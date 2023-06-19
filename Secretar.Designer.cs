namespace Proiect_v2
{
    partial class Secretar
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
            this.dataGridStudenti = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.btnGeneratGrupe = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.txtNrGrupe = new System.Windows.Forms.TextBox();
            this.radioBtnAIA = new System.Windows.Forms.RadioButton();
            this.radioBtnTI = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Export = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridStudenti
            // 
            this.dataGridStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudenti.Location = new System.Drawing.Point(721, 185);
            this.dataGridStudenti.Name = "dataGridStudenti";
            this.dataGridStudenti.RowHeadersWidth = 51;
            this.dataGridStudenti.RowTemplate.Height = 29;
            this.dataGridStudenti.Size = new System.Drawing.Size(513, 512);
            this.dataGridStudenti.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(941, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Studenți";
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInsert.Location = new System.Drawing.Point(722, 709);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(138, 59);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Inserare Student";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnInapoi
            // 
            this.btnInapoi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInapoi.Location = new System.Drawing.Point(11, 12);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(104, 32);
            this.btnInapoi.TabIndex = 3;
            this.btnInapoi.Text = "Înapoi";
            this.btnInapoi.UseVisualStyleBackColor = true;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // btnGeneratGrupe
            // 
            this.btnGeneratGrupe.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGeneratGrupe.Location = new System.Drawing.Point(11, 59);
            this.btnGeneratGrupe.Name = "btnGeneratGrupe";
            this.btnGeneratGrupe.Size = new System.Drawing.Size(154, 41);
            this.btnGeneratGrupe.TabIndex = 6;
            this.btnGeneratGrupe.Text = "Generare grupă";
            this.btnGeneratGrupe.UseVisualStyleBackColor = true;
            this.btnGeneratGrupe.Click += new System.EventHandler(this.btnGeneratGrupe_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStergere.Location = new System.Drawing.Point(1090, 709);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(145, 59);
            this.btnStergere.TabIndex = 7;
            this.btnStergere.Text = "Ștergere Student";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // txtNrGrupe
            // 
            this.txtNrGrupe.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNrGrupe.Location = new System.Drawing.Point(181, 67);
            this.txtNrGrupe.Name = "txtNrGrupe";
            this.txtNrGrupe.Size = new System.Drawing.Size(125, 31);
            this.txtNrGrupe.TabIndex = 10;
            // 
            // radioBtnAIA
            // 
            this.radioBtnAIA.AutoSize = true;
            this.radioBtnAIA.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtnAIA.ForeColor = System.Drawing.Color.White;
            this.radioBtnAIA.Location = new System.Drawing.Point(326, 67);
            this.radioBtnAIA.Name = "radioBtnAIA";
            this.radioBtnAIA.Size = new System.Drawing.Size(61, 27);
            this.radioBtnAIA.TabIndex = 12;
            this.radioBtnAIA.TabStop = true;
            this.radioBtnAIA.Text = "AIA";
            this.radioBtnAIA.UseVisualStyleBackColor = true;
            // 
            // radioBtnTI
            // 
            this.radioBtnTI.AutoSize = true;
            this.radioBtnTI.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtnTI.ForeColor = System.Drawing.Color.White;
            this.radioBtnTI.Location = new System.Drawing.Point(392, 67);
            this.radioBtnTI.Name = "radioBtnTI";
            this.radioBtnTI.Size = new System.Drawing.Size(49, 27);
            this.radioBtnTI.TabIndex = 13;
            this.radioBtnTI.TabStop = true;
            this.radioBtnTI.Text = "TI";
            this.radioBtnTI.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proiect_v2.Properties.Resources.icons8_student_50;
            this.pictureBox1.Location = new System.Drawing.Point(903, 136);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(919, 65);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(153, 29);
            this.Export.TabIndex = 15;
            this.Export.Text = "Export Catalog";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.btnExport);
            // 
            // Secretar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(92)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(1349, 789);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radioBtnTI);
            this.Controls.Add(this.radioBtnAIA);
            this.Controls.Add(this.txtNrGrupe);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnGeneratGrupe);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridStudenti);
            this.Name = "Secretar";
            this.Text = "Secretar";
            this.Load += new System.EventHandler(this.Secretar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridStudenti;
        private Label label1;
        private Button btnInsert;
        private Button btnInapoi;
        private DataGridView dataGridView1;
        private Button btnGeneratGrupe;
        private Button btnStergere;
        private TextBox txtNrGrupe;
        private RadioButton radioBtnAIA;
        private RadioButton radioBtnTI;
        private PictureBox pictureBox1;
        private Button button1;
        private Button Export;
    }
}

