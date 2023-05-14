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
    public partial class InventoryForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Winst\Documents\dbNF_Users.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;

        public void loadProducts()
        {
            int i = 0;
            dgvInv.Rows.Clear();
            com = new SqlCommand("SELECT * FROM tbProducts", con);
            con.Open();
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvInv.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            con.Close();
        }
        public InventoryForm()
        {
            InitializeComponent();
            loadProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProductForm productCreation = new AddProductForm();
            productCreation.btnAceptar.Enabled = true;
            productCreation.btnUpdate.Enabled = true;
            productCreation.ShowDialog();
            loadProducts();
        }

        private void dgvInv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvInv.Columns[e.ColumnIndex].Name;
            if (colName == "ColEdit")
            {
                AddProductForm productCreation = new AddProductForm();
                if (dgvInv.Rows[e.RowIndex].Cells[2].Value != null)
                {
                    productCreation.txtProdName.Text = dgvInv.Rows[e.RowIndex].Cells[2].Value.ToString();
                }
                if (dgvInv.Rows[e.RowIndex].Cells[3].Value != null)
                {
                    productCreation.txtQty.Text = dgvInv.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
                if (dgvInv.Rows[e.RowIndex].Cells[4].Value != null)
                {
                    productCreation.txtPrice.Text = dgvInv.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
                if (dgvInv.Rows[e.RowIndex].Cells[5].Value != null)
                {
                    productCreation.txtDesc.Text = dgvInv.Rows[e.RowIndex].Cells[5].Value.ToString();
                }
                productCreation.btnAceptar.Enabled = false;
                productCreation.btnUpdate.Enabled = true;
                productCreation.txtProdName.Enabled = false;
                productCreation.btnCancel.Enabled = true;
                productCreation.ShowDialog();
            }
            else if (colName == "ColDelete")
            {
                if (MessageBox.Show("¿Estás seguro de que quieres eliminar este producto?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    com = new SqlCommand("DELETE FROM tbProducts WHERE pid LIKE '" + dgvInv.Rows[e.RowIndex].Cells[4].Value.ToString() + "'", con);
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Producto eliminado...");
                }
            }
            loadProducts();
        }
    }
}
