using Model.Core;

namespace PetShelter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeDataFiles();
            FileLoader.Dock = DockStyle.Fill;
            FileLoader.MinimumSize = new Size(50, 30);
            FileLoader.Margin = new Padding(GetPercentagePadding(30));
            float fontSize = (FileLoader.Height) * 0.3f;
            fontSize = Math.Min(100, Math.Max(fontSize, 24));
            FileLoader.Font = new Font(FileLoader.Font.FontFamily, fontSize, FileLoader.Font.Style);
        }

        private int GetPercentagePadding(int percent)
        {
            int padding = Math.Min(
            tableLayoutPanel1.Width * percent / 100,
            tableLayoutPanel1.Height * percent / 100
            );
            return padding;
        }

        private void TableLayoutPanel1_Resize(object sender, EventArgs e)
        {
            FileLoader.Margin = new Padding(GetPercentagePadding(30));
            float fontSize = FileLoader.Height * 0.3f;
            fontSize = Math.Min(100, Math.Max(fontSize, 24));

            FileLoader.Font = new Font(FileLoader.Font.FontFamily, fontSize, FileLoader.Font.Style);
        }

        public DataBase DataBase { get; private set; }

        private void InitializeDataFiles()
        {
            string databasePath = "database.json";

            if (!File.Exists(databasePath))
            {
                DataBase defaultDB = new DataBase();
                Model.Core.JsonSerializer serializer = new Model.Core.JsonSerializer();
                serializer.Serialize(defaultDB, databasePath);
            }
        }

        private void LoadData()
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FileLoader_Click(object sender, EventArgs e)
        {

        }
      
    }
}
