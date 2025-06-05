using Model.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PetShelter
{
    public partial class Pets : Form
    {
        private IFilter _filterable;
        private Type _showType;
        private int _showFobia;

        private Model.Core.Pet[] SelectedPets { get; set; }
        private Type TypeForPet { get; set; }
        private string NameForPet { get; set; }
        private gender GenderForPet { get; set; }
        private int AgeForPet { get; set; }
        private int WeigthForPet { get; set; }
        private bool PhobiaForPet { get; set; }
        //Cat
        private int InteractionScoreForCat { get; set; }
        private bool TolerantGroomingForCar { get; set; }
        //Dog
        private leashReactivityLevel LeashReactivityLevelForDog { get; set; }
        private int DailyWalkForDog { get; set; }
        //Rabbit
        private bool BondingCompatibleForRabbit { get; set; }
        private dentalStatus DentalStatusForRabbit { get; set; }

        public Pets(IFilter filterable, Type type, int claustrophobic)

        {
            InitializeComponent();
            _filterable = filterable;
            _showType = type;
            _showFobia = claustrophobic;

            Send(filterable, type ?? typeof(Pet), claustrophobic);

            dataGridViewPets.DataSource = SelectedPets;

            dataGridViewPets.AutoGenerateColumns = true;
            dataGridViewPets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            bool isVisible = filterable is Shelter shelter;
            //тип
            comboBoxSelectType.Visible = isVisible;
            comboBoxSelectType.DataSource = new Type[] { typeof(Cat), typeof(Dog), typeof(Rabbit) };
            comboBoxSelectType.DisplayMember = "Name";
            comboBoxSelectType.SelectedIndex = -1;
            //имя
            textBoxEnterName.Visible = isVisible;
            textBoxEnterName.AccessibleName = "введите имя животного";
            //пол
            groupBoxSelectDender.Visible = isVisible;
            //возраст
            numericUpDownSelectAge.Visible = isVisible;
            numericUpDownSelectAge.Minimum = 1;
            numericUpDownSelectAge.Increment = 1;
            numericUpDownSelectAge.DecimalPlaces = 0;
            //вес
            numericUpDownSelectWeight.Visible = isVisible;
            numericUpDownSelectWeight.Minimum = 1;
            numericUpDownSelectWeight.Increment = 1;
            numericUpDownSelectWeight.DecimalPlaces = 0;
            //фобия
            groupBoxSelectPhobia.Visible = isVisible;

            //
            buttonAddPet.Visible = isVisible;
        }

        private void comboBoxSelectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeForPet = comboBoxSelectType.SelectedItem as Type;

            bool visibleForCat = TypeForPet == typeof(Cat);
            bool visibleForDog = TypeForPet == typeof(Dog);
            bool visibleForRabbit = TypeForPet == typeof(Rabbit);

            //Cat
            //HumanInteractionScore 
            numericUpDownHumanInteractionScore.Visible = visibleForCat;
            numericUpDownHumanInteractionScore.Minimum = 1;
            numericUpDownHumanInteractionScore.Maximum = 5;
            numericUpDownHumanInteractionScore.Increment = 1;
            numericUpDownHumanInteractionScore.DecimalPlaces = 0;
            numericUpDownHumanInteractionScore.Value = 3;
            //GroomingTolerant
            groupBoxGroomingTolerant.Visible = visibleForCat;

            //Dog
            //LeashReactivityLevel
            groupBoxLeashReactivityLevel.Visible = visibleForDog;
            //DailyWalks
            numericUpDownDailyWalks.Visible = visibleForDog;
            numericUpDownDailyWalks.Minimum = 0;
            numericUpDownDailyWalks.Maximum = 10;
            numericUpDownDailyWalks.DecimalPlaces = 0;

            //Rabbit
            //BondingCompatible
            groupBoxBondingCompatible.Visible = visibleForRabbit;
            groupBoxDentalStatus.Visible = visibleForRabbit;
            //DentalStatus
        }
        private void buttonAddPet_Click(object sender, EventArgs e)
        {
            if (!BaseFieldsCheck()) return;
            var shelter = _filterable as Shelter;
            Pet pet;
            if (TypeForPet == typeof(Cat))
            {
                if (!CatFieldsCheck()) return;
                pet = new Cat(NameForPet, GenderForPet, AgeForPet, WeigthForPet, true, InteractionScoreForCat, TolerantGroomingForCar, PhobiaForPet);

            }
            else if (TypeForPet == typeof(Dog))
            {
                if (!DogFieldCheck()) return;
                pet = new Dog(NameForPet, GenderForPet, AgeForPet, WeigthForPet, true, LeashReactivityLevelForDog, DailyWalkForDog, PhobiaForPet);

            }
            else if (TypeForPet == typeof(Rabbit))
            {
                if (!RabbitFieldsCheck()) return;
                pet = new Rabbit(NameForPet, GenderForPet, AgeForPet, WeigthForPet, true, BondingCompatibleForRabbit, DentalStatusForRabbit, PhobiaForPet);
            }
            else return;
            shelter.Add(pet);
            //обновить окно
            Send(shelter, _showType, _showFobia);
            dataGridViewPets.DataSource = SelectedPets;
        }
        private bool BaseFieldsCheck()
        {
            if (TypeForPet == null)
            {
                MessageBox.Show("выберите тип питомца");
                return false;
            }
            if (String.IsNullOrWhiteSpace(NameForPet))
            {
                MessageBox.Show("дайте имя питомцу");
                return false;
            }
            System.Windows.Forms.RadioButton selected = groupBoxSelectDender.Controls.OfType<System.Windows.Forms.RadioButton>().FirstOrDefault(r => r.Checked);
            if (selected == null)
            {
                MessageBox.Show("укажите пол питомца");
                return false;
            }
            selected = groupBoxSelectPhobia.Controls.OfType<System.Windows.Forms.RadioButton>().FirstOrDefault(r => r.Checked);
            if (selected == null)
            {
                MessageBox.Show("укажите наличие фобии");
                return false;
            }
            if (AgeForPet == 0)
            {
                MessageBox.Show("укажите возраст питомца");
                return false;
            }
            if (WeigthForPet == 0)
            {
                MessageBox.Show("укажите вес питомца");
                return false;
            }
            return true;
        }
        private bool CatFieldsCheck()
        {
            if (InteractionScoreForCat == 0)
            {
                MessageBox.Show("укажите HumanInteractionScore");
                return false;
            }
            var selected = groupBoxGroomingTolerant.Controls.OfType<System.Windows.Forms.RadioButton>().FirstOrDefault(r => r.Checked);
            if (selected == null)
            {
                MessageBox.Show("груминг толерант?");
                return false;
            }
            return true;
        }
        private bool DogFieldCheck()
        {
            var selected = groupBoxLeashReactivityLevel.Controls.OfType<System.Windows.Forms.RadioButton>().FirstOrDefault(r => r.Checked);
            if (selected == null)
            {
                MessageBox.Show("укажите LeashReactivityLevel");
                return false;
            }
            //проверка DailyWalks ???
            return true;
        }
        private bool RabbitFieldsCheck()
        {
            var selected = groupBoxBondingCompatible.Controls.OfType<System.Windows.Forms.RadioButton>().FirstOrDefault(r => r.Checked);
            if(selected == null)
            {
                MessageBox.Show("укажите BondingCompatible");
                return false;
            }
            selected = groupBoxDentalStatus.Controls.OfType<System.Windows.Forms.RadioButton>().FirstOrDefault(r => r.Checked);
            if (selected == null)
            {
                MessageBox.Show("укажите DentalStatus");
                return false;
            }
            return true;
        }
        //for pet
        private void textBoxEnterName_TextChanged(object sender, EventArgs e)
        {
            NameForPet = textBoxEnterName.Text;
        }
        private void numericUpDownSelectAge_ValueChanged(object sender, EventArgs e)
        {
            AgeForPet = (int)numericUpDownSelectAge.Value;
        }
        private void numericUpDownSelectWeight_ValueChanged(object sender, EventArgs e)
        {
            WeigthForPet = (int)numericUpDownSelectWeight.Value;
        }
        private void groupBoxSelectDender_Enter(object sender, EventArgs e)
        {
            if (radioButtonSelectedGenderMale.Checked)
                GenderForPet = gender.Male;
            if (radioButtonSelectedGenderFemale.Checked)
                GenderForPet = gender.Female;
        }
        private void groupBoxSelectPhobia_Enter(object sender, EventArgs e)
        {
            if (radioButtonHasPhobia.Checked)
                PhobiaForPet = true;
            else PhobiaForPet = false;
        }
        //for cat
        private void numericUpDownHumanInteractionScore_ValueChanged(object sender, EventArgs e)
        {
            InteractionScoreForCat = (int)numericUpDownHumanInteractionScore.Value;
        }
        private void groupBoxGroomingTolerant_Enter(object sender, EventArgs e)
        {
            radioButtonTolerant.CheckedChanged += RadioButtonCheckedChanged_GroomingTolersnt;
            radioButtonNotTolerant.CheckedChanged += RadioButtonCheckedChanged_GroomingTolersnt;
        }
        private void RadioButtonCheckedChanged_GroomingTolersnt(object sender, EventArgs e)
        {
            var selectedRB = sender as System.Windows.Forms.RadioButton;
            if (selectedRB != null && selectedRB.Checked)
                TolerantGroomingForCar = selectedRB.Text == "yes";
        }
        //for dog
        private void groupBoxLeashReactivityLevel_Enter(object sender, EventArgs e)
        {
            radioButtonUndefined.CheckedChanged += RadioButtonCheckedChanged_LeashReactivityLevel;
            radioButtonCalm.CheckedChanged += RadioButtonCheckedChanged_LeashReactivityLevel;
            radioButtonPulls.CheckedChanged += RadioButtonCheckedChanged_LeashReactivityLevel;
            radioButtonAggressiveToOtherDogs.CheckedChanged += RadioButtonCheckedChanged_LeashReactivityLevel;
            radioButtonFearful.CheckedChanged += RadioButtonCheckedChanged_LeashReactivityLevel;
        }
        private void RadioButtonCheckedChanged_LeashReactivityLevel(object sender, EventArgs e)
        {
            var selectedRB = sender as System.Windows.Forms.RadioButton;
            if (selectedRB != null && selectedRB.Checked)
            {
                if (selectedRB.Text == "Undefined")
                    LeashReactivityLevelForDog = leashReactivityLevel.Undefined;
                else if (selectedRB.Text == "Calm")
                    LeashReactivityLevelForDog = leashReactivityLevel.Calm;
                else if (selectedRB.Text == "Pulls")
                    LeashReactivityLevelForDog = leashReactivityLevel.Pulls;
                else if (selectedRB.Text == "AggressiveToOtherDogs")
                    LeashReactivityLevelForDog = leashReactivityLevel.AggressiveToOtherDogs;
                else if (selectedRB.Text == "Fearful")
                    LeashReactivityLevelForDog = leashReactivityLevel.Fearful;
            }
        }
        private void numericUpDownDailyWalks_ValueChanged(object sender, EventArgs e)
        {
            DailyWalkForDog = (int)numericUpDownDailyWalks.Value;
        }
        //for rabbit
        private void groupBoxBondingCompatible_Enter(object sender, EventArgs e)
        {
            radioButtonBondingCompatible.CheckedChanged += RadioButtonCheckedChanged_BondingCompatible;
            radioButtonNotBondingCompatible.CheckedChanged += RadioButtonCheckedChanged_BondingCompatible;
        }
        private void RadioButtonCheckedChanged_BondingCompatible(object sender, EventArgs e)
        {
            var selectedRB = sender as System.Windows.Forms.RadioButton;
            if (selectedRB != null && selectedRB.Checked)
                BondingCompatibleForRabbit = selectedRB.Text == "yes";
        }
        private void groupBoxDentalStatus_Enter(object sender, EventArgs e)
        {
            radioButtonDentalStatusMacclusion.CheckedChanged += RadioButtonCheckedChanged_DentalStatus;
            radioButtonDentalStatusNormal.CheckedChanged += RadioButtonCheckedChanged_DentalStatus;
        }
        private void RadioButtonCheckedChanged_DentalStatus(object sender, EventArgs e)
        {
            var selectedRB = sender as System.Windows.Forms.RadioButton;
            if (selectedRB != null && selectedRB.Checked)
            {
                if (selectedRB.Text == "Macclusion")
                    DentalStatusForRabbit = dentalStatus.Macclusion;
                else if (selectedRB.Text == "Normal")
                    DentalStatusForRabbit = dentalStatus.Normal;

            }
        }
        
        private void Send(IFilter filterable, Type type, int claustrophobic)
        {
            if (claustrophobic == -1)
            {
                SelectedPets = filterable.Filter(type);
            }
            else
            {
                SelectedPets = filterable.Filter(type, claustrophobic != 0);
            }
        }

        private void DeletePet_Click(object sender, EventArgs e)
        {
            if(dataGridViewPets.SelectedRows.Count == 0) return;
            Pet pet = (Pet)dataGridViewPets.SelectedRows[0].DataBoundItem;
            MainMenu mainMenu = Application.OpenForms.OfType<MainMenu>().FirstOrDefault();
            if(mainMenu == null)
            {
                MessageBox.Show("Oops I did it again");
            }
            mainMenu.RemovePet(pet);
            //update
            IFilter filterable;
            if (mainMenu.SelectedShelterIndex == -1)
                filterable = mainMenu.DataBase;
            else filterable = mainMenu.DataBase.Shelters[mainMenu.SelectedShelterIndex];
            Send(filterable, _showType, _showFobia);
            dataGridViewPets.DataSource = SelectedPets;
        }
    }
}
