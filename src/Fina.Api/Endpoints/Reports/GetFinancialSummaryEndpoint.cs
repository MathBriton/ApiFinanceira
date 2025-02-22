using System.Reflection.Metadata;
using System.Security.Claims;
using Fina.Api.Common.Api;
using Fina.Api.Handlers;
using Fina.Api.Models.Reports;
using Fina.Api.Requests.Reports;
using Fina.Api.Responses;

namespace Fina.Api.Endpoints.Reports;

public class GetFinancialSummaryEndpoint : IEndpoint
{
    public static void Map(IEndpointRouteBuilder app)
        => app.MapGet("/summary", HandleAsync)
            .Produces<Response<FinancialSummary?>>();

    private static async Task<IResult> HandleAsync(
        ClaimsPrincipal user,
        IReportHandler handler)
    {
        var request = new GetFinancialSummaryRequest
        {
            UserId = user.Identity?.Name ?? string.Empty
        };
        var result = await handler.GetFinancialSummaryReportAsync(request);
        return result.IsSuccess
            ? TypedResults.Ok(result)
            : TypedResults.BadRequest(result);
    }
}