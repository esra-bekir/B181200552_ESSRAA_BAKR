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

namespace WindowsFormsApp18
{
    public partial class GirisYap : Form
    {
        public GirisYap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FastFoodUrunleri heloo = new FastFoodUrunleri();
            this.Hide();
            heloo.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)// formda fazla alan kaplamasın diye 
            {
                richTextBox1.Visible = true;// eger kullancı yeni adres girdirmek istiyorsa bu alan gözükecektir

            }
            else
            {
                richTextBox1.Visible = false;// eğer kullanıcı kayıtlı olan adresini kullanmak istiyorsa bu alanı gizle
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {


        }

       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            kayıt yeni = new kayıt();
            this.Hide();
            yeni.Show();
        }
    }
}
