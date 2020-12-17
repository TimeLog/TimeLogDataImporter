using System;

namespace TimeLog.DataImporter.TimeLogApi.Model
{
    public class DepartmentReadModel
    {
        /// <summary>
        /// Gets or sets the Department identifier.
        /// </summary>
        /// <value>
        /// The Department  identifier.
        /// </value>
        public int DepartmentID { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is active; otherwise, <c>false</c>.
        /// </value>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the No.
        /// </summary>
        /// <value>
        /// The No.
        /// </value>
        public string No { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid ID { get; set; }

        /// <summary>
        /// Gets or sets the Parent identifier.
        /// </summary>
        /// <value>
        /// The Parent identifier.
        /// </value>
        public int ParentID { get; set; }

        /// <summary>
        /// Gets or sets the Manager Employee identifier.
        /// </summary>
        /// <value>
        /// The Manager Employee identifier.
        /// </value>
        public int ManagerEmployeeID { get; set; }
    }
}