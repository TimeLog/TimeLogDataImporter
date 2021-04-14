using System;

namespace TimeLog.DataImporter.TimeLogApi.Model
{
    public class AbsenceCodeReadModel
    {
        /// <summary>
        /// Gets or sets the absence code identifier.
        /// </summary>
        /// <value>
        /// The absence code identifier.
        /// </value>
        public int AbsenceCodeID { get; set; }

        /// <summary>
        /// Gets or sets the absence code.
        /// </summary>
        /// <value>
        /// The absence code.
        /// </value>
        public string AbsenceCode { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is active; otherwise, <c>false</c>.
        /// </value>
        public bool IsActive { get; set; }

       

    }
}