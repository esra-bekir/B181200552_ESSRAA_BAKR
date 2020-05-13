using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp18.Properties
{
    public class Yemekler
    {
        public float kalori { get; set; }
        public float agirlik { get; set; }
        public string icindeki { get; set; }
        public float protein { get; set; }
        public float yag { get; set; }
        public float kolesterol { get; set; }
        public float sodyum { get; set; }
        public string alarji_yapabilecek_urunler { get; set; }

        List<Yemekler> siparislerim;
        private double fiyat { get; set; }
        public void setFiyat(double _fiyat)
        {
            this.fiyat = _fiyat;
        }
        // void   
        public string getFiyatBirimle()
        {
            return fiyat + " ₺";
        }
        public double getFiyat()
        {
            return fiyat;
        }

        public void setAgirlik(float agr)
        {
            this.agirlik = agr;
        }

        public string getAgirlik()
        {
            return agirlik + " Gr";
        }

        public string getYag()
        {
            return yag + " L";
        }

        public string getProten()
        {
            return protein + " Ml";
        }

        public void setKalori(float kal)
        {
            this.kalori = kal;
        }

        public string getKalori()
        {
            return this.kalori + " kcal";
        }

    }

}
