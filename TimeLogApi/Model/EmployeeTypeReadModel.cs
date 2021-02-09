using System;

namespace TimeLog.DataImporter.TimeLogApi.Model
{
    public class EmployeeTypeReadModel
    {
        /// <summary>
        /// Gets or sets the employee type ID
        /// </summary>
        /// <value>
        /// The employee type ID
        /// </value>
        public int EmployeeTypeID { get; set; }

        /// <summary>
        /// Gets or sets the employee type GUID
        /// </summary>
        /// <value>
        /// The employee type GUID
        /// </value>
        public Guid ID { get; set;}

        /// <summary>
        /// Gets or sets whether the employee type is active
        /// </summary>
        /// <value>
        /// <c>true</c> if the employee type is active; otherwise, <c>false</c>.
        /// </value>
        public bool IsActive { get; set;}

        /// <summary>
        /// Gets or sets the employee type name
        /// </summary>
        /// <value>
        /// The employee type name
        /// </value>
        public string Name { get; set; }
    }
}