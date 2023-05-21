namespace NaturalFitnessApp
{
    partial class SalesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpSaleDay = new System.Windows.Forms.DateTimePicker();
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.nudProdQty = new System.Windows.Forms.NumericUpDown();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.btnGenSales = new System.Windows.Forms.Button();
            this.cbxProduct = new System.Windows.Forms.ComboBox();
            this.gbxStats = new System.Windows.Forms.GroupBox();
            this.txtMostSold = new System.Windows.Forms.TextBox();
            this.txtUnitsSold = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblMostSold = new System.Windows.Forms.Label();
            this.lblUnitsSold = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panelBottomBar = new System.Windows.Forms.Panel();
            this.panelLogoSales = new System.Windows.Forms.Panel();
            this.lblManageSales = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.tlpDailySales = new System.Windows.Forms.TableLayoutPanel();
            this.tlpAddSale = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSalesControl = new System.Windows.Forms.TableLayoutPanel();
            this.gbxAddSale = new System.Windows.Forms.GroupBox();
            this.tlpStats = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.tlpGraphs = new System.Windows.Forms.TableLayoutPanel();
            this.tlpGraph1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpGraph2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.nudProdQty)).BeginInit();
            this.gbxStats.SuspendLayout();
            this.panelBottomBar.SuspendLayout();
            this.tlpDailySales.SuspendLayout();
            this.tlpAddSale.SuspendLayout();
            this.tlpSalesControl.SuspendLayout();
            this.gbxAddSale.SuspendLayout();
            this.tlpStats.SuspendLayout();
            this.tlpGraphs.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpSaleDay
            // 
            this.dtpSaleDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpSaleDay.CalendarFont = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSaleDay.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSaleDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSaleDay.Location = new System.Drawing.Point(3, 29);
            this.dtpSaleDay.Name = "dtpSaleDay";
            this.dtpSaleDay.Size = new System.Drawing.Size(401, 32);
            this.dtpSaleDay.TabIndex = 0;
            // 
            // lstOrder
            // 
            this.lstOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstOrder.FormattingEnabled = true;
            this.lstOrder.ItemHeight = 16;
            this.lstOrder.Location = new System.Drawing.Point(3, 93);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(401, 564);
            this.lstOrder.TabIndex = 2;
            // 
            // lblOrder
            // 
            this.lblOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(3, 64);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(401, 26);
            this.lblOrder.TabIndex = 2;
            this.lblOrder.Text = "Productos vendidos:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha:";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Yu Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(3, 132);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(382, 45);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Añadir a la lista de Ventas";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModify.Enabled = false;
            this.btnModify.Font = new System.Drawing.Font("Yu Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(3, 183);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(382, 46);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "Modificar una venta";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Yu Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(3, 235);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(382, 46);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Eliminar una venta";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // nudProdQty
            // 
            this.nudProdQty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudProdQty.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudProdQty.Location = new System.Drawing.Point(3, 91);
            this.nudProdQty.Name = "nudProdQty";
            this.nudProdQty.Size = new System.Drawing.Size(382, 35);
            this.nudProdQty.TabIndex = 6;
            // 
            // lblProduct
            // 
            this.lblProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(3, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(101, 26);
            this.lblProduct.TabIndex = 5;
            this.lblProduct.Text = "Producto:";
            // 
            // lblQty
            // 
            this.lblQty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(3, 62);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(382, 26);
            this.lblQty.TabIndex = 5;
            this.lblQty.Text = "Cantidad:";
            // 
            // btnGenSales
            // 
            this.btnGenSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenSales.Enabled = false;
            this.btnGenSales.Font = new System.Drawing.Font("Yu Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenSales.Location = new System.Drawing.Point(3, 287);
            this.btnGenSales.Name = "btnGenSales";
            this.btnGenSales.Size = new System.Drawing.Size(382, 63);
            this.btnGenSales.TabIndex = 2;
            this.btnGenSales.Text = "Generar Añalisis de ventas";
            this.btnGenSales.UseVisualStyleBackColor = true;
            this.btnGenSales.Click += new System.EventHandler(this.btnGenSales_Click);
            // 
            // cbxProduct
            // 
            this.cbxProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxProduct.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProduct.FormattingEnabled = true;
            this.cbxProduct.Location = new System.Drawing.Point(3, 29);
            this.cbxProduct.Name = "cbxProduct";
            this.cbxProduct.Size = new System.Drawing.Size(382, 30);
            this.cbxProduct.TabIndex = 4;
            // 
            // gbxStats
            // 
            this.gbxStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxStats.Controls.Add(this.tlpStats);
            this.gbxStats.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxStats.Location = new System.Drawing.Point(3, 394);
            this.gbxStats.Name = "gbxStats";
            this.gbxStats.Size = new System.Drawing.Size(396, 190);
            this.gbxStats.TabIndex = 7;
            this.gbxStats.TabStop = false;
            this.gbxStats.Text = "Estadísticas";
            // 
            // txtMostSold
            // 
            this.txtMostSold.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMostSold.Location = new System.Drawing.Point(195, 105);
            this.txtMostSold.Name = "txtMostSold";
            this.txtMostSold.ReadOnly = true;
            this.txtMostSold.Size = new System.Drawing.Size(187, 35);
            this.txtMostSold.TabIndex = 6;
            // 
            // txtUnitsSold
            // 
            this.txtUnitsSold.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnitsSold.Location = new System.Drawing.Point(195, 54);
            this.txtUnitsSold.Name = "txtUnitsSold";
            this.txtUnitsSold.ReadOnly = true;
            this.txtUnitsSold.Size = new System.Drawing.Size(187, 35);
            this.txtUnitsSold.TabIndex = 6;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Location = new System.Drawing.Point(195, 3);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(187, 35);
            this.txtTotal.TabIndex = 6;
            // 
            // lblMostSold
            // 
            this.lblMostSold.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMostSold.AutoSize = true;
            this.lblMostSold.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostSold.Location = new System.Drawing.Point(3, 102);
            this.lblMostSold.Name = "lblMostSold";
            this.lblMostSold.Size = new System.Drawing.Size(186, 53);
            this.lblMostSold.TabIndex = 5;
            this.lblMostSold.Text = "P. más vendido:";
            // 
            // lblUnitsSold
            // 
            this.lblUnitsSold.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnitsSold.AutoSize = true;
            this.lblUnitsSold.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitsSold.Location = new System.Drawing.Point(3, 51);
            this.lblUnitsSold.Name = "lblUnitsSold";
            this.lblUnitsSold.Size = new System.Drawing.Size(186, 51);
            this.lblUnitsSold.TabIndex = 5;
            this.lblUnitsSold.Text = "Uds. Vendidas:";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(3, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(186, 51);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total Vendido:";
            // 
            // panelBottomBar
            // 
            this.panelBottomBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(96)))));
            this.panelBottomBar.Controls.Add(this.panelLogoSales);
            this.panelBottomBar.Controls.Add(this.lblManageSales);
            this.panelBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBottomBar.Location = new System.Drawing.Point(0, 666);
            this.panelBottomBar.Name = "panelBottomBar";
            this.panelBottomBar.Size = new System.Drawing.Size(1348, 58);
            this.panelBottomBar.TabIndex = 6;
            // 
            // panelLogoSales
            // 
            this.panelLogoSales.BackgroundImage = global::NaturalFitnessApp.Properties.Resources.finance_white;
            this.panelLogoSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogoSales.Location = new System.Drawing.Point(459, 9);
            this.panelLogoSales.Name = "panelLogoSales";
            this.panelLogoSales.Size = new System.Drawing.Size(55, 46);
            this.panelLogoSales.TabIndex = 2;
            // 
            // lblManageSales
            // 
            this.lblManageSales.AutoSize = true;
            this.lblManageSales.BackColor = System.Drawing.Color.Transparent;
            this.lblManageSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageSales.ForeColor = System.Drawing.Color.White;
            this.lblManageSales.Location = new System.Drawing.Point(12, 17);
            this.lblManageSales.Name = "lblManageSales";
            this.lblManageSales.Size = new System.Drawing.Size(427, 32);
            this.lblManageSales.TabIndex = 1;
            this.lblManageSales.Text = "Administrar Ventas/Ganancias";
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Enabled = false;
            this.btnExport.Font = new System.Drawing.Font("Yu Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(3, 629);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(396, 34);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Exportar a Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // tlpDailySales
            // 
            this.tlpDailySales.ColumnCount = 1;
            this.tlpDailySales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDailySales.Controls.Add(this.label1, 0, 0);
            this.tlpDailySales.Controls.Add(this.lstOrder, 0, 3);
            this.tlpDailySales.Controls.Add(this.dtpSaleDay, 0, 1);
            this.tlpDailySales.Controls.Add(this.lblOrder, 0, 2);
            this.tlpDailySales.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlpDailySales.Location = new System.Drawing.Point(0, 0);
            this.tlpDailySales.Name = "tlpDailySales";
            this.tlpDailySales.RowCount = 4;
            this.tlpDailySales.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDailySales.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDailySales.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDailySales.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDailySales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDailySales.Size = new System.Drawing.Size(401, 666);
            this.tlpDailySales.TabIndex = 3;
            // 
            // tlpAddSale
            // 
            this.tlpAddSale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpAddSale.ColumnCount = 1;
            this.tlpAddSale.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddSale.Controls.Add(this.nudProdQty, 0, 3);
            this.tlpAddSale.Controls.Add(this.btnAdd, 0, 4);
            this.tlpAddSale.Controls.Add(this.btnGenSales, 0, 7);
            this.tlpAddSale.Controls.Add(this.cbxProduct, 0, 1);
            this.tlpAddSale.Controls.Add(this.btnDelete, 0, 6);
            this.tlpAddSale.Controls.Add(this.btnModify, 0, 5);
            this.tlpAddSale.Controls.Add(this.lblQty, 0, 2);
            this.tlpAddSale.Controls.Add(this.lblProduct, 0, 0);
            this.tlpAddSale.Location = new System.Drawing.Point(2, 26);
            this.tlpAddSale.Name = "tlpAddSale";
            this.tlpAddSale.RowCount = 8;
            this.tlpAddSale.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAddSale.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAddSale.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAddSale.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAddSale.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAddSale.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAddSale.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAddSale.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAddSale.Size = new System.Drawing.Size(388, 353);
            this.tlpAddSale.TabIndex = 0;
            // 
            // tlpSalesControl
            // 
            this.tlpSalesControl.ColumnCount = 1;
            this.tlpSalesControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSalesControl.Controls.Add(this.gbxAddSale, 0, 0);
            this.tlpSalesControl.Controls.Add(this.btnExport, 0, 3);
            this.tlpSalesControl.Controls.Add(this.gbxStats, 0, 1);
            this.tlpSalesControl.Controls.Add(this.btnSave, 0, 2);
            this.tlpSalesControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlpSalesControl.Location = new System.Drawing.Point(401, 0);
            this.tlpSalesControl.Name = "tlpSalesControl";
            this.tlpSalesControl.RowCount = 4;
            this.tlpSalesControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.74449F));
            this.tlpSalesControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.46822F));
            this.tlpSalesControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.893643F));
            this.tlpSalesControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.893643F));
            this.tlpSalesControl.Size = new System.Drawing.Size(402, 666);
            this.tlpSalesControl.TabIndex = 8;
            // 
            // gbxAddSale
            // 
            this.gbxAddSale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxAddSale.Controls.Add(this.tlpAddSale);
            this.gbxAddSale.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAddSale.Location = new System.Drawing.Point(3, 3);
            this.gbxAddSale.Name = "gbxAddSale";
            this.gbxAddSale.Size = new System.Drawing.Size(396, 385);
            this.gbxAddSale.TabIndex = 3;
            this.gbxAddSale.TabStop = false;
            this.gbxAddSale.Text = "Añadir Venta";
            // 
            // tlpStats
            // 
            this.tlpStats.ColumnCount = 2;
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpStats.Controls.Add(this.lblMostSold, 0, 2);
            this.tlpStats.Controls.Add(this.txtMostSold, 1, 2);
            this.tlpStats.Controls.Add(this.lblTotal, 0, 0);
            this.tlpStats.Controls.Add(this.txtTotal, 1, 0);
            this.tlpStats.Controls.Add(this.lblUnitsSold, 0, 1);
            this.tlpStats.Controls.Add(this.txtUnitsSold, 1, 1);
            this.tlpStats.Location = new System.Drawing.Point(6, 29);
            this.tlpStats.Name = "tlpStats";
            this.tlpStats.RowCount = 3;
            this.tlpStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpStats.Size = new System.Drawing.Size(385, 155);
            this.tlpStats.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Yu Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(3, 590);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(396, 33);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Guardar Récord";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // tlpGraphs
            // 
            this.tlpGraphs.ColumnCount = 1;
            this.tlpGraphs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGraphs.Controls.Add(this.tlpGraph1, 0, 0);
            this.tlpGraphs.Controls.Add(this.tlpGraph2, 0, 1);
            this.tlpGraphs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGraphs.Location = new System.Drawing.Point(803, 0);
            this.tlpGraphs.Name = "tlpGraphs";
            this.tlpGraphs.RowCount = 2;
            this.tlpGraphs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGraphs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGraphs.Size = new System.Drawing.Size(545, 666);
            this.tlpGraphs.TabIndex = 9;
            // 
            // tlpGraph1
            // 
            this.tlpGraph1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpGraph1.ColumnCount = 1;
            this.tlpGraph1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGraph1.Location = new System.Drawing.Point(3, 3);
            this.tlpGraph1.Name = "tlpGraph1";
            this.tlpGraph1.RowCount = 1;
            this.tlpGraph1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGraph1.Size = new System.Drawing.Size(539, 327);
            this.tlpGraph1.TabIndex = 0;
            // 
            // tlpGraph2
            // 
            this.tlpGraph2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpGraph2.ColumnCount = 1;
            this.tlpGraph2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGraph2.Location = new System.Drawing.Point(3, 336);
            this.tlpGraph2.Name = "tlpGraph2";
            this.tlpGraph2.RowCount = 1;
            this.tlpGraph2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGraph2.Size = new System.Drawing.Size(539, 327);
            this.tlpGraph2.TabIndex = 0;
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 724);
            this.Controls.Add(this.tlpGraphs);
            this.Controls.Add(this.tlpSalesControl);
            this.Controls.Add(this.tlpDailySales);
            this.Controls.Add(this.panelBottomBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesForm";
            this.Text = "SalesForm";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudProdQty)).EndInit();
            this.gbxStats.ResumeLayout(false);
            this.panelBottomBar.ResumeLayout(false);
            this.panelBottomBar.PerformLayout();
            this.tlpDailySales.ResumeLayout(false);
            this.tlpDailySales.PerformLayout();
            this.tlpAddSale.ResumeLayout(false);
            this.tlpAddSale.PerformLayout();
            this.tlpSalesControl.ResumeLayout(false);
            this.gbxAddSale.ResumeLayout(false);
            this.tlpStats.ResumeLayout(false);
            this.tlpStats.PerformLayout();
            this.tlpGraphs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpSaleDay;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstOrder;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox cbxProduct;
        private System.Windows.Forms.NumericUpDown nudProdQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Panel panelBottomBar;
        private System.Windows.Forms.Panel panelLogoSales;
        private System.Windows.Forms.Label lblManageSales;
        private System.Windows.Forms.GroupBox gbxStats;
        private System.Windows.Forms.TextBox txtUnitsSold;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblUnitsSold;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnGenSales;
        private System.Windows.Forms.TextBox txtMostSold;
        private System.Windows.Forms.Label lblMostSold;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TableLayoutPanel tlpDailySales;
        private System.Windows.Forms.TableLayoutPanel tlpAddSale;
        private System.Windows.Forms.TableLayoutPanel tlpSalesControl;
        private System.Windows.Forms.GroupBox gbxAddSale;
        private System.Windows.Forms.TableLayoutPanel tlpStats;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tlpGraphs;
        private System.Windows.Forms.TableLayoutPanel tlpGraph1;
        private System.Windows.Forms.TableLayoutPanel tlpGraph2;
    }
}