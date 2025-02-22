namespace Fina.Domain.Models.Reports;

public record FinancalSummary(string UserId, decimal Incomes, decimal Expenses)
{
    public decimal Total => Incomes - (Expenses < 0 ? -Expenses : Expenses);
}