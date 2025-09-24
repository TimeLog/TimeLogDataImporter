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
            components = new System.ComponentModel.Container();
            WorkerFetcher = new System.ComponentModel.BackgroundWorker();
            panel_employeeDataTable = new System.Windows.Forms.Panel();
            dataGridView_employee = new System.Windows.Forms.DataGridView();
            panel_projectMessage = new System.Windows.Forms.Panel();
            textBox_employeeImportMessages = new System.Windows.Forms.TextBox();
            panel_projectButtons = new System.Windows.Forms.Panel();
            button_clear = new System.Windows.Forms.Button();
            button_import = new System.Windows.Forms.Button();
            button_validate = new System.Windows.Forms.Button();
            button_stop = new System.Windows.Forms.Button();
            panel_employeeFieldMapping = new System.Windows.Forms.Panel();
            flowLayoutPanel_nonMandatoryFields = new System.Windows.Forms.FlowLayoutPanel();
            panel_NonMandatoryButton = new System.Windows.Forms.Panel();
            label_nonMandatoryFields = new System.Windows.Forms.Label();
            button_expandNonMandatory = new System.Windows.Forms.Button();
            panel_NonMandatoryFields = new System.Windows.Forms.Panel();
            comboBox_userRoleDelimiter = new System.Windows.Forms.ComboBox();
            label_userRoleDelimiter = new System.Windows.Forms.Label();
            comboBox_userRoles = new System.Windows.Forms.ComboBox();
            label_userRoleNames = new System.Windows.Forms.Label();
            label_jobTitle = new System.Windows.Forms.Label();
            comboBox_jobTitle = new System.Windows.Forms.ComboBox();
            comboBox_employeeNo = new System.Windows.Forms.ComboBox();
            label_employeeNo = new System.Windows.Forms.Label();
            comboBox_employmentDate = new System.Windows.Forms.ComboBox();
            label_employmentDate = new System.Windows.Forms.Label();
            label_delimiter = new System.Windows.Forms.Label();
            comboBox_delimiter = new System.Windows.Forms.ComboBox();
            groupBox_employeeMandatoryFields = new System.Windows.Forms.GroupBox();
            checkBox_defaultSalaryGroup = new System.Windows.Forms.CheckBox();
            checkBox_defaultNormalWorkingTime = new System.Windows.Forms.CheckBox();
            checkBox_defaultAllowanceLegislation = new System.Windows.Forms.CheckBox();
            checkBox_defaultPublicHolidayCalendar = new System.Windows.Forms.CheckBox();
            comboBox_salaryGroup = new System.Windows.Forms.ComboBox();
            comboBox_allowanceLegislation = new System.Windows.Forms.ComboBox();
            comboBox_normalWorkingTime = new System.Windows.Forms.ComboBox();
            comboBox_employeeType = new System.Windows.Forms.ComboBox();
            comboBox_publicHolidayCalendar = new System.Windows.Forms.ComboBox();
            comboBox_costPrice = new System.Windows.Forms.ComboBox();
            label_allowanceLegislation = new System.Windows.Forms.Label();
            label_salaryGroup = new System.Windows.Forms.Label();
            label_employeeType = new System.Windows.Forms.Label();
            label_normalWorkingTime = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            checkBox_defaultEmployeeType = new System.Windows.Forms.CheckBox();
            label_costPrice = new System.Windows.Forms.Label();
            checkBox_defaultCostPrice = new System.Windows.Forms.CheckBox();
            checkBox_defaultHourlyRate = new System.Windows.Forms.CheckBox();
            label_managerInitials = new System.Windows.Forms.Label();
            comboBox_managerInitials = new System.Windows.Forms.ComboBox();
            label_email = new System.Windows.Forms.Label();
            label_defaultHourlyRate = new System.Windows.Forms.Label();
            comboBox_email = new System.Windows.Forms.ComboBox();
            label_initials = new System.Windows.Forms.Label();
            comboBox_initials = new System.Windows.Forms.ComboBox();
            label_lastName = new System.Windows.Forms.Label();
            comboBox_defaultHourlyRate = new System.Windows.Forms.ComboBox();
            comboBox_lastName = new System.Windows.Forms.ComboBox();
            label_firstName = new System.Windows.Forms.Label();
            comboBox_firstName = new System.Windows.Forms.ComboBox();
            label_userName = new System.Windows.Forms.Label();
            comboBox_userName = new System.Windows.Forms.ComboBox();
            checkBox_defaultLegalEntity = new System.Windows.Forms.CheckBox();
            label_legalEntity = new System.Windows.Forms.Label();
            comboBox_legalEntity = new System.Windows.Forms.ComboBox();
            label_department = new System.Windows.Forms.Label();
            checkBox_defaultDepartment = new System.Windows.Forms.CheckBox();
            comboBox_department = new System.Windows.Forms.ComboBox();
            label_employeeSetup = new System.Windows.Forms.Label();
            button_employeeSelectFile = new System.Windows.Forms.Button();
            tmrExpand = new System.Windows.Forms.Timer(components);
            defaultToolTip = new System.Windows.Forms.ToolTip(components);
            panel_employeeDataTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_employee).BeginInit();
            panel_projectMessage.SuspendLayout();
            panel_projectButtons.SuspendLayout();
            panel_employeeFieldMapping.SuspendLayout();
            flowLayoutPanel_nonMandatoryFields.SuspendLayout();
            panel_NonMandatoryButton.SuspendLayout();
            panel_NonMandatoryFields.SuspendLayout();
            groupBox_employeeMandatoryFields.SuspendLayout();
            SuspendLayout();
            // 
            // WorkerFetcher
            // 
            WorkerFetcher.WorkerReportsProgress = true;
            WorkerFetcher.WorkerSupportsCancellation = true;
            WorkerFetcher.DoWork += WorkerFetcherDoWork;
            // 
            // panel_employeeDataTable
            // 
            panel_employeeDataTable.Controls.Add(dataGridView_employee);
            panel_employeeDataTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_employeeDataTable.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel_employeeDataTable.Location = new System.Drawing.Point(0, 462);
            panel_employeeDataTable.Name = "panel_employeeDataTable";
            panel_employeeDataTable.Size = new System.Drawing.Size(1006, 180);
            panel_employeeDataTable.TabIndex = 6;
            // 
            // dataGridView_employee
            // 
            dataGridView_employee.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridView_employee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridView_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_employee.Dock = System.Windows.Forms.DockStyle.Bottom;
            dataGridView_employee.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridView_employee.Location = new System.Drawing.Point(0, 0);
            dataGridView_employee.Name = "dataGridView_employee";
            dataGridView_employee.Size = new System.Drawing.Size(1006, 180);
            dataGridView_employee.TabIndex = 0;
            // 
            // panel_projectMessage
            // 
            panel_projectMessage.Controls.Add(textBox_employeeImportMessages);
            panel_projectMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_projectMessage.Location = new System.Drawing.Point(0, 278);
            panel_projectMessage.Name = "panel_projectMessage";
            panel_projectMessage.Size = new System.Drawing.Size(1006, 184);
            panel_projectMessage.TabIndex = 10;
            // 
            // textBox_employeeImportMessages
            // 
            textBox_employeeImportMessages.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            textBox_employeeImportMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox_employeeImportMessages.Dock = System.Windows.Forms.DockStyle.Bottom;
            textBox_employeeImportMessages.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            textBox_employeeImportMessages.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            textBox_employeeImportMessages.Location = new System.Drawing.Point(0, 4);
            textBox_employeeImportMessages.Multiline = true;
            textBox_employeeImportMessages.Name = "textBox_employeeImportMessages";
            textBox_employeeImportMessages.ReadOnly = true;
            textBox_employeeImportMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBox_employeeImportMessages.Size = new System.Drawing.Size(1006, 180);
            textBox_employeeImportMessages.TabIndex = 0;
            defaultToolTip.SetToolTip(textBox_employeeImportMessages, "Validation or import status");
            textBox_employeeImportMessages.WordWrap = false;
            textBox_employeeImportMessages.MouseClick += textBox_employeeImportMessages_MouseClick;
            // 
            // panel_projectButtons
            // 
            panel_projectButtons.Controls.Add(button_clear);
            panel_projectButtons.Controls.Add(button_import);
            panel_projectButtons.Controls.Add(button_validate);
            panel_projectButtons.Controls.Add(button_stop);
            panel_projectButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_projectButtons.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            panel_projectButtons.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel_projectButtons.Location = new System.Drawing.Point(0, 226);
            panel_projectButtons.Name = "panel_projectButtons";
            panel_projectButtons.Size = new System.Drawing.Size(1006, 52);
            panel_projectButtons.TabIndex = 12;
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
            // panel_employeeFieldMapping
            // 
            panel_employeeFieldMapping.AutoScroll = true;
            panel_employeeFieldMapping.Controls.Add(flowLayoutPanel_nonMandatoryFields);
            panel_employeeFieldMapping.Controls.Add(label_delimiter);
            panel_employeeFieldMapping.Controls.Add(comboBox_delimiter);
            panel_employeeFieldMapping.Controls.Add(groupBox_employeeMandatoryFields);
            panel_employeeFieldMapping.Controls.Add(label_employeeSetup);
            panel_employeeFieldMapping.Controls.Add(button_employeeSelectFile);
            panel_employeeFieldMapping.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_employeeFieldMapping.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            panel_employeeFieldMapping.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel_employeeFieldMapping.Location = new System.Drawing.Point(0, 0);
            panel_employeeFieldMapping.MinimumSize = new System.Drawing.Size(0, 120);
            panel_employeeFieldMapping.Name = "panel_employeeFieldMapping";
            panel_employeeFieldMapping.Size = new System.Drawing.Size(1006, 226);
            panel_employeeFieldMapping.TabIndex = 13;
            // 
            // flowLayoutPanel_nonMandatoryFields
            // 
            flowLayoutPanel_nonMandatoryFields.Controls.Add(panel_NonMandatoryButton);
            flowLayoutPanel_nonMandatoryFields.Controls.Add(panel_NonMandatoryFields);
            flowLayoutPanel_nonMandatoryFields.Location = new System.Drawing.Point(572, 60);
            flowLayoutPanel_nonMandatoryFields.Name = "flowLayoutPanel_nonMandatoryFields";
            flowLayoutPanel_nonMandatoryFields.Size = new System.Drawing.Size(390, 330);
            flowLayoutPanel_nonMandatoryFields.TabIndex = 7;
            // 
            // panel_NonMandatoryButton
            // 
            panel_NonMandatoryButton.Controls.Add(label_nonMandatoryFields);
            panel_NonMandatoryButton.Controls.Add(button_expandNonMandatory);
            panel_NonMandatoryButton.Location = new System.Drawing.Point(3, 3);
            panel_NonMandatoryButton.Name = "panel_NonMandatoryButton";
            panel_NonMandatoryButton.Size = new System.Drawing.Size(382, 32);
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
            panel_NonMandatoryFields.Controls.Add(comboBox_userRoleDelimiter);
            panel_NonMandatoryFields.Controls.Add(label_userRoleDelimiter);
            panel_NonMandatoryFields.Controls.Add(comboBox_userRoles);
            panel_NonMandatoryFields.Controls.Add(label_userRoleNames);
            panel_NonMandatoryFields.Controls.Add(label_jobTitle);
            panel_NonMandatoryFields.Controls.Add(comboBox_jobTitle);
            panel_NonMandatoryFields.Controls.Add(comboBox_employeeNo);
            panel_NonMandatoryFields.Controls.Add(label_employeeNo);
            panel_NonMandatoryFields.Controls.Add(comboBox_employmentDate);
            panel_NonMandatoryFields.Controls.Add(label_employmentDate);
            panel_NonMandatoryFields.Location = new System.Drawing.Point(3, 41);
            panel_NonMandatoryFields.MaximumSize = new System.Drawing.Size(382, 289);
            panel_NonMandatoryFields.MinimumSize = new System.Drawing.Size(382, 0);
            panel_NonMandatoryFields.Name = "panel_NonMandatoryFields";
            panel_NonMandatoryFields.Size = new System.Drawing.Size(382, 180);
            panel_NonMandatoryFields.TabIndex = 1;
            // 
            // comboBox_userRoleDelimiter
            // 
            comboBox_userRoleDelimiter.FormattingEnabled = true;
            comboBox_userRoleDelimiter.Location = new System.Drawing.Point(153, 101);
            comboBox_userRoleDelimiter.Name = "comboBox_userRoleDelimiter";
            comboBox_userRoleDelimiter.Size = new System.Drawing.Size(150, 25);
            comboBox_userRoleDelimiter.TabIndex = 12;
            // 
            // label_userRoleDelimiter
            // 
            label_userRoleDelimiter.AutoSize = true;
            label_userRoleDelimiter.Location = new System.Drawing.Point(10, 104);
            label_userRoleDelimiter.Name = "label_userRoleDelimiter";
            label_userRoleDelimiter.Size = new System.Drawing.Size(123, 17);
            label_userRoleDelimiter.TabIndex = 1;
            label_userRoleDelimiter.Text = "User Role Delimiter";
            // 
            // comboBox_userRoles
            // 
            comboBox_userRoles.FormattingEnabled = true;
            comboBox_userRoles.Location = new System.Drawing.Point(153, 132);
            comboBox_userRoles.Name = "comboBox_userRoles";
            comboBox_userRoles.Size = new System.Drawing.Size(150, 25);
            comboBox_userRoles.TabIndex = 10;
            // 
            // label_userRoleNames
            // 
            label_userRoleNames.AutoSize = true;
            label_userRoleNames.Location = new System.Drawing.Point(10, 135);
            label_userRoleNames.Name = "label_userRoleNames";
            label_userRoleNames.Size = new System.Drawing.Size(111, 17);
            label_userRoleNames.TabIndex = 1;
            label_userRoleNames.Text = "User Role Names";
            // 
            // label_jobTitle
            // 
            label_jobTitle.AutoSize = true;
            label_jobTitle.Location = new System.Drawing.Point(10, 10);
            label_jobTitle.Name = "label_jobTitle";
            label_jobTitle.Size = new System.Drawing.Size(58, 17);
            label_jobTitle.TabIndex = 1;
            label_jobTitle.Text = "Job Title";
            // 
            // comboBox_jobTitle
            // 
            comboBox_jobTitle.FormattingEnabled = true;
            comboBox_jobTitle.Location = new System.Drawing.Point(153, 7);
            comboBox_jobTitle.Name = "comboBox_jobTitle";
            comboBox_jobTitle.Size = new System.Drawing.Size(150, 25);
            comboBox_jobTitle.TabIndex = 3;
            // 
            // comboBox_employeeNo
            // 
            comboBox_employeeNo.FormattingEnabled = true;
            comboBox_employeeNo.Location = new System.Drawing.Point(153, 38);
            comboBox_employeeNo.Name = "comboBox_employeeNo";
            comboBox_employeeNo.Size = new System.Drawing.Size(150, 25);
            comboBox_employeeNo.TabIndex = 3;
            // 
            // label_employeeNo
            // 
            label_employeeNo.AutoSize = true;
            label_employeeNo.Location = new System.Drawing.Point(10, 41);
            label_employeeNo.Name = "label_employeeNo";
            label_employeeNo.Size = new System.Drawing.Size(89, 17);
            label_employeeNo.TabIndex = 1;
            label_employeeNo.Text = "Employee No";
            // 
            // comboBox_employmentDate
            // 
            comboBox_employmentDate.FormattingEnabled = true;
            comboBox_employmentDate.Location = new System.Drawing.Point(153, 69);
            comboBox_employmentDate.Name = "comboBox_employmentDate";
            comboBox_employmentDate.Size = new System.Drawing.Size(150, 25);
            comboBox_employmentDate.TabIndex = 3;
            // 
            // label_employmentDate
            // 
            label_employmentDate.AutoSize = true;
            label_employmentDate.Location = new System.Drawing.Point(10, 72);
            label_employmentDate.Name = "label_employmentDate";
            label_employmentDate.Size = new System.Drawing.Size(117, 17);
            label_employmentDate.TabIndex = 1;
            label_employmentDate.Text = "Employment Date";
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
            // groupBox_employeeMandatoryFields
            // 
            groupBox_employeeMandatoryFields.Controls.Add(checkBox_defaultSalaryGroup);
            groupBox_employeeMandatoryFields.Controls.Add(checkBox_defaultNormalWorkingTime);
            groupBox_employeeMandatoryFields.Controls.Add(checkBox_defaultAllowanceLegislation);
            groupBox_employeeMandatoryFields.Controls.Add(checkBox_defaultPublicHolidayCalendar);
            groupBox_employeeMandatoryFields.Controls.Add(comboBox_salaryGroup);
            groupBox_employeeMandatoryFields.Controls.Add(comboBox_allowanceLegislation);
            groupBox_employeeMandatoryFields.Controls.Add(comboBox_normalWorkingTime);
            groupBox_employeeMandatoryFields.Controls.Add(comboBox_employeeType);
            groupBox_employeeMandatoryFields.Controls.Add(comboBox_publicHolidayCalendar);
            groupBox_employeeMandatoryFields.Controls.Add(comboBox_costPrice);
            groupBox_employeeMandatoryFields.Controls.Add(label_allowanceLegislation);
            groupBox_employeeMandatoryFields.Controls.Add(label_salaryGroup);
            groupBox_employeeMandatoryFields.Controls.Add(label_employeeType);
            groupBox_employeeMandatoryFields.Controls.Add(label_normalWorkingTime);
            groupBox_employeeMandatoryFields.Controls.Add(label2);
            groupBox_employeeMandatoryFields.Controls.Add(checkBox_defaultEmployeeType);
            groupBox_employeeMandatoryFields.Controls.Add(label_costPrice);
            groupBox_employeeMandatoryFields.Controls.Add(checkBox_defaultCostPrice);
            groupBox_employeeMandatoryFields.Controls.Add(checkBox_defaultHourlyRate);
            groupBox_employeeMandatoryFields.Controls.Add(label_managerInitials);
            groupBox_employeeMandatoryFields.Controls.Add(comboBox_managerInitials);
            groupBox_employeeMandatoryFields.Controls.Add(label_email);
            groupBox_employeeMandatoryFields.Controls.Add(label_defaultHourlyRate);
            groupBox_employeeMandatoryFields.Controls.Add(comboBox_email);
            groupBox_employeeMandatoryFields.Controls.Add(label_initials);
            groupBox_employeeMandatoryFields.Controls.Add(comboBox_initials);
            groupBox_employeeMandatoryFields.Controls.Add(label_lastName);
            groupBox_employeeMandatoryFields.Controls.Add(comboBox_defaultHourlyRate);
            groupBox_employeeMandatoryFields.Controls.Add(comboBox_lastName);
            groupBox_employeeMandatoryFields.Controls.Add(label_firstName);
            groupBox_employeeMandatoryFields.Controls.Add(comboBox_firstName);
            groupBox_employeeMandatoryFields.Controls.Add(label_userName);
            groupBox_employeeMandatoryFields.Controls.Add(comboBox_userName);
            groupBox_employeeMandatoryFields.Controls.Add(checkBox_defaultLegalEntity);
            groupBox_employeeMandatoryFields.Controls.Add(label_legalEntity);
            groupBox_employeeMandatoryFields.Controls.Add(comboBox_legalEntity);
            groupBox_employeeMandatoryFields.Controls.Add(label_department);
            groupBox_employeeMandatoryFields.Controls.Add(checkBox_defaultDepartment);
            groupBox_employeeMandatoryFields.Controls.Add(comboBox_department);
            groupBox_employeeMandatoryFields.Location = new System.Drawing.Point(160, 62);
            groupBox_employeeMandatoryFields.Name = "groupBox_employeeMandatoryFields";
            groupBox_employeeMandatoryFields.Size = new System.Drawing.Size(397, 496);
            groupBox_employeeMandatoryFields.TabIndex = 5;
            groupBox_employeeMandatoryFields.TabStop = false;
            groupBox_employeeMandatoryFields.Text = "Mandatory";
            // 
            // checkBox_defaultSalaryGroup
            // 
            checkBox_defaultSalaryGroup.AutoSize = true;
            checkBox_defaultSalaryGroup.Location = new System.Drawing.Point(323, 400);
            checkBox_defaultSalaryGroup.Name = "checkBox_defaultSalaryGroup";
            checkBox_defaultSalaryGroup.Size = new System.Drawing.Size(70, 21);
            checkBox_defaultSalaryGroup.TabIndex = 13;
            checkBox_defaultSalaryGroup.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultSalaryGroup, "Set default values for all rows of a particular column field");
            checkBox_defaultSalaryGroup.UseVisualStyleBackColor = true;
            checkBox_defaultSalaryGroup.CheckedChanged += checkBox_defaultSalaryGroup_CheckedChanged;
            // 
            // checkBox_defaultNormalWorkingTime
            // 
            checkBox_defaultNormalWorkingTime.AutoSize = true;
            checkBox_defaultNormalWorkingTime.Location = new System.Drawing.Point(323, 369);
            checkBox_defaultNormalWorkingTime.Name = "checkBox_defaultNormalWorkingTime";
            checkBox_defaultNormalWorkingTime.Size = new System.Drawing.Size(70, 21);
            checkBox_defaultNormalWorkingTime.TabIndex = 12;
            checkBox_defaultNormalWorkingTime.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultNormalWorkingTime, "Set default values for all rows of a particular column field");
            checkBox_defaultNormalWorkingTime.UseVisualStyleBackColor = true;
            checkBox_defaultNormalWorkingTime.CheckedChanged += checkBox_defaultNormalWorkingTime_CheckedChanged;
            // 
            // checkBox_defaultAllowanceLegislation
            // 
            checkBox_defaultAllowanceLegislation.AutoSize = true;
            checkBox_defaultAllowanceLegislation.Location = new System.Drawing.Point(323, 463);
            checkBox_defaultAllowanceLegislation.Name = "checkBox_defaultAllowanceLegislation";
            checkBox_defaultAllowanceLegislation.Size = new System.Drawing.Size(70, 21);
            checkBox_defaultAllowanceLegislation.TabIndex = 11;
            checkBox_defaultAllowanceLegislation.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultAllowanceLegislation, "Set default values for all rows of a particular column field");
            checkBox_defaultAllowanceLegislation.UseVisualStyleBackColor = true;
            checkBox_defaultAllowanceLegislation.CheckedChanged += checkBox_defaultAllowanceLegislation_CheckedChanged;
            // 
            // checkBox_defaultPublicHolidayCalendar
            // 
            checkBox_defaultPublicHolidayCalendar.AutoSize = true;
            checkBox_defaultPublicHolidayCalendar.Location = new System.Drawing.Point(323, 338);
            checkBox_defaultPublicHolidayCalendar.Name = "checkBox_defaultPublicHolidayCalendar";
            checkBox_defaultPublicHolidayCalendar.Size = new System.Drawing.Size(70, 21);
            checkBox_defaultPublicHolidayCalendar.TabIndex = 11;
            checkBox_defaultPublicHolidayCalendar.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultPublicHolidayCalendar, "Set default values for all rows of a particular column field");
            checkBox_defaultPublicHolidayCalendar.UseVisualStyleBackColor = true;
            checkBox_defaultPublicHolidayCalendar.CheckedChanged += checkBox_defaultPublicHolidayCalendar_CheckedChanged;
            // 
            // comboBox_salaryGroup
            // 
            comboBox_salaryGroup.FormattingEnabled = true;
            comboBox_salaryGroup.Location = new System.Drawing.Point(163, 398);
            comboBox_salaryGroup.Name = "comboBox_salaryGroup";
            comboBox_salaryGroup.Size = new System.Drawing.Size(154, 25);
            comboBox_salaryGroup.TabIndex = 10;
            // 
            // comboBox_allowanceLegislation
            // 
            comboBox_allowanceLegislation.FormattingEnabled = true;
            comboBox_allowanceLegislation.Location = new System.Drawing.Point(164, 461);
            comboBox_allowanceLegislation.Name = "comboBox_allowanceLegislation";
            comboBox_allowanceLegislation.Size = new System.Drawing.Size(153, 25);
            comboBox_allowanceLegislation.TabIndex = 10;
            // 
            // comboBox_normalWorkingTime
            // 
            comboBox_normalWorkingTime.FormattingEnabled = true;
            comboBox_normalWorkingTime.Location = new System.Drawing.Point(163, 367);
            comboBox_normalWorkingTime.Name = "comboBox_normalWorkingTime";
            comboBox_normalWorkingTime.Size = new System.Drawing.Size(154, 25);
            comboBox_normalWorkingTime.TabIndex = 9;
            // 
            // comboBox_employeeType
            // 
            comboBox_employeeType.FormattingEnabled = true;
            comboBox_employeeType.Location = new System.Drawing.Point(164, 430);
            comboBox_employeeType.Name = "comboBox_employeeType";
            comboBox_employeeType.Size = new System.Drawing.Size(153, 25);
            comboBox_employeeType.TabIndex = 10;
            // 
            // comboBox_publicHolidayCalendar
            // 
            comboBox_publicHolidayCalendar.FormattingEnabled = true;
            comboBox_publicHolidayCalendar.Location = new System.Drawing.Point(163, 336);
            comboBox_publicHolidayCalendar.Name = "comboBox_publicHolidayCalendar";
            comboBox_publicHolidayCalendar.Size = new System.Drawing.Size(154, 25);
            comboBox_publicHolidayCalendar.TabIndex = 8;
            // 
            // comboBox_costPrice
            // 
            comboBox_costPrice.FormattingEnabled = true;
            comboBox_costPrice.Location = new System.Drawing.Point(163, 305);
            comboBox_costPrice.Name = "comboBox_costPrice";
            comboBox_costPrice.Size = new System.Drawing.Size(154, 25);
            comboBox_costPrice.TabIndex = 7;
            // 
            // label_allowanceLegislation
            // 
            label_allowanceLegislation.AutoSize = true;
            label_allowanceLegislation.Location = new System.Drawing.Point(6, 463);
            label_allowanceLegislation.Name = "label_allowanceLegislation";
            label_allowanceLegislation.Size = new System.Drawing.Size(137, 17);
            label_allowanceLegislation.TabIndex = 1;
            label_allowanceLegislation.Text = "Allowance Legislation";
            // 
            // label_salaryGroup
            // 
            label_salaryGroup.AutoSize = true;
            label_salaryGroup.Location = new System.Drawing.Point(6, 401);
            label_salaryGroup.Name = "label_salaryGroup";
            label_salaryGroup.Size = new System.Drawing.Size(87, 17);
            label_salaryGroup.TabIndex = 1;
            label_salaryGroup.Text = "Salary Group";
            // 
            // label_employeeType
            // 
            label_employeeType.AutoSize = true;
            label_employeeType.Location = new System.Drawing.Point(6, 432);
            label_employeeType.Name = "label_employeeType";
            label_employeeType.Size = new System.Drawing.Size(99, 17);
            label_employeeType.TabIndex = 1;
            label_employeeType.Text = "Employee Type";
            // 
            // label_normalWorkingTime
            // 
            label_normalWorkingTime.AutoSize = true;
            label_normalWorkingTime.Location = new System.Drawing.Point(6, 370);
            label_normalWorkingTime.Name = "label_normalWorkingTime";
            label_normalWorkingTime.Size = new System.Drawing.Size(142, 17);
            label_normalWorkingTime.TabIndex = 1;
            label_normalWorkingTime.Text = "Normal Working Time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 339);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(151, 17);
            label2.TabIndex = 1;
            label2.Text = "Public Holiday Calendar";
            // 
            // checkBox_defaultEmployeeType
            // 
            checkBox_defaultEmployeeType.AutoSize = true;
            checkBox_defaultEmployeeType.Location = new System.Drawing.Point(323, 432);
            checkBox_defaultEmployeeType.Name = "checkBox_defaultEmployeeType";
            checkBox_defaultEmployeeType.Size = new System.Drawing.Size(70, 21);
            checkBox_defaultEmployeeType.TabIndex = 4;
            checkBox_defaultEmployeeType.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultEmployeeType, "Set default values for all rows of a particular column field");
            checkBox_defaultEmployeeType.UseVisualStyleBackColor = true;
            checkBox_defaultEmployeeType.CheckedChanged += checkBox_defaultEmployeeType_CheckedChanged;
            // 
            // label_costPrice
            // 
            label_costPrice.AutoSize = true;
            label_costPrice.Location = new System.Drawing.Point(6, 308);
            label_costPrice.Name = "label_costPrice";
            label_costPrice.Size = new System.Drawing.Size(68, 17);
            label_costPrice.TabIndex = 1;
            label_costPrice.Text = "Cost Price";
            // 
            // checkBox_defaultCostPrice
            // 
            checkBox_defaultCostPrice.AutoSize = true;
            checkBox_defaultCostPrice.Location = new System.Drawing.Point(323, 307);
            checkBox_defaultCostPrice.Name = "checkBox_defaultCostPrice";
            checkBox_defaultCostPrice.Size = new System.Drawing.Size(70, 21);
            checkBox_defaultCostPrice.TabIndex = 6;
            checkBox_defaultCostPrice.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultCostPrice, "Set default values for all rows of a particular column field");
            checkBox_defaultCostPrice.UseVisualStyleBackColor = true;
            checkBox_defaultCostPrice.CheckedChanged += checkBox_defaultCostPrice_CheckedChanged;
            // 
            // checkBox_defaultHourlyRate
            // 
            checkBox_defaultHourlyRate.AutoSize = true;
            checkBox_defaultHourlyRate.Location = new System.Drawing.Point(323, 276);
            checkBox_defaultHourlyRate.Name = "checkBox_defaultHourlyRate";
            checkBox_defaultHourlyRate.Size = new System.Drawing.Size(70, 21);
            checkBox_defaultHourlyRate.TabIndex = 4;
            checkBox_defaultHourlyRate.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultHourlyRate, "Set default values for all rows of a particular column field");
            checkBox_defaultHourlyRate.UseVisualStyleBackColor = true;
            checkBox_defaultHourlyRate.CheckedChanged += checkBox_defaultHourlyRate_CheckedChanged;
            // 
            // label_managerInitials
            // 
            label_managerInitials.AutoSize = true;
            label_managerInitials.Location = new System.Drawing.Point(6, 182);
            label_managerInitials.Name = "label_managerInitials";
            label_managerInitials.Size = new System.Drawing.Size(105, 17);
            label_managerInitials.TabIndex = 1;
            label_managerInitials.Text = "Manager Initials";
            // 
            // comboBox_managerInitials
            // 
            comboBox_managerInitials.FormattingEnabled = true;
            comboBox_managerInitials.Location = new System.Drawing.Point(163, 179);
            comboBox_managerInitials.Name = "comboBox_managerInitials";
            comboBox_managerInitials.Size = new System.Drawing.Size(154, 25);
            comboBox_managerInitials.TabIndex = 3;
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.Location = new System.Drawing.Point(6, 151);
            label_email.Name = "label_email";
            label_email.Size = new System.Drawing.Size(40, 17);
            label_email.TabIndex = 1;
            label_email.Text = "Email";
            // 
            // label_defaultHourlyRate
            // 
            label_defaultHourlyRate.AutoSize = true;
            label_defaultHourlyRate.Location = new System.Drawing.Point(6, 277);
            label_defaultHourlyRate.Name = "label_defaultHourlyRate";
            label_defaultHourlyRate.Size = new System.Drawing.Size(127, 17);
            label_defaultHourlyRate.TabIndex = 1;
            label_defaultHourlyRate.Text = "Default Hourly Rate";
            // 
            // comboBox_email
            // 
            comboBox_email.FormattingEnabled = true;
            comboBox_email.Location = new System.Drawing.Point(163, 148);
            comboBox_email.Name = "comboBox_email";
            comboBox_email.Size = new System.Drawing.Size(154, 25);
            comboBox_email.TabIndex = 3;
            // 
            // label_initials
            // 
            label_initials.AutoSize = true;
            label_initials.Location = new System.Drawing.Point(6, 120);
            label_initials.Name = "label_initials";
            label_initials.Size = new System.Drawing.Size(47, 17);
            label_initials.TabIndex = 1;
            label_initials.Text = "Initials";
            // 
            // comboBox_initials
            // 
            comboBox_initials.FormattingEnabled = true;
            comboBox_initials.Location = new System.Drawing.Point(163, 117);
            comboBox_initials.Name = "comboBox_initials";
            comboBox_initials.Size = new System.Drawing.Size(154, 25);
            comboBox_initials.TabIndex = 3;
            // 
            // label_lastName
            // 
            label_lastName.AutoSize = true;
            label_lastName.Location = new System.Drawing.Point(6, 89);
            label_lastName.Name = "label_lastName";
            label_lastName.Size = new System.Drawing.Size(72, 17);
            label_lastName.TabIndex = 1;
            label_lastName.Text = "Last Name";
            // 
            // comboBox_defaultHourlyRate
            // 
            comboBox_defaultHourlyRate.FormattingEnabled = true;
            comboBox_defaultHourlyRate.Location = new System.Drawing.Point(163, 274);
            comboBox_defaultHourlyRate.Name = "comboBox_defaultHourlyRate";
            comboBox_defaultHourlyRate.Size = new System.Drawing.Size(154, 25);
            comboBox_defaultHourlyRate.TabIndex = 3;
            // 
            // comboBox_lastName
            // 
            comboBox_lastName.FormattingEnabled = true;
            comboBox_lastName.Location = new System.Drawing.Point(163, 86);
            comboBox_lastName.Name = "comboBox_lastName";
            comboBox_lastName.Size = new System.Drawing.Size(154, 25);
            comboBox_lastName.TabIndex = 3;
            // 
            // label_firstName
            // 
            label_firstName.AutoSize = true;
            label_firstName.Location = new System.Drawing.Point(6, 58);
            label_firstName.Name = "label_firstName";
            label_firstName.Size = new System.Drawing.Size(74, 17);
            label_firstName.TabIndex = 1;
            label_firstName.Text = "First Name";
            // 
            // comboBox_firstName
            // 
            comboBox_firstName.FormattingEnabled = true;
            comboBox_firstName.Location = new System.Drawing.Point(163, 55);
            comboBox_firstName.Name = "comboBox_firstName";
            comboBox_firstName.Size = new System.Drawing.Size(154, 25);
            comboBox_firstName.TabIndex = 3;
            // 
            // label_userName
            // 
            label_userName.AutoSize = true;
            label_userName.Location = new System.Drawing.Point(6, 27);
            label_userName.Name = "label_userName";
            label_userName.Size = new System.Drawing.Size(69, 17);
            label_userName.TabIndex = 1;
            label_userName.Text = "Username";
            // 
            // comboBox_userName
            // 
            comboBox_userName.FormattingEnabled = true;
            comboBox_userName.Location = new System.Drawing.Point(163, 24);
            comboBox_userName.Name = "comboBox_userName";
            comboBox_userName.Size = new System.Drawing.Size(154, 25);
            comboBox_userName.TabIndex = 3;
            // 
            // checkBox_defaultLegalEntity
            // 
            checkBox_defaultLegalEntity.AutoSize = true;
            checkBox_defaultLegalEntity.Location = new System.Drawing.Point(323, 213);
            checkBox_defaultLegalEntity.Name = "checkBox_defaultLegalEntity";
            checkBox_defaultLegalEntity.Size = new System.Drawing.Size(70, 21);
            checkBox_defaultLegalEntity.TabIndex = 5;
            checkBox_defaultLegalEntity.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultLegalEntity, "Set default values for all rows of a particular column field");
            checkBox_defaultLegalEntity.UseVisualStyleBackColor = true;
            checkBox_defaultLegalEntity.CheckedChanged += checkBox_defaultLegalEntity_CheckedChanged;
            // 
            // label_legalEntity
            // 
            label_legalEntity.AutoSize = true;
            label_legalEntity.Location = new System.Drawing.Point(6, 214);
            label_legalEntity.Name = "label_legalEntity";
            label_legalEntity.Size = new System.Drawing.Size(78, 17);
            label_legalEntity.TabIndex = 1;
            label_legalEntity.Text = "Legal Entity";
            // 
            // comboBox_legalEntity
            // 
            comboBox_legalEntity.FormattingEnabled = true;
            comboBox_legalEntity.Location = new System.Drawing.Point(163, 211);
            comboBox_legalEntity.Name = "comboBox_legalEntity";
            comboBox_legalEntity.Size = new System.Drawing.Size(154, 25);
            comboBox_legalEntity.TabIndex = 3;
            // 
            // label_department
            // 
            label_department.AutoSize = true;
            label_department.Location = new System.Drawing.Point(6, 243);
            label_department.Name = "label_department";
            label_department.Size = new System.Drawing.Size(81, 17);
            label_department.TabIndex = 1;
            label_department.Text = "Department";
            // 
            // checkBox_defaultDepartment
            // 
            checkBox_defaultDepartment.AutoSize = true;
            checkBox_defaultDepartment.Location = new System.Drawing.Point(323, 244);
            checkBox_defaultDepartment.Name = "checkBox_defaultDepartment";
            checkBox_defaultDepartment.Size = new System.Drawing.Size(70, 21);
            checkBox_defaultDepartment.TabIndex = 5;
            checkBox_defaultDepartment.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultDepartment, "Set default values for all rows of a particular column field");
            checkBox_defaultDepartment.UseVisualStyleBackColor = true;
            checkBox_defaultDepartment.CheckedChanged += checkBox_defaultDepartment_CheckedChanged;
            // 
            // comboBox_department
            // 
            comboBox_department.FormattingEnabled = true;
            comboBox_department.Location = new System.Drawing.Point(163, 242);
            comboBox_department.Name = "comboBox_department";
            comboBox_department.Size = new System.Drawing.Size(153, 25);
            comboBox_department.TabIndex = 3;
            // 
            // label_employeeSetup
            // 
            label_employeeSetup.AutoSize = true;
            label_employeeSetup.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            label_employeeSetup.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            label_employeeSetup.Location = new System.Drawing.Point(7, 16);
            label_employeeSetup.Name = "label_employeeSetup";
            label_employeeSetup.Size = new System.Drawing.Size(260, 32);
            label_employeeSetup.TabIndex = 0;
            label_employeeSetup.Text = "Employee Data Import";
            // 
            // button_employeeSelectFile
            // 
            button_employeeSelectFile.BackColor = System.Drawing.Color.FromArgb(226, 43, 141);
            button_employeeSelectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            button_employeeSelectFile.FlatAppearance.BorderSize = 0;
            button_employeeSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_employeeSelectFile.ForeColor = System.Drawing.Color.White;
            button_employeeSelectFile.Location = new System.Drawing.Point(13, 111);
            button_employeeSelectFile.Name = "button_employeeSelectFile";
            button_employeeSelectFile.Size = new System.Drawing.Size(80, 29);
            button_employeeSelectFile.TabIndex = 4;
            button_employeeSelectFile.Text = "Select File";
            defaultToolTip.SetToolTip(button_employeeSelectFile, "Select input CSV file");
            button_employeeSelectFile.UseVisualStyleBackColor = false;
            button_employeeSelectFile.Click += button_select_employee_file_Click;
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
            // UserControl_EmployeeImport
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel_employeeFieldMapping);
            Controls.Add(panel_projectButtons);
            Controls.Add(panel_projectMessage);
            Controls.Add(panel_employeeDataTable);
            Name = "UserControl_EmployeeImport";
            Size = new System.Drawing.Size(1006, 642);
            Load += UserControl1_Load;
            panel_employeeDataTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_employee).EndInit();
            panel_projectMessage.ResumeLayout(false);
            panel_projectMessage.PerformLayout();
            panel_projectButtons.ResumeLayout(false);
            panel_employeeFieldMapping.ResumeLayout(false);
            panel_employeeFieldMapping.PerformLayout();
            flowLayoutPanel_nonMandatoryFields.ResumeLayout(false);
            panel_NonMandatoryButton.ResumeLayout(false);
            panel_NonMandatoryButton.PerformLayout();
            panel_NonMandatoryFields.ResumeLayout(false);
            panel_NonMandatoryFields.PerformLayout();
            groupBox_employeeMandatoryFields.ResumeLayout(false);
            groupBox_employeeMandatoryFields.PerformLayout();
            ResumeLayout(false);

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
