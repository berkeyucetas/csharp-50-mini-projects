using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lise_Sınav_Ortalama_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            double turkce;
            double matematik;
            double fen;
            double sosyal;
            double ygs1, ygs2, ygs3, ygs4, ygs5, ygs6;

            turkce= Convert.ToDouble(txtTurkce.Text);
            matematik= Convert.ToDouble(txtMatematik.Text);
            fen= Convert.ToDouble(txtFen.Text);
            sosyal=Convert.ToDouble(txtSosyal.Text);

            ygs1 = 100.160 + (turkce * 1.999) + (sosyal * 1) + (matematik * 3.998) + (fen * 2.999);
            lblygs1.Text= ygs1.ToString();

            ygs2 = 100.160 + (turkce * 1.999) + (sosyal * 1) + (matematik * 2.999) + (fen * 3.998);
            lblygs2.Text = ygs2.ToString();

            ygs3 = 100.160 + (turkce * 3.998) + (sosyal * 2.999) + (matematik * 1.999) + (fen * 1);
            lblygs3.Text = ygs3.ToString();

            ygs4 = 100.160 + (turkce * 2.999) + (sosyal * 3.998) + (matematik * 1.999) + (fen * 1);
            lblygs4.Text = ygs4.ToString();

            ygs5 = 100.160 + (turkce * 3.699) + (sosyal * 1.999) + (matematik * 3.299) + (fen * 1);
            lblygs5.Text = ygs5.ToString();

            ygs6 = 100.160 + (turkce * 3.299) + (sosyal * 1) + (matematik * 3.699) + (fen * 1.999);
            lblygs6.Text = ygs6.ToString();

        }

        
    }
}
