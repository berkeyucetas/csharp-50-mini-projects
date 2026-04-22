using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dört_İşlem_Tahmin_Oyunu
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private bool sonucGosterilebilir = false;
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
        }

        Random rastgele = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1;
            int sayi2;
            int islem;
            int a, b;
            int toplam, cikar, carp, bol;
            sayi1 = rastgele.Next(0, 11);
            sayi2 = rastgele.Next(0, 11);
            islem = rastgele.Next(0, 5);

            label1.Text = sayi1.ToString();
            label2.Text = sayi2.ToString();
            a = Convert.ToInt32(label1.Text);
            b = Convert.ToInt32(label2.Text);
            if (islem == 1)
            {
                label3.Text = "+";
                toplam = a + b;
                label4.Text = toplam.ToString();
            }
            else if (islem == 2)
            {
                label3.Text = "-";
                cikar = a - b;
                label4.Text = cikar.ToString();
            }
            else if (islem == 3)
            {
                label3.Text = "/";
                bol = a / b;
                label4.Text = bol.ToString();
            }
            else if (islem == 4)
            {
                label3.Text = "*";
                carp = a * b;
                label4.Text = carp.ToString();
            }
            labeltime.Text = "15";
            sonucGosterilebilir = false; 
            timer.Start();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (sonucGosterilebilir || label4.Text == textBox1.Text)
            {
                label5.Text = "Tebrikler Dogru Tahmin";
            }
            else if(label4.Text!=textBox1.Text)
            {
                MessageBox.Show("Yanlış Sonuç Girdiniz");
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int kalanSure = Convert.ToInt32(labeltime.Text);
            kalanSure--;

            if (kalanSure < 0) 
            {
                kalanSure = 0; 
            }

            labeltime.Text = kalanSure.ToString();
            if (kalanSure == 0 && label4.Text != "" && sonucGosterilebilir)
            {
                
                sonucGosterilebilir = true; 
                timer.Stop();
            }
            else
            {
                labeltime.Text = kalanSure.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
