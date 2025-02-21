using System.Net;
using Dima.Core.Requests.Stripe;
using Dima.Core.Responses;

namespace Dima.Core.Handlers;

public interface IStripeHandler

{
    Task<WebResponse<string?>> CreateSessionAsync (CreateSessionRequest request);
}