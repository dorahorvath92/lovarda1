using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lovarda1
{
    public partial class addhorse : Form
    {
        private tulajdonos_lo_hozzaad tulajdonoslokezeles;

    public addhorse(tulajdonos_lo_hozzaad tulajdonoslokezeles)
        {
            InitializeComponent();
            this.tulajdonoslokezeles = tulajdonoslokezeles;
        }


        private void addhorse_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nev = textBox1.Text;
            int szuletesiev;
            if (!int.TryParse(textBox2.Text, out szuletesiev))
            {
                MessageBox.Show("Érvénytelen születési dátum. Kérem számot írjon be.");
                return;
            }
            string fajta = textBox3.Text;
            string nem = textBox4.Text;
            string versenyek = textBox5.Text;


            tulajdonoslokezeles.AddHorse(nev, szuletesiev, fajta, nem, versenyek);


            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            this.Close();
        }
    }
}
