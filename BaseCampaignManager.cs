using GameBackendDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendDemo.Abstract
{
    public abstract class BaseCampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+" added.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " uptaded.");

        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " deleted.");

        }
    }
}
