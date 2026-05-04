using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafıza_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele=new Random();
        int sure = 15;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start(); 
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;

            int sayi1;
            int sayi2;
            int sayi3;
            int sayi4;
            int sayi5;
            int sayi6;
            sayi1 = rastgele.Next(0, 26);
            sayi2 = rastgele.Next(0, 26);
            sayi3 = rastgele.Next(0, 26);
            sayi4 = rastgele.Next(0, 26);
            sayi5 = rastgele.Next(0, 26);
            sayi6 = rastgele.Next(0, 26);           
            label1.Text=sayi1.ToString();
            label2.Text=sayi2.ToString();
            label3.Text=sayi3.ToString();
            label4.Text=sayi4.ToString();
            label5.Text=sayi5.ToString();
            label6.Text=sayi6.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            int sayi1;
            int sayi2;
            int sayi3;
            int sayi4;
            int sayi5;
            int sayi6;
            int sayi7;
            int sayi8;
            int sayi9;
            int sayi10;
            sayi1 = rastgele.Next(0, 31);
            sayi2 = rastgele.Next(0, 31);
            sayi3 = rastgele.Next(0, 31);
            sayi4 = rastgele.Next(0, 31);
            sayi5 = rastgele.Next(0, 31);
            sayi6 = rastgele.Next(0, 31);
            sayi7 = rastgele.Next(0, 31);
            sayi8 = rastgele.Next(0, 31);
            sayi9 = rastgele.Next(0, 31);
            sayi10 = rastgele.Next(0, 31);
            label1.Text = sayi1.ToString();
            label2.Text = sayi2.ToString();
            label3.Text = sayi3.ToString();
            label4.Text = sayi4.ToString();
            label5.Text = sayi5.ToString();
            label6.Text = sayi6.ToString();
            label7.Text = sayi7.ToString();
            label8.Text = sayi8.ToString();
            label9.Text = sayi9.ToString();
            label10.Text = sayi10.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button8.Enabled = false;
            int sayi1;
            int sayi2;
            int sayi3;
            int sayi4;
            int sayi5;
            int sayi6;
            int sayi7;
            int sayi8;
            int sayi9;
            int sayi10;
            sayi1 = rastgele.Next(-10, 11);
            sayi2 = rastgele.Next(-10, 11);
            sayi3 = rastgele.Next(-10, 11);
            sayi4 = rastgele.Next(-10, 11);
            sayi5 = rastgele.Next(-10, 11);
            sayi6 = rastgele.Next(-10, 11);
            sayi7 = rastgele.Next(-10, 11);
            sayi8 = rastgele.Next(-10, 11);
            sayi9 = rastgele.Next(-10, 11);
            sayi10 = rastgele.Next(-10, 11);
            label1.Text = sayi1.ToString();
            label2.Text = sayi2.ToString();
            label3.Text = sayi3.ToString();
            label4.Text = sayi4.ToString();
            label5.Text = sayi5.ToString();
            label6.Text = sayi6.ToString();
            label7.Text = sayi7.ToString();
            label8.Text = sayi8.ToString();
            label9.Text = sayi9.ToString();
            label10.Text = sayi10.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;            
            int sayi1;
            int sayi2;
            int sayi3;
            int sayi4;
            int sayi5;
            int sayi6;
            int sayi7;
            int sayi8;
            int sayi9;
            int sayi10;
            sayi1 = rastgele.Next(-20, 31);
            sayi2 = rastgele.Next(-20, 31);
            sayi3 = rastgele.Next(-20, 31);
            sayi4 = rastgele.Next(-20, 31);
            sayi5 = rastgele.Next(-20, 31);
            sayi6 = rastgele.Next(-20, 31);
            sayi7 = rastgele.Next(-20, 31);
            sayi8 = rastgele.Next(-20, 31);
            sayi9 = rastgele.Next(-20, 31);
            sayi10 = rastgele.Next(-20, 31);
            label1.Text = sayi1.ToString();
            label2.Text = sayi2.ToString();
            label3.Text = sayi3.ToString();
            label4.Text = sayi4.ToString();
            label5.Text = sayi5.ToString();
            label6.Text = sayi6.ToString();
            label7.Text = sayi7.ToString();
            label8.Text = sayi8.ToString();
            label9.Text = sayi9.ToString();
            label10.Text = sayi10.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text == textBox1.Text && label2.Text == textBox2.Text && label3.Text == textBox3.Text && label4.Text == textBox4.Text && label5.Text == textBox5.Text && label6.Text == textBox6.Text)
            {
                MessageBox.Show("Tebrikler (Basit) Zorluğu başarıyla tamamladınız hafızanız %25 kuvvetli..");
            }
            else
                MessageBox.Show("Malesef başarısız oldunuz.!!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == textBox1.Text && label2.Text == textBox2.Text && label3.Text == textBox3.Text && label4.Text == textBox4.Text && label5.Text == textBox5.Text && label6.Text == textBox6.Text && label7.Text == textBox7.Text && label8.Text == textBox8.Text && label9.Text == textBox9.Text && label10.Text == textBox10.Text)
            {
                MessageBox.Show("Tebrikler (Orta) Zorluğu başarıyla tamamladınız hafızanız %50 kuvvetli..");
            }
            else
                MessageBox.Show("Malesef başarısız oldunuz.!!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == textBox1.Text && label2.Text == textBox2.Text && label3.Text == textBox3.Text && label4.Text == textBox4.Text && label5.Text == textBox5.Text && label6.Text == textBox6.Text && label7.Text == textBox7.Text && label8.Text == textBox8.Text && label9.Text == textBox9.Text && label10.Text == textBox10.Text)
            {
                MessageBox.Show("Tebrikler (Zor) Zorluğu başarıyla tamamladınız hafızanız %75 kuvvetli..");
            }
            else
                MessageBox.Show("Malesef başarısız oldunuz.!!");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text == textBox1.Text && label2.Text == textBox2.Text && label3.Text == textBox3.Text && label4.Text == textBox4.Text && label5.Text == textBox5.Text && label6.Text == textBox6.Text && label7.Text == textBox7.Text && label8.Text == textBox8.Text && label9.Text == textBox9.Text && label10.Text == textBox10.Text)
            {
                MessageBox.Show("Tebrikler (Daha Zor) Zorluğu başarıyla tamamladınız hafızanız %1000 kuvvetli..");
            }
            else
                MessageBox.Show("Malesef başarısız oldunuz.!!");
        }

        private void btnSıfırla_Click(object sender, EventArgs e)
        {
            sure = 15;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            label1.Text = " ";
            label2.Text = " ";
            label3.Text = " ";
            label4.Text = " ";
            label5.Text = " ";
            label6.Text = " ";
            label7.Text = " ";
            label8.Text = " ";
            label9.Text = " ";
            label10.Text = " ";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            groupBox1.Visible = true;
            label1.Text = "Sayı 1";
            label2.Text = "Sayı 2";
            label3.Text = "Sayı 3";
            label4.Text = "Sayı 4";
            label5.Text = "Sayı 5";
            label6.Text = "Sayı 6";
            label7.Text = "Sayı 7";
            label8.Text = "Sayı 8";
            label9.Text = "Sayı 9";
            label10.Text = "Sayı 10";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            label12.Text=sure.ToString();
            if (sure == 0)
            {
                timer1.Stop();
                groupBox1.Visible = false;
                
            }

        }
    }
}
