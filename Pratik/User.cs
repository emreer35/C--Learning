using System;
using System.ComponentModel.DataAnnotations;

namespace Pratik;

public class UserManager // : IUserService
{
    // public class UserManager
    // {
    //     public void Register(string name, string email)
    //     {
    //         // İş kuralı
    //         if (!email.Contains("@"))
    //         {
    //             Console.WriteLine("Geçersiz e-posta");
    //             return;
    //         }

    //         // DB işlemi
    //         using (var context = new AppDbContext())
    //         {
    //             context.Users.Add(new User { Name = name, Email = email });
    //             context.SaveChanges();
    //         }

    //         // Bildirim işlemi
    //         Console.WriteLine("Kayıt başarılı! Hoşgeldiniz " + name);
    //     }
    // }
    public void Add(string name, string email)
    {
        UserValidator.Validator(name, email);

    }
}

public class DbContext // : DbCOntext
{
    public void Add()
    {
        using (var context = new DbContext())
        {
            context.Users.Add(new User { name = name, Email = email })
            context.SaveChanges();
        }
    }
}

public class Notification {
    public void SendNotification(string message)
    {
        System.Console.WriteLine("Mesajiniz: " + message);
    }
}

public class UserValidator {
    public static void Validator(string name, string email)
    {
        if (!email.Contains("@"))
        {
            System.Console.WriteLine("gecersiz e posta adresi");
            return;
        }
    }
}
    
