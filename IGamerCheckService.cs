﻿using GameBackendDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendDemo.Abstract
{
   public interface IGamerCheckService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
