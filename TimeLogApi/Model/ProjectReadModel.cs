using System;

namespace TimeLog.DataImporter.TimeLogApi.Model
{
    public class ProjectReadModel
    {
        /// <summary>
        /// Gets or sets the project identifier.
        /// </summary>
        /// <value>
        /// The project identifier.
        /// </value>
        public int ProjectID { get; set; }

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
        /// Gets or sets a value indicating whether [expense is billable].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [expense is billable]; otherwise, <c>false</c>.
        /// </value>
        public bool ExpenseIsBillable { get; set; }

        /// <summary>
        /// Gets or sets the customer identifier.
        /// </summary>
        /// <value>
        /// The customer identifier.
        /// </value>
        public int CustomerID { get; set; }

        /// <summary>
        /// Gets or sets the customer.
        /// </summary>
        /// <value>
        /// The customer.
        /// </value>
        public CustomerReadModel Customer { get; set; }
    }
}