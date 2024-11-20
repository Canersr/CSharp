using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_10_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = char.IsDigit(e.KeyChar);


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
           // e.Handled = char.IsDigit(e.KeyChar); //sadece harf girmesine yarıyor
        }
        string harf; int ortalama;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ADINIZI VE SOYADINIZI GIRINIZ!");
            }
            else
                if (textBox2.Text == "")
                {
                    MessageBox.Show("OGRENCININ ORTALAMASINI GIRINIZ!");
                }
                else
                {
                     ortalama = Convert.ToInt32(textBox2.Text);
                    if (ortalama<0 || ortalama > 100)
                    {
                        MessageBox.Show("0-100 ARASINDA NOT GIRINIZ!");
                        return;
                    }
                    if (ortalama >= 0 && ortalama <= 34) { harf = "FF"; }
                    if (ortalama >= 35 && ortalama <= 44) { harf = "FD"; }
                    if (ortalama >= 45 && ortalama <= 54) { harf = "DD"; }
                    if (ortalama >= 55 && ortalama <= 64) { harf = "CC"; }
                    if (ortalama >= 65 && ortalama <= 74) { harf = "CB"; }
                    if (ortalama >= 75 && ortalama <= 84) { harf = "BB"; }
                    if (ortalama >= 85 && ortalama <= 94) { harf = "BA"; }
                    if (ortalama >= 95 && ortalama <= 100) { harf = "AA"; }
                }
            listBox1.Items.Add(textBox1.Text.ToUpper()+" "+ortalama+" "+harf);
        }
    }
}
