using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public abstract class Mammal : Animals
    {
        abstract public string FurType { get; set; }
        public string ProduceMilk()
        {
            return "Produce Milk";
        }
    }
}