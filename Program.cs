using GameBackendDemo.Abstract;
using GameBackendDemo.Adapter;
using GameBackendDemo.Concrete;
using GameBackendDemo.Entities;
using System;

namespace GameBackendDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer
            {
                Id = 1, FirstName = "Mustafa",LastName = "Boz", NationalityId = "454656561256",
                DateOfBirth = new DateTime(1993, 2, 25)
            };
            Game game1 = new Game { Id = 25, GameName = "Akıncı", GameCategory = "Strateji", GameUnitPrice = 50 };
            Campaign campaign1 = new Campaign { Id = 2, CampaignName = "KayıtOL", CampaignRate = 20 };

            //Oyuncu kayıt,güncelleme ve silme
            BaseGamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Save(gamer1);
            gamerManager.Update(gamer1);
            gamerManager.Delete(gamer1);
            Console.WriteLine("-----------------------------------------------");
            
            //Kampanya kayıt,güncelleme ve silme
            BaseCampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Update(campaign1);
            campaignManager.Delete(campaign1);

            Console.WriteLine("-----------------------------------------------");
            //Oyun normal satış ve kampanyalı satış.
            GameOrderManager gameOrder = new GameOrderManager();
            gameOrder.Order(game1, gamer1);
            Console.WriteLine();
            gameOrder.OrderWithCampaign(game1,gamer1,campaign1);

        }
    }
}
