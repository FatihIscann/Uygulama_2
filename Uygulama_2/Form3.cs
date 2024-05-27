using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 cagir = new Form2();
            cagir.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 cagir = new Form1();
            cagir.Show();
        }
    }
}
