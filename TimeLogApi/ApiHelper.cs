using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace TimeLog.DataImporter.TimeLogApi
{
    public class ApiHelper
    {
        //public string SiteUrl = "https://app8.timelog.com/mdutestsite";
        //public string SiteUrl = "http://localhost/tlp";
        public string SiteUrl = "";

        public string CustomerValidateEndpoint = "/api/v1/customer/validate-new-customer";
        public string CustomerCreateEndpoint = "/api/v1/customer/create";
        public string ContactValidateEndpoint = "/api/v1/contact/validate-new-contact";
        public string ContactCreateEndpoint = "/api/v1/contact/create";
        public string ProjectValidateEndpoint = "/api/v1/project/validate-create-from-template";
        public string ProjectCreateEndpoint = "/api/v1/project/create-from-template";
        public string EmployeeValidateEndpoint = "/api/v1/user/validate-new-user";
        public string EmployeeCreateEndpoint = "/api/v1/user/create";
        public string ProjectExpenseValidateEndpoint = "/api/v1/project-expense/validate-project-expense";
        public string ProjectExpenseCreateEndpoint = "/api/v1/project-expense";
        public string TaskValidateEndpoint = "/api/v1/task/validate-new-task";
        public string TaskCreateEndpoint = "/api/v1/task/";
        public string SubTaskCreateEndpoint = "/api/v1/task/create-sub-task";
        public string TimeMaterialBasicValidateEndpoint = "/api/v1/contract/validate-time-material-basic-contract";
        public string TimeMaterialBasicCreateEndpoint = "/api/v1/contract/create-time-material-basic-contract";
        public string FixedPriceBasicValidateEndpoint = "/api/v1/contract/validate-fixed-price-basic-contract";
        public string FixedPriceBasicCreateEndpoint = "/api/v1/contract/create-fixed-price-basic-contract";
        public string TimeMaterialAccountEndBalancingValidateEndpoint = "/api/v1/contract/validate-time-material-account-end-balancing-contract";
        public string TimeMaterialAccountEndBalancingCreateEndpoint = "/api/v1/contract/create-time-material-account-end-balancing-contract";
        public string PrepaidServicesValidateEndpoint = "/api/v1/contract/validate-prepaid-services-contract";
        public string PrepaidServicesCreateEndpoint = "/api/v1/contract/create-prepaid-services-contract";
        public string TaskDrivenRevenueValidateEndpoint = "/api/v1/contract/validate-task-driven-revenue-contract";
        public string TaskDrivenRevenueCreateEndpoint = "/api/v1/contract/create-task-driven-revenue-contract";
        public string PaymentValidateEndpoint = "/api/v1/payment/validate-new-payment";
        public string PaymentCreateEndpoint = "/api/v1/payment";
        public string TimeregistrationValidateEndpoint = "/api/v1/time-registration/validate-import";
        public string TimeregistrationCreateEndpoint = "/api/v1/time-registration/import";

        public string RecurringPaymentPlanAmountUpdateEndpoint = "/api/v1/contract/update-recurring-contract-payment-plan-amount";
        public string RecurringPaymentPlanAmountUpdateValidateEndpoint = "/api/v1/contract/validate-update-recurring-contract-payment-plan-amount";

        public string HourlyRateCreateEndpoint = "/api/v1/contract-hourly-rate/create-hourly-rate";
        public string HourlyRateValidateEndpoint = "/api/v1/contract-hourly-rate/validate-hourly-rate";

        public string GetAllCountryEndpoint = "/api/v1/country/get-all?$page={0}&$pagesize=500";
        public string GetAllContractEndpoint = "/api/v1/contract?$page={0}&$pagesize=500";
        public string GetAllCustomerEndpoint = "/api/v1/customer?$page={0}&$pagesize=500";
        public string GetAllDepartmentEndpoint = "/api/v1/department?$page={0}&$pagesize=500";
        public string GetDefaultHourlyRatesEndpoint = "/api/v1/hourly-rate/default?$page={0}&$pagesize=500";
        public string GetAllContractHourlyRatesEndpoint = "/api/v1/contract-hourly-rate?$page={0}&$pagesize=500";
        public string GetAllEmployeeTypeEndpoint = "/api/v1/employee-type?$page={0}&$pagesize=500";  //user-type endpoint
        public string GetAllCostPriceEndpoint = "/api/v1/cost-price?$page={0}&$pagesize=500";
        public string GetAllHolidayCalendarEndpoint = "/api/v1/holiday-calendar?$page={0}&$pagesize=500";
        public string GetAllAllowanceLegislationEndpoint = "/api/v1/allowance-legislation?$page={0}&$pagesize=500";
        public string GetAllNormalWorkingTimeEndpoint = "/api/v1/normal-working-time?$page={0}&$pagesize=500";
        public string GetAllSalaryGroupEndpoint = "/api/v1/salary-group?$page={0}&$pagesize=500";
        public string GetAllIndustryEndpoint = "/api/v1/industry/get-all?$page={0}&$pagesize=500";
        public string GetAllCurrencyEndpoint = "/api/v1/currency/active?$page={0}&$pagesize=500";
        public string GetAllCustomerStatusEndpoint = "/api/v1/customerstatus?$page={0}&$pagesize=500";
        public string GetAllEmployeeEndpoint = "/api/v1/user?$page={0}&$pagesize=500";
        public string GetAllExpenseTypeEndpoint = "/api/v1/expense-type?$page={0}&$pagesize=500";
        public string GetAllPaymentTermEndpoint = "/api/v1/payment-term?$page={0}&$pagesize=500";
        public string GetAllPaymentMethodEndpoint = "/api/v1/payment-method?$page={0}&$pagesize=500";
        public string GetAllProjectEndpoint = "/api/v1/project/get-all?$page={0}&$pagesize=500";
        public string GetAllProjectTemplateEndpoint = "/api/v1/project-template/get-all?$page={0}&$pagesize=500";
        public string GetAllLegalEntityEndpoint = "/api/v1/legal-entity?$page={0}&$pagesize=500";
        public string GetAllProjectTypeEndpoint = "/api/v1/ProjectType?$page={0}&$pagesize=500";
        public string GetAllProjectCategoryEndpoint = "/api/v1/ProjectCategory?$page={0}&$pagesize=500";
        public string GetAllTaskEndpoint = "/api/v1/task?$page={0}&$pagesize=500";
        public string GetAllTaskTypeEndpoint = "/api/v1/TaskType?$page={0}&$pagesize=500";
        public string GetAllProductEndpoint = "/api/v1/product?$page={0}&$pagesize=500";
        public string GetAllUserRolesEndpoint = "/api/v1/role?$page={0}&$pagesize=500";
        public string GetAllContractModelsEndpoint = "/api/v1/ContractModel?$page={0}&$pagesize=500";
        public string GetAllUnitTypeEndpoint = "/api/v1/unit-type?$page={0}&$pagesize=500";
        public string GetAllAbsenceCodeEndpoint = "/api/v1/absence-code?$page={0}&$pagesize=500";
        public string GetContactPersonMethodEndpoint = "/api/v1/contact";

        private static ApiHelper _apiHelper;
        private static readonly object ApiHelperLock = new object();

        private ApiHelper()
        {
        }

        public static ApiHelper Instance
        {
            get
            {
                lock (ApiHelperLock)
                {
                    return _apiHelper ??= new ApiHelper();
                }
            }
        }

        public WebClient WebClient(string token)
        {
            var _client = new WebClient();
            _client.Encoding = Encoding.UTF8;
            _client.Headers.Add("Authorization", "Bearer " + token);
            _client.Headers.Add("Accept", "*/*");
            _client.Headers.Add("Content-Type", "application/json");
            return _client;
        }

        public DefaultApiResponse ProcessApiResponseContent(WebException webEx, string responseContent, out BusinessRulesApiResponse businessRulesApiResponse)
        {
            DefaultApiResponse _apiResponse = null;
            businessRulesApiResponse = null;

            if (webEx.Message == "The remote server returned an error: (401) Unauthorized.")
            {
                _apiResponse = JsonConvert.DeserializeObject<DefaultApiResponse>(responseContent);
                _apiResponse.Code = 401;
            } else
            {
                dynamic _apiResponseObject = JsonConvert.DeserializeObject<dynamic>(responseContent);

                switch (_apiResponseObject.Code.ToString())
                {
                    case "100":
                        _apiResponse = JsonConvert.DeserializeObject<DefaultApiResponse>(responseContent);
                        _apiResponse.Code = 100;
                        break;
                    case "102":
                        businessRulesApiResponse = JsonConvert.DeserializeObject<BusinessRulesApiResponse>(responseContent);
                        businessRulesApiResponse.Code = 102;
                        break;
                    case "200":
                        _apiResponse = JsonConvert.DeserializeObject<DefaultApiResponse>(responseContent);
                        _apiResponse.Code = 201;
                        break;                                        
                    default:
                        MessageBox.Show(webEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }

            return _apiResponse;
        }

        public int HandleApiResponse(DefaultApiResponse defaultResponse, DataGridViewRow row, BusinessRulesApiResponse businessRulesResponse, TextBox domainTextBox, BackgroundWorker workerFetcher, Control control)
        {
            int errorRowCount = 0;
            if (defaultResponse != null)
            {

                switch (defaultResponse.Code)
                {
                    case 100:
                        control.Invoke((MethodInvoker)(() => row.DefaultCellStyle.BackColor = Color.Red));
                        control.Invoke((MethodInvoker)(() => domainTextBox.AppendText(Environment.NewLine)));
                        control.Invoke((MethodInvoker)(() => domainTextBox.AppendText("Row " + (row.Index + 1) + " - " + defaultResponse.Message)));
                        errorRowCount++;
                        break;
                    case 200:
                        control.Invoke((MethodInvoker)(() => row.DefaultCellStyle.BackColor = Color.LimeGreen));
                        control.Invoke((MethodInvoker)(() => domainTextBox.AppendText(Environment.NewLine)));
                        control.Invoke((MethodInvoker)(() => domainTextBox.AppendText("Row " + (row.Index + 1) + " - " + defaultResponse.Message)));
                        break;
                    case 201:
                        control.Invoke((MethodInvoker)(() => row.DefaultCellStyle.BackColor = Color.Red));
                        control.Invoke((MethodInvoker)(() => domainTextBox.AppendText(Environment.NewLine)));
                        control.Invoke((MethodInvoker)(() => domainTextBox.AppendText("Row " + (row.Index + 1)
                                                        + " - " + defaultResponse.Message + " Details: " + string.Join(" | ", defaultResponse.Details))));
                        errorRowCount++;
                        break;
                    case 401:
                        control.Invoke((MethodInvoker)(() => row.DefaultCellStyle.BackColor = Color.Red));
                        control.Invoke((MethodInvoker)(() => domainTextBox.AppendText(Environment.NewLine)));
                        control.Invoke((MethodInvoker)(() => domainTextBox.AppendText("Row " + (row.Index + 1) + " - " + defaultResponse.Message)));
                        errorRowCount++;
                        //return to login page if token has expired
                        RedirectToLoginPage(workerFetcher, control);
                        break;
                    case 500:
                        control.Invoke((MethodInvoker)(() => row.DefaultCellStyle.BackColor = Color.Red));
                        control.Invoke((MethodInvoker)(() => domainTextBox.AppendText(Environment.NewLine)));
                        control.Invoke((MethodInvoker)(() => domainTextBox.AppendText("Row " + (row.Index + 1) + " - " + defaultResponse.Message)));
                        errorRowCount++;
                        break;
                }
            } else
            {

                if(businessRulesResponse.Code == 102)
                {
                    control.Invoke((MethodInvoker)(() => row.DefaultCellStyle.BackColor = Color.Red));
                    control.Invoke((MethodInvoker)(() => domainTextBox.AppendText(Environment.NewLine)));
                    control.Invoke((MethodInvoker)(() => domainTextBox.AppendText("Row " + (row.Index + 1)
                                                    + " - " + businessRulesResponse.Message + " Details: "
                                                    + string.Join(" | ", businessRulesResponse.Details.Select(x => x.Message)))));
                    errorRowCount++;
                }
            }

            return errorRowCount;
        }

        private void RedirectToLoginPage(BackgroundWorker workerFetcher, Control control)
        {
            MessageBox.Show("Authentication token has expired. You will be redirected to the Login page to login again.",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            workerFetcher.CancelAsync();
            control.Invoke((MethodInvoker)(() => Login.MainForm.Hide()));
            control.Invoke((MethodInvoker)(() => Program.LoginForm.Show()));
        }
    }
}