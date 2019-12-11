using System;
using Zoo.Lib;

namespace Zoo.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            PublicZoo zoo = new PublicZoo(39M);
            

            Console.WriteLine($"Hello Nightly Tourist!\n\n" +
                              $"Buy a ticket for {zoo.EntranceFee} euro\n\n" +
                              $"Take a look at our animals:\n\n");
            foreach (Lion lion in zoo.LionCage.Lions)
            {
                Console.WriteLine($"Grrrrr.... i am {lion.Name}, my sex is {lion.Sex}");
            }

        }
    }
}
