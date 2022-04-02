using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public class Crocodiles : Reptile, LayEggs, Swim
    {
        public override string Name { get; set; }

        public string LayEggs()
        {
            return "holes or mound nests";
        }

        public string Swimming()
        {
            return "When swimming, the crocodile places its legs back against the sides of the body and moves forward by means of lateral wavelike motions of the tail";
        }
    }
    

}