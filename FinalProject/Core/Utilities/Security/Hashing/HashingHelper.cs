using System;
using System.Text;

namespace Core.Utilities.Security.Hashing;

public class HashingHelper
{
    public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
    {
        using (var hmac = new System.Security.Cryptography.HMACSHA512())
        {
            passwordSalt = hmac.Key; // salt a yukaridaki key i veridk her kullanici icin farkli key olsuturur ve her kulanici key degeri farklidir
            passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password)); // compute hash byte turunde istediginden byte a cevirdik
        }
    }
    //. sonradan sisteme girmek isteyen kisinin passwordunu kontrol eden yer
    
    public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
    {
        // verieln passwordu algoritmaya gore yeniden hashleseydin passwordHash i alirmiydin
        // dogrulama yapacagimiz icin bize key soruyor key de yukarida verdigimiz salta es deger gelen kisim
        using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
        {
            // hesaplanmis hash computedHash
            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            for (int i = 0; i < computedHash.Length; i++)
            {
                if (computedHash[i] != passwordHash[i])
                {
                    return false;
                }
            }
            return true;
        }

    }
}
