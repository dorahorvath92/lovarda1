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
    public partial class lovasoktato : Form
    {
        public lovasoktato()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            oktatolomegtekintes oktatoranezlovakra = new oktatolomegtekintes();
            oktatoranezlovakra.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oraidopontok oratervezes = new oraidopontok();
            oratervezes.ShowDialog();
        }

        private void lovasoktato_Load(object sender, EventArgs e)
        {

        }
    }
}
