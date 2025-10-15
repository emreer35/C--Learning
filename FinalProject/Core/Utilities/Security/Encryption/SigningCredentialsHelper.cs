using System;
using System.Security.Cryptography;
using Microsoft.IdentityModel.Tokens;

namespace Core.Utilities.Security.Encryption;

// json web tokenlarinin olsuturabilmesi icin credential i imzalama neseninee donderecek
public class SigningCredentialsHelper
{
    public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
    {
        return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);
    }
}
