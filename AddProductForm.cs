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
    public partial class AddProductForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbNF_Users.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand com = new SqlCommand();

        public AddProductForm()
        {
            InitializeComponent();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Estás seguro de que quieres añadir este nuevo producto al inventario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    com = new SqlCommand("INSERT INTO tbProducts(pname,pqty,pprice,pdesc)VALUES(@pname,@pqty,@pprice,@pdesc)", con);
                    com.Parameters.AddWithValue("@pname", txtProdName.Text);
                    com.Parameters.AddWithValue("@pqty", Convert.ToInt16(txtQty.Text));
                    com.Parameters.AddWithValue("@pprice", Convert.ToDecimal(txtPrice.Text));
                    com.Parameters.AddWithValue("@pdesc", txtDesc.Text);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Producto añadido exitosamente.");
                    clearFields();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Estás seguro de que quieres actualizar los datos de este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    com = new SqlCommand("UPDATE tbProducts SET pqty=@pqty, pprice=@pprice, pdesc=@pdesc WHERE pname LIKE'" + txtProdName.Text + "' ", con);
                    com.Parameters.AddWithValue("@pqty", txtQty.Text);
                    com.Parameters.AddWithValue("@pprice", txtPrice.Text);
                    com.Parameters.AddWithValue("@pdesc", txtDesc.Text);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Producto actualizado exitosamente.");
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
            txtProdName.Clear();
            txtQty.Clear();
            txtPrice.Clear();
            txtDesc.Clear();
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
    }
}
