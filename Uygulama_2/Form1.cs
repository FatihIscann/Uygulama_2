using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Uygulama_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int karaktersayisi = textBox2.Text.Length;
            if (karaktersayisi > 0 && karaktersayisi < 4)
            {
                progressBar1.Value = 1;
                progressBar1.ForeColor = Color.Red;
                label5.Text = "Zayıf";
            }
            else if (karaktersayisi >= 4 && karaktersayisi < 8)
            {
                progressBar1.Value = 2;
                progressBar1.ForeColor = Color.Yellow;
                label5.Text = "Orta";
            }
            else if (karaktersayisi >=8)
            {
                progressBar1.Value = 3;
                progressBar1.ForeColor = Color.Green;
                label5.Text = "Güçlü";
            }
            else
            {
                progressBar1.Value = 0;
                label5.Text = "";
            }
                
        }
        private bool emailkontrol(string email)
        {
            try
            {
                MailAddress ma = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (emailkontrol(textBox4.Text) == false)
                MessageBox.Show("Mail adresini kontrol edin");
            else
            {
                if (textBox5.Text == label8.Text)
                    MessageBox.Show("Kayıt Gerçekleşti");
                else
                    MessageBox.Show("Doğrulama kodunu kontrole ediniz");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd= new Random();
            const string karakter = "QWERTYUIOOOOPPŞLKJHGFSAZXCVBNMqwertyuıoplkjhgfazxcbnm1234567890";
            string kod = "";
            for (int i = 0; i < 6; i++)
            {
                kod += karakter[rnd.Next(karakter.Length)];
            }
            label8.Text = kod;
            timer1.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        if (button2.Text== "Göster")
            {
                textBox2.PasswordChar = char.Parse("\0");
                textBox3.PasswordChar = char.Parse("\0");
                button2.Text = "Gizle";
            }
            else if (button2.Text == "Gizle")
            {
                textBox2.PasswordChar = char.Parse("*");
                textBox3.PasswordChar = char.Parse("*");
                button2.Text = "Göster";
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text != textBox2.Text)
                label6.Text = "Şifreler Eşit Değil";
            else
                label6.Text = "";
        }
        int sayac = 59;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            if(sayac ==0)
            {
                Random rnd = new Random();
                const string karakter = "QWERTYUIOOOOPPŞLKJHGFSAZXCVBNMqwertyuıoplkjhgfazxcbnm1234567890";
                string kod = "";
                for (int i = 0; i < 6; i++)
                {
                    kod += karakter[rnd.Next(karakter.Length)];
                }
                label8.Text = kod;
                sayac = 59;
            }
            label9.Text = sayac.ToString();
        }
    }
}
