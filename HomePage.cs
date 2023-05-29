using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Definitions.Charts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using EELicenseContext = OfficeOpenXml.LicenseContext;
using LiveCharts.Defaults;
using System.Windows.Media;
using System.Diagnostics;

namespace NaturalFitnessApp
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            UpdateHomePage();
            UpdateSalesChart();
            UpdateEntryChart();
            setLastDayEntry();
            setLastDaySales();
        }

        private void setLastDaySales()
        {
            string ventasFolderPath = Path.Combine(Application.StartupPath, "Ventas"); // folder path
            string[] subfolders = Directory.GetDirectories(ventasFolderPath); // get subfolders
            string latestSubfolder = subfolders.OrderByDescending(f => f).FirstOrDefault(); // order by name (day)

            if (latestSubfolder != null)
            {
                string lastDay = Path.GetFileName(latestSubfolder); // get last subfolder name
                DateTime lastDayDate;
                if (DateTime.TryParse(lastDay, out lastDayDate))
                {
                    string formattedDate = lastDayDate.ToString("dd/MMM/yyyy", new CultureInfo("es-ES")); // date in spanish
                    lblSales.Text = "Resumen de Ventas (" + formattedDate + ")"; // set date
                }
            }
        }

        private void setLastDayEntry()
        {
            string ventasFolderPath = Path.Combine(Application.StartupPath, "Entradas"); // folder path
            string[] subfolders = Directory.GetDirectories(ventasFolderPath); // get subfolders
            string latestSubfolder = subfolders.OrderByDescending(f => f).FirstOrDefault(); // order by name (day)

            if (latestSubfolder != null)
            {
                string lastDay = Path.GetFileName(latestSubfolder); // get last subfolder name
                DateTime lastDayDate;
                if (DateTime.TryParse(lastDay, out lastDayDate))
                {
                    string formattedDate = lastDayDate.ToString("dd/MMM/yyyy", new CultureInfo("es-ES")); // date in spanish
                    lblEntry.Text = "Resumen de Entrada (" + formattedDate + ")"; // set date
                }
            }
        }

        private decimal GetTotalIncome()
        {
            decimal totalIncome = 0;

            string folderPath = Path.Combine(Application.StartupPath, "Ventas"); // folder path
            string[] subfolders = Directory.GetDirectories(folderPath); // get subfolders

            foreach (string subfolder in subfolders)
            {
                string[] salesFiles = Directory.GetFiles(subfolder, "Ventas_*.xlsx"); // get excel file

                foreach (string file in salesFiles)
                {
                    using (var package = new ExcelPackage(new FileInfo(file)))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets["Sales in Revenue"];
                        if (worksheet != null)
                        {
                            int rowCount = worksheet.Dimension.Rows;
                            for (int row = 2; row <= rowCount; row++)
                            {
                                decimal revenue = 0;
                                if (decimal.TryParse(worksheet.Cells[row, 2].Value?.ToString(), out revenue))
                                {
                                    totalIncome += revenue;
                                }
                            }
                        }
                    }
                }
            }

            return totalIncome;
        }

        private int GetTotalProductsSold()
        {
            int totalProductsSold = 0;

            string folderPath = Path.Combine(Application.StartupPath, "Ventas");
            string[] subfolders = Directory.GetDirectories(folderPath);

            foreach (string subfolder in subfolders)
            {
                string[] salesFiles = Directory.GetFiles(subfolder, "Ventas_*.xlsx");

                foreach (string file in salesFiles)
                {
                    using (var package = new ExcelPackage(new FileInfo(file)))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets["Sales in Units"];
                        if (worksheet != null)
                        {
                            int rowCount = worksheet.Dimension.Rows;
                            for (int row = 2; row <= rowCount; row++)
                            {
                                int quantity = 0;
                                if (int.TryParse(worksheet.Cells[row, 2].Value?.ToString(), out quantity))
                                {
                                    totalProductsSold += quantity;
                                }
                            }
                        }
                    }
                }
            }

            return totalProductsSold;
        }

        private int GetTotalPeople()
        {
            int totalPeople = 0;

            string folderPath = Path.Combine(Application.StartupPath, "Entradas");
            string[] subfolders = Directory.GetDirectories(folderPath);

            foreach (string subfolder in subfolders)
            {
                string[] entranceFiles = Directory.GetFiles(subfolder, "Entradas_*.xlsx");

                foreach (string file in entranceFiles)
                {
                    using (var package = new ExcelPackage(new FileInfo(file)))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets["Data de entrada"];
                        if (worksheet != null)
                        {
                            int rowCount = worksheet.Dimension.Rows;
                            totalPeople += rowCount - 1; // remove header row
                        }
                    }
                }
            }

            return totalPeople;
        }

        private void UpdateHomePage()
        {
            decimal totalIncome = GetTotalIncome();
            lblGanancias.Text = totalIncome.ToString("C"); // display as currency
            lblProds.Text = GetTotalProductsSold().ToString();
            lblTotalPeople.Text = GetTotalPeople().ToString();
        }

        private void UpdateSalesChart()
        {
            string folderPath = Path.Combine(Application.StartupPath, "Ventas");
            string[] subfolders = Directory.GetDirectories(folderPath);

            // sort by newest date
            string latestSubfolder = subfolders.OrderByDescending(f => f).FirstOrDefault();

            if (latestSubfolder != null)
            {
                string latestFile = Directory.GetFiles(latestSubfolder, "Ventas_*.xlsx").FirstOrDefault();
                if (latestFile != null)
                {
                    using (var package = new ExcelPackage(new FileInfo(latestFile)))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[1]; // first sheet

                        if (worksheet != null)
                        {
                            int rowCount = worksheet.Dimension.Rows;
                            int columnCount = worksheet.Dimension.Columns;

                            var products = new List<string>();
                            var quantities = new List<int>();

                            for (int row = 2; row <= rowCount; row++)
                            {
                                string product = worksheet.Cells[row, 1].Value?.ToString();
                                int quantity = 0;
                                int.TryParse(worksheet.Cells[row, 2].Value?.ToString(), out quantity);

                                if (!string.IsNullOrEmpty(product) && quantity > 0)
                                {
                                    products.Add(product);
                                    quantities.Add(quantity);
                                }
                            }

                            cartesianChartSales.Series.Clear();

                            var columnSeries = new ColumnSeries
                            {
                                Title = "Productos",
                                Values = new ChartValues<ObservableValue>(),
                                Fill = System.Windows.Media.Brushes.DodgerBlue, // col color
                                Stroke = System.Windows.Media.Brushes.Black, // col outline color
                                StrokeThickness = 1 // col outline thickness
                            };

                            for (int i = 0; i < products.Count; i++)
                            {
                                columnSeries.Values.Add(new ObservableValue(quantities[i]));
                            }

                            cartesianChartSales.Series.Add(columnSeries);
                            cartesianChartSales.AxisX.Clear();
                            cartesianChartSales.AxisX.Add(new Axis
                            {
                                Title = "Productos",
                                Labels = products,
                                Foreground = System.Windows.Media.Brushes.Black // lbl colors
                            });

                            cartesianChartSales.AxisY.Clear();
                            cartesianChartSales.AxisY.Add(new Axis
                            {
                                Title = "Cantidad",
                                Foreground = System.Windows.Media.Brushes.Black, // lbl colors
                                Separator = new LiveCharts.Wpf.Separator
                                {
                                    Stroke = System.Windows.Media.Brushes.LightGray, // separator color
                                    StrokeThickness = 1 // separator thickness
                                }
                            });
                            cartesianChartSales.LegendLocation = LegendLocation.Right; // Change the legend location
                        }
                    }
                }
            }
        }

        private void UpdateEntryChart()
        {
            string folderPath = Path.Combine(Application.StartupPath, "Entradas");
            string[] subfolders = Directory.GetDirectories(folderPath);

            // sort by newest date
            string latestSubfolder = subfolders.OrderByDescending(f => f).FirstOrDefault();

            if (latestSubfolder != null)
            {
                string latestFile = Directory.GetFiles(latestSubfolder, "Entradas_*.xlsx").FirstOrDefault();
                if (latestFile != null)
                {
                    using (var package = new ExcelPackage(new FileInfo(latestFile)))
                    {
                        ExcelWorksheet entranceWorksheet = package.Workbook.Worksheets["Data de entrada"]; // first sheet

                        if (entranceWorksheet != null)
                        {
                            int rowCount = entranceWorksheet.Dimension.End.Row;

                            var values = new List<string>();

                            for (int row = 2; row <= rowCount; row++)
                            {
                                string value = entranceWorksheet.Cells[row, 1].Value?.ToString()?.Trim();
                                if (!string.IsNullOrEmpty(value))
                                {
                                    values.Add(value);
                                }
                            }

                            int visitorCount = 0;
                            int memberCount = 0;

                            foreach (string value in values)
                            {
                                if (value.StartsWith("VISITANTE"))
                                {
                                    visitorCount++;
                                }
                                else
                                {
                                    memberCount++;
                                }
                            }

                            cartesianChartEntry.Series.Clear();

                            var columnSeries = new ColumnSeries
                            {
                                Title = "Entrada",
                                Values = new ChartValues<ObservableValue>
                        {
                            new ObservableValue(visitorCount),
                            new ObservableValue(memberCount)
                        },
                                Fill = System.Windows.Media.Brushes.DarkOrange, // col color
                                Stroke = System.Windows.Media.Brushes.Black, // col outline color
                                StrokeThickness = 1 // col outline thickness
                            };

                            cartesianChartEntry.Series.Add(columnSeries);
                            cartesianChartEntry.AxisX.Clear();
                            cartesianChartEntry.AxisX.Add(new Axis
                            {
                                Title = "Categoría",
                                Labels = new[] { "Visitantes", "Miembros" },
                                Foreground = System.Windows.Media.Brushes.Black // lbl colors
                            });

                            cartesianChartEntry.AxisY.Clear();
                            cartesianChartEntry.AxisY.Add(new Axis
                            {
                                Title = "Cant.",
                                Foreground = System.Windows.Media.Brushes.Black, // lbl colors
                                Separator = new LiveCharts.Wpf.Separator
                                {
                                    Stroke = System.Windows.Media.Brushes.LightGray, // separator color
                                    StrokeThickness = 1 // separator thickness
                                }
                            });

                            cartesianChartEntry.LegendLocation = LegendLocation.Right; // Change the legend location

                        }
                    }
                }
            }
        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            string folderPath = Application.StartupPath;             
            Process.Start("explorer.exe", folderPath);
        }
    }
}
