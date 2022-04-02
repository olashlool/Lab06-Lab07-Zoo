using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public class Elephant : Placental, Swim
    {
        public override string FurType { get; set; } = "have hair all over their bodies but unevenly scattered.";
        public override string Name { get; set; }

        public override string MakeNoise()
        {
            return "Trumpet call";
        }
        
        public string Swimming()
        {
            return "elephants are natural-born swimmers.";
        }
    }
}