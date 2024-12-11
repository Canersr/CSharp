using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_12_10_Flash_Multimedya
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Random renkler = new Random();
            int a = renkler.Next(0,255);
            int b = renkler.Next(0, 255);
            int c = renkler.Next(0, 255);
            int d = renkler.Next(0, 255);
            label1.ForeColor = Color.FromArgb(a,b,c,d);
  //        label1.BackColor = Color.FromArgb(a,b,c,d);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
