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
using System.IO;

namespace WindowsFormsApp18.Properties
{
    public partial class FastFoodUrunleri : Form
    {
        public FastFoodUrunleri()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DenizYemekleri balıklar = new DenizYemekleri();
            this.Hide();
            balıklar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {   //butona tıklandığında tatlılar ve deniz ürünlri gözükmez ama fastfood gözüküsün.

            v.Visible = false;
            groupBox1.Visible = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {// butona tıklandığında   deniz ürünleri ve fastfood gözükmez ama tatlılar gözüküsün.
            v.Visible = true;
            groupBox1.Visible = false;

        }
        FastfoodYemekleri pizza;
        FastfoodYemekleri cheeseburger;
        FastfoodYemekleri nuget;
        private void Form2_Load(object sender, EventArgs e)
        {
            cheeseburger = new FastfoodYemekleri();
            cheeseburger.setAgirlik(100);
            cheeseburger.setKalori(303.1f);
            cheeseburger.setFiyat(18.99f);
            cheeseburger.kolesterol = 41;
            cheeseburger.Kalsiyum = 191;
            cheeseburger.alarji_yapabilecek_urunler = "yumurta\npatates\ndomates\nbiber ";

            label1.Text = cheeseburger.agirlik.ToString();
            label2.Text = cheeseburger.kalori.ToString();
            label3.Text = cheeseburger.kolesterol.ToString();
            label6.Text = cheeseburger.Kalsiyum.ToString();
            richTextBox1.Text = cheeseburger.alarji_yapabilecek_urunler.ToString();

            pizza = new FastfoodYemekleri();
            pizza.setAgirlik(100);
            pizza.setFiyat(29.99F);
            pizza.setKalori(266);
            pizza.kolesterol = 17;
            pizza.Kalsiyum = 188;
            pizza.alarji_yapabilecek_urunler = "yumurta\ndomates\nbiber ";

            label4.Text = pizza.getAgirlik();
            label5.Text = pizza.getKalori();
            label16.Text = pizza.kolesterol.ToString();
            label30.Text = pizza.Kalsiyum.ToString();
            richTextBox2.Text = pizza.alarji_yapabilecek_urunler.ToString();

            nuget = new FastfoodYemekleri();
            nuget.agirlik = 100;
            nuget.kalori = 225;
            nuget.setFiyat(14.99f); // bak buraya  simdi diyacaksin mademki fiyat bu sekilde ekleyebiliriz neden setFiyat() Kullaniyoruz 

            // CEVAP : GENELDE class ozellikleri genelde private oluyr yani bu sekilde 
            nuget.kolesterol = 17;
            nuget.Kalsiyum = 188;
            nuget.alarji_yapabilecek_urunler = "yumurta\ndomates\nbiber\nayçiçekyağı ";


            label17.Text = nuget.agirlik.ToString();
            label18.Text = nuget.kalori.ToString();
            label19.Text = nuget.kolesterol.ToString();
            label29.Text = nuget.Kalsiyum.ToString();
            richTextBox3.Text = nuget.alarji_yapabilecek_urunler.ToString();


            tatlılar anteplimakaron = new tatlılar();
            anteplimakaron.şekeroranı = "36 g";
            anteplimakaron.vitamenA = "330 IU";
            anteplimakaron.yapılış_tarihi = DateTime.Now.ToString();
            anteplimakaron.alarji_yapabilecek_urunler = "süt\nyumurta";

            label83.Text = anteplimakaron.şekeroranı.ToString();
            label85.Text = anteplimakaron.vitamenA.ToString();
            label82.Text = anteplimakaron.yapılış_tarihi.ToString();
            richTextBox5.Text = anteplimakaron.alarji_yapabilecek_urunler.ToString();

            tatlılar dağtatlısı = new tatlılar();
            dağtatlısı.şekeroranı = "50 g";
            dağtatlısı.vitamenA = "230 IU";
            dağtatlısı.yapılış_tarihi = DateTime.Now.ToString();
            dağtatlısı.alarji_yapabilecek_urunler = "fındık\nyumurta\n süt\nçikolata,\nçilek";

            label90.Text = dağtatlısı.şekeroranı.ToString();
            label92.Text = dağtatlısı.vitamenA.ToString();
            label89.Text = dağtatlısı.yapılış_tarihi.ToString();
            richTextBox6.Text = dağtatlısı.alarji_yapabilecek_urunler.ToString();

            tatlılar makaron = new tatlılar();
            makaron.şekeroranı = "43 gr";
            makaron.yapılış_tarihi = DateTime.Now.ToString();
            makaron.vitamenA = "280 IU";
            makaron.alarji_yapabilecek_urunler = "süt tozu\n fındık ";

            label75.Text = makaron.şekeroranı.ToString();
            label77.Text = makaron.vitamenA.ToString();
            label74.Text = makaron.yapılış_tarihi.ToString();
            richTextBox4.Text = makaron.alarji_yapabilecek_urunler.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hakkımızda projem = new hakkımızda();
            this.Hide();
            projem.Show();
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GirisYap yeni = new GirisYap();
            this.Hide();
            yeni.Show();
        }

        double genel_tutar = 0;
        double tutar = 0;
        int p_adet = 0;
        double PizzaTutari;

        int c_adet = 0;
        int N_adet = 0;
        double NugetTutari = 0;
        double ChessburgerTutari = 0;
        private void button6_Click(object sender, EventArgs e)
        {

            c_adet += 1;
            tutar = c_adet * cheeseburger.getFiyat();

            ChessburgerTutari += cheeseburger.getFiyat();
            label38.Text = ChessburgerTutari.ToString();

            label39.Text = c_adet.ToString();
            genel_tutar = ChessburgerTutari;

        }


        private void button7_Click(object sender, EventArgs e)
        {
            p_adet += 1;
            tutar = p_adet * pizza.getFiyat();
            PizzaTutari += pizza.getFiyat();
            label41.Text = PizzaTutari.ToString();

            label42.Text = p_adet.ToString();
            genel_tutar = PizzaTutari;

        }

        private void button8_Click(object sender, EventArgs e)
        {

            N_adet += 1;
            tutar = N_adet * nuget.getFiyat();
            NugetTutari += nuget.getFiyat();
            label45.Text = NugetTutari.ToString();

            label46.Text = N_adet.ToString();
            genel_tutar = NugetTutari;
        }


        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            if (c_adet > 0)
            {

                c_adet--;

                tutar = c_adet * cheeseburger.getFiyat();
                ChessburgerTutari -= cheeseburger.getFiyat();
                label38.Text = ChessburgerTutari.ToString();

                label39.Text = c_adet.ToString();
                genel_tutar = ChessburgerTutari;

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            
        }
       
        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            if (N_adet > 0)
            {

                N_adet--;

                tutar = N_adet * nuget.getFiyat();
                NugetTutari -= nuget.getFiyat();
                label45.Text = NugetTutari.ToString();

                label46.Text = N_adet.ToString();
                genel_tutar = NugetTutari;

            }
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            if (p_adet > 0)
            {

                p_adet--;

                    tutar = p_adet * pizza.getFiyat();
                    PizzaTutari -= pizza.getFiyat();
                    label41.Text = PizzaTutari.ToString();

                    label42.Text = p_adet.ToString();
                    genel_tutar = PizzaTutari;
                }
            }

       
       
