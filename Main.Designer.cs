using System.Windows.Forms;
using TimeLog.DataImporter.UserControls;

namespace TimeLog.DataImporter
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_customer = new System.Windows.Forms.TabPage();
            this.userControl_CustomerImport = new UserControl_CustomerImport();
            this.tabPage_contactPerson = new System.Windows.Forms.TabPage();
            this.userControl_ContactPersonImport = new UserControl_ContactPersonImport();
            this.tabPage_project = new System.Windows.Forms.TabPage();
            this.userControl_ProjectImport = new UserControl_ProjectImport();
            this.tabPage_payment = new System.Windows.Forms.TabPage();
            this.userControl_PaymentImport = new UserControl_PaymentImport();
            this.tabPage_contract = new System.Windows.Forms.TabPage();
            this.userControl_ContractImport = new UserControl_ContractImport();
            this.tabPage_employee = new System.Windows.Forms.TabPage();
            this.userControl_EmployeeImport = new UserControl_EmployeeImport();
            this.tabPage_projectExpense = new System.Windows.Forms.TabPage();
            this.userControl_ProjectExpenseImport = new UserControl_ProjectExpenseImport();
            this.tabPage_task = new System.Windows.Forms.TabPage();
            this.userControl_TaskImport = new UserControl_TaskImport();
            this.tabPage_timeregistration = new System.Windows.Forms.TabPage();
            this.userControl_TimeregistrationImport = new UserControl_TimeregistrationImport();
            this.tabPage_recurringPaymentPlanUpdate = new System.Windows.Forms.TabPage();
            this.userControl_RecurringPaymentPlanUpdate = new UserControl_RecurringPaymentPlanUpdate();
            this.tabPage_hourlyRate= new System.Windows.Forms.TabPage();
            this.userControl_HourlyRateImport = new UserControl_HourlyRateImport();
            this.tabPage_help = new System.Windows.Forms.TabPage();
            this.userControl_Help = new UserControl_Help();
            this.tabPage_logout = new System.Windows.Forms.TabPage();
            this.userControl_Logout = new UserControl_Logout();
            this.tabControl1.SuspendLayout();
            this.tabPage_customer.SuspendLayout();
            this.tabPage_contactPerson.SuspendLayout();
            this.tabPage_project.SuspendLayout();
            this.tabPage_payment.SuspendLayout();
            this.tabPage_contract.SuspendLayout();
            this.tabPage_employee.SuspendLayout();
            this.tabPage_projectExpense.SuspendLayout();
            this.tabPage_task.SuspendLayout();
            this.tabPage_timeregistration.SuspendLayout();
            this.tabPage_recurringPaymentPlanUpdate.SuspendLayout();
            this.tabPage_hourlyRate.SuspendLayout();
            this.tabPage_help.SuspendLayout();
            this.tabPage_logout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_employee);
            this.tabControl1.Controls.Add(this.tabPage_customer);
            this.tabControl1.Controls.Add(this.tabPage_contactPerson);
            this.tabControl1.Controls.Add(this.tabPage_project);
            this.tabControl1.Controls.Add(this.tabPage_task);
            this.tabControl1.Controls.Add(this.tabPage_contract);
            this.tabControl1.Controls.Add(this.tabPage_payment);
            this.tabControl1.Controls.Add(this.tabPage_projectExpense);
            this.tabControl1.Controls.Add(this.tabPage_timeregistration);
            this.tabControl1.Controls.Add(this.tabPage_recurringPaymentPlanUpdate);
            this.tabControl1.Controls.Add(this.tabPage_hourlyRate);
            
            this.tabControl1.Controls.Add(this.tabPage_help);
            this.tabControl1.Controls.Add(this.tabPage_logout);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1006, 942);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_customer
            // 
            this.tabPage_customer.AutoScroll = true;
            this.tabPage_customer.Controls.Add(this.userControl_CustomerImport);
            this.tabPage_customer.Location = new System.Drawing.Point(4, 24);
            this.tabPage_customer.Name = "tabPage_customer";
            this.tabPage_customer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_customer.Size = new System.Drawing.Size(998, 914);
            this.tabPage_customer.TabIndex = 0;
            this.tabPage_customer.Text = "Customer";
            this.tabPage_customer.UseVisualStyleBackColor = true;
            // 
            // userControl_CustomerImport
            // 
            this.userControl_CustomerImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_CustomerImport.Location = new System.Drawing.Point(3, 3);
            this.userControl_CustomerImport.Name = "userControl_CustomerImport";
            this.userControl_CustomerImport.Size = new System.Drawing.Size(992, 908);
            this.userControl_CustomerImport.TabIndex = 0;
            // 
            // tabPage_contactPerson
            // 
            this.tabPage_contactPerson.AutoScroll = true;
            this.tabPage_contactPerson.Controls.Add(this.userControl_ContactPersonImport);
            this.tabPage_contactPerson.Location = new System.Drawing.Point(4, 24);
            this.tabPage_contactPerson.Name = "tabPage_contactPerson";
            this.tabPage_contactPerson.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_contactPerson.Size = new System.Drawing.Size(998, 914);
            this.tabPage_contactPerson.TabIndex = 1;
            this.tabPage_contactPerson.Text = "Contact Person";
            this.tabPage_contactPerson.UseVisualStyleBackColor = true;
            // 
            // userControl_ContactPersonImport
            // 
            this.userControl_ContactPersonImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_ContactPersonImport.Location = new System.Drawing.Point(3, 3);
            this.userControl_ContactPersonImport.Name = "userControl_ContactPersonImport";
            this.userControl_ContactPersonImport.Size = new System.Drawing.Size(992, 908);
            this.userControl_ContactPersonImport.TabIndex = 0;
            //
            // 
            // tabPage_project
            // 
            this.tabPage_project.AutoScroll = true;
            this.tabPage_project.Controls.Add(this.userControl_ProjectImport);
            this.tabPage_project.Location = new System.Drawing.Point(4, 24);
            this.tabPage_project.Name = "tabPage_project";
            this.tabPage_project.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_project.Size = new System.Drawing.Size(998, 914);
            this.tabPage_project.TabIndex = 2;
            this.tabPage_project.Text = "Project";
            this.tabPage_project.UseVisualStyleBackColor = true;
            // 
            // userControl_ProjectImport
            // 
            this.userControl_ProjectImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_ProjectImport.Location = new System.Drawing.Point(3, 3);
            this.userControl_ProjectImport.Name = "userControl_ProjectImport";
            this.userControl_ProjectImport.Size = new System.Drawing.Size(992, 908);
            this.userControl_ProjectImport.TabIndex = 0;
            // 
            // tabPage_payment
            // 
            this.tabPage_payment.AutoScroll = true;
            this.tabPage_payment.Controls.Add(this.userControl_PaymentImport);
            this.tabPage_payment.Location = new System.Drawing.Point(4, 24);
            this.tabPage_payment.Name = "tabPage_payment";
            this.tabPage_payment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_payment.Size = new System.Drawing.Size(998, 914);
            this.tabPage_payment.TabIndex = 3;
            this.tabPage_payment.Text = "Payment";
            this.tabPage_payment.UseVisualStyleBackColor = true;
            // 
            // userControl_PaymentImport
            // 
            this.userControl_PaymentImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_PaymentImport.Location = new System.Drawing.Point(3, 3);
            this.userControl_PaymentImport.Name = "userControl_PaymentImport";
            this.userControl_PaymentImport.Size = new System.Drawing.Size(992, 908);
            this.userControl_PaymentImport.TabIndex = 0;
            // 
            // tabPage_contract
            // 
            this.tabPage_contract.AutoScroll = true;
            this.tabPage_contract.Controls.Add(this.userControl_ContractImport);
            this.tabPage_contract.Location = new System.Drawing.Point(4, 24);
            this.tabPage_contract.Name = "tabPage_contract";
            this.tabPage_contract.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_contract.Size = new System.Drawing.Size(998, 914);
            this.tabPage_contract.TabIndex = 5;
            this.tabPage_contract.Text = "Contract";
            this.tabPage_contract.UseVisualStyleBackColor = true;
            // 
            // userControl_ContractImport
            // 
            this.userControl_ContractImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_ContractImport.Location = new System.Drawing.Point(3, 3);
            this.userControl_ContractImport.Name = "userControl_ContractImport";
            this.userControl_ContractImport.Size = new System.Drawing.Size(992, 908);
            this.userControl_ContractImport.TabIndex = 0;
            // 
            // tabPage_employee
            // 
            this.tabPage_employee.AutoScroll = true;
            this.tabPage_employee.Controls.Add(this.userControl_EmployeeImport);
            this.tabPage_employee.Location = new System.Drawing.Point(4, 24);
            this.tabPage_employee.Name = "tabPage_employee";
            this.tabPage_employee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_employee.Size = new System.Drawing.Size(998, 914);
            this.tabPage_employee.TabIndex = 2;
            this.tabPage_employee.Text = "Employee";
            this.tabPage_employee.UseVisualStyleBackColor = true;
            // 
            // userControl_EmployeeImport
            // 
            this.userControl_EmployeeImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_EmployeeImport.Location = new System.Drawing.Point(3, 3);
            this.userControl_EmployeeImport.Name = "userControl_EmployeeImport";
            this.userControl_EmployeeImport.Size = new System.Drawing.Size(992, 908);
            this.userControl_EmployeeImport.TabIndex = 0;
            // 
            // tabPage_projectExpense
            // 
            this.tabPage_projectExpense.AutoScroll = true;
            this.tabPage_projectExpense.Controls.Add(this.userControl_ProjectExpenseImport);
            this.tabPage_projectExpense.Location = new System.Drawing.Point(4, 24);
            this.tabPage_projectExpense.Name = "tabPage_projectExpense";
            this.tabPage_projectExpense.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_projectExpense.Size = new System.Drawing.Size(998, 914);
            this.tabPage_projectExpense.TabIndex = 3;
            this.tabPage_projectExpense.Text = "Project Expense";
            this.tabPage_projectExpense.UseVisualStyleBackColor = true;
            // 
            // userControl_ProjectExpenseImport
            // 
            this.userControl_ProjectExpenseImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_ProjectExpenseImport.Location = new System.Drawing.Point(3, 3);
            this.userControl_ProjectExpenseImport.Name = "userControl_ProjectExpenseImport";
            this.userControl_ProjectExpenseImport.Size = new System.Drawing.Size(992, 908);
            this.userControl_ProjectExpenseImport.TabIndex = 0;
            // 
            // tabPage_task
            // 
            this.tabPage_task.AutoScroll = true;
            this.tabPage_task.Controls.Add(this.userControl_TaskImport);
            this.tabPage_task.Location = new System.Drawing.Point(4, 24);
            this.tabPage_task.Name = "tabPage_task";
            this.tabPage_task.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_task.Size = new System.Drawing.Size(998, 914);
            this.tabPage_task.TabIndex = 4;
            this.tabPage_task.Text = "Task";
            this.tabPage_task.UseVisualStyleBackColor = true;
            // 
            // tabPage_timeregistration
            // 
            this.tabPage_timeregistration.AutoScroll = true;
            this.tabPage_timeregistration.Controls.Add(this.userControl_TimeregistrationImport);
            this.tabPage_timeregistration.Location = new System.Drawing.Point(4, 24);
            this.tabPage_timeregistration.Name = "tabPage_timeregistration";
            this.tabPage_timeregistration.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_timeregistration.Size = new System.Drawing.Size(998, 914);
            this.tabPage_timeregistration.TabIndex = 5;
            this.tabPage_timeregistration.Text = "Timeregistration";
            this.tabPage_timeregistration.UseVisualStyleBackColor = true;
            // 
            // userControl_TaskImport
            // 
            this.userControl_TaskImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_TaskImport.Location = new System.Drawing.Point(3, 3);
            this.userControl_TaskImport.Name = "userControl_TaskImport";
            this.userControl_TaskImport.Size = new System.Drawing.Size(992, 908);
            this.userControl_TaskImport.TabIndex = 6;
            // 
            // userControl_TimeregistrationImport
            // 
            this.userControl_TimeregistrationImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_TimeregistrationImport.Location = new System.Drawing.Point(3, 3);
            this.userControl_TimeregistrationImport.Name = "userControl_TimeregistrationImport";
            this.userControl_TimeregistrationImport.Size = new System.Drawing.Size(992, 908);
            this.userControl_TimeregistrationImport.TabIndex = 0;

            // 
            // tabPage_recurringPaymentPlanUpdate
            // 
            this.tabPage_recurringPaymentPlanUpdate.AutoScroll = true;
            this.tabPage_recurringPaymentPlanUpdate.Controls.Add(this.userControl_RecurringPaymentPlanUpdate);
            this.tabPage_recurringPaymentPlanUpdate.Location = new System.Drawing.Point(4, 24);
            this.tabPage_recurringPaymentPlanUpdate.Name = "tabPage_recurringPaymentPlanUpdate";
            this.tabPage_recurringPaymentPlanUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_recurringPaymentPlanUpdate.Size = new System.Drawing.Size(998, 914);
            this.tabPage_recurringPaymentPlanUpdate.TabIndex = 4;
            this.tabPage_recurringPaymentPlanUpdate.Text = "RecurringPaymentPlanUpdate";
            this.tabPage_recurringPaymentPlanUpdate.UseVisualStyleBackColor = true;
            // 
            // userControl_RecurringPaymentPlanUpdate
            // 
            this.userControl_RecurringPaymentPlanUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_RecurringPaymentPlanUpdate.Location = new System.Drawing.Point(3, 3);
            this.userControl_RecurringPaymentPlanUpdate.Name = "userControl_RecurringPaymentPlanUpdate";
            this.userControl_RecurringPaymentPlanUpdate.Size = new System.Drawing.Size(992, 908);
            this.userControl_RecurringPaymentPlanUpdate.TabIndex = 0;

            // 
            // tabPage_hourlyRate
            // 
            this.tabPage_hourlyRate.AutoScroll = true;
            this.tabPage_hourlyRate.Controls.Add(this.userControl_HourlyRateImport);
            this.tabPage_hourlyRate.Location = new System.Drawing.Point(4, 24);
            this.tabPage_hourlyRate.Name = "tabPage_hourlyRate";
            this.tabPage_hourlyRate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_hourlyRate.Size = new System.Drawing.Size(998, 914);
            this.tabPage_hourlyRate.TabIndex = 4;
            this.tabPage_hourlyRate.Text = "Hourly Rate";
            this.tabPage_hourlyRate.UseVisualStyleBackColor = true;
            // 
            // userControl_HourlyRateImport
            // 
            this.userControl_HourlyRateImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_HourlyRateImport.Location = new System.Drawing.Point(3, 3);
            this.userControl_HourlyRateImport.Name = "userControl_HourlyRateImport";
            this.userControl_HourlyRateImport.Size = new System.Drawing.Size(992, 908);
            this.userControl_HourlyRateImport.TabIndex = 0;
            // 
            // tabPage_help
            // 
            this.tabPage_help.AutoScroll = true;
            this.tabPage_help.Controls.Add(this.userControl_Help);
            this.tabPage_help.Location = new System.Drawing.Point(4, 24);
            this.tabPage_help.Name = "tabPage_help";
            this.tabPage_help.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_help.Size = new System.Drawing.Size(998, 914);
            this.tabPage_help.TabIndex = 9;
            this.tabPage_help.Text = "Help";
            this.tabPage_help.UseVisualStyleBackColor = true;
            // 
            // userControl_Help
            // 
            this.userControl_Help.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Help.Location = new System.Drawing.Point(3, 3);
            this.userControl_Help.Name = "userControl_Help";
            this.userControl_Help.Size = new System.Drawing.Size(992, 908);
            this.userControl_Help.TabIndex = 0;
            // 
            // tabPage_logout
            // 
            this.tabPage_logout.AutoScroll = true;
            this.tabPage_logout.Controls.Add(this.userControl_Logout);
            this.tabPage_logout.Location = new System.Drawing.Point(4, 24);
            this.tabPage_logout.Name = "tabPage_logout";
            this.tabPage_logout.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_logout.Size = new System.Drawing.Size(998, 914);
            this.tabPage_logout.TabIndex = 10;
            this.tabPage_logout.Text = "Logout";
            this.tabPage_help.UseVisualStyleBackColor = true;
            // 
            // userControl_Logout
            // 
            this.userControl_Logout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Logout.Location = new System.Drawing.Point(3, 3);
            this.userControl_Logout.Name = "userControl_Logout";
            this.userControl_Logout.Size = new System.Drawing.Size(992, 908);
            this.userControl_Logout.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 942);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "TimeLog Data Importer";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_customer.ResumeLayout(false);
            this.tabPage_contactPerson.ResumeLayout(false);
            this.tabPage_project.ResumeLayout(false);
            this.tabPage_payment.ResumeLayout(false);
            this.tabPage_contract.ResumeLayout(false);
            this.tabPage_employee.ResumeLayout(false);
            this.tabPage_projectExpense.ResumeLayout(false);
            this.tabPage_task.ResumeLayout(false);
            this.tabPage_timeregistration.ResumeLayout(false);
            this.tabPage_recurringPaymentPlanUpdate.ResumeLayout(false);
            this.tabPage_hourlyRate.ResumeLayout(false);
            this.tabPage_help.ResumeLayout(false);
            this.tabPage_logout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public TabControl tabControl1;
        public TabPage tabPage_customer;
        public TabPage tabPage_contactPerson;
        public TabPage tabPage_project;
        public TabPage tabPage_payment;
        public TabPage tabPage_contract;
        public TabPage tabPage_employee;
        public TabPage tabPage_projectExpense;
        public TabPage tabPage_task;
        public TabPage tabPage_timeregistration;
        public TabPage tabPage_recurringPaymentPlanUpdate;
        public TabPage tabPage_hourlyRate;
        public TabPage tabPage_help;
        public TabPage tabPage_logout;
        public UserControl_CustomerImport userControl_CustomerImport;
        public UserControl_ContactPersonImport userControl_ContactPersonImport;
        public UserControl_ProjectImport userControl_ProjectImport;
        public UserControl_ContractImport userControl_ContractImport;
        public UserControl_EmployeeImport userControl_EmployeeImport;
        public UserControl_ProjectExpenseImport userControl_ProjectExpenseImport;
        public UserControl_TaskImport userControl_TaskImport;
        public UserControl_TimeregistrationImport userControl_TimeregistrationImport;
        public UserControl_RecurringPaymentPlanUpdate userControl_RecurringPaymentPlanUpdate;
        public UserControl_HourlyRateImport userControl_HourlyRateImport;
        public UserControl_PaymentImport userControl_PaymentImport;
        public UserControl_Help userControl_Help;
        public UserControl_Logout userControl_Logout;
    }
}