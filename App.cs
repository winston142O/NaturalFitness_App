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
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        //inventory
        private void btnCafeteria_Click(object sender, EventArgs e)
        {
            openChildForm(new InventoryForm());
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            // if there already is a childform open
            if (activeForm != null)
            {
                // close it
                activeForm.Close();
            }
            // change active form
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            openChildForm(new UserForm());
        }
    }
}
