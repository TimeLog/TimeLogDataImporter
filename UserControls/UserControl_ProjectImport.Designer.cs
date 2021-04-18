namespace TimeLog.DataImporter.UserControls
{
    partial class UserControl_ProjectImport
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
            this.dataGridView_project = new System.Windows.Forms.DataGridView();
            this.panel_projectMessage = new System.Windows.Forms.Panel();
            this.textBox_projectImportMessages = new System.Windows.Forms.TextBox();
            this.panel_projectButtons = new System.Windows.Forms.Panel();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_import = new System.Windows.Forms.Button();
            this.button_validate = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.panel_projectFieldMapping = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_nonMandatoryFields = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_NonMandatoryButton = new System.Windows.Forms.Panel();
            this.label_nonMandatoryFields = new System.Windows.Forms.Label();
            this.button_expandNonMandatory = new System.Windows.Forms.Button();
            this.panel_NonMandatoryFields = new System.Windows.Forms.Panel();
            this.checkBox_defaultProjectCategory = new System.Windows.Forms.CheckBox();
            this.label_projectNo = new System.Windows.Forms.Label();
            this.comboBox_projectNo = new System.Windows.Forms.ComboBox();
            this.label_projectCategory = new System.Windows.Forms.Label();
            this.comboBox_description = new System.Windows.Forms.ComboBox();
            this.comboBox_projectCategory = new System.Windows.Forms.ComboBox();
            this.label_description = new System.Windows.Forms.Label();
            this.comboBox_projectStartDate = new System.Windows.Forms.ComboBox();
            this.label_projectStartDate = new System.Windows.Forms.Label();
            this.label_projectEndDate = new System.Windows.Forms.Label();
            this.comboBox_projectEndDate = new System.Windows.Forms.ComboBox();
            this.label_delimiter = new System.Windows.Forms.Label();
            this.comboBox_delimiter = new System.Windows.Forms.ComboBox();
            this.groupBox_projectMandatoryFields = new System.Windows.Forms.GroupBox();
            this.checkBox_defaultProjectDepartment = new System.Windows.Forms.CheckBox();
            this.label_projectDepartment = new System.Windows.Forms.Label();
            this.comboBox_projectDepartment = new System.Windows.Forms.ComboBox();
            this.checkBox_defaultLegalEntity = new System.Windows.Forms.CheckBox();
            this.checkBox_defaultProjectTemplate = new System.Windows.Forms.CheckBox();
            this.checkBox_defaultProjectType = new System.Windows.Forms.CheckBox();
            this.checkBox_defaultCurrencyISO = new System.Windows.Forms.CheckBox();
            this.label_projectLegalEntity = new System.Windows.Forms.Label();
            this.comboBox_projectLegalEntity = new System.Windows.Forms.ComboBox();
            this.label_projectCurrencyISO = new System.Windows.Forms.Label();
            this.label_projectType = new System.Windows.Forms.Label();
            this.comboBox_projectCurrencyISO = new System.Windows.Forms.ComboBox();
            this.label_projectManager = new System.Windows.Forms.Label();
            this.comboBox_projectManager = new System.Windows.Forms.ComboBox();
            this.label_projectTemplate = new System.Windows.Forms.Label();
            this.comboBox_projectType = new System.Windows.Forms.ComboBox();
            this.comboBox_projectTemplate = new System.Windows.Forms.ComboBox();
            this.label_projectCustomerNo = new System.Windows.Forms.Label();
            this.comboBox_projectCustomerNo = new System.Windows.Forms.ComboBox();
            this.label_projectName = new System.Windows.Forms.Label();
            this.comboBox_projectName = new System.Windows.Forms.ComboBox();
            this.label_projectSetup = new System.Windows.Forms.Label();
            this.button_projectSelectFile = new System.Windows.Forms.Button();
            this.tmrExpand = new System.Windows.Forms.Timer(this.components);
            this.defaultToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel_projectDataTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_project)).BeginInit();
            this.panel_projectMessage.SuspendLayout();
            this.panel_projectButtons.SuspendLayout();
            this.panel_projectFieldMapping.SuspendLayout();
            this.flowLayoutPanel_nonMandatoryFields.SuspendLayout();
            this.panel_NonMandatoryButton.SuspendLayout();
            this.panel_NonMandatoryFields.SuspendLayout();
            this.groupBox_projectMandatoryFields.SuspendLayout();
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
            this.panel_projectDataTable.Controls.Add(this.dataGridView_project);
            this.panel_projectDataTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_projectDataTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_projectDataTable.Location = new System.Drawing.Point(0, 770);
            this.panel_projectDataTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_projectDataTable.Name = "panel_projectDataTable";
            this.panel_projectDataTable.Size = new System.Drawing.Size(1437, 300);
            this.panel_projectDataTable.TabIndex = 6;
            // 
            // dataGridView_project
            // 
            this.dataGridView_project.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView_project.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_project.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_project.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_project.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dataGridView_project.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_project.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_project.Name = "dataGridView_project";
            this.dataGridView_project.RowHeadersWidth = 62;
            this.dataGridView_project.Size = new System.Drawing.Size(1437, 300);
            this.dataGridView_project.TabIndex = 0;
            // 
            // panel_projectMessage
            // 
            this.panel_projectMessage.Controls.Add(this.textBox_projectImportMessages);
            this.panel_projectMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_projectMessage.Location = new System.Drawing.Point(0, 463);
            this.panel_projectMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_projectMessage.Name = "panel_projectMessage";
            this.panel_projectMessage.Size = new System.Drawing.Size(1437, 307);
            this.panel_projectMessage.TabIndex = 10;
            // 
            // textBox_projectImportMessages
            // 
            this.textBox_projectImportMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_projectImportMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_projectImportMessages.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_projectImportMessages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox_projectImportMessages.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_projectImportMessages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_projectImportMessages.Location = new System.Drawing.Point(0, 0);
            this.textBox_projectImportMessages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_projectImportMessages.Multiline = true;
            this.textBox_projectImportMessages.Name = "textBox_projectImportMessages";
            this.textBox_projectImportMessages.ReadOnly = true;
            this.textBox_projectImportMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_projectImportMessages.Size = new System.Drawing.Size(1437, 307);
            this.textBox_projectImportMessages.TabIndex = 0;
            this.defaultToolTip.SetToolTip(this.textBox_projectImportMessages, "Validation or import status");
            this.textBox_projectImportMessages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_projectImportMessages_MouseClick);
            // 
            // panel_projectButtons
            // 
            this.panel_projectButtons.Controls.Add(this.button_clear);
            this.panel_projectButtons.Controls.Add(this.button_import);
            this.panel_projectButtons.Controls.Add(this.button_validate);
            this.panel_projectButtons.Controls.Add(this.button_stop);
            this.panel_projectButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_projectButtons.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel_projectButtons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_projectButtons.Location = new System.Drawing.Point(0, 376);
            this.panel_projectButtons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_projectButtons.Name = "panel_projectButtons";
            this.panel_projectButtons.Size = new System.Drawing.Size(1437, 87);
            this.panel_projectButtons.TabIndex = 12;
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
            // panel_projectFieldMapping
            // 
            this.panel_projectFieldMapping.AutoScroll = true;
            this.panel_projectFieldMapping.Controls.Add(this.flowLayoutPanel_nonMandatoryFields);
            this.panel_projectFieldMapping.Controls.Add(this.label_delimiter);
            this.panel_projectFieldMapping.Controls.Add(this.comboBox_delimiter);
            this.panel_projectFieldMapping.Controls.Add(this.groupBox_projectMandatoryFields);
            this.panel_projectFieldMapping.Controls.Add(this.label_projectSetup);
            this.panel_projectFieldMapping.Controls.Add(this.button_projectSelectFile);
            this.panel_projectFieldMapping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_projectFieldMapping.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel_projectFieldMapping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_projectFieldMapping.Location = new System.Drawing.Point(0, 0);
            this.panel_projectFieldMapping.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_projectFieldMapping.Name = "panel_projectFieldMapping";
            this.panel_projectFieldMapping.Size = new System.Drawing.Size(1437, 376);
            this.panel_projectFieldMapping.TabIndex = 13;
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
            this.panel_NonMandatoryFields.Controls.Add(this.checkBox_defaultProjectCategory);
            this.panel_NonMandatoryFields.Controls.Add(this.label_projectNo);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_projectNo);
            this.panel_NonMandatoryFields.Controls.Add(this.label_projectCategory);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_description);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_projectCategory);
            this.panel_NonMandatoryFields.Controls.Add(this.label_description);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_projectStartDate);
            this.panel_NonMandatoryFields.Controls.Add(this.label_projectStartDate);
            this.panel_NonMandatoryFields.Controls.Add(this.label_projectEndDate);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_projectEndDate);
            this.panel_NonMandatoryFields.Location = new System.Drawing.Point(4, 68);
            this.panel_NonMandatoryFields.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_NonMandatoryFields.MaximumSize = new System.Drawing.Size(519, 272);
            this.panel_NonMandatoryFields.MinimumSize = new System.Drawing.Size(519, 0);
            this.panel_NonMandatoryFields.Name = "panel_NonMandatoryFields";
            this.panel_NonMandatoryFields.Size = new System.Drawing.Size(519, 272);
            this.panel_NonMandatoryFields.TabIndex = 1;
            // 
            // checkBox_defaultProjectCategory
            // 
            this.checkBox_defaultProjectCategory.AutoSize = true;
            this.checkBox_defaultProjectCategory.Location = new System.Drawing.Point(411, 222);
            this.checkBox_defaultProjectCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_defaultProjectCategory.Name = "checkBox_defaultProjectCategory";
            this.checkBox_defaultProjectCategory.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultProjectCategory.TabIndex = 5;
            this.checkBox_defaultProjectCategory.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultProjectCategory, "Set default values for all rows of a particular column field");
            this.checkBox_defaultProjectCategory.UseVisualStyleBackColor = true;
            this.checkBox_defaultProjectCategory.CheckedChanged += new System.EventHandler(this.checkBox_defaultProjectCategory_CheckedChanged);
            // 
            // label_projectNo
            // 
            this.label_projectNo.AutoSize = true;
            this.label_projectNo.Location = new System.Drawing.Point(14, 17);
            this.label_projectNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_projectNo.Name = "label_projectNo";
            this.label_projectNo.Size = new System.Drawing.Size(72, 17);
            this.label_projectNo.TabIndex = 1;
            this.label_projectNo.Text = "Project No";
            // 
            // comboBox_projectNo
            // 
            this.comboBox_projectNo.FormattingEnabled = true;
            this.comboBox_projectNo.Location = new System.Drawing.Point(204, 12);
            this.comboBox_projectNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_projectNo.Name = "comboBox_projectNo";
            this.comboBox_projectNo.Size = new System.Drawing.Size(197, 25);
            this.comboBox_projectNo.TabIndex = 3;
            // 
            // label_projectCategory
            // 
            this.label_projectCategory.AutoSize = true;
            this.label_projectCategory.Location = new System.Drawing.Point(14, 223);
            this.label_projectCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_projectCategory.Name = "label_projectCategory";
            this.label_projectCategory.Size = new System.Drawing.Size(110, 17);
            this.label_projectCategory.TabIndex = 1;
            this.label_projectCategory.Text = "Project Category";
            // 
            // comboBox_description
            // 
            this.comboBox_description.FormattingEnabled = true;
            this.comboBox_description.Location = new System.Drawing.Point(204, 63);
            this.comboBox_description.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_description.Name = "comboBox_description";
            this.comboBox_description.Size = new System.Drawing.Size(197, 25);
            this.comboBox_description.TabIndex = 3;
            // 
            // comboBox_projectCategory
            // 
            this.comboBox_projectCategory.FormattingEnabled = true;
            this.comboBox_projectCategory.Location = new System.Drawing.Point(204, 218);
            this.comboBox_projectCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_projectCategory.Name = "comboBox_projectCategory";
            this.comboBox_projectCategory.Size = new System.Drawing.Size(197, 25);
            this.comboBox_projectCategory.TabIndex = 3;
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Location = new System.Drawing.Point(14, 68);
            this.label_description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(76, 17);
            this.label_description.TabIndex = 1;
            this.label_description.Text = "Description";
            // 
            // comboBox_projectStartDate
            // 
            this.comboBox_projectStartDate.FormattingEnabled = true;
            this.comboBox_projectStartDate.Location = new System.Drawing.Point(204, 115);
            this.comboBox_projectStartDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_projectStartDate.Name = "comboBox_projectStartDate";
            this.comboBox_projectStartDate.Size = new System.Drawing.Size(197, 25);
            this.comboBox_projectStartDate.TabIndex = 3;
            // 
            // label_projectStartDate
            // 
            this.label_projectStartDate.AutoSize = true;
            this.label_projectStartDate.Location = new System.Drawing.Point(14, 120);
            this.label_projectStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_projectStartDate.Name = "label_projectStartDate";
            this.label_projectStartDate.Size = new System.Drawing.Size(115, 17);
            this.label_projectStartDate.TabIndex = 1;
            this.label_projectStartDate.Text = "Project Start Date";
            // 
            // label_projectEndDate
            // 
            this.label_projectEndDate.AutoSize = true;
            this.label_projectEndDate.Location = new System.Drawing.Point(14, 172);
            this.label_projectEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_projectEndDate.Name = "label_projectEndDate";
            this.label_projectEndDate.Size = new System.Drawing.Size(109, 17);
            this.label_projectEndDate.TabIndex = 1;
            this.label_projectEndDate.Text = "Project End Date";
            // 
            // comboBox_projectEndDate
            // 
            this.comboBox_projectEndDate.FormattingEnabled = true;
            this.comboBox_projectEndDate.Location = new System.Drawing.Point(204, 167);
            this.comboBox_projectEndDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_projectEndDate.Name = "comboBox_projectEndDate";
            this.comboBox_projectEndDate.Size = new System.Drawing.Size(197, 25);
            this.comboBox_projectEndDate.TabIndex = 3;
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
            // groupBox_projectMandatoryFields
            // 
            this.groupBox_projectMandatoryFields.Controls.Add(this.checkBox_defaultProjectDepartment);
            this.groupBox_projectMandatoryFields.Controls.Add(this.label_projectDepartment);
            this.groupBox_projectMandatoryFields.Controls.Add(this.comboBox_projectDepartment);
            this.groupBox_projectMandatoryFields.Controls.Add(this.checkBox_defaultLegalEntity);
            this.groupBox_projectMandatoryFields.Controls.Add(this.checkBox_defaultProjectTemplate);
            this.groupBox_projectMandatoryFields.Controls.Add(this.checkBox_defaultProjectType);
            this.groupBox_projectMandatoryFields.Controls.Add(this.checkBox_defaultCurrencyISO);
            this.groupBox_projectMandatoryFields.Controls.Add(this.label_projectLegalEntity);
            this.groupBox_projectMandatoryFields.Controls.Add(this.comboBox_projectLegalEntity);
            this.groupBox_projectMandatoryFields.Controls.Add(this.label_projectCurrencyISO);
            this.groupBox_projectMandatoryFields.Controls.Add(this.label_projectType);
            this.groupBox_projectMandatoryFields.Controls.Add(this.comboBox_projectCurrencyISO);
            this.groupBox_projectMandatoryFields.Controls.Add(this.label_projectManager);
            this.groupBox_projectMandatoryFields.Controls.Add(this.comboBox_projectManager);
            this.groupBox_projectMandatoryFields.Controls.Add(this.label_projectTemplate);
            this.groupBox_projectMandatoryFields.Controls.Add(this.comboBox_projectType);
            this.groupBox_projectMandatoryFields.Controls.Add(this.comboBox_projectTemplate);
            this.groupBox_projectMandatoryFields.Controls.Add(this.label_projectCustomerNo);
            this.groupBox_projectMandatoryFields.Controls.Add(this.comboBox_projectCustomerNo);
            this.groupBox_projectMandatoryFields.Controls.Add(this.label_projectName);
            this.groupBox_projectMandatoryFields.Controls.Add(this.comboBox_projectName);
            this.groupBox_projectMandatoryFields.Location = new System.Drawing.Point(263, 103);
            this.groupBox_projectMandatoryFields.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_projectMandatoryFields.Name = "groupBox_projectMandatoryFields";
            this.groupBox_projectMandatoryFields.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_projectMandatoryFields.Size = new System.Drawing.Size(511, 462);
            this.groupBox_projectMandatoryFields.TabIndex = 5;
            this.groupBox_projectMandatoryFields.TabStop = false;
            this.groupBox_projectMandatoryFields.Text = "Mandatory";
            // 
            // checkBox_defaultProjectDepartment
            // 
            this.checkBox_defaultProjectDepartment.AutoSize = true;
            this.checkBox_defaultProjectDepartment.Location = new System.Drawing.Point(404, 405);
            this.checkBox_defaultProjectDepartment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_defaultProjectDepartment.Name = "checkBox_defaultProjectDepartment";
            this.checkBox_defaultProjectDepartment.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultProjectDepartment.TabIndex = 9;
            this.checkBox_defaultProjectDepartment.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultProjectDepartment, "Set default values for all rows of a particular column field");
            this.checkBox_defaultProjectDepartment.UseVisualStyleBackColor = true;
            this.checkBox_defaultProjectDepartment.CheckedChanged += new System.EventHandler(this.checkBox_defaultProjectDepartment_CheckedChanged);
            // 
            // label_projectDepartment
            // 
            this.label_projectDepartment.AutoSize = true;
            this.label_projectDepartment.Location = new System.Drawing.Point(9, 407);
            this.label_projectDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_projectDepartment.Name = "label_projectDepartment";
            this.label_projectDepartment.Size = new System.Drawing.Size(121, 17);
            this.label_projectDepartment.TabIndex = 7;
            this.label_projectDepartment.Text = "Department Name";
            // 
            // comboBox_projectDepartment
            // 
            this.comboBox_projectDepartment.FormattingEnabled = true;
            this.comboBox_projectDepartment.Location = new System.Drawing.Point(197, 402);
            this.comboBox_projectDepartment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_projectDepartment.Name = "comboBox_projectDepartment";
            this.comboBox_projectDepartment.Size = new System.Drawing.Size(197, 25);
            this.comboBox_projectDepartment.TabIndex = 8;
            // 
            // checkBox_defaultLegalEntity
            // 
            this.checkBox_defaultLegalEntity.AutoSize = true;
            this.checkBox_defaultLegalEntity.Location = new System.Drawing.Point(404, 302);
            this.checkBox_defaultLegalEntity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_defaultLegalEntity.Name = "checkBox_defaultLegalEntity";
            this.checkBox_defaultLegalEntity.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultLegalEntity.TabIndex = 6;
            this.checkBox_defaultLegalEntity.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultLegalEntity, "Set default values for all rows of a particular column field");
            this.checkBox_defaultLegalEntity.UseVisualStyleBackColor = true;
            this.checkBox_defaultLegalEntity.CheckedChanged += new System.EventHandler(this.checkBox_defaultLegalEntity_CheckedChanged);
            // 
            // checkBox_defaultProjectTemplate
            // 
            this.checkBox_defaultProjectTemplate.AutoSize = true;
            this.checkBox_defaultProjectTemplate.Location = new System.Drawing.Point(404, 147);
            this.checkBox_defaultProjectTemplate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_defaultProjectTemplate.Name = "checkBox_defaultProjectTemplate";
            this.checkBox_defaultProjectTemplate.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultProjectTemplate.TabIndex = 5;
            this.checkBox_defaultProjectTemplate.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultProjectTemplate, "Set default values for all rows of a particular column field");
            this.checkBox_defaultProjectTemplate.UseVisualStyleBackColor = true;
            this.checkBox_defaultProjectTemplate.CheckedChanged += new System.EventHandler(this.checkBox_defaultProjectTemplate_CheckedChanged);
            // 
            // checkBox_defaultProjectType
            // 
            this.checkBox_defaultProjectType.AutoSize = true;
            this.checkBox_defaultProjectType.Location = new System.Drawing.Point(404, 353);
            this.checkBox_defaultProjectType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_defaultProjectType.Name = "checkBox_defaultProjectType";
            this.checkBox_defaultProjectType.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultProjectType.TabIndex = 4;
            this.checkBox_defaultProjectType.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultProjectType, "Set default values for all rows of a particular column field");
            this.checkBox_defaultProjectType.UseVisualStyleBackColor = true;
            this.checkBox_defaultProjectType.CheckedChanged += new System.EventHandler(this.checkBox_defaultProjectType_CheckedChanged);
            // 
            // checkBox_defaultCurrencyISO
            // 
            this.checkBox_defaultCurrencyISO.AutoSize = true;
            this.checkBox_defaultCurrencyISO.Location = new System.Drawing.Point(404, 250);
            this.checkBox_defaultCurrencyISO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_defaultCurrencyISO.Name = "checkBox_defaultCurrencyISO";
            this.checkBox_defaultCurrencyISO.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultCurrencyISO.TabIndex = 4;
            this.checkBox_defaultCurrencyISO.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultCurrencyISO, "Set default values for all rows of a particular column field");
            this.checkBox_defaultCurrencyISO.UseVisualStyleBackColor = true;
            this.checkBox_defaultCurrencyISO.CheckedChanged += new System.EventHandler(this.checkBox_defaultCurrencyISO_CheckedChanged);
            // 
            // label_projectLegalEntity
            // 
            this.label_projectLegalEntity.AutoSize = true;
            this.label_projectLegalEntity.Location = new System.Drawing.Point(9, 303);
            this.label_projectLegalEntity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_projectLegalEntity.Name = "label_projectLegalEntity";
            this.label_projectLegalEntity.Size = new System.Drawing.Size(78, 17);
            this.label_projectLegalEntity.TabIndex = 1;
            this.label_projectLegalEntity.Text = "Legal Entity";
            // 
            // comboBox_projectLegalEntity
            // 
            this.comboBox_projectLegalEntity.FormattingEnabled = true;
            this.comboBox_projectLegalEntity.Location = new System.Drawing.Point(197, 298);
            this.comboBox_projectLegalEntity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_projectLegalEntity.Name = "comboBox_projectLegalEntity";
            this.comboBox_projectLegalEntity.Size = new System.Drawing.Size(197, 25);
            this.comboBox_projectLegalEntity.TabIndex = 3;
            // 
            // label_projectCurrencyISO
            // 
            this.label_projectCurrencyISO.AutoSize = true;
            this.label_projectCurrencyISO.Location = new System.Drawing.Point(9, 252);
            this.label_projectCurrencyISO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_projectCurrencyISO.Name = "label_projectCurrencyISO";
            this.label_projectCurrencyISO.Size = new System.Drawing.Size(87, 17);
            this.label_projectCurrencyISO.TabIndex = 1;
            this.label_projectCurrencyISO.Text = "Currency ISO";
            // 
            // label_projectType
            // 
            this.label_projectType.AutoSize = true;
            this.label_projectType.Location = new System.Drawing.Point(9, 355);
            this.label_projectType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_projectType.Name = "label_projectType";
            this.label_projectType.Size = new System.Drawing.Size(82, 17);
            this.label_projectType.TabIndex = 1;
            this.label_projectType.Text = "Project Type";
            // 
            // comboBox_projectCurrencyISO
            // 
            this.comboBox_projectCurrencyISO.FormattingEnabled = true;
            this.comboBox_projectCurrencyISO.Location = new System.Drawing.Point(197, 247);
            this.comboBox_projectCurrencyISO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_projectCurrencyISO.Name = "comboBox_projectCurrencyISO";
            this.comboBox_projectCurrencyISO.Size = new System.Drawing.Size(197, 25);
            this.comboBox_projectCurrencyISO.TabIndex = 3;
            // 
            // label_projectManager
            // 
            this.label_projectManager.AutoSize = true;
            this.label_projectManager.Location = new System.Drawing.Point(9, 200);
            this.label_projectManager.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_projectManager.Name = "label_projectManager";
            this.label_projectManager.Size = new System.Drawing.Size(79, 17);
            this.label_projectManager.TabIndex = 1;
            this.label_projectManager.Text = "P. M. Initials";
            // 
            // comboBox_projectManager
            // 
            this.comboBox_projectManager.FormattingEnabled = true;
            this.comboBox_projectManager.Location = new System.Drawing.Point(197, 195);
            this.comboBox_projectManager.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_projectManager.Name = "comboBox_projectManager";
            this.comboBox_projectManager.Size = new System.Drawing.Size(197, 25);
            this.comboBox_projectManager.TabIndex = 3;
            // 
            // label_projectTemplate
            // 
            this.label_projectTemplate.AutoSize = true;
            this.label_projectTemplate.Location = new System.Drawing.Point(9, 148);
            this.label_projectTemplate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_projectTemplate.Name = "label_projectTemplate";
            this.label_projectTemplate.Size = new System.Drawing.Size(109, 17);
            this.label_projectTemplate.TabIndex = 1;
            this.label_projectTemplate.Text = "Project Template";
            // 
            // comboBox_projectType
            // 
            this.comboBox_projectType.FormattingEnabled = true;
            this.comboBox_projectType.Location = new System.Drawing.Point(197, 350);
            this.comboBox_projectType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_projectType.Name = "comboBox_projectType";
            this.comboBox_projectType.Size = new System.Drawing.Size(197, 25);
            this.comboBox_projectType.TabIndex = 3;
            // 
            // comboBox_projectTemplate
            // 
            this.comboBox_projectTemplate.FormattingEnabled = true;
            this.comboBox_projectTemplate.Location = new System.Drawing.Point(197, 143);
            this.comboBox_projectTemplate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_projectTemplate.Name = "comboBox_projectTemplate";
            this.comboBox_projectTemplate.Size = new System.Drawing.Size(197, 25);
            this.comboBox_projectTemplate.TabIndex = 3;
            // 
            // label_projectCustomerNo
            // 
            this.label_projectCustomerNo.AutoSize = true;
            this.label_projectCustomerNo.Location = new System.Drawing.Point(9, 97);
            this.label_projectCustomerNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_projectCustomerNo.Name = "label_projectCustomerNo";
            this.label_projectCustomerNo.Size = new System.Drawing.Size(89, 17);
            this.label_projectCustomerNo.TabIndex = 1;
            this.label_projectCustomerNo.Text = "Customer No";
            // 
            // comboBox_projectCustomerNo
            // 
            this.comboBox_projectCustomerNo.FormattingEnabled = true;
            this.comboBox_projectCustomerNo.Location = new System.Drawing.Point(197, 92);
            this.comboBox_projectCustomerNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_projectCustomerNo.Name = "comboBox_projectCustomerNo";
            this.comboBox_projectCustomerNo.Size = new System.Drawing.Size(197, 25);
            this.comboBox_projectCustomerNo.TabIndex = 3;
            // 
            // label_projectName
            // 
            this.label_projectName.AutoSize = true;
            this.label_projectName.Location = new System.Drawing.Point(9, 45);
            this.label_projectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_projectName.Name = "label_projectName";
            this.label_projectName.Size = new System.Drawing.Size(90, 17);
            this.label_projectName.TabIndex = 1;
            this.label_projectName.Text = "Project Name";
            // 
            // comboBox_projectName
            // 
            this.comboBox_projectName.FormattingEnabled = true;
            this.comboBox_projectName.Location = new System.Drawing.Point(197, 40);
            this.comboBox_projectName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_projectName.Name = "comboBox_projectName";
            this.comboBox_projectName.Size = new System.Drawing.Size(197, 25);
            this.comboBox_projectName.TabIndex = 3;
            // 
            // label_projectSetup
            // 
            this.label_projectSetup.AutoSize = true;
            this.label_projectSetup.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_projectSetup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_projectSetup.Location = new System.Drawing.Point(10, 27);
            this.label_projectSetup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_projectSetup.Name = "label_projectSetup";
            this.label_projectSetup.Size = new System.Drawing.Size(231, 32);
            this.label_projectSetup.TabIndex = 0;
            this.label_projectSetup.Text = "Project Data Import";
            // 
            // button_projectSelectFile
            // 
            this.button_projectSelectFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(43)))), ((int)(((byte)(141)))));
            this.button_projectSelectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_projectSelectFile.FlatAppearance.BorderSize = 0;
            this.button_projectSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_projectSelectFile.ForeColor = System.Drawing.Color.White;
            this.button_projectSelectFile.Location = new System.Drawing.Point(19, 185);
            this.button_projectSelectFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_projectSelectFile.Name = "button_projectSelectFile";
            this.button_projectSelectFile.Size = new System.Drawing.Size(114, 48);
            this.button_projectSelectFile.TabIndex = 4;
            this.button_projectSelectFile.Text = "Select File";
            this.defaultToolTip.SetToolTip(this.button_projectSelectFile, "Select input CSV file");
            this.button_projectSelectFile.UseVisualStyleBackColor = false;
            this.button_projectSelectFile.Click += new System.EventHandler(this.button_select_project_file_Click);
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
            // UserControl_ProjectImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_projectFieldMapping);
            this.Controls.Add(this.panel_projectButtons);
            this.Controls.Add(this.panel_projectMessage);
            this.Controls.Add(this.panel_projectDataTable);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControl_ProjectImport";
            this.Size = new System.Drawing.Size(1437, 1070);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.panel_projectDataTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_project)).EndInit();
            this.panel_projectMessage.ResumeLayout(false);
            this.panel_projectMessage.PerformLayout();
            this.panel_projectButtons.ResumeLayout(false);
            this.panel_projectFieldMapping.ResumeLayout(false);
            this.panel_projectFieldMapping.PerformLayout();
            this.flowLayoutPanel_nonMandatoryFields.ResumeLayout(false);
            this.panel_NonMandatoryButton.ResumeLayout(false);
            this.panel_NonMandatoryButton.PerformLayout();
            this.panel_NonMandatoryFields.ResumeLayout(false);
            this.panel_NonMandatoryFields.PerformLayout();
            this.groupBox_projectMandatoryFields.ResumeLayout(false);
            this.groupBox_projectMandatoryFields.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private void AddRowNumberToDataTable()
        {
            this.dataGridView_project.DataBindingComplete += (o, e) =>
            {
                foreach (System.Windows.Forms.DataGridViewRow row in dataGridView_project.Rows)
                {
                    row.HeaderCell.Value = (row.Index + 1).ToString();

                }
            };
            this.dataGridView_project.RowHeadersWidth = 65;
        }


        private System.ComponentModel.BackgroundWorker WorkerFetcher;
        private System.Windows.Forms.Panel panel_projectDataTable;
        private System.Windows.Forms.DataGridView dataGridView_project;
        private System.Windows.Forms.Panel panel_projectMessage;
        private System.Windows.Forms.Panel panel_projectButtons;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_import;
        private System.Windows.Forms.Button button_validate;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Panel panel_projectFieldMapping;
        private System.Windows.Forms.GroupBox groupBox_projectMandatoryFields;
        private System.Windows.Forms.ComboBox comboBox_projectName;
        private System.Windows.Forms.Label label_projectName;
        private System.Windows.Forms.Label label_projectSetup;
        private System.Windows.Forms.Button button_projectSelectFile;
        private System.Windows.Forms.TextBox textBox_projectImportMessages;
        private System.Windows.Forms.Label label_projectTemplate;
        private System.Windows.Forms.ComboBox comboBox_projectTemplate;
        private System.Windows.Forms.Label label_projectCustomerNo;
        private System.Windows.Forms.ComboBox comboBox_projectCustomerNo;
        private System.Windows.Forms.Label label_projectLegalEntity;
        private System.Windows.Forms.ComboBox comboBox_projectLegalEntity;
        private System.Windows.Forms.Label label_projectCurrencyISO;
        private System.Windows.Forms.ComboBox comboBox_projectCurrencyISO;
        private System.Windows.Forms.Label label_projectManager;
        private System.Windows.Forms.ComboBox comboBox_projectManager;
        private System.Windows.Forms.Label label_delimiter;
        private System.Windows.Forms.ComboBox comboBox_delimiter;
        private System.Windows.Forms.Label label_projectCategory;
        private System.Windows.Forms.ComboBox comboBox_projectCategory;
        private System.Windows.Forms.Label label_projectType;
        private System.Windows.Forms.ComboBox comboBox_projectType;
        private System.Windows.Forms.Label label_projectEndDate;
        private System.Windows.Forms.ComboBox comboBox_projectEndDate;
        private System.Windows.Forms.Label label_projectStartDate;
        private System.Windows.Forms.ComboBox comboBox_projectStartDate;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.ComboBox comboBox_description;
        private System.Windows.Forms.Label label_projectNo;
        private System.Windows.Forms.ComboBox comboBox_projectNo;
        private System.Windows.Forms.CheckBox checkBox_defaultCurrencyISO;
        private System.Windows.Forms.CheckBox checkBox_defaultProjectCategory;
        private System.Windows.Forms.CheckBox checkBox_defaultProjectType;
        private System.Windows.Forms.CheckBox checkBox_defaultLegalEntity;
        private System.Windows.Forms.CheckBox checkBox_defaultProjectTemplate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_nonMandatoryFields;
        private System.Windows.Forms.Panel panel_NonMandatoryButton;
        private System.Windows.Forms.Panel panel_NonMandatoryFields;
        private System.Windows.Forms.Label label_nonMandatoryFields;
        private System.Windows.Forms.Button button_expandNonMandatory;
        private System.Windows.Forms.Timer tmrExpand;
        private System.Windows.Forms.ToolTip defaultToolTip;
        private System.Windows.Forms.CheckBox checkBox_defaultProjectDepartment;
        private System.Windows.Forms.Label label_projectDepartment;
        private System.Windows.Forms.ComboBox comboBox_projectDepartment;
    }
}
