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
            components = new System.ComponentModel.Container();
            WorkerFetcher = new System.ComponentModel.BackgroundWorker();
            panel_projectDataTable = new System.Windows.Forms.Panel();
            dataGridView_contract = new System.Windows.Forms.DataGridView();
            panel_projectMessage = new System.Windows.Forms.Panel();
            textBox_contractImportMessages = new System.Windows.Forms.TextBox();
            panel_contractButtons = new System.Windows.Forms.Panel();
            button_clear = new System.Windows.Forms.Button();
            button_import = new System.Windows.Forms.Button();
            button_validate = new System.Windows.Forms.Button();
            button_stop = new System.Windows.Forms.Button();
            panel_contractFieldMapping = new System.Windows.Forms.Panel();
            textBox5 = new System.Windows.Forms.TextBox();
            textBox6 = new System.Windows.Forms.TextBox();
            textBox7 = new System.Windows.Forms.TextBox();
            textBox8 = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox1 = new System.Windows.Forms.TextBox();
            flowLayoutPanel_nonMandatoryFields = new System.Windows.Forms.FlowLayoutPanel();
            panel_NonMandatoryButton = new System.Windows.Forms.Panel();
            label_nonMandatoryFields = new System.Windows.Forms.Label();
            button_expandNonMandatory = new System.Windows.Forms.Button();
            panel_NonMandatoryFields = new System.Windows.Forms.Panel();
            checkBox_defaultContractIsFixedHourlyRate = new System.Windows.Forms.CheckBox();
            label_contractIsFixedHourlyRate = new System.Windows.Forms.Label();
            comboBox_contractIsFixedHourlyRate = new System.Windows.Forms.ComboBox();
            label_contractHourlyRateName = new System.Windows.Forms.Label();
            comboBox_contractHourlyRateName = new System.Windows.Forms.ComboBox();
            checkBox_defaultContractIsTravelLinked = new System.Windows.Forms.CheckBox();
            checkBox_defaultContractIsExpensesLinked = new System.Windows.Forms.CheckBox();
            label_contractIsExpensesLinked = new System.Windows.Forms.Label();
            label_contractIsTravelLinked = new System.Windows.Forms.Label();
            comboBox_contractIsTravelLinked = new System.Windows.Forms.ComboBox();
            comboBox_contractIsExpensesLinked = new System.Windows.Forms.ComboBox();
            label_contractRevenueTravelAmount = new System.Windows.Forms.Label();
            comboBox_contractRevenueTravelAmount = new System.Windows.Forms.ComboBox();
            label_contractRevenueExpensesAmount = new System.Windows.Forms.Label();
            comboBox_contractRevenueExpensesAmount = new System.Windows.Forms.ComboBox();
            label_contractPaymentPlanAmount = new System.Windows.Forms.Label();
            comboBox_contractPaymentPlanAmount = new System.Windows.Forms.ComboBox();
            label_contractTargetHourlyRate = new System.Windows.Forms.Label();
            comboBox_contractTargetHourlyRate = new System.Windows.Forms.ComboBox();
            checkBox_defaultContractHasBudgetOverrunNotification = new System.Windows.Forms.CheckBox();
            label_contractHasBudgetOverrunNotification = new System.Windows.Forms.Label();
            comboBox_contractHasBudgetOverrunNotification = new System.Windows.Forms.ComboBox();
            checkBox_defaultContractIsDefaultExpenses = new System.Windows.Forms.CheckBox();
            label_contractIsDefaultExpenses = new System.Windows.Forms.Label();
            comboBox_contractIsDefaultExpenses = new System.Windows.Forms.ComboBox();
            checkBox_defaultContractIsMileageBillable = new System.Windows.Forms.CheckBox();
            label_contractIsMileageBillable = new System.Windows.Forms.Label();
            comboBox_contractIsMileageBillable = new System.Windows.Forms.ComboBox();
            checkBox_defaultContractCompletionNotificationPercentage = new System.Windows.Forms.CheckBox();
            label_contractCompletionNotificationPercentage = new System.Windows.Forms.Label();
            comboBox_contractCompletionNotificationPercentage = new System.Windows.Forms.ComboBox();
            comboBox_contractBudgetExpensesAmount = new System.Windows.Forms.ComboBox();
            label_contractBudgetExpensesAmount = new System.Windows.Forms.Label();
            checkBox_defaultContractHasCompletionNotification = new System.Windows.Forms.CheckBox();
            label_contractHasCompletionNotification = new System.Windows.Forms.Label();
            comboBox_contractBudgetTravelAmount = new System.Windows.Forms.ComboBox();
            comboBox_contractHasCompletionNotification = new System.Windows.Forms.ComboBox();
            label_contractBudgetTravelAmount = new System.Windows.Forms.Label();
            comboBox_contractBudgetWorkAmount = new System.Windows.Forms.ComboBox();
            label_contractBudgetWorkAmount = new System.Windows.Forms.Label();
            label_contractBudgetWorkHour = new System.Windows.Forms.Label();
            comboBox_contractBudgetWorkHour = new System.Windows.Forms.ComboBox();
            label_delimiter = new System.Windows.Forms.Label();
            comboBox_delimiter = new System.Windows.Forms.ComboBox();
            groupBox_contractMandatoryFields = new System.Windows.Forms.GroupBox();
            checkBox_defaultContractModel = new System.Windows.Forms.CheckBox();
            label_contractModel = new System.Windows.Forms.Label();
            comboBox_ContractModel = new System.Windows.Forms.ComboBox();
            label_projectNo = new System.Windows.Forms.Label();
            checkBox_defaultContractStatus = new System.Windows.Forms.CheckBox();
            comboBox_projectNo = new System.Windows.Forms.ComboBox();
            label_contractOwnerInitials = new System.Windows.Forms.Label();
            comboBox_contractOwnerInitials = new System.Windows.Forms.ComboBox();
            label_contractStatus = new System.Windows.Forms.Label();
            comboBox_contractStatus = new System.Windows.Forms.ComboBox();
            label_projectName = new System.Windows.Forms.Label();
            comboBox_contractName = new System.Windows.Forms.ComboBox();
            label_contractSetup = new System.Windows.Forms.Label();
            button_contractSelectFile = new System.Windows.Forms.Button();
            tmrExpand = new System.Windows.Forms.Timer(components);
            defaultToolTip = new System.Windows.Forms.ToolTip(components);
            comboBox5 = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            panel_projectDataTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_contract).BeginInit();
            panel_projectMessage.SuspendLayout();
            panel_contractButtons.SuspendLayout();
            panel_contractFieldMapping.SuspendLayout();
            flowLayoutPanel_nonMandatoryFields.SuspendLayout();
            panel_NonMandatoryButton.SuspendLayout();
            panel_NonMandatoryFields.SuspendLayout();
            groupBox_contractMandatoryFields.SuspendLayout();
            SuspendLayout();
            // 
            // WorkerFetcher
            // 
            WorkerFetcher.WorkerReportsProgress = true;
            WorkerFetcher.WorkerSupportsCancellation = true;
            WorkerFetcher.DoWork += WorkerFetcherDoWork;
            // 
            // panel_projectDataTable
            // 
            panel_projectDataTable.Controls.Add(dataGridView_contract);
            panel_projectDataTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_projectDataTable.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel_projectDataTable.Location = new System.Drawing.Point(0, 462);
            panel_projectDataTable.Name = "panel_projectDataTable";
            panel_projectDataTable.Size = new System.Drawing.Size(1006, 180);
            panel_projectDataTable.TabIndex = 6;
            // 
            // dataGridView_contract
            // 
            dataGridView_contract.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridView_contract.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridView_contract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_contract.Dock = System.Windows.Forms.DockStyle.Bottom;
            dataGridView_contract.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridView_contract.Location = new System.Drawing.Point(0, 0);
            dataGridView_contract.Name = "dataGridView_contract";
            dataGridView_contract.RowHeadersWidth = 62;
            dataGridView_contract.Size = new System.Drawing.Size(1006, 180);
            dataGridView_contract.TabIndex = 0;
            // 
            // panel_projectMessage
            // 
            panel_projectMessage.Controls.Add(textBox_contractImportMessages);
            panel_projectMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_projectMessage.Location = new System.Drawing.Point(0, 278);
            panel_projectMessage.Name = "panel_projectMessage";
            panel_projectMessage.Size = new System.Drawing.Size(1006, 184);
            panel_projectMessage.TabIndex = 10;
            // 
            // textBox_contractImportMessages
            // 
            textBox_contractImportMessages.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            textBox_contractImportMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox_contractImportMessages.Dock = System.Windows.Forms.DockStyle.Bottom;
            textBox_contractImportMessages.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            textBox_contractImportMessages.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            textBox_contractImportMessages.Location = new System.Drawing.Point(0, 0);
            textBox_contractImportMessages.Multiline = true;
            textBox_contractImportMessages.Name = "textBox_contractImportMessages";
            textBox_contractImportMessages.ReadOnly = true;
            textBox_contractImportMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBox_contractImportMessages.Size = new System.Drawing.Size(1006, 184);
            textBox_contractImportMessages.TabIndex = 0;
            defaultToolTip.SetToolTip(textBox_contractImportMessages, "Validation or import status");
            textBox_contractImportMessages.WordWrap = false;
            textBox_contractImportMessages.MouseClick += textBox_projectImportMessages_MouseClick;
            // 
            // panel_contractButtons
            // 
            panel_contractButtons.Controls.Add(button_clear);
            panel_contractButtons.Controls.Add(button_import);
            panel_contractButtons.Controls.Add(button_validate);
            panel_contractButtons.Controls.Add(button_stop);
            panel_contractButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_contractButtons.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            panel_contractButtons.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel_contractButtons.Location = new System.Drawing.Point(0, 226);
            panel_contractButtons.Name = "panel_contractButtons";
            panel_contractButtons.Size = new System.Drawing.Size(1006, 52);
            panel_contractButtons.TabIndex = 12;
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
            // panel_contractFieldMapping
            // 
            panel_contractFieldMapping.AutoScroll = true;
            panel_contractFieldMapping.Controls.Add(textBox5);
            panel_contractFieldMapping.Controls.Add(textBox6);
            panel_contractFieldMapping.Controls.Add(textBox7);
            panel_contractFieldMapping.Controls.Add(textBox8);
            panel_contractFieldMapping.Controls.Add(textBox4);
            panel_contractFieldMapping.Controls.Add(textBox3);
            panel_contractFieldMapping.Controls.Add(textBox2);
            panel_contractFieldMapping.Controls.Add(textBox1);
            panel_contractFieldMapping.Controls.Add(flowLayoutPanel_nonMandatoryFields);
            panel_contractFieldMapping.Controls.Add(label_delimiter);
            panel_contractFieldMapping.Controls.Add(comboBox_delimiter);
            panel_contractFieldMapping.Controls.Add(groupBox_contractMandatoryFields);
            panel_contractFieldMapping.Controls.Add(label_contractSetup);
            panel_contractFieldMapping.Controls.Add(button_contractSelectFile);
            panel_contractFieldMapping.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_contractFieldMapping.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            panel_contractFieldMapping.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel_contractFieldMapping.Location = new System.Drawing.Point(0, 0);
            panel_contractFieldMapping.MinimumSize = new System.Drawing.Size(0, 120);
            panel_contractFieldMapping.Name = "panel_contractFieldMapping";
            panel_contractFieldMapping.Size = new System.Drawing.Size(1006, 226);
            panel_contractFieldMapping.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.BackColor = System.Drawing.SystemColors.InfoText;
            textBox5.ForeColor = System.Drawing.SystemColors.HighlightText;
            textBox5.Location = new System.Drawing.Point(312, 662);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(227, 25);
            textBox5.TabIndex = 15;
            textBox5.Text = "Fixed Price and TDR Contract -->";
            // 
            // textBox6
            // 
            textBox6.BackColor = System.Drawing.SystemColors.InfoText;
            textBox6.ForeColor = System.Drawing.SystemColors.HighlightText;
            textBox6.Location = new System.Drawing.Point(311, 629);
            textBox6.Name = "textBox6";
            textBox6.Size = new System.Drawing.Size(227, 25);
            textBox6.TabIndex = 14;
            textBox6.Text = "Fixed Price and TDR Contract -->";
            // 
            // textBox7
            // 
            textBox7.BackColor = System.Drawing.SystemColors.InfoText;
            textBox7.ForeColor = System.Drawing.SystemColors.HighlightText;
            textBox7.Location = new System.Drawing.Point(311, 598);
            textBox7.Name = "textBox7";
            textBox7.Size = new System.Drawing.Size(227, 25);
            textBox7.TabIndex = 13;
            textBox7.Text = "TDR Contract -->";
            // 
            // textBox8
            // 
            textBox8.BackColor = System.Drawing.SystemColors.InfoText;
            textBox8.ForeColor = System.Drawing.SystemColors.HighlightText;
            textBox8.Location = new System.Drawing.Point(311, 567);
            textBox8.Name = "textBox8";
            textBox8.Size = new System.Drawing.Size(227, 25);
            textBox8.TabIndex = 12;
            textBox8.Text = "TDR Contract -->";
            // 
            // textBox4
            // 
            textBox4.BackColor = System.Drawing.SystemColors.InfoText;
            textBox4.ForeColor = System.Drawing.SystemColors.HighlightText;
            textBox4.Location = new System.Drawing.Point(311, 534);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(227, 25);
            textBox4.TabIndex = 11;
            textBox4.Text = "TDR Contract -->";
            // 
            // textBox3
            // 
            textBox3.BackColor = System.Drawing.SystemColors.InfoText;
            textBox3.ForeColor = System.Drawing.SystemColors.HighlightText;
            textBox3.Location = new System.Drawing.Point(311, 503);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(227, 25);
            textBox3.TabIndex = 10;
            textBox3.Text = "Prepaid Service and TDR contract-->";
            // 
            // textBox2
            // 
            textBox2.BackColor = System.Drawing.SystemColors.InfoText;
            textBox2.ForeColor = System.Drawing.SystemColors.HighlightText;
            textBox2.Location = new System.Drawing.Point(311, 472);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(227, 25);
            textBox2.TabIndex = 9;
            textBox2.Text = "Prepaid Service contract -->";
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            textBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            textBox1.Location = new System.Drawing.Point(311, 441);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(227, 25);
            textBox1.TabIndex = 8;
            textBox1.Text = "Prepaid Service contract -->";
            // 
            // flowLayoutPanel_nonMandatoryFields
            // 
            flowLayoutPanel_nonMandatoryFields.Controls.Add(panel_NonMandatoryButton);
            flowLayoutPanel_nonMandatoryFields.Controls.Add(panel_NonMandatoryFields);
            flowLayoutPanel_nonMandatoryFields.Location = new System.Drawing.Point(547, 60);
            flowLayoutPanel_nonMandatoryFields.Name = "flowLayoutPanel_nonMandatoryFields";
            flowLayoutPanel_nonMandatoryFields.Size = new System.Drawing.Size(419, 650);
            flowLayoutPanel_nonMandatoryFields.TabIndex = 7;
            // 
            // panel_NonMandatoryButton
            // 
            panel_NonMandatoryButton.Controls.Add(label_nonMandatoryFields);
            panel_NonMandatoryButton.Controls.Add(button_expandNonMandatory);
            panel_NonMandatoryButton.Location = new System.Drawing.Point(3, 3);
            panel_NonMandatoryButton.Name = "panel_NonMandatoryButton";
            panel_NonMandatoryButton.Size = new System.Drawing.Size(416, 32);
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
            panel_NonMandatoryFields.Controls.Add(checkBox_defaultContractIsFixedHourlyRate);
            panel_NonMandatoryFields.Controls.Add(label_contractIsFixedHourlyRate);
            panel_NonMandatoryFields.Controls.Add(comboBox_contractIsFixedHourlyRate);
            panel_NonMandatoryFields.Controls.Add(label_contractHourlyRateName);
            panel_NonMandatoryFields.Controls.Add(comboBox_contractHourlyRateName);
            panel_NonMandatoryFields.Controls.Add(checkBox_defaultContractIsTravelLinked);
            panel_NonMandatoryFields.Controls.Add(checkBox_defaultContractIsExpensesLinked);
            panel_NonMandatoryFields.Controls.Add(label_contractIsExpensesLinked);
            panel_NonMandatoryFields.Controls.Add(label_contractIsTravelLinked);
            panel_NonMandatoryFields.Controls.Add(comboBox_contractIsTravelLinked);
            panel_NonMandatoryFields.Controls.Add(comboBox_contractIsExpensesLinked);
            panel_NonMandatoryFields.Controls.Add(label_contractRevenueTravelAmount);
            panel_NonMandatoryFields.Controls.Add(comboBox_contractRevenueTravelAmount);
            panel_NonMandatoryFields.Controls.Add(label_contractRevenueExpensesAmount);
            panel_NonMandatoryFields.Controls.Add(comboBox_contractRevenueExpensesAmount);
            panel_NonMandatoryFields.Controls.Add(label_contractPaymentPlanAmount);
            panel_NonMandatoryFields.Controls.Add(comboBox_contractPaymentPlanAmount);
            panel_NonMandatoryFields.Controls.Add(label_contractTargetHourlyRate);
            panel_NonMandatoryFields.Controls.Add(comboBox_contractTargetHourlyRate);
            panel_NonMandatoryFields.Controls.Add(checkBox_defaultContractHasBudgetOverrunNotification);
            panel_NonMandatoryFields.Controls.Add(label_contractHasBudgetOverrunNotification);
            panel_NonMandatoryFields.Controls.Add(comboBox_contractHasBudgetOverrunNotification);
            panel_NonMandatoryFields.Controls.Add(checkBox_defaultContractIsDefaultExpenses);
            panel_NonMandatoryFields.Controls.Add(label_contractIsDefaultExpenses);
            panel_NonMandatoryFields.Controls.Add(comboBox_contractIsDefaultExpenses);
            panel_NonMandatoryFields.Controls.Add(checkBox_defaultContractIsMileageBillable);
            panel_NonMandatoryFields.Controls.Add(label_contractIsMileageBillable);
            panel_NonMandatoryFields.Controls.Add(comboBox_contractIsMileageBillable);
            panel_NonMandatoryFields.Controls.Add(checkBox_defaultContractCompletionNotificationPercentage);
            panel_NonMandatoryFields.Controls.Add(label_contractCompletionNotificationPercentage);
            panel_NonMandatoryFields.Controls.Add(comboBox_contractCompletionNotificationPercentage);
            panel_NonMandatoryFields.Controls.Add(comboBox_contractBudgetExpensesAmount);
            panel_NonMandatoryFields.Controls.Add(label_contractBudgetExpensesAmount);
            panel_NonMandatoryFields.Controls.Add(checkBox_defaultContractHasCompletionNotification);
            panel_NonMandatoryFields.Controls.Add(label_contractHasCompletionNotification);
            panel_NonMandatoryFields.Controls.Add(comboBox_contractBudgetTravelAmount);
            panel_NonMandatoryFields.Controls.Add(comboBox_contractHasCompletionNotification);
            panel_NonMandatoryFields.Controls.Add(label_contractBudgetTravelAmount);
            panel_NonMandatoryFields.Controls.Add(comboBox_contractBudgetWorkAmount);
            panel_NonMandatoryFields.Controls.Add(label_contractBudgetWorkAmount);
            panel_NonMandatoryFields.Controls.Add(label_contractBudgetWorkHour);
            panel_NonMandatoryFields.Controls.Add(comboBox_contractBudgetWorkHour);
            panel_NonMandatoryFields.Location = new System.Drawing.Point(3, 41);
            panel_NonMandatoryFields.MinimumSize = new System.Drawing.Size(363, 0);
            panel_NonMandatoryFields.Name = "panel_NonMandatoryFields";
            panel_NonMandatoryFields.Size = new System.Drawing.Size(416, 650);
            panel_NonMandatoryFields.TabIndex = 1;
            // 
            // checkBox_defaultContractIsFixedHourlyRate
            // 
            checkBox_defaultContractIsFixedHourlyRate.AutoSize = true;
            checkBox_defaultContractIsFixedHourlyRate.Location = new System.Drawing.Point(339, 347);
            checkBox_defaultContractIsFixedHourlyRate.Name = "checkBox_defaultContractIsFixedHourlyRate";
            checkBox_defaultContractIsFixedHourlyRate.Size = new System.Drawing.Size(70, 21);
            checkBox_defaultContractIsFixedHourlyRate.TabIndex = 48;
            checkBox_defaultContractIsFixedHourlyRate.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultContractIsFixedHourlyRate, "Set default values for all rows of a particular column field");
            checkBox_defaultContractIsFixedHourlyRate.UseVisualStyleBackColor = true;
            checkBox_defaultContractIsFixedHourlyRate.CheckedChanged += checkBox_defaultContractIsFixedHourlyRate_CheckedChanged;
            // 
            // label_contractIsFixedHourlyRate
            // 
            label_contractIsFixedHourlyRate.AutoSize = true;
            label_contractIsFixedHourlyRate.Location = new System.Drawing.Point(10, 348);
            label_contractIsFixedHourlyRate.Name = "label_contractIsFixedHourlyRate";
            label_contractIsFixedHourlyRate.Size = new System.Drawing.Size(130, 17);
            label_contractIsFixedHourlyRate.TabIndex = 46;
            label_contractIsFixedHourlyRate.Text = "Is Fixed Hourly Rate";
            // 
            // comboBox_contractIsFixedHourlyRate
            // 
            comboBox_contractIsFixedHourlyRate.FormattingEnabled = true;
            comboBox_contractIsFixedHourlyRate.Location = new System.Drawing.Point(194, 345);
            comboBox_contractIsFixedHourlyRate.Name = "comboBox_contractIsFixedHourlyRate";
            comboBox_contractIsFixedHourlyRate.Size = new System.Drawing.Size(139, 25);
            comboBox_contractIsFixedHourlyRate.TabIndex = 47;
            // 
            // label_contractHourlyRateName
            // 
            label_contractHourlyRateName.AutoSize = true;
            label_contractHourlyRateName.Location = new System.Drawing.Point(10, 379);
            label_contractHourlyRateName.Name = "label_contractHourlyRateName";
            label_contractHourlyRateName.Size = new System.Drawing.Size(120, 17);
            label_contractHourlyRateName.TabIndex = 44;
            label_contractHourlyRateName.Text = "Hourly Rate Name";
            // 
            // comboBox_contractHourlyRateName
            // 
            comboBox_contractHourlyRateName.FormattingEnabled = true;
            comboBox_contractHourlyRateName.Location = new System.Drawing.Point(194, 376);
            comboBox_contractHourlyRateName.Name = "comboBox_contractHourlyRateName";
            comboBox_contractHourlyRateName.Size = new System.Drawing.Size(139, 25);
            comboBox_contractHourlyRateName.TabIndex = 45;
            // 
            // checkBox_defaultContractIsTravelLinked
            // 
            checkBox_defaultContractIsTravelLinked.AutoSize = true;
            checkBox_defaultContractIsTravelLinked.Location = new System.Drawing.Point(339, 566);
            checkBox_defaultContractIsTravelLinked.Name = "checkBox_defaultContractIsTravelLinked";
            checkBox_defaultContractIsTravelLinked.Size = new System.Drawing.Size(70, 21);
            checkBox_defaultContractIsTravelLinked.TabIndex = 43;
            checkBox_defaultContractIsTravelLinked.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultContractIsTravelLinked, "Set default values for all rows of a particular column field");
            checkBox_defaultContractIsTravelLinked.UseVisualStyleBackColor = true;
            checkBox_defaultContractIsTravelLinked.CheckedChanged += checkBox_defaultContractIsTravelLinked_CheckedChanged;
            // 
            // checkBox_defaultContractIsExpensesLinked
            // 
            checkBox_defaultContractIsExpensesLinked.AutoSize = true;
            checkBox_defaultContractIsExpensesLinked.Location = new System.Drawing.Point(339, 535);
            checkBox_defaultContractIsExpensesLinked.Name = "checkBox_defaultContractIsExpensesLinked";
            checkBox_defaultContractIsExpensesLinked.Size = new System.Drawing.Size(70, 21);
            checkBox_defaultContractIsExpensesLinked.TabIndex = 40;
            checkBox_defaultContractIsExpensesLinked.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultContractIsExpensesLinked, "Set default values for all rows of a particular column field");
            checkBox_defaultContractIsExpensesLinked.UseVisualStyleBackColor = true;
            checkBox_defaultContractIsExpensesLinked.CheckedChanged += checkBox_defaultContractIsExpensesLinked_CheckedChanged;
            // 
            // label_contractIsExpensesLinked
            // 
            label_contractIsExpensesLinked.AutoSize = true;
            label_contractIsExpensesLinked.Location = new System.Drawing.Point(10, 536);
            label_contractIsExpensesLinked.Name = "label_contractIsExpensesLinked";
            label_contractIsExpensesLinked.Size = new System.Drawing.Size(121, 17);
            label_contractIsExpensesLinked.TabIndex = 38;
            label_contractIsExpensesLinked.Text = "Is Expenses Linked";
            // 
            // label_contractIsTravelLinked
            // 
            label_contractIsTravelLinked.AutoSize = true;
            label_contractIsTravelLinked.Location = new System.Drawing.Point(10, 567);
            label_contractIsTravelLinked.Name = "label_contractIsTravelLinked";
            label_contractIsTravelLinked.Size = new System.Drawing.Size(100, 17);
            label_contractIsTravelLinked.TabIndex = 41;
            label_contractIsTravelLinked.Text = "Is Travel Linked";
            // 
            // comboBox_contractIsTravelLinked
            // 
            comboBox_contractIsTravelLinked.FormattingEnabled = true;
            comboBox_contractIsTravelLinked.Location = new System.Drawing.Point(194, 564);
            comboBox_contractIsTravelLinked.Name = "comboBox_contractIsTravelLinked";
            comboBox_contractIsTravelLinked.Size = new System.Drawing.Size(139, 25);
            comboBox_contractIsTravelLinked.TabIndex = 42;
            // 
            // comboBox_contractIsExpensesLinked
            // 
            comboBox_contractIsExpensesLinked.FormattingEnabled = true;
            comboBox_contractIsExpensesLinked.Location = new System.Drawing.Point(194, 533);
            comboBox_contractIsExpensesLinked.Name = "comboBox_contractIsExpensesLinked";
            comboBox_contractIsExpensesLinked.Size = new System.Drawing.Size(139, 25);
            comboBox_contractIsExpensesLinked.TabIndex = 39;
            // 
            // label_contractRevenueTravelAmount
            // 
            label_contractRevenueTravelAmount.AutoSize = true;
            label_contractRevenueTravelAmount.Location = new System.Drawing.Point(10, 506);
            label_contractRevenueTravelAmount.Name = "label_contractRevenueTravelAmount";
            label_contractRevenueTravelAmount.Size = new System.Drawing.Size(153, 17);
            label_contractRevenueTravelAmount.TabIndex = 35;
            label_contractRevenueTravelAmount.Text = "Revenue Travel Amount";
            // 
            // comboBox_contractRevenueTravelAmount
            // 
            comboBox_contractRevenueTravelAmount.FormattingEnabled = true;
            comboBox_contractRevenueTravelAmount.Location = new System.Drawing.Point(194, 503);
            comboBox_contractRevenueTravelAmount.Name = "comboBox_contractRevenueTravelAmount";
            comboBox_contractRevenueTravelAmount.Size = new System.Drawing.Size(139, 25);
            comboBox_contractRevenueTravelAmount.TabIndex = 36;
            // 
            // label_contractRevenueExpensesAmount
            // 
            label_contractRevenueExpensesAmount.AutoSize = true;
            label_contractRevenueExpensesAmount.Location = new System.Drawing.Point(10, 474);
            label_contractRevenueExpensesAmount.Name = "label_contractRevenueExpensesAmount";
            label_contractRevenueExpensesAmount.Size = new System.Drawing.Size(168, 17);
            label_contractRevenueExpensesAmount.TabIndex = 32;
            label_contractRevenueExpensesAmount.Text = "Revenue Expense Amount";
            // 
            // comboBox_contractRevenueExpensesAmount
            // 
            comboBox_contractRevenueExpensesAmount.FormattingEnabled = true;
            comboBox_contractRevenueExpensesAmount.Location = new System.Drawing.Point(194, 471);
            comboBox_contractRevenueExpensesAmount.Name = "comboBox_contractRevenueExpensesAmount";
            comboBox_contractRevenueExpensesAmount.Size = new System.Drawing.Size(139, 25);
            comboBox_contractRevenueExpensesAmount.TabIndex = 33;
            // 
            // label_contractPaymentPlanAmount
            // 
            label_contractPaymentPlanAmount.AutoSize = true;
            label_contractPaymentPlanAmount.Location = new System.Drawing.Point(10, 441);
            label_contractPaymentPlanAmount.Name = "label_contractPaymentPlanAmount";
            label_contractPaymentPlanAmount.Size = new System.Drawing.Size(146, 17);
            label_contractPaymentPlanAmount.TabIndex = 29;
            label_contractPaymentPlanAmount.Text = "Payment Plan Amount";
            // 
            // comboBox_contractPaymentPlanAmount
            // 
            comboBox_contractPaymentPlanAmount.FormattingEnabled = true;
            comboBox_contractPaymentPlanAmount.Location = new System.Drawing.Point(194, 438);
            comboBox_contractPaymentPlanAmount.Name = "comboBox_contractPaymentPlanAmount";
            comboBox_contractPaymentPlanAmount.Size = new System.Drawing.Size(139, 25);
            comboBox_contractPaymentPlanAmount.TabIndex = 30;
            // 
            // label_contractTargetHourlyRate
            // 
            label_contractTargetHourlyRate.AutoSize = true;
            label_contractTargetHourlyRate.Location = new System.Drawing.Point(10, 410);
            label_contractTargetHourlyRate.Name = "label_contractTargetHourlyRate";
            label_contractTargetHourlyRate.Size = new System.Drawing.Size(122, 17);
            label_contractTargetHourlyRate.TabIndex = 26;
            label_contractTargetHourlyRate.Text = "Target Hourly Rate";
            // 
            // comboBox_contractTargetHourlyRate
            // 
            comboBox_contractTargetHourlyRate.FormattingEnabled = true;
            comboBox_contractTargetHourlyRate.Location = new System.Drawing.Point(194, 407);
            comboBox_contractTargetHourlyRate.Name = "comboBox_contractTargetHourlyRate";
            comboBox_contractTargetHourlyRate.Size = new System.Drawing.Size(139, 25);
            comboBox_contractTargetHourlyRate.TabIndex = 27;
            // 
            // checkBox_defaultContractHasBudgetOverrunNotification
            // 
            checkBox_defaultContractHasBudgetOverrunNotification.AutoSize = true;
            checkBox_defaultContractHasBudgetOverrunNotification.Location = new System.Drawing.Point(339, 263);
            checkBox_defaultContractHasBudgetOverrunNotification.Name = "checkBox_defaultContractHasBudgetOverrunNotification";
            checkBox_defaultContractHasBudgetOverrunNotification.Size = new System.Drawing.Size(70, 21);
            checkBox_defaultContractHasBudgetOverrunNotification.TabIndex = 19;
            checkBox_defaultContractHasBudgetOverrunNotification.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultContractHasBudgetOverrunNotification, "Set default values for all rows of a particular column field");
            checkBox_defaultContractHasBudgetOverrunNotification.UseVisualStyleBackColor = true;
            checkBox_defaultContractHasBudgetOverrunNotification.CheckedChanged += checkBox_defaultContractHasBudgetOverrunNotification_CheckedChanged;
            // 
            // label_contractHasBudgetOverrunNotification
            // 
            label_contractHasBudgetOverrunNotification.AutoSize = true;
            label_contractHasBudgetOverrunNotification.Location = new System.Drawing.Point(10, 264);
            label_contractHasBudgetOverrunNotification.Name = "label_contractHasBudgetOverrunNotification";
            label_contractHasBudgetOverrunNotification.Size = new System.Drawing.Size(180, 17);
            label_contractHasBudgetOverrunNotification.TabIndex = 17;
            label_contractHasBudgetOverrunNotification.Text = "Budget Overrun Notification";
            // 
            // comboBox_contractHasBudgetOverrunNotification
            // 
            comboBox_contractHasBudgetOverrunNotification.FormattingEnabled = true;
            comboBox_contractHasBudgetOverrunNotification.Location = new System.Drawing.Point(194, 261);
            comboBox_contractHasBudgetOverrunNotification.Name = "comboBox_contractHasBudgetOverrunNotification";
            comboBox_contractHasBudgetOverrunNotification.Size = new System.Drawing.Size(139, 25);
            comboBox_contractHasBudgetOverrunNotification.TabIndex = 18;
            // 
            // checkBox_defaultContractIsDefaultExpenses
            // 
            checkBox_defaultContractIsDefaultExpenses.AutoSize = true;
            checkBox_defaultContractIsDefaultExpenses.Location = new System.Drawing.Point(339, 232);
            checkBox_defaultContractIsDefaultExpenses.Name = "checkBox_defaultContractIsDefaultExpenses";
            checkBox_defaultContractIsDefaultExpenses.Size = new System.Drawing.Size(70, 21);
            checkBox_defaultContractIsDefaultExpenses.TabIndex = 16;
            checkBox_defaultContractIsDefaultExpenses.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultContractIsDefaultExpenses, "Set default values for all rows of a particular column field");
            checkBox_defaultContractIsDefaultExpenses.UseVisualStyleBackColor = true;
            checkBox_defaultContractIsDefaultExpenses.CheckedChanged += checkBox_defaultContractIsDefaultExpenses_CheckedChanged;
            // 
            // label_contractIsDefaultExpenses
            // 
            label_contractIsDefaultExpenses.AutoSize = true;
            label_contractIsDefaultExpenses.Location = new System.Drawing.Point(10, 233);
            label_contractIsDefaultExpenses.Name = "label_contractIsDefaultExpenses";
            label_contractIsDefaultExpenses.Size = new System.Drawing.Size(125, 17);
            label_contractIsDefaultExpenses.TabIndex = 14;
            label_contractIsDefaultExpenses.Text = "Is Default Expenses";
            // 
            // comboBox_contractIsDefaultExpenses
            // 
            comboBox_contractIsDefaultExpenses.FormattingEnabled = true;
            comboBox_contractIsDefaultExpenses.Location = new System.Drawing.Point(194, 230);
            comboBox_contractIsDefaultExpenses.Name = "comboBox_contractIsDefaultExpenses";
            comboBox_contractIsDefaultExpenses.Size = new System.Drawing.Size(139, 25);
            comboBox_contractIsDefaultExpenses.TabIndex = 15;
            // 
            // checkBox_defaultContractIsMileageBillable
            // 
            checkBox_defaultContractIsMileageBillable.AutoSize = true;
            checkBox_defaultContractIsMileageBillable.Location = new System.Drawing.Point(339, 198);
            checkBox_defaultContractIsMileageBillable.Name = "checkBox_defaultContractIsMileageBillable";
            checkBox_defaultContractIsMileageBillable.Size = new System.Drawing.Size(70, 21);
            checkBox_defaultContractIsMileageBillable.TabIndex = 13;
            checkBox_defaultContractIsMileageBillable.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultContractIsMileageBillable, "Set default values for all rows of a particular column field");
            checkBox_defaultContractIsMileageBillable.UseVisualStyleBackColor = true;
            checkBox_defaultContractIsMileageBillable.CheckedChanged += checkBox_defaultContractIsMileageBillable_CheckedChanged;
            // 
            // label_contractIsMileageBillable
            // 
            label_contractIsMileageBillable.AutoSize = true;
            label_contractIsMileageBillable.Location = new System.Drawing.Point(10, 199);
            label_contractIsMileageBillable.Name = "label_contractIsMileageBillable";
            label_contractIsMileageBillable.Size = new System.Drawing.Size(115, 17);
            label_contractIsMileageBillable.TabIndex = 11;
            label_contractIsMileageBillable.Text = "Is Mileage Billable";
            // 
            // comboBox_contractIsMileageBillable
            // 
            comboBox_contractIsMileageBillable.FormattingEnabled = true;
            comboBox_contractIsMileageBillable.Location = new System.Drawing.Point(194, 196);
            comboBox_contractIsMileageBillable.Name = "comboBox_contractIsMileageBillable";
            comboBox_contractIsMileageBillable.Size = new System.Drawing.Size(139, 25);
            comboBox_contractIsMileageBillable.TabIndex = 12;
            // 
            // checkBox_defaultContractCompletionNotificationPercentage
            // 
            checkBox_defaultContractCompletionNotificationPercentage.AutoSize = true;
            checkBox_defaultContractCompletionNotificationPercentage.Location = new System.Drawing.Point(339, 164);
            checkBox_defaultContractCompletionNotificationPercentage.Name = "checkBox_defaultContractCompletionNotificationPercentage";
            checkBox_defaultContractCompletionNotificationPercentage.Size = new System.Drawing.Size(70, 21);
            checkBox_defaultContractCompletionNotificationPercentage.TabIndex = 10;
            checkBox_defaultContractCompletionNotificationPercentage.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultContractCompletionNotificationPercentage, "Set default values for all rows of a particular column field");
            checkBox_defaultContractCompletionNotificationPercentage.UseVisualStyleBackColor = true;
            checkBox_defaultContractCompletionNotificationPercentage.CheckedChanged += checkBox_defaultContractCompletionNotificationPercentage_CheckedChanged;
            // 
            // label_contractCompletionNotificationPercentage
            // 
            label_contractCompletionNotificationPercentage.AutoSize = true;
            label_contractCompletionNotificationPercentage.Location = new System.Drawing.Point(10, 165);
            label_contractCompletionNotificationPercentage.Name = "label_contractCompletionNotificationPercentage";
            label_contractCompletionNotificationPercentage.Size = new System.Drawing.Size(167, 17);
            label_contractCompletionNotificationPercentage.TabIndex = 8;
            label_contractCompletionNotificationPercentage.Text = "Completion Notification %";
            // 
            // comboBox_contractCompletionNotificationPercentage
            // 
            comboBox_contractCompletionNotificationPercentage.FormattingEnabled = true;
            comboBox_contractCompletionNotificationPercentage.Location = new System.Drawing.Point(194, 162);
            comboBox_contractCompletionNotificationPercentage.Name = "comboBox_contractCompletionNotificationPercentage";
            comboBox_contractCompletionNotificationPercentage.Size = new System.Drawing.Size(139, 25);
            comboBox_contractCompletionNotificationPercentage.TabIndex = 9;
            // 
            // comboBox_contractBudgetExpensesAmount
            // 
            comboBox_contractBudgetExpensesAmount.FormattingEnabled = true;
            comboBox_contractBudgetExpensesAmount.Location = new System.Drawing.Point(194, 7);
            comboBox_contractBudgetExpensesAmount.Name = "comboBox_contractBudgetExpensesAmount";
            comboBox_contractBudgetExpensesAmount.Size = new System.Drawing.Size(139, 25);
            comboBox_contractBudgetExpensesAmount.TabIndex = 7;
            // 
            // label_contractBudgetExpensesAmount
            // 
            label_contractBudgetExpensesAmount.AutoSize = true;
            label_contractBudgetExpensesAmount.Location = new System.Drawing.Point(10, 10);
            label_contractBudgetExpensesAmount.Name = "label_contractBudgetExpensesAmount";
            label_contractBudgetExpensesAmount.Size = new System.Drawing.Size(166, 17);
            label_contractBudgetExpensesAmount.TabIndex = 6;
            label_contractBudgetExpensesAmount.Text = "Budget Expenses Amount";
            // 
            // checkBox_defaultContractHasCompletionNotification
            // 
            checkBox_defaultContractHasCompletionNotification.AutoSize = true;
            checkBox_defaultContractHasCompletionNotification.Location = new System.Drawing.Point(339, 133);
            checkBox_defaultContractHasCompletionNotification.Name = "checkBox_defaultContractHasCompletionNotification";
            checkBox_defaultContractHasCompletionNotification.Size = new System.Drawing.Size(70, 21);
            checkBox_defaultContractHasCompletionNotification.TabIndex = 5;
            checkBox_defaultContractHasCompletionNotification.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultContractHasCompletionNotification, "Set default values for all rows of a particular column field");
            checkBox_defaultContractHasCompletionNotification.UseVisualStyleBackColor = true;
            checkBox_defaultContractHasCompletionNotification.CheckedChanged += checkBox_defaultContractHasCompletionNotification_CheckedChanged;
            // 
            // label_contractHasCompletionNotification
            // 
            label_contractHasCompletionNotification.AutoSize = true;
            label_contractHasCompletionNotification.Location = new System.Drawing.Point(10, 134);
            label_contractHasCompletionNotification.Name = "label_contractHasCompletionNotification";
            label_contractHasCompletionNotification.Size = new System.Drawing.Size(179, 17);
            label_contractHasCompletionNotification.TabIndex = 1;
            label_contractHasCompletionNotification.Text = "Has Completion Notification";
            // 
            // comboBox_contractBudgetTravelAmount
            // 
            comboBox_contractBudgetTravelAmount.FormattingEnabled = true;
            comboBox_contractBudgetTravelAmount.Location = new System.Drawing.Point(194, 38);
            comboBox_contractBudgetTravelAmount.Name = "comboBox_contractBudgetTravelAmount";
            comboBox_contractBudgetTravelAmount.Size = new System.Drawing.Size(139, 25);
            comboBox_contractBudgetTravelAmount.TabIndex = 3;
            // 
            // comboBox_contractHasCompletionNotification
            // 
            comboBox_contractHasCompletionNotification.FormattingEnabled = true;
            comboBox_contractHasCompletionNotification.Location = new System.Drawing.Point(194, 131);
            comboBox_contractHasCompletionNotification.Name = "comboBox_contractHasCompletionNotification";
            comboBox_contractHasCompletionNotification.Size = new System.Drawing.Size(139, 25);
            comboBox_contractHasCompletionNotification.TabIndex = 3;
            // 
            // label_contractBudgetTravelAmount
            // 
            label_contractBudgetTravelAmount.AutoSize = true;
            label_contractBudgetTravelAmount.Location = new System.Drawing.Point(10, 41);
            label_contractBudgetTravelAmount.Name = "label_contractBudgetTravelAmount";
            label_contractBudgetTravelAmount.Size = new System.Drawing.Size(145, 17);
            label_contractBudgetTravelAmount.TabIndex = 1;
            label_contractBudgetTravelAmount.Text = "Budget Travel Amount";
            // 
            // comboBox_contractBudgetWorkAmount
            // 
            comboBox_contractBudgetWorkAmount.FormattingEnabled = true;
            comboBox_contractBudgetWorkAmount.Location = new System.Drawing.Point(194, 69);
            comboBox_contractBudgetWorkAmount.Name = "comboBox_contractBudgetWorkAmount";
            comboBox_contractBudgetWorkAmount.Size = new System.Drawing.Size(139, 25);
            comboBox_contractBudgetWorkAmount.TabIndex = 3;
            // 
            // label_contractBudgetWorkAmount
            // 
            label_contractBudgetWorkAmount.AutoSize = true;
            label_contractBudgetWorkAmount.Location = new System.Drawing.Point(10, 72);
            label_contractBudgetWorkAmount.Name = "label_contractBudgetWorkAmount";
            label_contractBudgetWorkAmount.Size = new System.Drawing.Size(143, 17);
            label_contractBudgetWorkAmount.TabIndex = 1;
            label_contractBudgetWorkAmount.Text = "Budget Work Amount";
            // 
            // label_contractBudgetWorkHour
            // 
            label_contractBudgetWorkHour.AutoSize = true;
            label_contractBudgetWorkHour.Location = new System.Drawing.Point(10, 103);
            label_contractBudgetWorkHour.Name = "label_contractBudgetWorkHour";
            label_contractBudgetWorkHour.Size = new System.Drawing.Size(124, 17);
            label_contractBudgetWorkHour.TabIndex = 1;
            label_contractBudgetWorkHour.Text = "Budget Work Hour";
            // 
            // comboBox_contractBudgetWorkHour
            // 
            comboBox_contractBudgetWorkHour.FormattingEnabled = true;
            comboBox_contractBudgetWorkHour.Location = new System.Drawing.Point(194, 100);
            comboBox_contractBudgetWorkHour.Name = "comboBox_contractBudgetWorkHour";
            comboBox_contractBudgetWorkHour.Size = new System.Drawing.Size(139, 25);
            comboBox_contractBudgetWorkHour.TabIndex = 3;
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
            comboBox_delimiter.FormattingEnabled = true;
            comboBox_delimiter.Location = new System.Drawing.Point(82, 72);
            comboBox_delimiter.Name = "comboBox_delimiter";
            comboBox_delimiter.Size = new System.Drawing.Size(56, 25);
            comboBox_delimiter.TabIndex = 6;
            // 
            // groupBox_contractMandatoryFields
            // 
            groupBox_contractMandatoryFields.Controls.Add(checkBox_defaultContractModel);
            groupBox_contractMandatoryFields.Controls.Add(label_contractModel);
            groupBox_contractMandatoryFields.Controls.Add(comboBox_ContractModel);
            groupBox_contractMandatoryFields.Controls.Add(label_projectNo);
            groupBox_contractMandatoryFields.Controls.Add(checkBox_defaultContractStatus);
            groupBox_contractMandatoryFields.Controls.Add(comboBox_projectNo);
            groupBox_contractMandatoryFields.Controls.Add(label_contractOwnerInitials);
            groupBox_contractMandatoryFields.Controls.Add(comboBox_contractOwnerInitials);
            groupBox_contractMandatoryFields.Controls.Add(label_contractStatus);
            groupBox_contractMandatoryFields.Controls.Add(comboBox_contractStatus);
            groupBox_contractMandatoryFields.Controls.Add(label_projectName);
            groupBox_contractMandatoryFields.Controls.Add(comboBox_contractName);
            groupBox_contractMandatoryFields.Location = new System.Drawing.Point(166, 62);
            groupBox_contractMandatoryFields.Name = "groupBox_contractMandatoryFields";
            groupBox_contractMandatoryFields.Size = new System.Drawing.Size(375, 190);
            groupBox_contractMandatoryFields.TabIndex = 5;
            groupBox_contractMandatoryFields.TabStop = false;
            groupBox_contractMandatoryFields.Text = "Mandatory";
            // 
            // checkBox_defaultContractModel
            // 
            checkBox_defaultContractModel.AutoSize = true;
            checkBox_defaultContractModel.Location = new System.Drawing.Point(304, 150);
            checkBox_defaultContractModel.Name = "checkBox_defaultContractModel";
            checkBox_defaultContractModel.Size = new System.Drawing.Size(70, 21);
            checkBox_defaultContractModel.TabIndex = 8;
            checkBox_defaultContractModel.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultContractModel, "Set default values for all rows of a particular column field");
            checkBox_defaultContractModel.UseVisualStyleBackColor = true;
            checkBox_defaultContractModel.CheckedChanged += checkBox_defaultContractModel_CheckedChanged;
            // 
            // label_contractModel
            // 
            label_contractModel.AutoSize = true;
            label_contractModel.Location = new System.Drawing.Point(6, 151);
            label_contractModel.Name = "label_contractModel";
            label_contractModel.Size = new System.Drawing.Size(102, 17);
            label_contractModel.TabIndex = 6;
            label_contractModel.Text = "Contract Model";
            // 
            // comboBox_ContractModel
            // 
            comboBox_ContractModel.FormattingEnabled = true;
            comboBox_ContractModel.Location = new System.Drawing.Point(160, 148);
            comboBox_ContractModel.Name = "comboBox_ContractModel";
            comboBox_ContractModel.Size = new System.Drawing.Size(139, 25);
            comboBox_ContractModel.TabIndex = 7;
            // 
            // label_projectNo
            // 
            label_projectNo.AutoSize = true;
            label_projectNo.Location = new System.Drawing.Point(5, 58);
            label_projectNo.Name = "label_projectNo";
            label_projectNo.Size = new System.Drawing.Size(72, 17);
            label_projectNo.TabIndex = 1;
            label_projectNo.Text = "Project No";
            // 
            // checkBox_defaultContractStatus
            // 
            checkBox_defaultContractStatus.AutoSize = true;
            checkBox_defaultContractStatus.Location = new System.Drawing.Point(304, 88);
            checkBox_defaultContractStatus.Name = "checkBox_defaultContractStatus";
            checkBox_defaultContractStatus.Size = new System.Drawing.Size(70, 21);
            checkBox_defaultContractStatus.TabIndex = 5;
            checkBox_defaultContractStatus.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultContractStatus, "Set default values for all rows of a particular column field");
            checkBox_defaultContractStatus.UseVisualStyleBackColor = true;
            checkBox_defaultContractStatus.CheckedChanged += checkBox_defaultContractStatus_CheckedChanged;
            // 
            // comboBox_projectNo
            // 
            comboBox_projectNo.FormattingEnabled = true;
            comboBox_projectNo.Location = new System.Drawing.Point(160, 55);
            comboBox_projectNo.Name = "comboBox_projectNo";
            comboBox_projectNo.Size = new System.Drawing.Size(139, 25);
            comboBox_projectNo.TabIndex = 3;
            // 
            // label_contractOwnerInitials
            // 
            label_contractOwnerInitials.AutoSize = true;
            label_contractOwnerInitials.Location = new System.Drawing.Point(6, 120);
            label_contractOwnerInitials.Name = "label_contractOwnerInitials";
            label_contractOwnerInitials.Size = new System.Drawing.Size(147, 17);
            label_contractOwnerInitials.TabIndex = 1;
            label_contractOwnerInitials.Text = "Contract Owner Initials";
            // 
            // comboBox_contractOwnerInitials
            // 
            comboBox_contractOwnerInitials.FormattingEnabled = true;
            comboBox_contractOwnerInitials.Location = new System.Drawing.Point(160, 117);
            comboBox_contractOwnerInitials.Name = "comboBox_contractOwnerInitials";
            comboBox_contractOwnerInitials.Size = new System.Drawing.Size(139, 25);
            comboBox_contractOwnerInitials.TabIndex = 3;
            // 
            // label_contractStatus
            // 
            label_contractStatus.AutoSize = true;
            label_contractStatus.Location = new System.Drawing.Point(6, 89);
            label_contractStatus.Name = "label_contractStatus";
            label_contractStatus.Size = new System.Drawing.Size(102, 17);
            label_contractStatus.TabIndex = 1;
            label_contractStatus.Text = "Contract Status";
            // 
            // comboBox_contractStatus
            // 
            comboBox_contractStatus.FormattingEnabled = true;
            comboBox_contractStatus.Location = new System.Drawing.Point(160, 86);
            comboBox_contractStatus.Name = "comboBox_contractStatus";
            comboBox_contractStatus.Size = new System.Drawing.Size(139, 25);
            comboBox_contractStatus.TabIndex = 3;
            // 
            // label_projectName
            // 
            label_projectName.AutoSize = true;
            label_projectName.Location = new System.Drawing.Point(6, 27);
            label_projectName.Name = "label_projectName";
            label_projectName.Size = new System.Drawing.Size(100, 17);
            label_projectName.TabIndex = 1;
            label_projectName.Text = "Contract Name";
            // 
            // comboBox_contractName
            // 
            comboBox_contractName.FormattingEnabled = true;
            comboBox_contractName.Location = new System.Drawing.Point(160, 24);
            comboBox_contractName.Name = "comboBox_contractName";
            comboBox_contractName.Size = new System.Drawing.Size(139, 25);
            comboBox_contractName.TabIndex = 3;
            // 
            // label_contractSetup
            // 
            label_contractSetup.AutoSize = true;
            label_contractSetup.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            label_contractSetup.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            label_contractSetup.Location = new System.Drawing.Point(7, 16);
            label_contractSetup.Name = "label_contractSetup";
            label_contractSetup.Size = new System.Drawing.Size(249, 32);
            label_contractSetup.TabIndex = 0;
            label_contractSetup.Text = "Contract Data Import";
            // 
            // button_contractSelectFile
            // 
            button_contractSelectFile.BackColor = System.Drawing.Color.FromArgb(226, 43, 141);
            button_contractSelectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            button_contractSelectFile.FlatAppearance.BorderSize = 0;
            button_contractSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_contractSelectFile.ForeColor = System.Drawing.Color.White;
            button_contractSelectFile.Location = new System.Drawing.Point(13, 111);
            button_contractSelectFile.Name = "button_contractSelectFile";
            button_contractSelectFile.Size = new System.Drawing.Size(80, 29);
            button_contractSelectFile.TabIndex = 4;
            button_contractSelectFile.Text = "Select File";
            defaultToolTip.SetToolTip(button_contractSelectFile, "Select input CSV file");
            button_contractSelectFile.UseVisualStyleBackColor = false;
            button_contractSelectFile.Click += button_select_contract_file_Click;
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
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new System.Drawing.Point(271, 286);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new System.Drawing.Size(139, 23);
            comboBox5.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(138, 289);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(125, 17);
            label5.TabIndex = 26;
            label5.Text = "Is Default Expenses";
            // 
            // UserControl_ContractImport
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel_contractFieldMapping);
            Controls.Add(panel_contractButtons);
            Controls.Add(panel_projectMessage);
            Controls.Add(panel_projectDataTable);
            Name = "UserControl_ContractImport";
            Size = new System.Drawing.Size(1006, 642);
            Load += UserControl1_Load;
            panel_projectDataTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_contract).EndInit();
            panel_projectMessage.ResumeLayout(false);
            panel_projectMessage.PerformLayout();
            panel_contractButtons.ResumeLayout(false);
            panel_contractFieldMapping.ResumeLayout(false);
            panel_contractFieldMapping.PerformLayout();
            flowLayoutPanel_nonMandatoryFields.ResumeLayout(false);
            panel_NonMandatoryButton.ResumeLayout(false);
            panel_NonMandatoryButton.PerformLayout();
            panel_NonMandatoryFields.ResumeLayout(false);
            panel_NonMandatoryFields.PerformLayout();
            groupBox_contractMandatoryFields.ResumeLayout(false);
            groupBox_contractMandatoryFields.PerformLayout();
            ResumeLayout(false);

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
        private System.Windows.Forms.ComboBox comboBox_contractRevenueExpensesAmount;
        private System.Windows.Forms.Label label_contractPaymentPlanAmount;
        private System.Windows.Forms.ComboBox comboBox_contractPaymentPlanAmount;
        private System.Windows.Forms.Label label_contractTargetHourlyRate;
        private System.Windows.Forms.ComboBox comboBox_contractTargetHourlyRate;
        private System.Windows.Forms.Label label_contractModel;
        private System.Windows.Forms.ComboBox comboBox_ContractModel;
        private System.Windows.Forms.CheckBox checkBox_defaultContractModel;
        private System.Windows.Forms.Label label_contractHourlyRateName;
        private System.Windows.Forms.ComboBox comboBox_contractHourlyRateName;
        private System.Windows.Forms.CheckBox checkBox_defaultContractIsFixedHourlyRate;
        private System.Windows.Forms.Label label_contractIsFixedHourlyRate;
        private System.Windows.Forms.ComboBox comboBox_contractIsFixedHourlyRate;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_contractRevenueExpensesAmount;
    }
}
