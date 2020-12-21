namespace TimeLog.DataImporter.UserControls
{
    partial class UserControl_EmployeeImport
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
            this.dataGridView_employee = new System.Windows.Forms.DataGridView();
            this.panel_projectMessage = new System.Windows.Forms.Panel();
            this.textBox_employeeImportMessages = new System.Windows.Forms.TextBox();
            this.panel_projectButtons = new System.Windows.Forms.Panel();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_import = new System.Windows.Forms.Button();
            this.button_validate = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.panel_employeeFieldMapping = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_nonMandatoryFields = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_NonMandatoryButton = new System.Windows.Forms.Panel();
            this.label_nonMandatoryFields = new System.Windows.Forms.Label();
            this.button_expandNonMandatory = new System.Windows.Forms.Button();
            this.panel_NonMandatoryFields = new System.Windows.Forms.Panel();
            this.comboBox_userRoleDelimiter = new System.Windows.Forms.ComboBox();
            this.label_userRoleDelimiter = new System.Windows.Forms.Label();
            this.checkBox_defaultAllowanceLegislation = new System.Windows.Forms.CheckBox();
            this.comboBox_userRoles = new System.Windows.Forms.ComboBox();
            this.comboBox_allowanceLegislation = new System.Windows.Forms.ComboBox();
            this.comboBox_employeeType = new System.Windows.Forms.ComboBox();
            this.label_userRoleNames = new System.Windows.Forms.Label();
            this.label_allowanceLegislation = new System.Windows.Forms.Label();
            this.label_employeeType = new System.Windows.Forms.Label();
            this.checkBox_defaultDepartment = new System.Windows.Forms.CheckBox();
            this.label_jobTitle = new System.Windows.Forms.Label();
            this.comboBox_jobTitle = new System.Windows.Forms.ComboBox();
            this.checkBox_defaultLegalEntity = new System.Windows.Forms.CheckBox();
            this.checkBox_defaultEmployeeType = new System.Windows.Forms.CheckBox();
            this.label_department = new System.Windows.Forms.Label();
            this.comboBox_employeeNo = new System.Windows.Forms.ComboBox();
            this.comboBox_department = new System.Windows.Forms.ComboBox();
            this.label_employeeNo = new System.Windows.Forms.Label();
            this.comboBox_employmentDate = new System.Windows.Forms.ComboBox();
            this.label_employmentDate = new System.Windows.Forms.Label();
            this.label_legalEntity = new System.Windows.Forms.Label();
            this.comboBox_legalEntity = new System.Windows.Forms.ComboBox();
            this.label_delimiter = new System.Windows.Forms.Label();
            this.comboBox_delimiter = new System.Windows.Forms.ComboBox();
            this.groupBox_employeeMandatoryFields = new System.Windows.Forms.GroupBox();
            this.checkBox_defaultSalaryGroup = new System.Windows.Forms.CheckBox();
            this.checkBox_defaultNormalWorkingTime = new System.Windows.Forms.CheckBox();
            this.checkBox_defaultPublicHolidayCalendar = new System.Windows.Forms.CheckBox();
            this.comboBox_salaryGroup = new System.Windows.Forms.ComboBox();
            this.comboBox_normalWorkingTime = new System.Windows.Forms.ComboBox();
            this.comboBox_publicHolidayCalendar = new System.Windows.Forms.ComboBox();
            this.comboBox_costPrice = new System.Windows.Forms.ComboBox();
            this.label_salaryGroup = new System.Windows.Forms.Label();
            this.label_normalWorkingTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_costPrice = new System.Windows.Forms.Label();
            this.checkBox_defaultCostPrice = new System.Windows.Forms.CheckBox();
            this.checkBox_defaultHourlyRate = new System.Windows.Forms.CheckBox();
            this.label_managerInitials = new System.Windows.Forms.Label();
            this.comboBox_managerInitials = new System.Windows.Forms.ComboBox();
            this.label_email = new System.Windows.Forms.Label();
            this.label_defaultHourlyRate = new System.Windows.Forms.Label();
            this.comboBox_email = new System.Windows.Forms.ComboBox();
            this.label_initials = new System.Windows.Forms.Label();
            this.comboBox_initials = new System.Windows.Forms.ComboBox();
            this.label_lastName = new System.Windows.Forms.Label();
            this.comboBox_defaultHourlyRate = new System.Windows.Forms.ComboBox();
            this.comboBox_lastName = new System.Windows.Forms.ComboBox();
            this.label_firstName = new System.Windows.Forms.Label();
            this.comboBox_firstName = new System.Windows.Forms.ComboBox();
            this.label_userName = new System.Windows.Forms.Label();
            this.comboBox_userName = new System.Windows.Forms.ComboBox();
            this.label_employeeSetup = new System.Windows.Forms.Label();
            this.button_employeeSelectFile = new System.Windows.Forms.Button();
            this.tmrExpand = new System.Windows.Forms.Timer(this.components);
            this.defaultToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel_employeeDataTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employee)).BeginInit();
            this.panel_projectMessage.SuspendLayout();
            this.panel_projectButtons.SuspendLayout();
            this.panel_employeeFieldMapping.SuspendLayout();
            this.flowLayoutPanel_nonMandatoryFields.SuspendLayout();
            this.panel_NonMandatoryButton.SuspendLayout();
            this.panel_NonMandatoryFields.SuspendLayout();
            this.groupBox_employeeMandatoryFields.SuspendLayout();
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
            this.panel_employeeDataTable.Controls.Add(this.dataGridView_employee);
            this.panel_employeeDataTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_employeeDataTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_employeeDataTable.Location = new System.Drawing.Point(0, 581);
            this.panel_employeeDataTable.Name = "panel_employeeDataTable";
            this.panel_employeeDataTable.Size = new System.Drawing.Size(1006, 361);
            this.panel_employeeDataTable.TabIndex = 6;
            // 
            // dataGridView_employee
            // 
            this.dataGridView_employee.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView_employee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_employee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_employee.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dataGridView_employee.Location = new System.Drawing.Point(0, 10);
            this.dataGridView_employee.Name = "dataGridView_employee";
            this.dataGridView_employee.Size = new System.Drawing.Size(1006, 351);
            this.dataGridView_employee.TabIndex = 0;
            // 
            // panel_projectMessage
            // 
            this.panel_projectMessage.Controls.Add(this.textBox_employeeImportMessages);
            this.panel_projectMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_projectMessage.Location = new System.Drawing.Point(0, 397);
            this.panel_projectMessage.Name = "panel_projectMessage";
            this.panel_projectMessage.Size = new System.Drawing.Size(1006, 184);
            this.panel_projectMessage.TabIndex = 10;
            // 
            // textBox_employeeImportMessages
            // 
            this.textBox_employeeImportMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_employeeImportMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_employeeImportMessages.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_employeeImportMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_employeeImportMessages.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_employeeImportMessages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_employeeImportMessages.Location = new System.Drawing.Point(0, 0);
            this.textBox_employeeImportMessages.Multiline = true;
            this.textBox_employeeImportMessages.Name = "textBox_employeeImportMessages";
            this.textBox_employeeImportMessages.ReadOnly = true;
            this.textBox_employeeImportMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_employeeImportMessages.Size = new System.Drawing.Size(1006, 184);
            this.textBox_employeeImportMessages.TabIndex = 0;
            this.defaultToolTip.SetToolTip(this.textBox_employeeImportMessages, "Validation or import status");
            this.textBox_employeeImportMessages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_employeeImportMessages_MouseClick);
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
            this.panel_projectButtons.Location = new System.Drawing.Point(0, 345);
            this.panel_projectButtons.Name = "panel_projectButtons";
            this.panel_projectButtons.Size = new System.Drawing.Size(1006, 52);
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
            // panel_employeeFieldMapping
            // 
            this.panel_employeeFieldMapping.AutoScroll = true;
            this.panel_employeeFieldMapping.Controls.Add(this.flowLayoutPanel_nonMandatoryFields);
            this.panel_employeeFieldMapping.Controls.Add(this.label_delimiter);
            this.panel_employeeFieldMapping.Controls.Add(this.comboBox_delimiter);
            this.panel_employeeFieldMapping.Controls.Add(this.groupBox_employeeMandatoryFields);
            this.panel_employeeFieldMapping.Controls.Add(this.label_employeeSetup);
            this.panel_employeeFieldMapping.Controls.Add(this.button_employeeSelectFile);
            this.panel_employeeFieldMapping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_employeeFieldMapping.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel_employeeFieldMapping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_employeeFieldMapping.Location = new System.Drawing.Point(0, 0);
            this.panel_employeeFieldMapping.Name = "panel_employeeFieldMapping";
            this.panel_employeeFieldMapping.Size = new System.Drawing.Size(1006, 345);
            this.panel_employeeFieldMapping.TabIndex = 13;
            // 
            // flowLayoutPanel_nonMandatoryFields
            // 
            this.flowLayoutPanel_nonMandatoryFields.Controls.Add(this.panel_NonMandatoryButton);
            this.flowLayoutPanel_nonMandatoryFields.Controls.Add(this.panel_NonMandatoryFields);
            this.flowLayoutPanel_nonMandatoryFields.Location = new System.Drawing.Point(572, 60);
            this.flowLayoutPanel_nonMandatoryFields.Name = "flowLayoutPanel_nonMandatoryFields";
            this.flowLayoutPanel_nonMandatoryFields.Size = new System.Drawing.Size(390, 330);
            this.flowLayoutPanel_nonMandatoryFields.TabIndex = 7;
            // 
            // panel_NonMandatoryButton
            // 
            this.panel_NonMandatoryButton.Controls.Add(this.label_nonMandatoryFields);
            this.panel_NonMandatoryButton.Controls.Add(this.button_expandNonMandatory);
            this.panel_NonMandatoryButton.Location = new System.Drawing.Point(3, 3);
            this.panel_NonMandatoryButton.Name = "panel_NonMandatoryButton";
            this.panel_NonMandatoryButton.Size = new System.Drawing.Size(382, 32);
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
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_userRoleDelimiter);
            this.panel_NonMandatoryFields.Controls.Add(this.label_userRoleDelimiter);
            this.panel_NonMandatoryFields.Controls.Add(this.checkBox_defaultAllowanceLegislation);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_userRoles);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_allowanceLegislation);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_employeeType);
            this.panel_NonMandatoryFields.Controls.Add(this.label_userRoleNames);
            this.panel_NonMandatoryFields.Controls.Add(this.label_allowanceLegislation);
            this.panel_NonMandatoryFields.Controls.Add(this.label_employeeType);
            this.panel_NonMandatoryFields.Controls.Add(this.checkBox_defaultDepartment);
            this.panel_NonMandatoryFields.Controls.Add(this.label_jobTitle);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_jobTitle);
            this.panel_NonMandatoryFields.Controls.Add(this.checkBox_defaultLegalEntity);
            this.panel_NonMandatoryFields.Controls.Add(this.checkBox_defaultEmployeeType);
            this.panel_NonMandatoryFields.Controls.Add(this.label_department);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_employeeNo);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_department);
            this.panel_NonMandatoryFields.Controls.Add(this.label_employeeNo);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_employmentDate);
            this.panel_NonMandatoryFields.Controls.Add(this.label_employmentDate);
            this.panel_NonMandatoryFields.Controls.Add(this.label_legalEntity);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_legalEntity);
            this.panel_NonMandatoryFields.Location = new System.Drawing.Point(3, 41);
            this.panel_NonMandatoryFields.MaximumSize = new System.Drawing.Size(382, 289);
            this.panel_NonMandatoryFields.MinimumSize = new System.Drawing.Size(382, 0);
            this.panel_NonMandatoryFields.Name = "panel_NonMandatoryFields";
            this.panel_NonMandatoryFields.Size = new System.Drawing.Size(382, 289);
            this.panel_NonMandatoryFields.TabIndex = 1;
            // 
            // comboBox_userRoleDelimiter
            // 
            this.comboBox_userRoleDelimiter.FormattingEnabled = true;
            this.comboBox_userRoleDelimiter.Location = new System.Drawing.Point(153, 224);
            this.comboBox_userRoleDelimiter.Name = "comboBox_userRoleDelimiter";
            this.comboBox_userRoleDelimiter.Size = new System.Drawing.Size(150, 25);
            this.comboBox_userRoleDelimiter.TabIndex = 12;
            // 
            // label_userRoleDelimiter
            // 
            this.label_userRoleDelimiter.AutoSize = true;
            this.label_userRoleDelimiter.Location = new System.Drawing.Point(10, 227);
            this.label_userRoleDelimiter.Name = "label_userRoleDelimiter";
            this.label_userRoleDelimiter.Size = new System.Drawing.Size(123, 17);
            this.label_userRoleDelimiter.TabIndex = 1;
            this.label_userRoleDelimiter.Text = "User Role Delimiter";
            // 
            // checkBox_defaultAllowanceLegislation
            // 
            this.checkBox_defaultAllowanceLegislation.AutoSize = true;
            this.checkBox_defaultAllowanceLegislation.Location = new System.Drawing.Point(309, 195);
            this.checkBox_defaultAllowanceLegislation.Name = "checkBox_defaultAllowanceLegislation";
            this.checkBox_defaultAllowanceLegislation.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultAllowanceLegislation.TabIndex = 11;
            this.checkBox_defaultAllowanceLegislation.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultAllowanceLegislation, "Set default values for all rows of a particular column field");
            this.checkBox_defaultAllowanceLegislation.UseVisualStyleBackColor = true;
            this.checkBox_defaultAllowanceLegislation.CheckedChanged += new System.EventHandler(this.checkBox_defaultAllowanceLegislation_CheckedChanged);
            // 
            // comboBox_userRoles
            // 
            this.comboBox_userRoles.FormattingEnabled = true;
            this.comboBox_userRoles.Location = new System.Drawing.Point(153, 255);
            this.comboBox_userRoles.Name = "comboBox_userRoles";
            this.comboBox_userRoles.Size = new System.Drawing.Size(150, 25);
            this.comboBox_userRoles.TabIndex = 10;
            this.comboBox_userRoles.SelectedIndexChanged += new System.EventHandler(this.comboBox_userRoles_SelectedIndexChanged);
            // 
            // comboBox_allowanceLegislation
            // 
            this.comboBox_allowanceLegislation.FormattingEnabled = true;
            this.comboBox_allowanceLegislation.Location = new System.Drawing.Point(153, 193);
            this.comboBox_allowanceLegislation.Name = "comboBox_allowanceLegislation";
            this.comboBox_allowanceLegislation.Size = new System.Drawing.Size(150, 25);
            this.comboBox_allowanceLegislation.TabIndex = 10;
            this.comboBox_allowanceLegislation.SelectedIndexChanged += new System.EventHandler(this.comboBox_allowanceLegislation_SelectedIndexChanged);
            // 
            // comboBox_employeeType
            // 
            this.comboBox_employeeType.FormattingEnabled = true;
            this.comboBox_employeeType.Location = new System.Drawing.Point(153, 162);
            this.comboBox_employeeType.Name = "comboBox_employeeType";
            this.comboBox_employeeType.Size = new System.Drawing.Size(150, 25);
            this.comboBox_employeeType.TabIndex = 10;
            this.comboBox_employeeType.SelectedIndexChanged += new System.EventHandler(this.comboBox_employeeType_SelectedIndexChanged);
            // 
            // label_userRoleNames
            // 
            this.label_userRoleNames.AutoSize = true;
            this.label_userRoleNames.Location = new System.Drawing.Point(10, 258);
            this.label_userRoleNames.Name = "label_userRoleNames";
            this.label_userRoleNames.Size = new System.Drawing.Size(111, 17);
            this.label_userRoleNames.TabIndex = 1;
            this.label_userRoleNames.Text = "User Role Names";
            // 
            // label_allowanceLegislation
            // 
            this.label_allowanceLegislation.AutoSize = true;
            this.label_allowanceLegislation.Location = new System.Drawing.Point(10, 196);
            this.label_allowanceLegislation.Name = "label_allowanceLegislation";
            this.label_allowanceLegislation.Size = new System.Drawing.Size(137, 17);
            this.label_allowanceLegislation.TabIndex = 1;
            this.label_allowanceLegislation.Text = "Allowance Legislation";
            // 
            // label_employeeType
            // 
            this.label_employeeType.AutoSize = true;
            this.label_employeeType.Location = new System.Drawing.Point(10, 165);
            this.label_employeeType.Name = "label_employeeType";
            this.label_employeeType.Size = new System.Drawing.Size(99, 17);
            this.label_employeeType.TabIndex = 1;
            this.label_employeeType.Text = "Employee Type";
            // 
            // checkBox_defaultDepartment
            // 
            this.checkBox_defaultDepartment.AutoSize = true;
            this.checkBox_defaultDepartment.Location = new System.Drawing.Point(309, 133);
            this.checkBox_defaultDepartment.Name = "checkBox_defaultDepartment";
            this.checkBox_defaultDepartment.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultDepartment.TabIndex = 5;
            this.checkBox_defaultDepartment.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultDepartment, "Set default values for all rows of a particular column field");
            this.checkBox_defaultDepartment.UseVisualStyleBackColor = true;
            this.checkBox_defaultDepartment.CheckedChanged += new System.EventHandler(this.checkBox_defaultDepartment_CheckedChanged);
            // 
            // label_jobTitle
            // 
            this.label_jobTitle.AutoSize = true;
            this.label_jobTitle.Location = new System.Drawing.Point(10, 10);
            this.label_jobTitle.Name = "label_jobTitle";
            this.label_jobTitle.Size = new System.Drawing.Size(58, 17);
            this.label_jobTitle.TabIndex = 1;
            this.label_jobTitle.Text = "Job Title";
            // 
            // comboBox_jobTitle
            // 
            this.comboBox_jobTitle.FormattingEnabled = true;
            this.comboBox_jobTitle.Location = new System.Drawing.Point(153, 7);
            this.comboBox_jobTitle.Name = "comboBox_jobTitle";
            this.comboBox_jobTitle.Size = new System.Drawing.Size(150, 25);
            this.comboBox_jobTitle.TabIndex = 3;
            this.comboBox_jobTitle.SelectedIndexChanged += new System.EventHandler(this.comboBox_jobTitle_SelectedIndexChanged);
            // 
            // checkBox_defaultLegalEntity
            // 
            this.checkBox_defaultLegalEntity.AutoSize = true;
            this.checkBox_defaultLegalEntity.Location = new System.Drawing.Point(309, 102);
            this.checkBox_defaultLegalEntity.Name = "checkBox_defaultLegalEntity";
            this.checkBox_defaultLegalEntity.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultLegalEntity.TabIndex = 5;
            this.checkBox_defaultLegalEntity.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultLegalEntity, "Set default values for all rows of a particular column field");
            this.checkBox_defaultLegalEntity.UseVisualStyleBackColor = true;
            this.checkBox_defaultLegalEntity.CheckedChanged += new System.EventHandler(this.checkBox_defaultLegalEntity_CheckedChanged);
            // 
            // checkBox_defaultEmployeeType
            // 
            this.checkBox_defaultEmployeeType.AutoSize = true;
            this.checkBox_defaultEmployeeType.Location = new System.Drawing.Point(309, 164);
            this.checkBox_defaultEmployeeType.Name = "checkBox_defaultEmployeeType";
            this.checkBox_defaultEmployeeType.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultEmployeeType.TabIndex = 4;
            this.checkBox_defaultEmployeeType.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultEmployeeType, "Set default values for all rows of a particular column field");
            this.checkBox_defaultEmployeeType.UseVisualStyleBackColor = true;
            this.checkBox_defaultEmployeeType.CheckedChanged += new System.EventHandler(this.checkBox_defaultEmployeeType_CheckedChanged);
            // 
            // label_department
            // 
            this.label_department.AutoSize = true;
            this.label_department.Location = new System.Drawing.Point(10, 134);
            this.label_department.Name = "label_department";
            this.label_department.Size = new System.Drawing.Size(81, 17);
            this.label_department.TabIndex = 1;
            this.label_department.Text = "Department";
            // 
            // comboBox_employeeNo
            // 
            this.comboBox_employeeNo.FormattingEnabled = true;
            this.comboBox_employeeNo.Location = new System.Drawing.Point(153, 38);
            this.comboBox_employeeNo.Name = "comboBox_employeeNo";
            this.comboBox_employeeNo.Size = new System.Drawing.Size(150, 25);
            this.comboBox_employeeNo.TabIndex = 3;
            this.comboBox_employeeNo.SelectedIndexChanged += new System.EventHandler(this.comboBox_employeeNo_SelectedIndexChanged);
            // 
            // comboBox_department
            // 
            this.comboBox_department.FormattingEnabled = true;
            this.comboBox_department.Location = new System.Drawing.Point(153, 131);
            this.comboBox_department.Name = "comboBox_department";
            this.comboBox_department.Size = new System.Drawing.Size(150, 25);
            this.comboBox_department.TabIndex = 3;
            this.comboBox_department.SelectedIndexChanged += new System.EventHandler(this.comboBox_department_SelectedIndexChanged);
            // 
            // label_employeeNo
            // 
            this.label_employeeNo.AutoSize = true;
            this.label_employeeNo.Location = new System.Drawing.Point(10, 41);
            this.label_employeeNo.Name = "label_employeeNo";
            this.label_employeeNo.Size = new System.Drawing.Size(89, 17);
            this.label_employeeNo.TabIndex = 1;
            this.label_employeeNo.Text = "Employee No";
            // 
            // comboBox_employmentDate
            // 
            this.comboBox_employmentDate.FormattingEnabled = true;
            this.comboBox_employmentDate.Location = new System.Drawing.Point(153, 69);
            this.comboBox_employmentDate.Name = "comboBox_employmentDate";
            this.comboBox_employmentDate.Size = new System.Drawing.Size(150, 25);
            this.comboBox_employmentDate.TabIndex = 3;
            this.comboBox_employmentDate.SelectedIndexChanged += new System.EventHandler(this.comboBox_employmentDate_SelectedIndexChanged);
            // 
            // label_employmentDate
            // 
            this.label_employmentDate.AutoSize = true;
            this.label_employmentDate.Location = new System.Drawing.Point(10, 72);
            this.label_employmentDate.Name = "label_employmentDate";
            this.label_employmentDate.Size = new System.Drawing.Size(117, 17);
            this.label_employmentDate.TabIndex = 1;
            this.label_employmentDate.Text = "Employment Date";
            // 
            // label_legalEntity
            // 
            this.label_legalEntity.AutoSize = true;
            this.label_legalEntity.Location = new System.Drawing.Point(10, 103);
            this.label_legalEntity.Name = "label_legalEntity";
            this.label_legalEntity.Size = new System.Drawing.Size(78, 17);
            this.label_legalEntity.TabIndex = 1;
            this.label_legalEntity.Text = "Legal Entity";
            // 
            // comboBox_legalEntity
            // 
            this.comboBox_legalEntity.FormattingEnabled = true;
            this.comboBox_legalEntity.Location = new System.Drawing.Point(153, 100);
            this.comboBox_legalEntity.Name = "comboBox_legalEntity";
            this.comboBox_legalEntity.Size = new System.Drawing.Size(150, 25);
            this.comboBox_legalEntity.TabIndex = 3;
            this.comboBox_legalEntity.SelectedIndexChanged += new System.EventHandler(this.comboBox_legalEntity_SelectedIndexChanged);
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
            // groupBox_employeeMandatoryFields
            // 
            this.groupBox_employeeMandatoryFields.Controls.Add(this.checkBox_defaultSalaryGroup);
            this.groupBox_employeeMandatoryFields.Controls.Add(this.checkBox_defaultNormalWorkingTime);
            this.groupBox_employeeMandatoryFields.Controls.Add(this.checkBox_defaultPublicHolidayCalendar);
            this.groupBox_employeeMandatoryFields.Controls.Add(this.comboBox_salaryGroup);
            this.groupBox_employeeMandatoryFields.Controls.Add(this.comboBox_normalWorkingTime);
            this.groupBox_employeeMandatoryFields.Controls.Add(this.comboBox_publicHolidayCalendar);
            this.groupBox_employeeMandatoryFields.Controls.Add(this.comboBox_costPrice);
            this.groupBox_employeeMandatoryFields.Controls.Add(this.label_salaryGroup);
            this.groupBox_employeeMandatoryFields.Controls.Add(this.label_normalWorkingTime);
            this.groupBox_employeeMandatoryFields.Controls.Add(this.label2);
            this.groupBox_employeeMandatoryFields.Controls.Add(this.label_costPrice);
            this.groupBox_employeeMandatoryFields.Controls.Add(this.checkBox_defaultCostPrice);
            this.groupBox_employeeMandatoryFields.Controls.Add(this.checkBox_defaultHourlyRate);
            this.groupBox_employeeMandatoryFields.Controls.Add(this.label_managerInitials);
            this.groupBox_employeeMandatoryFields.Controls.Add(this.comboBox_managerInitials);
            this.groupBox_employeeMandatoryFields.Controls.Add(this.label_email);
            this.groupBox_employeeMandatoryFields.Controls.Add(this.label_defaultHourlyRate);
            this.groupBox_employeeMandatoryFields.Controls.Add(this.comboBox_email);
            this.groupBox_employeeMandatoryFields.Controls.Add(this.label_initials);
            this.groupBox_employeeMandatoryFields.Controls.Add(this.comboBox_initials);
            this.groupBox_employeeMandatoryFields.Controls.Add(this.label_lastName);
            this.groupBox_employeeMandatoryFields.Controls.Add(this.comboBox_defaultHourlyRate);
            this.groupBox_employeeMandatoryFields.Controls.Add(this.comboBox_lastName);
            this.groupBox_employeeMandatoryFields.Controls.Add(this.label_firstName);
            this.groupBox_employeeMandatoryFields.Controls.Add(this.comboBox_firstName);
            this.groupBox_employeeMandatoryFields.Controls.Add(this.label_userName);
            this.groupBox_employeeMandatoryFields.Controls.Add(this.comboBox_userName);
            this.groupBox_employeeMandatoryFields.Location = new System.Drawing.Point(160, 62);
            this.groupBox_employeeMandatoryFields.Name = "groupBox_employeeMandatoryFields";
            this.groupBox_employeeMandatoryFields.Size = new System.Drawing.Size(394, 370);
            this.groupBox_employeeMandatoryFields.TabIndex = 5;
            this.groupBox_employeeMandatoryFields.TabStop = false;
            this.groupBox_employeeMandatoryFields.Text = "Mandatory";
            // 
            // checkBox_defaultSalaryGroup
            // 
            this.checkBox_defaultSalaryGroup.AutoSize = true;
            this.checkBox_defaultSalaryGroup.Location = new System.Drawing.Point(323, 336);
            this.checkBox_defaultSalaryGroup.Name = "checkBox_defaultSalaryGroup";
            this.checkBox_defaultSalaryGroup.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultSalaryGroup.TabIndex = 13;
            this.checkBox_defaultSalaryGroup.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultSalaryGroup, "Set default values for all rows of a particular column field");
            this.checkBox_defaultSalaryGroup.UseVisualStyleBackColor = true;
            this.checkBox_defaultSalaryGroup.CheckedChanged += new System.EventHandler(this.checkBox_defaultSalaryGroup_CheckedChanged);
            // 
            // checkBox_defaultNormalWorkingTime
            // 
            this.checkBox_defaultNormalWorkingTime.AutoSize = true;
            this.checkBox_defaultNormalWorkingTime.Location = new System.Drawing.Point(323, 305);
            this.checkBox_defaultNormalWorkingTime.Name = "checkBox_defaultNormalWorkingTime";
            this.checkBox_defaultNormalWorkingTime.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultNormalWorkingTime.TabIndex = 12;
            this.checkBox_defaultNormalWorkingTime.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultNormalWorkingTime, "Set default values for all rows of a particular column field");
            this.checkBox_defaultNormalWorkingTime.UseVisualStyleBackColor = true;
            this.checkBox_defaultNormalWorkingTime.CheckedChanged += new System.EventHandler(this.checkBox_defaultNormalWorkingTime_CheckedChanged);
            // 
            // checkBox_defaultPublicHolidayCalendar
            // 
            this.checkBox_defaultPublicHolidayCalendar.AutoSize = true;
            this.checkBox_defaultPublicHolidayCalendar.Location = new System.Drawing.Point(323, 274);
            this.checkBox_defaultPublicHolidayCalendar.Name = "checkBox_defaultPublicHolidayCalendar";
            this.checkBox_defaultPublicHolidayCalendar.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultPublicHolidayCalendar.TabIndex = 11;
            this.checkBox_defaultPublicHolidayCalendar.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultPublicHolidayCalendar, "Set default values for all rows of a particular column field");
            this.checkBox_defaultPublicHolidayCalendar.UseVisualStyleBackColor = true;
            this.checkBox_defaultPublicHolidayCalendar.CheckedChanged += new System.EventHandler(this.checkBox_defaultPublicHolidayCalendar_CheckedChanged);
            // 
            // comboBox_salaryGroup
            // 
            this.comboBox_salaryGroup.FormattingEnabled = true;
            this.comboBox_salaryGroup.Location = new System.Drawing.Point(163, 334);
            this.comboBox_salaryGroup.Name = "comboBox_salaryGroup";
            this.comboBox_salaryGroup.Size = new System.Drawing.Size(154, 25);
            this.comboBox_salaryGroup.TabIndex = 10;
            this.comboBox_salaryGroup.SelectedIndexChanged += new System.EventHandler(this.comboBox_salaryGroup_SelectedIndexChanged);
            // 
            // comboBox_normalWorkingTime
            // 
            this.comboBox_normalWorkingTime.FormattingEnabled = true;
            this.comboBox_normalWorkingTime.Location = new System.Drawing.Point(163, 303);
            this.comboBox_normalWorkingTime.Name = "comboBox_normalWorkingTime";
            this.comboBox_normalWorkingTime.Size = new System.Drawing.Size(154, 25);
            this.comboBox_normalWorkingTime.TabIndex = 9;
            this.comboBox_normalWorkingTime.SelectedIndexChanged += new System.EventHandler(this.comboBox_normalWorkingTime_SelectedIndexChanged);
            // 
            // comboBox_publicHolidayCalendar
            // 
            this.comboBox_publicHolidayCalendar.FormattingEnabled = true;
            this.comboBox_publicHolidayCalendar.Location = new System.Drawing.Point(163, 272);
            this.comboBox_publicHolidayCalendar.Name = "comboBox_publicHolidayCalendar";
            this.comboBox_publicHolidayCalendar.Size = new System.Drawing.Size(154, 25);
            this.comboBox_publicHolidayCalendar.TabIndex = 8;
            this.comboBox_publicHolidayCalendar.SelectedIndexChanged += new System.EventHandler(this.comboBox_publicHolidayCalendar_SelectedIndexChanged);
            // 
            // comboBox_costPrice
            // 
            this.comboBox_costPrice.FormattingEnabled = true;
            this.comboBox_costPrice.Location = new System.Drawing.Point(163, 241);
            this.comboBox_costPrice.Name = "comboBox_costPrice";
            this.comboBox_costPrice.Size = new System.Drawing.Size(154, 25);
            this.comboBox_costPrice.TabIndex = 7;
            this.comboBox_costPrice.SelectedIndexChanged += new System.EventHandler(this.comboBox_costPrice_SelectedIndexChanged);
            // 
            // label_salaryGroup
            // 
            this.label_salaryGroup.AutoSize = true;
            this.label_salaryGroup.Location = new System.Drawing.Point(6, 337);
            this.label_salaryGroup.Name = "label_salaryGroup";
            this.label_salaryGroup.Size = new System.Drawing.Size(87, 17);
            this.label_salaryGroup.TabIndex = 1;
            this.label_salaryGroup.Text = "Salary Group";
            // 
            // label_normalWorkingTime
            // 
            this.label_normalWorkingTime.AutoSize = true;
            this.label_normalWorkingTime.Location = new System.Drawing.Point(6, 306);
            this.label_normalWorkingTime.Name = "label_normalWorkingTime";
            this.label_normalWorkingTime.Size = new System.Drawing.Size(142, 17);
            this.label_normalWorkingTime.TabIndex = 1;
            this.label_normalWorkingTime.Text = "Normal Working Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Public Holiday Calendar";
            // 
            // label_costPrice
            // 
            this.label_costPrice.AutoSize = true;
            this.label_costPrice.Location = new System.Drawing.Point(6, 244);
            this.label_costPrice.Name = "label_costPrice";
            this.label_costPrice.Size = new System.Drawing.Size(68, 17);
            this.label_costPrice.TabIndex = 1;
            this.label_costPrice.Text = "Cost Price";
            // 
            // checkBox_defaultCostPrice
            // 
            this.checkBox_defaultCostPrice.AutoSize = true;
            this.checkBox_defaultCostPrice.Location = new System.Drawing.Point(323, 243);
            this.checkBox_defaultCostPrice.Name = "checkBox_defaultCostPrice";
            this.checkBox_defaultCostPrice.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultCostPrice.TabIndex = 6;
            this.checkBox_defaultCostPrice.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultCostPrice, "Set default values for all rows of a particular column field");
            this.checkBox_defaultCostPrice.UseVisualStyleBackColor = true;
            this.checkBox_defaultCostPrice.CheckedChanged += new System.EventHandler(this.checkBox_defaultCostPrice_CheckedChanged);
            // 
            // checkBox_defaultHourlyRate
            // 
            this.checkBox_defaultHourlyRate.AutoSize = true;
            this.checkBox_defaultHourlyRate.Location = new System.Drawing.Point(323, 212);
            this.checkBox_defaultHourlyRate.Name = "checkBox_defaultHourlyRate";
            this.checkBox_defaultHourlyRate.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultHourlyRate.TabIndex = 4;
            this.checkBox_defaultHourlyRate.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultHourlyRate, "Set default values for all rows of a particular column field");
            this.checkBox_defaultHourlyRate.UseVisualStyleBackColor = true;
            this.checkBox_defaultHourlyRate.CheckedChanged += new System.EventHandler(this.checkBox_defaultHourlyRate_CheckedChanged);
            // 
            // label_managerInitials
            // 
            this.label_managerInitials.AutoSize = true;
            this.label_managerInitials.Location = new System.Drawing.Point(6, 182);
            this.label_managerInitials.Name = "label_managerInitials";
            this.label_managerInitials.Size = new System.Drawing.Size(105, 17);
            this.label_managerInitials.TabIndex = 1;
            this.label_managerInitials.Text = "Manager Initials";
            // 
            // comboBox_managerInitials
            // 
            this.comboBox_managerInitials.FormattingEnabled = true;
            this.comboBox_managerInitials.Location = new System.Drawing.Point(163, 179);
            this.comboBox_managerInitials.Name = "comboBox_managerInitials";
            this.comboBox_managerInitials.Size = new System.Drawing.Size(154, 25);
            this.comboBox_managerInitials.TabIndex = 3;
            this.comboBox_managerInitials.SelectedIndexChanged += new System.EventHandler(this.comboBox_managerInitials_SelectedIndexChanged);
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(6, 151);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(40, 17);
            this.label_email.TabIndex = 1;
            this.label_email.Text = "Email";
            // 
            // label_defaultHourlyRate
            // 
            this.label_defaultHourlyRate.AutoSize = true;
            this.label_defaultHourlyRate.Location = new System.Drawing.Point(6, 213);
            this.label_defaultHourlyRate.Name = "label_defaultHourlyRate";
            this.label_defaultHourlyRate.Size = new System.Drawing.Size(127, 17);
            this.label_defaultHourlyRate.TabIndex = 1;
            this.label_defaultHourlyRate.Text = "Default Hourly Rate";
            // 
            // comboBox_email
            // 
            this.comboBox_email.FormattingEnabled = true;
            this.comboBox_email.Location = new System.Drawing.Point(163, 148);
            this.comboBox_email.Name = "comboBox_email";
            this.comboBox_email.Size = new System.Drawing.Size(154, 25);
            this.comboBox_email.TabIndex = 3;
            this.comboBox_email.SelectedIndexChanged += new System.EventHandler(this.comboBox_email_SelectedIndexChanged);
            // 
            // label_initials
            // 
            this.label_initials.AutoSize = true;
            this.label_initials.Location = new System.Drawing.Point(6, 120);
            this.label_initials.Name = "label_initials";
            this.label_initials.Size = new System.Drawing.Size(47, 17);
            this.label_initials.TabIndex = 1;
            this.label_initials.Text = "Initials";
            // 
            // comboBox_initials
            // 
            this.comboBox_initials.FormattingEnabled = true;
            this.comboBox_initials.Location = new System.Drawing.Point(163, 117);
            this.comboBox_initials.Name = "comboBox_initials";
            this.comboBox_initials.Size = new System.Drawing.Size(154, 25);
            this.comboBox_initials.TabIndex = 3;
            this.comboBox_initials.SelectedIndexChanged += new System.EventHandler(this.comboBox_initials_SelectedIndexChanged);
            // 
            // label_lastName
            // 
            this.label_lastName.AutoSize = true;
            this.label_lastName.Location = new System.Drawing.Point(6, 89);
            this.label_lastName.Name = "label_lastName";
            this.label_lastName.Size = new System.Drawing.Size(72, 17);
            this.label_lastName.TabIndex = 1;
            this.label_lastName.Text = "Last Name";
            // 
            // comboBox_defaultHourlyRate
            // 
            this.comboBox_defaultHourlyRate.FormattingEnabled = true;
            this.comboBox_defaultHourlyRate.Location = new System.Drawing.Point(163, 210);
            this.comboBox_defaultHourlyRate.Name = "comboBox_defaultHourlyRate";
            this.comboBox_defaultHourlyRate.Size = new System.Drawing.Size(154, 25);
            this.comboBox_defaultHourlyRate.TabIndex = 3;
            this.comboBox_defaultHourlyRate.SelectedIndexChanged += new System.EventHandler(this.comboBox_defaultHourlyRate_SelectedIndexChanged);
            // 
            // comboBox_lastName
            // 
            this.comboBox_lastName.FormattingEnabled = true;
            this.comboBox_lastName.Location = new System.Drawing.Point(163, 86);
            this.comboBox_lastName.Name = "comboBox_lastName";
            this.comboBox_lastName.Size = new System.Drawing.Size(154, 25);
            this.comboBox_lastName.TabIndex = 3;
            this.comboBox_lastName.SelectedIndexChanged += new System.EventHandler(this.comboBox_lastName_SelectedIndexChanged);
            // 
            // label_firstName
            // 
            this.label_firstName.AutoSize = true;
            this.label_firstName.Location = new System.Drawing.Point(6, 58);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(74, 17);
            this.label_firstName.TabIndex = 1;
            this.label_firstName.Text = "First Name";
            // 
            // comboBox_firstName
            // 
            this.comboBox_firstName.FormattingEnabled = true;
            this.comboBox_firstName.Location = new System.Drawing.Point(163, 55);
            this.comboBox_firstName.Name = "comboBox_firstName";
            this.comboBox_firstName.Size = new System.Drawing.Size(154, 25);
            this.comboBox_firstName.TabIndex = 3;
            this.comboBox_firstName.SelectedIndexChanged += new System.EventHandler(this.comboBox_firstName_SelectedIndexChanged);
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Location = new System.Drawing.Point(6, 27);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(69, 17);
            this.label_userName.TabIndex = 1;
            this.label_userName.Text = "Username";
            // 
            // comboBox_userName
            // 
            this.comboBox_userName.FormattingEnabled = true;
            this.comboBox_userName.Location = new System.Drawing.Point(163, 24);
            this.comboBox_userName.Name = "comboBox_userName";
            this.comboBox_userName.Size = new System.Drawing.Size(154, 25);
            this.comboBox_userName.TabIndex = 3;
            this.comboBox_userName.SelectedIndexChanged += new System.EventHandler(this.comboBox_userName_SelectedIndexChanged);
            // 
            // label_employeeSetup
            // 
            this.label_employeeSetup.AutoSize = true;
            this.label_employeeSetup.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_employeeSetup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_employeeSetup.Location = new System.Drawing.Point(7, 16);
            this.label_employeeSetup.Name = "label_employeeSetup";
            this.label_employeeSetup.Size = new System.Drawing.Size(260, 32);
            this.label_employeeSetup.TabIndex = 0;
            this.label_employeeSetup.Text = "Employee Data Import";
            // 
            // button_employeeSelectFile
            // 
            this.button_employeeSelectFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(43)))), ((int)(((byte)(141)))));
            this.button_employeeSelectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_employeeSelectFile.FlatAppearance.BorderSize = 0;
            this.button_employeeSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_employeeSelectFile.ForeColor = System.Drawing.Color.White;
            this.button_employeeSelectFile.Location = new System.Drawing.Point(13, 111);
            this.button_employeeSelectFile.Name = "button_employeeSelectFile";
            this.button_employeeSelectFile.Size = new System.Drawing.Size(80, 29);
            this.button_employeeSelectFile.TabIndex = 4;
            this.button_employeeSelectFile.Text = "Select File";
            this.defaultToolTip.SetToolTip(this.button_employeeSelectFile, "Select input CSV file");
            this.button_employeeSelectFile.UseVisualStyleBackColor = false;
            this.button_employeeSelectFile.Click += new System.EventHandler(this.button_select_project_file_Click);
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
            // UserControl_EmployeeImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_employeeFieldMapping);
            this.Controls.Add(this.panel_projectButtons);
            this.Controls.Add(this.panel_projectMessage);
            this.Controls.Add(this.panel_employeeDataTable);
            this.Name = "UserControl_EmployeeImport";
            this.Size = new System.Drawing.Size(1006, 942);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.panel_employeeDataTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employee)).EndInit();
            this.panel_projectMessage.ResumeLayout(false);
            this.panel_projectMessage.PerformLayout();
            this.panel_projectButtons.ResumeLayout(false);
            this.panel_employeeFieldMapping.ResumeLayout(false);
            this.panel_employeeFieldMapping.PerformLayout();
            this.flowLayoutPanel_nonMandatoryFields.ResumeLayout(false);
            this.panel_NonMandatoryButton.ResumeLayout(false);
            this.panel_NonMandatoryButton.PerformLayout();
            this.panel_NonMandatoryFields.ResumeLayout(false);
            this.panel_NonMandatoryFields.PerformLayout();
            this.groupBox_employeeMandatoryFields.ResumeLayout(false);
            this.groupBox_employeeMandatoryFields.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private void AddRowNumberToDataTable()
        {
            this.dataGridView_employee.DataBindingComplete += (o, e) =>
            {
                foreach (System.Windows.Forms.DataGridViewRow row in dataGridView_employee.Rows)
                {
                    row.HeaderCell.Value = (row.Index + 1).ToString();

                }
            };
            this.dataGridView_employee.RowHeadersWidth = 65;
        }


        private System.ComponentModel.BackgroundWorker WorkerFetcher;
        private System.Windows.Forms.Panel panel_employeeDataTable;
        private System.Windows.Forms.DataGridView dataGridView_employee;
        private System.Windows.Forms.Panel panel_projectMessage;
        private System.Windows.Forms.Panel panel_projectButtons;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_import;
        private System.Windows.Forms.Button button_validate;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Panel panel_employeeFieldMapping;
        private System.Windows.Forms.GroupBox groupBox_employeeMandatoryFields;
        private System.Windows.Forms.ComboBox comboBox_userName;
        private System.Windows.Forms.Label label_userName;
        private System.Windows.Forms.Label label_employeeSetup;
        private System.Windows.Forms.Button button_employeeSelectFile;
        private System.Windows.Forms.TextBox textBox_employeeImportMessages;
        private System.Windows.Forms.Label label_lastName;
        private System.Windows.Forms.ComboBox comboBox_lastName;
        private System.Windows.Forms.Label label_firstName;
        private System.Windows.Forms.ComboBox comboBox_firstName;
        private System.Windows.Forms.Label label_managerInitials;
        private System.Windows.Forms.ComboBox comboBox_managerInitials;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.ComboBox comboBox_email;
        private System.Windows.Forms.Label label_initials;
        private System.Windows.Forms.ComboBox comboBox_initials;
        private System.Windows.Forms.Label label_delimiter;
        private System.Windows.Forms.ComboBox comboBox_delimiter;
        private System.Windows.Forms.Label label_department;
        private System.Windows.Forms.ComboBox comboBox_department;
        private System.Windows.Forms.Label label_defaultHourlyRate;
        private System.Windows.Forms.ComboBox comboBox_defaultHourlyRate;
        private System.Windows.Forms.Label label_legalEntity;
        private System.Windows.Forms.ComboBox comboBox_legalEntity;
        private System.Windows.Forms.Label label_employmentDate;
        private System.Windows.Forms.ComboBox comboBox_employmentDate;
        private System.Windows.Forms.Label label_employeeNo;
        private System.Windows.Forms.ComboBox comboBox_employeeNo;
        private System.Windows.Forms.Label label_jobTitle;
        private System.Windows.Forms.ComboBox comboBox_jobTitle;
        private System.Windows.Forms.CheckBox checkBox_defaultEmployeeType;
        private System.Windows.Forms.CheckBox checkBox_defaultDepartment;
        private System.Windows.Forms.CheckBox checkBox_defaultHourlyRate;
        private System.Windows.Forms.CheckBox checkBox_defaultCostPrice;
        private System.Windows.Forms.CheckBox checkBox_defaultLegalEntity;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_nonMandatoryFields;
        private System.Windows.Forms.Panel panel_NonMandatoryButton;
        private System.Windows.Forms.Panel panel_NonMandatoryFields;
        private System.Windows.Forms.Label label_nonMandatoryFields;
        private System.Windows.Forms.Button button_expandNonMandatory;
        private System.Windows.Forms.Timer tmrExpand;
        private System.Windows.Forms.ToolTip defaultToolTip;
        private System.Windows.Forms.Label label_normalWorkingTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_costPrice;
        private System.Windows.Forms.ComboBox comboBox_salaryGroup;
        private System.Windows.Forms.ComboBox comboBox_normalWorkingTime;
        private System.Windows.Forms.ComboBox comboBox_publicHolidayCalendar;
        private System.Windows.Forms.ComboBox comboBox_costPrice;
        private System.Windows.Forms.Label label_salaryGroup;
        private System.Windows.Forms.Label label_employeeType;
        private System.Windows.Forms.Label label_userRoleNames;
        private System.Windows.Forms.Label label_allowanceLegislation;
        private System.Windows.Forms.ComboBox comboBox_userRoles;
        private System.Windows.Forms.ComboBox comboBox_allowanceLegislation;
        private System.Windows.Forms.ComboBox comboBox_employeeType;
        private System.Windows.Forms.CheckBox checkBox_defaultSalaryGroup;
        private System.Windows.Forms.CheckBox checkBox_defaultNormalWorkingTime;
        private System.Windows.Forms.CheckBox checkBox_defaultPublicHolidayCalendar;
        private System.Windows.Forms.CheckBox checkBox_defaultAllowanceLegislation;
        private System.Windows.Forms.ComboBox comboBox_userRoleDelimiter;
        private System.Windows.Forms.Label label_userRoleDelimiter;
    }
}
