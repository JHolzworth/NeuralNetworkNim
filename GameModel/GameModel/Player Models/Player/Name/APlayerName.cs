using GameModel.Value_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameModel.Player_Models.Player.Name
{
    abstract class APlayerName : AValue<string>, IPlayerName
    {
        public APlayerName(string passedName)
            : base(passedName)
        {
        }
    }
}
