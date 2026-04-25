using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutucuk_Seçme_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int puan = 0;
        Random rdm=new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int rastgele = rdm.Next(1,51);
            foreach(var a in flowLayoutPanel1.Controls)
            {
                Button btn = a as Button;
                if (btn.Text == rastgele.ToString())
                {
                    btn.BackColor = Color.Red;
                    btn.ForeColor = Color.White;
                    btn.Click += new EventHandler(btn_click);
                }
                else
                {
                    btn.BackColor= Color.Purple;
                }
            }
        }
        void btn_click(object sender, EventArgs e)
        {
            Button btn= sender as Button;
            if (btn.BackColor == Color.Red)
            {
                puan++;
            }
            else
            {
                puan--;
            }
            this.Text = puan.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1500;
            timer1.Start();
            flowLayoutPanel1.Width = 400;
            flowLayoutPanel1.Height = 350;           
            for (int i = 1; i < 17; i++)
            {
                Button btn = new Button();
                btn.BackColor = Color.Purple;
                btn.ForeColor = Color.White;
                btn.Width = 75;
                btn.Height = 75;
                btn.Text = i.ToString();
                flowLayoutPanel1.Controls.Add(btn);
            }
            if (puan == 5)
            {
                timer1.Interval = 1250;
            }
            else if (puan == 10)
            {
                timer1.Interval=1000;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            flowLayoutPanel1.Width = 520;
            flowLayoutPanel1.Height = 520;
            for (int i = 1; i < 37; i++)
            {
                Button btn = new Button();
                btn.BackColor = Color.Purple;
                btn.ForeColor = Color.White;
                btn.Width = 75;
                btn.Height = 75;
                btn.Text = i.ToString();
                flowLayoutPanel1.Controls.Add(btn);
            }
            if (puan == 5)
            {
                timer1.Interval = 800;
            }
            else if (puan == 10)
            {
                timer1.Interval = 600;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {            
            timer1.Interval = 750;
            timer1.Start();            
            for (int i = 1; i < 51; i++)
            {
                Button btn = new Button();
                btn.BackColor = Color.Purple;
                btn.ForeColor = Color.White;
                btn.Width = 75;
                btn.Height = 75;
                btn.Text = i.ToString();
                flowLayoutPanel1.Controls.Add(btn);
            }
            if (puan == 5)
            {
                timer1.Interval = 550;
            }
            else if(puan==10)
            {
                timer1.Interval = 350;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
