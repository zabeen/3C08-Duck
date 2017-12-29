using System;

namespace OverrideDuck
{
    public class Duck
    {
        public string Name { get; }
        public string Type { get; }
        public int WeightInGrams { get; }
        public int AgeInMonths { get; }

        public Duck(string name, string type, int weightInGrams, int ageInMonths)
        {
            Name = name;
            Type = type;
            WeightInGrams = weightInGrams;
            AgeInMonths = ageInMonths;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Type: {Type}, Weight: {WeightInGrams}g, Age: {AgeInMonths}m";
        }
    }
}
