namespace Proiect_v2
{/// <summary>
/// PROIECT REALIZART DE GRAMA DANIEL ANDREI
/// </summary>
    partial class Profesor
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDisciplina = new System.Windows.Forms.TextBox();
            this.buttonStergeNota = new System.Windows.Forms.Button();
            this.buttonInsertNota = new System.Windows.Forms.Button();
            this.dataGridNote = new System.Windows.Forms.DataGridView();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNote)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(195, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Notele la disciplina:";
            // 
            // textBoxDisciplina
            // 
            this.textBoxDisciplina.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDisciplina.Location = new System.Drawing.Point(364, 12);
            this.textBoxDisciplina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDisciplina.Name = "textBoxDisciplina";
            this.textBoxDisciplina.Size = new System.Drawing.Size(139, 26);
            this.textBoxDisciplina.TabIndex = 8;
            // 
            // buttonStergeNota
            // 
            this.buttonStergeNota.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStergeNota.Location = new System.Drawing.Point(435, 351);
            this.buttonStergeNota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStergeNota.Name = "buttonStergeNota";
            this.buttonStergeNota.Size = new System.Drawing.Size(93, 41);
            this.buttonStergeNota.TabIndex = 7;
            this.buttonStergeNota.Text = "Șterge Notă";
            this.buttonStergeNota.UseVisualStyleBackColor = true;
            this.buttonStergeNota.Click += new System.EventHandler(this.buttonStergeNota_Click);
            // 
            // buttonInsertNota
            // 
            this.buttonInsertNota.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonInsertNota.Location = new System.Drawing.Point(173, 351);
            this.buttonInsertNota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInsertNota.Name = "buttonInsertNota";
            this.buttonInsertNota.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.buttonInsertNota.Size = new System.Drawing.Size(99, 41);
            this.buttonInsertNota.TabIndex = 6;
            this.buttonInsertNota.Text = "Adaugă Notă";
            this.buttonInsertNota.UseVisualStyleBackColor = true;
            this.buttonInsertNota.Click += new System.EventHandler(this.buttonInsertNota_Click);
            // 
            // dataGridNote
            // 
            this.dataGridNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNote.Location = new System.Drawing.Point(54, 109);
            this.dataGridNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridNote.Name = "dataGridNote";
            this.dataGridNote.RowHeadersWidth = 51;
            this.dataGridNote.RowTemplate.Height = 29;
            this.dataGridNote.Size = new System.Drawing.Size(590, 234);
            this.dataGridNote.TabIndex = 5;
            // 
            // btnInapoi
            // 
            this.btnInapoi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInapoi.Location = new System.Drawing.Point(13, 10);
            this.btnInapoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(86, 24);
            this.btnInapoi.TabIndex = 12;
            this.btnInapoi.Text = "Înapoi";
            this.btnInapoi.UseVisualStyleBackColor = true;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(316, 40);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(50, 27);
            this.comboBox1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(195, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Specializare:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(399, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "An:";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(444, 40);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(59, 27);
            this.comboBox2.TabIndex = 15;
            // 
            // Profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(92)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(732, 398);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDisciplina);
            this.Controls.Add(this.buttonStergeNota);
            this.Controls.Add(this.buttonInsertNota);
            this.Controls.Add(this.dataGridNote);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Profesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profesor";
            this.Load += new System.EventHandler(this.Profesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;

        private Button buttonStergeNota;
        private Button buttonInsertNota;
        private DataGridView dataGridNote;
        private Button btnInapoi;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox comboBox1;
        private Label label5;
        private Label label6;
        private ComboBox comboBox2;
    }
}