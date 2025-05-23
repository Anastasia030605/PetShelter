using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
    public partial class Shelter : ICountable, IFilter
    {
        public string Name { get; private set; } 
        public int Capacity { get; private set; }
        public bool HasOpenArea { get; private set; }
        public Pet[] Pets { get; private set; }

        public Shelter(string name,  int capacity, bool hasOpenArea) // bool hasOpenArea = false ?
        {
            Name = name;
            Capacity = capacity;
            HasOpenArea = hasOpenArea;
            Pets = new Pet[0];
        }

        public int Count()
        {
            return Pets.Length;
        }

        public int Count(Type type)
        {
            int count = 0;
            foreach(var pet in Pets)
            {
                if(pet.GetType() == type) count++;
            }
            return count;
        }

        public int Percentage(Type type)
        {
            return 100 * Count(type) / Count();
        }

        public Pet[] Filter(Type type)
        {
            var filtered = new Pet[Count(type)];
            int count = 0;
            foreach(var pet in Pets)
            {
                if (pet.GetType() == type)
                {
                    filtered[count] = pet;
                    count++;
                }
            }
            return  filtered;
        }

        public Pet[] Filter(Type type, bool hasPhobia) // мне не нравится, но мне лень думать сейчас
        {
            var sameType = Filter(type);
            var filtered = new Pet[HasPhobiaCount(sameType, hasPhobia)];
            int count = 0;
            foreach(var pet in sameType)
            {
                if(pet.HasClaustrophobia == hasPhobia)
                {
                    filtered[count] = pet;
                    count++;
                }
            }
            return filtered;
        }
        private int HasPhobiaCount(Pet[] pets, bool hasPhobia)
        {
            int count = 0;
            foreach(var pet in pets)
            {
                if(pet.HasClaustrophobia == hasPhobia) count++;
            }
            return count;
        }
    }

    public partial class Shelter : IChangeable
    {
        public void Add(Pet pet)
        {
            throw new NotImplementedException();

        }

        public void Add(Pet[] pets)
        {
            throw new NotImplementedException();
        }

        public void Remove(Pet pet)
        {
            throw new NotImplementedException();
        }
    }
}
