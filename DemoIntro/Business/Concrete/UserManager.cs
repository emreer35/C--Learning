using System;
using Business.Abstract;
using Business.Notification;
using Business.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class UserManager : IUserService
{
    IUserValidator _userValidator;
    INotifier _notifier;
    IUserDal _userDal;
    public UserManager(IUserDal userDal, IUserValidator userValidator, INotifier notifier)
    {
        _userDal = userDal;
        _userValidator = userValidator;
        _notifier = notifier;

    }
    public IResult Register(string name, string email)
    {
        var result = _userValidator.ValidateRegistration(name, email);

        if (!result.Ok) return new ErrorResult(result.error!);
        if (!_userDal.ExistsByEmail(email)) return new ErrorResult("Bu eposta zaten kayitli");

        _userDal.Add(new User { Name = name, Email = email });
        _notifier.SendWelcome(name, email);
        return new SuccessResult("ekleme islemi basarili");

    }
}
