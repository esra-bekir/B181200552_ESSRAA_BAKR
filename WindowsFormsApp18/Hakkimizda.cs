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
using WindowsFormsApp18.Properties;

namespace WindowsFormsApp18
{
    public partial class hakkımızda : Form
    {
        public hakkımızda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var hh = File.ReadLines(@"C:\Users\isra bekir\Desktop\hakkımızda.txt");
            foreach (var ndp in hh)
            {
                listBox1.Items.Add(ndp);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FastFoodUrunleri yeni = new FastFoodUrunleri();
            yeni.Show();
            this.Hide();
        }
    }
}
