using System;
using System.Collections.Generic;
using System.Linq;

namespace OverrideDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            var quack = new Duck("Sir Quackalot", "Mallard", 100, 17);
            var quack2 = new Duck("Sir Quackalot", "Mallard", 100, 17);
            var donald = new Duck("Donald Duck", "Cartoon", 0, 996);

            var dict = new Dictionary<Duck, DateTime>()
            {
                {quack, DateTime.Now},
                {donald, DateTime.Now}
            };

            Console.WriteLine($"quack: - {quack}");
            Console.WriteLine($"quack2: - {quack2}");
            Console.WriteLine($"donald: - {donald}");

            Console.WriteLine($"\nquack equals quack2: {quack.Equals(quack2)}");
            Console.WriteLine($"quack equals donald: {quack.Equals(donald)}");
            Console.WriteLine($"quack == quack2: {quack == quack2}");
            Console.WriteLine($"quack != donald: {quack != donald}");

            Console.WriteLine($"\nDatetime donald was added to dictionary: {dict[donald]}");

            Console.WriteLine($"\nOldest first:");
            foreach (var duck in dict.OrderByDescending(d => d.Key, Duck.AgeComparer))
            {
                Console.WriteLine(duck.Key.Name);
            }

            Console.WriteLine($"\nHeaviest first:");
            foreach (var duck in dict.OrderByDescending(d => d.Key, Duck.WeightComparer))
            {
                Console.WriteLine(duck.Key.Name);
            }

            Console.ReadLine();
        }
    }
}
