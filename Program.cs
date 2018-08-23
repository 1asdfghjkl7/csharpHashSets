using System;
using System.Collections.Generic;

namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> Showroom = new HashSet<string>();
            Showroom.Add("Camry");
            Showroom.Add("Accord");
            Showroom.Add("Mazda 3");
            Showroom.Add("The Jeep");

            // foreach (string item in Showroom)
            // {
            //     Console.WriteLine(item);

            // }
            Showroom.Add("Mazda 3");
            // foreach (string item in Showroom)
            // {
            //     Console.WriteLine(item);

            // }

            HashSet<string> UsedLot = new HashSet<string>();
            UsedLot.Add("Fiesta");
            UsedLot.Add("F-150");

            Showroom.UnionWith(UsedLot);
            Showroom.Remove("Camry");

            // foreach (string item in Showroom)
            // {
            //     Console.WriteLine(item);
            // }

            HashSet<string> Junkyard = new HashSet<string>();
            Junkyard.Add("Civic");
            Junkyard.Add("Ranger");
            Junkyard.Add("Mazda 3");
            Junkyard.Add("Accord");

            HashSet<string> clone = new HashSet<string>(Showroom);

            clone.IntersectWith(Junkyard);
            Showroom.UnionWith(Junkyard);
            Showroom.Remove("Ranger");

            foreach (string item in Showroom)
            {
                Console.WriteLine(item);
            }
        }
    }
}
