using System.Windows.Forms;

namespace TimeLog.DataImporter.UserControls
{
    partial class UserControl_ContactPersonImport
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
            panel_contactPersonDataTable = new Panel();
            dataGridView_contactPerson = new DataGridView();
            panel_contactPersonMessage = new Panel();
            textBox_contactPersonImportMessages = new TextBox();
            panel_contactPersonButtons = new Panel();
            button_clear = new Button();
            button_import = new Button();
            button_validate = new Button();
            button_stop = new Button();
            panel_contactPersonFieldMapping = new Panel();
            flowLayoutPanel_NonMandatoryFields = new FlowLayoutPanel();
            panel_contactPersonDetailsButton = new Panel();
            button_personDetails = new Button();
            label_personDetails = new Label();
            panel_personDetails = new Panel();
            comboBox_profTitle2 = new ComboBox();
            label_profTitle2 = new Label();
            comboBox_profTitle1 = new ComboBox();
            label_proftitle1 = new Label();
            comboBox_initials = new ComboBox();
            label_initials = new Label();
            label_customerNo = new Label();
            label_jobTitle = new Label();
            label_birthday = new Label();
            label_owner = new Label();
            comboBox_department = new ComboBox();
            label_reportsTo = new Label();
            comboBox_birthday = new ComboBox();
            label_department = new Label();
            comboBox_owner = new ComboBox();
            comboBox_reportsTo = new ComboBox();
            comboBox_jobTitle = new ComboBox();
            comboBox_customerNo = new ComboBox();
            panel_contactDetailsButton = new Panel();
            button_contactDetails = new Button();
            label_ContactDetails = new Label();
            panel_contactDetails = new Panel();
            comboBox_mobilePhone = new ComboBox();
            comboBox_homePhone = new ComboBox();
            label_homePhone = new Label();
            label_mobilePhone = new Label();
            comboBox_country = new ComboBox();
            label_country = new Label();
            label_phone = new Label();
            label_fax = new Label();
            label_address = new Label();
            label_address2 = new Label();
            label_address3 = new Label();
            label_zipCode = new Label();
            label_city = new Label();
            label_state = new Label();
            label_email = new Label();
            comboBox_phoneNo = new ComboBox();
            comboBox_faxNo = new ComboBox();
            comboBox_email = new ComboBox();
            comboBox_address = new ComboBox();
            comboBox_address2 = new ComboBox();
            comboBox_address3 = new ComboBox();
            comboBox_zipCode = new ComboBox();
            comboBox_city = new ComboBox();
            comboBox_state = new ComboBox();
            label_delimiter = new Label();
            comboBox_delimiter = new ComboBox();
            groupBox_contactPersonMandatoryFields = new GroupBox();
            label_contactPersonLastName = new Label();
            comboBox_contactPersonLastName = new ComboBox();
            label_contactPersonFirstName = new Label();
            comboBox_contactPersonFirstName = new ComboBox();
            label_contactPersonSetup = new Label();
            button_contactPersonSelectFile = new Button();
            defaultToolTip = new ToolTip(components);
            tmrExpand = new Timer(components);
            label1 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            panel_contactPersonDataTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_contactPerson).BeginInit();
            panel_contactPersonMessage.SuspendLayout();
            panel_contactPersonButtons.SuspendLayout();
            panel_contactPersonFieldMapping.SuspendLayout();
            flowLayoutPanel_NonMandatoryFields.SuspendLayout();
            panel_contactPersonDetailsButton.SuspendLayout();
            panel_personDetails.SuspendLayout();
            panel_contactDetailsButton.SuspendLayout();
            panel_contactDetails.SuspendLayout();
            groupBox_contactPersonMandatoryFields.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // WorkerFetcher
            // 
            WorkerFetcher.WorkerReportsProgress = true;
            WorkerFetcher.WorkerSupportsCancellation = true;
            WorkerFetcher.DoWork += WorkerFetcherDoWork;
            // 
            // panel_contactPersonDataTable
            // 
            panel_contactPersonDataTable.Controls.Add(dataGridView_contactPerson);
            panel_contactPersonDataTable.Dock = DockStyle.Bottom;
            panel_contactPersonDataTable.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel_contactPersonDataTable.Location = new System.Drawing.Point(0, 462);
            panel_contactPersonDataTable.Name = "panel_contactPersonDataTable";
            panel_contactPersonDataTable.Size = new System.Drawing.Size(1006, 180);
            panel_contactPersonDataTable.TabIndex = 6;
            // 
            // dataGridView_contactPerson
            // 
            dataGridView_contactPerson.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridView_contactPerson.BorderStyle = BorderStyle.None;
            dataGridView_contactPerson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_contactPerson.Dock = DockStyle.Bottom;
            dataGridView_contactPerson.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridView_contactPerson.Location = new System.Drawing.Point(0, 0);
            dataGridView_contactPerson.Name = "dataGridView_contactPerson";
            dataGridView_contactPerson.RowHeadersWidth = 62;
            dataGridView_contactPerson.Size = new System.Drawing.Size(1006, 180);
            dataGridView_contactPerson.TabIndex = 0;
            defaultToolTip.SetToolTip(dataGridView_contactPerson, "Contact Person input data table");
            // 
            // panel_contactPersonMessage
            // 
            panel_contactPersonMessage.Controls.Add(textBox_contactPersonImportMessages);
            panel_contactPersonMessage.Dock = DockStyle.Bottom;
            panel_contactPersonMessage.Location = new System.Drawing.Point(0, 278);
            panel_contactPersonMessage.Name = "panel_contactPersonMessage";
            panel_contactPersonMessage.Size = new System.Drawing.Size(1006, 184);
            panel_contactPersonMessage.TabIndex = 10;
            // 
            // textBox_contactPersonImportMessages
            // 
            textBox_contactPersonImportMessages.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            textBox_contactPersonImportMessages.BorderStyle = BorderStyle.None;
            textBox_contactPersonImportMessages.Dock = DockStyle.Bottom;
            textBox_contactPersonImportMessages.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            textBox_contactPersonImportMessages.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            textBox_contactPersonImportMessages.Location = new System.Drawing.Point(0, 0);
            textBox_contactPersonImportMessages.Multiline = true;
            textBox_contactPersonImportMessages.Name = "textBox_contactPersonImportMessages";
            textBox_contactPersonImportMessages.ReadOnly = true;
            textBox_contactPersonImportMessages.ScrollBars = ScrollBars.Vertical;
            textBox_contactPersonImportMessages.Size = new System.Drawing.Size(1006, 184);
            textBox_contactPersonImportMessages.TabIndex = 0;
            defaultToolTip.SetToolTip(textBox_contactPersonImportMessages, "Validation or import status");
            textBox_contactPersonImportMessages.WordWrap = false;
            textBox_contactPersonImportMessages.MouseClick += textBox_contactPersonImportMessages_MouseClick;
            // 
            // panel_contactPersonButtons
            // 
            panel_contactPersonButtons.Controls.Add(button_clear);
            panel_contactPersonButtons.Controls.Add(button_import);
            panel_contactPersonButtons.Controls.Add(button_validate);
            panel_contactPersonButtons.Controls.Add(button_stop);
            panel_contactPersonButtons.Dock = DockStyle.Bottom;
            panel_contactPersonButtons.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            panel_contactPersonButtons.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel_contactPersonButtons.Location = new System.Drawing.Point(0, 226);
            panel_contactPersonButtons.Name = "panel_contactPersonButtons";
            panel_contactPersonButtons.Size = new System.Drawing.Size(1006, 52);
            panel_contactPersonButtons.TabIndex = 12;
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Left;
            button_clear.BackColor = System.Drawing.Color.DimGray;
            button_clear.Cursor = Cursors.Hand;
            button_clear.FlatAppearance.BorderSize = 0;
            button_clear.FlatStyle = FlatStyle.Flat;
            button_clear.ForeColor = System.Drawing.Color.White;
            button_clear.Location = new System.Drawing.Point(14, 12);
            button_clear.Name = "button_clear";
            button_clear.Size = new System.Drawing.Size(80, 28);
            button_clear.TabIndex = 12;
            button_clear.Text = "Reset All";
            defaultToolTip.SetToolTip(button_clear, "Reset everything and reload data from TLP");
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click;
            // 
            // button_import
            // 
            button_import.Anchor = AnchorStyles.Right;
            button_import.BackColor = System.Drawing.Color.FromArgb(226, 43, 141);
            button_import.Cursor = Cursors.Hand;
            button_import.FlatAppearance.BorderSize = 0;
            button_import.FlatStyle = FlatStyle.Flat;
            button_import.ForeColor = System.Drawing.Color.White;
            button_import.Location = new System.Drawing.Point(917, 12);
            button_import.Name = "button_import";
            button_import.Size = new System.Drawing.Size(80, 28);
            button_import.TabIndex = 7;
            button_import.Text = "Import";
            defaultToolTip.SetToolTip(button_import, "Import all data");
            button_import.UseVisualStyleBackColor = false;
            button_import.Click += button_import_Click;
            // 
            // button_validate
            // 
            button_validate.Anchor = AnchorStyles.Right;
            button_validate.BackColor = System.Drawing.Color.FromArgb(226, 43, 141);
            button_validate.Cursor = Cursors.Hand;
            button_validate.FlatAppearance.BorderSize = 0;
            button_validate.FlatStyle = FlatStyle.Flat;
            button_validate.ForeColor = System.Drawing.Color.White;
            button_validate.Location = new System.Drawing.Point(745, 12);
            button_validate.Name = "button_validate";
            button_validate.Size = new System.Drawing.Size(80, 28);
            button_validate.TabIndex = 8;
            button_validate.Text = "Validate";
            defaultToolTip.SetToolTip(button_validate, "Validate data input before importing data");
            button_validate.UseVisualStyleBackColor = false;
            button_validate.Click += button_validate_Click;
            // 
            // button_stop
            // 
            button_stop.Anchor = AnchorStyles.Right;
            button_stop.BackColor = System.Drawing.Color.DimGray;
            button_stop.Cursor = Cursors.Hand;
            button_stop.FlatAppearance.BorderSize = 0;
            button_stop.FlatStyle = FlatStyle.Flat;
            button_stop.ForeColor = System.Drawing.Color.White;
            button_stop.Location = new System.Drawing.Point(831, 12);
            button_stop.Name = "button_stop";
            button_stop.Size = new System.Drawing.Size(80, 28);
            button_stop.TabIndex = 11;
            button_stop.Text = "Stop";
            defaultToolTip.SetToolTip(button_stop, "Stop validation or import");
            button_stop.UseVisualStyleBackColor = false;
            button_stop.Click += button_stop_Click;
            // 
            // panel_contactPersonFieldMapping
            // 
            panel_contactPersonFieldMapping.AutoScroll = true;
            panel_contactPersonFieldMapping.Controls.Add(flowLayoutPanel_NonMandatoryFields);
            panel_contactPersonFieldMapping.Controls.Add(label_delimiter);
            panel_contactPersonFieldMapping.Controls.Add(comboBox_delimiter);
            panel_contactPersonFieldMapping.Controls.Add(groupBox_contactPersonMandatoryFields);
            panel_contactPersonFieldMapping.Controls.Add(label_contactPersonSetup);
            panel_contactPersonFieldMapping.Controls.Add(button_contactPersonSelectFile);
            panel_contactPersonFieldMapping.Dock = DockStyle.Fill;
            panel_contactPersonFieldMapping.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            panel_contactPersonFieldMapping.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel_contactPersonFieldMapping.Location = new System.Drawing.Point(0, 0);
            panel_contactPersonFieldMapping.Name = "panel_contactPersonFieldMapping";
            panel_contactPersonFieldMapping.Size = new System.Drawing.Size(1006, 226);
            panel_contactPersonFieldMapping.TabIndex = 13;
            // 
            // flowLayoutPanel_NonMandatoryFields
            // 
            flowLayoutPanel_NonMandatoryFields.Controls.Add(panel_contactPersonDetailsButton);
            flowLayoutPanel_NonMandatoryFields.Controls.Add(panel_personDetails);
            flowLayoutPanel_NonMandatoryFields.Controls.Add(panel_contactDetailsButton);
            flowLayoutPanel_NonMandatoryFields.Controls.Add(panel_contactDetails);
            flowLayoutPanel_NonMandatoryFields.Location = new System.Drawing.Point(534, 16);
            flowLayoutPanel_NonMandatoryFields.Name = "flowLayoutPanel_NonMandatoryFields";
            flowLayoutPanel_NonMandatoryFields.Size = new System.Drawing.Size(437, 781);
            flowLayoutPanel_NonMandatoryFields.TabIndex = 8;
            // 
            // panel_contactPersonDetailsButton
            // 
            panel_contactPersonDetailsButton.Controls.Add(button_personDetails);
            panel_contactPersonDetailsButton.Controls.Add(label_personDetails);
            panel_contactPersonDetailsButton.Location = new System.Drawing.Point(3, 3);
            panel_contactPersonDetailsButton.Name = "panel_contactPersonDetailsButton";
            panel_contactPersonDetailsButton.Size = new System.Drawing.Size(426, 32);
            panel_contactPersonDetailsButton.TabIndex = 0;
            // 
            // button_personDetails
            // 
            button_personDetails.BackColor = System.Drawing.Color.White;
            button_personDetails.BackgroundImageLayout = ImageLayout.Stretch;
            button_personDetails.Cursor = Cursors.Hand;
            button_personDetails.FlatAppearance.BorderSize = 0;
            button_personDetails.FlatStyle = FlatStyle.Flat;
            button_personDetails.Location = new System.Drawing.Point(15, 2);
            button_personDetails.Name = "button_personDetails";
            button_personDetails.Size = new System.Drawing.Size(30, 30);
            button_personDetails.TabIndex = 9;
            button_personDetails.UseVisualStyleBackColor = false;
            button_personDetails.Click += button_expand_Click;
            // 
            // label_personDetails
            // 
            label_personDetails.AutoSize = true;
            label_personDetails.ForeColor = System.Drawing.Color.Black;
            label_personDetails.Location = new System.Drawing.Point(59, 9);
            label_personDetails.Name = "label_personDetails";
            label_personDetails.Size = new System.Drawing.Size(94, 17);
            label_personDetails.TabIndex = 1;
            label_personDetails.Text = "Person Details";
            // 
            // panel_personDetails
            // 
            panel_personDetails.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            panel_personDetails.Controls.Add(comboBox_profTitle2);
            panel_personDetails.Controls.Add(label_profTitle2);
            panel_personDetails.Controls.Add(comboBox_profTitle1);
            panel_personDetails.Controls.Add(label_proftitle1);
            panel_personDetails.Controls.Add(comboBox_initials);
            panel_personDetails.Controls.Add(label_initials);
            panel_personDetails.Controls.Add(label_customerNo);
            panel_personDetails.Controls.Add(label_jobTitle);
            panel_personDetails.Controls.Add(label_birthday);
            panel_personDetails.Controls.Add(label_owner);
            panel_personDetails.Controls.Add(comboBox_department);
            panel_personDetails.Controls.Add(label_reportsTo);
            panel_personDetails.Controls.Add(comboBox_birthday);
            panel_personDetails.Controls.Add(label_department);
            panel_personDetails.Controls.Add(comboBox_owner);
            panel_personDetails.Controls.Add(comboBox_reportsTo);
            panel_personDetails.Controls.Add(comboBox_jobTitle);
            panel_personDetails.Controls.Add(comboBox_customerNo);
            panel_personDetails.Location = new System.Drawing.Point(3, 41);
            panel_personDetails.MaximumSize = new System.Drawing.Size(426, 292);
            panel_personDetails.MinimumSize = new System.Drawing.Size(426, 0);
            panel_personDetails.Name = "panel_personDetails";
            panel_personDetails.Size = new System.Drawing.Size(426, 292);
            panel_personDetails.TabIndex = 10;
            // 
            // comboBox_profTitle2
            // 
            comboBox_profTitle2.FormattingEnabled = true;
            comboBox_profTitle2.Location = new System.Drawing.Point(154, 137);
            comboBox_profTitle2.Name = "comboBox_profTitle2";
            comboBox_profTitle2.Size = new System.Drawing.Size(138, 25);
            comboBox_profTitle2.TabIndex = 9;
            // 
            // label_profTitle2
            // 
            label_profTitle2.AutoSize = true;
            label_profTitle2.Location = new System.Drawing.Point(11, 142);
            label_profTitle2.Name = "label_profTitle2";
            label_profTitle2.Size = new System.Drawing.Size(119, 17);
            label_profTitle2.TabIndex = 8;
            label_profTitle2.Text = "Professional title 2";
            // 
            // comboBox_profTitle1
            // 
            comboBox_profTitle1.FormattingEnabled = true;
            comboBox_profTitle1.Location = new System.Drawing.Point(153, 105);
            comboBox_profTitle1.Name = "comboBox_profTitle1";
            comboBox_profTitle1.Size = new System.Drawing.Size(138, 25);
            comboBox_profTitle1.TabIndex = 7;
            // 
            // label_proftitle1
            // 
            label_proftitle1.AutoSize = true;
            label_proftitle1.Location = new System.Drawing.Point(10, 110);
            label_proftitle1.Name = "label_proftitle1";
            label_proftitle1.Size = new System.Drawing.Size(117, 17);
            label_proftitle1.TabIndex = 6;
            label_proftitle1.Text = "Professional title 1";
            // 
            // comboBox_initials
            // 
            comboBox_initials.FormattingEnabled = true;
            comboBox_initials.Location = new System.Drawing.Point(153, 74);
            comboBox_initials.Name = "comboBox_initials";
            comboBox_initials.Size = new System.Drawing.Size(138, 25);
            comboBox_initials.TabIndex = 5;
            // 
            // label_initials
            // 
            label_initials.AutoSize = true;
            label_initials.Location = new System.Drawing.Point(10, 76);
            label_initials.Name = "label_initials";
            label_initials.Size = new System.Drawing.Size(47, 17);
            label_initials.TabIndex = 4;
            label_initials.Text = "Initials";
            label_initials.Click += label2_Click_1;
            // 
            // label_customerNo
            // 
            label_customerNo.AutoSize = true;
            label_customerNo.Location = new System.Drawing.Point(10, 15);
            label_customerNo.Name = "label_customerNo";
            label_customerNo.Size = new System.Drawing.Size(89, 17);
            label_customerNo.TabIndex = 1;
            label_customerNo.Text = "Customer No";
            // 
            // label_jobTitle
            // 
            label_jobTitle.AutoSize = true;
            label_jobTitle.Location = new System.Drawing.Point(10, 46);
            label_jobTitle.Name = "label_jobTitle";
            label_jobTitle.Size = new System.Drawing.Size(58, 17);
            label_jobTitle.TabIndex = 1;
            label_jobTitle.Text = "Job Title";
            // 
            // label_birthday
            // 
            label_birthday.AutoSize = true;
            label_birthday.Location = new System.Drawing.Point(14, 234);
            label_birthday.Name = "label_birthday";
            label_birthday.Size = new System.Drawing.Size(59, 17);
            label_birthday.TabIndex = 1;
            label_birthday.Text = "Birthday";
            // 
            // label_owner
            // 
            label_owner.AutoSize = true;
            label_owner.Location = new System.Drawing.Point(12, 173);
            label_owner.Name = "label_owner";
            label_owner.Size = new System.Drawing.Size(48, 17);
            label_owner.TabIndex = 1;
            label_owner.Text = "Owner";
            // 
            // comboBox_department
            // 
            comboBox_department.FormattingEnabled = true;
            comboBox_department.Location = new System.Drawing.Point(150, 260);
            comboBox_department.Name = "comboBox_department";
            comboBox_department.Size = new System.Drawing.Size(138, 25);
            comboBox_department.TabIndex = 3;
            // 
            // label_reportsTo
            // 
            label_reportsTo.AutoSize = true;
            label_reportsTo.Location = new System.Drawing.Point(15, 205);
            label_reportsTo.Name = "label_reportsTo";
            label_reportsTo.Size = new System.Drawing.Size(73, 17);
            label_reportsTo.TabIndex = 1;
            label_reportsTo.Text = "Reports To";
            // 
            // comboBox_birthday
            // 
            comboBox_birthday.FormattingEnabled = true;
            comboBox_birthday.Location = new System.Drawing.Point(151, 231);
            comboBox_birthday.Name = "comboBox_birthday";
            comboBox_birthday.Size = new System.Drawing.Size(138, 25);
            comboBox_birthday.TabIndex = 3;
            // 
            // label_department
            // 
            label_department.AutoSize = true;
            label_department.Location = new System.Drawing.Point(13, 263);
            label_department.Name = "label_department";
            label_department.Size = new System.Drawing.Size(81, 17);
            label_department.TabIndex = 1;
            label_department.Text = "Department";
            // 
            // comboBox_owner
            // 
            comboBox_owner.FormattingEnabled = true;
            comboBox_owner.Location = new System.Drawing.Point(153, 171);
            comboBox_owner.Name = "comboBox_owner";
            comboBox_owner.Size = new System.Drawing.Size(138, 25);
            comboBox_owner.TabIndex = 3;
            // 
            // comboBox_reportsTo
            // 
            comboBox_reportsTo.FormattingEnabled = true;
            comboBox_reportsTo.Location = new System.Drawing.Point(152, 202);
            comboBox_reportsTo.Name = "comboBox_reportsTo";
            comboBox_reportsTo.Size = new System.Drawing.Size(138, 25);
            comboBox_reportsTo.TabIndex = 3;
            // 
            // comboBox_jobTitle
            // 
            comboBox_jobTitle.FormattingEnabled = true;
            comboBox_jobTitle.Location = new System.Drawing.Point(153, 44);
            comboBox_jobTitle.Name = "comboBox_jobTitle";
            comboBox_jobTitle.Size = new System.Drawing.Size(138, 25);
            comboBox_jobTitle.TabIndex = 3;
            // 
            // comboBox_customerNo
            // 
            comboBox_customerNo.FormattingEnabled = true;
            comboBox_customerNo.Location = new System.Drawing.Point(153, 12);
            comboBox_customerNo.Name = "comboBox_customerNo";
            comboBox_customerNo.Size = new System.Drawing.Size(138, 25);
            comboBox_customerNo.TabIndex = 3;
            // 
            // panel_contactDetailsButton
            // 
            panel_contactDetailsButton.Controls.Add(button_contactDetails);
            panel_contactDetailsButton.Controls.Add(label_ContactDetails);
            panel_contactDetailsButton.Location = new System.Drawing.Point(3, 339);
            panel_contactDetailsButton.Name = "panel_contactDetailsButton";
            panel_contactDetailsButton.Size = new System.Drawing.Size(426, 32);
            panel_contactDetailsButton.TabIndex = 11;
            // 
            // button_contactDetails
            // 
            button_contactDetails.BackColor = System.Drawing.Color.White;
            button_contactDetails.BackgroundImageLayout = ImageLayout.Stretch;
            button_contactDetails.Cursor = Cursors.Hand;
            button_contactDetails.FlatAppearance.BorderSize = 0;
            button_contactDetails.FlatStyle = FlatStyle.Flat;
            button_contactDetails.Location = new System.Drawing.Point(15, 1);
            button_contactDetails.Name = "button_contactDetails";
            button_contactDetails.Size = new System.Drawing.Size(30, 30);
            button_contactDetails.TabIndex = 2;
            button_contactDetails.UseVisualStyleBackColor = false;
            button_contactDetails.Click += button_expand_Click;
            // 
            // label_ContactDetails
            // 
            label_ContactDetails.AutoSize = true;
            label_ContactDetails.ForeColor = System.Drawing.Color.Black;
            label_ContactDetails.Location = new System.Drawing.Point(51, 8);
            label_ContactDetails.Name = "label_ContactDetails";
            label_ContactDetails.Size = new System.Drawing.Size(99, 17);
            label_ContactDetails.TabIndex = 1;
            label_ContactDetails.Text = "Contact Details";
            // 
            // panel_contactDetails
            // 
            panel_contactDetails.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            panel_contactDetails.Controls.Add(comboBox_mobilePhone);
            panel_contactDetails.Controls.Add(comboBox_homePhone);
            panel_contactDetails.Controls.Add(label_homePhone);
            panel_contactDetails.Controls.Add(label_mobilePhone);
            panel_contactDetails.Controls.Add(comboBox_country);
            panel_contactDetails.Controls.Add(label_country);
            panel_contactDetails.Controls.Add(label_phone);
            panel_contactDetails.Controls.Add(label_fax);
            panel_contactDetails.Controls.Add(label_address);
            panel_contactDetails.Controls.Add(label_address2);
            panel_contactDetails.Controls.Add(label_address3);
            panel_contactDetails.Controls.Add(label_zipCode);
            panel_contactDetails.Controls.Add(label_city);
            panel_contactDetails.Controls.Add(label_state);
            panel_contactDetails.Controls.Add(label_email);
            panel_contactDetails.Controls.Add(comboBox_phoneNo);
            panel_contactDetails.Controls.Add(comboBox_faxNo);
            panel_contactDetails.Controls.Add(comboBox_email);
            panel_contactDetails.Controls.Add(comboBox_address);
            panel_contactDetails.Controls.Add(comboBox_address2);
            panel_contactDetails.Controls.Add(comboBox_address3);
            panel_contactDetails.Controls.Add(comboBox_zipCode);
            panel_contactDetails.Controls.Add(comboBox_city);
            panel_contactDetails.Controls.Add(comboBox_state);
            panel_contactDetails.Location = new System.Drawing.Point(3, 377);
            panel_contactDetails.MaximumSize = new System.Drawing.Size(426, 390);
            panel_contactDetails.MinimumSize = new System.Drawing.Size(426, 0);
            panel_contactDetails.Name = "panel_contactDetails";
            panel_contactDetails.Size = new System.Drawing.Size(426, 390);
            panel_contactDetails.TabIndex = 1;
            panel_contactDetails.Paint += panel_contactDetails_Paint;
            // 
            // comboBox_mobilePhone
            // 
            comboBox_mobilePhone.FormattingEnabled = true;
            comboBox_mobilePhone.Location = new System.Drawing.Point(120, 42);
            comboBox_mobilePhone.Name = "comboBox_mobilePhone";
            comboBox_mobilePhone.Size = new System.Drawing.Size(133, 25);
            comboBox_mobilePhone.TabIndex = 9;
            // 
            // comboBox_homePhone
            // 
            comboBox_homePhone.FormattingEnabled = true;
            comboBox_homePhone.Location = new System.Drawing.Point(120, 73);
            comboBox_homePhone.Name = "comboBox_homePhone";
            comboBox_homePhone.Size = new System.Drawing.Size(133, 25);
            comboBox_homePhone.TabIndex = 8;
            // 
            // label_homePhone
            // 
            label_homePhone.AutoSize = true;
            label_homePhone.Location = new System.Drawing.Point(11, 74);
            label_homePhone.Name = "label_homePhone";
            label_homePhone.Size = new System.Drawing.Size(88, 17);
            label_homePhone.TabIndex = 7;
            label_homePhone.Text = "Home Phone";
            // 
            // label_mobilePhone
            // 
            label_mobilePhone.AutoSize = true;
            label_mobilePhone.Location = new System.Drawing.Point(10, 44);
            label_mobilePhone.Name = "label_mobilePhone";
            label_mobilePhone.Size = new System.Drawing.Size(92, 17);
            label_mobilePhone.TabIndex = 6;
            label_mobilePhone.Text = "Mobile Phone";
            // 
            // comboBox_country
            // 
            comboBox_country.FormattingEnabled = true;
            comboBox_country.Location = new System.Drawing.Point(119, 358);
            comboBox_country.Name = "comboBox_country";
            comboBox_country.Size = new System.Drawing.Size(133, 25);
            comboBox_country.TabIndex = 5;
            // 
            // label_country
            // 
            label_country.AutoSize = true;
            label_country.Location = new System.Drawing.Point(13, 362);
            label_country.Name = "label_country";
            label_country.Size = new System.Drawing.Size(83, 17);
            label_country.TabIndex = 4;
            label_country.Text = "Country ISO";
            label_country.Click += label2_Click;
            // 
            // label_phone
            // 
            label_phone.AutoSize = true;
            label_phone.Location = new System.Drawing.Point(10, 15);
            label_phone.Name = "label_phone";
            label_phone.Size = new System.Drawing.Size(69, 17);
            label_phone.TabIndex = 1;
            label_phone.Text = "Phone No";
            // 
            // label_fax
            // 
            label_fax.AutoSize = true;
            label_fax.Location = new System.Drawing.Point(12, 104);
            label_fax.Name = "label_fax";
            label_fax.Size = new System.Drawing.Size(51, 17);
            label_fax.TabIndex = 1;
            label_fax.Text = "Fax No";
            // 
            // label_address
            // 
            label_address.AutoSize = true;
            label_address.Location = new System.Drawing.Point(13, 175);
            label_address.Name = "label_address";
            label_address.Size = new System.Drawing.Size(57, 17);
            label_address.TabIndex = 1;
            label_address.Text = "Address";
            label_address.Click += label_address_Click;
            // 
            // label_address2
            // 
            label_address2.AutoSize = true;
            label_address2.Location = new System.Drawing.Point(14, 205);
            label_address2.Name = "label_address2";
            label_address2.Size = new System.Drawing.Size(68, 17);
            label_address2.TabIndex = 1;
            label_address2.Text = "Address 2";
            // 
            // label_address3
            // 
            label_address3.AutoSize = true;
            label_address3.Location = new System.Drawing.Point(13, 237);
            label_address3.Name = "label_address3";
            label_address3.Size = new System.Drawing.Size(68, 17);
            label_address3.TabIndex = 1;
            label_address3.Text = "Address 3";
            // 
            // label_zipCode
            // 
            label_zipCode.AutoSize = true;
            label_zipCode.Location = new System.Drawing.Point(14, 269);
            label_zipCode.Name = "label_zipCode";
            label_zipCode.Size = new System.Drawing.Size(62, 17);
            label_zipCode.TabIndex = 1;
            label_zipCode.Text = "Zip Code";
            // 
            // label_city
            // 
            label_city.AutoSize = true;
            label_city.Location = new System.Drawing.Point(14, 301);
            label_city.Name = "label_city";
            label_city.Size = new System.Drawing.Size(31, 17);
            label_city.TabIndex = 1;
            label_city.Text = "City";
            // 
            // label_state
            // 
            label_state.AutoSize = true;
            label_state.Location = new System.Drawing.Point(14, 331);
            label_state.Name = "label_state";
            label_state.Size = new System.Drawing.Size(39, 17);
            label_state.TabIndex = 1;
            label_state.Text = "State";
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.Location = new System.Drawing.Point(13, 135);
            label_email.Name = "label_email";
            label_email.Size = new System.Drawing.Size(40, 17);
            label_email.TabIndex = 1;
            label_email.Text = "Email";
            // 
            // comboBox_phoneNo
            // 
            comboBox_phoneNo.FormattingEnabled = true;
            comboBox_phoneNo.Location = new System.Drawing.Point(120, 12);
            comboBox_phoneNo.Name = "comboBox_phoneNo";
            comboBox_phoneNo.Size = new System.Drawing.Size(133, 25);
            comboBox_phoneNo.TabIndex = 3;
            // 
            // comboBox_faxNo
            // 
            comboBox_faxNo.FormattingEnabled = true;
            comboBox_faxNo.Location = new System.Drawing.Point(120, 104);
            comboBox_faxNo.Name = "comboBox_faxNo";
            comboBox_faxNo.Size = new System.Drawing.Size(133, 25);
            comboBox_faxNo.TabIndex = 3;
            // 
            // comboBox_email
            // 
            comboBox_email.FormattingEnabled = true;
            comboBox_email.Location = new System.Drawing.Point(120, 135);
            comboBox_email.Name = "comboBox_email";
            comboBox_email.Size = new System.Drawing.Size(133, 25);
            comboBox_email.TabIndex = 3;
            // 
            // comboBox_address
            // 
            comboBox_address.FormattingEnabled = true;
            comboBox_address.Location = new System.Drawing.Point(119, 169);
            comboBox_address.Name = "comboBox_address";
            comboBox_address.Size = new System.Drawing.Size(133, 25);
            comboBox_address.TabIndex = 3;
            // 
            // comboBox_address2
            // 
            comboBox_address2.FormattingEnabled = true;
            comboBox_address2.Location = new System.Drawing.Point(119, 200);
            comboBox_address2.Name = "comboBox_address2";
            comboBox_address2.Size = new System.Drawing.Size(133, 25);
            comboBox_address2.TabIndex = 3;
            // 
            // comboBox_address3
            // 
            comboBox_address3.FormattingEnabled = true;
            comboBox_address3.Location = new System.Drawing.Point(119, 232);
            comboBox_address3.Name = "comboBox_address3";
            comboBox_address3.Size = new System.Drawing.Size(133, 25);
            comboBox_address3.TabIndex = 3;
            // 
            // comboBox_zipCode
            // 
            comboBox_zipCode.FormattingEnabled = true;
            comboBox_zipCode.Location = new System.Drawing.Point(119, 265);
            comboBox_zipCode.Name = "comboBox_zipCode";
            comboBox_zipCode.Size = new System.Drawing.Size(133, 25);
            comboBox_zipCode.TabIndex = 3;
            // 
            // comboBox_city
            // 
            comboBox_city.FormattingEnabled = true;
            comboBox_city.Location = new System.Drawing.Point(119, 296);
            comboBox_city.Name = "comboBox_city";
            comboBox_city.Size = new System.Drawing.Size(133, 25);
            comboBox_city.TabIndex = 3;
            // 
            // comboBox_state
            // 
            comboBox_state.FormattingEnabled = true;
            comboBox_state.Location = new System.Drawing.Point(119, 326);
            comboBox_state.Name = "comboBox_state";
            comboBox_state.Size = new System.Drawing.Size(133, 25);
            comboBox_state.TabIndex = 3;
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
            comboBox_delimiter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_delimiter.FormattingEnabled = true;
            comboBox_delimiter.Location = new System.Drawing.Point(82, 72);
            comboBox_delimiter.Name = "comboBox_delimiter";
            comboBox_delimiter.Size = new System.Drawing.Size(56, 25);
            comboBox_delimiter.TabIndex = 7;
            // 
            // groupBox_contactPersonMandatoryFields
            // 
            groupBox_contactPersonMandatoryFields.Controls.Add(label_contactPersonLastName);
            groupBox_contactPersonMandatoryFields.Controls.Add(comboBox_contactPersonLastName);
            groupBox_contactPersonMandatoryFields.Controls.Add(label_contactPersonFirstName);
            groupBox_contactPersonMandatoryFields.Controls.Add(comboBox_contactPersonFirstName);
            groupBox_contactPersonMandatoryFields.Location = new System.Drawing.Point(169, 75);
            groupBox_contactPersonMandatoryFields.Name = "groupBox_contactPersonMandatoryFields";
            groupBox_contactPersonMandatoryFields.Size = new System.Drawing.Size(350, 99);
            groupBox_contactPersonMandatoryFields.TabIndex = 5;
            groupBox_contactPersonMandatoryFields.TabStop = false;
            groupBox_contactPersonMandatoryFields.Text = "Mandatory";
            // 
            // label_contactPersonLastName
            // 
            label_contactPersonLastName.AutoSize = true;
            label_contactPersonLastName.Location = new System.Drawing.Point(6, 62);
            label_contactPersonLastName.Name = "label_contactPersonLastName";
            label_contactPersonLastName.Size = new System.Drawing.Size(72, 17);
            label_contactPersonLastName.TabIndex = 5;
            label_contactPersonLastName.Text = "Last Name";
            // 
            // comboBox_contactPersonLastName
            // 
            comboBox_contactPersonLastName.FormattingEnabled = true;
            comboBox_contactPersonLastName.Location = new System.Drawing.Point(138, 58);
            comboBox_contactPersonLastName.Name = "comboBox_contactPersonLastName";
            comboBox_contactPersonLastName.Size = new System.Drawing.Size(133, 25);
            comboBox_contactPersonLastName.TabIndex = 4;
            // 
            // label_contactPersonFirstName
            // 
            label_contactPersonFirstName.AutoSize = true;
            label_contactPersonFirstName.Location = new System.Drawing.Point(6, 32);
            label_contactPersonFirstName.Name = "label_contactPersonFirstName";
            label_contactPersonFirstName.Size = new System.Drawing.Size(74, 17);
            label_contactPersonFirstName.TabIndex = 1;
            label_contactPersonFirstName.Text = "First Name";
            // 
            // comboBox_contactPersonFirstName
            // 
            comboBox_contactPersonFirstName.FormattingEnabled = true;
            comboBox_contactPersonFirstName.Location = new System.Drawing.Point(138, 28);
            comboBox_contactPersonFirstName.Name = "comboBox_contactPersonFirstName";
            comboBox_contactPersonFirstName.Size = new System.Drawing.Size(133, 25);
            comboBox_contactPersonFirstName.TabIndex = 3;
            // 
            // label_contactPersonSetup
            // 
            label_contactPersonSetup.AutoSize = true;
            label_contactPersonSetup.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            label_contactPersonSetup.Location = new System.Drawing.Point(6, 16);
            label_contactPersonSetup.Name = "label_contactPersonSetup";
            label_contactPersonSetup.Size = new System.Drawing.Size(179, 32);
            label_contactPersonSetup.TabIndex = 0;
            label_contactPersonSetup.Text = "Contact Person";
            // 
            // button_contactPersonSelectFile
            // 
            button_contactPersonSelectFile.BackColor = System.Drawing.Color.FromArgb(226, 43, 141);
            button_contactPersonSelectFile.Cursor = Cursors.Hand;
            button_contactPersonSelectFile.FlatAppearance.BorderSize = 0;
            button_contactPersonSelectFile.FlatStyle = FlatStyle.Flat;
            button_contactPersonSelectFile.ForeColor = System.Drawing.Color.White;
            button_contactPersonSelectFile.Location = new System.Drawing.Point(13, 111);
            button_contactPersonSelectFile.Name = "button_contactPersonSelectFile";
            button_contactPersonSelectFile.Size = new System.Drawing.Size(80, 28);
            button_contactPersonSelectFile.TabIndex = 4;
            button_contactPersonSelectFile.Text = "Select File";
            defaultToolTip.SetToolTip(button_contactPersonSelectFile, "Select input CSV file");
            button_contactPersonSelectFile.UseVisualStyleBackColor = false;
            button_contactPersonSelectFile.Click += button_select_contactPerson_file_Click;
            // 
            // defaultToolTip
            // 
            defaultToolTip.ShowAlways = true;
            // 
            // tmrExpand
            // 
            tmrExpand.Interval = 10;
            tmrExpand.Tick += tmrExpand_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(45, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(90, 15);
            label1.TabIndex = 1;
            label1.Text = "Invoice Address";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.White;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new System.Drawing.Point(9, 1);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(30, 30);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Location = new System.Drawing.Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(438, 32);
            panel1.TabIndex = 2;
            // 
            // UserControl_ContactPersonImport
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel_contactPersonFieldMapping);
            Controls.Add(panel_contactPersonButtons);
            Controls.Add(panel_contactPersonMessage);
            Controls.Add(panel_contactPersonDataTable);
            Name = "UserControl_ContactPersonImport";
            Size = new System.Drawing.Size(1006, 642);
            Load += UserControl1_Load;
            panel_contactPersonDataTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_contactPerson).EndInit();
            panel_contactPersonMessage.ResumeLayout(false);
            panel_contactPersonMessage.PerformLayout();
            panel_contactPersonButtons.ResumeLayout(false);
            panel_contactPersonFieldMapping.ResumeLayout(false);
            panel_contactPersonFieldMapping.PerformLayout();
            flowLayoutPanel_NonMandatoryFields.ResumeLayout(false);
            panel_contactPersonDetailsButton.ResumeLayout(false);
            panel_contactPersonDetailsButton.PerformLayout();
            panel_personDetails.ResumeLayout(false);
            panel_personDetails.PerformLayout();
            panel_contactDetailsButton.ResumeLayout(false);
            panel_contactDetailsButton.PerformLayout();
            panel_contactDetails.ResumeLayout(false);
            panel_contactDetails.PerformLayout();
            groupBox_contactPersonMandatoryFields.ResumeLayout(false);
            groupBox_contactPersonMandatoryFields.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion


        private void AddRowNumberToDataTable()
        {
            dataGridView_contactPerson.DataBindingComplete += (o, e) =>
            {
                foreach (DataGridViewRow row in dataGridView_contactPerson.Rows)
                {
                    row.HeaderCell.Value = (row.Index + 1).ToString();

                }
            };
            dataGridView_contactPerson.RowHeadersWidth = 65;
        }


        private System.ComponentModel.BackgroundWorker WorkerFetcher;
        private Panel panel_contactPersonDataTable;
        private DataGridView dataGridView_contactPerson;
        private Panel panel_contactPersonMessage;
        private Panel panel_contactPersonButtons;
        private Button button_clear;
        private Button button_import;
        private Button button_validate;
        private Button button_stop;
        private Panel panel_contactPersonFieldMapping;
        private GroupBox groupBox_contactPersonMandatoryFields;
        private ComboBox comboBox_contactPersonFirstName;
        private Label label_contactPersonFirstName;
        private Label label_contactPersonSetup;
        private Button button_contactPersonSelectFile;
        private TextBox textBox_contactPersonImportMessages;
        private ComboBox comboBox_contactPersonLastName;
        private Label label_contactPersonLastName;
        private Label label_reportsTo;
        private Label label_owner;
        private Label label_email;
        private Label label_department;
        private Label label_customerNo;
        private Label label_state;
        private Label label_city;
        private Label label_zipCode;
        private Label label_address3;
        private Label label_address2;
        private Label label_address;
        private Label label_fax;
        private Label label_phone;
        private Label label_birthday;
        private Label label_jobTitle;
        private ComboBox comboBox_customerNo;
        private ComboBox comboBox_reportsTo;
        private ComboBox comboBox_state;
        private ComboBox comboBox_city;
        private ComboBox comboBox_zipCode;
        private ComboBox comboBox_address3;
        private ComboBox comboBox_address2;
        private ComboBox comboBox_address;
        private ComboBox comboBox_email;
        private ComboBox comboBox_faxNo;
        private ComboBox comboBox_phoneNo;
        private ComboBox comboBox_department;
        private ComboBox comboBox_birthday;
        private ComboBox comboBox_owner;
        private ComboBox comboBox_jobTitle;
        private ComboBox comboBox_country;
        private Label label_delimiter;
        private ComboBox comboBox_delimiter;
        private ToolTip defaultToolTip;
        private Timer tmrExpand;
        private FlowLayoutPanel flowLayoutPanel_NonMandatoryFields;
        private Panel panel_contactPersonDetailsButton;
        private Panel panel_contactDetails;
        private Label label1;
        private Button button1;
        private Panel panel1;
        private Panel panel_personDetails;
        private Panel panel_contactDetailsButton;
        private Label label_ContactDetails;
        private Label label_country;

        private Label label_homePhone;
        private Label label_mobilePhone;
        private ComboBox comboBox_mobilePhone;
        private ComboBox comboBox_homePhone;
        private Button button_personDetails;
        private Button button_contactDetails;
        private Label label_personDetails;
        private Label label_initials;
        private ComboBox comboBox_initials;
        private ComboBox comboBox_profTitle2;
        private Label label_profTitle2;
        private ComboBox comboBox_profTitle1;
        private Label label_proftitle1;
    }
}
