namespace Employee
{
    partial class Form1
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
            this.LblChooseFile = new System.Windows.Forms.Label();
            this.TxtFileName = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnChooseFile = new System.Windows.Forms.Button();
            this.EmployeeGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LblChooseFile
            // 
            this.LblChooseFile.AutoSize = true;
            this.LblChooseFile.Location = new System.Drawing.Point(12, 25);
            this.LblChooseFile.Name = "LblChooseFile";
            this.LblChooseFile.Size = new System.Drawing.Size(97, 13);
            this.LblChooseFile.TabIndex = 1;
            this.LblChooseFile.Text = "Please Choose File";
            // 
            // TxtFileName
            // 
            this.TxtFileName.AllowDrop = true;
            this.TxtFileName.Location = new System.Drawing.Point(112, 22);
            this.TxtFileName.Name = "TxtFileName";
            this.TxtFileName.ReadOnly = true;
            this.TxtFileName.Size = new System.Drawing.Size(211, 20);
            this.TxtFileName.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnChooseFile
            // 
            this.BtnChooseFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnChooseFile.Location = new System.Drawing.Point(329, 21);
            this.BtnChooseFile.Name = "BtnChooseFile";
            this.BtnChooseFile.Size = new System.Drawing.Size(33, 23);
            this.BtnChooseFile.TabIndex = 2;
            this.BtnChooseFile.Text = "...";
            this.BtnChooseFile.UseVisualStyleBackColor = true;
            this.BtnChooseFile.Click += new System.EventHandler(this.BtnChooseFile_Click);
            // 
            // EmployeeGrid
            // 
            this.EmployeeGrid.AllowUserToAddRows = false;
            this.EmployeeGrid.AllowUserToDeleteRows = false;
            this.EmployeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeGrid.Location = new System.Drawing.Point(3, 71);
            this.EmployeeGrid.Name = "EmployeeGrid";
            this.EmployeeGrid.ReadOnly = true;
            this.EmployeeGrid.Size = new System.Drawing.Size(426, 123);
            this.EmployeeGrid.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(433, 201);
            this.Controls.Add(this.EmployeeGrid);
            this.Controls.Add(this.BtnChooseFile);
            this.Controls.Add(this.LblChooseFile);
            this.Controls.Add(this.TxtFileName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblChooseFile;
        private System.Windows.Forms.TextBox TxtFileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnChooseFile;
        private System.Windows.Forms.DataGridView EmployeeGrid;
    }
}

