using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NaturalFitnessApp
{
    public partial class UserCreationForm : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Winst\Documents\dbNF_Users.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand com = new SqlCommand();

        public UserCreationForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que deseas cancelar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Estás seguro de que quieres guardar este nuevo usuario en la base de datos?", "Confirmación (Añadir usuario)", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    com = new SqlCommand("INSERT INTO tbUsers(nombres,apellidos,direccion,telefono,fechaIngreso)VALUES(@nombres,@apellidos,@direccion,@telefono,@fechaIngreso)", con);
                    com.Parameters.AddWithValue("@nombres", txtNombres.Text);
                    com.Parameters.AddWithValue("@apellidos", txtApellidos.Text);
                    com.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                    com.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    com.Parameters.AddWithValue("@fechaIngreso", dtpFechaIngreso.Value);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Usuario guardado exitosamente.");
                    clearFields();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void clearFields()
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            dtpFechaIngreso.ResetText();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Estás seguro de que quieres actualizar los datos de este usuario?", "Confirmación (Actualizar Usuario)", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    com = new SqlCommand("UPDATE tbUsers SET apellidos=@apellidos, direccion=@direccion, telefono=@telefono, fechaIngreso=@fechaIngreso WHERE nombres LIKE '"+txtNombres.Text+"' ", con);
                    com.Parameters.AddWithValue("@apellidos", txtApellidos.Text);
                    com.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                    com.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    com.Parameters.AddWithValue("@fechaIngreso", dtpFechaIngreso.Value);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Usuario actualizado exitosamente.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
