using System;

namespace GameProject;

public class OrderManager : IOrderService
{
    IUserValidationService _userValidateService;
    ICampaignValidationService _campaignValidationService;



    public OrderManager(IUserValidationService userValidateService, ICampaignValidationService campaignValidationService)
    {
        _userValidateService = userValidateService;
        _campaignValidationService = campaignValidationService;
    }

    public void PlaceOrder(Campaign campaign, Gamer gamer)
    {
        if (!_userValidateService.Validate(gamer))
        {
            System.Console.WriteLine("Dogrulanmamsi hesap");
            return;

        }
        if (!_campaignValidationService.Validate(campaign))
            {
                 System.Console.WriteLine("Kampanya Kodunu Kontrol Ediniz");
                return;
            }
        Console.WriteLine("Sipariş başarıyla verildi");

    }
}
