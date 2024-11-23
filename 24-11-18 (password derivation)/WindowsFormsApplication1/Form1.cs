using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string sifre_olustur(int seviye)
        {
            string sifre="";
            char[] dizi = "QWERTYUIOPASDFGHJKL".ToArray(); //tochararray() ifadesi de aynı işlevi yapıyor.

            Random rastgele = new Random();

            for (int i = 1; i <= seviye; i++)
            { 
            sifre+=dizi[rastgele.Next(dizi.Count())]; //...(dizi.count()) da kullanabilirdik.
            }
                return sifre;
        }
        int seviye;
        private void button1_Click(object sender, EventArgs e)
        {

           // label1.Text = sifre_olustur();
            //foreach (string benzer in listBox1.Items)
            //{
            //    if (benzer == sifre_olustur())
            //    {
            //        MessageBox.Show("Oluşturulan Şifre Zaten Var.!!!");
            //        return;
            //    }


            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("lütfen bir seçim yapınız");

            }


            if (comboBox1.SelectedIndex == 0) { seviye = 4;}
            if (comboBox1.SelectedIndex == 1) { seviye = 8; }
            if (comboBox1.SelectedIndex == 2) { seviye = 12; }
           
            


            listBox1.Items.Add(sifre_olustur(seviye));
        }
    }
}
