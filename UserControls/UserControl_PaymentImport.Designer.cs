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
            components = new System.ComponentModel.Container();
            WorkerFetcher = new System.ComponentModel.BackgroundWorker();
            panel_paymentDataTable = new System.Windows.Forms.Panel();
            dataGridView_payment = new System.Windows.Forms.DataGridView();
            panel_paymentMessage = new System.Windows.Forms.Panel();
            textBox_paymentImportMessages = new System.Windows.Forms.TextBox();
            panel_paymentButtons = new System.Windows.Forms.Panel();
            button_clear = new System.Windows.Forms.Button();
            button_import = new System.Windows.Forms.Button();
            button_validate = new System.Windows.Forms.Button();
            button_stop = new System.Windows.Forms.Button();
            panel_paymentFieldMapping = new System.Windows.Forms.Panel();
            flowLayoutPanel_nonMandatoryFields = new System.Windows.Forms.FlowLayoutPanel();
            panel_NonMandatoryButton = new System.Windows.Forms.Panel();
            label_nonMandatoryFields = new System.Windows.Forms.Label();
            button_expandNonMandatory = new System.Windows.Forms.Button();
            panel_NonMandatoryFields = new System.Windows.Forms.Panel();
            label_paymentIsFixedPricePayment = new System.Windows.Forms.Label();
            comboBox_paymentIsFixedPricePayment = new System.Windows.Forms.ComboBox();
            label_paymentIsReadyForInvoicing = new System.Windows.Forms.Label();
            comboBox_paymentIsReadyForInvoicing = new System.Windows.Forms.ComboBox();
            label_paymentComment = new System.Windows.Forms.Label();
            comboBox_paymentProductNo = new System.Windows.Forms.ComboBox();
            comboBox_paymentComment = new System.Windows.Forms.ComboBox();
            label_paymentProductNo = new System.Windows.Forms.Label();
            label_paymentDiscountPercentage = new System.Windows.Forms.Label();
            comboBox_paymentDiscountPercentage = new System.Windows.Forms.ComboBox();
            label_paymentTaskNo = new System.Windows.Forms.Label();
            comboBox_paymentTaskNo = new System.Windows.Forms.ComboBox();
            label_delimiter = new System.Windows.Forms.Label();
            comboBox_delimiter = new System.Windows.Forms.ComboBox();
            groupBox_paymentMandatoryFields = new System.Windows.Forms.GroupBox();
            checkBox_defaultPaymentUnitType = new System.Windows.Forms.CheckBox();
            label_projectNo = new System.Windows.Forms.Label();
            label_paymentUnitType = new System.Windows.Forms.Label();
            comboBox_paymentProjectNo = new System.Windows.Forms.ComboBox();
            comboBox_paymentUnitType = new System.Windows.Forms.ComboBox();
            comboBox_paymentInvoiceDate = new System.Windows.Forms.ComboBox();
            label_paymentInvoiceDate = new System.Windows.Forms.Label();
            label_paymentAmount = new System.Windows.Forms.Label();
            comboBox_paymentAmount = new System.Windows.Forms.ComboBox();
            label_paymentQuantity = new System.Windows.Forms.Label();
            label_paymentContractName = new System.Windows.Forms.Label();
            comboBox_paymentQuantity = new System.Windows.Forms.ComboBox();
            comboBox_paymentContractName = new System.Windows.Forms.ComboBox();
            label_paymentName = new System.Windows.Forms.Label();
            comboBox_paymentName = new System.Windows.Forms.ComboBox();
            label_paymentSetup = new System.Windows.Forms.Label();
            button_paymentSelectFile = new System.Windows.Forms.Button();
            tmrExpand = new System.Windows.Forms.Timer(components);
            defaultToolTip = new System.Windows.Forms.ToolTip(components);
            panel_paymentDataTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_payment).BeginInit();
            panel_paymentMessage.SuspendLayout();
            panel_paymentButtons.SuspendLayout();
            panel_paymentFieldMapping.SuspendLayout();
            flowLayoutPanel_nonMandatoryFields.SuspendLayout();
            panel_NonMandatoryButton.SuspendLayout();
            panel_NonMandatoryFields.SuspendLayout();
            groupBox_paymentMandatoryFields.SuspendLayout();
            SuspendLayout();
            // 
            // WorkerFetcher
            // 
            WorkerFetcher.WorkerReportsProgress = true;
            WorkerFetcher.WorkerSupportsCancellation = true;
            WorkerFetcher.DoWork += WorkerFetcherDoWork;
            // 
            // panel_paymentDataTable
            // 
            panel_paymentDataTable.Controls.Add(dataGridView_payment);
            panel_paymentDataTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_paymentDataTable.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel_paymentDataTable.Location = new System.Drawing.Point(0, 462);
            panel_paymentDataTable.Name = "panel_paymentDataTable";
            panel_paymentDataTable.Size = new System.Drawing.Size(1006, 180);
            panel_paymentDataTable.TabIndex = 6;
            // 
            // dataGridView_payment
            // 
            dataGridView_payment.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridView_payment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridView_payment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_payment.Dock = System.Windows.Forms.DockStyle.Bottom;
            dataGridView_payment.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridView_payment.Location = new System.Drawing.Point(0, 0);
            dataGridView_payment.Name = "dataGridView_payment";
            dataGridView_payment.RowHeadersWidth = 62;
            dataGridView_payment.Size = new System.Drawing.Size(1006, 180);
            dataGridView_payment.TabIndex = 0;
            // 
            // panel_paymentMessage
            // 
            panel_paymentMessage.Controls.Add(textBox_paymentImportMessages);
            panel_paymentMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_paymentMessage.Location = new System.Drawing.Point(0, 278);
            panel_paymentMessage.Name = "panel_paymentMessage";
            panel_paymentMessage.Size = new System.Drawing.Size(1006, 184);
            panel_paymentMessage.TabIndex = 10;
            // 
            // textBox_paymentImportMessages
            // 
            textBox_paymentImportMessages.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            textBox_paymentImportMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox_paymentImportMessages.Dock = System.Windows.Forms.DockStyle.Bottom;
            textBox_paymentImportMessages.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            textBox_paymentImportMessages.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            textBox_paymentImportMessages.Location = new System.Drawing.Point(0, 0);
            textBox_paymentImportMessages.Multiline = true;
            textBox_paymentImportMessages.Name = "textBox_paymentImportMessages";
            textBox_paymentImportMessages.ReadOnly = true;
            textBox_paymentImportMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBox_paymentImportMessages.Size = new System.Drawing.Size(1006, 184);
            textBox_paymentImportMessages.TabIndex = 0;
            defaultToolTip.SetToolTip(textBox_paymentImportMessages, "Validation or import status");
            textBox_paymentImportMessages.WordWrap = false;
            textBox_paymentImportMessages.MouseClick += textBox_paymentImportMessages_MouseClick;
            // 
            // panel_paymentButtons
            // 
            panel_paymentButtons.Controls.Add(button_clear);
            panel_paymentButtons.Controls.Add(button_import);
            panel_paymentButtons.Controls.Add(button_validate);
            panel_paymentButtons.Controls.Add(button_stop);
            panel_paymentButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_paymentButtons.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            panel_paymentButtons.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel_paymentButtons.Location = new System.Drawing.Point(0, 226);
            panel_paymentButtons.Name = "panel_paymentButtons";
            panel_paymentButtons.Size = new System.Drawing.Size(1006, 52);
            panel_paymentButtons.TabIndex = 12;
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
            // panel_paymentFieldMapping
            // 
            panel_paymentFieldMapping.AutoScroll = true;
            panel_paymentFieldMapping.Controls.Add(flowLayoutPanel_nonMandatoryFields);
            panel_paymentFieldMapping.Controls.Add(label_delimiter);
            panel_paymentFieldMapping.Controls.Add(comboBox_delimiter);
            panel_paymentFieldMapping.Controls.Add(groupBox_paymentMandatoryFields);
            panel_paymentFieldMapping.Controls.Add(label_paymentSetup);
            panel_paymentFieldMapping.Controls.Add(button_paymentSelectFile);
            panel_paymentFieldMapping.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_paymentFieldMapping.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            panel_paymentFieldMapping.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel_paymentFieldMapping.Location = new System.Drawing.Point(0, 0);
            panel_paymentFieldMapping.MinimumSize = new System.Drawing.Size(0, 120);
            panel_paymentFieldMapping.Name = "panel_paymentFieldMapping";
            panel_paymentFieldMapping.Size = new System.Drawing.Size(1006, 226);
            panel_paymentFieldMapping.TabIndex = 13;
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
            panel_NonMandatoryFields.Controls.Add(label_paymentIsFixedPricePayment);
            panel_NonMandatoryFields.Controls.Add(comboBox_paymentIsFixedPricePayment);
            panel_NonMandatoryFields.Controls.Add(label_paymentIsReadyForInvoicing);
            panel_NonMandatoryFields.Controls.Add(comboBox_paymentIsReadyForInvoicing);
            panel_NonMandatoryFields.Controls.Add(label_paymentComment);
            panel_NonMandatoryFields.Controls.Add(comboBox_paymentProductNo);
            panel_NonMandatoryFields.Controls.Add(comboBox_paymentComment);
            panel_NonMandatoryFields.Controls.Add(label_paymentProductNo);
            panel_NonMandatoryFields.Controls.Add(label_paymentDiscountPercentage);
            panel_NonMandatoryFields.Controls.Add(comboBox_paymentDiscountPercentage);
            panel_NonMandatoryFields.Controls.Add(label_paymentTaskNo);
            panel_NonMandatoryFields.Controls.Add(comboBox_paymentTaskNo);
            panel_NonMandatoryFields.Location = new System.Drawing.Point(3, 41);
            panel_NonMandatoryFields.MinimumSize = new System.Drawing.Size(363, 0);
            panel_NonMandatoryFields.Name = "panel_NonMandatoryFields";
            panel_NonMandatoryFields.Size = new System.Drawing.Size(363, 214);
            panel_NonMandatoryFields.TabIndex = 1;
            // 
            // label_paymentIsFixedPricePayment
            // 
            label_paymentIsFixedPricePayment.AutoSize = true;
            label_paymentIsFixedPricePayment.Location = new System.Drawing.Point(10, 174);
            label_paymentIsFixedPricePayment.Name = "label_paymentIsFixedPricePayment";
            label_paymentIsFixedPricePayment.Size = new System.Drawing.Size(149, 17);
            label_paymentIsFixedPricePayment.TabIndex = 4;
            label_paymentIsFixedPricePayment.Text = "Is  Fixed Price Payment";
            // 
            // comboBox_paymentIsFixedPricePayment
            // 
            comboBox_paymentIsFixedPricePayment.FormattingEnabled = true;
            comboBox_paymentIsFixedPricePayment.Location = new System.Drawing.Point(180, 171);
            comboBox_paymentIsFixedPricePayment.Name = "comboBox_paymentIsFixedPricePayment";
            comboBox_paymentIsFixedPricePayment.Size = new System.Drawing.Size(139, 25);
            comboBox_paymentIsFixedPricePayment.TabIndex = 6;
            // 
            // label_paymentIsReadyForInvoicing
            // 
            label_paymentIsReadyForInvoicing.AutoSize = true;
            label_paymentIsReadyForInvoicing.Location = new System.Drawing.Point(10, 143);
            label_paymentIsReadyForInvoicing.Name = "label_paymentIsReadyForInvoicing";
            label_paymentIsReadyForInvoicing.Size = new System.Drawing.Size(142, 17);
            label_paymentIsReadyForInvoicing.TabIndex = 5;
            label_paymentIsReadyForInvoicing.Text = "Is Ready For Invoicing";
            // 
            // comboBox_paymentIsReadyForInvoicing
            // 
            comboBox_paymentIsReadyForInvoicing.FormattingEnabled = true;
            comboBox_paymentIsReadyForInvoicing.Location = new System.Drawing.Point(180, 140);
            comboBox_paymentIsReadyForInvoicing.Name = "comboBox_paymentIsReadyForInvoicing";
            comboBox_paymentIsReadyForInvoicing.Size = new System.Drawing.Size(139, 25);
            comboBox_paymentIsReadyForInvoicing.TabIndex = 7;
            // 
            // label_paymentComment
            // 
            label_paymentComment.AutoSize = true;
            label_paymentComment.Location = new System.Drawing.Point(10, 112);
            label_paymentComment.Name = "label_paymentComment";
            label_paymentComment.Size = new System.Drawing.Size(68, 17);
            label_paymentComment.TabIndex = 1;
            label_paymentComment.Text = "Comment";
            // 
            // comboBox_paymentProductNo
            // 
            comboBox_paymentProductNo.FormattingEnabled = true;
            comboBox_paymentProductNo.Location = new System.Drawing.Point(180, 47);
            comboBox_paymentProductNo.Name = "comboBox_paymentProductNo";
            comboBox_paymentProductNo.Size = new System.Drawing.Size(139, 25);
            comboBox_paymentProductNo.TabIndex = 3;
            // 
            // comboBox_paymentComment
            // 
            comboBox_paymentComment.FormattingEnabled = true;
            comboBox_paymentComment.Location = new System.Drawing.Point(180, 109);
            comboBox_paymentComment.Name = "comboBox_paymentComment";
            comboBox_paymentComment.Size = new System.Drawing.Size(139, 25);
            comboBox_paymentComment.TabIndex = 3;
            // 
            // label_paymentProductNo
            // 
            label_paymentProductNo.AutoSize = true;
            label_paymentProductNo.Location = new System.Drawing.Point(10, 50);
            label_paymentProductNo.Name = "label_paymentProductNo";
            label_paymentProductNo.Size = new System.Drawing.Size(78, 17);
            label_paymentProductNo.TabIndex = 1;
            label_paymentProductNo.Text = "Product No";
            // 
            // label_paymentDiscountPercentage
            // 
            label_paymentDiscountPercentage.AutoSize = true;
            label_paymentDiscountPercentage.Location = new System.Drawing.Point(10, 81);
            label_paymentDiscountPercentage.Name = "label_paymentDiscountPercentage";
            label_paymentDiscountPercentage.Size = new System.Drawing.Size(76, 17);
            label_paymentDiscountPercentage.TabIndex = 1;
            label_paymentDiscountPercentage.Text = "Discount %";
            // 
            // comboBox_paymentDiscountPercentage
            // 
            comboBox_paymentDiscountPercentage.FormattingEnabled = true;
            comboBox_paymentDiscountPercentage.Location = new System.Drawing.Point(180, 78);
            comboBox_paymentDiscountPercentage.Name = "comboBox_paymentDiscountPercentage";
            comboBox_paymentDiscountPercentage.Size = new System.Drawing.Size(139, 25);
            comboBox_paymentDiscountPercentage.TabIndex = 3;
            // 
            // label_paymentTaskNo
            // 
            label_paymentTaskNo.AutoSize = true;
            label_paymentTaskNo.Location = new System.Drawing.Point(10, 20);
            label_paymentTaskNo.Name = "label_paymentTaskNo";
            label_paymentTaskNo.Size = new System.Drawing.Size(56, 17);
            label_paymentTaskNo.TabIndex = 1;
            label_paymentTaskNo.Text = "Task No";
            // 
            // comboBox_paymentTaskNo
            // 
            comboBox_paymentTaskNo.FormattingEnabled = true;
            comboBox_paymentTaskNo.Location = new System.Drawing.Point(180, 16);
            comboBox_paymentTaskNo.Name = "comboBox_paymentTaskNo";
            comboBox_paymentTaskNo.Size = new System.Drawing.Size(139, 25);
            comboBox_paymentTaskNo.TabIndex = 3;
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
            // groupBox_paymentMandatoryFields
            // 
            groupBox_paymentMandatoryFields.Controls.Add(checkBox_defaultPaymentUnitType);
            groupBox_paymentMandatoryFields.Controls.Add(label_projectNo);
            groupBox_paymentMandatoryFields.Controls.Add(label_paymentUnitType);
            groupBox_paymentMandatoryFields.Controls.Add(comboBox_paymentProjectNo);
            groupBox_paymentMandatoryFields.Controls.Add(comboBox_paymentUnitType);
            groupBox_paymentMandatoryFields.Controls.Add(comboBox_paymentInvoiceDate);
            groupBox_paymentMandatoryFields.Controls.Add(label_paymentInvoiceDate);
            groupBox_paymentMandatoryFields.Controls.Add(label_paymentAmount);
            groupBox_paymentMandatoryFields.Controls.Add(comboBox_paymentAmount);
            groupBox_paymentMandatoryFields.Controls.Add(label_paymentQuantity);
            groupBox_paymentMandatoryFields.Controls.Add(label_paymentContractName);
            groupBox_paymentMandatoryFields.Controls.Add(comboBox_paymentQuantity);
            groupBox_paymentMandatoryFields.Controls.Add(comboBox_paymentContractName);
            groupBox_paymentMandatoryFields.Controls.Add(label_paymentName);
            groupBox_paymentMandatoryFields.Controls.Add(comboBox_paymentName);
            groupBox_paymentMandatoryFields.Location = new System.Drawing.Point(184, 62);
            groupBox_paymentMandatoryFields.Name = "groupBox_paymentMandatoryFields";
            groupBox_paymentMandatoryFields.Size = new System.Drawing.Size(384, 253);
            groupBox_paymentMandatoryFields.TabIndex = 5;
            groupBox_paymentMandatoryFields.TabStop = false;
            groupBox_paymentMandatoryFields.Text = "Mandatory";
            // 
            // checkBox_defaultPaymentUnitType
            // 
            checkBox_defaultPaymentUnitType.AutoSize = true;
            checkBox_defaultPaymentUnitType.Location = new System.Drawing.Point(308, 215);
            checkBox_defaultPaymentUnitType.Name = "checkBox_defaultPaymentUnitType";
            checkBox_defaultPaymentUnitType.Size = new System.Drawing.Size(70, 21);
            checkBox_defaultPaymentUnitType.TabIndex = 9;
            checkBox_defaultPaymentUnitType.Text = "Default";
            defaultToolTip.SetToolTip(checkBox_defaultPaymentUnitType, "Set default values for all rows of a particular column field");
            checkBox_defaultPaymentUnitType.UseVisualStyleBackColor = true;
            checkBox_defaultPaymentUnitType.CheckedChanged += checkBox_defaultPaymentUnitType_CheckedChanged;
            // 
            // label_projectNo
            // 
            label_projectNo.AutoSize = true;
            label_projectNo.Location = new System.Drawing.Point(5, 58);
            label_projectNo.Name = "label_projectNo";
            label_projectNo.Size = new System.Drawing.Size(72, 17);
            label_projectNo.TabIndex = 1;
            label_projectNo.Text = "Project No";
            // 
            // label_paymentUnitType
            // 
            label_paymentUnitType.AutoSize = true;
            label_paymentUnitType.Location = new System.Drawing.Point(6, 213);
            label_paymentUnitType.Name = "label_paymentUnitType";
            label_paymentUnitType.Size = new System.Drawing.Size(64, 17);
            label_paymentUnitType.TabIndex = 7;
            label_paymentUnitType.Text = "Unit type";
            // 
            // comboBox_paymentProjectNo
            // 
            comboBox_paymentProjectNo.FormattingEnabled = true;
            comboBox_paymentProjectNo.Location = new System.Drawing.Point(163, 58);
            comboBox_paymentProjectNo.Name = "comboBox_paymentProjectNo";
            comboBox_paymentProjectNo.Size = new System.Drawing.Size(139, 25);
            comboBox_paymentProjectNo.TabIndex = 3;
            // 
            // comboBox_paymentUnitType
            // 
            comboBox_paymentUnitType.FormattingEnabled = true;
            comboBox_paymentUnitType.Location = new System.Drawing.Point(163, 213);
            comboBox_paymentUnitType.Name = "comboBox_paymentUnitType";
            comboBox_paymentUnitType.Size = new System.Drawing.Size(139, 25);
            comboBox_paymentUnitType.TabIndex = 8;
            // 
            // comboBox_paymentInvoiceDate
            // 
            comboBox_paymentInvoiceDate.FormattingEnabled = true;
            comboBox_paymentInvoiceDate.Location = new System.Drawing.Point(163, 120);
            comboBox_paymentInvoiceDate.Name = "comboBox_paymentInvoiceDate";
            comboBox_paymentInvoiceDate.Size = new System.Drawing.Size(139, 25);
            comboBox_paymentInvoiceDate.TabIndex = 3;
            // 
            // label_paymentInvoiceDate
            // 
            label_paymentInvoiceDate.AutoSize = true;
            label_paymentInvoiceDate.Location = new System.Drawing.Point(6, 123);
            label_paymentInvoiceDate.Name = "label_paymentInvoiceDate";
            label_paymentInvoiceDate.Size = new System.Drawing.Size(83, 17);
            label_paymentInvoiceDate.TabIndex = 1;
            label_paymentInvoiceDate.Text = "Invoice Date";
            // 
            // label_paymentAmount
            // 
            label_paymentAmount.AutoSize = true;
            label_paymentAmount.Location = new System.Drawing.Point(6, 151);
            label_paymentAmount.Name = "label_paymentAmount";
            label_paymentAmount.Size = new System.Drawing.Size(58, 17);
            label_paymentAmount.TabIndex = 1;
            label_paymentAmount.Text = "Amount";
            // 
            // comboBox_paymentAmount
            // 
            comboBox_paymentAmount.FormattingEnabled = true;
            comboBox_paymentAmount.Location = new System.Drawing.Point(163, 151);
            comboBox_paymentAmount.Name = "comboBox_paymentAmount";
            comboBox_paymentAmount.Size = new System.Drawing.Size(139, 25);
            comboBox_paymentAmount.TabIndex = 3;
            // 
            // label_paymentQuantity
            // 
            label_paymentQuantity.AutoSize = true;
            label_paymentQuantity.Location = new System.Drawing.Point(6, 182);
            label_paymentQuantity.Name = "label_paymentQuantity";
            label_paymentQuantity.Size = new System.Drawing.Size(61, 17);
            label_paymentQuantity.TabIndex = 1;
            label_paymentQuantity.Text = "Quantity";
            // 
            // label_paymentContractName
            // 
            label_paymentContractName.AutoSize = true;
            label_paymentContractName.Location = new System.Drawing.Point(6, 89);
            label_paymentContractName.Name = "label_paymentContractName";
            label_paymentContractName.Size = new System.Drawing.Size(100, 17);
            label_paymentContractName.TabIndex = 1;
            label_paymentContractName.Text = "Contract Name";
            // 
            // comboBox_paymentQuantity
            // 
            comboBox_paymentQuantity.FormattingEnabled = true;
            comboBox_paymentQuantity.Location = new System.Drawing.Point(163, 182);
            comboBox_paymentQuantity.Name = "comboBox_paymentQuantity";
            comboBox_paymentQuantity.Size = new System.Drawing.Size(139, 25);
            comboBox_paymentQuantity.TabIndex = 3;
            // 
            // comboBox_paymentContractName
            // 
            comboBox_paymentContractName.FormattingEnabled = true;
            comboBox_paymentContractName.Location = new System.Drawing.Point(163, 89);
            comboBox_paymentContractName.Name = "comboBox_paymentContractName";
            comboBox_paymentContractName.Size = new System.Drawing.Size(139, 25);
            comboBox_paymentContractName.TabIndex = 3;
            // 
            // label_paymentName
            // 
            label_paymentName.AutoSize = true;
            label_paymentName.Location = new System.Drawing.Point(6, 27);
            label_paymentName.Name = "label_paymentName";
            label_paymentName.Size = new System.Drawing.Size(102, 17);
            label_paymentName.TabIndex = 1;
            label_paymentName.Text = "Payment Name";
            // 
            // comboBox_paymentName
            // 
            comboBox_paymentName.FormattingEnabled = true;
            comboBox_paymentName.Location = new System.Drawing.Point(163, 27);
            comboBox_paymentName.Name = "comboBox_paymentName";
            comboBox_paymentName.Size = new System.Drawing.Size(139, 25);
            comboBox_paymentName.TabIndex = 3;
            // 
            // label_paymentSetup
            // 
            label_paymentSetup.AutoSize = true;
            label_paymentSetup.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            label_paymentSetup.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            label_paymentSetup.Location = new System.Drawing.Point(7, 16);
            label_paymentSetup.Name = "label_paymentSetup";
            label_paymentSetup.Size = new System.Drawing.Size(250, 32);
            label_paymentSetup.TabIndex = 0;
            label_paymentSetup.Text = "Payment Data Import";
            // 
            // button_paymentSelectFile
            // 
            button_paymentSelectFile.BackColor = System.Drawing.Color.FromArgb(226, 43, 141);
            button_paymentSelectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            button_paymentSelectFile.FlatAppearance.BorderSize = 0;
            button_paymentSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_paymentSelectFile.ForeColor = System.Drawing.Color.White;
            button_paymentSelectFile.Location = new System.Drawing.Point(13, 111);
            button_paymentSelectFile.Name = "button_paymentSelectFile";
            button_paymentSelectFile.Size = new System.Drawing.Size(80, 29);
            button_paymentSelectFile.TabIndex = 4;
            button_paymentSelectFile.Text = "Select File";
            defaultToolTip.SetToolTip(button_paymentSelectFile, "Select input CSV file");
            button_paymentSelectFile.UseVisualStyleBackColor = false;
            button_paymentSelectFile.Click += button_select_payment_file_Click;
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
            // UserControl_PaymentImport
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel_paymentFieldMapping);
            Controls.Add(panel_paymentButtons);
            Controls.Add(panel_paymentMessage);
            Controls.Add(panel_paymentDataTable);
            Name = "UserControl_PaymentImport";
            Size = new System.Drawing.Size(1006, 642);
            panel_paymentDataTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_payment).EndInit();
            panel_paymentMessage.ResumeLayout(false);
            panel_paymentMessage.PerformLayout();
            panel_paymentButtons.ResumeLayout(false);
            panel_paymentFieldMapping.ResumeLayout(false);
            panel_paymentFieldMapping.PerformLayout();
            flowLayoutPanel_nonMandatoryFields.ResumeLayout(false);
            panel_NonMandatoryButton.ResumeLayout(false);
            panel_NonMandatoryButton.PerformLayout();
            panel_NonMandatoryFields.ResumeLayout(false);
            panel_NonMandatoryFields.PerformLayout();
            groupBox_paymentMandatoryFields.ResumeLayout(false);
            groupBox_paymentMandatoryFields.PerformLayout();
            ResumeLayout(false);

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
