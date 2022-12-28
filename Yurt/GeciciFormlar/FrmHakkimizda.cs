using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yurt.GeciciFormlar
{
    public partial class FrmHakkimizda : Form
    {
        public FrmHakkimizda()
        {
            InitializeComponent();
        }
        int sayac = 1;
        private void FrmHakkimizda_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Üniversite eğitimi gençlerimizin hayatlarındaki en önemli dönüm noktalarından birisi. Okulları, bölümleri ve aldıkları eğitimler kadar barınma ve konaklama konusu da gençlerimizin öncelikleri arasında yer alıyor.Evlerimizden uzak da olsak ev ortamı bulmak,güvenli bir şekilde konaklamak tüm öğrencilerin isteği ve hakkıdır.\r\nBiz de Yurt Yönetimi olarak üniversite eğitimleri boyunca onlara konfor düzeyi yüksek, temiz, güvenli, ev sıcaklığında barınma ve konaklama imkânı sunmak için yükseköğrenim öğrenci yurdu kurduk. İlk kez 2020 yılında hizmete açtığımız yükseköğrenim öğrenci yurtlarımızda geleceğimizin güvencesi olan gençlerimize ev sahipliği yapıyor, onları en iyi şekilde ağırlamaya gayret ediyoruz.Gençlerimizin eğlenebileceği,konaklayabileceği bir ortam için var gücümüzle çalışıyoruz ve her gün üstüne koyuyoruz";
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sayac > 1)
            {
                sayac--;
                label1.Text=sayac.ToString();   
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sayac <= 4)
            {
                sayac++;
                label1.Text = sayac.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            if(label1.Text== "1") {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible= false;
                pictureBox4.Visible = false;
            
            }
            else if(label1.Text== "2")
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
            }
            else if(label1.Text == "3")
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
            }
            else
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
        }
    }
}
