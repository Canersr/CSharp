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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        double final,vize,ortalama;
        string ad;
        private void button1_Click(object sender, EventArgs e)
        {
            vize = Convert.ToDouble(comboBox2.Text);
            final = Convert.ToDouble(comboBox3.Text);
            ad = textBox1.Text;
            ortalama = vize * 0.40 + final * 0.60;
            ortalama = Math.Round(ortalama, 1); //küsüratlı ortalamaları küsüratını yazdırmamak için kullanılır
            listBox1.Items.Add(ad + " " + ortalama);
            

        }
        int i;
        private void Form3_Load(object sender, EventArgs e)
        {

            for (i = 1; i <= 10;i++ )
            {
                comboBox2.Items.Add(i * 10);
                comboBox3.Items.Add(i * 10);

            }

        }
    }
}
