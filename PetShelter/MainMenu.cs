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
using static PetShelter.MainMenu;
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
        private class ComboItem
        {
            public string Display { get; set; }  // То, что показывается
            public int Value { get; set; }      // Скрытое значение

            public override string ToString() => Display;
        }
        public MainMenu(DataBase database)
        {
            InitializeComponent();
            DataBase = database;

            textBoxSelectShelter.ReadOnly = true;
            comboBoxShelters.DataSource = DataBase.Shelters;
            comboBoxShelters.SelectedIndex = -1;

            textBoxSelectPetType.ReadOnly = true;
            comboBoxPetType.DataSource = new Type[] { typeof(Cat), typeof(Dog), typeof(Rabbit) };
            comboBoxPetType.DisplayMember = "Name";
            comboBoxPetType.SelectedIndex = -1;

            comboBoxOpenSpace.DataSource = new List<ComboItem> {
            new ComboItem { Display = "Не выбрано", Value = -1 },
            new ComboItem { Display = "Нет", Value = 0 },
            new ComboItem { Display = "Есть", Value = 1 }
        };
            comboBoxOpenSpace.DisplayMember = "Display";
            comboBoxOpenSpace.ValueMember = "Value";
            SelectedOpenSpace = -1;
            comboBoxOpenSpace.SelectedIndex = 0;

            comboBoxClaustrophobiaFilter.DataSource = new List<ComboItem> {
            new ComboItem { Display = "Не выбрано", Value = -1 },
            new ComboItem { Display = "Нет", Value = 0 },
            new ComboItem { Display = "Есть", Value = 1 }
        };
            comboBoxClaustrophobiaFilter.DisplayMember = "Display";
            comboBoxClaustrophobiaFilter.ValueMember = "Value";

            SelectedClaustrophobic = -1;
            comboBoxClaustrophobiaFilter.SelectedIndex = 0;
        }

        public void RemovePet(Pet pet)
        {
            DataBase.RemoveFromDB(pet);
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
            var comboItem = comboBoxOpenSpace.SelectedItem as ComboItem;
            SelectedOpenSpace = comboItem.Value;
            switch (SelectedOpenSpace)
            {
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
                var comboItem = comboBoxClaustrophobiaFilter.SelectedItem as ComboItem;
                SelectedClaustrophobic = comboItem.Value;
        }
    }
}
