using System;

namespace TimeLog.DataImporter.TimeLogApi.Model
{
    public class PaymentCreateModel
    {
        /// <summary>
        /// Gets or sets the name
        /// </summary>
        /// <value>
        /// The name
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the project ID
        /// </summary>
        /// <value>
        /// The project ID
        /// </value>
        public int ProjectID { get; set; }

        /// <summary>
        /// Gets or sets the project sub contract ID
        /// </summary>
        /// <value>
        /// The project sub contract ID
        /// </value>
        public int ProjectSubContractID { get; set; }

        /// <summary>
        /// Gets or sets the task ID
        /// </summary>
        /// <value>
        /// The task ID
        /// </value>
        public int TaskID { get; set; }

        /// <summary>
        /// Gets or sets the invoice date
        /// </summary>
        /// <value>
        /// The invoice date
        /// </value>
        public DateTime InvoiceDate { get; set; }

        /// <summary>
        /// Gets or sets the amount
        /// </summary>
        /// <value>
        /// The amount
        /// </value>
        public double Amount { get; set; }

        /// <summary>
        /// Gets or sets the quantity
        /// </summary>
        /// <value>
        /// The quantity
        /// </value>
        public double Quantity { get; set; }

        /// <summary>
        /// Gets or sets the unit type
        /// </summary>
        /// <value>
        /// The unit type
        /// </value>
        public int UnitTypeID { get; set; }

        /// <summary>
        /// Gets or sets the product number
        /// </summary>
        /// <value>
        /// The product number
        /// </value>
        public string ProductNumber { get; set; }

        /// <summary>
        /// Gets or sets the discount
        /// </summary>
        /// <value>
        /// The discount
        /// </value>
        public double DiscountPercentage { get; set; }

        /// <summary>
        /// Gets or sets the comment
        /// </summary>
        /// <value>
        /// The comment
        /// </value>
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is ready for invoicing
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is ready for invoicing; otherwise, <c>false</c>
        /// </value>
        public bool IsReadyForInvoicing { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the payment is fixed price
        /// </summary>
        /// <value>
        /// <c>true</c> if this payment is fixed price; otherwise, <c>false</c>
        /// </value>
        public bool IsFixedPricePayment { get; set; }

        
    }
}