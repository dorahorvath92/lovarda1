using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lovarda1
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter sda;
        DataTable dt;
        SqlCommand cmd;



        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration registrationForm = new Registration();
            registrationForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Select * from loginadatok where felhasznalonev= '" + textBox3.Text + "' and jelszo= '" + textBox4.Text + "'", con);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            string cmbitemvalue = comboBox1.SelectedItem.ToString();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["szerepkor"].ToString() == cmbitemvalue)
                    {
                        MessageBox.Show("Beléptél " + dt.Rows[i]["szerepkor"] + "ként!");
                        if (comboBox1.SelectedIndex == 0)
                        {
                            lovasoktato lovaso = new lovasoktato();
                            this.Hide();
                            lovaso.Show();
                        }
                        else if (comboBox1.SelectedIndex == 1)
                        {
                            allatorvos orvos = new allatorvos();
                            this.Hide();
                            orvos.Show();
                        }
                        else if (comboBox1.SelectedIndex == 2)
                        {
                            lovasz istalloalkalmazott = new lovasz();
                            this.Hide();
                            istalloalkalmazott.Show();
                        }
                        else if (comboBox1.SelectedIndex == 3)
                        {
                            istallotulajdonos tulajdonos = new istallotulajdonos();
                            this.Hide();
                            tulajdonos.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Rossz a kiválasztott szerepkör!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Rossz felhasználónév vagy jelszó!");
            }
        }
    }
}
        
    

