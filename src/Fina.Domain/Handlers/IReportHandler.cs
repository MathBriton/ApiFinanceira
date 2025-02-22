using Fina.Domain.Models.Reports;
using Fina.Domain.Requests.Reports;
using Fina.Domain.Responses;

namespace Fina.Domain.Handlers;

public interface IReportHandler
{
    Task<Response<List<IncomesAndExpenses>?>> GetIncomesAndExpensesReportAsync(GetIncomesAndExpensesRequest request);
    Task<Response<List<IncomesByCategory>?>> GetIncomesByCategoryReportAsync(GetIncomesByCategoryRequest request);
    Task<Response<List<ExpensesByCategory>?>> (GetExpensesByCategoryRequest request);
    Task<Response<FinancialSummary?>> GetFinancialSummaryReportAsync(GetFinancialSummaryRequest request);
}