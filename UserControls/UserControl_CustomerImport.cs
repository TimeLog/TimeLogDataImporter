using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TimeLog.DataImporter.Handlers;
using TimeLog.DataImporter.TimeLogApi;
using TimeLog.DataImporter.TimeLogApi.Model;

namespace TimeLog.DataImporter.UserControls
{
    public partial class UserControl_CustomerImport : UserControl
    {
        #region Variable declarations

        private DataTable _customerTable;
        private DataTable _fileContent;
        private Button _senderButton;
        private int _errorRowCount;
        private bool _isMappingFieldValueToIDCorrect;
        private bool _isFirstTimeInvalidMapping;

        private static readonly Dictionary<int, string> MandatoryFields = new Dictionary<int, string>
        {
            {0, "Customer Name"},
            {1, "Currency ISO"},
            {2, "Customer Status"},
            {3, "Country ISO"}
        };

        //all column header variables
        private readonly string _customerName = "Customer Name";
        private readonly string _currencyISO = "Currency ISO";
        private readonly string _customerStatus = "Customer Status";
        private readonly string _countryISO = "Country ISO";
        private readonly string _customerNo = "Customer No";
        private readonly string _nickname = "Nickname";
        private readonly string _primaryKAM = "Primary KAM";
        private readonly string _secondaryKAM = "Secondary KAM";
        private readonly string _customerSince = "Customer Since";
        private readonly string _industryName = "Industry Name";
        private readonly string _phoneNo = "Phone No";
        private readonly string _faxNo = "Fax No";
        private readonly string _email = "Email";
        private readonly string _website = "Website";
        private readonly string _address = "Address";
        private readonly string _address2 = "Address 2";
        private readonly string _address3 = "Address 3";
        private readonly string _zipCode = "Zip Code";
        private readonly string _city = "City";
        private readonly string _state = "State";
        private readonly string _useEanNo = "Use Ean No";
        private readonly string _eanNo = "Ean No";
        private readonly string _organizationNo = "Organization No";
        private readonly string _VATNo = "VAT No";
        private readonly string _useInvoicingAddress = "Use Invoicing Address";
        private readonly string _invoicingAddress = "Invoicing Address";
        private readonly string _invoicingAddress2 = "Invoicing Address 2";
        private readonly string _invoicingAddress3 = "Invoicing Address 3";
        private readonly string _invoicingAddressZipCode = "Invoicing Address Zip Code";
        private readonly string _invoicingAddressCity = "Invoicing Address City";
        private readonly string _invoicingAddressState = "Invoicing Address State";
        private readonly string _invoicingAddressCountryID = "Invoicing Address Country ID";
        private readonly string _defaultMileageDistance = "Default Mileage Distance";
        private readonly string _expenseIsBillable = "Expense Is Billable";
        private readonly string _mileageIsBillable = "Mileage Is Billable";
        private readonly string _defaultDistIsMaxBillable = "Default Dist Is Max Billable";
        private readonly string _contactID = "Contact ID";
        private readonly string _invoiceAddressToUse = "Invoice Address To Use";
        private readonly string _internalReferenceID = "Internal Reference ID";
        private readonly string _customerReferenceID = "Customer Reference ID";
        private readonly string _paymentTermID = "Payment Term ID";
        private readonly string _discountPercentage = "Discount Percentage";
        private readonly string _calculateVAT = "Calculate VAT";
        private readonly string _VATPercentage = "VAT Percentage";

        //default value lists
        private static readonly List<string> ExpenseIsBillableList = new List<string> {"true", "false"};
        private static readonly List<string> MileageIsBillableList = new List<string> {"true", "false"};
        private static readonly List<string> VATPercentageList = new List<string>();

        //default value lists from API 
        private static readonly List<KeyValuePair<int, string>> CurrencyISOList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> CountryISOList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> CustomerStatusList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> PrimaryKAMList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> SecondaryKAMList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> IndustryNameList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> PaymentTermIDList = new List<KeyValuePair<int, string>>(); // not yet added, to be implemented

        //expanding panels' current states, expand panels, expand buttons
        private BaseHandler.ExpandState[] _expandStates;
        private Panel[] _expandPanels;
        private Button[] _expandButtons;

        //set the number of pixels expanded per timer Tick
        private const int ExpansionPerTick = 7;

        #endregion

