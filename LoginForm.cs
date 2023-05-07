using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NaturalFitnessApp
{
    public partial class LoginForm : Form
    {
        // user and password definition
        private string userName = "admin";
        private string passWord = "admin1234";

        public LoginForm()
        {
            InitializeComponent();
        }             

        // exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("¿Desea Salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                // nada
            }
        }

        // login and load app
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // verificar credenciales
            if (txtUsername.Text == userName && txtPassword.Text == passWord)
            {
                new App().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nombre o usuario incorrecto. Intente otra vez...");
            }
        }

        // show password method
        private void checkBox_ViewPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ViewPass.Checked)
            {
                // show password
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                // hide password
                txtPassword.PasswordChar = '*';
            }
        }

        // change username field color on focus
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.FromArgb(241, 219, 73);
            this.Refresh();
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.White;
            this.Refresh();
        }

        // change password field color on focus
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.FromArgb(241, 219, 73);
            this.Refresh();
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
            this.Refresh();
        }
    }
}
