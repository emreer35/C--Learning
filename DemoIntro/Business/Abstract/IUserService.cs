using System;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract;

public interface IUserService
{
    IResult Register(string name, string email);

}
