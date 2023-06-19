
using System.Data;

using System.Data.SqlClient;

namespace Proiect_v2
{
    public partial class Admin : Form
    {


        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ANDREI\\SQLEXPRESS;Initial Catalog=Administratie;Integrated Security=True;");
            SqlDataAdapter sdaAdmini = new SqlDataAdapter(@"SELECT * FROM Administratori", con);
            DataTable dt1 = new DataTable();
            sdaAdmini.Fill(dt1);
            dataGridAdmini.DataSource = dt1;
            //pentru secretari
            SqlDataAdapter sdaSecretari = new SqlDataAdapter(@"SELECT * FROM Secretari", con);
            DataTable dt2 = new DataTable();
            sdaSecretari.Fill(dt2);
            dataGridSecretari.DataSource = dt2;
            //pentru profesori
            SqlDataAdapter sdaProfesori = new SqlDataAdapter(@"SELECT * FROM Profesori", con);
            DataTable dt3 = new DataTable();
            sdaProfesori.Fill(dt3);
            dataGridProfesori.DataSource = dt3;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//--------------------------------------bnt insert Admini
        {
            // Create a custom form for the pop-up
            Form popupForm = new Form();
            popupForm.Text = "Admini";
            popupForm.StartPosition = FormStartPosition.CenterScreen;
            // Create labels and textboxes for name, username, and password
            Label lblName = new Label();
            lblName.Text = "Nume:";
            lblName.Location = new Point(10, 10);

            TextBox txtName = new TextBox();
            txtName.Location = new Point(120, 10);

            Label lblUsername = new Label();
            lblUsername.Text = "Username:";
            lblUsername.Location = new Point(10, 40);

            TextBox txtUsername = new TextBox();
            txtUsername.Location = new Point(120, 40);

            Label lblPassword = new Label();
            lblPassword.Text = "Parola:";
            lblPassword.Location = new Point(10, 70);

            TextBox txtPassword = new TextBox();
            txtPassword.Location = new Point(120, 70);
            txtPassword.PasswordChar = '*';

            // Create an OK button
            Button btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(120, 120);
            btnOK.Height = 30;

            //Create an Cancel button
            /*Button btnOK1 = new Button();
            btnOK1.Text = "Cancel";
            btnOK1.DialogResult = DialogResult.Cancel;
            btnOK1.Location = new Point(190, 190);
            btnOK1.Height = 30;*/



            // Add controls to the form
            popupForm.Controls.Add(lblName);
            popupForm.Controls.Add(txtName);
            popupForm.Controls.Add(lblUsername);
            popupForm.Controls.Add(txtUsername);
            popupForm.Controls.Add(lblPassword);
            popupForm.Controls.Add(txtPassword);
            popupForm.Controls.Add(btnOK);
            //popupForm.Controls.Add(btnOK1);

            // Show the pop-up form as a dialog
            DialogResult result = popupForm.ShowDialog();
            /*if (result == DialogResult.Cancel)
                popupForm.Close();*/
            if (string.IsNullOrEmpty(txtName.Text)
           || string.IsNullOrEmpty(txtUsername.Text)
           || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Completati toate campurile.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else


                // Process the result

                if (result == DialogResult.OK)
            {
                // Access the entered values
                string name = txtName.Text;
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                // Conexiune cu baza de date

                string connectionString = "Data Source=ANDREI\\SQLEXPRESS;Initial Catalog=Administratie;Integrated Security=True;";

                // Create the SQL query with parameter placeholders
                string query = "INSERT INTO Administratori (Nume, Username, Parola) VALUES (@Nume, @Username, @Parola)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameter values to the command
                        command.Parameters.AddWithValue("@Nume", name);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Parola", password);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Data inserted successfully!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }

                //segmentul asta face pull de date din baza de date 
                SqlConnection con = new SqlConnection("Data Source=ANDREI\\SQLEXPRESS;Initial Catalog=Administratie;Integrated Security=True;");
                SqlDataAdapter sdaAdmini = new SqlDataAdapter(@"SELECT * FROM Administratori", con);
                DataTable dt1 = new DataTable();
                sdaAdmini.Fill(dt1);
                dataGridAdmini.DataSource = dt1;
                MessageBox.Show("Admin inregistrat");
            }


        }

        private void button2_Click(object sender, EventArgs e)//--------------------------------btn secretari
        {
            // Create a custom form for the pop-up
            Form popupForm = new Form();
            popupForm.Text = "Secretar";
            popupForm.StartPosition = FormStartPosition.CenterScreen;
            // Create labels and textboxes for name, username, and password
            Label lblName = new Label();
            lblName.Text = "Nume:";
            lblName.Location = new Point(10, 10);

            TextBox txtName = new TextBox();
            txtName.Location = new Point(120, 10);

            Label lblUsername = new Label();
            lblUsername.Text = "Username:";
            lblUsername.Location = new Point(10, 40);

            TextBox txtUsername = new TextBox();
            txtUsername.Location = new Point(120, 40);

            Label lblPassword = new Label();
            lblPassword.Text = "Parola:";
            lblPassword.Location = new Point(10, 70);

            TextBox txtPassword = new TextBox();
            txtPassword.Location = new Point(120, 70);
            txtPassword.PasswordChar = '*';

            // Create an OK button
            Button btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(120, 120);
            btnOK.Height = 30;

            //Create an Cancel button
            /*Button btnOK1 = new Button();
            btnOK1.Text = "Cancel";
            btnOK1.DialogResult = DialogResult.Cancel;
            btnOK1.Location = new Point(190, 190);
            btnOK1.Height = 30;*/



            // Add controls to the form
            popupForm.Controls.Add(lblName);
            popupForm.Controls.Add(txtName);
            popupForm.Controls.Add(lblUsername);
            popupForm.Controls.Add(txtUsername);
            popupForm.Controls.Add(lblPassword);
            popupForm.Controls.Add(txtPassword);
            popupForm.Controls.Add(btnOK);
            //popupForm.Controls.Add(btnOK1);

            // Show the pop-up form as a dialog
            DialogResult result = popupForm.ShowDialog();
            /*if (result == DialogResult.Cancel)
                popupForm.Close();*/
            if (string.IsNullOrEmpty(txtName.Text)
           || string.IsNullOrEmpty(txtUsername.Text)
           || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Completati toate campurile.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else


            // Process the result
            if (result == DialogResult.OK)
            {
                // Access the entered values
                string name = txtName.Text;
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string connectionString = "Data Source=ANDREI\\SQLEXPRESS;Initial Catalog=Administratie;Integrated Security=True;";

                // Create the SQL query with parameter placeholders
                string query = "INSERT INTO Secretari (Nume, Username, Parola) VALUES (@Nume, @Username, @Parola)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameter values to the command
                        command.Parameters.AddWithValue("@Nume", name);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Parola", password);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Data inserted successfully!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }

                //segmentul asta face pull de date din baza de date 
                SqlConnection con = new SqlConnection("Data Source=ANDREI\\SQLEXPRESS;Initial Catalog=Administratie;Integrated Security=True;");
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM Secretari", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridSecretari.DataSource = dt;


                // Do something with the entered values
                MessageBox.Show("Secretar inregistrat");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Create a custom form for the pop-up
            Form popupForm = new Form();
            popupForm.Text = "Profesori";
            popupForm.StartPosition = FormStartPosition.CenterScreen;
            // Create labels and textboxes for name, username, and password
            Label lblName = new Label();
            lblName.Text = "Nume:";
            lblName.Location = new Point(10, 10);

            TextBox txtName = new TextBox();
            txtName.Location = new Point(120, 10);

            Label lblUsername = new Label();
            lblUsername.Text = "Username:";
            lblUsername.Location = new Point(10, 40);

            TextBox txtUsername = new TextBox();
            txtUsername.Location = new Point(120, 40);

            Label lblPassword = new Label();
            lblPassword.Text = "Parola:";
            lblPassword.Location = new Point(10, 70);

            TextBox txtPassword = new TextBox();
            txtPassword.Location = new Point(120, 70);
            txtPassword.PasswordChar = '*';

            // Create an OK button
            Button btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(120, 120);
            btnOK.Height = 30;

            //Create an Cancel button
            /*Button btnOK1 = new Button();
            btnOK1.Text = "Cancel";
            btnOK1.DialogResult = DialogResult.Cancel;
            btnOK1.Location = new Point(190, 190);
            btnOK1.Height = 30;*/



            // Add controls to the form
            popupForm.Controls.Add(lblName);
            popupForm.Controls.Add(txtName);
            popupForm.Controls.Add(lblUsername);
            popupForm.Controls.Add(txtUsername);
            popupForm.Controls.Add(lblPassword);
            popupForm.Controls.Add(txtPassword);
            popupForm.Controls.Add(btnOK);
            //popupForm.Controls.Add(btnOK1);

            // Show the pop-up form as a dialog
            DialogResult result = popupForm.ShowDialog();
            /*if (result == DialogResult.Cancel)
                popupForm.Close();*/
            if (string.IsNullOrEmpty(txtName.Text)
           || string.IsNullOrEmpty(txtUsername.Text)
           || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Completati toate campurile.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else


            // Process the result
            if (result == DialogResult.OK)
            {
                // Access the entered values
                string name = txtName.Text;
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string connectionString = "Data Source=ANDREI\\SQLEXPRESS;Initial Catalog=Administratie;Integrated Security=True;";

                // Create the SQL query with parameter placeholders
                string query = "INSERT INTO Profesori (Nume, Username, Parola) VALUES (@Nume, @Username, @Parola)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameter values to the command
                        command.Parameters.AddWithValue("@Nume", name);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Parola", password);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Data inserted successfully!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }

                //segmentul asta face pull de date din baza de date 
                SqlConnection con = new SqlConnection("Data Source=ANDREI\\SQLEXPRESS;Initial Catalog=Administratie;Integrated Security=True;");
                SqlDataAdapter sdaProfesori = new SqlDataAdapter(@"SELECT * FROM Profesori", con);
                DataTable dt3 = new DataTable();
                sdaProfesori.Fill(dt3);
                dataGridProfesori.DataSource = dt3;
                MessageBox.Show("Profesor inregistrat");

            }
        }

        private void deleteAdmin_Click(object sender, EventArgs e)
        {
            if (dataGridAdmini.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridAdmini.SelectedRows[0].Index;
                int adminId = Convert.ToInt32(dataGridAdmini.Rows[selectedRowIndex].Cells["ID"].Value);

                string connectionString = "Data Source=ANDREI\\SQLEXPRESS;Initial Catalog=Administratie;Integrated Security=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Administratori WHERE ID = @AdminId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AdminId", adminId);

                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Administratorul a fost șters cu succes!");
                                // Reîncarcă datele în DataGridView pentru a reflecta modificările
                                SqlDataAdapter sdaAdmini = new SqlDataAdapter(@"SELECT * FROM Administratori", connection);
                                DataTable dtAdmini = new DataTable();
                                sdaAdmini.Fill(dtAdmini);
                                dataGridAdmini.DataSource = dtAdmini;
                            }
                            else
                            {
                                MessageBox.Show("Nu s-a putut șterge administratorul.");
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

        private void deleteSecretar_Click(object sender, EventArgs e)
        {
            if (dataGridSecretari.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridSecretari.SelectedRows[0].Index;
                int secretarId = Convert.ToInt32(dataGridSecretari.Rows[selectedRowIndex].Cells["ID"].Value);

                string connectionString = "Data Source=ANDREI\\SQLEXPRESS;Initial Catalog=Administratie;Integrated Security=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Secretari WHERE ID = @secretarId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@secretarId", secretarId);

                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Secretarul a fost șters cu succes!");
                                // Reîncarcă datele în DataGridView pentru a reflecta modificările
                                SqlDataAdapter sdaSecretari = new SqlDataAdapter(@"SELECT * FROM Secretari", connection);
                                DataTable dtSecretari = new DataTable();
                                sdaSecretari.Fill(dtSecretari);
                                dataGridSecretari.DataSource = dtSecretari;
                            }
                            else
                            {
                                MessageBox.Show("Nu s-a putut șterge secretarul.");
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
                MessageBox.Show("Selectați un secretar pentru a-l șterge.");
            }
        }

        private void deleteProfesor_Click(object sender, EventArgs e)//-----nu merge !!!!
        {
            if (dataGridProfesori.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridProfesori.SelectedRows[0].Index;
                int profesorId = Convert.ToInt32(dataGridProfesori.Rows[selectedRowIndex].Cells["ID"].Value);

                string connectionString = "Data Source=ANDREI\\SQLEXPRESS;Initial Catalog=Administratie;Integrated Security=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Profesori WHERE ID = @ProfesorId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProfesorId", profesorId);

                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Profesorul a fost șters cu succes!");
                                // Reîncarcă datele în DataGridView pentru a reflecta modificările
                                SqlDataAdapter sdaProfesori = new SqlDataAdapter(@"SELECT * FROM Profesori", connection);
                                DataTable dtProfesori = new DataTable();
                                sdaProfesori.Fill(dtProfesori);
                                dataGridProfesori.DataSource = dtProfesori;
                            }
                            else
                            {
                                MessageBox.Show("Nu s-a putut șterge profesorul.");
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
                MessageBox.Show("Selectați un profesor pentru a-l șterge.");
            }
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Close(); // Închide formularul curent
            Home Form1 = new Home();
            Form1.Show(); // Deschide Form1
        }

        
    }
}
