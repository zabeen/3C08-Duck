using System;

namespace OverrideDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            var quack = new Duck("Sir Quackalot", "Mallard", 100, 17);
            var quack2 = new Duck("Sir Quackalot", "Mallard", 100, 17);
            var donald = new Duck("Donald Duck", "Cartoon", 0, 996);

            Console.WriteLine(quack);
            Console.WriteLine($"quack equals quack2: {quack.Equals(quack2)}");
            Console.WriteLine($"quack equals donald: {quack.Equals(donald)}");
            Console.ReadLine();
        }
    }
}
