﻿namespace CarRentApp
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.managerVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewArhiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managerVehicleToolStripMenuItem,
            this.manageRentalToolStripMenuItem,
            this.manageUsersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // managerVehicleToolStripMenuItem
            // 
            this.managerVehicleToolStripMenuItem.Name = "managerVehicleToolStripMenuItem";
            this.managerVehicleToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.managerVehicleToolStripMenuItem.Text = "Manager Vehicle";
            // 
            // manageRentalToolStripMenuItem
            // 
            this.manageRentalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRentalToolStripMenuItem,
            this.editRentalToolStripMenuItem,
            this.viewArhiveToolStripMenuItem});
            this.manageRentalToolStripMenuItem.Name = "manageRentalToolStripMenuItem";
            this.manageRentalToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.manageRentalToolStripMenuItem.Text = "Manage Rental";
            // 
            // addRentalToolStripMenuItem
            // 
            this.addRentalToolStripMenuItem.Name = "addRentalToolStripMenuItem";
            this.addRentalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addRentalToolStripMenuItem.Text = "Add Rental";
            // 
            // editRentalToolStripMenuItem
            // 
            this.editRentalToolStripMenuItem.Name = "editRentalToolStripMenuItem";
            this.editRentalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editRentalToolStripMenuItem.Text = "Edit Rental";
            // 
            // viewArhiveToolStripMenuItem
            // 
            this.viewArhiveToolStripMenuItem.Name = "viewArhiveToolStripMenuItem";
            this.viewArhiveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewArhiveToolStripMenuItem.Text = "View Arhive";
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem managerVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewArhiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
    }
}