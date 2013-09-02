using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameModel.Value_Models
{
    public class Value<T>:AValue<T>
    {
        public Value(T passedValue):base(passedValue)
        {

        }
    }
}
