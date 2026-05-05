using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Site_Ip_Adresi_Ögrenme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBilgi_Click(object sender, EventArgs e)
        {
            textBilgisayar.Text = "Bilgisayar: " + Dns.GetHostName();
            foreach (IPAddress adres in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                textAdres.Text = "Ip Adresi: "+ adres;
            }
        }
    }
}
