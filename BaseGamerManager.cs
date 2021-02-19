using GameBackendDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendDemo.Abstract
{
   public abstract class BaseGamerManager : IGamerService
    {
        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" deleted db.");

        }

        public virtual void Save(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " saved db.");

        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " updated db.");

        }
    }
}
