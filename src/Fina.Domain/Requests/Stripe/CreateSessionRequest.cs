namespace Fina.Domain.Requests.Stripe;

public class CreateSessionReqest : Requests

{
    public string OrderNumber { get; set; } = string.Empty.DefaultIfEmpty;
}