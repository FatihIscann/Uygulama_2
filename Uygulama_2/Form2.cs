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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Güncelleme", 110);
            listView1.Columns.Add("İsim Soyisim", 110);
            listView1.Columns.Add("Cep No", 70);
            listView1.Columns.Add("Mail", 70);
            listView1.Columns.Add("Şifre", 70);
            listView1.Columns.Add("Cinsiyet", 70);
            listView1.Columns.Add("Adres", 250);

            comboBox1.Items.Add("İstanbul");
            comboBox1.Items.Add("Ankara");
            comboBox1.Items.Add("İzmir");


        }
        int kayit_id = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            kayit_id++;

            string[] row = { kayit_id.ToString(), textBox1.Text, maskedTextBox1.Text, maskedTextBox2.Text, textBox3.Text, radioButton1.Text, radioButton2.Text, textBox2.ToString(), comboBox1.ToString(), comboBox2.ToString(), checkBox1.ToString()};
            var satir = new ListViewItem(row);
            listView1.Items.Add(satir);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.Clear();
                comboBox2.Text = "";
                string[] ilce = { "Beyoğlu", "Sarıyer", "Kadıköy" };
                comboBox2.Items.AddRange(ilce);
            }
            if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.Clear();
                comboBox2.Text = "";
                string[] ilce = { "altındağ", "beypazarı", "çankaya" };
                comboBox2.Items.AddRange(ilce);
            }
            if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Items.Clear();
                comboBox2.Text = "";
                string[] ilce = { "buca", "bornova", "torbalı" };
                comboBox2.Items.AddRange(ilce);
            }
        }
    }
}
