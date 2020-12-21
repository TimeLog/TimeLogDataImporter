using System;

namespace TimeLog.DataImporter.TimeLogApi.Model
{
    public class ExpenseTypeReadModel
    {
        /// <summary>
        /// Gets or sets the expense type identifier.
        /// </summary>
        /// <value>
        /// The expense type identifier.
        /// </value>
        public int ExpenseTypeID { get; set; }

        /// <summary>
        /// Gets or sets the name of the expense type.
        /// </summary>
        /// <value>
        /// The name of the expense type.
        /// </value>
        public string ExpenseTypeName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [show in travel].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show in travel]; otherwise, <c>false</c>.
        /// </value>
        public bool ShowInTravel { get; set; }

        /// <summary>
        /// Gets or sets the account no.
        /// </summary>
        /// <value>
        /// The account no.
        /// </value>
        public string AccountNo { get; set; }

        /// <summary>
        /// Gets or sets the vat.
        /// </summary>
        /// <value>
        /// The vat.
        /// </value>
        public double VAT { get; set; }

        /// <summary>
        /// Gets or sets the product no.
        /// </summary>
        /// <value>
        /// The product no.
        /// </value>
        public string ProductNo { get; set; }

        /// <summary>
        /// Gets or sets the salary code.
        /// </summary>
        /// <value>
        /// The salary code.
        /// </value>
        public string SalaryCode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is active; otherwise, <c>false</c>.
        /// </value>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is equipment.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is equipment; otherwise, <c>false</c>.
        /// </value>
        public bool IsEquipment { get; set; }

        /// <summary>
        /// Gets or sets the cost price.
        /// </summary>
        /// <value>
        /// The cost price.
        /// </value>
        public double CostPrice { get; set; }

        /// <summary>
        /// Gets or sets the sales price.
        /// </summary>
        /// <value>
        /// The sales price.
        /// </value>
        public double SalesPrice { get; set; }

        /// <summary>
        /// Gets or sets the equipment text.
        /// </summary>
        /// <value>
        /// The equipment text.
        /// </value>
        public string EquipmentText { get; set; }
    }
}