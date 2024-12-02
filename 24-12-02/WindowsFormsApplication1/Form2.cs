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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 mesajlar = new Class1();
            mesajlar.mesaj1();
            mesajlar.mesaj2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) == true)
            {
                MessageBox.Show("DIKDORTGENIN KISA KENARINI GIRINIZ");
                return;
            }
            if (String.IsNullOrEmpty(textBox2.Text) == true)
            {
                MessageBox.Show("DIKDORTGENIN UZUN KENARINI GIRINIZ");
                return;
            }
            hesapla alancevre = new hesapla();
            int kkenar = Convert.ToInt32(textBox1.Text);
            int ukenar = Convert.ToInt32(textBox2.Text);
            label1.Text="DIKDORTGENIN ALANI "+alancevre.alan(kkenar,ukenar);
            label2.Text = "DIKDORTGENIN CEVRESI " + alancevre.cevre(kkenar,ukenar);        
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
