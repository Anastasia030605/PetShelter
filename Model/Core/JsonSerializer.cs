using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Model.Core
{
    public class JsonSerializer : Serializer
    {
        protected override string Extension => "json";

        public override void Serialize<T>(T obj, string fileName)
        {
            SelectFile(fileName);
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Objects,
            };
            string json = JsonConvert.SerializeObject(obj, settings);
            File.WriteAllText(FilePath, json);
        }

        public override T Deserialize<T>(string filePath)
        {
            FilePath = filePath;
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Objects,
            };
            string json = File.ReadAllText(FilePath);
            return JsonConvert.DeserializeObject<T>(json, settings);
        }
    }
}