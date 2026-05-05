using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Metin_Belgesi_Oluşturup_Kaydetme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StreamWriter sw;
        string belgeadi, belgeyolu;

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            belgeadi = textAd.Text;
            sw=File.CreateText(belgeyolu+"\\"+belgeadi+".txt");
            sw.Close();
            MessageBox.Show("Metin belgeniz oluşturuldu.");
        }

        private void buttonAktar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader oku=new StreamReader(openFileDialog1.FileName);
                string kelime=oku.ReadToEnd();
                while (kelime != null)
                {
                    textAktar.Text = kelime;
                    kelime = oku.ReadLine();
                }

            }
        }

        private void buttonVeri_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Title = "Kayıt yerini seçiniz";
                saveFileDialog1.Filter = "Metin dosyası(*.txt) | *.txt";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.InitialDirectory = "C:\\";
                saveFileDialog1.ShowDialog();
                StreamWriter save=new StreamWriter(saveFileDialog1.FileName);
                save.WriteLine(textVeri.Text);
                save.Close();
                MessageBox.Show("Kayıt Başarılı");
            }
            catch 
            {
                MessageBox.Show("Kayıt Başarısız İşlem Gerçekleşmedi");
            }
        }

        private void buttonYol_Click(object sender, EventArgs e)
        {
           if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                belgeyolu = folderBrowserDialog1.SelectedPath.ToString();
                textYol.Text = belgeyolu.ToString();
            }
        }
    }
}
