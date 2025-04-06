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

        }

        private void btnsatış_Click(object sender, EventArgs e)
        {
            sinema1.BiletSat(Chkİndirimli.Checked);
            
        }

        private void Chkiade_Click(object sender, EventArgs e)
        {
            sinema1.Biletİade(Chkİndirimli.Checked);
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
    }
}
