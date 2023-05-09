using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaturalFitnessApp
{
    public partial class UserForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Winst\Documents\dbNF_Users.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;

        public UserForm()
        {
            InitializeComponent();
            loadUsers();
        }
        
        public void loadUsers()
        {
            int i = 0;
            dgvUsers.Rows.Clear();
            com = new SqlCommand("SELECT * FROM tbUsers", con);
            con.Open();
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvUsers.Rows.Add(i,dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserCreationForm userCreation = new UserCreationForm();
            userCreation.btnAceptar.Enabled = true;
            userCreation.btnUpdate.Enabled = false;
            userCreation.ShowDialog();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvUsers.Columns[e.ColumnIndex].Name;
            if (colName == "colEdit")
            {
                UserCreationForm userCreation = new UserCreationForm();
                if (dgvUsers.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    userCreation.txtNombres.Text = dgvUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                }
                if (dgvUsers.Rows[e.RowIndex].Cells[2].Value != null)
                {
                    userCreation.txtApellidos.Text = dgvUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
                }
                if (dgvUsers.Rows[e.RowIndex].Cells[3].Value != null)
                {
                    userCreation.txtDireccion.Text = dgvUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
                if (dgvUsers.Rows[e.RowIndex].Cells[4].Value != null)
                {
                    userCreation.txtTelefono.Text = dgvUsers.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
                DateTime fechaIngreso;
                if (DateTime.TryParse(dgvUsers.Rows[e.RowIndex].Cells[5].Value.ToString(), out fechaIngreso))
                {
                    userCreation.dtpFechaIngreso.Value = fechaIngreso;
                }
                userCreation.btnAceptar.Enabled = false;
                userCreation.btnUpdate.Enabled = true;
                userCreation.btnCancel.Enabled = true;

                userCreation.ShowDialog();
            }
            else if (colName == "colDelete")
            {

            }
        }
    }
}
