using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analog_Saat_ve_Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Timer t=new Timer();
        int Genişlik = 300, Yukseklik = 300;
        int SaniyeIbre=140;
        int DakikaIbre = 110;
        int SaatIbre = 80;
        int OrtaX, OrtaY;
        Bitmap bmp;
        Graphics g;

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp= new Bitmap(Genişlik+1,Yukseklik+1);
            OrtaX = Genişlik / 2;
            OrtaY = Yukseklik / 2;
            this.BackColor = Color.White;
            t.Interval = 1000;
            t.Tick += new EventHandler(this.timer1_Tick);
            t.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g=Graphics.FromImage(bmp);
            int ss = DateTime.Now.Second;
            int mm= DateTime.Now.Minute;
            int hh= DateTime.Now.Hour;

            int[] kordinat = new int[2];
            g.Clear(Color.White);
            g.DrawEllipse(new Pen(Color.Black, 1F), 0, 0, Yukseklik, Genişlik);

            g.DrawString("12", new Font("Arial", 12), Brushes.Black, new PointF(140, 2));
            g.DrawString("3", new Font("Arial", 12), Brushes.Black, new PointF(286, 140));
            g.DrawString("6", new Font("Arial", 12), Brushes.Black, new PointF(142, 282));
            g.DrawString("9", new Font("Arial", 12), Brushes.Black, new PointF(0, 140));

            kordinat = mscoord(ss, SaniyeIbre);
            g.DrawLine(new Pen(Color.Red, 1f), new Point(OrtaX, OrtaY), new Point(kordinat[0], kordinat[1]));
            kordinat = mscoord(mm, DakikaIbre);
            g.DrawLine(new Pen(Color.Blue, 2f), new Point(OrtaX, OrtaY), new Point(kordinat[0], kordinat[1]));
            kordinat = hrcoord(hh%12,mm, SaatIbre);
            g.DrawLine(new Pen(Color.DarkGreen, 3f), new Point(OrtaX, OrtaY), new Point(kordinat[0], kordinat[1]));
            pictureBox1.Image = bmp;
            if (mm < 10)
            {
                this.Text = "Saat:" + hh + ":"+"0"+ mm + ":" + ss;
            }
            else
            {
                this.Text = "Saat:" + hh + ":" + mm + ":" + ss;
            }
            
            g.Dispose();
        }
        int[] coord = new int[2];

        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }
        int salise = 0;
        int saniye = 0;
        int dakika = 0;
        int saat = 0;

        private void timer2_Tick(object sender, EventArgs e)
        {
            salise++;
            
            if (salise == 100)
            {
                salise = 0;
                saniye++;
            }

            if (saniye == 60)
            {
                saniye = 0;
                dakika++;
            }


            if (dakika == 60)
            {
                dakika = 0;
                saat++;
            }

            labelSalise.Text = salise.ToString();
            labelSaniye.Text = saniye.ToString();
            labelDakika.Text = dakika.ToString();
            labelSaat.Text = saat.ToString();

        }

        private void btnDuraklat_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            listBox1.Items.Add(saat + ":" + dakika + ":" + saniye + "." + salise);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            salise = 0;
            saniye = 0;
            dakika = 0;
            saat = 0;
            labelSalise.Text = salise.ToString();
            labelSaniye.Text = saniye.ToString();
            labelDakika.Text = dakika.ToString();
            labelSaat.Text = saat.ToString();
            listBox1.Items.Clear();
        }

        private int[] mscoord(int saniyedeger, int saataci)
        {
            
            saniyedeger *= 6;
            if(saniyedeger>=0&&saniyedeger<=180)
            {
                coord[0] = OrtaX + (int)(saataci * Math.Sin(Math.PI * saniyedeger / 180));
                coord[1] = OrtaX - (int)(saataci * Math.Cos(Math.PI * saniyedeger / 180));
            }
            else
            {
                coord[0] = OrtaX - (int)(saataci * -Math.Sin(Math.PI * saniyedeger / 180));
                coord[1] = OrtaX - (int)(saataci * Math.Cos(Math.PI * saniyedeger / 180));
            }
            return coord;
        }
        private int[] hrcoord(int saatdeger, int dakikadeger, int saataci)
        {
            int val = (int)((saatdeger * 30) + (dakikadeger * 0.5));
            if (val >= 0 && val <= 180)
            {
                coord[0] = OrtaX + (int)(saataci * Math.Sin(Math.PI * val / 180));
                coord[1] = OrtaX - (int)(saataci * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = OrtaX - (int)(saataci * -Math.Sin(Math.PI * val / 180));
                coord[1] = OrtaX - (int)(saataci * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }
    }
}
