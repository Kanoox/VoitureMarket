using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bibliotheque_cars
{
    public partial class FormAchat : Form
    {
        private int vehicleId;
        string connectionString = "server=localhost;port=3306;database=bibliotheque_cars;user=root;password=";

        public FormAchat()
        {
            InitializeComponent();
        }

        private void FormAchat_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT id_client, nom, prenom FROM client"; // Requête voulu
                MySqlCommand command = new MySqlCommand(query, connection); // Création de la command pour simplifier l'éxécution
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Récupérer la valeur de la colonne
                    int id = reader.GetInt32("id_client");
                    string nom = reader.GetString("nom"); // Supposons que la première colonne soit de type chaîne (string)
                    string prenom = reader.GetString("prenom"); // Supposons que la première colonne soit de type chaîne (string)

                    // Ajouter la valeur à la ListBox
                    listBox1.Items.Add(id + " " + nom + " " + prenom);
                }



                connection.Close(); // Fermeture de la connexion

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT id, model FROM cars"; // Requête voulu
                MySqlCommand command = new MySqlCommand(query, connection); // Création de la command pour simplifier l'éxécution
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //textBox2
                }

                connection.Close(); // Fermeture de la connexion

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT id, model FROM cars"; // Requête voulu
                MySqlCommand command = new MySqlCommand(query, connection); // Création de la command pour simplifier l'éxécution
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //textBox2
                }

                connection.Close(); // Fermeture de la connexion

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}