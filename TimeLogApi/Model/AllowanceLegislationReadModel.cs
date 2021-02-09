using System;

namespace TimeLog.DataImporter.TimeLogApi.Model
{
    public class AllowanceLegislationReadModel
    {
        #region Variables

        /// <summary>
        /// Gets or sets the allowance legislation ID
        /// </summary>
        /// <value>
        /// The allowance legislation ID
        /// </value>
        public int AllowanceLegislationID { get; set; }

        /// <summary>
        /// Gets or sets the country ID
        /// </summary>
        /// <value>
        /// The country ID
        /// </value>
        public int CountryID { get; set; }

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