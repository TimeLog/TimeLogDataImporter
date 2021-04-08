using System;

namespace TimeLog.DataImporter.TimeLogApi.Model
{
    public class TaskCreateModel
    {
        /// <summary>
        /// Gets or sets the task number
        /// </summary>
        /// <value>
        /// The task number
        /// </value>
        public string TaskNo { get; set; }

        /// <summary>
        /// Gets or sets the task name
        /// </summary>
        /// <value>
        /// The task name
        /// </value>
        public string TaskName { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        /// <value>
        /// The description
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the start date
        /// </summary>
        /// <value>
        /// The start date
        /// </value>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date
        /// </summary>
        /// <value>
        /// The end date
        /// </value>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether additional text is required
        /// </summary>
        /// <value>
        ///   <c>true</c> if additional text is required; otherwise, <c>false</c>.
        /// </value>
        public bool AdditionalTextIsRequired { get; set; }

        /// <summary>
        /// Gets or sets the budget hours
        /// </summary>
        /// <value>
        /// The budget hours
        /// </value>
        public double BudgetHours { get; set; }

        /// <summary>
        /// Gets or sets the budget amount
        /// </summary>
        /// <value>
        /// The budget amount
        /// </value>
        public double BudgetAmount { get; set; }

        /// <summary>
        /// Gets or sets the project sub contract ID
        /// </summary>
        /// <value>
        /// The project sub contract ID
        /// </value>
        public int ProjectSubContractID { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the task is ready for invoicing
        /// </summary>
        /// <value>
        ///   <c>true</c> if the task is ready for invoicing; otherwise, <c>false</c>.
        /// </value>
        public bool IsReadyForInvoicing { get; set; }

        /// <summary>
        /// Gets or sets the task type ID
        /// </summary>
        /// <value>
        /// The task type ID
        /// </value>
        public int? TaskTypeID { get; set; }

        /// <summary>
        /// Gets or sets the hourly rate ID
        /// </summary>
        /// <value>
        /// The hourly rate ID
        /// </value>
        public int? HourlyRateID { get; set; }

        /// <summary>
        /// Gets or sets the project ID
        /// </summary>
        /// <value>
        /// The project ID
        /// </value>
        public int ProjectID { get; set; }

        /// <summary>
        /// Gets or sets the parent task ID
        /// </summary>
        /// <value>
        /// The parent task ID
        /// </value>
        public int? ParentTaskID { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the task is billable
        /// </summary>
        /// <value>
        ///   <c>true</c> if the task is billable; otherwise, <c>false</c>.
        /// </value>
        public bool IsBillable { get; set; }

        /// <summary>
        /// Gets or sets the PaymentRecognitionModel
        /// </summary>
        /// <value>
        /// The PaymentRecognitionModel value (0 = undefined, 1 = OverallPaymentPlan, 2 = FixedPricePayment)
        /// </value>
        public PaymentRecognitionModelTypes PaymentRecognitionModel { get; set; }

        /// <summary>
        /// Gets or sets the payment amount
        /// </summary>
        /// <value>
        /// The budget amount
        /// </value>
        public double PaymentAmount { get; set; }

        /// <summary>
        /// Gets or sets the hourly rate of a TDR task
        /// </summary>
        /// <value>
        /// The hourly rate 
        /// </value>
        public double TaskHourlyRate { get; set; }

        /// <summary>
        /// Gets or sets the payment product no. for a TDR task
        /// </summary>
        /// <value>
        /// The product no.
        /// </value>
        public string PaymentProductNo { get; set; }

        /// <summary>
        /// Gets or sets the payment name for a TDR task
        /// </summary>
        /// <value>
        /// The name
        /// </value>
        public string PaymentName { get; set; }

        /// <summary>
        /// Gets or sets the payment invoice date for a TDR task
        /// </summary>
        /// <value>
        /// The invoice date
        /// </value>
        public DateTime? PaymentInvoiceDate { get; set; }
    }

    public enum PaymentRecognitionModelTypes
    {
        OverallPaymentPlan = 1,
        FixedPricePayment = 2,
        Undefined = 0
    }
}