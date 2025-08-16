using System;

namespace GameProject;

public class GamerManager : IGamerService
{
    UserValidationManager _userValidationManager;

    public GamerManager(UserValidationManager userValidationManager)
    {
        _userValidationManager = userValidationManager;
    }

    public void Add(Gamer gamer)
    {
        if (_userValidationManager.Validate(gamer))
        {
            System.Console.WriteLine("Kayit Basarili");
        }
        else
        {
            System.Console.WriteLine("Kayit basarisiz. Kontrolden gecemedi");
        }
    }

    public void Delete(Gamer gamer)
    {
        if (_userValidationManager.Validate(gamer))
        {
            System.Console.WriteLine("Basariyla silidni");
        }
        else
        {
           System.Console.WriteLine("basarisiz silme islemi");

        }
    }

    public void Update(Gamer gamer)
    {
        System.Console.WriteLine("Basariyla guncelendi");
    }
}
