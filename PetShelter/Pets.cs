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
        public Pets(IFilter filterable, Type type)
        {
            InitializeComponent();

            if (type != null)
                SelectedPets = filterable.Filter(type);
            else
                SelectedPets = filterable.Filter(typeof(Pet));
            dataGridViewPets.DataSource = SelectedPets;

            dataGridViewPets.AutoGenerateColumns = true;
        }
    }
}
