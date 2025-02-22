using Fina.Domain.Models;
using Fina.Domain.Requests.Orders;
using Fina.Domain.Responses;

namespace Fina.Domain.Handlers;

public interface IOrderHandler
{
    Task<Response<Order?>> CreateOrderAsync (CreateOrderRequest request);
    Task<Response<Order?>> ConfirmOrderAsync (ConfirmOrderRequest request);
}