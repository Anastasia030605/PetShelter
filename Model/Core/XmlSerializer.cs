using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;


namespace Model.Core
{
    internal class XMLSerializer : Serializer
    {
        protected override string Extension => throw new NotImplementedException();

        public override void Serialize<T>(T obj, string fileName)
        {
            if (String.IsNullOrEmpty(fileName)) return;
            SelectFile(fileName);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ShelterDTO));
            using (FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, new ShelterDTO(obj));
            }
        }

        public override T Deserialize<T>(string fileName)
        {
            if (String.IsNullOrEmpty(fileName)) return null;

            SelectFile(fileName);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ShelterDTO));
            ShelterDTO obj;
            using (FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate))
            {
                obj = xmlSerializer.Deserialize(fs) as ShelterDTO;
            }
            if (obj == null) return null;

            T shelter = (T)new Shelter(obj.Name, obj.Capacity, obj.HasOpenArea);
            foreach (var petDTO in obj.Pets)
            {
                Pet pet;
                if (petDTO.PetType == typeof(Cat))
                {
                    pet = new Cat(petDTO.Name, petDTO.Age, petDTO.Weigth, petDTO.HasClaustrophobia);
                }
                else if (petDTO.PetType == typeof(Dog))
                {
                    pet = new Dog(petDTO.Name, petDTO.Age, petDTO.Weigth, petDTO.HasClaustrophobia);
                }
                else if (petDTO.PetType == typeof(Rabbit))
                {
                    pet = new Rabbit(petDTO.Name, petDTO.Age, petDTO.Weigth, petDTO.HasClaustrophobia);
                }
                else continue;
                shelter.Add(pet);
            }
            return shelter;
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
