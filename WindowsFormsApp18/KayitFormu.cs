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
using WindowsFormsApp18.Properties;
using System.Globalization;
using System.Threading;
namespace WindowsFormsApp18
{
    public partial class kayıt : System.Windows.Forms.Form
    {
        public kayıt()
        {
            InitializeComponent();

        }
        public void diller(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);

            label1.Text = Localization.label1;
            label3.Text = Localization.label3;
            label4.Text = Localization.label4;
            label5.Text = Localization.label5;
            label6.Text = Localization.label6;
            label9.Text = Localization.label9;
            sartlar_txt.Text = Localization.sartlar_txt;
            KayitOl_Btn.Text = Localization.KayidVar_Btn;
            KayidVar_Btn.Text = Localization.KayidVar_Btn;
            button2.Text = Localization.button2;
            button1.Text = Localization.button1;




        }

        // Kayit Var Bottunu Basinca
        private void KayidVar_Btn_Click(object sender, EventArgs e)
        {
            GirisYap KayitForm = new GirisYap();
            KayitForm.Show();
            this.Hide();
        }

        // Program Kapatma metodu
       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Giris Yap Bottunu Basinca
        private void KayitOl_Btn_Click(object sender, EventArgs e)
        {
            bool formDogrumu = true;
            if (sartlar_checkbox.Checked == false)
            {
                MessageBox.Show("Lutfen Sartlar Kabuul Et");
                formDogrumu = false;
            }
            //if (kullanci_box.Text.ToString() == "")
            //{
            //    MessageBox.Show("Lutfen Kullanci Adi Giriniz.");
            //    formDogrumu = false;
            //}
            //if (email_box.Text.ToString() == "")
            //{
            //    MessageBox.Show("Lutfen Eposta Giriniz.");
            //    formDogrumu = false;
            //}
            if (sifre_box.Text.ToString() == "" || sifre_tekrarlama_box.Text.ToString() == "")
            {
                MessageBox.Show("Lutfen Sifre Giriniz.");
                formDogrumu = false;
            }
            if (sifre_box.Text.ToString() != sifre_tekrarlama_box.Text.ToString())
            {
                MessageBox.Show("Sifreler bir birine benzemiyor .");
                formDogrumu = false;
            }

            if (formDogrumu == true)
            {
                FastFoodUrunleri yeni = new FastFoodUrunleri();
                yeni.Show();
                this.Hide();
            }
           
        }
       

        private void sartlar_txt_Click(object sender, EventArgs e)
        {
            if (sartlar_checkbox.Checked == true)
            {
                sartlar_checkbox.Checked= false;
            }
            else
            {
                sartlar_checkbox.Checked = true;
            }
        }

        private void kayıt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            diller("en-US");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            diller("");
        }
    }
}
