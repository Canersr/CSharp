using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_09_30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Int32 soru;

        private void button1_Click(object sender, EventArgs e)
        {

            soru = Convert.ToInt32(MessageBox.Show("PROGRAM KAPATILSIN MI?", "KAPAT",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2));

            if (soru == 6)
            {
                Application.Exit();
                //this.Close;
            }




        }

        DialogResult cikis;

        private void button2_Click(object sender, EventArgs e)
        {
            // BU YÖNTEM C# IN KENDİ METODUDUR
            cikis = MessageBox.Show("PROGRAM KAPATILSIN MI?", "KAPAT",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (cikis == DialogResult.Yes)
            {
                Application.Exit();
                //this.Close;
            }

        }

        void bilgi(string adi, string soyadi)
        {
            textBox3.Text = "GELEN DEGERLER: " + adi + " " + soyadi;
            label1.Text = "gelen degerler: " + adi + " " + soyadi;
            MessageBox.Show("gelen degerler: " + adi + " " + soyadi);
        }

        void temizle()
        {
            textBox1.Text = "";
            textBox1.Clear();
            textBox1.Focus();
            textBox3.Clear();
            label1.Text = "";
        }
        string adi;
        string soyadi;
        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("MUSTERININ ADINI YAZINIZ");
                textBox1.Focus();
                
            }
            else

                if (textBox2.Text.Trim() == "")
                {
                MessageBox.Show("MUSTERININ SOYADINI YAZINIZ");
                textBox2.Focus();
                
                }

                else
                {
                    adi = textBox1.Text.ToUpper().Trim();
                    soyadi = textBox2.Text.ToUpper().Trim();
                    bilgi(adi, soyadi);
                }


        }
        
        //fonksiyon oluşturma
        double hesapla(double a, double b)
        {
            double toplam = a + b;
            return toplam;
        }
        double a, b;
        private void button4_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox1.Text);
            textBox3.Text = "Toplamın sonucu : " + hesapla(a,b);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Form2 siyah = new Form2();
            siyah.ShowDialog();

        }
    }
}

        
    

