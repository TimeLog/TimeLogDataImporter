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
            this.components = new System.ComponentModel.Container();
            this.WorkerFetcher = new System.ComponentModel.BackgroundWorker();
            this.panel_taskDataTable = new System.Windows.Forms.Panel();
            this.dataGridView_task = new System.Windows.Forms.DataGridView();
            this.panel_projectMessage = new System.Windows.Forms.Panel();
            this.textBox_taskImportMessages = new System.Windows.Forms.TextBox();
            this.panel_taskButtons = new System.Windows.Forms.Panel();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_import = new System.Windows.Forms.Button();
            this.button_validate = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.panel_taskFieldMapping = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_nonMandatoryFields = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_NonMandatoryButton = new System.Windows.Forms.Panel();
            this.label_nonMandatoryFields = new System.Windows.Forms.Label();
            this.button_expandNonMandatory = new System.Windows.Forms.Button();
            this.panel_NonMandatoryFields = new System.Windows.Forms.Panel();
            this.label_paymentInvoiceDate = new System.Windows.Forms.Label();
            this.label_paymentName = new System.Windows.Forms.Label();
            this.checkBox_defaultAdditionalTextIsRequired = new System.Windows.Forms.CheckBox();
            this.label_paymentProductNo = new System.Windows.Forms.Label();
            this.comboBox_paymentInvoiceDate = new System.Windows.Forms.ComboBox();
            this.comboBox_paymentName = new System.Windows.Forms.ComboBox();
            this.comboBox_paymentProductNo = new System.Windows.Forms.ComboBox();
            this.comboBox_taskHourlyRate = new System.Windows.Forms.ComboBox();
            this.label_taskHourlyRate = new System.Windows.Forms.Label();
            this.checkBox_defaultPaymentRecognitionModel = new System.Windows.Forms.CheckBox();
            this.checkBox_defaultIsBillable = new System.Windows.Forms.CheckBox();
            this.label_paymentRecognitionModel = new System.Windows.Forms.Label();
            this.comboBox_budgetAmount = new System.Windows.Forms.ComboBox();
            this.comboBox_paymentRecognitionModel = new System.Windows.Forms.ComboBox();
            this.comboBox_paymentAmount = new System.Windows.Forms.ComboBox();
            this.label_isBillable = new System.Windows.Forms.Label();
            this.label_paymentAmount = new System.Windows.Forms.Label();
            this.label_budgetAmount = new System.Windows.Forms.Label();
            this.comboBox_isBillable = new System.Windows.Forms.ComboBox();
            this.label_taskNo = new System.Windows.Forms.Label();
            this.label_hourlyRate = new System.Windows.Forms.Label();
            this.comboBox_parentTaskNo = new System.Windows.Forms.ComboBox();
            this.label_parentTaskNo = new System.Windows.Forms.Label();
            this.comboBox_taskNo = new System.Windows.Forms.ComboBox();
            this.label_budgetHours = new System.Windows.Forms.Label();
            this.comboBox_budgetHours = new System.Windows.Forms.ComboBox();
            this.checkBox_defaultIsReadyForInvoicing = new System.Windows.Forms.CheckBox();
            this.label_isReadyForInvoicing = new System.Windows.Forms.Label();
            this.comboBox_description = new System.Windows.Forms.ComboBox();
            this.comboBox_isReadyForInvoicing = new System.Windows.Forms.ComboBox();
            this.label_description = new System.Windows.Forms.Label();
            this.label_additionalTextIsRequired = new System.Windows.Forms.Label();
            this.comboBox_additionalTextIsRequired = new System.Windows.Forms.ComboBox();
            this.comboBox_hourlyRate = new System.Windows.Forms.ComboBox();
            this.label_delimiter = new System.Windows.Forms.Label();
            this.comboBox_delimiter = new System.Windows.Forms.ComboBox();
            this.groupBox_taskMandatoryFields = new System.Windows.Forms.GroupBox();
            this.checkBox_defaultTaskType = new System.Windows.Forms.CheckBox();
            this.comboBox_contractName = new System.Windows.Forms.ComboBox();
            this.label_contractName = new System.Windows.Forms.Label();
            this.label_projectNo = new System.Windows.Forms.Label();
            this.comboBox_projectNo = new System.Windows.Forms.ComboBox();
            this.label_taskType = new System.Windows.Forms.Label();
            this.comboBox_taskType = new System.Windows.Forms.ComboBox();
            this.label_endDate = new System.Windows.Forms.Label();
            this.comboBox_endDate = new System.Windows.Forms.ComboBox();
            this.label_startDate = new System.Windows.Forms.Label();
            this.comboBox_startDate = new System.Windows.Forms.ComboBox();
            this.label_taskName = new System.Windows.Forms.Label();
            this.comboBox_taskName = new System.Windows.Forms.ComboBox();
            this.label_taskSetup = new System.Windows.Forms.Label();
            this.button_taskSelectFile = new System.Windows.Forms.Button();
            this.tmrExpand = new System.Windows.Forms.Timer(this.components);
            this.defaultToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_taskTDRProperties = new System.Windows.Forms.Label();
            this.panel_taskDataTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_task)).BeginInit();
            this.panel_projectMessage.SuspendLayout();
            this.panel_taskButtons.SuspendLayout();
            this.panel_taskFieldMapping.SuspendLayout();
            this.flowLayoutPanel_nonMandatoryFields.SuspendLayout();
            this.panel_NonMandatoryButton.SuspendLayout();
            this.panel_NonMandatoryFields.SuspendLayout();
            this.groupBox_taskMandatoryFields.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkerFetcher
            // 
            this.WorkerFetcher.WorkerReportsProgress = true;
            this.WorkerFetcher.WorkerSupportsCancellation = true;
            this.WorkerFetcher.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WorkerFetcherDoWork);
            // 
            // panel_taskDataTable
            // 
            this.panel_taskDataTable.Controls.Add(this.dataGridView_task);
            this.panel_taskDataTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_taskDataTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_taskDataTable.Location = new System.Drawing.Point(0, 968);
            this.panel_taskDataTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_taskDataTable.Name = "panel_taskDataTable";
            this.panel_taskDataTable.Size = new System.Drawing.Size(1437, 602);
            this.panel_taskDataTable.TabIndex = 6;
            // 
            // dataGridView_task
            // 
            this.dataGridView_task.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView_task.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_task.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_task.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_task.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dataGridView_task.Location = new System.Drawing.Point(0, 17);
            this.dataGridView_task.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_task.Name = "dataGridView_task";
            this.dataGridView_task.RowHeadersWidth = 62;
            this.dataGridView_task.Size = new System.Drawing.Size(1437, 585);
            this.dataGridView_task.TabIndex = 0;
            // 
            // panel_projectMessage
            // 
            this.panel_projectMessage.Controls.Add(this.textBox_taskImportMessages);
            this.panel_projectMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_projectMessage.Location = new System.Drawing.Point(0, 661);
            this.panel_projectMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_projectMessage.Name = "panel_projectMessage";
            this.panel_projectMessage.Size = new System.Drawing.Size(1437, 307);
            this.panel_projectMessage.TabIndex = 10;
            // 
            // textBox_taskImportMessages
            // 
            this.textBox_taskImportMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_taskImportMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_taskImportMessages.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_taskImportMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_taskImportMessages.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_taskImportMessages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_taskImportMessages.Location = new System.Drawing.Point(0, 0);
            this.textBox_taskImportMessages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_taskImportMessages.Multiline = true;
            this.textBox_taskImportMessages.Name = "textBox_taskImportMessages";
            this.textBox_taskImportMessages.ReadOnly = true;
            this.textBox_taskImportMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_taskImportMessages.Size = new System.Drawing.Size(1437, 307);
            this.textBox_taskImportMessages.TabIndex = 0;
            this.defaultToolTip.SetToolTip(this.textBox_taskImportMessages, "Validation or import status");
            this.textBox_taskImportMessages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_taskImportMessages_MouseClick);
            // 
            // panel_taskButtons
            // 
            this.panel_taskButtons.Controls.Add(this.button_clear);
            this.panel_taskButtons.Controls.Add(this.button_import);
            this.panel_taskButtons.Controls.Add(this.button_validate);
            this.panel_taskButtons.Controls.Add(this.button_stop);
            this.panel_taskButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_taskButtons.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel_taskButtons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_taskButtons.Location = new System.Drawing.Point(0, 574);
            this.panel_taskButtons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_taskButtons.Name = "panel_taskButtons";
            this.panel_taskButtons.Size = new System.Drawing.Size(1437, 87);
            this.panel_taskButtons.TabIndex = 12;
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
            // panel_taskFieldMapping
            // 
            this.panel_taskFieldMapping.AutoScroll = true;
            this.panel_taskFieldMapping.Controls.Add(this.flowLayoutPanel_nonMandatoryFields);
            this.panel_taskFieldMapping.Controls.Add(this.label_delimiter);
            this.panel_taskFieldMapping.Controls.Add(this.comboBox_delimiter);
            this.panel_taskFieldMapping.Controls.Add(this.groupBox_taskMandatoryFields);
            this.panel_taskFieldMapping.Controls.Add(this.label_taskSetup);
            this.panel_taskFieldMapping.Controls.Add(this.button_taskSelectFile);
            this.panel_taskFieldMapping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_taskFieldMapping.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel_taskFieldMapping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_taskFieldMapping.Location = new System.Drawing.Point(0, 0);
            this.panel_taskFieldMapping.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_taskFieldMapping.Name = "panel_taskFieldMapping";
            this.panel_taskFieldMapping.Size = new System.Drawing.Size(1437, 574);
            this.panel_taskFieldMapping.TabIndex = 13;
            // 
            // flowLayoutPanel_nonMandatoryFields
            // 
            this.flowLayoutPanel_nonMandatoryFields.Controls.Add(this.panel_NonMandatoryButton);
            this.flowLayoutPanel_nonMandatoryFields.Controls.Add(this.panel_NonMandatoryFields);
            this.flowLayoutPanel_nonMandatoryFields.Location = new System.Drawing.Point(751, 100);
            this.flowLayoutPanel_nonMandatoryFields.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel_nonMandatoryFields.Name = "flowLayoutPanel_nonMandatoryFields";
            this.flowLayoutPanel_nonMandatoryFields.Size = new System.Drawing.Size(639, 951);
            this.flowLayoutPanel_nonMandatoryFields.TabIndex = 7;
            // 
            // panel_NonMandatoryButton
            // 
            this.panel_NonMandatoryButton.Controls.Add(this.label_nonMandatoryFields);
            this.panel_NonMandatoryButton.Controls.Add(this.button_expandNonMandatory);
            this.panel_NonMandatoryButton.Location = new System.Drawing.Point(4, 5);
            this.panel_NonMandatoryButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_NonMandatoryButton.Name = "panel_NonMandatoryButton";
            this.panel_NonMandatoryButton.Size = new System.Drawing.Size(629, 53);
            this.panel_NonMandatoryButton.TabIndex = 0;
            // 
            // label_nonMandatoryFields
            // 
            this.label_nonMandatoryFields.AutoSize = true;
            this.label_nonMandatoryFields.ForeColor = System.Drawing.Color.Black;
            this.label_nonMandatoryFields.Location = new System.Drawing.Point(66, 13);
            this.label_nonMandatoryFields.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_nonMandatoryFields.Name = "label_nonMandatoryFields";
            this.label_nonMandatoryFields.Size = new System.Drawing.Size(158, 28);
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
            this.panel_NonMandatoryFields.Controls.Add(this.panel1);
            this.panel_NonMandatoryFields.Controls.Add(this.label_paymentInvoiceDate);
            this.panel_NonMandatoryFields.Controls.Add(this.label_paymentName);
            this.panel_NonMandatoryFields.Controls.Add(this.checkBox_defaultAdditionalTextIsRequired);
            this.panel_NonMandatoryFields.Controls.Add(this.label_paymentProductNo);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_paymentInvoiceDate);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_paymentName);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_paymentProductNo);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_taskHourlyRate);
            this.panel_NonMandatoryFields.Controls.Add(this.label_taskHourlyRate);
            this.panel_NonMandatoryFields.Controls.Add(this.checkBox_defaultPaymentRecognitionModel);
            this.panel_NonMandatoryFields.Controls.Add(this.checkBox_defaultIsBillable);
            this.panel_NonMandatoryFields.Controls.Add(this.label_paymentRecognitionModel);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_budgetAmount);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_paymentRecognitionModel);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_paymentAmount);
            this.panel_NonMandatoryFields.Controls.Add(this.label_isBillable);
            this.panel_NonMandatoryFields.Controls.Add(this.label_paymentAmount);
            this.panel_NonMandatoryFields.Controls.Add(this.label_budgetAmount);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_isBillable);
            this.panel_NonMandatoryFields.Controls.Add(this.label_taskNo);
            this.panel_NonMandatoryFields.Controls.Add(this.label_hourlyRate);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_parentTaskNo);
            this.panel_NonMandatoryFields.Controls.Add(this.label_parentTaskNo);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_taskNo);
            this.panel_NonMandatoryFields.Controls.Add(this.label_budgetHours);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_budgetHours);
            this.panel_NonMandatoryFields.Controls.Add(this.checkBox_defaultIsReadyForInvoicing);
            this.panel_NonMandatoryFields.Controls.Add(this.label_isReadyForInvoicing);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_description);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_isReadyForInvoicing);
            this.panel_NonMandatoryFields.Controls.Add(this.label_description);
            this.panel_NonMandatoryFields.Controls.Add(this.label_additionalTextIsRequired);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_additionalTextIsRequired);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_hourlyRate);
            this.panel_NonMandatoryFields.Location = new System.Drawing.Point(4, 68);
            this.panel_NonMandatoryFields.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_NonMandatoryFields.MaximumSize = new System.Drawing.Size(629, 950);
            this.panel_NonMandatoryFields.MinimumSize = new System.Drawing.Size(546, 0);
            this.panel_NonMandatoryFields.Name = "panel_NonMandatoryFields";
            this.panel_NonMandatoryFields.Size = new System.Drawing.Size(629, 883);
            this.panel_NonMandatoryFields.TabIndex = 1;
            // 
            // label_paymentInvoiceDate
            // 
            this.label_paymentInvoiceDate.AutoSize = true;
            this.label_paymentInvoiceDate.Location = new System.Drawing.Point(14, 827);
            this.label_paymentInvoiceDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_paymentInvoiceDate.Name = "label_paymentInvoiceDate";
            this.label_paymentInvoiceDate.Size = new System.Drawing.Size(210, 28);
            this.label_paymentInvoiceDate.TabIndex = 1;
            this.label_paymentInvoiceDate.Text = "Payment Invoice Date";
            // 
            // label_paymentName
            // 
            this.label_paymentName.AutoSize = true;
            this.label_paymentName.Location = new System.Drawing.Point(14, 775);
            this.label_paymentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_paymentName.Name = "label_paymentName";
            this.label_paymentName.Size = new System.Drawing.Size(151, 28);
            this.label_paymentName.TabIndex = 1;
            this.label_paymentName.Text = "Payment Name";
            // 
            // checkBox_defaultAdditionalTextIsRequired
            // 
            this.checkBox_defaultAdditionalTextIsRequired.AutoSize = true;
            this.checkBox_defaultAdditionalTextIsRequired.Location = new System.Drawing.Point(517, 118);
            this.checkBox_defaultAdditionalTextIsRequired.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_defaultAdditionalTextIsRequired.Name = "checkBox_defaultAdditionalTextIsRequired";
            this.checkBox_defaultAdditionalTextIsRequired.Size = new System.Drawing.Size(104, 32);
            this.checkBox_defaultAdditionalTextIsRequired.TabIndex = 4;
            this.checkBox_defaultAdditionalTextIsRequired.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultAdditionalTextIsRequired, "Set default values for all rows of a particular column field");
            this.checkBox_defaultAdditionalTextIsRequired.UseVisualStyleBackColor = true;
            this.checkBox_defaultAdditionalTextIsRequired.CheckedChanged += new System.EventHandler(this.checkBox_defaultAdditionalTextIsRequired_CheckedChanged);
            // 
            // label_paymentProductNo
            // 
            this.label_paymentProductNo.AutoSize = true;
            this.label_paymentProductNo.Location = new System.Drawing.Point(14, 724);
            this.label_paymentProductNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_paymentProductNo.Name = "label_paymentProductNo";
            this.label_paymentProductNo.Size = new System.Drawing.Size(201, 28);
            this.label_paymentProductNo.TabIndex = 1;
            this.label_paymentProductNo.Text = "Payment Product No";
            // 
            // comboBox_paymentInvoiceDate
            // 
            this.comboBox_paymentInvoiceDate.FormattingEnabled = true;
            this.comboBox_paymentInvoiceDate.Location = new System.Drawing.Point(280, 822);
            this.comboBox_paymentInvoiceDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_paymentInvoiceDate.Name = "comboBox_paymentInvoiceDate";
            this.comboBox_paymentInvoiceDate.Size = new System.Drawing.Size(227, 36);
            this.comboBox_paymentInvoiceDate.TabIndex = 18;
            this.comboBox_paymentInvoiceDate.SelectedIndexChanged += new System.EventHandler(this.comboBox_paymentInvoiceDate_SelectedIndexChanged);
            // 
            // comboBox_paymentName
            // 
            this.comboBox_paymentName.FormattingEnabled = true;
            this.comboBox_paymentName.Location = new System.Drawing.Point(280, 770);
            this.comboBox_paymentName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_paymentName.Name = "comboBox_paymentName";
            this.comboBox_paymentName.Size = new System.Drawing.Size(227, 36);
            this.comboBox_paymentName.TabIndex = 17;
            this.comboBox_paymentName.SelectedIndexChanged += new System.EventHandler(this.comboBox_paymentName_SelectedIndexChanged);
            // 
            // comboBox_paymentProductNo
            // 
            this.comboBox_paymentProductNo.FormattingEnabled = true;
            this.comboBox_paymentProductNo.Location = new System.Drawing.Point(280, 719);
            this.comboBox_paymentProductNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_paymentProductNo.Name = "comboBox_paymentProductNo";
            this.comboBox_paymentProductNo.Size = new System.Drawing.Size(227, 36);
            this.comboBox_paymentProductNo.TabIndex = 16;
            this.comboBox_paymentProductNo.SelectedIndexChanged += new System.EventHandler(this.comboBox_paymentProductNo_SelectedIndexChanged);
            // 
            // comboBox_taskHourlyRate
            // 
            this.comboBox_taskHourlyRate.FormattingEnabled = true;
            this.comboBox_taskHourlyRate.Location = new System.Drawing.Point(280, 667);
            this.comboBox_taskHourlyRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_taskHourlyRate.Name = "comboBox_taskHourlyRate";
            this.comboBox_taskHourlyRate.Size = new System.Drawing.Size(227, 36);
            this.comboBox_taskHourlyRate.TabIndex = 15;
            this.comboBox_taskHourlyRate.SelectedIndexChanged += new System.EventHandler(this.comboBox_taskHourlyRate_SelectedIndexChanged);
            // 
            // label_taskHourlyRate
            // 
            this.label_taskHourlyRate.AutoSize = true;
            this.label_taskHourlyRate.Location = new System.Drawing.Point(14, 672);
            this.label_taskHourlyRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_taskHourlyRate.Name = "label_taskHourlyRate";
            this.label_taskHourlyRate.Size = new System.Drawing.Size(164, 28);
            this.label_taskHourlyRate.TabIndex = 1;
            this.label_taskHourlyRate.Text = "Task Hourly Rate";
            // 
            // checkBox_defaultPaymentRecognitionModel
            // 
            this.checkBox_defaultPaymentRecognitionModel.AutoSize = true;
            this.checkBox_defaultPaymentRecognitionModel.Location = new System.Drawing.Point(517, 567);
            this.checkBox_defaultPaymentRecognitionModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_defaultPaymentRecognitionModel.Name = "checkBox_defaultPaymentRecognitionModel";
            this.checkBox_defaultPaymentRecognitionModel.Size = new System.Drawing.Size(104, 32);
            this.checkBox_defaultPaymentRecognitionModel.TabIndex = 12;
            this.checkBox_defaultPaymentRecognitionModel.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultPaymentRecognitionModel, "Set default values for all rows of a particular column field");
            this.checkBox_defaultPaymentRecognitionModel.UseVisualStyleBackColor = true;
            this.checkBox_defaultPaymentRecognitionModel.CheckedChanged += new System.EventHandler(this.checkBox_defaultPaymentRecognitionModel_CheckedChanged);
            // 
            // checkBox_defaultIsBillable
            // 
            this.checkBox_defaultIsBillable.AutoSize = true;
            this.checkBox_defaultIsBillable.Location = new System.Drawing.Point(517, 428);
            this.checkBox_defaultIsBillable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_defaultIsBillable.Name = "checkBox_defaultIsBillable";
            this.checkBox_defaultIsBillable.Size = new System.Drawing.Size(104, 32);
            this.checkBox_defaultIsBillable.TabIndex = 14;
            this.checkBox_defaultIsBillable.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultIsBillable, "Set default values for all rows of a particular column field");
            this.checkBox_defaultIsBillable.UseVisualStyleBackColor = true;
            this.checkBox_defaultIsBillable.CheckedChanged += new System.EventHandler(this.checkBox_defaultIsBillable_CheckedChanged);
            // 
            // label_paymentRecognitionModel
            // 
            this.label_paymentRecognitionModel.AutoSize = true;
            this.label_paymentRecognitionModel.Location = new System.Drawing.Point(14, 569);
            this.label_paymentRecognitionModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_paymentRecognitionModel.Name = "label_paymentRecognitionModel";
            this.label_paymentRecognitionModel.Size = new System.Drawing.Size(269, 28);
            this.label_paymentRecognitionModel.TabIndex = 1;
            this.label_paymentRecognitionModel.Text = "Payment Recognition Model";
            // 
            // comboBox_budgetAmount
            // 
            this.comboBox_budgetAmount.FormattingEnabled = true;
            this.comboBox_budgetAmount.Location = new System.Drawing.Point(280, 218);
            this.comboBox_budgetAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_budgetAmount.Name = "comboBox_budgetAmount";
            this.comboBox_budgetAmount.Size = new System.Drawing.Size(227, 36);
            this.comboBox_budgetAmount.TabIndex = 10;
            this.comboBox_budgetAmount.SelectedIndexChanged += new System.EventHandler(this.comboBox_budgetAmount_SelectedIndexChanged);
            // 
            // comboBox_paymentRecognitionModel
            // 
            this.comboBox_paymentRecognitionModel.FormattingEnabled = true;
            this.comboBox_paymentRecognitionModel.Location = new System.Drawing.Point(280, 564);
            this.comboBox_paymentRecognitionModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_paymentRecognitionModel.Name = "comboBox_paymentRecognitionModel";
            this.comboBox_paymentRecognitionModel.Size = new System.Drawing.Size(227, 36);
            this.comboBox_paymentRecognitionModel.TabIndex = 9;
            this.comboBox_paymentRecognitionModel.SelectedIndexChanged += new System.EventHandler(this.comboBox_paymentRecognitionModel_SelectedIndexChanged);
            // 
            // comboBox_paymentAmount
            // 
            this.comboBox_paymentAmount.FormattingEnabled = true;
            this.comboBox_paymentAmount.Location = new System.Drawing.Point(280, 615);
            this.comboBox_paymentAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_paymentAmount.Name = "comboBox_paymentAmount";
            this.comboBox_paymentAmount.Size = new System.Drawing.Size(227, 36);
            this.comboBox_paymentAmount.TabIndex = 3;
            this.comboBox_paymentAmount.SelectedIndexChanged += new System.EventHandler(this.comboBox_paymentAmount_SelectedIndexChanged);
            // 
            // label_isBillable
            // 
            this.label_isBillable.AutoSize = true;
            this.label_isBillable.Location = new System.Drawing.Point(14, 430);
            this.label_isBillable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_isBillable.Name = "label_isBillable";
            this.label_isBillable.Size = new System.Drawing.Size(98, 28);
            this.label_isBillable.TabIndex = 1;
            this.label_isBillable.Text = "Is Billable";
            // 
            // label_paymentAmount
            // 
            this.label_paymentAmount.AutoSize = true;
            this.label_paymentAmount.Location = new System.Drawing.Point(14, 620);
            this.label_paymentAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_paymentAmount.Name = "label_paymentAmount";
            this.label_paymentAmount.Size = new System.Drawing.Size(171, 28);
            this.label_paymentAmount.TabIndex = 1;
            this.label_paymentAmount.Text = "Payment Amount";
            // 
            // label_budgetAmount
            // 
            this.label_budgetAmount.AutoSize = true;
            this.label_budgetAmount.Location = new System.Drawing.Point(14, 223);
            this.label_budgetAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_budgetAmount.Name = "label_budgetAmount";
            this.label_budgetAmount.Size = new System.Drawing.Size(158, 28);
            this.label_budgetAmount.TabIndex = 1;
            this.label_budgetAmount.Text = "Budget Amount";
            // 
            // comboBox_isBillable
            // 
            this.comboBox_isBillable.FormattingEnabled = true;
            this.comboBox_isBillable.Location = new System.Drawing.Point(280, 425);
            this.comboBox_isBillable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_isBillable.Name = "comboBox_isBillable";
            this.comboBox_isBillable.Size = new System.Drawing.Size(227, 36);
            this.comboBox_isBillable.TabIndex = 8;
            this.comboBox_isBillable.SelectedIndexChanged += new System.EventHandler(this.comboBox_isBillable_SelectedIndexChanged);
            // 
            // label_taskNo
            // 
            this.label_taskNo.AutoSize = true;
            this.label_taskNo.Location = new System.Drawing.Point(14, 17);
            this.label_taskNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_taskNo.Name = "label_taskNo";
            this.label_taskNo.Size = new System.Drawing.Size(84, 28);
            this.label_taskNo.TabIndex = 1;
            this.label_taskNo.Text = "Task No";
            // 
            // label_hourlyRate
            // 
            this.label_hourlyRate.AutoSize = true;
            this.label_hourlyRate.Location = new System.Drawing.Point(14, 327);
            this.label_hourlyRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_hourlyRate.Name = "label_hourlyRate";
            this.label_hourlyRate.Size = new System.Drawing.Size(119, 28);
            this.label_hourlyRate.TabIndex = 1;
            this.label_hourlyRate.Text = "Hourly Rate";
            this.defaultToolTip.SetToolTip(this.label_hourlyRate, "In expense currency");
            // 
            // comboBox_parentTaskNo
            // 
            this.comboBox_parentTaskNo.FormattingEnabled = true;
            this.comboBox_parentTaskNo.Location = new System.Drawing.Point(280, 373);
            this.comboBox_parentTaskNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_parentTaskNo.Name = "comboBox_parentTaskNo";
            this.comboBox_parentTaskNo.Size = new System.Drawing.Size(227, 36);
            this.comboBox_parentTaskNo.TabIndex = 7;
            this.comboBox_parentTaskNo.SelectedIndexChanged += new System.EventHandler(this.comboBox_parentTaskNo_SelectedIndexChanged);
            // 
            // label_parentTaskNo
            // 
            this.label_parentTaskNo.AutoSize = true;
            this.label_parentTaskNo.Location = new System.Drawing.Point(14, 378);
            this.label_parentTaskNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_parentTaskNo.Name = "label_parentTaskNo";
            this.label_parentTaskNo.Size = new System.Drawing.Size(148, 28);
            this.label_parentTaskNo.TabIndex = 1;
            this.label_parentTaskNo.Text = "Parent Task No";
            // 
            // comboBox_taskNo
            // 
            this.comboBox_taskNo.FormattingEnabled = true;
            this.comboBox_taskNo.Location = new System.Drawing.Point(280, 12);
            this.comboBox_taskNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_taskNo.Name = "comboBox_taskNo";
            this.comboBox_taskNo.Size = new System.Drawing.Size(227, 36);
            this.comboBox_taskNo.TabIndex = 3;
            this.comboBox_taskNo.SelectedIndexChanged += new System.EventHandler(this.comboBox_taskNo_SelectedIndexChanged);
            // 
            // label_budgetHours
            // 
            this.label_budgetHours.AutoSize = true;
            this.label_budgetHours.Location = new System.Drawing.Point(14, 172);
            this.label_budgetHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_budgetHours.Name = "label_budgetHours";
            this.label_budgetHours.Size = new System.Drawing.Size(139, 28);
            this.label_budgetHours.TabIndex = 1;
            this.label_budgetHours.Text = "Budget Hours";
            // 
            // comboBox_budgetHours
            // 
            this.comboBox_budgetHours.FormattingEnabled = true;
            this.comboBox_budgetHours.Location = new System.Drawing.Point(280, 167);
            this.comboBox_budgetHours.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_budgetHours.Name = "comboBox_budgetHours";
            this.comboBox_budgetHours.Size = new System.Drawing.Size(227, 36);
            this.comboBox_budgetHours.TabIndex = 3;
            this.comboBox_budgetHours.SelectedIndexChanged += new System.EventHandler(this.comboBox_budgetHours_SelectedIndexChanged);
            // 
            // checkBox_defaultIsReadyForInvoicing
            // 
            this.checkBox_defaultIsReadyForInvoicing.AutoSize = true;
            this.checkBox_defaultIsReadyForInvoicing.Location = new System.Drawing.Point(517, 273);
            this.checkBox_defaultIsReadyForInvoicing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_defaultIsReadyForInvoicing.Name = "checkBox_defaultIsReadyForInvoicing";
            this.checkBox_defaultIsReadyForInvoicing.Size = new System.Drawing.Size(104, 32);
            this.checkBox_defaultIsReadyForInvoicing.TabIndex = 6;
            this.checkBox_defaultIsReadyForInvoicing.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultIsReadyForInvoicing, "Set default values for all rows of a particular column field");
            this.checkBox_defaultIsReadyForInvoicing.UseVisualStyleBackColor = true;
            this.checkBox_defaultIsReadyForInvoicing.CheckedChanged += new System.EventHandler(this.checkBox_defaultIsReadyForInvoicing_CheckedChanged);
            // 
            // label_isReadyForInvoicing
            // 
            this.label_isReadyForInvoicing.AutoSize = true;
            this.label_isReadyForInvoicing.Location = new System.Drawing.Point(14, 275);
            this.label_isReadyForInvoicing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_isReadyForInvoicing.Name = "label_isReadyForInvoicing";
            this.label_isReadyForInvoicing.Size = new System.Drawing.Size(211, 28);
            this.label_isReadyForInvoicing.TabIndex = 1;
            this.label_isReadyForInvoicing.Text = "Is Ready For Invoicing";
            // 
            // comboBox_description
            // 
            this.comboBox_description.FormattingEnabled = true;
            this.comboBox_description.Location = new System.Drawing.Point(280, 63);
            this.comboBox_description.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_description.Name = "comboBox_description";
            this.comboBox_description.Size = new System.Drawing.Size(227, 36);
            this.comboBox_description.TabIndex = 3;
            this.comboBox_description.SelectedIndexChanged += new System.EventHandler(this.comboBox_description_SelectedIndexChanged);
            // 
            // comboBox_isReadyForInvoicing
            // 
            this.comboBox_isReadyForInvoicing.FormattingEnabled = true;
            this.comboBox_isReadyForInvoicing.Location = new System.Drawing.Point(280, 270);
            this.comboBox_isReadyForInvoicing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_isReadyForInvoicing.Name = "comboBox_isReadyForInvoicing";
            this.comboBox_isReadyForInvoicing.Size = new System.Drawing.Size(227, 36);
            this.comboBox_isReadyForInvoicing.TabIndex = 3;
            this.comboBox_isReadyForInvoicing.SelectedIndexChanged += new System.EventHandler(this.comboBox_isReadyForInvoicing_SelectedIndexChanged);
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Location = new System.Drawing.Point(14, 68);
            this.label_description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(115, 28);
            this.label_description.TabIndex = 1;
            this.label_description.Text = "Description";
            // 
            // label_additionalTextIsRequired
            // 
            this.label_additionalTextIsRequired.AutoSize = true;
            this.label_additionalTextIsRequired.Location = new System.Drawing.Point(14, 120);
            this.label_additionalTextIsRequired.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_additionalTextIsRequired.Name = "label_additionalTextIsRequired";
            this.label_additionalTextIsRequired.Size = new System.Drawing.Size(205, 28);
            this.label_additionalTextIsRequired.TabIndex = 1;
            this.label_additionalTextIsRequired.Text = "Add. Text Is Required";
            // 
            // comboBox_additionalTextIsRequired
            // 
            this.comboBox_additionalTextIsRequired.FormattingEnabled = true;
            this.comboBox_additionalTextIsRequired.Location = new System.Drawing.Point(280, 115);
            this.comboBox_additionalTextIsRequired.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_additionalTextIsRequired.Name = "comboBox_additionalTextIsRequired";
            this.comboBox_additionalTextIsRequired.Size = new System.Drawing.Size(227, 36);
            this.comboBox_additionalTextIsRequired.TabIndex = 3;
            this.comboBox_additionalTextIsRequired.SelectedIndexChanged += new System.EventHandler(this.comboBox_additionalTextIsRequired_SelectedIndexChanged);
            // 
            // comboBox_hourlyRate
            // 
            this.comboBox_hourlyRate.FormattingEnabled = true;
            this.comboBox_hourlyRate.Location = new System.Drawing.Point(280, 322);
            this.comboBox_hourlyRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_hourlyRate.Name = "comboBox_hourlyRate";
            this.comboBox_hourlyRate.Size = new System.Drawing.Size(227, 36);
            this.comboBox_hourlyRate.TabIndex = 3;
            this.comboBox_hourlyRate.SelectedIndexChanged += new System.EventHandler(this.comboBox_hourlyRate_SelectedIndexChanged);
            // 
            // label_delimiter
            // 
            this.label_delimiter.AutoSize = true;
            this.label_delimiter.Location = new System.Drawing.Point(14, 125);
            this.label_delimiter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_delimiter.Name = "label_delimiter";
            this.label_delimiter.Size = new System.Drawing.Size(95, 28);
            this.label_delimiter.TabIndex = 1;
            this.label_delimiter.Text = "Delimiter";
            // 
            // comboBox_delimiter
            // 
            this.comboBox_delimiter.FormattingEnabled = true;
            this.comboBox_delimiter.Location = new System.Drawing.Point(117, 120);
            this.comboBox_delimiter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_delimiter.Name = "comboBox_delimiter";
            this.comboBox_delimiter.Size = new System.Drawing.Size(78, 36);
            this.comboBox_delimiter.TabIndex = 6;
            // 
            // groupBox_taskMandatoryFields
            // 
            this.groupBox_taskMandatoryFields.Controls.Add(this.checkBox_defaultTaskType);
            this.groupBox_taskMandatoryFields.Controls.Add(this.comboBox_contractName);
            this.groupBox_taskMandatoryFields.Controls.Add(this.label_contractName);
            this.groupBox_taskMandatoryFields.Controls.Add(this.label_projectNo);
            this.groupBox_taskMandatoryFields.Controls.Add(this.comboBox_projectNo);
            this.groupBox_taskMandatoryFields.Controls.Add(this.label_taskType);
            this.groupBox_taskMandatoryFields.Controls.Add(this.comboBox_taskType);
            this.groupBox_taskMandatoryFields.Controls.Add(this.label_endDate);
            this.groupBox_taskMandatoryFields.Controls.Add(this.comboBox_endDate);
            this.groupBox_taskMandatoryFields.Controls.Add(this.label_startDate);
            this.groupBox_taskMandatoryFields.Controls.Add(this.comboBox_startDate);
            this.groupBox_taskMandatoryFields.Controls.Add(this.label_taskName);
            this.groupBox_taskMandatoryFields.Controls.Add(this.comboBox_taskName);
            this.groupBox_taskMandatoryFields.Location = new System.Drawing.Point(213, 103);
            this.groupBox_taskMandatoryFields.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_taskMandatoryFields.Name = "groupBox_taskMandatoryFields";
            this.groupBox_taskMandatoryFields.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_taskMandatoryFields.Size = new System.Drawing.Size(523, 368);
            this.groupBox_taskMandatoryFields.TabIndex = 5;
            this.groupBox_taskMandatoryFields.TabStop = false;
            this.groupBox_taskMandatoryFields.Text = "Mandatory";
            // 
            // checkBox_defaultTaskType
            // 
            this.checkBox_defaultTaskType.AutoSize = true;
            this.checkBox_defaultTaskType.Location = new System.Drawing.Point(421, 250);
            this.checkBox_defaultTaskType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_defaultTaskType.Name = "checkBox_defaultTaskType";
            this.checkBox_defaultTaskType.Size = new System.Drawing.Size(104, 32);
            this.checkBox_defaultTaskType.TabIndex = 11;
            this.checkBox_defaultTaskType.Text = "Default";
            this.checkBox_defaultTaskType.UseVisualStyleBackColor = true;
            this.checkBox_defaultTaskType.CheckedChanged += new System.EventHandler(this.checkBox_defaultTaskType_CheckedChanged);
            // 
            // comboBox_contractName
            // 
            this.comboBox_contractName.FormattingEnabled = true;
            this.comboBox_contractName.Location = new System.Drawing.Point(193, 195);
            this.comboBox_contractName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_contractName.Name = "comboBox_contractName";
            this.comboBox_contractName.Size = new System.Drawing.Size(218, 36);
            this.comboBox_contractName.TabIndex = 10;
            this.comboBox_contractName.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractName_SelectedIndexChanged);
            // 
            // label_contractName
            // 
            this.label_contractName.AutoSize = true;
            this.label_contractName.Location = new System.Drawing.Point(9, 200);
            this.label_contractName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_contractName.Name = "label_contractName";
            this.label_contractName.Size = new System.Drawing.Size(148, 28);
            this.label_contractName.TabIndex = 1;
            this.label_contractName.Text = "Contract Name";
            // 
            // label_projectNo
            // 
            this.label_projectNo.AutoSize = true;
            this.label_projectNo.Location = new System.Drawing.Point(9, 303);
            this.label_projectNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_projectNo.Name = "label_projectNo";
            this.label_projectNo.Size = new System.Drawing.Size(108, 28);
            this.label_projectNo.TabIndex = 1;
            this.label_projectNo.Text = "Project No";
            this.defaultToolTip.SetToolTip(this.label_projectNo, "In project currency");
            // 
            // comboBox_projectNo
            // 
            this.comboBox_projectNo.FormattingEnabled = true;
            this.comboBox_projectNo.Location = new System.Drawing.Point(193, 298);
            this.comboBox_projectNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_projectNo.Name = "comboBox_projectNo";
            this.comboBox_projectNo.Size = new System.Drawing.Size(218, 36);
            this.comboBox_projectNo.TabIndex = 3;
            this.comboBox_projectNo.SelectedIndexChanged += new System.EventHandler(this.comboBox_projectNo_SelectedIndexChanged);
            // 
            // label_taskType
            // 
            this.label_taskType.AutoSize = true;
            this.label_taskType.Location = new System.Drawing.Point(9, 252);
            this.label_taskType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_taskType.Name = "label_taskType";
            this.label_taskType.Size = new System.Drawing.Size(100, 28);
            this.label_taskType.TabIndex = 1;
            this.label_taskType.Text = "Task Type";
            this.defaultToolTip.SetToolTip(this.label_taskType, "In expense currency");
            // 
            // comboBox_taskType
            // 
            this.comboBox_taskType.FormattingEnabled = true;
            this.comboBox_taskType.Location = new System.Drawing.Point(193, 247);
            this.comboBox_taskType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_taskType.Name = "comboBox_taskType";
            this.comboBox_taskType.Size = new System.Drawing.Size(218, 36);
            this.comboBox_taskType.TabIndex = 3;
            this.comboBox_taskType.SelectedIndexChanged += new System.EventHandler(this.comboBox_taskType_SelectedIndexChanged);
            // 
            // label_endDate
            // 
            this.label_endDate.AutoSize = true;
            this.label_endDate.Location = new System.Drawing.Point(9, 148);
            this.label_endDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_endDate.Name = "label_endDate";
            this.label_endDate.Size = new System.Drawing.Size(94, 28);
            this.label_endDate.TabIndex = 1;
            this.label_endDate.Text = "End Date";
            // 
            // comboBox_endDate
            // 
            this.comboBox_endDate.FormattingEnabled = true;
            this.comboBox_endDate.Location = new System.Drawing.Point(193, 143);
            this.comboBox_endDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_endDate.Name = "comboBox_endDate";
            this.comboBox_endDate.Size = new System.Drawing.Size(218, 36);
            this.comboBox_endDate.TabIndex = 3;
            this.comboBox_endDate.SelectedIndexChanged += new System.EventHandler(this.comboBox_endDate_SelectedIndexChanged);
            // 
            // label_startDate
            // 
            this.label_startDate.AutoSize = true;
            this.label_startDate.Location = new System.Drawing.Point(9, 97);
            this.label_startDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_startDate.Name = "label_startDate";
            this.label_startDate.Size = new System.Drawing.Size(102, 28);
            this.label_startDate.TabIndex = 1;
            this.label_startDate.Text = "Start Date";
            // 
            // comboBox_startDate
            // 
            this.comboBox_startDate.FormattingEnabled = true;
            this.comboBox_startDate.Location = new System.Drawing.Point(193, 92);
            this.comboBox_startDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_startDate.Name = "comboBox_startDate";
            this.comboBox_startDate.Size = new System.Drawing.Size(218, 36);
            this.comboBox_startDate.TabIndex = 3;
            this.comboBox_startDate.SelectedIndexChanged += new System.EventHandler(this.comboBox_startDate_SelectedIndexChanged);
            // 
            // label_taskName
            // 
            this.label_taskName.AutoSize = true;
            this.label_taskName.Location = new System.Drawing.Point(9, 45);
            this.label_taskName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_taskName.Name = "label_taskName";
            this.label_taskName.Size = new System.Drawing.Size(111, 28);
            this.label_taskName.TabIndex = 1;
            this.label_taskName.Text = "Task Name";
            // 
            // comboBox_taskName
            // 
            this.comboBox_taskName.FormattingEnabled = true;
            this.comboBox_taskName.Location = new System.Drawing.Point(193, 40);
            this.comboBox_taskName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_taskName.Name = "comboBox_taskName";
            this.comboBox_taskName.Size = new System.Drawing.Size(218, 36);
            this.comboBox_taskName.TabIndex = 3;
            this.comboBox_taskName.SelectedIndexChanged += new System.EventHandler(this.comboBox_taskName_SelectedIndexChanged);
            // 
            // label_taskSetup
            // 
            this.label_taskSetup.AutoSize = true;
            this.label_taskSetup.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_taskSetup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_taskSetup.Location = new System.Drawing.Point(10, 27);
            this.label_taskSetup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_taskSetup.Name = "label_taskSetup";
            this.label_taskSetup.Size = new System.Drawing.Size(302, 48);
            this.label_taskSetup.TabIndex = 0;
            this.label_taskSetup.Text = "Task Data Import";
            // 
            // button_taskSelectFile
            // 
            this.button_taskSelectFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(43)))), ((int)(((byte)(141)))));
            this.button_taskSelectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_taskSelectFile.FlatAppearance.BorderSize = 0;
            this.button_taskSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_taskSelectFile.ForeColor = System.Drawing.Color.White;
            this.button_taskSelectFile.Location = new System.Drawing.Point(19, 185);
            this.button_taskSelectFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_taskSelectFile.Name = "button_taskSelectFile";
            this.button_taskSelectFile.Size = new System.Drawing.Size(114, 48);
            this.button_taskSelectFile.TabIndex = 4;
            this.button_taskSelectFile.Text = "Select File";
            this.defaultToolTip.SetToolTip(this.button_taskSelectFile, "Select input CSV file");
            this.button_taskSelectFile.UseVisualStyleBackColor = false;
            this.button_taskSelectFile.Click += new System.EventHandler(this.button_select_task_file_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label_taskTDRProperties);
            this.panel1.Location = new System.Drawing.Point(0, 517);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 47);
            this.panel1.TabIndex = 19;
            // 
            // label_taskTDRProperties
            // 
            this.label_taskTDRProperties.AutoSize = true;
            this.label_taskTDRProperties.Location = new System.Drawing.Point(14, 9);
            this.label_taskTDRProperties.Name = "label_taskTDRProperties";
            this.label_taskTDRProperties.Size = new System.Drawing.Size(233, 28);
            this.label_taskTDRProperties.TabIndex = 0;
            this.label_taskTDRProperties.Text = "Properties for TDR tasks";
            // 
            // UserControl_TaskImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_taskFieldMapping);
            this.Controls.Add(this.panel_taskButtons);
            this.Controls.Add(this.panel_projectMessage);
            this.Controls.Add(this.panel_taskDataTable);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControl_TaskImport";
            this.Size = new System.Drawing.Size(1437, 1570);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.panel_taskDataTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_task)).EndInit();
            this.panel_projectMessage.ResumeLayout(false);
            this.panel_projectMessage.PerformLayout();
            this.panel_taskButtons.ResumeLayout(false);
            this.panel_taskFieldMapping.ResumeLayout(false);
            this.panel_taskFieldMapping.PerformLayout();
            this.flowLayoutPanel_nonMandatoryFields.ResumeLayout(false);
            this.panel_NonMandatoryButton.ResumeLayout(false);
            this.panel_NonMandatoryButton.PerformLayout();
            this.panel_NonMandatoryFields.ResumeLayout(false);
            this.panel_NonMandatoryFields.PerformLayout();
            this.groupBox_taskMandatoryFields.ResumeLayout(false);
            this.groupBox_taskMandatoryFields.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
