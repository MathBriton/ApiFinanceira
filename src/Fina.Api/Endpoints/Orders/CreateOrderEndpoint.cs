using System.Security.Claims;
using Fina.Api.Common.Api;
using Fina.Api.Handlers;
using Fina.Api.Models;
using Fina.Api.Requests.Orders;
using Fina.Api.Responses;

namespace Fina.Api.Endpoints.Orders;

public class CreateOrderEndpoint : IEndpoint
{
    public static void Map(IEndpointRouteBuilder app)
        => app.MapPost("/", HandleAsync)
            .Produces<Response<Order?>>();

    private static async Task<IResult> HandleAsync(
        ClaimsPrincipal user,
        IOrderHandler handler,
        CreateOrderRequest request)
    {
        request.UserId = user.Identity?.Name ?? string.Empty;

        var result = await handler.CreateOrderAsync(request);
        return result.IsSuccess
            ? TypedResults.Created("", result)
            : TypedResults.BadRequest(result);
    }
}