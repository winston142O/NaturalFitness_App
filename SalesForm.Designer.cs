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
            this.tlpStats = new System.Windows.Forms.TableLayoutPanel();
            this.lblMostSold = new System.Windows.Forms.Label();
            this.txtMostSold = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblUnitsSold = new System.Windows.Forms.Label();
            this.txtUnitsSold = new System.Windows.Forms.TextBox();
            this.panelBottomBar = new System.Windows.Forms.Panel();
            this.panelLogoSales = new System.Windows.Forms.Panel();
            this.lblManageSales = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.tlpDailySales = new System.Windows.Forms.TableLayoutPanel();
            this.tlpAddSale = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSalesControl = new System.Windows.Forms.TableLayoutPanel();
            this.gbxAddSale = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tlpGraphs = new System.Windows.Forms.TableLayoutPanel();
            this.tlpGraph2 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpGraph1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCafeteria = new System.Windows.Forms.TabPage();
            this.tbEntrance = new System.Windows.Forms.TabPage();
            this.tlpGraphs2 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPplGraph2 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPplGraph1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpEntraceControls = new System.Windows.Forms.TableLayoutPanel();
            this.gbxEntrance = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.btnGenGraph2 = new System.Windows.Forms.Button();
            this.cbxMembers = new System.Windows.Forms.ComboBox();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.btnAddNotMember = new System.Windows.Forms.Button();
            this.chkIsMember = new System.Windows.Forms.CheckBox();
            this.lblMemberType = new System.Windows.Forms.Label();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.gbxStats2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblEarnings2 = new System.Windows.Forms.Label();
            this.txtEarnings2 = new System.Windows.Forms.TextBox();
            this.lblTotalTraffic = new System.Windows.Forms.Label();
            this.txtTotalTraffic = new System.Windows.Forms.TextBox();
            this.lblMemberPercent = new System.Windows.Forms.Label();
            this.txtMemberPercent = new System.Windows.Forms.TextBox();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.tlpEntrance = new System.Windows.Forms.TableLayoutPanel();
            this.lblDateEntrance = new System.Windows.Forms.Label();
            this.lstEntrance = new System.Windows.Forms.ListBox();
            this.dtpEntranceDay = new System.Windows.Forms.DateTimePicker();
            this.lblPeopleList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudProdQty)).BeginInit();
            this.gbxStats.SuspendLayout();
            this.tlpStats.SuspendLayout();
            this.panelBottomBar.SuspendLayout();
            this.tlpDailySales.SuspendLayout();
            this.tlpAddSale.SuspendLayout();
            this.tlpSalesControl.SuspendLayout();
            this.gbxAddSale.SuspendLayout();
            this.tlpGraphs.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpCafeteria.SuspendLayout();
            this.tbEntrance.SuspendLayout();
            this.tlpGraphs2.SuspendLayout();
            this.tlpEntraceControls.SuspendLayout();
            this.gbxEntrance.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbxStats2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tlpEntrance.SuspendLayout();
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
            this.gbxStats.Location = new System.Drawing.Point(3, 377);
            this.gbxStats.Name = "gbxStats";
            this.gbxStats.Size = new System.Drawing.Size(396, 181);
            this.gbxStats.TabIndex = 7;
            this.gbxStats.TabStop = false;
            this.gbxStats.Text = "Estadísticas";
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
            // panelBottomBar
            // 
            this.panelBottomBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(96)))));
            this.panelBottomBar.Controls.Add(this.panelLogoSales);
            this.panelBottomBar.Controls.Add(this.lblManageSales);
            this.panelBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBottomBar.Location = new System.Drawing.Point(0, 672);
            this.panelBottomBar.Name = "panelBottomBar";
            this.panelBottomBar.Size = new System.Drawing.Size(1348, 52);
            this.panelBottomBar.TabIndex = 6;
            // 
            // panelLogoSales
            // 
            this.panelLogoSales.BackgroundImage = global::NaturalFitnessApp.Properties.Resources.finance_white;
            this.panelLogoSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogoSales.Location = new System.Drawing.Point(459, 4);
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
            this.lblManageSales.Location = new System.Drawing.Point(12, 11);
            this.lblManageSales.Name = "lblManageSales";
            this.lblManageSales.Size = new System.Drawing.Size(427, 32);
            this.lblManageSales.TabIndex = 1;
            this.lblManageSales.Text = "Administrar Ventas/Ganancias";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Enabled = false;
            this.btnClear.Font = new System.Drawing.Font("Yu Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(3, 601);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(396, 33);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.tlpDailySales.Location = new System.Drawing.Point(3, 3);
            this.tlpDailySales.Name = "tlpDailySales";
            this.tlpDailySales.RowCount = 4;
            this.tlpDailySales.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDailySales.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDailySales.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDailySales.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDailySales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDailySales.Size = new System.Drawing.Size(401, 637);
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
            this.tlpAddSale.Size = new System.Drawing.Size(388, 336);
            this.tlpAddSale.TabIndex = 0;
            // 
            // tlpSalesControl
            // 
            this.tlpSalesControl.ColumnCount = 1;
            this.tlpSalesControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSalesControl.Controls.Add(this.gbxAddSale, 0, 0);
            this.tlpSalesControl.Controls.Add(this.btnClear, 0, 3);
            this.tlpSalesControl.Controls.Add(this.gbxStats, 0, 1);
            this.tlpSalesControl.Controls.Add(this.btnSave, 0, 2);
            this.tlpSalesControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlpSalesControl.Location = new System.Drawing.Point(404, 3);
            this.tlpSalesControl.Name = "tlpSalesControl";
            this.tlpSalesControl.RowCount = 4;
            this.tlpSalesControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.74449F));
            this.tlpSalesControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.46822F));
            this.tlpSalesControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.893643F));
            this.tlpSalesControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.893643F));
            this.tlpSalesControl.Size = new System.Drawing.Size(402, 637);
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
            this.gbxAddSale.Size = new System.Drawing.Size(396, 368);
            this.gbxAddSale.TabIndex = 3;
            this.gbxAddSale.TabStop = false;
            this.gbxAddSale.Text = "Añadir Venta";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Yu Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(3, 564);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(396, 31);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Guardar Récord";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tlpGraphs
            // 
            this.tlpGraphs.ColumnCount = 1;
            this.tlpGraphs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGraphs.Controls.Add(this.tlpGraph2, 0, 1);
            this.tlpGraphs.Controls.Add(this.tlpGraph1, 0, 0);
            this.tlpGraphs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGraphs.Location = new System.Drawing.Point(806, 3);
            this.tlpGraphs.Name = "tlpGraphs";
            this.tlpGraphs.RowCount = 2;
            this.tlpGraphs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGraphs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGraphs.Size = new System.Drawing.Size(531, 637);
            this.tlpGraphs.TabIndex = 9;
            // 
            // tlpGraph2
            // 
            this.tlpGraph2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpGraph2.ColumnCount = 1;
            this.tlpGraph2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGraph2.Location = new System.Drawing.Point(3, 321);
            this.tlpGraph2.Name = "tlpGraph2";
            this.tlpGraph2.RowCount = 1;
            this.tlpGraph2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGraph2.Size = new System.Drawing.Size(525, 313);
            this.tlpGraph2.TabIndex = 0;
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
            this.tlpGraph1.Size = new System.Drawing.Size(525, 312);
            this.tlpGraph1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpCafeteria);
            this.tabControl1.Controls.Add(this.tbEntrance);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1348, 672);
            this.tabControl1.TabIndex = 10;
            // 
            // tpCafeteria
            // 
            this.tpCafeteria.Controls.Add(this.tlpGraphs);
            this.tpCafeteria.Controls.Add(this.tlpSalesControl);
            this.tpCafeteria.Controls.Add(this.tlpDailySales);
            this.tpCafeteria.Location = new System.Drawing.Point(4, 25);
            this.tpCafeteria.Name = "tpCafeteria";
            this.tpCafeteria.Padding = new System.Windows.Forms.Padding(3);
            this.tpCafeteria.Size = new System.Drawing.Size(1340, 643);
            this.tpCafeteria.TabIndex = 0;
            this.tpCafeteria.Text = "Cafetería";
            this.tpCafeteria.UseVisualStyleBackColor = true;
            // 
            // tbEntrance
            // 
            this.tbEntrance.Controls.Add(this.tlpGraphs2);
            this.tbEntrance.Controls.Add(this.tlpEntraceControls);
            this.tbEntrance.Controls.Add(this.tlpEntrance);
            this.tbEntrance.Location = new System.Drawing.Point(4, 25);
            this.tbEntrance.Name = "tbEntrance";
            this.tbEntrance.Padding = new System.Windows.Forms.Padding(3);
            this.tbEntrance.Size = new System.Drawing.Size(1340, 643);
            this.tbEntrance.TabIndex = 1;
            this.tbEntrance.Text = "Entrada de personas";
            this.tbEntrance.UseVisualStyleBackColor = true;
            // 
            // tlpGraphs2
            // 
            this.tlpGraphs2.ColumnCount = 1;
            this.tlpGraphs2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGraphs2.Controls.Add(this.tlpPplGraph2, 0, 1);
            this.tlpGraphs2.Controls.Add(this.tlpPplGraph1, 0, 0);
            this.tlpGraphs2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGraphs2.Location = new System.Drawing.Point(815, 3);
            this.tlpGraphs2.Name = "tlpGraphs2";
            this.tlpGraphs2.RowCount = 2;
            this.tlpGraphs2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGraphs2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGraphs2.Size = new System.Drawing.Size(522, 637);
            this.tlpGraphs2.TabIndex = 10;
            // 
            // tlpPplGraph2
            // 
            this.tlpPplGraph2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPplGraph2.ColumnCount = 1;
            this.tlpPplGraph2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPplGraph2.Location = new System.Drawing.Point(3, 321);
            this.tlpPplGraph2.Name = "tlpPplGraph2";
            this.tlpPplGraph2.RowCount = 1;
            this.tlpPplGraph2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPplGraph2.Size = new System.Drawing.Size(516, 313);
            this.tlpPplGraph2.TabIndex = 0;
            // 
            // tlpPplGraph1
            // 
            this.tlpPplGraph1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPplGraph1.ColumnCount = 1;
            this.tlpPplGraph1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPplGraph1.Location = new System.Drawing.Point(3, 3);
            this.tlpPplGraph1.Name = "tlpPplGraph1";
            this.tlpPplGraph1.RowCount = 1;
            this.tlpPplGraph1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPplGraph1.Size = new System.Drawing.Size(516, 312);
            this.tlpPplGraph1.TabIndex = 0;
            // 
            // tlpEntraceControls
            // 
            this.tlpEntraceControls.ColumnCount = 1;
            this.tlpEntraceControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEntraceControls.Controls.Add(this.gbxEntrance, 0, 0);
            this.tlpEntraceControls.Controls.Add(this.btnClear2, 0, 3);
            this.tlpEntraceControls.Controls.Add(this.gbxStats2, 0, 1);
            this.tlpEntraceControls.Controls.Add(this.btnSave2, 0, 2);
            this.tlpEntraceControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlpEntraceControls.Location = new System.Drawing.Point(413, 3);
            this.tlpEntraceControls.Name = "tlpEntraceControls";
            this.tlpEntraceControls.RowCount = 4;
            this.tlpEntraceControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.74449F));
            this.tlpEntraceControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.46822F));
            this.tlpEntraceControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.893643F));
            this.tlpEntraceControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.893643F));
            this.tlpEntraceControls.Size = new System.Drawing.Size(402, 637);
            this.tlpEntraceControls.TabIndex = 9;
            // 
            // gbxEntrance
            // 
            this.gbxEntrance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxEntrance.Controls.Add(this.tableLayoutPanel2);
            this.gbxEntrance.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEntrance.Location = new System.Drawing.Point(3, 3);
            this.gbxEntrance.Name = "gbxEntrance";
            this.gbxEntrance.Size = new System.Drawing.Size(396, 368);
            this.gbxEntrance.TabIndex = 3;
            this.gbxEntrance.TabStop = false;
            this.gbxEntrance.Text = "Administrar Entrada";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnAdd2, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnGenGraph2, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.cbxMembers, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnDelete2, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.btnAddNotMember, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.chkIsMember, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblMemberType, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 26);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(388, 336);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnAdd2
            // 
            this.btnAdd2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd2.Enabled = false;
            this.btnAdd2.Font = new System.Drawing.Font("Yu Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd2.Location = new System.Drawing.Point(3, 101);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(382, 45);
            this.btnAdd2.TabIndex = 3;
            this.btnAdd2.Text = "Añadir a la lista ";
            this.btnAdd2.UseVisualStyleBackColor = true;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // btnGenGraph2
            // 
            this.btnGenGraph2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenGraph2.Enabled = false;
            this.btnGenGraph2.Font = new System.Drawing.Font("Yu Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenGraph2.Location = new System.Drawing.Point(3, 256);
            this.btnGenGraph2.Name = "btnGenGraph2";
            this.btnGenGraph2.Size = new System.Drawing.Size(382, 77);
            this.btnGenGraph2.TabIndex = 2;
            this.btnGenGraph2.Text = "Generar Añalisis de ventas";
            this.btnGenGraph2.UseVisualStyleBackColor = true;
            this.btnGenGraph2.Click += new System.EventHandler(this.btnGenGraph2_Click);
            // 
            // cbxMembers
            // 
            this.cbxMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMembers.Enabled = false;
            this.cbxMembers.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMembers.FormattingEnabled = true;
            this.cbxMembers.Location = new System.Drawing.Point(3, 29);
            this.cbxMembers.Name = "cbxMembers";
            this.cbxMembers.Size = new System.Drawing.Size(382, 30);
            this.cbxMembers.TabIndex = 4;
            // 
            // btnDelete2
            // 
            this.btnDelete2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete2.Enabled = false;
            this.btnDelete2.Font = new System.Drawing.Font("Yu Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete2.Location = new System.Drawing.Point(3, 204);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(382, 46);
            this.btnDelete2.TabIndex = 2;
            this.btnDelete2.Text = "Eliminar una entrada";
            this.btnDelete2.UseVisualStyleBackColor = true;
            // 
            // btnAddNotMember
            // 
            this.btnAddNotMember.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNotMember.Font = new System.Drawing.Font("Yu Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNotMember.Location = new System.Drawing.Point(3, 152);
            this.btnAddNotMember.Name = "btnAddNotMember";
            this.btnAddNotMember.Size = new System.Drawing.Size(382, 46);
            this.btnAddNotMember.TabIndex = 3;
            this.btnAddNotMember.Text = "Añadir (No-Miembro)";
            this.btnAddNotMember.UseVisualStyleBackColor = true;
            this.btnAddNotMember.Click += new System.EventHandler(this.btnAddNotMember_Click);
            // 
            // chkIsMember
            // 
            this.chkIsMember.AutoSize = true;
            this.chkIsMember.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsMember.Location = new System.Drawing.Point(3, 65);
            this.chkIsMember.Name = "chkIsMember";
            this.chkIsMember.Size = new System.Drawing.Size(142, 30);
            this.chkIsMember.TabIndex = 0;
            this.chkIsMember.Text = "Es miembro";
            this.chkIsMember.UseVisualStyleBackColor = true;
            this.chkIsMember.CheckedChanged += new System.EventHandler(this.chkIsMember_CheckedChanged);
            // 
            // lblMemberType
            // 
            this.lblMemberType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMemberType.AutoSize = true;
            this.lblMemberType.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberType.Location = new System.Drawing.Point(3, 0);
            this.lblMemberType.Name = "lblMemberType";
            this.lblMemberType.Size = new System.Drawing.Size(99, 26);
            this.lblMemberType.TabIndex = 5;
            this.lblMemberType.Text = "Miembro:";
            // 
            // btnClear2
            // 
            this.btnClear2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear2.Enabled = false;
            this.btnClear2.Font = new System.Drawing.Font("Yu Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear2.Location = new System.Drawing.Point(3, 601);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(396, 33);
            this.btnClear2.TabIndex = 4;
            this.btnClear2.Text = "Limpiar";
            this.btnClear2.UseVisualStyleBackColor = true;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // gbxStats2
            // 
            this.gbxStats2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxStats2.Controls.Add(this.tableLayoutPanel3);
            this.gbxStats2.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxStats2.Location = new System.Drawing.Point(3, 377);
            this.gbxStats2.Name = "gbxStats2";
            this.gbxStats2.Size = new System.Drawing.Size(396, 181);
            this.gbxStats2.TabIndex = 7;
            this.gbxStats2.TabStop = false;
            this.gbxStats2.Text = "Estadísticas";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lblEarnings2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtEarnings2, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblTotalTraffic, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtTotalTraffic, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblMemberPercent, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtMemberPercent, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 29);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(385, 155);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // lblEarnings2
            // 
            this.lblEarnings2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEarnings2.AutoSize = true;
            this.lblEarnings2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEarnings2.Location = new System.Drawing.Point(3, 102);
            this.lblEarnings2.Name = "lblEarnings2";
            this.lblEarnings2.Size = new System.Drawing.Size(186, 53);
            this.lblEarnings2.TabIndex = 5;
            this.lblEarnings2.Text = "Ganancias";
            // 
            // txtEarnings2
            // 
            this.txtEarnings2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEarnings2.Location = new System.Drawing.Point(195, 105);
            this.txtEarnings2.Name = "txtEarnings2";
            this.txtEarnings2.ReadOnly = true;
            this.txtEarnings2.Size = new System.Drawing.Size(187, 35);
            this.txtEarnings2.TabIndex = 6;
            // 
            // lblTotalTraffic
            // 
            this.lblTotalTraffic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalTraffic.AutoSize = true;
            this.lblTotalTraffic.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTraffic.Location = new System.Drawing.Point(3, 0);
            this.lblTotalTraffic.Name = "lblTotalTraffic";
            this.lblTotalTraffic.Size = new System.Drawing.Size(186, 51);
            this.lblTotalTraffic.TabIndex = 5;
            this.lblTotalTraffic.Text = "Tráfico Total";
            // 
            // txtTotalTraffic
            // 
            this.txtTotalTraffic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalTraffic.Location = new System.Drawing.Point(195, 3);
            this.txtTotalTraffic.Name = "txtTotalTraffic";
            this.txtTotalTraffic.ReadOnly = true;
            this.txtTotalTraffic.Size = new System.Drawing.Size(187, 35);
            this.txtTotalTraffic.TabIndex = 6;
            // 
            // lblMemberPercent
            // 
            this.lblMemberPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMemberPercent.AutoSize = true;
            this.lblMemberPercent.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberPercent.Location = new System.Drawing.Point(3, 51);
            this.lblMemberPercent.Name = "lblMemberPercent";
            this.lblMemberPercent.Size = new System.Drawing.Size(186, 51);
            this.lblMemberPercent.TabIndex = 5;
            this.lblMemberPercent.Text = "% Miembros";
            // 
            // txtMemberPercent
            // 
            this.txtMemberPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMemberPercent.Location = new System.Drawing.Point(195, 54);
            this.txtMemberPercent.Name = "txtMemberPercent";
            this.txtMemberPercent.ReadOnly = true;
            this.txtMemberPercent.Size = new System.Drawing.Size(187, 35);
            this.txtMemberPercent.TabIndex = 6;
            // 
            // btnSave2
            // 
            this.btnSave2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave2.Enabled = false;
            this.btnSave2.Font = new System.Drawing.Font("Yu Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave2.Location = new System.Drawing.Point(3, 564);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(396, 31);
            this.btnSave2.TabIndex = 2;
            this.btnSave2.Text = "Guardar Récord";
            this.btnSave2.UseVisualStyleBackColor = true;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // tlpEntrance
            // 
            this.tlpEntrance.ColumnCount = 1;
            this.tlpEntrance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpEntrance.Controls.Add(this.lblDateEntrance, 0, 0);
            this.tlpEntrance.Controls.Add(this.lstEntrance, 0, 3);
            this.tlpEntrance.Controls.Add(this.dtpEntranceDay, 0, 1);
            this.tlpEntrance.Controls.Add(this.lblPeopleList, 0, 2);
            this.tlpEntrance.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlpEntrance.Location = new System.Drawing.Point(3, 3);
            this.tlpEntrance.Name = "tlpEntrance";
            this.tlpEntrance.RowCount = 4;
            this.tlpEntrance.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEntrance.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEntrance.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEntrance.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEntrance.Size = new System.Drawing.Size(410, 637);
            this.tlpEntrance.TabIndex = 0;
            // 
            // lblDateEntrance
            // 
            this.lblDateEntrance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateEntrance.AutoSize = true;
            this.lblDateEntrance.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateEntrance.Location = new System.Drawing.Point(3, 0);
            this.lblDateEntrance.Name = "lblDateEntrance";
            this.lblDateEntrance.Size = new System.Drawing.Size(404, 26);
            this.lblDateEntrance.TabIndex = 4;
            this.lblDateEntrance.Text = "Fecha:";
            // 
            // lstEntrance
            // 
            this.lstEntrance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstEntrance.FormattingEnabled = true;
            this.lstEntrance.ItemHeight = 16;
            this.lstEntrance.Location = new System.Drawing.Point(3, 93);
            this.lstEntrance.Name = "lstEntrance";
            this.lstEntrance.Size = new System.Drawing.Size(404, 532);
            this.lstEntrance.TabIndex = 5;
            // 
            // dtpEntranceDay
            // 
            this.dtpEntranceDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEntranceDay.CalendarFont = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEntranceDay.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEntranceDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntranceDay.Location = new System.Drawing.Point(3, 29);
            this.dtpEntranceDay.Name = "dtpEntranceDay";
            this.dtpEntranceDay.Size = new System.Drawing.Size(404, 32);
            this.dtpEntranceDay.TabIndex = 3;
            // 
            // lblPeopleList
            // 
            this.lblPeopleList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPeopleList.AutoSize = true;
            this.lblPeopleList.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeopleList.Location = new System.Drawing.Point(3, 64);
            this.lblPeopleList.Name = "lblPeopleList";
            this.lblPeopleList.Size = new System.Drawing.Size(404, 26);
            this.lblPeopleList.TabIndex = 6;
            this.lblPeopleList.Text = "Listado de entrada:";
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 724);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelBottomBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesForm";
            this.Text = "SalesForm";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudProdQty)).EndInit();
            this.gbxStats.ResumeLayout(false);
            this.tlpStats.ResumeLayout(false);
            this.tlpStats.PerformLayout();
            this.panelBottomBar.ResumeLayout(false);
            this.panelBottomBar.PerformLayout();
            this.tlpDailySales.ResumeLayout(false);
            this.tlpDailySales.PerformLayout();
            this.tlpAddSale.ResumeLayout(false);
            this.tlpAddSale.PerformLayout();
            this.tlpSalesControl.ResumeLayout(false);
            this.gbxAddSale.ResumeLayout(false);
            this.tlpGraphs.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpCafeteria.ResumeLayout(false);
            this.tbEntrance.ResumeLayout(false);
            this.tlpGraphs2.ResumeLayout(false);
            this.tlpEntraceControls.ResumeLayout(false);
            this.gbxEntrance.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.gbxStats2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tlpEntrance.ResumeLayout(false);
            this.tlpEntrance.PerformLayout();
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
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TableLayoutPanel tlpDailySales;
        private System.Windows.Forms.TableLayoutPanel tlpAddSale;
        private System.Windows.Forms.TableLayoutPanel tlpSalesControl;
        private System.Windows.Forms.GroupBox gbxAddSale;
        private System.Windows.Forms.TableLayoutPanel tlpStats;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tlpGraphs;
        private System.Windows.Forms.TableLayoutPanel tlpGraph1;
        private System.Windows.Forms.TableLayoutPanel tlpGraph2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpCafeteria;
        private System.Windows.Forms.TabPage tbEntrance;
        private System.Windows.Forms.TableLayoutPanel tlpEntrance;
        private System.Windows.Forms.Label lblDateEntrance;
        private System.Windows.Forms.ListBox lstEntrance;
        private System.Windows.Forms.DateTimePicker dtpEntranceDay;
        private System.Windows.Forms.Label lblPeopleList;
        private System.Windows.Forms.TableLayoutPanel tlpEntraceControls;
        private System.Windows.Forms.GroupBox gbxEntrance;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.Button btnGenGraph2;
        private System.Windows.Forms.ComboBox cbxMembers;
        private System.Windows.Forms.Button btnDelete2;
        private System.Windows.Forms.Button btnAddNotMember;
        private System.Windows.Forms.Label lblMemberType;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.GroupBox gbxStats2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblEarnings2;
        private System.Windows.Forms.TextBox txtEarnings2;
        private System.Windows.Forms.Label lblTotalTraffic;
        private System.Windows.Forms.TextBox txtTotalTraffic;
        private System.Windows.Forms.Label lblMemberPercent;
        private System.Windows.Forms.TextBox txtMemberPercent;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.TableLayoutPanel tlpGraphs2;
        private System.Windows.Forms.TableLayoutPanel tlpPplGraph2;
        private System.Windows.Forms.TableLayoutPanel tlpPplGraph1;
        private System.Windows.Forms.CheckBox chkIsMember;
    }
}