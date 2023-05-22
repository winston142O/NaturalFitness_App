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
        private LiveCharts.WinForms.CartesianChart revenueChart2;
        private int visitantCount = 0;

        public SalesForm()
        {
            InitializeComponent();
            GenerateChart1();
            GenerateChart2();
            generatePieChart();
            revenueChart2 = new LiveCharts.WinForms.CartesianChart();

        }

        // TAB 1

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
            populateComboBox2();
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
        // generate empty charts
        private void GenerateChart1()
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
        private void GenerateChart2()
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

        // graph 1: unities sold (inv)
        private void GenerateSalesChart()
        {
            // Clear existing series
            salesChart.Series.Clear();
            salesChart.AxisX.Clear();
            salesChart.AxisY.Clear();

            // Get data
            List<int> salesData = ExtractQuantityData();
            List<string> productNames = ExtractProductNames();

            // New series
            var salesSeries = new ColumnSeries
            {
                Title = String.Format("Ventas {0}", dtpSaleDay.Value),
                Values = new ChartValues<int>(salesData),
                Fill = System.Windows.Media.Brushes.DodgerBlue,
                Stroke = System.Windows.Media.Brushes.Black,
                StrokeThickness = 1
            };

            // X-axis column names
            salesChart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Productos",
                Labels = productNames,
                Foreground = System.Windows.Media.Brushes.Black
            });

            // Y-axis
            salesChart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Ventas",
                Foreground = System.Windows.Media.Brushes.Black,
                Separator = new LiveCharts.Wpf.Separator
                {
                    Stroke = System.Windows.Media.Brushes.LightGray,
                    StrokeThickness = 1
                }
            });

            // Add series to chart
            salesChart.Series.Add(salesSeries);

            // Update the chart
            salesChart.Update();
        }
        // graph 2: money earning per product (inv)
        private void GenerateRevenueChart()
        {
            // Clear existing series
            revenueChart.Series.Clear();
            revenueChart.AxisX.Clear();
            revenueChart.AxisY.Clear();

            // Get required data
            List<decimal> revenueData = ExtractRevenueData();
            List<string> productNames = ExtractProductNames();

            // New series
            var revenueSeries = new ColumnSeries
            {
                Title = $"Ganancias {dtpSaleDay.Value}",
                Values = new ChartValues<decimal>(revenueData),
                Fill = System.Windows.Media.Brushes.Orange,
                Stroke = System.Windows.Media.Brushes.Black,
                StrokeThickness = 1
            };

            // X-axis column names
            revenueChart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Productos",
                Labels = productNames,
                Foreground = System.Windows.Media.Brushes.Black
            });

            // Y-axis
            revenueChart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Ganancias",
                Foreground = System.Windows.Media.Brushes.Black,
                Separator = new LiveCharts.Wpf.Separator
                {
                    Stroke = System.Windows.Media.Brushes.LightGray,
                    StrokeThickness = 1
                }
            });

            // Add series to chart
            revenueChart.Series.Add(revenueSeries);

            // Update the chart
            revenueChart.Update();
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

                try
                {
                    using (var package = new ExcelPackage())
                    {
                        var salesUnitsWorksheet = package.Workbook.Worksheets.Add("Sales in Units");

                        List<int> salesData = ExtractQuantityData();
                        List<string> productNames = ExtractProductNames();

                        salesUnitsWorksheet.Cells[1, 1].Value = "Producto";
                        salesUnitsWorksheet.Cells[1, 2].Value = "Unidades Vendias";

                        for (int i = 0; i < salesData.Count; i++)
                        {
                            salesUnitsWorksheet.Cells[i + 2, 1].Value = productNames[i];
                            salesUnitsWorksheet.Cells[i + 2, 2].Value = salesData[i];
                        }

                        var salesRevenueWorksheet = package.Workbook.Worksheets.Add("Sales in Revenue");

                        List<decimal> revenueData = ExtractRevenueData();

                        salesRevenueWorksheet.Cells[1, 1].Value = "Producto";
                        salesRevenueWorksheet.Cells[1, 2].Value = "Ganancias Obtenidas";

                        for (int i = 0; i < revenueData.Count; i++)
                        {
                            salesRevenueWorksheet.Cells[i + 2, 1].Value = productNames[i];
                            salesRevenueWorksheet.Cells[i + 2, 2].Value = revenueData[i];
                        }

                        string excelFilePath = Path.Combine(folderPath, $"Ventas_{saleDate:yyyy-MM-dd}.xlsx");
                        package.SaveAs(new FileInfo(excelFilePath));

                        Bitmap salesUnitsChartImage = new Bitmap(salesChart.Width, salesChart.Height);
                        salesChart.DrawToBitmap(salesUnitsChartImage, new Rectangle(0, 0, salesChart.Width, salesChart.Height));
                        string salesUnitsChartImagePath = Path.Combine(folderPath, $"UnidadesGrafico_{saleDate:yyyy-MM-dd}.png");
                        salesUnitsChartImage.Save(salesUnitsChartImagePath, System.Drawing.Imaging.ImageFormat.Png);

                        Bitmap salesRevenueChartImage = new Bitmap(revenueChart.Width, revenueChart.Height);
                        revenueChart.DrawToBitmap(salesRevenueChartImage, new Rectangle(0, 0, revenueChart.Width, revenueChart.Height));
                        string salesRevenueChartImagePath = Path.Combine(folderPath, $"GananciasGrafico_{saleDate:yyyy-MM-dd}.png");
                        salesRevenueChartImage.Save(salesRevenueChartImagePath, System.Drawing.Imaging.ImageFormat.Png);
                    }

                    MessageBox.Show("Los datos se han guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(folderPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al guardar los datos. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // nothing
            }                              
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que quieres borrar todos los datos de hoy? LOS PERDERAS SI NO LOS HAS GUARDADO...", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cbxProduct.SelectedIndex = -1;
                nudProdQty.Value = 0;
                lstOrder.Items.Clear();
                btnModify.Enabled = false;
                btnDelete.Enabled = false;
                btnGenSales.Enabled = false;
                btnClear.Enabled = false;
                btnSave.Enabled = false;

                salesChart.Series.Clear();
                revenueChart.Series.Clear();
                salesChart.AxisX.Clear();
                revenueChart.AxisX.Clear();

            }
            else
            {
                // nothing
            }
        }

        // TAB 2        
        
        private void populateComboBox2()
        {
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Winst\Documents\dbNF_Users.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "SELECT nombres, apellidos FROM tbUsers";

            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string value1 = reader["nombres"].ToString();
                    string value2 = reader["apellidos"].ToString();
                    string fullName = value1 + "-" + value2;
                    cbxMembers.Items.Add(fullName);
                }

                reader.Close();
            }
        }
        private void generatePieChart()
        {
            int memberCount = 0;
            int visitantCount = 0;

            // Count the number of members and visitors
            foreach (var item in lstEntrance.Items)
            {
                string entranceItem = item.ToString();

                if (!entranceItem.Contains("VISITANTE"))
                {
                    memberCount++;
                }
                else
                {
                    visitantCount++;
                }
            }

            // Create the pie chart
            var pieChart = new LiveCharts.WinForms.PieChart();
            pieChart.Width = 500;
            pieChart.Height = 300;

            // Create a chart series with member and visitor data
            var series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Miembros",
                    Values = new ChartValues<int> { memberCount },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Visitantes",
                    Values = new ChartValues<int> { visitantCount },
                    DataLabels = true
                }
            };

            // Set the series collection to the chart
            pieChart.Series = series;

            // Add the chart to the form or container
            pieChart.Dock = DockStyle.Top;
            // Replace tlpGraph1 with the appropriate container control in your form
            tlpPplGraph1.Controls.Add(pieChart);
        }
        private void generateRevChart()
        {
            // Clear existing series and axes
            revenueChart2.Series.Clear();
            revenueChart2.AxisX.Clear();
            revenueChart2.AxisY.Clear();

            decimal dailyCost = 100;
            decimal memberRev = 1300.00M / 31.00M;
            decimal memberRevenue = 0;
            decimal visitantRevenue = 0;

            // Calculate revenue generated by members and visitors
            foreach (var item in lstEntrance.Items)
            {
                string entranceItem = item.ToString();

                if (!entranceItem.Contains("VISITANTE"))
                {
                    // Calculate revenue generated by members
                    memberRevenue += memberRev;
                }
                else
                {
                    // Calculate revenue generated by visitors
                    visitantRevenue += dailyCost;
                }
            }

            // Create a series collection with member and visitor revenue data
            var seriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Miembros",
                    Values = new ChartValues<decimal> { memberRevenue }
                },
                new ColumnSeries
                {
                    Title = "Visitantes",
                    Values = new ChartValues<decimal> { visitantRevenue }
                }
            };

            // Create an x-axis for the chart
            revenueChart2.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Ganancias",
                Labels = new[] { "Miembros", "Visitantes" },
                Foreground = System.Windows.Media.Brushes.Black
            });

            // Create a y-axis for the chart
            revenueChart2.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Cantidad",
                Foreground = System.Windows.Media.Brushes.Black,
                Separator = new LiveCharts.Wpf.Separator
                {
                    Stroke = System.Windows.Media.Brushes.LightGray,
                    StrokeThickness = 1
                }
            });

            // Add the series collection to the chart
            revenueChart2.Series = seriesCollection;

            // Set the chart's parent container
            revenueChart2.Parent = tlpPplGraph2;
            // Set the chart's size and position within the container
            revenueChart2.Dock = DockStyle.Fill;
        }
        
        private void chkIsMember_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIsMember.Checked)
            {
                cbxMembers.Enabled = true;
                btnAdd2.Enabled = true;
                btnAddNotMember.Enabled = false;
            }
            else
            {
                btnAddNotMember.Enabled = true;
                btnAdd2.Enabled = false;
                cbxMembers.Enabled = false;
            }
        }
        private void btnClear2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que quieres borrar todos los datos de hoy? LOS PERDERAS SI NO LOS HAS GUARDADO...", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lstEntrance.Items.Clear();
                cbxMembers.SelectedIndex = -1;
                // Clear the revenue chart
                if (revenueChart2 != null)
                {
                    revenueChart2.Series.Clear();
                    revenueChart2.AxisX.Clear();
                    revenueChart2.AxisY.Clear();
                }
            }
            else
            {
                // nothing
            }
        }
        private void UpdateTotals2()
        {
            decimal monthlyCost = 1300.00M;
            decimal dailyMemberCost = monthlyCost / 31;
            decimal dailyVisitantCost = 100.00M;

            decimal totalEarnings = 0;
            int memberCount = 0;
            int totalTraffic = lstEntrance.Items.Count;

            // Iterate through each item in lstEntrance
            foreach (var item in lstEntrance.Items)
            {
                string entranceItem = item.ToString();

                // Check if the entrance item represents a member
                if (!entranceItem.Contains("VISITANTE"))
                {
                    totalEarnings += dailyMemberCost;
                    memberCount++;
                }
                else
                {
                    totalEarnings += dailyVisitantCost;
                }
            }

            // Calculate the percentage of entries due to members
            decimal memberPercentage = 0;
            if (totalTraffic > 0)
            {
                memberPercentage = (decimal)memberCount / totalTraffic * 100;
            }

            // Update the total earnings, member percentage, and total traffic text boxes
            txtEarnings2.Text = $"RD${totalEarnings:F2}";
            txtMemberPercent.Text = $"{memberPercentage:F2}%";
            txtTotalTraffic.Text = totalTraffic.ToString();
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            if (cbxMembers.SelectedItem != null)
            {
                string member = cbxMembers.SelectedItem.ToString();

                // Add member to lstEntrance
                lstEntrance.Items.Add(member);

                // Clear the selection in cbxMembers
                cbxMembers.SelectedIndex = -1;

                // Update totals
                UpdateTotals2();
                // enable all buttons
                if (btnDelete2.Enabled == false && btnGenGraph2.Enabled == false && btnSave2.Enabled == false && btnClear2.Enabled == false)
                {
                    btnDelete2.Enabled = true;
                    btnGenGraph2.Enabled = true;
                    btnClear2.Enabled = true;
                    btnSave2.Enabled = true;
                }
            }
            else
            {

            }
        }

        private void btnAddNotMember_Click(object sender, EventArgs e)
        {
            visitantCount++;

            // Create the visitant entry
            string visitantEntry = $"VISITANTE - {visitantCount}";

            // Add visitant entry to lstEntrance
            lstEntrance.Items.Add(visitantEntry);

            // Update totals
            UpdateTotals2();
            if (btnDelete2.Enabled == false && btnGenGraph2.Enabled == false && btnSave2.Enabled == false && btnClear2.Enabled == false)
            {
                btnDelete2.Enabled = true;
                btnGenGraph2.Enabled = true;
                btnClear2.Enabled = true;
                btnSave2.Enabled = true;
            }

        }

        private void btnSave2_Click(object sender, EventArgs e)
        {

        }

        private void btnGenGraph2_Click(object sender, EventArgs e)
        {
            // Clear the previous chart, if any
            tlpPplGraph1.Controls.Clear();

            // Generate the pie chart
            generatePieChart();
        }
    }
}
