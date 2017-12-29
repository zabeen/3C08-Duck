using System;
using System.Collections.Generic;

namespace OverrideDuck
{
    public class Duck : IEquatable<Duck>
    {
        private sealed class WeightRelationalComparer : Comparer<Duck>
        {
            public override int Compare(Duck x, Duck y)
            {
                if (ReferenceEquals(x, y)) return 0;
                if (ReferenceEquals(null, y)) return 1;
                if (ReferenceEquals(null, x)) return -1;
                return x.WeightInGrams.CompareTo(y.WeightInGrams);
            }
        }

        private sealed class AgeRelationalComparer : Comparer<Duck>
        {
            public override int Compare(Duck x, Duck y)
            {
                if (ReferenceEquals(x, y)) return 0;
                if (ReferenceEquals(null, y)) return 1;
                if (ReferenceEquals(null, x)) return -1;
                return x.AgeInMonths.CompareTo(y.AgeInMonths);
            }
        }

        public string Name { get; }
        public string Type { get; }
        public int WeightInGrams { get; }
        public int AgeInMonths { get; }
        public static Comparer<Duck> WeightComparer { get; } = new WeightRelationalComparer();
        public static Comparer<Duck> AgeComparer { get; } = new AgeRelationalComparer();

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
