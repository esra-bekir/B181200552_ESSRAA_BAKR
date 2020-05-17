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
    public partial class Sepet : Form
    {

        DataTable dtsiparisler;
        public Sepet(DataTable dt)
        {
           
            this.dtsiparisler = dt;
            InitializeComponent();
          
        }

            private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Siparişiniz Başarıyla Alınmıştır en kısa sürede size ulaşacaktır=) \n Afiyet Olsun.");
            Application.Exit();
        }

  


        private void Sepet_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dtsiparisler;//siparişlerin yada seçilen ürünlerin sepette gözükmesine sağlar

            Random rnd = new Random();//fatura numarası
            listBox1.Items.Add(rnd.Next(256485, 12569856));
            


        }

       

        private void button2_Click(object sender, EventArgs e)
        {
           
            
        }

      
        private void pictureBox1_Click(object sender, EventArgs e)
        {

           

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FastFoodUrunleri yenii = new FastFoodUrunleri();
            this.Hide();
            yenii.Show();
        }
    }
}
