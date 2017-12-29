using System;

namespace OverrideDuck
{
    public class Duck : IEquatable<Duck>
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

        public bool Equals(Duck other)
        {
            return Name == other.Name && Type == other.Type && WeightInGrams == other.WeightInGrams && AgeInMonths == other.AgeInMonths;
        }

        public static bool operator ==(Duck left, Duck right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Duck left, Duck right)
        {
            return !Equals(left, right);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Duck)obj);
        }

        public override int GetHashCode()
        {
            int hash = Name.GetHashCode();
            hash = (hash * 31) + Type.GetHashCode();
            hash = (hash * 31) + WeightInGrams.GetHashCode();
            hash = (hash * 31) + AgeInMonths.GetHashCode();
            return hash;
        }
    }
}
