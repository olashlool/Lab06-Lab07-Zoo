using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public class Snake : Reptile
    {
        public override string Name { get ; set; }
        public override string ScaleColor { get; set; } = "yellow";

    }
}