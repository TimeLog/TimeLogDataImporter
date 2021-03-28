using System;

public class PrepaidServicesContractCreateModel : ProjectSubContractCreateModelBase
{
    public PrepaidServicesContractCreateModel(ProjectSubContractCreateModelBase contractModelBase) : base(contractModelBase)
    {

    }
    #region Variables
    /// <summary>
    /// Gets or sets whether the hourly rate is fixed
    /// </summary>
    /// <value>
    /// <c>true</c> if the hourly rate is fixed; otherwise, <c>false</c>
    /// </value>
    public bool IsFixedHourlyRate { get; set; }

    /// <summary>
    /// Gets or sets the hourly rate price
    /// </summary>
    /// <value>
    /// The hourly rate price
    /// </value>
    public double HourlyRatePrice { get; set; }

    /// <summary>
    /// Gets or sets the hourly rate name
    /// </summary>
    /// <value>
    /// The hourly rate name
    /// </value>
    public string HourlyRateName { get; set; }

    #endregion
}