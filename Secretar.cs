using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Security.Policy;
using System.Net.NetworkInformation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Proiect_v2
{
    public partial class Secretar : Form
    {
        string selectedSpecializare = "AIA";
        string prefix = "4LF4";
        public Secretar()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)//insert
        {

        }



        private void btnInsert_Click(object sender, EventArgs e)
        {
            // Create a custom form for the pop-up
            Form popupForm = new Form();
            popupForm.Text = "Student";
            popupForm.StartPosition = FormStartPosition.CenterScreen;
            popupForm.Width = 400;
            popupForm.Height = 370;
            Label lblNrM = new Label();
            lblNrM.Text = "Nr matricol:";
            lblNrM.Location = new Point(10, 10);

            TextBox txtNrM = new TextBox();
            txtNrM.Location = new Point(120, 10);
            // Create labels and textboxes for name, username, and password
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

            Label lblInT = new Label();
            lblInT.Text = "Init tata:";
            lblInT.Location = new Point(10, 100);

            TextBox txtInT = new TextBox();
            txtInT.Location = new Point(120, 100);

            Label lblCNP = new Label();
            lblCNP.Text = "CNP:";
            lblCNP.Location = new Point(10, 130);

            TextBox txtCNP = new TextBox();
            txtCNP.Location = new Point(120, 130);

            Label lblData = new Label();
            lblData.Text = "Data insc:";
            lblData.Location = new Point(10, 160);

            DateTimePicker data = new DateTimePicker();
            data.Location = new Point(120, 160);

            Label lblCicluInv = new Label();
            lblCicluInv.Text = "Ciclu inv:";
            lblCicluInv.Location = new Point(10, 190);

            TextBox txtCicluInv = new TextBox();
            txtCicluInv.Location = new Point(120, 190);

            Label lblMedia = new Label();
            lblMedia.Text = "Media:";
            lblMedia.Location = new Point(10, 220);

            TextBox txtMedia = new TextBox();
            txtMedia.Location = new Point(120, 220);


            Label lblSpecializare = new Label();
            lblSpecializare.Text = "Specializare:";
            lblSpecializare.Location = new Point(10, 250);

            TextBox txtSpecializare = new TextBox();
            txtSpecializare.Location = new Point(120, 250);

            // Create an OK button
            Button btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(120, 280);
            btnOK.Height = 30;





            // Add controls to the form
            popupForm.Controls.Add(lblNrM);
            popupForm.Controls.Add(txtNrM);
            popupForm.Controls.Add(lblNume);
            popupForm.Controls.Add(txtNume);
            popupForm.Controls.Add(lblPrenume);
            popupForm.Controls.Add(txtPrenume);
            popupForm.Controls.Add(lblInT);
            popupForm.Controls.Add(txtInT);
            popupForm.Controls.Add(lblCNP);
            popupForm.Controls.Add(txtCNP);
            popupForm.Controls.Add(btnOK);
            popupForm.Controls.Add(lblData);
            popupForm.Controls.Add(data);
            popupForm.Controls.Add(lblCicluInv);
            popupForm.Controls.Add(txtCicluInv);
            popupForm.Controls.Add(lblMedia);
            popupForm.Controls.Add(txtMedia);
            popupForm.Controls.Add(lblSpecializare);
            popupForm.Controls.Add(txtSpecializare);
            //popupForm.Controls.Add(btnOK1);

            // Show the pop-up form as a dialog
            DialogResult result = popupForm.ShowDialog();


            if (result == DialogResult.OK)
            {
                // Access the entered values
                string NM = txtNrM.Text;
                string Nume = txtNume.Text;
                string Prenume = txtPrenume.Text;
                string Initiala_tatalui = txtInT.Text;
                string CNP = txtCNP.Text;
                string Data = data.Value.ToString("yyyy-MM-dd"); // Formatul dorit, ex. "2023-06-13"
                string Ciclu_de_inv = txtCicluInv.Text;
                string Media = txtMedia.Text;
                string Specializare = txtSpecializare.Text;

                // Restul codului rămâne neschimbat
                // ...

                // Create the SQL query with parameter placeholders
                string query = "INSERT INTO Studenti (NumarMatricol,Nume, Prenume,InitialaTatalui,CNP,DataInscriere,CicluInvatamant, Medie, Specializare)" +
                                " VALUES (@NM, @Nume, @Prenume, @IT, @CNP, @Data, @CicluInv, @Media, @Specializare)";

                string connectionString = "Data Source=ANDREI\\SQLEXPRESS;Initial Catalog=StudentiAutomatica;Integrated Security=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameter values to the command
                        command.Parameters.AddWithValue("@NM", NM);
                        command.Parameters.AddWithValue("@Nume", Nume);
                        command.Parameters.AddWithValue("@Prenume", Prenume);
                        command.Parameters.AddWithValue("@IT", Initiala_tatalui);
                        command.Parameters.AddWithValue("@CNP", CNP);
                        command.Parameters.AddWithValue("@Data", DateTime.ParseExact(Data, "yyyy-MM-dd", CultureInfo.InvariantCulture)); // Convertim stringul Data la tipul DateTime
                        command.Parameters.AddWithValue("@CicluInv", Ciclu_de_inv);
                        command.Parameters.AddWithValue("@Media", Media);
                        command.Parameters.AddWithValue("@Specializare", Specializare);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Data inserted successfully!");
                            SqlConnection con = new SqlConnection("Data Source=ANDREI\\SQLEXPRESS;Initial Catalog=StudentiAutomatica;Integrated Security=True;");
                            SqlDataAdapter sdaStudenti = new SqlDataAdapter(@"SELECT * FROM Studenti", con);
                            DataTable dt1 = new DataTable();
                            sdaStudenti.Fill(dt1);
                            dataGridStudenti.DataSource = dt1;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }



                    }
                }
            }
        }

        

        private void btnStergere_Click(object sender, EventArgs e)
        {
            if (dataGridStudenti.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridStudenti.SelectedRows[0].Index;
                int StudentNM = Convert.ToInt32(dataGridStudenti.Rows[selectedRowIndex].Cells["NumarMatricol"].Value);

                string connectionString = "Data Source=ANDREI\\SQLEXPRESS;Initial Catalog=StudentiAutomatica;Integrated Security=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Studenti WHERE NumarMatricol = @StudentNM";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentNM", StudentNM);

                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Studentul a fost șters cu succes!");
                                // Reîncarcă datele în DataGridView pentru a reflecta modificările
                                SqlDataAdapter sdaStudenti = new SqlDataAdapter(@"SELECT * FROM Studenti", connection);
                                DataTable dtStudenti = new DataTable();
                                sdaStudenti.Fill(dtStudenti);
                                dataGridStudenti.DataSource = dtStudenti;
                            }
                            else
                            {
                                MessageBox.Show("Nu s-a putut șterge studentul.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Eroare: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Selectați un administrator pentru a-l șterge.");
            }
        }

        private void btnGeneratGrupe_Click(object sender, EventArgs e)
        {



            int numarGrupe = Convert.ToInt32(txtNrGrupe.Text);
            int left = 10;
            int top = 130;
            int width = 600;
            int height = 200;
            int margin = 10;

            string connectionString = "Data Source=ANDREI\\SQLEXPRESS;Initial Catalog=StudentiAutomatica;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Copy data from Studenti to StudentiOrdonati in descending order
                string copyQuery = $"INSERT INTO StudentiOrdonati SELECT * FROM Studenti WHERE Specializare = '{selectedSpecializare}' ORDER BY Medie DESC";
                using (SqlCommand copyCommand = new SqlCommand(copyQuery, connection))
                {
                    copyCommand.ExecuteNonQuery();
                }

                // Obține numărul de studenți din specializarea "AIA"
                string countQuery = $"SELECT COUNT(*) AS Total FROM StudentiOrdonati WHERE Specializare = '{selectedSpecializare}'";

                using (SqlCommand countCommand = new SqlCommand(countQuery, connection))
                {
                    int totalStudAIA = Convert.ToInt32(countCommand.ExecuteScalar());

                    int studentiPeGrupa = (int)Math.Ceiling((double)totalStudAIA / numarGrupe);
                    int grupaCurenta = 1;
                    //textBox1.Text = totalStudAIA.ToString() + selectedSpecializare;
                    int studentiProcesati = 0;

                    List<DataTable> grupe = new List<DataTable>();
                    for (int i = 0; i < numarGrupe; i++)
                    {
                        grupe.Add(new DataTable());
                    }

                    while (studentiProcesati < totalStudAIA)
                    {
                        for (int i = 0; i < numarGrupe && studentiProcesati < totalStudAIA; i++)
                        {
                            string query = $"SELECT TOP (1) Id, Specializare, Nume, Prenume, Medie, @Grupa AS Grupa FROM StudentiOrdonati WHERE Specializare = '{selectedSpecializare}' AND Id NOT IN " +
                                           "(SELECT Id FROM Grupe WHERE Grupa <= @Grupa) " +
                                           "ORDER BY Medie DESC";

                            using (SqlCommand selectCommand = new SqlCommand(query, connection))
                            {
                                selectCommand.Parameters.AddWithValue("@Grupa",prefix+( i + 1));

                                using (SqlDataReader reader = selectCommand.ExecuteReader())
                                {
                                    DataTable dtGrupa = grupe[i];
                                    dtGrupa.Load(reader);

                                    // Delete student from StudentiOrdonati table
                                    if (dtGrupa.Rows.Count > 0)
                                    {
                                        DataRow row = dtGrupa.Rows[dtGrupa.Rows.Count - 1];
                                        string deleteQuery = "DELETE FROM StudentiOrdonati WHERE Id=@Id";
                                        using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                                        {
                                            deleteCommand.Parameters.AddWithValue("@Id", row["Id"]);
                                            deleteCommand.ExecuteNonQuery();
                                        }
                                    }
                                }
                            }

                            studentiProcesati++;
                        }
                    }

                    for (int i = 0; i < grupe.Count; i++)
                    {
                        DataTable dtGrupa = grupe[i];
                        if (dtGrupa.Rows.Count > 0)
                        {
                            DataGridView dataGridGrupa = new DataGridView();
                            dataGridGrupa.Left = left;
                            dataGridGrupa.Top = top;
                            dataGridGrupa.Width = width;
                            dataGridGrupa.Height = height;
                            dataGridGrupa.DataSource = dtGrupa;

                            this.Controls.Add(dataGridGrupa);

                            // Adaugă un label sub controlul DataGridView
                            Label labelGrupa = new Label();
                            labelGrupa.Text = prefix + (i + 1);
                            labelGrupa.Left = left;
                            labelGrupa.Top = top + height + 5;
                            labelGrupa.AutoSize = true;

                            this.Controls.Add(labelGrupa);

                            top += height + margin + labelGrupa.Height + 5;
                        }
                    }
                }
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM StudentiOrdonati";

                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                {
                    deleteCommand.ExecuteNonQuery();
                }
            }
        }

        

        private void radioBtnAIA_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnTI.Checked)
            {
                selectedSpecializare = "AIA";
                prefix = "4LF4";
            }
        }

        private void radioBtnTI_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnTI.Checked)
            {
                selectedSpecializare = "TI";
                prefix = "4LF3";
            }
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Close(); // Închide formularul curent
            Home Form1 = new Home();
            Form1.Show(); // Deschide Form1
        }

        private void Secretar_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ANDREI\\SQLEXPRESS;Initial Catalog=StudentiAutomatica;Integrated Security=True;");
            SqlDataAdapter sdaStudenti = new SqlDataAdapter(@"SELECT * FROM Studenti", con);
            DataTable dt1 = new DataTable();
            sdaStudenti.Fill(dt1);
            dataGridStudenti.DataSource = dt1;
        }

        private void btnExport(object sender, EventArgs e)
        {
            // Obținem conținutul din tabela "Note"
            DataTable dataTable = GetNoteData();

            // Verificăm dacă există date de exportat
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                // Afișăm dialogul de salvare fișier
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Fișier CSV|*.csv";
                saveFileDialog.Title = "Exportare în fișier CSV";
                saveFileDialog.FileName = "export_note.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Creăm fișierul CSV și scriem datele în el
                        using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName))
                        {
                            // Scriem antetul coloanelor
                            string headerLine = string.Join(",", dataTable.Columns.Cast<DataColumn>().Select(column => column.ColumnName));
                            streamWriter.WriteLine(headerLine);

                            // Scriem datele în fișier
                            foreach (DataRow row in dataTable.Rows)
                            {
                                string dataLine = string.Join(",", row.ItemArray.Select(field => field.ToString()));
                                streamWriter.WriteLine(dataLine);
                            }

                            // Mesaj de exportare cu succes
                            MessageBox.Show("Datele au fost exportate cu succes în fișierul CSV.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("A apărut o eroare la exportarea datelor: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nu există date de exportat.");
            }
        }

        private DataTable GetNoteData()
        {
            DataTable dataTable = new DataTable();

            string connectionString = "Data Source=ANDREI\\SQLEXPRESS;Initial Catalog=Note;Integrated Security=True;";

            // Selectăm toate coloanele din tabela "Note"
            string query = "SELECT * FROM Note";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // Creaăm un adaptor de date și populăm tabela
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        dataAdapter.Fill(dataTable);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("A apărut o eroare la preluarea datelor: " + ex.Message);
                    }
                }
            }

            return dataTable;
        }
    }
  }


