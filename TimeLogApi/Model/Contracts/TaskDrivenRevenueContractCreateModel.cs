using System;

public class TaskDrivenRevenueContractCreateModel : ProjectSubContractCreateModelBase
{
    public TaskDrivenRevenueContractCreateModel(ProjectSubContractCreateModelBase contractModelBase) : base(contractModelBase)
    {

    }
    #region Variables

    /// <summary>
    /// Gets or sets the budget expenses amount
    /// </summary>
    /// <value>
    /// The budget expenses amount
    /// </value>
    public double BudgetExpensesAmount { get; set; }

    /// <summary>
    /// Gets or sets the budget travel amount
    /// </summary>
    /// <value>
    /// The budget travel amount
    /// </value>
    public double BudgetTravelAmount { get; set; }


    /// <summary>
    /// Gets or sets the target hourly rate
    /// </summary>
    /// <value>
    /// The target hourly rate
    /// </value>
    public double TargetHourlyRate { get; set; }


    /// <summary>
    /// Gets or sets the payment plan amount
    /// </summary>
    /// <value>
    /// The payment plan amount
    /// </value>
    public double PaymentPlanAmount { get; set; }

    /// <summary>
    /// Gets or sets the revenue expr amount
    /// </summary>
    /// <value>
    /// The revenue expr amount
    /// </value>
    public double RevenueExpensesAmount { get; set; }

    /// <summary>
    /// Gets or sets the revenue travel amount
    /// </summary>
    /// <value>
    /// The revenue travel amount
    /// </value>
    public double RevenueTravelAmount { get; set; }

    /// <summary>
    /// Gets or sets whether the expenses are linked to revenue distribution
    /// </summary>
    /// <value>
    /// <c>true</c> if the expenses are linked; otherwise, <c>false</c>
    /// </value>
    public bool IsExpensesLinked { get; set; }

    /// <summary>
    /// Gets or sets whether the travel are linked to revenue distribution
    /// </summary>
    /// <value>
    /// <c>true</c> if the contract is travel linked; otherwise, <c>false</c>
    /// </value>
    public bool IsTravelLinked { get; set; }

    #endregion
}