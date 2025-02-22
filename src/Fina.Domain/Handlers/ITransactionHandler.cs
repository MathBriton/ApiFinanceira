using Fina.Domain.Models;
using Fina.Domain.Requests.Transactions;
using Fina.Domain.Responses;

namespace Fina.Domain.Handlers;

public interface ITransactionHandler

{
    Task<Response<Transaction?>> CreateAsync(CreateTransactionRequest request);
    Task<Response<Transaction?>> UpdateAsync(UpdateTransactionRequest request);
    Task<Response<Transation?>> DeleteAsync (DeleteTransactionRequest request);
    Task<Response<Transaction?>> GetByIdAsync(GetTransactionByIdRequest request);
    Task<PagedResponse<List<Transaction>?>> GetPyPeriodAsync (GetTransactionByPeriodRequest request);
}