namespace TimeLog.DataImporter.UserControls
{
    partial class UserControl_PaymentImport
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
            this.panel_paymentDataTable = new System.Windows.Forms.Panel();
            this.dataGridView_payment = new System.Windows.Forms.DataGridView();
            this.panel_paymentMessage = new System.Windows.Forms.Panel();
            this.textBox_paymentImportMessages = new System.Windows.Forms.TextBox();
            this.panel_paymentButtons = new System.Windows.Forms.Panel();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_import = new System.Windows.Forms.Button();
            this.button_validate = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.panel_paymentFieldMapping = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_nonMandatoryFields = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_NonMandatoryButton = new System.Windows.Forms.Panel();
            this.label_nonMandatoryFields = new System.Windows.Forms.Label();
            this.button_expandNonMandatory = new System.Windows.Forms.Button();
            this.panel_NonMandatoryFields = new System.Windows.Forms.Panel();
            this.label_paymentIsFixedPricePayment = new System.Windows.Forms.Label();
            this.comboBox_paymentIsFixedPricePayment = new System.Windows.Forms.ComboBox();
            this.label_paymentIsReadyForInvoicing = new System.Windows.Forms.Label();
            this.comboBox_paymentIsReadyForInvoicing = new System.Windows.Forms.ComboBox();
            this.label_paymentComment = new System.Windows.Forms.Label();
            this.comboBox_paymentProductNo = new System.Windows.Forms.ComboBox();
            this.comboBox_paymentComment = new System.Windows.Forms.ComboBox();
            this.label_paymentProductNo = new System.Windows.Forms.Label();
            this.label_paymentDiscountPercentage = new System.Windows.Forms.Label();
            this.comboBox_paymentDiscountPercentage = new System.Windows.Forms.ComboBox();
            this.label_paymentTaskNo = new System.Windows.Forms.Label();
            this.comboBox_paymentTaskNo = new System.Windows.Forms.ComboBox();
            this.label_delimiter = new System.Windows.Forms.Label();
            this.comboBox_delimiter = new System.Windows.Forms.ComboBox();
            this.groupBox_paymentMandatoryFields = new System.Windows.Forms.GroupBox();
            this.checkBox_defaultPaymentUnitType = new System.Windows.Forms.CheckBox();
            this.label_projectNo = new System.Windows.Forms.Label();
            this.label_paymentUnitType = new System.Windows.Forms.Label();
            this.comboBox_paymentProjectNo = new System.Windows.Forms.ComboBox();
            this.comboBox_paymentUnitType = new System.Windows.Forms.ComboBox();
            this.comboBox_paymentInvoiceDate = new System.Windows.Forms.ComboBox();
            this.label_paymentInvoiceDate = new System.Windows.Forms.Label();
            this.label_paymentAmount = new System.Windows.Forms.Label();
            this.comboBox_paymentAmount = new System.Windows.Forms.ComboBox();
            this.label_paymentQuantity = new System.Windows.Forms.Label();
            this.label_paymentContractName = new System.Windows.Forms.Label();
            this.comboBox_paymentQuantity = new System.Windows.Forms.ComboBox();
            this.comboBox_paymentContractName = new System.Windows.Forms.ComboBox();
            this.label_paymentName = new System.Windows.Forms.Label();
            this.comboBox_paymentName = new System.Windows.Forms.ComboBox();
            this.label_paymentSetup = new System.Windows.Forms.Label();
            this.button_paymentSelectFile = new System.Windows.Forms.Button();
            this.tmrExpand = new System.Windows.Forms.Timer(this.components);
            this.defaultToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel_paymentDataTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_payment)).BeginInit();
            this.panel_paymentMessage.SuspendLayout();
            this.panel_paymentButtons.SuspendLayout();
            this.panel_paymentFieldMapping.SuspendLayout();
            this.flowLayoutPanel_nonMandatoryFields.SuspendLayout();
            this.panel_NonMandatoryButton.SuspendLayout();
            this.panel_NonMandatoryFields.SuspendLayout();
            this.groupBox_paymentMandatoryFields.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkerFetcher
            // 
            this.WorkerFetcher.WorkerReportsProgress = true;
            this.WorkerFetcher.WorkerSupportsCancellation = true;
            this.WorkerFetcher.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WorkerFetcherDoWork);
            // 
            // panel_paymentDataTable
            // 
            this.panel_paymentDataTable.Controls.Add(this.dataGridView_payment);
            this.panel_paymentDataTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_paymentDataTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_paymentDataTable.Location = new System.Drawing.Point(0, 770);
            this.panel_paymentDataTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_paymentDataTable.Name = "panel_paymentDataTable";
            this.panel_paymentDataTable.Size = new System.Drawing.Size(1437, 300);
            this.panel_paymentDataTable.TabIndex = 6;
            // 
            // dataGridView_payment
            // 
            this.dataGridView_payment.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView_payment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_payment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_payment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_payment.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dataGridView_payment.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_payment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_payment.Name = "dataGridView_payment";
            this.dataGridView_payment.RowHeadersWidth = 62;
            this.dataGridView_payment.Size = new System.Drawing.Size(1437, 300);
            this.dataGridView_payment.TabIndex = 0;
            // 
            // panel_paymentMessage
            // 
            this.panel_paymentMessage.Controls.Add(this.textBox_paymentImportMessages);
            this.panel_paymentMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_paymentMessage.Location = new System.Drawing.Point(0, 463);
            this.panel_paymentMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_paymentMessage.Name = "panel_paymentMessage";
            this.panel_paymentMessage.Size = new System.Drawing.Size(1437, 307);
            this.panel_paymentMessage.TabIndex = 10;
            // 
            // textBox_paymentImportMessages
            // 
            this.textBox_paymentImportMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_paymentImportMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_paymentImportMessages.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_paymentImportMessages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox_paymentImportMessages.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_paymentImportMessages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_paymentImportMessages.Location = new System.Drawing.Point(0, 0);
            this.textBox_paymentImportMessages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_paymentImportMessages.Multiline = true;
            this.textBox_paymentImportMessages.Name = "textBox_paymentImportMessages";
            this.textBox_paymentImportMessages.ReadOnly = true;
            this.textBox_paymentImportMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_paymentImportMessages.Size = new System.Drawing.Size(1437, 307);
            this.textBox_paymentImportMessages.TabIndex = 0;
            this.textBox_paymentImportMessages.WordWrap = false;
            this.defaultToolTip.SetToolTip(this.textBox_paymentImportMessages, "Validation or import status");
            this.textBox_paymentImportMessages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_paymentImportMessages_MouseClick);
            // 
            // panel_paymentButtons
            // 
            this.panel_paymentButtons.Controls.Add(this.button_clear);
            this.panel_paymentButtons.Controls.Add(this.button_import);
            this.panel_paymentButtons.Controls.Add(this.button_validate);
            this.panel_paymentButtons.Controls.Add(this.button_stop);
            this.panel_paymentButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_paymentButtons.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel_paymentButtons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_paymentButtons.Location = new System.Drawing.Point(0, 376);
            this.panel_paymentButtons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_paymentButtons.Name = "panel_paymentButtons";
            this.panel_paymentButtons.Size = new System.Drawing.Size(1437, 87);
            this.panel_paymentButtons.TabIndex = 12;
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
            this.defaultToolTip.SetToolTip(this.button_clear, "Reset everything and reload data from TLP");
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
            // panel_paymentFieldMapping
            // 
            this.panel_paymentFieldMapping.AutoScroll = true;
            this.panel_paymentFieldMapping.Controls.Add(this.flowLayoutPanel_nonMandatoryFields);
            this.panel_paymentFieldMapping.Controls.Add(this.label_delimiter);
            this.panel_paymentFieldMapping.Controls.Add(this.comboBox_delimiter);
            this.panel_paymentFieldMapping.Controls.Add(this.groupBox_paymentMandatoryFields);
            this.panel_paymentFieldMapping.Controls.Add(this.label_paymentSetup);
            this.panel_paymentFieldMapping.Controls.Add(this.button_paymentSelectFile);
            this.panel_paymentFieldMapping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_paymentFieldMapping.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel_paymentFieldMapping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_paymentFieldMapping.Location = new System.Drawing.Point(0, 0);
            this.panel_paymentFieldMapping.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_paymentFieldMapping.MinimumSize = new System.Drawing.Size(0, 200);
            this.panel_paymentFieldMapping.Name = "panel_paymentFieldMapping";
            this.panel_paymentFieldMapping.Size = new System.Drawing.Size(1437, 376);
            this.panel_paymentFieldMapping.TabIndex = 13;
            // 
            // flowLayoutPanel_nonMandatoryFields
            // 
            this.flowLayoutPanel_nonMandatoryFields.Controls.Add(this.panel_NonMandatoryButton);
            this.flowLayoutPanel_nonMandatoryFields.Controls.Add(this.panel_NonMandatoryFields);
            this.flowLayoutPanel_nonMandatoryFields.Location = new System.Drawing.Point(841, 100);
            this.flowLayoutPanel_nonMandatoryFields.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel_nonMandatoryFields.Name = "flowLayoutPanel_nonMandatoryFields";
            this.flowLayoutPanel_nonMandatoryFields.Size = new System.Drawing.Size(531, 465);
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
            this.panel_NonMandatoryFields.Controls.Add(this.label_paymentIsFixedPricePayment);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_paymentIsFixedPricePayment);
            this.panel_NonMandatoryFields.Controls.Add(this.label_paymentIsReadyForInvoicing);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_paymentIsReadyForInvoicing);
            this.panel_NonMandatoryFields.Controls.Add(this.label_paymentComment);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_paymentProductNo);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_paymentComment);
            this.panel_NonMandatoryFields.Controls.Add(this.label_paymentProductNo);
            this.panel_NonMandatoryFields.Controls.Add(this.label_paymentDiscountPercentage);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_paymentDiscountPercentage);
            this.panel_NonMandatoryFields.Controls.Add(this.label_paymentTaskNo);
            this.panel_NonMandatoryFields.Controls.Add(this.comboBox_paymentTaskNo);
            this.panel_NonMandatoryFields.Location = new System.Drawing.Point(4, 68);
            this.panel_NonMandatoryFields.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_NonMandatoryFields.MinimumSize = new System.Drawing.Size(519, 0);
            this.panel_NonMandatoryFields.Name = "panel_NonMandatoryFields";
            this.panel_NonMandatoryFields.Size = new System.Drawing.Size(519, 397);
            this.panel_NonMandatoryFields.TabIndex = 1;
            // 
            // label_paymentIsFixedPricePayment
            // 
            this.label_paymentIsFixedPricePayment.AutoSize = true;
            this.label_paymentIsFixedPricePayment.Location = new System.Drawing.Point(14, 290);
            this.label_paymentIsFixedPricePayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_paymentIsFixedPricePayment.Name = "label_paymentIsFixedPricePayment";
            this.label_paymentIsFixedPricePayment.Size = new System.Drawing.Size(149, 17);
            this.label_paymentIsFixedPricePayment.TabIndex = 4;
            this.label_paymentIsFixedPricePayment.Text = "Is  Fixed Price Payment";
            // 
            // comboBox_paymentIsFixedPricePayment
            // 
            this.comboBox_paymentIsFixedPricePayment.FormattingEnabled = true;
            this.comboBox_paymentIsFixedPricePayment.Location = new System.Drawing.Point(257, 285);
            this.comboBox_paymentIsFixedPricePayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_paymentIsFixedPricePayment.Name = "comboBox_paymentIsFixedPricePayment";
            this.comboBox_paymentIsFixedPricePayment.Size = new System.Drawing.Size(197, 25);
            this.comboBox_paymentIsFixedPricePayment.TabIndex = 6;
            // 
            // label_paymentIsReadyForInvoicing
            // 
            this.label_paymentIsReadyForInvoicing.AutoSize = true;
            this.label_paymentIsReadyForInvoicing.Location = new System.Drawing.Point(14, 238);
            this.label_paymentIsReadyForInvoicing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_paymentIsReadyForInvoicing.Name = "label_paymentIsReadyForInvoicing";
            this.label_paymentIsReadyForInvoicing.Size = new System.Drawing.Size(142, 17);
            this.label_paymentIsReadyForInvoicing.TabIndex = 5;
            this.label_paymentIsReadyForInvoicing.Text = "Is Ready For Invoicing";
            // 
            // comboBox_paymentIsReadyForInvoicing
            // 
            this.comboBox_paymentIsReadyForInvoicing.FormattingEnabled = true;
            this.comboBox_paymentIsReadyForInvoicing.Location = new System.Drawing.Point(257, 233);
            this.comboBox_paymentIsReadyForInvoicing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_paymentIsReadyForInvoicing.Name = "comboBox_paymentIsReadyForInvoicing";
            this.comboBox_paymentIsReadyForInvoicing.Size = new System.Drawing.Size(197, 25);
            this.comboBox_paymentIsReadyForInvoicing.TabIndex = 7;
            // 
            // label_paymentComment
            // 
            this.label_paymentComment.AutoSize = true;
            this.label_paymentComment.Location = new System.Drawing.Point(14, 187);
            this.label_paymentComment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_paymentComment.Name = "label_paymentComment";
            this.label_paymentComment.Size = new System.Drawing.Size(68, 17);
            this.label_paymentComment.TabIndex = 1;
            this.label_paymentComment.Text = "Comment";
            // 
            // comboBox_paymentProductNo
            // 
            this.comboBox_paymentProductNo.FormattingEnabled = true;
            this.comboBox_paymentProductNo.Location = new System.Drawing.Point(257, 78);
            this.comboBox_paymentProductNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_paymentProductNo.Name = "comboBox_paymentProductNo";
            this.comboBox_paymentProductNo.Size = new System.Drawing.Size(197, 25);
            this.comboBox_paymentProductNo.TabIndex = 3;
            // 
            // comboBox_paymentComment
            // 
            this.comboBox_paymentComment.FormattingEnabled = true;
            this.comboBox_paymentComment.Location = new System.Drawing.Point(257, 182);
            this.comboBox_paymentComment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_paymentComment.Name = "comboBox_paymentComment";
            this.comboBox_paymentComment.Size = new System.Drawing.Size(197, 25);
            this.comboBox_paymentComment.TabIndex = 3;
            // 
            // label_paymentProductNo
            // 
            this.label_paymentProductNo.AutoSize = true;
            this.label_paymentProductNo.Location = new System.Drawing.Point(14, 83);
            this.label_paymentProductNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_paymentProductNo.Name = "label_paymentProductNo";
            this.label_paymentProductNo.Size = new System.Drawing.Size(78, 17);
            this.label_paymentProductNo.TabIndex = 1;
            this.label_paymentProductNo.Text = "Product No";
            // 
            // label_paymentDiscountPercentage
            // 
            this.label_paymentDiscountPercentage.AutoSize = true;
            this.label_paymentDiscountPercentage.Location = new System.Drawing.Point(14, 135);
            this.label_paymentDiscountPercentage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_paymentDiscountPercentage.Name = "label_paymentDiscountPercentage";
            this.label_paymentDiscountPercentage.Size = new System.Drawing.Size(76, 17);
            this.label_paymentDiscountPercentage.TabIndex = 1;
            this.label_paymentDiscountPercentage.Text = "Discount %";
            // 
            // comboBox_paymentDiscountPercentage
            // 
            this.comboBox_paymentDiscountPercentage.FormattingEnabled = true;
            this.comboBox_paymentDiscountPercentage.Location = new System.Drawing.Point(257, 130);
            this.comboBox_paymentDiscountPercentage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_paymentDiscountPercentage.Name = "comboBox_paymentDiscountPercentage";
            this.comboBox_paymentDiscountPercentage.Size = new System.Drawing.Size(197, 25);
            this.comboBox_paymentDiscountPercentage.TabIndex = 3;
            // 
            // label_paymentTaskNo
            // 
            this.label_paymentTaskNo.AutoSize = true;
            this.label_paymentTaskNo.Location = new System.Drawing.Point(14, 33);
            this.label_paymentTaskNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_paymentTaskNo.Name = "label_paymentTaskNo";
            this.label_paymentTaskNo.Size = new System.Drawing.Size(56, 17);
            this.label_paymentTaskNo.TabIndex = 1;
            this.label_paymentTaskNo.Text = "Task No";
            // 
            // comboBox_paymentTaskNo
            // 
            this.comboBox_paymentTaskNo.FormattingEnabled = true;
            this.comboBox_paymentTaskNo.Location = new System.Drawing.Point(257, 27);
            this.comboBox_paymentTaskNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_paymentTaskNo.Name = "comboBox_paymentTaskNo";
            this.comboBox_paymentTaskNo.Size = new System.Drawing.Size(197, 25);
            this.comboBox_paymentTaskNo.TabIndex = 3;
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
            // groupBox_paymentMandatoryFields
            // 
            this.groupBox_paymentMandatoryFields.Controls.Add(this.checkBox_defaultPaymentUnitType);
            this.groupBox_paymentMandatoryFields.Controls.Add(this.label_projectNo);
            this.groupBox_paymentMandatoryFields.Controls.Add(this.label_paymentUnitType);
            this.groupBox_paymentMandatoryFields.Controls.Add(this.comboBox_paymentProjectNo);
            this.groupBox_paymentMandatoryFields.Controls.Add(this.comboBox_paymentUnitType);
            this.groupBox_paymentMandatoryFields.Controls.Add(this.comboBox_paymentInvoiceDate);
            this.groupBox_paymentMandatoryFields.Controls.Add(this.label_paymentInvoiceDate);
            this.groupBox_paymentMandatoryFields.Controls.Add(this.label_paymentAmount);
            this.groupBox_paymentMandatoryFields.Controls.Add(this.comboBox_paymentAmount);
            this.groupBox_paymentMandatoryFields.Controls.Add(this.label_paymentQuantity);
            this.groupBox_paymentMandatoryFields.Controls.Add(this.label_paymentContractName);
            this.groupBox_paymentMandatoryFields.Controls.Add(this.comboBox_paymentQuantity);
            this.groupBox_paymentMandatoryFields.Controls.Add(this.comboBox_paymentContractName);
            this.groupBox_paymentMandatoryFields.Controls.Add(this.label_paymentName);
            this.groupBox_paymentMandatoryFields.Controls.Add(this.comboBox_paymentName);
            this.groupBox_paymentMandatoryFields.Location = new System.Drawing.Point(263, 103);
            this.groupBox_paymentMandatoryFields.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_paymentMandatoryFields.Name = "groupBox_paymentMandatoryFields";
            this.groupBox_paymentMandatoryFields.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_paymentMandatoryFields.Size = new System.Drawing.Size(549, 462);
            this.groupBox_paymentMandatoryFields.TabIndex = 5;
            this.groupBox_paymentMandatoryFields.TabStop = false;
            this.groupBox_paymentMandatoryFields.Text = "Mandatory";
            // 
            // checkBox_defaultPaymentUnitType
            // 
            this.checkBox_defaultPaymentUnitType.AutoSize = true;
            this.checkBox_defaultPaymentUnitType.Location = new System.Drawing.Point(440, 358);
            this.checkBox_defaultPaymentUnitType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_defaultPaymentUnitType.Name = "checkBox_defaultPaymentUnitType";
            this.checkBox_defaultPaymentUnitType.Size = new System.Drawing.Size(70, 21);
            this.checkBox_defaultPaymentUnitType.TabIndex = 9;
            this.checkBox_defaultPaymentUnitType.Text = "Default";
            this.defaultToolTip.SetToolTip(this.checkBox_defaultPaymentUnitType, "Set default values for all rows of a particular column field");
            this.checkBox_defaultPaymentUnitType.UseVisualStyleBackColor = true;
            this.checkBox_defaultPaymentUnitType.CheckedChanged += new System.EventHandler(this.checkBox_defaultPaymentUnitType_CheckedChanged);
            // 
            // label_projectNo
            // 
            this.label_projectNo.AutoSize = true;
            this.label_projectNo.Location = new System.Drawing.Point(7, 97);
            this.label_projectNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_projectNo.Name = "label_projectNo";
            this.label_projectNo.Size = new System.Drawing.Size(72, 17);
            this.label_projectNo.TabIndex = 1;
            this.label_projectNo.Text = "Project No";
            // 
            // label_paymentUnitType
            // 
            this.label_paymentUnitType.AutoSize = true;
            this.label_paymentUnitType.Location = new System.Drawing.Point(9, 355);
            this.label_paymentUnitType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_paymentUnitType.Name = "label_paymentUnitType";
            this.label_paymentUnitType.Size = new System.Drawing.Size(64, 17);
            this.label_paymentUnitType.TabIndex = 7;
            this.label_paymentUnitType.Text = "Unit type";
            // 
            // comboBox_paymentProjectNo
            // 
            this.comboBox_paymentProjectNo.FormattingEnabled = true;
            this.comboBox_paymentProjectNo.Location = new System.Drawing.Point(233, 97);
            this.comboBox_paymentProjectNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_paymentProjectNo.Name = "comboBox_paymentProjectNo";
            this.comboBox_paymentProjectNo.Size = new System.Drawing.Size(197, 25);
            this.comboBox_paymentProjectNo.TabIndex = 3;
            // 
            // comboBox_paymentUnitType
            // 
            this.comboBox_paymentUnitType.FormattingEnabled = true;
            this.comboBox_paymentUnitType.Location = new System.Drawing.Point(233, 355);
            this.comboBox_paymentUnitType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_paymentUnitType.Name = "comboBox_paymentUnitType";
            this.comboBox_paymentUnitType.Size = new System.Drawing.Size(197, 25);
            this.comboBox_paymentUnitType.TabIndex = 8;
            // 
            // comboBox_paymentInvoiceDate
            // 
            this.comboBox_paymentInvoiceDate.FormattingEnabled = true;
            this.comboBox_paymentInvoiceDate.Location = new System.Drawing.Point(233, 200);
            this.comboBox_paymentInvoiceDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_paymentInvoiceDate.Name = "comboBox_paymentInvoiceDate";
            this.comboBox_paymentInvoiceDate.Size = new System.Drawing.Size(197, 25);
            this.comboBox_paymentInvoiceDate.TabIndex = 3;
            // 
            // label_paymentInvoiceDate
            // 
            this.label_paymentInvoiceDate.AutoSize = true;
            this.label_paymentInvoiceDate.Location = new System.Drawing.Point(9, 205);
            this.label_paymentInvoiceDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_paymentInvoiceDate.Name = "label_paymentInvoiceDate";
            this.label_paymentInvoiceDate.Size = new System.Drawing.Size(83, 17);
            this.label_paymentInvoiceDate.TabIndex = 1;
            this.label_paymentInvoiceDate.Text = "Invoice Date";
            // 
            // label_paymentAmount
            // 
            this.label_paymentAmount.AutoSize = true;
            this.label_paymentAmount.Location = new System.Drawing.Point(9, 252);
            this.label_paymentAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_paymentAmount.Name = "label_paymentAmount";
            this.label_paymentAmount.Size = new System.Drawing.Size(58, 17);
            this.label_paymentAmount.TabIndex = 1;
            this.label_paymentAmount.Text = "Amount";
            // 
            // comboBox_paymentAmount
            // 
            this.comboBox_paymentAmount.FormattingEnabled = true;
            this.comboBox_paymentAmount.Location = new System.Drawing.Point(233, 252);
            this.comboBox_paymentAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_paymentAmount.Name = "comboBox_paymentAmount";
            this.comboBox_paymentAmount.Size = new System.Drawing.Size(197, 25);
            this.comboBox_paymentAmount.TabIndex = 3;
            // 
            // label_paymentQuantity
            // 
            this.label_paymentQuantity.AutoSize = true;
            this.label_paymentQuantity.Location = new System.Drawing.Point(9, 303);
            this.label_paymentQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_paymentQuantity.Name = "label_paymentQuantity";
            this.label_paymentQuantity.Size = new System.Drawing.Size(61, 17);
            this.label_paymentQuantity.TabIndex = 1;
            this.label_paymentQuantity.Text = "Quantity";
            // 
            // label_paymentContractName
            // 
            this.label_paymentContractName.AutoSize = true;
            this.label_paymentContractName.Location = new System.Drawing.Point(9, 148);
            this.label_paymentContractName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_paymentContractName.Name = "label_paymentContractName";
            this.label_paymentContractName.Size = new System.Drawing.Size(100, 17);
            this.label_paymentContractName.TabIndex = 1;
            this.label_paymentContractName.Text = "Contract Name";
            // 
            // comboBox_paymentQuantity
            // 
            this.comboBox_paymentQuantity.FormattingEnabled = true;
            this.comboBox_paymentQuantity.Location = new System.Drawing.Point(233, 303);
            this.comboBox_paymentQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_paymentQuantity.Name = "comboBox_paymentQuantity";
            this.comboBox_paymentQuantity.Size = new System.Drawing.Size(197, 25);
            this.comboBox_paymentQuantity.TabIndex = 3;
            // 
            // comboBox_paymentContractName
            // 
            this.comboBox_paymentContractName.FormattingEnabled = true;
            this.comboBox_paymentContractName.Location = new System.Drawing.Point(233, 148);
            this.comboBox_paymentContractName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_paymentContractName.Name = "comboBox_paymentContractName";
            this.comboBox_paymentContractName.Size = new System.Drawing.Size(197, 25);
            this.comboBox_paymentContractName.TabIndex = 3;
            // 
            // label_paymentName
            // 
            this.label_paymentName.AutoSize = true;
            this.label_paymentName.Location = new System.Drawing.Point(9, 45);
            this.label_paymentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_paymentName.Name = "label_paymentName";
            this.label_paymentName.Size = new System.Drawing.Size(102, 17);
            this.label_paymentName.TabIndex = 1;
            this.label_paymentName.Text = "Payment Name";
            // 
            // comboBox_paymentName
            // 
            this.comboBox_paymentName.FormattingEnabled = true;
            this.comboBox_paymentName.Location = new System.Drawing.Point(233, 45);
            this.comboBox_paymentName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_paymentName.Name = "comboBox_paymentName";
            this.comboBox_paymentName.Size = new System.Drawing.Size(197, 25);
            this.comboBox_paymentName.TabIndex = 3;
            // 
            // label_paymentSetup
            // 
            this.label_paymentSetup.AutoSize = true;
            this.label_paymentSetup.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_paymentSetup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_paymentSetup.Location = new System.Drawing.Point(10, 27);
            this.label_paymentSetup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_paymentSetup.Name = "label_paymentSetup";
            this.label_paymentSetup.Size = new System.Drawing.Size(250, 32);
            this.label_paymentSetup.TabIndex = 0;
            this.label_paymentSetup.Text = "Payment Data Import";
            // 
            // button_paymentSelectFile
            // 
            this.button_paymentSelectFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(43)))), ((int)(((byte)(141)))));
            this.button_paymentSelectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_paymentSelectFile.FlatAppearance.BorderSize = 0;
            this.button_paymentSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_paymentSelectFile.ForeColor = System.Drawing.Color.White;
            this.button_paymentSelectFile.Location = new System.Drawing.Point(19, 185);
            this.button_paymentSelectFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_paymentSelectFile.Name = "button_paymentSelectFile";
            this.button_paymentSelectFile.Size = new System.Drawing.Size(114, 48);
            this.button_paymentSelectFile.TabIndex = 4;
            this.button_paymentSelectFile.Text = "Select File";
            this.defaultToolTip.SetToolTip(this.button_paymentSelectFile, "Select input CSV file");
            this.button_paymentSelectFile.UseVisualStyleBackColor = false;
            this.button_paymentSelectFile.Click += new System.EventHandler(this.button_select_payment_file_Click);
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
            // UserControl_PaymentImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_paymentFieldMapping);
            this.Controls.Add(this.panel_paymentButtons);
            this.Controls.Add(this.panel_paymentMessage);
            this.Controls.Add(this.panel_paymentDataTable);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControl_PaymentImport";
            this.Size = new System.Drawing.Size(1437, 1070);
            this.panel_paymentDataTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_payment)).EndInit();
            this.panel_paymentMessage.ResumeLayout(false);
            this.panel_paymentMessage.PerformLayout();
            this.panel_paymentButtons.ResumeLayout(false);
            this.panel_paymentFieldMapping.ResumeLayout(false);
            this.panel_paymentFieldMapping.PerformLayout();
            this.flowLayoutPanel_nonMandatoryFields.ResumeLayout(false);
            this.panel_NonMandatoryButton.ResumeLayout(false);
            this.panel_NonMandatoryButton.PerformLayout();
            this.panel_NonMandatoryFields.ResumeLayout(false);
            this.panel_NonMandatoryFields.PerformLayout();
            this.groupBox_paymentMandatoryFields.ResumeLayout(false);
            this.groupBox_paymentMandatoryFields.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private void AddRowNumberToDataTable()
        {
            this.dataGridView_payment.DataBindingComplete += (o, e) =>
            {
                foreach (System.Windows.Forms.DataGridViewRow row in dataGridView_payment.Rows)
                {
                    row.HeaderCell.Value = (row.Index + 1).ToString();

                }
            };
            this.dataGridView_payment.RowHeadersWidth = 65;
        }


        private System.ComponentModel.BackgroundWorker WorkerFetcher;
        private System.Windows.Forms.Panel panel_paymentDataTable;
        private System.Windows.Forms.DataGridView dataGridView_payment;
        private System.Windows.Forms.Panel panel_paymentMessage;
        private System.Windows.Forms.Panel panel_paymentButtons;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_import;
        private System.Windows.Forms.Button button_validate;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Panel panel_paymentFieldMapping;
        private System.Windows.Forms.GroupBox groupBox_paymentMandatoryFields;
        private System.Windows.Forms.ComboBox comboBox_paymentName;
        private System.Windows.Forms.Label label_paymentName;
        private System.Windows.Forms.Label label_paymentSetup;
        private System.Windows.Forms.Button button_paymentSelectFile;
        private System.Windows.Forms.TextBox textBox_paymentImportMessages;
        private System.Windows.Forms.Label label_paymentContractName;
        private System.Windows.Forms.ComboBox comboBox_paymentContractName;
        private System.Windows.Forms.Label label_paymentAmount;
        private System.Windows.Forms.ComboBox comboBox_paymentAmount;
        private System.Windows.Forms.Label label_paymentTaskNo;
        private System.Windows.Forms.ComboBox comboBox_paymentTaskNo;
        private System.Windows.Forms.Label label_delimiter;
        private System.Windows.Forms.ComboBox comboBox_delimiter;
        private System.Windows.Forms.Label label_paymentComment;
        private System.Windows.Forms.ComboBox comboBox_paymentComment;
        private System.Windows.Forms.Label label_paymentQuantity;
        private System.Windows.Forms.ComboBox comboBox_paymentQuantity;
        private System.Windows.Forms.Label label_paymentDiscountPercentage;
        private System.Windows.Forms.ComboBox comboBox_paymentDiscountPercentage;
        private System.Windows.Forms.Label label_paymentInvoiceDate;
        private System.Windows.Forms.ComboBox comboBox_paymentInvoiceDate;
        private System.Windows.Forms.Label label_paymentProductNo;
        private System.Windows.Forms.ComboBox comboBox_paymentProductNo;
        private System.Windows.Forms.Label label_projectNo;
        private System.Windows.Forms.ComboBox comboBox_paymentProjectNo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_nonMandatoryFields;
        private System.Windows.Forms.Panel panel_NonMandatoryButton;
        private System.Windows.Forms.Panel panel_NonMandatoryFields;
        private System.Windows.Forms.Label label_nonMandatoryFields;
        private System.Windows.Forms.Button button_expandNonMandatory;
        private System.Windows.Forms.Timer tmrExpand;
        private System.Windows.Forms.ToolTip defaultToolTip;
        private System.Windows.Forms.CheckBox checkBox_defaultPaymentUnitType;
        private System.Windows.Forms.Label label_paymentUnitType;
        private System.Windows.Forms.ComboBox comboBox_paymentUnitType;
        private System.Windows.Forms.Label label_paymentIsFixedPricePayment;
        private System.Windows.Forms.ComboBox comboBox_paymentIsFixedPricePayment;
        private System.Windows.Forms.Label label_paymentIsReadyForInvoicing;
        private System.Windows.Forms.ComboBox comboBox_paymentIsReadyForInvoicing;
    }
}
