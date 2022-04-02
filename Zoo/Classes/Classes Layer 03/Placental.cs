using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public abstract class Placental : Mammal
    {
        public virtual string HasTail()
        {
            return "My tail sways.";
        }
    }
}