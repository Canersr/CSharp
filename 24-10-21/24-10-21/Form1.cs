using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_10_21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar);
        }

       public static double miktar; //projenin her formunda miktar değişkenini kullanmk için yazılır
       public static Int32 taksitsayisi;
       public static double tutar;
       int i;
       DialogResult soru;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("LUTFEN TOPLAM  BORC TUTARINI GIRINIZ.!.");
                textBox1.Focus();
                return;
            }
            if (radioButton1.Checked) { taksitsayisi = 2; }
            if (radioButton2.Checked) { taksitsayisi = 3; }
            if (radioButton3.Checked) { taksitsayisi = 4; }
            if (radioButton4.Checked) { taksitsayisi = 5; }
            if (radioButton5.Checked) { taksitsayisi = 6; }
            if (radioButton6.Checked) { taksitsayisi = 7; }
            if (radioButton7.Checked) { taksitsayisi = 8; }

             
            miktar = Convert.ToDouble(textBox1.Text);
            tutar = (miktar / taksitsayisi);
            tutar = Math.Round(tutar,2);

            soru = MessageBox.Show(miktar.ToString("C2")+
                " TUTARINDAKI BORC "+taksitsayisi+" AY TAKSIT ILE"+" AYLIK "+tutar.ToString("C2")+
               " ODEME HESAPLAMALASI AKTARILSIN MI","TAKSITLENDIRME",MessageBoxButtons.YesNo,MessageBoxIcon.Question );
           
            
            if (soru == DialogResult.Yes)
            {
                Form2 goster = new Form2();
                goster.ShowDialog();
               
            }
            else
            {
                textBox1.Clear();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
            }
          //MessageBox.Show(tutar.ToString());      

        }
    }
}
