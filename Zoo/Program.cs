using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            MammalCalls();
            Console.WriteLine("======================================");
            ReptileCalls();
            Console.WriteLine("======================================");
            BirdCall();
        }
        static void BirdCall()
        {
            Bird turkey = new BirdTurkey()
            {
                Name = "Bird Turkey"
            };
            
            Bird falcon = new Falcon()
            {
                Name = "Falcon"
            };
            Console.WriteLine($"{turkey.Name} my speed {turkey.Speed} miles per hour");
            if (turkey.Migrates)
            {
                Console.WriteLine("I'm from type Migrates");
            }
            else
            {
                Console.WriteLine("I'm from type not-Migrates");
            }
            Console.WriteLine($"{falcon.Name} my speed {falcon.Speed} miles per hour");
            if (falcon.Migrates)
            {
                Console.WriteLine("I'm from type Migrates");
            }
            else
            {
                Console.WriteLine("I'm from type not-Migrates");
            }
        }
        static void MammalCalls()
        {
            Elephant babar = new Elephant()
            {
                Name = "Babar"
            };

            Platypus ducky = new Platypus()
            {
                Name = "Ducky"
            };

            Console.WriteLine($"{babar.Name} sounds like this : {babar.MakeNoise()} and has {babar.NumberOfEyes} eyes");
            Console.WriteLine($"{ducky.Name} have type fur : {ducky.FurType}");
            Console.WriteLine(ducky.ProduceVenom());
        }
        static void ReptileCalls()
        {
            Crocodiles donatello = new Crocodiles()
            {
                Name = "Donatello"
            };

            Snake nagaina = new Snake()
            {
                Name = "Nagaina"
            };

            Console.WriteLine($"This donatello has {donatello.ScaleColor} scales");
            Console.WriteLine($"This {nagaina.Name} has sound: {nagaina.MakeNoise()}");

        }
    }
}
