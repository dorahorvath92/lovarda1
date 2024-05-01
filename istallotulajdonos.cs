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
using System.Windows.Markup;

namespace lovarda1
{
    public partial class istallotulajdonos : Form
    {
        public istallotulajdonos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           boxkezeles boxfoglalas = new boxkezeles();
            boxfoglalas.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tulajdonos_lo_hozzaad tulajhozzaad= new tulajdonos_lo_hozzaad();
            tulajhozzaad.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            beosztaskeszites beosztas = new beosztaskeszites();
            beosztas.ShowDialog();
        }

        private void istallotulajdonos_Load(object sender, EventArgs e)
        {

        }
    }
}
