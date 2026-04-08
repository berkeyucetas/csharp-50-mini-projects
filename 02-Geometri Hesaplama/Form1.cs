using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometri_Hesaplama
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text="Kare";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Dikdörtgen";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double kenar1, kenar2;
            double cevre, alan;
            double dalan, dcevre;
            kenar1 = Convert.ToDouble(textBox1.Text);
            kenar2 = Convert.ToDouble(textBox2.Text);
            alan = kenar1 * kenar1;
            cevre = kenar1 * 4;
            dalan = kenar1 * kenar2;
            dcevre = (kenar1 + kenar2) * 2;


            if (label1.Text == "Kare")
            {
                label7.Text = Convert.ToString(cevre);
            }
            else if (label1.Text == "Dikdörtgen")
            {
                label7.Text = Convert.ToString(dcevre);
            }

                    
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double kenar1, kenar2;
            double cevre, alan;
            double dalan, dcevre;
            kenar1= Convert.ToDouble(textBox1.Text);
            kenar2=Convert.ToDouble(textBox2.Text);
            alan = kenar1 * kenar1;
            cevre = kenar1 * 4;
            dalan = kenar1*kenar2;
            dcevre = (kenar1 + kenar2)*2;

            if (label1.Text == "Kare")
            {
                label6.Text = Convert.ToString(alan);
            }
            else if (label1.Text == "Dikdörtgen")
            {
                label6.Text = Convert.ToString(dalan);
            }
        }
    }
}
