using GameModel.Player_Models.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameModel.Player_Models
{
    interface IPlayers
    {
        IEnumerable<IPlayer> Players { get; }
    }
}
