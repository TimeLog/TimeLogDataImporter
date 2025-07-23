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
            components = new System.ComponentModel.Container();
            WorkerFetcher = new System.ComponentModel.BackgroundWorker();
            panel_recurringPaymentPlanAmountUpdateDataTable = new System.Windows.Forms.Panel();
            dataGridView_recurringPaymentPlanAmountUpdate = new System.Windows.Forms.DataGridView();
            panel_recurringPaymentPlanAmountUpdateMessage = new System.Windows.Forms.Panel();
            textBox_recurringPaymentPlanAmountUpdateImportMessages = new System.Windows.Forms.TextBox();
            panel_recurringPaymentPlanAmountUpdateButtons = new System.Windows.Forms.Panel();
            button_clear = new System.Windows.Forms.Button();
            button_import = new System.Windows.Forms.Button();
            button_validate = new System.Windows.Forms.Button();
            button_stop = new System.Windows.Forms.Button();
            panel_recurringPaymentPlanAmountUpdateFieldMapping = new System.Windows.Forms.Panel();
            flowLayoutPanel_nonMandatoryFields = new System.Windows.Forms.FlowLayoutPanel();
            panel_NonMandatoryButton = new System.Windows.Forms.Panel();
            label_nonMandatoryFields = new System.Windows.Forms.Label();
            button_expandNonMandatory = new System.Windows.Forms.Button();
            panel_NonMandatoryFields = new System.Windows.Forms.Panel();
            label_delimiter = new System.Windows.Forms.Label();
            comboBox_delimiter = new System.Windows.Forms.ComboBox();
            groupBox_recurringPaymentPlanAmountUpdateMandatoryFields = new System.Windows.Forms.GroupBox();
            label_recurringPaymentPlanAmountUpdatePaymentPlanAmount = new System.Windows.Forms.Label();
            comboBox_PaymentPlanAmount = new System.Windows.Forms.ComboBox();
            label_recurringPaymentPlanAmountUpdateContractName = new System.Windows.Forms.Label();
            comboBox_recurringPaymentPlanAmountUpdateContractName = new System.Windows.Forms.ComboBox();
            label_recurringPaymentPlanAmountUpdateProjectNo = new System.Windows.Forms.Label();
            comboBox_recurringPaymentPlanAmountUpdateProjectNo = new System.Windows.Forms.ComboBox();
            label_recurringPaymentPlanAmountUpdateSetup = new System.Windows.Forms.Label();
            button_recurringPaymentPlanAmountUpdateSelectFile = new System.Windows.Forms.Button();
            tmrExpand = new System.Windows.Forms.Timer(components);
            defaultToolTip = new System.Windows.Forms.ToolTip(components);
            panel_recurringPaymentPlanAmountUpdateDataTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_recurringPaymentPlanAmountUpdate).BeginInit();
            panel_recurringPaymentPlanAmountUpdateMessage.SuspendLayout();
            panel_recurringPaymentPlanAmountUpdateButtons.SuspendLayout();
            panel_recurringPaymentPlanAmountUpdateFieldMapping.SuspendLayout();
            flowLayoutPanel_nonMandatoryFields.SuspendLayout();
            panel_NonMandatoryButton.SuspendLayout();
            groupBox_recurringPaymentPlanAmountUpdateMandatoryFields.SuspendLayout();
            SuspendLayout();
            // 
            // WorkerFetcher
            // 
            WorkerFetcher.WorkerReportsProgress = true;
            WorkerFetcher.WorkerSupportsCancellation = true;
            WorkerFetcher.DoWork += WorkerFetcherDoWork;
            // 
            // panel_recurringPaymentPlanAmountUpdateDataTable
            // 
            panel_recurringPaymentPlanAmountUpdateDataTable.Controls.Add(dataGridView_recurringPaymentPlanAmountUpdate);
            panel_recurringPaymentPlanAmountUpdateDataTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_recurringPaymentPlanAmountUpdateDataTable.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel_recurringPaymentPlanAmountUpdateDataTable.Location = new System.Drawing.Point(0, 462);
            panel_recurringPaymentPlanAmountUpdateDataTable.Name = "panel_recurringPaymentPlanAmountUpdateDataTable";
            panel_recurringPaymentPlanAmountUpdateDataTable.Size = new System.Drawing.Size(1006, 180);
            panel_recurringPaymentPlanAmountUpdateDataTable.TabIndex = 6;
            // 
            // dataGridView_recurringPaymentPlanAmountUpdate
            // 
            dataGridView_recurringPaymentPlanAmountUpdate.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridView_recurringPaymentPlanAmountUpdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridView_recurringPaymentPlanAmountUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_recurringPaymentPlanAmountUpdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            dataGridView_recurringPaymentPlanAmountUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridView_recurringPaymentPlanAmountUpdate.Location = new System.Drawing.Point(0, 0);
            dataGridView_recurringPaymentPlanAmountUpdate.Name = "dataGridView_recurringPaymentPlanAmountUpdate";
            dataGridView_recurringPaymentPlanAmountUpdate.RowHeadersWidth = 62;
            dataGridView_recurringPaymentPlanAmountUpdate.Size = new System.Drawing.Size(1006, 180);
            dataGridView_recurringPaymentPlanAmountUpdate.TabIndex = 0;
            // 
            // panel_recurringPaymentPlanAmountUpdateMessage
            // 
            panel_recurringPaymentPlanAmountUpdateMessage.Controls.Add(textBox_recurringPaymentPlanAmountUpdateImportMessages);
            panel_recurringPaymentPlanAmountUpdateMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_recurringPaymentPlanAmountUpdateMessage.Location = new System.Drawing.Point(0, 278);
            panel_recurringPaymentPlanAmountUpdateMessage.Name = "panel_recurringPaymentPlanAmountUpdateMessage";
            panel_recurringPaymentPlanAmountUpdateMessage.Size = new System.Drawing.Size(1006, 184);
            panel_recurringPaymentPlanAmountUpdateMessage.TabIndex = 10;
            // 
            // textBox_recurringPaymentPlanAmountUpdateImportMessages
            // 
            textBox_recurringPaymentPlanAmountUpdateImportMessages.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            textBox_recurringPaymentPlanAmountUpdateImportMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox_recurringPaymentPlanAmountUpdateImportMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            textBox_recurringPaymentPlanAmountUpdateImportMessages.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            textBox_recurringPaymentPlanAmountUpdateImportMessages.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            textBox_recurringPaymentPlanAmountUpdateImportMessages.Location = new System.Drawing.Point(0, 0);
            textBox_recurringPaymentPlanAmountUpdateImportMessages.Multiline = true;
            textBox_recurringPaymentPlanAmountUpdateImportMessages.Name = "textBox_recurringPaymentPlanAmountUpdateImportMessages";
            textBox_recurringPaymentPlanAmountUpdateImportMessages.ReadOnly = true;
            textBox_recurringPaymentPlanAmountUpdateImportMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBox_recurringPaymentPlanAmountUpdateImportMessages.Size = new System.Drawing.Size(1006, 184);
            textBox_recurringPaymentPlanAmountUpdateImportMessages.TabIndex = 0;
            defaultToolTip.SetToolTip(textBox_recurringPaymentPlanAmountUpdateImportMessages, "Validation or import status");
            textBox_recurringPaymentPlanAmountUpdateImportMessages.WordWrap = false;
            textBox_recurringPaymentPlanAmountUpdateImportMessages.MouseClick += textBox_recurringPaymentPlanAmountUpdateImportMessages_MouseClick;
            // 
            // panel_recurringPaymentPlanAmountUpdateButtons
            // 
            panel_recurringPaymentPlanAmountUpdateButtons.Controls.Add(button_clear);
            panel_recurringPaymentPlanAmountUpdateButtons.Controls.Add(button_import);
            panel_recurringPaymentPlanAmountUpdateButtons.Controls.Add(button_validate);
            panel_recurringPaymentPlanAmountUpdateButtons.Controls.Add(button_stop);
            panel_recurringPaymentPlanAmountUpdateButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_recurringPaymentPlanAmountUpdateButtons.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            panel_recurringPaymentPlanAmountUpdateButtons.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel_recurringPaymentPlanAmountUpdateButtons.Location = new System.Drawing.Point(0, 226);
            panel_recurringPaymentPlanAmountUpdateButtons.Name = "panel_recurringPaymentPlanAmountUpdateButtons";
            panel_recurringPaymentPlanAmountUpdateButtons.Size = new System.Drawing.Size(1006, 52);
            panel_recurringPaymentPlanAmountUpdateButtons.TabIndex = 12;
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
            defaultToolTip.SetToolTip(button_clear, "Reset all file input above and data table below");
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
            // panel_recurringPaymentPlanAmountUpdateFieldMapping
            // 
            panel_recurringPaymentPlanAmountUpdateFieldMapping.AutoScroll = true;
            panel_recurringPaymentPlanAmountUpdateFieldMapping.Controls.Add(flowLayoutPanel_nonMandatoryFields);
            panel_recurringPaymentPlanAmountUpdateFieldMapping.Controls.Add(label_delimiter);
            panel_recurringPaymentPlanAmountUpdateFieldMapping.Controls.Add(comboBox_delimiter);
            panel_recurringPaymentPlanAmountUpdateFieldMapping.Controls.Add(groupBox_recurringPaymentPlanAmountUpdateMandatoryFields);
            panel_recurringPaymentPlanAmountUpdateFieldMapping.Controls.Add(label_recurringPaymentPlanAmountUpdateSetup);
            panel_recurringPaymentPlanAmountUpdateFieldMapping.Controls.Add(button_recurringPaymentPlanAmountUpdateSelectFile);
            panel_recurringPaymentPlanAmountUpdateFieldMapping.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_recurringPaymentPlanAmountUpdateFieldMapping.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            panel_recurringPaymentPlanAmountUpdateFieldMapping.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel_recurringPaymentPlanAmountUpdateFieldMapping.Location = new System.Drawing.Point(0, 0);
            panel_recurringPaymentPlanAmountUpdateFieldMapping.Name = "panel_recurringPaymentPlanAmountUpdateFieldMapping";
            panel_recurringPaymentPlanAmountUpdateFieldMapping.Size = new System.Drawing.Size(1006, 226);
            panel_recurringPaymentPlanAmountUpdateFieldMapping.TabIndex = 13;
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
            panel_NonMandatoryFields.Location = new System.Drawing.Point(3, 41);
            panel_NonMandatoryFields.MaximumSize = new System.Drawing.Size(363, 163);
            panel_NonMandatoryFields.MinimumSize = new System.Drawing.Size(363, 0);
            panel_NonMandatoryFields.Name = "panel_NonMandatoryFields";
            panel_NonMandatoryFields.Size = new System.Drawing.Size(363, 109);
            panel_NonMandatoryFields.TabIndex = 1;
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
            // groupBox_recurringPaymentPlanAmountUpdateMandatoryFields
            // 
            groupBox_recurringPaymentPlanAmountUpdateMandatoryFields.Controls.Add(label_recurringPaymentPlanAmountUpdatePaymentPlanAmount);
            groupBox_recurringPaymentPlanAmountUpdateMandatoryFields.Controls.Add(comboBox_PaymentPlanAmount);
            groupBox_recurringPaymentPlanAmountUpdateMandatoryFields.Controls.Add(label_recurringPaymentPlanAmountUpdateContractName);
            groupBox_recurringPaymentPlanAmountUpdateMandatoryFields.Controls.Add(comboBox_recurringPaymentPlanAmountUpdateContractName);
            groupBox_recurringPaymentPlanAmountUpdateMandatoryFields.Controls.Add(label_recurringPaymentPlanAmountUpdateProjectNo);
            groupBox_recurringPaymentPlanAmountUpdateMandatoryFields.Controls.Add(comboBox_recurringPaymentPlanAmountUpdateProjectNo);
            groupBox_recurringPaymentPlanAmountUpdateMandatoryFields.Location = new System.Drawing.Point(184, 62);
            groupBox_recurringPaymentPlanAmountUpdateMandatoryFields.Name = "groupBox_recurringPaymentPlanAmountUpdateMandatoryFields";
            groupBox_recurringPaymentPlanAmountUpdateMandatoryFields.Size = new System.Drawing.Size(358, 158);
            groupBox_recurringPaymentPlanAmountUpdateMandatoryFields.TabIndex = 5;
            groupBox_recurringPaymentPlanAmountUpdateMandatoryFields.TabStop = false;
            groupBox_recurringPaymentPlanAmountUpdateMandatoryFields.Text = "Mandatory";
            // 
            // label_recurringPaymentPlanAmountUpdatePaymentPlanAmount
            // 
            label_recurringPaymentPlanAmountUpdatePaymentPlanAmount.AutoSize = true;
            label_recurringPaymentPlanAmountUpdatePaymentPlanAmount.Location = new System.Drawing.Point(6, 122);
            label_recurringPaymentPlanAmountUpdatePaymentPlanAmount.Name = "label_recurringPaymentPlanAmountUpdatePaymentPlanAmount";
            label_recurringPaymentPlanAmountUpdatePaymentPlanAmount.Size = new System.Drawing.Size(146, 17);
            label_recurringPaymentPlanAmountUpdatePaymentPlanAmount.TabIndex = 15;
            label_recurringPaymentPlanAmountUpdatePaymentPlanAmount.Text = "Payment Plan Amount";
            // 
            // comboBox_PaymentPlanAmount
            // 
            comboBox_PaymentPlanAmount.FormattingEnabled = true;
            comboBox_PaymentPlanAmount.Location = new System.Drawing.Point(163, 119);
            comboBox_PaymentPlanAmount.Name = "comboBox_PaymentPlanAmount";
            comboBox_PaymentPlanAmount.Size = new System.Drawing.Size(139, 25);
            comboBox_PaymentPlanAmount.TabIndex = 16;
            // 
            // label_recurringPaymentPlanAmountUpdateContractName
            // 
            label_recurringPaymentPlanAmountUpdateContractName.AutoSize = true;
            label_recurringPaymentPlanAmountUpdateContractName.Location = new System.Drawing.Point(6, 89);
            label_recurringPaymentPlanAmountUpdateContractName.Name = "label_recurringPaymentPlanAmountUpdateContractName";
            label_recurringPaymentPlanAmountUpdateContractName.Size = new System.Drawing.Size(100, 17);
            label_recurringPaymentPlanAmountUpdateContractName.TabIndex = 1;
            label_recurringPaymentPlanAmountUpdateContractName.Text = "Contract Name";
            // 
            // comboBox_recurringPaymentPlanAmountUpdateContractName
            // 
            comboBox_recurringPaymentPlanAmountUpdateContractName.FormattingEnabled = true;
            comboBox_recurringPaymentPlanAmountUpdateContractName.Location = new System.Drawing.Point(163, 86);
            comboBox_recurringPaymentPlanAmountUpdateContractName.Name = "comboBox_recurringPaymentPlanAmountUpdateContractName";
            comboBox_recurringPaymentPlanAmountUpdateContractName.Size = new System.Drawing.Size(139, 25);
            comboBox_recurringPaymentPlanAmountUpdateContractName.TabIndex = 3;
            // 
            // label_recurringPaymentPlanAmountUpdateProjectNo
            // 
            label_recurringPaymentPlanAmountUpdateProjectNo.AutoSize = true;
            label_recurringPaymentPlanAmountUpdateProjectNo.Location = new System.Drawing.Point(6, 58);
            label_recurringPaymentPlanAmountUpdateProjectNo.Name = "label_recurringPaymentPlanAmountUpdateProjectNo";
            label_recurringPaymentPlanAmountUpdateProjectNo.Size = new System.Drawing.Size(72, 17);
            label_recurringPaymentPlanAmountUpdateProjectNo.TabIndex = 1;
            label_recurringPaymentPlanAmountUpdateProjectNo.Text = "Project No";
            // 
            // comboBox_recurringPaymentPlanAmountUpdateProjectNo
            // 
            comboBox_recurringPaymentPlanAmountUpdateProjectNo.FormattingEnabled = true;
            comboBox_recurringPaymentPlanAmountUpdateProjectNo.Location = new System.Drawing.Point(163, 55);
            comboBox_recurringPaymentPlanAmountUpdateProjectNo.Name = "comboBox_recurringPaymentPlanAmountUpdateProjectNo";
            comboBox_recurringPaymentPlanAmountUpdateProjectNo.Size = new System.Drawing.Size(139, 25);
            comboBox_recurringPaymentPlanAmountUpdateProjectNo.TabIndex = 3;
            // 
            // label_recurringPaymentPlanAmountUpdateSetup
            // 
            label_recurringPaymentPlanAmountUpdateSetup.AutoSize = true;
            label_recurringPaymentPlanAmountUpdateSetup.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            label_recurringPaymentPlanAmountUpdateSetup.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            label_recurringPaymentPlanAmountUpdateSetup.Location = new System.Drawing.Point(7, 16);
            label_recurringPaymentPlanAmountUpdateSetup.Name = "label_recurringPaymentPlanAmountUpdateSetup";
            label_recurringPaymentPlanAmountUpdateSetup.Size = new System.Drawing.Size(515, 32);
            label_recurringPaymentPlanAmountUpdateSetup.TabIndex = 0;
            label_recurringPaymentPlanAmountUpdateSetup.Text = "Recurring Payment Plan Amount Data Update";
            label_recurringPaymentPlanAmountUpdateSetup.Click += label_recurringPaymentPlanAmountSetup_Click;
            // 
            // button_recurringPaymentPlanAmountUpdateSelectFile
            // 
            button_recurringPaymentPlanAmountUpdateSelectFile.BackColor = System.Drawing.Color.FromArgb(226, 43, 141);
            button_recurringPaymentPlanAmountUpdateSelectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            button_recurringPaymentPlanAmountUpdateSelectFile.FlatAppearance.BorderSize = 0;
            button_recurringPaymentPlanAmountUpdateSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_recurringPaymentPlanAmountUpdateSelectFile.ForeColor = System.Drawing.Color.White;
            button_recurringPaymentPlanAmountUpdateSelectFile.Location = new System.Drawing.Point(13, 111);
            button_recurringPaymentPlanAmountUpdateSelectFile.Name = "button_recurringPaymentPlanAmountUpdateSelectFile";
            button_recurringPaymentPlanAmountUpdateSelectFile.Size = new System.Drawing.Size(80, 29);
            button_recurringPaymentPlanAmountUpdateSelectFile.TabIndex = 4;
            button_recurringPaymentPlanAmountUpdateSelectFile.Text = "Select File";
            defaultToolTip.SetToolTip(button_recurringPaymentPlanAmountUpdateSelectFile, "Select input CSV file");
            button_recurringPaymentPlanAmountUpdateSelectFile.UseVisualStyleBackColor = false;
            button_recurringPaymentPlanAmountUpdateSelectFile.Click += button_select_recurringPaymentPlanAmountUpdate_file_Click;
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
            // UserControl_RecurringPaymentPlanUpdate
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel_recurringPaymentPlanAmountUpdateFieldMapping);
            Controls.Add(panel_recurringPaymentPlanAmountUpdateButtons);
            Controls.Add(panel_recurringPaymentPlanAmountUpdateMessage);
            Controls.Add(panel_recurringPaymentPlanAmountUpdateDataTable);
            Name = "UserControl_RecurringPaymentPlanUpdate";
            Size = new System.Drawing.Size(1006, 642);
            Load += UserControl1_Load;
            panel_recurringPaymentPlanAmountUpdateDataTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_recurringPaymentPlanAmountUpdate).EndInit();
            panel_recurringPaymentPlanAmountUpdateMessage.ResumeLayout(false);
            panel_recurringPaymentPlanAmountUpdateMessage.PerformLayout();
            panel_recurringPaymentPlanAmountUpdateButtons.ResumeLayout(false);
            panel_recurringPaymentPlanAmountUpdateFieldMapping.ResumeLayout(false);
            panel_recurringPaymentPlanAmountUpdateFieldMapping.PerformLayout();
            flowLayoutPanel_nonMandatoryFields.ResumeLayout(false);
            panel_NonMandatoryButton.ResumeLayout(false);
            panel_NonMandatoryButton.PerformLayout();
            groupBox_recurringPaymentPlanAmountUpdateMandatoryFields.ResumeLayout(false);
            groupBox_recurringPaymentPlanAmountUpdateMandatoryFields.PerformLayout();
            ResumeLayout(false);

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
