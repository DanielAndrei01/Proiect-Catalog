using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_v2
{
    public partial class Profesor : Form
    {

        public TextBox TextBoxDisciplina
        {
            get { return textBoxDisciplina; }
            set { textBoxDisciplina = value; }
        }

        private TextBox textBoxDisciplina;
        public Profesor()
        {
            InitializeComponent();
        }


        private void buttonInsertNota_Click(object sender, EventArgs e)
        {
            // Create a custom form for the pop-up
            Form popupForm = new Form();
            popupForm.Text = "Note";
            popupForm.StartPosition = FormStartPosition.CenterScreen;
            popupForm.Width = 300;
            popupForm.Height = 250;

            Label lblNrMat = new Label();
            lblNrMat.Text = "Numar Matricol:";
            lblNrMat.Location = new Point(10, 10);

            TextBox txtNrMat = new TextBox();
            txtNrMat.Location = new Point(120, 10);

            Label lblNume = new Label();
            lblNume.Text = "Nume:";
            lblNume.Location = new Point(10, 40);

            TextBox txtNume = new TextBox();
            txtNume.Location = new Point(120, 40);

            Label lblPrenume = new Label();
            lblPrenume.Text = "Prenume:";
            lblPrenume.Location = new Point(10, 70);

            TextBox txtPrenume = new TextBox();
            txtPrenume.Location = new Point(120, 70);

            Label lblInitialaTata = new Label();
            lblInitialaTata.Text = "Initiala Tatalui:";
            lblInitialaTata.Location = new Point(10, 100);

            TextBox txtInitialaTata = new TextBox();
            txtInitialaTata.Location = new Point(120, 100);

            Label lblNota = new Label();
            lblNota.Text = "Nota:";
            lblNota.Location = new Point(10, 130);

            TextBox txtNota = new TextBox();
            txtNota.Location = new Point(120, 130);

            // Create an OK button
            Button btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(120, 170);
            btnOK.Height = 30;

            // Add controls to the form
            popupForm.Controls.Add(lblNrMat);
            popupForm.Controls.Add(txtNrMat);
            popupForm.Controls.Add(lblNume);
            popupForm.Controls.Add(txtNume);
            popupForm.Controls.Add(lblPrenume);
            popupForm.Controls.Add(txtPrenume);
            popupForm.Controls.Add(lblInitialaTata);
            popupForm.Controls.Add(txtInitialaTata);
            popupForm.Controls.Add(lblNota);
            popupForm.Controls.Add(txtNota);
            popupForm.Controls.Add(btnOK);

            // Show the pop-up form as a dialog
            DialogResult result = popupForm.ShowDialog();

            // Process the dialog result

            if (result == DialogResult.OK)
            {
                string connectionString = "Data Source=ANDREI\\SQLEXPRESS;Initial Catalog=Note;Integrated Security=True;";

                string numarMatricol = txtNrMat.Text;
                string nume = txtNume.Text;
                string prenume = txtPrenume.Text;
                string initialaTatalui = txtInitialaTata.Text;
                string disciplina = textBoxDisciplina.Text;
                string nota = txtNota.Text;

                // Update the value in the Note table
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = $"UPDATE Note SET {disciplina} = @Nota WHERE NumarMatricol = @NumarMatricol ";//AND Nume = @Nume AND Prenume = @Prenume AND InitialaTatalui = @InitialaTatalui

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nota", nota);
                        command.Parameters.AddWithValue("@NumarMatricol", numarMatricol);
                        command.Parameters.AddWithValue("@Nume", nume);
                        command.Parameters.AddWithValue("@Prenume", prenume);
                        command.Parameters.AddWithValue("@InitialaTatalui", initialaTatalui);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Nota a fost actualizată în tabelul Note.");
                            ComboBox1_SelectedIndexChanged(sender, e);


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Close(); // Închide formularul curent
            Home Form1 = new Home();
            Form1.Show(); // Deschide Form1
        }

        private void Profesor_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ANDREI\\SQLEXPRESS;Initial Catalog=Note;Integrated Security=True;";

            string disciplina = textBoxDisciplina.Text;
            SqlDataAdapter sdaAdmini = new SqlDataAdapter($"SELECT NumarMatricol, Nume, Prenume, InitialaTatalui, '{disciplina}' AS Disciplina FROM Note", connectionString);
            DataTable dt1 = new DataTable();
            sdaAdmini.Fill(dt1);
            // Bind the DataTable to the DataGridView
            // dataGridNote.DataSource = dt1;
            comboBox1.Items.Add("AIA");
            comboBox1.Items.Add("TI");
            comboBox1.SelectedIndex = 0; // Set AIA as the default selection

            comboBox2.Items.Add("I");
            comboBox2.Items.Add("II");
            comboBox2.Items.Add("III");
            comboBox2.Items.Add("IV");
            comboBox2.SelectedIndex = 0; // Set the default selection

            // Handle the selection change event of comboBox1
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ANDREI\\SQLEXPRESS;Initial Catalog=Note;Integrated Security=True;";

            // Retrieve data from the "Note" table
            string disciplina = textBoxDisciplina.Text;
            SqlDataAdapter sdaAdmini = new SqlDataAdapter($"SELECT NumarMatricol, Nume, Prenume, InitialaTatalui, '{disciplina}' AS Disciplina FROM Note", connectionString);
            DataTable dt1 = new DataTable();
            sdaAdmini.Fill(dt1);

            // Set the name of the last column to the value from textBoxDisciplina
            dt1.Columns[dt1.Columns.Count - 1].ColumnName = disciplina;

            // Retrieve data from the "studenti" table based on selected specialization
            string specialization = comboBox1.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(specialization))
            {
                //string connectionString2 = "Data Source=ANDREI\\SQLEXPRESS;Initial Catalog=Note   ;Integrated Security=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = $"SELECT NumarMatricol, Nume, Prenume, InitialaTatalui, {disciplina} FROM Note WHERE Specializare = @Specialization";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Specialization", specialization);

                        try
                        {
                            connection.Open();
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // Bind the DataTable to the DataGridView or perform any other operations with the retrieved data
                            dataGridNote.DataSource = dt;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a specialization.");
            }
        }

        private void buttonStergeNota_Click(object sender, EventArgs e)
        {
            // Verificăm dacă a fost selectată o înregistrare în tabel
            if (dataGridNote.SelectedRows.Count > 0)
            {
                // Obținem valoarea NumarMatricol din înregistrarea selectată
                string numarMatricol = dataGridNote.SelectedRows[0].Cells["NumarMatricol"].Value.ToString();

                // Confirmăm ștergerea notei
                DialogResult result = MessageBox.Show("Sigur doriți să ștergeți nota pentru NumarMatricol " + numarMatricol + "?", "Confirmare ștergere", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string connectionString = "Data Source=ANDREI\\SQLEXPRESS;Initial Catalog=Note;Integrated Security=True;";

                    // Ștergem valoarea notei pentru NumarMatricolul specificat din tabela Note
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = $"UPDATE Note SET {textBoxDisciplina.Text} = NULL WHERE NumarMatricol = @NumarMatricol";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@NumarMatricol", numarMatricol);

                            try
                            {
                                connection.Open();
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Nota a fost ștearsă din tabela Note.");

                                    // Reîncărcăm tabela cu datele actualizate
                                    ComboBox1_SelectedIndexChanged(sender, e);
                                }
                                else
                                {
                                    MessageBox.Show("Nu a fost găsită nicio înregistrare cu NumarMatricolul specificat.");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vă rugăm să selectați o înregistrare din tabel.");
            }
        }   


    }
}