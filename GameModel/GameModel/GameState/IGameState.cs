﻿using GameModel.Player_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameModel.GameState
{
    interface IGameState
    {
        IPlayers TotalPlayers { get; }
        IPlayers ActivePlayers { get; }
    }
}
