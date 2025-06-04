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
        public Pets(IFilter filterable, Type type, int claustrophobic)
        {
            InitializeComponent();

            Send(filterable, type ?? typeof(Pet), claustrophobic);

            dataGridViewPets.DataSource = SelectedPets;

            dataGridViewPets.AutoGenerateColumns = true;
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
