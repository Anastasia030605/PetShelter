using Newtonsoft.Json;
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

        //[JsonConstructor]
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

        private void Filter(Predicate<Pet> filter, Pet[] to_filter, ref Pet[] filter_to)
        {

            int count = 0;
            foreach (Pet pet in to_filter)
            {
                if (filter(pet))
                {
                    filter_to[count++] = pet;
                }
            }
        }

        public Pet[] Filter(Type type)
        {
            var filtered = new Pet[Count(type)];
            Filter(pet => pet.GetType() == type, Pets, ref filtered);
            return filtered;
        }

        public Pet[] Filter(Type type, bool hasPhobia)
        {
            if (!HasOpenArea) return [];

            var sameType = Filter(type);
            var filtered = new Pet[HasPhobiaCount(sameType, hasPhobia)];
            Filter(pet => pet.HasClaustrophobia, sameType, ref filtered);
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
            if (pet == null || Pets.Length == Capacity || Pets == null) return;

            var newPets = new Pet[Pets.Length + 1];
            Array.Copy(Pets, newPets, Pets.Length);
            newPets[newPets.Length] = pet;
            Pets = newPets;
        }

        public void Add(Pet[] pets)
        {
            if(pets == null || Pets == null) return;
            int numToAdd = pets.Length;
            if(Pets.Length + numToAdd > Capacity)
                numToAdd = Capacity - Pets.Length;

            var newPets = new Pet[Pets.Length + numToAdd];
            Array.Copy(Pets, newPets, Pets.Length);
            Array.Copy(pets, 0, newPets, Pets.Length, numToAdd);
            Pets = newPets;
        }

        public void Remove(Pet pet)
        {
            throw new NotImplementedException();
            int place = -1;
            for(int k = 0; k < Pets.Length; k++)
            {
                if (Pets[k].Equals(pet))
                {
                    place = k;
                    break;
                }
            }
            if (place == -1) return;
            var newPets = new Pet[Pets.Length - 1];
            Array.Copy(Pets, newPets, place);
            Array.Copy(Pets, place + 1, newPets, place, newPets.Length - place);
            Pets = newPets;
        }
    }
}
