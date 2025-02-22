using System.Net;
using Fina.Domain.Requests.Stripe;
using Fina.Domain.Responses;

namespace Fina.Domain.Handlers;

public interface IStripeHandler

{
    Task<WebResponse<string?>> CreateSessionAsync (CreateSessionRequest request);
}