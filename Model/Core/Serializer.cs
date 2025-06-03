using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
    public abstract class Serializer
    {
        //private static int count;
        public string FilePath { get; protected set; }
        public string FolderPath
        {
            get
            {
                string baseDir = AppContext.BaseDirectory;
                string projectDir = Path.GetFullPath(Path.Combine(baseDir, "../../.."));
                string dataDir = Path.Combine(projectDir, "Data");
                if (!Directory.Exists(dataDir))
                    Directory.CreateDirectory(dataDir);
                return dataDir;
            }
        }
        protected abstract string Extension { get; }

        public void SelectFile(string name)
        {
            string fileName = String.Concat(name, ".", Extension);
            FilePath = Path.Combine(FolderPath, fileName);
            string[] file = Directory.GetFiles(FolderPath, fileName);
            if (file == null || file.Length == 0)
                using (File.Create(FilePath)) ;
        }

        public bool CheckFormat(string file)
        {
            if (Path.GetExtension(file) == "json" || Path.GetExtension(file) == "xml")
            {
                string fileName = Path.GetFileName(file);
                string[] nameComponents = fileName.Split('_'); //Подборка_№Х_от_data
                if(nameComponents.Length == 4)
                {
                    if (nameComponents[0] == "Подборка" && nameComponents[2] == "от")
                        return true;
                    return false;
                }
                else return false;
            }
            else return false;
        }

        public abstract void Serialize<T>(T obj, string fileName) where T : DataBase;
        public abstract T Deserialize<T>(string filePath) where T : DataBase;
    }
}