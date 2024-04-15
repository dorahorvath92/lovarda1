using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lovarda1
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void labe1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                MessageBox.Show("Sikertelen regisztráció! Nem töltötte ki a vezetéknév mezőt!");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Sikertelen regisztráció! Nem töltötte ki a keresztnév mezőt!");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Sikertelen regisztráció! Nem töltötte ki az e-mail cím mezőt!");
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("Sikertelen regisztráció! Nem adott meg felhasználónevet!");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Sikertelen regisztráció! Nem adott meg jelszót!");
            }
            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Sikertelen regisztráció! Nem választott szerepkört!");
            }
            else
            {
                MessageBox.Show("Sikeres regisztráció!");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = new DateTime(1920, 1, 1);
            dateTimePicker1.MaxDate = new DateTime(2010, 1, 1);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
   


}

