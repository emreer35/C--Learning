using System;
using Core.Entitites.Concrete;

namespace Core.Utilities.Security.JWT;

public interface ITokenHelper

{
    // kullanici giris yapmak istediginde kullanicinin operationclaimlerine bakacak onlara gore jwt uretecek
    AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
}
