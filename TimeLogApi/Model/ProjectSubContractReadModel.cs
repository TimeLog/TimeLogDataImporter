using System;

namespace TimeLog.DataImporter.TimeLogApi.Model
{
    public class ProjectSubContractReadModel
    {
        /// <summary>
        /// Gets or sets the contract ID
        /// </summary>
        /// <value>
        /// The contract ID
        /// </value>
        public int ContractID { get; set; }

        /// <summary>
        /// Gets or sets the contract GUID
        /// </summary>
        /// <value>
        /// The contract GUID
        /// </value>
        public Guid ContractGuid { get; set; }

        /// <summary>
        /// Gets or sets the contract model type
        /// </summary>
        /// <value>
        /// The contract model type
        /// </value>
        public int ContractModelType { get; set; }

        /// <summary>
        /// Gets or sets the project ID
        /// </summary>
        /// <value>
        /// The project ID
        /// </value>
        public int ProjectID { get; set; }

        /// <summary>
        /// Gets or sets whether the contract is a main contract
        /// </summary>
        /// <value>
        /// <c>true</c> if the contract is a main contract; otherwise, <c>false</c>.
        /// </value>
        public bool IsMainContract { get; set; }

        /// <summary>
        /// Gets or sets the contract name
        /// </summary>
        /// <value>
        /// The contract name
        /// </value>
        public string ContractName { get; set; }

        /// <summary>
        /// Gets or sets the contract status
        /// </summary>
        /// <value>
        /// The contract status
        /// </value>
        public ProjectSubContractStatus ContractStatus { get; set; }

        /// <summary>
        /// Gets or sets whether the mileage is billable
        /// </summary>
        /// <value>
        /// <c>true</c> if the mileage is billable; otherwise, <c>false</c>.
        /// </value>
        public bool IsMileageBillable { get; set; }

        /// <summary>
        /// Gets or sets whether the expenses are default
        /// </summary>
        /// <value>
        /// <c>true</c> if the expenses are default; otherwise, <c>false</c>.
        /// </value>
        public bool? IsDefaultExpenses { get; set; }
    }

    public enum ProjectSubContractStatus
    {
        Quotation = 1,
        Active = 2,
        Completed = 3,
        Cancelled = 4
    }

    //public enum ContractModelType
    //{
    //    /// <summary>
    //    /// The Time and Material Standard Agreement contract type
    //    /// </summary>
    //    TimeMaterialBasic = 1,

    //    /// <summary>
    //    /// The fixed price standard agreement contract type
    //    /// </summary>
    //    FixedPriceBasic = 2,

    //    /// <summary>
    //    /// The On Account with end balancing - Time and Material contract type
    //    /// </summary>
    //    TimeMaterialAccountEndBalancing = 3,

    //    /// <summary>
    //    /// The On Account with periodic balancing - Time and Material contract type
    //    /// Recurrence Contract
    //    /// </summary>
    //    TimeMaterialAccountPeriodicBalancing = 4,

    //    /// <summary>
    //    /// The prepaid hours - Time and Material contract type
    //    /// </summary>
    //    PrepaidServices = 5,

    //    /// <summary>
    //    /// The revenue request per task - fixed price contract type (TDR = task driven revenue)
    //    /// </summary>
    //    TaskDrivenRevenue = 6,

    //    /// <summary>
    //    /// The revenue request per period - fixed price contract type (continuous service)
    //    /// Recurrence Contract
    //    /// </summary>
    //    ContinuousService = 7,

    //    /// <summary>
    //    /// The volumn invoicing - fixed price contract type (FPVI)
    //    /// Recurrence Contract
    //    /// </summary>
    //    ContinuousItemInvoicing = 8,

    //    #region System contracts

    //    /// <summary>
    //    /// Recurring Product Contract for expenses generated from recurring product sales
    //    /// </summary>
    //    RecurringProductContract = 20

    //    #endregion
    //}
}