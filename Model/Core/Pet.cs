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
        public gender Gender { get; private set; }
        public int Age { get; private set; }
        public int Weigth { get; private set; }
        public bool InShelter { get; private set; }
    
        public Pet(string name, gender gender, int age, int weight, bool inShelter)
        {
            Name = name;
            Gender = gender;
            Age = age;
            Weigth = weight;
            InShelter = inShelter;
        }

        public override bool Equals(object? obj)
        {
            if (base.Equals(obj)) return true;
            if (obj is not Pet pet) return false;
            if (pet.GetType() == this.GetType() && pet.Name == this.Name &&
                pet.Age == this.Age && pet.Weigth == this.Weigth)
                return true;
            return false;
        }
        public static bool operator ==(Pet? pet1, Pet? pet2)
        {
            if (ReferenceEquals(pet1, pet2)) return true;
            if (pet1 is null || pet2 is null) return false;
            return pet1.Equals(pet2);
        }
        public static bool operator !=(Pet? pet1, Pet? pet2) => !(pet1 == pet2);
    }

    public abstract partial class Pet
    {
        public bool HasClaustrophobia { get; protected set; }

        [JsonConstructor]
        public Pet(string name, gender gender, int age, int weight, bool inShelter, bool phobia) : this(name, gender, age, weight, inShelter)
        {
            HasClaustrophobia = phobia;
        }
    }
}
