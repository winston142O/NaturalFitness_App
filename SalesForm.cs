using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using OfficeOpenXml;
using EELicenseContext = OfficeOpenXml.LicenseContext;

namespace NaturalFitnessApp
{
    public partial class SalesForm : Form
    {
        private LiveCharts.WinForms.CartesianChart salesChart;
        private LiveCharts.WinForms.CartesianChart revenueChart;

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

            // store cuantities
            Dictionary<string, int> productQuantities = new Dictionary<string, int>();

            foreach (var item in lstOrder.Items)
            {
                string[] saleParts = item.ToString().Split('-');
                string productName = saleParts[0].Trim();
                int quantity = Convert.ToInt32(saleParts[1].Trim().Split(' ')[0]);
                decimal itemPrice = GetItemPriceFromDatabase(productName);
                totalSales += quantity * itemPrice;
                totalQty += quantity;

                // update quantities
                if (productQuantities.ContainsKey(productName))
                {
                    productQuantities[productName] += quantity;
                }
                else
                {
                    productQuantities.Add(productName, quantity);
                }
            }

            txtTotal.Text = String.Format("RD${0:F2}", totalSales);
            txtUnitsSold.Text = String.Format("{0}", totalQty);
            ClearInput();

            // most sold product
            int maxQuantity = 0;
            string mostSoldProduct = string.Empty;

            foreach (var entry in productQuantities)
            {
                if (entry.Value > maxQuantity)
                {
                    maxQuantity = entry.Value;
                    mostSoldProduct = entry.Key;
                }
            }

            txtMostSold.Text = mostSoldProduct;
        }

        private void ClearInput()
        {
            cbxProduct.SelectedIndex = -1;
            nudProdQty.Value = 0;
        }        

        private List<int> ExtractQuantityData()
        {
            List<int> salesData = new List<int>();

            // get quantity
            foreach (var item in lstOrder.Items)
            {
                string[] saleParts = item.ToString().Split('-');
                int quantity = Convert.ToInt32(saleParts[1].Trim().Split(' ')[0]);
                salesData.Add(quantity);
            }

            return salesData;
        }

        private List<string> ExtractProductNames()
        {           
            List<string> productNames = new List<string>();

            // get product names
            foreach (var item in lstOrder.Items)
            {
                string[] saleParts = item.ToString().Split('-');
                string productName = saleParts[0].Trim();
                productNames.Add(productName);
            }

            return productNames;
        }
        private List<decimal> ExtractRevenueData()
        {
            List<decimal> revenueData = new List<decimal>();

            // extract earnings $
            foreach (var item in lstOrder.Items)
            {
                string[] saleParts = item.ToString().Split('-');
                string productName = saleParts[0].Trim();
                int quantity = Convert.ToInt32(saleParts[1].Trim().Split(' ')[0]);
                decimal itemPrice = GetItemPriceFromDatabase(productName);
                decimal revenue = itemPrice * quantity;
                revenueData.Add(revenue);
            }

            return revenueData;
        }

