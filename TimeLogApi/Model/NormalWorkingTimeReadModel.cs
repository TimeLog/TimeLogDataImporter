using System;

namespace TimeLog.DataImporter.TimeLogApi.Model
{
    public class NormalWorkingTimeReadModel 
    {
        #region Variables

        /// <summary>
        /// Gets or sets the normal working time ID
        /// </summary>
        /// <value>
        /// The normal working time ID
        /// </value>
        public int NormalWorkingTimeID { get; set; }

        /// <summary>
        /// Gets or sets the normal working time name
        /// </summary>
        /// <value>
        /// The normal working time name
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the normal working time GUID
        /// </summary>
        /// <value>
        /// The normal working time GUID
        /// </value>
        public Guid ID { get; set; }


        /// <summary>
        /// Gets or sets whether the normal working time is active
        /// </summary>
        /// <value>
        /// <c>true</c> if the normal working time is active; otherwise, <c>false</c>.
        /// </value>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets whether the normal working time is default
        /// </summary>
        /// <value>
        /// <c>true</c> if the normal working time is default; otherwise, <c>false</c>.
        /// </value>
        public bool IsDefault { get; set; }

        #endregion
    }
}