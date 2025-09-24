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
            components = new System.ComponentModel.Container();
            WorkerFetcher = new System.ComponentModel.BackgroundWorker();
            panel_projectDataTable = new System.Windows.Forms.Panel();
            dataGridView_project = new System.Windows.Forms.DataGridView();
            panel_projectMessage = new System.Windows.Forms.Panel();
            textBox_projectImportMessages = new System.Windows.Forms.TextBox();
            panel_projectButtons = new System.Windows.Forms.Panel();
            button_clear = new System.Windows.Forms.Button();
            button_import = new System.Windows.Forms.Button();
            button_validate = new System.Windows.Forms.Button();
            button_stop = new System.Windows.Forms.Button();
            panel_projectFieldMapping = new System.Windows.Forms.Panel();
            flowLayoutPanel_nonMandatoryFields = new System.Windows.Forms.FlowLayoutPanel();
            panel_NonMandatoryButton = new System.Windows.Forms.Panel();
            label_nonMandatoryFields = new System.Windows.Forms.Label();
            button_expandNonMandatory = new System.Windows.Forms.Button();
            panel_NonMandatoryFields = new System.Windows.Forms.Panel();
            comboBox_customerInvRef = new System.Windows.Forms.ComboBox();
            label_customerInvRef = new System.Windows.Forms.Label();
            comboBox_contactPerson = new System.Windows.Forms.ComboBox();
            label_contactPerson = new System.Windows.Forms.Label();
            checkBox_defaultProjectCategory = new System.Windows.Forms.CheckBox();
            label_projectNo = new System.Windows.Forms.Label();
            comboBox_projectNo = new System.Windows.Forms.ComboBox();
            label_projectCategory = new System.Windows.Forms.Label();
            comboBox_description = new System.Windows.Forms.ComboBox();
            comboBox_projectCategory = new System.Windows.Forms.ComboBox();
            label_description = new System.Windows.Forms.Label();
            comboBox_projectStartDate = new System.Windows.Forms.ComboBox();
            label_projectStartDate = new System.Windows.Forms.Label();
            label_projectEndDate = new System.Windows.Forms.Label();
            comboBox_projectEndDate = new System.Windows.Forms.ComboBox();
            label_delimiter = new System.Windows.Forms.Label();
            comboBox_delimiter = new System.Windows.Forms.ComboBox();
            groupBox_projectMandatoryFields = new System.Windows.Forms.GroupBox();
            checkBox_defaultProjectDepartment = new System.Windows.Forms.CheckBox();
            label_projectDepartment = new System.Windows.Forms.Label();
            comboBox_projectDepartment = new System.Windows.Forms.ComboBox();
            checkBox_defaultLegalEntity = new System.Windows.Forms.CheckBox();
            checkBox_defaultProjectTemplate = new System.Windows.Forms.CheckBox();
            checkBox_defaultProjectType = new System.Windows.Forms.CheckBox();
            checkBox_defaultCurrencyISO = new System.Windows.Forms.CheckBox();
            label_projectLegalEntity = new System.Windows.Forms.Label();
            comboBox_projectLegalEntity = new System.Windows.Forms.ComboBox();
            label_projectCurrencyISO = new System.Windows.Forms.Label();
            label_projectType = new System.Windows.Forms.Label();
            comboBox_projectCurrencyISO = new System.Windows.Forms.ComboBox();
            label_projectManager = new System.Windows.Forms.Label();
            comboBox_projectManager = new System.Windows.Forms.ComboBox();
            label_projectTemplate = new System.Windows.Forms.Label();
            comboBox_projectType = new System.Windows.Forms.ComboBox();
            comboBox_projectTemplate = new System.Windows.Forms.ComboBox();
            label_projectCustomerNo = new System.Windows.Forms.Label();
            comboBox_projectCustomerNo = new System.Windows.Forms.ComboBox();
            label_projectName = new System.Windows.Forms.Label();
            comboBox_projectName = new System.Windows.Forms.ComboBox();
            label_projectSetup = new System.Windows.Forms.Label();
            button_projectSelectFile = new System.Windows.Forms.Button();
            tmrExpand = new System.Windows.Forms.Timer(components);
            defaultToolTip = new System.Windows.Forms.ToolTip(components);
            panel_projectDataTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_project).BeginInit();
            panel_projectMessage.SuspendLayout();
            panel_projectButtons.SuspendLayout();
            panel_projectFieldMapping.SuspendLayout();
            flowLayoutPanel_nonMandatoryFields.SuspendLayout();
            panel_NonMandatoryButton.SuspendLayout();
            panel_NonMandatoryFields.SuspendLayout();
            groupBox_projectMandatoryFields.SuspendLayout();
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
            panel_projectDataTable.Controls.Add(dataGridView_project);
            panel_projectDataTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_projectDataTable.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel_projectDataTable.Location = new System.Drawing.Point(0, 462);
            panel_projectDataTable.Name = "panel_projectDataTable";
            panel_projectDataTable.Size = new System.Drawing.Size(1006, 180);
            panel_projectDataTable.TabIndex = 6;
            // 
            // dataGridView_project
            // 
            dataGridView_project.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridView_project.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridView_project.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_project.Dock = System.Windows.Forms.DockStyle.Bottom;
            dataGridView_project.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridView_project.Location = new System.Drawing.Point(0, 0);
            dataGridView_project.Name = "dataGridView_project";
            dataGridView_project.RowHeadersWidth = 62;
            dataGridView_project.Size = new System.Drawing.Size(1006, 180);
            dataGridView_project.TabIndex = 0;
            // 
            // panel_projectMessage
            // 
            panel_projectMessage.Controls.Add(textBox_projectImportMessages);
            panel_projectMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_projectMessage.Location = new System.Drawing.Point(0, 278);
            panel_projectMessage.Name = "panel_projectMessage";
            panel_projectMessage.Size = new System.Drawing.Size(1006, 184);
            panel_projectMessage.TabIndex = 10;
            // 
            // textBox_projectImportMessages
            // 
            textBox_projectImportMessages.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            textBox_projectImportMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox_projectImportMessages.Dock = System.Windows.Forms.DockStyle.Bottom;
            textBox_projectImportMessages.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            textBox_projectImportMessages.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            textBox_projectImportMessages.Location = new System.Drawing.Point(0, 0);
            textBox_projectImportMessages.Multiline = true;
            textBox_projectImportMessages.Name = "textBox_projectImportMessages";
            textBox_projectImportMessages.ReadOnly = true;
            textBox_projectImportMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBox_projectImportMessages.Size = new System.Drawing.Size(1006, 184);
            textBox_projectImportMessages.TabIndex = 0;
            defaultToolTip.SetToolTip(textBox_projectImportMessages, "Validation or import status");
            textBox_projectImportMessages.WordWrap = false;
            textBox_projectImportMessages.MouseClick += textBox_projectImportMessages_MouseClick;
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
            // panel_projectFieldMapping
            // 
            panel_projectFieldMapping.AutoScroll = true;
            panel_projectFieldMapping.Controls.Add(flowLayoutPanel_nonMandatoryFields);
            panel_projectFieldMapping.Controls.Add(label_delimiter);
            panel_projectFieldMapping.Controls.Add(comboBox_delimiter);
            panel_projectFieldMapping.Controls.Add(groupBox_projectMandatoryFields);
            panel_projectFieldMapping.Controls.Add(label_projectSetup);
            panel_projectFieldMapping.Controls.Add(button_projectSelectFile);
            panel_projectFieldMapping.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_projectFieldMapping.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            panel_projectFieldMapping.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel_projectFieldMapping.Location = new System.Drawing.Point(0, 0);
            panel_projectFieldMapping.Name = "panel_projectFieldMapping";
            panel_projectFieldMapping.Size = new System.Drawing.Size(1006, 226);
            panel_projectFieldMapping.TabIndex = 13;
            // 
            // flowLayoutPanel_nonMandatoryFields
            // 
            flowLayoutPanel_nonMandatoryFields.Controls.Add(panel_NonMandatoryButton);
            flowLayoutPanel_nonMandatoryFields.Controls.Add(panel_NonMandatoryFields);
            flowLayoutPanel_nonMandatoryFields.Location = new System.Drawing.Point(589, 60);
            flowLayoutPanel_nonMandatoryFields.Name = "flowLayoutPanel_nonMandatoryFields";
            flowLayoutPanel_nonMandatoryFields.Size = new System.Drawing.Size(372, 279);
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
            panel_NonMandatoryFields.Controls.Add(comboBox_customerInvRef);
            panel_NonMandatoryFields.Controls.Add(label_customerInvRef);
            panel_NonMandatoryFields.Controls.Add(comboBox_contactPerson);
            panel_NonMandatoryFields.Controls.Add(label_contactPerson);
            panel_NonMandatoryFields.Controls.Add(checkBox_defaultProjectCategory);
            panel_NonMandatoryFields.Controls.Add(label_projectNo);
            panel_NonMandatoryFields.Controls.Add(comboBox_projectNo);
            panel_NonMandatoryFields.Controls.Add(label_projectCategory);
            panel_NonMandatoryFields.Controls.Add(comboBox_description);
            panel_NonMandatoryFields.Controls.Add(comboBox_projectCategory);
            panel_NonMandatoryFields.Controls.Add(label_description);
            panel_NonMandatoryFields.Controls.Add(comboBox_projectStartDate);
            panel_NonMandatoryFields.Controls.Add(label_projectStartDate);
            panel_NonMandatoryFields.Controls.Add(label_projectEndDate);
            panel_NonMandatoryFields.Controls.Add(comboBox_projectEndDate);
            panel_NonMandatoryFields.Location = new System.Drawing.Point(3, 41);
            panel_NonMandatoryFields.MaximumSize = new System.Drawing.Size(363, 225);
            panel_NonMandatoryFields.MinimumSize = new System.Drawing.Size(363, 0);
            panel_NonMandatoryFields.Name = "panel_NonMandatoryFields";
            panel_NonMandatoryFields.Size = new System.Drawing.Size(363, 225);
            panel_NonMandatoryFields.TabIndex = 1;
            // 
            // comboBox_customerInvRef
            // 
            comboBox_customerInvRef.FormattingEnabled = true;
            comboBox_customerInvRef.Location = new System.Drawing.Point(153, 193);
            comboBox_customerInvRef.Name = "comboBox_customerInvRef";
            comboBox_customerInvRef.Size = new System.Drawing.Size(139, 25);
            comboBox_customerInvRef.TabIndex = 9;
            // 
            // label_customerInvRef
            // 
            label_customerInvRef.AutoSize = true;
            label_customerInvRef.Location = new System.Drawing.Point(10, 199);
            label_customerInvRef.Name = "label_customerInvRef";
            label_customerInvRef.Size = new System.Drawing.Size(117, 17);
            label_customerInvRef.TabIndex = 8;
            label_customerInvRef.Text = "Customer Inv. Ref.";
            // 
            // comboBox_contactPerson
            // 
            comboBox_contactPerson.FormattingEnabled = true;
            comboBox_contactPerson.Location = new System.Drawing.Point(153, 162);
            comboBox_contactPerson.Name = "comboBox_contactPerson";
            comboBox_contactPerson.Size = new System.Drawing.Size(139, 25);
            comboBox_contactPerson.TabIndex = 7;
            // 
            // label_contactPerson
            // 
            label_contactPerson.AutoSize = true;
            label_contactPerson.Location = new System.Drawing.Point(10, 168);
            label_contactPerson.Name = "label_contactPerson";
            label_contactPerson.Size = new System.Drawing.Size(145, 17);
            label_contactPerson.TabIndex = 6;
            label_contactPerson.Text = "Contact Person (email)";
            // 
            // checkBox_defaultProjectCategory
            // 
            checkBox_defaultProjectCategory.AutoSize = true;
            checkBox_defaultProjectCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            checkBox_defaultProjectCategory.Location = new System.Drawing.Point(293, 133);
            checkBox_defaultProjectCategory.MaximumSize = new System.Drawing.Size(70, 21);
            checkBox_defaultProjectCategory.Name = "checkBox_defaultProjectCategory";
            checkBox_defaultProjectCategory.Size = new System.Drawing.Size(65, 19);
            checkBox_defaultProjectCategory.TabIndex = 5;
            checkBox_defaultProjectCategory.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultProjectCategory, "Set default values for all rows of a particular column field");
            checkBox_defaultProjectCategory.UseVisualStyleBackColor = true;
            checkBox_defaultProjectCategory.CheckedChanged += checkBox_defaultProjectCategory_CheckedChanged;
            // 
            // label_projectNo
            // 
            label_projectNo.AutoSize = true;
            label_projectNo.Location = new System.Drawing.Point(10, 10);
            label_projectNo.Name = "label_projectNo";
            label_projectNo.Size = new System.Drawing.Size(72, 17);
            label_projectNo.TabIndex = 1;
            label_projectNo.Text = "Project No";
            // 
            // comboBox_projectNo
            // 
            comboBox_projectNo.FormattingEnabled = true;
            comboBox_projectNo.Location = new System.Drawing.Point(153, 7);
            comboBox_projectNo.Name = "comboBox_projectNo";
            comboBox_projectNo.Size = new System.Drawing.Size(139, 25);
            comboBox_projectNo.TabIndex = 3;
            // 
            // label_projectCategory
            // 
            label_projectCategory.AutoSize = true;
            label_projectCategory.Location = new System.Drawing.Point(10, 134);
            label_projectCategory.Name = "label_projectCategory";
            label_projectCategory.Size = new System.Drawing.Size(110, 17);
            label_projectCategory.TabIndex = 1;
            label_projectCategory.Text = "Project Category";
            // 
            // comboBox_description
            // 
            comboBox_description.FormattingEnabled = true;
            comboBox_description.Location = new System.Drawing.Point(153, 38);
            comboBox_description.Name = "comboBox_description";
            comboBox_description.Size = new System.Drawing.Size(139, 25);
            comboBox_description.TabIndex = 3;
            // 
            // comboBox_projectCategory
            // 
            comboBox_projectCategory.FormattingEnabled = true;
            comboBox_projectCategory.Location = new System.Drawing.Point(153, 131);
            comboBox_projectCategory.Name = "comboBox_projectCategory";
            comboBox_projectCategory.Size = new System.Drawing.Size(139, 25);
            comboBox_projectCategory.TabIndex = 3;
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
            // comboBox_projectStartDate
            // 
            comboBox_projectStartDate.FormattingEnabled = true;
            comboBox_projectStartDate.Location = new System.Drawing.Point(153, 69);
            comboBox_projectStartDate.Name = "comboBox_projectStartDate";
            comboBox_projectStartDate.Size = new System.Drawing.Size(139, 25);
            comboBox_projectStartDate.TabIndex = 3;
            // 
            // label_projectStartDate
            // 
            label_projectStartDate.AutoSize = true;
            label_projectStartDate.Location = new System.Drawing.Point(10, 72);
            label_projectStartDate.Name = "label_projectStartDate";
            label_projectStartDate.Size = new System.Drawing.Size(115, 17);
            label_projectStartDate.TabIndex = 1;
            label_projectStartDate.Text = "Project Start Date";
            // 
            // label_projectEndDate
            // 
            label_projectEndDate.AutoSize = true;
            label_projectEndDate.Location = new System.Drawing.Point(10, 103);
            label_projectEndDate.Name = "label_projectEndDate";
            label_projectEndDate.Size = new System.Drawing.Size(109, 17);
            label_projectEndDate.TabIndex = 1;
            label_projectEndDate.Text = "Project End Date";
            // 
            // comboBox_projectEndDate
            // 
            comboBox_projectEndDate.FormattingEnabled = true;
            comboBox_projectEndDate.Location = new System.Drawing.Point(153, 100);
            comboBox_projectEndDate.Name = "comboBox_projectEndDate";
            comboBox_projectEndDate.Size = new System.Drawing.Size(139, 25);
            comboBox_projectEndDate.TabIndex = 3;
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
            // groupBox_projectMandatoryFields
            // 
            groupBox_projectMandatoryFields.Controls.Add(checkBox_defaultProjectDepartment);
            groupBox_projectMandatoryFields.Controls.Add(label_projectDepartment);
            groupBox_projectMandatoryFields.Controls.Add(comboBox_projectDepartment);
            groupBox_projectMandatoryFields.Controls.Add(checkBox_defaultLegalEntity);
            groupBox_projectMandatoryFields.Controls.Add(checkBox_defaultProjectTemplate);
            groupBox_projectMandatoryFields.Controls.Add(checkBox_defaultProjectType);
            groupBox_projectMandatoryFields.Controls.Add(checkBox_defaultCurrencyISO);
            groupBox_projectMandatoryFields.Controls.Add(label_projectLegalEntity);
            groupBox_projectMandatoryFields.Controls.Add(comboBox_projectLegalEntity);
            groupBox_projectMandatoryFields.Controls.Add(label_projectCurrencyISO);
            groupBox_projectMandatoryFields.Controls.Add(label_projectType);
            groupBox_projectMandatoryFields.Controls.Add(comboBox_projectCurrencyISO);
            groupBox_projectMandatoryFields.Controls.Add(label_projectManager);
            groupBox_projectMandatoryFields.Controls.Add(comboBox_projectManager);
            groupBox_projectMandatoryFields.Controls.Add(label_projectTemplate);
            groupBox_projectMandatoryFields.Controls.Add(comboBox_projectType);
            groupBox_projectMandatoryFields.Controls.Add(comboBox_projectTemplate);
            groupBox_projectMandatoryFields.Controls.Add(label_projectCustomerNo);
            groupBox_projectMandatoryFields.Controls.Add(comboBox_projectCustomerNo);
            groupBox_projectMandatoryFields.Controls.Add(label_projectName);
            groupBox_projectMandatoryFields.Controls.Add(comboBox_projectName);
            groupBox_projectMandatoryFields.Location = new System.Drawing.Point(184, 62);
            groupBox_projectMandatoryFields.Name = "groupBox_projectMandatoryFields";
            groupBox_projectMandatoryFields.Size = new System.Drawing.Size(358, 277);
            groupBox_projectMandatoryFields.TabIndex = 5;
            groupBox_projectMandatoryFields.TabStop = false;
            groupBox_projectMandatoryFields.Text = "Mandatory";
            // 
            // checkBox_defaultProjectDepartment
            // 
            checkBox_defaultProjectDepartment.AutoSize = true;
            checkBox_defaultProjectDepartment.Location = new System.Drawing.Point(283, 243);
            checkBox_defaultProjectDepartment.Name = "checkBox_defaultProjectDepartment";
            checkBox_defaultProjectDepartment.Size = new System.Drawing.Size(70, 21);
            checkBox_defaultProjectDepartment.TabIndex = 9;
            checkBox_defaultProjectDepartment.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultProjectDepartment, "Set default values for all rows of a particular column field");
            checkBox_defaultProjectDepartment.UseVisualStyleBackColor = true;
            checkBox_defaultProjectDepartment.CheckedChanged += checkBox_defaultProjectDepartment_CheckedChanged;
            // 
            // label_projectDepartment
            // 
            label_projectDepartment.AutoSize = true;
            label_projectDepartment.Location = new System.Drawing.Point(6, 244);
            label_projectDepartment.Name = "label_projectDepartment";
            label_projectDepartment.Size = new System.Drawing.Size(121, 17);
            label_projectDepartment.TabIndex = 7;
            label_projectDepartment.Text = "Department Name";
            // 
            // comboBox_projectDepartment
            // 
            comboBox_projectDepartment.FormattingEnabled = true;
            comboBox_projectDepartment.Location = new System.Drawing.Point(138, 241);
            comboBox_projectDepartment.Name = "comboBox_projectDepartment";
            comboBox_projectDepartment.Size = new System.Drawing.Size(139, 25);
            comboBox_projectDepartment.TabIndex = 8;
            // 
            // checkBox_defaultLegalEntity
            // 
            checkBox_defaultLegalEntity.AutoSize = true;
            checkBox_defaultLegalEntity.Location = new System.Drawing.Point(283, 181);
            checkBox_defaultLegalEntity.Name = "checkBox_defaultLegalEntity";
            checkBox_defaultLegalEntity.Size = new System.Drawing.Size(70, 21);
            checkBox_defaultLegalEntity.TabIndex = 6;
            checkBox_defaultLegalEntity.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultLegalEntity, "Set default values for all rows of a particular column field");
            checkBox_defaultLegalEntity.UseVisualStyleBackColor = true;
            checkBox_defaultLegalEntity.CheckedChanged += checkBox_defaultLegalEntity_CheckedChanged;
            // 
            // checkBox_defaultProjectTemplate
            // 
            checkBox_defaultProjectTemplate.AutoSize = true;
            checkBox_defaultProjectTemplate.Location = new System.Drawing.Point(283, 88);
            checkBox_defaultProjectTemplate.Name = "checkBox_defaultProjectTemplate";
            checkBox_defaultProjectTemplate.Size = new System.Drawing.Size(70, 21);
            checkBox_defaultProjectTemplate.TabIndex = 5;
            checkBox_defaultProjectTemplate.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultProjectTemplate, "Set default values for all rows of a particular column field");
            checkBox_defaultProjectTemplate.UseVisualStyleBackColor = true;
            checkBox_defaultProjectTemplate.CheckedChanged += checkBox_defaultProjectTemplate_CheckedChanged;
            // 
            // checkBox_defaultProjectType
            // 
            checkBox_defaultProjectType.AutoSize = true;
            checkBox_defaultProjectType.Location = new System.Drawing.Point(283, 212);
            checkBox_defaultProjectType.Name = "checkBox_defaultProjectType";
            checkBox_defaultProjectType.Size = new System.Drawing.Size(70, 21);
            checkBox_defaultProjectType.TabIndex = 4;
            checkBox_defaultProjectType.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultProjectType, "Set default values for all rows of a particular column field");
            checkBox_defaultProjectType.UseVisualStyleBackColor = true;
            checkBox_defaultProjectType.CheckedChanged += checkBox_defaultProjectType_CheckedChanged;
            // 
            // checkBox_defaultCurrencyISO
            // 
            checkBox_defaultCurrencyISO.AutoSize = true;
            checkBox_defaultCurrencyISO.Location = new System.Drawing.Point(283, 150);
            checkBox_defaultCurrencyISO.Name = "checkBox_defaultCurrencyISO";
            checkBox_defaultCurrencyISO.Size = new System.Drawing.Size(70, 21);
            checkBox_defaultCurrencyISO.TabIndex = 4;
            checkBox_defaultCurrencyISO.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultCurrencyISO, "Set default values for all rows of a particular column field");
            checkBox_defaultCurrencyISO.UseVisualStyleBackColor = true;
            checkBox_defaultCurrencyISO.CheckedChanged += checkBox_defaultCurrencyISO_CheckedChanged;
            // 
            // label_projectLegalEntity
            // 
            label_projectLegalEntity.AutoSize = true;
            label_projectLegalEntity.Location = new System.Drawing.Point(6, 182);
            label_projectLegalEntity.Name = "label_projectLegalEntity";
            label_projectLegalEntity.Size = new System.Drawing.Size(78, 17);
            label_projectLegalEntity.TabIndex = 1;
            label_projectLegalEntity.Text = "Legal Entity";
            // 
            // comboBox_projectLegalEntity
            // 
            comboBox_projectLegalEntity.FormattingEnabled = true;
            comboBox_projectLegalEntity.Location = new System.Drawing.Point(138, 179);
            comboBox_projectLegalEntity.Name = "comboBox_projectLegalEntity";
            comboBox_projectLegalEntity.Size = new System.Drawing.Size(139, 25);
            comboBox_projectLegalEntity.TabIndex = 3;
            // 
            // label_projectCurrencyISO
            // 
            label_projectCurrencyISO.AutoSize = true;
            label_projectCurrencyISO.Location = new System.Drawing.Point(6, 151);
            label_projectCurrencyISO.Name = "label_projectCurrencyISO";
            label_projectCurrencyISO.Size = new System.Drawing.Size(87, 17);
            label_projectCurrencyISO.TabIndex = 1;
            label_projectCurrencyISO.Text = "Currency ISO";
            // 
            // label_projectType
            // 
            label_projectType.AutoSize = true;
            label_projectType.Location = new System.Drawing.Point(6, 213);
            label_projectType.Name = "label_projectType";
            label_projectType.Size = new System.Drawing.Size(82, 17);
            label_projectType.TabIndex = 1;
            label_projectType.Text = "Project Type";
            // 
            // comboBox_projectCurrencyISO
            // 
            comboBox_projectCurrencyISO.FormattingEnabled = true;
            comboBox_projectCurrencyISO.Location = new System.Drawing.Point(138, 148);
            comboBox_projectCurrencyISO.Name = "comboBox_projectCurrencyISO";
            comboBox_projectCurrencyISO.Size = new System.Drawing.Size(139, 25);
            comboBox_projectCurrencyISO.TabIndex = 3;
            // 
            // label_projectManager
            // 
            label_projectManager.AutoSize = true;
            label_projectManager.Location = new System.Drawing.Point(6, 120);
            label_projectManager.Name = "label_projectManager";
            label_projectManager.Size = new System.Drawing.Size(79, 17);
            label_projectManager.TabIndex = 1;
            label_projectManager.Text = "P. M. Initials";
            // 
            // comboBox_projectManager
            // 
            comboBox_projectManager.FormattingEnabled = true;
            comboBox_projectManager.Location = new System.Drawing.Point(138, 117);
            comboBox_projectManager.Name = "comboBox_projectManager";
            comboBox_projectManager.Size = new System.Drawing.Size(139, 25);
            comboBox_projectManager.TabIndex = 3;
            // 
            // label_projectTemplate
            // 
            label_projectTemplate.AutoSize = true;
            label_projectTemplate.Location = new System.Drawing.Point(6, 89);
            label_projectTemplate.Name = "label_projectTemplate";
            label_projectTemplate.Size = new System.Drawing.Size(109, 17);
            label_projectTemplate.TabIndex = 1;
            label_projectTemplate.Text = "Project Template";
            // 
            // comboBox_projectType
            // 
            comboBox_projectType.FormattingEnabled = true;
            comboBox_projectType.Location = new System.Drawing.Point(138, 210);
            comboBox_projectType.Name = "comboBox_projectType";
            comboBox_projectType.Size = new System.Drawing.Size(139, 25);
            comboBox_projectType.TabIndex = 3;
            // 
            // comboBox_projectTemplate
            // 
            comboBox_projectTemplate.FormattingEnabled = true;
            comboBox_projectTemplate.Location = new System.Drawing.Point(138, 86);
            comboBox_projectTemplate.Name = "comboBox_projectTemplate";
            comboBox_projectTemplate.Size = new System.Drawing.Size(139, 25);
            comboBox_projectTemplate.TabIndex = 3;
            // 
            // label_projectCustomerNo
            // 
            label_projectCustomerNo.AutoSize = true;
            label_projectCustomerNo.Location = new System.Drawing.Point(6, 58);
            label_projectCustomerNo.Name = "label_projectCustomerNo";
            label_projectCustomerNo.Size = new System.Drawing.Size(89, 17);
            label_projectCustomerNo.TabIndex = 1;
            label_projectCustomerNo.Text = "Customer No";
            // 
            // comboBox_projectCustomerNo
            // 
            comboBox_projectCustomerNo.FormattingEnabled = true;
            comboBox_projectCustomerNo.Location = new System.Drawing.Point(138, 55);
            comboBox_projectCustomerNo.Name = "comboBox_projectCustomerNo";
            comboBox_projectCustomerNo.Size = new System.Drawing.Size(139, 25);
            comboBox_projectCustomerNo.TabIndex = 3;
            // 
            // label_projectName
            // 
            label_projectName.AutoSize = true;
            label_projectName.Location = new System.Drawing.Point(6, 27);
            label_projectName.Name = "label_projectName";
            label_projectName.Size = new System.Drawing.Size(90, 17);
            label_projectName.TabIndex = 1;
            label_projectName.Text = "Project Name";
            // 
            // comboBox_projectName
            // 
            comboBox_projectName.FormattingEnabled = true;
            comboBox_projectName.Location = new System.Drawing.Point(138, 24);
            comboBox_projectName.Name = "comboBox_projectName";
            comboBox_projectName.Size = new System.Drawing.Size(139, 25);
            comboBox_projectName.TabIndex = 3;
            // 
            // label_projectSetup
            // 
            label_projectSetup.AutoSize = true;
            label_projectSetup.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            label_projectSetup.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            label_projectSetup.Location = new System.Drawing.Point(7, 16);
            label_projectSetup.Name = "label_projectSetup";
            label_projectSetup.Size = new System.Drawing.Size(231, 32);
            label_projectSetup.TabIndex = 0;
            label_projectSetup.Text = "Project Data Import";
            // 
            // button_projectSelectFile
            // 
            button_projectSelectFile.BackColor = System.Drawing.Color.FromArgb(226, 43, 141);
            button_projectSelectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            button_projectSelectFile.FlatAppearance.BorderSize = 0;
            button_projectSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_projectSelectFile.ForeColor = System.Drawing.Color.White;
            button_projectSelectFile.Location = new System.Drawing.Point(13, 111);
            button_projectSelectFile.Name = "button_projectSelectFile";
            button_projectSelectFile.Size = new System.Drawing.Size(80, 29);
            button_projectSelectFile.TabIndex = 4;
            button_projectSelectFile.Text = "Select File";
            defaultToolTip.SetToolTip(button_projectSelectFile, "Select input CSV file");
            button_projectSelectFile.UseVisualStyleBackColor = false;
            button_projectSelectFile.Click += button_select_project_file_Click;
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
            // UserControl_ProjectImport
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel_projectFieldMapping);
            Controls.Add(panel_projectButtons);
            Controls.Add(panel_projectMessage);
            Controls.Add(panel_projectDataTable);
            Name = "UserControl_ProjectImport";
            Size = new System.Drawing.Size(1006, 642);
            panel_projectDataTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_project).EndInit();
            panel_projectMessage.ResumeLayout(false);
            panel_projectMessage.PerformLayout();
            panel_projectButtons.ResumeLayout(false);
            panel_projectFieldMapping.ResumeLayout(false);
            panel_projectFieldMapping.PerformLayout();
            flowLayoutPanel_nonMandatoryFields.ResumeLayout(false);
            panel_NonMandatoryButton.ResumeLayout(false);
            panel_NonMandatoryButton.PerformLayout();
            panel_NonMandatoryFields.ResumeLayout(false);
            panel_NonMandatoryFields.PerformLayout();
            groupBox_projectMandatoryFields.ResumeLayout(false);
            groupBox_projectMandatoryFields.PerformLayout();
            ResumeLayout(false);

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
        private System.Windows.Forms.ComboBox comboBox_contactPerson;
        private System.Windows.Forms.Label label_contactPerson;
        private System.Windows.Forms.ComboBox comboBox_customerInvRef;
        private System.Windows.Forms.Label label_customerInvRef;
    }
}
