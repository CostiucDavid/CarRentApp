namespace CarRentApp
{
    partial class ManageUsers
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
            this.btRefresh = new System.Windows.Forms.Button();
            this.btAddNewUser = new System.Windows.Forms.Button();
            this.btResetPassword = new System.Windows.Forms.Button();
            this.btActivateDeactivate = new System.Windows.Forms.Button();
            this.dgvUserList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // btRefresh
            // 
            this.btRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btRefresh.Location = new System.Drawing.Point(12, 12);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(186, 34);
            this.btRefresh.TabIndex = 0;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            // 
            // btAddNewUser
            // 
            this.btAddNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAddNewUser.Location = new System.Drawing.Point(13, 404);
            this.btAddNewUser.Name = "btAddNewUser";
            this.btAddNewUser.Size = new System.Drawing.Size(185, 34);
            this.btAddNewUser.TabIndex = 1;
            this.btAddNewUser.Text = "Add new user";
            this.btAddNewUser.UseVisualStyleBackColor = true;
            // 
            // btResetPassword
            // 
            this.btResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btResetPassword.Location = new System.Drawing.Point(424, 404);
            this.btResetPassword.Name = "btResetPassword";
            this.btResetPassword.Size = new System.Drawing.Size(185, 34);
            this.btResetPassword.TabIndex = 2;
            this.btResetPassword.Text = "Reset password";
            this.btResetPassword.UseVisualStyleBackColor = true;
            this.btResetPassword.Click += new System.EventHandler(this.btResetPassword_Click);
            // 
            // btActivateDeactivate
            // 
            this.btActivateDeactivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btActivateDeactivate.Location = new System.Drawing.Point(922, 404);
            this.btActivateDeactivate.Name = "btActivateDeactivate";
            this.btActivateDeactivate.Size = new System.Drawing.Size(185, 34);
            this.btActivateDeactivate.TabIndex = 3;
            this.btActivateDeactivate.Text = "Activate / Deactivate";
            this.btActivateDeactivate.UseVisualStyleBackColor = true;
            // 
            // dgvUserList
            // 
            this.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserList.Location = new System.Drawing.Point(0, 52);
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.Size = new System.Drawing.Size(1119, 346);
            this.dgvUserList.TabIndex = 4;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 450);
            this.Controls.Add(this.dgvUserList);
            this.Controls.Add(this.btActivateDeactivate);
            this.Controls.Add(this.btResetPassword);
            this.Controls.Add(this.btAddNewUser);
            this.Controls.Add(this.btRefresh);
            this.Name = "ManageUsers";
            this.Text = "ManageUsers";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btAddNewUser;
        private System.Windows.Forms.Button btResetPassword;
        private System.Windows.Forms.Button btActivateDeactivate;
        private System.Windows.Forms.DataGridView dgvUserList;
    }
}