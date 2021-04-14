using System;
using System.Collections.Generic;
using System.Text;

namespace TimeLog.DataImporter.TimeLogApi.Model
{
    public class TimeregistrationCreateModel
    {
        #region Variables


        /// <summary>
        /// Gets or sets the task identifier.
        /// </summary>
        /// <value>
        /// The task identifier.
        /// </value>
        public int TaskID { get; set; }

        /// <summary>
        /// Gets or sets the project identifier.
        /// </summary>
        /// <value>
        /// The project identifier.
        /// </value>
        public int ProjectID { get; set; }

        /// <summary>
        /// Gets or sets the contract identifier.
        /// </summary>
        /// <value>
        /// The contract identifier.
        /// </value>
        public int ContractID { get; set; }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        public int UserID { get; set; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the hours.
        /// </summary>
        /// <value>
        /// The hours.
        /// </value>
        public double? Hours { get; set; }

        /// <summary>
        /// Gets or sets the type of the group.
        /// </summary>
        /// <value>
        /// The type of the group.
        /// </value>
        public int GroupType { get; set; }

        /// <summary>
        /// Gets or sets the type of the group.
        /// </summary>
        /// <value>
        /// The type of the group.
        /// </value>
        public int AbsenceCodeID { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this timeregistration is billable.
        /// </summary>
        /// <value>
        ///   <c>true</c> if billable; otherwise, <c>false</c>.
        /// </value>
        public bool Billable { get; set; }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        /// <value>
        /// The comment.
        /// </value>
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the additional comment.
        /// </summary>
        /// <value>
        /// The additional comment.
        /// </value>
        public string AdditionalComment { get; set; }

        /// <summary>
        /// Gets or sets the billable hours.
        /// </summary>
        /// <value>
        /// The billable hours.
        /// </value>
        public double? BillableHours { get; set; }


        public string MonthlyPeriod { get; set; }

        /// <summary>
        /// Gets or sets the hourly rate.
        /// </summary>
        /// <value>
        /// The hourly rate.
        /// </value>
        public double HourlyRate { get; set; }

        /// <summary>
        /// Gets or sets the hourly rate name.
        /// </summary>
        /// <value>
        /// The hourly rate name.
        /// </value>
        public string HourlyRateName { get; set; }

        /// <summary>
        /// Gets or sets the cost price.
        /// </summary>
        /// <value>
        /// The cost price.
        /// </value>
        public double CostPrice { get; set; }

        /// <summary>
        /// Gets or sets the cost price name.
        /// </summary>
        /// <value>
        /// The cost price name.
        /// </value>
        public string CostPriceName { get; set; }
        #endregion
    }
}