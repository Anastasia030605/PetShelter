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
