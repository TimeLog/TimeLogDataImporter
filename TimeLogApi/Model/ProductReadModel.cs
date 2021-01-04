using System;
using Newtonsoft.Json;

namespace TimeLog.DataImporter.TimeLogApi.Model
{
    public class ProductReadModel
    {
        /// <summary>
        /// Gets or sets the product number ID
        /// </summary>
        /// <value>
        /// The product number ID
        /// </value>
        public int ProductNumberID { get; set; }

        /// <summary>
        /// Gets or sets the product number
        /// </summary>
        /// <value>
        /// The product number
        /// </value>
        public string ProductNumber { get; set; }

        /// <summary>
        /// Gets or sets the product name
        /// </summary>
        /// <value>
        /// The product name
        /// </value>
        public string ProductName { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        /// <value>
        /// The description
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets whether the VAT is used
        /// </summary>
        /// <value>
        /// <c>true</c> if the VAT is used; otherwise, <c>false</c>.
        /// </value>
        public bool UseVAT { get; set; }

        /// <summary>
        /// Gets or sets the VAT percentage
        /// </summary>
        /// <value>
        /// The VAT percentage
        /// </value>
        public double VATPercentage { get; set; }

        /// <summary>
        /// Gets or sets whether the product is active
        /// </summary>
        /// <value>
        /// <c>true</c> if the product is active; otherwise, <c>false</c>.
        /// </value>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the product number GUID
        /// </summary>
        /// <value>
        /// The product number GUID
        /// </value>
        public Guid ProductNumberGuid { get; set; }

        /// <summary>
        /// Gets or sets the legal entity ID
        /// </summary>
        /// <value>
        /// The legal entity ID
        /// </value>
        public int LegalEntityID { get; set; }
    }
}