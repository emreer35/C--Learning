// See https://aka.ms/new-console-template for more information
using Business.Abstract;
using Business.Concrete;
using Business.Notification;
using Business.Validation;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

Console.WriteLine("Hello, World!");


IUserService userService = new UserManager(new InMemoryUserDal(), new BasicUserValidate(), new ConsoleNotifier());

List<User> users = new List<User> {
    new User{Id = 1, Name = "", Email = "123123@hotmailcim"},
    new User{Id = 2, Name = "emre", Email = "12312"},
    new User{Id = 3, Name = "bu kim ", Email = "123123@hotmailcim"},
    new User{Id = 4, Name = "bu bir digeri", Email = "birdigeri@hotmailcim"},
};

foreach (var u in users)
{
    var r = userService.Register(u.Name, u.Email);
    System.Console.WriteLine($"{r.Success} | {r.Message}");
}