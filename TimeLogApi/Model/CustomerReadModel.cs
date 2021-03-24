using System;

namespace TimeLog.DataImporter.TimeLogApi.Model
{
    public class CustomerReadModel
    {
        /// <summary>
        /// Gets or sets the customer identifier.
        /// </summary>
        /// <value>
        /// The customer identifier.
        /// </value>
        public int CustomerID { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid ID { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the no.
        /// </summary>
        /// <value>
        /// The no.
        /// </value>
        public string No { get; set; }

        /// <summary>
        /// Gets or sets the default mileage
        /// </summary>
        /// <value>
        /// Default mileage for customer.
        /// </value>
        public int DefaultMileageDistance { get; set; }

        /// <summary>
        /// Gets or sets the customer status ID.
        /// </summary>
        /// <value>
        /// The customer status ID.
        /// </value>
        public int CustomerStatusID { get; set; }
    }
}