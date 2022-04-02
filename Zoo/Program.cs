using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======================================Mammal=========================================");
            Console.WriteLine();
            MammalCalls();
            Console.WriteLine();
            Console.WriteLine("=======================================Reptile========================================");
            Console.WriteLine();
            ReptileCalls();
            Console.WriteLine();
            Console.WriteLine("=========================================Bird=========================================");
            Console.WriteLine();
            BirdCall();
        }
        static void BirdCall()
        {
            Bird turkey = new BirdTurkey()
            {
                Name = "Bird Turkey"
            };

            Falcon falcon = new Falcon()
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
            Console.WriteLine($"{falcon.Name} lay eggs in {falcon.LayEggs()}");
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

            Console.WriteLine($"{babar.Name} sounds like this : {babar.MakeNoise()} and has {babar.NumberOfEyes} eyes {babar.Swimming()}");
            Console.WriteLine($"{ducky.Name} have type fur : {ducky.FurType}");
            Console.WriteLine($"{ducky.Name} lay eggs in : {ducky.LayEggs()}, {ducky.Swimming()}");
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

            Console.WriteLine($"This {donatello.Name} has {donatello.ScaleColor} scales {donatello.Swimming()}");
            Console.WriteLine($"This {nagaina.Name} has sound: {nagaina.MakeNoise()} and lay eggs in {nagaina.LayEggs()}");

        }
    }
}
