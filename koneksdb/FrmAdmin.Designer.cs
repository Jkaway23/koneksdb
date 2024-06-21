namespace koneksdb
{
    partial class FrmAdmin
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
            this.TxtIDPengguna = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.Label();
            this.TxtNamaPengguna = new System.Windows.Forms.Label();
            this.TxtLevel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.CBLevel = new System.Windows.Forms.ComboBox();
            this.TxtDataPengguna = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnRead = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtIDPengguna
            // 
            this.TxtIDPengguna.AutoSize = true;
            this.TxtIDPengguna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIDPengguna.Location = new System.Drawing.Point(40, 71);
            this.TxtIDPengguna.Name = "TxtIDPengguna";
            this.TxtIDPengguna.Size = new System.Drawing.Size(92, 18);
            this.TxtIDPengguna.TabIndex = 0;
            this.TxtIDPengguna.Text = "ID Pengguna";
            this.TxtIDPengguna.Click += new System.EventHandler(this.TxtIDPengguna_Click);
            // 
            // TxtUsername
            // 
            this.TxtUsername.AutoSize = true;
            this.TxtUsername.Location = new System.Drawing.Point(40, 112);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(70, 16);
            this.TxtUsername.TabIndex = 1;
            this.TxtUsername.Text = "Username";
            // 
            // TxtPassword
            // 
            this.TxtPassword.AutoSize = true;
            this.TxtPassword.Location = new System.Drawing.Point(40, 160);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(67, 16);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.Text = "Password";
            // 
            // TxtNamaPengguna
            // 
            this.TxtNamaPengguna.AutoSize = true;
            this.TxtNamaPengguna.Location = new System.Drawing.Point(40, 201);
            this.TxtNamaPengguna.Name = "TxtNamaPengguna";
            this.TxtNamaPengguna.Size = new System.Drawing.Size(109, 16);
            this.TxtNamaPengguna.TabIndex = 3;
            this.TxtNamaPengguna.Text = "Nama Pengguna";
            // 
            // TxtLevel
            // 
            this.TxtLevel.AutoSize = true;
            this.TxtLevel.Location = new System.Drawing.Point(40, 248);
            this.TxtLevel.Name = "TxtLevel";
            this.TxtLevel.Size = new System.Drawing.Size(40, 16);
            this.TxtLevel.TabIndex = 4;
            this.TxtLevel.Text = "Level";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(187, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(187, 154);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(160, 22);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(187, 201);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(160, 22);
            this.textBox4.TabIndex = 8;
            // 
            // CBLevel
            // 
            this.CBLevel.FormattingEnabled = true;
            this.CBLevel.Location = new System.Drawing.Point(187, 248);
            this.CBLevel.Name = "CBLevel";
            this.CBLevel.Size = new System.Drawing.Size(121, 24);
            this.CBLevel.TabIndex = 9;
            this.CBLevel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TxtDataPengguna
            // 
            this.TxtDataPengguna.AutoSize = true;
            this.TxtDataPengguna.Location = new System.Drawing.Point(64, 320);
            this.TxtDataPengguna.Name = "TxtDataPengguna";
            this.TxtDataPengguna.Size = new System.Drawing.Size(101, 16);
            this.TxtDataPengguna.TabIndex = 10;
            this.TxtDataPengguna.Text = "Data Pengguna";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 349);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(580, 183);
            this.dataGridView1.TabIndex = 11;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(429, 69);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(89, 31);
            this.BtnSave.TabIndex = 12;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(429, 112);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(89, 31);
            this.BtnDelete.TabIndex = 13;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnRead
            // 
            this.BtnRead.Location = new System.Drawing.Point(539, 71);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(89, 31);
            this.BtnRead.TabIndex = 14;
            this.BtnRead.Text = "Read";
            this.BtnRead.UseVisualStyleBackColor = true;
            this.BtnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(539, 112);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(89, 31);
            this.BtnUpdate.TabIndex = 15;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(539, 186);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(89, 31);
            this.BtnClear.TabIndex = 16;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 544);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnRead);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtDataPengguna);
            this.Controls.Add(this.CBLevel);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TxtLevel);
            this.Controls.Add(this.TxtNamaPengguna);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.TxtIDPengguna);
            this.Name = "FrmAdmin";
            this.Text = "FrmAdmin";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TxtIDPengguna;
        private System.Windows.Forms.Label TxtUsername;
        private System.Windows.Forms.Label TxtPassword;
        private System.Windows.Forms.Label TxtNamaPengguna;
        private System.Windows.Forms.Label TxtLevel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox CBLevel;
        private System.Windows.Forms.Label TxtDataPengguna;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnRead;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnClear;
    }
}