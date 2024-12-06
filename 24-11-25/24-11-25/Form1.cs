using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_11_25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int sayilar;
        public static int i;
        private void button1_Click(object sender, EventArgs e)
        {

            Random rastgele = new Random();
            StringBuilder olustur = new StringBuilder();
           
            for (i = 1; i <= 6;i++ )
            {
                sayilar = rastgele.Next(65, 90); //ASCII tablosundaki A dan Z ye kadar karakter içeriyor A=65 Z=90 (A VE Z DAHİL)
                char harf = Convert.ToChar(sayilar);
                olustur.Append(harf);
            }

            label1.Text = DateTime.Now.Year + " " + olustur.ToString();
            
            
            




        }

        
    }
}
