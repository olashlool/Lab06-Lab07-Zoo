using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public abstract class Reptile : Animals
    {
        public virtual string ScaleColor { get; set; } = "Green";

        public override string MakeNoise()
        {
            return "Hisssss";
        }
    }
}