using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaturalFitnessApp
{
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProductForm productCreation = new AddProductForm();
            productCreation.btnAceptar.Enabled = true;
            productCreation.btnUpdate.Enabled = true;
            productCreation.ShowDialog();
        }
    }
}
