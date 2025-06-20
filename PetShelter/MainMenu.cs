﻿using Model.Core;
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
        private Serializer SelectedSerializer { get; set; }
        public DataBase DataBase { get; private set; }
        public int SelectedShelterIndex { get; private set; }
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

            comboBoxSelectExtention.DataSource = new String[] { ".json", ".xml" };
            comboBoxSelectExtention.SelectedIndex = 1;
        }

        public bool Check(Pet pet)
        {
            return DataBase.Check(pet);
        }
        public void RemovePet(Pet pet)
        {
            DataBase.RemoveFromDB(pet);
        }

        private void comboBoxShelters_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedShelterIndex = comboBoxShelters.SelectedIndex;
        }

        private void comboBoxPetType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedPetType = comboBoxPetType.SelectedItem as Type;
        }

        private void buttonShowPets_Click(object sender, EventArgs e)
        {
            Pets petswindow;
            if (comboBoxPetType.SelectedIndex == -1) SelectedPetType = typeof(Pet);
            if (SelectedShelterIndex == -1)
                petswindow = new Pets(DataBase, SelectedPetType, SelectedClaustrophobic);
            else petswindow = new Pets(DataBase.Shelters[SelectedShelterIndex], SelectedPetType, SelectedClaustrophobic);
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

        private void comboBoxSelectExtention_SelectedIndexChanged(object sender, EventArgs e)
        {
            var extention = comboBoxSelectExtention.SelectedItem as String;
            if (extention == ".xml") SelectedSerializer = new XMLSerializer();
            else SelectedSerializer = new JsonSerializer();
        }

        private void buttonSerializer_Click(object sender, EventArgs e)
        {
            if (SelectedSerializer == null)
            {
                MessageBox.Show("Укажите расширение сохраняемого файла");
                return;
            }
            string fileName = $"Подборка_от_{DateTime.Now}";
            fileName = fileName.Replace(' ', '_');
            fileName = fileName.Replace('.', '-');
            fileName = fileName.Replace(':', '-');
            var database = new DataBase(DataBase.Shelters, DataBase.Homeless);
            SelectedSerializer.Serialize<DataBase>(database, fileName);
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            Serializer serializerFrom;
            string anotherExtention;
            var extention = comboBoxSelectExtention.SelectedItem as String;
            if (extention == ".xml")
            {
                SelectedSerializer = new XMLSerializer();
                serializerFrom = new JsonSerializer();
                anotherExtention = ".json";
            }
            else
            {
                SelectedSerializer = new JsonSerializer();
                serializerFrom = new XMLSerializer();
                anotherExtention = ".xml";
            }

            var allFiles = Directory.GetFiles(SelectedSerializer.FolderPath);
            foreach (var file in allFiles)
            {
                if (Path.GetExtension(file) == extention)
                    continue;
                string fileName = Path.GetFileName(file).Replace(anotherExtention, "");
                string filePath = file.Replace(anotherExtention, extention);
                if (File.Exists(filePath))
                    continue;
                var database = serializerFrom.Deserialize<DataBase>(file);
                SelectedSerializer.Serialize(database, fileName);
            }
        }
    }
}
