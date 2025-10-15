namespace TimeLog.DataImporter.UserControls
{
    partial class UserControl_TaskImport
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
            panel_taskDataTable = new System.Windows.Forms.Panel();
            dataGridView_task = new System.Windows.Forms.DataGridView();
            panel_projectMessage = new System.Windows.Forms.Panel();
            textBox_taskImportMessages = new System.Windows.Forms.TextBox();
            panel_taskButtons = new System.Windows.Forms.Panel();
            button_clear = new System.Windows.Forms.Button();
            button_import = new System.Windows.Forms.Button();
            button_validate = new System.Windows.Forms.Button();
            button_stop = new System.Windows.Forms.Button();
            panel_taskFieldMapping = new System.Windows.Forms.Panel();
            flowLayoutPanel_nonMandatoryFields = new System.Windows.Forms.FlowLayoutPanel();
            panel_NonMandatoryButton = new System.Windows.Forms.Panel();
            label_nonMandatoryFields = new System.Windows.Forms.Label();
            button_expandNonMandatory = new System.Windows.Forms.Button();
            panel_NonMandatoryFields = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            label_taskTDRProperties = new System.Windows.Forms.Label();
            label_paymentInvoiceDate = new System.Windows.Forms.Label();
            label_paymentName = new System.Windows.Forms.Label();
            checkBox_defaultAdditionalTextIsRequired = new System.Windows.Forms.CheckBox();
            label_paymentProductNo = new System.Windows.Forms.Label();
            comboBox_paymentInvoiceDate = new System.Windows.Forms.ComboBox();
            comboBox_paymentName = new System.Windows.Forms.ComboBox();
            comboBox_paymentProductNo = new System.Windows.Forms.ComboBox();
            comboBox_taskHourlyRate = new System.Windows.Forms.ComboBox();
            label_taskHourlyRate = new System.Windows.Forms.Label();
            checkBox_defaultPaymentRecognitionModel = new System.Windows.Forms.CheckBox();
            checkBox_defaultIsBillable = new System.Windows.Forms.CheckBox();
            label_paymentRecognitionModel = new System.Windows.Forms.Label();
            comboBox_budgetAmount = new System.Windows.Forms.ComboBox();
            comboBox_paymentRecognitionModel = new System.Windows.Forms.ComboBox();
            comboBox_paymentAmount = new System.Windows.Forms.ComboBox();
            label_isBillable = new System.Windows.Forms.Label();
            label_paymentAmount = new System.Windows.Forms.Label();
            label_budgetAmount = new System.Windows.Forms.Label();
            comboBox_isBillable = new System.Windows.Forms.ComboBox();
            label_taskNo = new System.Windows.Forms.Label();
            label_hourlyRate = new System.Windows.Forms.Label();
            comboBox_parentTaskNo = new System.Windows.Forms.ComboBox();
            label_parentTaskNo = new System.Windows.Forms.Label();
            comboBox_taskNo = new System.Windows.Forms.ComboBox();
            label_budgetHours = new System.Windows.Forms.Label();
            comboBox_budgetHours = new System.Windows.Forms.ComboBox();
            checkBox_defaultIsReadyForInvoicing = new System.Windows.Forms.CheckBox();
            label_isReadyForInvoicing = new System.Windows.Forms.Label();
            comboBox_description = new System.Windows.Forms.ComboBox();
            comboBox_isReadyForInvoicing = new System.Windows.Forms.ComboBox();
            label_description = new System.Windows.Forms.Label();
            label_additionalTextIsRequired = new System.Windows.Forms.Label();
            comboBox_additionalTextIsRequired = new System.Windows.Forms.ComboBox();
            comboBox_hourlyRate = new System.Windows.Forms.ComboBox();
            label_delimiter = new System.Windows.Forms.Label();
            comboBox_delimiter = new System.Windows.Forms.ComboBox();
            groupBox_taskMandatoryFields = new System.Windows.Forms.GroupBox();
            checkBox_defaultTaskType = new System.Windows.Forms.CheckBox();
            comboBox_contractName = new System.Windows.Forms.ComboBox();
            label_contractName = new System.Windows.Forms.Label();
            label_projectNo = new System.Windows.Forms.Label();
            comboBox_projectNo = new System.Windows.Forms.ComboBox();
            label_taskType = new System.Windows.Forms.Label();
            comboBox_taskType = new System.Windows.Forms.ComboBox();
            label_endDate = new System.Windows.Forms.Label();
            comboBox_endDate = new System.Windows.Forms.ComboBox();
            label_startDate = new System.Windows.Forms.Label();
            comboBox_startDate = new System.Windows.Forms.ComboBox();
            label_taskName = new System.Windows.Forms.Label();
            comboBox_taskName = new System.Windows.Forms.ComboBox();
            label_taskSetup = new System.Windows.Forms.Label();
            button_taskSelectFile = new System.Windows.Forms.Button();
            tmrExpand = new System.Windows.Forms.Timer(components);
            defaultToolTip = new System.Windows.Forms.ToolTip(components);
            panel_taskDataTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_task).BeginInit();
            panel_projectMessage.SuspendLayout();
            panel_taskButtons.SuspendLayout();
            panel_taskFieldMapping.SuspendLayout();
            flowLayoutPanel_nonMandatoryFields.SuspendLayout();
            panel_NonMandatoryButton.SuspendLayout();
            panel_NonMandatoryFields.SuspendLayout();
            panel1.SuspendLayout();
            groupBox_taskMandatoryFields.SuspendLayout();
            SuspendLayout();
            // 
            // WorkerFetcher
            // 
            WorkerFetcher.WorkerReportsProgress = true;
            WorkerFetcher.WorkerSupportsCancellation = true;
            WorkerFetcher.DoWork += WorkerFetcherDoWork;
            // 
            // panel_taskDataTable
            // 
            panel_taskDataTable.Controls.Add(dataGridView_task);
            panel_taskDataTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_taskDataTable.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel_taskDataTable.Location = new System.Drawing.Point(0, 462);
            panel_taskDataTable.Name = "panel_taskDataTable";
            panel_taskDataTable.Size = new System.Drawing.Size(1006, 180);
            panel_taskDataTable.TabIndex = 6;
            // 
            // dataGridView_task
            // 
            dataGridView_task.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridView_task.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridView_task.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_task.Dock = System.Windows.Forms.DockStyle.Bottom;
            dataGridView_task.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridView_task.Location = new System.Drawing.Point(0, 0);
            dataGridView_task.Name = "dataGridView_task";
            dataGridView_task.RowHeadersWidth = 62;
            dataGridView_task.Size = new System.Drawing.Size(1006, 180);
            dataGridView_task.TabIndex = 0;
            // 
            // panel_projectMessage
            // 
            panel_projectMessage.Controls.Add(textBox_taskImportMessages);
            panel_projectMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_projectMessage.Location = new System.Drawing.Point(0, 278);
            panel_projectMessage.Name = "panel_projectMessage";
            panel_projectMessage.Size = new System.Drawing.Size(1006, 184);
            panel_projectMessage.TabIndex = 10;
            // 
            // textBox_taskImportMessages
            // 
            textBox_taskImportMessages.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            textBox_taskImportMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox_taskImportMessages.Dock = System.Windows.Forms.DockStyle.Bottom;
            textBox_taskImportMessages.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            textBox_taskImportMessages.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            textBox_taskImportMessages.Location = new System.Drawing.Point(0, 0);
            textBox_taskImportMessages.Multiline = true;
            textBox_taskImportMessages.Name = "textBox_taskImportMessages";
            textBox_taskImportMessages.ReadOnly = true;
            textBox_taskImportMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBox_taskImportMessages.Size = new System.Drawing.Size(1006, 184);
            textBox_taskImportMessages.TabIndex = 0;
            defaultToolTip.SetToolTip(textBox_taskImportMessages, "Validation or import status");
            textBox_taskImportMessages.WordWrap = false;
            textBox_taskImportMessages.MouseClick += textBox_taskImportMessages_MouseClick;
            // 
            // panel_taskButtons
            // 
            panel_taskButtons.Controls.Add(button_clear);
            panel_taskButtons.Controls.Add(button_import);
            panel_taskButtons.Controls.Add(button_validate);
            panel_taskButtons.Controls.Add(button_stop);
            panel_taskButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_taskButtons.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            panel_taskButtons.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel_taskButtons.Location = new System.Drawing.Point(0, 226);
            panel_taskButtons.Name = "panel_taskButtons";
            panel_taskButtons.Size = new System.Drawing.Size(1006, 52);
            panel_taskButtons.TabIndex = 12;
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
            // panel_taskFieldMapping
            // 
            panel_taskFieldMapping.AutoScroll = true;
            panel_taskFieldMapping.Controls.Add(flowLayoutPanel_nonMandatoryFields);
            panel_taskFieldMapping.Controls.Add(label_delimiter);
            panel_taskFieldMapping.Controls.Add(comboBox_delimiter);
            panel_taskFieldMapping.Controls.Add(groupBox_taskMandatoryFields);
            panel_taskFieldMapping.Controls.Add(label_taskSetup);
            panel_taskFieldMapping.Controls.Add(button_taskSelectFile);
            panel_taskFieldMapping.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_taskFieldMapping.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            panel_taskFieldMapping.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel_taskFieldMapping.Location = new System.Drawing.Point(0, 0);
            panel_taskFieldMapping.Name = "panel_taskFieldMapping";
            panel_taskFieldMapping.Size = new System.Drawing.Size(1006, 226);
            panel_taskFieldMapping.TabIndex = 13;
            // 
            // flowLayoutPanel_nonMandatoryFields
            // 
            flowLayoutPanel_nonMandatoryFields.Controls.Add(panel_NonMandatoryButton);
            flowLayoutPanel_nonMandatoryFields.Controls.Add(panel_NonMandatoryFields);
            flowLayoutPanel_nonMandatoryFields.Location = new System.Drawing.Point(526, 60);
            flowLayoutPanel_nonMandatoryFields.Name = "flowLayoutPanel_nonMandatoryFields";
            flowLayoutPanel_nonMandatoryFields.Size = new System.Drawing.Size(447, 571);
            flowLayoutPanel_nonMandatoryFields.TabIndex = 7;
            // 
            // panel_NonMandatoryButton
            // 
            panel_NonMandatoryButton.Controls.Add(label_nonMandatoryFields);
            panel_NonMandatoryButton.Controls.Add(button_expandNonMandatory);
            panel_NonMandatoryButton.Location = new System.Drawing.Point(3, 3);
            panel_NonMandatoryButton.Name = "panel_NonMandatoryButton";
            panel_NonMandatoryButton.Size = new System.Drawing.Size(440, 32);
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
            panel_NonMandatoryFields.Controls.Add(panel1);
            panel_NonMandatoryFields.Controls.Add(label_paymentInvoiceDate);
            panel_NonMandatoryFields.Controls.Add(label_paymentName);
            panel_NonMandatoryFields.Controls.Add(checkBox_defaultAdditionalTextIsRequired);
            panel_NonMandatoryFields.Controls.Add(label_paymentProductNo);
            panel_NonMandatoryFields.Controls.Add(comboBox_paymentInvoiceDate);
            panel_NonMandatoryFields.Controls.Add(comboBox_paymentName);
            panel_NonMandatoryFields.Controls.Add(comboBox_paymentProductNo);
            panel_NonMandatoryFields.Controls.Add(comboBox_taskHourlyRate);
            panel_NonMandatoryFields.Controls.Add(label_taskHourlyRate);
            panel_NonMandatoryFields.Controls.Add(checkBox_defaultPaymentRecognitionModel);
            panel_NonMandatoryFields.Controls.Add(checkBox_defaultIsBillable);
            panel_NonMandatoryFields.Controls.Add(label_paymentRecognitionModel);
            panel_NonMandatoryFields.Controls.Add(comboBox_budgetAmount);
            panel_NonMandatoryFields.Controls.Add(comboBox_paymentRecognitionModel);
            panel_NonMandatoryFields.Controls.Add(comboBox_paymentAmount);
            panel_NonMandatoryFields.Controls.Add(label_isBillable);
            panel_NonMandatoryFields.Controls.Add(label_paymentAmount);
            panel_NonMandatoryFields.Controls.Add(label_budgetAmount);
            panel_NonMandatoryFields.Controls.Add(comboBox_isBillable);
            panel_NonMandatoryFields.Controls.Add(label_taskNo);
            panel_NonMandatoryFields.Controls.Add(label_hourlyRate);
            panel_NonMandatoryFields.Controls.Add(comboBox_parentTaskNo);
            panel_NonMandatoryFields.Controls.Add(label_parentTaskNo);
            panel_NonMandatoryFields.Controls.Add(comboBox_taskNo);
            panel_NonMandatoryFields.Controls.Add(label_budgetHours);
            panel_NonMandatoryFields.Controls.Add(comboBox_budgetHours);
            panel_NonMandatoryFields.Controls.Add(checkBox_defaultIsReadyForInvoicing);
            panel_NonMandatoryFields.Controls.Add(label_isReadyForInvoicing);
            panel_NonMandatoryFields.Controls.Add(comboBox_description);
            panel_NonMandatoryFields.Controls.Add(comboBox_isReadyForInvoicing);
            panel_NonMandatoryFields.Controls.Add(label_description);
            panel_NonMandatoryFields.Controls.Add(label_additionalTextIsRequired);
            panel_NonMandatoryFields.Controls.Add(comboBox_additionalTextIsRequired);
            panel_NonMandatoryFields.Controls.Add(comboBox_hourlyRate);
            panel_NonMandatoryFields.Location = new System.Drawing.Point(3, 41);
            panel_NonMandatoryFields.MaximumSize = new System.Drawing.Size(440, 570);
            panel_NonMandatoryFields.MinimumSize = new System.Drawing.Size(382, 0);
            panel_NonMandatoryFields.Name = "panel_NonMandatoryFields";
            panel_NonMandatoryFields.Size = new System.Drawing.Size(440, 530);
            panel_NonMandatoryFields.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label_taskTDRProperties);
            panel1.Location = new System.Drawing.Point(0, 310);
            panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(440, 28);
            panel1.TabIndex = 19;
            // 
            // label_taskTDRProperties
            // 
            label_taskTDRProperties.AutoSize = true;
            label_taskTDRProperties.Location = new System.Drawing.Point(10, 5);
            label_taskTDRProperties.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label_taskTDRProperties.Name = "label_taskTDRProperties";
            label_taskTDRProperties.Size = new System.Drawing.Size(154, 17);
            label_taskTDRProperties.TabIndex = 0;
            label_taskTDRProperties.Text = "Properties for TDR tasks";
            // 
            // label_paymentInvoiceDate
            // 
            label_paymentInvoiceDate.AutoSize = true;
            label_paymentInvoiceDate.Location = new System.Drawing.Point(10, 496);
            label_paymentInvoiceDate.Name = "label_paymentInvoiceDate";
            label_paymentInvoiceDate.Size = new System.Drawing.Size(141, 17);
            label_paymentInvoiceDate.TabIndex = 1;
            label_paymentInvoiceDate.Text = "Payment Invoice Date";
            // 
            // label_paymentName
            // 
            label_paymentName.AutoSize = true;
            label_paymentName.Location = new System.Drawing.Point(10, 465);
            label_paymentName.Name = "label_paymentName";
            label_paymentName.Size = new System.Drawing.Size(102, 17);
            label_paymentName.TabIndex = 1;
            label_paymentName.Text = "Payment Name";
            // 
            // checkBox_defaultAdditionalTextIsRequired
            // 
            checkBox_defaultAdditionalTextIsRequired.AutoSize = true;
            checkBox_defaultAdditionalTextIsRequired.Location = new System.Drawing.Point(362, 71);
            checkBox_defaultAdditionalTextIsRequired.Name = "checkBox_defaultAdditionalTextIsRequired";
            checkBox_defaultAdditionalTextIsRequired.Size = new System.Drawing.Size(70, 21);
            checkBox_defaultAdditionalTextIsRequired.TabIndex = 4;
            checkBox_defaultAdditionalTextIsRequired.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultAdditionalTextIsRequired, "Set default values for all rows of a particular column field");
            checkBox_defaultAdditionalTextIsRequired.UseVisualStyleBackColor = true;
            checkBox_defaultAdditionalTextIsRequired.CheckedChanged += checkBox_defaultAdditionalTextIsRequired_CheckedChanged;
            // 
            // label_paymentProductNo
            // 
            label_paymentProductNo.AutoSize = true;
            label_paymentProductNo.Location = new System.Drawing.Point(10, 434);
            label_paymentProductNo.Name = "label_paymentProductNo";
            label_paymentProductNo.Size = new System.Drawing.Size(136, 17);
            label_paymentProductNo.TabIndex = 1;
            label_paymentProductNo.Text = "Payment Product No";
            // 
            // comboBox_paymentInvoiceDate
            // 
            comboBox_paymentInvoiceDate.FormattingEnabled = true;
            comboBox_paymentInvoiceDate.Location = new System.Drawing.Point(196, 493);
            comboBox_paymentInvoiceDate.Name = "comboBox_paymentInvoiceDate";
            comboBox_paymentInvoiceDate.Size = new System.Drawing.Size(160, 25);
            comboBox_paymentInvoiceDate.TabIndex = 18;
            // 
            // comboBox_paymentName
            // 
            comboBox_paymentName.FormattingEnabled = true;
            comboBox_paymentName.Location = new System.Drawing.Point(196, 462);
            comboBox_paymentName.Name = "comboBox_paymentName";
            comboBox_paymentName.Size = new System.Drawing.Size(160, 25);
            comboBox_paymentName.TabIndex = 17;
            // 
            // comboBox_paymentProductNo
            // 
            comboBox_paymentProductNo.FormattingEnabled = true;
            comboBox_paymentProductNo.Location = new System.Drawing.Point(196, 431);
            comboBox_paymentProductNo.Name = "comboBox_paymentProductNo";
            comboBox_paymentProductNo.Size = new System.Drawing.Size(160, 25);
            comboBox_paymentProductNo.TabIndex = 16;
            // 
            // comboBox_taskHourlyRate
            // 
            comboBox_taskHourlyRate.FormattingEnabled = true;
            comboBox_taskHourlyRate.Location = new System.Drawing.Point(196, 400);
            comboBox_taskHourlyRate.Name = "comboBox_taskHourlyRate";
            comboBox_taskHourlyRate.Size = new System.Drawing.Size(160, 25);
            comboBox_taskHourlyRate.TabIndex = 15;
            // 
            // label_taskHourlyRate
            // 
            label_taskHourlyRate.AutoSize = true;
            label_taskHourlyRate.Location = new System.Drawing.Point(10, 403);
            label_taskHourlyRate.Name = "label_taskHourlyRate";
            label_taskHourlyRate.Size = new System.Drawing.Size(110, 17);
            label_taskHourlyRate.TabIndex = 1;
            label_taskHourlyRate.Text = "Task Hourly Rate";
            // 
            // checkBox_defaultPaymentRecognitionModel
            // 
            checkBox_defaultPaymentRecognitionModel.AutoSize = true;
            checkBox_defaultPaymentRecognitionModel.Location = new System.Drawing.Point(362, 340);
            checkBox_defaultPaymentRecognitionModel.Name = "checkBox_defaultPaymentRecognitionModel";
            checkBox_defaultPaymentRecognitionModel.Size = new System.Drawing.Size(70, 21);
            checkBox_defaultPaymentRecognitionModel.TabIndex = 12;
            checkBox_defaultPaymentRecognitionModel.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultPaymentRecognitionModel, "Set default values for all rows of a particular column field");
            checkBox_defaultPaymentRecognitionModel.UseVisualStyleBackColor = true;
            checkBox_defaultPaymentRecognitionModel.CheckedChanged += checkBox_defaultPaymentRecognitionModel_CheckedChanged;
            // 
            // checkBox_defaultIsBillable
            // 
            checkBox_defaultIsBillable.AutoSize = true;
            checkBox_defaultIsBillable.Location = new System.Drawing.Point(362, 257);
            checkBox_defaultIsBillable.Name = "checkBox_defaultIsBillable";
            checkBox_defaultIsBillable.Size = new System.Drawing.Size(70, 21);
            checkBox_defaultIsBillable.TabIndex = 14;
            checkBox_defaultIsBillable.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultIsBillable, "Set default values for all rows of a particular column field");
            checkBox_defaultIsBillable.UseVisualStyleBackColor = true;
            checkBox_defaultIsBillable.CheckedChanged += checkBox_defaultIsBillable_CheckedChanged;
            // 
            // label_paymentRecognitionModel
            // 
            label_paymentRecognitionModel.AutoSize = true;
            label_paymentRecognitionModel.Location = new System.Drawing.Point(10, 341);
            label_paymentRecognitionModel.Name = "label_paymentRecognitionModel";
            label_paymentRecognitionModel.Size = new System.Drawing.Size(180, 17);
            label_paymentRecognitionModel.TabIndex = 1;
            label_paymentRecognitionModel.Text = "Payment Recognition Model";
            // 
            // comboBox_budgetAmount
            // 
            comboBox_budgetAmount.FormattingEnabled = true;
            comboBox_budgetAmount.Location = new System.Drawing.Point(196, 131);
            comboBox_budgetAmount.Name = "comboBox_budgetAmount";
            comboBox_budgetAmount.Size = new System.Drawing.Size(160, 25);
            comboBox_budgetAmount.TabIndex = 10;
            // 
            // comboBox_paymentRecognitionModel
            // 
            comboBox_paymentRecognitionModel.FormattingEnabled = true;
            comboBox_paymentRecognitionModel.Location = new System.Drawing.Point(196, 338);
            comboBox_paymentRecognitionModel.Name = "comboBox_paymentRecognitionModel";
            comboBox_paymentRecognitionModel.Size = new System.Drawing.Size(160, 25);
            comboBox_paymentRecognitionModel.TabIndex = 9;
            // 
            // comboBox_paymentAmount
            // 
            comboBox_paymentAmount.FormattingEnabled = true;
            comboBox_paymentAmount.Location = new System.Drawing.Point(196, 369);
            comboBox_paymentAmount.Name = "comboBox_paymentAmount";
            comboBox_paymentAmount.Size = new System.Drawing.Size(160, 25);
            comboBox_paymentAmount.TabIndex = 3;
            // 
            // label_isBillable
            // 
            label_isBillable.AutoSize = true;
            label_isBillable.Location = new System.Drawing.Point(10, 258);
            label_isBillable.Name = "label_isBillable";
            label_isBillable.Size = new System.Drawing.Size(64, 17);
            label_isBillable.TabIndex = 1;
            label_isBillable.Text = "Is Billable";
            // 
            // label_paymentAmount
            // 
            label_paymentAmount.AutoSize = true;
            label_paymentAmount.Location = new System.Drawing.Point(10, 372);
            label_paymentAmount.Name = "label_paymentAmount";
            label_paymentAmount.Size = new System.Drawing.Size(116, 17);
            label_paymentAmount.TabIndex = 1;
            label_paymentAmount.Text = "Payment Amount";
            // 
            // label_budgetAmount
            // 
            label_budgetAmount.AutoSize = true;
            label_budgetAmount.Location = new System.Drawing.Point(10, 134);
            label_budgetAmount.Name = "label_budgetAmount";
            label_budgetAmount.Size = new System.Drawing.Size(106, 17);
            label_budgetAmount.TabIndex = 1;
            label_budgetAmount.Text = "Budget Amount";
            // 
            // comboBox_isBillable
            // 
            comboBox_isBillable.FormattingEnabled = true;
            comboBox_isBillable.Location = new System.Drawing.Point(196, 255);
            comboBox_isBillable.Name = "comboBox_isBillable";
            comboBox_isBillable.Size = new System.Drawing.Size(160, 25);
            comboBox_isBillable.TabIndex = 8;
            // 
            // label_taskNo
            // 
            label_taskNo.AutoSize = true;
            label_taskNo.Location = new System.Drawing.Point(10, 10);
            label_taskNo.Name = "label_taskNo";
            label_taskNo.Size = new System.Drawing.Size(56, 17);
            label_taskNo.TabIndex = 1;
            label_taskNo.Text = "Task No";
            // 
            // label_hourlyRate
            // 
            label_hourlyRate.AutoSize = true;
            label_hourlyRate.Location = new System.Drawing.Point(10, 196);
            label_hourlyRate.Name = "label_hourlyRate";
            label_hourlyRate.Size = new System.Drawing.Size(80, 17);
            label_hourlyRate.TabIndex = 1;
            label_hourlyRate.Text = "Hourly Rate";
            defaultToolTip.SetToolTip(label_hourlyRate, "In expense currency");
            // 
            // comboBox_parentTaskNo
            // 
            comboBox_parentTaskNo.FormattingEnabled = true;
            comboBox_parentTaskNo.Location = new System.Drawing.Point(196, 224);
            comboBox_parentTaskNo.Name = "comboBox_parentTaskNo";
            comboBox_parentTaskNo.Size = new System.Drawing.Size(160, 25);
            comboBox_parentTaskNo.TabIndex = 7;
            // 
            // label_parentTaskNo
            // 
            label_parentTaskNo.AutoSize = true;
            label_parentTaskNo.Location = new System.Drawing.Point(10, 227);
            label_parentTaskNo.Name = "label_parentTaskNo";
            label_parentTaskNo.Size = new System.Drawing.Size(100, 17);
            label_parentTaskNo.TabIndex = 1;
            label_parentTaskNo.Text = "Parent Task No";
            // 
            // comboBox_taskNo
            // 
            comboBox_taskNo.FormattingEnabled = true;
            comboBox_taskNo.Location = new System.Drawing.Point(196, 7);
            comboBox_taskNo.Name = "comboBox_taskNo";
            comboBox_taskNo.Size = new System.Drawing.Size(160, 25);
            comboBox_taskNo.TabIndex = 3;
            // 
            // label_budgetHours
            // 
            label_budgetHours.AutoSize = true;
            label_budgetHours.Location = new System.Drawing.Point(10, 103);
            label_budgetHours.Name = "label_budgetHours";
            label_budgetHours.Size = new System.Drawing.Size(93, 17);
            label_budgetHours.TabIndex = 1;
            label_budgetHours.Text = "Budget Hours";
            // 
            // comboBox_budgetHours
            // 
            comboBox_budgetHours.FormattingEnabled = true;
            comboBox_budgetHours.Location = new System.Drawing.Point(196, 100);
            comboBox_budgetHours.Name = "comboBox_budgetHours";
            comboBox_budgetHours.Size = new System.Drawing.Size(160, 25);
            comboBox_budgetHours.TabIndex = 3;
            // 
            // checkBox_defaultIsReadyForInvoicing
            // 
            checkBox_defaultIsReadyForInvoicing.AutoSize = true;
            checkBox_defaultIsReadyForInvoicing.Location = new System.Drawing.Point(362, 164);
            checkBox_defaultIsReadyForInvoicing.Name = "checkBox_defaultIsReadyForInvoicing";
            checkBox_defaultIsReadyForInvoicing.Size = new System.Drawing.Size(70, 21);
            checkBox_defaultIsReadyForInvoicing.TabIndex = 6;
            checkBox_defaultIsReadyForInvoicing.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultIsReadyForInvoicing, "Set default values for all rows of a particular column field");
            checkBox_defaultIsReadyForInvoicing.UseVisualStyleBackColor = true;
            checkBox_defaultIsReadyForInvoicing.CheckedChanged += checkBox_defaultIsReadyForInvoicing_CheckedChanged;
            // 
            // label_isReadyForInvoicing
            // 
            label_isReadyForInvoicing.AutoSize = true;
            label_isReadyForInvoicing.Location = new System.Drawing.Point(10, 165);
            label_isReadyForInvoicing.Name = "label_isReadyForInvoicing";
            label_isReadyForInvoicing.Size = new System.Drawing.Size(142, 17);
            label_isReadyForInvoicing.TabIndex = 1;
            label_isReadyForInvoicing.Text = "Is Ready For Invoicing";
            // 
            // comboBox_description
            // 
            comboBox_description.FormattingEnabled = true;
            comboBox_description.Location = new System.Drawing.Point(196, 38);
            comboBox_description.Name = "comboBox_description";
            comboBox_description.Size = new System.Drawing.Size(160, 25);
            comboBox_description.TabIndex = 3;
            // 
            // comboBox_isReadyForInvoicing
            // 
            comboBox_isReadyForInvoicing.FormattingEnabled = true;
            comboBox_isReadyForInvoicing.Location = new System.Drawing.Point(196, 162);
            comboBox_isReadyForInvoicing.Name = "comboBox_isReadyForInvoicing";
            comboBox_isReadyForInvoicing.Size = new System.Drawing.Size(160, 25);
            comboBox_isReadyForInvoicing.TabIndex = 3;
            // 
            // label_description
            // 
            label_description.AutoSize = true;
            label_description.Location = new System.Drawing.Point(10, 41);
            label_description.Name = "label_description";
            label_description.Size = new System.Drawing.Size(76, 17);
            label_description.TabIndex = 1;
            label_description.Text = "Description";
            // 
            // label_additionalTextIsRequired
            // 
            label_additionalTextIsRequired.AutoSize = true;
            label_additionalTextIsRequired.Location = new System.Drawing.Point(10, 72);
            label_additionalTextIsRequired.Name = "label_additionalTextIsRequired";
            label_additionalTextIsRequired.Size = new System.Drawing.Size(137, 17);
            label_additionalTextIsRequired.TabIndex = 1;
            label_additionalTextIsRequired.Text = "Add. Text Is Required";
            // 
            // comboBox_additionalTextIsRequired
            // 
            comboBox_additionalTextIsRequired.FormattingEnabled = true;
            comboBox_additionalTextIsRequired.Location = new System.Drawing.Point(196, 69);
            comboBox_additionalTextIsRequired.Name = "comboBox_additionalTextIsRequired";
            comboBox_additionalTextIsRequired.Size = new System.Drawing.Size(160, 25);
            comboBox_additionalTextIsRequired.TabIndex = 3;
            // 
            // comboBox_hourlyRate
            // 
            comboBox_hourlyRate.FormattingEnabled = true;
            comboBox_hourlyRate.Location = new System.Drawing.Point(196, 193);
            comboBox_hourlyRate.Name = "comboBox_hourlyRate";
            comboBox_hourlyRate.Size = new System.Drawing.Size(160, 25);
            comboBox_hourlyRate.TabIndex = 3;
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
            // groupBox_taskMandatoryFields
            // 
            groupBox_taskMandatoryFields.Controls.Add(checkBox_defaultTaskType);
            groupBox_taskMandatoryFields.Controls.Add(comboBox_contractName);
            groupBox_taskMandatoryFields.Controls.Add(label_contractName);
            groupBox_taskMandatoryFields.Controls.Add(label_projectNo);
            groupBox_taskMandatoryFields.Controls.Add(comboBox_projectNo);
            groupBox_taskMandatoryFields.Controls.Add(label_taskType);
            groupBox_taskMandatoryFields.Controls.Add(comboBox_taskType);
            groupBox_taskMandatoryFields.Controls.Add(label_endDate);
            groupBox_taskMandatoryFields.Controls.Add(comboBox_endDate);
            groupBox_taskMandatoryFields.Controls.Add(label_startDate);
            groupBox_taskMandatoryFields.Controls.Add(comboBox_startDate);
            groupBox_taskMandatoryFields.Controls.Add(label_taskName);
            groupBox_taskMandatoryFields.Controls.Add(comboBox_taskName);
            groupBox_taskMandatoryFields.Location = new System.Drawing.Point(149, 62);
            groupBox_taskMandatoryFields.Name = "groupBox_taskMandatoryFields";
            groupBox_taskMandatoryFields.Size = new System.Drawing.Size(366, 221);
            groupBox_taskMandatoryFields.TabIndex = 5;
            groupBox_taskMandatoryFields.TabStop = false;
            groupBox_taskMandatoryFields.Text = "Mandatory";
            // 
            // checkBox_defaultTaskType
            // 
            checkBox_defaultTaskType.AutoSize = true;
            checkBox_defaultTaskType.Location = new System.Drawing.Point(295, 150);
            checkBox_defaultTaskType.Name = "checkBox_defaultTaskType";
            checkBox_defaultTaskType.Size = new System.Drawing.Size(70, 21);
            checkBox_defaultTaskType.TabIndex = 11;
            checkBox_defaultTaskType.Text = "Default";
            checkBox_defaultTaskType.UseVisualStyleBackColor = true;
            checkBox_defaultTaskType.CheckedChanged += checkBox_defaultTaskType_CheckedChanged;
            // 
            // comboBox_contractName
            // 
            comboBox_contractName.FormattingEnabled = true;
            comboBox_contractName.Location = new System.Drawing.Point(135, 117);
            comboBox_contractName.Name = "comboBox_contractName";
            comboBox_contractName.Size = new System.Drawing.Size(154, 25);
            comboBox_contractName.TabIndex = 10;
            // 
            // label_contractName
            // 
            label_contractName.AutoSize = true;
            label_contractName.Location = new System.Drawing.Point(6, 120);
            label_contractName.Name = "label_contractName";
            label_contractName.Size = new System.Drawing.Size(100, 17);
            label_contractName.TabIndex = 1;
            label_contractName.Text = "Contract Name";
            // 
            // label_projectNo
            // 
            label_projectNo.AutoSize = true;
            label_projectNo.Location = new System.Drawing.Point(6, 182);
            label_projectNo.Name = "label_projectNo";
            label_projectNo.Size = new System.Drawing.Size(72, 17);
            label_projectNo.TabIndex = 1;
            label_projectNo.Text = "Project No";
            defaultToolTip.SetToolTip(label_projectNo, "In project currency");
            // 
            // comboBox_projectNo
            // 
            comboBox_projectNo.FormattingEnabled = true;
            comboBox_projectNo.Location = new System.Drawing.Point(135, 179);
            comboBox_projectNo.Name = "comboBox_projectNo";
            comboBox_projectNo.Size = new System.Drawing.Size(154, 25);
            comboBox_projectNo.TabIndex = 3;
            // 
            // label_taskType
            // 
            label_taskType.AutoSize = true;
            label_taskType.Location = new System.Drawing.Point(6, 151);
            label_taskType.Name = "label_taskType";
            label_taskType.Size = new System.Drawing.Size(66, 17);
            label_taskType.TabIndex = 1;
            label_taskType.Text = "Task Type";
            defaultToolTip.SetToolTip(label_taskType, "In expense currency");
            // 
            // comboBox_taskType
            // 
            comboBox_taskType.FormattingEnabled = true;
            comboBox_taskType.Location = new System.Drawing.Point(135, 148);
            comboBox_taskType.Name = "comboBox_taskType";
            comboBox_taskType.Size = new System.Drawing.Size(154, 25);
            comboBox_taskType.TabIndex = 3;
            // 
            // label_endDate
            // 
            label_endDate.AutoSize = true;
            label_endDate.Location = new System.Drawing.Point(6, 89);
            label_endDate.Name = "label_endDate";
            label_endDate.Size = new System.Drawing.Size(63, 17);
            label_endDate.TabIndex = 1;
            label_endDate.Text = "End Date";
            // 
            // comboBox_endDate
            // 
            comboBox_endDate.FormattingEnabled = true;
            comboBox_endDate.Location = new System.Drawing.Point(135, 86);
            comboBox_endDate.Name = "comboBox_endDate";
            comboBox_endDate.Size = new System.Drawing.Size(154, 25);
            comboBox_endDate.TabIndex = 3;
            // 
            // label_startDate
            // 
            label_startDate.AutoSize = true;
            label_startDate.Location = new System.Drawing.Point(6, 58);
            label_startDate.Name = "label_startDate";
            label_startDate.Size = new System.Drawing.Size(69, 17);
            label_startDate.TabIndex = 1;
            label_startDate.Text = "Start Date";
            // 
            // comboBox_startDate
            // 
            comboBox_startDate.FormattingEnabled = true;
            comboBox_startDate.Location = new System.Drawing.Point(135, 55);
            comboBox_startDate.Name = "comboBox_startDate";
            comboBox_startDate.Size = new System.Drawing.Size(154, 25);
            comboBox_startDate.TabIndex = 3;
            // 
            // label_taskName
            // 
            label_taskName.AutoSize = true;
            label_taskName.Location = new System.Drawing.Point(6, 27);
            label_taskName.Name = "label_taskName";
            label_taskName.Size = new System.Drawing.Size(74, 17);
            label_taskName.TabIndex = 1;
            label_taskName.Text = "Task Name";
            // 
            // comboBox_taskName
            // 
            comboBox_taskName.FormattingEnabled = true;
            comboBox_taskName.Location = new System.Drawing.Point(135, 24);
            comboBox_taskName.Name = "comboBox_taskName";
            comboBox_taskName.Size = new System.Drawing.Size(154, 25);
            comboBox_taskName.TabIndex = 3;
            // 
            // label_taskSetup
            // 
            label_taskSetup.AutoSize = true;
            label_taskSetup.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            label_taskSetup.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            label_taskSetup.Location = new System.Drawing.Point(7, 16);
            label_taskSetup.Name = "label_taskSetup";
            label_taskSetup.Size = new System.Drawing.Size(202, 32);
            label_taskSetup.TabIndex = 0;
            label_taskSetup.Text = "Task Data Import";
            // 
            // button_taskSelectFile
            // 
            button_taskSelectFile.BackColor = System.Drawing.Color.FromArgb(226, 43, 141);
            button_taskSelectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            button_taskSelectFile.FlatAppearance.BorderSize = 0;
            button_taskSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_taskSelectFile.ForeColor = System.Drawing.Color.White;
            button_taskSelectFile.Location = new System.Drawing.Point(13, 111);
            button_taskSelectFile.Name = "button_taskSelectFile";
            button_taskSelectFile.Size = new System.Drawing.Size(80, 29);
            button_taskSelectFile.TabIndex = 4;
            button_taskSelectFile.Text = "Select File";
            defaultToolTip.SetToolTip(button_taskSelectFile, "Select input CSV file");
            button_taskSelectFile.UseVisualStyleBackColor = false;
            button_taskSelectFile.Click += button_select_task_file_Click;
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
            // UserControl_TaskImport
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel_taskFieldMapping);
            Controls.Add(panel_taskButtons);
            Controls.Add(panel_projectMessage);
            Controls.Add(panel_taskDataTable);
            Name = "UserControl_TaskImport";
            Size = new System.Drawing.Size(1006, 642);
            Load += UserControl1_Load;
            panel_taskDataTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_task).EndInit();
            panel_projectMessage.ResumeLayout(false);
            panel_projectMessage.PerformLayout();
            panel_taskButtons.ResumeLayout(false);
            panel_taskFieldMapping.ResumeLayout(false);
            panel_taskFieldMapping.PerformLayout();
            flowLayoutPanel_nonMandatoryFields.ResumeLayout(false);
            panel_NonMandatoryButton.ResumeLayout(false);
            panel_NonMandatoryButton.PerformLayout();
            panel_NonMandatoryFields.ResumeLayout(false);
            panel_NonMandatoryFields.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox_taskMandatoryFields.ResumeLayout(false);
            groupBox_taskMandatoryFields.PerformLayout();
            ResumeLayout(false);

        }

        #endregion


        private void AddRowNumberToDataTable()
        {
            this.dataGridView_task.DataBindingComplete += (o, e) =>
            {
                foreach (System.Windows.Forms.DataGridViewRow row in dataGridView_task.Rows)
                {
                    row.HeaderCell.Value = (row.Index + 1).ToString();

                }
            };
            this.dataGridView_task.RowHeadersWidth = 65;
        }


        private System.ComponentModel.BackgroundWorker WorkerFetcher;
        private System.Windows.Forms.Panel panel_taskDataTable;
        private System.Windows.Forms.DataGridView dataGridView_task;
        private System.Windows.Forms.Panel panel_projectMessage;
        private System.Windows.Forms.Panel panel_taskButtons;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_import;
        private System.Windows.Forms.Button button_validate;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Panel panel_taskFieldMapping;
        private System.Windows.Forms.GroupBox groupBox_taskMandatoryFields;
        private System.Windows.Forms.ComboBox comboBox_taskName;
        private System.Windows.Forms.Label label_taskName;
        private System.Windows.Forms.Label label_taskSetup;
        private System.Windows.Forms.Button button_taskSelectFile;
        private System.Windows.Forms.TextBox textBox_taskImportMessages;
        private System.Windows.Forms.Label label_endDate;
        private System.Windows.Forms.ComboBox comboBox_endDate;
        private System.Windows.Forms.Label label_startDate;
        private System.Windows.Forms.ComboBox comboBox_startDate;
        private System.Windows.Forms.Label label_projectNo;
        private System.Windows.Forms.ComboBox comboBox_projectNo;
        private System.Windows.Forms.Label label_taskType;
        private System.Windows.Forms.ComboBox comboBox_taskType;
        private System.Windows.Forms.Label label_isReadyForInvoicing;
        private System.Windows.Forms.ComboBox comboBox_isReadyForInvoicing;
        private System.Windows.Forms.Label label_delimiter;
        private System.Windows.Forms.ComboBox comboBox_delimiter;
        private System.Windows.Forms.Label label_budgetHours;
        private System.Windows.Forms.ComboBox comboBox_budgetHours;
        private System.Windows.Forms.Label label_isBillable;
        private System.Windows.Forms.ComboBox comboBox_hourlyRate;
        private System.Windows.Forms.Label label_additionalTextIsRequired;
        private System.Windows.Forms.ComboBox comboBox_additionalTextIsRequired;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.ComboBox comboBox_description;
        private System.Windows.Forms.Label label_paymentAmount;
        private System.Windows.Forms.ComboBox comboBox_paymentAmount;
        private System.Windows.Forms.Label label_taskNo;
        private System.Windows.Forms.ComboBox comboBox_taskNo;
        private System.Windows.Forms.CheckBox checkBox_defaultAdditionalTextIsRequired;
        private System.Windows.Forms.CheckBox checkBox_defaultIsReadyForInvoicing;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_nonMandatoryFields;
        private System.Windows.Forms.Panel panel_NonMandatoryButton;
        private System.Windows.Forms.Panel panel_NonMandatoryFields;
        private System.Windows.Forms.Label label_nonMandatoryFields;
        private System.Windows.Forms.Button button_expandNonMandatory;
        private System.Windows.Forms.Timer tmrExpand;
        private System.Windows.Forms.ToolTip defaultToolTip;
        private System.Windows.Forms.Label label_paymentRecognitionModel;
        private System.Windows.Forms.Label label_hourlyRate;
        private System.Windows.Forms.Label label_parentTaskNo;
        private System.Windows.Forms.ComboBox comboBox_contractName;
        private System.Windows.Forms.ComboBox comboBox_paymentRecognitionModel;
        private System.Windows.Forms.ComboBox comboBox_isBillable;
        private System.Windows.Forms.ComboBox comboBox_parentTaskNo;
        private System.Windows.Forms.Label label_contractName;
        private System.Windows.Forms.Label label_budgetAmount;
        private System.Windows.Forms.ComboBox comboBox_budgetAmount;
        private System.Windows.Forms.CheckBox checkBox_defaultPaymentRecognitionModel;
        private System.Windows.Forms.CheckBox checkBox_defaultIsBillable;
        private System.Windows.Forms.Label label_taskHourlyRate;
        private System.Windows.Forms.ComboBox comboBox_paymentInvoiceDate;
        private System.Windows.Forms.ComboBox comboBox_paymentName;
        private System.Windows.Forms.ComboBox comboBox_paymentProductNo;
        private System.Windows.Forms.ComboBox comboBox_taskHourlyRate;
        private System.Windows.Forms.Label label_paymentInvoiceDate;
        private System.Windows.Forms.Label label_paymentName;
        private System.Windows.Forms.Label label_paymentProductNo;
        private System.Windows.Forms.CheckBox checkBox_defaultTaskType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_taskTDRProperties;
    }
}