        public UserControl_CustomerImport()
        {
            InitializeComponent();
            CustomerHandler.Instance.InitializeDelimiterComboBox(comboBox_delimiter);
            InitializeExpandCollapsePanels();
            AddRowNumberToDataTable();
            InitializeAllDefaultValues();
            _customerTable = CustomerHandler.Instance.InitializeDomainDataTable(MandatoryFields);
            dataGridView_customer.DataSource = _customerTable;
            button_import.Enabled = false;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        #region Initialization methods

        private void InitializeExpandCollapsePanels()
        {
            _expandStates = new[]
            {
                BaseHandler.ExpandState.Expanded,
                BaseHandler.ExpandState.Expanded,
                BaseHandler.ExpandState.Expanded,
                BaseHandler.ExpandState.Expanded,
                BaseHandler.ExpandState.Expanded,
                BaseHandler.ExpandState.Expanded,
            };
            _expandPanels = new[]
            {
                panel_customerDetails,
                panel_contactDetails,
                panel_invoiceAddress,
                panel_financeCompanyInfo,
                panel_defaultInvoiceSettings,
                panel_incoiceExternalCosts
            };
            _expandButtons = new[]
            {
                button_customerDetails,
                button_contactDetails,
                button_invoiceAddress,
                button_financeCompanyInfo,
                button_defaultInvoiceSettings,
                button_invoiceExternalCosts
            };

            for (int i = 0; i < _expandButtons.Length; i++)
            {
                _expandButtons[i].Tag = i;
                _expandButtons[i].BackgroundImage = Properties.Resources.upload;
            }
        }

        private void InitializeAllDefaultValues()
        {
            GetAllCurrencyFromApi();
            GetAllCountryFromApi();
            GetAllCustomerStatusFromApi();
            GetAllPrimaryKAMFromApi();
            GetAllSecondaryKAMFromApi();
            GetAllIndustryFromApi();
        }

        #endregion

        #region Functionalities implementations

        private void button_select_customer_file_Click(object sender, EventArgs e)
        {
            CustomerHandler.Instance.FileColumnHeaders = new List<string>();
            _fileContent = new DataTable();
            _fileContent = CustomerHandler.Instance.GetFileContent(comboBox_delimiter.SelectedItem.ToString());

            if (_fileContent != null)
            {
                textBox_customerImportMessages.Text = string.Empty;
                ClearAndResetAllCheckBoxes();
                ClearAndResetAllComboBoxes();
                Invoke((MethodInvoker) (() => button_import.Enabled = false));

                if (dataGridView_customer.RowCount > 1)
                {
                    dataGridView_customer.DataSource = null;
                    _customerTable = CustomerHandler.Instance.InitializeDomainDataTable(MandatoryFields);
                    dataGridView_customer.DataSource = _customerTable;
                }

                foreach (DataRow _fileContentRow in _fileContent.Rows)
                {
                    _customerTable.Rows.Add();
                }

                AddFileColumnHeaderToComboBox(CustomerHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
            }
            else
            {
                button_clear_Click(sender, e);
            }
        }

        private void button_validate_Click(object sender, EventArgs e)
        {
            textBox_customerImportMessages.Text = string.Empty;
            _senderButton = (Button) sender;
            WorkerFetcher.RunWorkerAsync();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            WorkerFetcher.CancelAsync();
        }

        private void button_import_Click(object sender, EventArgs e)
        {
            textBox_customerImportMessages.Text = string.Empty;
            _senderButton = (Button) sender;
            WorkerFetcher.RunWorkerAsync();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            CustomerHandler.Instance.FileColumnHeaders = new List<string>();
            textBox_customerImportMessages.Text = string.Empty;
            ClearAndResetAllCheckBoxes();
            ClearAndResetAllComboBoxes();
            Invoke((MethodInvoker) (() => button_import.Enabled = false));

            dataGridView_customer.DataSource = null;
            _customerTable = CustomerHandler.Instance.InitializeDomainDataTable(MandatoryFields);
            dataGridView_customer.DataSource = _customerTable;
        }

        private void textBox_customerImportMessages_MouseClick(object sender, MouseEventArgs e)
        {
            CustomerHandler.Instance.HighlightDataTableRowByTextBoxClick(e, dataGridView_customer, textBox_customerImportMessages);
        }

        private void button_expand_Click(object sender, EventArgs e)
        {
            CustomerHandler.Instance.ExpandCollapseFieldByButtonClick(sender, _expandStates, _expandButtons, tmrExpand);
        }

        private void tmrExpand_Tick(object sender, EventArgs e)
        {
            CustomerHandler.Instance.ProcessExpandCollapseFieldForPanel(_expandPanels, _expandStates, ExpansionPerTick, tmrExpand);
        }

        private void WorkerFetcherDoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (dataGridView_customer != null && dataGridView_customer.RowCount > 1)
            {
                _errorRowCount = 0;

                //while validating, deactivate other buttons
                Invoke((MethodInvoker)(() => button_validate.Enabled = false));
                Invoke((MethodInvoker)(() => button_import.Enabled = false));
                Invoke((MethodInvoker)(() => button_clear.Enabled = false));
                Invoke((MethodInvoker)(() => button_customerSelectFile.Enabled = false));

                try
                {
                    foreach (DataGridViewRow _row in dataGridView_customer.Rows)
                    {
                        if (WorkerFetcher.CancellationPending)
                        {
                            break;
                        }

                        _isMappingFieldValueToIDCorrect = true;
                        _isFirstTimeInvalidMapping = true;

                        if (_row.DataBoundItem != null)
                        {
                            CustomerCreateModel _newCustomer = new CustomerCreateModel
                            {
                                Name = CustomerHandler.Instance.CheckAndGetString(dataGridView_customer, _customerName, _row),
                                CurrencyID = (int) MapFieldValueToID(_currencyISO, _row, false),
                                CustomerStatusID = (int) MapFieldValueToID(_customerStatus, _row, false),
                                CountryID = (int) MapFieldValueToID(_countryISO, _row, false),
                                CustomerNo = CustomerHandler.Instance.CheckAndGetString(dataGridView_customer, _customerNo, _row),
                                NickName = CustomerHandler.Instance.CheckAndGetString(dataGridView_customer, _nickname, _row),
                                PrimaryKAMID = MapFieldValueToID(_primaryKAM, _row, true),
                                SecondaryKAMID = MapFieldValueToID(_secondaryKAM, _row, true),
                                CustomerSince = CustomerHandler.Instance.CheckAndGetDate(dataGridView_customer, _customerSince, _row),
                                IndustryID = MapFieldValueToID(_industryName, _row, true),
                                Phone = CustomerHandler.Instance.CheckAndGetString(dataGridView_customer, _phoneNo, _row),
                                Fax = CustomerHandler.Instance.CheckAndGetString(dataGridView_customer, _faxNo, _row),
                                Email = CustomerHandler.Instance.CheckAndGetString(dataGridView_customer, _email, _row),
                                Website = CustomerHandler.Instance.CheckAndGetString(dataGridView_customer, _website, _row),
                                Address = CustomerHandler.Instance.CheckAndGetString(dataGridView_customer, _address, _row),
                                Address2 = CustomerHandler.Instance.CheckAndGetString(dataGridView_customer, _address2, _row),
                                Address3 = CustomerHandler.Instance.CheckAndGetString(dataGridView_customer, _address3, _row),
                                ZipCode = CustomerHandler.Instance.CheckAndGetString(dataGridView_customer, _zipCode, _row),
                                City = CustomerHandler.Instance.CheckAndGetString(dataGridView_customer, _city, _row),
                                State = CustomerHandler.Instance.CheckAndGetString(dataGridView_customer, _state, _row),
                                UseEanNo = CustomerHandler.Instance.CheckAndGetBoolean(dataGridView_customer, _useEanNo, _row),
                                EanNo = CustomerHandler.Instance.CheckAndGetString(dataGridView_customer, _eanNo, _row),
                                OrganizationNo = CustomerHandler.Instance.CheckAndGetString(dataGridView_customer, _organizationNo, _row),
                                VatNo = CustomerHandler.Instance.CheckAndGetString(dataGridView_customer, _VATNo, _row),
                                UseInvoicingAddress = CustomerHandler.Instance.CheckAndGetBoolean(dataGridView_customer, _useInvoicingAddress, _row),
                                InvoicingAddress = CustomerHandler.Instance.CheckAndGetString(dataGridView_customer, _invoicingAddress, _row),
                                InvoicingAddress2 = CustomerHandler.Instance.CheckAndGetString(dataGridView_customer, _invoicingAddress2, _row),
                                InvoicingAddress3 = CustomerHandler.Instance.CheckAndGetString(dataGridView_customer, _invoicingAddress3, _row),
                                InvoicingAddressZipCode = CustomerHandler.Instance.CheckAndGetString(dataGridView_customer, _invoicingAddressZipCode, _row),
                                InvoicingAddressCity = CustomerHandler.Instance.CheckAndGetString(dataGridView_customer, _invoicingAddressCity, _row),
                                InvoicingAddressState = CustomerHandler.Instance.CheckAndGetString(dataGridView_customer, _invoicingAddressState, _row),
                                InvoicingAddressCountryID = CustomerHandler.Instance.CheckAndGetInteger(dataGridView_customer, _invoicingAddressCountryID, _row),
                                DefaultMileageDistance = CustomerHandler.Instance.CheckAndGetInteger(dataGridView_customer, _defaultMileageDistance, _row),
                                ExpenseIsBillable = CustomerHandler.Instance.CheckAndGetBoolean(dataGridView_customer, _expenseIsBillable, _row),
                                MileageIsBillable = CustomerHandler.Instance.CheckAndGetBoolean(dataGridView_customer, _mileageIsBillable, _row),
                                DefaultDistIsMaxBillable = CustomerHandler.Instance.CheckAndGetBoolean(dataGridView_customer, _defaultDistIsMaxBillable, _row),
                                ContactID = CustomerHandler.Instance.CheckAndGetInteger(dataGridView_customer, _contactID, _row),
                                InvoiceAddressToUse = CustomerHandler.Instance.CheckAndGetInteger(dataGridView_customer, _invoiceAddressToUse, _row),
                                InternalReferenceID = CustomerHandler.Instance.CheckAndGetInteger(dataGridView_customer, _internalReferenceID, _row),
                                CustomerReferenceID = CustomerHandler.Instance.CheckAndGetInteger(dataGridView_customer, _customerReferenceID, _row),
                                PaymentTermID = CustomerHandler.Instance.CheckAndGetInteger(dataGridView_customer, _paymentTermID, _row),
                                DiscountPercentage = CustomerHandler.Instance.CheckAndGetDouble(dataGridView_customer, _discountPercentage, _row),
                                CalculateVat = CustomerHandler.Instance.CheckAndGetBoolean(dataGridView_customer, _calculateVAT, _row),
                                VatPercentage = CustomerHandler.Instance.CheckAndGetDouble(dataGridView_customer, _VATPercentage, _row)
                            };

                            if (_isMappingFieldValueToIDCorrect)
                            {
                                if (_senderButton.Name == button_validate.Name)
                                {
                                    var _defaultApiResponse = CustomerHandler.Instance.ValidateCustomer(_newCustomer,
                                        AuthenticationHandler.Instance.Token, out var _businessRulesApiResponse);

                                    _errorRowCount = ApiHelper.Instance.HandleApiResponse(_defaultApiResponse, _row, _businessRulesApiResponse, 
                                        textBox_customerImportMessages, _errorRowCount, WorkerFetcher, this);
                                }
                                else
                                {
                                    var _defaultApiResponse = CustomerHandler.Instance.ImportCustomer(_newCustomer,
                                        AuthenticationHandler.Instance.Token, out var _businessRulesApiResponse);

                                    _errorRowCount = ApiHelper.Instance.HandleApiResponse(_defaultApiResponse, _row, _businessRulesApiResponse, 
                                        textBox_customerImportMessages, _errorRowCount, WorkerFetcher, this);
                                }
                            }
                        }
                    }

                    CustomerHandler.Instance.DisplayErrorRowCountAndSuccessMessage(_errorRowCount, button_import, button_validate, _senderButton, textBox_customerImportMessages, this);
                }
                catch (FormatException _ex)
                {
                    MessageBox.Show(_ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception _ex)
                {
                    MessageBox.Show(_ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //reactivate buttons after work is done
                Invoke((MethodInvoker)(() => button_validate.Enabled = true));
                Invoke((MethodInvoker)(() => button_clear.Enabled = true));
                Invoke((MethodInvoker)(() => button_customerSelectFile.Enabled = true));
            }
        }

        #endregion

        #region Helper methods

        private void AddFileColumnHeaderToComboBox(object[] fileColumnHeaderArray)
        {
            comboBox_customerName.Items.AddRange(fileColumnHeaderArray);
            comboBox_currencyISO.Items.AddRange(fileColumnHeaderArray);
            comboBox_customerStatus.Items.AddRange(fileColumnHeaderArray);
            comboBox_countryISO.Items.AddRange(fileColumnHeaderArray);
            comboBox_customerNo.Items.AddRange(fileColumnHeaderArray);
            comboBox_nickName.Items.AddRange(fileColumnHeaderArray);
            comboBox_primaryKAM.Items.AddRange(fileColumnHeaderArray);
            comboBox_secondaryKAM.Items.AddRange(fileColumnHeaderArray);
            comboBox_customerSince.Items.AddRange(fileColumnHeaderArray);
            comboBox_industryName.Items.AddRange(fileColumnHeaderArray);
            comboBox_phoneNo.Items.AddRange(fileColumnHeaderArray);
            comboBox_faxNo.Items.AddRange(fileColumnHeaderArray);
            comboBox_email.Items.AddRange(fileColumnHeaderArray);
            comboBox_website.Items.AddRange(fileColumnHeaderArray);
            comboBox_address.Items.AddRange(fileColumnHeaderArray);
            comboBox_address2.Items.AddRange(fileColumnHeaderArray);
            comboBox_address3.Items.AddRange(fileColumnHeaderArray);
            comboBox_zipCode.Items.AddRange(fileColumnHeaderArray);
            comboBox_city.Items.AddRange(fileColumnHeaderArray);
            comboBox_state.Items.AddRange(fileColumnHeaderArray);
            comboBox_useEanNo.Items.AddRange(fileColumnHeaderArray);
            comboBox_eanNo.Items.AddRange(fileColumnHeaderArray);
            comboBox_organizationNo.Items.AddRange(fileColumnHeaderArray);
            comboBox_VATNo.Items.AddRange(fileColumnHeaderArray);
            comboBox_useInvoicingAddress.Items.AddRange(fileColumnHeaderArray);
            comboBox_invoicingAddress.Items.AddRange(fileColumnHeaderArray);
            comboBox_invoicingAddress2.Items.AddRange(fileColumnHeaderArray);
            comboBox_invoicingAddress3.Items.AddRange(fileColumnHeaderArray);
            comboBox_invoicingAddressZipCode.Items.AddRange(fileColumnHeaderArray);
            comboBox_invoicingAddressCity.Items.AddRange(fileColumnHeaderArray);
            comboBox_invoicingAddressState.Items.AddRange(fileColumnHeaderArray);
            comboBox_invoicingAddressCountryID.Items.AddRange(fileColumnHeaderArray);
            comboBox_defaultMileageDistance.Items.AddRange(fileColumnHeaderArray);
            comboBox_expenseIsBillable.Items.AddRange(fileColumnHeaderArray);
            comboBox_mileageIsBillable.Items.AddRange(fileColumnHeaderArray);
            comboBox_defaultDistIsMaxBillable.Items.AddRange(fileColumnHeaderArray);
            comboBox_contactID.Items.AddRange(fileColumnHeaderArray);
            comboBox_invoiceAddressToUse.Items.AddRange(fileColumnHeaderArray);
            comboBox_internalReferenceID.Items.AddRange(fileColumnHeaderArray);
            comboBox_customerReferenceID.Items.AddRange(fileColumnHeaderArray);
            comboBox_paymentTermID.Items.AddRange(fileColumnHeaderArray);
            comboBox_discountPercentage.Items.AddRange(fileColumnHeaderArray);
            comboBox_calculateVAT.Items.AddRange(fileColumnHeaderArray);
            comboBox_VATPercentage.Items.AddRange(fileColumnHeaderArray);
        }

        private void MapFileContentToTable(int tableColumnIndex, int fileColumnIndex)
        {
            for (int i = 0; i < _fileContent.Rows.Count; i++)
            {
                Invoke((MethodInvoker) (() => _customerTable.Rows[i][tableColumnIndex] = _fileContent.Rows[i][fileColumnIndex]));
            }

            dataGridView_customer.Rows[0].Cells[tableColumnIndex].Selected = true;
            dataGridView_customer.FirstDisplayedScrollingColumnIndex = tableColumnIndex;
            dataGridView_customer.Focus();
        }

        private void MapDefaultValueToTable(int tableColumnIndex, string defaultValue)
        {
            for (int i = 0; i < _customerTable.Rows.Count; i++)
            {
                Invoke((MethodInvoker) (() => _customerTable.Rows[i][tableColumnIndex] = defaultValue));
            }

            dataGridView_customer.Rows[0].Cells[tableColumnIndex].Selected = true;
            dataGridView_customer.FirstDisplayedScrollingColumnIndex = tableColumnIndex;
            dataGridView_customer.Focus();
        }

        private int? MapFieldValueToID(string columnName, DataGridViewRow row, bool isNullableField)
        {
            if (dataGridView_customer.Columns[columnName] != null)
            {
                var _fieldValue = CustomerHandler.Instance.CheckAndGetString(dataGridView_customer, columnName, row);
                int _result = -1;

                if (columnName == _currencyISO)
                {
                    _result = CustomerHandler.Instance.GetIDFromFieldValue(CurrencyISOList, _fieldValue);
                }
                else if (columnName == _countryISO)
                {
                    _result = CustomerHandler.Instance.GetIDFromFieldValue(CountryISOList, _fieldValue);
                }
                else if (columnName == _customerStatus)
                {
                    _result = CustomerHandler.Instance.GetIDFromFieldValue(CustomerStatusList, _fieldValue);
                }
                else if (columnName == _primaryKAM)
                {
                    _result = CustomerHandler.Instance.GetIDFromFieldValue(PrimaryKAMList, _fieldValue);
                }
                else if (columnName == _secondaryKAM)
                {
                    _result = CustomerHandler.Instance.GetIDFromFieldValue(SecondaryKAMList, _fieldValue);
                }
                else if (columnName == _industryName)
                {
                    _result = CustomerHandler.Instance.GetIDFromFieldValue(IndustryNameList, _fieldValue);
                }

                if (_result != -1)
                {
                    return _result;
                }

                //if can't match, display error message
                _errorRowCount = CustomerHandler.Instance.HandleInvalidFieldValueToIDMapping(columnName, row, _fieldValue, textBox_customerImportMessages,
                    WorkerFetcher, this, _isFirstTimeInvalidMapping, _errorRowCount);
                _isMappingFieldValueToIDCorrect = false;
                _isFirstTimeInvalidMapping = false;
            }

            if (isNullableField)
            {
                return null;
            }

            return 0;
        }

        private void CheckAndAddColumn(string columnName)
        {
            if (!_customerTable.Columns.Contains(columnName))
            {
                _customerTable.Columns.Add(columnName);
            }
        }

        private void CheckCellsForNullOrEmpty(int columnIndex)
        {
            foreach (DataGridViewRow _row in dataGridView_customer.Rows)
            {
                if (_row.Cells[columnIndex].Value == null ||
                    string.IsNullOrEmpty(_row.Cells[columnIndex].Value.ToString()))
                {
                    if (_row.DataBoundItem != null)
                    {
                        _row.Cells[columnIndex].Style.BackColor = Color.Red;
                    }
                }
            }
        }

        private void ClearColumn(int columnIndex)
        {
            if (dataGridView_customer != null && dataGridView_customer.Columns.Count - 1 >= columnIndex)
            {
                var _tmpCol = dataGridView_customer.Columns[columnIndex];
                dataGridView_customer.Columns.Remove(dataGridView_customer.Columns[columnIndex]);
                dataGridView_customer.Columns.Insert(columnIndex, _tmpCol);
            }
        }

        private void ClearRow(int tableColumnIndex)
        {
            for (int i = 0; i < _customerTable.Rows.Count; i++)
            {
                Invoke((MethodInvoker) (() => _customerTable.Rows[i][tableColumnIndex] = ""));
            }
        }

        private void ClearAndResetAllComboBoxes()
        {
            comboBox_customerName.ResetText();
            comboBox_customerName.Items.Clear();
            comboBox_currencyISO.ResetText();
            comboBox_currencyISO.Items.Clear();
            comboBox_customerStatus.ResetText();
            comboBox_customerStatus.Items.Clear();
            comboBox_countryISO.ResetText();
            comboBox_countryISO.Items.Clear();
            comboBox_customerNo.ResetText();
            comboBox_customerNo.Items.Clear();
            comboBox_nickName.ResetText();
            comboBox_nickName.Items.Clear();
            comboBox_primaryKAM.ResetText();
            comboBox_primaryKAM.Items.Clear();
            comboBox_secondaryKAM.ResetText();
            comboBox_secondaryKAM.Items.Clear();
            comboBox_customerSince.ResetText();
            comboBox_customerSince.Items.Clear();
            comboBox_industryName.ResetText();
            comboBox_industryName.Items.Clear();
            comboBox_phoneNo.ResetText();
            comboBox_phoneNo.Items.Clear();
            comboBox_faxNo.ResetText();
            comboBox_faxNo.Items.Clear();
            comboBox_email.ResetText();
            comboBox_email.Items.Clear();
            comboBox_website.ResetText();
            comboBox_website.Items.Clear();
            comboBox_address.ResetText();
            comboBox_address.Items.Clear();
            comboBox_address2.ResetText();
            comboBox_address2.Items.Clear();
            comboBox_address3.ResetText();
            comboBox_address3.Items.Clear();
            comboBox_zipCode.ResetText();
            comboBox_zipCode.Items.Clear();
            comboBox_city.ResetText();
            comboBox_city.Items.Clear();
            comboBox_state.ResetText();
            comboBox_state.Items.Clear();
            comboBox_useEanNo.ResetText();
            comboBox_useEanNo.Items.Clear();
            comboBox_eanNo.ResetText();
            comboBox_eanNo.Items.Clear();
            comboBox_organizationNo.ResetText();
            comboBox_organizationNo.Items.Clear();
            comboBox_VATNo.ResetText();
            comboBox_VATNo.Items.Clear();
            comboBox_useInvoicingAddress.ResetText();
            comboBox_useInvoicingAddress.Items.Clear();
            comboBox_invoicingAddress.ResetText();
            comboBox_invoicingAddress.Items.Clear();
            comboBox_invoicingAddress2.ResetText();
            comboBox_invoicingAddress2.Items.Clear();
            comboBox_invoicingAddress3.ResetText();
            comboBox_invoicingAddress3.Items.Clear();
            comboBox_invoicingAddressZipCode.ResetText();
            comboBox_invoicingAddressZipCode.Items.Clear();
            comboBox_invoicingAddressCity.ResetText();
            comboBox_invoicingAddressCity.Items.Clear();
            comboBox_invoicingAddressState.ResetText();
            comboBox_invoicingAddressState.Items.Clear();
            comboBox_invoicingAddressCountryID.ResetText();
            comboBox_invoicingAddressCountryID.Items.Clear();
            comboBox_defaultMileageDistance.ResetText();
            comboBox_defaultMileageDistance.Items.Clear();
            comboBox_expenseIsBillable.ResetText();
            comboBox_expenseIsBillable.Items.Clear();
            comboBox_mileageIsBillable.ResetText();
            comboBox_mileageIsBillable.Items.Clear();
            comboBox_defaultDistIsMaxBillable.ResetText();
            comboBox_defaultDistIsMaxBillable.Items.Clear();
            comboBox_contactID.ResetText();
            comboBox_contactID.Items.Clear();
            comboBox_invoiceAddressToUse.ResetText();
            comboBox_invoiceAddressToUse.Items.Clear();
            comboBox_internalReferenceID.ResetText();
            comboBox_internalReferenceID.Items.Clear();
            comboBox_customerReferenceID.ResetText();
            comboBox_customerReferenceID.Items.Clear();
            comboBox_paymentTermID.ResetText();
            comboBox_paymentTermID.Items.Clear();
            comboBox_invoicingAddress.ResetText();
            comboBox_invoicingAddress.Items.Clear();
            comboBox_discountPercentage.ResetText();
            comboBox_discountPercentage.Items.Clear();
            comboBox_calculateVAT.ResetText();
            comboBox_calculateVAT.Items.Clear();
            comboBox_VATPercentage.ResetText();
            comboBox_VATPercentage.Items.Clear();
        }

        private void ClearAndResetAllCheckBoxes()
        {
            checkBox_defaultCurrencyISO.Checked = false;
            checkBox_defaultCustomerStatus.Checked = false;
            checkBox_defaultCountryISO.Checked = false;
            checkBox_defaultPrimaryKAM.Checked = false;
            checkBox_defaultSecondaryKAM.Checked = false;
            checkBox_defaultIndustryName.Checked = false;
            checkBox_defaultExpenseIsBillable.Checked = false;
            checkBox_defaultMileageIsBillable.Checked = false;
            checkBox_defaultPaymentTermID.Checked = false;
            checkBox_defaultVATPercentage.Checked = false;
        }

        #endregion

        #region Get default values from API

        private void GetAllCurrencyFromApi()
        {
            var _apiResponse = CustomerHandler.Instance.GetAllCurrency(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _currency in _apiResponse)
                {
                    CurrencyISOList.Add(new KeyValuePair<int, string>(_currency.CurrencyID, _currency.CurrencyABB));
                }
            }
        }

        private void GetAllCountryFromApi()
        {
            var _apiResponse = CustomerHandler.Instance.GetAllCountry(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _country in _apiResponse)
                {
                    CountryISOList.Add(new KeyValuePair<int, string>(_country.CountryID, _country.ISO));
                }
            }
        }

        private void GetAllCustomerStatusFromApi()
        {
            var _apiResponse = CustomerHandler.Instance.GetAllCustomerStatus(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _customerStatus in _apiResponse)
                {
                    CustomerStatusList.Add(new KeyValuePair<int, string>(_customerStatus.CustomerStatusID, _customerStatus.Name));
                }
            }
        }

        private void GetAllPrimaryKAMFromApi()
        {
            var _apiResponse = CustomerHandler.Instance.GetAllEmployee(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _primaryKAM in _apiResponse)
                {
                    PrimaryKAMList.Add(new KeyValuePair<int, string>(_primaryKAM.UserID, _primaryKAM.Initials));
                }
            }
        }

