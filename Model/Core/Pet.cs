using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Model.Core
{
    public abstract partial class Pet
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public int Weigth { get; private set; }
        public string ChipNumber { get; private set; }

        public Pet(string name, int age, int weight, string chipNumber) 
        {
            Name = name;
            Age = age;
            Weigth = weight;
            ChipNumber = chipNumber.PadLeft(16, '0');
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Pet pet) return false;

            return this.ChipNumber == pet.ChipNumber;
        }
        public static bool operator ==(Pet? pet1, Pet? pet2)
        {
            if (ReferenceEquals(pet1, pet2)) return true;
            if (pet1 is null || pet2 is null) return false;
            return pet1.Equals(pet2);
        }
        public static bool operator !=(Pet? pet1, Pet? pet2) => !(pet1 == pet2);
        public override int GetHashCode() => ChipNumber.GetHashCode();
    }

    public abstract partial class Pet
    {
        public bool HasClaustrophobia { get; protected set; }

        [JsonConstructor]
        public Pet (string name, int age, int weight, bool phobia) : this(name, age, weight)  
        {
            HasClaustrophobia = phobia;
        }
    }
}
