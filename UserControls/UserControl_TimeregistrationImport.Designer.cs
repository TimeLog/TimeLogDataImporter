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
            this.components = new System.ComponentModel.Container();
            this.WorkerFetcher = new System.ComponentModel.BackgroundWorker();
            this.panel_timeregistrationDataTable = new System.Windows.Forms.Panel();
            this.dataGridView_timeregistration = new System.Windows.Forms.DataGridView();
            this.panel_timeregistrationMessage = new System.Windows.Forms.Panel();
            this.textBox_timeregistrationImportMessages = new System.Windows.Forms.TextBox();
            this.panel_timeregistrationButtons = new System.Windows.Forms.Panel();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_import = new System.Windows.Forms.Button();
            this.button_validate = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.panel_timeregistrationFieldMapping = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_nonMandatoryFields = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_NonMandatoryButton = new System.Windows.Forms.Panel();
            this.label_nonMandatoryFields = new System.Windows.Forms.Label();
            this.button_expandNonMandatory = new System.Windows.Forms.Button();
            this.panel_NonMandatoryFields = new System.Windows.Forms.Panel();
            this.label_timeregistrationComment = new System.Windows.Forms.Label();
            this.comboBox_timeregistrationComment = new System.Windows.Forms.ComboBox();
            this.comboBox_timeregistrationAdditionalComment = new System.Windows.Forms.ComboBox();
            this.label__timeregistrationAdditionalComment = new System.Windows.Forms.Label();
            this.comboBox_timeregistrationMonthlyPeriod = new System.Windows.Forms.ComboBox();
            this.label_timeregistrationMonthlyPeriod = new System.Windows.Forms.Label();
            this.label_delimiter = new System.Windows.Forms.Label();
            this.comboBox_delimiter = new System.Windows.Forms.ComboBox();
            this.groupBox_timeregistrationMandatoryFields = new System.Windows.Forms.GroupBox();
            this.label_timeregistrationAbsenceCode = new System.Windows.Forms.Label();
            this.comboBox_timeregistrationAbcenseCode = new System.Windows.Forms.ComboBox();
            this.label_timeregistrationCostPriceName = new System.Windows.Forms.Label();
            this.comboBox_timeregistrationCostPriceName = new System.Windows.Forms.ComboBox();
            this.label_timeregistrationCostPrice = new System.Windows.Forms.Label();
            this.comboBox_timeregistrationCostPrice = new System.Windows.Forms.ComboBox();
            this.label_timeregistrationHourlyRateName = new System.Windows.Forms.Label();
            this.comboBox_timeregistrationHourlyRateName = new System.Windows.Forms.ComboBox();
            this.label_timeregistrationHourlyRate = new System.Windows.Forms.Label();
            this.comboBox_timeregistrationHourlyRate = new System.Windows.Forms.ComboBox();
            this.label_timeregistrationBillableHours = new System.Windows.Forms.Label();
            this.comboBox_timeregistrationBillableHours = new System.Windows.Forms.ComboBox();
            this.label_timeregistrationIsBillable = new System.Windows.Forms.Label();
            this.comboBox_timeregistrationIsBillable = new System.Windows.Forms.ComboBox();
            this.label_timeregistrationHours = new System.Windows.Forms.Label();
            this.comboBox_timeregistrationHours = new System.Windows.Forms.ComboBox();
            this.label_timeregistrationDate = new System.Windows.Forms.Label();
            this.label_timeregistrationGroupType = new System.Windows.Forms.Label();
            this.comboBox_timeregistrationDate = new System.Windows.Forms.ComboBox();
            this.label_timeregistrationUserInitials = new System.Windows.Forms.Label();
            this.comboBox_timeregistrationUserInitials = new System.Windows.Forms.ComboBox();
            this.label_timeregistrationContractName = new System.Windows.Forms.Label();
            this.comboBox_timeregistrationGroupType = new System.Windows.Forms.ComboBox();
            this.comboBox_timeregistrationContractName = new System.Windows.Forms.ComboBox();
            this.label_timeregistrationProjectNo = new System.Windows.Forms.Label();
            this.comboBox_timeregistrationProjectNo = new System.Windows.Forms.ComboBox();
            this.label_timeregistrationTaskNo = new System.Windows.Forms.Label();
            this.comboBox_timeregistrationTaskNo = new System.Windows.Forms.ComboBox();
            this.label_timeregistrationSetup = new System.Windows.Forms.Label();
            this.button_timeregistrationSelectFile = new System.Windows.Forms.Button();
            this.tmrExpand = new System.Windows.Forms.Timer(this.components);
            this.defaultToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel_timeregistrationDataTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_timeregistration)).BeginInit();
            this.panel_timeregistrationMessage.SuspendLayout();
            this.panel_timeregistrationButtons.SuspendLayout();
            this.panel_timeregistrationFieldMapping.SuspendLayout();
            this.flowLayoutPanel_nonMandatoryFields.SuspendLayout();
            this.panel_NonMandatoryButton.SuspendLayout();
            this.panel_NonMandatoryFields.SuspendLayout();
            this.groupBox_timeregistrationMandatoryFields.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkerFetcher
            // 
            this.WorkerFetcher.WorkerReportsProgress = true;
            this.WorkerFetcher.WorkerSupportsCancellation = true;
            this.WorkerFetcher.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WorkerFetcherDoWork);
            // 
            // panel_timeregistrationDataTable
            // 
            this.panel_timeregistrationDataTable.Controls.Add(this.dataGridView_timeregistration);
            this.panel_timeregistrationDataTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_timeregistrationDataTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_timeregistrationDataTable.Location = new System.Drawing.Point(0, 770);
            this.panel_timeregistrationDataTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_timeregistrationDataTable.Name = "panel_timeregistrationDataTable";
            this.panel_timeregistrationDataTable.Size = new System.Drawing.Size(1437, 300);
            this.panel_timeregistrationDataTable.TabIndex = 6;
            // 
            // dataGridView_timeregistration
            // 
            this.dataGridView_timeregistration.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView_timeregistration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_timeregistration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_timeregistration.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_timeregistration.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dataGridView_timeregistration.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_timeregistration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_timeregistration.Name = "dataGridView_timeregistration";
            this.dataGridView_timeregistration.RowHeadersWidth = 62;
            this.dataGridView_timeregistration.Size = new System.Drawing.Size(1437, 300);
            this.dataGridView_timeregistration.TabIndex = 0;
            // 
            // panel_timeregistrationMessage
            // 
            this.panel_timeregistrationMessage.Controls.Add(this.textBox_timeregistrationImportMessages);
            this.panel_timeregistrationMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_timeregistrationMessage.Location = new System.Drawing.Point(0, 463);
            this.panel_timeregistrationMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_timeregistrationMessage.Name = "panel_timeregistrationMessage";
            this.panel_timeregistrationMessage.Size = new System.Drawing.Size(1437, 307);
            this.panel_timeregistrationMessage.TabIndex = 10;
            // 
            // textBox_timeregistrationImportMessages
            // 
            this.textBox_timeregistrationImportMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_timeregistrationImportMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_timeregistrationImportMessages.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_timeregistrationImportMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_timeregistrationImportMessages.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_timeregistrationImportMessages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_timeregistrationImportMessages.Location = new System.Drawing.Point(0, 0);
            this.textBox_timeregistrationImportMessages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_timeregistrationImportMessages.Multiline = true;
            this.textBox_timeregistrationImportMessages.Name = "textBox_timeregistrationImportMessages";
            this.textBox_timeregistrationImportMessages.ReadOnly = true;
            this.textBox_timeregistrationImportMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_timeregistrationImportMessages.Size = new System.Drawing.Size(1437, 307);
            this.textBox_timeregistrationImportMessages.TabIndex = 0;
            this.defaultToolTip.SetToolTip(this.textBox_timeregistrationImportMessages, "Validation or import status");
            this.textBox_timeregistrationImportMessages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_timeregistrationImportMessages_MouseClick);
            // 
            // panel_timeregistrationButtons
            // 
            this.panel_timeregistrationButtons.Controls.Add(this.button_clear);
            this.panel_timeregistrationButtons.Controls.Add(this.button_import);
            this.panel_timeregistrationButtons.Controls.Add(this.button_validate);
            this.panel_timeregistrationButtons.Controls.Add(this.button_stop);
            this.panel_timeregistrationButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_timeregistrationButtons.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel_timeregistrationButtons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_timeregistrationButtons.Location = new System.Drawing.Point(0, 376);
            this.panel_timeregistrationButtons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_timeregistrationButtons.Name = "panel_timeregistrationButtons";
            this.panel_timeregistrationButtons.Size = new System.Drawing.Size(1437, 87);
            this.panel_timeregistrationButtons.TabIndex = 12;
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
            // panel_timeregistrationFieldMapping
            // 
            this.panel_timeregistrationFieldMapping.AutoScroll = true;
            this.panel_timeregistrationFieldMapping.Controls.Add(this.flowLayoutPanel_nonMandatoryFields);
            this.panel_timeregistrationFieldMapping.Controls.Add(this.label_delimiter);
            this.panel_timeregistrationFieldMapping.Controls.Add(this.comboBox_delimiter);
            this.panel_timeregistrationFieldMapping.Controls.Add(this.groupBox_timeregistrationMandatoryFields);
            this.panel_timeregistrationFieldMapping.Controls.Add(this.label_timeregistrationSetup);
            this.panel_timeregistrationFieldMapping.Controls.Add(this.button_timeregistrationSelectFile);
            this.panel_timeregistrationFieldMapping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_timeregistrationFieldMapping.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel_timeregistrationFieldMapping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_timeregistrationFieldMapping.Location = new System.Drawing.Point(0, 0);
            this.panel_timeregistrationFieldMapping.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_timeregistrationFieldMapping.Name = "panel_timeregistrationFieldMapping";
            this.panel_timeregistrationFieldMapping.Size = new System.Drawing.Size(1437, 376);
            this.panel_timeregistrationFieldMapping.TabIndex = 13;
            // 
            // flowLayoutPanel_nonMandatoryFields
            // 
            this.flowLayoutPanel_nonMandatoryFields.Controls.Add(this.panel_NonMandatoryButton);
            this.flowLayoutPanel_nonMandatoryFields.Controls.Add(this.panel_NonMandatoryFields);
            this.flowLayoutPanel_nonMandatoryFields.Location = new System.Drawing.Point(841, 100);
            this.flowLayoutPanel_nonMandatoryFields.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel_nonMandatoryFields.Name = "flowLayoutPanel_nonMandatoryFields";
            this.flowLayoutPanel_nonMandatoryFields.Size = new System.Drawing.Size(531, 347);
            this.flowLayoutPanel_nonMandatoryFields.TabIndex = 7;
            // 
            // panel_NonMandatoryButton
            // 
            this.panel_NonMandatoryButton.Controls.Add(this.label_nonMandatoryFields);
            this.panel_NonMandatoryButton.Controls.Add(this.button_expandNonMandatory);
            this.panel_NonMandatoryButton.Location = new System.Drawing.Point(4, 5);
            this.panel_NonMandatoryButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_NonMandatoryButton.Name = "panel_NonMandatoryButton";
            this.panel_NonMandatoryButton.Size = new System.Drawing.Size(519, 53);
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
            this.panel_NonMandatoryFields.Controls.Add(this.label_timeregistrationComment);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_timeregistrationComment);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_timeregistrationAdditionalComment);
            this.panel_NonMandatoryFields.Controls.Add(this.label__timeregistrationAdditionalComment);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_timeregistrationMonthlyPeriod);
            this.panel_NonMandatoryFields.Controls.Add(this.label_timeregistrationMonthlyPeriod);
            this.panel_NonMandatoryFields.Location = new System.Drawing.Point(4, 68);
            this.panel_NonMandatoryFields.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_NonMandatoryFields.MaximumSize = new System.Drawing.Size(519, 272);
            this.panel_NonMandatoryFields.MinimumSize = new System.Drawing.Size(519, 0);
            this.panel_NonMandatoryFields.Name = "panel_NonMandatoryFields";
            this.panel_NonMandatoryFields.Size = new System.Drawing.Size(519, 181);
            this.panel_NonMandatoryFields.TabIndex = 1;
            // 
            // label_timeregistrationComment
            // 
            this.label_timeregistrationComment.AutoSize = true;
            this.label_timeregistrationComment.Location = new System.Drawing.Point(14, 17);
            this.label_timeregistrationComment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_timeregistrationComment.Name = "label_timeregistrationComment";
            this.label_timeregistrationComment.Size = new System.Drawing.Size(68, 17);
            this.label_timeregistrationComment.TabIndex = 1;
            this.label_timeregistrationComment.Text = "Comment";
            // 
            // comboBox_timeregistrationComment
            // 
            this.comboBox_timeregistrationComment.FormattingEnabled = true;
            this.comboBox_timeregistrationComment.Location = new System.Drawing.Point(204, 12);
            this.comboBox_timeregistrationComment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_timeregistrationComment.Name = "comboBox_timeregistrationComment";
            this.comboBox_timeregistrationComment.Size = new System.Drawing.Size(197, 25);
            this.comboBox_timeregistrationComment.TabIndex = 3;
            // 
            // comboBox_timeregistrationAdditionalComment
            // 
            this.comboBox_timeregistrationAdditionalComment.FormattingEnabled = true;
            this.comboBox_timeregistrationAdditionalComment.Location = new System.Drawing.Point(204, 63);
            this.comboBox_timeregistrationAdditionalComment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_timeregistrationAdditionalComment.Name = "comboBox_timeregistrationAdditionalComment";
            this.comboBox_timeregistrationAdditionalComment.Size = new System.Drawing.Size(197, 25);
            this.comboBox_timeregistrationAdditionalComment.TabIndex = 3;
            // 
            // label__timeregistrationAdditionalComment
            // 
            this.label__timeregistrationAdditionalComment.AutoSize = true;
            this.label__timeregistrationAdditionalComment.Location = new System.Drawing.Point(14, 68);
            this.label__timeregistrationAdditionalComment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label__timeregistrationAdditionalComment.Name = "label__timeregistrationAdditionalComment";
            this.label__timeregistrationAdditionalComment.Size = new System.Drawing.Size(134, 17);
            this.label__timeregistrationAdditionalComment.TabIndex = 1;
            this.label__timeregistrationAdditionalComment.Text = "Additional Comment";
            // 
            // comboBox_timeregistrationMonthlyPeriod
            // 
            this.comboBox_timeregistrationMonthlyPeriod.FormattingEnabled = true;
            this.comboBox_timeregistrationMonthlyPeriod.Location = new System.Drawing.Point(204, 115);
            this.comboBox_timeregistrationMonthlyPeriod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_timeregistrationMonthlyPeriod.Name = "comboBox_timeregistrationMonthlyPeriod";
            this.comboBox_timeregistrationMonthlyPeriod.Size = new System.Drawing.Size(197, 25);
            this.comboBox_timeregistrationMonthlyPeriod.TabIndex = 3;
            // 
            // label_timeregistrationMonthlyPeriod
            // 
            this.label_timeregistrationMonthlyPeriod.AutoSize = true;
            this.label_timeregistrationMonthlyPeriod.Location = new System.Drawing.Point(14, 120);
            this.label_timeregistrationMonthlyPeriod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_timeregistrationMonthlyPeriod.Name = "label_timeregistrationMonthlyPeriod";
            this.label_timeregistrationMonthlyPeriod.Size = new System.Drawing.Size(102, 17);
            this.label_timeregistrationMonthlyPeriod.TabIndex = 1;
            this.label_timeregistrationMonthlyPeriod.Text = "Monthly Period";
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
            // groupBox_timeregistrationMandatoryFields
            // 
            this.groupBox_timeregistrationMandatoryFields.Controls.Add(this.label_timeregistrationAbsenceCode);
            this.groupBox_timeregistrationMandatoryFields.Controls.Add(this.comboBox_timeregistrationAbcenseCode);
            this.groupBox_timeregistrationMandatoryFields.Controls.Add(this.label_timeregistrationCostPriceName);
            this.groupBox_timeregistrationMandatoryFields.Controls.Add(this.comboBox_timeregistrationCostPriceName);
            this.groupBox_timeregistrationMandatoryFields.Controls.Add(this.label_timeregistrationCostPrice);
            this.groupBox_timeregistrationMandatoryFields.Controls.Add(this.comboBox_timeregistrationCostPrice);
            this.groupBox_timeregistrationMandatoryFields.Controls.Add(this.label_timeregistrationHourlyRateName);
            this.groupBox_timeregistrationMandatoryFields.Controls.Add(this.comboBox_timeregistrationHourlyRateName);
            this.groupBox_timeregistrationMandatoryFields.Controls.Add(this.label_timeregistrationHourlyRate);
            this.groupBox_timeregistrationMandatoryFields.Controls.Add(this.comboBox_timeregistrationHourlyRate);
            this.groupBox_timeregistrationMandatoryFields.Controls.Add(this.label_timeregistrationBillableHours);
            this.groupBox_timeregistrationMandatoryFields.Controls.Add(this.comboBox_timeregistrationBillableHours);
            this.groupBox_timeregistrationMandatoryFields.Controls.Add(this.label_timeregistrationIsBillable);
            this.groupBox_timeregistrationMandatoryFields.Controls.Add(this.comboBox_timeregistrationIsBillable);
            this.groupBox_timeregistrationMandatoryFields.Controls.Add(this.label_timeregistrationHours);
            this.groupBox_timeregistrationMandatoryFields.Controls.Add(this.comboBox_timeregistrationHours);
            this.groupBox_timeregistrationMandatoryFields.Controls.Add(this.label_timeregistrationDate);
            this.groupBox_timeregistrationMandatoryFields.Controls.Add(this.label_timeregistrationGroupType);
            this.groupBox_timeregistrationMandatoryFields.Controls.Add(this.comboBox_timeregistrationDate);
            this.groupBox_timeregistrationMandatoryFields.Controls.Add(this.label_timeregistrationUserInitials);
            this.groupBox_timeregistrationMandatoryFields.Controls.Add(this.comboBox_timeregistrationUserInitials);
            this.groupBox_timeregistrationMandatoryFields.Controls.Add(this.label_timeregistrationContractName);
            this.groupBox_timeregistrationMandatoryFields.Controls.Add(this.comboBox_timeregistrationGroupType);
            this.groupBox_timeregistrationMandatoryFields.Controls.Add(this.comboBox_timeregistrationContractName);
            this.groupBox_timeregistrationMandatoryFields.Controls.Add(this.label_timeregistrationProjectNo);
            this.groupBox_timeregistrationMandatoryFields.Controls.Add(this.comboBox_timeregistrationProjectNo);
            this.groupBox_timeregistrationMandatoryFields.Controls.Add(this.label_timeregistrationTaskNo);
            this.groupBox_timeregistrationMandatoryFields.Controls.Add(this.comboBox_timeregistrationTaskNo);
            this.groupBox_timeregistrationMandatoryFields.Location = new System.Drawing.Point(263, 103);
            this.groupBox_timeregistrationMandatoryFields.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_timeregistrationMandatoryFields.Name = "groupBox_timeregistrationMandatoryFields";
            this.groupBox_timeregistrationMandatoryFields.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_timeregistrationMandatoryFields.Size = new System.Drawing.Size(511, 665);
            this.groupBox_timeregistrationMandatoryFields.TabIndex = 5;
            this.groupBox_timeregistrationMandatoryFields.TabStop = false;
            this.groupBox_timeregistrationMandatoryFields.Text = "Mandatory";
            // 
            // label_timeregistrationAbsenceCode
            // 
            this.label_timeregistrationAbsenceCode.AutoSize = true;
            this.label_timeregistrationAbsenceCode.Location = new System.Drawing.Point(9, 390);
            this.label_timeregistrationAbsenceCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_timeregistrationAbsenceCode.Name = "label_timeregistrationAbsenceCode";
            this.label_timeregistrationAbsenceCode.Size = new System.Drawing.Size(94, 17);
            this.label_timeregistrationAbsenceCode.TabIndex = 21;
            this.label_timeregistrationAbsenceCode.Text = "Absence Code";
            // 
            // comboBox_timeregistrationAbcenseCode
            // 
            this.comboBox_timeregistrationAbcenseCode.FormattingEnabled = true;
            this.comboBox_timeregistrationAbcenseCode.Location = new System.Drawing.Point(197, 385);
            this.comboBox_timeregistrationAbcenseCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_timeregistrationAbcenseCode.Name = "comboBox_timeregistrationAbcenseCode";
            this.comboBox_timeregistrationAbcenseCode.Size = new System.Drawing.Size(197, 25);
            this.comboBox_timeregistrationAbcenseCode.TabIndex = 22;
            // 
            // label_timeregistrationCostPriceName
            // 
            this.label_timeregistrationCostPriceName.AutoSize = true;
            this.label_timeregistrationCostPriceName.Location = new System.Drawing.Point(9, 597);
            this.label_timeregistrationCostPriceName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_timeregistrationCostPriceName.Name = "label_timeregistrationCostPriceName";
            this.label_timeregistrationCostPriceName.Size = new System.Drawing.Size(108, 17);
            this.label_timeregistrationCostPriceName.TabIndex = 19;
            this.label_timeregistrationCostPriceName.Text = "Cost Price Name";
            // 
            // comboBox_timeregistrationCostPriceName
            // 
            this.comboBox_timeregistrationCostPriceName.FormattingEnabled = true;
            this.comboBox_timeregistrationCostPriceName.Location = new System.Drawing.Point(197, 592);
            this.comboBox_timeregistrationCostPriceName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_timeregistrationCostPriceName.Name = "comboBox_timeregistrationCostPriceName";
            this.comboBox_timeregistrationCostPriceName.Size = new System.Drawing.Size(197, 25);
            this.comboBox_timeregistrationCostPriceName.TabIndex = 20;
            // 
            // label_timeregistrationCostPrice
            // 
            this.label_timeregistrationCostPrice.AutoSize = true;
            this.label_timeregistrationCostPrice.Location = new System.Drawing.Point(9, 562);
            this.label_timeregistrationCostPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_timeregistrationCostPrice.Name = "label_timeregistrationCostPrice";
            this.label_timeregistrationCostPrice.Size = new System.Drawing.Size(68, 17);
            this.label_timeregistrationCostPrice.TabIndex = 17;
            this.label_timeregistrationCostPrice.Text = "Cost Price";
            // 
            // comboBox_timeregistrationCostPrice
            // 
            this.comboBox_timeregistrationCostPrice.FormattingEnabled = true;
            this.comboBox_timeregistrationCostPrice.Location = new System.Drawing.Point(197, 557);
            this.comboBox_timeregistrationCostPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_timeregistrationCostPrice.Name = "comboBox_timeregistrationCostPrice";
            this.comboBox_timeregistrationCostPrice.Size = new System.Drawing.Size(197, 25);
            this.comboBox_timeregistrationCostPrice.TabIndex = 18;
            // 
            // label_timeregistrationHourlyRateName
            // 
            this.label_timeregistrationHourlyRateName.AutoSize = true;
            this.label_timeregistrationHourlyRateName.Location = new System.Drawing.Point(9, 527);
            this.label_timeregistrationHourlyRateName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_timeregistrationHourlyRateName.Name = "label_timeregistrationHourlyRateName";
            this.label_timeregistrationHourlyRateName.Size = new System.Drawing.Size(120, 17);
            this.label_timeregistrationHourlyRateName.TabIndex = 15;
            this.label_timeregistrationHourlyRateName.Text = "Hourly Rate Name";
            // 
            // comboBox_timeregistrationHourlyRateName
            // 
            this.comboBox_timeregistrationHourlyRateName.FormattingEnabled = true;
            this.comboBox_timeregistrationHourlyRateName.Location = new System.Drawing.Point(197, 522);
            this.comboBox_timeregistrationHourlyRateName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_timeregistrationHourlyRateName.Name = "comboBox_timeregistrationHourlyRateName";
            this.comboBox_timeregistrationHourlyRateName.Size = new System.Drawing.Size(197, 25);
            this.comboBox_timeregistrationHourlyRateName.TabIndex = 16;
            // 
            // label_timeregistrationHourlyRate
            // 
            this.label_timeregistrationHourlyRate.AutoSize = true;
            this.label_timeregistrationHourlyRate.Location = new System.Drawing.Point(9, 492);
            this.label_timeregistrationHourlyRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_timeregistrationHourlyRate.Name = "label_timeregistrationHourlyRate";
            this.label_timeregistrationHourlyRate.Size = new System.Drawing.Size(80, 17);
            this.label_timeregistrationHourlyRate.TabIndex = 13;
            this.label_timeregistrationHourlyRate.Text = "Hourly Rate";
            // 
            // comboBox_timeregistrationHourlyRate
            // 
            this.comboBox_timeregistrationHourlyRate.FormattingEnabled = true;
            this.comboBox_timeregistrationHourlyRate.Location = new System.Drawing.Point(197, 487);
            this.comboBox_timeregistrationHourlyRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_timeregistrationHourlyRate.Name = "comboBox_timeregistrationHourlyRate";
            this.comboBox_timeregistrationHourlyRate.Size = new System.Drawing.Size(197, 25);
            this.comboBox_timeregistrationHourlyRate.TabIndex = 14;
            // 
            // label_timeregistrationBillableHours
            // 
            this.label_timeregistrationBillableHours.AutoSize = true;
            this.label_timeregistrationBillableHours.Location = new System.Drawing.Point(9, 457);
            this.label_timeregistrationBillableHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_timeregistrationBillableHours.Name = "label_timeregistrationBillableHours";
            this.label_timeregistrationBillableHours.Size = new System.Drawing.Size(91, 17);
            this.label_timeregistrationBillableHours.TabIndex = 11;
            this.label_timeregistrationBillableHours.Text = "Billable Hours";
            // 
            // comboBox_timeregistrationBillableHours
            // 
            this.comboBox_timeregistrationBillableHours.FormattingEnabled = true;
            this.comboBox_timeregistrationBillableHours.Location = new System.Drawing.Point(197, 452);
            this.comboBox_timeregistrationBillableHours.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_timeregistrationBillableHours.Name = "comboBox_timeregistrationBillableHours";
            this.comboBox_timeregistrationBillableHours.Size = new System.Drawing.Size(197, 25);
            this.comboBox_timeregistrationBillableHours.TabIndex = 12;
            // 
            // label_timeregistrationIsBillable
            // 
            this.label_timeregistrationIsBillable.AutoSize = true;
            this.label_timeregistrationIsBillable.Location = new System.Drawing.Point(9, 422);
            this.label_timeregistrationIsBillable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_timeregistrationIsBillable.Name = "label_timeregistrationIsBillable";
            this.label_timeregistrationIsBillable.Size = new System.Drawing.Size(64, 17);
            this.label_timeregistrationIsBillable.TabIndex = 7;
            this.label_timeregistrationIsBillable.Text = "Is Billable";
            // 
            // comboBox_timeregistrationIsBillable
            // 
            this.comboBox_timeregistrationIsBillable.FormattingEnabled = true;
            this.comboBox_timeregistrationIsBillable.Location = new System.Drawing.Point(197, 417);
            this.comboBox_timeregistrationIsBillable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_timeregistrationIsBillable.Name = "comboBox_timeregistrationIsBillable";
            this.comboBox_timeregistrationIsBillable.Size = new System.Drawing.Size(197, 25);
            this.comboBox_timeregistrationIsBillable.TabIndex = 8;
            // 
            // label_timeregistrationHours
            // 
            this.label_timeregistrationHours.AutoSize = true;
            this.label_timeregistrationHours.Location = new System.Drawing.Point(9, 303);
            this.label_timeregistrationHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_timeregistrationHours.Name = "label_timeregistrationHours";
            this.label_timeregistrationHours.Size = new System.Drawing.Size(45, 17);
            this.label_timeregistrationHours.TabIndex = 1;
            this.label_timeregistrationHours.Text = "Hours";
            // 
            // comboBox_timeregistrationHours
            // 
            this.comboBox_timeregistrationHours.FormattingEnabled = true;
            this.comboBox_timeregistrationHours.Location = new System.Drawing.Point(197, 298);
            this.comboBox_timeregistrationHours.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_timeregistrationHours.Name = "comboBox_timeregistrationHours";
            this.comboBox_timeregistrationHours.Size = new System.Drawing.Size(197, 25);
            this.comboBox_timeregistrationHours.TabIndex = 3;
            // 
            // label_timeregistrationDate
            // 
            this.label_timeregistrationDate.AutoSize = true;
            this.label_timeregistrationDate.Location = new System.Drawing.Point(9, 252);
            this.label_timeregistrationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_timeregistrationDate.Name = "label_timeregistrationDate";
            this.label_timeregistrationDate.Size = new System.Drawing.Size(36, 17);
            this.label_timeregistrationDate.TabIndex = 1;
            this.label_timeregistrationDate.Text = "Date";
            // 
            // label_timeregistrationGroupType
            // 
            this.label_timeregistrationGroupType.AutoSize = true;
            this.label_timeregistrationGroupType.Location = new System.Drawing.Point(9, 355);
            this.label_timeregistrationGroupType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_timeregistrationGroupType.Name = "label_timeregistrationGroupType";
            this.label_timeregistrationGroupType.Size = new System.Drawing.Size(78, 17);
            this.label_timeregistrationGroupType.TabIndex = 1;
            this.label_timeregistrationGroupType.Text = "Group Type";
            // 
            // comboBox_timeregistrationDate
            // 
            this.comboBox_timeregistrationDate.FormattingEnabled = true;
            this.comboBox_timeregistrationDate.Location = new System.Drawing.Point(197, 247);
            this.comboBox_timeregistrationDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_timeregistrationDate.Name = "comboBox_timeregistrationDate";
            this.comboBox_timeregistrationDate.Size = new System.Drawing.Size(197, 25);
            this.comboBox_timeregistrationDate.TabIndex = 3;
            // 
            // label_timeregistrationUserInitials
            // 
            this.label_timeregistrationUserInitials.AutoSize = true;
            this.label_timeregistrationUserInitials.Location = new System.Drawing.Point(9, 200);
            this.label_timeregistrationUserInitials.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_timeregistrationUserInitials.Name = "label_timeregistrationUserInitials";
            this.label_timeregistrationUserInitials.Size = new System.Drawing.Size(78, 17);
            this.label_timeregistrationUserInitials.TabIndex = 1;
            this.label_timeregistrationUserInitials.Text = "User Initials";
            // 
            // comboBox_timeregistrationUserInitials
            // 
            this.comboBox_timeregistrationUserInitials.FormattingEnabled = true;
            this.comboBox_timeregistrationUserInitials.Location = new System.Drawing.Point(197, 195);
            this.comboBox_timeregistrationUserInitials.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_timeregistrationUserInitials.Name = "comboBox_timeregistrationUserInitials";
            this.comboBox_timeregistrationUserInitials.Size = new System.Drawing.Size(197, 25);
            this.comboBox_timeregistrationUserInitials.TabIndex = 3;
            // 
            // label_timeregistrationContractName
            // 
            this.label_timeregistrationContractName.AutoSize = true;
            this.label_timeregistrationContractName.Location = new System.Drawing.Point(9, 148);
            this.label_timeregistrationContractName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_timeregistrationContractName.Name = "label_timeregistrationContractName";
            this.label_timeregistrationContractName.Size = new System.Drawing.Size(100, 17);
            this.label_timeregistrationContractName.TabIndex = 1;
            this.label_timeregistrationContractName.Text = "Contract Name";
            // 
            // comboBox_timeregistrationGroupType
            // 
            this.comboBox_timeregistrationGroupType.FormattingEnabled = true;
            this.comboBox_timeregistrationGroupType.Location = new System.Drawing.Point(197, 350);
            this.comboBox_timeregistrationGroupType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_timeregistrationGroupType.Name = "comboBox_timeregistrationGroupType";
            this.comboBox_timeregistrationGroupType.Size = new System.Drawing.Size(197, 25);
            this.comboBox_timeregistrationGroupType.TabIndex = 3;
            // 
            // comboBox_timeregistrationContractName
            // 
            this.comboBox_timeregistrationContractName.FormattingEnabled = true;
            this.comboBox_timeregistrationContractName.Location = new System.Drawing.Point(197, 143);
            this.comboBox_timeregistrationContractName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_timeregistrationContractName.Name = "comboBox_timeregistrationContractName";
            this.comboBox_timeregistrationContractName.Size = new System.Drawing.Size(197, 25);
            this.comboBox_timeregistrationContractName.TabIndex = 3;
            // 
            // label_timeregistrationProjectNo
            // 
            this.label_timeregistrationProjectNo.AutoSize = true;
            this.label_timeregistrationProjectNo.Location = new System.Drawing.Point(9, 97);
            this.label_timeregistrationProjectNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_timeregistrationProjectNo.Name = "label_timeregistrationProjectNo";
            this.label_timeregistrationProjectNo.Size = new System.Drawing.Size(72, 17);
            this.label_timeregistrationProjectNo.TabIndex = 1;
            this.label_timeregistrationProjectNo.Text = "Project No";
            // 
            // comboBox_timeregistrationProjectNo
            // 
            this.comboBox_timeregistrationProjectNo.FormattingEnabled = true;
            this.comboBox_timeregistrationProjectNo.Location = new System.Drawing.Point(197, 92);
            this.comboBox_timeregistrationProjectNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_timeregistrationProjectNo.Name = "comboBox_timeregistrationProjectNo";
            this.comboBox_timeregistrationProjectNo.Size = new System.Drawing.Size(197, 25);
            this.comboBox_timeregistrationProjectNo.TabIndex = 3;
            // 
            // label_timeregistrationTaskNo
            // 
            this.label_timeregistrationTaskNo.AutoSize = true;
            this.label_timeregistrationTaskNo.Location = new System.Drawing.Point(9, 45);
            this.label_timeregistrationTaskNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_timeregistrationTaskNo.Name = "label_timeregistrationTaskNo";
            this.label_timeregistrationTaskNo.Size = new System.Drawing.Size(56, 17);
            this.label_timeregistrationTaskNo.TabIndex = 1;
            this.label_timeregistrationTaskNo.Text = "Task No";
            // 
            // comboBox_timeregistrationTaskNo
            // 
            this.comboBox_timeregistrationTaskNo.FormattingEnabled = true;
            this.comboBox_timeregistrationTaskNo.Location = new System.Drawing.Point(197, 40);
            this.comboBox_timeregistrationTaskNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_timeregistrationTaskNo.Name = "comboBox_timeregistrationTaskNo";
            this.comboBox_timeregistrationTaskNo.Size = new System.Drawing.Size(197, 25);
            this.comboBox_timeregistrationTaskNo.TabIndex = 3;
            // 
            // label_timeregistrationSetup
            // 
            this.label_timeregistrationSetup.AutoSize = true;
            this.label_timeregistrationSetup.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_timeregistrationSetup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_timeregistrationSetup.Location = new System.Drawing.Point(10, 27);
            this.label_timeregistrationSetup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_timeregistrationSetup.Name = "label_timeregistrationSetup";
            this.label_timeregistrationSetup.Size = new System.Drawing.Size(334, 32);
            this.label_timeregistrationSetup.TabIndex = 0;
            this.label_timeregistrationSetup.Text = "Timeregistration Data Import";
            // 
            // button_timeregistrationSelectFile
            // 
            this.button_timeregistrationSelectFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(43)))), ((int)(((byte)(141)))));
            this.button_timeregistrationSelectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_timeregistrationSelectFile.FlatAppearance.BorderSize = 0;
            this.button_timeregistrationSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_timeregistrationSelectFile.ForeColor = System.Drawing.Color.White;
            this.button_timeregistrationSelectFile.Location = new System.Drawing.Point(19, 185);
            this.button_timeregistrationSelectFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_timeregistrationSelectFile.Name = "button_timeregistrationSelectFile";
            this.button_timeregistrationSelectFile.Size = new System.Drawing.Size(114, 48);
            this.button_timeregistrationSelectFile.TabIndex = 4;
            this.button_timeregistrationSelectFile.Text = "Select File";
            this.defaultToolTip.SetToolTip(this.button_timeregistrationSelectFile, "Select input CSV file");
            this.button_timeregistrationSelectFile.UseVisualStyleBackColor = false;
            this.button_timeregistrationSelectFile.Click += new System.EventHandler(this.button_select_timeregistration_file_Click);
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
            // UserControl_TimeregistrationImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_timeregistrationFieldMapping);
            this.Controls.Add(this.panel_timeregistrationButtons);
            this.Controls.Add(this.panel_timeregistrationMessage);
            this.Controls.Add(this.panel_timeregistrationDataTable);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControl_TimeregistrationImport";
            this.Size = new System.Drawing.Size(1437, 1070);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.panel_timeregistrationDataTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_timeregistration)).EndInit();
            this.panel_timeregistrationMessage.ResumeLayout(false);
            this.panel_timeregistrationMessage.PerformLayout();
            this.panel_timeregistrationButtons.ResumeLayout(false);
            this.panel_timeregistrationFieldMapping.ResumeLayout(false);
            this.panel_timeregistrationFieldMapping.PerformLayout();
            this.flowLayoutPanel_nonMandatoryFields.ResumeLayout(false);
            this.panel_NonMandatoryButton.ResumeLayout(false);
            this.panel_NonMandatoryButton.PerformLayout();
            this.panel_NonMandatoryFields.ResumeLayout(false);
            this.panel_NonMandatoryFields.PerformLayout();
            this.groupBox_timeregistrationMandatoryFields.ResumeLayout(false);
            this.groupBox_timeregistrationMandatoryFields.PerformLayout();
            this.ResumeLayout(false);

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
