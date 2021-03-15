using System;

public class PrepaidServicesContractCreateModel : ProjectSubContractCreateModelBase
{
    #region Variables

    /// <summary>
    /// Gets or sets whether the hourly rate is fixed
    /// </summary>
    /// <value>
    /// <c>true</c> if the hourly rate is fixed; otherwise, <c>false</c>
    /// </value>
    public bool IsFixedHourlyRate { get; set; }

    /// <summary>
    /// Gets or sets the hourly rate ID
    /// </summary>
    /// <value>
    /// The hourly rate ID
    /// </value>
    public int HourlyRateServiceID { get; set; }

    #endregion
}