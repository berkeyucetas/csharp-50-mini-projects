using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trafik_Lambası
{
    public partial class Form1 : Form
    {
        int timerCounter = 0;
        public Form1()
        {
            InitializeComponent();

            
            timer1.Interval = 1000; 
            timer1.Tick += new EventHandler(timer1_Tick);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
           
            btnKirmizi.BackColor = System.Drawing.Color.Red; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timerCounter++;

            if (timerCounter == 1)
            {
                btnKirmizi.BackColor = System.Drawing.Color.Red;
            }
            if (timerCounter == 30)
            {
                btnKirmizi.BackColor = System.Drawing.Color.Gray;
                btnSari.BackColor = System.Drawing.Color.Yellow;
            }
            else if (timerCounter == 32)
            {
                btnKirmizi.BackColor = System.Drawing.Color.Gray;
                btnSari.BackColor = System.Drawing.Color.Gray;
                btnYesil.BackColor = System.Drawing.Color.Green;
            }
            else if (timerCounter == 45)
            {
                timerCounter = 0; 
                btnKirmizi.BackColor = System.Drawing.Color.Red;
                btnYesil.BackColor = System.Drawing.Color.Gray;
            }
            
        }
    }
}
