using System;

namespace TimeLog.DataImporter.TimeLogApi.Model
{
    public class ProjectExpenseCreateModel
    {
        /// <summary>
        /// Gets or sets the comment
        /// </summary>
        /// <value>
        /// The comment
        /// </value>
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the project ID
        /// </summary>
        /// <value>
        /// The project ID
        /// </value>
        public int ProjectID { get; set; }

        /// <summary>
        /// Gets or sets the purchase date
        /// </summary>
        /// <value>
        /// The purchase date
        /// </value>
        public DateTime PurchaseDate { get; set; }

        /// <summary>
        /// Gets or sets the payment method ID
        /// </summary>
        /// <value>
        /// The payment method ID
        /// </value>
        public int PaymentMethodID { get; set; }

        /// <summary>
        /// Gets or sets the expense type ID
        /// </summary>
        /// <value>
        /// The expense type ID
        /// </value>
        public int ExpenseTypeID { get; set; }

        /// <summary>
        /// Gets or sets the amount including VAT in expense currency
        /// </summary>
        /// <value>
        /// The amount including VAT
        /// </value>
        public double AmountIncludingVatExpenseCurrency { get; set; }

        /// <summary>
        /// Gets or sets the sales price amount in project currency
        /// </summary>
        /// <value> 
        /// The sales price amount
        /// </value>
        public double SalesPriceAmountProjectCurrency { get; set; }

        /// <summary>
        /// Gets or sets whether the expense is billable
        /// </summary>
        /// <value>
        /// <c>true</c> if the expense is billable; otherwise, <c>false</c>.
        /// </value>
        public bool IsBillable { get; set; }

        /// <summary>
        /// Gets or sets the expense number
        /// </summary>
        /// <value>
        /// The expense number
        /// </value>
        public string ExpenseNo { get; set; }

        /// <summary>
        /// Gets or sets the VAT amount in Expense Currency
        /// </summary>
        /// <value>
        /// The VAT amount 
        /// </value>
        public double VatAmountExpenseCurrency { get; set; }

        /// <summary>
        /// Gets or sets the currency ISO
        /// </summary>
        /// <value>
        /// The currency ISO
        /// </value>
        public string ExpenseCurrencyISO { get; set; }

        /// <summary>
        /// Gets or sets the external ID
        /// </summary>
        /// <value>
        /// The external ID
        /// </value>
        public string ExternalID { get; set; }

        /// <summary>
        /// Gets or sets the project sub contract ID
        /// </summary>
        /// <value>
        /// The project sub contract ID
        /// </value>
        public int ProjectSubContractID { get; set; }

        /// <summary>
        /// Gets or sets the exchange rate
        /// </summary>
        /// <value>
        /// The exchange rate
        /// </value>
        public double ProjectExpenseExchangeRate { get; set; }

        /// <summary>
        /// Gets or sets the supplier ID
        /// </summary>
        /// <value>
        /// The supplier ID
        /// </value>
        public int? SupplierID { get; set; }

        /// <summary>
        /// Gets or sets the supplier invoice number
        /// </summary>
        /// <value>
        /// The supplier invoice number
        /// </value>
        public string SupplierInvoiceNo { get; set; }

        /// <summary>
        /// Gets or sets the profit ratio
        /// </summary>
        /// <value>
        /// The profit ratio
        /// </value>
        public double ProfitRatio { get; set; }
    }
}