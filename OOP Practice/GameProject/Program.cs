

using GameProject;

IGamerService gamer = new GamerManager(new UserValidationManager());
Gamer gamer1 = new Gamer() { Id = 1, FirstName = "YUNUS EMRE", LastName = "ER", BirthYear = 2001, IdentityNumber = "12345" };
gamer.Add(gamer1);

ISellerService seller = new SellerManager(new UserValidationManager());
seller.Buy(gamer1);

List<Campaign> campaigns = new List<Campaign> {
    new Campaign(){Id=1,CampaignName = "kamp1", CampaignPercentage=12, Code="kamp12"},
    new Campaign(){Id=2,CampaignName = "kamp2", CampaignPercentage=13, Code="kamp13"},
    new Campaign(){Id=3,CampaignName = "kamp3", CampaignPercentage=14, Code="kamp14"},

};
ICampaignService campaign = new CampaignManager();
foreach (var campain in campaigns)
{
    campaign.Add(campain);
}
campaign.Delete(campaigns[0]);


IOrderService orderService = new OrderManager(new UserValidationManager(), new CampaingValidationManager());

orderService.PlaceOrder(campaigns[1], gamer1);