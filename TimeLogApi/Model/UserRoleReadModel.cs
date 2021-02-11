using System;

namespace TimeLog.DataImporter.TimeLogApi.Model
{
    public class UserRoleReadModel
    {
        #region Variables

        /// <summary>
        /// Gets or sets the Role identifier.
        /// </summary>
        /// <value>
        /// The Role identifier.
        /// </value>
        public int RoleID { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        /// <value>
        /// The Description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is active; otherwise, <c>false</c>.
        /// </value>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is a locked system role.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is a locked system role; otherwise, <c>false</c>.
        /// </value>
        public bool IsLockedSystemRole { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid ID { get; set; }

        #endregion
    }
}