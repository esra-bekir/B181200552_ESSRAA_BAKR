/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2019-2020 BAHAR DÖNEMİ
**
** PROJE NUMARASI.........: Proje
** ÖĞRENCİ ADI............: ESSRAA BAKR
** ÖĞRENCİ NUMARASI.......: B181200552
** DERSİN ALINDIĞI GRUP...: A
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp18.Properties
{
    class FastfoodYemekleri : Yemekler
    {
        public float Kalsiyum { get; set; }
        public double enerji { get; set; }

        public List<string> icindekilr { get; set; }

        public List<int> enerjiler { get; set; }

        public FastfoodYemekleri()
        {
            enerji = 0.0f;
            Kalsiyum = 0.0f;

            icindekilr = new List<string>();
            icindekilr.Add("test1");
            icindekilr.Add("test2");
            icindekilr.Add("test3");

        }

        public List<string> getIcindekiler()
        {
            return this.icindekilr;
        }

        public string getEnergy()
        {
            return this.enerji + " mg";
        }

        public void setEnergy(float enrj)
        {
            this.enerji = enrj;
        }

        public string getKalsiyum()
        {
            return this.Kalsiyum + " mg";
        }

        public void setKalsiyum(float kal)
        {
            this.Kalsiyum = kal;
        }

      


    }
}
