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
    public partial class XMLSerializer : Serializer
    {
        protected override string Extension => throw new NotImplementedException();

        public override void Serialize<T>(T obj, string fileName)
        {
            if (String.IsNullOrEmpty(fileName)) return;
            SelectFile(fileName);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(DataBaseDTO));
            using (FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, new DataBaseDTO(obj));
            }
        }

        public override T Deserialize<T>(string fileName)
        {
            if (String.IsNullOrEmpty(fileName)) return null;

            SelectFile(fileName);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(DataBaseDTO));
            DataBaseDTO databaseDTO;
            using (FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate))
            {
                databaseDTO = xmlSerializer.Deserialize(fs) as DataBaseDTO;
            }
            if (databaseDTO == null) return null;

            var homeless = new Pet[databaseDTO.Homeless.Length];
            for(int k = 0; k < homeless.Length; k++)
            {
                homeless[k] = databaseDTO.Homeless[k].ToPet();
            }
            var shelters = new Shelter[databaseDTO.Shelters.Length];
            for(int k = 0;k < shelters.Length; k++)
            {
                shelters[k] = databaseDTO.Shelters[k].ToShelter();
            }

            T database = (T)new DataBase(shelters, homeless);
            return database;
        }
    }
}
