using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;


namespace Model.Core
{
    internal class XmlSerializer : Serializer
    {
        protected override string Extension => throw new NotImplementedException();

        public override void Serialize<T>(T obj, string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ShelterDTO));
            //Ошибка(активно) CS1729  "XmlSerializer" не содержит конструктор, который принимает аргументы 1
            //а ничё тот факт что я так в 9 лабе делала ? как ошибку исправить ...

        }

        public override T Deserialize<T>(string fileName)
        {
            throw new NotImplementedException();
        }

        private class ShelterDTO
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
                for(int k = 0; k < Pets.Length; k++)
                {
                    Pets[k] = new PetDTO(shelter.Pets[k]);
                }
            }

        }
        private class PetDTO
        {
            public Type PetType { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public int Weigth { get; set; }
            public bool HasClaustrophobia { get; set; }

            public PetDTO() { }
            public PetDTO(Pet pet)
            {
                PetType = pet.GetType();
                Name = pet.Name;
                Age = pet.Age;
                Weigth = pet.Weigth;
                HasClaustrophobia = pet.HasClaustrophobia;
            }
        }
    }
}
