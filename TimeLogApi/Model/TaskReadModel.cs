using System;

namespace TimeLog.DataImporter.TimeLogApi.Model
{
    public class TaskReadModel
    {
        /// <summary>
        /// Gets or sets the task identifier.
        /// </summary>
        /// <value>
        /// The task identifier.
        /// </value>
        public int TaskID { get; set; }

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
        /// Gets or sets a value indicating whether this instance is fixed price.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is fixed price; otherwise, <c>false</c>.
        /// </value>
        public bool IsFixedPrice { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is default billable.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is default billable; otherwise, <c>false</c>.
        /// </value>
        public bool IsDefaultBillable { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance requires additional text to be entered.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is requires additional text; otherwise, <c>false</c>.
        /// </value>
        public bool AdditionalTextIsRequired { get; set; }

        /// <summary>
        /// Gets or sets the full name of the parent.
        /// </summary>
        /// <value>
        /// The full name of the parent.
        /// </value>
        public string ParentFullName { get; set; }

        /// <summary>
        /// Gets or sets the project identifier.
        /// </summary>
        /// <value>
        /// The project identifier.
        /// </value>
        public int ProjectID { get; set; }

        /// <summary>
        /// Gets or sets the project.
        /// </summary>
        /// <value>
        /// The project.
        /// </value>
        public ProjectHeaderReadModel Project { get; set; }

        /// <summary>
        /// Gets or sets the parent task ID.
        /// </summary>
        /// <value>
        /// The parent task ID.
        /// </value>
        public int? ParentTaskID { get; set; }
    }
}