using System.Data.SqlClient;
using System.Data;
namespace Proiect_v2
{
    public partial class Home : Form
    {


        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            Admin Back = new Admin();
            this.Hide();
            Back.Show();


        }

        private void buttonSecretar_Click(object sender, EventArgs e)
        {
            Secretar Back = new Secretar();
            this.Hide();
            Back.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtParola.Text;

            if (radiobtnAdmin.Checked)
            {
                // Accesați baza de date pentru administratori și verificați autentificarea
                string connectionString = "Data Source=ANDREI\\SQLEXPRESS;Initial Catalog=Administratie;Integrated Security=True;";
                string query = "SELECT COUNT(*) FROM Administratori WHERE username = @Username AND parola = @Password";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        try
                        {
                            connection.Open();
                            int result = (int)command.ExecuteScalar();
                            if (result > 0)
                            {
                                // Autentificare reușită pentru administrator
                                //  MessageBox.Show("Autentificare reușită pentru administrator");

                                // Verifică dacă există înregistrări cu aceleasi date in baza de date
                                string checkQuery = "SELECT COUNT(*) FROM Administratori WHERE username = @Username AND parola = @Password";
                                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                                {
                                    checkCommand.Parameters.AddWithValue("@Username", username);
                                    checkCommand.Parameters.AddWithValue("@Password", password);

                                    /*  int checkResult = (int)checkCommand.ExecuteScalar();
                                      if (checkResult > 0)
                                      {
                                          // Datele introduse se găsesc în baza de date
                                          MessageBox.Show("Datele introduse se găsesc în baza de date");
                                      }
                                      else
                                      {
                                          // Datele introduse nu se găsesc în baza de date
                                          MessageBox.Show("Datele introduse nu se găsesc în baza de date");
                                      }
                                    */
                                }
                                Admin Back = new Admin();
                                this.Hide();
                                Back.Show();
                                // Aici puteți adăuga cod pentru a deschide formularul corespunzător administratorului
                            }
                            else
                            {
                                MessageBox.Show("Autentificare eșuată pentru administrator");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Eroare: " + ex.Message);
                        }
                    }
                }
            }

            else if (radioBtnSecretar.Checked)
            {

                // Accesați baza de date pentru administratori și verificați autentificarea
                string connectionString = "Data Source=ANDREI\\SQLEXPRESS;Initial Catalog=Administratie;Integrated Security=True;";
                string query = "SELECT COUNT(*) FROM Secretari WHERE username = @Username AND parola = @Password";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        try
                        {
                            connection.Open();
                            int result = (int)command.ExecuteScalar();
                            if (result > 0)
                            {
                                // Autentificare reușită pentru administrator
                                //  MessageBox.Show("Autentificare reușită pentru administrator");

                                // Verifică dacă există înregistrări cu aceleasi date in baza de date
                                string checkQuery = "SELECT COUNT(*) FROM Secretari WHERE username = @Username AND parola = @Password";
                                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                                {
                                    checkCommand.Parameters.AddWithValue("@Username", username);
                                    checkCommand.Parameters.AddWithValue("@Password", password);

                                    /*  int checkResult = (int)checkCommand.ExecuteScalar();
                                      if (checkResult > 0)
                                      {
                                          // Datele introduse se găsesc în baza de date
                                          MessageBox.Show("Datele introduse se găsesc în baza de date");
                                      }
                                      else
                                      {
                                          // Datele introduse nu se găsesc în baza de date
                                          MessageBox.Show("Datele introduse nu se găsesc în baza de date");
                                      }
                                    */
                                }
                                Secretar Back = new Secretar();
                                this.Hide();
                                Back.Show();
                                // Aici puteți adăuga cod pentru a deschide formularul corespunzător administratorului
                            }
                            else
                            {
                                MessageBox.Show("Autentificare eșuată pentru administrator");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Eroare: " + ex.Message);
                        }
                    }

                }
            }

            else if (radioBtnProfesor.Checked)
            {
                // Access the database for administrators and check authentication
                string connectionString = "Data Source=ANDREI\\SQLEXPRESS;Initial Catalog=Administratie;Integrated Security=True;";
                string query = "SELECT COUNT(*) FROM Profesori WHERE username = @Username AND parola = @Password";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        try
                        {
                            connection.Open();
                            int result = (int)command.ExecuteScalar();
                            if (result > 0)
                            {
                                // Authentication successful for administrator
                                // MessageBox.Show("Authentication successful for administrator");

                                // Check if there are records with the same data in the database
                                string checkQuery = "SELECT COUNT(*) FROM Profesori WHERE username = @Username AND parola = @Password";
                                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                                {
                                    checkCommand.Parameters.AddWithValue("@Username", username);
                                    checkCommand.Parameters.AddWithValue("@Password", password);

                                    // Execute the check command
                                    int checkResult = (int)checkCommand.ExecuteScalar();

                                    // Save the subject in the textBoxDisciplina field
                                    if (checkResult > 0)
                                    {
                                        // Get the subject from the database (assuming it is stored in a field called "Materia")
                                        string materiaQuery = "SELECT Materie FROM Profesori WHERE username = @Username";
                                        using (SqlCommand materiaCommand = new SqlCommand(materiaQuery, connection))
                                        {
                                            materiaCommand.Parameters.AddWithValue("@Username", username);

                                            // Execute the command to get the subject
                                            string materia = materiaCommand.ExecuteScalar().ToString();

                                            // Hide the login form
                                            this.Hide();

                                            // Show the Professor form and set the subject in the text box
                                            Profesor Back = new Profesor();
                                            Back.TextBoxDisciplina.Text = materia;
                                            Back.Show();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Authentication failed for administrator");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Authentication failed for professor");
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



        private void buttonProfesor_Click_1(object sender, EventArgs e)
        {
            Profesor Back = new Profesor();
            this.Hide();
            Back.Show();
        }

    }
}