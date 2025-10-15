namespace TimeLog.DataImporter.UserControls
{
    partial class UserControl_ProjectExpenseImport
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
            panel_employeeDataTable = new System.Windows.Forms.Panel();
            dataGridView_projectExpense = new System.Windows.Forms.DataGridView();
            panel_projectMessage = new System.Windows.Forms.Panel();
            textBox_projectExpenseImportMessages = new System.Windows.Forms.TextBox();
            panel_projectExpenseButtons = new System.Windows.Forms.Panel();
            button_clear = new System.Windows.Forms.Button();
            button_import = new System.Windows.Forms.Button();
            button_validate = new System.Windows.Forms.Button();
            button_stop = new System.Windows.Forms.Button();
            panel_projectExpenseFieldMapping = new System.Windows.Forms.Panel();
            flowLayoutPanel_nonMandatoryFields = new System.Windows.Forms.FlowLayoutPanel();
            panel_NonMandatoryButton = new System.Windows.Forms.Panel();
            label_nonMandatoryFields = new System.Windows.Forms.Label();
            button_expandNonMandatory = new System.Windows.Forms.Button();
            panel_NonMandatoryFields = new System.Windows.Forms.Panel();
            comboBox_profitRatio = new System.Windows.Forms.ComboBox();
            label_profitRatio = new System.Windows.Forms.Label();
            label_externalID = new System.Windows.Forms.Label();
            comboBox_externalID = new System.Windows.Forms.ComboBox();
            label_supplierInvoiceNo = new System.Windows.Forms.Label();
            comboBox_supplierInvoiceNo = new System.Windows.Forms.ComboBox();
            comboBox_comment = new System.Windows.Forms.ComboBox();
            label_comment = new System.Windows.Forms.Label();
            label_supplierNo = new System.Windows.Forms.Label();
            comboBox_supplierNo = new System.Windows.Forms.ComboBox();
            label_delimiter = new System.Windows.Forms.Label();
            comboBox_delimiter = new System.Windows.Forms.ComboBox();
            groupBox_projectExpenseMandatoryFields = new System.Windows.Forms.GroupBox();
            checkBox_defaultIsBillable = new System.Windows.Forms.CheckBox();
            checkBox_defaultExpenseCurrencyISO = new System.Windows.Forms.CheckBox();
            comboBox_contractName = new System.Windows.Forms.ComboBox();
            comboBox_expenseCurrencyISO = new System.Windows.Forms.ComboBox();
            comboBox_VATAmount = new System.Windows.Forms.ComboBox();
            comboBox_expenseNo = new System.Windows.Forms.ComboBox();
            label_contractName = new System.Windows.Forms.Label();
            label_expenseCurrencyISO = new System.Windows.Forms.Label();
            label_VATAmountCurrency = new System.Windows.Forms.Label();
            label_expenseNo = new System.Windows.Forms.Label();
            checkBox_defaultExpenseType = new System.Windows.Forms.CheckBox();
            checkBox_defaultPaymentMethod = new System.Windows.Forms.CheckBox();
            label_salesPriceAmount = new System.Windows.Forms.Label();
            comboBox_salesPriceAmount = new System.Windows.Forms.ComboBox();
            comboBox_exchangeRate = new System.Windows.Forms.ComboBox();
            label_amountIncludingVAT = new System.Windows.Forms.Label();
            label_isBillable = new System.Windows.Forms.Label();
            label_exchangeRate = new System.Windows.Forms.Label();
            comboBox_amountIncludingVAT = new System.Windows.Forms.ComboBox();
            label_expenseType = new System.Windows.Forms.Label();
            comboBox_expenseType = new System.Windows.Forms.ComboBox();
            label_paymentMethod = new System.Windows.Forms.Label();
            comboBox_isBillable = new System.Windows.Forms.ComboBox();
            comboBox_paymentMethod = new System.Windows.Forms.ComboBox();
            label_purchaseDate = new System.Windows.Forms.Label();
            comboBox_purchaseDate = new System.Windows.Forms.ComboBox();
            label_projectNo = new System.Windows.Forms.Label();
            comboBox_projectNo = new System.Windows.Forms.ComboBox();
            label_projectExpenseSetup = new System.Windows.Forms.Label();
            button_projectExpenseSelectFile = new System.Windows.Forms.Button();
            tmrExpand = new System.Windows.Forms.Timer(components);
            defaultToolTip = new System.Windows.Forms.ToolTip(components);
            panel_employeeDataTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_projectExpense).BeginInit();
            panel_projectMessage.SuspendLayout();
            panel_projectExpenseButtons.SuspendLayout();
            panel_projectExpenseFieldMapping.SuspendLayout();
            flowLayoutPanel_nonMandatoryFields.SuspendLayout();
            panel_NonMandatoryButton.SuspendLayout();
            panel_NonMandatoryFields.SuspendLayout();
            groupBox_projectExpenseMandatoryFields.SuspendLayout();
            SuspendLayout();
            // 
            // WorkerFetcher
            // 
            WorkerFetcher.WorkerReportsProgress = true;
            WorkerFetcher.WorkerSupportsCancellation = true;
            WorkerFetcher.DoWork += WorkerFetcherDoWork;
            // 
            // panel_employeeDataTable
            // 
            panel_employeeDataTable.Controls.Add(dataGridView_projectExpense);
            panel_employeeDataTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_employeeDataTable.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel_employeeDataTable.Location = new System.Drawing.Point(0, 462);
            panel_employeeDataTable.Name = "panel_employeeDataTable";
            panel_employeeDataTable.Size = new System.Drawing.Size(1006, 180);
            panel_employeeDataTable.TabIndex = 6;
            // 
            // dataGridView_projectExpense
            // 
            dataGridView_projectExpense.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridView_projectExpense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridView_projectExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_projectExpense.Dock = System.Windows.Forms.DockStyle.Bottom;
            dataGridView_projectExpense.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridView_projectExpense.Location = new System.Drawing.Point(0, 0);
            dataGridView_projectExpense.Name = "dataGridView_projectExpense";
            dataGridView_projectExpense.Size = new System.Drawing.Size(1006, 180);
            dataGridView_projectExpense.TabIndex = 0;
            // 
            // panel_projectMessage
            // 
            panel_projectMessage.Controls.Add(textBox_projectExpenseImportMessages);
            panel_projectMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_projectMessage.Location = new System.Drawing.Point(0, 278);
            panel_projectMessage.Name = "panel_projectMessage";
            panel_projectMessage.Size = new System.Drawing.Size(1006, 184);
            panel_projectMessage.TabIndex = 10;
            // 
            // textBox_projectExpenseImportMessages
            // 
            textBox_projectExpenseImportMessages.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            textBox_projectExpenseImportMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox_projectExpenseImportMessages.Dock = System.Windows.Forms.DockStyle.Bottom;
            textBox_projectExpenseImportMessages.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            textBox_projectExpenseImportMessages.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            textBox_projectExpenseImportMessages.Location = new System.Drawing.Point(0, 0);
            textBox_projectExpenseImportMessages.Multiline = true;
            textBox_projectExpenseImportMessages.Name = "textBox_projectExpenseImportMessages";
            textBox_projectExpenseImportMessages.ReadOnly = true;
            textBox_projectExpenseImportMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBox_projectExpenseImportMessages.Size = new System.Drawing.Size(1006, 184);
            textBox_projectExpenseImportMessages.TabIndex = 0;
            defaultToolTip.SetToolTip(textBox_projectExpenseImportMessages, "Validation or import status");
            textBox_projectExpenseImportMessages.WordWrap = false;
            textBox_projectExpenseImportMessages.MouseClick += textBox_projectExpenseImportMessages_MouseClick;
            // 
            // panel_projectExpenseButtons
            // 
            panel_projectExpenseButtons.Controls.Add(button_clear);
            panel_projectExpenseButtons.Controls.Add(button_import);
            panel_projectExpenseButtons.Controls.Add(button_validate);
            panel_projectExpenseButtons.Controls.Add(button_stop);
            panel_projectExpenseButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_projectExpenseButtons.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            panel_projectExpenseButtons.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel_projectExpenseButtons.Location = new System.Drawing.Point(0, 226);
            panel_projectExpenseButtons.Name = "panel_projectExpenseButtons";
            panel_projectExpenseButtons.Size = new System.Drawing.Size(1006, 52);
            panel_projectExpenseButtons.TabIndex = 12;
            // 
            // button_clear
            // 
            button_clear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            button_clear.BackColor = System.Drawing.Color.DimGray;
            button_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            button_clear.FlatAppearance.BorderSize = 0;
            button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_clear.ForeColor = System.Drawing.Color.White;
            button_clear.Location = new System.Drawing.Point(14, 12);
            button_clear.Name = "button_clear";
            button_clear.Size = new System.Drawing.Size(80, 29);
            button_clear.TabIndex = 12;
            button_clear.Text = "Reset All";
            defaultToolTip.SetToolTip(button_clear, "Reset everything and reload data from TLP");
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click;
            // 
            // button_import
            // 
            button_import.Anchor = System.Windows.Forms.AnchorStyles.Right;
            button_import.BackColor = System.Drawing.Color.FromArgb(226, 43, 141);
            button_import.Cursor = System.Windows.Forms.Cursors.Hand;
            button_import.FlatAppearance.BorderSize = 0;
            button_import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_import.ForeColor = System.Drawing.Color.White;
            button_import.Location = new System.Drawing.Point(917, 12);
            button_import.Name = "button_import";
            button_import.Size = new System.Drawing.Size(80, 29);
            button_import.TabIndex = 7;
            button_import.Text = "Import";
            defaultToolTip.SetToolTip(button_import, "Import all data");
            button_import.UseVisualStyleBackColor = false;
            button_import.Click += button_import_Click;
            // 
            // button_validate
            // 
            button_validate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            button_validate.BackColor = System.Drawing.Color.FromArgb(226, 43, 141);
            button_validate.Cursor = System.Windows.Forms.Cursors.Hand;
            button_validate.FlatAppearance.BorderSize = 0;
            button_validate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_validate.ForeColor = System.Drawing.Color.White;
            button_validate.Location = new System.Drawing.Point(745, 12);
            button_validate.Name = "button_validate";
            button_validate.Size = new System.Drawing.Size(80, 29);
            button_validate.TabIndex = 8;
            button_validate.Text = "Validate";
            defaultToolTip.SetToolTip(button_validate, "Validate data input before importing data");
            button_validate.UseVisualStyleBackColor = false;
            button_validate.Click += button_validate_Click;
            // 
            // button_stop
            // 
            button_stop.Anchor = System.Windows.Forms.AnchorStyles.Right;
            button_stop.BackColor = System.Drawing.Color.DimGray;
            button_stop.Cursor = System.Windows.Forms.Cursors.Hand;
            button_stop.FlatAppearance.BorderSize = 0;
            button_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_stop.ForeColor = System.Drawing.Color.White;
            button_stop.Location = new System.Drawing.Point(831, 12);
            button_stop.Name = "button_stop";
            button_stop.Size = new System.Drawing.Size(80, 29);
            button_stop.TabIndex = 11;
            button_stop.Text = "Stop";
            defaultToolTip.SetToolTip(button_stop, "Stop validation or import");
            button_stop.UseVisualStyleBackColor = false;
            button_stop.Click += button_stop_Click;
            // 
            // panel_projectExpenseFieldMapping
            // 
            panel_projectExpenseFieldMapping.AutoScroll = true;
            panel_projectExpenseFieldMapping.Controls.Add(flowLayoutPanel_nonMandatoryFields);
            panel_projectExpenseFieldMapping.Controls.Add(label_delimiter);
            panel_projectExpenseFieldMapping.Controls.Add(comboBox_delimiter);
            panel_projectExpenseFieldMapping.Controls.Add(groupBox_projectExpenseMandatoryFields);
            panel_projectExpenseFieldMapping.Controls.Add(label_projectExpenseSetup);
            panel_projectExpenseFieldMapping.Controls.Add(button_projectExpenseSelectFile);
            panel_projectExpenseFieldMapping.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_projectExpenseFieldMapping.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            panel_projectExpenseFieldMapping.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel_projectExpenseFieldMapping.Location = new System.Drawing.Point(0, 0);
            panel_projectExpenseFieldMapping.Name = "panel_projectExpenseFieldMapping";
            panel_projectExpenseFieldMapping.Size = new System.Drawing.Size(1006, 226);
            panel_projectExpenseFieldMapping.TabIndex = 13;
            // 
            // flowLayoutPanel_nonMandatoryFields
            // 
            flowLayoutPanel_nonMandatoryFields.Controls.Add(panel_NonMandatoryButton);
            flowLayoutPanel_nonMandatoryFields.Controls.Add(panel_NonMandatoryFields);
            flowLayoutPanel_nonMandatoryFields.Location = new System.Drawing.Point(572, 60);
            flowLayoutPanel_nonMandatoryFields.Name = "flowLayoutPanel_nonMandatoryFields";
            flowLayoutPanel_nonMandatoryFields.Size = new System.Drawing.Size(390, 215);
            flowLayoutPanel_nonMandatoryFields.TabIndex = 7;
            // 
            // panel_NonMandatoryButton
            // 
            panel_NonMandatoryButton.Controls.Add(label_nonMandatoryFields);
            panel_NonMandatoryButton.Controls.Add(button_expandNonMandatory);
            panel_NonMandatoryButton.Location = new System.Drawing.Point(3, 3);
            panel_NonMandatoryButton.Name = "panel_NonMandatoryButton";
            panel_NonMandatoryButton.Size = new System.Drawing.Size(382, 32);
            panel_NonMandatoryButton.TabIndex = 0;
            // 
            // label_nonMandatoryFields
            // 
            label_nonMandatoryFields.AutoSize = true;
            label_nonMandatoryFields.ForeColor = System.Drawing.Color.Black;
            label_nonMandatoryFields.Location = new System.Drawing.Point(46, 8);
            label_nonMandatoryFields.Name = "label_nonMandatoryFields";
            label_nonMandatoryFields.Size = new System.Drawing.Size(107, 17);
            label_nonMandatoryFields.TabIndex = 1;
            label_nonMandatoryFields.Text = "Non-Mandatory";
            // 
            // button_expandNonMandatory
            // 
            button_expandNonMandatory.BackColor = System.Drawing.Color.White;
            button_expandNonMandatory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button_expandNonMandatory.Cursor = System.Windows.Forms.Cursors.Hand;
            button_expandNonMandatory.FlatAppearance.BorderSize = 0;
            button_expandNonMandatory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_expandNonMandatory.ForeColor = System.Drawing.Color.White;
            button_expandNonMandatory.Location = new System.Drawing.Point(10, 1);
            button_expandNonMandatory.Name = "button_expandNonMandatory";
            button_expandNonMandatory.Size = new System.Drawing.Size(30, 30);
            button_expandNonMandatory.TabIndex = 0;
            button_expandNonMandatory.UseVisualStyleBackColor = false;
            button_expandNonMandatory.Click += button_expand_Click;
            // 
            // panel_NonMandatoryFields
            // 
            panel_NonMandatoryFields.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            panel_NonMandatoryFields.Controls.Add(comboBox_profitRatio);
            panel_NonMandatoryFields.Controls.Add(label_profitRatio);
            panel_NonMandatoryFields.Controls.Add(label_externalID);
            panel_NonMandatoryFields.Controls.Add(comboBox_externalID);
            panel_NonMandatoryFields.Controls.Add(label_supplierInvoiceNo);
            panel_NonMandatoryFields.Controls.Add(comboBox_supplierInvoiceNo);
            panel_NonMandatoryFields.Controls.Add(comboBox_comment);
            panel_NonMandatoryFields.Controls.Add(label_comment);
            panel_NonMandatoryFields.Controls.Add(label_supplierNo);
            panel_NonMandatoryFields.Controls.Add(comboBox_supplierNo);
            panel_NonMandatoryFields.Location = new System.Drawing.Point(3, 41);
            panel_NonMandatoryFields.MaximumSize = new System.Drawing.Size(382, 165);
            panel_NonMandatoryFields.MinimumSize = new System.Drawing.Size(382, 0);
            panel_NonMandatoryFields.Name = "panel_NonMandatoryFields";
            panel_NonMandatoryFields.Size = new System.Drawing.Size(382, 165);
            panel_NonMandatoryFields.TabIndex = 1;
            // 
            // comboBox_profitRatio
            // 
            comboBox_profitRatio.FormattingEnabled = true;
            comboBox_profitRatio.Location = new System.Drawing.Point(153, 131);
            comboBox_profitRatio.Name = "comboBox_profitRatio";
            comboBox_profitRatio.Size = new System.Drawing.Size(150, 25);
            comboBox_profitRatio.TabIndex = 10;
            // 
            // label_profitRatio
            // 
            label_profitRatio.AutoSize = true;
            label_profitRatio.Location = new System.Drawing.Point(10, 134);
            label_profitRatio.Name = "label_profitRatio";
            label_profitRatio.Size = new System.Drawing.Size(76, 17);
            label_profitRatio.TabIndex = 1;
            label_profitRatio.Text = "Profit Ratio";
            // 
            // label_externalID
            // 
            label_externalID.AutoSize = true;
            label_externalID.Location = new System.Drawing.Point(10, 10);
            label_externalID.Name = "label_externalID";
            label_externalID.Size = new System.Drawing.Size(74, 17);
            label_externalID.TabIndex = 1;
            label_externalID.Text = "External ID";
            // 
            // comboBox_externalID
            // 
            comboBox_externalID.FormattingEnabled = true;
            comboBox_externalID.Location = new System.Drawing.Point(153, 7);
            comboBox_externalID.Name = "comboBox_externalID";
            comboBox_externalID.Size = new System.Drawing.Size(150, 25);
            comboBox_externalID.TabIndex = 3;
            // 
            // label_supplierInvoiceNo
            // 
            label_supplierInvoiceNo.AutoSize = true;
            label_supplierInvoiceNo.Location = new System.Drawing.Point(10, 103);
            label_supplierInvoiceNo.Name = "label_supplierInvoiceNo";
            label_supplierInvoiceNo.Size = new System.Drawing.Size(126, 17);
            label_supplierInvoiceNo.TabIndex = 1;
            label_supplierInvoiceNo.Text = "Supplier Invoice No";
            // 
            // comboBox_supplierInvoiceNo
            // 
            comboBox_supplierInvoiceNo.FormattingEnabled = true;
            comboBox_supplierInvoiceNo.Location = new System.Drawing.Point(153, 100);
            comboBox_supplierInvoiceNo.Name = "comboBox_supplierInvoiceNo";
            comboBox_supplierInvoiceNo.Size = new System.Drawing.Size(150, 25);
            comboBox_supplierInvoiceNo.TabIndex = 3;
            // 
            // comboBox_comment
            // 
            comboBox_comment.FormattingEnabled = true;
            comboBox_comment.Location = new System.Drawing.Point(153, 38);
            comboBox_comment.Name = "comboBox_comment";
            comboBox_comment.Size = new System.Drawing.Size(150, 25);
            comboBox_comment.TabIndex = 3;
            // 
            // label_comment
            // 
            label_comment.AutoSize = true;
            label_comment.Location = new System.Drawing.Point(10, 41);
            label_comment.Name = "label_comment";
            label_comment.Size = new System.Drawing.Size(68, 17);
            label_comment.TabIndex = 1;
            label_comment.Text = "Comment";
            // 
            // label_supplierNo
            // 
            label_supplierNo.AutoSize = true;
            label_supplierNo.Location = new System.Drawing.Point(10, 72);
            label_supplierNo.Name = "label_supplierNo";
            label_supplierNo.Size = new System.Drawing.Size(79, 17);
            label_supplierNo.TabIndex = 1;
            label_supplierNo.Text = "Supplier No";
            // 
            // comboBox_supplierNo
            // 
            comboBox_supplierNo.FormattingEnabled = true;
            comboBox_supplierNo.Location = new System.Drawing.Point(153, 69);
            comboBox_supplierNo.Name = "comboBox_supplierNo";
            comboBox_supplierNo.Size = new System.Drawing.Size(150, 25);
            comboBox_supplierNo.TabIndex = 3;
            // 
            // label_delimiter
            // 
            label_delimiter.AutoSize = true;
            label_delimiter.Location = new System.Drawing.Point(10, 75);
            label_delimiter.Name = "label_delimiter";
            label_delimiter.Size = new System.Drawing.Size(62, 17);
            label_delimiter.TabIndex = 1;
            label_delimiter.Text = "Delimiter";
            // 
            // comboBox_delimiter
            // 
            comboBox_delimiter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_delimiter.FormattingEnabled = true;
            comboBox_delimiter.Location = new System.Drawing.Point(82, 72);
            comboBox_delimiter.Name = "comboBox_delimiter";
            comboBox_delimiter.Size = new System.Drawing.Size(56, 25);
            comboBox_delimiter.TabIndex = 6;
            // 
            // groupBox_projectExpenseMandatoryFields
            // 
            groupBox_projectExpenseMandatoryFields.Controls.Add(checkBox_defaultIsBillable);
            groupBox_projectExpenseMandatoryFields.Controls.Add(checkBox_defaultExpenseCurrencyISO);
            groupBox_projectExpenseMandatoryFields.Controls.Add(comboBox_contractName);
            groupBox_projectExpenseMandatoryFields.Controls.Add(comboBox_expenseCurrencyISO);
            groupBox_projectExpenseMandatoryFields.Controls.Add(comboBox_VATAmount);
            groupBox_projectExpenseMandatoryFields.Controls.Add(comboBox_expenseNo);
            groupBox_projectExpenseMandatoryFields.Controls.Add(label_contractName);
            groupBox_projectExpenseMandatoryFields.Controls.Add(label_expenseCurrencyISO);
            groupBox_projectExpenseMandatoryFields.Controls.Add(label_VATAmountCurrency);
            groupBox_projectExpenseMandatoryFields.Controls.Add(label_expenseNo);
            groupBox_projectExpenseMandatoryFields.Controls.Add(checkBox_defaultExpenseType);
            groupBox_projectExpenseMandatoryFields.Controls.Add(checkBox_defaultPaymentMethod);
            groupBox_projectExpenseMandatoryFields.Controls.Add(label_salesPriceAmount);
            groupBox_projectExpenseMandatoryFields.Controls.Add(comboBox_salesPriceAmount);
            groupBox_projectExpenseMandatoryFields.Controls.Add(comboBox_exchangeRate);
            groupBox_projectExpenseMandatoryFields.Controls.Add(label_amountIncludingVAT);
            groupBox_projectExpenseMandatoryFields.Controls.Add(label_isBillable);
            groupBox_projectExpenseMandatoryFields.Controls.Add(label_exchangeRate);
            groupBox_projectExpenseMandatoryFields.Controls.Add(comboBox_amountIncludingVAT);
            groupBox_projectExpenseMandatoryFields.Controls.Add(label_expenseType);
            groupBox_projectExpenseMandatoryFields.Controls.Add(comboBox_expenseType);
            groupBox_projectExpenseMandatoryFields.Controls.Add(label_paymentMethod);
            groupBox_projectExpenseMandatoryFields.Controls.Add(comboBox_isBillable);
            groupBox_projectExpenseMandatoryFields.Controls.Add(comboBox_paymentMethod);
            groupBox_projectExpenseMandatoryFields.Controls.Add(label_purchaseDate);
            groupBox_projectExpenseMandatoryFields.Controls.Add(comboBox_purchaseDate);
            groupBox_projectExpenseMandatoryFields.Controls.Add(label_projectNo);
            groupBox_projectExpenseMandatoryFields.Controls.Add(comboBox_projectNo);
            groupBox_projectExpenseMandatoryFields.Location = new System.Drawing.Point(160, 62);
            groupBox_projectExpenseMandatoryFields.Name = "groupBox_projectExpenseMandatoryFields";
            groupBox_projectExpenseMandatoryFields.Size = new System.Drawing.Size(394, 405);
            groupBox_projectExpenseMandatoryFields.TabIndex = 5;
            groupBox_projectExpenseMandatoryFields.TabStop = false;
            groupBox_projectExpenseMandatoryFields.Text = "Mandatory";
            // 
            // checkBox_defaultIsBillable
            // 
            checkBox_defaultIsBillable.AutoSize = true;
            checkBox_defaultIsBillable.Location = new System.Drawing.Point(323, 212);
            checkBox_defaultIsBillable.Name = "checkBox_defaultIsBillable";
            checkBox_defaultIsBillable.Size = new System.Drawing.Size(70, 21);
            checkBox_defaultIsBillable.TabIndex = 14;
            checkBox_defaultIsBillable.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultIsBillable, "Set default values for all rows of a particular column field");
            checkBox_defaultIsBillable.UseVisualStyleBackColor = true;
            checkBox_defaultIsBillable.CheckedChanged += checkBox_defaultIsBillable_CheckedChanged;
            // 
            // checkBox_defaultExpenseCurrencyISO
            // 
            checkBox_defaultExpenseCurrencyISO.AutoSize = true;
            checkBox_defaultExpenseCurrencyISO.Location = new System.Drawing.Point(323, 305);
            checkBox_defaultExpenseCurrencyISO.Name = "checkBox_defaultExpenseCurrencyISO";
            checkBox_defaultExpenseCurrencyISO.Size = new System.Drawing.Size(70, 21);
            checkBox_defaultExpenseCurrencyISO.TabIndex = 12;
            checkBox_defaultExpenseCurrencyISO.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultExpenseCurrencyISO, "Set default values for all rows of a particular column field");
            checkBox_defaultExpenseCurrencyISO.UseVisualStyleBackColor = true;
            checkBox_defaultExpenseCurrencyISO.CheckedChanged += checkBox_defaultExpenseCurrencyISO_CheckedChanged;
            // 
            // comboBox_contractName
            // 
            comboBox_contractName.FormattingEnabled = true;
            comboBox_contractName.Location = new System.Drawing.Point(163, 334);
            comboBox_contractName.Name = "comboBox_contractName";
            comboBox_contractName.Size = new System.Drawing.Size(154, 25);
            comboBox_contractName.TabIndex = 10;
            // 
            // comboBox_expenseCurrencyISO
            // 
            comboBox_expenseCurrencyISO.FormattingEnabled = true;
            comboBox_expenseCurrencyISO.Location = new System.Drawing.Point(163, 303);
            comboBox_expenseCurrencyISO.Name = "comboBox_expenseCurrencyISO";
            comboBox_expenseCurrencyISO.Size = new System.Drawing.Size(154, 25);
            comboBox_expenseCurrencyISO.TabIndex = 9;
            // 
            // comboBox_VATAmount
            // 
            comboBox_VATAmount.FormattingEnabled = true;
            comboBox_VATAmount.Location = new System.Drawing.Point(163, 272);
            comboBox_VATAmount.Name = "comboBox_VATAmount";
            comboBox_VATAmount.Size = new System.Drawing.Size(154, 25);
            comboBox_VATAmount.TabIndex = 8;
            // 
            // comboBox_expenseNo
            // 
            comboBox_expenseNo.FormattingEnabled = true;
            comboBox_expenseNo.Location = new System.Drawing.Point(163, 241);
            comboBox_expenseNo.Name = "comboBox_expenseNo";
            comboBox_expenseNo.Size = new System.Drawing.Size(154, 25);
            comboBox_expenseNo.TabIndex = 7;
            // 
            // label_contractName
            // 
            label_contractName.AutoSize = true;
            label_contractName.Location = new System.Drawing.Point(6, 337);
            label_contractName.Name = "label_contractName";
            label_contractName.Size = new System.Drawing.Size(100, 17);
            label_contractName.TabIndex = 1;
            label_contractName.Text = "Contract Name";
            // 
            // label_expenseCurrencyISO
            // 
            label_expenseCurrencyISO.AutoSize = true;
            label_expenseCurrencyISO.Location = new System.Drawing.Point(6, 306);
            label_expenseCurrencyISO.Name = "label_expenseCurrencyISO";
            label_expenseCurrencyISO.Size = new System.Drawing.Size(141, 17);
            label_expenseCurrencyISO.TabIndex = 1;
            label_expenseCurrencyISO.Text = "Expense Currency ISO";
            // 
            // label_VATAmountCurrency
            // 
            label_VATAmountCurrency.AutoSize = true;
            label_VATAmountCurrency.Location = new System.Drawing.Point(6, 275);
            label_VATAmountCurrency.Name = "label_VATAmountCurrency";
            label_VATAmountCurrency.Size = new System.Drawing.Size(84, 17);
            label_VATAmountCurrency.TabIndex = 1;
            label_VATAmountCurrency.Text = "VAT Amount";
            defaultToolTip.SetToolTip(label_VATAmountCurrency, "In expense currency");
            // 
            // label_expenseNo
            // 
            label_expenseNo.AutoSize = true;
            label_expenseNo.Location = new System.Drawing.Point(6, 244);
            label_expenseNo.Name = "label_expenseNo";
            label_expenseNo.Size = new System.Drawing.Size(80, 17);
            label_expenseNo.TabIndex = 1;
            label_expenseNo.Text = "Expense No";
            // 
            // checkBox_defaultExpenseType
            // 
            checkBox_defaultExpenseType.AutoSize = true;
            checkBox_defaultExpenseType.Location = new System.Drawing.Point(323, 119);
            checkBox_defaultExpenseType.Name = "checkBox_defaultExpenseType";
            checkBox_defaultExpenseType.Size = new System.Drawing.Size(70, 21);
            checkBox_defaultExpenseType.TabIndex = 6;
            checkBox_defaultExpenseType.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultExpenseType, "Set default values for all rows of a particular column field");
            checkBox_defaultExpenseType.UseVisualStyleBackColor = true;
            checkBox_defaultExpenseType.CheckedChanged += checkBox_defaultExpenseType_CheckedChanged;
            // 
            // checkBox_defaultPaymentMethod
            // 
            checkBox_defaultPaymentMethod.AutoSize = true;
            checkBox_defaultPaymentMethod.Location = new System.Drawing.Point(323, 88);
            checkBox_defaultPaymentMethod.Name = "checkBox_defaultPaymentMethod";
            checkBox_defaultPaymentMethod.Size = new System.Drawing.Size(70, 21);
            checkBox_defaultPaymentMethod.TabIndex = 4;
            checkBox_defaultPaymentMethod.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultPaymentMethod, "Set default values for all rows of a particular column field");
            checkBox_defaultPaymentMethod.UseVisualStyleBackColor = true;
            checkBox_defaultPaymentMethod.CheckedChanged += checkBox_defaultPaymentMethod_CheckedChanged;
            // 
            // label_salesPriceAmount
            // 
            label_salesPriceAmount.AutoSize = true;
            label_salesPriceAmount.Location = new System.Drawing.Point(6, 182);
            label_salesPriceAmount.Name = "label_salesPriceAmount";
            label_salesPriceAmount.Size = new System.Drawing.Size(125, 17);
            label_salesPriceAmount.TabIndex = 1;
            label_salesPriceAmount.Text = "Sales Price Amount";
            defaultToolTip.SetToolTip(label_salesPriceAmount, "In project currency");
            // 
            // comboBox_salesPriceAmount
            // 
            comboBox_salesPriceAmount.FormattingEnabled = true;
            comboBox_salesPriceAmount.Location = new System.Drawing.Point(163, 179);
            comboBox_salesPriceAmount.Name = "comboBox_salesPriceAmount";
            comboBox_salesPriceAmount.Size = new System.Drawing.Size(154, 25);
            comboBox_salesPriceAmount.TabIndex = 3;
            // 
            // comboBox_exchangeRate
            // 
            comboBox_exchangeRate.FormattingEnabled = true;
            comboBox_exchangeRate.Location = new System.Drawing.Point(163, 365);
            comboBox_exchangeRate.Name = "comboBox_exchangeRate";
            comboBox_exchangeRate.Size = new System.Drawing.Size(154, 25);
            comboBox_exchangeRate.TabIndex = 3;
            // 
            // label_amountIncludingVAT
            // 
            label_amountIncludingVAT.AutoSize = true;
            label_amountIncludingVAT.Location = new System.Drawing.Point(6, 151);
            label_amountIncludingVAT.Name = "label_amountIncludingVAT";
            label_amountIncludingVAT.Size = new System.Drawing.Size(108, 17);
            label_amountIncludingVAT.TabIndex = 1;
            label_amountIncludingVAT.Text = "Amount inc. VAT";
            defaultToolTip.SetToolTip(label_amountIncludingVAT, "In expense currency");
            // 
            // label_isBillable
            // 
            label_isBillable.AutoSize = true;
            label_isBillable.Location = new System.Drawing.Point(6, 213);
            label_isBillable.Name = "label_isBillable";
            label_isBillable.Size = new System.Drawing.Size(64, 17);
            label_isBillable.TabIndex = 1;
            label_isBillable.Text = "Is Billable";
            // 
            // label_exchangeRate
            // 
            label_exchangeRate.AutoSize = true;
            label_exchangeRate.Location = new System.Drawing.Point(6, 368);
            label_exchangeRate.Name = "label_exchangeRate";
            label_exchangeRate.Size = new System.Drawing.Size(97, 17);
            label_exchangeRate.TabIndex = 1;
            label_exchangeRate.Text = "Exchange Rate";
            // 
            // comboBox_amountIncludingVAT
            // 
            comboBox_amountIncludingVAT.FormattingEnabled = true;
            comboBox_amountIncludingVAT.Location = new System.Drawing.Point(163, 148);
            comboBox_amountIncludingVAT.Name = "comboBox_amountIncludingVAT";
            comboBox_amountIncludingVAT.Size = new System.Drawing.Size(154, 25);
            comboBox_amountIncludingVAT.TabIndex = 3;
            // 
            // label_expenseType
            // 
            label_expenseType.AutoSize = true;
            label_expenseType.Location = new System.Drawing.Point(6, 120);
            label_expenseType.Name = "label_expenseType";
            label_expenseType.Size = new System.Drawing.Size(90, 17);
            label_expenseType.TabIndex = 1;
            label_expenseType.Text = "Expense Type";
            // 
            // comboBox_expenseType
            // 
            comboBox_expenseType.FormattingEnabled = true;
            comboBox_expenseType.Location = new System.Drawing.Point(163, 117);
            comboBox_expenseType.Name = "comboBox_expenseType";
            comboBox_expenseType.Size = new System.Drawing.Size(154, 25);
            comboBox_expenseType.TabIndex = 3;
            // 
            // label_paymentMethod
            // 
            label_paymentMethod.AutoSize = true;
            label_paymentMethod.Location = new System.Drawing.Point(6, 89);
            label_paymentMethod.Name = "label_paymentMethod";
            label_paymentMethod.Size = new System.Drawing.Size(114, 17);
            label_paymentMethod.TabIndex = 1;
            label_paymentMethod.Text = "Payment Method";
            // 
            // comboBox_isBillable
            // 
            comboBox_isBillable.FormattingEnabled = true;
            comboBox_isBillable.Location = new System.Drawing.Point(163, 210);
            comboBox_isBillable.Name = "comboBox_isBillable";
            comboBox_isBillable.Size = new System.Drawing.Size(154, 25);
            comboBox_isBillable.TabIndex = 3;
            // 
            // comboBox_paymentMethod
            // 
            comboBox_paymentMethod.FormattingEnabled = true;
            comboBox_paymentMethod.Location = new System.Drawing.Point(163, 86);
            comboBox_paymentMethod.Name = "comboBox_paymentMethod";
            comboBox_paymentMethod.Size = new System.Drawing.Size(154, 25);
            comboBox_paymentMethod.TabIndex = 3;
            // 
            // label_purchaseDate
            // 
            label_purchaseDate.AutoSize = true;
            label_purchaseDate.Location = new System.Drawing.Point(6, 58);
            label_purchaseDate.Name = "label_purchaseDate";
            label_purchaseDate.Size = new System.Drawing.Size(95, 17);
            label_purchaseDate.TabIndex = 1;
            label_purchaseDate.Text = "Purchase Date";
            // 
            // comboBox_purchaseDate
            // 
            comboBox_purchaseDate.FormattingEnabled = true;
            comboBox_purchaseDate.Location = new System.Drawing.Point(163, 55);
            comboBox_purchaseDate.Name = "comboBox_purchaseDate";
            comboBox_purchaseDate.Size = new System.Drawing.Size(154, 25);
            comboBox_purchaseDate.TabIndex = 3;
            // 
            // label_projectNo
            // 
            label_projectNo.AutoSize = true;
            label_projectNo.Location = new System.Drawing.Point(6, 27);
            label_projectNo.Name = "label_projectNo";
            label_projectNo.Size = new System.Drawing.Size(72, 17);
            label_projectNo.TabIndex = 1;
            label_projectNo.Text = "Project No";
            // 
            // comboBox_projectNo
            // 
            comboBox_projectNo.FormattingEnabled = true;
            comboBox_projectNo.Location = new System.Drawing.Point(163, 24);
            comboBox_projectNo.Name = "comboBox_projectNo";
            comboBox_projectNo.Size = new System.Drawing.Size(154, 25);
            comboBox_projectNo.TabIndex = 3;
            // 
            // label_projectExpenseSetup
            // 
            label_projectExpenseSetup.AutoSize = true;
            label_projectExpenseSetup.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            label_projectExpenseSetup.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            label_projectExpenseSetup.Location = new System.Drawing.Point(7, 16);
            label_projectExpenseSetup.Name = "label_projectExpenseSetup";
            label_projectExpenseSetup.Size = new System.Drawing.Size(326, 32);
            label_projectExpenseSetup.TabIndex = 0;
            label_projectExpenseSetup.Text = "Project Expense Data Import";
            // 
            // button_projectExpenseSelectFile
            // 
            button_projectExpenseSelectFile.BackColor = System.Drawing.Color.FromArgb(226, 43, 141);
            button_projectExpenseSelectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            button_projectExpenseSelectFile.FlatAppearance.BorderSize = 0;
            button_projectExpenseSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_projectExpenseSelectFile.ForeColor = System.Drawing.Color.White;
            button_projectExpenseSelectFile.Location = new System.Drawing.Point(13, 111);
            button_projectExpenseSelectFile.Name = "button_projectExpenseSelectFile";
            button_projectExpenseSelectFile.Size = new System.Drawing.Size(80, 29);
            button_projectExpenseSelectFile.TabIndex = 4;
            button_projectExpenseSelectFile.Text = "Select File";
            defaultToolTip.SetToolTip(button_projectExpenseSelectFile, "Select input CSV file");
            button_projectExpenseSelectFile.UseVisualStyleBackColor = false;
            button_projectExpenseSelectFile.Click += button_select_project_file_Click;
            // 
            // tmrExpand
            // 
            tmrExpand.Interval = 10;
            tmrExpand.Tick += tmrExpand_Tick;
            // 
            // defaultToolTip
            // 
            defaultToolTip.ShowAlways = true;
            // 
            // UserControl_ProjectExpenseImport
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel_projectExpenseFieldMapping);
            Controls.Add(panel_projectExpenseButtons);
            Controls.Add(panel_projectMessage);
            Controls.Add(panel_employeeDataTable);
            Name = "UserControl_ProjectExpenseImport";
            Size = new System.Drawing.Size(1006, 642);
            Load += UserControl1_Load;
            panel_employeeDataTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_projectExpense).EndInit();
            panel_projectMessage.ResumeLayout(false);
            panel_projectMessage.PerformLayout();
            panel_projectExpenseButtons.ResumeLayout(false);
            panel_projectExpenseFieldMapping.ResumeLayout(false);
            panel_projectExpenseFieldMapping.PerformLayout();
            flowLayoutPanel_nonMandatoryFields.ResumeLayout(false);
            panel_NonMandatoryButton.ResumeLayout(false);
            panel_NonMandatoryButton.PerformLayout();
            panel_NonMandatoryFields.ResumeLayout(false);
            panel_NonMandatoryFields.PerformLayout();
            groupBox_projectExpenseMandatoryFields.ResumeLayout(false);
            groupBox_projectExpenseMandatoryFields.PerformLayout();
            ResumeLayout(false);

        }

        #endregion


        private void AddRowNumberToDataTable()
        {
            this.dataGridView_projectExpense.DataBindingComplete += (o, e) =>
            {
                foreach (System.Windows.Forms.DataGridViewRow row in dataGridView_projectExpense.Rows)
                {
                    row.HeaderCell.Value = (row.Index + 1).ToString();

                }
            };
            this.dataGridView_projectExpense.RowHeadersWidth = 65;
        }


        private System.ComponentModel.BackgroundWorker WorkerFetcher;
        private System.Windows.Forms.Panel panel_employeeDataTable;
        private System.Windows.Forms.DataGridView dataGridView_projectExpense;
        private System.Windows.Forms.Panel panel_projectMessage;
        private System.Windows.Forms.Panel panel_projectExpenseButtons;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_import;
        private System.Windows.Forms.Button button_validate;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Panel panel_projectExpenseFieldMapping;
        private System.Windows.Forms.GroupBox groupBox_projectExpenseMandatoryFields;
        private System.Windows.Forms.ComboBox comboBox_projectNo;
        private System.Windows.Forms.Label label_projectNo;
        private System.Windows.Forms.Label label_projectExpenseSetup;
        private System.Windows.Forms.Button button_projectExpenseSelectFile;
        private System.Windows.Forms.TextBox textBox_projectExpenseImportMessages;
        private System.Windows.Forms.Label label_paymentMethod;
        private System.Windows.Forms.ComboBox comboBox_paymentMethod;
        private System.Windows.Forms.Label label_purchaseDate;
        private System.Windows.Forms.ComboBox comboBox_purchaseDate;
        private System.Windows.Forms.Label label_salesPriceAmount;
        private System.Windows.Forms.ComboBox comboBox_salesPriceAmount;
        private System.Windows.Forms.Label label_amountIncludingVAT;
        private System.Windows.Forms.ComboBox comboBox_amountIncludingVAT;
        private System.Windows.Forms.Label label_expenseType;
        private System.Windows.Forms.ComboBox comboBox_expenseType;
        private System.Windows.Forms.Label label_delimiter;
        private System.Windows.Forms.ComboBox comboBox_delimiter;
        private System.Windows.Forms.Label label_supplierInvoiceNo;
        private System.Windows.Forms.ComboBox comboBox_supplierInvoiceNo;
        private System.Windows.Forms.Label label_isBillable;
        private System.Windows.Forms.ComboBox comboBox_isBillable;
        private System.Windows.Forms.Label label_supplierNo;
        private System.Windows.Forms.ComboBox comboBox_supplierNo;
        private System.Windows.Forms.Label label_comment;
        private System.Windows.Forms.ComboBox comboBox_comment;
        private System.Windows.Forms.Label label_exchangeRate;
        private System.Windows.Forms.ComboBox comboBox_exchangeRate;
        private System.Windows.Forms.Label label_externalID;
        private System.Windows.Forms.ComboBox comboBox_externalID;
        private System.Windows.Forms.CheckBox checkBox_defaultPaymentMethod;
        private System.Windows.Forms.CheckBox checkBox_defaultExpenseType;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_nonMandatoryFields;
        private System.Windows.Forms.Panel panel_NonMandatoryButton;
        private System.Windows.Forms.Panel panel_NonMandatoryFields;
        private System.Windows.Forms.Label label_nonMandatoryFields;
        private System.Windows.Forms.Button button_expandNonMandatory;
        private System.Windows.Forms.Timer tmrExpand;
        private System.Windows.Forms.ToolTip defaultToolTip;
        private System.Windows.Forms.Label label_expenseCurrencyISO;
        private System.Windows.Forms.Label label_VATAmountCurrency;
        private System.Windows.Forms.Label label_expenseNo;
        private System.Windows.Forms.ComboBox comboBox_contractName;
        private System.Windows.Forms.ComboBox comboBox_expenseCurrencyISO;
        private System.Windows.Forms.ComboBox comboBox_VATAmount;
        private System.Windows.Forms.ComboBox comboBox_expenseNo;
        private System.Windows.Forms.Label label_contractName;
        private System.Windows.Forms.Label label_profitRatio;
        private System.Windows.Forms.ComboBox comboBox_profitRatio;
        private System.Windows.Forms.CheckBox checkBox_defaultExpenseCurrencyISO;
        private System.Windows.Forms.CheckBox checkBox_defaultIsBillable;
    }
}
