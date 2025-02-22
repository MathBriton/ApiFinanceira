namespace Fina.Domain.Models.Reports;

public record IncomesByCategory (string UserId, string Category, int Year, decimal Incomes);