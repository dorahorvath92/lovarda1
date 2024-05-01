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

namespace lovarda1
{
    public partial class boxkezeles : Form
    {
        private Dictionary<int, bool> stallReservationStatus = new Dictionary<int, bool>();
        private SqlConnection sqlConnection;
        private const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\login.mdf;Integrated Security=True;Connect Timeout=30";
        public boxkezeles()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadStallsFromDatabase();
        }
        private void InitializeDatabaseConnection()
        {
            sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to the database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        // Load stall data from the database and create stall buttons
        private void LoadStallsFromDatabase()
        {
            string query = "SELECT szam, foglalt FROM boxok";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int szam = reader.GetInt32(0);
                bool foglalt = reader.GetBoolean(1);

                // Store reservation status in dictionary
                stallReservationStatus.Add(szam, foglalt);

                // Update button properties based on reservation status
                Button button = (Button)this.Controls["button" + szam];
                if (button != null)
                {
                    button.BackColor = foglalt ? Color.Red : Color.Green;
                }
            }

            reader.Close();
        }

        private void DeleteReservation(int szam)
        {
            string query = "UPDATE boxok SET foglalt = 0 WHERE szam = @szam";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@szam", szam);
            command.ExecuteNonQuery();

            stallReservationStatus[szam] = false;
        }

        // Event handler for stall button clicks
        private void stallButton_Click(object sender, EventArgs e)
        {
            {
                Button clickedButton = (Button)sender;

                // Get the stall ID from the button's name
                int szam = int.Parse(clickedButton.Name.Replace("button", ""));

                // Check if the stall is currently reserved
                bool foglalt = IsStallReserved(szam);

                if (!foglalt)
                {
                    // Stall is free, ask the user if they want to reserve it
                    DialogResult result = MessageBox.Show("Le akarja foglalni a boxot?", "Stall Reservation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Update button color and database reservation status
                        clickedButton.BackColor = Color.Red;
                        ReserveStall(szam);

                        MessageBox.Show("Box sikeresen lefoglalva.", "Sikeres foglalás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    // If the user clicks "No" or closes the message box, do nothing
                }
                else
                {
                    // Stall is already reserved, ask if the user wants to delete the reservation
                    DialogResult deleteResult = MessageBox.Show("Ez a box már foglalt. Szeretné törölni a foglalást?", "Foglalt box", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (deleteResult == DialogResult.Yes)
                    {
                        // Delete the reservation
                        clickedButton.BackColor = Color.Green; // Change button color back to green
                        DeleteReservation(szam); // Update database to mark stall as not reserved
                    }
                    // If the user clicks "No" or closes the message box, do nothing
                }
            }
        }

        // Check if the stall is reserved
        private bool IsStallReserved(int szam)
        {
            {
                if (stallReservationStatus.ContainsKey(szam))
                {
                    return stallReservationStatus[szam];
                }
                else
                {
                    // Stall not found in dictionary, assuming it's not reserved
                    return false;
                }
            }
        }

        // Reserve the stall
        private void ReserveStall(int szam)
        {
            string query = "UPDATE boxok SET foglalt = 1 WHERE szam = @szam";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@szam", szam);
            command.ExecuteNonQuery();
        }

        private void boxkezeles_Load(object sender, EventArgs e)
        {

        }
    }
}
