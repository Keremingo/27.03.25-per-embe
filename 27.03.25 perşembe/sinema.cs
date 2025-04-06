using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._03._25_perşembe
{
    public class sinema
    {
        public int toplamKoltukSayısı {  get; set; }
        public int boşKoltukSayısı { get; set; }
        public double bakiye {  get; set; }
        public string salonAdı {  get; set; }
        public const double TamBilet = 150;
        public const double İndirimliBilet = 100;
        
        public sinema(string _salonAdı,int _koltukSayısı)
        {
            this.toplamKoltukSayısı = _koltukSayısı;
            this.boşKoltukSayısı = toplamKoltukSayısı;
            this.bakiye = 0;
            this.salonAdı = _salonAdı;
        }
        public void BiletSat(bool _indirimli)
        {
            if (_indirimli)
                bakiye += İndirimliBilet;
            else
                bakiye += TamBilet;

            boşKoltukSayısı--;
        }
        public void Biletİade (bool _indirimli)
        {
            if (_indirimli)
                bakiye -= İndirimliBilet;
            else
                bakiye -= TamBilet;

            boşKoltukSayısı++;
        }
        internal int BoşKoltukSayısıGetir()
        {
            return boşKoltukSayısı;
        }
       public double BakiyeGetir()
        {
            return bakiye;
        }

    }
}
