using System;
using System.Collections.Generic;
using System.Text;

namespace TimeLog.DataImporter.TimeLogApi.Model
{
    public class ContractHourlyRateApiCreateModel 
    {
        /// <summary>
        /// Gets or set the projectId for the entity
        /// </summary>
        /// <value>
        /// The project Id
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
        /// Gets or set the new hourly rate name
        /// </summary>
        /// <value>
        /// The name of the hourly rate
        /// </value>
        public string ContractHourlyRateName { get; set; }

        /// <summary>
        /// Gets or set the value of the hourly rate
        /// </summary>
        /// <value>
        /// The hourly rate value
        /// </value>
        public double ContractHourlyRateValue { get; set; }

        /// <summary>
        /// Gets or set the product no. for the hourly rate
        /// </summary>
        /// <value>
        /// The product no.
        /// </value>
        public string ProductNo { get; set; }

        /// <summary>
        /// Gets or set the contract hourly rate category
        /// </summary>
        /// <value>
        /// The contract hourly rate category value (AddRateToContract, AddRateToStandard,AddRateToCustomer)
        /// </value>
        public string ContractHourlyRateCreateCategory;

    }
}
