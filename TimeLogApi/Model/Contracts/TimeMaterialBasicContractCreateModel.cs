using System;

public class TimeMaterialBasicContractCreateModel : ProjectSubContractCreateModelBase
{
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
    /// Gets or sets whether the contract has budget overrun notification
    /// </summary>
    /// <value>
    /// <c>true</c> if the contract has budget overrun notification; otherwise, <c>false</c>
    /// </value>
    public bool? HasBudgetOverrunNotification { get; set; }

    #endregion
}