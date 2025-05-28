using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
    public class Cat : Pet
    {
        public Cat(string name, int age, int weight) : base(name, age, weight) { }
        public Cat(string name, int age, int weight, bool phobia) : base(name, age, weight, phobia) { }
    } // Cat

    public class Dog : Pet
    {
        public Dog(string name, int age, int weight) : base(name, age, weight)
        {
            HasClaustrophobia = true;
        }
        public Dog(string name, int age, int weight, bool phobia) : base(name, age, weight, phobia) { }
    } // Dog

    public class Rabbit : Pet
    {
        public Rabbit(string name, int age, int weight) : base(name, age, weight) { }
        public Rabbit(string name, int age, int weight, bool phobia) : base(name, age, weight, phobia) { }
    } // Rabbit
}
