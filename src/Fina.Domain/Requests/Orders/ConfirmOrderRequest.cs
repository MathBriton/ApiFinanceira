namespace Fina.Domain.Requests.Orders;

public class ConfirmOrderRequest : Request

{
    public string Number {get; set;} = string.Empty;
}