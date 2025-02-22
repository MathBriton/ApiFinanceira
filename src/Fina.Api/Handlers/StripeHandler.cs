using Fina.Api;
using Fina.Api.Handlers;
using Fina.Api.Requests.Stripe;
using Fina.Api.Responses;
using Stripe.Checkout;

namespace Fina.Api.Handlers;

public class StripeHandler : IStripeHandler
{
    public async Task<Response<string?>> CreateSessionAsync(CreateSessionRequest request)
    {
        var options = new SessionCreateOptions
        {
            CustomerEmail = request.UserId,
            PaymentIntentData = new SessionPaymentIntentDataOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order", request.OrderNumber }
                }
            },
            PaymentMethodTypes =
            [
                "card"
            ],
            LineItems = [
                new SessionLineItemOptions
                {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        Currency = "BRL",
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = "Premium Anual",
                            Description = "Plano para um ano de acesso"
                        },
                        UnitAmountDecimal = Configuration.PremiumPrice,
                    },
                    Quantity = 1
                }
            ],
            Mode = "payment",
            SuccessUrl = $"{Configuration.FrontendUrl}/pedidos/{request.OrderNumber}/confirmar",
            CancelUrl = $"{Configuration.FrontendUrl}/pedidos/{request.OrderNumber}/cancelar",
        };

        var service = new SessionService();
        var session = await service.CreateAsync(options);

        return new Response<string?>(session.Id);
    }
}