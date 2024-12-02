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

        private void timer1_Tick(object sender, EventArgs e)
        {

           //prs =progresbar (ismini biz değiştirdik)
            prs.Value += 2;
            label1.Text = "SISTEM YUKLENIYOR %"+prs.Value;

            if (prs.Value >= 100)
            {
                this.Hide();
                timer1.Enabled = false;
                Form2 goster = new Form2();
                goster.ShowDialog();
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
