using System;

namespace TimeLog.DataImporter.TimeLogApi.Model
{
    public class HourlyRateReadModel
    {
        /// <summary>
        /// Gets or sets the hourly rate ID
        /// </summary>
        /// <value>
        /// The hourly rate ID
        /// </value>
        public int HourlyRateID { get; set; }

        /// <summary>
        /// Gets or sets the hourly rate name
        /// </summary>
        /// <value>
        /// The hourly rate name
        /// </value>
        public string HourlyRateName { get; set; }

        /// <summary>
        /// Gets or sets the amount
        /// </summary>
        /// <value>
        /// The amount
        /// </value>
        public double Amount { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        /// <value>
        /// The description
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets whether the hourly rate is active
        /// </summary>
        /// <value>
        /// <c>true</c> if the hourly rate is active; otherwise, <c>false</c>.
        /// </value>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the customer ID
        /// </summary>
        /// <value>
        /// The customer ID
        /// </value>
        public int? CustomerID { get; set; }

        /// <summary>
        /// Gets or sets the product number
        /// </summary>
        /// <value>
        /// The product number
        /// </value>
        public string ProductNo { get; set; }

        /// <summary>
        /// Gets or sets the hourly rate GUID
        /// </summary>
        /// <value>
        /// The hourly rate GUID
        /// </value>
        public Guid ID { get; set; }

        /// <summary>
        /// Gets or sets the service ID
        /// </summary>
        /// <value>
        /// The service ID
        /// </value>
        public int ServiceID { get; set; }

        /// <summary>
        /// Gets or sets the currency ID
        /// </summary>
        /// <value>
        /// The currency ID
        /// </value>
        public int CurrencyID { get; set; }

        /// <summary>
        /// Gets or sets whether the hourly rate is default
        /// </summary>
        /// <value>
        /// <c>true</c> if the hourly rate is default; otherwise, <c>false</c>.
        /// </value>
        public bool IsDefault { get; set; }
    }
}