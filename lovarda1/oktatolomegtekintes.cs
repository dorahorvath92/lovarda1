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
    public partial class oktatolomegtekintes : Form
    {
        public oktatolomegtekintes()
        {
            InitializeComponent();
        }

        private void oktatolomegtekintes_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Loneve", "Ló neve");
            dataGridView1.Columns.Add("Szuletesiev", "Születési év");
            dataGridView1.Columns.Add("Neme", "Neme");
            dataGridView1.Columns.Add("Fajta", "Fajta");
            dataGridView1.Columns.Add("Sportag", "Sportág");

            DataGridViewRow row1 = new DataGridViewRow();
            row1.CreateCells(dataGridView1);
            row1.Cells[0].Value = "Bella";
            row1.Cells[1].Value = "2014";
            row1.Cells[2].Value = "Kanca";
            row1.Cells[3].Value = "Lipicai";
            row1.Cells[4].Value = "Tereplovaglás";
            dataGridView1.Rows.Add(row1);
        }
    }
}
