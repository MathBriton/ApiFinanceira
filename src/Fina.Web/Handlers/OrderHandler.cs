using System.Net.Http.Json;
using Fina.Domain.Handlers;
using Fina.Domain.Models;
using Fina.Domain.Requests.Orders;
using Fina.Domain.Responses;

namespace Dima.Web.Handlers;

public class OrderHandler(IHttpClientFactory httpClientFactory) : IOrderHandler
{
    private readonly HttpClient _client = httpClientFactory.CreateClient(Configuration.HttpClientName);

    public async Task<Response<Order?>> CreateOrderAsync(CreateOrderRequest request)
    {
        var result = await _client.PostAsJsonAsync($"v1/orders", request);
        return await result.Content.ReadFromJsonAsync<Response<Order?>>()
               ?? new Response<Order?>(null, 400, "Não foi possível criar seu pedido");
    }

    public async Task<Response<Order?>> ConfirmOrderAsync(ConfirmOrderRequest request)
    {
        var result = await _client.PutAsJsonAsync($"v1/orders", request);
        return await result.Content.ReadFromJsonAsync<Response<Order?>>()
               ?? new Response<Order?>(null, 400, "Não foi possível atualizar seu pedido");
    }
}