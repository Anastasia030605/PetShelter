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
    public partial class Pets : Form
    {
        private Model.Core.Pet[] SelectedPets { get; set; }
        private Type TypeForPet { get; set; }
        private string NameForPet { get; set; }
        private gender GenderForPet { get; set; }
        private int AgeForPet { get; set; }
        private int WeigthForPet { get; set; }
        private bool PhobiaForPet { get; set; }
        public Pets(IFilter filterable, Type type, int claustrophobic)

        {
            InitializeComponent();

            Send(filterable, type ?? typeof(Pet), claustrophobic);

            dataGridViewPets.DataSource = SelectedPets;

            dataGridViewPets.AutoGenerateColumns = true;

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
            numericUpDownSelectAge.Minimum = 0;
            numericUpDownSelectAge.Increment = 1;
            numericUpDownSelectAge.DecimalPlaces = 0;
            //вес
            numericUpDownSelectWeight.Visible = isVisible;
            numericUpDownSelectWeight.Minimum = 0;
            numericUpDownSelectWeight.Increment = 1;
            numericUpDownSelectWeight.DecimalPlaces = 0;
            //фобия
            groupBoxSelectPhobia.Visible = isVisible;

            
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
            numericUpDownHumanInteractionScore.Minimum = 0;
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
            //обработать
        }

        private void groupBoxSelectPhobia_Enter(object sender, EventArgs e)
        {
            if (radioButtonHasPhobia.Checked)
                PhobiaForPet = true;
            else PhobiaForPet = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Send(IFilter filterable, Type type, int claustrophobic) { 
            if(claustrophobic == -1)
            {
                SelectedPets = filterable.Filter(type);
            } else
            {
                SelectedPets = filterable.Filter(type, claustrophobic != 0);
            }
        }
    }
}
