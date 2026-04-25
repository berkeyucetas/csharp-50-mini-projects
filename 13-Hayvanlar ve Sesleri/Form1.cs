using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hayvanlar_ve_Sesleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }        
        private void pictureat_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\bekoo\\Desktop\\DERS\\C# Uygulama\\Hayvanlar ve Sesleri\\ses\\at.mp3";
            label1.Text = "At";
            label4.Text = "At";
            label2.Text = "Horse";
        }

        private void pictureesek_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\bekoo\\Desktop\\DERS\\C# Uygulama\\Hayvanlar ve Sesleri\\ses\\esek.mp3";
            label1.Text = "Eşek";
            label4.Text = "Eşek";
            label2.Text = "Donkey";
        }

        private void picturehoroz_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\bekoo\\Desktop\\DERS\\C# Uygulama\\Hayvanlar ve Sesleri\\ses\\horoz.mp3";
            label1.Text = "Horoz";
            label4.Text = "Horoz";
            label2.Text = "Rooster";
        }

        private void pictureinek_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\bekoo\\Desktop\\DERS\\C# Uygulama\\Hayvanlar ve Sesleri\\ses\\inek.mp3";
            label1.Text = "İnek";
            label4.Text = "İnek";
            label2.Text = "Cow";
        }

        private void picturekedi_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\bekoo\\Desktop\\DERS\\C# Uygulama\\Hayvanlar ve Sesleri\\ses\\kedi.mp3";
            label1.Text = "Kedi";
            label4.Text = "Kedi";
            label2.Text = "Cat";
        }

        private void picturekus_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\bekoo\\Desktop\\DERS\\C# Uygulama\\Hayvanlar ve Sesleri\\ses\\kus.mp3";
            label1.Text = "Kuş";
            label4.Text = "Kuş";
            label2.Text = "Bird";
        }

        private void pictureordek_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\bekoo\\Desktop\\DERS\\C# Uygulama\\Hayvanlar ve Sesleri\\ses\\ordek.mp3";
            label1.Text = "Ördek";
            label4.Text = "Ördek";
            label2.Text = "Duck";
        }

        private void picturemaymun_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\bekoo\\Desktop\\DERS\\C# Uygulama\\Hayvanlar ve Sesleri\\ses\\maymun.mp3";
            label1.Text = "Maymun";
            label4.Text = "Maymun";
            label2.Text = "Monkey";
        }

        private void picturekoyun_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\bekoo\\Desktop\\DERS\\C# Uygulama\\Hayvanlar ve Sesleri\\ses\\koyun.mp3";
            label1.Text = "Koyun";
            label4.Text = "Koyun";
            label2.Text = "Sheep";
        }

        private void picturekopek_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\bekoo\\Desktop\\DERS\\C# Uygulama\\Hayvanlar ve Sesleri\\ses\\kopek.mp3";
            label1.Text = "Köpek";
            label4.Text = "Köpek";
            label2.Text = "Dog";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Okul öncesi egitimdeki ögrenci kardeşlerimiz için hayvanları tanıyor seslerini ve ingilizce yazılışına gösteriyor ve onları bilgilendiriyorum. ";
        }
    }
}
