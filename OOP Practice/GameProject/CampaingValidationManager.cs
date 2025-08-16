using System;

namespace GameProject;

public class CampaingValidationManager : ICampaignValidationService
{
    public bool Validate(Campaign campaign)
    {
        if (campaign.Code == "kamp12" || campaign.Code == "kamp13" || campaign.Code == "kamp13")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
