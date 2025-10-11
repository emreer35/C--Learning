using System;
using Entities.Concrete;

namespace DataAccess.Abstract;

public interface IUserDal
{
    void Add(User user);
    bool ExistsByEmail(string email);
}
