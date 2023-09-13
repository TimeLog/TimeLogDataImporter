namespace TimeLog.DataImporter.UserControls
{
    partial class UserControl_RecurringPaymentPlanUpdate
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
            this.panel_recurringPaymentPlanAmountUpdateDataTable = new System.Windows.Forms.Panel();
            this.dataGridView_recurringPaymentPlanAmountUpdate = new System.Windows.Forms.DataGridView();
            this.panel_recurringPaymentPlanAmountUpdateMessage = new System.Windows.Forms.Panel();
            this.textBox_recurringPaymentPlanAmountUpdateImportMessages = new System.Windows.Forms.TextBox();
            this.panel_recurringPaymentPlanAmountUpdateButtons = new System.Windows.Forms.Panel();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_import = new System.Windows.Forms.Button();
            this.button_validate = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.panel_recurringPaymentPlanAmountUpdateFieldMapping = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_nonMandatoryFields = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_NonMandatoryButton = new System.Windows.Forms.Panel();
            this.label_nonMandatoryFields = new System.Windows.Forms.Label();
            this.button_expandNonMandatory = new System.Windows.Forms.Button();
            this.panel_NonMandatoryFields = new System.Windows.Forms.Panel();
            this.label_delimiter = new System.Windows.Forms.Label();
            this.comboBox_delimiter = new System.Windows.Forms.ComboBox();
            this.groupBox_recurringPaymentPlanAmountUpdateMandatoryFields = new System.Windows.Forms.GroupBox();
            this.label_recurringPaymentPlanAmountUpdatePaymentPlanAmount = new System.Windows.Forms.Label();
            this.comboBox_PaymentPlanAmount = new System.Windows.Forms.ComboBox();
            this.label_recurringPaymentPlanAmountUpdateContractName = new System.Windows.Forms.Label();
            this.comboBox_recurringPaymentPlanAmountUpdateContractName = new System.Windows.Forms.ComboBox();
            this.label_recurringPaymentPlanAmountUpdateProjectNo = new System.Windows.Forms.Label();
            this.comboBox_recurringPaymentPlanAmountUpdateProjectNo = new System.Windows.Forms.ComboBox();
            this.label_recurringPaymentPlanAmountUpdateSetup = new System.Windows.Forms.Label();
            this.button_recurringPaymentPlanAmountUpdateSelectFile = new System.Windows.Forms.Button();
            this.tmrExpand = new System.Windows.Forms.Timer(this.components);
            this.defaultToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel_recurringPaymentPlanAmountUpdateDataTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_recurringPaymentPlanAmountUpdate)).BeginInit();
            this.panel_recurringPaymentPlanAmountUpdateMessage.SuspendLayout();
            this.panel_recurringPaymentPlanAmountUpdateButtons.SuspendLayout();
            this.panel_recurringPaymentPlanAmountUpdateFieldMapping.SuspendLayout();
            this.flowLayoutPanel_nonMandatoryFields.SuspendLayout();
            this.panel_NonMandatoryButton.SuspendLayout();
            this.groupBox_recurringPaymentPlanAmountUpdateMandatoryFields.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkerFetcher
            // 
            this.WorkerFetcher.WorkerReportsProgress = true;
            this.WorkerFetcher.WorkerSupportsCancellation = true;
            this.WorkerFetcher.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WorkerFetcherDoWork);
            // 
            // panel_recurringPaymentPlanAmountUpdateDataTable
            // 
            this.panel_recurringPaymentPlanAmountUpdateDataTable.Controls.Add(this.dataGridView_recurringPaymentPlanAmountUpdate);
            this.panel_recurringPaymentPlanAmountUpdateDataTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_recurringPaymentPlanAmountUpdateDataTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_recurringPaymentPlanAmountUpdateDataTable.Location = new System.Drawing.Point(0, 462);
            this.panel_recurringPaymentPlanAmountUpdateDataTable.Name = "panel_recurringPaymentPlanAmountUpdateDataTable";
            this.panel_recurringPaymentPlanAmountUpdateDataTable.Size = new System.Drawing.Size(1006, 180);
            this.panel_recurringPaymentPlanAmountUpdateDataTable.TabIndex = 6;
            // 
            // dataGridView_recurringPaymentPlanAmountUpdate
            // 
            this.dataGridView_recurringPaymentPlanAmountUpdate.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView_recurringPaymentPlanAmountUpdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_recurringPaymentPlanAmountUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_recurringPaymentPlanAmountUpdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_recurringPaymentPlanAmountUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dataGridView_recurringPaymentPlanAmountUpdate.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_recurringPaymentPlanAmountUpdate.Name = "dataGridView_recurringPaymentPlanAmountUpdate";
            this.dataGridView_recurringPaymentPlanAmountUpdate.RowHeadersWidth = 62;
            this.dataGridView_recurringPaymentPlanAmountUpdate.Size = new System.Drawing.Size(1006, 180);
            this.dataGridView_recurringPaymentPlanAmountUpdate.TabIndex = 0;
            // 
            // panel_recurringPaymentPlanAmountUpdateMessage
            // 
            this.panel_recurringPaymentPlanAmountUpdateMessage.Controls.Add(this.textBox_recurringPaymentPlanAmountUpdateImportMessages);
            this.panel_recurringPaymentPlanAmountUpdateMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_recurringPaymentPlanAmountUpdateMessage.Location = new System.Drawing.Point(0, 278);
            this.panel_recurringPaymentPlanAmountUpdateMessage.Name = "panel_recurringPaymentPlanAmountUpdateMessage";
            this.panel_recurringPaymentPlanAmountUpdateMessage.Size = new System.Drawing.Size(1006, 184);
            this.panel_recurringPaymentPlanAmountUpdateMessage.TabIndex = 10;
            // 
            // textBox_recurringPaymentPlanAmountUpdateImportMessages
            // 
            this.textBox_recurringPaymentPlanAmountUpdateImportMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_recurringPaymentPlanAmountUpdateImportMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_recurringPaymentPlanAmountUpdateImportMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_recurringPaymentPlanAmountUpdateImportMessages.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_recurringPaymentPlanAmountUpdateImportMessages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_recurringPaymentPlanAmountUpdateImportMessages.Location = new System.Drawing.Point(0, 0);
            this.textBox_recurringPaymentPlanAmountUpdateImportMessages.Multiline = true;
            this.textBox_recurringPaymentPlanAmountUpdateImportMessages.Name = "textBox_recurringPaymentPlanAmountUpdateImportMessages";
            this.textBox_recurringPaymentPlanAmountUpdateImportMessages.ReadOnly = true;
            this.textBox_recurringPaymentPlanAmountUpdateImportMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_recurringPaymentPlanAmountUpdateImportMessages.Size = new System.Drawing.Size(1006, 184);
            this.textBox_recurringPaymentPlanAmountUpdateImportMessages.TabIndex = 0;
            this.defaultToolTip.SetToolTip(this.textBox_recurringPaymentPlanAmountUpdateImportMessages, "Validation or import status");
            this.textBox_recurringPaymentPlanAmountUpdateImportMessages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_recurringPaymentPlanAmountUpdateImportMessages_MouseClick);
            // 
            // panel_recurringPaymentPlanAmountUpdateButtons
            // 
            this.panel_recurringPaymentPlanAmountUpdateButtons.Controls.Add(this.button_clear);
            this.panel_recurringPaymentPlanAmountUpdateButtons.Controls.Add(this.button_import);
            this.panel_recurringPaymentPlanAmountUpdateButtons.Controls.Add(this.button_validate);
            this.panel_recurringPaymentPlanAmountUpdateButtons.Controls.Add(this.button_stop);
            this.panel_recurringPaymentPlanAmountUpdateButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_recurringPaymentPlanAmountUpdateButtons.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel_recurringPaymentPlanAmountUpdateButtons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_recurringPaymentPlanAmountUpdateButtons.Location = new System.Drawing.Point(0, 226);
            this.panel_recurringPaymentPlanAmountUpdateButtons.Name = "panel_recurringPaymentPlanAmountUpdateButtons";
            this.panel_recurringPaymentPlanAmountUpdateButtons.Size = new System.Drawing.Size(1006, 52);
            this.panel_recurringPaymentPlanAmountUpdateButtons.TabIndex = 12;
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
            // panel_recurringPaymentPlanAmountUpdateFieldMapping
            // 
            this.panel_recurringPaymentPlanAmountUpdateFieldMapping.AutoScroll = true;
            this.panel_recurringPaymentPlanAmountUpdateFieldMapping.Controls.Add(this.flowLayoutPanel_nonMandatoryFields);
            this.panel_recurringPaymentPlanAmountUpdateFieldMapping.Controls.Add(this.label_delimiter);
            this.panel_recurringPaymentPlanAmountUpdateFieldMapping.Controls.Add(this.comboBox_delimiter);
            this.panel_recurringPaymentPlanAmountUpdateFieldMapping.Controls.Add(this.groupBox_recurringPaymentPlanAmountUpdateMandatoryFields);
            this.panel_recurringPaymentPlanAmountUpdateFieldMapping.Controls.Add(this.label_recurringPaymentPlanAmountUpdateSetup);
            this.panel_recurringPaymentPlanAmountUpdateFieldMapping.Controls.Add(this.button_recurringPaymentPlanAmountUpdateSelectFile);
            this.panel_recurringPaymentPlanAmountUpdateFieldMapping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_recurringPaymentPlanAmountUpdateFieldMapping.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel_recurringPaymentPlanAmountUpdateFieldMapping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_recurringPaymentPlanAmountUpdateFieldMapping.Location = new System.Drawing.Point(0, 0);
            this.panel_recurringPaymentPlanAmountUpdateFieldMapping.Name = "panel_recurringPaymentPlanAmountUpdateFieldMapping";
            this.panel_recurringPaymentPlanAmountUpdateFieldMapping.Size = new System.Drawing.Size(1006, 226);
            this.panel_recurringPaymentPlanAmountUpdateFieldMapping.TabIndex = 13;
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
            // groupBox_recurringPaymentPlanAmountUpdateMandatoryFields
            // 
            this.groupBox_recurringPaymentPlanAmountUpdateMandatoryFields.Controls.Add(this.label_recurringPaymentPlanAmountUpdatePaymentPlanAmount);
            this.groupBox_recurringPaymentPlanAmountUpdateMandatoryFields.Controls.Add(this.comboBox_PaymentPlanAmount);
            this.groupBox_recurringPaymentPlanAmountUpdateMandatoryFields.Controls.Add(this.label_recurringPaymentPlanAmountUpdateContractName);
            this.groupBox_recurringPaymentPlanAmountUpdateMandatoryFields.Controls.Add(this.comboBox_recurringPaymentPlanAmountUpdateContractName);
            this.groupBox_recurringPaymentPlanAmountUpdateMandatoryFields.Controls.Add(this.label_recurringPaymentPlanAmountUpdateProjectNo);
            this.groupBox_recurringPaymentPlanAmountUpdateMandatoryFields.Controls.Add(this.comboBox_recurringPaymentPlanAmountUpdateProjectNo);
            this.groupBox_recurringPaymentPlanAmountUpdateMandatoryFields.Location = new System.Drawing.Point(184, 62);
            this.groupBox_recurringPaymentPlanAmountUpdateMandatoryFields.Name = "groupBox_recurringPaymentPlanAmountUpdateMandatoryFields";
            this.groupBox_recurringPaymentPlanAmountUpdateMandatoryFields.Size = new System.Drawing.Size(358, 399);
            this.groupBox_recurringPaymentPlanAmountUpdateMandatoryFields.TabIndex = 5;
            this.groupBox_recurringPaymentPlanAmountUpdateMandatoryFields.TabStop = false;
            this.groupBox_recurringPaymentPlanAmountUpdateMandatoryFields.Text = "Mandatory";
            // 
            // label_recurringPaymentPlanAmountUpdatePaymentPlanAmount
            // 
            this.label_recurringPaymentPlanAmountUpdatePaymentPlanAmount.AutoSize = true;
            this.label_recurringPaymentPlanAmountUpdatePaymentPlanAmount.Location = new System.Drawing.Point(6, 122);
            this.label_recurringPaymentPlanAmountUpdatePaymentPlanAmount.Name = "label_recurringPaymentPlanAmountUpdatePaymentPlanAmount";
            this.label_recurringPaymentPlanAmountUpdatePaymentPlanAmount.Size = new System.Drawing.Size(146, 17);
            this.label_recurringPaymentPlanAmountUpdatePaymentPlanAmount.TabIndex = 15;
            this.label_recurringPaymentPlanAmountUpdatePaymentPlanAmount.Text = "Payment Plan Amount";
            // 
            // comboBox_PaymentPlanAmount
            // 
            this.comboBox_PaymentPlanAmount.FormattingEnabled = true;
            this.comboBox_PaymentPlanAmount.Location = new System.Drawing.Point(138, 119);
            this.comboBox_PaymentPlanAmount.Name = "comboBox_PaymentPlanAmount";
            this.comboBox_PaymentPlanAmount.Size = new System.Drawing.Size(139, 25);
            this.comboBox_PaymentPlanAmount.TabIndex = 16;
            // 
            // label_recurringPaymentPlanAmountUpdateContractName
            // 
            this.label_recurringPaymentPlanAmountUpdateContractName.AutoSize = true;
            this.label_recurringPaymentPlanAmountUpdateContractName.Location = new System.Drawing.Point(6, 89);
            this.label_recurringPaymentPlanAmountUpdateContractName.Name = "label_recurringPaymentPlanAmountUpdateContractName";
            this.label_recurringPaymentPlanAmountUpdateContractName.Size = new System.Drawing.Size(100, 17);
            this.label_recurringPaymentPlanAmountUpdateContractName.TabIndex = 1;
            this.label_recurringPaymentPlanAmountUpdateContractName.Text = "Contract Name";
            // 
            // comboBox_recurringPaymentPlanAmountUpdateContractName
            // 
            this.comboBox_recurringPaymentPlanAmountUpdateContractName.FormattingEnabled = true;
            this.comboBox_recurringPaymentPlanAmountUpdateContractName.Location = new System.Drawing.Point(138, 86);
            this.comboBox_recurringPaymentPlanAmountUpdateContractName.Name = "comboBox_recurringPaymentPlanAmountUpdateContractName";
            this.comboBox_recurringPaymentPlanAmountUpdateContractName.Size = new System.Drawing.Size(139, 25);
            this.comboBox_recurringPaymentPlanAmountUpdateContractName.TabIndex = 3;
            // 
            // label_recurringPaymentPlanAmountUpdateProjectNo
            // 
            this.label_recurringPaymentPlanAmountUpdateProjectNo.AutoSize = true;
            this.label_recurringPaymentPlanAmountUpdateProjectNo.Location = new System.Drawing.Point(6, 58);
            this.label_recurringPaymentPlanAmountUpdateProjectNo.Name = "label_recurringPaymentPlanAmountUpdateProjectNo";
            this.label_recurringPaymentPlanAmountUpdateProjectNo.Size = new System.Drawing.Size(72, 17);
            this.label_recurringPaymentPlanAmountUpdateProjectNo.TabIndex = 1;
            this.label_recurringPaymentPlanAmountUpdateProjectNo.Text = "Project No";
            // 
            // comboBox_recurringPaymentPlanAmountUpdateProjectNo
            // 
            this.comboBox_recurringPaymentPlanAmountUpdateProjectNo.FormattingEnabled = true;
            this.comboBox_recurringPaymentPlanAmountUpdateProjectNo.Location = new System.Drawing.Point(138, 55);
            this.comboBox_recurringPaymentPlanAmountUpdateProjectNo.Name = "comboBox_recurringPaymentPlanAmountUpdateProjectNo";
            this.comboBox_recurringPaymentPlanAmountUpdateProjectNo.Size = new System.Drawing.Size(139, 25);
            this.comboBox_recurringPaymentPlanAmountUpdateProjectNo.TabIndex = 3;
            // 
            // label_recurringPaymentPlanAmountUpdateSetup
            // 
            this.label_recurringPaymentPlanAmountUpdateSetup.AutoSize = true;
            this.label_recurringPaymentPlanAmountUpdateSetup.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_recurringPaymentPlanAmountUpdateSetup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_recurringPaymentPlanAmountUpdateSetup.Location = new System.Drawing.Point(7, 16);
            this.label_recurringPaymentPlanAmountUpdateSetup.Name = "label_recurringPaymentPlanAmountUpdateSetup";
            this.label_recurringPaymentPlanAmountUpdateSetup.Size = new System.Drawing.Size(334, 32);
            this.label_recurringPaymentPlanAmountUpdateSetup.TabIndex = 0;
            this.label_recurringPaymentPlanAmountUpdateSetup.Text = "Recurring Payment Plan Amount Data Update";
            this.label_recurringPaymentPlanAmountUpdateSetup.Click += new System.EventHandler(this.label_recurringPaymentPlanAmountSetup_Click);
            // 
            // button_recurringPaymentPlanAmountUpdateSelectFile
            // 
            this.button_recurringPaymentPlanAmountUpdateSelectFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(43)))), ((int)(((byte)(141)))));
            this.button_recurringPaymentPlanAmountUpdateSelectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_recurringPaymentPlanAmountUpdateSelectFile.FlatAppearance.BorderSize = 0;
            this.button_recurringPaymentPlanAmountUpdateSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_recurringPaymentPlanAmountUpdateSelectFile.ForeColor = System.Drawing.Color.White;
            this.button_recurringPaymentPlanAmountUpdateSelectFile.Location = new System.Drawing.Point(13, 111);
            this.button_recurringPaymentPlanAmountUpdateSelectFile.Name = "button_recurringPaymentPlanAmountUpdateSelectFile";
            this.button_recurringPaymentPlanAmountUpdateSelectFile.Size = new System.Drawing.Size(80, 29);
            this.button_recurringPaymentPlanAmountUpdateSelectFile.TabIndex = 4;
            this.button_recurringPaymentPlanAmountUpdateSelectFile.Text = "Select File";
            this.defaultToolTip.SetToolTip(this.button_recurringPaymentPlanAmountUpdateSelectFile, "Select input CSV file");
            this.button_recurringPaymentPlanAmountUpdateSelectFile.UseVisualStyleBackColor = false;
            this.button_recurringPaymentPlanAmountUpdateSelectFile.Click += new System.EventHandler(this.button_select_recurringPaymentPlanAmountUpdate_file_Click);
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
            // UserControl_RecurringPaymentPlanUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_recurringPaymentPlanAmountUpdateFieldMapping);
            this.Controls.Add(this.panel_recurringPaymentPlanAmountUpdateButtons);
            this.Controls.Add(this.panel_recurringPaymentPlanAmountUpdateMessage);
            this.Controls.Add(this.panel_recurringPaymentPlanAmountUpdateDataTable);
            this.Name = "UserControl_RecurringPaymentPlanUpdate";
            this.Size = new System.Drawing.Size(1006, 642);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.panel_recurringPaymentPlanAmountUpdateDataTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_recurringPaymentPlanAmountUpdate)).EndInit();
            this.panel_recurringPaymentPlanAmountUpdateMessage.ResumeLayout(false);
            this.panel_recurringPaymentPlanAmountUpdateMessage.PerformLayout();
            this.panel_recurringPaymentPlanAmountUpdateButtons.ResumeLayout(false);
            this.panel_recurringPaymentPlanAmountUpdateFieldMapping.ResumeLayout(false);
            this.panel_recurringPaymentPlanAmountUpdateFieldMapping.PerformLayout();
            this.flowLayoutPanel_nonMandatoryFields.ResumeLayout(false);
            this.panel_NonMandatoryButton.ResumeLayout(false);
            this.panel_NonMandatoryButton.PerformLayout();
            this.groupBox_recurringPaymentPlanAmountUpdateMandatoryFields.ResumeLayout(false);
            this.groupBox_recurringPaymentPlanAmountUpdateMandatoryFields.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private void AddRowNumberToDataTable()
        {
            this.dataGridView_recurringPaymentPlanAmountUpdate.DataBindingComplete += (o, e) =>
            {
                foreach (System.Windows.Forms.DataGridViewRow row in dataGridView_recurringPaymentPlanAmountUpdate.Rows)
                {
                    row.HeaderCell.Value = (row.Index + 1).ToString();

                }
            };
            this.dataGridView_recurringPaymentPlanAmountUpdate.RowHeadersWidth = 65;
        }


        private System.ComponentModel.BackgroundWorker WorkerFetcher;
        private System.Windows.Forms.Panel panel_recurringPaymentPlanAmountUpdateDataTable;
        private System.Windows.Forms.DataGridView dataGridView_recurringPaymentPlanAmountUpdate;
        private System.Windows.Forms.Panel panel_recurringPaymentPlanAmountUpdateMessage;
        private System.Windows.Forms.Panel panel_recurringPaymentPlanAmountUpdateButtons;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_import;
        private System.Windows.Forms.Button button_validate;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Panel panel_recurringPaymentPlanAmountUpdateFieldMapping;
        private System.Windows.Forms.GroupBox groupBox_recurringPaymentPlanAmountUpdateMandatoryFields;
        private System.Windows.Forms.Label label_recurringPaymentPlanAmountUpdateSetup;
        private System.Windows.Forms.Button button_recurringPaymentPlanAmountUpdateSelectFile;
        private System.Windows.Forms.TextBox textBox_recurringPaymentPlanAmountUpdateImportMessages;
        private System.Windows.Forms.Label label_recurringPaymentPlanAmountUpdateContractName;
        private System.Windows.Forms.ComboBox comboBox_recurringPaymentPlanAmountUpdateContractName;
        private System.Windows.Forms.Label label_recurringPaymentPlanAmountUpdateProjectNo;
        private System.Windows.Forms.ComboBox comboBox_recurringPaymentPlanAmountUpdateProjectNo;
        private System.Windows.Forms.Label label_recurringPaymentPlanAmountUpdatePaymentPlanAmount;
        private System.Windows.Forms.ComboBox comboBox_PaymentPlanAmount;

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
