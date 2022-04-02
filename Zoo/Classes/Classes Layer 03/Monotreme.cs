using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public abstract class Monotreme : Mammal
    {
        public virtual bool IsPet { get; set; } = false;

        public abstract string ProduceVenom();
    }
}