        int m_adet = 0;
        double makaronTutari;
        double makaron = 24;
        private void button12_Click(object sender, EventArgs e)
        {
            m_adet += 1;
            tutar = m_adet * makaron;

            makaronTutari += makaron;
            label50.Text = makaronTutari.ToString();

            label51.Text = m_adet.ToString();
            genel_tutar = makaronTutari;
        }
        int anteplimakaron_adet = 0;
        double Antepli_makaronTutari;
        double Antepli_makaron = 24;
        private void button13_Click(object sender, EventArgs e)
        {
           anteplimakaron_adet += 1;
            Antepli_makaronTutari = anteplimakaron_adet * makaron;

            Antepli_makaronTutari += Antepli_makaron;
            label55.Text = makaronTutari.ToString();

            label53.Text = anteplimakaron_adet.ToString();
            genel_tutar = Antepli_makaronTutari;
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
        int Dgıtatlısı_adet = 0;
        double DagıTutarı;
        double Dağıtatliıs = 12;
        private void button9_Click(object sender, EventArgs e)
        {
            Dgıtatlısı_adet += 1;
            DagıTutarı = Dgıtatlısı_adet * Dağıtatliıs;

            DagıTutarı += Dağıtatliıs;
            label59.Text = DagıTutarı.ToString();

            label57.Text = Dgıtatlısı_adet.ToString();
            genel_tutar = Antepli_makaronTutari;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }
    }
    }
