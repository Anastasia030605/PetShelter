using Model.Core;
using Newtonsoft.Json;

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
                Model.Core.JsonSerializer serializer = new();
                serializer.Serialize(defaultDB, databasePath);
                BaseDir = serializer.FolderPath;
            }
        }

        private void LoadData(string FilePath)
        {
            if (string.IsNullOrWhiteSpace(FilePath)) {
                MessageBox.Show("������������ ���� � �����",
                                "��������� �������",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                return; 
            }
            try {
                this.DataBase = JsonConvert.DeserializeObject<DataBase>(File.ReadAllText(FilePath));
                MessageBox.Show("���� ������� ��������");
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message,
                                "��������� �������",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
            }
        }

        private void FileLoader_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "�������� JSON-����";
            openFileDialog.Filter = "JSON files (*.json)|*.json|��� ����� (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.InitialDirectory = BaseDir;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                if (Path.GetExtension(selectedFilePath).ToLower() != ".json")
                {
                    MessageBox.Show("����������, �������� ���� � ����������� .json",
                                 "�������� ������ �����",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                    return;
                }

                LoadData(selectedFilePath);
            }
        }
    }
}
