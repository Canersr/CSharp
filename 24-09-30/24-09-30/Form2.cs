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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Int32 faktoryel(Int32 sayi)
        {
            int fakt = 1;
            int i;
            for (i = 1; i <= sayi; i++)
            {
                fakt *= i;
                
            }
            return fakt;
        }
        Int32 sayi;
        private void button1_Click(object sender, EventArgs e)
        {

            //SORU: Text nesnesine girilen bir sayının faktorielini hesaplayınız
            //özellikler: 1: girilen sayı 1-9 arasında olmalıdır 
        //2: girilen sayı negatif olmamalıdır negatif ise pozitif yapılmalıdır
        //3: girilen sayı faktoriel isimli fonksiyona gönderilerek sonucu mesajla göstermelidir
            sayi = Convert.ToInt32(textBox1.Text);

            if (sayi < 0)
            {
                //sayi *= -1;
                Math.Abs(sayi);
            }
            if (sayi < 1 || sayi > 9)
            {
                MessageBox.Show("1-9 arasında sayi giriniz..");
            }
            else
            {
            MessageBox.Show("sonucun degeri :"+faktoryel(sayi));

            }
        }
    }
}
