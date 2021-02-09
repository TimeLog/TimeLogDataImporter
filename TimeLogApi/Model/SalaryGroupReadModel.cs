using System;

namespace TimeLog.DataImporter.TimeLogApi.Model
{
    public class SalaryGroupReadModel
    {
        #region Variables

        /// <summary>
        /// Gets or sets the salary group ID
        /// </summary>
        /// <value>
        /// The salary group ID
        /// </value>
        public int SalaryGroupID { get; set; }

        /// <summary>
        /// Gets or sets the salary group name
        /// </summary>
        /// <value>
        /// The salary group name
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the salary group GUID
        /// </summary>
        /// <value>
        /// The salary group GUID
        /// </value>
        public Guid ID { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        /// <value>
        /// The description
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets whether the salary group is active
        /// </summary>
        /// <value>
        /// <c>true</c> if the salary group is active; otherwise, <c>false</c>.
        /// </value>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets whether the salary group is system salary group
        /// </summary>
        /// <value>
        /// <c>true</c> if the salary group is system salary group; otherwise, <c>false</c>.
        /// </value>
        public bool IsSystemSalaryGroup { get; set; }

        #endregion
    }
}