using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgisayar_Donanımları_Tanıma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabPage1.ForeColor = Color.Brown;
            tabPage2.ForeColor = Color.Brown;
            tabPage3.ForeColor = Color.Brown;
            tabPage4.ForeColor = Color.Brown;
            tabPage5.ForeColor = Color.Brown;
            tabPage6.ForeColor = Color.Brown;
            tabPage7.ForeColor = Color.Brown;
            tabPage8.ForeColor = Color.Brown;
            tabPage1.BackColor = Color.LightGreen;
            tabPage2.BackColor = Color.LightGreen;
            tabPage3.BackColor = Color.LightGreen;
            tabPage4.BackColor = Color.LightGreen;
            tabPage5.BackColor = Color.LightGreen;
            tabPage6.BackColor = Color.LightGreen;
            tabPage7.BackColor = Color.LightGreen;
            tabPage8.BackColor = Color.LightGreen;
        }
    }
}
