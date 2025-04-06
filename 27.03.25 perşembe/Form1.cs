using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27._03._25_perşembe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        sinema sinema1;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string salonAdı = TxtSalonAdı.Text;
            int salonKapasitesi = Int32.Parse(TxtKoltukSayısı.Text);

            sinema1 = new sinema(salonAdı, salonKapasitesi);
            LblInfo.Text = salonAdı + "isimli salon oluşturuldu";

            btnoluştur.Enabled = false;
            btnbakiye.Enabled = true;
            btnboşkoltuk.Enabled = true;
            btnsatış.Enabled = true;
            btniade.Enabled = true;
            btnsatilankoltuk.Enabled = true;

        }

        private void btnsatış_Click(object sender, EventArgs e)
        {
            int BosKoltuk = sinema1.BoşKoltukSayısıGetir();
            if (BosKoltuk == 0)
            {
                LblInfo.Text = "Koltuklar Tükenmiştir";
                return;
            }
            sinema1.BiletSat(Chkİndirimli.Checked);
            LblInfo.Text = "Bilet Satıldı";
        }

        private void Chkiade_Click(object sender, EventArgs e)
        {
            int bosKoltuk = sinema1.BoşKoltukSayısıGetir();
            int koltukSayisi = sinema1.toplamKoltukSayısı;
            if(bosKoltuk == koltukSayisi)
            {
                LblInfo.Text = "İade Edilecek Koltuk Bulunamadı";
                return;
            }
            int indirimliKoltuk = sinema1.indirimliKoltuk;
            int normalKoltuk = sinema1.normalKoltuk;
            if(indirimliKoltuk==0)
            {
                Chkİndirimli.Checked = false;
                LblInfo.Text = "İndirimli Koltuk Bulunamadı";
                
            }
            if(normalKoltuk == 0)
            {
                LblInfo.Text = "Normal Koltuk Kalmnadı";
                
            }
            sinema1.Biletİade(Chkİndirimli.Checked);
            LblInfo.Text = "Bilet İade Edildi";
        }

        private void btnboşkoltuk_Click(object sender, EventArgs e)
        {
            int sayı = sinema1.BoşKoltukSayısıGetir();
            LblInfo.Text = "boş koltuk sayısı: " + sayı;
        }

        private void btnbakiye_Click(object sender, EventArgs e)
        {
            double bakiye = sinema1.BakiyeGetir();
            LblInfo.Text = "bakiye: " + bakiye;


        }

        private void btnsatilankoltuk_Click(object sender, EventArgs e)
        {
            int indirimliKoltuk = sinema1.indirimliKoltuk;
            int normalKoltuk = sinema1.normalKoltuk;
            LblInfo.Text = "İndirimli Koltuk:" + indirimliKoltuk + " Normal Koltuk:" + normalKoltuk;
        }
    }
}
