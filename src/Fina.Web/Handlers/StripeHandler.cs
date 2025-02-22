using System.Net.Http.Json;
using Fina.Domain.Handlers;
using Fina.Domain.Requests.Stripe;
using Fina.Domain.Responses;

namespace Dima.Web.Handlers;

public class StripeHandler(IHttpClientFactory httpClientFactory) : IStripeHandler
{
    private readonly HttpClient _client = httpClientFactory.CreateClient(Configuration.HttpClientName);

    public async Task<Response<string?>> CreateSessionAsync(CreateSessionRequest request)
    {
        var result = await _client.PostAsJsonAsync($"v1/payments/stripe/session", request);
        return await result.Content.ReadFromJsonAsync<Response<string?>>()
               ?? new Response<string?>(null, 400, "Falha ao criar sessão no Stripe");
    }
}