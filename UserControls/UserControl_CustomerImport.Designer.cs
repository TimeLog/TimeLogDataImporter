using System.Windows.Forms;

namespace TimeLog.DataImporter.UserControls
{
    partial class UserControl_CustomerImport
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            WorkerFetcher = new System.ComponentModel.BackgroundWorker();
            panel_customerDataTable = new Panel();
            dataGridView_customer = new DataGridView();
            panel_customerMessage = new Panel();
            textBox_customerImportMessages = new TextBox();
            panel_customerButtons = new Panel();
            button_clear = new Button();
            button_import = new Button();
            button_validate = new Button();
            button_stop = new Button();
            panel_customerFieldMapping = new Panel();
            flowLayoutPanel_NonMandatoryFields = new FlowLayoutPanel();
            panel_customerDetailsButton = new Panel();
            label_customerDetails = new Label();
            button_customerDetails = new Button();
            panel_customerDetails = new Panel();
            label_customerNo = new Label();
            label_nickname = new Label();
            checkBox_defaultIndustryName = new CheckBox();
            label_customerSince = new Label();
            checkBox_defaultSecondaryKAM = new CheckBox();
            label_primaryKAM = new Label();
            comboBox_industryName = new ComboBox();
            label_secondaryKAM = new Label();
            comboBox_customerSince = new ComboBox();
            label_industryName = new Label();
            comboBox_primaryKAM = new ComboBox();
            comboBox_secondaryKAM = new ComboBox();
            comboBox_nickName = new ComboBox();
            comboBox_customerNo = new ComboBox();
            checkBox_defaultPrimaryKAM = new CheckBox();
            panel_contactDetailsButton = new Panel();
            label_ContactDetails = new Label();
            button_contactDetails = new Button();
            panel_contactDetails = new Panel();
            label_phone = new Label();
            label_fax = new Label();
            label_website = new Label();
            label_address = new Label();
            label_address2 = new Label();
            label_address3 = new Label();
            label_zipCode = new Label();
            label_city = new Label();
            label_state = new Label();
            label_email = new Label();
            comboBox_phoneNo = new ComboBox();
            comboBox_faxNo = new ComboBox();
            comboBox_email = new ComboBox();
            comboBox_website = new ComboBox();
            comboBox_address = new ComboBox();
            comboBox_address2 = new ComboBox();
            comboBox_address3 = new ComboBox();
            comboBox_zipCode = new ComboBox();
            comboBox_city = new ComboBox();
            comboBox_state = new ComboBox();
            panel_invoiceAddressButton = new Panel();
            label_invoiceAddress = new Label();
            button_invoiceAddress = new Button();
            panel_invoiceAddress = new Panel();
            checkBox_defaultInvoicingAddressCountryISO = new CheckBox();
            label_useInvoicingAddress = new Label();
            label_invoicingAddress = new Label();
            label_invoicingAddressCity = new Label();
            label_invoicingAddressZipCode = new Label();
            label_invoicingAddress2 = new Label();
            label_invoicingAddress3 = new Label();
            label_invoicingAddressState = new Label();
            label_invoicingAddressCountryID = new Label();
            comboBox_useInvoicingAddress = new ComboBox();
            comboBox_invoicingAddress = new ComboBox();
            comboBox_invoicingAddress2 = new ComboBox();
            comboBox_invoicingAddress3 = new ComboBox();
            comboBox_invoicingAddressZipCode = new ComboBox();
            comboBox_invoicingAddressCity = new ComboBox();
            comboBox_invoicingAddressState = new ComboBox();
            comboBox_invoicingAddressCountryISO = new ComboBox();
            panel2 = new Panel();
            label_financeCompanyInfo = new Label();
            button_financeCompanyInfo = new Button();
            panel_financeCompanyInfo = new Panel();
            label_organizationNo = new Label();
            label_vatNo = new Label();
            comboBox_organizationNo = new ComboBox();
            comboBox_VATNo = new ComboBox();
            comboBox_eanNo = new ComboBox();
            comboBox_useEanNo = new ComboBox();
            label_eanNo = new Label();
            label_useEanNo = new Label();
            panel_defaultInvoiceSettingsButton = new Panel();
            label_defaultInvoiceSettings = new Label();
            button_defaultInvoiceSettings = new Button();
            panel_defaultInvoiceSettings = new Panel();
            checkBox_defaultVATPercentage = new CheckBox();
            checkBox_defaultPaymentTerm = new CheckBox();
            label_paymentTerm = new Label();
            label_discountPercentage = new Label();
            label_calculateVAT = new Label();
            comboBox_VATPercentage = new ComboBox();
            label_vatPercentage = new Label();
            comboBox_calculateVAT = new ComboBox();
            comboBox_discountPercentage = new ComboBox();
            comboBox_paymentTerm = new ComboBox();
            panel_invoiceExternalCosts = new Panel();
            label_invoiceExternalCosts = new Label();
            button_invoiceExternalCosts = new Button();
            panel_incoiceExternalCosts = new Panel();
            checkBox_defaultExpenseIsBillable = new CheckBox();
            checkBox_defaultMileageIsBillable = new CheckBox();
            label_defaultMileageDistance = new Label();
            label_defaultDistIsMaxBillable = new Label();
            label_expenseIsBillable = new Label();
            label_mileageIsBillable = new Label();
            comboBox_defaultDistIsMaxBillable = new ComboBox();
            comboBox_defaultMileageDistance = new ComboBox();
            comboBox_expenseIsBillable = new ComboBox();
            comboBox_mileageIsBillable = new ComboBox();
            label_delimiter = new Label();
            comboBox_delimiter = new ComboBox();
            groupBox_customerMandatoryFields = new GroupBox();
            checkBox_defaultCountryISO = new CheckBox();
            checkBox_defaultCustomerStatus = new CheckBox();
            checkBox_defaultCurrencyISO = new CheckBox();
            label_countryISO = new Label();
            label_customerStatus = new Label();
            comboBox_countryISO = new ComboBox();
            comboBox_customerStatus = new ComboBox();
            label_currencyISO = new Label();
            comboBox_currencyISO = new ComboBox();
            label_customerName = new Label();
            comboBox_customerName = new ComboBox();
            label_customerSetup = new Label();
            button_customerSelectFile = new Button();
            defaultToolTip = new ToolTip(components);
            tmrExpand = new Timer(components);
            label1 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            label_contactPerson = new Label();
            comboBox_contactPerson = new ComboBox();
            panel_customerDataTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_customer).BeginInit();
            panel_customerMessage.SuspendLayout();
            panel_customerButtons.SuspendLayout();
            panel_customerFieldMapping.SuspendLayout();
            flowLayoutPanel_NonMandatoryFields.SuspendLayout();
            panel_customerDetailsButton.SuspendLayout();
            panel_customerDetails.SuspendLayout();
            panel_contactDetailsButton.SuspendLayout();
            panel_contactDetails.SuspendLayout();
            panel_invoiceAddressButton.SuspendLayout();
            panel_invoiceAddress.SuspendLayout();
            panel2.SuspendLayout();
            panel_financeCompanyInfo.SuspendLayout();
            panel_defaultInvoiceSettingsButton.SuspendLayout();
            panel_defaultInvoiceSettings.SuspendLayout();
            panel_invoiceExternalCosts.SuspendLayout();
            panel_incoiceExternalCosts.SuspendLayout();
            groupBox_customerMandatoryFields.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // WorkerFetcher
            // 
            WorkerFetcher.WorkerReportsProgress = true;
            WorkerFetcher.WorkerSupportsCancellation = true;
            WorkerFetcher.DoWork += WorkerFetcherDoWork;
            // 
            // panel_customerDataTable
            // 
            panel_customerDataTable.Controls.Add(dataGridView_customer);
            panel_customerDataTable.Dock = DockStyle.Bottom;
            panel_customerDataTable.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel_customerDataTable.Location = new System.Drawing.Point(0, 616);
            panel_customerDataTable.Margin = new Padding(3, 4, 3, 4);
            panel_customerDataTable.Name = "panel_customerDataTable";
            panel_customerDataTable.Size = new System.Drawing.Size(1150, 240);
            panel_customerDataTable.TabIndex = 6;
            // 
            // dataGridView_customer
            // 
            dataGridView_customer.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridView_customer.BorderStyle = BorderStyle.None;
            dataGridView_customer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_customer.Dock = DockStyle.Bottom;
            dataGridView_customer.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridView_customer.Location = new System.Drawing.Point(0, 0);
            dataGridView_customer.Margin = new Padding(3, 4, 3, 4);
            dataGridView_customer.Name = "dataGridView_customer";
            dataGridView_customer.RowHeadersWidth = 62;
            dataGridView_customer.Size = new System.Drawing.Size(1150, 240);
            dataGridView_customer.TabIndex = 0;
            defaultToolTip.SetToolTip(dataGridView_customer, "Customer input data table");
            // 
            // panel_customerMessage
            // 
            panel_customerMessage.Controls.Add(textBox_customerImportMessages);
            panel_customerMessage.Dock = DockStyle.Bottom;
            panel_customerMessage.Location = new System.Drawing.Point(0, 370);
            panel_customerMessage.Margin = new Padding(3, 4, 3, 4);
            panel_customerMessage.Name = "panel_customerMessage";
            panel_customerMessage.Size = new System.Drawing.Size(1150, 246);
            panel_customerMessage.TabIndex = 10;
            // 
            // textBox_customerImportMessages
            // 
            textBox_customerImportMessages.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            textBox_customerImportMessages.BorderStyle = BorderStyle.None;
            textBox_customerImportMessages.Dock = DockStyle.Bottom;
            textBox_customerImportMessages.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBox_customerImportMessages.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            textBox_customerImportMessages.Location = new System.Drawing.Point(0, 0);
            textBox_customerImportMessages.Margin = new Padding(3, 4, 3, 4);
            textBox_customerImportMessages.Multiline = true;
            textBox_customerImportMessages.Name = "textBox_customerImportMessages";
            textBox_customerImportMessages.ReadOnly = true;
            textBox_customerImportMessages.ScrollBars = ScrollBars.Vertical;
            textBox_customerImportMessages.Size = new System.Drawing.Size(1150, 246);
            textBox_customerImportMessages.TabIndex = 0;
            defaultToolTip.SetToolTip(textBox_customerImportMessages, "Validation or import status");
            textBox_customerImportMessages.MouseClick += textBox_customerImportMessages_MouseClick;
            // 
            // panel_customerButtons
            // 
            panel_customerButtons.Controls.Add(button_clear);
            panel_customerButtons.Controls.Add(button_import);
            panel_customerButtons.Controls.Add(button_validate);
            panel_customerButtons.Controls.Add(button_stop);
            panel_customerButtons.Dock = DockStyle.Bottom;
            panel_customerButtons.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            panel_customerButtons.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel_customerButtons.Location = new System.Drawing.Point(0, 300);
            panel_customerButtons.Margin = new Padding(3, 4, 3, 4);
            panel_customerButtons.Name = "panel_customerButtons";
            panel_customerButtons.Size = new System.Drawing.Size(1150, 70);
            panel_customerButtons.TabIndex = 12;
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Left;
            button_clear.BackColor = System.Drawing.Color.DimGray;
            button_clear.Cursor = Cursors.Hand;
            button_clear.FlatAppearance.BorderSize = 0;
            button_clear.FlatStyle = FlatStyle.Flat;
            button_clear.ForeColor = System.Drawing.Color.White;
            button_clear.Location = new System.Drawing.Point(16, 16);
            button_clear.Margin = new Padding(3, 4, 3, 4);
            button_clear.Name = "button_clear";
            button_clear.Size = new System.Drawing.Size(91, 38);
            button_clear.TabIndex = 12;
            button_clear.Text = "Reset All";
            defaultToolTip.SetToolTip(button_clear, "Reset all file input above and data table below");
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click;
            // 
            // button_import
            // 
            button_import.Anchor = AnchorStyles.Right;
            button_import.BackColor = System.Drawing.Color.FromArgb(226, 43, 141);
            button_import.Cursor = Cursors.Hand;
            button_import.FlatAppearance.BorderSize = 0;
            button_import.FlatStyle = FlatStyle.Flat;
            button_import.ForeColor = System.Drawing.Color.White;
            button_import.Location = new System.Drawing.Point(1048, 16);
            button_import.Margin = new Padding(3, 4, 3, 4);
            button_import.Name = "button_import";
            button_import.Size = new System.Drawing.Size(91, 38);
            button_import.TabIndex = 7;
            button_import.Text = "Import";
            defaultToolTip.SetToolTip(button_import, "Import all data");
            button_import.UseVisualStyleBackColor = false;
            button_import.Click += button_import_Click;
            // 
            // button_validate
            // 
            button_validate.Anchor = AnchorStyles.Right;
            button_validate.BackColor = System.Drawing.Color.FromArgb(226, 43, 141);
            button_validate.Cursor = Cursors.Hand;
            button_validate.FlatAppearance.BorderSize = 0;
            button_validate.FlatStyle = FlatStyle.Flat;
            button_validate.ForeColor = System.Drawing.Color.White;
            button_validate.Location = new System.Drawing.Point(851, 16);
            button_validate.Margin = new Padding(3, 4, 3, 4);
            button_validate.Name = "button_validate";
            button_validate.Size = new System.Drawing.Size(91, 38);
            button_validate.TabIndex = 8;
            button_validate.Text = "Validate";
            defaultToolTip.SetToolTip(button_validate, "Validate data input before importing data");
            button_validate.UseVisualStyleBackColor = false;
            button_validate.Click += button_validate_Click;
            // 
            // button_stop
            // 
            button_stop.Anchor = AnchorStyles.Right;
            button_stop.BackColor = System.Drawing.Color.DimGray;
            button_stop.Cursor = Cursors.Hand;
            button_stop.FlatAppearance.BorderSize = 0;
            button_stop.FlatStyle = FlatStyle.Flat;
            button_stop.ForeColor = System.Drawing.Color.White;
            button_stop.Location = new System.Drawing.Point(950, 16);
            button_stop.Margin = new Padding(3, 4, 3, 4);
            button_stop.Name = "button_stop";
            button_stop.Size = new System.Drawing.Size(91, 38);
            button_stop.TabIndex = 11;
            button_stop.Text = "Stop";
            defaultToolTip.SetToolTip(button_stop, "Stop validation or import");
            button_stop.UseVisualStyleBackColor = false;
            button_stop.Click += button_stop_Click;
            // 
            // panel_customerFieldMapping
            // 
            panel_customerFieldMapping.AutoScroll = true;
            panel_customerFieldMapping.Controls.Add(flowLayoutPanel_NonMandatoryFields);
            panel_customerFieldMapping.Controls.Add(label_delimiter);
            panel_customerFieldMapping.Controls.Add(comboBox_delimiter);
            panel_customerFieldMapping.Controls.Add(groupBox_customerMandatoryFields);
            panel_customerFieldMapping.Controls.Add(label_customerSetup);
            panel_customerFieldMapping.Controls.Add(button_customerSelectFile);
            panel_customerFieldMapping.Dock = DockStyle.Fill;
            panel_customerFieldMapping.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            panel_customerFieldMapping.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel_customerFieldMapping.Location = new System.Drawing.Point(0, 0);
            panel_customerFieldMapping.Margin = new Padding(3, 4, 3, 4);
            panel_customerFieldMapping.Name = "panel_customerFieldMapping";
            panel_customerFieldMapping.Size = new System.Drawing.Size(1150, 300);
            panel_customerFieldMapping.TabIndex = 13;
            // 
            // flowLayoutPanel_NonMandatoryFields
            // 
            flowLayoutPanel_NonMandatoryFields.Controls.Add(panel_customerDetailsButton);
            flowLayoutPanel_NonMandatoryFields.Controls.Add(panel_customerDetails);
            flowLayoutPanel_NonMandatoryFields.Controls.Add(panel_contactDetailsButton);
            flowLayoutPanel_NonMandatoryFields.Controls.Add(panel_contactDetails);
            flowLayoutPanel_NonMandatoryFields.Controls.Add(panel_invoiceAddressButton);
            flowLayoutPanel_NonMandatoryFields.Controls.Add(panel_invoiceAddress);
            flowLayoutPanel_NonMandatoryFields.Controls.Add(panel2);
            flowLayoutPanel_NonMandatoryFields.Controls.Add(panel_financeCompanyInfo);
            flowLayoutPanel_NonMandatoryFields.Controls.Add(panel_defaultInvoiceSettingsButton);
            flowLayoutPanel_NonMandatoryFields.Controls.Add(panel_defaultInvoiceSettings);
            flowLayoutPanel_NonMandatoryFields.Controls.Add(panel_invoiceExternalCosts);
            flowLayoutPanel_NonMandatoryFields.Controls.Add(panel_incoiceExternalCosts);
            flowLayoutPanel_NonMandatoryFields.Location = new System.Drawing.Point(610, 22);
            flowLayoutPanel_NonMandatoryFields.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel_NonMandatoryFields.Name = "flowLayoutPanel_NonMandatoryFields";
            flowLayoutPanel_NonMandatoryFields.Size = new System.Drawing.Size(499, 2152);
            flowLayoutPanel_NonMandatoryFields.TabIndex = 8;
            // 
            // panel_customerDetailsButton
            // 
            panel_customerDetailsButton.Controls.Add(label_customerDetails);
            panel_customerDetailsButton.Controls.Add(button_customerDetails);
            panel_customerDetailsButton.Location = new System.Drawing.Point(3, 4);
            panel_customerDetailsButton.Margin = new Padding(3, 4, 3, 4);
            panel_customerDetailsButton.Name = "panel_customerDetailsButton";
            panel_customerDetailsButton.Size = new System.Drawing.Size(487, 42);
            panel_customerDetailsButton.TabIndex = 0;
            // 
            // label_customerDetails
            // 
            label_customerDetails.AutoSize = true;
            label_customerDetails.ForeColor = System.Drawing.Color.Black;
            label_customerDetails.Location = new System.Drawing.Point(51, 10);
            label_customerDetails.Name = "label_customerDetails";
            label_customerDetails.Size = new System.Drawing.Size(140, 23);
            label_customerDetails.TabIndex = 1;
            label_customerDetails.Text = "Customer Details";
            // 
            // button_customerDetails
            // 
            button_customerDetails.BackColor = System.Drawing.Color.White;
            button_customerDetails.BackgroundImageLayout = ImageLayout.Stretch;
            button_customerDetails.Cursor = Cursors.Hand;
            button_customerDetails.FlatAppearance.BorderSize = 0;
            button_customerDetails.FlatStyle = FlatStyle.Flat;
            button_customerDetails.Location = new System.Drawing.Point(10, 2);
            button_customerDetails.Margin = new Padding(3, 4, 3, 4);
            button_customerDetails.Name = "button_customerDetails";
            button_customerDetails.Size = new System.Drawing.Size(34, 40);
            button_customerDetails.TabIndex = 0;
            button_customerDetails.UseVisualStyleBackColor = false;
            button_customerDetails.Click += button_expand_Click;
            // 
            // panel_customerDetails
            // 
            panel_customerDetails.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            panel_customerDetails.Controls.Add(comboBox_contactPerson);
            panel_customerDetails.Controls.Add(label_contactPerson);
            panel_customerDetails.Controls.Add(label_customerNo);
            panel_customerDetails.Controls.Add(label_nickname);
            panel_customerDetails.Controls.Add(checkBox_defaultIndustryName);
            panel_customerDetails.Controls.Add(label_customerSince);
            panel_customerDetails.Controls.Add(checkBox_defaultSecondaryKAM);
            panel_customerDetails.Controls.Add(label_primaryKAM);
            panel_customerDetails.Controls.Add(comboBox_industryName);
            panel_customerDetails.Controls.Add(label_secondaryKAM);
            panel_customerDetails.Controls.Add(comboBox_customerSince);
            panel_customerDetails.Controls.Add(label_industryName);
            panel_customerDetails.Controls.Add(comboBox_primaryKAM);
            panel_customerDetails.Controls.Add(comboBox_secondaryKAM);
            panel_customerDetails.Controls.Add(comboBox_nickName);
            panel_customerDetails.Controls.Add(comboBox_customerNo);
            panel_customerDetails.Controls.Add(checkBox_defaultPrimaryKAM);
            panel_customerDetails.Location = new System.Drawing.Point(3, 54);
            panel_customerDetails.Margin = new Padding(3, 4, 3, 4);
            panel_customerDetails.MaximumSize = new System.Drawing.Size(487, 300);
            panel_customerDetails.MinimumSize = new System.Drawing.Size(487, 0);
            panel_customerDetails.Name = "panel_customerDetails";
            panel_customerDetails.Size = new System.Drawing.Size(487, 300);
            panel_customerDetails.TabIndex = 10;
            // 
            // label_customerNo
            // 
            label_customerNo.AutoSize = true;
            label_customerNo.Location = new System.Drawing.Point(11, 20);
            label_customerNo.Name = "label_customerNo";
            label_customerNo.Size = new System.Drawing.Size(112, 23);
            label_customerNo.TabIndex = 1;
            label_customerNo.Text = "Customer No";
            // 
            // label_nickname
            // 
            label_nickname.AutoSize = true;
            label_nickname.Location = new System.Drawing.Point(11, 62);
            label_nickname.Name = "label_nickname";
            label_nickname.Size = new System.Drawing.Size(87, 23);
            label_nickname.TabIndex = 1;
            label_nickname.Text = "Nickname";
            // 
            // checkBox_defaultIndustryName
            // 
            checkBox_defaultIndustryName.AutoSize = true;
            checkBox_defaultIndustryName.Location = new System.Drawing.Point(339, 226);
            checkBox_defaultIndustryName.Margin = new Padding(3, 4, 3, 4);
            checkBox_defaultIndustryName.Name = "checkBox_defaultIndustryName";
            checkBox_defaultIndustryName.Size = new System.Drawing.Size(88, 27);
            checkBox_defaultIndustryName.TabIndex = 8;
            checkBox_defaultIndustryName.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultIndustryName, "Set default values for all rows of a particular column field");
            checkBox_defaultIndustryName.UseVisualStyleBackColor = true;
            checkBox_defaultIndustryName.CheckedChanged += checkBox_defaultIndustryName_CheckedChanged;
            // 
            // label_customerSince
            // 
            label_customerSince.AutoSize = true;
            label_customerSince.Location = new System.Drawing.Point(11, 186);
            label_customerSince.Name = "label_customerSince";
            label_customerSince.Size = new System.Drawing.Size(129, 23);
            label_customerSince.TabIndex = 1;
            label_customerSince.Text = "Customer Since";
            // 
            // checkBox_defaultSecondaryKAM
            // 
            checkBox_defaultSecondaryKAM.AutoSize = true;
            checkBox_defaultSecondaryKAM.Location = new System.Drawing.Point(339, 142);
            checkBox_defaultSecondaryKAM.Margin = new Padding(3, 4, 3, 4);
            checkBox_defaultSecondaryKAM.Name = "checkBox_defaultSecondaryKAM";
            checkBox_defaultSecondaryKAM.Size = new System.Drawing.Size(88, 27);
            checkBox_defaultSecondaryKAM.TabIndex = 8;
            checkBox_defaultSecondaryKAM.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultSecondaryKAM, "Set default values for all rows of a particular column field");
            checkBox_defaultSecondaryKAM.UseVisualStyleBackColor = true;
            checkBox_defaultSecondaryKAM.CheckedChanged += checkBox_defaultSecondaryKAM_CheckedChanged;
            // 
            // label_primaryKAM
            // 
            label_primaryKAM.AutoSize = true;
            label_primaryKAM.Location = new System.Drawing.Point(11, 102);
            label_primaryKAM.Name = "label_primaryKAM";
            label_primaryKAM.Size = new System.Drawing.Size(112, 23);
            label_primaryKAM.TabIndex = 1;
            label_primaryKAM.Text = "Primary KAM";
            // 
            // comboBox_industryName
            // 
            comboBox_industryName.FormattingEnabled = true;
            comboBox_industryName.Location = new System.Drawing.Point(175, 222);
            comboBox_industryName.Margin = new Padding(3, 4, 3, 4);
            comboBox_industryName.Name = "comboBox_industryName";
            comboBox_industryName.Size = new System.Drawing.Size(157, 29);
            comboBox_industryName.TabIndex = 3;
            // 
            // label_secondaryKAM
            // 
            label_secondaryKAM.AutoSize = true;
            label_secondaryKAM.Location = new System.Drawing.Point(11, 144);
            label_secondaryKAM.Name = "label_secondaryKAM";
            label_secondaryKAM.Size = new System.Drawing.Size(133, 23);
            label_secondaryKAM.TabIndex = 1;
            label_secondaryKAM.Text = "Secondary KAM";
            // 
            // comboBox_customerSince
            // 
            comboBox_customerSince.FormattingEnabled = true;
            comboBox_customerSince.Location = new System.Drawing.Point(175, 182);
            comboBox_customerSince.Margin = new Padding(3, 4, 3, 4);
            comboBox_customerSince.Name = "comboBox_customerSince";
            comboBox_customerSince.Size = new System.Drawing.Size(157, 29);
            comboBox_customerSince.TabIndex = 3;
            // 
            // label_industryName
            // 
            label_industryName.AutoSize = true;
            label_industryName.Location = new System.Drawing.Point(11, 226);
            label_industryName.Name = "label_industryName";
            label_industryName.Size = new System.Drawing.Size(125, 23);
            label_industryName.TabIndex = 1;
            label_industryName.Text = "Industry Name";
            // 
            // comboBox_primaryKAM
            // 
            comboBox_primaryKAM.FormattingEnabled = true;
            comboBox_primaryKAM.Location = new System.Drawing.Point(175, 98);
            comboBox_primaryKAM.Margin = new Padding(3, 4, 3, 4);
            comboBox_primaryKAM.Name = "comboBox_primaryKAM";
            comboBox_primaryKAM.Size = new System.Drawing.Size(157, 29);
            comboBox_primaryKAM.TabIndex = 3;
            // 
            // comboBox_secondaryKAM
            // 
            comboBox_secondaryKAM.FormattingEnabled = true;
            comboBox_secondaryKAM.Location = new System.Drawing.Point(175, 140);
            comboBox_secondaryKAM.Margin = new Padding(3, 4, 3, 4);
            comboBox_secondaryKAM.Name = "comboBox_secondaryKAM";
            comboBox_secondaryKAM.Size = new System.Drawing.Size(157, 29);
            comboBox_secondaryKAM.TabIndex = 3;
            // 
            // comboBox_nickName
            // 
            comboBox_nickName.FormattingEnabled = true;
            comboBox_nickName.Location = new System.Drawing.Point(175, 58);
            comboBox_nickName.Margin = new Padding(3, 4, 3, 4);
            comboBox_nickName.Name = "comboBox_nickName";
            comboBox_nickName.Size = new System.Drawing.Size(157, 29);
            comboBox_nickName.TabIndex = 3;
            // 
            // comboBox_customerNo
            // 
            comboBox_customerNo.FormattingEnabled = true;
            comboBox_customerNo.Location = new System.Drawing.Point(175, 16);
            comboBox_customerNo.Margin = new Padding(3, 4, 3, 4);
            comboBox_customerNo.Name = "comboBox_customerNo";
            comboBox_customerNo.Size = new System.Drawing.Size(157, 29);
            comboBox_customerNo.TabIndex = 3;
            // 
            // checkBox_defaultPrimaryKAM
            // 
            checkBox_defaultPrimaryKAM.AutoSize = true;
            checkBox_defaultPrimaryKAM.Location = new System.Drawing.Point(339, 102);
            checkBox_defaultPrimaryKAM.Margin = new Padding(3, 4, 3, 4);
            checkBox_defaultPrimaryKAM.Name = "checkBox_defaultPrimaryKAM";
            checkBox_defaultPrimaryKAM.Size = new System.Drawing.Size(88, 27);
            checkBox_defaultPrimaryKAM.TabIndex = 8;
            checkBox_defaultPrimaryKAM.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultPrimaryKAM, "Set default values for all rows of a particular column field");
            checkBox_defaultPrimaryKAM.UseVisualStyleBackColor = true;
            checkBox_defaultPrimaryKAM.CheckedChanged += checkBox_defaultPrimaryKAM_CheckedChanged;
            // 
            // panel_contactDetailsButton
            // 
            panel_contactDetailsButton.Controls.Add(label_ContactDetails);
            panel_contactDetailsButton.Controls.Add(button_contactDetails);
            panel_contactDetailsButton.Location = new System.Drawing.Point(3, 362);
            panel_contactDetailsButton.Margin = new Padding(3, 4, 3, 4);
            panel_contactDetailsButton.Name = "panel_contactDetailsButton";
            panel_contactDetailsButton.Size = new System.Drawing.Size(487, 42);
            panel_contactDetailsButton.TabIndex = 11;
            // 
            // label_ContactDetails
            // 
            label_ContactDetails.AutoSize = true;
            label_ContactDetails.ForeColor = System.Drawing.Color.Black;
            label_ContactDetails.Location = new System.Drawing.Point(51, 10);
            label_ContactDetails.Name = "label_ContactDetails";
            label_ContactDetails.Size = new System.Drawing.Size(126, 23);
            label_ContactDetails.TabIndex = 1;
            label_ContactDetails.Text = "Contact Details";
            // 
            // button_contactDetails
            // 
            button_contactDetails.BackColor = System.Drawing.Color.White;
            button_contactDetails.BackgroundImageLayout = ImageLayout.Stretch;
            button_contactDetails.Cursor = Cursors.Hand;
            button_contactDetails.FlatAppearance.BorderSize = 0;
            button_contactDetails.FlatStyle = FlatStyle.Flat;
            button_contactDetails.Location = new System.Drawing.Point(10, 2);
            button_contactDetails.Margin = new Padding(3, 4, 3, 4);
            button_contactDetails.Name = "button_contactDetails";
            button_contactDetails.Size = new System.Drawing.Size(34, 40);
            button_contactDetails.TabIndex = 0;
            button_contactDetails.UseVisualStyleBackColor = false;
            button_contactDetails.Click += button_expand_Click;
            // 
            // panel_contactDetails
            // 
            panel_contactDetails.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            panel_contactDetails.Controls.Add(label_phone);
            panel_contactDetails.Controls.Add(label_fax);
            panel_contactDetails.Controls.Add(label_website);
            panel_contactDetails.Controls.Add(label_address);
            panel_contactDetails.Controls.Add(label_address2);
            panel_contactDetails.Controls.Add(label_address3);
            panel_contactDetails.Controls.Add(label_zipCode);
            panel_contactDetails.Controls.Add(label_city);
            panel_contactDetails.Controls.Add(label_state);
            panel_contactDetails.Controls.Add(label_email);
            panel_contactDetails.Controls.Add(comboBox_phoneNo);
            panel_contactDetails.Controls.Add(comboBox_faxNo);
            panel_contactDetails.Controls.Add(comboBox_email);
            panel_contactDetails.Controls.Add(comboBox_website);
            panel_contactDetails.Controls.Add(comboBox_address);
            panel_contactDetails.Controls.Add(comboBox_address2);
            panel_contactDetails.Controls.Add(comboBox_address3);
            panel_contactDetails.Controls.Add(comboBox_zipCode);
            panel_contactDetails.Controls.Add(comboBox_city);
            panel_contactDetails.Controls.Add(comboBox_state);
            panel_contactDetails.Location = new System.Drawing.Point(3, 412);
            panel_contactDetails.Margin = new Padding(3, 4, 3, 4);
            panel_contactDetails.MaximumSize = new System.Drawing.Size(487, 436);
            panel_contactDetails.MinimumSize = new System.Drawing.Size(487, 0);
            panel_contactDetails.Name = "panel_contactDetails";
            panel_contactDetails.Size = new System.Drawing.Size(487, 436);
            panel_contactDetails.TabIndex = 1;
            // 
            // label_phone
            // 
            label_phone.AutoSize = true;
            label_phone.Location = new System.Drawing.Point(11, 20);
            label_phone.Name = "label_phone";
            label_phone.Size = new System.Drawing.Size(87, 23);
            label_phone.TabIndex = 1;
            label_phone.Text = "Phone No";
            // 
            // label_fax
            // 
            label_fax.AutoSize = true;
            label_fax.Location = new System.Drawing.Point(11, 62);
            label_fax.Name = "label_fax";
            label_fax.Size = new System.Drawing.Size(64, 23);
            label_fax.TabIndex = 1;
            label_fax.Text = "Fax No";
            // 
            // label_website
            // 
            label_website.AutoSize = true;
            label_website.Location = new System.Drawing.Point(11, 144);
            label_website.Name = "label_website";
            label_website.Size = new System.Drawing.Size(71, 23);
            label_website.TabIndex = 1;
            label_website.Text = "Website";
            // 
            // label_address
            // 
            label_address.AutoSize = true;
            label_address.Location = new System.Drawing.Point(11, 186);
            label_address.Name = "label_address";
            label_address.Size = new System.Drawing.Size(70, 23);
            label_address.TabIndex = 1;
            label_address.Text = "Address";
            // 
            // label_address2
            // 
            label_address2.AutoSize = true;
            label_address2.Location = new System.Drawing.Point(11, 226);
            label_address2.Name = "label_address2";
            label_address2.Size = new System.Drawing.Size(84, 23);
            label_address2.TabIndex = 1;
            label_address2.Text = "Address 2";
            // 
            // label_address3
            // 
            label_address3.AutoSize = true;
            label_address3.Location = new System.Drawing.Point(11, 268);
            label_address3.Name = "label_address3";
            label_address3.Size = new System.Drawing.Size(84, 23);
            label_address3.TabIndex = 1;
            label_address3.Text = "Address 3";
            // 
            // label_zipCode
            // 
            label_zipCode.AutoSize = true;
            label_zipCode.Location = new System.Drawing.Point(11, 310);
            label_zipCode.Name = "label_zipCode";
            label_zipCode.Size = new System.Drawing.Size(79, 23);
            label_zipCode.TabIndex = 1;
            label_zipCode.Text = "Zip Code";
            // 
            // label_city
            // 
            label_city.AutoSize = true;
            label_city.Location = new System.Drawing.Point(11, 350);
            label_city.Name = "label_city";
            label_city.Size = new System.Drawing.Size(40, 23);
            label_city.TabIndex = 1;
            label_city.Text = "City";
            // 
            // label_state
            // 
            label_state.AutoSize = true;
            label_state.Location = new System.Drawing.Point(11, 392);
            label_state.Name = "label_state";
            label_state.Size = new System.Drawing.Size(49, 23);
            label_state.TabIndex = 1;
            label_state.Text = "State";
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.Location = new System.Drawing.Point(11, 102);
            label_email.Name = "label_email";
            label_email.Size = new System.Drawing.Size(51, 23);
            label_email.TabIndex = 1;
            label_email.Text = "Email";
            // 
            // comboBox_phoneNo
            // 
            comboBox_phoneNo.FormattingEnabled = true;
            comboBox_phoneNo.Location = new System.Drawing.Point(137, 16);
            comboBox_phoneNo.Margin = new Padding(3, 4, 3, 4);
            comboBox_phoneNo.Name = "comboBox_phoneNo";
            comboBox_phoneNo.Size = new System.Drawing.Size(151, 29);
            comboBox_phoneNo.TabIndex = 3;
            // 
            // comboBox_faxNo
            // 
            comboBox_faxNo.FormattingEnabled = true;
            comboBox_faxNo.Location = new System.Drawing.Point(137, 58);
            comboBox_faxNo.Margin = new Padding(3, 4, 3, 4);
            comboBox_faxNo.Name = "comboBox_faxNo";
            comboBox_faxNo.Size = new System.Drawing.Size(151, 29);
            comboBox_faxNo.TabIndex = 3;
            // 
            // comboBox_email
            // 
            comboBox_email.FormattingEnabled = true;
            comboBox_email.Location = new System.Drawing.Point(137, 98);
            comboBox_email.Margin = new Padding(3, 4, 3, 4);
            comboBox_email.Name = "comboBox_email";
            comboBox_email.Size = new System.Drawing.Size(151, 29);
            comboBox_email.TabIndex = 3;
            // 
            // comboBox_website
            // 
            comboBox_website.FormattingEnabled = true;
            comboBox_website.Location = new System.Drawing.Point(137, 140);
            comboBox_website.Margin = new Padding(3, 4, 3, 4);
            comboBox_website.Name = "comboBox_website";
            comboBox_website.Size = new System.Drawing.Size(151, 29);
            comboBox_website.TabIndex = 3;
            // 
            // comboBox_address
            // 
            comboBox_address.FormattingEnabled = true;
            comboBox_address.Location = new System.Drawing.Point(137, 182);
            comboBox_address.Margin = new Padding(3, 4, 3, 4);
            comboBox_address.Name = "comboBox_address";
            comboBox_address.Size = new System.Drawing.Size(151, 29);
            comboBox_address.TabIndex = 3;
            // 
            // comboBox_address2
            // 
            comboBox_address2.FormattingEnabled = true;
            comboBox_address2.Location = new System.Drawing.Point(137, 222);
            comboBox_address2.Margin = new Padding(3, 4, 3, 4);
            comboBox_address2.Name = "comboBox_address2";
            comboBox_address2.Size = new System.Drawing.Size(151, 29);
            comboBox_address2.TabIndex = 3;
            // 
            // comboBox_address3
            // 
            comboBox_address3.FormattingEnabled = true;
            comboBox_address3.Location = new System.Drawing.Point(137, 264);
            comboBox_address3.Margin = new Padding(3, 4, 3, 4);
            comboBox_address3.Name = "comboBox_address3";
            comboBox_address3.Size = new System.Drawing.Size(151, 29);
            comboBox_address3.TabIndex = 3;
            // 
            // comboBox_zipCode
            // 
            comboBox_zipCode.FormattingEnabled = true;
            comboBox_zipCode.Location = new System.Drawing.Point(137, 306);
            comboBox_zipCode.Margin = new Padding(3, 4, 3, 4);
            comboBox_zipCode.Name = "comboBox_zipCode";
            comboBox_zipCode.Size = new System.Drawing.Size(151, 29);
            comboBox_zipCode.TabIndex = 3;
            // 
            // comboBox_city
            // 
            comboBox_city.FormattingEnabled = true;
            comboBox_city.Location = new System.Drawing.Point(137, 346);
            comboBox_city.Margin = new Padding(3, 4, 3, 4);
            comboBox_city.Name = "comboBox_city";
            comboBox_city.Size = new System.Drawing.Size(151, 29);
            comboBox_city.TabIndex = 3;
            // 
            // comboBox_state
            // 
            comboBox_state.FormattingEnabled = true;
            comboBox_state.Location = new System.Drawing.Point(137, 388);
            comboBox_state.Margin = new Padding(3, 4, 3, 4);
            comboBox_state.Name = "comboBox_state";
            comboBox_state.Size = new System.Drawing.Size(151, 29);
            comboBox_state.TabIndex = 3;
            // 
            // panel_invoiceAddressButton
            // 
            panel_invoiceAddressButton.Controls.Add(label_invoiceAddress);
            panel_invoiceAddressButton.Controls.Add(button_invoiceAddress);
            panel_invoiceAddressButton.Location = new System.Drawing.Point(3, 856);
            panel_invoiceAddressButton.Margin = new Padding(3, 4, 3, 4);
            panel_invoiceAddressButton.Name = "panel_invoiceAddressButton";
            panel_invoiceAddressButton.Size = new System.Drawing.Size(487, 42);
            panel_invoiceAddressButton.TabIndex = 2;
            // 
            // label_invoiceAddress
            // 
            label_invoiceAddress.AutoSize = true;
            label_invoiceAddress.ForeColor = System.Drawing.Color.Black;
            label_invoiceAddress.Location = new System.Drawing.Point(51, 10);
            label_invoiceAddress.Name = "label_invoiceAddress";
            label_invoiceAddress.Size = new System.Drawing.Size(130, 23);
            label_invoiceAddress.TabIndex = 1;
            label_invoiceAddress.Text = "Invoice Address";
            // 
            // button_invoiceAddress
            // 
            button_invoiceAddress.BackColor = System.Drawing.Color.White;
            button_invoiceAddress.BackgroundImageLayout = ImageLayout.Stretch;
            button_invoiceAddress.Cursor = Cursors.Hand;
            button_invoiceAddress.FlatAppearance.BorderSize = 0;
            button_invoiceAddress.FlatStyle = FlatStyle.Flat;
            button_invoiceAddress.Location = new System.Drawing.Point(10, 2);
            button_invoiceAddress.Margin = new Padding(3, 4, 3, 4);
            button_invoiceAddress.Name = "button_invoiceAddress";
            button_invoiceAddress.Size = new System.Drawing.Size(34, 40);
            button_invoiceAddress.TabIndex = 0;
            button_invoiceAddress.UseVisualStyleBackColor = false;
            button_invoiceAddress.Click += button_expand_Click;
            // 
            // panel_invoiceAddress
            // 
            panel_invoiceAddress.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            panel_invoiceAddress.Controls.Add(checkBox_defaultInvoicingAddressCountryISO);
            panel_invoiceAddress.Controls.Add(label_useInvoicingAddress);
            panel_invoiceAddress.Controls.Add(label_invoicingAddress);
            panel_invoiceAddress.Controls.Add(label_invoicingAddressCity);
            panel_invoiceAddress.Controls.Add(label_invoicingAddressZipCode);
            panel_invoiceAddress.Controls.Add(label_invoicingAddress2);
            panel_invoiceAddress.Controls.Add(label_invoicingAddress3);
            panel_invoiceAddress.Controls.Add(label_invoicingAddressState);
            panel_invoiceAddress.Controls.Add(label_invoicingAddressCountryID);
            panel_invoiceAddress.Controls.Add(comboBox_useInvoicingAddress);
            panel_invoiceAddress.Controls.Add(comboBox_invoicingAddress);
            panel_invoiceAddress.Controls.Add(comboBox_invoicingAddress2);
            panel_invoiceAddress.Controls.Add(comboBox_invoicingAddress3);
            panel_invoiceAddress.Controls.Add(comboBox_invoicingAddressZipCode);
            panel_invoiceAddress.Controls.Add(comboBox_invoicingAddressCity);
            panel_invoiceAddress.Controls.Add(comboBox_invoicingAddressState);
            panel_invoiceAddress.Controls.Add(comboBox_invoicingAddressCountryISO);
            panel_invoiceAddress.Location = new System.Drawing.Point(3, 906);
            panel_invoiceAddress.Margin = new Padding(3, 4, 3, 4);
            panel_invoiceAddress.MaximumSize = new System.Drawing.Size(487, 354);
            panel_invoiceAddress.MinimumSize = new System.Drawing.Size(487, 0);
            panel_invoiceAddress.Name = "panel_invoiceAddress";
            panel_invoiceAddress.Size = new System.Drawing.Size(487, 354);
            panel_invoiceAddress.TabIndex = 3;
            // 
            // checkBox_defaultInvoicingAddressCountryISO
            // 
            checkBox_defaultInvoicingAddressCountryISO.AutoSize = true;
            checkBox_defaultInvoicingAddressCountryISO.Location = new System.Drawing.Point(390, 308);
            checkBox_defaultInvoicingAddressCountryISO.Margin = new Padding(3, 4, 3, 4);
            checkBox_defaultInvoicingAddressCountryISO.Name = "checkBox_defaultInvoicingAddressCountryISO";
            checkBox_defaultInvoicingAddressCountryISO.Size = new System.Drawing.Size(88, 27);
            checkBox_defaultInvoicingAddressCountryISO.TabIndex = 6;
            checkBox_defaultInvoicingAddressCountryISO.Text = "Default";
            checkBox_defaultInvoicingAddressCountryISO.UseVisualStyleBackColor = true;
            checkBox_defaultInvoicingAddressCountryISO.CheckedChanged += checkBox_defaultInvoiceAddressCountryISO_CheckedChanged;
            // 
            // label_useInvoicingAddress
            // 
            label_useInvoicingAddress.AutoSize = true;
            label_useInvoicingAddress.Location = new System.Drawing.Point(11, 20);
            label_useInvoicingAddress.Name = "label_useInvoicingAddress";
            label_useInvoicingAddress.Size = new System.Drawing.Size(178, 23);
            label_useInvoicingAddress.TabIndex = 1;
            label_useInvoicingAddress.Text = "Use Invoicing Address";
            // 
            // label_invoicingAddress
            // 
            label_invoicingAddress.AutoSize = true;
            label_invoicingAddress.Location = new System.Drawing.Point(11, 62);
            label_invoicingAddress.Name = "label_invoicingAddress";
            label_invoicingAddress.Size = new System.Drawing.Size(145, 23);
            label_invoicingAddress.TabIndex = 1;
            label_invoicingAddress.Text = "Invoicing Address";
            // 
            // label_invoicingAddressCity
            // 
            label_invoicingAddressCity.AutoSize = true;
            label_invoicingAddressCity.Location = new System.Drawing.Point(11, 226);
            label_invoicingAddressCity.Name = "label_invoicingAddressCity";
            label_invoicingAddressCity.Size = new System.Drawing.Size(180, 23);
            label_invoicingAddressCity.TabIndex = 1;
            label_invoicingAddressCity.Text = "Invoicing Address City";
            // 
            // label_invoicingAddressZipCode
            // 
            label_invoicingAddressZipCode.AutoSize = true;
            label_invoicingAddressZipCode.Location = new System.Drawing.Point(11, 186);
            label_invoicingAddressZipCode.Name = "label_invoicingAddressZipCode";
            label_invoicingAddressZipCode.Size = new System.Drawing.Size(219, 23);
            label_invoicingAddressZipCode.TabIndex = 1;
            label_invoicingAddressZipCode.Text = "Invoicing Address Zip Code";
            // 
            // label_invoicingAddress2
            // 
            label_invoicingAddress2.AutoSize = true;
            label_invoicingAddress2.Location = new System.Drawing.Point(11, 102);
            label_invoicingAddress2.Name = "label_invoicingAddress2";
            label_invoicingAddress2.Size = new System.Drawing.Size(159, 23);
            label_invoicingAddress2.TabIndex = 1;
            label_invoicingAddress2.Text = "Invoicing Address 2";
            // 
            // label_invoicingAddress3
            // 
            label_invoicingAddress3.AutoSize = true;
            label_invoicingAddress3.Location = new System.Drawing.Point(11, 144);
            label_invoicingAddress3.Name = "label_invoicingAddress3";
            label_invoicingAddress3.Size = new System.Drawing.Size(159, 23);
            label_invoicingAddress3.TabIndex = 1;
            label_invoicingAddress3.Text = "Invoicing Address 3";
            // 
            // label_invoicingAddressState
            // 
            label_invoicingAddressState.AutoSize = true;
            label_invoicingAddressState.Location = new System.Drawing.Point(11, 268);
            label_invoicingAddressState.Name = "label_invoicingAddressState";
            label_invoicingAddressState.Size = new System.Drawing.Size(189, 23);
            label_invoicingAddressState.TabIndex = 1;
            label_invoicingAddressState.Text = "Invoicing Address State";
            // 
            // label_invoicingAddressCountryID
            // 
            label_invoicingAddressCountryID.AutoSize = true;
            label_invoicingAddressCountryID.Location = new System.Drawing.Point(11, 310);
            label_invoicingAddressCountryID.Name = "label_invoicingAddressCountryID";
            label_invoicingAddressCountryID.Size = new System.Drawing.Size(235, 23);
            label_invoicingAddressCountryID.TabIndex = 5;
            label_invoicingAddressCountryID.Text = "Invoicing Address Country ID";
            // 
            // comboBox_useInvoicingAddress
            // 
            comboBox_useInvoicingAddress.FormattingEnabled = true;
            comboBox_useInvoicingAddress.Location = new System.Drawing.Point(231, 16);
            comboBox_useInvoicingAddress.Margin = new Padding(3, 4, 3, 4);
            comboBox_useInvoicingAddress.Name = "comboBox_useInvoicingAddress";
            comboBox_useInvoicingAddress.Size = new System.Drawing.Size(151, 29);
            comboBox_useInvoicingAddress.TabIndex = 3;
            // 
            // comboBox_invoicingAddress
            // 
            comboBox_invoicingAddress.FormattingEnabled = true;
            comboBox_invoicingAddress.Location = new System.Drawing.Point(231, 58);
            comboBox_invoicingAddress.Margin = new Padding(3, 4, 3, 4);
            comboBox_invoicingAddress.Name = "comboBox_invoicingAddress";
            comboBox_invoicingAddress.Size = new System.Drawing.Size(151, 29);
            comboBox_invoicingAddress.TabIndex = 3;
            // 
            // comboBox_invoicingAddress2
            // 
            comboBox_invoicingAddress2.FormattingEnabled = true;
            comboBox_invoicingAddress2.Location = new System.Drawing.Point(231, 98);
            comboBox_invoicingAddress2.Margin = new Padding(3, 4, 3, 4);
            comboBox_invoicingAddress2.Name = "comboBox_invoicingAddress2";
            comboBox_invoicingAddress2.Size = new System.Drawing.Size(151, 29);
            comboBox_invoicingAddress2.TabIndex = 3;
            // 
            // comboBox_invoicingAddress3
            // 
            comboBox_invoicingAddress3.FormattingEnabled = true;
            comboBox_invoicingAddress3.Location = new System.Drawing.Point(231, 140);
            comboBox_invoicingAddress3.Margin = new Padding(3, 4, 3, 4);
            comboBox_invoicingAddress3.Name = "comboBox_invoicingAddress3";
            comboBox_invoicingAddress3.Size = new System.Drawing.Size(151, 29);
            comboBox_invoicingAddress3.TabIndex = 3;
            // 
            // comboBox_invoicingAddressZipCode
            // 
            comboBox_invoicingAddressZipCode.FormattingEnabled = true;
            comboBox_invoicingAddressZipCode.Location = new System.Drawing.Point(231, 182);
            comboBox_invoicingAddressZipCode.Margin = new Padding(3, 4, 3, 4);
            comboBox_invoicingAddressZipCode.Name = "comboBox_invoicingAddressZipCode";
            comboBox_invoicingAddressZipCode.Size = new System.Drawing.Size(151, 29);
            comboBox_invoicingAddressZipCode.TabIndex = 3;
            // 
            // comboBox_invoicingAddressCity
            // 
            comboBox_invoicingAddressCity.FormattingEnabled = true;
            comboBox_invoicingAddressCity.Location = new System.Drawing.Point(231, 222);
            comboBox_invoicingAddressCity.Margin = new Padding(3, 4, 3, 4);
            comboBox_invoicingAddressCity.Name = "comboBox_invoicingAddressCity";
            comboBox_invoicingAddressCity.Size = new System.Drawing.Size(151, 29);
            comboBox_invoicingAddressCity.TabIndex = 3;
            // 
            // comboBox_invoicingAddressState
            // 
            comboBox_invoicingAddressState.FormattingEnabled = true;
            comboBox_invoicingAddressState.Location = new System.Drawing.Point(231, 264);
            comboBox_invoicingAddressState.Margin = new Padding(3, 4, 3, 4);
            comboBox_invoicingAddressState.Name = "comboBox_invoicingAddressState";
            comboBox_invoicingAddressState.Size = new System.Drawing.Size(151, 29);
            comboBox_invoicingAddressState.TabIndex = 3;
            // 
            // comboBox_invoicingAddressCountryISO
            // 
            comboBox_invoicingAddressCountryISO.FormattingEnabled = true;
            comboBox_invoicingAddressCountryISO.Location = new System.Drawing.Point(231, 306);
            comboBox_invoicingAddressCountryISO.Margin = new Padding(3, 4, 3, 4);
            comboBox_invoicingAddressCountryISO.Name = "comboBox_invoicingAddressCountryISO";
            comboBox_invoicingAddressCountryISO.Size = new System.Drawing.Size(151, 29);
            comboBox_invoicingAddressCountryISO.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(label_financeCompanyInfo);
            panel2.Controls.Add(button_financeCompanyInfo);
            panel2.Location = new System.Drawing.Point(3, 1268);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(487, 42);
            panel2.TabIndex = 4;
            // 
            // label_financeCompanyInfo
            // 
            label_financeCompanyInfo.AutoSize = true;
            label_financeCompanyInfo.ForeColor = System.Drawing.Color.Black;
            label_financeCompanyInfo.Location = new System.Drawing.Point(51, 10);
            label_financeCompanyInfo.Name = "label_financeCompanyInfo";
            label_financeCompanyInfo.Size = new System.Drawing.Size(196, 23);
            label_financeCompanyInfo.TabIndex = 1;
            label_financeCompanyInfo.Text = "Finance - Company Info";
            // 
            // button_financeCompanyInfo
            // 
            button_financeCompanyInfo.BackColor = System.Drawing.Color.White;
            button_financeCompanyInfo.BackgroundImageLayout = ImageLayout.Stretch;
            button_financeCompanyInfo.Cursor = Cursors.Hand;
            button_financeCompanyInfo.FlatAppearance.BorderSize = 0;
            button_financeCompanyInfo.FlatStyle = FlatStyle.Flat;
            button_financeCompanyInfo.Location = new System.Drawing.Point(10, 2);
            button_financeCompanyInfo.Margin = new Padding(3, 4, 3, 4);
            button_financeCompanyInfo.Name = "button_financeCompanyInfo";
            button_financeCompanyInfo.Size = new System.Drawing.Size(34, 40);
            button_financeCompanyInfo.TabIndex = 0;
            button_financeCompanyInfo.UseVisualStyleBackColor = false;
            button_financeCompanyInfo.Click += button_expand_Click;
            // 
            // panel_financeCompanyInfo
            // 
            panel_financeCompanyInfo.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            panel_financeCompanyInfo.Controls.Add(label_organizationNo);
            panel_financeCompanyInfo.Controls.Add(label_vatNo);
            panel_financeCompanyInfo.Controls.Add(comboBox_organizationNo);
            panel_financeCompanyInfo.Controls.Add(comboBox_VATNo);
            panel_financeCompanyInfo.Controls.Add(comboBox_eanNo);
            panel_financeCompanyInfo.Controls.Add(comboBox_useEanNo);
            panel_financeCompanyInfo.Controls.Add(label_eanNo);
            panel_financeCompanyInfo.Controls.Add(label_useEanNo);
            panel_financeCompanyInfo.Location = new System.Drawing.Point(3, 1318);
            panel_financeCompanyInfo.Margin = new Padding(3, 4, 3, 4);
            panel_financeCompanyInfo.MaximumSize = new System.Drawing.Size(487, 188);
            panel_financeCompanyInfo.MinimumSize = new System.Drawing.Size(487, 0);
            panel_financeCompanyInfo.Name = "panel_financeCompanyInfo";
            panel_financeCompanyInfo.Size = new System.Drawing.Size(487, 188);
            panel_financeCompanyInfo.TabIndex = 5;
            // 
            // label_organizationNo
            // 
            label_organizationNo.AutoSize = true;
            label_organizationNo.Location = new System.Drawing.Point(11, 20);
            label_organizationNo.Name = "label_organizationNo";
            label_organizationNo.Size = new System.Drawing.Size(137, 23);
            label_organizationNo.TabIndex = 1;
            label_organizationNo.Text = "Organization No";
            // 
            // label_vatNo
            // 
            label_vatNo.AutoSize = true;
            label_vatNo.Location = new System.Drawing.Point(11, 62);
            label_vatNo.Name = "label_vatNo";
            label_vatNo.Size = new System.Drawing.Size(67, 23);
            label_vatNo.TabIndex = 1;
            label_vatNo.Text = "VAT No";
            // 
            // comboBox_organizationNo
            // 
            comboBox_organizationNo.FormattingEnabled = true;
            comboBox_organizationNo.Location = new System.Drawing.Point(154, 16);
            comboBox_organizationNo.Margin = new Padding(3, 4, 3, 4);
            comboBox_organizationNo.Name = "comboBox_organizationNo";
            comboBox_organizationNo.Size = new System.Drawing.Size(151, 29);
            comboBox_organizationNo.TabIndex = 3;
            // 
            // comboBox_VATNo
            // 
            comboBox_VATNo.FormattingEnabled = true;
            comboBox_VATNo.Location = new System.Drawing.Point(154, 58);
            comboBox_VATNo.Margin = new Padding(3, 4, 3, 4);
            comboBox_VATNo.Name = "comboBox_VATNo";
            comboBox_VATNo.Size = new System.Drawing.Size(151, 29);
            comboBox_VATNo.TabIndex = 3;
            // 
            // comboBox_eanNo
            // 
            comboBox_eanNo.FormattingEnabled = true;
            comboBox_eanNo.Location = new System.Drawing.Point(154, 140);
            comboBox_eanNo.Margin = new Padding(3, 4, 3, 4);
            comboBox_eanNo.Name = "comboBox_eanNo";
            comboBox_eanNo.Size = new System.Drawing.Size(151, 29);
            comboBox_eanNo.TabIndex = 3;
            // 
            // comboBox_useEanNo
            // 
            comboBox_useEanNo.FormattingEnabled = true;
            comboBox_useEanNo.Location = new System.Drawing.Point(154, 98);
            comboBox_useEanNo.Margin = new Padding(3, 4, 3, 4);
            comboBox_useEanNo.Name = "comboBox_useEanNo";
            comboBox_useEanNo.Size = new System.Drawing.Size(151, 29);
            comboBox_useEanNo.TabIndex = 3;
            // 
            // label_eanNo
            // 
            label_eanNo.AutoSize = true;
            label_eanNo.Location = new System.Drawing.Point(11, 144);
            label_eanNo.Name = "label_eanNo";
            label_eanNo.Size = new System.Drawing.Size(66, 23);
            label_eanNo.TabIndex = 1;
            label_eanNo.Text = "Ean No";
            // 
            // label_useEanNo
            // 
            label_useEanNo.AutoSize = true;
            label_useEanNo.Location = new System.Drawing.Point(11, 102);
            label_useEanNo.Name = "label_useEanNo";
            label_useEanNo.Size = new System.Drawing.Size(99, 23);
            label_useEanNo.TabIndex = 1;
            label_useEanNo.Text = "Use Ean No";
            // 
            // panel_defaultInvoiceSettingsButton
            // 
            panel_defaultInvoiceSettingsButton.Controls.Add(label_defaultInvoiceSettings);
            panel_defaultInvoiceSettingsButton.Controls.Add(button_defaultInvoiceSettings);
            panel_defaultInvoiceSettingsButton.Location = new System.Drawing.Point(3, 1514);
            panel_defaultInvoiceSettingsButton.Margin = new Padding(3, 4, 3, 4);
            panel_defaultInvoiceSettingsButton.Name = "panel_defaultInvoiceSettingsButton";
            panel_defaultInvoiceSettingsButton.Size = new System.Drawing.Size(487, 42);
            panel_defaultInvoiceSettingsButton.TabIndex = 6;
            // 
            // label_defaultInvoiceSettings
            // 
            label_defaultInvoiceSettings.AutoSize = true;
            label_defaultInvoiceSettings.ForeColor = System.Drawing.Color.Black;
            label_defaultInvoiceSettings.Location = new System.Drawing.Point(51, 10);
            label_defaultInvoiceSettings.Name = "label_defaultInvoiceSettings";
            label_defaultInvoiceSettings.Size = new System.Drawing.Size(268, 23);
            label_defaultInvoiceSettings.TabIndex = 1;
            label_defaultInvoiceSettings.Text = "Finance - Default Invoice Settings";
            // 
            // button_defaultInvoiceSettings
            // 
            button_defaultInvoiceSettings.BackColor = System.Drawing.Color.White;
            button_defaultInvoiceSettings.BackgroundImageLayout = ImageLayout.Stretch;
            button_defaultInvoiceSettings.Cursor = Cursors.Hand;
            button_defaultInvoiceSettings.FlatAppearance.BorderSize = 0;
            button_defaultInvoiceSettings.FlatStyle = FlatStyle.Flat;
            button_defaultInvoiceSettings.Location = new System.Drawing.Point(10, 2);
            button_defaultInvoiceSettings.Margin = new Padding(3, 4, 3, 4);
            button_defaultInvoiceSettings.Name = "button_defaultInvoiceSettings";
            button_defaultInvoiceSettings.Size = new System.Drawing.Size(34, 40);
            button_defaultInvoiceSettings.TabIndex = 0;
            button_defaultInvoiceSettings.UseVisualStyleBackColor = false;
            button_defaultInvoiceSettings.Click += button_expand_Click;
            // 
            // panel_defaultInvoiceSettings
            // 
            panel_defaultInvoiceSettings.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            panel_defaultInvoiceSettings.Controls.Add(checkBox_defaultVATPercentage);
            panel_defaultInvoiceSettings.Controls.Add(checkBox_defaultPaymentTerm);
            panel_defaultInvoiceSettings.Controls.Add(label_paymentTerm);
            panel_defaultInvoiceSettings.Controls.Add(label_discountPercentage);
            panel_defaultInvoiceSettings.Controls.Add(label_calculateVAT);
            panel_defaultInvoiceSettings.Controls.Add(comboBox_VATPercentage);
            panel_defaultInvoiceSettings.Controls.Add(label_vatPercentage);
            panel_defaultInvoiceSettings.Controls.Add(comboBox_calculateVAT);
            panel_defaultInvoiceSettings.Controls.Add(comboBox_discountPercentage);
            panel_defaultInvoiceSettings.Controls.Add(comboBox_paymentTerm);
            panel_defaultInvoiceSettings.Location = new System.Drawing.Point(3, 1564);
            panel_defaultInvoiceSettings.Margin = new Padding(3, 4, 3, 4);
            panel_defaultInvoiceSettings.MaximumSize = new System.Drawing.Size(487, 354);
            panel_defaultInvoiceSettings.MinimumSize = new System.Drawing.Size(487, 0);
            panel_defaultInvoiceSettings.Name = "panel_defaultInvoiceSettings";
            panel_defaultInvoiceSettings.Size = new System.Drawing.Size(487, 202);
            panel_defaultInvoiceSettings.TabIndex = 7;
            // 
            // checkBox_defaultVATPercentage
            // 
            checkBox_defaultVATPercentage.AutoSize = true;
            checkBox_defaultVATPercentage.Location = new System.Drawing.Point(378, 143);
            checkBox_defaultVATPercentage.Margin = new Padding(3, 4, 3, 4);
            checkBox_defaultVATPercentage.Name = "checkBox_defaultVATPercentage";
            checkBox_defaultVATPercentage.Size = new System.Drawing.Size(88, 27);
            checkBox_defaultVATPercentage.TabIndex = 8;
            checkBox_defaultVATPercentage.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultVATPercentage, "Set default values for all rows of a particular column field");
            checkBox_defaultVATPercentage.UseVisualStyleBackColor = true;
            checkBox_defaultVATPercentage.CheckedChanged += checkBox_defaultVATPercentage_CheckedChanged;
            // 
            // checkBox_defaultPaymentTerm
            // 
            checkBox_defaultPaymentTerm.AutoSize = true;
            checkBox_defaultPaymentTerm.Location = new System.Drawing.Point(378, 18);
            checkBox_defaultPaymentTerm.Margin = new Padding(3, 4, 3, 4);
            checkBox_defaultPaymentTerm.Name = "checkBox_defaultPaymentTerm";
            checkBox_defaultPaymentTerm.Size = new System.Drawing.Size(88, 27);
            checkBox_defaultPaymentTerm.TabIndex = 8;
            checkBox_defaultPaymentTerm.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultPaymentTerm, "Set default values for all rows of a particular column field");
            checkBox_defaultPaymentTerm.UseVisualStyleBackColor = true;
            checkBox_defaultPaymentTerm.CheckedChanged += checkBox_defaultPaymentTerm_CheckedChanged;
            // 
            // label_paymentTerm
            // 
            label_paymentTerm.AutoSize = true;
            label_paymentTerm.Location = new System.Drawing.Point(16, 19);
            label_paymentTerm.Name = "label_paymentTerm";
            label_paymentTerm.Size = new System.Drawing.Size(120, 23);
            label_paymentTerm.TabIndex = 1;
            label_paymentTerm.Text = "Payment Term";
            // 
            // label_discountPercentage
            // 
            label_discountPercentage.AutoSize = true;
            label_discountPercentage.Location = new System.Drawing.Point(16, 62);
            label_discountPercentage.Name = "label_discountPercentage";
            label_discountPercentage.Size = new System.Drawing.Size(167, 23);
            label_discountPercentage.TabIndex = 1;
            label_discountPercentage.Text = "Discount Percentage";
            // 
            // label_calculateVAT
            // 
            label_calculateVAT.AutoSize = true;
            label_calculateVAT.Location = new System.Drawing.Point(16, 103);
            label_calculateVAT.Name = "label_calculateVAT";
            label_calculateVAT.Size = new System.Drawing.Size(114, 23);
            label_calculateVAT.TabIndex = 1;
            label_calculateVAT.Text = "Calculate VAT";
            // 
            // comboBox_VATPercentage
            // 
            comboBox_VATPercentage.FormattingEnabled = true;
            comboBox_VATPercentage.Location = new System.Drawing.Point(198, 141);
            comboBox_VATPercentage.Margin = new Padding(3, 4, 3, 4);
            comboBox_VATPercentage.Name = "comboBox_VATPercentage";
            comboBox_VATPercentage.Size = new System.Drawing.Size(173, 29);
            comboBox_VATPercentage.TabIndex = 3;
            // 
            // label_vatPercentage
            // 
            label_vatPercentage.AutoSize = true;
            label_vatPercentage.Location = new System.Drawing.Point(16, 145);
            label_vatPercentage.Name = "label_vatPercentage";
            label_vatPercentage.Size = new System.Drawing.Size(129, 23);
            label_vatPercentage.TabIndex = 1;
            label_vatPercentage.Text = "VAT Percentage";
            // 
            // comboBox_calculateVAT
            // 
            comboBox_calculateVAT.FormattingEnabled = true;
            comboBox_calculateVAT.Location = new System.Drawing.Point(198, 99);
            comboBox_calculateVAT.Margin = new Padding(3, 4, 3, 4);
            comboBox_calculateVAT.Name = "comboBox_calculateVAT";
            comboBox_calculateVAT.Size = new System.Drawing.Size(173, 29);
            comboBox_calculateVAT.TabIndex = 3;
            // 
            // comboBox_discountPercentage
            // 
            comboBox_discountPercentage.FormattingEnabled = true;
            comboBox_discountPercentage.Location = new System.Drawing.Point(198, 58);
            comboBox_discountPercentage.Margin = new Padding(3, 4, 3, 4);
            comboBox_discountPercentage.Name = "comboBox_discountPercentage";
            comboBox_discountPercentage.Size = new System.Drawing.Size(173, 29);
            comboBox_discountPercentage.TabIndex = 3;
            // 
            // comboBox_paymentTerm
            // 
            comboBox_paymentTerm.FormattingEnabled = true;
            comboBox_paymentTerm.Location = new System.Drawing.Point(198, 17);
            comboBox_paymentTerm.Margin = new Padding(3, 4, 3, 4);
            comboBox_paymentTerm.Name = "comboBox_paymentTerm";
            comboBox_paymentTerm.Size = new System.Drawing.Size(173, 29);
            comboBox_paymentTerm.TabIndex = 3;
            // 
            // panel_invoiceExternalCosts
            // 
            panel_invoiceExternalCosts.Controls.Add(label_invoiceExternalCosts);
            panel_invoiceExternalCosts.Controls.Add(button_invoiceExternalCosts);
            panel_invoiceExternalCosts.Location = new System.Drawing.Point(3, 1774);
            panel_invoiceExternalCosts.Margin = new Padding(3, 4, 3, 4);
            panel_invoiceExternalCosts.Name = "panel_invoiceExternalCosts";
            panel_invoiceExternalCosts.Size = new System.Drawing.Size(487, 42);
            panel_invoiceExternalCosts.TabIndex = 8;
            // 
            // label_invoiceExternalCosts
            // 
            label_invoiceExternalCosts.AutoSize = true;
            label_invoiceExternalCosts.ForeColor = System.Drawing.Color.Black;
            label_invoiceExternalCosts.Location = new System.Drawing.Point(51, 10);
            label_invoiceExternalCosts.Name = "label_invoiceExternalCosts";
            label_invoiceExternalCosts.Size = new System.Drawing.Size(317, 23);
            label_invoiceExternalCosts.TabIndex = 1;
            label_invoiceExternalCosts.Text = "Finance - Re-Invoicing of External Costs";
            // 
            // button_invoiceExternalCosts
            // 
            button_invoiceExternalCosts.BackColor = System.Drawing.Color.White;
            button_invoiceExternalCosts.BackgroundImageLayout = ImageLayout.Stretch;
            button_invoiceExternalCosts.Cursor = Cursors.Hand;
            button_invoiceExternalCosts.FlatAppearance.BorderSize = 0;
            button_invoiceExternalCosts.FlatStyle = FlatStyle.Flat;
            button_invoiceExternalCosts.Location = new System.Drawing.Point(10, 2);
            button_invoiceExternalCosts.Margin = new Padding(3, 4, 3, 4);
            button_invoiceExternalCosts.Name = "button_invoiceExternalCosts";
            button_invoiceExternalCosts.Size = new System.Drawing.Size(34, 40);
            button_invoiceExternalCosts.TabIndex = 0;
            button_invoiceExternalCosts.UseVisualStyleBackColor = false;
            button_invoiceExternalCosts.Click += button_expand_Click;
            // 
            // panel_incoiceExternalCosts
            // 
            panel_incoiceExternalCosts.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            panel_incoiceExternalCosts.Controls.Add(checkBox_defaultExpenseIsBillable);
            panel_incoiceExternalCosts.Controls.Add(checkBox_defaultMileageIsBillable);
            panel_incoiceExternalCosts.Controls.Add(label_defaultMileageDistance);
            panel_incoiceExternalCosts.Controls.Add(label_defaultDistIsMaxBillable);
            panel_incoiceExternalCosts.Controls.Add(label_expenseIsBillable);
            panel_incoiceExternalCosts.Controls.Add(label_mileageIsBillable);
            panel_incoiceExternalCosts.Controls.Add(comboBox_defaultDistIsMaxBillable);
            panel_incoiceExternalCosts.Controls.Add(comboBox_defaultMileageDistance);
            panel_incoiceExternalCosts.Controls.Add(comboBox_expenseIsBillable);
            panel_incoiceExternalCosts.Controls.Add(comboBox_mileageIsBillable);
            panel_incoiceExternalCosts.Location = new System.Drawing.Point(3, 1824);
            panel_incoiceExternalCosts.Margin = new Padding(3, 4, 3, 4);
            panel_incoiceExternalCosts.MaximumSize = new System.Drawing.Size(487, 188);
            panel_incoiceExternalCosts.MinimumSize = new System.Drawing.Size(487, 0);
            panel_incoiceExternalCosts.Name = "panel_incoiceExternalCosts";
            panel_incoiceExternalCosts.Size = new System.Drawing.Size(487, 188);
            panel_incoiceExternalCosts.TabIndex = 9;
            // 
            // checkBox_defaultExpenseIsBillable
            // 
            checkBox_defaultExpenseIsBillable.AutoSize = true;
            checkBox_defaultExpenseIsBillable.Location = new System.Drawing.Point(390, 62);
            checkBox_defaultExpenseIsBillable.Margin = new Padding(3, 4, 3, 4);
            checkBox_defaultExpenseIsBillable.Name = "checkBox_defaultExpenseIsBillable";
            checkBox_defaultExpenseIsBillable.Size = new System.Drawing.Size(88, 27);
            checkBox_defaultExpenseIsBillable.TabIndex = 5;
            checkBox_defaultExpenseIsBillable.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultExpenseIsBillable, "Set default values for all rows of a particular column field");
            checkBox_defaultExpenseIsBillable.UseVisualStyleBackColor = true;
            checkBox_defaultExpenseIsBillable.CheckedChanged += checkBox_defaultExpenseIsBillable_CheckedChanged;
            // 
            // checkBox_defaultMileageIsBillable
            // 
            checkBox_defaultMileageIsBillable.AutoSize = true;
            checkBox_defaultMileageIsBillable.Location = new System.Drawing.Point(390, 102);
            checkBox_defaultMileageIsBillable.Margin = new Padding(3, 4, 3, 4);
            checkBox_defaultMileageIsBillable.Name = "checkBox_defaultMileageIsBillable";
            checkBox_defaultMileageIsBillable.Size = new System.Drawing.Size(88, 27);
            checkBox_defaultMileageIsBillable.TabIndex = 4;
            checkBox_defaultMileageIsBillable.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultMileageIsBillable, "Set default values for all rows of a particular column field");
            checkBox_defaultMileageIsBillable.UseVisualStyleBackColor = true;
            checkBox_defaultMileageIsBillable.CheckedChanged += checkBox_defaultMileageIsBillable_CheckedChanged;
            // 
            // label_defaultMileageDistance
            // 
            label_defaultMileageDistance.AutoSize = true;
            label_defaultMileageDistance.Location = new System.Drawing.Point(11, 20);
            label_defaultMileageDistance.Name = "label_defaultMileageDistance";
            label_defaultMileageDistance.Size = new System.Drawing.Size(202, 23);
            label_defaultMileageDistance.TabIndex = 1;
            label_defaultMileageDistance.Text = "Default Mileage Distance";
            // 
            // label_defaultDistIsMaxBillable
            // 
            label_defaultDistIsMaxBillable.AutoSize = true;
            label_defaultDistIsMaxBillable.Location = new System.Drawing.Point(11, 144);
            label_defaultDistIsMaxBillable.Name = "label_defaultDistIsMaxBillable";
            label_defaultDistIsMaxBillable.Size = new System.Drawing.Size(215, 23);
            label_defaultDistIsMaxBillable.TabIndex = 1;
            label_defaultDistIsMaxBillable.Text = "Default Dist Is Max Billable";
            // 
            // label_expenseIsBillable
            // 
            label_expenseIsBillable.AutoSize = true;
            label_expenseIsBillable.Location = new System.Drawing.Point(11, 62);
            label_expenseIsBillable.Name = "label_expenseIsBillable";
            label_expenseIsBillable.Size = new System.Drawing.Size(149, 23);
            label_expenseIsBillable.TabIndex = 1;
            label_expenseIsBillable.Text = "Expense Is Billable";
            // 
            // label_mileageIsBillable
            // 
            label_mileageIsBillable.AutoSize = true;
            label_mileageIsBillable.Location = new System.Drawing.Point(11, 102);
            label_mileageIsBillable.Name = "label_mileageIsBillable";
            label_mileageIsBillable.Size = new System.Drawing.Size(147, 23);
            label_mileageIsBillable.TabIndex = 1;
            label_mileageIsBillable.Text = "Mileage Is Billable";
            // 
            // comboBox_defaultDistIsMaxBillable
            // 
            comboBox_defaultDistIsMaxBillable.FormattingEnabled = true;
            comboBox_defaultDistIsMaxBillable.Location = new System.Drawing.Point(213, 140);
            comboBox_defaultDistIsMaxBillable.Margin = new Padding(3, 4, 3, 4);
            comboBox_defaultDistIsMaxBillable.Name = "comboBox_defaultDistIsMaxBillable";
            comboBox_defaultDistIsMaxBillable.Size = new System.Drawing.Size(206, 29);
            comboBox_defaultDistIsMaxBillable.TabIndex = 3;
            // 
            // comboBox_defaultMileageDistance
            // 
            comboBox_defaultMileageDistance.FormattingEnabled = true;
            comboBox_defaultMileageDistance.Location = new System.Drawing.Point(213, 16);
            comboBox_defaultMileageDistance.Margin = new Padding(3, 4, 3, 4);
            comboBox_defaultMileageDistance.Name = "comboBox_defaultMileageDistance";
            comboBox_defaultMileageDistance.Size = new System.Drawing.Size(206, 29);
            comboBox_defaultMileageDistance.TabIndex = 3;
            // 
            // comboBox_expenseIsBillable
            // 
            comboBox_expenseIsBillable.FormattingEnabled = true;
            comboBox_expenseIsBillable.Location = new System.Drawing.Point(213, 58);
            comboBox_expenseIsBillable.Margin = new Padding(3, 4, 3, 4);
            comboBox_expenseIsBillable.Name = "comboBox_expenseIsBillable";
            comboBox_expenseIsBillable.Size = new System.Drawing.Size(170, 29);
            comboBox_expenseIsBillable.TabIndex = 3;
            // 
            // comboBox_mileageIsBillable
            // 
            comboBox_mileageIsBillable.FormattingEnabled = true;
            comboBox_mileageIsBillable.Location = new System.Drawing.Point(213, 98);
            comboBox_mileageIsBillable.Margin = new Padding(3, 4, 3, 4);
            comboBox_mileageIsBillable.Name = "comboBox_mileageIsBillable";
            comboBox_mileageIsBillable.Size = new System.Drawing.Size(170, 29);
            comboBox_mileageIsBillable.TabIndex = 3;
            // 
            // label_delimiter
            // 
            label_delimiter.AutoSize = true;
            label_delimiter.Location = new System.Drawing.Point(11, 100);
            label_delimiter.Name = "label_delimiter";
            label_delimiter.Size = new System.Drawing.Size(79, 23);
            label_delimiter.TabIndex = 1;
            label_delimiter.Text = "Delimiter";
            // 
            // comboBox_delimiter
            // 
            comboBox_delimiter.FormattingEnabled = true;
            comboBox_delimiter.Location = new System.Drawing.Point(94, 96);
            comboBox_delimiter.Margin = new Padding(3, 4, 3, 4);
            comboBox_delimiter.Name = "comboBox_delimiter";
            comboBox_delimiter.Size = new System.Drawing.Size(63, 29);
            comboBox_delimiter.TabIndex = 7;
            // 
            // groupBox_customerMandatoryFields
            // 
            groupBox_customerMandatoryFields.Controls.Add(checkBox_defaultCountryISO);
            groupBox_customerMandatoryFields.Controls.Add(checkBox_defaultCustomerStatus);
            groupBox_customerMandatoryFields.Controls.Add(checkBox_defaultCurrencyISO);
            groupBox_customerMandatoryFields.Controls.Add(label_countryISO);
            groupBox_customerMandatoryFields.Controls.Add(label_customerStatus);
            groupBox_customerMandatoryFields.Controls.Add(comboBox_countryISO);
            groupBox_customerMandatoryFields.Controls.Add(comboBox_customerStatus);
            groupBox_customerMandatoryFields.Controls.Add(label_currencyISO);
            groupBox_customerMandatoryFields.Controls.Add(comboBox_currencyISO);
            groupBox_customerMandatoryFields.Controls.Add(label_customerName);
            groupBox_customerMandatoryFields.Controls.Add(comboBox_customerName);
            groupBox_customerMandatoryFields.Location = new System.Drawing.Point(193, 100);
            groupBox_customerMandatoryFields.Margin = new Padding(3, 4, 3, 4);
            groupBox_customerMandatoryFields.Name = "groupBox_customerMandatoryFields";
            groupBox_customerMandatoryFields.Padding = new Padding(3, 4, 3, 4);
            groupBox_customerMandatoryFields.Size = new System.Drawing.Size(400, 220);
            groupBox_customerMandatoryFields.TabIndex = 5;
            groupBox_customerMandatoryFields.TabStop = false;
            groupBox_customerMandatoryFields.Text = "Mandatory";
            // 
            // checkBox_defaultCountryISO
            // 
            checkBox_defaultCountryISO.AutoSize = true;
            checkBox_defaultCountryISO.Location = new System.Drawing.Point(317, 164);
            checkBox_defaultCountryISO.Margin = new Padding(3, 4, 3, 4);
            checkBox_defaultCountryISO.Name = "checkBox_defaultCountryISO";
            checkBox_defaultCountryISO.Size = new System.Drawing.Size(88, 27);
            checkBox_defaultCountryISO.TabIndex = 8;
            checkBox_defaultCountryISO.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultCountryISO, "Set default values for all rows of a particular column field");
            checkBox_defaultCountryISO.UseVisualStyleBackColor = true;
            checkBox_defaultCountryISO.CheckedChanged += checkBox_defaultCountryISO_CheckedChanged;
            // 
            // checkBox_defaultCustomerStatus
            // 
            checkBox_defaultCustomerStatus.AutoSize = true;
            checkBox_defaultCustomerStatus.Location = new System.Drawing.Point(317, 122);
            checkBox_defaultCustomerStatus.Margin = new Padding(3, 4, 3, 4);
            checkBox_defaultCustomerStatus.Name = "checkBox_defaultCustomerStatus";
            checkBox_defaultCustomerStatus.Size = new System.Drawing.Size(88, 27);
            checkBox_defaultCustomerStatus.TabIndex = 8;
            checkBox_defaultCustomerStatus.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultCustomerStatus, "Set default values for all rows of a particular column field");
            checkBox_defaultCustomerStatus.UseVisualStyleBackColor = true;
            checkBox_defaultCustomerStatus.CheckedChanged += checkBox_defaultCustomerStatus_CheckedChanged;
            // 
            // checkBox_defaultCurrencyISO
            // 
            checkBox_defaultCurrencyISO.AutoSize = true;
            checkBox_defaultCurrencyISO.Location = new System.Drawing.Point(317, 84);
            checkBox_defaultCurrencyISO.Margin = new Padding(3, 4, 3, 4);
            checkBox_defaultCurrencyISO.Name = "checkBox_defaultCurrencyISO";
            checkBox_defaultCurrencyISO.Size = new System.Drawing.Size(88, 27);
            checkBox_defaultCurrencyISO.TabIndex = 8;
            checkBox_defaultCurrencyISO.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultCurrencyISO, "Set default values for all rows of a particular column field");
            checkBox_defaultCurrencyISO.UseVisualStyleBackColor = true;
            checkBox_defaultCurrencyISO.CheckedChanged += checkBox_defaultCurrencyISO_CheckedChanged;
            // 
            // label_countryISO
            // 
            label_countryISO.AutoSize = true;
            label_countryISO.Location = new System.Drawing.Point(7, 166);
            label_countryISO.Name = "label_countryISO";
            label_countryISO.Size = new System.Drawing.Size(105, 23);
            label_countryISO.TabIndex = 5;
            label_countryISO.Text = "Country ISO";
            // 
            // label_customerStatus
            // 
            label_customerStatus.AutoSize = true;
            label_customerStatus.Location = new System.Drawing.Point(6, 124);
            label_customerStatus.Name = "label_customerStatus";
            label_customerStatus.Size = new System.Drawing.Size(136, 23);
            label_customerStatus.TabIndex = 5;
            label_customerStatus.Text = "Customer Status";
            // 
            // comboBox_countryISO
            // 
            comboBox_countryISO.FormattingEnabled = true;
            comboBox_countryISO.Location = new System.Drawing.Point(158, 162);
            comboBox_countryISO.Margin = new Padding(3, 4, 3, 4);
            comboBox_countryISO.Name = "comboBox_countryISO";
            comboBox_countryISO.Size = new System.Drawing.Size(151, 29);
            comboBox_countryISO.TabIndex = 7;
            // 
            // comboBox_customerStatus
            // 
            comboBox_customerStatus.FormattingEnabled = true;
            comboBox_customerStatus.Location = new System.Drawing.Point(158, 120);
            comboBox_customerStatus.Margin = new Padding(3, 4, 3, 4);
            comboBox_customerStatus.Name = "comboBox_customerStatus";
            comboBox_customerStatus.Size = new System.Drawing.Size(151, 29);
            comboBox_customerStatus.TabIndex = 6;
            // 
            // label_currencyISO
            // 
            label_currencyISO.AutoSize = true;
            label_currencyISO.Location = new System.Drawing.Point(7, 82);
            label_currencyISO.Name = "label_currencyISO";
            label_currencyISO.Size = new System.Drawing.Size(111, 23);
            label_currencyISO.TabIndex = 5;
            label_currencyISO.Text = "Currency ISO";
            // 
            // comboBox_currencyISO
            // 
            comboBox_currencyISO.FormattingEnabled = true;
            comboBox_currencyISO.Location = new System.Drawing.Point(158, 78);
            comboBox_currencyISO.Margin = new Padding(3, 4, 3, 4);
            comboBox_currencyISO.Name = "comboBox_currencyISO";
            comboBox_currencyISO.Size = new System.Drawing.Size(151, 29);
            comboBox_currencyISO.TabIndex = 4;
            // 
            // label_customerName
            // 
            label_customerName.AutoSize = true;
            label_customerName.Location = new System.Drawing.Point(7, 42);
            label_customerName.Name = "label_customerName";
            label_customerName.Size = new System.Drawing.Size(135, 23);
            label_customerName.TabIndex = 1;
            label_customerName.Text = "Customer Name";
            // 
            // comboBox_customerName
            // 
            comboBox_customerName.FormattingEnabled = true;
            comboBox_customerName.Location = new System.Drawing.Point(158, 38);
            comboBox_customerName.Margin = new Padding(3, 4, 3, 4);
            comboBox_customerName.Name = "comboBox_customerName";
            comboBox_customerName.Size = new System.Drawing.Size(151, 29);
            comboBox_customerName.TabIndex = 3;
            // 
            // label_customerSetup
            // 
            label_customerSetup.AutoSize = true;
            label_customerSetup.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label_customerSetup.Location = new System.Drawing.Point(7, 22);
            label_customerSetup.Name = "label_customerSetup";
            label_customerSetup.Size = new System.Drawing.Size(327, 41);
            label_customerSetup.TabIndex = 0;
            label_customerSetup.Text = "Customer Data Import";
            // 
            // button_customerSelectFile
            // 
            button_customerSelectFile.BackColor = System.Drawing.Color.FromArgb(226, 43, 141);
            button_customerSelectFile.Cursor = Cursors.Hand;
            button_customerSelectFile.FlatAppearance.BorderSize = 0;
            button_customerSelectFile.FlatStyle = FlatStyle.Flat;
            button_customerSelectFile.ForeColor = System.Drawing.Color.White;
            button_customerSelectFile.Location = new System.Drawing.Point(15, 148);
            button_customerSelectFile.Margin = new Padding(3, 4, 3, 4);
            button_customerSelectFile.Name = "button_customerSelectFile";
            button_customerSelectFile.Size = new System.Drawing.Size(91, 38);
            button_customerSelectFile.TabIndex = 4;
            button_customerSelectFile.Text = "Select File";
            defaultToolTip.SetToolTip(button_customerSelectFile, "Select input CSV file");
            button_customerSelectFile.UseVisualStyleBackColor = false;
            button_customerSelectFile.Click += button_select_customer_file_Click;
            // 
            // defaultToolTip
            // 
            defaultToolTip.ShowAlways = true;
            // 
            // tmrExpand
            // 
            tmrExpand.Interval = 10;
            tmrExpand.Tick += tmrExpand_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(45, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(113, 20);
            label1.TabIndex = 1;
            label1.Text = "Invoice Address";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.White;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new System.Drawing.Point(9, 1);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(30, 30);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Location = new System.Drawing.Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(438, 32);
            panel1.TabIndex = 2;
            // 
            // label_contactPerson
            // 
            label_contactPerson.AutoSize = true;
            label_contactPerson.Location = new System.Drawing.Point(10, 266);
            label_contactPerson.Name = "label_contactPerson";
            label_contactPerson.Size = new System.Drawing.Size(126, 23);
            label_contactPerson.TabIndex = 9;
            label_contactPerson.Text = "Contact Person";
            // 
            // comboBox_contactPerson
            // 
            comboBox_contactPerson.FormattingEnabled = true;
            comboBox_contactPerson.Location = new System.Drawing.Point(175, 263);
            comboBox_contactPerson.Margin = new Padding(3, 4, 3, 4);
            comboBox_contactPerson.Name = "comboBox_contactPerson";
            comboBox_contactPerson.Size = new System.Drawing.Size(157, 29);
            comboBox_contactPerson.TabIndex = 10;
            // 
            // UserControl_CustomerImport
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel_customerFieldMapping);
            Controls.Add(panel_customerButtons);
            Controls.Add(panel_customerMessage);
            Controls.Add(panel_customerDataTable);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControl_CustomerImport";
            Size = new System.Drawing.Size(1150, 856);
            Load += UserControl1_Load;
            panel_customerDataTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_customer).EndInit();
            panel_customerMessage.ResumeLayout(false);
            panel_customerMessage.PerformLayout();
            panel_customerButtons.ResumeLayout(false);
            panel_customerFieldMapping.ResumeLayout(false);
            panel_customerFieldMapping.PerformLayout();
            flowLayoutPanel_NonMandatoryFields.ResumeLayout(false);
            panel_customerDetailsButton.ResumeLayout(false);
            panel_customerDetailsButton.PerformLayout();
            panel_customerDetails.ResumeLayout(false);
            panel_customerDetails.PerformLayout();
            panel_contactDetailsButton.ResumeLayout(false);
            panel_contactDetailsButton.PerformLayout();
            panel_contactDetails.ResumeLayout(false);
            panel_contactDetails.PerformLayout();
            panel_invoiceAddressButton.ResumeLayout(false);
            panel_invoiceAddressButton.PerformLayout();
            panel_invoiceAddress.ResumeLayout(false);
            panel_invoiceAddress.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel_financeCompanyInfo.ResumeLayout(false);
            panel_financeCompanyInfo.PerformLayout();
            panel_defaultInvoiceSettingsButton.ResumeLayout(false);
            panel_defaultInvoiceSettingsButton.PerformLayout();
            panel_defaultInvoiceSettings.ResumeLayout(false);
            panel_defaultInvoiceSettings.PerformLayout();
            panel_invoiceExternalCosts.ResumeLayout(false);
            panel_invoiceExternalCosts.PerformLayout();
            panel_incoiceExternalCosts.ResumeLayout(false);
            panel_incoiceExternalCosts.PerformLayout();
            groupBox_customerMandatoryFields.ResumeLayout(false);
            groupBox_customerMandatoryFields.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion


        private void AddRowNumberToDataTable()
        {
            dataGridView_customer.DataBindingComplete += (o, e) =>
            {
                foreach (DataGridViewRow row in dataGridView_customer.Rows)
                {
                    row.HeaderCell.Value = (row.Index + 1).ToString();

                }
            };
            dataGridView_customer.RowHeadersWidth = 65;
        }


        private System.ComponentModel.BackgroundWorker WorkerFetcher;
        private Panel panel_customerDataTable;
        private DataGridView dataGridView_customer;
        private Panel panel_customerMessage;
        private Panel panel_customerButtons;
        private Button button_clear;
        private Button button_import;
        private Button button_validate;
        private Button button_stop;
        private Panel panel_customerFieldMapping;
        private GroupBox groupBox_customerMandatoryFields;
        private ComboBox comboBox_customerName;
        private Label label_customerName;
        private Label label_customerSetup;
        private Button button_customerSelectFile;
        private TextBox textBox_customerImportMessages;
        private ComboBox comboBox_currencyISO;
        private Label label_currencyISO;
        private ComboBox comboBox_countryISO;
        private ComboBox comboBox_customerStatus;
        private Label label_invoicingAddressCountryID;
        private Label label_countryISO;
        private Label label_customerStatus;
        private Label label_eanNo;
        private Label label_secondaryKAM;
        private Label label_primaryKAM;
        private Label label_email;
        private Label label_industryName;
        private Label label_defaultMileageDistance;
        private Label label_customerNo;
        private Label label_useEanNo;
        private Label label_vatPercentage;
        private Label label_calculateVAT;
        private Label label_discountPercentage;
        private Label label_paymentTerm;
        private Label label_defaultDistIsMaxBillable;
        private Label label_organizationNo;
        private Label label_vatNo;
        private Label label_invoicingAddressState;
        private Label label_expenseIsBillable;
        private Label label_mileageIsBillable;
        private Label label_invoicingAddress3;
        private Label label_invoicingAddress2;
        private Label label_invoicingAddressZipCode;
        private Label label_invoicingAddressCity;
        private Label label_invoicingAddress;
        private Label label_useInvoicingAddress;
        private Label label_state;
        private Label label_city;
        private Label label_zipCode;
        private Label label_address3;
        private Label label_address2;
        private Label label_address;
        private Label label_website;
        private Label label_fax;
        private Label label_phone;
        private Label label_customerSince;
        private Label label_nickname;
        private ComboBox comboBox_customerNo;
        private ComboBox comboBox_secondaryKAM;
        private CheckBox checkBox_defaultCurrencyISO;
        private CheckBox checkBox_defaultPrimaryKAM;
        private ComboBox comboBox_useInvoicingAddress;
        private ComboBox comboBox_organizationNo;
        private ComboBox comboBox_eanNo;
        private ComboBox comboBox_useEanNo;
        private ComboBox comboBox_state;
        private ComboBox comboBox_city;
        private ComboBox comboBox_zipCode;
        private ComboBox comboBox_address3;
        private ComboBox comboBox_address2;
        private ComboBox comboBox_address;
        private ComboBox comboBox_website;
        private ComboBox comboBox_email;
        private ComboBox comboBox_faxNo;
        private ComboBox comboBox_phoneNo;
        private ComboBox comboBox_industryName;
        private ComboBox comboBox_customerSince;
        private ComboBox comboBox_primaryKAM;
        private ComboBox comboBox_nickName;
        private ComboBox comboBox_VATNo;
        private ComboBox comboBox_VATPercentage;
        private ComboBox comboBox_calculateVAT;
        private ComboBox comboBox_discountPercentage;
        private ComboBox comboBox_defaultDistIsMaxBillable;
        private ComboBox comboBox_mileageIsBillable;
        private ComboBox comboBox_expenseIsBillable;
        private ComboBox comboBox_defaultMileageDistance;
        private ComboBox comboBox_invoicingAddressCountryISO;
        private ComboBox comboBox_invoicingAddressState;
        private ComboBox comboBox_invoicingAddressCity;
        private ComboBox comboBox_invoicingAddressZipCode;
        private ComboBox comboBox_invoicingAddress3;
        private ComboBox comboBox_invoicingAddress2;
        private ComboBox comboBox_invoicingAddress;
        private CheckBox checkBox_defaultCountryISO;
        private CheckBox checkBox_defaultCustomerStatus;
        private CheckBox checkBox_defaultVATPercentage;
        private CheckBox checkBox_defaultPaymentTerm;
        private CheckBox checkBox_defaultIndustryName;
        private CheckBox checkBox_defaultSecondaryKAM;
        private Label label_delimiter;
        private ComboBox comboBox_delimiter;
        private ToolTip defaultToolTip;
        private Timer tmrExpand;
        private FlowLayoutPanel flowLayoutPanel_NonMandatoryFields;
        private Panel panel_customerDetailsButton;
        private Panel panel_contactDetails;
        private Button button_contactDetails;
        private Panel panel_invoiceAddressButton;
        private Panel panel_invoiceAddress;
        private Label label_ContactDetails;
        private Label label_invoiceAddress;
        private Button button_invoiceAddress;
        private Label label1;
        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel_financeCompanyInfo;
        private Panel panel_defaultInvoiceSettingsButton;
        private Panel panel_defaultInvoiceSettings;
        private Button button_financeCompanyInfo;
        private Button button_defaultInvoiceSettings;
        private Panel panel_invoiceExternalCosts;
        private Panel panel_incoiceExternalCosts;
        private Button button_invoiceExternalCosts;
        private Label label_financeCompanyInfo;
        private Label label_defaultInvoiceSettings;
        private Label label_invoiceExternalCosts;
        private Panel panel_customerDetails;
        private Panel panel_contactDetailsButton;
        private Button button_customerDetails;
        private Label label_customerDetails;
        private CheckBox checkBox_defaultMileageIsBillable;
        private CheckBox checkBox_defaultExpenseIsBillable;
        private ComboBox comboBox_paymentTerm;
        private CheckBox checkBox_defaultInvoicingAddressCountryISO;
        private ComboBox comboBox_contactPerson;
        private Label label_contactPerson;
    }
}
