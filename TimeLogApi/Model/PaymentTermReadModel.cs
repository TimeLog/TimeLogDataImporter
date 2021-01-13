using System;

namespace TimeLog.DataImporter.TimeLogApi.Model
{
    public class PaymentTermReadModel
    {
        /// <summary>
        /// Gets or sets the payment term ID
        /// </summary>
        /// <value>
        /// The payment term ID
        /// </value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the payment term name
        /// </summary>
        /// <value>
        /// The payment term name
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the term message
        /// </summary>
        /// <value>
        /// The term message
        /// </value>
        public string TermMessage { get; set; }

        /// <summary>
        /// Gets or sets the credit term
        /// </summary>
        /// <value>
        /// The credit term
        /// </value>
        public string CreditTerm { get; set; }

        /// <summary>
        /// Gets or sets the days of credit
        /// </summary>
        /// <value>
        /// The days of credit
        /// </value>
        public int DaysOfCredit { get; set; }

        /// <summary>
        /// Gets or sets the interest rate
        /// </summary>
        /// <value>
        /// The interest rate
        /// </value>
        public double InterestRate { get; set; }

        /// <summary>
        /// Gets or sets the interest period
        /// </summary>
        /// <value>
        /// The interest period
        /// </value>
        public string InterestPeriod { get; set; }

        /// <summary>
        /// Gets or sets the reminder fee
        /// </summary>
        /// <value>
        /// The reminder fee
        /// </value>
        public double ReminderFee { get; set; }

        /// <summary>
        /// Gets or sets whether this payment term is default term
        /// </summary>
        /// <value>
        ///   <c>true</c> if this payment term is default term; otherwise, <c>false</c>.
        /// </value>
        public bool IsDefaultTerm { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is active
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is active; otherwise, <c>false</c>.
        /// </value>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the currency ID
        /// </summary>
        /// <value>
        /// The currency ID
        /// </value>
        public int CurrencyID { get; set; }

        /// <summary>
        /// Gets or sets the payment term Guid
        /// </summary>
        /// <value>
        /// The payment term Guid
        /// </value>
        public Guid PaymentTermGuid { get; set; }
    }
}