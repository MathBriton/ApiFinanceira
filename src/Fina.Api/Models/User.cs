using Microsoft.AspNetCore.Identity;

namespace Fina.Api.Models;

public class User : IdentityUser<long>

{
    publi List<IdentityRole<long>>? Roles {
    get;set;}
    
}