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
using Microsoft.VisualBasic; //inputu kullabilmek için bunu yazmak gerekir(bütün dillerde böyle kullanılır)

namespace _24_10_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            //if (textBox1.Text != "")
            //{
            //    if (Convert.ToInt16(textBox1.Text) < 1 || Convert.ToInt32(textBox1.Text) > 9)
            //    {
            //        MessageBox.Show("1-9 arasında sayi giriniz...");
            //        textBox1.Clear();
            //    }
            //}
            }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //if (textBox2.Text != "")
            //{
            //    if (Convert.ToInt16(textBox2.Text) < 1 || Convert.ToInt32(textBox2.Text) > 9)
            //    {
            //        MessageBox.Show("1-9 arasında sayi giriniz...");
            //        textBox2.Clear();
            //    }
            //}
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //if (textBox3.Text != "")
            //{
            //    if (Convert.ToInt16(textBox3.Text) < 1 || Convert.ToInt32(textBox3.Text) > 9)
            //    {
            //        MessageBox.Show("1-9 arasında sayi giriniz...");
            //        textBox3.Clear();
            //    }
            //}
        }
        void temizle()
    {
        textBox1.Clear();
        textBox2.Clear();
        textBox3.Clear();
    }
        double a, b, c, delta, tekkok, x1, x2;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = Convert.ToDouble(textBox3.Text);
                delta = (b * b) - (4 * a * c);

                if (delta < 0)
                {
                    MessageBox.Show("Fonksiyonun reel kökleri yok.");
                }

                if (delta == 0)
                {
                    tekkok = (-1 * b) / (2 * a);
                   
                    StreamWriter kaydet1;
                   kaydet1= File.AppendText("tekkok1.txt");
                   kaydet1.WriteLine("A = "+a+" "+"B = "+b+" "+"C = "+c+" "+"TEKKOK = "+" "+tekkok);
                   kaydet1.WriteLine("------------------------------------");
                   kaydet1.Close();
                   listBox1.Items.Add("A = "+a+" "+"B = "+b+" "+"C = "+c+" "+"TEKKOK = "+" "+tekkok);

                   MessageBox.Show("Kok tekkok.txt dosyasına kaydedilmiştir.");

                }

                if (delta > 0)
                {
                    x1 = ((-1 * b) + Math.Sqrt(delta)) / 2 * a;
                    x2 = ((-1 * b) + Math.Sqrt(delta)) / 2 * a;
                    StreamWriter kaydet2;
                    kaydet2 = File.AppendText("ciftkok.txt");
                    kaydet2.WriteLine("A = " + a + " " + "B = " + b + " " + "C = " + c + " "+"x1 = "+Math.Round(x1,2)+" "+"x2 = "+Math.Round(x2,2));
                    kaydet2.WriteLine("------------------------------------");
                    kaydet2.Close();
                    MessageBox.Show("Kok çiftkok.txt dosyasına kaydedilmiştir.");
                }


            }
            catch
            {
                MessageBox.Show("SAYISAL DEGER GIRINIZ..");
            }
            finally
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }





          

          

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string veriler;
            StreamReader oku;
            listBox2.Items.Clear();
            oku = File.OpenText("ciftkok.txt");

            while (((veriler=oku.ReadLine())!=null ))
            {
                listBox2.Items.Add(veriler);
                
            }
            oku.Close();

            //using Microsoft.VisualBasic; //inputu kullabilmek için bunu yazmak gerekir(bütün dillerde böyle kullanılır)
            // referance> add referance> microsoft.visualbasic ekle
            //inputbox kullanmak için Interaction.InputBox();
            
        }
        Int32 deger;
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                deger = Convert.ToInt32(Interaction.InputBox("Herhangi bir deger giriniz", "SAYI GIRISI", "BURAYA GIRINIZ"));
                textBox4.Text = "GIRILEN SAYI ="+deger;
            }
            catch
            {
                MessageBox.Show("SAYISAL DEGER GIR");

            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
