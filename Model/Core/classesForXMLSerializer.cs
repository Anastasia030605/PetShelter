using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
    public partial class XMLSerializer : Serializer
    {
        public class DataBaseDTO
        {
            public ShelterDTO[] Shelters { get; set; }
            public PetDTO[] Homeless { get; set; }

            public DataBaseDTO() { }
            public DataBaseDTO(DataBase database)
            {
                Shelters = new ShelterDTO[database.Shelters.Length];
                for(int k = 0;  k < database.Shelters.Length; k++)
                {
                    Shelters[k]= new ShelterDTO(database.Shelters[k]);
                }
                Homeless = new PetDTO[database.Homeless.Length];
                for(int k = 0;k < database.Homeless.Length; k++)
                {
                    Homeless[k]= new PetDTO(database.Homeless[k]);
                }
            }

        }// DataBaseDTO

        public class ShelterDTO
        {
            public string Name { get; set; }
            public int Capacity { get; set; }
            public bool HasOpenArea { get; set; }
            public PetDTO[] Pets { get; set; }

            public ShelterDTO() { }
            public ShelterDTO(Shelter shelter)
            {
                Name = shelter.Name;
                Capacity = shelter.Capacity;
                HasOpenArea = shelter.HasOpenArea;
                Pets = new PetDTO[shelter.Pets.Length];
                for (int k = 0; k < Pets.Length; k++)
                {
                    Pets[k] = new PetDTO(shelter.Pets[k]);
                }
            }

            public Shelter ToShelter()
            {
                var shelter =  new Shelter(Name, Capacity, HasOpenArea);
                foreach (var petDTO in Pets)
                    shelter.Add(petDTO.ToPet());
                return shelter;
            }
        }// ShelterDTO


        public class PetDTO
        {
            // тип
            public string PetType { get; set; } 
            // общия свойства
            public string Name { get; set; }
            public gender Gender { get; set; }
            public int Age { get; set; }
            public int Weigth { get; set; }
            public bool InShelter { get; set; }
            public bool HasClaustrophobia { get; set; }
            // уникальные свойства типов
            public int HumanInteractionScore { get; set; } // Cat
            public bool GroomingTolerant { get; set; } // Cat
            public leashReactivityLevel LeashReactivityLevel { get; set; } // Dog
            public int DailyWalks { get; set; } // Dog
            public bool BondingCompatible { get; set; } // Rabbit
            public dentalStatus DentalStatus { get; set; } // Rabbit

            public PetDTO() { }
            public PetDTO(Pet pet)
            {
                PetType = pet.GetType().ToString();
                Name = pet.Name;
                Gender = pet.Gender;
                Age = pet.Age;
                Weigth = pet.Weigth;
                InShelter = pet.InShelter;
                HasClaustrophobia = pet.HasClaustrophobia;
                if(pet is Cat cat)
                {
                    HumanInteractionScore = cat.HumanInteractionScore;
                    GroomingTolerant = cat.GroomingTolerant;
                }
                else if (pet is Dog dog)
                {
                    LeashReactivityLevel = dog.LeashReactivityLevel;
                    DailyWalks = dog.DailyWalks;
                }
                else if(pet is Rabbit rabbit) 
                {
                    BondingCompatible = rabbit.BondingCompatible;
                    DentalStatus = rabbit.DentalStatus;
                }
            }

            public Pet ToPet()
            {
                if (PetType == typeof(Cat).ToString())
                    return new Cat(Name, Gender, Age, Weigth, InShelter, HumanInteractionScore, GroomingTolerant, HasClaustrophobia);
                if (PetType == typeof(Dog).ToString())
                    return new Dog(Name, Gender, Age, Weigth, InShelter, LeashReactivityLevel, DailyWalks, HasClaustrophobia);
                if (PetType == typeof(Rabbit).ToString())
                    return new Rabbit(Name, Gender, Age, Weigth, InShelter, BondingCompatible, DentalStatus, HasClaustrophobia);
                return null;
            }
        }// PetDTO
    }
}
