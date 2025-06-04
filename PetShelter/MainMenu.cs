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

namespace PetShelter
{
    public partial class MainMenu : Form
    {
        private DataBase DataBase { get; set; }
        private Shelter SelectedShelter { get; set; }
        private Type SelectedPetType { get; set; }

        public MainMenu(DataBase database)
        {
            InitializeComponent();
            DataBase = database;

            comboBoxShelters.DataSource = DataBase.Shelters;
            comboBoxShelters.SelectedIndex = -1;
            comboBoxPetType.DataSource = new Type[] { typeof(Cat), typeof(Dog), typeof(Rabbit) };
            comboBoxPetType.DisplayMember = "Name";
            comboBoxPetType.SelectedIndex = -1;
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
            if(SelectedShelter == null) 
                petswindow = new Pets(DataBase, SelectedPetType);
            else petswindow = new Pets(SelectedShelter, SelectedPetType);
            petswindow.ShowDialog();
        }
    }
}
