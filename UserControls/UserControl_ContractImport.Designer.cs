namespace TimeLog.DataImporter.UserControls
{
    partial class UserControl_ContractImport
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
            this.panel_projectDataTable = new System.Windows.Forms.Panel();
            this.dataGridView_contract = new System.Windows.Forms.DataGridView();
            this.panel_projectMessage = new System.Windows.Forms.Panel();
            this.textBox_contractImportMessages = new System.Windows.Forms.TextBox();
            this.panel_contractButtons = new System.Windows.Forms.Panel();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_import = new System.Windows.Forms.Button();
            this.button_validate = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.panel_contractFieldMapping = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_nonMandatoryFields = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_NonMandatoryButton = new System.Windows.Forms.Panel();
            this.label_nonMandatoryFields = new System.Windows.Forms.Label();
            this.button_expandNonMandatory = new System.Windows.Forms.Button();
            this.panel_NonMandatoryFields = new System.Windows.Forms.Panel();
            this.checkBox_defaultContractIsTravelLinked = new System.Windows.Forms.CheckBox();
            this.checkBox_defaultContractIsExpensesLinked = new System.Windows.Forms.CheckBox();
            this.label_contractIsExpensesLinked = new System.Windows.Forms.Label();
            this.label_contractIsTravelLinked = new System.Windows.Forms.Label();
            this.comboBox_contractIsTravelLinked = new System.Windows.Forms.ComboBox();
            this.comboBox_contractIsExpensesLinked = new System.Windows.Forms.ComboBox();
            this.label_contractRevenueTravelAmount = new System.Windows.Forms.Label();
            this.comboBox_contractRevenueTravelAmount = new System.Windows.Forms.ComboBox();
            this.label_contractRevenueExprAmount = new System.Windows.Forms.Label();
            this.comboBox_contractRevenueExprAmount = new System.Windows.Forms.ComboBox();
            this.label_contractPaymentPlanAmount = new System.Windows.Forms.Label();
            this.comboBox_contractPaymentPlanAmount = new System.Windows.Forms.ComboBox();
            this.label_contractTargetHourlyRate = new System.Windows.Forms.Label();
            this.comboBox_contractTargetHourlyRate = new System.Windows.Forms.ComboBox();
            this.checkBox_defaultContractHasBudgetOverrunNotification = new System.Windows.Forms.CheckBox();
            this.label_contractHasBudgetOverrunNotification = new System.Windows.Forms.Label();
            this.comboBox_contractHasBudgetOverrunNotification = new System.Windows.Forms.ComboBox();
            this.checkBox_defaultContractIsDefaultExpenses = new System.Windows.Forms.CheckBox();
            this.label_contractIsDefaultExpenses = new System.Windows.Forms.Label();
            this.comboBox_contractIsDefaultExpenses = new System.Windows.Forms.ComboBox();
            this.checkBox_defaultContractIsMileageBillable = new System.Windows.Forms.CheckBox();
            this.label_contractIsMileageBillable = new System.Windows.Forms.Label();
            this.comboBox_contractIsMileageBillable = new System.Windows.Forms.ComboBox();
            this.checkBox_defaultContractCompletionNotificationPercentage = new System.Windows.Forms.CheckBox();
            this.label_contractCompletionNotificationPercentage = new System.Windows.Forms.Label();
            this.comboBox_contractCompletionNotificationPercentage = new System.Windows.Forms.ComboBox();
            this.comboBox_contractBudgetExpensesAmount = new System.Windows.Forms.ComboBox();
            this.label_contractBudgetExpensesAmount = new System.Windows.Forms.Label();
            this.checkBox_defaultContractHasCompletionNotification = new System.Windows.Forms.CheckBox();
            this.label_contractHasCompletionNotification = new System.Windows.Forms.Label();
            this.comboBox_contractBudgetTravelAmount = new System.Windows.Forms.ComboBox();
            this.comboBox_contractHasCompletionNotification = new System.Windows.Forms.ComboBox();
            this.label_contractBudgetTravelAmount = new System.Windows.Forms.Label();
            this.comboBox_contractBudgetWorkAmount = new System.Windows.Forms.ComboBox();
            this.label_contractBudgetWorkAmount = new System.Windows.Forms.Label();
            this.label_contractBudgetWorkHour = new System.Windows.Forms.Label();
            this.comboBox_contractBudgetWorkHour = new System.Windows.Forms.ComboBox();
            this.label_delimiter = new System.Windows.Forms.Label();
            this.comboBox_delimiter = new System.Windows.Forms.ComboBox();
            this.groupBox_contractMandatoryFields = new System.Windows.Forms.GroupBox();
            this.label_projectNo = new System.Windows.Forms.Label();
            this.checkBox_defaultContractStatus = new System.Windows.Forms.CheckBox();
            this.comboBox_projectNo = new System.Windows.Forms.ComboBox();
            this.label_contractOwnerInitials = new System.Windows.Forms.Label();
            this.comboBox_contractOwnerInitials = new System.Windows.Forms.ComboBox();
            this.label_contractStatus = new System.Windows.Forms.Label();
            this.comboBox_contractStatus = new System.Windows.Forms.ComboBox();
            this.label_projectName = new System.Windows.Forms.Label();
            this.comboBox_contractName = new System.Windows.Forms.ComboBox();
            this.label_contractSetup = new System.Windows.Forms.Label();
            this.button_contractSelectFile = new System.Windows.Forms.Button();
            this.tmrExpand = new System.Windows.Forms.Timer(this.components);
            this.defaultToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label_contractModel = new System.Windows.Forms.Label();
            this.comboBox_ContractModel = new System.Windows.Forms.ComboBox();
            this.checkBox_defaultContractModel = new System.Windows.Forms.CheckBox();
            this.panel_projectDataTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_contract)).BeginInit();
            this.panel_projectMessage.SuspendLayout();
            this.panel_contractButtons.SuspendLayout();
            this.panel_contractFieldMapping.SuspendLayout();
            this.flowLayoutPanel_nonMandatoryFields.SuspendLayout();
            this.panel_NonMandatoryButton.SuspendLayout();
            this.panel_NonMandatoryFields.SuspendLayout();
            this.groupBox_contractMandatoryFields.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkerFetcher
            // 
            this.WorkerFetcher.WorkerReportsProgress = true;
            this.WorkerFetcher.WorkerSupportsCancellation = true;
            this.WorkerFetcher.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WorkerFetcherDoWork);
            // 
            // panel_projectDataTable
            // 
            this.panel_projectDataTable.Controls.Add(this.dataGridView_contract);
            this.panel_projectDataTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_projectDataTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_projectDataTable.Location = new System.Drawing.Point(0, 581);
            this.panel_projectDataTable.Name = "panel_projectDataTable";
            this.panel_projectDataTable.Size = new System.Drawing.Size(1006, 361);
            this.panel_projectDataTable.TabIndex = 6;
            // 
            // dataGridView_contract
            // 
            this.dataGridView_contract.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView_contract.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_contract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_contract.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_contract.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dataGridView_contract.Location = new System.Drawing.Point(0, 10);
            this.dataGridView_contract.Name = "dataGridView_contract";
            this.dataGridView_contract.Size = new System.Drawing.Size(1006, 351);
            this.dataGridView_contract.TabIndex = 0;
            // 
            // panel_projectMessage
            // 
            this.panel_projectMessage.Controls.Add(this.textBox_contractImportMessages);
            this.panel_projectMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_projectMessage.Location = new System.Drawing.Point(0, 397);
            this.panel_projectMessage.Name = "panel_projectMessage";
            this.panel_projectMessage.Size = new System.Drawing.Size(1006, 184);
            this.panel_projectMessage.TabIndex = 10;
            // 
            // textBox_contractImportMessages
            // 
            this.textBox_contractImportMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_contractImportMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_contractImportMessages.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_contractImportMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_contractImportMessages.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_contractImportMessages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_contractImportMessages.Location = new System.Drawing.Point(0, 0);
            this.textBox_contractImportMessages.Multiline = true;
            this.textBox_contractImportMessages.Name = "textBox_contractImportMessages";
            this.textBox_contractImportMessages.ReadOnly = true;
            this.textBox_contractImportMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_contractImportMessages.Size = new System.Drawing.Size(1006, 184);
            this.textBox_contractImportMessages.TabIndex = 0;
            this.defaultToolTip.SetToolTip(this.textBox_contractImportMessages, "Validation or import status");
            this.textBox_contractImportMessages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_projectImportMessages_MouseClick);
            // 
            // panel_contractButtons
            // 
            this.panel_contractButtons.Controls.Add(this.button_clear);
            this.panel_contractButtons.Controls.Add(this.button_import);
            this.panel_contractButtons.Controls.Add(this.button_validate);
            this.panel_contractButtons.Controls.Add(this.button_stop);
            this.panel_contractButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_contractButtons.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel_contractButtons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_contractButtons.Location = new System.Drawing.Point(0, 345);
            this.panel_contractButtons.Name = "panel_contractButtons";
            this.panel_contractButtons.Size = new System.Drawing.Size(1006, 52);
            this.panel_contractButtons.TabIndex = 12;
            // 
            // button_clear
            // 
            this.button_clear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_clear.BackColor = System.Drawing.Color.DimGray;
            this.button_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_clear.FlatAppearance.BorderSize = 0;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.ForeColor = System.Drawing.Color.White;
            this.button_clear.Location = new System.Drawing.Point(14, 12);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(80, 29);
            this.button_clear.TabIndex = 12;
            this.button_clear.Text = "Reset All";
            this.defaultToolTip.SetToolTip(this.button_clear, "Reset all file input above and data table below");
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
            this.button_import.Location = new System.Drawing.Point(917, 12);
            this.button_import.Name = "button_import";
            this.button_import.Size = new System.Drawing.Size(80, 29);
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
            this.button_validate.Location = new System.Drawing.Point(745, 12);
            this.button_validate.Name = "button_validate";
            this.button_validate.Size = new System.Drawing.Size(80, 29);
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
            this.button_stop.Location = new System.Drawing.Point(831, 12);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(80, 29);
            this.button_stop.TabIndex = 11;
            this.button_stop.Text = "Stop";
            this.defaultToolTip.SetToolTip(this.button_stop, "Stop validation or import");
            this.button_stop.UseVisualStyleBackColor = false;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // panel_contractFieldMapping
            // 
            this.panel_contractFieldMapping.AutoScroll = true;
            this.panel_contractFieldMapping.Controls.Add(this.flowLayoutPanel_nonMandatoryFields);
            this.panel_contractFieldMapping.Controls.Add(this.label_delimiter);
            this.panel_contractFieldMapping.Controls.Add(this.comboBox_delimiter);
            this.panel_contractFieldMapping.Controls.Add(this.groupBox_contractMandatoryFields);
            this.panel_contractFieldMapping.Controls.Add(this.label_contractSetup);
            this.panel_contractFieldMapping.Controls.Add(this.button_contractSelectFile);
            this.panel_contractFieldMapping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contractFieldMapping.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel_contractFieldMapping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_contractFieldMapping.Location = new System.Drawing.Point(0, 0);
            this.panel_contractFieldMapping.Name = "panel_contractFieldMapping";
            this.panel_contractFieldMapping.Size = new System.Drawing.Size(1006, 345);
            this.panel_contractFieldMapping.TabIndex = 13;
            // 
            // flowLayoutPanel_nonMandatoryFields
            // 
            this.flowLayoutPanel_nonMandatoryFields.Controls.Add(this.panel_NonMandatoryButton);
            this.flowLayoutPanel_nonMandatoryFields.Controls.Add(this.panel_NonMandatoryFields);
            this.flowLayoutPanel_nonMandatoryFields.Location = new System.Drawing.Point(547, 60);
            this.flowLayoutPanel_nonMandatoryFields.Name = "flowLayoutPanel_nonMandatoryFields";
            this.flowLayoutPanel_nonMandatoryFields.Size = new System.Drawing.Size(419, 600);
            this.flowLayoutPanel_nonMandatoryFields.TabIndex = 7;
            // 
            // panel_NonMandatoryButton
            // 
            this.panel_NonMandatoryButton.Controls.Add(this.label_nonMandatoryFields);
            this.panel_NonMandatoryButton.Controls.Add(this.button_expandNonMandatory);
            this.panel_NonMandatoryButton.Location = new System.Drawing.Point(3, 3);
            this.panel_NonMandatoryButton.Name = "panel_NonMandatoryButton";
            this.panel_NonMandatoryButton.Size = new System.Drawing.Size(416, 32);
            this.panel_NonMandatoryButton.TabIndex = 0;
            // 
            // label_nonMandatoryFields
            // 
            this.label_nonMandatoryFields.AutoSize = true;
            this.label_nonMandatoryFields.ForeColor = System.Drawing.Color.Black;
            this.label_nonMandatoryFields.Location = new System.Drawing.Point(46, 8);
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
            this.button_expandNonMandatory.Location = new System.Drawing.Point(10, 1);
            this.button_expandNonMandatory.Name = "button_expandNonMandatory";
            this.button_expandNonMandatory.Size = new System.Drawing.Size(30, 30);
            this.button_expandNonMandatory.TabIndex = 0;
            this.button_expandNonMandatory.UseVisualStyleBackColor = false;
            this.button_expandNonMandatory.Click += new System.EventHandler(this.button_expand_Click);
            // 
            // panel_NonMandatoryFields
            // 
            this.panel_NonMandatoryFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_NonMandatoryFields.Controls.Add(this.checkBox_defaultContractIsTravelLinked);
            this.panel_NonMandatoryFields.Controls.Add(this.checkBox_defaultContractIsExpensesLinked);
            this.panel_NonMandatoryFields.Controls.Add(this.label_contractIsExpensesLinked);
            this.panel_NonMandatoryFields.Controls.Add(this.label_contractIsTravelLinked);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_contractIsTravelLinked);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_contractIsExpensesLinked);
            this.panel_NonMandatoryFields.Controls.Add(this.label_contractRevenueTravelAmount);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_contractRevenueTravelAmount);
            this.panel_NonMandatoryFields.Controls.Add(this.label_contractRevenueExprAmount);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_contractRevenueExprAmount);
            this.panel_NonMandatoryFields.Controls.Add(this.label_contractPaymentPlanAmount);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_contractPaymentPlanAmount);
            this.panel_NonMandatoryFields.Controls.Add(this.label_contractTargetHourlyRate);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_contractTargetHourlyRate);
            this.panel_NonMandatoryFields.Controls.Add(this.checkBox_defaultContractHasBudgetOverrunNotification);
            this.panel_NonMandatoryFields.Controls.Add(this.label_contractHasBudgetOverrunNotification);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_contractHasBudgetOverrunNotification);
            this.panel_NonMandatoryFields.Controls.Add(this.checkBox_defaultContractIsDefaultExpenses);
            this.panel_NonMandatoryFields.Controls.Add(this.label_contractIsDefaultExpenses);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_contractIsDefaultExpenses);
            this.panel_NonMandatoryFields.Controls.Add(this.checkBox_defaultContractIsMileageBillable);
            this.panel_NonMandatoryFields.Controls.Add(this.label_contractIsMileageBillable);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_contractIsMileageBillable);
            this.panel_NonMandatoryFields.Controls.Add(this.checkBox_defaultContractCompletionNotificationPercentage);
            this.panel_NonMandatoryFields.Controls.Add(this.label_contractCompletionNotificationPercentage);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_contractCompletionNotificationPercentage);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_contractBudgetExpensesAmount);
            this.panel_NonMandatoryFields.Controls.Add(this.label_contractBudgetExpensesAmount);
            this.panel_NonMandatoryFields.Controls.Add(this.checkBox_defaultContractHasCompletionNotification);
            this.panel_NonMandatoryFields.Controls.Add(this.label_contractHasCompletionNotification);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_contractBudgetTravelAmount);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_contractHasCompletionNotification);
            this.panel_NonMandatoryFields.Controls.Add(this.label_contractBudgetTravelAmount);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_contractBudgetWorkAmount);
            this.panel_NonMandatoryFields.Controls.Add(this.label_contractBudgetWorkAmount);
            this.panel_NonMandatoryFields.Controls.Add(this.label_contractBudgetWorkHour);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_contractBudgetWorkHour);
            this.panel_NonMandatoryFields.Location = new System.Drawing.Point(3, 41);
            this.panel_NonMandatoryFields.MinimumSize = new System.Drawing.Size(363, 0);
            this.panel_NonMandatoryFields.Name = "panel_NonMandatoryFields";
            this.panel_NonMandatoryFields.Size = new System.Drawing.Size(416, 550);
            this.panel_NonMandatoryFields.TabIndex = 1;
            // 
            // checkBox_defaultContractIsTravelLinked
            // 
            this.checkBox_defaultContractIsTravelLinked.AutoSize = true;
            this.checkBox_defaultContractIsTravelLinked.Location = new System.Drawing.Point(340, 498);
            this.checkBox_defaultContractIsTravelLinked.Name = "checkBox_defaultContractIsTravelLinked";
            this.checkBox_defaultContractIsTravelLinked.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultContractIsTravelLinked.TabIndex = 43;
            this.checkBox_defaultContractIsTravelLinked.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultContractIsTravelLinked, "Set default values for all rows of a particular column field");
            this.checkBox_defaultContractIsTravelLinked.UseVisualStyleBackColor = true;
            this.checkBox_defaultContractIsTravelLinked.CheckedChanged += new System.EventHandler(this.checkBox_defaultContractIsTravelLinked_CheckedChanged);
            // 
            // checkBox_defaultContractIsExpensesLinked
            // 
            this.checkBox_defaultContractIsExpensesLinked.AutoSize = true;
            this.checkBox_defaultContractIsExpensesLinked.Location = new System.Drawing.Point(340, 467);
            this.checkBox_defaultContractIsExpensesLinked.Name = "checkBox_defaultContractIsExpensesLinked";
            this.checkBox_defaultContractIsExpensesLinked.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultContractIsExpensesLinked.TabIndex = 40;
            this.checkBox_defaultContractIsExpensesLinked.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultContractIsExpensesLinked, "Set default values for all rows of a particular column field");
            this.checkBox_defaultContractIsExpensesLinked.UseVisualStyleBackColor = true;
            this.checkBox_defaultContractIsExpensesLinked.CheckedChanged += new System.EventHandler(this.checkBox_defaultContractIsExpensesLinked_CheckedChanged);
            // 
            // label_contractIsExpensesLinked
            // 
            this.label_contractIsExpensesLinked.AutoSize = true;
            this.label_contractIsExpensesLinked.Location = new System.Drawing.Point(11, 468);
            this.label_contractIsExpensesLinked.Name = "label_contractIsExpensesLinked";
            this.label_contractIsExpensesLinked.Size = new System.Drawing.Size(121, 17);
            this.label_contractIsExpensesLinked.TabIndex = 38;
            this.label_contractIsExpensesLinked.Text = "Is Expenses Linked";
            // 
            // label_contractIsTravelLinked
            // 
            this.label_contractIsTravelLinked.AutoSize = true;
            this.label_contractIsTravelLinked.Location = new System.Drawing.Point(11, 499);
            this.label_contractIsTravelLinked.Name = "label_contractIsTravelLinked";
            this.label_contractIsTravelLinked.Size = new System.Drawing.Size(100, 17);
            this.label_contractIsTravelLinked.TabIndex = 41;
            this.label_contractIsTravelLinked.Text = "Is Travel Linked";
            // 
            // comboBox_contractIsTravelLinked
            // 
            this.comboBox_contractIsTravelLinked.FormattingEnabled = true;
            this.comboBox_contractIsTravelLinked.Location = new System.Drawing.Point(195, 496);
            this.comboBox_contractIsTravelLinked.Name = "comboBox_contractIsTravelLinked";
            this.comboBox_contractIsTravelLinked.Size = new System.Drawing.Size(139, 25);
            this.comboBox_contractIsTravelLinked.TabIndex = 42;
            this.comboBox_contractIsTravelLinked.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractIsTravelLinked_SelectedIndexChanged);
            // 
            // comboBox_contractIsExpensesLinked
            // 
            this.comboBox_contractIsExpensesLinked.FormattingEnabled = true;
            this.comboBox_contractIsExpensesLinked.Location = new System.Drawing.Point(195, 465);
            this.comboBox_contractIsExpensesLinked.Name = "comboBox_contractIsExpensesLinked";
            this.comboBox_contractIsExpensesLinked.Size = new System.Drawing.Size(139, 25);
            this.comboBox_contractIsExpensesLinked.TabIndex = 39;
            this.comboBox_contractIsExpensesLinked.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractIsExpensesLinked_SelectedIndexChanged);
            // 
            // label_contractRevenueTravelAmount
            // 
            this.label_contractRevenueTravelAmount.AutoSize = true;
            this.label_contractRevenueTravelAmount.Location = new System.Drawing.Point(11, 438);
            this.label_contractRevenueTravelAmount.Name = "label_contractRevenueTravelAmount";
            this.label_contractRevenueTravelAmount.Size = new System.Drawing.Size(153, 17);
            this.label_contractRevenueTravelAmount.TabIndex = 35;
            this.label_contractRevenueTravelAmount.Text = "Revenue Travel Amount";
            // 
            // comboBox_contractRevenueTravelAmount
            // 
            this.comboBox_contractRevenueTravelAmount.FormattingEnabled = true;
            this.comboBox_contractRevenueTravelAmount.Location = new System.Drawing.Point(195, 435);
            this.comboBox_contractRevenueTravelAmount.Name = "comboBox_contractRevenueTravelAmount";
            this.comboBox_contractRevenueTravelAmount.Size = new System.Drawing.Size(139, 25);
            this.comboBox_contractRevenueTravelAmount.TabIndex = 36;
            this.comboBox_contractRevenueTravelAmount.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractRevenueTravelAmount_SelectedIndexChanged);
            // 
            // label_contractRevenueExprAmount
            // 
            this.label_contractRevenueExprAmount.AutoSize = true;
            this.label_contractRevenueExprAmount.Location = new System.Drawing.Point(11, 406);
            this.label_contractRevenueExprAmount.Name = "label_contractRevenueExprAmount";
            this.label_contractRevenueExprAmount.Size = new System.Drawing.Size(145, 17);
            this.label_contractRevenueExprAmount.TabIndex = 32;
            this.label_contractRevenueExprAmount.Text = "Revenue Expr Amount";
            // 
            // comboBox_contractRevenueExprAmount
            // 
            this.comboBox_contractRevenueExprAmount.FormattingEnabled = true;
            this.comboBox_contractRevenueExprAmount.Location = new System.Drawing.Point(195, 403);
            this.comboBox_contractRevenueExprAmount.Name = "comboBox_contractRevenueExprAmount";
            this.comboBox_contractRevenueExprAmount.Size = new System.Drawing.Size(139, 25);
            this.comboBox_contractRevenueExprAmount.TabIndex = 33;
            this.comboBox_contractRevenueExprAmount.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractRevenueExprAmount_SelectedIndexChanged);
            // 
            // label_contractPaymentPlanAmount
            // 
            this.label_contractPaymentPlanAmount.AutoSize = true;
            this.label_contractPaymentPlanAmount.Location = new System.Drawing.Point(11, 373);
            this.label_contractPaymentPlanAmount.Name = "label_contractPaymentPlanAmount";
            this.label_contractPaymentPlanAmount.Size = new System.Drawing.Size(146, 17);
            this.label_contractPaymentPlanAmount.TabIndex = 29;
            this.label_contractPaymentPlanAmount.Text = "Payment Plan Amount";
            // 
            // comboBox_contractPaymentPlanAmount
            // 
            this.comboBox_contractPaymentPlanAmount.FormattingEnabled = true;
            this.comboBox_contractPaymentPlanAmount.Location = new System.Drawing.Point(195, 370);
            this.comboBox_contractPaymentPlanAmount.Name = "comboBox_contractPaymentPlanAmount";
            this.comboBox_contractPaymentPlanAmount.Size = new System.Drawing.Size(139, 25);
            this.comboBox_contractPaymentPlanAmount.TabIndex = 30;
            this.comboBox_contractPaymentPlanAmount.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractPaymentPlanAmount_SelectedIndexChanged);
            // 
            // label_contractTargetHourlyRate
            // 
            this.label_contractTargetHourlyRate.AutoSize = true;
            this.label_contractTargetHourlyRate.Location = new System.Drawing.Point(11, 342);
            this.label_contractTargetHourlyRate.Name = "label_contractTargetHourlyRate";
            this.label_contractTargetHourlyRate.Size = new System.Drawing.Size(122, 17);
            this.label_contractTargetHourlyRate.TabIndex = 26;
            this.label_contractTargetHourlyRate.Text = "Target Hourly Rate";
            // 
            // comboBox_contractTargetHourlyRate
            // 
            this.comboBox_contractTargetHourlyRate.FormattingEnabled = true;
            this.comboBox_contractTargetHourlyRate.Location = new System.Drawing.Point(195, 339);
            this.comboBox_contractTargetHourlyRate.Name = "comboBox_contractTargetHourlyRate";
            this.comboBox_contractTargetHourlyRate.Size = new System.Drawing.Size(139, 25);
            this.comboBox_contractTargetHourlyRate.TabIndex = 27;
            this.comboBox_contractTargetHourlyRate.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractTargetHourlyRate_SelectedIndexChanged);
            // 
            // checkBox_defaultContractHasBudgetOverrunNotification
            // 
            this.checkBox_defaultContractHasBudgetOverrunNotification.AutoSize = true;
            this.checkBox_defaultContractHasBudgetOverrunNotification.Location = new System.Drawing.Point(339, 263);
            this.checkBox_defaultContractHasBudgetOverrunNotification.Name = "checkBox_defaultContractHasBudgetOverrunNotification";
            this.checkBox_defaultContractHasBudgetOverrunNotification.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultContractHasBudgetOverrunNotification.TabIndex = 19;
            this.checkBox_defaultContractHasBudgetOverrunNotification.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultContractHasBudgetOverrunNotification, "Set default values for all rows of a particular column field");
            this.checkBox_defaultContractHasBudgetOverrunNotification.UseVisualStyleBackColor = true;
            this.checkBox_defaultContractHasBudgetOverrunNotification.CheckedChanged += new System.EventHandler(this.checkBox_defaultContractHasBudgetOverrunNotification_CheckedChanged);
            // 
            // label_contractHasBudgetOverrunNotification
            // 
            this.label_contractHasBudgetOverrunNotification.AutoSize = true;
            this.label_contractHasBudgetOverrunNotification.Location = new System.Drawing.Point(10, 264);
            this.label_contractHasBudgetOverrunNotification.Name = "label_contractHasBudgetOverrunNotification";
            this.label_contractHasBudgetOverrunNotification.Size = new System.Drawing.Size(180, 17);
            this.label_contractHasBudgetOverrunNotification.TabIndex = 17;
            this.label_contractHasBudgetOverrunNotification.Text = "Budget Overrun Notification";
            // 
            // comboBox_contractHasBudgetOverrunNotification
            // 
            this.comboBox_contractHasBudgetOverrunNotification.FormattingEnabled = true;
            this.comboBox_contractHasBudgetOverrunNotification.Location = new System.Drawing.Point(194, 261);
            this.comboBox_contractHasBudgetOverrunNotification.Name = "comboBox_contractHasBudgetOverrunNotification";
            this.comboBox_contractHasBudgetOverrunNotification.Size = new System.Drawing.Size(139, 25);
            this.comboBox_contractHasBudgetOverrunNotification.TabIndex = 18;
            this.comboBox_contractHasBudgetOverrunNotification.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractHasBudgetOverrunNotification_SelectedIndexChanged);
            // 
            // checkBox_defaultContractIsDefaultExpenses
            // 
            this.checkBox_defaultContractIsDefaultExpenses.AutoSize = true;
            this.checkBox_defaultContractIsDefaultExpenses.Location = new System.Drawing.Point(339, 232);
            this.checkBox_defaultContractIsDefaultExpenses.Name = "checkBox_defaultContractIsDefaultExpenses";
            this.checkBox_defaultContractIsDefaultExpenses.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultContractIsDefaultExpenses.TabIndex = 16;
            this.checkBox_defaultContractIsDefaultExpenses.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultContractIsDefaultExpenses, "Set default values for all rows of a particular column field");
            this.checkBox_defaultContractIsDefaultExpenses.UseVisualStyleBackColor = true;
            this.checkBox_defaultContractIsDefaultExpenses.CheckedChanged += new System.EventHandler(this.checkBox_defaultContractIsDefaultExpenses_CheckedChanged);
            // 
            // label_contractIsDefaultExpenses
            // 
            this.label_contractIsDefaultExpenses.AutoSize = true;
            this.label_contractIsDefaultExpenses.Location = new System.Drawing.Point(10, 233);
            this.label_contractIsDefaultExpenses.Name = "label_contractIsDefaultExpenses";
            this.label_contractIsDefaultExpenses.Size = new System.Drawing.Size(125, 17);
            this.label_contractIsDefaultExpenses.TabIndex = 14;
            this.label_contractIsDefaultExpenses.Text = "Is Default Expenses";
            // 
            // comboBox_contractIsDefaultExpenses
            // 
            this.comboBox_contractIsDefaultExpenses.FormattingEnabled = true;
            this.comboBox_contractIsDefaultExpenses.Location = new System.Drawing.Point(194, 230);
            this.comboBox_contractIsDefaultExpenses.Name = "comboBox_contractIsDefaultExpenses";
            this.comboBox_contractIsDefaultExpenses.Size = new System.Drawing.Size(139, 25);
            this.comboBox_contractIsDefaultExpenses.TabIndex = 15;
            this.comboBox_contractIsDefaultExpenses.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractIsDefaultExpenses_SelectedIndexChanged);
            // 
            // checkBox_defaultContractIsMileageBillable
            // 
            this.checkBox_defaultContractIsMileageBillable.AutoSize = true;
            this.checkBox_defaultContractIsMileageBillable.Location = new System.Drawing.Point(339, 198);
            this.checkBox_defaultContractIsMileageBillable.Name = "checkBox_defaultContractIsMileageBillable";
            this.checkBox_defaultContractIsMileageBillable.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultContractIsMileageBillable.TabIndex = 13;
            this.checkBox_defaultContractIsMileageBillable.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultContractIsMileageBillable, "Set default values for all rows of a particular column field");
            this.checkBox_defaultContractIsMileageBillable.UseVisualStyleBackColor = true;
            this.checkBox_defaultContractIsMileageBillable.CheckedChanged += new System.EventHandler(this.checkBox_defaultContractIsMileageBillable_CheckedChanged);
            // 
            // label_contractIsMileageBillable
            // 
            this.label_contractIsMileageBillable.AutoSize = true;
            this.label_contractIsMileageBillable.Location = new System.Drawing.Point(10, 199);
            this.label_contractIsMileageBillable.Name = "label_contractIsMileageBillable";
            this.label_contractIsMileageBillable.Size = new System.Drawing.Size(115, 17);
            this.label_contractIsMileageBillable.TabIndex = 11;
            this.label_contractIsMileageBillable.Text = "Is Mileage Billable";
            // 
            // comboBox_contractIsMileageBillable
            // 
            this.comboBox_contractIsMileageBillable.FormattingEnabled = true;
            this.comboBox_contractIsMileageBillable.Location = new System.Drawing.Point(194, 196);
            this.comboBox_contractIsMileageBillable.Name = "comboBox_contractIsMileageBillable";
            this.comboBox_contractIsMileageBillable.Size = new System.Drawing.Size(139, 25);
            this.comboBox_contractIsMileageBillable.TabIndex = 12;
            this.comboBox_contractIsMileageBillable.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractIsMileageBillable_SelectedIndexChanged);
            // 
            // checkBox_defaultContractCompletionNotificationPercentage
            // 
            this.checkBox_defaultContractCompletionNotificationPercentage.AutoSize = true;
            this.checkBox_defaultContractCompletionNotificationPercentage.Location = new System.Drawing.Point(339, 164);
            this.checkBox_defaultContractCompletionNotificationPercentage.Name = "checkBox_defaultContractCompletionNotificationPercentage";
            this.checkBox_defaultContractCompletionNotificationPercentage.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultContractCompletionNotificationPercentage.TabIndex = 10;
            this.checkBox_defaultContractCompletionNotificationPercentage.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultContractCompletionNotificationPercentage, "Set default values for all rows of a particular column field");
            this.checkBox_defaultContractCompletionNotificationPercentage.UseVisualStyleBackColor = true;
            this.checkBox_defaultContractCompletionNotificationPercentage.CheckedChanged += new System.EventHandler(this.checkBox_defaultContractCompletionNotificationPercentage_CheckedChanged);
            // 
            // label_contractCompletionNotificationPercentage
            // 
            this.label_contractCompletionNotificationPercentage.AutoSize = true;
            this.label_contractCompletionNotificationPercentage.Location = new System.Drawing.Point(10, 165);
            this.label_contractCompletionNotificationPercentage.Name = "label_contractCompletionNotificationPercentage";
            this.label_contractCompletionNotificationPercentage.Size = new System.Drawing.Size(167, 17);
            this.label_contractCompletionNotificationPercentage.TabIndex = 8;
            this.label_contractCompletionNotificationPercentage.Text = "Completion Notification %";
            // 
            // comboBox_contractCompletionNotificationPercentage
            // 
            this.comboBox_contractCompletionNotificationPercentage.FormattingEnabled = true;
            this.comboBox_contractCompletionNotificationPercentage.Location = new System.Drawing.Point(194, 162);
            this.comboBox_contractCompletionNotificationPercentage.Name = "comboBox_contractCompletionNotificationPercentage";
            this.comboBox_contractCompletionNotificationPercentage.Size = new System.Drawing.Size(139, 25);
            this.comboBox_contractCompletionNotificationPercentage.TabIndex = 9;
            this.comboBox_contractCompletionNotificationPercentage.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractCompletionNotificationPercentage_SelectedIndexChanged);
            // 
            // comboBox_contractBudgetExpensesAmount
            // 
            this.comboBox_contractBudgetExpensesAmount.FormattingEnabled = true;
            this.comboBox_contractBudgetExpensesAmount.Location = new System.Drawing.Point(194, 7);
            this.comboBox_contractBudgetExpensesAmount.Name = "comboBox_contractBudgetExpensesAmount";
            this.comboBox_contractBudgetExpensesAmount.Size = new System.Drawing.Size(139, 25);
            this.comboBox_contractBudgetExpensesAmount.TabIndex = 7;
            this.comboBox_contractBudgetExpensesAmount.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractBudgetExpensesAmount_SelectedIndexChanged);
            // 
            // label_contractBudgetExpensesAmount
            // 
            this.label_contractBudgetExpensesAmount.AutoSize = true;
            this.label_contractBudgetExpensesAmount.Location = new System.Drawing.Point(10, 10);
            this.label_contractBudgetExpensesAmount.Name = "label_contractBudgetExpensesAmount";
            this.label_contractBudgetExpensesAmount.Size = new System.Drawing.Size(166, 17);
            this.label_contractBudgetExpensesAmount.TabIndex = 6;
            this.label_contractBudgetExpensesAmount.Text = "Budget Expenses Amount";
            // 
            // checkBox_defaultContractHasCompletionNotification
            // 
            this.checkBox_defaultContractHasCompletionNotification.AutoSize = true;
            this.checkBox_defaultContractHasCompletionNotification.Location = new System.Drawing.Point(339, 133);
            this.checkBox_defaultContractHasCompletionNotification.Name = "checkBox_defaultContractHasCompletionNotification";
            this.checkBox_defaultContractHasCompletionNotification.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultContractHasCompletionNotification.TabIndex = 5;
            this.checkBox_defaultContractHasCompletionNotification.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultContractHasCompletionNotification, "Set default values for all rows of a particular column field");
            this.checkBox_defaultContractHasCompletionNotification.UseVisualStyleBackColor = true;
            this.checkBox_defaultContractHasCompletionNotification.CheckedChanged += new System.EventHandler(this.checkBox_defaultContractHasCompletionNotification_CheckedChanged);
            // 
            // label_contractHasCompletionNotification
            // 
            this.label_contractHasCompletionNotification.AutoSize = true;
            this.label_contractHasCompletionNotification.Location = new System.Drawing.Point(10, 134);
            this.label_contractHasCompletionNotification.Name = "label_contractHasCompletionNotification";
            this.label_contractHasCompletionNotification.Size = new System.Drawing.Size(179, 17);
            this.label_contractHasCompletionNotification.TabIndex = 1;
            this.label_contractHasCompletionNotification.Text = "Has Completion Notification";
            // 
            // comboBox_contractBudgetTravelAmount
            // 
            this.comboBox_contractBudgetTravelAmount.FormattingEnabled = true;
            this.comboBox_contractBudgetTravelAmount.Location = new System.Drawing.Point(194, 38);
            this.comboBox_contractBudgetTravelAmount.Name = "comboBox_contractBudgetTravelAmount";
            this.comboBox_contractBudgetTravelAmount.Size = new System.Drawing.Size(139, 25);
            this.comboBox_contractBudgetTravelAmount.TabIndex = 3;
            this.comboBox_contractBudgetTravelAmount.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractBudgetTravelAmount_SelectedIndexChanged);
            // 
            // comboBox_contractHasCompletionNotification
            // 
            this.comboBox_contractHasCompletionNotification.FormattingEnabled = true;
            this.comboBox_contractHasCompletionNotification.Location = new System.Drawing.Point(194, 131);
            this.comboBox_contractHasCompletionNotification.Name = "comboBox_contractHasCompletionNotification";
            this.comboBox_contractHasCompletionNotification.Size = new System.Drawing.Size(139, 25);
            this.comboBox_contractHasCompletionNotification.TabIndex = 3;
            this.comboBox_contractHasCompletionNotification.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractHasCompletionNotification_SelectedIndexChanged);
            // 
            // label_contractBudgetTravelAmount
            // 
            this.label_contractBudgetTravelAmount.AutoSize = true;
            this.label_contractBudgetTravelAmount.Location = new System.Drawing.Point(10, 41);
            this.label_contractBudgetTravelAmount.Name = "label_contractBudgetTravelAmount";
            this.label_contractBudgetTravelAmount.Size = new System.Drawing.Size(145, 17);
            this.label_contractBudgetTravelAmount.TabIndex = 1;
            this.label_contractBudgetTravelAmount.Text = "Budget Travel Amount";
            // 
            // comboBox_contractBudgetWorkAmount
            // 
            this.comboBox_contractBudgetWorkAmount.FormattingEnabled = true;
            this.comboBox_contractBudgetWorkAmount.Location = new System.Drawing.Point(194, 69);
            this.comboBox_contractBudgetWorkAmount.Name = "comboBox_contractBudgetWorkAmount";
            this.comboBox_contractBudgetWorkAmount.Size = new System.Drawing.Size(139, 25);
            this.comboBox_contractBudgetWorkAmount.TabIndex = 3;
            this.comboBox_contractBudgetWorkAmount.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractBudgetWorkAmount_SelectedIndexChanged);
            // 
            // label_contractBudgetWorkAmount
            // 
            this.label_contractBudgetWorkAmount.AutoSize = true;
            this.label_contractBudgetWorkAmount.Location = new System.Drawing.Point(10, 72);
            this.label_contractBudgetWorkAmount.Name = "label_contractBudgetWorkAmount";
            this.label_contractBudgetWorkAmount.Size = new System.Drawing.Size(143, 17);
            this.label_contractBudgetWorkAmount.TabIndex = 1;
            this.label_contractBudgetWorkAmount.Text = "Budget Work Amount";
            // 
            // label_contractBudgetWorkHour
            // 
            this.label_contractBudgetWorkHour.AutoSize = true;
            this.label_contractBudgetWorkHour.Location = new System.Drawing.Point(10, 103);
            this.label_contractBudgetWorkHour.Name = "label_contractBudgetWorkHour";
            this.label_contractBudgetWorkHour.Size = new System.Drawing.Size(124, 17);
            this.label_contractBudgetWorkHour.TabIndex = 1;
            this.label_contractBudgetWorkHour.Text = "Budget Work Hour";
            // 
            // comboBox_contractBudgetWorkHour
            // 
            this.comboBox_contractBudgetWorkHour.FormattingEnabled = true;
            this.comboBox_contractBudgetWorkHour.Location = new System.Drawing.Point(194, 100);
            this.comboBox_contractBudgetWorkHour.Name = "comboBox_contractBudgetWorkHour";
            this.comboBox_contractBudgetWorkHour.Size = new System.Drawing.Size(139, 25);
            this.comboBox_contractBudgetWorkHour.TabIndex = 3;
            this.comboBox_contractBudgetWorkHour.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractBudgetWorkHour_SelectedIndexChanged);
            // 
            // label_delimiter
            // 
            this.label_delimiter.AutoSize = true;
            this.label_delimiter.Location = new System.Drawing.Point(10, 75);
            this.label_delimiter.Name = "label_delimiter";
            this.label_delimiter.Size = new System.Drawing.Size(62, 17);
            this.label_delimiter.TabIndex = 1;
            this.label_delimiter.Text = "Delimiter";
            // 
            // comboBox_delimiter
            // 
            this.comboBox_delimiter.FormattingEnabled = true;
            this.comboBox_delimiter.Location = new System.Drawing.Point(82, 72);
            this.comboBox_delimiter.Name = "comboBox_delimiter";
            this.comboBox_delimiter.Size = new System.Drawing.Size(56, 25);
            this.comboBox_delimiter.TabIndex = 6;
            // 
            // groupBox_contractMandatoryFields
            // 
            this.groupBox_contractMandatoryFields.Controls.Add(this.checkBox_defaultContractModel);
            this.groupBox_contractMandatoryFields.Controls.Add(this.label_contractModel);
            this.groupBox_contractMandatoryFields.Controls.Add(this.comboBox_ContractModel);
            this.groupBox_contractMandatoryFields.Controls.Add(this.label_projectNo);
            this.groupBox_contractMandatoryFields.Controls.Add(this.checkBox_defaultContractStatus);
            this.groupBox_contractMandatoryFields.Controls.Add(this.comboBox_projectNo);
            this.groupBox_contractMandatoryFields.Controls.Add(this.label_contractOwnerInitials);
            this.groupBox_contractMandatoryFields.Controls.Add(this.comboBox_contractOwnerInitials);
            this.groupBox_contractMandatoryFields.Controls.Add(this.label_contractStatus);
            this.groupBox_contractMandatoryFields.Controls.Add(this.comboBox_contractStatus);
            this.groupBox_contractMandatoryFields.Controls.Add(this.label_projectName);
            this.groupBox_contractMandatoryFields.Controls.Add(this.comboBox_contractName);
            this.groupBox_contractMandatoryFields.Location = new System.Drawing.Point(166, 62);
            this.groupBox_contractMandatoryFields.Name = "groupBox_contractMandatoryFields";
            this.groupBox_contractMandatoryFields.Size = new System.Drawing.Size(375, 245);
            this.groupBox_contractMandatoryFields.TabIndex = 5;
            this.groupBox_contractMandatoryFields.TabStop = false;
            this.groupBox_contractMandatoryFields.Text = "Mandatory";
            // 
            // label_projectNo
            // 
            this.label_projectNo.AutoSize = true;
            this.label_projectNo.Location = new System.Drawing.Point(5, 58);
            this.label_projectNo.Name = "label_projectNo";
            this.label_projectNo.Size = new System.Drawing.Size(72, 17);
            this.label_projectNo.TabIndex = 1;
            this.label_projectNo.Text = "Project No";
            // 
            // checkBox_defaultContractStatus
            // 
            this.checkBox_defaultContractStatus.AutoSize = true;
            this.checkBox_defaultContractStatus.Location = new System.Drawing.Point(302, 88);
            this.checkBox_defaultContractStatus.Name = "checkBox_defaultContractStatus";
            this.checkBox_defaultContractStatus.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultContractStatus.TabIndex = 5;
            this.checkBox_defaultContractStatus.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultContractStatus, "Set default values for all rows of a particular column field");
            this.checkBox_defaultContractStatus.UseVisualStyleBackColor = true;
            this.checkBox_defaultContractStatus.CheckedChanged += new System.EventHandler(this.checkBox_defaultContractStatus_CheckedChanged);
            // 
            // comboBox_projectNo
            // 
            this.comboBox_projectNo.FormattingEnabled = true;
            this.comboBox_projectNo.Location = new System.Drawing.Point(157, 55);
            this.comboBox_projectNo.Name = "comboBox_projectNo";
            this.comboBox_projectNo.Size = new System.Drawing.Size(139, 25);
            this.comboBox_projectNo.TabIndex = 3;
            this.comboBox_projectNo.SelectedIndexChanged += new System.EventHandler(this.comboBox_projectNo_SelectedIndexChanged);
            // 
            // label_contractOwnerInitials
            // 
            this.label_contractOwnerInitials.AutoSize = true;
            this.label_contractOwnerInitials.Location = new System.Drawing.Point(6, 120);
            this.label_contractOwnerInitials.Name = "label_contractOwnerInitials";
            this.label_contractOwnerInitials.Size = new System.Drawing.Size(147, 17);
            this.label_contractOwnerInitials.TabIndex = 1;
            this.label_contractOwnerInitials.Text = "Contract Owner Initials";
            // 
            // comboBox_contractOwnerInitials
            // 
            this.comboBox_contractOwnerInitials.FormattingEnabled = true;
            this.comboBox_contractOwnerInitials.Location = new System.Drawing.Point(157, 117);
            this.comboBox_contractOwnerInitials.Name = "comboBox_contractOwnerInitials";
            this.comboBox_contractOwnerInitials.Size = new System.Drawing.Size(139, 25);
            this.comboBox_contractOwnerInitials.TabIndex = 3;
            this.comboBox_contractOwnerInitials.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractOwnerInitials_SelectedIndexChanged);
            // 
            // label_contractStatus
            // 
            this.label_contractStatus.AutoSize = true;
            this.label_contractStatus.Location = new System.Drawing.Point(6, 89);
            this.label_contractStatus.Name = "label_contractStatus";
            this.label_contractStatus.Size = new System.Drawing.Size(102, 17);
            this.label_contractStatus.TabIndex = 1;
            this.label_contractStatus.Text = "Contract Status";
            // 
            // comboBox_contractStatus
            // 
            this.comboBox_contractStatus.FormattingEnabled = true;
            this.comboBox_contractStatus.Location = new System.Drawing.Point(157, 86);
            this.comboBox_contractStatus.Name = "comboBox_contractStatus";
            this.comboBox_contractStatus.Size = new System.Drawing.Size(139, 25);
            this.comboBox_contractStatus.TabIndex = 3;
            this.comboBox_contractStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractStatus_SelectedIndexChanged);
            // 
            // label_projectName
            // 
            this.label_projectName.AutoSize = true;
            this.label_projectName.Location = new System.Drawing.Point(6, 27);
            this.label_projectName.Name = "label_projectName";
            this.label_projectName.Size = new System.Drawing.Size(100, 17);
            this.label_projectName.TabIndex = 1;
            this.label_projectName.Text = "Contract Name";
            // 
            // comboBox_contractName
            // 
            this.comboBox_contractName.FormattingEnabled = true;
            this.comboBox_contractName.Location = new System.Drawing.Point(157, 24);
            this.comboBox_contractName.Name = "comboBox_contractName";
            this.comboBox_contractName.Size = new System.Drawing.Size(139, 25);
            this.comboBox_contractName.TabIndex = 3;
            this.comboBox_contractName.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractName_SelectedIndexChanged);
            // 
            // label_contractSetup
            // 
            this.label_contractSetup.AutoSize = true;
            this.label_contractSetup.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_contractSetup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_contractSetup.Location = new System.Drawing.Point(7, 16);
            this.label_contractSetup.Name = "label_contractSetup";
            this.label_contractSetup.Size = new System.Drawing.Size(249, 32);
            this.label_contractSetup.TabIndex = 0;
            this.label_contractSetup.Text = "Contract Data Import";
            // 
            // button_contractSelectFile
            // 
            this.button_contractSelectFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(43)))), ((int)(((byte)(141)))));
            this.button_contractSelectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_contractSelectFile.FlatAppearance.BorderSize = 0;
            this.button_contractSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_contractSelectFile.ForeColor = System.Drawing.Color.White;
            this.button_contractSelectFile.Location = new System.Drawing.Point(13, 111);
            this.button_contractSelectFile.Name = "button_contractSelectFile";
            this.button_contractSelectFile.Size = new System.Drawing.Size(80, 29);
            this.button_contractSelectFile.TabIndex = 4;
            this.button_contractSelectFile.Text = "Select File";
            this.defaultToolTip.SetToolTip(this.button_contractSelectFile, "Select input CSV file");
            this.button_contractSelectFile.UseVisualStyleBackColor = false;
            this.button_contractSelectFile.Click += new System.EventHandler(this.button_select_contract_file_Click);
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
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(271, 286);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(139, 23);
            this.comboBox5.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Is Default Expenses";
            // 
            // label_contractModel
            // 
            this.label_contractModel.AutoSize = true;
            this.label_contractModel.Location = new System.Drawing.Point(6, 151);
            this.label_contractModel.Name = "label_contractModel";
            this.label_contractModel.Size = new System.Drawing.Size(102, 17);
            this.label_contractModel.TabIndex = 6;
            this.label_contractModel.Text = "Contract Model";
            // 
            // comboBox_ContractModel
            // 
            this.comboBox_ContractModel.FormattingEnabled = true;
            this.comboBox_ContractModel.Location = new System.Drawing.Point(157, 148);
            this.comboBox_ContractModel.Name = "comboBox_ContractModel";
            this.comboBox_ContractModel.Size = new System.Drawing.Size(139, 25);
            this.comboBox_ContractModel.TabIndex = 7;
            this.comboBox_ContractModel.SelectedIndexChanged += new System.EventHandler(this.comboBox_ContractModel_SelectedIndexChanged);
            // 
            // checkBox_defaultContractModel
            // 
            this.checkBox_defaultContractModel.AutoSize = true;
            this.checkBox_defaultContractModel.Location = new System.Drawing.Point(302, 150);
            this.checkBox_defaultContractModel.Name = "checkBox_defaultContractModel";
            this.checkBox_defaultContractModel.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultContractModel.TabIndex = 8;
            this.checkBox_defaultContractModel.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultContractModel, "Set default values for all rows of a particular column field");
            this.checkBox_defaultContractModel.UseVisualStyleBackColor = true;
            this.checkBox_defaultContractModel.CheckedChanged += new System.EventHandler(this.checkBox_defaultContractModel_CheckedChanged);
            // 
            // UserControl_ContractImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_contractFieldMapping);
            this.Controls.Add(this.panel_contractButtons);
            this.Controls.Add(this.panel_projectMessage);
            this.Controls.Add(this.panel_projectDataTable);
            this.Name = "UserControl_ContractImport";
            this.Size = new System.Drawing.Size(1006, 942);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.panel_projectDataTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_contract)).EndInit();
            this.panel_projectMessage.ResumeLayout(false);
            this.panel_projectMessage.PerformLayout();
            this.panel_contractButtons.ResumeLayout(false);
            this.panel_contractFieldMapping.ResumeLayout(false);
            this.panel_contractFieldMapping.PerformLayout();
            this.flowLayoutPanel_nonMandatoryFields.ResumeLayout(false);
            this.panel_NonMandatoryButton.ResumeLayout(false);
            this.panel_NonMandatoryButton.PerformLayout();
            this.panel_NonMandatoryFields.ResumeLayout(false);
            this.panel_NonMandatoryFields.PerformLayout();
            this.groupBox_contractMandatoryFields.ResumeLayout(false);
            this.groupBox_contractMandatoryFields.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private void AddRowNumberToDataTable()
        {
            this.dataGridView_contract.DataBindingComplete += (o, e) =>
            {
                foreach (System.Windows.Forms.DataGridViewRow row in dataGridView_contract.Rows)
                {
                    row.HeaderCell.Value = (row.Index + 1).ToString();

                }
            };
            this.dataGridView_contract.RowHeadersWidth = 65;
        }


        private System.ComponentModel.BackgroundWorker WorkerFetcher;
        private System.Windows.Forms.Panel panel_projectDataTable;
        private System.Windows.Forms.DataGridView dataGridView_contract;
        private System.Windows.Forms.Panel panel_projectMessage;
        private System.Windows.Forms.Panel panel_contractButtons;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_import;
        private System.Windows.Forms.Button button_validate;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Panel panel_contractFieldMapping;
        private System.Windows.Forms.GroupBox groupBox_contractMandatoryFields;
        private System.Windows.Forms.ComboBox comboBox_contractName;
        private System.Windows.Forms.Label label_projectName;
        private System.Windows.Forms.Label label_contractSetup;
        private System.Windows.Forms.Button button_contractSelectFile;
        private System.Windows.Forms.TextBox textBox_contractImportMessages;
        private System.Windows.Forms.Label label_contractStatus;
        private System.Windows.Forms.ComboBox comboBox_contractStatus;
        private System.Windows.Forms.Label label_contractOwnerInitials;
        private System.Windows.Forms.ComboBox comboBox_contractOwnerInitials;
        private System.Windows.Forms.Label label_delimiter;
        private System.Windows.Forms.ComboBox comboBox_delimiter;
        private System.Windows.Forms.Label label_contractHasCompletionNotification;
        private System.Windows.Forms.ComboBox comboBox_contractHasCompletionNotification;
        private System.Windows.Forms.Label label_contractBudgetWorkHour;
        private System.Windows.Forms.ComboBox comboBox_contractBudgetWorkHour;
        private System.Windows.Forms.Label label_contractBudgetWorkAmount;
        private System.Windows.Forms.ComboBox comboBox_contractBudgetWorkAmount;
        private System.Windows.Forms.Label label_contractBudgetTravelAmount;
        private System.Windows.Forms.ComboBox comboBox_contractBudgetTravelAmount;
        private System.Windows.Forms.Label label_projectNo;
        private System.Windows.Forms.ComboBox comboBox_projectNo;
        private System.Windows.Forms.CheckBox checkBox_defaultContractHasCompletionNotification;
        private System.Windows.Forms.CheckBox checkBox_defaultContractStatus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_nonMandatoryFields;
        private System.Windows.Forms.Panel panel_NonMandatoryButton;
        private System.Windows.Forms.Panel panel_NonMandatoryFields;
        private System.Windows.Forms.Label label_nonMandatoryFields;
        private System.Windows.Forms.Button button_expandNonMandatory;
        private System.Windows.Forms.Timer tmrExpand;
        private System.Windows.Forms.ToolTip defaultToolTip;
        private System.Windows.Forms.ComboBox comboBox_contractBudgetExpensesAmount;
        private System.Windows.Forms.Label label_contractBudgetExpensesAmount;
        private System.Windows.Forms.CheckBox checkBox_defaultContractIsMileageBillable;
        private System.Windows.Forms.Label label_contractIsMileageBillable;
        private System.Windows.Forms.ComboBox comboBox_contractIsMileageBillable;
        private System.Windows.Forms.CheckBox checkBox_defaultContractCompletionNotificationPercentage;
        private System.Windows.Forms.Label label_contractCompletionNotificationPercentage;
        private System.Windows.Forms.ComboBox comboBox_contractCompletionNotificationPercentage;
        private System.Windows.Forms.CheckBox checkBox_defaultContractIsDefaultExpenses;
        private System.Windows.Forms.Label label_contractIsDefaultExpenses;
        private System.Windows.Forms.ComboBox comboBox_contractIsDefaultExpenses;
        private System.Windows.Forms.CheckBox checkBox_defaultContractHasBudgetOverrunNotification;
        private System.Windows.Forms.Label label_contractHasBudgetOverrunNotification;
        private System.Windows.Forms.ComboBox comboBox_contractHasBudgetOverrunNotification;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_defaultContractIsTravelLinked;
        private System.Windows.Forms.Label label_contractIsTravelLinked;
        private System.Windows.Forms.ComboBox comboBox_contractIsTravelLinked;
        private System.Windows.Forms.CheckBox checkBox_defaultContractIsExpensesLinked;
        private System.Windows.Forms.Label label_contractIsExpensesLinked;
        private System.Windows.Forms.ComboBox comboBox_contractIsExpensesLinked;
        private System.Windows.Forms.Label label_contractRevenueTravelAmount;
        private System.Windows.Forms.ComboBox comboBox_contractRevenueTravelAmount;
        private System.Windows.Forms.Label label_contractRevenueExprAmount;
        private System.Windows.Forms.ComboBox comboBox_contractRevenueExprAmount;
        private System.Windows.Forms.Label label_contractPaymentPlanAmount;
        private System.Windows.Forms.ComboBox comboBox_contractPaymentPlanAmount;
        private System.Windows.Forms.Label label_contractTargetHourlyRate;
        private System.Windows.Forms.ComboBox comboBox_contractTargetHourlyRate;
        private System.Windows.Forms.Label label_contractModel;
        private System.Windows.Forms.ComboBox comboBox_ContractModel;
        private System.Windows.Forms.CheckBox checkBox_defaultContractModel;
    }
}
