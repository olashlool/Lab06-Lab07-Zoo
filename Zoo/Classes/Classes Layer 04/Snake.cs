using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public class Snake : Reptile, LayEggs
    {
        public override string Name { get; set; }
        public override string ScaleColor { get; set; } = "yellow";
        public string LayEggs()
        {
            return "dirt, compost, or loose and moist ground.";
        }
    }
}