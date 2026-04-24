using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ülke_Başkent_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayaç = 0;
        int puan = 0;
        int süre = 60;
        private void btnbasla_Click(object sender, EventArgs e)
        {
            timer1.Start();        
            sayaç++;
            btnbasla.Text = "Sonraki";
            if (sayaç == 1)
            {
                btnA.BackColor = Color.MediumPurple;
                btnA.ForeColor = Color.White;
                btnB.BackColor = Color.MediumPurple;
                btnB.ForeColor = Color.White;
                btnC.BackColor = Color.MediumPurple;
                btnC.ForeColor = Color.White;
                btnD.BackColor = Color.MediumPurple;
                btnD.ForeColor = Color.White;
                label1.Text = "TÜRKİYE";
                btnA.Text = "İstanbul";
                btnB.Text = "Konya";
                btnC.Text = "Ankara";
                btnD.Text = "İzmir";
                textBox1.Text = "Tarihi ve kültürel zenginlikleriyle göz dolduran ülkemiz, listede 6. sıradan yerini aldı. İstanbul’un haricinde nefis plajları ve koylarıyla Akdeniz ve Ege kıyıları da her yıl olduğu gibi geçen yıl da milyonlarca turist çekti. Türkiye 2016 yılında 10. sıradayken, 2017’de 6’ya yükseldi. Akdeniz Turistik Otelciler ve İşletmeciler Birliği (AKTOB) Başkanı, UNWTO verilerini ve geçen iki yılı değerlendirerek Türkiye’nin 2018 sonunda 45 milyon yabancı turist noktasına ulaşabileceğini kaydetti. Birçok kültüre ev sahipliği yapan İstanbul’un yanı sıra Antalya, İzmir, Muğla, Ankara ve Denizli en çok ziyaret edilen şehirler arasında.";
                pictureBox1.ImageLocation = @"C:\Users\bekoo\Desktop\DERS\C# Uygulama\Ülke Başkent Oyunu\resimler\turkiye.jpg";
                label3.Text = "Ankara";
            }
            if (sayaç == 2)
            {
                btnA.BackColor = Color.MediumPurple;
                btnA.ForeColor = Color.White;
                btnB.BackColor = Color.MediumPurple;
                btnB.ForeColor = Color.White;
                btnC.BackColor = Color.MediumPurple;
                btnC.ForeColor = Color.White;
                btnD.BackColor = Color.MediumPurple;
                btnD.ForeColor = Color.White;
                label1.Text = "ALMANYA";
                btnA.Text = "Hamburg";
                btnB.Text = "Berlin";
                btnC.Text = "Heidelberg";
                btnD.Text = "Bremen";
                textBox1.Text = "Bira festivalleri, müzik festivalleri ve noel pazarları ile ünlü Almanya, dünyanın her köşesinden insanı eğlenceye davet ediyor. Avrupa şehir hayatını ve underground kültürünü deneyimlemek isteyen pek çok genç Berlin’i tercih etmeye devam ediyor. Berlin’de ayrıca dünyaca ünlü Berlin Duvarı ve Brandenburg Kapısı bulunuyor. Berlin, Frankfurt, Hamburg ve Oktoberfest’i ile ünlü Münih en çok yabancı turist çeken şehirler arasında.";
                pictureBox1.ImageLocation = @"C:\Users\bekoo\Desktop\DERS\C# Uygulama\Ülke Başkent Oyunu\resimler\almanya.jpg";
                label3.Text = "Berlin";
            }
            if (sayaç == 3)
            {
                btnA.BackColor = Color.MediumPurple;
                btnA.ForeColor = Color.White;
                btnB.BackColor = Color.MediumPurple;
                btnB.ForeColor = Color.White;
                btnC.BackColor = Color.MediumPurple;
                btnC.ForeColor = Color.White;
                btnD.BackColor = Color.MediumPurple;
                btnD.ForeColor = Color.White;
                label1.Text = "TAYLAND";
                btnA.Text = "Bangkok";
                btnB.Text = "Ayutthaya";
                btnC.Text = "Surat Thani";
                btnD.Text = "Chiang Mai";
                textBox1.Text = "Tayland’ın yabancı ziyaretçi sayıları her yıl artmaya devam ediyor. Bangkok, Pattaya, Phuket en çok tercih edilen şehirler arasında. Yeni yılın kutlandığı Songkran Festivali de yabancı turistlerin gözdesi konumunda. Tayland’a Türkiye’den düzenli ve doğrudan uçuşların bulunması ve her yıl çeşitlenen ekonomik tur paketleri ile de ülke, Türkiye’den ciddi miktarda ziyaretçi çekmeye devam ediyor.";
                pictureBox1.ImageLocation = @"C:\Users\bekoo\Desktop\DERS\C# Uygulama\Ülke Başkent Oyunu\resimler\tayland.jpg";
                label3.Text = "Bangkok";
            }
            if (sayaç == 4)
            {
                btnA.BackColor = Color.MediumPurple;
                btnA.ForeColor = Color.White;
                btnB.BackColor = Color.MediumPurple;
                btnB.ForeColor = Color.White;
                btnC.BackColor = Color.MediumPurple;
                btnC.ForeColor = Color.White;
                btnD.BackColor = Color.MediumPurple;
                btnD.ForeColor = Color.White;
                label1.Text = "İNGİLTERE";
                btnA.Text = "Cambridge";
                btnB.Text = "Bristol";
                btnC.Text = "Manchester";
                btnD.Text = "Londra";
                textBox1.Text = "Birleşik Krallık'ı meydana getiren dört ülkeden en büyüğü olan İngiltere, 38,7 milyon kişiyle 8. sırada yerini aldı. Kendine özgü havası, müziği, kültürü, edebiyatı ve doğasıyla diğer Avrupa ülkelerinden farklı bir konuma oturt(ul)an ülke, her yıl milyonlarca yabancı turist çekmeye devam ediyor. Londra’nın haricinde Liverpool, Manchester ve Birmingham en çok ziyaret edilen şehirler arasında.";
                pictureBox1.ImageLocation = @"C:\Users\bekoo\Desktop\DERS\C# Uygulama\Ülke Başkent Oyunu\resimler\ingiltere.jpg";
                label3.Text = "Londra";
            }
            if (sayaç == 5)
            {
                btnA.BackColor = Color.MediumPurple;
                btnA.ForeColor = Color.White;
                btnB.BackColor = Color.MediumPurple;
                btnB.ForeColor = Color.White;
                btnC.BackColor = Color.MediumPurple;
                btnC.ForeColor = Color.White;
                btnD.BackColor = Color.MediumPurple;
                btnD.ForeColor = Color.White;
                label1.Text = "MEKSİKA";
                btnA.Text = "Meksiko";
                btnB.Text = "Oaxaca de Juarez";
                btnC.Text = "San Luis Potosi";
                btnD.Text = "Victoria de Durango";
                textBox1.Text = "Meksika, Amerika kıtasının en popüler ülkelerinden biri. Meksika, sahilleri kadar gastronomi ve eğlence sektöründe de yabancıların gözdesi konumunda. Büyük Maya şehirlerinden en ünlüsü olan Chichen Itza ve Mexico City en çok ziyaret edilen şehirler arasında.";
                pictureBox1.ImageLocation = @"C:\Users\bekoo\Desktop\DERS\C# Uygulama\Ülke Başkent Oyunu\resimler\meksika.jpg";
                label3.Text = "Meksiko";
            }
            if (sayaç == 6)
            {
                btnA.BackColor = Color.MediumPurple;
                btnA.ForeColor = Color.White;
                btnB.BackColor = Color.MediumPurple;
                btnB.ForeColor = Color.White;
                btnC.BackColor = Color.MediumPurple;
                btnC.ForeColor = Color.White;
                btnD.BackColor = Color.MediumPurple;
                btnD.ForeColor = Color.White;
                label1.Text = "İTALYA";
                btnA.Text = "Venedik";
                btnB.Text = "Roma";
                btnC.Text = "Pisa";
                btnD.Text = "Milan";
                textBox1.Text = "Her noktasında farklı bir kültür ve tarih barındıran İtalya ise 57,8 milyon turist ile en çok tercih edilen ülkeler arasında yer aldı. Masalsı sokakları ve kanallarıyla ünlü Venedik, moda dünyasının kalbinin attığı Milano ve bir açık hava heykel müzesini andıran Floransa en çok ziyaret edilen şehirler arasında.";
                pictureBox1.ImageLocation = @"C:\Users\bekoo\Desktop\DERS\C# Uygulama\Ülke Başkent Oyunu\resimler\italya.jpg";
                label3.Text = "Roma";
            }
            if (sayaç == 7)
            {
                btnA.BackColor = Color.MediumPurple;
                btnA.ForeColor = Color.White;
                btnB.BackColor = Color.MediumPurple;
                btnB.ForeColor = Color.White;
                btnC.BackColor = Color.MediumPurple;
                btnC.ForeColor = Color.White;
                btnD.BackColor = Color.MediumPurple;
                btnD.ForeColor = Color.White;
                label1.Text = "ÇİN";
                btnA.Text = "Wuhan";
                btnB.Text = "Chongqing";
                btnC.Text = "Shanghai";
                btnD.Text = "Beijing";
                textBox1.Text = "Dünyanın yüz ölçümü bakımında en büyük 3. ülkesi olan Çin, 59,3 milyon kişiyle 4. sıradan yerini aldı. Çin özellikle iş turizmi anlamında çok fazla iş insanını ağırlıyor. Çin’de son yıllarda şehir merkezleri kadar kırsal alanlar da yabancı turistler tarafından ziyaret ediliyor. Hong Kong, Pekin, Şangay ülkede en çok ziyaret edilen şehirler arasında yerini aldı.";
                pictureBox1.ImageLocation = @"C:\Users\bekoo\Desktop\DERS\C# Uygulama\Ülke Başkent Oyunu\resimler\cin.jpg";
                label3.Text = "Beijing";
            }
            if (sayaç == 8)
            {
                btnA.BackColor = Color.MediumPurple;
                btnA.ForeColor = Color.White;
                btnB.BackColor = Color.MediumPurple;
                btnB.ForeColor = Color.White;
                btnC.BackColor = Color.MediumPurple;
                btnC.ForeColor = Color.White;
                btnD.BackColor = Color.MediumPurple;
                btnD.ForeColor = Color.White;
                label1.Text = "AMERİKA";
                btnA.Text = "New York";
                btnB.Text = "Washington, D.C.";
                btnC.Text = "San Francisco";
                btnD.Text = "Chicago";
                textBox1.Text = "Dünyanın en geniş yü zölçümüne sahip 4. ülke olan ABD listede 3. Sırada yerini aldı. Tahmin edeceğiniz gibi ülkede en çok yabancı ziyaretçi çeken bölgeler New York City, Los Angeles, Washington D.C. ve San Francisco.";
                pictureBox1.ImageLocation = @"C:\Users\bekoo\Desktop\DERS\C# Uygulama\Ülke Başkent Oyunu\resimler\amerika.jpg";
                label3.Text = "Washington, D.C.";
            }
            if (sayaç == 9)
            {
                btnA.BackColor = Color.MediumPurple;
                btnA.ForeColor = Color.White;
                btnB.BackColor = Color.MediumPurple;
                btnB.ForeColor = Color.White;
                btnC.BackColor = Color.MediumPurple;
                btnC.ForeColor = Color.White;
                btnD.BackColor = Color.MediumPurple;
                btnD.ForeColor = Color.White;
                label1.Text = "İSPANYA";
                btnA.Text = "Seville";
                btnB.Text = "Madrid";
                btnC.Text = "Valencia";
                btnD.Text = "Barcelona";
                textBox1.Text = "Daha önceki yıllara oranla İspanya’ya gelen ziyaretçi sayısında artış gözlendi. Köklü tarihinin yanında eşsiz tabiatı ile dikkat çeken İspanya’yı en çok Almanlar, Hollandalılar ve İngilizler tercih ediyor. Özellikle yaz aylarında gelen yabancı turistler başkent Madrid’i, Barselona’yı, İbiza’yı, Balear Adaları’nı ziyaret ederek ülke ekonomisine büyük katkı sağlıyor.";
                pictureBox1.ImageLocation = @"C:\Users\bekoo\Desktop\DERS\C# Uygulama\Ülke Başkent Oyunu\resimler\ispanya.jpg";
                label3.Text = "Madrid";
            }
            if (sayaç == 10)
            {
                btnA.BackColor = Color.MediumPurple;
                btnA.ForeColor = Color.White;
                btnB.BackColor = Color.MediumPurple;
                btnB.ForeColor = Color.White;
                btnC.BackColor = Color.MediumPurple;
                btnC.ForeColor = Color.White;
                btnD.BackColor = Color.MediumPurple;
                btnD.ForeColor = Color.White;
                label1.Text = "FRANSA";
                btnA.Text = "Lyon";
                btnB.Text = "Strasbourg";
                btnC.Text = "Marseille";
                btnD.Text = "Paris";
                textBox1.Text = "82,6 milyon ziyaretçiyle Fransa, listenin en tepesindeki yerini korudu. En çok ziyaret edilen şehir de tahmin edebileceğiniz gibi Tour Eiffel, mimari ve sanatın buluştuğu Louvre Müzesi, Musée dOrsay, Arc de Triomphe ve macera dolu park Disneyland’ın bulunduğu başkent Paris.";
                pictureBox1.ImageLocation = @"C:\Users\bekoo\Desktop\DERS\C# Uygulama\Ülke Başkent Oyunu\resimler\fransa.jpg";
                label3.Text = "Paris";
                btnbasla.Text = "Bitir";

            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            label2.Text=btnA.Text;
            if (label3.Text == label2.Text)
            {
                puan = puan + 10;
                label5.Text=puan.ToString();
                btnA.BackColor = Color.Green;
            }   
            else
            {
                btnA.BackColor=Color.Red;
            }
            
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            label2.Text = btnB.Text;
            if (label3.Text == label2.Text)
            {
                puan = puan + 10;
                label5.Text = puan.ToString(); 
                btnB.BackColor = Color.Green;
            }
            else
            {
                btnB.BackColor = Color.Red;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            label2.Text = btnC.Text;
            if (label3.Text == label2.Text)
            {
                puan = puan + 10;
                label5.Text = puan.ToString();
                btnC.BackColor = Color.Green;
            }
            else
            {
                btnC.BackColor = Color.Red;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            label2.Text = btnD.Text;
            if (label3.Text == label2.Text)
            {
                puan = puan + 10;
                label5.Text = puan.ToString();
                btnD.BackColor = Color.Green;
            }
            else
            {
                btnD.BackColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Soruyu cevaplamadan sonraki butonuna tıklamayınız aksi taktirde bir önceki soruya dönemezsiniz.!!");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            süre--;
            label6.Text=süre.ToString();
            if (süre == 0)
            {
                MessageBox.Show("Süre Bitti..!!");
                Application.Exit();
            }
        }
    }
}
