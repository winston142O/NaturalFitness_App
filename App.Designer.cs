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
            this.btnCafeteria = new System.Windows.Forms.Button();
            this.NF_Logo = new System.Windows.Forms.FlowLayoutPanel();
            this.panelBottomBar = new System.Windows.Forms.Panel();
            this.panelTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(96)))));
            this.panelTopBar.Controls.Add(this.btnCafeteria);
            this.panelTopBar.Controls.Add(this.NF_Logo);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(1289, 150);
            this.panelTopBar.TabIndex = 0;
            // 
            // btnCafeteria
            // 
            this.btnCafeteria.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCafeteria.FlatAppearance.BorderSize = 0;
            this.btnCafeteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCafeteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCafeteria.ForeColor = System.Drawing.Color.White;
            this.btnCafeteria.Location = new System.Drawing.Point(185, 0);
            this.btnCafeteria.Name = "btnCafeteria";
            this.btnCafeteria.Size = new System.Drawing.Size(363, 150);
            this.btnCafeteria.TabIndex = 1;
            this.btnCafeteria.Text = "Cafetería";
            this.btnCafeteria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCafeteria.UseVisualStyleBackColor = true;
            this.btnCafeteria.Click += new System.EventHandler(this.btnCafeteria_Click);
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
            this.panelBottomBar.Location = new System.Drawing.Point(0, 749);
            this.panelBottomBar.Name = "panelBottomBar";
            this.panelBottomBar.Size = new System.Drawing.Size(1289, 26);
            this.panelBottomBar.TabIndex = 1;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1289, 775);
            this.Controls.Add(this.panelBottomBar);
            this.Controls.Add(this.panelTopBar);
            this.Name = "App";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Natural Fitness Manager";
            this.panelTopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.FlowLayoutPanel NF_Logo;
        private System.Windows.Forms.Button btnCafeteria;
        private System.Windows.Forms.Panel panelBottomBar;
    }
}