using GameBackendDemo.Abstract;
using GameBackendDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendDemo.Concrete
{
   public class GamerManager:BaseGamerManager
    {
        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public override void Save(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                base.Save(gamer);
            }
            else
            {
                throw new Exception("Not a valid Person...");
            }
            
        }
    }
}
