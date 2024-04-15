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
    public partial class oraidopontok : Form
    {
        public oraidopontok()
        {
            InitializeComponent();
        }

        private void oraidopontok_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Idopont", "Óra időpontja");
            dataGridView1.Columns.Add("Tipus", "Óra típusa");
            dataGridView1.Columns.Add("Szint", "Óra szintje");
            dataGridView1.Columns.Add("Helyszin", "Óra helyszíne");
            dataGridView1.Columns.Add("Oktatoneve", "Oktató neve");

            DataGridViewRow row1 = new DataGridViewRow();
            row1.CreateCells(dataGridView1);
            row1.Cells[0].Value = "2024-04-11 11:00";
            row1.Cells[1].Value = "Futószáras oktatás";
            row1.Cells[2].Value = "Középhaladó";
            row1.Cells[3].Value = "Kinti körkarám";
            row1.Cells[4].Value = "Nagy Péter";
            dataGridView1.Rows.Add(row1);

           
        }

        private void BtnTorles_Click(object sender, EventArgs e)
        {
            // Kiválasztott sor törlése a DataGridView-ból
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}