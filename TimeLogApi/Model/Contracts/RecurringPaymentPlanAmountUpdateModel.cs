using System;
using System.Collections.Generic;
using System.Text;

namespace TimeLog.DataImporter.TimeLogApi.Model.Contracts
{
    public class RecurringPaymentPlanAmountUpdateModel 
    {
        /// <summary>
        /// Gets or set the projectNo for the entity
        /// </summary>
        /// <value>
        /// The project No
        /// </value>
        public int ProjectId { get; set; }

        /// <summary>
        /// Gets or set the ProjectSubContractId for the entity
        /// </summary>
        /// <value>
        /// The project sub contract id
        /// </value>
        public int ProjectSubContractId { get; set; }


        /// <summary>
        /// Gets or set the value of the hourly rate
        /// </summary>
        /// <value>
        /// The hourly rate value
        /// </value>
        public double PaymentPlanAmount { get; set; }

    }
}
