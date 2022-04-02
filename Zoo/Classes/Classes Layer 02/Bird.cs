using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public abstract class Bird : Animals
    {
        public virtual bool Migrates { get; set; } = true;

        public abstract int Speed { get; set; }

        public override string MakeNoise()
        {
           return "Gobble-Gobble-Gobble";
        }

    }
}