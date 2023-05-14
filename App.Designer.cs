namespace NaturalFitnessApp
{
    partial class App
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
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.btnFinance = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.NF_Logo = new System.Windows.Forms.FlowLayoutPanel();
            this.panelBottomBar = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(96)))));
            this.panelTopBar.Controls.Add(this.btnFinance);
            this.panelTopBar.Controls.Add(this.btnMembers);
            this.panelTopBar.Controls.Add(this.btnInventory);
            this.panelTopBar.Controls.Add(this.NF_Logo);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(1348, 150);
            this.panelTopBar.TabIndex = 0;
            // 
            // btnFinance
            // 
            this.btnFinance.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFinance.FlatAppearance.BorderSize = 0;
            this.btnFinance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.btnFinance.ForeColor = System.Drawing.Color.White;
            this.btnFinance.Image = global::NaturalFitnessApp.Properties.Resources.finance_white;
            this.btnFinance.Location = new System.Drawing.Point(653, 0);
            this.btnFinance.Name = "btnFinance";
            this.btnFinance.Size = new System.Drawing.Size(266, 150);
            this.btnFinance.TabIndex = 2;
            this.btnFinance.Text = "Ganancias";
            this.btnFinance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFinance.UseVisualStyleBackColor = true;
            // 
            // btnMembers
            // 
            this.btnMembers.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMembers.FlatAppearance.BorderSize = 0;
            this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.btnMembers.ForeColor = System.Drawing.Color.White;
            this.btnMembers.Image = global::NaturalFitnessApp.Properties.Resources.group_white;
            this.btnMembers.Location = new System.Drawing.Point(416, 0);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(237, 150);
            this.btnMembers.TabIndex = 3;
            this.btnMembers.Text = "Miembros";
            this.btnMembers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMembers.UseVisualStyleBackColor = true;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Image = global::NaturalFitnessApp.Properties.Resources.inventory_white;
            this.btnInventory.Location = new System.Drawing.Point(185, 0);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(231, 150);
            this.btnInventory.TabIndex = 1;
            this.btnInventory.Text = "Inventario";
            this.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnCafeteria_Click);
            // 
            // NF_Logo
            // 
            this.NF_Logo.BackgroundImage = global::NaturalFitnessApp.Properties.Resources.NaturalFitness;
            this.NF_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NF_Logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.NF_Logo.Location = new System.Drawing.Point(0, 0);
            this.NF_Logo.Name = "NF_Logo";
            this.NF_Logo.Size = new System.Drawing.Size(185, 150);
            this.NF_Logo.TabIndex = 1;
            // 
            // panelBottomBar
            // 
            this.panelBottomBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(96)))));
            this.panelBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomBar.Location = new System.Drawing.Point(0, 874);
            this.panelBottomBar.Name = "panelBottomBar";
            this.panelBottomBar.Size = new System.Drawing.Size(1348, 10);
            this.panelBottomBar.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 150);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1348, 724);
            this.panelMain.TabIndex = 2;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1348, 884);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelBottomBar);
            this.Controls.Add(this.panelTopBar);
            this.Name = "App";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Natural Fitness Manager";
            this.panelTopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.FlowLayoutPanel NF_Logo;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Panel panelBottomBar;
        private System.Windows.Forms.Button btnFinance;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Panel panelMain;
    }
}