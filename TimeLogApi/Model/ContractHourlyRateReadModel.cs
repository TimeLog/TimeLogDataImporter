using System;

namespace TimeLog.DataImporter.TimeLogApi.Model
{
    public class ContractHourlyRateReadModel 
    {
        #region Variables

        /// <summary>
        /// Gets or sets the contract hourly rate ID
        /// </summary>
        /// <value>
        /// The contract hourly rate ID
        /// </value>
        public int ContractHourlyRateID { get; set; }

        /// <summary>
        /// Gets or sets the contract hourly rate GUID
        /// </summary>
        /// <value>
        /// The contract hourly rate GUID
        /// </value>
        public Guid ContractHourlyRateGUID { get; set; }

        /// <summary>
        /// Gets or sets the project sub contract ID
        /// </summary>
        /// <value>
        /// The project sub contract ID
        /// </value>
        public int ProjectSubContractID { get; set; }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        /// <value>
        /// The name
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the amount
        /// </summary>
        /// <value>
        /// The amount
        /// </value>
        public double Amount { get; set; }

        /// <summary>
        /// Gets or sets the type
        /// </summary>
        /// <value>
        /// The type
        /// </value>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the contract specific hourly rate ID
        /// </summary>
        /// <value>
        /// The contract specific hourly rate ID
        /// </value>
        public int? ContractSpecificHourlyRateID { get; set; }

        /// <summary>
        /// Gets or sets whether the contract hourly rate is active
        /// </summary>
        /// <value>
        /// <c>true</c> if the contract hourly rate is active; otherwise, <c>false</c>.
        /// </value>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets whether the contract hourly rate is manually adjusted
        /// </summary>
        /// <value>
        /// <c>true</c> if the contract hourly rate is manually adjusted; otherwise, <c>false</c>.
        /// </value>
        public bool IsManuallyAdjusted { get; set; }

        /// <summary>
        /// Gets or sets the product number
        /// </summary>
        /// <value>
        /// The product number
        /// </value>
        public string ProductNo { get; set; }

        /// <summary>
        /// Gets or sets the currency ISO
        /// </summary>
        /// <value>
        /// The currency ISO
        /// </value>
        public string CurrencyISO { get; set; }

        #endregion
    }
}