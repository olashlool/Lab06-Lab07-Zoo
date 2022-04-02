using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public abstract class Animals
    {
        public abstract string Name { get; set; }
        public virtual int NumberOfEyes { get; set; } = 2;

        public abstract string MakeNoise();
    }
}