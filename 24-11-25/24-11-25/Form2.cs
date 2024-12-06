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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

      
        
        private void button1_Click(object sender, EventArgs e)
        {
        Random s1=new Random();

        textBox1.Text = s1.Next(1, 49).ToString();
        textBox2.Text = s1.Next(1, 49).ToString();
        textBox3.Text = s1.Next(1, 49).ToString();
        textBox4.Text = s1.Next(1, 49).ToString();
        textBox5.Text = s1.Next(1, 49).ToString();
        textBox6.Text = s1.Next(1, 49).ToString();
        textBox7.Text = s1.Next(1, 49).ToString();
            
        }
    }
}