        private void GetAllSecondaryKAMFromApi()
        {
            var _apiResponse = CustomerHandler.Instance.GetAllEmployee(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _secondaryKAM in _apiResponse)
                {
                    SecondaryKAMList.Add(new KeyValuePair<int, string>(_secondaryKAM.UserID, _secondaryKAM.Initials));
                }
            }
        }

        private void GetAllIndustryFromApi()
        {
            var _apiResponse = CustomerHandler.Instance.GetAllIndustry(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _industry in _apiResponse)
                {
                    IndustryNameList.Add(new KeyValuePair<int, string>(_industry.IndustryID, _industry.IndustryName));
                }
            }
        }

        private void GetAllPaymentTermFromApi()
        {
            var _apiResponse = CustomerHandler.Instance.GetAllPaymentTerm(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _paymentTerm in _apiResponse)
                {
                    PaymentTermIDList.Add(new KeyValuePair<int, string>(_paymentTerm.PaymentMethodID,
                        _paymentTerm.Name));
                }
            }
        }

        #endregion

        #region Add default key value pair list to Combobox

        private void AddKeyValuePairListToCurrencyIDComboBox()
        {
            comboBox_currencyISO.DisplayMember = "Value";
            comboBox_currencyISO.ValueMember = "Key";

            if (CurrencyISOList != null)
            {
                foreach (var _currency in CurrencyISOList)
                {
                    comboBox_currencyISO.Items.Add(new {_currency.Key, _currency.Value});
                }
            }
        }

        private void AddKeyValuePairListToCountryIDComboBox()
        {
            comboBox_countryISO.DisplayMember = "Value";
            comboBox_countryISO.ValueMember = "Key";

            if (CountryISOList != null)
            {
                foreach (var _country in CountryISOList)
                {
                    comboBox_countryISO.Items.Add(new {_country.Key, _country.Value});
                }
            }
        }

        private void AddKeyValuePairListToCustomerStatusIDComboBox()
        {
            comboBox_customerStatus.DisplayMember = "Value";
            comboBox_customerStatus.ValueMember = "Key";

            if (CustomerStatusList != null)
            {
                foreach (var _customerStatus in CustomerStatusList)
                {
                    comboBox_customerStatus.Items.Add(new {_customerStatus.Key, _customerStatus.Value});
                }
            }
        }

        private void AddKeyValuePairListToPrimaryKAMIDComboBox()
        {
            comboBox_primaryKAM.DisplayMember = "Value";
            comboBox_primaryKAM.ValueMember = "Key";

            if (PrimaryKAMList != null)
            {
                foreach (var _primaryKAM in PrimaryKAMList)
                {
                    comboBox_primaryKAM.Items.Add(new {_primaryKAM.Key, _primaryKAM.Value});
                }
            }
        }

        private void AddKeyValuePairListToSecondaryKAMIDComboBox()
        {
            comboBox_secondaryKAM.DisplayMember = "Value";
            comboBox_secondaryKAM.ValueMember = "Key";

            if (SecondaryKAMList != null)
            {
                foreach (var _secondaryKAM in SecondaryKAMList)
                {
                    comboBox_secondaryKAM.Items.Add(new {_secondaryKAM.Key, _secondaryKAM.Value});
                }
            }
        }

        private void AddKeyValuePairListToIndustryIDComboBox()
        {
            comboBox_industryName.DisplayMember = "Value";
            comboBox_industryName.ValueMember = "Key";

            if (IndustryNameList != null)
            {
                foreach (var _industry in IndustryNameList)
                {
                    comboBox_industryName.Items.Add(new {_industry.Key, _industry.Value});
                }
            }
        }

        private void AddKeyValuePairListToPaymentTermIDComboBox()
        {
            comboBox_paymentTermID.DisplayMember = "Value";
            comboBox_paymentTermID.ValueMember = "Key";

            if (PaymentTermIDList != null)
            {
                foreach (var _paymentTerm in PaymentTermIDList)
                {
                    comboBox_paymentTermID.Items.Add(new {_paymentTerm.Key, _paymentTerm.Value});
                }
            }
        }

        #endregion

        #region Combobox implementations

        private void comboBox_customerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, 
                comboBox_customerName, _customerName);

            //var _columnIndex = _fileContent.Columns.IndexOf(comboBox_customerName.SelectedItem.ToString());

            //var _tableColumnIndex = _customerTable.Columns.IndexOf(_customerName);

            //ClearColumn(_tableColumnIndex);

            //CustomerHandler.Instance.MapFileContentToTable(_fileContent, dataGridView_customer, _customerTable,_tableColumnIndex, _columnIndex);

            //CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_currencyISO_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, 
                comboBox_currencyISO, _currencyISO, checkBox_defaultCurrencyISO);

            //var _tableColumnIndex = _customerTable.Columns.IndexOf(_currencyISO);

            //ClearColumn(_tableColumnIndex);

            //if (!checkBox_defaultCurrencyISO.Checked)
            //{
            //    var _columnIndex = _fileContent.Columns.IndexOf(comboBox_currencyISO.SelectedItem.ToString());

            //    MapFileContentToTable(_tableColumnIndex, _columnIndex);
            //}
            //else
            //{
            //    var _defaultValue = (comboBox_currencyISO.SelectedItem as dynamic).Value.ToString();

            //    MapDefaultValueToTable(_tableColumnIndex, _defaultValue);
            //}

            //CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_customerStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, 
                comboBox_customerStatus, _customerStatus, checkBox_defaultCustomerStatus);

            //var _tableColumnIndex = _customerTable.Columns.IndexOf(_customerStatus);

            //ClearColumn(_tableColumnIndex);

            //if (!checkBox_defaultCustomerStatus.Checked)
            //{
            //    var _columnIndex = _fileContent.Columns.IndexOf(comboBox_customerStatus.SelectedItem.ToString());

            //    MapFileContentToTable(_tableColumnIndex, _columnIndex);
            //}
            //else
            //{
            //    var _defaultValue = (comboBox_customerStatus.SelectedItem as dynamic).Value.ToString();

            //    MapDefaultValueToTable(_tableColumnIndex, _defaultValue);
            //}

            //CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_countryISO_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _tableColumnIndex = _customerTable.Columns.IndexOf(_countryISO);

            ClearColumn(_tableColumnIndex);

            if (!checkBox_defaultCountryISO.Checked)
            {
                var _columnIndex = _fileContent.Columns.IndexOf(comboBox_countryISO.SelectedItem.ToString());

                MapFileContentToTable(_tableColumnIndex, _columnIndex);
            }
            else
            {
                var _defaultValue = (comboBox_countryISO.SelectedItem as dynamic).Value.ToString();

                MapDefaultValueToTable(_tableColumnIndex, _defaultValue);
            }

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_customerNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, 
                comboBox_customerNo, _customerNo);

            //var _columnIndex = _fileContent.Columns.IndexOf(comboBox_customerNo.SelectedItem.ToString());

            //CheckAndAddColumn(_customerNo);

            //var _tableColumnIndex = _customerTable.Columns.IndexOf(_customerNo);

            //ClearColumn(_tableColumnIndex);

            //CustomerHandler.Instance.MapFileContentToTable(_fileContent, dataGridView_customer, _customerTable, _tableColumnIndex, _columnIndex);
            ////MapFileContentToTable(_tableColumnIndex, _columnIndex);

            //CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_nickName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_nickName.SelectedItem.ToString());

            CheckAndAddColumn(_nickname);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_nickname);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_primaryKAM_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, 
                comboBox_primaryKAM, _primaryKAM, checkBox_defaultPrimaryKAM);

            //CheckAndAddColumn(_primaryKAM);

            //var _tableColumnIndex = _customerTable.Columns.IndexOf(_primaryKAM);

            //ClearColumn(_tableColumnIndex);

            //if (!checkBox_defaultPrimaryKAM.Checked)
            //{
            //    var _columnIndex = _fileContent.Columns.IndexOf(comboBox_primaryKAM.SelectedItem.ToString());

            //    MapFileContentToTable(_tableColumnIndex, _columnIndex);
            //}
            //else
            //{
            //    var _defaultValue = (comboBox_primaryKAM.SelectedItem as dynamic).Value.ToString();

            //    MapDefaultValueToTable(_tableColumnIndex, _defaultValue);
            //}

            //CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_secondaryKAM_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAndAddColumn(_secondaryKAM);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_secondaryKAM);

            ClearColumn(_tableColumnIndex);

            if (!checkBox_defaultSecondaryKAM.Checked)
            {
                var _columnIndex = _fileContent.Columns.IndexOf(comboBox_secondaryKAM.SelectedItem.ToString());

                MapFileContentToTable(_tableColumnIndex, _columnIndex);
            }
            else
            {
                var _defaultValue = (comboBox_secondaryKAM.SelectedItem as dynamic).Value.ToString();

                MapDefaultValueToTable(_tableColumnIndex, _defaultValue);
            }

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_customerSince_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_customerSince.SelectedItem.ToString());

            CheckAndAddColumn(_customerSince);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_customerSince);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_industryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAndAddColumn(_industryName);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_industryName);

            ClearColumn(_tableColumnIndex);

            if (!checkBox_defaultIndustryName.Checked)
            {
                var _columnIndex = _fileContent.Columns.IndexOf(comboBox_industryName.SelectedItem.ToString());

                MapFileContentToTable(_tableColumnIndex, _columnIndex);
            }
            else
            {
                var _defaultValue = (comboBox_industryName.SelectedItem as dynamic).Value.ToString();

                MapDefaultValueToTable(_tableColumnIndex, _defaultValue);
            }

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_phoneNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_phoneNo.SelectedItem.ToString());

            CheckAndAddColumn(_phoneNo);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_phoneNo);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_faxNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_faxNo.SelectedItem.ToString());

            CheckAndAddColumn(_faxNo);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_faxNo);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_email_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_email.SelectedItem.ToString());

            CheckAndAddColumn(_email);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_email);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_website_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_website.SelectedItem.ToString());

            CheckAndAddColumn(_website);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_website);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_address_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_address.SelectedItem.ToString());

            CheckAndAddColumn(_address);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_address);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_address2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_address2.SelectedItem.ToString());

            CheckAndAddColumn(_address2);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_address2);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_address3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_address3.SelectedItem.ToString());

            CheckAndAddColumn(_address3);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_address3);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_zipCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_zipCode.SelectedItem.ToString());

            CheckAndAddColumn(_zipCode);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_zipCode);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_city.SelectedItem.ToString());

            CheckAndAddColumn(_city);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_city);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_state_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_state.SelectedItem.ToString());

            CheckAndAddColumn(_state);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_state);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_useEanNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_useEanNo.SelectedItem.ToString());

            CheckAndAddColumn(_useEanNo);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_useEanNo);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_eanNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_eanNo.SelectedItem.ToString());

            CheckAndAddColumn(_eanNo);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_eanNo);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_organizationNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_organizationNo.SelectedItem.ToString());

            CheckAndAddColumn(_organizationNo);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_organizationNo);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_VATNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_VATNo.SelectedItem.ToString());

            CheckAndAddColumn(_VATNo);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_VATNo);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_useInvoicingAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_useInvoicingAddress.SelectedItem.ToString());

            CheckAndAddColumn(_useInvoicingAddress);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_useInvoicingAddress);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_invoicingAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_invoicingAddress.SelectedItem.ToString());

            CheckAndAddColumn(_invoicingAddress);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_invoicingAddress);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_invoicingAddress2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_invoicingAddress2.SelectedItem.ToString());

            CheckAndAddColumn(_invoicingAddress2);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_invoicingAddress2);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_invoicingAddress3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_invoicingAddress3.SelectedItem.ToString());

            CheckAndAddColumn(_invoicingAddress3);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_invoicingAddress3);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_invoicingAddressZipCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_invoicingAddressZipCode.SelectedItem.ToString());

            CheckAndAddColumn(_invoicingAddressZipCode);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_invoicingAddressZipCode);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_invoicingAddressCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_invoicingAddressCity.SelectedItem.ToString());

            CheckAndAddColumn(_invoicingAddressCity);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_invoicingAddressCity);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_invoicingAddressState_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_invoicingAddressState.SelectedItem.ToString());

            CheckAndAddColumn(_invoicingAddressState);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_invoicingAddressState);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_invoicingAddressCountryID_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_invoicingAddressCountryID.SelectedItem.ToString());

            CheckAndAddColumn(_invoicingAddressCountryID);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_invoicingAddressCountryID);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_defaultMileageDistance_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_defaultMileageDistance.SelectedItem.ToString());

            CheckAndAddColumn(_defaultMileageDistance);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_defaultMileageDistance);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_expenseIsBillable_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAndAddColumn(_expenseIsBillable);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_expenseIsBillable);

            ClearColumn(_tableColumnIndex);

            if (!checkBox_defaultExpenseIsBillable.Checked)
            {
                var _columnIndex = _fileContent.Columns.IndexOf(comboBox_expenseIsBillable.SelectedItem.ToString());

                MapFileContentToTable(_tableColumnIndex, _columnIndex);
            }
            else
            {
                var _defaultValue = comboBox_expenseIsBillable.SelectedItem.ToString();

                MapDefaultValueToTable(_tableColumnIndex, _defaultValue);
            }

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_mileageIsBillable_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAndAddColumn(_mileageIsBillable);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_mileageIsBillable);

            ClearColumn(_tableColumnIndex);

            if (!checkBox_defaultMileageIsBillable.Checked)
            {
                var _columnIndex = _fileContent.Columns.IndexOf(comboBox_mileageIsBillable.SelectedItem.ToString());

                MapFileContentToTable(_tableColumnIndex, _columnIndex);
            }
            else
            {
                var _defaultValue = comboBox_mileageIsBillable.SelectedItem.ToString();

                MapDefaultValueToTable(_tableColumnIndex, _defaultValue);
            }

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_defaultDistIsMaxBillable_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_defaultDistIsMaxBillable.SelectedItem.ToString());

            CheckAndAddColumn(_defaultDistIsMaxBillable);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_defaultDistIsMaxBillable);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_contactID_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_contactID.SelectedItem.ToString());

            CheckAndAddColumn(_contactID);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_contactID);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_invoiceAddressToUse_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_invoiceAddressToUse.SelectedItem.ToString());

            CheckAndAddColumn(_invoiceAddressToUse);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_invoiceAddressToUse);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_internalReferenceID_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_internalReferenceID.SelectedItem.ToString());

            CheckAndAddColumn(_internalReferenceID);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_internalReferenceID);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_customerReferenceID_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_customerReferenceID.SelectedItem.ToString());

            CheckAndAddColumn(_customerReferenceID);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_customerReferenceID);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_paymentTermID_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAndAddColumn(_paymentTermID);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_paymentTermID);

            ClearColumn(_tableColumnIndex);

            if (!checkBox_defaultPaymentTermID.Checked)
            {
                var _columnIndex = _fileContent.Columns.IndexOf(comboBox_paymentTermID.SelectedItem.ToString());

                MapFileContentToTable(_tableColumnIndex, _columnIndex);
            }
            else
            {
                var _defaultValue = (comboBox_paymentTermID.SelectedItem as dynamic).Value.ToString();

                MapDefaultValueToTable(_tableColumnIndex, _defaultValue);
            }

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_discountPercentage_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_discountPercentage.SelectedItem.ToString());

            CheckAndAddColumn(_discountPercentage);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_discountPercentage);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_calculateVAT_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_calculateVAT.SelectedItem.ToString());

            CheckAndAddColumn(_calculateVAT);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_calculateVAT);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_VATPercentage_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAndAddColumn(_VATPercentage);

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_VATPercentage);

            ClearColumn(_tableColumnIndex);

            if (!checkBox_defaultVATPercentage.Checked)
            {
                var _columnIndex = _fileContent.Columns.IndexOf(comboBox_VATPercentage.SelectedItem.ToString());

                MapFileContentToTable(_tableColumnIndex, _columnIndex);
            }
            else
            {
                var _defaultValue = comboBox_VATPercentage.SelectedItem.ToString();

                MapDefaultValueToTable(_tableColumnIndex, _defaultValue);
            }

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        #endregion

        #region Checkbox implementations

        private void checkBox_defaultCurrencyISO_CheckedChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapValuesToComboBoxByCheckboxStatus(dataGridView_customer, _customerTable, comboBox_currencyISO, 
                _currencyISO, checkBox_defaultCurrencyISO, CurrencyISOList, CustomerHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());

            //comboBox_currencyISO.ResetText();
            //comboBox_currencyISO.Items.Clear();

            //if (checkBox_defaultCurrencyISO.Checked)
            //{
            //    if (_currencyISOList == null)
            //    {
            //        GetAllCurrencyFromApi();
            //    }

            //    AddKeyValuePairListToCurrencyIDComboBox();
            //}
            //else
            //{
            //    comboBox_currencyISO.Items.AddRange(CustomerHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
            //}

            //var _tableColumnIndex = _customerTable.Columns.IndexOf(_currencyISO);

            //if (_tableColumnIndex != -1)
            //{
            //    ClearColumn(_tableColumnIndex);

            //    ClearRow(_tableColumnIndex);

            //    CheckCellsForNullOrEmpty(_tableColumnIndex);
            //}
        }

        private void checkBox_defaultCustomerStatus_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_customerStatus.ResetText();
            comboBox_customerStatus.Items.Clear();

            if (checkBox_defaultCustomerStatus.Checked)
            {
                if (CustomerStatusList == null)
                {
                    GetAllCustomerStatusFromApi();
                }

                AddKeyValuePairListToCustomerStatusIDComboBox();
            }
            else
            {
                comboBox_customerStatus.Items.AddRange(CustomerHandler.Instance.FileColumnHeaders.Cast<object>()
                    .ToArray());
            }

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_customerStatus);

            if (_tableColumnIndex != -1)
            {
                ClearColumn(_tableColumnIndex);

                ClearRow(_tableColumnIndex);

                CheckCellsForNullOrEmpty(_tableColumnIndex);
            }
        }

        private void checkBox_defaultCountryISO_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_countryISO.ResetText();
            comboBox_countryISO.Items.Clear();

            if (checkBox_defaultCountryISO.Checked)
            {
                if (CountryISOList == null)
                {
                    GetAllCountryFromApi();
                }

                AddKeyValuePairListToCountryIDComboBox();
            }
            else
            {
                comboBox_countryISO.Items.AddRange(CustomerHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
            }

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_countryISO);

            if (_tableColumnIndex != -1)
            {
                ClearColumn(_tableColumnIndex);

                ClearRow(_tableColumnIndex);

                CheckCellsForNullOrEmpty(_tableColumnIndex);
            }
        }

        private void checkBox_defaultPrimaryKAM_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_primaryKAM.ResetText();
            comboBox_primaryKAM.Items.Clear();

            if (checkBox_defaultPrimaryKAM.Checked)
            {
                if (PrimaryKAMList == null)
                {
                    GetAllPrimaryKAMFromApi();
                }

                AddKeyValuePairListToPrimaryKAMIDComboBox();
            }
            else
            {
                comboBox_primaryKAM.Items.AddRange(
                    CustomerHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
            }

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_primaryKAM);

            if (_tableColumnIndex != -1)
            {
                ClearColumn(_tableColumnIndex);

                ClearRow(_tableColumnIndex);

                CheckCellsForNullOrEmpty(_tableColumnIndex);
            }
        }

        private void checkBox_defaultSecondaryKAM_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_secondaryKAM.ResetText();
            comboBox_secondaryKAM.Items.Clear();

            if (checkBox_defaultSecondaryKAM.Checked)
            {
                if (SecondaryKAMList == null)
                {
                    GetAllSecondaryKAMFromApi();
                }

                AddKeyValuePairListToSecondaryKAMIDComboBox();
            }
            else
            {
                comboBox_secondaryKAM.Items.AddRange(CustomerHandler.Instance.FileColumnHeaders.Cast<object>()
                    .ToArray());
            }

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_secondaryKAM);

            if (_tableColumnIndex != -1)
            {
                ClearColumn(_tableColumnIndex);

                ClearRow(_tableColumnIndex);

                CheckCellsForNullOrEmpty(_tableColumnIndex);
            }
        }

        private void checkBox_defaultIndustryName_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_industryName.ResetText();
            comboBox_industryName.Items.Clear();

            if (checkBox_defaultIndustryName.Checked)
            {
                if (IndustryNameList == null)
                {
                    GetAllIndustryFromApi();
                }

                AddKeyValuePairListToIndustryIDComboBox();
            }
            else
            {
                comboBox_industryName.Items.AddRange(CustomerHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
            }

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_industryName);

            if (_tableColumnIndex != -1)
            {
                ClearColumn(_tableColumnIndex);

                ClearRow(_tableColumnIndex);

                CheckCellsForNullOrEmpty(_tableColumnIndex);
            }
        }

        private void checkBox_defaultExpenseIsBillable_CheckedChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonKeyValuePairToComboBoxByCheckboxStatus(dataGridView_customer, _customerTable, comboBox_expenseIsBillable,
                _expenseIsBillable, checkBox_defaultExpenseIsBillable, ExpenseIsBillableList, CustomerHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());

            //comboBox_expenseIsBillable.ResetText();
            //comboBox_expenseIsBillable.Items.Clear();

            //comboBox_expenseIsBillable.Items.AddRange(checkBox_defaultExpenseIsBillable.Checked
            //    ? ExpenseIsBillableList.Cast<object>().ToArray()
            //    : CustomerHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());

            //var _tableColumnIndex = _customerTable.Columns.IndexOf(_expenseIsBillable);

            //if (_tableColumnIndex != -1)
            //{
            //    ClearColumn(_tableColumnIndex);

            //    ClearRow(_tableColumnIndex);

            //    CheckCellsForNullOrEmpty(_tableColumnIndex);
            //}
        }

        private void checkBox_defaultMileageIsBillable_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_mileageIsBillable.ResetText();
            comboBox_mileageIsBillable.Items.Clear();

            comboBox_mileageIsBillable.Items.AddRange(checkBox_defaultMileageIsBillable.Checked
                ? MileageIsBillableList.Cast<object>().ToArray()
                : CustomerHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_mileageIsBillable);

            if (_tableColumnIndex != -1)
            {
                ClearColumn(_tableColumnIndex);

                ClearRow(_tableColumnIndex);

                CheckCellsForNullOrEmpty(_tableColumnIndex);
            }
        }

        private void checkBox_defaultPaymentTermID_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_paymentTermID.ResetText();
            comboBox_paymentTermID.Items.Clear();

            if (checkBox_defaultPaymentTermID.Checked)
            {
                //default values for payment term ID to be implemented later due to lack of API
                //if (_paymentTermIDList == null)
                //{
                //    GetAllPaymentTermFromApi();
                //}

                //AddKeyValuePairListToPaymentTermIDComboBox();
            }
            else
            {
                comboBox_paymentTermID.Items.AddRange(CustomerHandler.Instance.FileColumnHeaders.Cast<object>()
                    .ToArray());
            }

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_paymentTermID);

            if (_tableColumnIndex != -1)
            {
                ClearColumn(_tableColumnIndex);

                ClearRow(_tableColumnIndex);

                CheckCellsForNullOrEmpty(_tableColumnIndex);
            }
        }

        private void checkBox_defaultVATPercentage_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_VATPercentage.ResetText();
            comboBox_VATPercentage.Items.Clear();

            for (int i = 0; i <= 100; i++)
            {
                VATPercentageList.Add(i.ToString());
            }

            comboBox_VATPercentage.Items.AddRange(checkBox_defaultVATPercentage.Checked
                ? VATPercentageList.Cast<object>().ToArray()
                : CustomerHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());

            var _tableColumnIndex = _customerTable.Columns.IndexOf(_VATPercentage);

            if (_tableColumnIndex != -1)
            {
                ClearColumn(_tableColumnIndex);

                ClearRow(_tableColumnIndex);

                CheckCellsForNullOrEmpty(_tableColumnIndex);
            }
        }

        #endregion
    }
}