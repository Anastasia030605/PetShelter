using Model.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PetShelter
{
    public partial class MainMenu : Form
    {
        private DataBase DataBase { get; set; }
        private Shelter SelectedShelter { get; set; }
        private Type SelectedPetType { get; set; }
        private int SelectedClaustrophobic { get; set; }
        private int SelectedOpenSpace { get; set; }


        public MainMenu(DataBase database)
        {
            InitializeComponent();
            DataBase = database;

            comboBoxShelters.DataSource = DataBase.Shelters;
            comboBoxShelters.SelectedIndex = -1;
            comboBoxPetType.DataSource = new Type[] { typeof(Cat), typeof(Dog), typeof(Rabbit) };
            comboBoxPetType.DisplayMember = "Name";
            comboBoxPetType.SelectedIndex = -1;

            comboBoxOpenSpace.DataSource = new[]
            {
            new { Name = "Не выбрано",  Value = -1 },
            new { Name = "Нет", Value = 0 },
            new { Name = "Есть", Value = 1 }
            };

            SelectedOpenSpace = -1;
            comboBoxOpenSpace.SelectedIndex = 0;
            comboBoxOpenSpace.DisplayMember = "Name";
            comboBoxOpenSpace.ValueMember = "Value";

            comboBoxClaustrophobiaFilter.DataSource = new[]
            {
            new { Name = "Не выбрано", Value = -1 },
            new { Name = "Нет", Value = 0 },
            new { Name = "Есть", Value = 1 }
            };

            SelectedClaustrophobic = -1;
            comboBoxClaustrophobiaFilter.SelectedIndex = 0;
            comboBoxClaustrophobiaFilter.DisplayMember = "Name";
            comboBoxClaustrophobiaFilter.ValueMember = "Value";
        }

        private void comboBoxShelters_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedShelter = comboBoxShelters.SelectedItem as Shelter;
        }

        private void comboBoxPetType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedPetType = comboBoxPetType.SelectedItem as Type;
        }

        private void buttonShowPets_Click(object sender, EventArgs e)
        {
            Pets petswindow;
            if (SelectedShelter == null)
                petswindow = new Pets(DataBase, SelectedPetType, SelectedClaustrophobic);
            else petswindow = new Pets(SelectedShelter, SelectedPetType, SelectedClaustrophobic);
            petswindow.ShowDialog();
        }

        private void comboBoxOpenSpace_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedOpenSpace = (int)comboBoxOpenSpace.SelectedValue;
            switch (SelectedOpenSpace) {
                case 0:
                    comboBoxShelters.DataSource = DataBase.Shelters.Where(shelter => !shelter.HasOpenArea).ToArray();
                    break;
                case 1:
                    comboBoxShelters.DataSource = DataBase.Shelters.Where(shelter => shelter.HasOpenArea).ToArray(); 
                    break;
                case -1:
                    comboBoxShelters.DataSource = DataBase.Shelters;
                    break;
            }
        }

        private void comboBoxClaustrophobiaFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedClaustrophobic = (int)comboBoxClaustrophobiaFilter.SelectedValue;
        }
    }
}
