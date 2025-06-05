using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Model.Core
{
    [JsonObject]
    public class Cat : Pet
    {
        public int HumanInteractionScore { get; private set; } // степень социализации с людьми от 1 до 5
        public bool GroomingTolerant { get; private set; }

        [JsonConstructor]
        public Cat(string name, gender gender, int age, int weight, bool inShelter, int humanInteractionScore, bool groomingTolerant, bool phobia = false) :
            base(name, gender, age, weight, inShelter, phobia) 
        {
            HumanInteractionScore = humanInteractionScore;
            GroomingTolerant = groomingTolerant;
        }
    } // Cat


    [JsonObject]
    public class Dog : Pet
    {
        public leashReactivityLevel LeashReactivityLevel { get; private set; }
        public int DailyWalks { get; private set; }

        [JsonConstructor]
        public Dog(string name, gender gender, int age, int weight, bool inShelter, leashReactivityLevel leashReactLvl, int dailyWalks, bool phobia = true) :
            base(name, gender, age, weight, inShelter, phobia) 
        { 
            LeashReactivityLevel = leashReactLvl;
            DailyWalks = dailyWalks;
        }
    } // Dog

    [JsonObject]
    public class Rabbit : Pet
    {
        public bool BondingCompatible { get; private set; } //можно содержать с другими кроликами
        public dentalStatus DentalStatus { get; private set; } //состояние зубов

        [JsonConstructor]
        public Rabbit(string name, gender gender, int age, int weight, bool inShelter, bool bondingCompatible, dentalStatus dentalStatus, bool phobia = false) :
            base(name, gender, age, weight, inShelter, phobia) 
        {
            BondingCompatible = bondingCompatible;
            DentalStatus = dentalStatus;
        }

    } // Rabbit
}
