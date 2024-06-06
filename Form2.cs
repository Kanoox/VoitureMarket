using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace Bibliotheque_cars
{
    public partial class Form2 : Form
    {
        // Chaîne de connexion à la base de données
        string connectionString = "server=localhost;port=3306;database=bibliotheque_cars;user=root;password=";
        public Form2()
        {
            InitializeComponent();

        }

        private void listBox_marque_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_marque.SelectedIndex != -1)
            {
                listBox_vehdispo.Items.Clear();
                carburantBox.Clear();
                anneeBox.Clear();
                transmissionBox.Clear();
                powerBox.Clear();
                label9.Text = string.Empty;

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT type FROM cars WHERE marque = @marque"; // Requête voulu
                    MySqlCommand command = new MySqlCommand(query, connection); // Création de la command pour simplifier l'éxécution
                    command.Parameters.AddWithValue("@marque", listBox_marque.SelectedItem);
                    MySqlDataReader reader = command.ExecuteReader();
                    listBox_type.Items.Clear();

                    while (reader.Read())
                    {
                        // Récupérer la valeur de la colonne
                        string valeurColonne = reader.GetString(0); // Supposons que la première colonne soit de type chaîne (string)

                        if (!ItemExists(valeurColonne, listBox_type)) // Si la donne n'existe pas
                        {
                            // Ajouter la valeur à la ListBox
                            listBox_type.Items.Add(valeurColonne);
                        }
                        else // Si l'element existe déjà ça fait rien, ça ne l'affiche pas.
                        {
                            //MessageBox.Show("Cet élément existe déjà dans la liste.");
                        }

                    }
                    connection.Close(); // Fermeture de la connexion
                }
            }

        }
        private void listBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox_type.SelectedIndex != -1)
            {
                listBox_vehdispo.Items.Clear();
                carburantBox.Clear();
                anneeBox.Clear();
                transmissionBox.Clear();
                powerBox.Clear();
                label9.Text = string.Empty;

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT model FROM cars WHERE type = @type"; // Requête voulu
                    MySqlCommand command = new MySqlCommand(query, connection); // Création de la command pour simplifier l'éxécution
                    command.Parameters.AddWithValue("@type", listBox_type.SelectedItem);

                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Récupérer la valeur de la colonne
                        string valeurColonne = reader.GetString(0); // Supposons que la première colonne soit de type chaîne (string)

                        // Ajouter la valeur à la ListBox
                        listBox_vehdispo.Items.Add(valeurColonne);
                    }
                    connection.Close(); // Fermeture de la connexion
                }
            }
        }

        private void button_affichermarque_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT marque FROM cars"; // Requête voulu
                    MySqlCommand command = new MySqlCommand(query, connection); // Création de la command pour simplifier l'éxécution

                    // Exécuter la commande INSERT
                    MySqlDataReader reader = command.ExecuteReader();

                    listBox_marque.Items.Clear();
                    while (reader.Read())
                    {
                        // Récupérer la valeur de la colonne
                        string valeurColonne = reader.GetString(0); // Supposons que la première colonne soit de type chaîne (string)

                        if (!ItemExists(valeurColonne, listBox_marque))
                        {
                            // Ajouter la valeur à la ListBox
                            listBox_marque.Items.Add(valeurColonne);
                        }
                        else // Si l'element existe déjà ça fait rien, ça ne l'affiche pas.
                        {
                            //MessageBox.Show("Cet élément existe déjà dans la liste.");
                        }
                    }

                    connection.Close(); // Fermeture de la connexion
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur de connexion à la base de données : " + ex.Message);
            }
        }

        private bool ItemExists(string item, ListBox listbox)
        {
            foreach (var existingItem in listbox.Items)
            {
                // Convertir l'élément en chaîne et comparer avec l'élément que vous souhaitez ajouter
                if (existingItem.ToString() == item)
                {
                    return true; // L'élément existe déjà
                }
            }
            return false; // L'élément n'existe pas encore
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void listBox_vehdispo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_vehdispo.SelectedIndex != -1)
            {
                label9.Text = string.Empty;

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT id, fuel, date, transmission, power from cars WHERE model = @model";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@model", listBox_vehdispo.SelectedItem);

                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        // Récupération des valeurs de la ligne actuelle
                        string fuel = reader["fuel"].ToString();
                        string anneeBox_data = reader["date"].ToString(); // Colonne 2
                        string transmissionBox_data = reader["transmission"].ToString(); // Colonne 3
                        string powerBox_data = reader["power"].ToString(); // Colonne 4

                        // Ajouter la valeur à la ListBox
                        carburantBox.Text = fuel;
                        anneeBox.Text = anneeBox_data;
                        transmissionBox.Text = transmissionBox_data;
                        powerBox.Text = powerBox_data;

                        label9.Text += " " + listBox_vehdispo.SelectedItem.ToString();
                    }

                }
            }
        }

        private void carburantBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void achat_button_Click(object sender, EventArgs e)
        {


            // Crée une instance de la nouvelle fenêtre
            FormAchat formAchat = new FormAchat();
            // Ouvre la nouvelle fenêtre
            formAchat.Show();

        }
    }
}
