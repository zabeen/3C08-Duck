using System;
using System.Collections.Generic;

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

            Console.WriteLine(quack);
            Console.WriteLine($"quack equals quack2: {quack.Equals(quack2)}");
            Console.WriteLine($"quack equals donald: {quack.Equals(donald)}");
            Console.WriteLine($"Datetime donald was added to dictionary: {dict[donald]}");
            Console.ReadLine();
        }
    }
}
