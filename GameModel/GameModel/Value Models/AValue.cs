using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameModel.Value_Models
{
    public abstract class AValue<T>:IValue<T>
    {
        protected T _value;
        public T Value
        {
            get { return this._value; }
        }

        public AValue(T passedValue)
        {
            this._value = passedValue;
        }
    }
}
