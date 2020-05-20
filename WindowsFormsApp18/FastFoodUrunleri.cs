/****************************************************************************
**                             SAKARYA ÜNİVERSİTESİ
**                  BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                   BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**                      NESNEYE DAYALI PROGRAMLAMA DERSİ
**                       2019-2020 BAHAR DÖNEMİ
**
**                         PROJE NUMARASI.........:2_ Proje
**                          ÖĞRENCİ ADI............: ESSRAA BAKR
**                           ÖĞRENCİ NUMARASI.......: B181200552
**                               DERSİN ALINDIĞI GRUP...: A
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
using System.Globalization;
using System.Threading;
using System.IO;
using System.Drawing.Text;



namespace WindowsFormsApp18.Properties
{
    public partial class FastFoodUrunleri : Form
    {
        readonly List<FastFoodUrunleri> siparislerim;

        public FastFoodUrunleri()
        {
            InitializeComponent();
        }

        public void diller(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();// EN_ TR ÇEVRİ
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);

            label72.Text = Resource1.label72;
            label76.Text = Resource1.label76;
            label78.Text = Resource1.label78;
            label73.Text = Resource1.label73;
            label79.Text = Resource1.label79;
            label49.Text = Resource1.label49;
            label44.Text = Resource1.label44;
            label61.Text = Resource1.label61;
            label64.Text = Resource1.label64;
            label69.Text = Resource1.label69;
            button3.Text = Resource1.button3;
            button1.Text = Resource1.button1;
            button5.Text = Resource1.button5;
            label31.Text = Resource1.label31;
            label32.Text = Resource1.label32;
            label131.Text = Resource1.label31;
            label35.Text = Resource1.label35;
            label34.Text = Resource1.label34;
            label87.Text = Resource1.label87;
            label113.Text = Resource1.label113;
            label112.Text = Resource1.label112;
            label80.Text = Resource1.label80;
            label105.Text = Resource1.label105;
            label126.Text = Resource1.label126;
            label136.Text = Resource1.label136;
            label184.Text = Resource1.label184;
            label193.Text = Resource1.label193;
            label204.Text = Resource1.label204;
            label128.Text = Resource1.label128;
            label107.Text = Resource1.label107;
            label147.Text = Resource1.label147;
            label186.Text = Resource1.label186;
            label195.Text = Resource1.label195;
            label206.Text = Resource1.label206;
            label123.Text = Resource1.label123;
            label102.Text = Resource1.label102;
            label97.Text = Resource1.label97;
            label181.Text = Resource1.label181;
            label190.Text = Resource1.label190;
            label201.Text = Resource1.label201;
            label121.Text = Resource1.label121;
            label175.Text = Resource1.label175;
            label145.Text = Resource1.label145;
            label116.Text = Resource1.label116; 
            label91.Text = Resource1.label91;
            label122.Text = Resource1.label122;
            label161.Text = Resource1.label161;
            label177.Text = Resource1.label177;
            label146.Text = Resource1.label146;
            label117.Text = Resource1.label117;
            label53.Text = Resource1.label53;
            label148.Text = Resource1.label148;
            label110.Text = Resource1.label110;
            label69.Text = Resource1.label69;
            label197.Text = Resource1.label197;
            label196.Text = Resource1.label196;
            label207.Text = Resource1.label207;
         




        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }




        FastfoodYemekleri pizza;
        FastfoodYemekleri cheeseburger;
        FastfoodYemekleri nuget;
        tatlılar makaron;
        tatlılar anteplimakaron;
        tatlılar dagitatlisi;
        DenizUrunleri salamun;
        DenizUrunleri capura;
        DenizUrunleri hamsi; //  Bu genel  (global) degisken // tum projede calisir
        DenizUrunleri levrek;
        DenizUrunleri lufer;
        DenizUrunleri mezgit;
        int p_adet = 0;//pizza adet  globel değşken tanımlama
        int c_adet = 0;// chessburger adet globel değşken tanımlama
        int N_adet = 0;//  nugit adat globel değşken tanımlama
        int Dgıtatlısı_adet = 0;
        int m_adet = 0;//globel değşeken tanımlama    
        int anteplimakaron_adet = 0;//globel değşeken tanımlama
        int salamun_adet = 0;
        int capura_adet = 0;
        int Hamsi_adet = 0;
        int mezgit_adet = 0;
        int lufer_adet = 0;
        int levrel_adet = 0;
        double genel_tutar = 0;


        DataTable dtFatura;


        private void Form2_Load(object sender, EventArgs e)
        {
            cheeseburger = new FastfoodYemekleri();
            cheeseburger.setAgirlik(100); //Private/ OLARAK TANIMLADIĞIMIZ İÇİN set ve geti kullandık
            cheeseburger.setKalori(303.1f);
            cheeseburger.setFiyat(24.5f);
            cheeseburger.kolesterol = 41;
            cheeseburger.Kalsiyum = 191;
            cheeseburger.alarji_yapabilecek_urunler = "yumurta\npatates\ndomates\nbiber ";

            label1.Text = cheeseburger.getAgirlik();//labılara yazdırma işlemi
            label2.Text = cheeseburger.getKalori();//labılara yazdırma işlemi
            label3.Text = cheeseburger.getkolestirol();//labılara yazdırma işlemi
            label6.Text = cheeseburger.getKalsiyum();//labılara yazdırma işlemi

            richTextBox1.Text = cheeseburger.alarji_yapabilecek_urunler.ToString();//labılara yazdırma işlemi

            pizza = new FastfoodYemekleri();
            pizza.setAgirlik(100);//setagrılığı privet olarak tanımladığımız için kullandık
            pizza.setFiyat(29.99F);//setfiyat privet olarak tanımladığımız için kullandık
            pizza.setKalori(266);//setakalori privet olarak tanımladığımız için kullandık
            pizza.kolesterol = 17;
            pizza.Kalsiyum = 188;
            pizza.alarji_yapabilecek_urunler = "yumurta\ndomates\nbiber ";

            label4.Text = pizza.getAgirlik();//labılara yazdırma işlemi
            label5.Text = pizza.getKalori();//labılara yazdırma işlemi
            label16.Text = pizza.getkolestirol();//labılara yazdırma işlemi
            label30.Text = pizza.getKalsiyum();//labılara yazdırma işlemi
            richTextBox2.Text = pizza.alarji_yapabilecek_urunler.ToString();//labılara yazdırma işlemi

            nuget = new FastfoodYemekleri();//yeni nesne mirası kullanarak yemekler clasından getirdim 
            nuget.agirlik = 100;//değer tanımlama
            nuget.kalori = 225;//değer tanımlama
            nuget.kolesterol = 26;
            nuget.Kalsiyum = 12;
            nuget.setFiyat(14.99f);  //  GENELDE class ozellikleri genelde private oluyr yani bu sekilde           
            nuget.alarji_yapabilecek_urunler = "yumurta\ndomates\nbiber\nayçiçekyağı ";
            label17.Text = nuget.getAgirlik();//labılara yazdırma işlemi
            label18.Text = nuget.getKalori();//labılara yazdırma işlemi
            label19.Text = nuget.getkolestirol();//labılara yazdırma işlemi
            label29.Text = nuget.getKalsiyum();//labılara yazdırma işlemi
            richTextBox3.Text = nuget.alarji_yapabilecek_urunler.ToString();

            //tatlılar/anteplimakaron
            anteplimakaron = new tatlılar();//yeni nesne mirası kullanarak yemekler clasından getirdim hocam
            anteplimakaron.şekeroranı = "36";
            anteplimakaron.vitamenA = "330 IU";
            anteplimakaron.yapılış_tarihi = DateTime.Now.ToString();
            anteplimakaron.alarji_yapabilecek_urunler = "süt\nyumurta";
            anteplimakaron.setFiyat(59.99f);

            label83.Text = anteplimakaron.getsekerorani();
            label85.Text = anteplimakaron.getvitamenA();
            label82.Text = anteplimakaron.getyapılış_tarihi();
            richTextBox5.Text = anteplimakaron.alarji_yapabilecek_urunler.ToString();

            //tatlılar/dağıtatlısı
            dagitatlisi = new tatlılar();//yeni nesne mirası kullanarak yemekler clasından getirdim 
            dagitatlisi.şekeroranı = "50";
            dagitatlisi.vitamenA = "230";
            dagitatlisi.yapılış_tarihi = DateTime.Now.ToString();
            dagitatlisi.alarji_yapabilecek_urunler = "fındık\nyumurta\n süt\nçikolata,\nçilek";
            dagitatlisi.setFiyat(14.5f);

            label90.Text = dagitatlisi.getsekerorani();
            label92.Text = dagitatlisi.getvitamenA();
            label89.Text = dagitatlisi.getyapılış_tarihi();
            richTextBox6.Text = dagitatlisi.alarji_yapabilecek_urunler.ToString();

            //tatlılar/makaron
            makaron = new tatlılar();//yeni nesne mirası kullanarak yemekler clasından getirdim hocam
            makaron.şekeroranı = "43";
            makaron.yapılış_tarihi = DateTime.Now.ToString();
            makaron.vitamenA = "280 IU";
            makaron.alarji_yapabilecek_urunler = "süt tozu\n fındık ";
            makaron.setFiyat(49.99f);
            label75.Text = makaron.getsekerorani();
            label77.Text = makaron.getvitamenA();//atamış olduğum vitamin A degerini getirip ve tatlılar sınıfında taımladığım A vitamin
            label74.Text = makaron.getyapılış_tarihi().ToString();
            richTextBox4.Text = makaron.alarji_yapabilecek_urunler.ToString();//convert işlemi double olarak tanımlamıştım

            //deniz ürünleri/ salamun
            salamun = new DenizUrunleri();
            salamun.agirlik = 2000;
            salamun.protein = 18.65f;
            salamun.yag = 10.63f;
            salamun.setFiyat(79.99f);

            label18.Text = salamun.getAgirlik();
            label50.Text = salamun.getProten();
            label17.Text = salamun.getYag();

            //deniz ürünleri/ mezgit

            mezgit = new DenizUrunleri();
            mezgit.agirlik = 2000;
            mezgit.protein = 18.65f;
            mezgit.yag = 10.63f;
            mezgit.setFiyat(29.99f);

            label90.Text = mezgit.getAgirlik();
            label92.Text = mezgit.getProten();
            label89.Text = mezgit.getYag();

            //deniz ürünleri/Hamsi
            hamsi = new DenizUrunleri();
            hamsi.agirlik = 2000;
            hamsi.protein = 18.65f;
            hamsi.yag = 10.63f;

            hamsi.setFiyat(49.99f);
            label69.Text = hamsi.getAgirlik();
            label93.Text = hamsi.getProten();
            label300.Text = hamsi.getYag();

            //deniz ürünleri/levrek
            levrek = new DenizUrunleri();
            levrek.agirlik = 2300f;
            levrek.protein = 25.235f;
            levrek.yag = 6.2356f;
            levrek.setFiyat(69.99f);

            label32.Text = levrek.getAgirlik();
            label35.Text = levrek.getProten();
            label31.Text = levrek.getYag();

            //deniz ürünleri/çapura
            capura = new DenizUrunleri();
            capura.agirlik = 12300.0f;
            capura.protein = 17.235f;
            capura.yag = 10.3625f;
            capura.setFiyat(69.99f);

            label21.Text = capura.getAgirlik();
            label25.Text = capura.getProten();
            label20.Text = capura.getYag();

            //deniz ürünleri/lufer
            lufer = new DenizUrunleri();
            lufer.agirlik = 7500;
            lufer.protein = 19.9329f;
            lufer.yag = 10.4315f;
            lufer.setFiyat(49.99f);
            label50.Text = lufer.getAgirlik();
            label41.Text = lufer.getProten();
            label38.Text = lufer.getYag();

            dtFatura = new DataTable();
            dtFatura.Columns.Add("urunadi");
            dtFatura.Columns.Add("adet");
            dtFatura.Columns.Add("birimfiyat");
            dtFatura.Columns.Add("toplamfiyat");
           

        }

        private void button5_Click(object sender, EventArgs e)
        {
            hakkımızda projem = new hakkımızda();
            this.Hide();
            projem.Show();
        }




        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Sepet sepet = new Sepet(dtFatura);// SEBET SAYFASINA GİT
            sepet.Show();
            this.Hide();
        }

        private int adetAzalt(int adet)
        {// daha sonra kullanacağım müşterin isteğine bağlı ürün azaltma işlemi
            return --adet;
        }
        private int adetArttir(int adet)
        {
            return ++adet;
        }
        
      
       
       
        
     
       
        //makarun adet va fiyat hesaplama alani
        private void tutarmakaronHesaplaVeYazdir(int adet, double fiyat)
        {//oluşturmuş olduğum  deniz yemekleri sınıfından bir metot çağrıp fiyat hesaplyıp kod yardımıyla yazdırmaktadır
            double tutar = adet * fiyat;
            ma_fiyat_lbl.Text = tutar.ToString();
            ma_adet_box.Text = adet.ToString();
           

        }
        private void ma_adet_box_TextChanged_1(object sender, EventArgs e)
        {//MA_adet_arttir_btn_Click_1
            //bu alanda değerli müşterinin girdiği herhangi bir adeti  ürünün fiyatına çarpılarak müşteriye fiyatı gösterir

            if (ma_adet_box.Text.ToString() == "")
            {
                m_adet = 0;
            }
            else
            {
                m_adet = Convert.ToInt32(ma_adet_box.Text.ToString());
            }
            double fiyat = makaron.getFiyat();
            this.tutarmakaronHesaplaVeYazdir(m_adet, fiyat);
            
            
        }

        
        private void MA_adet_arttir_btn_Click_1(object sender, EventArgs e)
        {
            //eğer müşteri artıya basarsa  ürünün adadi  ve fiyat da artar 
            m_adet = this.adetArttir(m_adet);
            double fiyat = makaron.getFiyat();
            this.tutarmakaronHesaplaVeYazdir(m_adet, fiyat);
           
        }

        private void ma_adet_azalt_btn_Click_1(object sender, EventArgs e)
        {
            //eğer müşteri eksiye basarsa adet ve fiyat azalır ama müşteri en azından bir adet bu ürününden seçmelidir

            if (m_adet > 0)
            {
                m_adet = this.adetAzalt(m_adet);
                double fiyat = makaron.getFiyat();
                this.tutarmakaronHesaplaVeYazdir(m_adet, fiyat);
                
            }
        }
      
        
        //Anteplimakaron alanı
        private void tutarAnteplimakaronHesaplaVeYazdir(int adet, double fiyat)
        {//oluşturmuş olduğum  deniz yemekleri sınıfından bir metot çağrıp fiyat hesaplyıp kod yardımıyla yazdırmaktadır
            double tutar = adet * fiyat;
            antmak_fiyat_lbl.Text = tutar.ToString();
            antplima_adet_box.Text = adet.ToString();
          
        }

        private void antplima_adet_box_TextChanged_1(object sender, EventArgs e)
        {
            //bu alanda değerli müşterinin girdiği herhangi bir adeti  ürünün fiyatına çarpılarak müşteriye fiyatı gösterir

            if (antplima_adet_box.Text.ToString() == "")
            {
                anteplimakaron_adet = 0;
            }
            else
            {
                anteplimakaron_adet = Convert.ToInt32(antplima_adet_box.Text.ToString());
            }
            double fiyat = anteplimakaron.getFiyat();
            this.tutarAnteplimakaronHesaplaVeYazdir(anteplimakaron_adet, fiyat);
           
        }

        private void AtepliMA_adet_arttir_btn_Click_1(object sender, EventArgs e)
        {
            //eğer müşteri artıya basarsa  ürünün adadi  ve fiyat da artar 
            anteplimakaron_adet = this.adetArttir(anteplimakaron_adet);
            double fiyat = anteplimakaron.getFiyat();
            this.tutarAnteplimakaronHesaplaVeYazdir(anteplimakaron_adet, fiyat);
            
        }

        //dağıtatlısı alanı
        private void daği_adet_azalt_btn_Click_1(object sender, EventArgs e)
        {
            //eğer müşteri eksiye basarsa adet ve fiyat azalır ama müşteri en azından bir adet bu ürününden seçmelidir

            if (anteplimakaron_adet > 0)
            {
                anteplimakaron_adet = this.adetAzalt(anteplimakaron_adet);
                double fiyat = anteplimakaron.getFiyat();
                this.tutarmakaronHesaplaVeYazdir(anteplimakaron_adet, fiyat);
               
            }

        }
        private void tutardagHesaplaVeYazdir(int adet, double fiyat)
        {//oluşturmuş olduğum  deniz yemekleri sınıfından bir metot çağrıp fiyat hesaplyıp kod yardımıyla yazdırmaktadır.
            double tutar = adet * fiyat;
            dagi_fiyat_lbl.Text = tutar.ToString();
            dagi_adet_box.Text = adet.ToString();
        }
        private void dagi_adet_box_TextChanged(object sender, EventArgs e)
        {
            //bu alanda değerli müşterinin girdiği herhangi bir adeti  ürünün fiyatına çarpılarak müşteriye fiyatı gösterir.

            if (dagi_adet_box.Text.ToString() == "")
            {
                Dgıtatlısı_adet = 0;
            }
            else
            {
                Dgıtatlısı_adet = Convert.ToInt32(dagi_adet_box.Text.ToString());
            }
            double fiyat = dagitatlisi.getFiyat();
            this.tutardagHesaplaVeYazdir(Dgıtatlısı_adet, fiyat);
        }

        private void dagi_adet_arttir_btn_Click_1(object sender, EventArgs e)
        {
            //eğer müşteri artıya basarsa  ürünün adadi  ve fiyat da artar.
            Dgıtatlısı_adet = this.adetArttir(Dgıtatlısı_adet);
            double fiyat = dagitatlisi.getFiyat();
            this.tutardagHesaplaVeYazdir(Dgıtatlısı_adet, fiyat);
        }

        private void dagi_adet_azalt_btn_Click(object sender, EventArgs e)
        {
            //eğer müşteri eksiye basarsa adet ve fiyat azalır ama müşteri en azından bir adet bu ürününden seçmelidir.
            if (Dgıtatlısı_adet > 0)
            {
                Dgıtatlısı_adet = this.adetAzalt(Dgıtatlısı_adet);
                double fiyat = dagitatlisi.getFiyat();
                this.tutardagHesaplaVeYazdir(Dgıtatlısı_adet, fiyat);

            }
        }



        private void button2_Click_1(object sender, EventArgs e)
        {//3 TANE PANEL ÜST ÜSTE KOYDUM MÜŞTERİ TATLILARA BASINCA FAASTFOOD ve deniz ürünleri gözükmeyecek VE TERSİ İÇİN GEÇERLİDİR
            tatlılarpaneli.Visible = false;
            panel10.Visible = false;
            fastfood_panel.Visible = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {//3 TANE PANEL ÜST ÜSTE KOYDUM MÜŞTERİ TATLILARA BASINCA FAASTFOOD ve deniz ürünleri gözükmeyecek VE TERSİ İÇİN GEÇERLİDİR

            fastfood_panel.Visible = false;
            panel10.Visible = false;
            tatlılarpaneli.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           // DenizYemekleri yeni = new DenizYemekleri();
            //this.Hide();
            //yeni.Show();

            panel10.Visible = true;
            fastfood_panel.Visible = false;
            tatlılarpaneli.Visible = false;

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        //CHESSBURGER. alanı11
        private void TutarCHESSBURGERHesaplaVeYazdir(int adet, double fiyat)
        {//oluşturmuş olduğum  deniz yemekleri sınıfından bir metot çağrıp fiyat hesaplyıp kod yardımıyla yazdırmaktadır
            double tutar = adet * fiyat;
            CH_fiyat_lbl.Text = tutar.ToString();
            CH_adet_box.Text = adet.ToString();
            genel_tutar = tutar;
        }
        private void ch_adet_arttir_btn_Click(object sender, EventArgs e)
        {
            //eğer müşteri artıya basarsa  ürünün adadi  ve fiyat da artar 
            c_adet = this.adetArttir(c_adet);
            double fiyat = cheeseburger.getFiyat();
            this.TutarCHESSBURGERHesaplaVeYazdir(c_adet, fiyat);
        }

        private void ch_adet_azalt_btn_Click(object sender, EventArgs e)
        {
            //eğer müşteri eksiye basarsa adet ve fiyat azalır ama müşteri en azından bir adet bu ürününden seçmelidir

            if (c_adet > 0)
            {
                c_adet = this.adetAzalt(c_adet);
                double fiyat = cheeseburger.getFiyat();
                this.TutarCHESSBURGERHesaplaVeYazdir(c_adet, fiyat);

            }
        }

        private void CH_adet_box_TextChanged(object sender, EventArgs e)
        {
            //bu alanda değerli müşterinin girdiği herhangi bir adeti  ürünün fiyatına çarpılarak müşteriye fiyatı gösterir

            if (CH_adet_box.Text.ToString() == "")
            {
                c_adet = 0;
            }
            else
            {
                c_adet = Convert.ToInt32(CH_adet_box.Text.ToString());
            }
            double fiyat = cheeseburger.getFiyat();
            this.TutarCHESSBURGERHesaplaVeYazdir(c_adet, fiyat);
        }
        //pizza alanı
        private void pizzaHesaplaVeYazdir(int adet, double fiyat)
        {//oluşturmuş olduğum  deniz yemekleri sınıfından bir metot çağrıp fiyat hesaplyıp kod yardımıyla yazdırmaktadır

            double tutar = adet * fiyat;
            pizza_fiyat_lbl.Text = tutar.ToString();
            piz_adet_box.Text = adet.ToString();
        }
        private void piz_adet_box_TextChanged(object sender, EventArgs e)
        {
            //bu alanda değerli müşterinin girdiği herhangi bir adeti  ürünün fiyatına çarpılarak müşteriye fiyatı gösterir


            if (piz_adet_box.Text.ToString() == "")
            {
                p_adet = 0;
            }
            else
            {
                p_adet = Convert.ToInt32(piz_adet_box.Text.ToString());
            }
            double fiyat = pizza.getFiyat();
            this.pizzaHesaplaVeYazdir(p_adet, fiyat);
        }

        private void piz_adet_arttir_btn_Click(object sender, EventArgs e)
        {
            //eğer müşteri artıya basarsa  ürünün adadi  ve fiyat da artar

            p_adet = this.adetArttir(p_adet);
            double fiyat = pizza.getFiyat();
            this.pizzaHesaplaVeYazdir(p_adet, fiyat);
        }

        private void piz_adet_azalt_btn_Click_1(object sender, EventArgs e)
        {
            if (p_adet > 0)
            {
                p_adet = this.adetAzalt(p_adet);
                double fiyat = pizza.getFiyat();
                this.pizzaHesaplaVeYazdir(p_adet, fiyat);
            }
        }

        //nugit alanı

        private void nugitHesaplaVeYazdir(int adet, double fiyat)
        {//oluşturmuş olduğum  deniz yemekleri sınıfından bir metot çağrıp fiyat hesaplyıp kod yardımıyla yazdırmaktadır

            double tutar = adet * fiyat;
            nugit_fiyat_lbl.Text = tutar.ToString();
            nugit_adet_box.Text = adet.ToString();
        }
        private void nugit_adet_box_TextChanged(object sender, EventArgs e)
        {
            //bu alanda değerli müşterinin girdiği herhangi bir adeti  ürünün fiyatına çarpılarak müşteriye fiyatı gösterir

            if (nugit_adet_box.Text.ToString() == "")
            {
                p_adet = 0;
            }
            else
            {
                N_adet = Convert.ToInt32(nugit_adet_box.Text.ToString());
            }
            double fiyat = nuget.getFiyat();
            this.nugitHesaplaVeYazdir(N_adet, fiyat);
        }

        private void nugit_adet_arttir_btn_Click(object sender, EventArgs e)
        {
            //eğer müşteri artıya basarsa  ürünün adadi  ve fiyat da artar 
            N_adet = this.adetArttir(N_adet);
            double fiyat = nuget.getFiyat();
            this.nugitHesaplaVeYazdir(N_adet, fiyat);
        }

        private void nugit_adet_azalt_btn_Click(object sender, EventArgs e)
        {
            if (N_adet > 0)
            {
                N_adet = this.adetAzalt(N_adet);
                double fiyat = nuget.getFiyat();
                this.nugitHesaplaVeYazdir(N_adet, fiyat);
            }
        }
        //DENİZ ÜRÜNLERİ ALANLARI
        //salamun balığı====>
        private void TutarSHesaplaVeYazdir(int adet, double fiyat)
        {//oluşturmuş olduğum  deniz yemekleri sınıfından bir metot çağrıp fiyat hesaplyıp kod yardımıyla yazdırmaktadır
            double tutar = adet * fiyat;
            s_Fiyat_lbl.Text = tutar.ToString();
            s_adet_box.Text = adet.ToString();
        }
        private void s_adet_arttir_btn_Click(object sender, EventArgs e)
        {
            //eğer müşteri artıya basarsa  ürünün adadi  ve fiyat da artar 
            salamun_adet = this.adetArttir(salamun_adet);
            double fiyat = salamun.getFiyat();
            this.TutarSHesaplaVeYazdir(salamun_adet, fiyat);

            //siparislerim.Add(new Siparis()
            //{
            //    adet
            //});
        }

        private void M_adet_azalt_btn_Click(object sender, EventArgs e)
        {
            //eğer müşteri eksiye basarsa adet ve fiyat azalır ama müşteri en azından bir adet bu ürününden seçmelidir

            if (salamun_adet > 0)
            {
                salamun_adet = this.adetAzalt(salamun_adet);
                double fiyat = salamun.getFiyat();
                this.TutarSHesaplaVeYazdir(salamun_adet, fiyat);

            }
        }

        private void s_adet_box_TextChanged(object sender, EventArgs e)
        {
            //bu alanda değerli müşterinin girdiği herhangi bir adeti  ürünün fiyatına çarpılarak müşteriye fiyatı gösterir

            if (s_adet_box.Text.ToString() == "")
            {
                salamun_adet = 0;
            }
            else
            {
                salamun_adet = Convert.ToInt32(s_adet_box.Text.ToString());
            }
            double fiyat = salamun.getFiyat();
            this.TutarSHesaplaVeYazdir(salamun_adet, fiyat);
        }
        // Capure
        private void TutarCHesaplaVeYazdir(int adet, double fiyat)
        {//oluşturmuş olduğum  deniz yemekleri sınıfından bir metot çağrıp fiyat hesaplyıp kod yardımıyla yazdırmaktadır
            double tutar = adet * fiyat;
            cu_fiyat_lbl.Text = tutar.ToString();
            c_adet_box.Text = adet.ToString();
        }

        private void ca_adet_arttir_btn_Click(object sender, EventArgs e)
        {
            //eğer müşteri artıya basarsa  ürünün adadi  ve fiyat da artar 
            capura_adet = this.adetArttir(capura_adet);
            double fiyat = capura.getFiyat();
            this.TutarCHesaplaVeYazdir(capura_adet, fiyat);
        }

        private void ca_adet_azalt_btn_Click(object sender, EventArgs e)
        {
            if (capura_adet > 0)
            {
                capura_adet = this.adetAzalt(capura_adet);
                double fiyat = capura.getFiyat();
                this.TutarCHesaplaVeYazdir(capura_adet, fiyat);
            }
        }

        private void c_adet_box_TextChanged(object sender, EventArgs e)
        {
            //bu alanda değerli müşterinin girdiği herhangi bir adeti  ürünün fiyatına çarpılarak müşteriye fiyatı gösterir
            if (c_adet_box.Text.ToString() == "")
            {
                capura_adet = 0;
            }
            else
            {
                capura_adet = Convert.ToInt32(c_adet_box.Text.ToString());
            }
            double fiyat = capura.getFiyat();
            this.TutarCHesaplaVeYazdir(capura_adet, fiyat);
        }

        // hamsi
        private void TutarHHesaplaVeYazdir(int adet, double fiyat)
        {//oluşturmuş olduğum  deniz yemekleri sınıfından bir metot çağrıp fiyat hesaplyıp kod yardımıyla yazdırmaktadır
            double tutar = adet * fiyat;
            label176.Text = tutar.ToString();
            h_adettxtbox.Text = adet.ToString();
            genel_tutar = fiyat;
        }
        private void ha_adet_arttir_btn_Click(object sender, EventArgs e)
        {
            //eğer müşteri artıya basarsa  ürünün adadi  ve fiyat da artar 
            Hamsi_adet = this.adetArttir(Hamsi_adet);
            double fiyat = hamsi.getFiyat();
            this.TutarHHesaplaVeYazdir(Hamsi_adet, fiyat);
            genel_tutar = fiyat;
        }
        private void ha_adet_azalt_btn_Click(object sender, EventArgs e)
        {
            //eğer müşteri eksiye basarsa adet ve fiyat azalır ama müşteri en azından bir adet bu ürününden seçmelidir
            if (Hamsi_adet > 0)
            {
                Hamsi_adet = this.adetAzalt(Hamsi_adet);
                double fiyat = hamsi.getFiyat();
                this.TutarHHesaplaVeYazdir(Hamsi_adet, fiyat);
                genel_tutar = fiyat;
            }
        }
        private void h_adettxtbox_TextChanged(object sender, EventArgs e)
        {
            //bu alanda değerli müşterinin girdiği herhangi bir adeti  ürünün fiyatına çarpılarak müşteriye fiyatı gösterir
            if (h_adettxtbox.Text.ToString() == "")
            {
                Hamsi_adet = 0;
            }
            else
            {
                Hamsi_adet = Convert.ToInt32(h_adettxtbox.Text.ToString());
            }
            double fiyat = hamsi.getFiyat();
            this.TutarHHesaplaVeYazdir(Hamsi_adet, fiyat);
            genel_tutar = fiyat;
        }

        //Mezgit
        private void TutarMHesaplaVeYazdir(int adet, double fiyat)
        {//oluşturmuş olduğum  deniz yemekleri sınıfından bir metot çağrıp fiyat hesaplyıp kod yardımıyla yazdırmaktadır
            double tutar = adet * fiyat;
            mi_fiyat_lbl.Text = tutar.ToString();
            M_adet_box.Text = adet.ToString();
            genel_tutar = fiyat;

        }
        private void M_adet_box_TextChanged(object sender, EventArgs e)
        {
            //bu alanda değerli müşterinin girdiği herhangi bir adeti  ürünün fiyatına çarpılarak müşteriye fiyatı gösterir
            if (M_adet_box.Text.ToString() == "")
            {
                mezgit_adet = 0;
            }
            else
            {
                mezgit_adet = Convert.ToInt32(M_adet_box.Text.ToString());
            }
            double fiyat = mezgit.getFiyat();
            this.TutarMHesaplaVeYazdir(mezgit_adet, fiyat);
            genel_tutar = fiyat;
        }

        private void mi_adet_arttir_btn_Click(object sender, EventArgs e)
        {
            //eğer müşteri artıya basarsa  ürünün adadi  ve fiyat da artar 
            mezgit_adet = this.adetArttir(mezgit_adet);
            double fiyat = mezgit.getFiyat();
            this.TutarMHesaplaVeYazdir(mezgit_adet, fiyat);
            genel_tutar = fiyat;
        }

        private void mi_adet_azalt_btn_Click(object sender, EventArgs e)
        {
            //eğer müşteri eksiye basarsa adet ve fiyat azalır ama müşteri en azından bir adet bu ürününden seçmelidir
            if (mezgit_adet > 0)
            {
                mezgit_adet = this.adetAzalt(mezgit_adet);
                double fiyat = mezgit.getFiyat();
                this.TutarMHesaplaVeYazdir(mezgit_adet, fiyat);
                genel_tutar = fiyat;
            }
        }
        //lüfer balığının alanı

        private void TutarluHesaplaVeYazdir(int adet, double fiyat)
        {//oluşturmuş olduğum  deniz yemekleri sınıfından bir metot çağrıp fiyat hesaplyıp kod yardımıyla yazdırmaktadır
            double tutar = adet * fiyat;
            lu_fiyat_lbl.Text = tutar.ToString();
            LU_adet_box.Text = adet.ToString();
        }

        private void lu_adet_arttir_btn_Click(object sender, EventArgs e)
        {
            //eğer müşteri artıya basarsa  ürünün adadi  ve fiyat da artar 
            lufer_adet = this.adetArttir(lufer_adet);
            double fiyat = lufer.getFiyat();
            this.TutarluHesaplaVeYazdir(lufer_adet, fiyat);
        }

        private void LU_adet_box_TextChanged(object sender, EventArgs e)
        {
            //bu alanda değerli müşterinin girdiği herhangi bir adeti  ürünün fiyatına çarpılarak müşteriye fiyatı gösterir
            if (LU_adet_box.Text.ToString() == "")
            {
                lufer_adet = 0;
            }
            else
            {
                lufer_adet = Convert.ToInt32(LU_adet_box.Text.ToString());
            }
            double fiyat = lufer.getFiyat();
            this.TutarluHesaplaVeYazdir(lufer_adet, fiyat);
        }

        private void Lu_adet_azalt_btn_Click(object sender, EventArgs e)
        {
            //eğer müşteri eksiye basarsa adet ve fiyat azalır ama müşteri en azından bir adet bu ürününden seçmelidir
            if (lufer_adet > 0)
            {
                lufer_adet = this.adetAzalt(lufer_adet);
                double fiyat = lufer.getFiyat();
                this.TutarluHesaplaVeYazdir(lufer_adet, fiyat);

            }
        }
        //levrek alanı
        private void TutarlvHesaplaVeYazdir(int adet, double fiyat)
        {//oluşturmuş olduğum  deniz yemekleri sınıfından bir metot çağrıp fiyat hesaplyıp kod yardımıyla yazdırmaktadır
            double tutar = adet * fiyat;
            lev_fiyat_lbl.Text = tutar.ToString();
            LV_adet_box.Text = adet.ToString();
        }

        private void le_adet_arttir_btn_Click(object sender, EventArgs e)
        {
            //eğer müşteri artıya basarsa  ürünün adadi  ve fiyat da artar 
            levrel_adet = this.adetArttir(levrel_adet);
            double fiyat = levrek.getFiyat();
            this.TutarlvHesaplaVeYazdir(levrel_adet, fiyat);
        }

        private void LV_adet_box_TextChanged(object sender, EventArgs e)
        {
            //müşterinin eğer birden fazla ürün almak istiyorsa her defasında butona tıklmak yerine tex box içinde yazdığı rakamı===>
            if (LV_adet_box.Text.ToString() == "")//program tarfından ürün adedi olarak algılanıp ve ürün fiyatına çarpılıp son fiyatı lable kısmına yazılmaktadır.
            {
                levrel_adet = 0;
            }
            else
            {
                levrel_adet = Convert.ToInt32(LV_adet_box.Text.ToString());
            }
            double fiyat = levrek.getFiyat();
            this.TutarlvHesaplaVeYazdir(levrel_adet, fiyat);
        }

        private void le_adet_azalt_btn_Click(object sender, EventArgs e)
        {
            //eğer müşteri eksiye basarsa adet ve fiyat azalır ama müşteri en azından bir adet bu ürününden seçmelidir
            if (levrel_adet > 0)
            {
                levrel_adet = this.adetAzalt(levrel_adet);
                double fiyat = levrek.getFiyat();
                this.TutarlvHesaplaVeYazdir(levrel_adet, fiyat);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            kayıt yeni = new kayıt();
            this.Hide();
            yeni.Show();
        }

        void siparisleriHesapla()//data table kullnarak  değerleri sepette gözükmesine sağladım
        {
            //dt, urun adi ,adet, birim fiyat , toplam fiyat /fastfood

            if (CH_adet_box.Text != "0" && CH_adet_box.Text != "")//chesseburger
            {
                dtDoldur(dtFatura, label13.Text, CH_adet_box.Text, label12.Text, CH_fiyat_lbl.Text);
            }
            if (piz_adet_box.Text != "0" && piz_adet_box.Text != "")//pizza
            {
                dtDoldur(dtFatura, label11.Text, piz_adet_box.Text, label10.Text, pizza_fiyat_lbl.Text);
            }
            if (nugit_adet_box.Text != "0" && nugit_adet_box.Text != "")//nugit
            {
                dtDoldur(dtFatura, label9.Text, nugit_adet_box.Text, label8.Text, nugit_fiyat_lbl.Text);
            }
            //dt, urun adi ,adet, birim fiyat , toplam fiyat /tatlılar

            if (ma_adet_box.Text != "0" && ma_adet_box.Text != "")//makaron
            {
                dtDoldur(dtFatura, label64.Text, ma_adet_box.Text, label65.Text, ma_fiyat_lbl.Text);
            }
            if (antplima_adet_box.Text != "0" && antplima_adet_box.Text != "")//antepli makaron
            {
                dtDoldur(dtFatura, label72.Text, antplima_adet_box.Text, label70.Text, antmak_fiyat_lbl.Text);
            }
            if (dagi_adet_box.Text != "0" && dagi_adet_box.Text != "")///dağitatlısı
            {
                dtDoldur(dtFatura, label69.Text, dagi_adet_box.Text, label67.Text, dagi_fiyat_lbl.Text);
            }
            //dt, urun adi ,adet, birim fiyat , toplam fiyat /deniz ürünleri
            if (s_adet_box.Text != "0" && s_adet_box.Text != "")//salamun
            {
                dtDoldur(dtFatura, label170.Text, s_adet_box.Text, s_Fiyat_lbl.Text, mi_fiyat_lbl.Text);
            }
            if (c_adet_box.Text != "0" && c_adet_box.Text != "")//capura
            {
                dtDoldur(dtFatura, label169.Text, c_adet_box.Text, label157.Text, cu_fiyat_lbl.Text);
            }

            if (h_adettxtbox.Text != "0" && h_adettxtbox.Text != "")//hamsi
            {
                dtDoldur(dtFatura, label168.Text, h_adettxtbox.Text, label54.Text, label176.Text);
            }

            if (M_adet_box.Text != "0" && M_adet_box.Text != "")//mezgit
            {
                dtDoldur(dtFatura, label167.Text, M_adet_box.Text, label109.Text, s_Fiyat_lbl.Text);
            }

            if (LU_adet_box.Text != "0" && LU_adet_box.Text != "")//lufer
            {
                dtDoldur(dtFatura, label166.Text, LU_adet_box.Text, label149.Text, lu_fiyat_lbl.Text);
            }

            if (LV_adet_box.Text != "0" && LV_adet_box.Text != "")//levrek
            {
                dtDoldur(dtFatura, label165.Text, LV_adet_box.Text, label151.Text, lev_fiyat_lbl.Text);
            }

        }

        void dtDoldur(DataTable dt, string urunadi, string adet, string birim, string toplam)
        {
            dt.Rows.Add();
            dt.Rows[dt.Rows.Count - 1]["urunadi"] = urunadi;
            dt.Rows[dt.Rows.Count - 1]["adet"] = adet;
            dt.Rows[dt.Rows.Count - 1]["birimfiyat"] = birim;
            dt.Rows[dt.Rows.Count - 1]["toplamfiyat"] = toplam;
        }
        void siparislerimiHesapla()
        {

        }
        private void label61_Click(object sender, EventArgs e)
        {
            siparisleriHesapla();
            Sepet sepet = new Sepet(dtFatura);// SEBET SAYFASINA GİT
            sepet.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/Yemeksepeti/");//sitemizin facebook hesabı
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/yemeksepeti/");
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label147_Click(object sender, EventArgs e)
        {

        }
        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void tatlılarpaneli_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            hakkımızda yeni =new hakkımızda();
            this.Hide();
            yeni.Show();

        }

        

        

        private void pictureBox8_Click_3(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            diller("");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            diller("en-US");
        }
    }
}
