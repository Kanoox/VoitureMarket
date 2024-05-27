using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bibliotheque_cars
{
    public partial class Form1 : Form
    {
        // Chaîne de connexion à la base de données
        string connectionString = "server=localhost;port=3306;database=bibliotheque_cars;user=florentin;password=Q6XHp!ilboECe!6.;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM users WHERE username = @username AND password = @password"; // Requête voulu
                    MySqlCommand command = new MySqlCommand(query, connection); // Création de la command pour simplifier l'éxécution
                    command.Parameters.AddWithValue("@username", username); // Ajout en paramètre des valeurs
                    command.Parameters.AddWithValue("@password", password); // Ajout en paramètre des valeurs

                    // Exécuter la commande INSERT
                    int rowsAffected = Convert.ToInt32(command.ExecuteScalar());

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Connexion réussi");

                        this.Hide();

                        Form2 form2 = new Form2();
                        form2.Show();
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de l'insertion des données.");
                    }

                    connection.Close(); // Fermeture de la connexion
                }
            }
            catch (Exception ex)
            {
                passwordBox.Text = "Erreur de connexion à la base de données : " + ex.Message;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
