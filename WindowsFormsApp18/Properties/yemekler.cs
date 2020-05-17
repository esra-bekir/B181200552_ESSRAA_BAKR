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
        public float sekerorani { get; set; }
        public string alarji_yapabilecek_urunler { get; set; }

        readonly List<Yemekler> siparislerim;
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
            
            return fiyat= Math.Round(fiyat, 2);  // g'rm'; oldu[um float sayinin basamaktan sonra sadece iki sayıyı gösterir 
        }

        public void setAgirlik(float gr)
        {
            this.agirlik =gr;
        }

        public string getAgirlik()
        {
            return agirlik + " gr";
        }

        public string getYag()
        {
            return yag + " gr";
        }

        public string getkolestirol()
        {
            return kolesterol + " gr";
        }
        public string getProten()
        {
            return protein + " Ml";
        }
        public string getsekerorani()
        {
            return sekerorani + " gr";
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
