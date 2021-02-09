using System;

namespace TimeLog.DataImporter.TimeLogApi.Model
{
    public class CostPriceReadModel
    {
        #region Variables

        /// <summary>
        /// Gets or sets the cost price ID
        /// </summary>
        /// <value>
        /// The cost price ID
        /// </value>
        public int CostPriceID { get; set; }

        /// <summary>
        /// Gets or sets the amount
        /// </summary>
        /// <value>
        /// The amount
        /// </value>
        public double Amount { get; set; }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        /// <value>
        /// The name
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets whether the cost price is default
        /// </summary>
        /// <value>
        /// <c>true</c> if the cost price is default; otherwise, <c>false</c>.
        /// </value>
        public bool IsDefault { get; set; }

        /// <summary>
        /// Gets or sets whether the cost price is active
        /// </summary>
        /// <value>
        /// <c>true</c> if the cost price is active; otherwise, <c>false</c>.
        /// </value>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the cost price GUID
        /// </summary>
        /// <value>
        /// The cost price GUID
        /// </value>
        public Guid ID { get; set; }

        #endregion
    }
}