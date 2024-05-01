using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lovarda1
{
    public partial class tulajdonos_lo_hozzaad : Form
    {
        private DataTable horseData;
        private string connectionString; // Store the connection string
        public tulajdonos_lo_hozzaad()
        {
            InitializeComponent();


            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\login.mdf;Integrated Security=True;Connect Timeout=30";

            horseData = new DataTable();
            horseData.Columns.Add("nev", typeof(string));
            horseData.Columns.Add("szuletesiev", typeof(int));
            horseData.Columns.Add("fajta", typeof(string));
            horseData.Columns.Add("nem", typeof(string));
            horseData.Columns.Add("versenyek", typeof(string));


            dataGridView1.DataSource = horseData;
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            addhorse add_horse = new addhorse(this);
            add_horse.ShowDialog();

        }

        public void AddHorse(string nev, int szuletesiev, string fajta, string nem, string versenyek)
        {
            DataRow newRow = horseData.NewRow();
            newRow["nev"] = nev;
            newRow["szuletesiev"] = szuletesiev;
            newRow["fajta"] = fajta;
            newRow["nem"] = nem;
            newRow["versenyek"] = versenyek;

            horseData.Rows.Add(newRow);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            // Loop through the DataTable rows to insert new horses
            foreach (DataRow row in horseData.Rows)
            {
                if (row.RowState == DataRowState.Added) // Check for newly added rows
                {
                    string nev = row["nev"].ToString();
                    int szuletesiev = (int)row["szuletesiev"];
                    string fajta = row["fajta"].ToString();
                    string nem = row["nem"].ToString();
                    string versenyek = row["versenyek"].ToString();

                    InsertHorseIntoDatabase(nev, szuletesiev, fajta, nem, versenyek);
                }
            }

            MessageBox.Show("A módosítások mentése sikeres!"); // Optional: Show confirmation message

        }

        private void InsertHorseIntoDatabase(string nev, int szuletesiev, string fajta, string nem, string versenyek)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO HorseData (nev, szuletesiev, fajta, nem, versenyek) VALUES (@nev, @szuletesiev, @fajta, @nem, @versenyek)";

                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nev", nev);
                    command.Parameters.AddWithValue("@szuletesiev", szuletesiev);
                    command.Parameters.AddWithValue("@fajta", fajta);
                    command.Parameters.AddWithValue("@nem", nem);
                    command.Parameters.AddWithValue("@versenyek", versenyek);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba a mentés során: " + ex.Message);
                }
            }
        }

        private void TestDatabaseConnection()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\login.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Connection to database successful!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tulajdonos_lo_hozzaad_Load(object sender, EventArgs e)
        {
            TestDatabaseConnection();
        }
    }
}
