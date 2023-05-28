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
            this.panelBottomBar = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.flpTopBar = new System.Windows.Forms.FlowLayoutPanel();
            this.NF_Logo = new System.Windows.Forms.FlowLayoutPanel();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnFinance = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.flpTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottomBar
            // 
            this.panelBottomBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(96)))));
            this.panelBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomBar.Location = new System.Drawing.Point(0, 601);
            this.panelBottomBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBottomBar.Name = "panelBottomBar";
            this.panelBottomBar.Size = new System.Drawing.Size(1011, 8);
            this.panelBottomBar.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.flpTopBar);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1011, 601);
            this.panelMain.TabIndex = 2;
            // 
            // flpTopBar
            // 
            this.flpTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(96)))));
            this.flpTopBar.Controls.Add(this.NF_Logo);
            this.flpTopBar.Controls.Add(this.btnHome);
            this.flpTopBar.Controls.Add(this.btnInventory);
            this.flpTopBar.Controls.Add(this.btnMembers);
            this.flpTopBar.Controls.Add(this.btnFinance);
            this.flpTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpTopBar.Location = new System.Drawing.Point(0, 0);
            this.flpTopBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpTopBar.Name = "flpTopBar";
            this.flpTopBar.Size = new System.Drawing.Size(1011, 124);
            this.flpTopBar.TabIndex = 0;
            // 
            // NF_Logo
            // 
            this.NF_Logo.BackgroundImage = global::NaturalFitnessApp.Properties.Resources.NaturalFitness;
            this.NF_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NF_Logo.Location = new System.Drawing.Point(2, 2);
            this.NF_Logo.Margin = new System.Windows.Forms.Padding(2);
            this.NF_Logo.Name = "NF_Logo";
            this.NF_Logo.Size = new System.Drawing.Size(139, 122);
            this.NF_Logo.TabIndex = 1;
            // 
            // btnInventory
            // 
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Image = global::NaturalFitnessApp.Properties.Resources.inventory_white;
            this.btnInventory.Location = new System.Drawing.Point(322, 2);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(2);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(173, 122);
            this.btnInventory.TabIndex = 1;
            this.btnInventory.Text = "Inventario";
            this.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnCafeteria_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.FlatAppearance.BorderSize = 0;
            this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.btnMembers.ForeColor = System.Drawing.Color.White;
            this.btnMembers.Image = global::NaturalFitnessApp.Properties.Resources.group_white;
            this.btnMembers.Location = new System.Drawing.Point(499, 2);
            this.btnMembers.Margin = new System.Windows.Forms.Padding(2);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(178, 122);
            this.btnMembers.TabIndex = 3;
            this.btnMembers.Text = "Miembros";
            this.btnMembers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMembers.UseVisualStyleBackColor = true;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // btnFinance
            // 
            this.btnFinance.FlatAppearance.BorderSize = 0;
            this.btnFinance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.btnFinance.ForeColor = System.Drawing.Color.White;
            this.btnFinance.Image = global::NaturalFitnessApp.Properties.Resources.finance_white;
            this.btnFinance.Location = new System.Drawing.Point(681, 2);
            this.btnFinance.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinance.Name = "btnFinance";
            this.btnFinance.Size = new System.Drawing.Size(200, 122);
            this.btnFinance.TabIndex = 2;
            this.btnFinance.Text = "Ganancias";
            this.btnFinance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFinance.UseVisualStyleBackColor = true;
            this.btnFinance.Click += new System.EventHandler(this.btnFinance_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::NaturalFitnessApp.Properties.Resources.home_white;
            this.btnHome.Location = new System.Drawing.Point(145, 2);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(173, 122);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Inicio";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1011, 609);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelBottomBar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "App";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Natural Fitness Manager";
            this.panelMain.ResumeLayout(false);
            this.flpTopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel NF_Logo;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Panel panelBottomBar;
        private System.Windows.Forms.Button btnFinance;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.FlowLayoutPanel flpTopBar;
        private System.Windows.Forms.Button btnHome;
    }
}