        // graph 1: unities sold
        private void GenerateSalesChart()
        {
            // create x/y chart
            salesChart = new LiveCharts.WinForms.CartesianChart();
            // size
            salesChart.Width = 500;
            salesChart.Height = 300;

            // new collection
            var seriesCollection = new SeriesCollection();

            // get required data
            List<int> salesData = ExtractQuantityData();
            List<string> productNames = ExtractProductNames();

            // new series
            var salesSeries = new ColumnSeries
            {
                Title = String.Format("Ventas {0}", dtpSaleDay.Value),
                Values = new ChartValues<int>(salesData),
                Fill = System.Windows.Media.Brushes.DodgerBlue, // col color
                Stroke = System.Windows.Media.Brushes.Black, // col outline color
                StrokeThickness = 1 // col outline thickness
            };

            // x asis column names
            salesChart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Productos",
                Labels = productNames,
                Foreground = System.Windows.Media.Brushes.Black // lbl colors
            });

            // y axis
            salesChart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Ventas",
                Foreground = System.Windows.Media.Brushes.Black, // lbl colors
                Separator = new LiveCharts.Wpf.Separator
                {
                    Stroke = System.Windows.Media.Brushes.LightGray, // separator color
                    StrokeThickness = 1 // separator thickness
                }
            });

            // Add series to collection
            seriesCollection.Add(salesSeries);

            // add collection to chart
            salesChart.Series = seriesCollection;

            // add chart to control
            salesChart.Dock = DockStyle.Top;
            tlpGraph1.Controls.Add(salesChart);
        }


        private void GenerateRevenueChart()
        {
            // create x/y chart
            revenueChart = new LiveCharts.WinForms.CartesianChart();

            // size
            revenueChart.Width = 500;
            revenueChart.Height = 300;

            // new collection
            var seriesCollection = new SeriesCollection();

            // get required data
            List<decimal> revenueData = ExtractRevenueData();
            List<string> productNames = ExtractProductNames();

            // new series
            var revenueSeries = new ColumnSeries
            {
                Title = $"Ganancias {dtpSaleDay.Value}",
                Values = new ChartValues<decimal>(revenueData),
                Fill = System.Windows.Media.Brushes.Orange, // col color
                Stroke = System.Windows.Media.Brushes.Black, // col outline color
                StrokeThickness = 1 // col outline thickness
            };

            // x asis column names
            revenueChart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Productos",
                Labels = productNames,
                Foreground = System.Windows.Media.Brushes.Black // lbl colors
            });

            // y axis
            revenueChart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Ganancias",
                Foreground = System.Windows.Media.Brushes.Black, // lbl colors
                Separator = new LiveCharts.Wpf.Separator
                {
                    Stroke = System.Windows.Media.Brushes.LightGray, // separator color
                    StrokeThickness = 1 // separator thickness
                }
            });

            // add series to collection
            seriesCollection.Add(revenueSeries);

            // add collection to chart
            revenueChart.Series = seriesCollection;

            // add chart to control
            revenueChart.Dock = DockStyle.Top;
            tlpGraph2.Controls.Add(revenueChart);
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
                UpdateTotals();
                // enable all buttons
                if (btnModify.Enabled == false && btnDelete.Enabled == false && btnGenSales.Enabled == false && btnSave.Enabled == false && btnClear.Enabled == false)
                {
                    btnModify.Enabled = true;
                    btnDelete.Enabled = true;
                    btnGenSales.Enabled = true;
                    btnSave.Enabled = true;
                    btnClear.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar el producto y la cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstOrder.SelectedItem != null)
            {
                if (MessageBox.Show("¿Estás seguro de que quieres eliminar esta venta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // remove sale from list
                    lstOrder.Items.RemoveAt(lstOrder.SelectedIndex);
                    // update totals
                    UpdateTotals();
                }
                else
                {
                    // nothing
                }
            }            
            else
            {
                MessageBox.Show("Debe seleccionar una venta para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnGenSales_Click(object sender, EventArgs e)
        {
            GenerateSalesChart();
            GenerateRevenueChart();
            // enable save button
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que quieres guardar este récord?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DateTime saleDate = dtpSaleDay.Value;

                string folderPath = Path.Combine(Application.StartupPath, "Ventas", saleDate.ToString("yyyy-MM-dd"));


                using (var package = new ExcelPackage())
                {
                    var salesUnitsWorksheet = package.Workbook.Worksheets.Add("Sales in Units");

                    List<int> salesData = ExtractQuantityData();
                    List<string> productNames = ExtractProductNames();

                    salesUnitsWorksheet.Cells[1, 1].Value = "Product";
                    salesUnitsWorksheet.Cells[1, 2].Value = "Quantity";

                    for (int i = 0; i < salesData.Count; i++)
                    {
                        salesUnitsWorksheet.Cells[i + 2, 1].Value = productNames[i];
                        salesUnitsWorksheet.Cells[i + 2, 2].Value = salesData[i];
                    }

                    var salesRevenueWorksheet = package.Workbook.Worksheets.Add("Sales in Revenue");

                    List<decimal> revenueData = ExtractRevenueData();

                    salesRevenueWorksheet.Cells[1, 1].Value = "Product";
                    salesRevenueWorksheet.Cells[1, 2].Value = "Revenue";

                    for (int i = 0; i < revenueData.Count; i++)
                    {
                        salesRevenueWorksheet.Cells[i + 2, 1].Value = productNames[i];
                        salesRevenueWorksheet.Cells[i + 2, 2].Value = revenueData[i];
                    }

                    string excelFilePath = Path.Combine(folderPath, $"Ventas_{saleDate:yyyy-MM-dd}.xlsx");
                    package.SaveAs(new FileInfo(excelFilePath));

                    Bitmap salesUnitsChartImage = new Bitmap(salesChart.Width, salesChart.Height);
                    salesChart.DrawToBitmap(salesUnitsChartImage, new Rectangle(0, 0, salesChart.Width, salesChart.Height));
                    string salesUnitsChartImagePath = Path.Combine(folderPath, $"SalesUnitsChart_{saleDate:yyyy-MM-dd}.png");
                    salesUnitsChartImage.Save(salesUnitsChartImagePath, System.Drawing.Imaging.ImageFormat.Png);

                    Bitmap salesRevenueChartImage = new Bitmap(revenueChart.Width, revenueChart.Height);
                    revenueChart.DrawToBitmap(salesRevenueChartImage, new Rectangle(0, 0, revenueChart.Width, revenueChart.Height));
                    string salesRevenueChartImagePath = Path.Combine(folderPath, $"SalesRevenueChart_{saleDate:yyyy-MM-dd}.png");
                    salesRevenueChartImage.Save(salesRevenueChartImagePath, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
            else
            {
                // nothing
            }                        
        }
    }
}
