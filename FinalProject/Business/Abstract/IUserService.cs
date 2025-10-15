using System;
using Core.Entitites.Concrete;

namespace Business.Abstract;

public interface IUserService
{
    List<OperationClaim> GetClaims(User user);
    void Add(User user);
    User GetByMail(string email);
}
