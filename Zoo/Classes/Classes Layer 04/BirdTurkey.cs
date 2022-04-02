using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public class BirdTurkey : Bird, LayEggs
    {
        public override int Speed { get; set; } = 25;
        public override bool Migrates { get; set; } = false;

        public override string Name { get; set; }
        public string LayEggs()
        {
            return "nest";
        }
    }
}