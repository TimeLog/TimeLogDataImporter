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
            this.components = new System.ComponentModel.Container();
            this.WorkerFetcher = new System.ComponentModel.BackgroundWorker();
            this.panel_contractHourlyRateDataTable = new System.Windows.Forms.Panel();
            this.dataGridView_contractHourlyRate = new System.Windows.Forms.DataGridView();
            this.panel_contractHourlyRateMessage = new System.Windows.Forms.Panel();
            this.textBox_contractHourlyRateImportMessages = new System.Windows.Forms.TextBox();
            this.panel_contractHourlyRateButtons = new System.Windows.Forms.Panel();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_import = new System.Windows.Forms.Button();
            this.button_validate = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.panel_contractHourlyRateFieldMapping = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_nonMandatoryFields = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_NonMandatoryButton = new System.Windows.Forms.Panel();
            this.label_nonMandatoryFields = new System.Windows.Forms.Label();
            this.button_expandNonMandatory = new System.Windows.Forms.Button();
            this.panel_NonMandatoryFields = new System.Windows.Forms.Panel();
            this.label_delimiter = new System.Windows.Forms.Label();
            this.comboBox_delimiter = new System.Windows.Forms.ComboBox();
            this.groupBox_contractHourlyRateMandatoryFields = new System.Windows.Forms.GroupBox();
            this.label_contractHourlyRateName = new System.Windows.Forms.Label();
            this.comboBox_contractHourlyRateName = new System.Windows.Forms.ComboBox();
            this.label_contractHourlyRateAmount = new System.Windows.Forms.Label();
            this.comboBox_contractHourlyRateAmount = new System.Windows.Forms.ComboBox();
            this.label_contractHourlyRateProductNo = new System.Windows.Forms.Label();
            this.comboBox_contractHourlyRateProductNo = new System.Windows.Forms.ComboBox();
            this.label_contractHourlyRateCreateCategory = new System.Windows.Forms.Label();
            this.comboBox_contractHourlyRateCreateCategory = new System.Windows.Forms.ComboBox();
            this.label_contractHourlyRateContractName = new System.Windows.Forms.Label();
            this.comboBox_contractHourlyRateContractName = new System.Windows.Forms.ComboBox();
            this.label_contractHourlyRateProjectNo = new System.Windows.Forms.Label();
            this.comboBox_contractHourlyRateProjectNo = new System.Windows.Forms.ComboBox();
            this.label_contractHourlyRateSetup = new System.Windows.Forms.Label();
            this.button_contractHourlyRateSelectFile = new System.Windows.Forms.Button();
            this.tmrExpand = new System.Windows.Forms.Timer(this.components);
            this.defaultToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel_contractHourlyRateDataTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_contractHourlyRate)).BeginInit();
            this.panel_contractHourlyRateMessage.SuspendLayout();
            this.panel_contractHourlyRateButtons.SuspendLayout();
            this.panel_contractHourlyRateFieldMapping.SuspendLayout();
            this.flowLayoutPanel_nonMandatoryFields.SuspendLayout();
            this.panel_NonMandatoryButton.SuspendLayout();
            this.panel_NonMandatoryFields.SuspendLayout();
            this.groupBox_contractHourlyRateMandatoryFields.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkerFetcher
            // 
            this.WorkerFetcher.WorkerReportsProgress = true;
            this.WorkerFetcher.WorkerSupportsCancellation = true;
            this.WorkerFetcher.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WorkerFetcherDoWork);
            // 
            // panel_contractHourlyRateDataTable
            // 
            this.panel_contractHourlyRateDataTable.Controls.Add(this.dataGridView_contractHourlyRate);
            this.panel_contractHourlyRateDataTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_contractHourlyRateDataTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_contractHourlyRateDataTable.Location = new System.Drawing.Point(0, 462);
            this.panel_contractHourlyRateDataTable.Name = "panel_contractHourlyRateDataTable";
            this.panel_contractHourlyRateDataTable.Size = new System.Drawing.Size(1006, 180);
            this.panel_contractHourlyRateDataTable.TabIndex = 6;
            // 
            // dataGridView_contractHourlyRate
            // 
            this.dataGridView_contractHourlyRate.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView_contractHourlyRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_contractHourlyRate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_contractHourlyRate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_contractHourlyRate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dataGridView_contractHourlyRate.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_contractHourlyRate.Name = "dataGridView_contractHourlyRate";
            this.dataGridView_contractHourlyRate.RowHeadersWidth = 62;
            this.dataGridView_contractHourlyRate.Size = new System.Drawing.Size(1006, 180);
            this.dataGridView_contractHourlyRate.TabIndex = 0;
            // 
            // panel_contractHourlyRateMessage
            // 
            this.panel_contractHourlyRateMessage.Controls.Add(this.textBox_contractHourlyRateImportMessages);
            this.panel_contractHourlyRateMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_contractHourlyRateMessage.Location = new System.Drawing.Point(0, 278);
            this.panel_contractHourlyRateMessage.Name = "panel_contractHourlyRateMessage";
            this.panel_contractHourlyRateMessage.Size = new System.Drawing.Size(1006, 184);
            this.panel_contractHourlyRateMessage.TabIndex = 10;
            // 
            // textBox_contractHourlyRateImportMessages
            // 
            this.textBox_contractHourlyRateImportMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_contractHourlyRateImportMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_contractHourlyRateImportMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_contractHourlyRateImportMessages.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_contractHourlyRateImportMessages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_contractHourlyRateImportMessages.Location = new System.Drawing.Point(0, 0);
            this.textBox_contractHourlyRateImportMessages.Multiline = true;
            this.textBox_contractHourlyRateImportMessages.Name = "textBox_contractHourlyRateImportMessages";
            this.textBox_contractHourlyRateImportMessages.ReadOnly = true;
            this.textBox_contractHourlyRateImportMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_contractHourlyRateImportMessages.Size = new System.Drawing.Size(1006, 184);
            this.textBox_contractHourlyRateImportMessages.TabIndex = 0;
            this.defaultToolTip.SetToolTip(this.textBox_contractHourlyRateImportMessages, "Validation or import status");
            this.textBox_contractHourlyRateImportMessages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_contractHourlyRateImportMessages_MouseClick);
            // 
            // panel_contractHourlyRateButtons
            // 
            this.panel_contractHourlyRateButtons.Controls.Add(this.button_clear);
            this.panel_contractHourlyRateButtons.Controls.Add(this.button_import);
            this.panel_contractHourlyRateButtons.Controls.Add(this.button_validate);
            this.panel_contractHourlyRateButtons.Controls.Add(this.button_stop);
            this.panel_contractHourlyRateButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_contractHourlyRateButtons.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel_contractHourlyRateButtons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_contractHourlyRateButtons.Location = new System.Drawing.Point(0, 226);
            this.panel_contractHourlyRateButtons.Name = "panel_contractHourlyRateButtons";
            this.panel_contractHourlyRateButtons.Size = new System.Drawing.Size(1006, 52);
            this.panel_contractHourlyRateButtons.TabIndex = 12;
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
            // panel_contractHourlyRateFieldMapping
            // 
            this.panel_contractHourlyRateFieldMapping.AutoScroll = true;
            this.panel_contractHourlyRateFieldMapping.Controls.Add(this.flowLayoutPanel_nonMandatoryFields);
            this.panel_contractHourlyRateFieldMapping.Controls.Add(this.label_delimiter);
            this.panel_contractHourlyRateFieldMapping.Controls.Add(this.comboBox_delimiter);
            this.panel_contractHourlyRateFieldMapping.Controls.Add(this.groupBox_contractHourlyRateMandatoryFields);
            this.panel_contractHourlyRateFieldMapping.Controls.Add(this.label_contractHourlyRateSetup);
            this.panel_contractHourlyRateFieldMapping.Controls.Add(this.button_contractHourlyRateSelectFile);
            this.panel_contractHourlyRateFieldMapping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contractHourlyRateFieldMapping.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel_contractHourlyRateFieldMapping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_contractHourlyRateFieldMapping.Location = new System.Drawing.Point(0, 0);
            this.panel_contractHourlyRateFieldMapping.Name = "panel_contractHourlyRateFieldMapping";
            this.panel_contractHourlyRateFieldMapping.Size = new System.Drawing.Size(1006, 226);
            this.panel_contractHourlyRateFieldMapping.TabIndex = 13;
            // 
            // flowLayoutPanel_nonMandatoryFields
            // 
            this.flowLayoutPanel_nonMandatoryFields.Controls.Add(this.panel_NonMandatoryButton);
            this.flowLayoutPanel_nonMandatoryFields.Controls.Add(this.panel_NonMandatoryFields);
            this.flowLayoutPanel_nonMandatoryFields.Location = new System.Drawing.Point(589, 60);
            this.flowLayoutPanel_nonMandatoryFields.Name = "flowLayoutPanel_nonMandatoryFields";
            this.flowLayoutPanel_nonMandatoryFields.Size = new System.Drawing.Size(372, 208);
            this.flowLayoutPanel_nonMandatoryFields.TabIndex = 7;
            // 
            // panel_NonMandatoryButton
            // 
            this.panel_NonMandatoryButton.Controls.Add(this.label_nonMandatoryFields);
            this.panel_NonMandatoryButton.Controls.Add(this.button_expandNonMandatory);
            this.panel_NonMandatoryButton.Location = new System.Drawing.Point(3, 3);
            this.panel_NonMandatoryButton.Name = "panel_NonMandatoryButton";
            this.panel_NonMandatoryButton.Size = new System.Drawing.Size(363, 32);
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
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_contractHourlyRateProductNo);
            this.panel_NonMandatoryFields.Controls.Add(this.label_contractHourlyRateProductNo);
            this.panel_NonMandatoryFields.Location = new System.Drawing.Point(3, 41);
            this.panel_NonMandatoryFields.MaximumSize = new System.Drawing.Size(363, 163);
            this.panel_NonMandatoryFields.MinimumSize = new System.Drawing.Size(363, 0);
            this.panel_NonMandatoryFields.Name = "panel_NonMandatoryFields";
            this.panel_NonMandatoryFields.Size = new System.Drawing.Size(363, 109);
            this.panel_NonMandatoryFields.TabIndex = 1;
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
            // groupBox_contractHourlyRateMandatoryFields
            // 
            this.groupBox_contractHourlyRateMandatoryFields.Controls.Add(this.label_contractHourlyRateName);
            this.groupBox_contractHourlyRateMandatoryFields.Controls.Add(this.comboBox_contractHourlyRateName);
            this.groupBox_contractHourlyRateMandatoryFields.Controls.Add(this.label_contractHourlyRateAmount);
            this.groupBox_contractHourlyRateMandatoryFields.Controls.Add(this.comboBox_contractHourlyRateAmount);
            this.groupBox_contractHourlyRateMandatoryFields.Controls.Add(this.label_contractHourlyRateCreateCategory);
            this.groupBox_contractHourlyRateMandatoryFields.Controls.Add(this.comboBox_contractHourlyRateCreateCategory);
            this.groupBox_contractHourlyRateMandatoryFields.Controls.Add(this.label_contractHourlyRateContractName);
            this.groupBox_contractHourlyRateMandatoryFields.Controls.Add(this.comboBox_contractHourlyRateContractName);
            this.groupBox_contractHourlyRateMandatoryFields.Controls.Add(this.label_contractHourlyRateProjectNo);
            this.groupBox_contractHourlyRateMandatoryFields.Controls.Add(this.comboBox_contractHourlyRateProjectNo);
            this.groupBox_contractHourlyRateMandatoryFields.Location = new System.Drawing.Point(184, 62);
            this.groupBox_contractHourlyRateMandatoryFields.Name = "groupBox_contractHourlyRateMandatoryFields";
            this.groupBox_contractHourlyRateMandatoryFields.Size = new System.Drawing.Size(358, 399);
            this.groupBox_contractHourlyRateMandatoryFields.TabIndex = 5;
            this.groupBox_contractHourlyRateMandatoryFields.TabStop = false;
            this.groupBox_contractHourlyRateMandatoryFields.Text = "Mandatory";
            // 
            // label_contractHourlyRateName
            // 
            this.label_contractHourlyRateName.AutoSize = true;
            this.label_contractHourlyRateName.Location = new System.Drawing.Point(6, 184);
            this.label_contractHourlyRateName.Name = "label_contractHourlyRateName";
            this.label_contractHourlyRateName.Size = new System.Drawing.Size(120, 17);
            this.label_contractHourlyRateName.TabIndex = 15;
            this.label_contractHourlyRateName.Text = "Hourly Rate Name";
            // 
            // comboBox_contractHourlyRateName
            // 
            this.comboBox_contractHourlyRateName.FormattingEnabled = true;
            this.comboBox_contractHourlyRateName.Location = new System.Drawing.Point(138, 181);
            this.comboBox_contractHourlyRateName.Name = "comboBox_contractHourlyRateName";
            this.comboBox_contractHourlyRateName.Size = new System.Drawing.Size(139, 25);
            this.comboBox_contractHourlyRateName.TabIndex = 16;
            // 
            // label_contractHourlyRateAmount
            // 
            this.label_contractHourlyRateAmount.AutoSize = true;
            this.label_contractHourlyRateAmount.Location = new System.Drawing.Point(6, 153);
            this.label_contractHourlyRateAmount.Name = "label_contractHourlyRateAmount";
            this.label_contractHourlyRateAmount.Size = new System.Drawing.Size(80, 17);
            this.label_contractHourlyRateAmount.TabIndex = 13;
            this.label_contractHourlyRateAmount.Text = "Hourly Rate";
            // 
            // comboBox_contractHourlyRateAmount
            // 
            this.comboBox_contractHourlyRateAmount.FormattingEnabled = true;
            this.comboBox_contractHourlyRateAmount.Location = new System.Drawing.Point(138, 150);
            this.comboBox_contractHourlyRateAmount.Name = "comboBox_contractHourlyRateAmount";
            this.comboBox_contractHourlyRateAmount.Size = new System.Drawing.Size(139, 25);
            this.comboBox_contractHourlyRateAmount.TabIndex = 14;
            // 
            // label_contractHourlyRateProductNo
            // 
            this.label_contractHourlyRateProductNo.AutoSize = true;
            this.label_contractHourlyRateProductNo.Location = new System.Drawing.Point(8, 19);
            this.label_contractHourlyRateProductNo.Name = "label_contractHourlyRateProductNo";
            this.label_contractHourlyRateProductNo.Size = new System.Drawing.Size(78, 17);
            this.label_contractHourlyRateProductNo.TabIndex = 11;
            this.label_contractHourlyRateProductNo.Text = "Product No";
            // 
            // comboBox_contractHourlyRateProductNo
            // 
            this.comboBox_contractHourlyRateProductNo.FormattingEnabled = true;
            this.comboBox_contractHourlyRateProductNo.Location = new System.Drawing.Point(140, 16);
            this.comboBox_contractHourlyRateProductNo.Name = "comboBox_contractHourlyRateProductNo";
            this.comboBox_contractHourlyRateProductNo.Size = new System.Drawing.Size(139, 25);
            this.comboBox_contractHourlyRateProductNo.TabIndex = 12;
            // 
            // label_contractHourlyRateCreateCategory
            // 
            this.label_contractHourlyRateCreateCategory.AutoSize = true;
            this.label_contractHourlyRateCreateCategory.Location = new System.Drawing.Point(6, 120);
            this.label_contractHourlyRateCreateCategory.Name = "label_contractHourlyRateCreateCategory";
            this.label_contractHourlyRateCreateCategory.Size = new System.Drawing.Size(140, 17);
            this.label_contractHourlyRateCreateCategory.TabIndex = 7;
            this.label_contractHourlyRateCreateCategory.Text = "Hourly Rate Category";
            // 
            // comboBox_contractHourlyRateCreateCategory
            // 
            this.comboBox_contractHourlyRateCreateCategory.FormattingEnabled = true;
            this.comboBox_contractHourlyRateCreateCategory.Location = new System.Drawing.Point(138, 117);
            this.comboBox_contractHourlyRateCreateCategory.Name = "comboBox_contractHourlyRateCreateCategory";
            this.comboBox_contractHourlyRateCreateCategory.Size = new System.Drawing.Size(139, 25);
            this.comboBox_contractHourlyRateCreateCategory.TabIndex = 8;
            // 
            // label_contractHourlyRateContractName
            // 
            this.label_contractHourlyRateContractName.AutoSize = true;
            this.label_contractHourlyRateContractName.Location = new System.Drawing.Point(6, 89);
            this.label_contractHourlyRateContractName.Name = "label_contractHourlyRateContractName";
            this.label_contractHourlyRateContractName.Size = new System.Drawing.Size(100, 17);
            this.label_contractHourlyRateContractName.TabIndex = 1;
            this.label_contractHourlyRateContractName.Text = "Contract Name";
            // 
            // comboBox_contractHourlyRateContractName
            // 
            this.comboBox_contractHourlyRateContractName.FormattingEnabled = true;
            this.comboBox_contractHourlyRateContractName.Location = new System.Drawing.Point(138, 86);
            this.comboBox_contractHourlyRateContractName.Name = "comboBox_contractHourlyRateContractName";
            this.comboBox_contractHourlyRateContractName.Size = new System.Drawing.Size(139, 25);
            this.comboBox_contractHourlyRateContractName.TabIndex = 3;
            // 
            // label_contractHourlyRateProjectNo
            // 
            this.label_contractHourlyRateProjectNo.AutoSize = true;
            this.label_contractHourlyRateProjectNo.Location = new System.Drawing.Point(6, 58);
            this.label_contractHourlyRateProjectNo.Name = "label_contractHourlyRateProjectNo";
            this.label_contractHourlyRateProjectNo.Size = new System.Drawing.Size(72, 17);
            this.label_contractHourlyRateProjectNo.TabIndex = 1;
            this.label_contractHourlyRateProjectNo.Text = "Project No";
            // 
            // comboBox_contractHourlyRateProjectNo
            // 
            this.comboBox_contractHourlyRateProjectNo.FormattingEnabled = true;
            this.comboBox_contractHourlyRateProjectNo.Location = new System.Drawing.Point(138, 55);
            this.comboBox_contractHourlyRateProjectNo.Name = "comboBox_contractHourlyRateProjectNo";
            this.comboBox_contractHourlyRateProjectNo.Size = new System.Drawing.Size(139, 25);
            this.comboBox_contractHourlyRateProjectNo.TabIndex = 3;
            // 
            // label_contractHourlyRateSetup
            // 
            this.label_contractHourlyRateSetup.AutoSize = true;
            this.label_contractHourlyRateSetup.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_contractHourlyRateSetup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_contractHourlyRateSetup.Location = new System.Drawing.Point(7, 16);
            this.label_contractHourlyRateSetup.Name = "label_contractHourlyRateSetup";
            this.label_contractHourlyRateSetup.Size = new System.Drawing.Size(285, 32);
            this.label_contractHourlyRateSetup.TabIndex = 0;
            this.label_contractHourlyRateSetup.Text = "Hourly Rate Data Import";
            // 
            // button_contractHourlyRateSelectFile
            // 
            this.button_contractHourlyRateSelectFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(43)))), ((int)(((byte)(141)))));
            this.button_contractHourlyRateSelectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_contractHourlyRateSelectFile.FlatAppearance.BorderSize = 0;
            this.button_contractHourlyRateSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_contractHourlyRateSelectFile.ForeColor = System.Drawing.Color.White;
            this.button_contractHourlyRateSelectFile.Location = new System.Drawing.Point(13, 111);
            this.button_contractHourlyRateSelectFile.Name = "button_contractHourlyRateSelectFile";
            this.button_contractHourlyRateSelectFile.Size = new System.Drawing.Size(80, 29);
            this.button_contractHourlyRateSelectFile.TabIndex = 4;
            this.button_contractHourlyRateSelectFile.Text = "Select File";
            this.defaultToolTip.SetToolTip(this.button_contractHourlyRateSelectFile, "Select input CSV file");
            this.button_contractHourlyRateSelectFile.UseVisualStyleBackColor = false;
            this.button_contractHourlyRateSelectFile.Click += new System.EventHandler(this.button_select_contractHourlyRate_file_Click);
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
            // UserControl_HourlyRateImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_contractHourlyRateFieldMapping);
            this.Controls.Add(this.panel_contractHourlyRateButtons);
            this.Controls.Add(this.panel_contractHourlyRateMessage);
            this.Controls.Add(this.panel_contractHourlyRateDataTable);
            this.Name = "UserControl_HourlyRateImport";
            this.Size = new System.Drawing.Size(1006, 642);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.panel_contractHourlyRateDataTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_contractHourlyRate)).EndInit();
            this.panel_contractHourlyRateMessage.ResumeLayout(false);
            this.panel_contractHourlyRateMessage.PerformLayout();
            this.panel_contractHourlyRateButtons.ResumeLayout(false);
            this.panel_contractHourlyRateFieldMapping.ResumeLayout(false);
            this.panel_contractHourlyRateFieldMapping.PerformLayout();
            this.flowLayoutPanel_nonMandatoryFields.ResumeLayout(false);
            this.panel_NonMandatoryButton.ResumeLayout(false);
            this.panel_NonMandatoryButton.PerformLayout();
            this.panel_NonMandatoryFields.ResumeLayout(false);
            this.panel_NonMandatoryFields.PerformLayout();
            this.groupBox_contractHourlyRateMandatoryFields.ResumeLayout(false);
            this.groupBox_contractHourlyRateMandatoryFields.PerformLayout();
            this.ResumeLayout(false);

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
