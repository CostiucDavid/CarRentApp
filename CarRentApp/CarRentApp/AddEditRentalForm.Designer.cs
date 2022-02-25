namespace CarRentApp
{
    partial class AddEditRentalForm
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
            this.lCustomerName = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.lCost = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.lDateRented = new System.Windows.Forms.Label();
            this.lTypeOfCar = new System.Windows.Forms.Label();
            this.lDateReturned = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpDataRented = new System.Windows.Forms.DateTimePicker();
            this.dtpDateReturned = new System.Windows.Forms.DateTimePicker();
            this.cbTypeOfCar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lCustomerName
            // 
            this.lCustomerName.AutoSize = true;
            this.lCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCustomerName.Location = new System.Drawing.Point(28, 25);
            this.lCustomerName.Name = "lCustomerName";
            this.lCustomerName.Size = new System.Drawing.Size(147, 24);
            this.lCustomerName.TabIndex = 0;
            this.lCustomerName.Text = "Customer Name";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(262, 28);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(200, 20);
            this.tbCustomerName.TabIndex = 1;
            // 
            // lCost
            // 
            this.lCost.AutoSize = true;
            this.lCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCost.Location = new System.Drawing.Point(28, 92);
            this.lCost.Name = "lCost";
            this.lCost.Size = new System.Drawing.Size(47, 24);
            this.lCost.TabIndex = 2;
            this.lCost.Text = "Cost";
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(262, 97);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(200, 20);
            this.tbCost.TabIndex = 3;
            // 
            // lDateRented
            // 
            this.lDateRented.AutoSize = true;
            this.lDateRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDateRented.Location = new System.Drawing.Point(28, 164);
            this.lDateRented.Name = "lDateRented";
            this.lDateRented.Size = new System.Drawing.Size(114, 24);
            this.lDateRented.TabIndex = 4;
            this.lDateRented.Text = "Date Rented";
            // 
            // lTypeOfCar
            // 
            this.lTypeOfCar.AutoSize = true;
            this.lTypeOfCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTypeOfCar.Location = new System.Drawing.Point(28, 312);
            this.lTypeOfCar.Name = "lTypeOfCar";
            this.lTypeOfCar.Size = new System.Drawing.Size(107, 24);
            this.lTypeOfCar.TabIndex = 6;
            this.lTypeOfCar.Text = "Type of Car";
            // 
            // lDateReturned
            // 
            this.lDateReturned.AutoSize = true;
            this.lDateReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDateReturned.Location = new System.Drawing.Point(28, 234);
            this.lDateReturned.Name = "lDateReturned";
            this.lDateReturned.Size = new System.Drawing.Size(131, 24);
            this.lDateReturned.TabIndex = 8;
            this.lDateReturned.Text = "Date Returned";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(154, 381);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 40);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpDataRented
            // 
            this.dtpDataRented.Location = new System.Drawing.Point(262, 167);
            this.dtpDataRented.Name = "dtpDataRented";
            this.dtpDataRented.Size = new System.Drawing.Size(200, 20);
            this.dtpDataRented.TabIndex = 11;
            // 
            // dtpDateReturned
            // 
            this.dtpDateReturned.Location = new System.Drawing.Point(262, 238);
            this.dtpDateReturned.Name = "dtpDateReturned";
            this.dtpDateReturned.Size = new System.Drawing.Size(200, 20);
            this.dtpDateReturned.TabIndex = 12;
            // 
            // cbTypeOfCar
            // 
            this.cbTypeOfCar.FormattingEnabled = true;
            this.cbTypeOfCar.Location = new System.Drawing.Point(262, 314);
            this.cbTypeOfCar.Name = "cbTypeOfCar";
            this.cbTypeOfCar.Size = new System.Drawing.Size(200, 21);
            this.cbTypeOfCar.TabIndex = 13;
            // 
            // AddEditRentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::CarRentApp.Properties.Resources.ranger_4df6c1b6;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbTypeOfCar);
            this.Controls.Add(this.dtpDateReturned);
            this.Controls.Add(this.dtpDataRented);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lDateReturned);
            this.Controls.Add(this.lTypeOfCar);
            this.Controls.Add(this.lDateRented);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.lCost);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.lCustomerName);
            this.Name = "AddEditRentalForm";
            this.Text = "AddEditRentalForm";
            this.Load += new System.EventHandler(this.AddEditRentalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lCustomerName;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label lCost;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label lDateRented;
        private System.Windows.Forms.Label lTypeOfCar;
        private System.Windows.Forms.Label lDateReturned;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpDataRented;
        private System.Windows.Forms.DateTimePicker dtpDateReturned;
        private System.Windows.Forms.ComboBox cbTypeOfCar;
    }
}