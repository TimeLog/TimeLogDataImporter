using System;

namespace TimeLog.DataImporter.TimeLogApi.Model
{
    public class EmployeeCreateModel
    {
        /// <summary>
        /// Gets or sets the Username
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string UserName { get; set; }

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
        /// The lastname.
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
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the employee number.
        /// </summary>
        /// <value>
        /// The employee number.
        /// </value>
        public string EmployeeNo { get; set; }

        /// <summary>
        /// Gets or sets the employment date.
        /// </summary>
        /// <value>
        /// The the employment date.
        /// </value>
        public DateTime EmploymentDate { get; set; }

        /// <summary>
        /// Gets or sets the legal entity id.
        /// </summary>
        /// <value>
        /// The ID of the legal entity.
        /// </value>
        public int LegalEntityID { get; set; }

        /// <summary>
        /// Gets or sets the department id.
        /// </summary>
        /// <value>
        /// The ID of the department.
        /// </value>
        public int DepartmentID { get; set; }

        /// <summary>
        /// Gets or sets the approval manager id.
        /// </summary>
        /// <value>
        /// The ID of the approval manager.
        /// </value>
        public int ApprovalManagerID { get; set; }

        /// <summary>
        /// Gets or sets the employee type id.
        /// </summary>
        /// <value>
        /// The ID of the employee type.
        /// </value>
        public int EmployeeTypeID { get; set; }

        /// <summary>
        /// Gets or sets the standard hourly rate id.
        /// </summary>
        /// <value>
        /// The ID of the standard hourly rate.
        /// </value>
        public int StandardHourlyRateID { get; set; }

        /// <summary>
        /// Gets or sets the cost price id.
        /// </summary>
        /// <value>
        /// The ID of the cost price.
        /// </value>
        public int CostPriceID { get; set; }

        /// <summary>
        /// Gets or sets the public holiday calendar id.
        /// </summary>
        /// <value>
        /// The ID of the public holiday calendar.
        /// </value>
        public int PublicHolidayCalendarID { get; set; }

        /// <summary>
        /// Gets or sets the allowance legislation id.
        /// </summary>
        /// <value>
        /// The ID of the allowance legislation id.
        /// </value>
        public int AllowanceLegislationID { get; set; }

        /// <summary>
        /// Gets or sets the normal working time id.
        /// </summary>
        /// <value>
        /// The ID of the normal working time.
        /// </value>
        public int NormalWorkingTimeID { get; set; }

        /// <summary>
        /// Gets or sets the salary group id.
        /// </summary>
        /// <value>
        /// The ID of the salary group.
        /// </value>
        public int SalaryGroupID { get; set; }

        ///// <summary>
        ///// Gets or sets the user license type.
        ///// </summary>
        ///// <value>
        ///// The user license type.
        ///// </value>
        //public UserLicenseTypes UserLicenseType { get; set; }

        /// <summary>
        /// Gets or sets the active roles on the user.
        /// </summary>
        /// <value>
        /// An array with the ID of the user roles to activate.
        /// </value>
        public int[] UserRoleIDs { get; set; }
    }
}