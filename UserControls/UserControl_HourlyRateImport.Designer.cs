namespace TimeLog.DataImporter.UserControls
{
    partial class UserControl_HourlyRateImport
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
            panel_contractHourlyRateDataTable = new System.Windows.Forms.Panel();
            dataGridView_contractHourlyRate = new System.Windows.Forms.DataGridView();
            panel_contractHourlyRateMessage = new System.Windows.Forms.Panel();
            textBox_contractHourlyRateImportMessages = new System.Windows.Forms.TextBox();
            panel_contractHourlyRateButtons = new System.Windows.Forms.Panel();
            button_clear = new System.Windows.Forms.Button();
            button_import = new System.Windows.Forms.Button();
            button_validate = new System.Windows.Forms.Button();
            button_stop = new System.Windows.Forms.Button();
            panel_contractHourlyRateFieldMapping = new System.Windows.Forms.Panel();
            flowLayoutPanel_nonMandatoryFields = new System.Windows.Forms.FlowLayoutPanel();
            panel_NonMandatoryButton = new System.Windows.Forms.Panel();
            label_nonMandatoryFields = new System.Windows.Forms.Label();
            button_expandNonMandatory = new System.Windows.Forms.Button();
            panel_NonMandatoryFields = new System.Windows.Forms.Panel();
            comboBox_contractHourlyRateProductNo = new System.Windows.Forms.ComboBox();
            label_contractHourlyRateProductNo = new System.Windows.Forms.Label();
            label_delimiter = new System.Windows.Forms.Label();
            comboBox_delimiter = new System.Windows.Forms.ComboBox();
            groupBox_contractHourlyRateMandatoryFields = new System.Windows.Forms.GroupBox();
            label_contractHourlyRateName = new System.Windows.Forms.Label();
            comboBox_contractHourlyRateName = new System.Windows.Forms.ComboBox();
            label_contractHourlyRateAmount = new System.Windows.Forms.Label();
            comboBox_contractHourlyRateAmount = new System.Windows.Forms.ComboBox();
            label_contractHourlyRateCreateCategory = new System.Windows.Forms.Label();
            comboBox_contractHourlyRateCreateCategory = new System.Windows.Forms.ComboBox();
            label_contractHourlyRateContractName = new System.Windows.Forms.Label();
            comboBox_contractHourlyRateContractName = new System.Windows.Forms.ComboBox();
            label_contractHourlyRateProjectNo = new System.Windows.Forms.Label();
            comboBox_contractHourlyRateProjectNo = new System.Windows.Forms.ComboBox();
            label_contractHourlyRateSetup = new System.Windows.Forms.Label();
            button_contractHourlyRateSelectFile = new System.Windows.Forms.Button();
            tmrExpand = new System.Windows.Forms.Timer(components);
            defaultToolTip = new System.Windows.Forms.ToolTip(components);
            panel_contractHourlyRateDataTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_contractHourlyRate).BeginInit();
            panel_contractHourlyRateMessage.SuspendLayout();
            panel_contractHourlyRateButtons.SuspendLayout();
            panel_contractHourlyRateFieldMapping.SuspendLayout();
            flowLayoutPanel_nonMandatoryFields.SuspendLayout();
            panel_NonMandatoryButton.SuspendLayout();
            panel_NonMandatoryFields.SuspendLayout();
            groupBox_contractHourlyRateMandatoryFields.SuspendLayout();
            SuspendLayout();
            // 
            // WorkerFetcher
            // 
            WorkerFetcher.WorkerReportsProgress = true;
            WorkerFetcher.WorkerSupportsCancellation = true;
            WorkerFetcher.DoWork += WorkerFetcherDoWork;
            // 
            // panel_contractHourlyRateDataTable
            // 
            panel_contractHourlyRateDataTable.Controls.Add(dataGridView_contractHourlyRate);
            panel_contractHourlyRateDataTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_contractHourlyRateDataTable.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel_contractHourlyRateDataTable.Location = new System.Drawing.Point(0, 462);
            panel_contractHourlyRateDataTable.Name = "panel_contractHourlyRateDataTable";
            panel_contractHourlyRateDataTable.Size = new System.Drawing.Size(1006, 180);
            panel_contractHourlyRateDataTable.TabIndex = 6;
            // 
            // dataGridView_contractHourlyRate
            // 
            dataGridView_contractHourlyRate.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridView_contractHourlyRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridView_contractHourlyRate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_contractHourlyRate.Dock = System.Windows.Forms.DockStyle.Bottom;
            dataGridView_contractHourlyRate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridView_contractHourlyRate.Location = new System.Drawing.Point(0, 0);
            dataGridView_contractHourlyRate.Name = "dataGridView_contractHourlyRate";
            dataGridView_contractHourlyRate.RowHeadersWidth = 62;
            dataGridView_contractHourlyRate.Size = new System.Drawing.Size(1006, 180);
            dataGridView_contractHourlyRate.TabIndex = 0;
            // 
            // panel_contractHourlyRateMessage
            // 
            panel_contractHourlyRateMessage.Controls.Add(textBox_contractHourlyRateImportMessages);
            panel_contractHourlyRateMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_contractHourlyRateMessage.Location = new System.Drawing.Point(0, 278);
            panel_contractHourlyRateMessage.Name = "panel_contractHourlyRateMessage";
            panel_contractHourlyRateMessage.Size = new System.Drawing.Size(1006, 184);
            panel_contractHourlyRateMessage.TabIndex = 10;
            // 
            // textBox_contractHourlyRateImportMessages
            // 
            textBox_contractHourlyRateImportMessages.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            textBox_contractHourlyRateImportMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox_contractHourlyRateImportMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            textBox_contractHourlyRateImportMessages.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            textBox_contractHourlyRateImportMessages.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            textBox_contractHourlyRateImportMessages.Location = new System.Drawing.Point(0, 0);
            textBox_contractHourlyRateImportMessages.Multiline = true;
            textBox_contractHourlyRateImportMessages.Name = "textBox_contractHourlyRateImportMessages";
            textBox_contractHourlyRateImportMessages.ReadOnly = true;
            textBox_contractHourlyRateImportMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBox_contractHourlyRateImportMessages.Size = new System.Drawing.Size(1006, 184);
            textBox_contractHourlyRateImportMessages.TabIndex = 0;
            defaultToolTip.SetToolTip(textBox_contractHourlyRateImportMessages, "Validation or import status");
            textBox_contractHourlyRateImportMessages.WordWrap = false;
            textBox_contractHourlyRateImportMessages.MouseClick += textBox_contractHourlyRateImportMessages_MouseClick;
            // 
            // panel_contractHourlyRateButtons
            // 
            panel_contractHourlyRateButtons.Controls.Add(button_clear);
            panel_contractHourlyRateButtons.Controls.Add(button_import);
            panel_contractHourlyRateButtons.Controls.Add(button_validate);
            panel_contractHourlyRateButtons.Controls.Add(button_stop);
            panel_contractHourlyRateButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_contractHourlyRateButtons.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            panel_contractHourlyRateButtons.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel_contractHourlyRateButtons.Location = new System.Drawing.Point(0, 226);
            panel_contractHourlyRateButtons.Name = "panel_contractHourlyRateButtons";
            panel_contractHourlyRateButtons.Size = new System.Drawing.Size(1006, 52);
            panel_contractHourlyRateButtons.TabIndex = 12;
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
            // panel_contractHourlyRateFieldMapping
            // 
            panel_contractHourlyRateFieldMapping.AutoScroll = true;
            panel_contractHourlyRateFieldMapping.Controls.Add(flowLayoutPanel_nonMandatoryFields);
            panel_contractHourlyRateFieldMapping.Controls.Add(label_delimiter);
            panel_contractHourlyRateFieldMapping.Controls.Add(comboBox_delimiter);
            panel_contractHourlyRateFieldMapping.Controls.Add(groupBox_contractHourlyRateMandatoryFields);
            panel_contractHourlyRateFieldMapping.Controls.Add(label_contractHourlyRateSetup);
            panel_contractHourlyRateFieldMapping.Controls.Add(button_contractHourlyRateSelectFile);
            panel_contractHourlyRateFieldMapping.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_contractHourlyRateFieldMapping.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            panel_contractHourlyRateFieldMapping.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel_contractHourlyRateFieldMapping.Location = new System.Drawing.Point(0, 0);
            panel_contractHourlyRateFieldMapping.Name = "panel_contractHourlyRateFieldMapping";
            panel_contractHourlyRateFieldMapping.Size = new System.Drawing.Size(1006, 226);
            panel_contractHourlyRateFieldMapping.TabIndex = 13;
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
            panel_NonMandatoryFields.Controls.Add(comboBox_contractHourlyRateProductNo);
            panel_NonMandatoryFields.Controls.Add(label_contractHourlyRateProductNo);
            panel_NonMandatoryFields.Location = new System.Drawing.Point(3, 41);
            panel_NonMandatoryFields.MaximumSize = new System.Drawing.Size(363, 163);
            panel_NonMandatoryFields.MinimumSize = new System.Drawing.Size(363, 0);
            panel_NonMandatoryFields.Name = "panel_NonMandatoryFields";
            panel_NonMandatoryFields.Size = new System.Drawing.Size(363, 109);
            panel_NonMandatoryFields.TabIndex = 1;
            // 
            // comboBox_contractHourlyRateProductNo
            // 
            comboBox_contractHourlyRateProductNo.FormattingEnabled = true;
            comboBox_contractHourlyRateProductNo.Location = new System.Drawing.Point(140, 16);
            comboBox_contractHourlyRateProductNo.Name = "comboBox_contractHourlyRateProductNo";
            comboBox_contractHourlyRateProductNo.Size = new System.Drawing.Size(139, 25);
            comboBox_contractHourlyRateProductNo.TabIndex = 12;
            // 
            // label_contractHourlyRateProductNo
            // 
            label_contractHourlyRateProductNo.AutoSize = true;
            label_contractHourlyRateProductNo.Location = new System.Drawing.Point(8, 19);
            label_contractHourlyRateProductNo.Name = "label_contractHourlyRateProductNo";
            label_contractHourlyRateProductNo.Size = new System.Drawing.Size(78, 17);
            label_contractHourlyRateProductNo.TabIndex = 11;
            label_contractHourlyRateProductNo.Text = "Product No";
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
            // groupBox_contractHourlyRateMandatoryFields
            // 
            groupBox_contractHourlyRateMandatoryFields.Controls.Add(label_contractHourlyRateName);
            groupBox_contractHourlyRateMandatoryFields.Controls.Add(comboBox_contractHourlyRateName);
            groupBox_contractHourlyRateMandatoryFields.Controls.Add(label_contractHourlyRateAmount);
            groupBox_contractHourlyRateMandatoryFields.Controls.Add(comboBox_contractHourlyRateAmount);
            groupBox_contractHourlyRateMandatoryFields.Controls.Add(label_contractHourlyRateCreateCategory);
            groupBox_contractHourlyRateMandatoryFields.Controls.Add(comboBox_contractHourlyRateCreateCategory);
            groupBox_contractHourlyRateMandatoryFields.Controls.Add(label_contractHourlyRateContractName);
            groupBox_contractHourlyRateMandatoryFields.Controls.Add(comboBox_contractHourlyRateContractName);
            groupBox_contractHourlyRateMandatoryFields.Controls.Add(label_contractHourlyRateProjectNo);
            groupBox_contractHourlyRateMandatoryFields.Controls.Add(comboBox_contractHourlyRateProjectNo);
            groupBox_contractHourlyRateMandatoryFields.Location = new System.Drawing.Point(184, 62);
            groupBox_contractHourlyRateMandatoryFields.Name = "groupBox_contractHourlyRateMandatoryFields";
            groupBox_contractHourlyRateMandatoryFields.Size = new System.Drawing.Size(358, 220);
            groupBox_contractHourlyRateMandatoryFields.TabIndex = 5;
            groupBox_contractHourlyRateMandatoryFields.TabStop = false;
            groupBox_contractHourlyRateMandatoryFields.Text = "Mandatory";
            // 
            // label_contractHourlyRateName
            // 
            label_contractHourlyRateName.AutoSize = true;
            label_contractHourlyRateName.Location = new System.Drawing.Point(6, 184);
            label_contractHourlyRateName.Name = "label_contractHourlyRateName";
            label_contractHourlyRateName.Size = new System.Drawing.Size(120, 17);
            label_contractHourlyRateName.TabIndex = 15;
            label_contractHourlyRateName.Text = "Hourly Rate Name";
            // 
            // comboBox_contractHourlyRateName
            // 
            comboBox_contractHourlyRateName.FormattingEnabled = true;
            comboBox_contractHourlyRateName.Location = new System.Drawing.Point(163, 181);
            comboBox_contractHourlyRateName.Name = "comboBox_contractHourlyRateName";
            comboBox_contractHourlyRateName.Size = new System.Drawing.Size(139, 25);
            comboBox_contractHourlyRateName.TabIndex = 16;
            // 
            // label_contractHourlyRateAmount
            // 
            label_contractHourlyRateAmount.AutoSize = true;
            label_contractHourlyRateAmount.Location = new System.Drawing.Point(6, 153);
            label_contractHourlyRateAmount.Name = "label_contractHourlyRateAmount";
            label_contractHourlyRateAmount.Size = new System.Drawing.Size(80, 17);
            label_contractHourlyRateAmount.TabIndex = 13;
            label_contractHourlyRateAmount.Text = "Hourly Rate";
            // 
            // comboBox_contractHourlyRateAmount
            // 
            comboBox_contractHourlyRateAmount.FormattingEnabled = true;
            comboBox_contractHourlyRateAmount.Location = new System.Drawing.Point(163, 150);
            comboBox_contractHourlyRateAmount.Name = "comboBox_contractHourlyRateAmount";
            comboBox_contractHourlyRateAmount.Size = new System.Drawing.Size(139, 25);
            comboBox_contractHourlyRateAmount.TabIndex = 14;
            // 
            // label_contractHourlyRateCreateCategory
            // 
            label_contractHourlyRateCreateCategory.AutoSize = true;
            label_contractHourlyRateCreateCategory.Location = new System.Drawing.Point(6, 120);
            label_contractHourlyRateCreateCategory.Name = "label_contractHourlyRateCreateCategory";
            label_contractHourlyRateCreateCategory.Size = new System.Drawing.Size(140, 17);
            label_contractHourlyRateCreateCategory.TabIndex = 7;
            label_contractHourlyRateCreateCategory.Text = "Hourly Rate Category";
            // 
            // comboBox_contractHourlyRateCreateCategory
            // 
            comboBox_contractHourlyRateCreateCategory.FormattingEnabled = true;
            comboBox_contractHourlyRateCreateCategory.Location = new System.Drawing.Point(163, 117);
            comboBox_contractHourlyRateCreateCategory.Name = "comboBox_contractHourlyRateCreateCategory";
            comboBox_contractHourlyRateCreateCategory.Size = new System.Drawing.Size(139, 25);
            comboBox_contractHourlyRateCreateCategory.TabIndex = 8;
            // 
            // label_contractHourlyRateContractName
            // 
            label_contractHourlyRateContractName.AutoSize = true;
            label_contractHourlyRateContractName.Location = new System.Drawing.Point(6, 89);
            label_contractHourlyRateContractName.Name = "label_contractHourlyRateContractName";
            label_contractHourlyRateContractName.Size = new System.Drawing.Size(100, 17);
            label_contractHourlyRateContractName.TabIndex = 1;
            label_contractHourlyRateContractName.Text = "Contract Name";
            // 
            // comboBox_contractHourlyRateContractName
            // 
            comboBox_contractHourlyRateContractName.FormattingEnabled = true;
            comboBox_contractHourlyRateContractName.Location = new System.Drawing.Point(163, 86);
            comboBox_contractHourlyRateContractName.Name = "comboBox_contractHourlyRateContractName";
            comboBox_contractHourlyRateContractName.Size = new System.Drawing.Size(139, 25);
            comboBox_contractHourlyRateContractName.TabIndex = 3;
            // 
            // label_contractHourlyRateProjectNo
            // 
            label_contractHourlyRateProjectNo.AutoSize = true;
            label_contractHourlyRateProjectNo.Location = new System.Drawing.Point(6, 58);
            label_contractHourlyRateProjectNo.Name = "label_contractHourlyRateProjectNo";
            label_contractHourlyRateProjectNo.Size = new System.Drawing.Size(72, 17);
            label_contractHourlyRateProjectNo.TabIndex = 1;
            label_contractHourlyRateProjectNo.Text = "Project No";
            // 
            // comboBox_contractHourlyRateProjectNo
            // 
            comboBox_contractHourlyRateProjectNo.FormattingEnabled = true;
            comboBox_contractHourlyRateProjectNo.Location = new System.Drawing.Point(163, 55);
            comboBox_contractHourlyRateProjectNo.Name = "comboBox_contractHourlyRateProjectNo";
            comboBox_contractHourlyRateProjectNo.Size = new System.Drawing.Size(139, 25);
            comboBox_contractHourlyRateProjectNo.TabIndex = 3;
            // 
            // label_contractHourlyRateSetup
            // 
            label_contractHourlyRateSetup.AutoSize = true;
            label_contractHourlyRateSetup.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            label_contractHourlyRateSetup.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            label_contractHourlyRateSetup.Location = new System.Drawing.Point(7, 16);
            label_contractHourlyRateSetup.Name = "label_contractHourlyRateSetup";
            label_contractHourlyRateSetup.Size = new System.Drawing.Size(285, 32);
            label_contractHourlyRateSetup.TabIndex = 0;
            label_contractHourlyRateSetup.Text = "Hourly Rate Data Import";
            // 
            // button_contractHourlyRateSelectFile
            // 
            button_contractHourlyRateSelectFile.BackColor = System.Drawing.Color.FromArgb(226, 43, 141);
            button_contractHourlyRateSelectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            button_contractHourlyRateSelectFile.FlatAppearance.BorderSize = 0;
            button_contractHourlyRateSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_contractHourlyRateSelectFile.ForeColor = System.Drawing.Color.White;
            button_contractHourlyRateSelectFile.Location = new System.Drawing.Point(13, 111);
            button_contractHourlyRateSelectFile.Name = "button_contractHourlyRateSelectFile";
            button_contractHourlyRateSelectFile.Size = new System.Drawing.Size(80, 29);
            button_contractHourlyRateSelectFile.TabIndex = 4;
            button_contractHourlyRateSelectFile.Text = "Select File";
            defaultToolTip.SetToolTip(button_contractHourlyRateSelectFile, "Select input CSV file");
            button_contractHourlyRateSelectFile.UseVisualStyleBackColor = false;
            button_contractHourlyRateSelectFile.Click += button_select_contractHourlyRate_file_Click;
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
            // UserControl_HourlyRateImport
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel_contractHourlyRateFieldMapping);
            Controls.Add(panel_contractHourlyRateButtons);
            Controls.Add(panel_contractHourlyRateMessage);
            Controls.Add(panel_contractHourlyRateDataTable);
            Name = "UserControl_HourlyRateImport";
            Size = new System.Drawing.Size(1006, 642);
            Load += UserControl1_Load;
            panel_contractHourlyRateDataTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_contractHourlyRate).EndInit();
            panel_contractHourlyRateMessage.ResumeLayout(false);
            panel_contractHourlyRateMessage.PerformLayout();
            panel_contractHourlyRateButtons.ResumeLayout(false);
            panel_contractHourlyRateFieldMapping.ResumeLayout(false);
            panel_contractHourlyRateFieldMapping.PerformLayout();
            flowLayoutPanel_nonMandatoryFields.ResumeLayout(false);
            panel_NonMandatoryButton.ResumeLayout(false);
            panel_NonMandatoryButton.PerformLayout();
            panel_NonMandatoryFields.ResumeLayout(false);
            panel_NonMandatoryFields.PerformLayout();
            groupBox_contractHourlyRateMandatoryFields.ResumeLayout(false);
            groupBox_contractHourlyRateMandatoryFields.PerformLayout();
            ResumeLayout(false);

        }

        #endregion


        private void AddRowNumberToDataTable()
        {
            this.dataGridView_contractHourlyRate.DataBindingComplete += (o, e) =>
            {
                foreach (System.Windows.Forms.DataGridViewRow row in dataGridView_contractHourlyRate.Rows)
                {
                    row.HeaderCell.Value = (row.Index + 1).ToString();

                }
            };
            this.dataGridView_contractHourlyRate.RowHeadersWidth = 65;
        }


        private System.ComponentModel.BackgroundWorker WorkerFetcher;
        private System.Windows.Forms.Panel panel_contractHourlyRateDataTable;
        private System.Windows.Forms.DataGridView dataGridView_contractHourlyRate;
        private System.Windows.Forms.Panel panel_contractHourlyRateMessage;
        private System.Windows.Forms.Panel panel_contractHourlyRateButtons;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_import;
        private System.Windows.Forms.Button button_validate;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Panel panel_contractHourlyRateFieldMapping;
        private System.Windows.Forms.GroupBox groupBox_contractHourlyRateMandatoryFields;


        private System.Windows.Forms.Label label_contractHourlyRateSetup;
        private System.Windows.Forms.Button button_contractHourlyRateSelectFile;
        private System.Windows.Forms.TextBox textBox_contractHourlyRateImportMessages;

        private System.Windows.Forms.Label label_contractHourlyRateContractName;
        private System.Windows.Forms.ComboBox comboBox_contractHourlyRateContractName;

        private System.Windows.Forms.Label label_contractHourlyRateProjectNo;
        private System.Windows.Forms.ComboBox comboBox_contractHourlyRateProjectNo;

        private System.Windows.Forms.Label label_contractHourlyRateName;
        private System.Windows.Forms.ComboBox comboBox_contractHourlyRateName;

        private System.Windows.Forms.Label label_contractHourlyRateAmount;
        private System.Windows.Forms.ComboBox comboBox_contractHourlyRateAmount;

        private System.Windows.Forms.Label label_contractHourlyRateProductNo;
        private System.Windows.Forms.ComboBox comboBox_contractHourlyRateProductNo;

        private System.Windows.Forms.Label label_contractHourlyRateCreateCategory;
        private System.Windows.Forms.ComboBox comboBox_contractHourlyRateCreateCategory;


        private System.Windows.Forms.Label label_delimiter;
        private System.Windows.Forms.ComboBox comboBox_delimiter;

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_nonMandatoryFields;
        private System.Windows.Forms.Panel panel_NonMandatoryButton;
        private System.Windows.Forms.Panel panel_NonMandatoryFields;
        private System.Windows.Forms.Label label_nonMandatoryFields;
        private System.Windows.Forms.Button button_expandNonMandatory;
        private System.Windows.Forms.Timer tmrExpand;
        private System.Windows.Forms.ToolTip defaultToolTip;

        

    }
}
