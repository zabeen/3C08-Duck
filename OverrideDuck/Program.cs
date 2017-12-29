using System;

namespace OverrideDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            var quack = new Duck("Sir Quackalot", "Mallard", 100, 17);

            Console.WriteLine(quack);
            Console.ReadLine();
        }
    }
}
