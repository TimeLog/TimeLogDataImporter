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
            this.components = new System.ComponentModel.Container();
            this.WorkerFetcher = new System.ComponentModel.BackgroundWorker();
            this.panel_employeeDataTable = new System.Windows.Forms.Panel();
            this.dataGridView_projectExpense = new System.Windows.Forms.DataGridView();
            this.panel_projectMessage = new System.Windows.Forms.Panel();
            this.textBox_projectExpenseImportMessages = new System.Windows.Forms.TextBox();
            this.panel_projectExpenseButtons = new System.Windows.Forms.Panel();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_import = new System.Windows.Forms.Button();
            this.button_validate = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.panel_projectExpenseFieldMapping = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_nonMandatoryFields = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_NonMandatoryButton = new System.Windows.Forms.Panel();
            this.label_nonMandatoryFields = new System.Windows.Forms.Label();
            this.button_expandNonMandatory = new System.Windows.Forms.Button();
            this.panel_NonMandatoryFields = new System.Windows.Forms.Panel();
            this.comboBox_profitRatio = new System.Windows.Forms.ComboBox();
            this.label_profitRatio = new System.Windows.Forms.Label();
            this.label_externalID = new System.Windows.Forms.Label();
            this.comboBox_externalID = new System.Windows.Forms.ComboBox();
            this.label_supplierInvoiceNo = new System.Windows.Forms.Label();
            this.comboBox_supplierInvoiceNo = new System.Windows.Forms.ComboBox();
            this.comboBox_comment = new System.Windows.Forms.ComboBox();
            this.label_comment = new System.Windows.Forms.Label();
            this.label_supplierNo = new System.Windows.Forms.Label();
            this.comboBox_supplierNo = new System.Windows.Forms.ComboBox();
            this.label_delimiter = new System.Windows.Forms.Label();
            this.comboBox_delimiter = new System.Windows.Forms.ComboBox();
            this.groupBox_projectExpenseMandatoryFields = new System.Windows.Forms.GroupBox();
            this.checkBox_defaultIsBillable = new System.Windows.Forms.CheckBox();
            this.checkBox_defaultExpenseCurrencyISO = new System.Windows.Forms.CheckBox();
            this.comboBox_contractName = new System.Windows.Forms.ComboBox();
            this.comboBox_expenseCurrencyISO = new System.Windows.Forms.ComboBox();
            this.comboBox_VATAmount = new System.Windows.Forms.ComboBox();
            this.comboBox_expenseNo = new System.Windows.Forms.ComboBox();
            this.label_contractName = new System.Windows.Forms.Label();
            this.label_expenseCurrencyISO = new System.Windows.Forms.Label();
            this.label_VATAmountCurrency = new System.Windows.Forms.Label();
            this.label_expenseNo = new System.Windows.Forms.Label();
            this.checkBox_defaultExpenseType = new System.Windows.Forms.CheckBox();
            this.checkBox_defaultPaymentMethod = new System.Windows.Forms.CheckBox();
            this.label_salesPriceAmount = new System.Windows.Forms.Label();
            this.comboBox_salesPriceAmount = new System.Windows.Forms.ComboBox();
            this.comboBox_exchangeRate = new System.Windows.Forms.ComboBox();
            this.label_amountIncludingVAT = new System.Windows.Forms.Label();
            this.label_isBillable = new System.Windows.Forms.Label();
            this.label_exchangeRate = new System.Windows.Forms.Label();
            this.comboBox_amountIncludingVAT = new System.Windows.Forms.ComboBox();
            this.label_expenseType = new System.Windows.Forms.Label();
            this.comboBox_expenseType = new System.Windows.Forms.ComboBox();
            this.label_paymentMethod = new System.Windows.Forms.Label();
            this.comboBox_isBillable = new System.Windows.Forms.ComboBox();
            this.comboBox_paymentMethod = new System.Windows.Forms.ComboBox();
            this.label_purchaseDate = new System.Windows.Forms.Label();
            this.comboBox_purchaseDate = new System.Windows.Forms.ComboBox();
            this.label_projectNo = new System.Windows.Forms.Label();
            this.comboBox_projectNo = new System.Windows.Forms.ComboBox();
            this.label_projectExpenseSetup = new System.Windows.Forms.Label();
            this.button_projectExpenseSelectFile = new System.Windows.Forms.Button();
            this.tmrExpand = new System.Windows.Forms.Timer(this.components);
            this.defaultToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel_employeeDataTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_projectExpense)).BeginInit();
            this.panel_projectMessage.SuspendLayout();
            this.panel_projectExpenseButtons.SuspendLayout();
            this.panel_projectExpenseFieldMapping.SuspendLayout();
            this.flowLayoutPanel_nonMandatoryFields.SuspendLayout();
            this.panel_NonMandatoryButton.SuspendLayout();
            this.panel_NonMandatoryFields.SuspendLayout();
            this.groupBox_projectExpenseMandatoryFields.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkerFetcher
            // 
            this.WorkerFetcher.WorkerReportsProgress = true;
            this.WorkerFetcher.WorkerSupportsCancellation = true;
            this.WorkerFetcher.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WorkerFetcherDoWork);
            // 
            // panel_employeeDataTable
            // 
            this.panel_employeeDataTable.Controls.Add(this.dataGridView_projectExpense);
            this.panel_employeeDataTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_employeeDataTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_employeeDataTable.Location = new System.Drawing.Point(0, 770);
            this.panel_employeeDataTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_employeeDataTable.Name = "panel_employeeDataTable";
            this.panel_employeeDataTable.Size = new System.Drawing.Size(1437, 300);
            this.panel_employeeDataTable.TabIndex = 6;
            // 
            // dataGridView_projectExpense
            // 
            this.dataGridView_projectExpense.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView_projectExpense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_projectExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_projectExpense.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_projectExpense.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dataGridView_projectExpense.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_projectExpense.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_projectExpense.Name = "dataGridView_projectExpense";
            this.dataGridView_projectExpense.Size = new System.Drawing.Size(1437, 300);
            this.dataGridView_projectExpense.TabIndex = 0;
            // 
            // panel_projectMessage
            // 
            this.panel_projectMessage.Controls.Add(this.textBox_projectExpenseImportMessages);
            this.panel_projectMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_projectMessage.Location = new System.Drawing.Point(0, 463);
            this.panel_projectMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_projectMessage.Name = "panel_projectMessage";
            this.panel_projectMessage.Size = new System.Drawing.Size(1437, 307);
            this.panel_projectMessage.TabIndex = 10;
            // 
            // textBox_projectExpenseImportMessages
            // 
            this.textBox_projectExpenseImportMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_projectExpenseImportMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_projectExpenseImportMessages.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_projectExpenseImportMessages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox_projectExpenseImportMessages.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_projectExpenseImportMessages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_projectExpenseImportMessages.Location = new System.Drawing.Point(0, 0);
            this.textBox_projectExpenseImportMessages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_projectExpenseImportMessages.Multiline = true;
            this.textBox_projectExpenseImportMessages.Name = "textBox_projectExpenseImportMessages";
            this.textBox_projectExpenseImportMessages.ReadOnly = true;
            this.textBox_projectExpenseImportMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_projectExpenseImportMessages.Size = new System.Drawing.Size(1437, 307);
            this.textBox_projectExpenseImportMessages.TabIndex = 0;
            this.textBox_projectExpenseImportMessages.WordWrap = false;
            this.defaultToolTip.SetToolTip(this.textBox_projectExpenseImportMessages, "Validation or import status");
            this.textBox_projectExpenseImportMessages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_projectExpenseImportMessages_MouseClick);
            // 
            // panel_projectExpenseButtons
            // 
            this.panel_projectExpenseButtons.Controls.Add(this.button_clear);
            this.panel_projectExpenseButtons.Controls.Add(this.button_import);
            this.panel_projectExpenseButtons.Controls.Add(this.button_validate);
            this.panel_projectExpenseButtons.Controls.Add(this.button_stop);
            this.panel_projectExpenseButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_projectExpenseButtons.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel_projectExpenseButtons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_projectExpenseButtons.Location = new System.Drawing.Point(0, 376);
            this.panel_projectExpenseButtons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_projectExpenseButtons.Name = "panel_projectExpenseButtons";
            this.panel_projectExpenseButtons.Size = new System.Drawing.Size(1437, 87);
            this.panel_projectExpenseButtons.TabIndex = 12;
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
            // panel_projectExpenseFieldMapping
            // 
            this.panel_projectExpenseFieldMapping.AutoScroll = true;
            this.panel_projectExpenseFieldMapping.Controls.Add(this.flowLayoutPanel_nonMandatoryFields);
            this.panel_projectExpenseFieldMapping.Controls.Add(this.label_delimiter);
            this.panel_projectExpenseFieldMapping.Controls.Add(this.comboBox_delimiter);
            this.panel_projectExpenseFieldMapping.Controls.Add(this.groupBox_projectExpenseMandatoryFields);
            this.panel_projectExpenseFieldMapping.Controls.Add(this.label_projectExpenseSetup);
            this.panel_projectExpenseFieldMapping.Controls.Add(this.button_projectExpenseSelectFile);
            this.panel_projectExpenseFieldMapping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_projectExpenseFieldMapping.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel_projectExpenseFieldMapping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_projectExpenseFieldMapping.Location = new System.Drawing.Point(0, 0);
            this.panel_projectExpenseFieldMapping.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_projectExpenseFieldMapping.Name = "panel_projectExpenseFieldMapping";
            this.panel_projectExpenseFieldMapping.Size = new System.Drawing.Size(1437, 376);
            this.panel_projectExpenseFieldMapping.TabIndex = 13;
            // 
            // flowLayoutPanel_nonMandatoryFields
            // 
            this.flowLayoutPanel_nonMandatoryFields.Controls.Add(this.panel_NonMandatoryButton);
            this.flowLayoutPanel_nonMandatoryFields.Controls.Add(this.panel_NonMandatoryFields);
            this.flowLayoutPanel_nonMandatoryFields.Location = new System.Drawing.Point(817, 100);
            this.flowLayoutPanel_nonMandatoryFields.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel_nonMandatoryFields.Name = "flowLayoutPanel_nonMandatoryFields";
            this.flowLayoutPanel_nonMandatoryFields.Size = new System.Drawing.Size(557, 358);
            this.flowLayoutPanel_nonMandatoryFields.TabIndex = 7;
            // 
            // panel_NonMandatoryButton
            // 
            this.panel_NonMandatoryButton.Controls.Add(this.label_nonMandatoryFields);
            this.panel_NonMandatoryButton.Controls.Add(this.button_expandNonMandatory);
            this.panel_NonMandatoryButton.Location = new System.Drawing.Point(4, 5);
            this.panel_NonMandatoryButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_NonMandatoryButton.Name = "panel_NonMandatoryButton";
            this.panel_NonMandatoryButton.Size = new System.Drawing.Size(546, 53);
            this.panel_NonMandatoryButton.TabIndex = 0;
            // 
            // label_nonMandatoryFields
            // 
            this.label_nonMandatoryFields.AutoSize = true;
            this.label_nonMandatoryFields.ForeColor = System.Drawing.Color.Black;
            this.label_nonMandatoryFields.Location = new System.Drawing.Point(66, 13);
            this.label_nonMandatoryFields.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_nonMandatoryFields.Name = "label_nonMandatoryFields";
            this.label_nonMandatoryFields.Size = new System.Drawing.Size(107, 17);
            this.label_nonMandatoryFields.TabIndex = 1;
            this.label_nonMandatoryFields.Text = "Non-Mandatory";
            // 
            // button_expandNonMandatory
            // 
            this.button_expandNonMandatory.BackColor = System.Drawing.Color.White;
            this.button_expandNonMandatory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_expandNonMandatory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_expandNonMandatory.FlatAppearance.BorderSize = 0;
            this.button_expandNonMandatory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_expandNonMandatory.ForeColor = System.Drawing.Color.White;
            this.button_expandNonMandatory.Location = new System.Drawing.Point(14, 2);
            this.button_expandNonMandatory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_expandNonMandatory.Name = "button_expandNonMandatory";
            this.button_expandNonMandatory.Size = new System.Drawing.Size(43, 50);
            this.button_expandNonMandatory.TabIndex = 0;
            this.button_expandNonMandatory.UseVisualStyleBackColor = false;
            this.button_expandNonMandatory.Click += new System.EventHandler(this.button_expand_Click);
            // 
            // panel_NonMandatoryFields
            // 
            this.panel_NonMandatoryFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_profitRatio);
            this.panel_NonMandatoryFields.Controls.Add(this.label_profitRatio);
            this.panel_NonMandatoryFields.Controls.Add(this.label_externalID);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_externalID);
            this.panel_NonMandatoryFields.Controls.Add(this.label_supplierInvoiceNo);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_supplierInvoiceNo);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_comment);
            this.panel_NonMandatoryFields.Controls.Add(this.label_comment);
            this.panel_NonMandatoryFields.Controls.Add(this.label_supplierNo);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_supplierNo);
            this.panel_NonMandatoryFields.Location = new System.Drawing.Point(4, 68);
            this.panel_NonMandatoryFields.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_NonMandatoryFields.MaximumSize = new System.Drawing.Size(546, 275);
            this.panel_NonMandatoryFields.MinimumSize = new System.Drawing.Size(546, 0);
            this.panel_NonMandatoryFields.Name = "panel_NonMandatoryFields";
            this.panel_NonMandatoryFields.Size = new System.Drawing.Size(546, 275);
            this.panel_NonMandatoryFields.TabIndex = 1;
            // 
            // comboBox_profitRatio
            // 
            this.comboBox_profitRatio.FormattingEnabled = true;
            this.comboBox_profitRatio.Location = new System.Drawing.Point(219, 218);
            this.comboBox_profitRatio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_profitRatio.Name = "comboBox_profitRatio";
            this.comboBox_profitRatio.Size = new System.Drawing.Size(213, 25);
            this.comboBox_profitRatio.TabIndex = 10;
            // 
            // label_profitRatio
            // 
            this.label_profitRatio.AutoSize = true;
            this.label_profitRatio.Location = new System.Drawing.Point(14, 223);
            this.label_profitRatio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_profitRatio.Name = "label_profitRatio";
            this.label_profitRatio.Size = new System.Drawing.Size(76, 17);
            this.label_profitRatio.TabIndex = 1;
            this.label_profitRatio.Text = "Profit Ratio";
            // 
            // label_externalID
            // 
            this.label_externalID.AutoSize = true;
            this.label_externalID.Location = new System.Drawing.Point(14, 17);
            this.label_externalID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_externalID.Name = "label_externalID";
            this.label_externalID.Size = new System.Drawing.Size(74, 17);
            this.label_externalID.TabIndex = 1;
            this.label_externalID.Text = "External ID";
            // 
            // comboBox_externalID
            // 
            this.comboBox_externalID.FormattingEnabled = true;
            this.comboBox_externalID.Location = new System.Drawing.Point(219, 12);
            this.comboBox_externalID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_externalID.Name = "comboBox_externalID";
            this.comboBox_externalID.Size = new System.Drawing.Size(213, 25);
            this.comboBox_externalID.TabIndex = 3;
            // 
            // label_supplierInvoiceNo
            // 
            this.label_supplierInvoiceNo.AutoSize = true;
            this.label_supplierInvoiceNo.Location = new System.Drawing.Point(14, 172);
            this.label_supplierInvoiceNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_supplierInvoiceNo.Name = "label_supplierInvoiceNo";
            this.label_supplierInvoiceNo.Size = new System.Drawing.Size(126, 17);
            this.label_supplierInvoiceNo.TabIndex = 1;
            this.label_supplierInvoiceNo.Text = "Supplier Invoice No";
            // 
            // comboBox_supplierInvoiceNo
            // 
            this.comboBox_supplierInvoiceNo.FormattingEnabled = true;
            this.comboBox_supplierInvoiceNo.Location = new System.Drawing.Point(219, 167);
            this.comboBox_supplierInvoiceNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_supplierInvoiceNo.Name = "comboBox_supplierInvoiceNo";
            this.comboBox_supplierInvoiceNo.Size = new System.Drawing.Size(213, 25);
            this.comboBox_supplierInvoiceNo.TabIndex = 3;
            // 
            // comboBox_comment
            // 
            this.comboBox_comment.FormattingEnabled = true;
            this.comboBox_comment.Location = new System.Drawing.Point(219, 63);
            this.comboBox_comment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_comment.Name = "comboBox_comment";
            this.comboBox_comment.Size = new System.Drawing.Size(213, 25);
            this.comboBox_comment.TabIndex = 3;
            // 
            // label_comment
            // 
            this.label_comment.AutoSize = true;
            this.label_comment.Location = new System.Drawing.Point(14, 68);
            this.label_comment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_comment.Name = "label_comment";
            this.label_comment.Size = new System.Drawing.Size(68, 17);
            this.label_comment.TabIndex = 1;
            this.label_comment.Text = "Comment";
            // 
            // label_supplierNo
            // 
            this.label_supplierNo.AutoSize = true;
            this.label_supplierNo.Location = new System.Drawing.Point(14, 120);
            this.label_supplierNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_supplierNo.Name = "label_supplierNo";
            this.label_supplierNo.Size = new System.Drawing.Size(79, 17);
            this.label_supplierNo.TabIndex = 1;
            this.label_supplierNo.Text = "Supplier No";
            // 
            // comboBox_supplierNo
            // 
            this.comboBox_supplierNo.FormattingEnabled = true;
            this.comboBox_supplierNo.Location = new System.Drawing.Point(219, 115);
            this.comboBox_supplierNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_supplierNo.Name = "comboBox_supplierNo";
            this.comboBox_supplierNo.Size = new System.Drawing.Size(213, 25);
            this.comboBox_supplierNo.TabIndex = 3;
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
            this.comboBox_delimiter.TabIndex = 6;
            // 
            // groupBox_projectExpenseMandatoryFields
            // 
            this.groupBox_projectExpenseMandatoryFields.Controls.Add(this.checkBox_defaultIsBillable);
            this.groupBox_projectExpenseMandatoryFields.Controls.Add(this.checkBox_defaultExpenseCurrencyISO);
            this.groupBox_projectExpenseMandatoryFields.Controls.Add(this.comboBox_contractName);
            this.groupBox_projectExpenseMandatoryFields.Controls.Add(this.comboBox_expenseCurrencyISO);
            this.groupBox_projectExpenseMandatoryFields.Controls.Add(this.comboBox_VATAmount);
            this.groupBox_projectExpenseMandatoryFields.Controls.Add(this.comboBox_expenseNo);
            this.groupBox_projectExpenseMandatoryFields.Controls.Add(this.label_contractName);
            this.groupBox_projectExpenseMandatoryFields.Controls.Add(this.label_expenseCurrencyISO);
            this.groupBox_projectExpenseMandatoryFields.Controls.Add(this.label_VATAmountCurrency);
            this.groupBox_projectExpenseMandatoryFields.Controls.Add(this.label_expenseNo);
            this.groupBox_projectExpenseMandatoryFields.Controls.Add(this.checkBox_defaultExpenseType);
            this.groupBox_projectExpenseMandatoryFields.Controls.Add(this.checkBox_defaultPaymentMethod);
            this.groupBox_projectExpenseMandatoryFields.Controls.Add(this.label_salesPriceAmount);
            this.groupBox_projectExpenseMandatoryFields.Controls.Add(this.comboBox_salesPriceAmount);
            this.groupBox_projectExpenseMandatoryFields.Controls.Add(this.comboBox_exchangeRate);
            this.groupBox_projectExpenseMandatoryFields.Controls.Add(this.label_amountIncludingVAT);
            this.groupBox_projectExpenseMandatoryFields.Controls.Add(this.label_isBillable);
            this.groupBox_projectExpenseMandatoryFields.Controls.Add(this.label_exchangeRate);
            this.groupBox_projectExpenseMandatoryFields.Controls.Add(this.comboBox_amountIncludingVAT);
            this.groupBox_projectExpenseMandatoryFields.Controls.Add(this.label_expenseType);
            this.groupBox_projectExpenseMandatoryFields.Controls.Add(this.comboBox_expenseType);
            this.groupBox_projectExpenseMandatoryFields.Controls.Add(this.label_paymentMethod);
            this.groupBox_projectExpenseMandatoryFields.Controls.Add(this.comboBox_isBillable);
            this.groupBox_projectExpenseMandatoryFields.Controls.Add(this.comboBox_paymentMethod);
            this.groupBox_projectExpenseMandatoryFields.Controls.Add(this.label_purchaseDate);
            this.groupBox_projectExpenseMandatoryFields.Controls.Add(this.comboBox_purchaseDate);
            this.groupBox_projectExpenseMandatoryFields.Controls.Add(this.label_projectNo);
            this.groupBox_projectExpenseMandatoryFields.Controls.Add(this.comboBox_projectNo);
            this.groupBox_projectExpenseMandatoryFields.Location = new System.Drawing.Point(229, 103);
            this.groupBox_projectExpenseMandatoryFields.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_projectExpenseMandatoryFields.Name = "groupBox_projectExpenseMandatoryFields";
            this.groupBox_projectExpenseMandatoryFields.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_projectExpenseMandatoryFields.Size = new System.Drawing.Size(563, 675);
            this.groupBox_projectExpenseMandatoryFields.TabIndex = 5;
            this.groupBox_projectExpenseMandatoryFields.TabStop = false;
            this.groupBox_projectExpenseMandatoryFields.Text = "Mandatory";
            // 
            // checkBox_defaultIsBillable
            // 
            this.checkBox_defaultIsBillable.AutoSize = true;
            this.checkBox_defaultIsBillable.Location = new System.Drawing.Point(461, 353);
            this.checkBox_defaultIsBillable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_defaultIsBillable.Name = "checkBox_defaultIsBillable";
            this.checkBox_defaultIsBillable.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultIsBillable.TabIndex = 14;
            this.checkBox_defaultIsBillable.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultIsBillable, "Set default values for all rows of a particular column field");
            this.checkBox_defaultIsBillable.UseVisualStyleBackColor = true;
            this.checkBox_defaultIsBillable.CheckedChanged += new System.EventHandler(this.checkBox_defaultIsBillable_CheckedChanged);
            // 
            // checkBox_defaultExpenseCurrencyISO
            // 
            this.checkBox_defaultExpenseCurrencyISO.AutoSize = true;
            this.checkBox_defaultExpenseCurrencyISO.Location = new System.Drawing.Point(461, 508);
            this.checkBox_defaultExpenseCurrencyISO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_defaultExpenseCurrencyISO.Name = "checkBox_defaultExpenseCurrencyISO";
            this.checkBox_defaultExpenseCurrencyISO.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultExpenseCurrencyISO.TabIndex = 12;
            this.checkBox_defaultExpenseCurrencyISO.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultExpenseCurrencyISO, "Set default values for all rows of a particular column field");
            this.checkBox_defaultExpenseCurrencyISO.UseVisualStyleBackColor = true;
            this.checkBox_defaultExpenseCurrencyISO.CheckedChanged += new System.EventHandler(this.checkBox_defaultExpenseCurrencyISO_CheckedChanged);
            // 
            // comboBox_contractName
            // 
            this.comboBox_contractName.FormattingEnabled = true;
            this.comboBox_contractName.Location = new System.Drawing.Point(233, 557);
            this.comboBox_contractName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_contractName.Name = "comboBox_contractName";
            this.comboBox_contractName.Size = new System.Drawing.Size(218, 25);
            this.comboBox_contractName.TabIndex = 10;
            // 
            // comboBox_expenseCurrencyISO
            // 
            this.comboBox_expenseCurrencyISO.FormattingEnabled = true;
            this.comboBox_expenseCurrencyISO.Location = new System.Drawing.Point(233, 505);
            this.comboBox_expenseCurrencyISO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_expenseCurrencyISO.Name = "comboBox_expenseCurrencyISO";
            this.comboBox_expenseCurrencyISO.Size = new System.Drawing.Size(218, 25);
            this.comboBox_expenseCurrencyISO.TabIndex = 9;
            // 
            // comboBox_VATAmount
            // 
            this.comboBox_VATAmount.FormattingEnabled = true;
            this.comboBox_VATAmount.Location = new System.Drawing.Point(233, 453);
            this.comboBox_VATAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_VATAmount.Name = "comboBox_VATAmount";
            this.comboBox_VATAmount.Size = new System.Drawing.Size(218, 25);
            this.comboBox_VATAmount.TabIndex = 8;
            // 
            // comboBox_expenseNo
            // 
            this.comboBox_expenseNo.FormattingEnabled = true;
            this.comboBox_expenseNo.Location = new System.Drawing.Point(233, 402);
            this.comboBox_expenseNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_expenseNo.Name = "comboBox_expenseNo";
            this.comboBox_expenseNo.Size = new System.Drawing.Size(218, 25);
            this.comboBox_expenseNo.TabIndex = 7;
            // 
            // label_contractName
            // 
            this.label_contractName.AutoSize = true;
            this.label_contractName.Location = new System.Drawing.Point(9, 562);
            this.label_contractName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_contractName.Name = "label_contractName";
            this.label_contractName.Size = new System.Drawing.Size(100, 17);
            this.label_contractName.TabIndex = 1;
            this.label_contractName.Text = "Contract Name";
            // 
            // label_expenseCurrencyISO
            // 
            this.label_expenseCurrencyISO.AutoSize = true;
            this.label_expenseCurrencyISO.Location = new System.Drawing.Point(9, 510);
            this.label_expenseCurrencyISO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_expenseCurrencyISO.Name = "label_expenseCurrencyISO";
            this.label_expenseCurrencyISO.Size = new System.Drawing.Size(141, 17);
            this.label_expenseCurrencyISO.TabIndex = 1;
            this.label_expenseCurrencyISO.Text = "Expense Currency ISO";
            // 
            // label_VATAmountCurrency
            // 
            this.label_VATAmountCurrency.AutoSize = true;
            this.label_VATAmountCurrency.Location = new System.Drawing.Point(9, 458);
            this.label_VATAmountCurrency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_VATAmountCurrency.Name = "label_VATAmountCurrency";
            this.label_VATAmountCurrency.Size = new System.Drawing.Size(84, 17);
            this.label_VATAmountCurrency.TabIndex = 1;
            this.label_VATAmountCurrency.Text = "VAT Amount";
            this.defaultToolTip.SetToolTip(this.label_VATAmountCurrency, "In expense currency");
            // 
            // label_expenseNo
            // 
            this.label_expenseNo.AutoSize = true;
            this.label_expenseNo.Location = new System.Drawing.Point(9, 407);
            this.label_expenseNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_expenseNo.Name = "label_expenseNo";
            this.label_expenseNo.Size = new System.Drawing.Size(80, 17);
            this.label_expenseNo.TabIndex = 1;
            this.label_expenseNo.Text = "Expense No";
            // 
            // checkBox_defaultExpenseType
            // 
            this.checkBox_defaultExpenseType.AutoSize = true;
            this.checkBox_defaultExpenseType.Location = new System.Drawing.Point(461, 198);
            this.checkBox_defaultExpenseType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_defaultExpenseType.Name = "checkBox_defaultExpenseType";
            this.checkBox_defaultExpenseType.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultExpenseType.TabIndex = 6;
            this.checkBox_defaultExpenseType.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultExpenseType, "Set default values for all rows of a particular column field");
            this.checkBox_defaultExpenseType.UseVisualStyleBackColor = true;
            this.checkBox_defaultExpenseType.CheckedChanged += new System.EventHandler(this.checkBox_defaultExpenseType_CheckedChanged);
            // 
            // checkBox_defaultPaymentMethod
            // 
            this.checkBox_defaultPaymentMethod.AutoSize = true;
            this.checkBox_defaultPaymentMethod.Location = new System.Drawing.Point(461, 147);
            this.checkBox_defaultPaymentMethod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_defaultPaymentMethod.Name = "checkBox_defaultPaymentMethod";
            this.checkBox_defaultPaymentMethod.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultPaymentMethod.TabIndex = 4;
            this.checkBox_defaultPaymentMethod.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultPaymentMethod, "Set default values for all rows of a particular column field");
            this.checkBox_defaultPaymentMethod.UseVisualStyleBackColor = true;
            this.checkBox_defaultPaymentMethod.CheckedChanged += new System.EventHandler(this.checkBox_defaultPaymentMethod_CheckedChanged);
            // 
            // label_salesPriceAmount
            // 
            this.label_salesPriceAmount.AutoSize = true;
            this.label_salesPriceAmount.Location = new System.Drawing.Point(9, 303);
            this.label_salesPriceAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_salesPriceAmount.Name = "label_salesPriceAmount";
            this.label_salesPriceAmount.Size = new System.Drawing.Size(125, 17);
            this.label_salesPriceAmount.TabIndex = 1;
            this.label_salesPriceAmount.Text = "Sales Price Amount";
            this.defaultToolTip.SetToolTip(this.label_salesPriceAmount, "In project currency");
            // 
            // comboBox_salesPriceAmount
            // 
            this.comboBox_salesPriceAmount.FormattingEnabled = true;
            this.comboBox_salesPriceAmount.Location = new System.Drawing.Point(233, 298);
            this.comboBox_salesPriceAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_salesPriceAmount.Name = "comboBox_salesPriceAmount";
            this.comboBox_salesPriceAmount.Size = new System.Drawing.Size(218, 25);
            this.comboBox_salesPriceAmount.TabIndex = 3;
            // 
            // comboBox_exchangeRate
            // 
            this.comboBox_exchangeRate.FormattingEnabled = true;
            this.comboBox_exchangeRate.Location = new System.Drawing.Point(233, 608);
            this.comboBox_exchangeRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_exchangeRate.Name = "comboBox_exchangeRate";
            this.comboBox_exchangeRate.Size = new System.Drawing.Size(218, 25);
            this.comboBox_exchangeRate.TabIndex = 3;
            // 
            // label_amountIncludingVAT
            // 
            this.label_amountIncludingVAT.AutoSize = true;
            this.label_amountIncludingVAT.Location = new System.Drawing.Point(9, 252);
            this.label_amountIncludingVAT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_amountIncludingVAT.Name = "label_amountIncludingVAT";
            this.label_amountIncludingVAT.Size = new System.Drawing.Size(108, 17);
            this.label_amountIncludingVAT.TabIndex = 1;
            this.label_amountIncludingVAT.Text = "Amount inc. VAT";
            this.defaultToolTip.SetToolTip(this.label_amountIncludingVAT, "In expense currency");
            // 
            // label_isBillable
            // 
            this.label_isBillable.AutoSize = true;
            this.label_isBillable.Location = new System.Drawing.Point(9, 355);
            this.label_isBillable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_isBillable.Name = "label_isBillable";
            this.label_isBillable.Size = new System.Drawing.Size(64, 17);
            this.label_isBillable.TabIndex = 1;
            this.label_isBillable.Text = "Is Billable";
            // 
            // label_exchangeRate
            // 
            this.label_exchangeRate.AutoSize = true;
            this.label_exchangeRate.Location = new System.Drawing.Point(9, 613);
            this.label_exchangeRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_exchangeRate.Name = "label_exchangeRate";
            this.label_exchangeRate.Size = new System.Drawing.Size(97, 17);
            this.label_exchangeRate.TabIndex = 1;
            this.label_exchangeRate.Text = "Exchange Rate";
            // 
            // comboBox_amountIncludingVAT
            // 
            this.comboBox_amountIncludingVAT.FormattingEnabled = true;
            this.comboBox_amountIncludingVAT.Location = new System.Drawing.Point(233, 247);
            this.comboBox_amountIncludingVAT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_amountIncludingVAT.Name = "comboBox_amountIncludingVAT";
            this.comboBox_amountIncludingVAT.Size = new System.Drawing.Size(218, 25);
            this.comboBox_amountIncludingVAT.TabIndex = 3;
            // 
            // label_expenseType
            // 
            this.label_expenseType.AutoSize = true;
            this.label_expenseType.Location = new System.Drawing.Point(9, 200);
            this.label_expenseType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_expenseType.Name = "label_expenseType";
            this.label_expenseType.Size = new System.Drawing.Size(90, 17);
            this.label_expenseType.TabIndex = 1;
            this.label_expenseType.Text = "Expense Type";
            // 
            // comboBox_expenseType
            // 
            this.comboBox_expenseType.FormattingEnabled = true;
            this.comboBox_expenseType.Location = new System.Drawing.Point(233, 195);
            this.comboBox_expenseType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_expenseType.Name = "comboBox_expenseType";
            this.comboBox_expenseType.Size = new System.Drawing.Size(218, 25);
            this.comboBox_expenseType.TabIndex = 3;
            // 
            // label_paymentMethod
            // 
            this.label_paymentMethod.AutoSize = true;
            this.label_paymentMethod.Location = new System.Drawing.Point(9, 148);
            this.label_paymentMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_paymentMethod.Name = "label_paymentMethod";
            this.label_paymentMethod.Size = new System.Drawing.Size(114, 17);
            this.label_paymentMethod.TabIndex = 1;
            this.label_paymentMethod.Text = "Payment Method";
            // 
            // comboBox_isBillable
            // 
            this.comboBox_isBillable.FormattingEnabled = true;
            this.comboBox_isBillable.Location = new System.Drawing.Point(233, 350);
            this.comboBox_isBillable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_isBillable.Name = "comboBox_isBillable";
            this.comboBox_isBillable.Size = new System.Drawing.Size(218, 25);
            this.comboBox_isBillable.TabIndex = 3;
            // 
            // comboBox_paymentMethod
            // 
            this.comboBox_paymentMethod.FormattingEnabled = true;
            this.comboBox_paymentMethod.Location = new System.Drawing.Point(233, 143);
            this.comboBox_paymentMethod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_paymentMethod.Name = "comboBox_paymentMethod";
            this.comboBox_paymentMethod.Size = new System.Drawing.Size(218, 25);
            this.comboBox_paymentMethod.TabIndex = 3;
            // 
            // label_purchaseDate
            // 
            this.label_purchaseDate.AutoSize = true;
            this.label_purchaseDate.Location = new System.Drawing.Point(9, 97);
            this.label_purchaseDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_purchaseDate.Name = "label_purchaseDate";
            this.label_purchaseDate.Size = new System.Drawing.Size(95, 17);
            this.label_purchaseDate.TabIndex = 1;
            this.label_purchaseDate.Text = "Purchase Date";
            // 
            // comboBox_purchaseDate
            // 
            this.comboBox_purchaseDate.FormattingEnabled = true;
            this.comboBox_purchaseDate.Location = new System.Drawing.Point(233, 92);
            this.comboBox_purchaseDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_purchaseDate.Name = "comboBox_purchaseDate";
            this.comboBox_purchaseDate.Size = new System.Drawing.Size(218, 25);
            this.comboBox_purchaseDate.TabIndex = 3;
            // 
            // label_projectNo
            // 
            this.label_projectNo.AutoSize = true;
            this.label_projectNo.Location = new System.Drawing.Point(9, 45);
            this.label_projectNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_projectNo.Name = "label_projectNo";
            this.label_projectNo.Size = new System.Drawing.Size(72, 17);
            this.label_projectNo.TabIndex = 1;
            this.label_projectNo.Text = "Project No";
            // 
            // comboBox_projectNo
            // 
            this.comboBox_projectNo.FormattingEnabled = true;
            this.comboBox_projectNo.Location = new System.Drawing.Point(233, 40);
            this.comboBox_projectNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_projectNo.Name = "comboBox_projectNo";
            this.comboBox_projectNo.Size = new System.Drawing.Size(218, 25);
            this.comboBox_projectNo.TabIndex = 3;
            // 
            // label_projectExpenseSetup
            // 
            this.label_projectExpenseSetup.AutoSize = true;
            this.label_projectExpenseSetup.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_projectExpenseSetup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_projectExpenseSetup.Location = new System.Drawing.Point(10, 27);
            this.label_projectExpenseSetup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_projectExpenseSetup.Name = "label_projectExpenseSetup";
            this.label_projectExpenseSetup.Size = new System.Drawing.Size(326, 32);
            this.label_projectExpenseSetup.TabIndex = 0;
            this.label_projectExpenseSetup.Text = "Project Expense Data Import";
            // 
            // button_projectExpenseSelectFile
            // 
            this.button_projectExpenseSelectFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(43)))), ((int)(((byte)(141)))));
            this.button_projectExpenseSelectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_projectExpenseSelectFile.FlatAppearance.BorderSize = 0;
            this.button_projectExpenseSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_projectExpenseSelectFile.ForeColor = System.Drawing.Color.White;
            this.button_projectExpenseSelectFile.Location = new System.Drawing.Point(19, 185);
            this.button_projectExpenseSelectFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_projectExpenseSelectFile.Name = "button_projectExpenseSelectFile";
            this.button_projectExpenseSelectFile.Size = new System.Drawing.Size(114, 48);
            this.button_projectExpenseSelectFile.TabIndex = 4;
            this.button_projectExpenseSelectFile.Text = "Select File";
            this.defaultToolTip.SetToolTip(this.button_projectExpenseSelectFile, "Select input CSV file");
            this.button_projectExpenseSelectFile.UseVisualStyleBackColor = false;
            this.button_projectExpenseSelectFile.Click += new System.EventHandler(this.button_select_project_file_Click);
            // 
            // tmrExpand
            // 
            this.tmrExpand.Interval = 10;
            this.tmrExpand.Tick += new System.EventHandler(this.tmrExpand_Tick);
            // 
            // defaultToolTip
            // 
            this.defaultToolTip.ShowAlways = true;
            // 
            // UserControl_ProjectExpenseImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_projectExpenseFieldMapping);
            this.Controls.Add(this.panel_projectExpenseButtons);
            this.Controls.Add(this.panel_projectMessage);
            this.Controls.Add(this.panel_employeeDataTable);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControl_ProjectExpenseImport";
            this.Size = new System.Drawing.Size(1437, 1070);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.panel_employeeDataTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_projectExpense)).EndInit();
            this.panel_projectMessage.ResumeLayout(false);
            this.panel_projectMessage.PerformLayout();
            this.panel_projectExpenseButtons.ResumeLayout(false);
            this.panel_projectExpenseFieldMapping.ResumeLayout(false);
            this.panel_projectExpenseFieldMapping.PerformLayout();
            this.flowLayoutPanel_nonMandatoryFields.ResumeLayout(false);
            this.panel_NonMandatoryButton.ResumeLayout(false);
            this.panel_NonMandatoryButton.PerformLayout();
            this.panel_NonMandatoryFields.ResumeLayout(false);
            this.panel_NonMandatoryFields.PerformLayout();
            this.groupBox_projectExpenseMandatoryFields.ResumeLayout(false);
            this.groupBox_projectExpenseMandatoryFields.PerformLayout();
            this.ResumeLayout(false);

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
