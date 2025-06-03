using Model.Core;
//using Newtonsoft.Json;

namespace PetShelter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeDataFiles();
            FileLoader.Anchor = AnchorStyles.None;
            FileLoader.Location = new Point(
            (this.ClientSize.Width - FileLoader.Width) / 2,
            (this.ClientSize.Height - FileLoader.Height) / 2
        );
            this.Resize += (sender, e) => {
                FileLoader.Location = new Point(
                    (this.ClientSize.Width - FileLoader.Width) / 2,
                    (this.ClientSize.Height - FileLoader.Height) / 2
                );
            };
            this.Resize += (sender, e) =>
            {
                FileLoader.Height = Math.Min(this.ClientSize.Height / 2, this.ClientSize.Width / 2);
                FileLoader.Width = FileLoader.Height;
            };
        }

        public DataBase DataBase { get; private set; }
        public string BaseDir { get; private set; }

        private void InitializeDataFiles()
        {
            string databasePath = "database";

            if (!File.Exists(databasePath))
            {
                DataBase defaultDB = new DataBase();
                Model.Core.JsonSerializer serializerJson = new();
                Model.Core.XMLSerializer serializerXml = new();
                serializerJson.Serialize(defaultDB, databasePath);
                serializerXml.Serialize(defaultDB, databasePath);
                BaseDir = serializerJson.FolderPath;
            }
        }

        private void LoadData(string FilePath)
        {
            if (string.IsNullOrWhiteSpace(FilePath))
            {
                MessageBox.Show("Некорректный путь к файлу",
                                "Повторите попытку",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                return;
            }
            
            Serializer serializer;
            if (Path.GetExtension(FilePath).ToLower() == ".json")
                serializer = new JsonSerializer();
            else serializer = new XMLSerializer();

            try {
                this.DataBase = serializer.Deserialize<DataBase>(FilePath); //JsonConvert.DeserializeObject<DataBase>(File.ReadAllText(FilePath));
                MessageBox.Show("Файл успешно загружен");
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message,
                                "Повторите попытку",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
            }
        }

        private void FileLoader_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Выберите JSON или XML файл";
            openFileDialog.Filter = "JSONorXML files (*.json;*.xml)|*.json;*.xml|Все файлы (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.InitialDirectory = BaseDir;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                
                if (Path.GetExtension(selectedFilePath).ToLower() != ".json" && Path.GetExtension(selectedFilePath).ToLower() != ".xml")
                {
                    MessageBox.Show("Пожалуйста, выберите файл с расширением .json или .xml",
                                 "Неверный формат файла",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                    return;
                }

                LoadData(selectedFilePath);
            }
        }
    }
}
