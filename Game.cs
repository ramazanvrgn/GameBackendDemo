using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendDemo.Entities
{
   public class Game
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string GameCategory { get; set; }
        public int GameUnitPrice { get; set; }

    }
}
