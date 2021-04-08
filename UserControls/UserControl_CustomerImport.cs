using System;
using System.Collections.Generic;
using System.Data;
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
        private readonly string _invoicingAddressCountryISO = "Invoicing Address Country ISO";
        private readonly string _defaultMileageDistance = "Default Mileage Distance";
        private readonly string _expenseIsBillable = "Expense Is Billable";
        private readonly string _mileageIsBillable = "Mileage Is Billable";
        private readonly string _defaultDistIsMaxBillable = "Default Dist Is Max Billable";
        private readonly string _paymentTerm = "Payment Term";
        private readonly string _discountPercentage = "Discount Percentage";
        private readonly string _calculateVAT = "Calculate VAT";
        private readonly string _VATPercentage = "VAT Percentage";

        //default value lists
        private static readonly List<string> ExpenseIsBillableList = new List<string> {"true", "false"};
        private static readonly List<string> MileageIsBillableList = new List<string> {"true", "false"};
        private static List<string> VATPercentageList = new List<string>();


        //default value lists from API 
        private static readonly List<KeyValuePair<int, string>> CurrencyISOList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> CountryISOList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> CustomerStatusList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> PrimaryKAMList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> SecondaryKAMList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> IndustryNameList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> PaymentTermList = new List<KeyValuePair<int, string>>();


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
            GetAllPaymentTermFromApi();
            VATPercentageList = CustomerHandler.Instance.GetPercentageList();
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


                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_customerName, _customerName);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_currencyISO, _currencyISO);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_customerStatus, _customerStatus);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_countryISO, _countryISO);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_customerNo, _customerNo);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_nickName, _nickname);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_primaryKAM, _primaryKAM);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_secondaryKAM, _secondaryKAM);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_customerSince, _customerSince);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_industryName, _industryName);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_phoneNo, _phoneNo);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_faxNo, _faxNo);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_email, _email);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_website, _website);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_address, _address);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_address2, _address2);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_address3, _address3);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_zipCode, _zipCode);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_city, _city);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_state, _state);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_useEanNo, _useEanNo);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_eanNo, _eanNo);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_organizationNo, _organizationNo);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_VATNo, _VATNo);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_useInvoicingAddress, _useInvoicingAddress);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_invoicingAddress, _invoicingAddress);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_invoicingAddress2, _invoicingAddress2);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_invoicingAddress3, _invoicingAddress3);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_invoicingAddressZipCode, _invoicingAddressZipCode);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_invoicingAddressCity, _invoicingAddressCity);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_invoicingAddressState, _invoicingAddressState);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_invoicingAddressCountryISO, _invoicingAddressCountryISO);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_defaultMileageDistance, _defaultMileageDistance);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_expenseIsBillable, _expenseIsBillable);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_mileageIsBillable, _mileageIsBillable);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_defaultDistIsMaxBillable, _defaultDistIsMaxBillable);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_paymentTerm, _paymentTerm);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_discountPercentage, _discountPercentage);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_calculateVAT, _calculateVAT);
                CustomerHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_VATPercentage, _VATPercentage);
            



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
                Invoke((MethodInvoker) (() => button_validate.Enabled = false));
                Invoke((MethodInvoker) (() => button_import.Enabled = false));
                Invoke((MethodInvoker) (() => button_clear.Enabled = false));
                Invoke((MethodInvoker) (() => button_customerSelectFile.Enabled = false));

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
                                InvoicingAddressCountryID = (int) MapFieldValueToID(_invoicingAddressCountryISO, _row, false),
                                DefaultMileageDistance = CustomerHandler.Instance.CheckAndGetInteger(dataGridView_customer, _defaultMileageDistance, _row),
                                ExpenseIsBillable = CustomerHandler.Instance.CheckAndGetBoolean(dataGridView_customer, _expenseIsBillable, _row),
                                MileageIsBillable = CustomerHandler.Instance.CheckAndGetBoolean(dataGridView_customer, _mileageIsBillable, _row),
                                DefaultDistIsMaxBillable = CustomerHandler.Instance.CheckAndGetBoolean(dataGridView_customer, _defaultDistIsMaxBillable, _row),
                                PaymentTermID = (int) MapFieldValueToID(_paymentTerm, _row, false),
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
                Invoke((MethodInvoker) (() => button_validate.Enabled = true));
                Invoke((MethodInvoker) (() => button_clear.Enabled = true));
                Invoke((MethodInvoker) (() => button_customerSelectFile.Enabled = true));
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
            comboBox_invoicingAddressCountryISO.Items.AddRange(fileColumnHeaderArray);
            comboBox_defaultMileageDistance.Items.AddRange(fileColumnHeaderArray);
            comboBox_expenseIsBillable.Items.AddRange(fileColumnHeaderArray);
            comboBox_mileageIsBillable.Items.AddRange(fileColumnHeaderArray);
            comboBox_defaultDistIsMaxBillable.Items.AddRange(fileColumnHeaderArray);
            comboBox_paymentTerm.Items.AddRange(fileColumnHeaderArray);
            comboBox_discountPercentage.Items.AddRange(fileColumnHeaderArray);
            comboBox_calculateVAT.Items.AddRange(fileColumnHeaderArray);
            comboBox_VATPercentage.Items.AddRange(fileColumnHeaderArray);
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
                else if (columnName == _invoicingAddressCountryISO)
                {
                    _result = CustomerHandler.Instance.GetIDFromFieldValue(CountryISOList, _fieldValue);

                    if (_result == -1)
                    {
                        // if no invoice address country is added fall back to customer main country
                        _fieldValue = CustomerHandler.Instance.CheckAndGetString(dataGridView_customer, _countryISO, row);
                        _result = CustomerHandler.Instance.GetIDFromFieldValue(CountryISOList, _fieldValue);
                    }

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
                else if (columnName == _paymentTerm)
                {
                    _result = CustomerHandler.Instance.GetIDFromFieldValue(PaymentTermList, _fieldValue);
                    if (_result == -1)
                    {
                        _result = 0;
                    }
                }


                if (_result != -1)
                {
                    return _result;
                }

                if (isNullableField)
                {
                    return null;
                }

                //if can't match, display error message
                _errorRowCount = CustomerHandler.Instance.HandleInvalidFieldValueToIDMapping(columnName, row, _fieldValue, textBox_customerImportMessages,
                    WorkerFetcher, this, _isFirstTimeInvalidMapping, _errorRowCount);
                _isMappingFieldValueToIDCorrect = false;
                _isFirstTimeInvalidMapping = false;
            }

            

            return 0;
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
            comboBox_invoicingAddressCountryISO.ResetText();
            comboBox_invoicingAddressCountryISO.Items.Clear();
            comboBox_defaultMileageDistance.ResetText();
            comboBox_defaultMileageDistance.Items.Clear();
            comboBox_expenseIsBillable.ResetText();
            comboBox_expenseIsBillable.Items.Clear();
            comboBox_mileageIsBillable.ResetText();
            comboBox_mileageIsBillable.Items.Clear();
            comboBox_defaultDistIsMaxBillable.ResetText();
            comboBox_defaultDistIsMaxBillable.Items.Clear();
            comboBox_paymentTerm.ResetText();
            comboBox_paymentTerm.Items.Clear();
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
            checkBox_defaultPaymentTerm.Checked = false;
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
                    PaymentTermList.Add(new KeyValuePair<int, string>(_paymentTerm.ID,
                        _paymentTerm.Name));
                }
            }
        }

        #endregion

        #region Combobox implementations

        private void comboBox_customerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_customerName, _customerName);
        }

        private void comboBox_currencyISO_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_currencyISO, _currencyISO, checkBox_defaultCurrencyISO);
        }

        private void comboBox_customerStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_customerStatus, _customerStatus, checkBox_defaultCustomerStatus);
        }

        private void comboBox_countryISO_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_countryISO, _countryISO, checkBox_defaultCountryISO);
        }

        private void comboBox_customerNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_customerNo, _customerNo);
        }

        private void comboBox_nickName_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_nickName, _nickname);
        }

        private void comboBox_primaryKAM_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_primaryKAM, _primaryKAM, checkBox_defaultPrimaryKAM);
        }

        private void comboBox_secondaryKAM_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_secondaryKAM, _secondaryKAM, checkBox_defaultSecondaryKAM);
        }

        private void comboBox_customerSince_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_customerSince, _customerSince);
        }

        private void comboBox_industryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_industryName, _industryName, checkBox_defaultIndustryName);
        }

        private void comboBox_phoneNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_phoneNo, _phoneNo);
        }

        private void comboBox_faxNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_faxNo, _faxNo);
        }

        private void comboBox_email_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_email, _email);
        }

        private void comboBox_website_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_website, _website);
        }

        private void comboBox_address_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_address, _address);
        }

        private void comboBox_address2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_address2, _address2);
        }

        private void comboBox_address3_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_address3, _address3);
        }

        private void comboBox_zipCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_zipCode, _zipCode);
        }

        private void comboBox_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_city, _city);
        }

        private void comboBox_state_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_state, _state);
        }

        private void comboBox_useEanNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_useEanNo, _useEanNo);
        }

        private void comboBox_eanNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_eanNo, _eanNo);
        }

        private void comboBox_organizationNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_organizationNo, _organizationNo);
        }

        private void comboBox_VATNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_VATNo, _VATNo);
        }

        private void comboBox_useInvoicingAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_useInvoicingAddress, _useInvoicingAddress);
        }

        private void comboBox_invoicingAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_invoicingAddress, _invoicingAddress);
        }

        private void comboBox_invoicingAddress2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_invoicingAddress2, _invoicingAddress2);
        }

        private void comboBox_invoicingAddress3_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_invoicingAddress3, _invoicingAddress3);
        }

        private void comboBox_invoicingAddressZipCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_invoicingAddressZipCode, _invoicingAddressZipCode);
        }

        private void comboBox_invoicingAddressCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_invoicingAddressCity, _invoicingAddressCity);
        }

        private void comboBox_invoicingAddressState_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_invoicingAddressState, _invoicingAddressState);
        }

        private void comboBox_invoicingAddressCountryID_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_invoicingAddressCountryISO, _invoicingAddressCountryISO);
        }

        private void comboBox_defaultMileageDistance_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_defaultMileageDistance, _defaultMileageDistance);
        }

        private void comboBox_expenseIsBillable_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatoryNonKeyValuePairSelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_expenseIsBillable, _expenseIsBillable, checkBox_defaultExpenseIsBillable);
        }

        private void comboBox_mileageIsBillable_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatoryNonKeyValuePairSelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_mileageIsBillable, _mileageIsBillable, checkBox_defaultMileageIsBillable);
        }

        private void comboBox_defaultDistIsMaxBillable_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_defaultDistIsMaxBillable, _defaultDistIsMaxBillable);
        }


        private void comboBox_paymentTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_paymentTerm, _paymentTerm, checkBox_defaultPaymentTerm);
        }

        private void comboBox_discountPercentage_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_discountPercentage, _discountPercentage);
        }

        private void comboBox_calculateVAT_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_calculateVAT, _calculateVAT);
        }

        private void comboBox_VATPercentage_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_customer, _customerTable, comboBox_VATPercentage, _VATPercentage, checkBox_defaultVATPercentage);
        }

        #endregion

        #region Checkbox implementations

        private void checkBox_defaultCurrencyISO_CheckedChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapValuesToComboBoxByCheckboxStatus(dataGridView_customer, _customerTable, comboBox_currencyISO,
                _currencyISO, checkBox_defaultCurrencyISO, CurrencyISOList, CustomerHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultCustomerStatus_CheckedChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapValuesToComboBoxByCheckboxStatus(dataGridView_customer, _customerTable, comboBox_customerStatus,
                _customerStatus, checkBox_defaultCustomerStatus, CustomerStatusList, CustomerHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultCountryISO_CheckedChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapValuesToComboBoxByCheckboxStatus(dataGridView_customer, _customerTable, comboBox_countryISO,
                _countryISO, checkBox_defaultCountryISO, CountryISOList, CustomerHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultInvoiceAddressCountryISO_CheckedChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapValuesToComboBoxByCheckboxStatus(dataGridView_customer, _customerTable, comboBox_invoicingAddressCountryISO,
                _invoicingAddressCountryISO, checkBox_defaultInvoicingAddressCountryISO, CountryISOList, CustomerHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultPrimaryKAM_CheckedChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapValuesToComboBoxByCheckboxStatus(dataGridView_customer, _customerTable, comboBox_primaryKAM,
                _primaryKAM, checkBox_defaultPrimaryKAM, PrimaryKAMList, CustomerHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultSecondaryKAM_CheckedChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapValuesToComboBoxByCheckboxStatus(dataGridView_customer, _customerTable, comboBox_secondaryKAM,
                _secondaryKAM, checkBox_defaultSecondaryKAM, SecondaryKAMList, CustomerHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultIndustryName_CheckedChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapValuesToComboBoxByCheckboxStatus(dataGridView_customer, _customerTable, comboBox_industryName,
                _industryName, checkBox_defaultIndustryName, IndustryNameList, CustomerHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultExpenseIsBillable_CheckedChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonKeyValuePairToComboBoxByCheckboxStatus(dataGridView_customer, _customerTable, comboBox_expenseIsBillable,
                _expenseIsBillable, checkBox_defaultExpenseIsBillable, ExpenseIsBillableList, CustomerHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultMileageIsBillable_CheckedChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonKeyValuePairToComboBoxByCheckboxStatus(dataGridView_customer, _customerTable, comboBox_mileageIsBillable,
                _mileageIsBillable, checkBox_defaultMileageIsBillable, MileageIsBillableList, CustomerHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultPaymentTerm_CheckedChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapValuesToComboBoxByCheckboxStatus(dataGridView_customer, _customerTable, comboBox_paymentTerm,
                _paymentTerm, checkBox_defaultPaymentTerm, PaymentTermList, CustomerHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultVATPercentage_CheckedChanged(object sender, EventArgs e)
        {
            CustomerHandler.Instance.MapNonKeyValuePairToComboBoxByCheckboxStatus(dataGridView_customer, _customerTable, comboBox_VATPercentage,
                _VATPercentage, checkBox_defaultVATPercentage, VATPercentageList, CustomerHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        #endregion
    }
}