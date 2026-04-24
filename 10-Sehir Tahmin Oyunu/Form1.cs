using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Şehir_Tahmin_Oyunu
{
    public partial class Form1 : Form
    {
        Random rastgele=new Random();
        int kalanhak = 5;
        int bulunanharfsayisi = 0;
        string bulunacaksehirismi = "";
        string[] sehirlistesi =
        {
            "Adana","Adıyaman","Afyon","Ağrı","Amasya","Ankara","Antalya","Artvin","Aydın","Balıkesir","Bilecik","Bingöl","Bitlis","Bolu","Burdur","Bursa","Çanakkale","Çankırı","Çorum","Denizli","Diyarbakır","Edirne","Elâzığ","Erzincan","Erzurum","Eskişehir","Gaziantep","Giresun","Gümüşhane","Hakkâri","Hatay","Isparta","Mersin","İstanbul","İzmir","Kars","Kastamonu","Kayseri","Kırklareli","Kırşehir","Kocaeli","Konya","Kütahya","Malatya","Manisa","Kahramanmaraş","Mardin","Muğla","Muş","Nevşehir","Niğde","Ordu","Rize","Sakarya","Samsun","Siirt","Sinop","Sivas","Tekirdağ","Tokat","Trabzon","Tunceli","Şanlıurfa","Uşak","Van","Yozgat","Zonguldak","Aksaray","Bayburt","Karaman","Kırıkkale","Batman","Şırnak","Bartın","Ardahan","Iğdır","Yalova","Karabük","Kilis","Osmaniye","Düzce"
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            Yenisehirsec();
            bulunanharfsayisi = 0;
            btnHarf.Enabled = true;
            btnTahmin.Enabled = true;
            lblHarf.Text = "";
            kalanhak = 5;

            grpSoru.Controls.Clear();
            for (int i = 0; i < bulunacaksehirismi.Length; i++)
            {
                Label label = new Label();
                label.Location = new Point(20 * i + 30, 20);
                label.Text = bulunacaksehirismi[i].ToString();
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                label.Size = new System.Drawing.Size(15, 20);
                label.BackColor = Color.Red;
                label.ForeColor = Color.Red;
                grpSoru.Controls.Add(label);

            }
        }

        private void btnHarf_Click(object sender, EventArgs e)
        {
            bool harfvarmi = false;
            if (txtHarf.Text.Length != 1)
            {
                MessageBox.Show("Lütfen Tek Harf Giriniz..!");
            }
            else
            {
                if (lblHarf.Text.Contains(txtHarf.Text))
                {
                    MessageBox.Show("Bu Harfi Daha Önce Kullandınız..!");
                    txtHarf.Text = "";
                    txtHarf.Focus();

                    return;
                }
                foreach(Control item  in grpSoru.Controls)
                {
                    if (item is Label)
                    {
                        Label label = item as Label;
                        if(label.Text.ToUpper()==txtHarf.Text.ToUpper())
                        {
                            label.ForeColor= Color.Black;
                            label.BackColor= Color.Lime;
                            harfvarmi = true;
                            bulunanharfsayisi++;
                        }
                    }
                }

            }
            if(!harfvarmi)
            {
                kalanhak--;
                lblkalan.Text=kalanhak.ToString();
                if(kalanhak==0)
                {
                    btnHarf.Enabled = false;
                    btnTahmin.Enabled = false;
                    MessageBox.Show("Oyun Bitti Kaydettiniz..!  " + bulunacaksehirismi);
                }
            }
            lblHarf.Text += txtHarf.Text + " ";
            if(bulunanharfsayisi==bulunacaksehirismi.Length)
            {
                btnHarf.Enabled = false;
                btnTahmin.Enabled= false;
                MessageBox.Show("Oyun Bitti Kazandınız..  ");
            }
            txtHarf.Text = "";
            txtHarf.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnHarf.Enabled= false;
            btnTahmin.Enabled= false;
            rastgele =new Random();
            this.AcceptButton = btnHarf;

        }
        private void Yenisehirsec()
        {
            int rastgelesayi=rastgele.Next(0,sehirlistesi.Length);
            bulunacaksehirismi = sehirlistesi[rastgelesayi];

        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            if(bulunacaksehirismi.ToUpper()==txtKelime.Text.ToUpper())
            {
                foreach (Control item in grpSoru.Controls)
                {
                    if (item is Label)
                    {
                        Label label = item as Label;                        
                        label.ForeColor = Color.Black;
                        label.BackColor = Color.Lime;
                    }
                }
                MessageBox.Show("Oyun Bitti Kazandınız..  ");
            }
            else
            {
                MessageBox.Show("Oyun Bitti Kaydettiniz..!  " + bulunacaksehirismi);
            }
            btnHarf.Enabled = false;
            btnTahmin.Enabled = false;
        }
    }
}
