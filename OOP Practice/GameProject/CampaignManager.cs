using System;

namespace GameProject;

public class CampaignManager : ICampaignService
{
    public void Add(Campaign campaign)
    {
        System.Console.WriteLine($"Kampanya Eklendi: {campaign.CampaignName} | {campaign.Code} | {campaign.CampaignPercentage}" );
    }

    public void Delete(Campaign campaign)
    {
        System.Console.WriteLine($"{campaign.CampaignName} kampanyasi silindi");
    }

    public void Update(Campaign campaign)
    {
        System.Console.WriteLine($"{campaign.CampaignName} kampanyasi guncellendi");
    }
}
