using System;

namespace GameProject;

public class SellerManager : ISellerService
{
    IUserValidationService _userValidationService;

    public SellerManager(IUserValidationService userValidationService)
    {
        _userValidationService = userValidationService;
    }

    public void Buy(Gamer gamer)
    {
        if (_userValidationService.Validate(gamer))
        {
            System.Console.WriteLine("Satis Basarili");
        }
        else
        {
            System.Console.WriteLine("Satis Yapilamadi Luten Kimlik Kontrolunu yapiniz");
        }
    }
}
