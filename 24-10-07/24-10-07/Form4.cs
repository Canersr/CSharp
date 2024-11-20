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
namespace _24_10_07
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Bir ders adi seciniz");
                return;
            }

            listBox2.Items.Add(listBox1.Text);
            listBox1.Items.Remove(listBox1.Text);


        }
        int i;
        private void button2_Click(object sender, EventArgs e)
        {
            for (i = 0; i < listBox1.Items.Count; i++)
            {
                listBox2.Items.Add(listBox1.Items [i] );
            }
            listBox1.Items.Clear();
        }
        DialogResult soru;
        private void button3_Click(object sender, EventArgs e)
        {

            soru = MessageBox.Show("bilgiler kaydedilsin mi ?","KAYIT",MessageBoxButtons.YesNo);

            if (soru == DialogResult.Yes)
            {
                StreamWriter kaydet = new StreamWriter("bilgiler.txt",true); // true ifadesi =eğer dosya oluşturur ve kaldığı yerden devam eder
                kaydet.WriteLine(DateTime.Now+" "+"tarihli bilgiler");
                kaydet.WriteLine("---------------------");

                foreach ( string veriler in listBox2.Items) //sınavda çıkacak
                {
                    kaydet.WriteLine(veriler);
                }
                
                
                kaydet.WriteLine("---------------------");
                kaydet.Close();
                MessageBox.Show("Bilgiler başarıyla kaydedildi");


                
            }

        }
    }
}
