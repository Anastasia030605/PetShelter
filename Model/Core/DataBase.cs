using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
    public class DataBase
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

        //private void Add<T>(T elem, ref T[] array)
        //{
        //    if (elem == null || array == null) return;

        //    var newArray = new T[array.Length + 1];
        //    Array.Copy(array, newArray, array.Length);
        //    newArray[newArray.Length] = elem;
        //    array = newArray;
        //}                         :((
    }
}
