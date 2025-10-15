using System;

namespace Core.Utilities.Security.JWT;

// app settings de ki tokenoptions degerlerimizi aldik 
public class TokenOptions
{
    public string Audience { get; set; }
    public string Issuer { get; set; }
    public int AccessTokenExpiration { get; set; }
    public string SecurityKey { get; set; }
}
