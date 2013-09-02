using GameModel.Player_Models.Player.Name;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameModel.Player_Models.Player
{
    interface IPlayer
    {
        IPlayerName Name {get;}
    }
}
