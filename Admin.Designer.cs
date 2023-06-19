namespace Proiect_v2
{/// <summary>
/// Realizat de Andrei Grama 19-06-2023
/// </summary>
    partial class Admin
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
            this.dataGridAdmini = new System.Windows.Forms.DataGridView();
            this.dataGridSecretari = new System.Windows.Forms.DataGridView();
            this.dataGridProfesori = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InsAdmin = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.deleteAdmin = new System.Windows.Forms.Button();
            this.deleteSecretar = new System.Windows.Forms.Button();
            this.deleteProfesor = new System.Windows.Forms.Button();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdmini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSecretari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfesori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAdmini
            // 
            this.dataGridAdmini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAdmini.Location = new System.Drawing.Point(73, 74);
            this.dataGridAdmini.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridAdmini.Name = "dataGridAdmini";
            this.dataGridAdmini.RowHeadersWidth = 51;
            this.dataGridAdmini.RowTemplate.Height = 29;
            this.dataGridAdmini.Size = new System.Drawing.Size(262, 263);
            this.dataGridAdmini.TabIndex = 0;
            // 
            // dataGridSecretari
            // 
            this.dataGridSecretari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSecretari.Location = new System.Drawing.Point(424, 74);
            this.dataGridSecretari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridSecretari.Name = "dataGridSecretari";
            this.dataGridSecretari.RowHeadersWidth = 51;
            this.dataGridSecretari.RowTemplate.Height = 29;
            this.dataGridSecretari.Size = new System.Drawing.Size(262, 263);
            this.dataGridSecretari.TabIndex = 1;
            // 
            // dataGridProfesori
            // 
            this.dataGridProfesori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProfesori.Location = new System.Drawing.Point(773, 74);
            this.dataGridProfesori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridProfesori.Name = "dataGridProfesori";
            this.dataGridProfesori.RowHeadersWidth = 51;
            this.dataGridProfesori.RowTemplate.Height = 29;
            this.dataGridProfesori.Size = new System.Drawing.Size(262, 263);
            this.dataGridProfesori.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(177, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admini";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(524, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Secretari";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(878, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Profesori";
            // 
            // InsAdmin
            // 
            this.InsAdmin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InsAdmin.Location = new System.Drawing.Point(73, 352);
            this.InsAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InsAdmin.Name = "InsAdmin";
            this.InsAdmin.Size = new System.Drawing.Size(93, 42);
            this.InsAdmin.TabIndex = 11;
            this.InsAdmin.Text = "Adaugă Admin";
            this.InsAdmin.UseVisualStyleBackColor = true;
            this.InsAdmin.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(424, 352);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 42);
            this.button2.TabIndex = 12;
            this.button2.Text = "Adaugă Secretar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(773, 352);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 42);
            this.button3.TabIndex = 13;
            this.button3.Text = "Adaugă Profesor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // deleteAdmin
            // 
            this.deleteAdmin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteAdmin.Location = new System.Drawing.Point(231, 352);
            this.deleteAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteAdmin.Name = "deleteAdmin";
            this.deleteAdmin.Size = new System.Drawing.Size(104, 42);
            this.deleteAdmin.TabIndex = 14;
            this.deleteAdmin.Text = "Șterge Admin";
            this.deleteAdmin.UseVisualStyleBackColor = true;
            this.deleteAdmin.Click += new System.EventHandler(this.deleteAdmin_Click);
            // 
            // deleteSecretar
            // 
            this.deleteSecretar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteSecretar.Location = new System.Drawing.Point(577, 352);
            this.deleteSecretar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteSecretar.Name = "deleteSecretar";
            this.deleteSecretar.Size = new System.Drawing.Size(110, 42);
            this.deleteSecretar.TabIndex = 15;
            this.deleteSecretar.Text = "Șterge Secretar";
            this.deleteSecretar.UseVisualStyleBackColor = true;
            // 
            // deleteProfesor
            // 
            this.deleteProfesor.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteProfesor.Location = new System.Drawing.Point(918, 352);
            this.deleteProfesor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteProfesor.Name = "deleteProfesor";
            this.deleteProfesor.Size = new System.Drawing.Size(117, 42);
            this.deleteProfesor.TabIndex = 16;
            this.deleteProfesor.Text = "Șterge Profesor";
            this.deleteProfesor.UseVisualStyleBackColor = true;
            // 
            // btnInapoi
            // 
            this.btnInapoi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInapoi.Location = new System.Drawing.Point(10, 9);
            this.btnInapoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(88, 26);
            this.btnInapoi.TabIndex = 17;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = true;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proiect_v2.Properties.Resources.icons8_admin_50;
            this.pictureBox1.Location = new System.Drawing.Point(146, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proiect_v2.Properties.Resources.icons8_secretary_66;
            this.pictureBox2.Location = new System.Drawing.Point(491, 43);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Proiect_v2.Properties.Resources.icons8_professor_50;
            this.pictureBox3.Location = new System.Drawing.Point(827, 20);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(92)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(1097, 406);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.deleteProfesor);
            this.Controls.Add(this.deleteSecretar);
            this.Controls.Add(this.deleteAdmin);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.InsAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridProfesori);
            this.Controls.Add(this.dataGridSecretari);
            this.Controls.Add(this.dataGridAdmini);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdmini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSecretari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfesori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridAdmini;
        private DataGridView dataGridSecretari;
        private DataGridView dataGridProfesori;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button InsAdmin;
        private Button button2;
        private Button button3;
        private Button deleteAdmin;
        private Button deleteSecretar;
        private Button deleteProfesor;
        private Button btnInapoi;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}