using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public class Falcon : Bird, LayEggs
    {
        public override int Speed { get; set; } = 390;
        public override string Name { get; set; }
        public override string MakeNoise()
        {
            return "kack-kack-kack";
        }
        public string LayEggs()
        {
            return "sand or gravel";
        }
    }
}