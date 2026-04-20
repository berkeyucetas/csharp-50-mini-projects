using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kilo_Endexsi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            string cinsiyet = cmbcinsiyet.Text;
            int yas = Convert.ToInt32(txtyas.Text);
            double boy = Convert.ToDouble(txtboy.Text);
            double kilo = Convert.ToDouble(txtkilo.Text);

            double endeks = kilo / (boy * boy);

            if (cinsiyet == "Women")
            {
                if (endeks < 18.5)
                {
                    txtendeks.Text = "İdeal kilonun altında";
                }
                else if (endeks >= 18.5 && endeks <= 24.9)
                {
                    txtendeks.Text = "İdeal kiloda";
                }
                else if (endeks >= 25 && endeks <= 29.9)
                {
                    txtendeks.Text = "İdeal kilonun üstünde";
                }
                else if (endeks >= 30)
                {
                    txtendeks.Text = "İdeal kilonun çok üstünde (obez)";
                }
                else
                {
                    txtendeks.Text = "Hata: Yanlış bir değer girildi.";
                }
            }
            else
            {
                txtendeks.Text = "Lütfen cinsiyetinizi seçin.";
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            txtboy.Clear();
            txtkilo.Clear();
            txtyas.Clear();
            cmbcinsiyet.Text = "";
            txtendeks.Clear();
        }
    }
}
