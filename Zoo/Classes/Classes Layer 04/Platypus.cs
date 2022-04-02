using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public class Platypus : Monotreme, LayEggs, Swim
    {
        public override string FurType { get; set; } = "dense";
        public override string Name { get; set; }

        public override string MakeNoise()
        {
            return Name + " aggravated purr";
        }

        public override string ProduceVenom()
        {
            return Name + " Name Produce Venom, but venom's effects are extremely painful but are not lethal to humans.!";
        }
        public string LayEggs()
        {
            return "underground burrow";
        }

        public string Swimming()
        {
            return "swim gracefully by paddling with their front webbed feet and steering with their hind feet and beaverlike tail.";
        }
    }
}