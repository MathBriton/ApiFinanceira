using Fina.Domain.Requests.Account;
using Fina.Domain.Responses;

namespace Fina.Domain.Handlers;

public interface IAccountHandler

{

    Task<Response<string>> LoginAsync (LoginRequest request);
    Task<Response<string>> RegisterAsync(RegisterRequest request);
    Task LogoutAsync();
}