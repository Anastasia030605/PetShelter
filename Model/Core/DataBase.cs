using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
    public class DataBase : ICountable, IFilter
    {
        public Shelter[] Shelters { get; private set; }
        public Pet[] Homeless { get; private set; }

        public DataBase()
        {
            Shelters = new Shelter[3];
            Shelters[0] = new Shelter("Простоквашино", 5, true);
            Shelters[1] = new Shelter("Приют 1", 30, true);
            Shelters[2] = new Shelter("Приют 2", 5, false);

            Homeless = new Pet[3];
            Homeless[0] = new Cat("Кот в сапогах", gender.Male, 10, 8, false, 2, true);
            Homeless[1] = new Dog("Cобака без сапог", gender.Female, 10, 8, false, leashReactivityLevel.Pulls, 2);
            Homeless[2] = new Rabbit("Кролик с сапогом", gender.Female, 1, 1, false, false, dentalStatus.Normal);

            Shelters[0].Add(new Cat("Матроскин", gender.Male, 4, 7, true, 5, true));
            Shelters[0].Add(new Dog("Шарик", gender.Male, 5, 20, true, leashReactivityLevel.Calm, 4));
            Shelters[0].Add(new Rabbit("Федор", gender.Male, 10, 10, true, true, dentalStatus.Normal));

            Shelters[1].Add(new Cat("Мурка", gender.Female, 3, 5, true, 4, false));
            Shelters[1].Add(new Cat("Барсик", gender.Male, 2, 6, true, 3, true));
            Shelters[1].Add(new Cat("Васька", gender.Male, 5, 4, true, 5, false));
            Shelters[1].Add(new Dog("Лайка", gender.Female, 4, 15, true, leashReactivityLevel.Pulls, 3));
            Shelters[1].Add(new Dog("Рекс", gender.Male, 7, 25, true, leashReactivityLevel.AggressiveToOtherDogs, 5));
            Shelters[1].Add(new Dog("Джесси", gender.Female, 2, 12, true, leashReactivityLevel.Calm, 2));
            Shelters[1].Add(new Rabbit("Пушок", gender.Male, 8, 4, true, false, dentalStatus.Normal));
            Shelters[1].Add(new Rabbit("Нюша", gender.Female, 12, 5, true, true, dentalStatus.Macclusion));
            Shelters[1].Add(new Rabbit("Роджер", gender.Male, 6, 6, true, false, dentalStatus.Normal));

            Shelters[2].Add(new Cat("Лилу", gender.Female, 2, 4, true, 3, true));
            Shelters[2].Add(new Dog("Чарли", gender.Male, 4, 18, true, leashReactivityLevel.Calm, 3, false));
            Shelters[2].Add(new Dog("Молли", gender.Female, 5, 15, true, leashReactivityLevel.Pulls, 2, false));
        }

        public DataBase(Shelter[] shelters, Pet[] homeless)
        {
            Shelters = shelters;
            Homeless = homeless;
            if (Shelters == null) Shelters = new Shelter[0];
            if (Homeless == null) Homeless = new Pet[0];
        }

        public void Add(Pet pet)
        {
            if (pet == null || Homeless == null || pet.InShelter) return;

            var newHomeless = new Pet[Homeless.Length + 1];
            Array.Copy(Homeless, newHomeless, Homeless.Length);
            newHomeless[newHomeless.Length] = pet;
            Homeless = newHomeless;
        }
        public void Add(Pet[] homeless)
        {
            if (Homeless == null || homeless == null) return;
            int numToAdd = homeless.Length;

            var newHomeless = new Pet[Homeless.Length + numToAdd];
            Array.Copy(Homeless, newHomeless, Homeless.Length);
            Array.Copy(homeless, 0, newHomeless, Homeless.Length, numToAdd);
            Homeless = newHomeless;
        }
        public void MoveTo(Pet pet, Shelter shelter)
        {
            if (pet == null || shelter == null || pet.InShelter) return;

            shelter.Add(pet);
        }
        public void MoveTo(Pet[] pet, Shelter shelter) //повторы преследуют меня
        {
            if (pet == null || shelter == null) return;

            shelter.Add(pet);
        }
        // ICountable
        public int Count()
        {
            int count = Homeless.Length;
            foreach (var shelter in Shelters)
                count += shelter.Count();
            return count;
        }

        public int Count(Type type)
        {
            if (type == typeof(Pet)) return Count();

            int count = 0;
            foreach (var pet in Homeless)
            {
                if (pet.GetType() == type) count++;
            }
            foreach(var shelter in Shelters)
            {
                count += shelter.Count(type);
            }
            return count;
        }
        public int Percentage(Type type)
        {
            return 100 * Count(type) / Count();
        }

        // IFilter
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
            int countType = Count(type);
            var filtered = new Pet[countType];
            Filter(pet => pet.GetType().IsAssignableTo(type), Homeless, ref filtered);

            int inShelterCount = 0;
            foreach(var shelter in Shelters)
            {
                inShelterCount += shelter.Count(type);
            }

            int index = countType - inShelterCount;
            foreach (var shelter in Shelters)
            {
                var current = shelter.Filter(type);
                Array.Copy(current, 0, filtered, index, current.Length);
                index += current.Length;
            }
            return filtered;
        }

        public Pet[] Filter(Type type, bool hasPhobia)
        {
            var sameType = Filter(type);
            var filtered = new Pet[HasPhobiaCount(sameType, hasPhobia)];
            Filter(pet => pet.HasClaustrophobia == hasPhobia, sameType, ref filtered);
            return filtered;
        }

        private int HasPhobiaCount(Pet[] pets, bool hasPhobia)
        {
            int count = 0;
            foreach (var pet in pets)
            {
                if (pet.HasClaustrophobia == hasPhobia) count++;
            }
            return count;
        }
    }
}

