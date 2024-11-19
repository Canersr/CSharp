using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;  //DOSYA OKUMA VEYA YAZMA İÇİN

namespace ILK_UYGULAMAM_IO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                sigorta = checkBox1.Text;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar > 47 && e.KeyChar < 58 || e.KeyChar == 8)
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }



        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 47 && e.KeyChar < 58 || e.KeyChar == 8)
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 64 || e.KeyChar < 91 && e.KeyChar == 8)
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 64 || e.KeyChar < 91 && e.KeyChar == 8)
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
           // comboBox1.Items.Add("IZMIR");
            //comboBox1.Items.Add("MUGLA");
            //comboBox1.Items.Add("ANTALYA");
            //comboBox1.Items.Add("ANKARA");
            //comboBox1.Sorted = true;

            //VEYA

            string[] iller = {"ANKARA","IZMIR","ANTALYA" };

            comboBox1.Items.AddRange(iller);
            comboBox1.Sorted = true;
        }
        string sigorta;
        Int32 gelir, gider, fark;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            comboBox2.Items.Clear();
            if (comboBox1.SelectedIndex == 0)//ankara
            {
                comboBox2.Items.AddRange(File.ReadAllLines(@"blg\\ank.txt",Encoding.Default));
            }
            if (comboBox1.SelectedIndex == 1)//antalya
            {
                comboBox2.Items.AddRange(File.ReadAllLines(@"blg\\ant.txt",Encoding.Default));
            }
            if (comboBox1.SelectedIndex == 2)//izmir
            {
                comboBox2.Items.AddRange(File.ReadAllLines(@"blg\\i.txt", Encoding.Default));
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                textBox3.PasswordChar = '*';
            }
            else
            {
                textBox3.PasswordChar = '\0';
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                sigorta = checkBox2.Text;
                checkBox1.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                sigorta = checkBox3.Text;
                checkBox2.Checked = false;
                checkBox1.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ADINI GIRINIZ...", "HATA");
                return;
            }
            if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("SOYADINI GIRINIZ...", "HATA");
                return;
            }

            if (checkBox1.Checked == false &&
                checkBox2.Checked == false &&
                checkBox3.Checked == false)
            {
                MessageBox.Show("SIGORTA TURUNU GIRINIZ...", "HATA");
                return;
            }

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("LUTFEN MEMLEKETI SECINIZ...", "HATA");
                return;

            }

            //HESAP

            gelir = Convert.ToInt32(textBox3.Text);
            gider = Convert.ToInt32(textBox3.Text);
            fark = gelir - gider;
            //KAYIT

            listBox1.Items.Add(textBox1.Text + " " + textBox2.Text + " " + sigorta +
                " " + comboBox1.SelectedItem + " " + comboBox2.SelectedItem + " " + fark.ToString("c2"));
        }
    }
}
