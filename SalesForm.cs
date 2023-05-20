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
using System.Xml;

namespace NaturalFitnessApp
{
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
        }
        private void PopulateComboBox()
        {
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Winst\Documents\dbNF_Users.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "SELECT pName FROM tbProducts";

            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string value = reader["pName"].ToString();
                    cbxProduct.Items.Add(value);
                }

                reader.Close();
            }
        }
          
        private void SalesForm_Load(object sender, EventArgs e)
        {
            PopulateComboBox();
        }

        private decimal GetItemPriceFromDatabase(string productName)
        {
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Winst\Documents\dbNF_Users.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "SELECT pPrice FROM tbProducts WHERE pName = @ProductName";

            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductName", productName);

                connection.Open();

                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    decimal itemPrice = Convert.ToDecimal(result);
                    return itemPrice;
                }
            }

            // default price
            return 0;
        }

        private void UpdateTotals()
        {            
            decimal totalSales = 0;
            int totalQty = 0;
            foreach (var item in lstOrder.Items)
            {
                string[] saleParts = item.ToString().Split('-');
                int quantity = Convert.ToInt32(saleParts[1].Trim().Split(' ')[0]);
                decimal itemPrice = GetItemPriceFromDatabase(saleParts[0]);
                totalSales += quantity * itemPrice;
                totalQty += quantity;
            }
            txtTotal.Text = String.Format("RD${0:F2}", totalSales);
            txtUnitsSold.Text = String.Format("{0}", totalQty);
            ClearInput();
        }

        private void ClearInput()
        {
            cbxProduct.SelectedIndex = -1;
            nudProdQty.Value = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbxProduct.SelectedItem != null && nudProdQty.Value > 0)
            {
                string prod = cbxProduct.SelectedItem.ToString();
                int prodQty = Convert.ToInt32(nudProdQty.Value);
                string saleText = $"{prod} - {prodQty} UNIDADES";
                // add sale to list
                lstOrder.Items.Add(saleText);
                // get item price
                decimal itemPrice = GetItemPriceFromDatabase(prod);
                // calc sales total
                decimal totalSales = 0;
                int totalQty = 0;
                foreach (var item in lstOrder.Items)
                {
                    string[] saleParts = item.ToString().Split('-');
                    int quantity = Convert.ToInt32(saleParts[1].Trim().Split(' ')[0]);
                    totalSales += quantity * itemPrice;
                    totalQty += quantity;
                }
                txtTotal.Text = String.Format("RD${0:F2}", totalSales);
                txtUnitsSold.Text = String.Format("{0}", totalQty);
                ClearInput();
            }
            else
            {
                MessageBox.Show("Debe seleccionar el producto y la cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que quieres eliminar esta venta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (lstOrder.SelectedItem != null)
                {
                    // remove sale from list
                    lstOrder.Items.RemoveAt(lstOrder.SelectedIndex);
                    // update totals
                    UpdateTotals();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una venta para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // nothing
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (lstOrder.SelectedItem != null)
            {
                // get sale from list
                string selectedSale = lstOrder.SelectedItem.ToString();
                // split into array to get name and qty
                string[] saleParts = selectedSale.Split('-');
                string prod = saleParts[0].Trim();               
                int prodQty = Convert.ToInt32(saleParts[1].Trim().Split(' ')[0]);
                // show modification window                
                ModifyQuantityDialog dialog = new ModifyQuantityDialog(prod);
                dialog.ModifiedQuantity = prodQty;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // update sale
                    int modifiedQty = dialog.ModifiedQuantity;
                    string modifiedSale = $"{prod} - {modifiedQty} UNIDADES";
                    lstOrder.Items[lstOrder.SelectedIndex] = modifiedSale;
                    // update totals
                    UpdateTotals();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una venta para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
