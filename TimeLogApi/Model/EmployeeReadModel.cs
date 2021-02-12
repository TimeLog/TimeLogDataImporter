using System;

namespace TimeLog.DataImporter.TimeLogApi.Model
{
    public class EmployeeReadModel
    {
        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        public int UserID { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid ID { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the initials.
        /// </summary>
        /// <value>
        /// The initials.
        /// </value>
        public string Initials { get; set; }

        /// <summary>
        /// Gets or sets if the user is active.
        /// </summary>
        /// <value>
        /// <c>true</c> if this user is active; otherwise, <c>false</c>.
        /// </value>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the user type.
        /// </summary>
        /// <value>
        /// The user type
        /// </value>
        public int UserType { get; set; }

    }
}