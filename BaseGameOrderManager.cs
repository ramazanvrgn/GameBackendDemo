using GameBackendDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendDemo.Abstract
{
    public class BaseGameOrderManager : IOrderService
    {
        public void Order(Game game, Gamer gamer)
        {
            Console.WriteLine("Satış fiyatı :"+game.GameUnitPrice +" TL");
            Console.WriteLine("Satış işlemi gerçekleşmiştir...");
        }

        public void OrderWithCampaign(Game game, Gamer gamer, Campaign campaign)
        {
            var campaignTotal = (game.GameUnitPrice)-(((campaign.CampaignRate) * (game.GameUnitPrice))/100);
            Console.WriteLine("Kampanyalı Fiyatı : "+ campaignTotal+ " TL");
            Console.WriteLine("Kampanyalı satış işlemi gerçekleşti...");
        }
    }
}
