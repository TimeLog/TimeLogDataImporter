using System;

namespace TimeLog.DataImporter.TimeLogApi.Model
{
    public class HolidayCalendarReadModel 
    {
        #region Variables

        /// <summary>
        /// Gets or sets the holiday calendar ID
        /// </summary>
        /// <value>
        /// The holiday calendar ID
        /// </value>
        public int HolidayCalendarID { get; set; }

        /// <summary>
        /// Gets or sets the holiday calendar name
        /// </summary>
        /// <value>
        /// The holiday calendar name
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the holiday calendar GUID
        /// </summary>
        /// <value>
        /// The holiday calendar GUID
        /// </value>
        public Guid ID { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        /// <value>
        /// The description
        /// </value>
        public string Description { get; set; }

        #endregion
    }
}