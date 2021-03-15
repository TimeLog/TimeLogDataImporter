using System;
using TimeLog.DataImporter.TimeLogApi.Model;

public class ProjectSubContractCreateModelBase
{
    /// <summary>
    /// Gets or sets the project ID
    /// </summary>
    /// <value>
    /// The project ID
    /// </value>
    public int ProjectID { get; set; }

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
    /// Gets or sets the userID of the contract owner
    /// </summary>
    /// <value>
    /// The contract owner userID
    /// </value>
    public int ContractOwnerUserID { get; set; }

    /// <summary>
    /// Gets or sets the budget work amount
    /// </summary>
    /// <value>
    /// The budget work amount
    /// </value>
    public double BudgetWorkAmount { get; set; }

    /// <summary>
    /// Gets or sets the budget work hour
    /// </summary>
    /// <value>
    /// The budget work hour
    /// </value>
    public double BudgetWorkHour { get; set; }

    /// <summary>
    /// Gets or sets whether the contract has completion notification
    /// </summary>
    /// <value>
    /// <c>true</c> if the contract has completion notification; otherwise, <c>false</c>
    /// </value>
    public bool HasCompletionNotification { get; set; }

    /// <summary>
    /// Gets or sets the completion notification percentage
    /// </summary>
    /// <value>
    /// The completion notification percentage
    /// </value>
    public double CompletionNotificationPercentage { get; set; }

    /// <summary>
    /// Gets or sets whether the mileage is billable
    /// </summary>
    /// <value>
    /// <c>true</c> if the mileage is billable; otherwise, <c>false</c>
    /// </value>
    public bool IsMileageBillable { get; set; }

    /// <summary>
    /// Gets or sets whether the expenses are default
    /// </summary>
    /// <value>
    /// <c>true</c> if the expenses are default; otherwise, <c>false</c>
    /// </value>
    public bool IsDefaultExpenses { get; set; }
}