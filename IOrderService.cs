using GameBackendDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendDemo.Abstract
{
    public interface IOrderService
    {
        void Order(Game game,Gamer gamer);
        void OrderWithCampaign(Game game, Gamer gamer,Campaign campaign );
    }
}
