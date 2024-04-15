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
    public partial class allatorvos : Form
    {
        public allatorvos()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vizsgalatidopontok vizsgalattervezes = new vizsgalatidopontok();
            vizsgalattervezes.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lovakkezelese lomenedzsment = new lovakkezelese();
            lomenedzsment.ShowDialog();
        }
    }
}
