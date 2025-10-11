using System;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory;

public class InMemoryUserDal : IUserDal
{
    List<User> _users;

    public InMemoryUserDal()
    {
        _users = new List<User>
        {

        };
    }
    public void Add(User user)
    {
        _users.Add(user);
    }

    public bool ExistsByEmail(string email)
    {
        return _users.Any(u => string.Equals(u.Email,email,StringComparison.OrdinalIgnoreCase));
    }
}
