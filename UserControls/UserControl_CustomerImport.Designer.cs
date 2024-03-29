﻿using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            this.WorkerFetcher = new System.ComponentModel.BackgroundWorker();
            this.panel_customerDataTable = new System.Windows.Forms.Panel();
            this.dataGridView_customer = new System.Windows.Forms.DataGridView();
            this.panel_customerMessage = new System.Windows.Forms.Panel();
            this.textBox_customerImportMessages = new System.Windows.Forms.TextBox();
            this.panel_customerButtons = new System.Windows.Forms.Panel();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_import = new System.Windows.Forms.Button();
            this.button_validate = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.panel_customerFieldMapping = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_NonMandatoryFields = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_customerDetailsButton = new System.Windows.Forms.Panel();
            this.label_customerDetails = new System.Windows.Forms.Label();
            this.button_customerDetails = new System.Windows.Forms.Button();
            this.panel_customerDetails = new System.Windows.Forms.Panel();
            this.label_customerNo = new System.Windows.Forms.Label();
            this.label_nickname = new System.Windows.Forms.Label();
            this.checkBox_defaultIndustryName = new System.Windows.Forms.CheckBox();
            this.label_customerSince = new System.Windows.Forms.Label();
            this.checkBox_defaultSecondaryKAM = new System.Windows.Forms.CheckBox();
            this.label_primaryKAM = new System.Windows.Forms.Label();
            this.comboBox_industryName = new System.Windows.Forms.ComboBox();
            this.label_secondaryKAM = new System.Windows.Forms.Label();
            this.comboBox_customerSince = new System.Windows.Forms.ComboBox();
            this.label_industryName = new System.Windows.Forms.Label();
            this.comboBox_primaryKAM = new System.Windows.Forms.ComboBox();
            this.comboBox_secondaryKAM = new System.Windows.Forms.ComboBox();
            this.comboBox_nickName = new System.Windows.Forms.ComboBox();
            this.comboBox_customerNo = new System.Windows.Forms.ComboBox();
            this.checkBox_defaultPrimaryKAM = new System.Windows.Forms.CheckBox();
            this.panel_contactDetailsButton = new System.Windows.Forms.Panel();
            this.label_ContactDetails = new System.Windows.Forms.Label();
            this.button_contactDetails = new System.Windows.Forms.Button();
            this.panel_contactDetails = new System.Windows.Forms.Panel();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_fax = new System.Windows.Forms.Label();
            this.label_website = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.label_address2 = new System.Windows.Forms.Label();
            this.label_address3 = new System.Windows.Forms.Label();
            this.label_zipCode = new System.Windows.Forms.Label();
            this.label_city = new System.Windows.Forms.Label();
            this.label_state = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.comboBox_phoneNo = new System.Windows.Forms.ComboBox();
            this.comboBox_faxNo = new System.Windows.Forms.ComboBox();
            this.comboBox_email = new System.Windows.Forms.ComboBox();
            this.comboBox_website = new System.Windows.Forms.ComboBox();
            this.comboBox_address = new System.Windows.Forms.ComboBox();
            this.comboBox_address2 = new System.Windows.Forms.ComboBox();
            this.comboBox_address3 = new System.Windows.Forms.ComboBox();
            this.comboBox_zipCode = new System.Windows.Forms.ComboBox();
            this.comboBox_city = new System.Windows.Forms.ComboBox();
            this.comboBox_state = new System.Windows.Forms.ComboBox();
            this.panel_invoiceAddressButton = new System.Windows.Forms.Panel();
            this.label_invoiceAddress = new System.Windows.Forms.Label();
            this.button_invoiceAddress = new System.Windows.Forms.Button();
            this.panel_invoiceAddress = new System.Windows.Forms.Panel();
            this.checkBox_defaultInvoicingAddressCountryISO = new System.Windows.Forms.CheckBox();
            this.label_useInvoicingAddress = new System.Windows.Forms.Label();
            this.label_invoicingAddress = new System.Windows.Forms.Label();
            this.label_invoicingAddressCity = new System.Windows.Forms.Label();
            this.label_invoicingAddressZipCode = new System.Windows.Forms.Label();
            this.label_invoicingAddress2 = new System.Windows.Forms.Label();
            this.label_invoicingAddress3 = new System.Windows.Forms.Label();
            this.label_invoicingAddressState = new System.Windows.Forms.Label();
            this.label_invoicingAddressCountryID = new System.Windows.Forms.Label();
            this.comboBox_useInvoicingAddress = new System.Windows.Forms.ComboBox();
            this.comboBox_invoicingAddress = new System.Windows.Forms.ComboBox();
            this.comboBox_invoicingAddress2 = new System.Windows.Forms.ComboBox();
            this.comboBox_invoicingAddress3 = new System.Windows.Forms.ComboBox();
            this.comboBox_invoicingAddressZipCode = new System.Windows.Forms.ComboBox();
            this.comboBox_invoicingAddressCity = new System.Windows.Forms.ComboBox();
            this.comboBox_invoicingAddressState = new System.Windows.Forms.ComboBox();
            this.comboBox_invoicingAddressCountryISO = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_financeCompanyInfo = new System.Windows.Forms.Label();
            this.button_financeCompanyInfo = new System.Windows.Forms.Button();
            this.panel_financeCompanyInfo = new System.Windows.Forms.Panel();
            this.label_organizationNo = new System.Windows.Forms.Label();
            this.label_vatNo = new System.Windows.Forms.Label();
            this.comboBox_organizationNo = new System.Windows.Forms.ComboBox();
            this.comboBox_VATNo = new System.Windows.Forms.ComboBox();
            this.comboBox_eanNo = new System.Windows.Forms.ComboBox();
            this.comboBox_useEanNo = new System.Windows.Forms.ComboBox();
            this.label_eanNo = new System.Windows.Forms.Label();
            this.label_useEanNo = new System.Windows.Forms.Label();
            this.panel_defaultInvoiceSettingsButton = new System.Windows.Forms.Panel();
            this.label_defaultInvoiceSettings = new System.Windows.Forms.Label();
            this.button_defaultInvoiceSettings = new System.Windows.Forms.Button();
            this.panel_defaultInvoiceSettings = new System.Windows.Forms.Panel();
            this.checkBox_defaultVATPercentage = new System.Windows.Forms.CheckBox();
            this.checkBox_defaultPaymentTerm = new System.Windows.Forms.CheckBox();
            this.label_paymentTerm = new System.Windows.Forms.Label();
            this.label_discountPercentage = new System.Windows.Forms.Label();
            this.label_calculateVAT = new System.Windows.Forms.Label();
            this.comboBox_VATPercentage = new System.Windows.Forms.ComboBox();
            this.label_vatPercentage = new System.Windows.Forms.Label();
            this.comboBox_calculateVAT = new System.Windows.Forms.ComboBox();
            this.comboBox_discountPercentage = new System.Windows.Forms.ComboBox();
            this.comboBox_paymentTerm = new System.Windows.Forms.ComboBox();
            this.panel_invoiceExternalCosts = new System.Windows.Forms.Panel();
            this.label_invoiceExternalCosts = new System.Windows.Forms.Label();
            this.button_invoiceExternalCosts = new System.Windows.Forms.Button();
            this.panel_incoiceExternalCosts = new System.Windows.Forms.Panel();
            this.checkBox_defaultExpenseIsBillable = new System.Windows.Forms.CheckBox();
            this.checkBox_defaultMileageIsBillable = new System.Windows.Forms.CheckBox();
            this.label_defaultMileageDistance = new System.Windows.Forms.Label();
            this.label_defaultDistIsMaxBillable = new System.Windows.Forms.Label();
            this.label_expenseIsBillable = new System.Windows.Forms.Label();
            this.label_mileageIsBillable = new System.Windows.Forms.Label();
            this.comboBox_defaultDistIsMaxBillable = new System.Windows.Forms.ComboBox();
            this.comboBox_defaultMileageDistance = new System.Windows.Forms.ComboBox();
            this.comboBox_expenseIsBillable = new System.Windows.Forms.ComboBox();
            this.comboBox_mileageIsBillable = new System.Windows.Forms.ComboBox();
            this.label_delimiter = new System.Windows.Forms.Label();
            this.comboBox_delimiter = new System.Windows.Forms.ComboBox();
            this.groupBox_customerMandatoryFields = new System.Windows.Forms.GroupBox();
            this.checkBox_defaultCountryISO = new System.Windows.Forms.CheckBox();
            this.checkBox_defaultCustomerStatus = new System.Windows.Forms.CheckBox();
            this.checkBox_defaultCurrencyISO = new System.Windows.Forms.CheckBox();
            this.label_countryISO = new System.Windows.Forms.Label();
            this.label_customerStatus = new System.Windows.Forms.Label();
            this.comboBox_countryISO = new System.Windows.Forms.ComboBox();
            this.comboBox_customerStatus = new System.Windows.Forms.ComboBox();
            this.label_currencyISO = new System.Windows.Forms.Label();
            this.comboBox_currencyISO = new System.Windows.Forms.ComboBox();
            this.label_customerName = new System.Windows.Forms.Label();
            this.comboBox_customerName = new System.Windows.Forms.ComboBox();
            this.label_customerSetup = new System.Windows.Forms.Label();
            this.button_customerSelectFile = new System.Windows.Forms.Button();
            this.defaultToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tmrExpand = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_customerDataTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_customer)).BeginInit();
            this.panel_customerMessage.SuspendLayout();
            this.panel_customerButtons.SuspendLayout();
            this.panel_customerFieldMapping.SuspendLayout();
            this.flowLayoutPanel_NonMandatoryFields.SuspendLayout();
            this.panel_customerDetailsButton.SuspendLayout();
            this.panel_customerDetails.SuspendLayout();
            this.panel_contactDetailsButton.SuspendLayout();
            this.panel_contactDetails.SuspendLayout();
            this.panel_invoiceAddressButton.SuspendLayout();
            this.panel_invoiceAddress.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_financeCompanyInfo.SuspendLayout();
            this.panel_defaultInvoiceSettingsButton.SuspendLayout();
            this.panel_defaultInvoiceSettings.SuspendLayout();
            this.panel_invoiceExternalCosts.SuspendLayout();
            this.panel_incoiceExternalCosts.SuspendLayout();
            this.groupBox_customerMandatoryFields.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkerFetcher
            // 
            this.WorkerFetcher.WorkerReportsProgress = true;
            this.WorkerFetcher.WorkerSupportsCancellation = true;
            this.WorkerFetcher.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WorkerFetcherDoWork);
            // 
            // panel_customerDataTable
            // 
            this.panel_customerDataTable.Controls.Add(this.dataGridView_customer);
            this.panel_customerDataTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_customerDataTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_customerDataTable.Location = new System.Drawing.Point(0, 770);
            this.panel_customerDataTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_customerDataTable.Name = "panel_customerDataTable";
            this.panel_customerDataTable.Size = new System.Drawing.Size(1437, 300);
            this.panel_customerDataTable.TabIndex = 6;
            // 
            // dataGridView_customer
            // 
            this.dataGridView_customer.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView_customer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_customer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_customer.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dataGridView_customer.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_customer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_customer.Name = "dataGridView_customer";
            this.dataGridView_customer.RowHeadersWidth = 62;
            this.dataGridView_customer.Size = new System.Drawing.Size(1437, 300);
            this.dataGridView_customer.TabIndex = 0;
            this.defaultToolTip.SetToolTip(this.dataGridView_customer, "Customer input data table");
            // 
            // panel_customerMessage
            // 
            this.panel_customerMessage.Controls.Add(this.textBox_customerImportMessages);
            this.panel_customerMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_customerMessage.Location = new System.Drawing.Point(0, 463);
            this.panel_customerMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_customerMessage.Name = "panel_customerMessage";
            this.panel_customerMessage.Size = new System.Drawing.Size(1437, 307);
            this.panel_customerMessage.TabIndex = 10;
            // 
            // textBox_customerImportMessages
            // 
            this.textBox_customerImportMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_customerImportMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_customerImportMessages.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_customerImportMessages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox_customerImportMessages.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_customerImportMessages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_customerImportMessages.Location = new System.Drawing.Point(0, 0);
            this.textBox_customerImportMessages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_customerImportMessages.Multiline = true;
            this.textBox_customerImportMessages.Name = "textBox_customerImportMessages";
            this.textBox_customerImportMessages.ReadOnly = true;
            this.textBox_customerImportMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_customerImportMessages.Size = new System.Drawing.Size(1437, 307);
            this.textBox_customerImportMessages.TabIndex = 0;
            this.defaultToolTip.SetToolTip(this.textBox_customerImportMessages, "Validation or import status");
            this.textBox_customerImportMessages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_customerImportMessages_MouseClick);
            // 
            // panel_customerButtons
            // 
            this.panel_customerButtons.Controls.Add(this.button_clear);
            this.panel_customerButtons.Controls.Add(this.button_import);
            this.panel_customerButtons.Controls.Add(this.button_validate);
            this.panel_customerButtons.Controls.Add(this.button_stop);
            this.panel_customerButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_customerButtons.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel_customerButtons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_customerButtons.Location = new System.Drawing.Point(0, 376);
            this.panel_customerButtons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_customerButtons.Name = "panel_customerButtons";
            this.panel_customerButtons.Size = new System.Drawing.Size(1437, 87);
            this.panel_customerButtons.TabIndex = 12;
            // 
            // button_clear
            // 
            this.button_clear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_clear.BackColor = System.Drawing.Color.DimGray;
            this.button_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_clear.FlatAppearance.BorderSize = 0;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.ForeColor = System.Drawing.Color.White;
            this.button_clear.Location = new System.Drawing.Point(20, 20);
            this.button_clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(114, 48);
            this.button_clear.TabIndex = 12;
            this.button_clear.Text = "Reset All";
            this.defaultToolTip.SetToolTip(this.button_clear, "Reset everything and reload data from TLP");
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_import
            // 
            this.button_import.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(43)))), ((int)(((byte)(141)))));
            this.button_import.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_import.FlatAppearance.BorderSize = 0;
            this.button_import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_import.ForeColor = System.Drawing.Color.White;
            this.button_import.Location = new System.Drawing.Point(1310, 20);
            this.button_import.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_import.Name = "button_import";
            this.button_import.Size = new System.Drawing.Size(114, 48);
            this.button_import.TabIndex = 7;
            this.button_import.Text = "Import";
            this.defaultToolTip.SetToolTip(this.button_import, "Import all data");
            this.button_import.UseVisualStyleBackColor = false;
            this.button_import.Click += new System.EventHandler(this.button_import_Click);
            // 
            // button_validate
            // 
            this.button_validate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_validate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(43)))), ((int)(((byte)(141)))));
            this.button_validate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_validate.FlatAppearance.BorderSize = 0;
            this.button_validate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_validate.ForeColor = System.Drawing.Color.White;
            this.button_validate.Location = new System.Drawing.Point(1064, 20);
            this.button_validate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_validate.Name = "button_validate";
            this.button_validate.Size = new System.Drawing.Size(114, 48);
            this.button_validate.TabIndex = 8;
            this.button_validate.Text = "Validate";
            this.defaultToolTip.SetToolTip(this.button_validate, "Validate data input before importing data");
            this.button_validate.UseVisualStyleBackColor = false;
            this.button_validate.Click += new System.EventHandler(this.button_validate_Click);
            // 
            // button_stop
            // 
            this.button_stop.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_stop.BackColor = System.Drawing.Color.DimGray;
            this.button_stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_stop.FlatAppearance.BorderSize = 0;
            this.button_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_stop.ForeColor = System.Drawing.Color.White;
            this.button_stop.Location = new System.Drawing.Point(1187, 20);
            this.button_stop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(114, 48);
            this.button_stop.TabIndex = 11;
            this.button_stop.Text = "Stop";
            this.defaultToolTip.SetToolTip(this.button_stop, "Stop validation or import");
            this.button_stop.UseVisualStyleBackColor = false;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // panel_customerFieldMapping
            // 
            this.panel_customerFieldMapping.AutoScroll = true;
            this.panel_customerFieldMapping.Controls.Add(this.flowLayoutPanel_NonMandatoryFields);
            this.panel_customerFieldMapping.Controls.Add(this.label_delimiter);
            this.panel_customerFieldMapping.Controls.Add(this.comboBox_delimiter);
            this.panel_customerFieldMapping.Controls.Add(this.groupBox_customerMandatoryFields);
            this.panel_customerFieldMapping.Controls.Add(this.label_customerSetup);
            this.panel_customerFieldMapping.Controls.Add(this.button_customerSelectFile);
            this.panel_customerFieldMapping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_customerFieldMapping.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel_customerFieldMapping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_customerFieldMapping.Location = new System.Drawing.Point(0, 0);
            this.panel_customerFieldMapping.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_customerFieldMapping.Name = "panel_customerFieldMapping";
            this.panel_customerFieldMapping.Size = new System.Drawing.Size(1437, 376);
            this.panel_customerFieldMapping.TabIndex = 13;
            // 
            // flowLayoutPanel_NonMandatoryFields
            // 
            this.flowLayoutPanel_NonMandatoryFields.Controls.Add(this.panel_customerDetailsButton);
            this.flowLayoutPanel_NonMandatoryFields.Controls.Add(this.panel_customerDetails);
            this.flowLayoutPanel_NonMandatoryFields.Controls.Add(this.panel_contactDetailsButton);
            this.flowLayoutPanel_NonMandatoryFields.Controls.Add(this.panel_contactDetails);
            this.flowLayoutPanel_NonMandatoryFields.Controls.Add(this.panel_invoiceAddressButton);
            this.flowLayoutPanel_NonMandatoryFields.Controls.Add(this.panel_invoiceAddress);
            this.flowLayoutPanel_NonMandatoryFields.Controls.Add(this.panel2);
            this.flowLayoutPanel_NonMandatoryFields.Controls.Add(this.panel_financeCompanyInfo);
            this.flowLayoutPanel_NonMandatoryFields.Controls.Add(this.panel_defaultInvoiceSettingsButton);
            this.flowLayoutPanel_NonMandatoryFields.Controls.Add(this.panel_defaultInvoiceSettings);
            this.flowLayoutPanel_NonMandatoryFields.Controls.Add(this.panel_invoiceExternalCosts);
            this.flowLayoutPanel_NonMandatoryFields.Controls.Add(this.panel_incoiceExternalCosts);
            this.flowLayoutPanel_NonMandatoryFields.Location = new System.Drawing.Point(763, 27);
            this.flowLayoutPanel_NonMandatoryFields.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel_NonMandatoryFields.Name = "flowLayoutPanel_NonMandatoryFields";
            this.flowLayoutPanel_NonMandatoryFields.Size = new System.Drawing.Size(624, 2690);
            this.flowLayoutPanel_NonMandatoryFields.TabIndex = 8;
            // 
            // panel_customerDetailsButton
            // 
            this.panel_customerDetailsButton.Controls.Add(this.label_customerDetails);
            this.panel_customerDetailsButton.Controls.Add(this.button_customerDetails);
            this.panel_customerDetailsButton.Location = new System.Drawing.Point(4, 5);
            this.panel_customerDetailsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_customerDetailsButton.Name = "panel_customerDetailsButton";
            this.panel_customerDetailsButton.Size = new System.Drawing.Size(609, 53);
            this.panel_customerDetailsButton.TabIndex = 0;
            // 
            // label_customerDetails
            // 
            this.label_customerDetails.AutoSize = true;
            this.label_customerDetails.ForeColor = System.Drawing.Color.Black;
            this.label_customerDetails.Location = new System.Drawing.Point(64, 13);
            this.label_customerDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_customerDetails.Name = "label_customerDetails";
            this.label_customerDetails.Size = new System.Drawing.Size(111, 17);
            this.label_customerDetails.TabIndex = 1;
            this.label_customerDetails.Text = "Customer Details";
            // 
            // button_customerDetails
            // 
            this.button_customerDetails.BackColor = System.Drawing.Color.White;
            this.button_customerDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_customerDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_customerDetails.FlatAppearance.BorderSize = 0;
            this.button_customerDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_customerDetails.Location = new System.Drawing.Point(13, 2);
            this.button_customerDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_customerDetails.Name = "button_customerDetails";
            this.button_customerDetails.Size = new System.Drawing.Size(43, 50);
            this.button_customerDetails.TabIndex = 0;
            this.button_customerDetails.UseVisualStyleBackColor = false;
            this.button_customerDetails.Click += new System.EventHandler(this.button_expand_Click);
            // 
            // panel_customerDetails
            // 
            this.panel_customerDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_customerDetails.Controls.Add(this.label_customerNo);
            this.panel_customerDetails.Controls.Add(this.label_nickname);
            this.panel_customerDetails.Controls.Add(this.checkBox_defaultIndustryName);
            this.panel_customerDetails.Controls.Add(this.label_customerSince);
            this.panel_customerDetails.Controls.Add(this.checkBox_defaultSecondaryKAM);
            this.panel_customerDetails.Controls.Add(this.label_primaryKAM);
            this.panel_customerDetails.Controls.Add(this.comboBox_industryName);
            this.panel_customerDetails.Controls.Add(this.label_secondaryKAM);
            this.panel_customerDetails.Controls.Add(this.comboBox_customerSince);
            this.panel_customerDetails.Controls.Add(this.label_industryName);
            this.panel_customerDetails.Controls.Add(this.comboBox_primaryKAM);
            this.panel_customerDetails.Controls.Add(this.comboBox_secondaryKAM);
            this.panel_customerDetails.Controls.Add(this.comboBox_nickName);
            this.panel_customerDetails.Controls.Add(this.comboBox_customerNo);
            this.panel_customerDetails.Controls.Add(this.checkBox_defaultPrimaryKAM);
            this.panel_customerDetails.Location = new System.Drawing.Point(4, 68);
            this.panel_customerDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_customerDetails.MaximumSize = new System.Drawing.Size(609, 338);
            this.panel_customerDetails.MinimumSize = new System.Drawing.Size(609, 0);
            this.panel_customerDetails.Name = "panel_customerDetails";
            this.panel_customerDetails.Size = new System.Drawing.Size(609, 338);
            this.panel_customerDetails.TabIndex = 10;
            // 
            // label_customerNo
            // 
            this.label_customerNo.AutoSize = true;
            this.label_customerNo.Location = new System.Drawing.Point(14, 25);
            this.label_customerNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_customerNo.Name = "label_customerNo";
            this.label_customerNo.Size = new System.Drawing.Size(89, 17);
            this.label_customerNo.TabIndex = 1;
            this.label_customerNo.Text = "Customer No";
            // 
            // label_nickname
            // 
            this.label_nickname.AutoSize = true;
            this.label_nickname.Location = new System.Drawing.Point(14, 77);
            this.label_nickname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_nickname.Name = "label_nickname";
            this.label_nickname.Size = new System.Drawing.Size(68, 17);
            this.label_nickname.TabIndex = 1;
            this.label_nickname.Text = "Nickname";
            // 
            // checkBox_defaultIndustryName
            // 
            this.checkBox_defaultIndustryName.AutoSize = true;
            this.checkBox_defaultIndustryName.Location = new System.Drawing.Point(424, 282);
            this.checkBox_defaultIndustryName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_defaultIndustryName.Name = "checkBox_defaultIndustryName";
            this.checkBox_defaultIndustryName.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultIndustryName.TabIndex = 8;
            this.checkBox_defaultIndustryName.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultIndustryName, "Set default values for all rows of a particular column field");
            this.checkBox_defaultIndustryName.UseVisualStyleBackColor = true;
            this.checkBox_defaultIndustryName.CheckedChanged += new System.EventHandler(this.checkBox_defaultIndustryName_CheckedChanged);
            // 
            // label_customerSince
            // 
            this.label_customerSince.AutoSize = true;
            this.label_customerSince.Location = new System.Drawing.Point(14, 232);
            this.label_customerSince.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_customerSince.Name = "label_customerSince";
            this.label_customerSince.Size = new System.Drawing.Size(102, 17);
            this.label_customerSince.TabIndex = 1;
            this.label_customerSince.Text = "Customer Since";
            // 
            // checkBox_defaultSecondaryKAM
            // 
            this.checkBox_defaultSecondaryKAM.AutoSize = true;
            this.checkBox_defaultSecondaryKAM.Location = new System.Drawing.Point(424, 178);
            this.checkBox_defaultSecondaryKAM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_defaultSecondaryKAM.Name = "checkBox_defaultSecondaryKAM";
            this.checkBox_defaultSecondaryKAM.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultSecondaryKAM.TabIndex = 8;
            this.checkBox_defaultSecondaryKAM.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultSecondaryKAM, "Set default values for all rows of a particular column field");
            this.checkBox_defaultSecondaryKAM.UseVisualStyleBackColor = true;
            this.checkBox_defaultSecondaryKAM.CheckedChanged += new System.EventHandler(this.checkBox_defaultSecondaryKAM_CheckedChanged);
            // 
            // label_primaryKAM
            // 
            this.label_primaryKAM.AutoSize = true;
            this.label_primaryKAM.Location = new System.Drawing.Point(14, 128);
            this.label_primaryKAM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_primaryKAM.Name = "label_primaryKAM";
            this.label_primaryKAM.Size = new System.Drawing.Size(89, 17);
            this.label_primaryKAM.TabIndex = 1;
            this.label_primaryKAM.Text = "Primary KAM";
            // 
            // comboBox_industryName
            // 
            this.comboBox_industryName.FormattingEnabled = true;
            this.comboBox_industryName.Location = new System.Drawing.Point(219, 278);
            this.comboBox_industryName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_industryName.Name = "comboBox_industryName";
            this.comboBox_industryName.Size = new System.Drawing.Size(195, 25);
            this.comboBox_industryName.TabIndex = 3;
            // 
            // label_secondaryKAM
            // 
            this.label_secondaryKAM.AutoSize = true;
            this.label_secondaryKAM.Location = new System.Drawing.Point(14, 180);
            this.label_secondaryKAM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_secondaryKAM.Name = "label_secondaryKAM";
            this.label_secondaryKAM.Size = new System.Drawing.Size(105, 17);
            this.label_secondaryKAM.TabIndex = 1;
            this.label_secondaryKAM.Text = "Secondary KAM";
            // 
            // comboBox_customerSince
            // 
            this.comboBox_customerSince.FormattingEnabled = true;
            this.comboBox_customerSince.Location = new System.Drawing.Point(219, 227);
            this.comboBox_customerSince.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_customerSince.Name = "comboBox_customerSince";
            this.comboBox_customerSince.Size = new System.Drawing.Size(195, 25);
            this.comboBox_customerSince.TabIndex = 3;
            // 
            // label_industryName
            // 
            this.label_industryName.AutoSize = true;
            this.label_industryName.Location = new System.Drawing.Point(14, 283);
            this.label_industryName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_industryName.Name = "label_industryName";
            this.label_industryName.Size = new System.Drawing.Size(100, 17);
            this.label_industryName.TabIndex = 1;
            this.label_industryName.Text = "Industry Name";
            // 
            // comboBox_primaryKAM
            // 
            this.comboBox_primaryKAM.FormattingEnabled = true;
            this.comboBox_primaryKAM.Location = new System.Drawing.Point(219, 123);
            this.comboBox_primaryKAM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_primaryKAM.Name = "comboBox_primaryKAM";
            this.comboBox_primaryKAM.Size = new System.Drawing.Size(195, 25);
            this.comboBox_primaryKAM.TabIndex = 3;
            // 
            // comboBox_secondaryKAM
            // 
            this.comboBox_secondaryKAM.FormattingEnabled = true;
            this.comboBox_secondaryKAM.Location = new System.Drawing.Point(219, 175);
            this.comboBox_secondaryKAM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_secondaryKAM.Name = "comboBox_secondaryKAM";
            this.comboBox_secondaryKAM.Size = new System.Drawing.Size(195, 25);
            this.comboBox_secondaryKAM.TabIndex = 3;
            // 
            // comboBox_nickName
            // 
            this.comboBox_nickName.FormattingEnabled = true;
            this.comboBox_nickName.Location = new System.Drawing.Point(219, 72);
            this.comboBox_nickName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_nickName.Name = "comboBox_nickName";
            this.comboBox_nickName.Size = new System.Drawing.Size(195, 25);
            this.comboBox_nickName.TabIndex = 3;
            // 
            // comboBox_customerNo
            // 
            this.comboBox_customerNo.FormattingEnabled = true;
            this.comboBox_customerNo.Location = new System.Drawing.Point(219, 20);
            this.comboBox_customerNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_customerNo.Name = "comboBox_customerNo";
            this.comboBox_customerNo.Size = new System.Drawing.Size(195, 25);
            this.comboBox_customerNo.TabIndex = 3;
            // 
            // checkBox_defaultPrimaryKAM
            // 
            this.checkBox_defaultPrimaryKAM.AutoSize = true;
            this.checkBox_defaultPrimaryKAM.Location = new System.Drawing.Point(424, 127);
            this.checkBox_defaultPrimaryKAM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_defaultPrimaryKAM.Name = "checkBox_defaultPrimaryKAM";
            this.checkBox_defaultPrimaryKAM.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultPrimaryKAM.TabIndex = 8;
            this.checkBox_defaultPrimaryKAM.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultPrimaryKAM, "Set default values for all rows of a particular column field");
            this.checkBox_defaultPrimaryKAM.UseVisualStyleBackColor = true;
            this.checkBox_defaultPrimaryKAM.CheckedChanged += new System.EventHandler(this.checkBox_defaultPrimaryKAM_CheckedChanged);
            // 
            // panel_contactDetailsButton
            // 
            this.panel_contactDetailsButton.Controls.Add(this.label_ContactDetails);
            this.panel_contactDetailsButton.Controls.Add(this.button_contactDetails);
            this.panel_contactDetailsButton.Location = new System.Drawing.Point(4, 416);
            this.panel_contactDetailsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_contactDetailsButton.Name = "panel_contactDetailsButton";
            this.panel_contactDetailsButton.Size = new System.Drawing.Size(609, 53);
            this.panel_contactDetailsButton.TabIndex = 11;
            // 
            // label_ContactDetails
            // 
            this.label_ContactDetails.AutoSize = true;
            this.label_ContactDetails.ForeColor = System.Drawing.Color.Black;
            this.label_ContactDetails.Location = new System.Drawing.Point(64, 13);
            this.label_ContactDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ContactDetails.Name = "label_ContactDetails";
            this.label_ContactDetails.Size = new System.Drawing.Size(99, 17);
            this.label_ContactDetails.TabIndex = 1;
            this.label_ContactDetails.Text = "Contact Details";
            // 
            // button_contactDetails
            // 
            this.button_contactDetails.BackColor = System.Drawing.Color.White;
            this.button_contactDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_contactDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_contactDetails.FlatAppearance.BorderSize = 0;
            this.button_contactDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_contactDetails.Location = new System.Drawing.Point(13, 2);
            this.button_contactDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_contactDetails.Name = "button_contactDetails";
            this.button_contactDetails.Size = new System.Drawing.Size(43, 50);
            this.button_contactDetails.TabIndex = 0;
            this.button_contactDetails.UseVisualStyleBackColor = false;
            this.button_contactDetails.Click += new System.EventHandler(this.button_expand_Click);
            // 
            // panel_contactDetails
            // 
            this.panel_contactDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_contactDetails.Controls.Add(this.label_phone);
            this.panel_contactDetails.Controls.Add(this.label_fax);
            this.panel_contactDetails.Controls.Add(this.label_website);
            this.panel_contactDetails.Controls.Add(this.label_address);
            this.panel_contactDetails.Controls.Add(this.label_address2);
            this.panel_contactDetails.Controls.Add(this.label_address3);
            this.panel_contactDetails.Controls.Add(this.label_zipCode);
            this.panel_contactDetails.Controls.Add(this.label_city);
            this.panel_contactDetails.Controls.Add(this.label_state);
            this.panel_contactDetails.Controls.Add(this.label_email);
            this.panel_contactDetails.Controls.Add(this.comboBox_phoneNo);
            this.panel_contactDetails.Controls.Add(this.comboBox_faxNo);
            this.panel_contactDetails.Controls.Add(this.comboBox_email);
            this.panel_contactDetails.Controls.Add(this.comboBox_website);
            this.panel_contactDetails.Controls.Add(this.comboBox_address);
            this.panel_contactDetails.Controls.Add(this.comboBox_address2);
            this.panel_contactDetails.Controls.Add(this.comboBox_address3);
            this.panel_contactDetails.Controls.Add(this.comboBox_zipCode);
            this.panel_contactDetails.Controls.Add(this.comboBox_city);
            this.panel_contactDetails.Controls.Add(this.comboBox_state);
            this.panel_contactDetails.Location = new System.Drawing.Point(4, 479);
            this.panel_contactDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_contactDetails.MaximumSize = new System.Drawing.Size(609, 545);
            this.panel_contactDetails.MinimumSize = new System.Drawing.Size(609, 0);
            this.panel_contactDetails.Name = "panel_contactDetails";
            this.panel_contactDetails.Size = new System.Drawing.Size(609, 545);
            this.panel_contactDetails.TabIndex = 1;
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Location = new System.Drawing.Point(14, 25);
            this.label_phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(69, 17);
            this.label_phone.TabIndex = 1;
            this.label_phone.Text = "Phone No";
            // 
            // label_fax
            // 
            this.label_fax.AutoSize = true;
            this.label_fax.Location = new System.Drawing.Point(14, 77);
            this.label_fax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_fax.Name = "label_fax";
            this.label_fax.Size = new System.Drawing.Size(51, 17);
            this.label_fax.TabIndex = 1;
            this.label_fax.Text = "Fax No";
            // 
            // label_website
            // 
            this.label_website.AutoSize = true;
            this.label_website.Location = new System.Drawing.Point(14, 180);
            this.label_website.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_website.Name = "label_website";
            this.label_website.Size = new System.Drawing.Size(57, 17);
            this.label_website.TabIndex = 1;
            this.label_website.Text = "Website";
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(14, 232);
            this.label_address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(57, 17);
            this.label_address.TabIndex = 1;
            this.label_address.Text = "Address";
            // 
            // label_address2
            // 
            this.label_address2.AutoSize = true;
            this.label_address2.Location = new System.Drawing.Point(14, 283);
            this.label_address2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_address2.Name = "label_address2";
            this.label_address2.Size = new System.Drawing.Size(68, 17);
            this.label_address2.TabIndex = 1;
            this.label_address2.Text = "Address 2";
            // 
            // label_address3
            // 
            this.label_address3.AutoSize = true;
            this.label_address3.Location = new System.Drawing.Point(14, 335);
            this.label_address3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_address3.Name = "label_address3";
            this.label_address3.Size = new System.Drawing.Size(68, 17);
            this.label_address3.TabIndex = 1;
            this.label_address3.Text = "Address 3";
            // 
            // label_zipCode
            // 
            this.label_zipCode.AutoSize = true;
            this.label_zipCode.Location = new System.Drawing.Point(14, 387);
            this.label_zipCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_zipCode.Name = "label_zipCode";
            this.label_zipCode.Size = new System.Drawing.Size(62, 17);
            this.label_zipCode.TabIndex = 1;
            this.label_zipCode.Text = "Zip Code";
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.Location = new System.Drawing.Point(14, 438);
            this.label_city.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(31, 17);
            this.label_city.TabIndex = 1;
            this.label_city.Text = "City";
            // 
            // label_state
            // 
            this.label_state.AutoSize = true;
            this.label_state.Location = new System.Drawing.Point(14, 490);
            this.label_state.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_state.Name = "label_state";
            this.label_state.Size = new System.Drawing.Size(39, 17);
            this.label_state.TabIndex = 1;
            this.label_state.Text = "State";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(14, 128);
            this.label_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(40, 17);
            this.label_email.TabIndex = 1;
            this.label_email.Text = "Email";
            // 
            // comboBox_phoneNo
            // 
            this.comboBox_phoneNo.FormattingEnabled = true;
            this.comboBox_phoneNo.Location = new System.Drawing.Point(171, 20);
            this.comboBox_phoneNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_phoneNo.Name = "comboBox_phoneNo";
            this.comboBox_phoneNo.Size = new System.Drawing.Size(188, 25);
            this.comboBox_phoneNo.TabIndex = 3;
            // 
            // comboBox_faxNo
            // 
            this.comboBox_faxNo.FormattingEnabled = true;
            this.comboBox_faxNo.Location = new System.Drawing.Point(171, 72);
            this.comboBox_faxNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_faxNo.Name = "comboBox_faxNo";
            this.comboBox_faxNo.Size = new System.Drawing.Size(188, 25);
            this.comboBox_faxNo.TabIndex = 3;
            // 
            // comboBox_email
            // 
            this.comboBox_email.FormattingEnabled = true;
            this.comboBox_email.Location = new System.Drawing.Point(171, 123);
            this.comboBox_email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_email.Name = "comboBox_email";
            this.comboBox_email.Size = new System.Drawing.Size(188, 25);
            this.comboBox_email.TabIndex = 3;
            // 
            // comboBox_website
            // 
            this.comboBox_website.FormattingEnabled = true;
            this.comboBox_website.Location = new System.Drawing.Point(171, 175);
            this.comboBox_website.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_website.Name = "comboBox_website";
            this.comboBox_website.Size = new System.Drawing.Size(188, 25);
            this.comboBox_website.TabIndex = 3;
            // 
            // comboBox_address
            // 
            this.comboBox_address.FormattingEnabled = true;
            this.comboBox_address.Location = new System.Drawing.Point(171, 227);
            this.comboBox_address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_address.Name = "comboBox_address";
            this.comboBox_address.Size = new System.Drawing.Size(188, 25);
            this.comboBox_address.TabIndex = 3;
            // 
            // comboBox_address2
            // 
            this.comboBox_address2.FormattingEnabled = true;
            this.comboBox_address2.Location = new System.Drawing.Point(171, 278);
            this.comboBox_address2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_address2.Name = "comboBox_address2";
            this.comboBox_address2.Size = new System.Drawing.Size(188, 25);
            this.comboBox_address2.TabIndex = 3;
            // 
            // comboBox_address3
            // 
            this.comboBox_address3.FormattingEnabled = true;
            this.comboBox_address3.Location = new System.Drawing.Point(171, 330);
            this.comboBox_address3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_address3.Name = "comboBox_address3";
            this.comboBox_address3.Size = new System.Drawing.Size(188, 25);
            this.comboBox_address3.TabIndex = 3;
            // 
            // comboBox_zipCode
            // 
            this.comboBox_zipCode.FormattingEnabled = true;
            this.comboBox_zipCode.Location = new System.Drawing.Point(171, 382);
            this.comboBox_zipCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_zipCode.Name = "comboBox_zipCode";
            this.comboBox_zipCode.Size = new System.Drawing.Size(188, 25);
            this.comboBox_zipCode.TabIndex = 3;
            // 
            // comboBox_city
            // 
            this.comboBox_city.FormattingEnabled = true;
            this.comboBox_city.Location = new System.Drawing.Point(171, 433);
            this.comboBox_city.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_city.Name = "comboBox_city";
            this.comboBox_city.Size = new System.Drawing.Size(188, 25);
            this.comboBox_city.TabIndex = 3;
            // 
            // comboBox_state
            // 
            this.comboBox_state.FormattingEnabled = true;
            this.comboBox_state.Location = new System.Drawing.Point(171, 485);
            this.comboBox_state.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_state.Name = "comboBox_state";
            this.comboBox_state.Size = new System.Drawing.Size(188, 25);
            this.comboBox_state.TabIndex = 3;
            // 
            // panel_invoiceAddressButton
            // 
            this.panel_invoiceAddressButton.Controls.Add(this.label_invoiceAddress);
            this.panel_invoiceAddressButton.Controls.Add(this.button_invoiceAddress);
            this.panel_invoiceAddressButton.Location = new System.Drawing.Point(4, 1034);
            this.panel_invoiceAddressButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_invoiceAddressButton.Name = "panel_invoiceAddressButton";
            this.panel_invoiceAddressButton.Size = new System.Drawing.Size(609, 53);
            this.panel_invoiceAddressButton.TabIndex = 2;
            // 
            // label_invoiceAddress
            // 
            this.label_invoiceAddress.AutoSize = true;
            this.label_invoiceAddress.ForeColor = System.Drawing.Color.Black;
            this.label_invoiceAddress.Location = new System.Drawing.Point(64, 13);
            this.label_invoiceAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_invoiceAddress.Name = "label_invoiceAddress";
            this.label_invoiceAddress.Size = new System.Drawing.Size(104, 17);
            this.label_invoiceAddress.TabIndex = 1;
            this.label_invoiceAddress.Text = "Invoice Address";
            // 
            // button_invoiceAddress
            // 
            this.button_invoiceAddress.BackColor = System.Drawing.Color.White;
            this.button_invoiceAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_invoiceAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_invoiceAddress.FlatAppearance.BorderSize = 0;
            this.button_invoiceAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_invoiceAddress.Location = new System.Drawing.Point(13, 2);
            this.button_invoiceAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_invoiceAddress.Name = "button_invoiceAddress";
            this.button_invoiceAddress.Size = new System.Drawing.Size(43, 50);
            this.button_invoiceAddress.TabIndex = 0;
            this.button_invoiceAddress.UseVisualStyleBackColor = false;
            this.button_invoiceAddress.Click += new System.EventHandler(this.button_expand_Click);
            // 
            // panel_invoiceAddress
            // 
            this.panel_invoiceAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_invoiceAddress.Controls.Add(this.checkBox_defaultInvoicingAddressCountryISO);
            this.panel_invoiceAddress.Controls.Add(this.label_useInvoicingAddress);
            this.panel_invoiceAddress.Controls.Add(this.label_invoicingAddress);
            this.panel_invoiceAddress.Controls.Add(this.label_invoicingAddressCity);
            this.panel_invoiceAddress.Controls.Add(this.label_invoicingAddressZipCode);
            this.panel_invoiceAddress.Controls.Add(this.label_invoicingAddress2);
            this.panel_invoiceAddress.Controls.Add(this.label_invoicingAddress3);
            this.panel_invoiceAddress.Controls.Add(this.label_invoicingAddressState);
            this.panel_invoiceAddress.Controls.Add(this.label_invoicingAddressCountryID);
            this.panel_invoiceAddress.Controls.Add(this.comboBox_useInvoicingAddress);
            this.panel_invoiceAddress.Controls.Add(this.comboBox_invoicingAddress);
            this.panel_invoiceAddress.Controls.Add(this.comboBox_invoicingAddress2);
            this.panel_invoiceAddress.Controls.Add(this.comboBox_invoicingAddress3);
            this.panel_invoiceAddress.Controls.Add(this.comboBox_invoicingAddressZipCode);
            this.panel_invoiceAddress.Controls.Add(this.comboBox_invoicingAddressCity);
            this.panel_invoiceAddress.Controls.Add(this.comboBox_invoicingAddressState);
            this.panel_invoiceAddress.Controls.Add(this.comboBox_invoicingAddressCountryISO);
            this.panel_invoiceAddress.Location = new System.Drawing.Point(4, 1097);
            this.panel_invoiceAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_invoiceAddress.MaximumSize = new System.Drawing.Size(609, 442);
            this.panel_invoiceAddress.MinimumSize = new System.Drawing.Size(609, 0);
            this.panel_invoiceAddress.Name = "panel_invoiceAddress";
            this.panel_invoiceAddress.Size = new System.Drawing.Size(609, 442);
            this.panel_invoiceAddress.TabIndex = 3;
            // 
            // checkBox_defaultInvoicingAddressCountryISO
            // 
            this.checkBox_defaultInvoicingAddressCountryISO.AutoSize = true;
            this.checkBox_defaultInvoicingAddressCountryISO.Location = new System.Drawing.Point(487, 385);
            this.checkBox_defaultInvoicingAddressCountryISO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_defaultInvoicingAddressCountryISO.Name = "checkBox_defaultInvoicingAddressCountryISO";
            this.checkBox_defaultInvoicingAddressCountryISO.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultInvoicingAddressCountryISO.TabIndex = 6;
            this.checkBox_defaultInvoicingAddressCountryISO.Text = "Default";
            this.checkBox_defaultInvoicingAddressCountryISO.UseVisualStyleBackColor = true;
            this.checkBox_defaultInvoicingAddressCountryISO.CheckedChanged += new System.EventHandler(this.checkBox_defaultInvoiceAddressCountryISO_CheckedChanged);
            // 
            // label_useInvoicingAddress
            // 
            this.label_useInvoicingAddress.AutoSize = true;
            this.label_useInvoicingAddress.Location = new System.Drawing.Point(14, 25);
            this.label_useInvoicingAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_useInvoicingAddress.Name = "label_useInvoicingAddress";
            this.label_useInvoicingAddress.Size = new System.Drawing.Size(142, 17);
            this.label_useInvoicingAddress.TabIndex = 1;
            this.label_useInvoicingAddress.Text = "Use Invoicing Address";
            // 
            // label_invoicingAddress
            // 
            this.label_invoicingAddress.AutoSize = true;
            this.label_invoicingAddress.Location = new System.Drawing.Point(14, 77);
            this.label_invoicingAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_invoicingAddress.Name = "label_invoicingAddress";
            this.label_invoicingAddress.Size = new System.Drawing.Size(116, 17);
            this.label_invoicingAddress.TabIndex = 1;
            this.label_invoicingAddress.Text = "Invoicing Address";
            // 
            // label_invoicingAddressCity
            // 
            this.label_invoicingAddressCity.AutoSize = true;
            this.label_invoicingAddressCity.Location = new System.Drawing.Point(14, 283);
            this.label_invoicingAddressCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_invoicingAddressCity.Name = "label_invoicingAddressCity";
            this.label_invoicingAddressCity.Size = new System.Drawing.Size(143, 17);
            this.label_invoicingAddressCity.TabIndex = 1;
            this.label_invoicingAddressCity.Text = "Invoicing Address City";
            // 
            // label_invoicingAddressZipCode
            // 
            this.label_invoicingAddressZipCode.AutoSize = true;
            this.label_invoicingAddressZipCode.Location = new System.Drawing.Point(14, 232);
            this.label_invoicingAddressZipCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_invoicingAddressZipCode.Name = "label_invoicingAddressZipCode";
            this.label_invoicingAddressZipCode.Size = new System.Drawing.Size(174, 17);
            this.label_invoicingAddressZipCode.TabIndex = 1;
            this.label_invoicingAddressZipCode.Text = "Invoicing Address Zip Code";
            // 
            // label_invoicingAddress2
            // 
            this.label_invoicingAddress2.AutoSize = true;
            this.label_invoicingAddress2.Location = new System.Drawing.Point(14, 128);
            this.label_invoicingAddress2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_invoicingAddress2.Name = "label_invoicingAddress2";
            this.label_invoicingAddress2.Size = new System.Drawing.Size(127, 17);
            this.label_invoicingAddress2.TabIndex = 1;
            this.label_invoicingAddress2.Text = "Invoicing Address 2";
            // 
            // label_invoicingAddress3
            // 
            this.label_invoicingAddress3.AutoSize = true;
            this.label_invoicingAddress3.Location = new System.Drawing.Point(14, 180);
            this.label_invoicingAddress3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_invoicingAddress3.Name = "label_invoicingAddress3";
            this.label_invoicingAddress3.Size = new System.Drawing.Size(127, 17);
            this.label_invoicingAddress3.TabIndex = 1;
            this.label_invoicingAddress3.Text = "Invoicing Address 3";
            // 
            // label_invoicingAddressState
            // 
            this.label_invoicingAddressState.AutoSize = true;
            this.label_invoicingAddressState.Location = new System.Drawing.Point(14, 335);
            this.label_invoicingAddressState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_invoicingAddressState.Name = "label_invoicingAddressState";
            this.label_invoicingAddressState.Size = new System.Drawing.Size(151, 17);
            this.label_invoicingAddressState.TabIndex = 1;
            this.label_invoicingAddressState.Text = "Invoicing Address State";
            // 
            // label_invoicingAddressCountryID
            // 
            this.label_invoicingAddressCountryID.AutoSize = true;
            this.label_invoicingAddressCountryID.Location = new System.Drawing.Point(14, 387);
            this.label_invoicingAddressCountryID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_invoicingAddressCountryID.Name = "label_invoicingAddressCountryID";
            this.label_invoicingAddressCountryID.Size = new System.Drawing.Size(187, 17);
            this.label_invoicingAddressCountryID.TabIndex = 5;
            this.label_invoicingAddressCountryID.Text = "Invoicing Address Country ID";
            // 
            // comboBox_useInvoicingAddress
            // 
            this.comboBox_useInvoicingAddress.FormattingEnabled = true;
            this.comboBox_useInvoicingAddress.Location = new System.Drawing.Point(289, 20);
            this.comboBox_useInvoicingAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_useInvoicingAddress.Name = "comboBox_useInvoicingAddress";
            this.comboBox_useInvoicingAddress.Size = new System.Drawing.Size(188, 25);
            this.comboBox_useInvoicingAddress.TabIndex = 3;
            // 
            // comboBox_invoicingAddress
            // 
            this.comboBox_invoicingAddress.FormattingEnabled = true;
            this.comboBox_invoicingAddress.Location = new System.Drawing.Point(289, 72);
            this.comboBox_invoicingAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_invoicingAddress.Name = "comboBox_invoicingAddress";
            this.comboBox_invoicingAddress.Size = new System.Drawing.Size(188, 25);
            this.comboBox_invoicingAddress.TabIndex = 3;
            // 
            // comboBox_invoicingAddress2
            // 
            this.comboBox_invoicingAddress2.FormattingEnabled = true;
            this.comboBox_invoicingAddress2.Location = new System.Drawing.Point(289, 123);
            this.comboBox_invoicingAddress2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_invoicingAddress2.Name = "comboBox_invoicingAddress2";
            this.comboBox_invoicingAddress2.Size = new System.Drawing.Size(188, 25);
            this.comboBox_invoicingAddress2.TabIndex = 3;
            // 
            // comboBox_invoicingAddress3
            // 
            this.comboBox_invoicingAddress3.FormattingEnabled = true;
            this.comboBox_invoicingAddress3.Location = new System.Drawing.Point(289, 175);
            this.comboBox_invoicingAddress3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_invoicingAddress3.Name = "comboBox_invoicingAddress3";
            this.comboBox_invoicingAddress3.Size = new System.Drawing.Size(188, 25);
            this.comboBox_invoicingAddress3.TabIndex = 3;
            // 
            // comboBox_invoicingAddressZipCode
            // 
            this.comboBox_invoicingAddressZipCode.FormattingEnabled = true;
            this.comboBox_invoicingAddressZipCode.Location = new System.Drawing.Point(289, 227);
            this.comboBox_invoicingAddressZipCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_invoicingAddressZipCode.Name = "comboBox_invoicingAddressZipCode";
            this.comboBox_invoicingAddressZipCode.Size = new System.Drawing.Size(188, 25);
            this.comboBox_invoicingAddressZipCode.TabIndex = 3;
            // 
            // comboBox_invoicingAddressCity
            // 
            this.comboBox_invoicingAddressCity.FormattingEnabled = true;
            this.comboBox_invoicingAddressCity.Location = new System.Drawing.Point(289, 278);
            this.comboBox_invoicingAddressCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_invoicingAddressCity.Name = "comboBox_invoicingAddressCity";
            this.comboBox_invoicingAddressCity.Size = new System.Drawing.Size(188, 25);
            this.comboBox_invoicingAddressCity.TabIndex = 3;
            // 
            // comboBox_invoicingAddressState
            // 
            this.comboBox_invoicingAddressState.FormattingEnabled = true;
            this.comboBox_invoicingAddressState.Location = new System.Drawing.Point(289, 330);
            this.comboBox_invoicingAddressState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_invoicingAddressState.Name = "comboBox_invoicingAddressState";
            this.comboBox_invoicingAddressState.Size = new System.Drawing.Size(188, 25);
            this.comboBox_invoicingAddressState.TabIndex = 3;
            // 
            // comboBox_invoicingAddressCountryISO
            // 
            this.comboBox_invoicingAddressCountryISO.FormattingEnabled = true;
            this.comboBox_invoicingAddressCountryISO.Location = new System.Drawing.Point(289, 382);
            this.comboBox_invoicingAddressCountryISO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_invoicingAddressCountryISO.Name = "comboBox_invoicingAddressCountryISO";
            this.comboBox_invoicingAddressCountryISO.Size = new System.Drawing.Size(188, 25);
            this.comboBox_invoicingAddressCountryISO.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_financeCompanyInfo);
            this.panel2.Controls.Add(this.button_financeCompanyInfo);
            this.panel2.Location = new System.Drawing.Point(4, 1549);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(609, 53);
            this.panel2.TabIndex = 4;
            // 
            // label_financeCompanyInfo
            // 
            this.label_financeCompanyInfo.AutoSize = true;
            this.label_financeCompanyInfo.ForeColor = System.Drawing.Color.Black;
            this.label_financeCompanyInfo.Location = new System.Drawing.Point(64, 13);
            this.label_financeCompanyInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_financeCompanyInfo.Name = "label_financeCompanyInfo";
            this.label_financeCompanyInfo.Size = new System.Drawing.Size(153, 17);
            this.label_financeCompanyInfo.TabIndex = 1;
            this.label_financeCompanyInfo.Text = "Finance - Company Info";
            // 
            // button_financeCompanyInfo
            // 
            this.button_financeCompanyInfo.BackColor = System.Drawing.Color.White;
            this.button_financeCompanyInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_financeCompanyInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_financeCompanyInfo.FlatAppearance.BorderSize = 0;
            this.button_financeCompanyInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_financeCompanyInfo.Location = new System.Drawing.Point(13, 2);
            this.button_financeCompanyInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_financeCompanyInfo.Name = "button_financeCompanyInfo";
            this.button_financeCompanyInfo.Size = new System.Drawing.Size(43, 50);
            this.button_financeCompanyInfo.TabIndex = 0;
            this.button_financeCompanyInfo.UseVisualStyleBackColor = false;
            this.button_financeCompanyInfo.Click += new System.EventHandler(this.button_expand_Click);
            // 
            // panel_financeCompanyInfo
            // 
            this.panel_financeCompanyInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_financeCompanyInfo.Controls.Add(this.label_organizationNo);
            this.panel_financeCompanyInfo.Controls.Add(this.label_vatNo);
            this.panel_financeCompanyInfo.Controls.Add(this.comboBox_organizationNo);
            this.panel_financeCompanyInfo.Controls.Add(this.comboBox_VATNo);
            this.panel_financeCompanyInfo.Controls.Add(this.comboBox_eanNo);
            this.panel_financeCompanyInfo.Controls.Add(this.comboBox_useEanNo);
            this.panel_financeCompanyInfo.Controls.Add(this.label_eanNo);
            this.panel_financeCompanyInfo.Controls.Add(this.label_useEanNo);
            this.panel_financeCompanyInfo.Location = new System.Drawing.Point(4, 1612);
            this.panel_financeCompanyInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_financeCompanyInfo.MaximumSize = new System.Drawing.Size(609, 235);
            this.panel_financeCompanyInfo.MinimumSize = new System.Drawing.Size(609, 0);
            this.panel_financeCompanyInfo.Name = "panel_financeCompanyInfo";
            this.panel_financeCompanyInfo.Size = new System.Drawing.Size(609, 235);
            this.panel_financeCompanyInfo.TabIndex = 5;
            // 
            // label_organizationNo
            // 
            this.label_organizationNo.AutoSize = true;
            this.label_organizationNo.Location = new System.Drawing.Point(14, 25);
            this.label_organizationNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_organizationNo.Name = "label_organizationNo";
            this.label_organizationNo.Size = new System.Drawing.Size(108, 17);
            this.label_organizationNo.TabIndex = 1;
            this.label_organizationNo.Text = "Organization No";
            // 
            // label_vatNo
            // 
            this.label_vatNo.AutoSize = true;
            this.label_vatNo.Location = new System.Drawing.Point(14, 77);
            this.label_vatNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_vatNo.Name = "label_vatNo";
            this.label_vatNo.Size = new System.Drawing.Size(52, 17);
            this.label_vatNo.TabIndex = 1;
            this.label_vatNo.Text = "VAT No";
            // 
            // comboBox_organizationNo
            // 
            this.comboBox_organizationNo.FormattingEnabled = true;
            this.comboBox_organizationNo.Location = new System.Drawing.Point(193, 20);
            this.comboBox_organizationNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_organizationNo.Name = "comboBox_organizationNo";
            this.comboBox_organizationNo.Size = new System.Drawing.Size(188, 25);
            this.comboBox_organizationNo.TabIndex = 3;
            // 
            // comboBox_VATNo
            // 
            this.comboBox_VATNo.FormattingEnabled = true;
            this.comboBox_VATNo.Location = new System.Drawing.Point(193, 72);
            this.comboBox_VATNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_VATNo.Name = "comboBox_VATNo";
            this.comboBox_VATNo.Size = new System.Drawing.Size(188, 25);
            this.comboBox_VATNo.TabIndex = 3;
            // 
            // comboBox_eanNo
            // 
            this.comboBox_eanNo.FormattingEnabled = true;
            this.comboBox_eanNo.Location = new System.Drawing.Point(193, 175);
            this.comboBox_eanNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_eanNo.Name = "comboBox_eanNo";
            this.comboBox_eanNo.Size = new System.Drawing.Size(188, 25);
            this.comboBox_eanNo.TabIndex = 3;
            // 
            // comboBox_useEanNo
            // 
            this.comboBox_useEanNo.FormattingEnabled = true;
            this.comboBox_useEanNo.Location = new System.Drawing.Point(193, 123);
            this.comboBox_useEanNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_useEanNo.Name = "comboBox_useEanNo";
            this.comboBox_useEanNo.Size = new System.Drawing.Size(188, 25);
            this.comboBox_useEanNo.TabIndex = 3;
            // 
            // label_eanNo
            // 
            this.label_eanNo.AutoSize = true;
            this.label_eanNo.Location = new System.Drawing.Point(14, 180);
            this.label_eanNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_eanNo.Name = "label_eanNo";
            this.label_eanNo.Size = new System.Drawing.Size(52, 17);
            this.label_eanNo.TabIndex = 1;
            this.label_eanNo.Text = "Ean No";
            // 
            // label_useEanNo
            // 
            this.label_useEanNo.AutoSize = true;
            this.label_useEanNo.Location = new System.Drawing.Point(14, 128);
            this.label_useEanNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_useEanNo.Name = "label_useEanNo";
            this.label_useEanNo.Size = new System.Drawing.Size(78, 17);
            this.label_useEanNo.TabIndex = 1;
            this.label_useEanNo.Text = "Use Ean No";
            // 
            // panel_defaultInvoiceSettingsButton
            // 
            this.panel_defaultInvoiceSettingsButton.Controls.Add(this.label_defaultInvoiceSettings);
            this.panel_defaultInvoiceSettingsButton.Controls.Add(this.button_defaultInvoiceSettings);
            this.panel_defaultInvoiceSettingsButton.Location = new System.Drawing.Point(4, 1857);
            this.panel_defaultInvoiceSettingsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_defaultInvoiceSettingsButton.Name = "panel_defaultInvoiceSettingsButton";
            this.panel_defaultInvoiceSettingsButton.Size = new System.Drawing.Size(609, 53);
            this.panel_defaultInvoiceSettingsButton.TabIndex = 6;
            // 
            // label_defaultInvoiceSettings
            // 
            this.label_defaultInvoiceSettings.AutoSize = true;
            this.label_defaultInvoiceSettings.ForeColor = System.Drawing.Color.Black;
            this.label_defaultInvoiceSettings.Location = new System.Drawing.Point(64, 13);
            this.label_defaultInvoiceSettings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_defaultInvoiceSettings.Name = "label_defaultInvoiceSettings";
            this.label_defaultInvoiceSettings.Size = new System.Drawing.Size(210, 17);
            this.label_defaultInvoiceSettings.TabIndex = 1;
            this.label_defaultInvoiceSettings.Text = "Finance - Default Invoice Settings";
            // 
            // button_defaultInvoiceSettings
            // 
            this.button_defaultInvoiceSettings.BackColor = System.Drawing.Color.White;
            this.button_defaultInvoiceSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_defaultInvoiceSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_defaultInvoiceSettings.FlatAppearance.BorderSize = 0;
            this.button_defaultInvoiceSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_defaultInvoiceSettings.Location = new System.Drawing.Point(13, 2);
            this.button_defaultInvoiceSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_defaultInvoiceSettings.Name = "button_defaultInvoiceSettings";
            this.button_defaultInvoiceSettings.Size = new System.Drawing.Size(43, 50);
            this.button_defaultInvoiceSettings.TabIndex = 0;
            this.button_defaultInvoiceSettings.UseVisualStyleBackColor = false;
            this.button_defaultInvoiceSettings.Click += new System.EventHandler(this.button_expand_Click);
            // 
            // panel_defaultInvoiceSettings
            // 
            this.panel_defaultInvoiceSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_defaultInvoiceSettings.Controls.Add(this.checkBox_defaultVATPercentage);
            this.panel_defaultInvoiceSettings.Controls.Add(this.checkBox_defaultPaymentTerm);
            this.panel_defaultInvoiceSettings.Controls.Add(this.label_paymentTerm);
            this.panel_defaultInvoiceSettings.Controls.Add(this.label_discountPercentage);
            this.panel_defaultInvoiceSettings.Controls.Add(this.label_calculateVAT);
            this.panel_defaultInvoiceSettings.Controls.Add(this.comboBox_VATPercentage);
            this.panel_defaultInvoiceSettings.Controls.Add(this.label_vatPercentage);
            this.panel_defaultInvoiceSettings.Controls.Add(this.comboBox_calculateVAT);
            this.panel_defaultInvoiceSettings.Controls.Add(this.comboBox_discountPercentage);
            this.panel_defaultInvoiceSettings.Controls.Add(this.comboBox_paymentTerm);
            this.panel_defaultInvoiceSettings.Location = new System.Drawing.Point(4, 1920);
            this.panel_defaultInvoiceSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_defaultInvoiceSettings.MaximumSize = new System.Drawing.Size(609, 442);
            this.panel_defaultInvoiceSettings.MinimumSize = new System.Drawing.Size(609, 0);
            this.panel_defaultInvoiceSettings.Name = "panel_defaultInvoiceSettings";
            this.panel_defaultInvoiceSettings.Size = new System.Drawing.Size(609, 253);
            this.panel_defaultInvoiceSettings.TabIndex = 7;
            // 
            // checkBox_defaultVATPercentage
            // 
            this.checkBox_defaultVATPercentage.AutoSize = true;
            this.checkBox_defaultVATPercentage.Location = new System.Drawing.Point(473, 179);
            this.checkBox_defaultVATPercentage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_defaultVATPercentage.Name = "checkBox_defaultVATPercentage";
            this.checkBox_defaultVATPercentage.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultVATPercentage.TabIndex = 8;
            this.checkBox_defaultVATPercentage.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultVATPercentage, "Set default values for all rows of a particular column field");
            this.checkBox_defaultVATPercentage.UseVisualStyleBackColor = true;
            this.checkBox_defaultVATPercentage.CheckedChanged += new System.EventHandler(this.checkBox_defaultVATPercentage_CheckedChanged);
            // 
            // checkBox_defaultPaymentTerm
            // 
            this.checkBox_defaultPaymentTerm.AutoSize = true;
            this.checkBox_defaultPaymentTerm.Location = new System.Drawing.Point(473, 22);
            this.checkBox_defaultPaymentTerm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_defaultPaymentTerm.Name = "checkBox_defaultPaymentTerm";
            this.checkBox_defaultPaymentTerm.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultPaymentTerm.TabIndex = 8;
            this.checkBox_defaultPaymentTerm.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultPaymentTerm, "Set default values for all rows of a particular column field");
            this.checkBox_defaultPaymentTerm.UseVisualStyleBackColor = true;
            this.checkBox_defaultPaymentTerm.CheckedChanged += new System.EventHandler(this.checkBox_defaultPaymentTerm_CheckedChanged);
            // 
            // label_paymentTerm
            // 
            this.label_paymentTerm.AutoSize = true;
            this.label_paymentTerm.Location = new System.Drawing.Point(20, 24);
            this.label_paymentTerm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_paymentTerm.Name = "label_paymentTerm";
            this.label_paymentTerm.Size = new System.Drawing.Size(96, 17);
            this.label_paymentTerm.TabIndex = 1;
            this.label_paymentTerm.Text = "Payment Term";
            // 
            // label_discountPercentage
            // 
            this.label_discountPercentage.AutoSize = true;
            this.label_discountPercentage.Location = new System.Drawing.Point(20, 77);
            this.label_discountPercentage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_discountPercentage.Name = "label_discountPercentage";
            this.label_discountPercentage.Size = new System.Drawing.Size(133, 17);
            this.label_discountPercentage.TabIndex = 1;
            this.label_discountPercentage.Text = "Discount Percentage";
            // 
            // label_calculateVAT
            // 
            this.label_calculateVAT.AutoSize = true;
            this.label_calculateVAT.Location = new System.Drawing.Point(20, 129);
            this.label_calculateVAT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_calculateVAT.Name = "label_calculateVAT";
            this.label_calculateVAT.Size = new System.Drawing.Size(88, 17);
            this.label_calculateVAT.TabIndex = 1;
            this.label_calculateVAT.Text = "Calculate VAT";
            // 
            // comboBox_VATPercentage
            // 
            this.comboBox_VATPercentage.FormattingEnabled = true;
            this.comboBox_VATPercentage.Location = new System.Drawing.Point(247, 176);
            this.comboBox_VATPercentage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_VATPercentage.Name = "comboBox_VATPercentage";
            this.comboBox_VATPercentage.Size = new System.Drawing.Size(215, 25);
            this.comboBox_VATPercentage.TabIndex = 3;
            // 
            // label_vatPercentage
            // 
            this.label_vatPercentage.AutoSize = true;
            this.label_vatPercentage.Location = new System.Drawing.Point(20, 181);
            this.label_vatPercentage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_vatPercentage.Name = "label_vatPercentage";
            this.label_vatPercentage.Size = new System.Drawing.Size(102, 17);
            this.label_vatPercentage.TabIndex = 1;
            this.label_vatPercentage.Text = "VAT Percentage";
            // 
            // comboBox_calculateVAT
            // 
            this.comboBox_calculateVAT.FormattingEnabled = true;
            this.comboBox_calculateVAT.Location = new System.Drawing.Point(247, 124);
            this.comboBox_calculateVAT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_calculateVAT.Name = "comboBox_calculateVAT";
            this.comboBox_calculateVAT.Size = new System.Drawing.Size(215, 25);
            this.comboBox_calculateVAT.TabIndex = 3;
            // 
            // comboBox_discountPercentage
            // 
            this.comboBox_discountPercentage.FormattingEnabled = true;
            this.comboBox_discountPercentage.Location = new System.Drawing.Point(247, 72);
            this.comboBox_discountPercentage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_discountPercentage.Name = "comboBox_discountPercentage";
            this.comboBox_discountPercentage.Size = new System.Drawing.Size(215, 25);
            this.comboBox_discountPercentage.TabIndex = 3;
            // 
            // comboBox_paymentTerm
            // 
            this.comboBox_paymentTerm.FormattingEnabled = true;
            this.comboBox_paymentTerm.Location = new System.Drawing.Point(247, 21);
            this.comboBox_paymentTerm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_paymentTerm.Name = "comboBox_paymentTerm";
            this.comboBox_paymentTerm.Size = new System.Drawing.Size(215, 25);
            this.comboBox_paymentTerm.TabIndex = 3;
            // 
            // panel_invoiceExternalCosts
            // 
            this.panel_invoiceExternalCosts.Controls.Add(this.label_invoiceExternalCosts);
            this.panel_invoiceExternalCosts.Controls.Add(this.button_invoiceExternalCosts);
            this.panel_invoiceExternalCosts.Location = new System.Drawing.Point(4, 2183);
            this.panel_invoiceExternalCosts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_invoiceExternalCosts.Name = "panel_invoiceExternalCosts";
            this.panel_invoiceExternalCosts.Size = new System.Drawing.Size(609, 53);
            this.panel_invoiceExternalCosts.TabIndex = 8;
            // 
            // label_invoiceExternalCosts
            // 
            this.label_invoiceExternalCosts.AutoSize = true;
            this.label_invoiceExternalCosts.ForeColor = System.Drawing.Color.Black;
            this.label_invoiceExternalCosts.Location = new System.Drawing.Point(64, 13);
            this.label_invoiceExternalCosts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_invoiceExternalCosts.Name = "label_invoiceExternalCosts";
            this.label_invoiceExternalCosts.Size = new System.Drawing.Size(248, 17);
            this.label_invoiceExternalCosts.TabIndex = 1;
            this.label_invoiceExternalCosts.Text = "Finance - Re-Invoicing of External Costs";
            // 
            // button_invoiceExternalCosts
            // 
            this.button_invoiceExternalCosts.BackColor = System.Drawing.Color.White;
            this.button_invoiceExternalCosts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_invoiceExternalCosts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_invoiceExternalCosts.FlatAppearance.BorderSize = 0;
            this.button_invoiceExternalCosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_invoiceExternalCosts.Location = new System.Drawing.Point(13, 2);
            this.button_invoiceExternalCosts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_invoiceExternalCosts.Name = "button_invoiceExternalCosts";
            this.button_invoiceExternalCosts.Size = new System.Drawing.Size(43, 50);
            this.button_invoiceExternalCosts.TabIndex = 0;
            this.button_invoiceExternalCosts.UseVisualStyleBackColor = false;
            this.button_invoiceExternalCosts.Click += new System.EventHandler(this.button_expand_Click);
            // 
            // panel_incoiceExternalCosts
            // 
            this.panel_incoiceExternalCosts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_incoiceExternalCosts.Controls.Add(this.checkBox_defaultExpenseIsBillable);
            this.panel_incoiceExternalCosts.Controls.Add(this.checkBox_defaultMileageIsBillable);
            this.panel_incoiceExternalCosts.Controls.Add(this.label_defaultMileageDistance);
            this.panel_incoiceExternalCosts.Controls.Add(this.label_defaultDistIsMaxBillable);
            this.panel_incoiceExternalCosts.Controls.Add(this.label_expenseIsBillable);
            this.panel_incoiceExternalCosts.Controls.Add(this.label_mileageIsBillable);
            this.panel_incoiceExternalCosts.Controls.Add(this.comboBox_defaultDistIsMaxBillable);
            this.panel_incoiceExternalCosts.Controls.Add(this.comboBox_defaultMileageDistance);
            this.panel_incoiceExternalCosts.Controls.Add(this.comboBox_expenseIsBillable);
            this.panel_incoiceExternalCosts.Controls.Add(this.comboBox_mileageIsBillable);
            this.panel_incoiceExternalCosts.Location = new System.Drawing.Point(4, 2246);
            this.panel_incoiceExternalCosts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_incoiceExternalCosts.MaximumSize = new System.Drawing.Size(609, 235);
            this.panel_incoiceExternalCosts.MinimumSize = new System.Drawing.Size(609, 0);
            this.panel_incoiceExternalCosts.Name = "panel_incoiceExternalCosts";
            this.panel_incoiceExternalCosts.Size = new System.Drawing.Size(609, 235);
            this.panel_incoiceExternalCosts.TabIndex = 9;
            // 
            // checkBox_defaultExpenseIsBillable
            // 
            this.checkBox_defaultExpenseIsBillable.AutoSize = true;
            this.checkBox_defaultExpenseIsBillable.Location = new System.Drawing.Point(487, 77);
            this.checkBox_defaultExpenseIsBillable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_defaultExpenseIsBillable.Name = "checkBox_defaultExpenseIsBillable";
            this.checkBox_defaultExpenseIsBillable.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultExpenseIsBillable.TabIndex = 5;
            this.checkBox_defaultExpenseIsBillable.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultExpenseIsBillable, "Set default values for all rows of a particular column field");
            this.checkBox_defaultExpenseIsBillable.UseVisualStyleBackColor = true;
            this.checkBox_defaultExpenseIsBillable.CheckedChanged += new System.EventHandler(this.checkBox_defaultExpenseIsBillable_CheckedChanged);
            // 
            // checkBox_defaultMileageIsBillable
            // 
            this.checkBox_defaultMileageIsBillable.AutoSize = true;
            this.checkBox_defaultMileageIsBillable.Location = new System.Drawing.Point(487, 127);
            this.checkBox_defaultMileageIsBillable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_defaultMileageIsBillable.Name = "checkBox_defaultMileageIsBillable";
            this.checkBox_defaultMileageIsBillable.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultMileageIsBillable.TabIndex = 4;
            this.checkBox_defaultMileageIsBillable.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultMileageIsBillable, "Set default values for all rows of a particular column field");
            this.checkBox_defaultMileageIsBillable.UseVisualStyleBackColor = true;
            this.checkBox_defaultMileageIsBillable.CheckedChanged += new System.EventHandler(this.checkBox_defaultMileageIsBillable_CheckedChanged);
            // 
            // label_defaultMileageDistance
            // 
            this.label_defaultMileageDistance.AutoSize = true;
            this.label_defaultMileageDistance.Location = new System.Drawing.Point(14, 25);
            this.label_defaultMileageDistance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_defaultMileageDistance.Name = "label_defaultMileageDistance";
            this.label_defaultMileageDistance.Size = new System.Drawing.Size(157, 17);
            this.label_defaultMileageDistance.TabIndex = 1;
            this.label_defaultMileageDistance.Text = "Default Mileage Distance";
            // 
            // label_defaultDistIsMaxBillable
            // 
            this.label_defaultDistIsMaxBillable.AutoSize = true;
            this.label_defaultDistIsMaxBillable.Location = new System.Drawing.Point(14, 180);
            this.label_defaultDistIsMaxBillable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_defaultDistIsMaxBillable.Name = "label_defaultDistIsMaxBillable";
            this.label_defaultDistIsMaxBillable.Size = new System.Drawing.Size(168, 17);
            this.label_defaultDistIsMaxBillable.TabIndex = 1;
            this.label_defaultDistIsMaxBillable.Text = "Default Dist Is Max Billable";
            // 
            // label_expenseIsBillable
            // 
            this.label_expenseIsBillable.AutoSize = true;
            this.label_expenseIsBillable.Location = new System.Drawing.Point(14, 77);
            this.label_expenseIsBillable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_expenseIsBillable.Name = "label_expenseIsBillable";
            this.label_expenseIsBillable.Size = new System.Drawing.Size(118, 17);
            this.label_expenseIsBillable.TabIndex = 1;
            this.label_expenseIsBillable.Text = "Expense Is Billable";
            // 
            // label_mileageIsBillable
            // 
            this.label_mileageIsBillable.AutoSize = true;
            this.label_mileageIsBillable.Location = new System.Drawing.Point(14, 128);
            this.label_mileageIsBillable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_mileageIsBillable.Name = "label_mileageIsBillable";
            this.label_mileageIsBillable.Size = new System.Drawing.Size(115, 17);
            this.label_mileageIsBillable.TabIndex = 1;
            this.label_mileageIsBillable.Text = "Mileage Is Billable";
            // 
            // comboBox_defaultDistIsMaxBillable
            // 
            this.comboBox_defaultDistIsMaxBillable.FormattingEnabled = true;
            this.comboBox_defaultDistIsMaxBillable.Location = new System.Drawing.Point(266, 175);
            this.comboBox_defaultDistIsMaxBillable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_defaultDistIsMaxBillable.Name = "comboBox_defaultDistIsMaxBillable";
            this.comboBox_defaultDistIsMaxBillable.Size = new System.Drawing.Size(257, 25);
            this.comboBox_defaultDistIsMaxBillable.TabIndex = 3;
            // 
            // comboBox_defaultMileageDistance
            // 
            this.comboBox_defaultMileageDistance.FormattingEnabled = true;
            this.comboBox_defaultMileageDistance.Location = new System.Drawing.Point(266, 20);
            this.comboBox_defaultMileageDistance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_defaultMileageDistance.Name = "comboBox_defaultMileageDistance";
            this.comboBox_defaultMileageDistance.Size = new System.Drawing.Size(257, 25);
            this.comboBox_defaultMileageDistance.TabIndex = 3;
            // 
            // comboBox_expenseIsBillable
            // 
            this.comboBox_expenseIsBillable.FormattingEnabled = true;
            this.comboBox_expenseIsBillable.Location = new System.Drawing.Point(266, 72);
            this.comboBox_expenseIsBillable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_expenseIsBillable.Name = "comboBox_expenseIsBillable";
            this.comboBox_expenseIsBillable.Size = new System.Drawing.Size(211, 25);
            this.comboBox_expenseIsBillable.TabIndex = 3;
            // 
            // comboBox_mileageIsBillable
            // 
            this.comboBox_mileageIsBillable.FormattingEnabled = true;
            this.comboBox_mileageIsBillable.Location = new System.Drawing.Point(266, 123);
            this.comboBox_mileageIsBillable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_mileageIsBillable.Name = "comboBox_mileageIsBillable";
            this.comboBox_mileageIsBillable.Size = new System.Drawing.Size(211, 25);
            this.comboBox_mileageIsBillable.TabIndex = 3;
            // 
            // label_delimiter
            // 
            this.label_delimiter.AutoSize = true;
            this.label_delimiter.Location = new System.Drawing.Point(14, 125);
            this.label_delimiter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_delimiter.Name = "label_delimiter";
            this.label_delimiter.Size = new System.Drawing.Size(62, 17);
            this.label_delimiter.TabIndex = 1;
            this.label_delimiter.Text = "Delimiter";
            // 
            // comboBox_delimiter
            // 
            this.comboBox_delimiter.FormattingEnabled = true;
            this.comboBox_delimiter.Location = new System.Drawing.Point(117, 120);
            this.comboBox_delimiter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_delimiter.Name = "comboBox_delimiter";
            this.comboBox_delimiter.Size = new System.Drawing.Size(78, 25);
            this.comboBox_delimiter.TabIndex = 7;
            // 
            // groupBox_customerMandatoryFields
            // 
            this.groupBox_customerMandatoryFields.Controls.Add(this.checkBox_defaultCountryISO);
            this.groupBox_customerMandatoryFields.Controls.Add(this.checkBox_defaultCustomerStatus);
            this.groupBox_customerMandatoryFields.Controls.Add(this.checkBox_defaultCurrencyISO);
            this.groupBox_customerMandatoryFields.Controls.Add(this.label_countryISO);
            this.groupBox_customerMandatoryFields.Controls.Add(this.label_customerStatus);
            this.groupBox_customerMandatoryFields.Controls.Add(this.comboBox_countryISO);
            this.groupBox_customerMandatoryFields.Controls.Add(this.comboBox_customerStatus);
            this.groupBox_customerMandatoryFields.Controls.Add(this.label_currencyISO);
            this.groupBox_customerMandatoryFields.Controls.Add(this.comboBox_currencyISO);
            this.groupBox_customerMandatoryFields.Controls.Add(this.label_customerName);
            this.groupBox_customerMandatoryFields.Controls.Add(this.comboBox_customerName);
            this.groupBox_customerMandatoryFields.Location = new System.Drawing.Point(241, 125);
            this.groupBox_customerMandatoryFields.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_customerMandatoryFields.Name = "groupBox_customerMandatoryFields";
            this.groupBox_customerMandatoryFields.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_customerMandatoryFields.Size = new System.Drawing.Size(500, 275);
            this.groupBox_customerMandatoryFields.TabIndex = 5;
            this.groupBox_customerMandatoryFields.TabStop = false;
            this.groupBox_customerMandatoryFields.Text = "Mandatory";
            // 
            // checkBox_defaultCountryISO
            // 
            this.checkBox_defaultCountryISO.AutoSize = true;
            this.checkBox_defaultCountryISO.Location = new System.Drawing.Point(396, 205);
            this.checkBox_defaultCountryISO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_defaultCountryISO.Name = "checkBox_defaultCountryISO";
            this.checkBox_defaultCountryISO.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultCountryISO.TabIndex = 8;
            this.checkBox_defaultCountryISO.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultCountryISO, "Set default values for all rows of a particular column field");
            this.checkBox_defaultCountryISO.UseVisualStyleBackColor = true;
            this.checkBox_defaultCountryISO.CheckedChanged += new System.EventHandler(this.checkBox_defaultCountryISO_CheckedChanged);
            // 
            // checkBox_defaultCustomerStatus
            // 
            this.checkBox_defaultCustomerStatus.AutoSize = true;
            this.checkBox_defaultCustomerStatus.Location = new System.Drawing.Point(396, 153);
            this.checkBox_defaultCustomerStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_defaultCustomerStatus.Name = "checkBox_defaultCustomerStatus";
            this.checkBox_defaultCustomerStatus.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultCustomerStatus.TabIndex = 8;
            this.checkBox_defaultCustomerStatus.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultCustomerStatus, "Set default values for all rows of a particular column field");
            this.checkBox_defaultCustomerStatus.UseVisualStyleBackColor = true;
            this.checkBox_defaultCustomerStatus.CheckedChanged += new System.EventHandler(this.checkBox_defaultCustomerStatus_CheckedChanged);
            // 
            // checkBox_defaultCurrencyISO
            // 
            this.checkBox_defaultCurrencyISO.AutoSize = true;
            this.checkBox_defaultCurrencyISO.Location = new System.Drawing.Point(396, 105);
            this.checkBox_defaultCurrencyISO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_defaultCurrencyISO.Name = "checkBox_defaultCurrencyISO";
            this.checkBox_defaultCurrencyISO.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultCurrencyISO.TabIndex = 8;
            this.checkBox_defaultCurrencyISO.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultCurrencyISO, "Set default values for all rows of a particular column field");
            this.checkBox_defaultCurrencyISO.UseVisualStyleBackColor = true;
            this.checkBox_defaultCurrencyISO.CheckedChanged += new System.EventHandler(this.checkBox_defaultCurrencyISO_CheckedChanged);
            // 
            // label_countryISO
            // 
            this.label_countryISO.AutoSize = true;
            this.label_countryISO.Location = new System.Drawing.Point(9, 207);
            this.label_countryISO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_countryISO.Name = "label_countryISO";
            this.label_countryISO.Size = new System.Drawing.Size(83, 17);
            this.label_countryISO.TabIndex = 5;
            this.label_countryISO.Text = "Country ISO";
            // 
            // label_customerStatus
            // 
            this.label_customerStatus.AutoSize = true;
            this.label_customerStatus.Location = new System.Drawing.Point(7, 155);
            this.label_customerStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_customerStatus.Name = "label_customerStatus";
            this.label_customerStatus.Size = new System.Drawing.Size(109, 17);
            this.label_customerStatus.TabIndex = 5;
            this.label_customerStatus.Text = "Customer Status";
            // 
            // comboBox_countryISO
            // 
            this.comboBox_countryISO.FormattingEnabled = true;
            this.comboBox_countryISO.Location = new System.Drawing.Point(197, 202);
            this.comboBox_countryISO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_countryISO.Name = "comboBox_countryISO";
            this.comboBox_countryISO.Size = new System.Drawing.Size(188, 25);
            this.comboBox_countryISO.TabIndex = 7;
            // 
            // comboBox_customerStatus
            // 
            this.comboBox_customerStatus.FormattingEnabled = true;
            this.comboBox_customerStatus.Location = new System.Drawing.Point(197, 150);
            this.comboBox_customerStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_customerStatus.Name = "comboBox_customerStatus";
            this.comboBox_customerStatus.Size = new System.Drawing.Size(188, 25);
            this.comboBox_customerStatus.TabIndex = 6;
            // 
            // label_currencyISO
            // 
            this.label_currencyISO.AutoSize = true;
            this.label_currencyISO.Location = new System.Drawing.Point(9, 103);
            this.label_currencyISO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_currencyISO.Name = "label_currencyISO";
            this.label_currencyISO.Size = new System.Drawing.Size(87, 17);
            this.label_currencyISO.TabIndex = 5;
            this.label_currencyISO.Text = "Currency ISO";
            // 
            // comboBox_currencyISO
            // 
            this.comboBox_currencyISO.FormattingEnabled = true;
            this.comboBox_currencyISO.Location = new System.Drawing.Point(197, 98);
            this.comboBox_currencyISO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_currencyISO.Name = "comboBox_currencyISO";
            this.comboBox_currencyISO.Size = new System.Drawing.Size(188, 25);
            this.comboBox_currencyISO.TabIndex = 4;
            // 
            // label_customerName
            // 
            this.label_customerName.AutoSize = true;
            this.label_customerName.Location = new System.Drawing.Point(9, 52);
            this.label_customerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_customerName.Name = "label_customerName";
            this.label_customerName.Size = new System.Drawing.Size(107, 17);
            this.label_customerName.TabIndex = 1;
            this.label_customerName.Text = "Customer Name";
            // 
            // comboBox_customerName
            // 
            this.comboBox_customerName.FormattingEnabled = true;
            this.comboBox_customerName.Location = new System.Drawing.Point(197, 47);
            this.comboBox_customerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_customerName.Name = "comboBox_customerName";
            this.comboBox_customerName.Size = new System.Drawing.Size(188, 25);
            this.comboBox_customerName.TabIndex = 3;
            // 
            // label_customerSetup
            // 
            this.label_customerSetup.AutoSize = true;
            this.label_customerSetup.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_customerSetup.Location = new System.Drawing.Point(9, 27);
            this.label_customerSetup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_customerSetup.Name = "label_customerSetup";
            this.label_customerSetup.Size = new System.Drawing.Size(260, 32);
            this.label_customerSetup.TabIndex = 0;
            this.label_customerSetup.Text = "Customer Data Import";
            // 
            // button_customerSelectFile
            // 
            this.button_customerSelectFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(43)))), ((int)(((byte)(141)))));
            this.button_customerSelectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_customerSelectFile.FlatAppearance.BorderSize = 0;
            this.button_customerSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_customerSelectFile.ForeColor = System.Drawing.Color.White;
            this.button_customerSelectFile.Location = new System.Drawing.Point(19, 185);
            this.button_customerSelectFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_customerSelectFile.Name = "button_customerSelectFile";
            this.button_customerSelectFile.Size = new System.Drawing.Size(114, 48);
            this.button_customerSelectFile.TabIndex = 4;
            this.button_customerSelectFile.Text = "Select File";
            this.defaultToolTip.SetToolTip(this.button_customerSelectFile, "Select input CSV file");
            this.button_customerSelectFile.UseVisualStyleBackColor = false;
            this.button_customerSelectFile.Click += new System.EventHandler(this.button_select_customer_file_Click);
            // 
            // defaultToolTip
            // 
            this.defaultToolTip.ShowAlways = true;
            // 
            // tmrExpand
            // 
            this.tmrExpand.Interval = 10;
            this.tmrExpand.Tick += new System.EventHandler(this.tmrExpand_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(45, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Invoice Address";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(9, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 32);
            this.panel1.TabIndex = 2;
            // 
            // UserControl_CustomerImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_customerFieldMapping);
            this.Controls.Add(this.panel_customerButtons);
            this.Controls.Add(this.panel_customerMessage);
            this.Controls.Add(this.panel_customerDataTable);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControl_CustomerImport";
            this.Size = new System.Drawing.Size(1437, 1070);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.panel_customerDataTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_customer)).EndInit();
            this.panel_customerMessage.ResumeLayout(false);
            this.panel_customerMessage.PerformLayout();
            this.panel_customerButtons.ResumeLayout(false);
            this.panel_customerFieldMapping.ResumeLayout(false);
            this.panel_customerFieldMapping.PerformLayout();
            this.flowLayoutPanel_NonMandatoryFields.ResumeLayout(false);
            this.panel_customerDetailsButton.ResumeLayout(false);
            this.panel_customerDetailsButton.PerformLayout();
            this.panel_customerDetails.ResumeLayout(false);
            this.panel_customerDetails.PerformLayout();
            this.panel_contactDetailsButton.ResumeLayout(false);
            this.panel_contactDetailsButton.PerformLayout();
            this.panel_contactDetails.ResumeLayout(false);
            this.panel_contactDetails.PerformLayout();
            this.panel_invoiceAddressButton.ResumeLayout(false);
            this.panel_invoiceAddressButton.PerformLayout();
            this.panel_invoiceAddress.ResumeLayout(false);
            this.panel_invoiceAddress.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_financeCompanyInfo.ResumeLayout(false);
            this.panel_financeCompanyInfo.PerformLayout();
            this.panel_defaultInvoiceSettingsButton.ResumeLayout(false);
            this.panel_defaultInvoiceSettingsButton.PerformLayout();
            this.panel_defaultInvoiceSettings.ResumeLayout(false);
            this.panel_defaultInvoiceSettings.PerformLayout();
            this.panel_invoiceExternalCosts.ResumeLayout(false);
            this.panel_invoiceExternalCosts.PerformLayout();
            this.panel_incoiceExternalCosts.ResumeLayout(false);
            this.panel_incoiceExternalCosts.PerformLayout();
            this.groupBox_customerMandatoryFields.ResumeLayout(false);
            this.groupBox_customerMandatoryFields.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private void AddRowNumberToDataTable()
        {
            this.dataGridView_customer.DataBindingComplete += (o, e) =>
            {
                foreach (System.Windows.Forms.DataGridViewRow row in dataGridView_customer.Rows)
                {
                    row.HeaderCell.Value = (row.Index + 1).ToString();

                }
            };
            this.dataGridView_customer.RowHeadersWidth = 65;
        }


        private System.ComponentModel.BackgroundWorker WorkerFetcher;
        private System.Windows.Forms.Panel panel_customerDataTable;
        private System.Windows.Forms.DataGridView dataGridView_customer;
        private System.Windows.Forms.Panel panel_customerMessage;
        private System.Windows.Forms.Panel panel_customerButtons;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_import;
        private System.Windows.Forms.Button button_validate;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Panel panel_customerFieldMapping;
        private System.Windows.Forms.GroupBox groupBox_customerMandatoryFields;
        private System.Windows.Forms.ComboBox comboBox_customerName;
        private System.Windows.Forms.Label label_customerName;
        private System.Windows.Forms.Label label_customerSetup;
        private System.Windows.Forms.Button button_customerSelectFile;
        private System.Windows.Forms.TextBox textBox_customerImportMessages;
        private System.Windows.Forms.ComboBox comboBox_currencyISO;
        private System.Windows.Forms.Label label_currencyISO;
        private System.Windows.Forms.ComboBox comboBox_countryISO;
        private System.Windows.Forms.ComboBox comboBox_customerStatus;
        private System.Windows.Forms.Label label_invoicingAddressCountryID;
        private System.Windows.Forms.Label label_countryISO;
        private System.Windows.Forms.Label label_customerStatus;
        private System.Windows.Forms.Label label_eanNo;
        private System.Windows.Forms.Label label_secondaryKAM;
        private System.Windows.Forms.Label label_primaryKAM;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_industryName;
        private System.Windows.Forms.Label label_defaultMileageDistance;
        private System.Windows.Forms.Label label_customerNo;
        private System.Windows.Forms.Label label_useEanNo;
        private System.Windows.Forms.Label label_vatPercentage;
        private System.Windows.Forms.Label label_calculateVAT;
        private System.Windows.Forms.Label label_discountPercentage;
        private System.Windows.Forms.Label label_paymentTerm;
        private System.Windows.Forms.Label label_defaultDistIsMaxBillable;
        private System.Windows.Forms.Label label_organizationNo;
        private System.Windows.Forms.Label label_vatNo;
        private System.Windows.Forms.Label label_invoicingAddressState;
        private System.Windows.Forms.Label label_expenseIsBillable;
        private System.Windows.Forms.Label label_mileageIsBillable;
        private System.Windows.Forms.Label label_invoicingAddress3;
        private System.Windows.Forms.Label label_invoicingAddress2;
        private System.Windows.Forms.Label label_invoicingAddressZipCode;
        private System.Windows.Forms.Label label_invoicingAddressCity;
        private System.Windows.Forms.Label label_invoicingAddress;
        private System.Windows.Forms.Label label_useInvoicingAddress;
        private System.Windows.Forms.Label label_state;
        private System.Windows.Forms.Label label_city;
        private System.Windows.Forms.Label label_zipCode;
        private System.Windows.Forms.Label label_address3;
        private System.Windows.Forms.Label label_address2;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_website;
        private System.Windows.Forms.Label label_fax;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_customerSince;
        private System.Windows.Forms.Label label_nickname;
        private System.Windows.Forms.ComboBox comboBox_customerNo;
        private System.Windows.Forms.ComboBox comboBox_secondaryKAM;
        private System.Windows.Forms.CheckBox checkBox_defaultCurrencyISO;
        private System.Windows.Forms.CheckBox checkBox_defaultPrimaryKAM;
        private System.Windows.Forms.ComboBox comboBox_useInvoicingAddress;
        private System.Windows.Forms.ComboBox comboBox_organizationNo;
        private System.Windows.Forms.ComboBox comboBox_eanNo;
        private System.Windows.Forms.ComboBox comboBox_useEanNo;
        private System.Windows.Forms.ComboBox comboBox_state;
        private System.Windows.Forms.ComboBox comboBox_city;
        private System.Windows.Forms.ComboBox comboBox_zipCode;
        private System.Windows.Forms.ComboBox comboBox_address3;
        private System.Windows.Forms.ComboBox comboBox_address2;
        private System.Windows.Forms.ComboBox comboBox_address;
        private System.Windows.Forms.ComboBox comboBox_website;
        private System.Windows.Forms.ComboBox comboBox_email;
        private System.Windows.Forms.ComboBox comboBox_faxNo;
        private System.Windows.Forms.ComboBox comboBox_phoneNo;
        private System.Windows.Forms.ComboBox comboBox_industryName;
        private System.Windows.Forms.ComboBox comboBox_customerSince;
        private System.Windows.Forms.ComboBox comboBox_primaryKAM;
        private System.Windows.Forms.ComboBox comboBox_nickName;
        private System.Windows.Forms.ComboBox comboBox_VATNo;
        private System.Windows.Forms.ComboBox comboBox_VATPercentage;
        private System.Windows.Forms.ComboBox comboBox_calculateVAT;
        private System.Windows.Forms.ComboBox comboBox_discountPercentage;
        private System.Windows.Forms.ComboBox comboBox_defaultDistIsMaxBillable;
        private System.Windows.Forms.ComboBox comboBox_mileageIsBillable;
        private System.Windows.Forms.ComboBox comboBox_expenseIsBillable;
        private System.Windows.Forms.ComboBox comboBox_defaultMileageDistance;
        private System.Windows.Forms.ComboBox comboBox_invoicingAddressCountryISO;
        private System.Windows.Forms.ComboBox comboBox_invoicingAddressState;
        private System.Windows.Forms.ComboBox comboBox_invoicingAddressCity;
        private System.Windows.Forms.ComboBox comboBox_invoicingAddressZipCode;
        private System.Windows.Forms.ComboBox comboBox_invoicingAddress3;
        private System.Windows.Forms.ComboBox comboBox_invoicingAddress2;
        private System.Windows.Forms.ComboBox comboBox_invoicingAddress;
        private System.Windows.Forms.CheckBox checkBox_defaultCountryISO;
        private System.Windows.Forms.CheckBox checkBox_defaultCustomerStatus;
        private System.Windows.Forms.CheckBox checkBox_defaultVATPercentage;
        private System.Windows.Forms.CheckBox checkBox_defaultPaymentTerm;
        private System.Windows.Forms.CheckBox checkBox_defaultIndustryName;
        private System.Windows.Forms.CheckBox checkBox_defaultSecondaryKAM;
        private System.Windows.Forms.Label label_delimiter;
        private System.Windows.Forms.ComboBox comboBox_delimiter;
        private System.Windows.Forms.ToolTip defaultToolTip;
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
    }
}
