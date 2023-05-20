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
    public partial class ModifyQuantityDialog : Form
    {
        public ModifyQuantityDialog()
        {
            InitializeComponent();
        }
        public ModifyQuantityDialog(string productName)
        {
            InitializeComponent();
            ProductName = productName;
            txtProdName.Text = productName;
        }

        public string ProductName { get; set; }
        public int ModifiedQuantity
        {
            get { return (int)nudModifiedQuantity.Value; }
            set { nudModifiedQuantity.Value = value; }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
