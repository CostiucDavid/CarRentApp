namespace CarRentApp
{
    partial class SearchArchiveForm
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
            this.lSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.dgvCarRents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarRents)).BeginInit();
            this.SuspendLayout();
            // 
            // lSearch
            // 
            this.lSearch.AutoSize = true;
            this.lSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lSearch.Location = new System.Drawing.Point(34, 30);
            this.lSearch.Name = "lSearch";
            this.lSearch.Size = new System.Drawing.Size(70, 24);
            this.lSearch.TabIndex = 0;
            this.lSearch.Text = "Search";
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearch.Location = new System.Drawing.Point(153, 27);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(191, 29);
            this.tbSearch.TabIndex = 2;
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProcess.Location = new System.Drawing.Point(79, 82);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(107, 34);
            this.btnProcess.TabIndex = 3;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            // 
            // dgvCarRents
            // 
            this.dgvCarRents.AllowUserToOrderColumns = true;
            this.dgvCarRents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCarRents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarRents.Location = new System.Drawing.Point(2, 136);
            this.dgvCarRents.Name = "dgvCarRents";
            this.dgvCarRents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarRents.Size = new System.Drawing.Size(734, 251);
            this.dgvCarRents.TabIndex = 4;
            // 
            // SearchArchiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCarRents);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lSearch);
            this.Name = "SearchArchiveForm";
            this.Text = "SearchArchiveForm";
            this.Load += new System.EventHandler(this.SearchArchiveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarRents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.DataGridView dgvCarRents;
    }
}