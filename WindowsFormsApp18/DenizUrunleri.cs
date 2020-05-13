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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18.Properties
{
    public partial class DenizYemekleri : Form
    {
        List<DenizUrunleri> siparislerim;
        public DenizYemekleri()
        {
            InitializeComponent();
            //siparislerim = new List<Siparis>();
        }


        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            FastFoodUrunleri yeni = new FastFoodUrunleri();
            yeni.Show();
            this.Hide();
        }
        DenizUrunleri salamun;
        DenizUrunleri capura;

        private void Form3_Load(object sender, EventArgs e)
        {
            //List<DenizUrunleri> denizurunlerliste = new List<DenizUrunleri>();
            //denizurunlerliste.Add(new DenizUrunleri()
            //{
            //    agirlik ="75\n",
            //    protein ="19.9329\n",
            //    yag ="10.4315\n",
            //});
            salamun = new DenizUrunleri();
            salamun.agirlik = 2;
            salamun.protein = 18.65f;
            salamun.yag = 10.63f;
            salamun.setFiyat(79.99f);

            label18.Text = salamun.getAgirlik();
            label50.Text = salamun.getProten();
            label17.Text = salamun.getYag();

            DenizUrunleri mezgit = new DenizUrunleri();
            mezgit.agirlik = 2;
            mezgit.protein = 18.65f;
            mezgit.yag = 10.63f;

            label32.Text = mezgit.getAgirlik();
            label35.Text = mezgit.getProten();
            label31.Text = mezgit.getYag();

            DenizUrunleri hamsi = new DenizUrunleri();
            hamsi.agirlik = 2;
            hamsi.protein = 18.65f;
            hamsi.yag = 10.63f;

            label25.Text = hamsi.getAgirlik();
            label27.Text = hamsi.getProten();
            label20.Text = hamsi.getYag();


            DenizUrunleri levrek = new DenizUrunleri();
            levrek.agirlik = 2.3f;
            levrek.protein = 25.235f;
            levrek.yag = 6.2356f;

            label39.Text = levrek.getAgirlik();
            label41.Text = levrek.getProten();
            label38.Text = levrek.getYag();

            capura = new DenizUrunleri();
            capura.agirlik = 1.23f;
            capura.protein = 17.2356f;
            capura.yag = 10.3625f;
            capura.setFiyat(69.99f);

            label21.Text = capura.getAgirlik();
            label25.Text = capura.getProten();
            label20.Text = capura.getYag();

            DenizUrunleri lufer = new DenizUrunleri();
            lufer.agirlik = 75;
            lufer.protein = 19.9329f;
            lufer.yag = 10.4315f;

            label18.Text = lufer.getAgirlik();
            label50.Text = lufer.getProten();
            label17.Text = lufer.getYag();
        }




        private int adetAzalt(int adet)
        {
            return --adet;
        }
        private int adetArttir(int adet)
        {
            return ++adet;
        }
        double genel_tutar = 0;

        private void tutarSHesaplaVeYazdir(int adet, double fiyat)
        {
            double tutar = adet * fiyat;
            s_fiyat_lbl.Text = tutar.ToString();
            s_adet_box.Text = adet.ToString();
            genel_tutar = tutar;
        }

        int salamun_adet = 0;
        int capura_adet = 0;
        private void adet_arttir_btn_Click(object sender, EventArgs e)
        {
            salamun_adet = this.adetArttir(salamun_adet);
            double fiyat = salamun.getFiyat();
            this.tutarSHesaplaVeYazdir(salamun_adet, fiyat);

            //siparislerim.Add(new Siparis()
            //{
            //    adet
            //});

        }

        private void adet_azalt_btn_Click(object sender, EventArgs e)
        {
            if (salamun_adet > 0)
            {
                salamun_adet = this.adetAzalt(salamun_adet);
                double fiyat = salamun.getFiyat();
                this.tutarSHesaplaVeYazdir(salamun_adet, fiyat);

            }
        }

        private void s_adet_box_TextChanged(object sender, EventArgs e)
        {
            if (s_adet_box.Text.ToString() == "")
            {
                salamun_adet = 0;
            }
            else
            {
                salamun_adet = Convert.ToInt32(s_adet_box.Text.ToString());
            }
            double fiyat = salamun.getFiyat();
            this.tutarSHesaplaVeYazdir(salamun_adet, fiyat);
        }

        // Capure
        private void tutarCHesaplaVeYazdir(int adet, double fiyat)
        {
            double tutar = adet * fiyat;
            c_fiyat_lbl.Text = tutar.ToString();
            c_adet_box.Text = adet.ToString();
            genel_tutar = tutar;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (capura_adet > 0)
            {
                capura_adet = this.adetAzalt(capura_adet);
                double fiyat = capura.getFiyat();
                this.tutarCHesaplaVeYazdir(capura_adet, fiyat);
            }
        }

        private void c_adet_box_TextChanged(object sender, EventArgs e)
        {
            if (c_adet_box.Text.ToString() == "")
            {
                capura_adet = 0;
            }
            else
            {
                capura_adet = Convert.ToInt32(c_adet_box.Text.ToString());
            }
            double fiyat = capura.getFiyat();
            this.tutarCHesaplaVeYazdir(capura_adet, fiyat);
        }

        private void label10_Click_1(object sender, EventArgs e)
        {
            capura_adet = this.adetArttir(capura_adet);
            double fiyat = capura.getFiyat();
            this.tutarCHesaplaVeYazdir(capura_adet, fiyat);
        }

        private void sepete_git_Click(object sender, EventArgs e)
        {
            Sepet sepet = new Sepet();
            sepet.Show();
            this.Hide();
        }

        private void label62_Click(object sender, EventArgs e)
        {
            
        }
    }
}
