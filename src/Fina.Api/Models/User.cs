using Microsoft.AspNetCore.Identity;

namespace Dima.Api.Models;

public class User : IdentityUser<long>

{
    publi List<IdentityRole<long>>? Roles {
    get;set;}
    
}