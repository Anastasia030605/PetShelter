using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
    public class Cat : Pet
    {
        public Cat(string name, Gender gender, int age, int weight, bool inShelter, bool phobia = false) :
            base(name, gender, age, weight, inShelter, phobia) { }
    } // Cat

    public class Dog : Pet
    {
        public Dog(string name, Gender gender, int age, int weight, bool inShelter, bool phobia = true) :
            base(name, gender, age, weight, inShelter, phobia) { }
    } // Dog

    public class Rabbit : Pet
    {
        public Rabbit(string name, Gender gender, int age, int weight, bool inShelter, bool phobia = false) :
            base(name, gender, age, weight, inShelter, phobia) { }

    } // Rabbit
}
