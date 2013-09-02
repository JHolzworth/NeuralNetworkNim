using GameModel.Player_Models.Player.Name;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameModel.Player_Models.Player
{
    abstract class APlayer : IPlayer
    {
        IPlayerName name;

        public IPlayerName Name 
        {
            get
            {
                return this.name;
            }
        }


        public APlayer(IPlayerName passedName)
        {
            this.name = passedName;
        }

    }
}
