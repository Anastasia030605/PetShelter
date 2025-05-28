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

        public Pet(string name, int age, int weight) 
        {
            Name = name;
            Age = age;
            Weigth = weight;
        }

        public override bool Equals(object? obj)
        {
            if (base.Equals(obj)) return true;
            var pet = obj as Pet;
            if (pet == null) return false;
            if (pet.GetType() == this.GetType() &&
                pet.Name == this.Name) // стоит ли сравнивать ещё и возраст и вес? 
                return true;
            return false;
        }
        //public static override bool operator == (Pet pet1, Pet pet2)
        //{
        //    if () return true;
        //    return false;
        //}
        //public static override bool operator != (Pet pet1, Pet pet2)
        //{
        //    if () return true;
        //    return false;
        //}
    }

    public abstract partial class Pet
    {
        public bool HasClaustrophobia { get; protected set; }

        public Pet (string name, int age, int weight, bool phobia) : this(name, age, weight)  
        {
            HasClaustrophobia = phobia;
        }
    }
}
