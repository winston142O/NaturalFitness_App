namespace NaturalFitnessApp
{
    partial class InventoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBottomBar = new System.Windows.Forms.Panel();
            this.lblManageInv = new System.Windows.Forms.Label();
            this.dgvInv = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelLogoInv = new System.Windows.Forms.Panel();
            this.ColNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProdCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelBottomBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInv)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBottomBar
            // 
            this.panelBottomBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(219)))), ((int)(((byte)(73)))));
            this.panelBottomBar.Controls.Add(this.btnAdd);
            this.panelBottomBar.Controls.Add(this.panelLogoInv);
            this.panelBottomBar.Controls.Add(this.lblManageInv);
            this.panelBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBottomBar.Location = new System.Drawing.Point(0, 701);
            this.panelBottomBar.Name = "panelBottomBar";
            this.panelBottomBar.Size = new System.Drawing.Size(1366, 67);
            this.panelBottomBar.TabIndex = 1;
            // 
            // lblManageInv
            // 
            this.lblManageInv.AutoSize = true;
            this.lblManageInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageInv.Location = new System.Drawing.Point(12, 17);
            this.lblManageInv.Name = "lblManageInv";
            this.lblManageInv.Size = new System.Drawing.Size(312, 32);
            this.lblManageInv.TabIndex = 1;
            this.lblManageInv.Text = "Administrar Inventario";
            // 
            // dgvInv
            // 
            this.dgvInv.AllowUserToAddRows = false;
            this.dgvInv.BackgroundColor = System.Drawing.Color.White;
            this.dgvInv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(219)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInv.ColumnHeadersHeight = 30;
            this.dgvInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNum,
            this.colProdID,
            this.colProdName,
            this.ColProdCant,
            this.ColProdPrice,
            this.ColPhone,
            this.ColEdit,
            this.ColDelete});
            this.dgvInv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInv.EnableHeadersVisualStyles = false;
            this.dgvInv.Location = new System.Drawing.Point(0, 0);
            this.dgvInv.Name = "dgvInv";
            this.dgvInv.RowHeadersWidth = 51;
            this.dgvInv.RowTemplate.Height = 24;
            this.dgvInv.Size = new System.Drawing.Size(1366, 768);
            this.dgvInv.TabIndex = 2;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::NaturalFitnessApp.Properties.Resources.edit;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 6;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::NaturalFitnessApp.Properties.Resources.delete;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::NaturalFitnessApp.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(1308, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 67);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // panelLogoInv
            // 
            this.panelLogoInv.BackgroundImage = global::NaturalFitnessApp.Properties.Resources.inventory;
            this.panelLogoInv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogoInv.Location = new System.Drawing.Point(345, 9);
            this.panelLogoInv.Name = "panelLogoInv";
            this.panelLogoInv.Size = new System.Drawing.Size(55, 46);
            this.panelLogoInv.TabIndex = 2;
            // 
            // ColNum
            // 
            this.ColNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColNum.HeaderText = "No";
            this.ColNum.MinimumWidth = 6;
            this.ColNum.Name = "ColNum";
            this.ColNum.Width = 59;
            // 
            // colProdID
            // 
            this.colProdID.HeaderText = "ID";
            this.colProdID.MinimumWidth = 6;
            this.colProdID.Name = "colProdID";
            this.colProdID.Width = 125;
            // 
            // colProdName
            // 
            this.colProdName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProdName.HeaderText = "Nombre";
            this.colProdName.MinimumWidth = 6;
            this.colProdName.Name = "colProdName";
            // 
            // ColProdCant
            // 
            this.ColProdCant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColProdCant.HeaderText = "Cant.";
            this.ColProdCant.MinimumWidth = 6;
            this.ColProdCant.Name = "ColProdCant";
            // 
            // ColProdPrice
            // 
            this.ColProdPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColProdPrice.HeaderText = "Precio";
            this.ColProdPrice.MinimumWidth = 6;
            this.ColProdPrice.Name = "ColProdPrice";
            this.ColProdPrice.Width = 90;
            // 
            // ColPhone
            // 
            this.ColPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColPhone.HeaderText = "Teléfono";
            this.ColPhone.MinimumWidth = 6;
            this.ColPhone.Name = "ColPhone";
            this.ColPhone.Width = 108;
            // 
            // ColEdit
            // 
            this.ColEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColEdit.HeaderText = "";
            this.ColEdit.Image = global::NaturalFitnessApp.Properties.Resources.edit;
            this.ColEdit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColEdit.MinimumWidth = 6;
            this.ColEdit.Name = "ColEdit";
            this.ColEdit.Width = 6;
            // 
            // ColDelete
            // 
            this.ColDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColDelete.HeaderText = "";
            this.ColDelete.Image = global::NaturalFitnessApp.Properties.Resources.delete;
            this.ColDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColDelete.MinimumWidth = 6;
            this.ColDelete.Name = "ColDelete";
            this.ColDelete.Width = 6;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panelBottomBar);
            this.Controls.Add(this.dgvInv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryForm";
            this.Text = "InventoryForm";
            this.panelBottomBar.ResumeLayout(false);
            this.panelBottomBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBottomBar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panelLogoInv;
        private System.Windows.Forms.Label lblManageInv;
        private System.Windows.Forms.DataGridView dgvInv;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProdCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPhone;
        private System.Windows.Forms.DataGridViewImageColumn ColEdit;
        private System.Windows.Forms.DataGridViewImageColumn ColDelete;
    }
}