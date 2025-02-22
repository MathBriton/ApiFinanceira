namespace Fina.Domain.Requests.Transactions;

public class DeleteTransactionRequest : Request
{
    public long Id { get; set; }
}