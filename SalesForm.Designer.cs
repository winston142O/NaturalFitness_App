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
            this.pnlDailySales = new System.Windows.Forms.Panel();
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.gbxAddSale = new System.Windows.Forms.GroupBox();
            this.nudProdQty = new System.Windows.Forms.NumericUpDown();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.cbxProduct = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUnitsSold = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblUnitsSold = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panelBottomBar = new System.Windows.Forms.Panel();
            this.panelLogoSales = new System.Windows.Forms.Panel();
            this.lblManageSales = new System.Windows.Forms.Label();
            this.btnGenSales = new System.Windows.Forms.Button();
            this.lblMostSold = new System.Windows.Forms.Label();
            this.txtMostSold = new System.Windows.Forms.TextBox();
            this.pnlDailySales.SuspendLayout();
            this.gbxAddSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProdQty)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelBottomBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpSaleDay
            // 
            this.dtpSaleDay.CalendarFont = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSaleDay.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSaleDay.Location = new System.Drawing.Point(106, 16);
            this.dtpSaleDay.Name = "dtpSaleDay";
            this.dtpSaleDay.Size = new System.Drawing.Size(276, 32);
            this.dtpSaleDay.TabIndex = 0;
            // 
            // pnlDailySales
            // 
            this.pnlDailySales.Controls.Add(this.lstOrder);
            this.pnlDailySales.Controls.Add(this.lblOrder);
            this.pnlDailySales.Controls.Add(this.label1);
            this.pnlDailySales.Controls.Add(this.dtpSaleDay);
            this.pnlDailySales.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDailySales.Location = new System.Drawing.Point(0, 0);
            this.pnlDailySales.Name = "pnlDailySales";
            this.pnlDailySales.Size = new System.Drawing.Size(401, 651);
            this.pnlDailySales.TabIndex = 1;
            // 
            // lstOrder
            // 
            this.lstOrder.FormattingEnabled = true;
            this.lstOrder.ItemHeight = 16;
            this.lstOrder.Location = new System.Drawing.Point(19, 89);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(363, 548);
            this.lstOrder.TabIndex = 2;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(14, 60);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(200, 26);
            this.lblOrder.TabIndex = 2;
            this.lblOrder.Text = "Productos vendidos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Yu Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(11, 141);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(364, 45);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Añadir a la lista de Ventas";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Yu Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(11, 192);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(364, 46);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "Modificar una venta";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Yu Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(11, 249);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(364, 46);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Eliminar una venta";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Yu Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(3, 585);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(203, 43);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Guardar Récord";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Yu Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(212, 585);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(181, 43);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Exportar a Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // gbxAddSale
            // 
            this.gbxAddSale.Controls.Add(this.nudProdQty);
            this.gbxAddSale.Controls.Add(this.lblProduct);
            this.gbxAddSale.Controls.Add(this.lblQty);
            this.gbxAddSale.Controls.Add(this.btnAdd);
            this.gbxAddSale.Controls.Add(this.btnGenSales);
            this.gbxAddSale.Controls.Add(this.btnDelete);
            this.gbxAddSale.Controls.Add(this.cbxProduct);
            this.gbxAddSale.Controls.Add(this.btnModify);
            this.gbxAddSale.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAddSale.Location = new System.Drawing.Point(6, 12);
            this.gbxAddSale.Name = "gbxAddSale";
            this.gbxAddSale.Size = new System.Drawing.Size(391, 353);
            this.gbxAddSale.TabIndex = 3;
            this.gbxAddSale.TabStop = false;
            this.gbxAddSale.Text = "Añadir Venta";
            // 
            // nudProdQty
            // 
            this.nudProdQty.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudProdQty.Location = new System.Drawing.Point(160, 89);
            this.nudProdQty.Name = "nudProdQty";
            this.nudProdQty.Size = new System.Drawing.Size(95, 35);
            this.nudProdQty.TabIndex = 6;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(7, 42);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(101, 26);
            this.lblProduct.TabIndex = 5;
            this.lblProduct.Text = "Producto:";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(6, 98);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(102, 26);
            this.lblQty.TabIndex = 5;
            this.lblQty.Text = "Cantidad:";
            // 
            // cbxProduct
            // 
            this.cbxProduct.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProduct.FormattingEnabled = true;
            this.cbxProduct.Location = new System.Drawing.Point(160, 42);
            this.cbxProduct.Name = "cbxProduct";
            this.cbxProduct.Size = new System.Drawing.Size(216, 30);
            this.cbxProduct.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.gbxAddSale);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(401, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 651);
            this.panel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMostSold);
            this.groupBox1.Controls.Add(this.txtUnitsSold);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.lblMostSold);
            this.groupBox1.Controls.Add(this.lblUnitsSold);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 371);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 198);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estadísticas";
            // 
            // txtUnitsSold
            // 
            this.txtUnitsSold.Location = new System.Drawing.Point(251, 93);
            this.txtUnitsSold.Name = "txtUnitsSold";
            this.txtUnitsSold.ReadOnly = true;
            this.txtUnitsSold.Size = new System.Drawing.Size(124, 35);
            this.txtUnitsSold.TabIndex = 6;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(251, 42);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(124, 35);
            this.txtTotal.TabIndex = 6;
            // 
            // lblUnitsSold
            // 
            this.lblUnitsSold.AutoSize = true;
            this.lblUnitsSold.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitsSold.Location = new System.Drawing.Point(6, 102);
            this.lblUnitsSold.Name = "lblUnitsSold";
            this.lblUnitsSold.Size = new System.Drawing.Size(197, 26);
            this.lblUnitsSold.TabIndex = 5;
            this.lblUnitsSold.Text = "Unidades Vendidas:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(6, 51);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(144, 26);
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
            this.panelBottomBar.Location = new System.Drawing.Point(0, 651);
            this.panelBottomBar.Name = "panelBottomBar";
            this.panelBottomBar.Size = new System.Drawing.Size(1366, 67);
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
            // btnGenSales
            // 
            this.btnGenSales.Font = new System.Drawing.Font("Yu Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenSales.Location = new System.Drawing.Point(10, 301);
            this.btnGenSales.Name = "btnGenSales";
            this.btnGenSales.Size = new System.Drawing.Size(364, 46);
            this.btnGenSales.TabIndex = 2;
            this.btnGenSales.Text = "Generar Añalisis de ventas";
            this.btnGenSales.UseVisualStyleBackColor = true;
            // 
            // lblMostSold
            // 
            this.lblMostSold.AutoSize = true;
            this.lblMostSold.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostSold.Location = new System.Drawing.Point(6, 154);
            this.lblMostSold.Name = "lblMostSold";
            this.lblMostSold.Size = new System.Drawing.Size(224, 26);
            this.lblMostSold.TabIndex = 5;
            this.lblMostSold.Text = "Producto más vendido:";
            // 
            // txtMostSold
            // 
            this.txtMostSold.Location = new System.Drawing.Point(251, 145);
            this.txtMostSold.Name = "txtMostSold";
            this.txtMostSold.ReadOnly = true;
            this.txtMostSold.Size = new System.Drawing.Size(124, 35);
            this.txtMostSold.TabIndex = 6;
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 718);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDailySales);
            this.Controls.Add(this.panelBottomBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesForm";
            this.Text = "SalesForm";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            this.pnlDailySales.ResumeLayout(false);
            this.pnlDailySales.PerformLayout();
            this.gbxAddSale.ResumeLayout(false);
            this.gbxAddSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProdQty)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelBottomBar.ResumeLayout(false);
            this.panelBottomBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpSaleDay;
        private System.Windows.Forms.Panel pnlDailySales;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstOrder;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxAddSale;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox cbxProduct;
        private System.Windows.Forms.NumericUpDown nudProdQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelBottomBar;
        private System.Windows.Forms.Panel panelLogoSales;
        private System.Windows.Forms.Label lblManageSales;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUnitsSold;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblUnitsSold;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnGenSales;
        private System.Windows.Forms.TextBox txtMostSold;
        private System.Windows.Forms.Label lblMostSold;
    }
}