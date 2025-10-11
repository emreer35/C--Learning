using System;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework;

public class EfUserDal : IUserDal
{
    public void Add(User user)
    {
        throw new NotImplementedException();
    }

    public bool ExistsByEmail(string email)
    {
        throw new NotImplementedException();
    }
}
