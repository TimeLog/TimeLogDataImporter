namespace TimeLog.DataImporter.UserControls
{
    partial class UserControl_TimeregistrationImport
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
            panel_timeregistrationDataTable = new System.Windows.Forms.Panel();
            dataGridView_timeregistration = new System.Windows.Forms.DataGridView();
            panel_timeregistrationMessage = new System.Windows.Forms.Panel();
            textBox_timeregistrationImportMessages = new System.Windows.Forms.TextBox();
            panel_timeregistrationButtons = new System.Windows.Forms.Panel();
            button_clear = new System.Windows.Forms.Button();
            button_import = new System.Windows.Forms.Button();
            button_validate = new System.Windows.Forms.Button();
            button_stop = new System.Windows.Forms.Button();
            panel_timeregistrationFieldMapping = new System.Windows.Forms.Panel();
            flowLayoutPanel_nonMandatoryFields = new System.Windows.Forms.FlowLayoutPanel();
            panel_NonMandatoryButton = new System.Windows.Forms.Panel();
            label_nonMandatoryFields = new System.Windows.Forms.Label();
            button_expandNonMandatory = new System.Windows.Forms.Button();
            panel_NonMandatoryFields = new System.Windows.Forms.Panel();
            label_timeregistrationComment = new System.Windows.Forms.Label();
            comboBox_timeregistrationComment = new System.Windows.Forms.ComboBox();
            comboBox_timeregistrationAdditionalComment = new System.Windows.Forms.ComboBox();
            label__timeregistrationAdditionalComment = new System.Windows.Forms.Label();
            comboBox_timeregistrationMonthlyPeriod = new System.Windows.Forms.ComboBox();
            label_timeregistrationMonthlyPeriod = new System.Windows.Forms.Label();
            label_delimiter = new System.Windows.Forms.Label();
            comboBox_delimiter = new System.Windows.Forms.ComboBox();
            groupBox_timeregistrationMandatoryFields = new System.Windows.Forms.GroupBox();
            label_timeregistrationAbsenceCode = new System.Windows.Forms.Label();
            comboBox_timeregistrationAbcenseCode = new System.Windows.Forms.ComboBox();
            label_timeregistrationCostPriceName = new System.Windows.Forms.Label();
            comboBox_timeregistrationCostPriceName = new System.Windows.Forms.ComboBox();
            label_timeregistrationCostPrice = new System.Windows.Forms.Label();
            comboBox_timeregistrationCostPrice = new System.Windows.Forms.ComboBox();
            label_timeregistrationHourlyRateName = new System.Windows.Forms.Label();
            comboBox_timeregistrationHourlyRateName = new System.Windows.Forms.ComboBox();
            label_timeregistrationHourlyRate = new System.Windows.Forms.Label();
            comboBox_timeregistrationHourlyRate = new System.Windows.Forms.ComboBox();
            label_timeregistrationBillableHours = new System.Windows.Forms.Label();
            comboBox_timeregistrationBillableHours = new System.Windows.Forms.ComboBox();
            label_timeregistrationIsBillable = new System.Windows.Forms.Label();
            comboBox_timeregistrationIsBillable = new System.Windows.Forms.ComboBox();
            label_timeregistrationHours = new System.Windows.Forms.Label();
            comboBox_timeregistrationHours = new System.Windows.Forms.ComboBox();
            label_timeregistrationDate = new System.Windows.Forms.Label();
            label_timeregistrationGroupType = new System.Windows.Forms.Label();
            comboBox_timeregistrationDate = new System.Windows.Forms.ComboBox();
            label_timeregistrationUserInitials = new System.Windows.Forms.Label();
            comboBox_timeregistrationUserInitials = new System.Windows.Forms.ComboBox();
            label_timeregistrationContractName = new System.Windows.Forms.Label();
            comboBox_timeregistrationGroupType = new System.Windows.Forms.ComboBox();
            comboBox_timeregistrationContractName = new System.Windows.Forms.ComboBox();
            label_timeregistrationProjectNo = new System.Windows.Forms.Label();
            comboBox_timeregistrationProjectNo = new System.Windows.Forms.ComboBox();
            label_timeregistrationTaskNo = new System.Windows.Forms.Label();
            comboBox_timeregistrationTaskNo = new System.Windows.Forms.ComboBox();
            label_timeregistrationSetup = new System.Windows.Forms.Label();
            button_timeregistrationSelectFile = new System.Windows.Forms.Button();
            tmrExpand = new System.Windows.Forms.Timer(components);
            defaultToolTip = new System.Windows.Forms.ToolTip(components);
            panel_timeregistrationDataTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_timeregistration).BeginInit();
            panel_timeregistrationMessage.SuspendLayout();
            panel_timeregistrationButtons.SuspendLayout();
            panel_timeregistrationFieldMapping.SuspendLayout();
            flowLayoutPanel_nonMandatoryFields.SuspendLayout();
            panel_NonMandatoryButton.SuspendLayout();
            panel_NonMandatoryFields.SuspendLayout();
            groupBox_timeregistrationMandatoryFields.SuspendLayout();
            SuspendLayout();
            // 
            // WorkerFetcher
            // 
            WorkerFetcher.WorkerReportsProgress = true;
            WorkerFetcher.WorkerSupportsCancellation = true;
            WorkerFetcher.DoWork += WorkerFetcherDoWork;
            // 
            // panel_timeregistrationDataTable
            // 
            panel_timeregistrationDataTable.Controls.Add(dataGridView_timeregistration);
            panel_timeregistrationDataTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_timeregistrationDataTable.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel_timeregistrationDataTable.Location = new System.Drawing.Point(0, 462);
            panel_timeregistrationDataTable.Name = "panel_timeregistrationDataTable";
            panel_timeregistrationDataTable.Size = new System.Drawing.Size(1006, 180);
            panel_timeregistrationDataTable.TabIndex = 6;
            // 
            // dataGridView_timeregistration
            // 
            dataGridView_timeregistration.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridView_timeregistration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridView_timeregistration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_timeregistration.Dock = System.Windows.Forms.DockStyle.Bottom;
            dataGridView_timeregistration.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridView_timeregistration.Location = new System.Drawing.Point(0, 0);
            dataGridView_timeregistration.Name = "dataGridView_timeregistration";
            dataGridView_timeregistration.RowHeadersWidth = 62;
            dataGridView_timeregistration.Size = new System.Drawing.Size(1006, 180);
            dataGridView_timeregistration.TabIndex = 0;
            // 
            // panel_timeregistrationMessage
            // 
            panel_timeregistrationMessage.Controls.Add(textBox_timeregistrationImportMessages);
            panel_timeregistrationMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_timeregistrationMessage.Location = new System.Drawing.Point(0, 278);
            panel_timeregistrationMessage.Name = "panel_timeregistrationMessage";
            panel_timeregistrationMessage.Size = new System.Drawing.Size(1006, 184);
            panel_timeregistrationMessage.TabIndex = 10;
            // 
            // textBox_timeregistrationImportMessages
            // 
            textBox_timeregistrationImportMessages.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            textBox_timeregistrationImportMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox_timeregistrationImportMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            textBox_timeregistrationImportMessages.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            textBox_timeregistrationImportMessages.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            textBox_timeregistrationImportMessages.Location = new System.Drawing.Point(0, 0);
            textBox_timeregistrationImportMessages.Multiline = true;
            textBox_timeregistrationImportMessages.Name = "textBox_timeregistrationImportMessages";
            textBox_timeregistrationImportMessages.ReadOnly = true;
            textBox_timeregistrationImportMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBox_timeregistrationImportMessages.Size = new System.Drawing.Size(1006, 184);
            textBox_timeregistrationImportMessages.TabIndex = 0;
            defaultToolTip.SetToolTip(textBox_timeregistrationImportMessages, "Validation or import status");
            textBox_timeregistrationImportMessages.WordWrap = false;
            textBox_timeregistrationImportMessages.MouseClick += textBox_timeregistrationImportMessages_MouseClick;
            // 
            // panel_timeregistrationButtons
            // 
            panel_timeregistrationButtons.Controls.Add(button_clear);
            panel_timeregistrationButtons.Controls.Add(button_import);
            panel_timeregistrationButtons.Controls.Add(button_validate);
            panel_timeregistrationButtons.Controls.Add(button_stop);
            panel_timeregistrationButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_timeregistrationButtons.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            panel_timeregistrationButtons.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel_timeregistrationButtons.Location = new System.Drawing.Point(0, 226);
            panel_timeregistrationButtons.Name = "panel_timeregistrationButtons";
            panel_timeregistrationButtons.Size = new System.Drawing.Size(1006, 52);
            panel_timeregistrationButtons.TabIndex = 12;
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
            // panel_timeregistrationFieldMapping
            // 
            panel_timeregistrationFieldMapping.AutoScroll = true;
            panel_timeregistrationFieldMapping.Controls.Add(flowLayoutPanel_nonMandatoryFields);
            panel_timeregistrationFieldMapping.Controls.Add(label_delimiter);
            panel_timeregistrationFieldMapping.Controls.Add(comboBox_delimiter);
            panel_timeregistrationFieldMapping.Controls.Add(groupBox_timeregistrationMandatoryFields);
            panel_timeregistrationFieldMapping.Controls.Add(label_timeregistrationSetup);
            panel_timeregistrationFieldMapping.Controls.Add(button_timeregistrationSelectFile);
            panel_timeregistrationFieldMapping.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_timeregistrationFieldMapping.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            panel_timeregistrationFieldMapping.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel_timeregistrationFieldMapping.Location = new System.Drawing.Point(0, 0);
            panel_timeregistrationFieldMapping.Name = "panel_timeregistrationFieldMapping";
            panel_timeregistrationFieldMapping.Size = new System.Drawing.Size(1006, 226);
            panel_timeregistrationFieldMapping.TabIndex = 13;
            // 
            // flowLayoutPanel_nonMandatoryFields
            // 
            flowLayoutPanel_nonMandatoryFields.Controls.Add(panel_NonMandatoryButton);
            flowLayoutPanel_nonMandatoryFields.Controls.Add(panel_NonMandatoryFields);
            flowLayoutPanel_nonMandatoryFields.Location = new System.Drawing.Point(589, 60);
            flowLayoutPanel_nonMandatoryFields.Name = "flowLayoutPanel_nonMandatoryFields";
            flowLayoutPanel_nonMandatoryFields.Size = new System.Drawing.Size(372, 208);
            flowLayoutPanel_nonMandatoryFields.TabIndex = 7;
            // 
            // panel_NonMandatoryButton
            // 
            panel_NonMandatoryButton.Controls.Add(label_nonMandatoryFields);
            panel_NonMandatoryButton.Controls.Add(button_expandNonMandatory);
            panel_NonMandatoryButton.Location = new System.Drawing.Point(3, 3);
            panel_NonMandatoryButton.Name = "panel_NonMandatoryButton";
            panel_NonMandatoryButton.Size = new System.Drawing.Size(363, 32);
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
            panel_NonMandatoryFields.Controls.Add(label_timeregistrationComment);
            panel_NonMandatoryFields.Controls.Add(comboBox_timeregistrationComment);
            panel_NonMandatoryFields.Controls.Add(comboBox_timeregistrationAdditionalComment);
            panel_NonMandatoryFields.Controls.Add(label__timeregistrationAdditionalComment);
            panel_NonMandatoryFields.Controls.Add(comboBox_timeregistrationMonthlyPeriod);
            panel_NonMandatoryFields.Controls.Add(label_timeregistrationMonthlyPeriod);
            panel_NonMandatoryFields.Location = new System.Drawing.Point(3, 41);
            panel_NonMandatoryFields.MaximumSize = new System.Drawing.Size(363, 163);
            panel_NonMandatoryFields.MinimumSize = new System.Drawing.Size(363, 0);
            panel_NonMandatoryFields.Name = "panel_NonMandatoryFields";
            panel_NonMandatoryFields.Size = new System.Drawing.Size(363, 109);
            panel_NonMandatoryFields.TabIndex = 1;
            // 
            // label_timeregistrationComment
            // 
            label_timeregistrationComment.AutoSize = true;
            label_timeregistrationComment.Location = new System.Drawing.Point(10, 10);
            label_timeregistrationComment.Name = "label_timeregistrationComment";
            label_timeregistrationComment.Size = new System.Drawing.Size(68, 17);
            label_timeregistrationComment.TabIndex = 1;
            label_timeregistrationComment.Text = "Comment";
            // 
            // comboBox_timeregistrationComment
            // 
            comboBox_timeregistrationComment.FormattingEnabled = true;
            comboBox_timeregistrationComment.Location = new System.Drawing.Point(143, 7);
            comboBox_timeregistrationComment.Name = "comboBox_timeregistrationComment";
            comboBox_timeregistrationComment.Size = new System.Drawing.Size(139, 25);
            comboBox_timeregistrationComment.TabIndex = 3;
            // 
            // comboBox_timeregistrationAdditionalComment
            // 
            comboBox_timeregistrationAdditionalComment.FormattingEnabled = true;
            comboBox_timeregistrationAdditionalComment.Location = new System.Drawing.Point(143, 38);
            comboBox_timeregistrationAdditionalComment.Name = "comboBox_timeregistrationAdditionalComment";
            comboBox_timeregistrationAdditionalComment.Size = new System.Drawing.Size(139, 25);
            comboBox_timeregistrationAdditionalComment.TabIndex = 3;
            // 
            // label__timeregistrationAdditionalComment
            // 
            label__timeregistrationAdditionalComment.AutoSize = true;
            label__timeregistrationAdditionalComment.Location = new System.Drawing.Point(10, 41);
            label__timeregistrationAdditionalComment.Name = "label__timeregistrationAdditionalComment";
            label__timeregistrationAdditionalComment.Size = new System.Drawing.Size(134, 17);
            label__timeregistrationAdditionalComment.TabIndex = 1;
            label__timeregistrationAdditionalComment.Text = "Additional Comment";
            // 
            // comboBox_timeregistrationMonthlyPeriod
            // 
            comboBox_timeregistrationMonthlyPeriod.FormattingEnabled = true;
            comboBox_timeregistrationMonthlyPeriod.Location = new System.Drawing.Point(143, 69);
            comboBox_timeregistrationMonthlyPeriod.Name = "comboBox_timeregistrationMonthlyPeriod";
            comboBox_timeregistrationMonthlyPeriod.Size = new System.Drawing.Size(139, 25);
            comboBox_timeregistrationMonthlyPeriod.TabIndex = 3;
            // 
            // label_timeregistrationMonthlyPeriod
            // 
            label_timeregistrationMonthlyPeriod.AutoSize = true;
            label_timeregistrationMonthlyPeriod.Location = new System.Drawing.Point(10, 72);
            label_timeregistrationMonthlyPeriod.Name = "label_timeregistrationMonthlyPeriod";
            label_timeregistrationMonthlyPeriod.Size = new System.Drawing.Size(102, 17);
            label_timeregistrationMonthlyPeriod.TabIndex = 1;
            label_timeregistrationMonthlyPeriod.Text = "Monthly Period";
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
            // groupBox_timeregistrationMandatoryFields
            // 
            groupBox_timeregistrationMandatoryFields.Controls.Add(label_timeregistrationAbsenceCode);
            groupBox_timeregistrationMandatoryFields.Controls.Add(comboBox_timeregistrationAbcenseCode);
            groupBox_timeregistrationMandatoryFields.Controls.Add(label_timeregistrationCostPriceName);
            groupBox_timeregistrationMandatoryFields.Controls.Add(comboBox_timeregistrationCostPriceName);
            groupBox_timeregistrationMandatoryFields.Controls.Add(label_timeregistrationCostPrice);
            groupBox_timeregistrationMandatoryFields.Controls.Add(comboBox_timeregistrationCostPrice);
            groupBox_timeregistrationMandatoryFields.Controls.Add(label_timeregistrationHourlyRateName);
            groupBox_timeregistrationMandatoryFields.Controls.Add(comboBox_timeregistrationHourlyRateName);
            groupBox_timeregistrationMandatoryFields.Controls.Add(label_timeregistrationHourlyRate);
            groupBox_timeregistrationMandatoryFields.Controls.Add(comboBox_timeregistrationHourlyRate);
            groupBox_timeregistrationMandatoryFields.Controls.Add(label_timeregistrationBillableHours);
            groupBox_timeregistrationMandatoryFields.Controls.Add(comboBox_timeregistrationBillableHours);
            groupBox_timeregistrationMandatoryFields.Controls.Add(label_timeregistrationIsBillable);
            groupBox_timeregistrationMandatoryFields.Controls.Add(comboBox_timeregistrationIsBillable);
            groupBox_timeregistrationMandatoryFields.Controls.Add(label_timeregistrationHours);
            groupBox_timeregistrationMandatoryFields.Controls.Add(comboBox_timeregistrationHours);
            groupBox_timeregistrationMandatoryFields.Controls.Add(label_timeregistrationDate);
            groupBox_timeregistrationMandatoryFields.Controls.Add(label_timeregistrationGroupType);
            groupBox_timeregistrationMandatoryFields.Controls.Add(comboBox_timeregistrationDate);
            groupBox_timeregistrationMandatoryFields.Controls.Add(label_timeregistrationUserInitials);
            groupBox_timeregistrationMandatoryFields.Controls.Add(comboBox_timeregistrationUserInitials);
            groupBox_timeregistrationMandatoryFields.Controls.Add(label_timeregistrationContractName);
            groupBox_timeregistrationMandatoryFields.Controls.Add(comboBox_timeregistrationGroupType);
            groupBox_timeregistrationMandatoryFields.Controls.Add(comboBox_timeregistrationContractName);
            groupBox_timeregistrationMandatoryFields.Controls.Add(label_timeregistrationProjectNo);
            groupBox_timeregistrationMandatoryFields.Controls.Add(comboBox_timeregistrationProjectNo);
            groupBox_timeregistrationMandatoryFields.Controls.Add(label_timeregistrationTaskNo);
            groupBox_timeregistrationMandatoryFields.Controls.Add(comboBox_timeregistrationTaskNo);
            groupBox_timeregistrationMandatoryFields.Location = new System.Drawing.Point(184, 62);
            groupBox_timeregistrationMandatoryFields.Name = "groupBox_timeregistrationMandatoryFields";
            groupBox_timeregistrationMandatoryFields.Size = new System.Drawing.Size(358, 465);
            groupBox_timeregistrationMandatoryFields.TabIndex = 5;
            groupBox_timeregistrationMandatoryFields.TabStop = false;
            groupBox_timeregistrationMandatoryFields.Text = "Mandatory";
            // 
            // label_timeregistrationAbsenceCode
            // 
            label_timeregistrationAbsenceCode.AutoSize = true;
            label_timeregistrationAbsenceCode.Location = new System.Drawing.Point(6, 244);
            label_timeregistrationAbsenceCode.Name = "label_timeregistrationAbsenceCode";
            label_timeregistrationAbsenceCode.Size = new System.Drawing.Size(94, 17);
            label_timeregistrationAbsenceCode.TabIndex = 21;
            label_timeregistrationAbsenceCode.Text = "Absence Code";
            // 
            // comboBox_timeregistrationAbcenseCode
            // 
            comboBox_timeregistrationAbcenseCode.FormattingEnabled = true;
            comboBox_timeregistrationAbcenseCode.Location = new System.Drawing.Point(138, 241);
            comboBox_timeregistrationAbcenseCode.Name = "comboBox_timeregistrationAbcenseCode";
            comboBox_timeregistrationAbcenseCode.Size = new System.Drawing.Size(139, 25);
            comboBox_timeregistrationAbcenseCode.TabIndex = 22;
            // 
            // label_timeregistrationCostPriceName
            // 
            label_timeregistrationCostPriceName.AutoSize = true;
            label_timeregistrationCostPriceName.Location = new System.Drawing.Point(6, 430);
            label_timeregistrationCostPriceName.Name = "label_timeregistrationCostPriceName";
            label_timeregistrationCostPriceName.Size = new System.Drawing.Size(108, 17);
            label_timeregistrationCostPriceName.TabIndex = 19;
            label_timeregistrationCostPriceName.Text = "Cost Price Name";
            // 
            // comboBox_timeregistrationCostPriceName
            // 
            comboBox_timeregistrationCostPriceName.FormattingEnabled = true;
            comboBox_timeregistrationCostPriceName.Location = new System.Drawing.Point(138, 427);
            comboBox_timeregistrationCostPriceName.Name = "comboBox_timeregistrationCostPriceName";
            comboBox_timeregistrationCostPriceName.Size = new System.Drawing.Size(139, 25);
            comboBox_timeregistrationCostPriceName.TabIndex = 20;
            // 
            // label_timeregistrationCostPrice
            // 
            label_timeregistrationCostPrice.AutoSize = true;
            label_timeregistrationCostPrice.Location = new System.Drawing.Point(6, 399);
            label_timeregistrationCostPrice.Name = "label_timeregistrationCostPrice";
            label_timeregistrationCostPrice.Size = new System.Drawing.Size(68, 17);
            label_timeregistrationCostPrice.TabIndex = 17;
            label_timeregistrationCostPrice.Text = "Cost Price";
            // 
            // comboBox_timeregistrationCostPrice
            // 
            comboBox_timeregistrationCostPrice.FormattingEnabled = true;
            comboBox_timeregistrationCostPrice.Location = new System.Drawing.Point(138, 396);
            comboBox_timeregistrationCostPrice.Name = "comboBox_timeregistrationCostPrice";
            comboBox_timeregistrationCostPrice.Size = new System.Drawing.Size(139, 25);
            comboBox_timeregistrationCostPrice.TabIndex = 18;
            // 
            // label_timeregistrationHourlyRateName
            // 
            label_timeregistrationHourlyRateName.AutoSize = true;
            label_timeregistrationHourlyRateName.Location = new System.Drawing.Point(6, 368);
            label_timeregistrationHourlyRateName.Name = "label_timeregistrationHourlyRateName";
            label_timeregistrationHourlyRateName.Size = new System.Drawing.Size(120, 17);
            label_timeregistrationHourlyRateName.TabIndex = 15;
            label_timeregistrationHourlyRateName.Text = "Hourly Rate Name";
            // 
            // comboBox_timeregistrationHourlyRateName
            // 
            comboBox_timeregistrationHourlyRateName.FormattingEnabled = true;
            comboBox_timeregistrationHourlyRateName.Location = new System.Drawing.Point(138, 365);
            comboBox_timeregistrationHourlyRateName.Name = "comboBox_timeregistrationHourlyRateName";
            comboBox_timeregistrationHourlyRateName.Size = new System.Drawing.Size(139, 25);
            comboBox_timeregistrationHourlyRateName.TabIndex = 16;
            // 
            // label_timeregistrationHourlyRate
            // 
            label_timeregistrationHourlyRate.AutoSize = true;
            label_timeregistrationHourlyRate.Location = new System.Drawing.Point(6, 337);
            label_timeregistrationHourlyRate.Name = "label_timeregistrationHourlyRate";
            label_timeregistrationHourlyRate.Size = new System.Drawing.Size(80, 17);
            label_timeregistrationHourlyRate.TabIndex = 13;
            label_timeregistrationHourlyRate.Text = "Hourly Rate";
            // 
            // comboBox_timeregistrationHourlyRate
            // 
            comboBox_timeregistrationHourlyRate.FormattingEnabled = true;
            comboBox_timeregistrationHourlyRate.Location = new System.Drawing.Point(138, 334);
            comboBox_timeregistrationHourlyRate.Name = "comboBox_timeregistrationHourlyRate";
            comboBox_timeregistrationHourlyRate.Size = new System.Drawing.Size(139, 25);
            comboBox_timeregistrationHourlyRate.TabIndex = 14;
            // 
            // label_timeregistrationBillableHours
            // 
            label_timeregistrationBillableHours.AutoSize = true;
            label_timeregistrationBillableHours.Location = new System.Drawing.Point(6, 306);
            label_timeregistrationBillableHours.Name = "label_timeregistrationBillableHours";
            label_timeregistrationBillableHours.Size = new System.Drawing.Size(91, 17);
            label_timeregistrationBillableHours.TabIndex = 11;
            label_timeregistrationBillableHours.Text = "Billable Hours";
            // 
            // comboBox_timeregistrationBillableHours
            // 
            comboBox_timeregistrationBillableHours.FormattingEnabled = true;
            comboBox_timeregistrationBillableHours.Location = new System.Drawing.Point(138, 303);
            comboBox_timeregistrationBillableHours.Name = "comboBox_timeregistrationBillableHours";
            comboBox_timeregistrationBillableHours.Size = new System.Drawing.Size(139, 25);
            comboBox_timeregistrationBillableHours.TabIndex = 12;
            // 
            // label_timeregistrationIsBillable
            // 
            label_timeregistrationIsBillable.AutoSize = true;
            label_timeregistrationIsBillable.Location = new System.Drawing.Point(6, 275);
            label_timeregistrationIsBillable.Name = "label_timeregistrationIsBillable";
            label_timeregistrationIsBillable.Size = new System.Drawing.Size(64, 17);
            label_timeregistrationIsBillable.TabIndex = 7;
            label_timeregistrationIsBillable.Text = "Is Billable";
            // 
            // comboBox_timeregistrationIsBillable
            // 
            comboBox_timeregistrationIsBillable.FormattingEnabled = true;
            comboBox_timeregistrationIsBillable.Location = new System.Drawing.Point(138, 272);
            comboBox_timeregistrationIsBillable.Name = "comboBox_timeregistrationIsBillable";
            comboBox_timeregistrationIsBillable.Size = new System.Drawing.Size(139, 25);
            comboBox_timeregistrationIsBillable.TabIndex = 8;
            // 
            // label_timeregistrationHours
            // 
            label_timeregistrationHours.AutoSize = true;
            label_timeregistrationHours.Location = new System.Drawing.Point(6, 182);
            label_timeregistrationHours.Name = "label_timeregistrationHours";
            label_timeregistrationHours.Size = new System.Drawing.Size(45, 17);
            label_timeregistrationHours.TabIndex = 1;
            label_timeregistrationHours.Text = "Hours";
            // 
            // comboBox_timeregistrationHours
            // 
            comboBox_timeregistrationHours.FormattingEnabled = true;
            comboBox_timeregistrationHours.Location = new System.Drawing.Point(138, 179);
            comboBox_timeregistrationHours.Name = "comboBox_timeregistrationHours";
            comboBox_timeregistrationHours.Size = new System.Drawing.Size(139, 25);
            comboBox_timeregistrationHours.TabIndex = 3;
            // 
            // label_timeregistrationDate
            // 
            label_timeregistrationDate.AutoSize = true;
            label_timeregistrationDate.Location = new System.Drawing.Point(6, 151);
            label_timeregistrationDate.Name = "label_timeregistrationDate";
            label_timeregistrationDate.Size = new System.Drawing.Size(36, 17);
            label_timeregistrationDate.TabIndex = 1;
            label_timeregistrationDate.Text = "Date";
            // 
            // label_timeregistrationGroupType
            // 
            label_timeregistrationGroupType.AutoSize = true;
            label_timeregistrationGroupType.Location = new System.Drawing.Point(6, 213);
            label_timeregistrationGroupType.Name = "label_timeregistrationGroupType";
            label_timeregistrationGroupType.Size = new System.Drawing.Size(78, 17);
            label_timeregistrationGroupType.TabIndex = 1;
            label_timeregistrationGroupType.Text = "Group Type";
            // 
            // comboBox_timeregistrationDate
            // 
            comboBox_timeregistrationDate.FormattingEnabled = true;
            comboBox_timeregistrationDate.Location = new System.Drawing.Point(138, 148);
            comboBox_timeregistrationDate.Name = "comboBox_timeregistrationDate";
            comboBox_timeregistrationDate.Size = new System.Drawing.Size(139, 25);
            comboBox_timeregistrationDate.TabIndex = 3;
            // 
            // label_timeregistrationUserInitials
            // 
            label_timeregistrationUserInitials.AutoSize = true;
            label_timeregistrationUserInitials.Location = new System.Drawing.Point(6, 120);
            label_timeregistrationUserInitials.Name = "label_timeregistrationUserInitials";
            label_timeregistrationUserInitials.Size = new System.Drawing.Size(78, 17);
            label_timeregistrationUserInitials.TabIndex = 1;
            label_timeregistrationUserInitials.Text = "User Initials";
            // 
            // comboBox_timeregistrationUserInitials
            // 
            comboBox_timeregistrationUserInitials.FormattingEnabled = true;
            comboBox_timeregistrationUserInitials.Location = new System.Drawing.Point(138, 117);
            comboBox_timeregistrationUserInitials.Name = "comboBox_timeregistrationUserInitials";
            comboBox_timeregistrationUserInitials.Size = new System.Drawing.Size(139, 25);
            comboBox_timeregistrationUserInitials.TabIndex = 3;
            // 
            // label_timeregistrationContractName
            // 
            label_timeregistrationContractName.AutoSize = true;
            label_timeregistrationContractName.Location = new System.Drawing.Point(6, 89);
            label_timeregistrationContractName.Name = "label_timeregistrationContractName";
            label_timeregistrationContractName.Size = new System.Drawing.Size(100, 17);
            label_timeregistrationContractName.TabIndex = 1;
            label_timeregistrationContractName.Text = "Contract Name";
            // 
            // comboBox_timeregistrationGroupType
            // 
            comboBox_timeregistrationGroupType.FormattingEnabled = true;
            comboBox_timeregistrationGroupType.Location = new System.Drawing.Point(138, 210);
            comboBox_timeregistrationGroupType.Name = "comboBox_timeregistrationGroupType";
            comboBox_timeregistrationGroupType.Size = new System.Drawing.Size(139, 25);
            comboBox_timeregistrationGroupType.TabIndex = 3;
            // 
            // comboBox_timeregistrationContractName
            // 
            comboBox_timeregistrationContractName.FormattingEnabled = true;
            comboBox_timeregistrationContractName.Location = new System.Drawing.Point(138, 86);
            comboBox_timeregistrationContractName.Name = "comboBox_timeregistrationContractName";
            comboBox_timeregistrationContractName.Size = new System.Drawing.Size(139, 25);
            comboBox_timeregistrationContractName.TabIndex = 3;
            // 
            // label_timeregistrationProjectNo
            // 
            label_timeregistrationProjectNo.AutoSize = true;
            label_timeregistrationProjectNo.Location = new System.Drawing.Point(6, 58);
            label_timeregistrationProjectNo.Name = "label_timeregistrationProjectNo";
            label_timeregistrationProjectNo.Size = new System.Drawing.Size(72, 17);
            label_timeregistrationProjectNo.TabIndex = 1;
            label_timeregistrationProjectNo.Text = "Project No";
            // 
            // comboBox_timeregistrationProjectNo
            // 
            comboBox_timeregistrationProjectNo.FormattingEnabled = true;
            comboBox_timeregistrationProjectNo.Location = new System.Drawing.Point(138, 55);
            comboBox_timeregistrationProjectNo.Name = "comboBox_timeregistrationProjectNo";
            comboBox_timeregistrationProjectNo.Size = new System.Drawing.Size(139, 25);
            comboBox_timeregistrationProjectNo.TabIndex = 3;
            // 
            // label_timeregistrationTaskNo
            // 
            label_timeregistrationTaskNo.AutoSize = true;
            label_timeregistrationTaskNo.Location = new System.Drawing.Point(6, 27);
            label_timeregistrationTaskNo.Name = "label_timeregistrationTaskNo";
            label_timeregistrationTaskNo.Size = new System.Drawing.Size(56, 17);
            label_timeregistrationTaskNo.TabIndex = 1;
            label_timeregistrationTaskNo.Text = "Task No";
            // 
            // comboBox_timeregistrationTaskNo
            // 
            comboBox_timeregistrationTaskNo.FormattingEnabled = true;
            comboBox_timeregistrationTaskNo.Location = new System.Drawing.Point(138, 24);
            comboBox_timeregistrationTaskNo.Name = "comboBox_timeregistrationTaskNo";
            comboBox_timeregistrationTaskNo.Size = new System.Drawing.Size(139, 25);
            comboBox_timeregistrationTaskNo.TabIndex = 3;
            // 
            // label_timeregistrationSetup
            // 
            label_timeregistrationSetup.AutoSize = true;
            label_timeregistrationSetup.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            label_timeregistrationSetup.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            label_timeregistrationSetup.Location = new System.Drawing.Point(7, 16);
            label_timeregistrationSetup.Name = "label_timeregistrationSetup";
            label_timeregistrationSetup.Size = new System.Drawing.Size(334, 32);
            label_timeregistrationSetup.TabIndex = 0;
            label_timeregistrationSetup.Text = "Timeregistration Data Import";
            // 
            // button_timeregistrationSelectFile
            // 
            button_timeregistrationSelectFile.BackColor = System.Drawing.Color.FromArgb(226, 43, 141);
            button_timeregistrationSelectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            button_timeregistrationSelectFile.FlatAppearance.BorderSize = 0;
            button_timeregistrationSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_timeregistrationSelectFile.ForeColor = System.Drawing.Color.White;
            button_timeregistrationSelectFile.Location = new System.Drawing.Point(13, 111);
            button_timeregistrationSelectFile.Name = "button_timeregistrationSelectFile";
            button_timeregistrationSelectFile.Size = new System.Drawing.Size(80, 29);
            button_timeregistrationSelectFile.TabIndex = 4;
            button_timeregistrationSelectFile.Text = "Select File";
            defaultToolTip.SetToolTip(button_timeregistrationSelectFile, "Select input CSV file");
            button_timeregistrationSelectFile.UseVisualStyleBackColor = false;
            button_timeregistrationSelectFile.Click += button_select_timeregistration_file_Click;
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
            // UserControl_TimeregistrationImport
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel_timeregistrationFieldMapping);
            Controls.Add(panel_timeregistrationButtons);
            Controls.Add(panel_timeregistrationMessage);
            Controls.Add(panel_timeregistrationDataTable);
            Name = "UserControl_TimeregistrationImport";
            Size = new System.Drawing.Size(1006, 642);
            Load += UserControl1_Load;
            panel_timeregistrationDataTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_timeregistration).EndInit();
            panel_timeregistrationMessage.ResumeLayout(false);
            panel_timeregistrationMessage.PerformLayout();
            panel_timeregistrationButtons.ResumeLayout(false);
            panel_timeregistrationFieldMapping.ResumeLayout(false);
            panel_timeregistrationFieldMapping.PerformLayout();
            flowLayoutPanel_nonMandatoryFields.ResumeLayout(false);
            panel_NonMandatoryButton.ResumeLayout(false);
            panel_NonMandatoryButton.PerformLayout();
            panel_NonMandatoryFields.ResumeLayout(false);
            panel_NonMandatoryFields.PerformLayout();
            groupBox_timeregistrationMandatoryFields.ResumeLayout(false);
            groupBox_timeregistrationMandatoryFields.PerformLayout();
            ResumeLayout(false);

        }

        #endregion


        private void AddRowNumberToDataTable()
        {
            this.dataGridView_timeregistration.DataBindingComplete += (o, e) =>
            {
                foreach (System.Windows.Forms.DataGridViewRow row in dataGridView_timeregistration.Rows)
                {
                    row.HeaderCell.Value = (row.Index + 1).ToString();

                }
            };
            this.dataGridView_timeregistration.RowHeadersWidth = 65;
        }


        private System.ComponentModel.BackgroundWorker WorkerFetcher;
        private System.Windows.Forms.Panel panel_timeregistrationDataTable;
        private System.Windows.Forms.DataGridView dataGridView_timeregistration;
        private System.Windows.Forms.Panel panel_timeregistrationMessage;
        private System.Windows.Forms.Panel panel_timeregistrationButtons;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_import;
        private System.Windows.Forms.Button button_validate;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Panel panel_timeregistrationFieldMapping;
        private System.Windows.Forms.GroupBox groupBox_timeregistrationMandatoryFields;
        private System.Windows.Forms.ComboBox comboBox_timeregistrationTaskNo;
        private System.Windows.Forms.Label label_timeregistrationTaskNo;
        private System.Windows.Forms.Label label_timeregistrationSetup;
        private System.Windows.Forms.Button button_timeregistrationSelectFile;
        private System.Windows.Forms.TextBox textBox_timeregistrationImportMessages;
        private System.Windows.Forms.Label label_timeregistrationContractName;
        private System.Windows.Forms.ComboBox comboBox_timeregistrationContractName;
        private System.Windows.Forms.Label label_timeregistrationProjectNo;
        private System.Windows.Forms.ComboBox comboBox_timeregistrationProjectNo;
        private System.Windows.Forms.Label label_timeregistrationHours;
        private System.Windows.Forms.ComboBox comboBox_timeregistrationHours;
        private System.Windows.Forms.Label label_timeregistrationDate;
        private System.Windows.Forms.ComboBox comboBox_timeregistrationDate;
        private System.Windows.Forms.Label label_timeregistrationUserInitials;
        private System.Windows.Forms.ComboBox comboBox_timeregistrationUserInitials;
        private System.Windows.Forms.Label label_delimiter;
        private System.Windows.Forms.ComboBox comboBox_delimiter;
        private System.Windows.Forms.Label label_timeregistrationGroupType;
        private System.Windows.Forms.ComboBox comboBox_timeregistrationGroupType;
        private System.Windows.Forms.Label label_timeregistrationMonthlyPeriod;
        private System.Windows.Forms.ComboBox comboBox_timeregistrationMonthlyPeriod;
        private System.Windows.Forms.Label label__timeregistrationAdditionalComment;
        private System.Windows.Forms.ComboBox comboBox_timeregistrationAdditionalComment;
        private System.Windows.Forms.Label label_timeregistrationComment;
        private System.Windows.Forms.ComboBox comboBox_timeregistrationComment;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_nonMandatoryFields;
        private System.Windows.Forms.Panel panel_NonMandatoryButton;
        private System.Windows.Forms.Panel panel_NonMandatoryFields;
        private System.Windows.Forms.Label label_nonMandatoryFields;
        private System.Windows.Forms.Button button_expandNonMandatory;
        private System.Windows.Forms.Timer tmrExpand;
        private System.Windows.Forms.ToolTip defaultToolTip;
        private System.Windows.Forms.Label label_timeregistrationIsBillable;
        private System.Windows.Forms.ComboBox comboBox_timeregistrationIsBillable;
        private System.Windows.Forms.Label label_timeregistrationCostPriceName;
        private System.Windows.Forms.ComboBox comboBox_timeregistrationCostPriceName;
        private System.Windows.Forms.Label label_timeregistrationCostPrice;
        private System.Windows.Forms.ComboBox comboBox_timeregistrationCostPrice;
        private System.Windows.Forms.Label label_timeregistrationHourlyRateName;
        private System.Windows.Forms.ComboBox comboBox_timeregistrationHourlyRateName;
        private System.Windows.Forms.Label label_timeregistrationHourlyRate;
        private System.Windows.Forms.ComboBox comboBox_timeregistrationHourlyRate;
        private System.Windows.Forms.Label label_timeregistrationBillableHours;
        private System.Windows.Forms.ComboBox comboBox_timeregistrationBillableHours;
        private System.Windows.Forms.Label label_timeregistrationAbsenceCode;
        private System.Windows.Forms.ComboBox comboBox_timeregistrationAbcenseCode;
    }
}
