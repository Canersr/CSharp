using Microsoft.VisualBasic;
using System.IO;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void faktoriyel(int sayi)
        {
            fakt = 1;
            for (int i = 1; i <= sayi; i++)
            {
                fakt *= i;
            }

            soru = MessageBox.Show(sayi + "! = " + fakt, "SONU�", MessageBoxButtons.YesNo);
            if (soru == DialogResult.Yes)
            {
                soru2 = MessageBox.Show(sayi + "! = " + fakt +
                    "\nSonucu 'bilgiler.txt' dosyas�na kaydedilsin mi?", "SONU�",
                    MessageBoxButtons.YesNo);

                if (soru2 == DialogResult.Yes)
                {
                    // Dosyaya yaz
                    StreamWriter kaydet = File.AppendText("bilgiler.txt");
                    kaydet.WriteLine(sayi + "! = " + fakt + "   Tarih:" + DateTime.Now);
                    kaydet.Close();

                    MessageBox.Show("Bilgiler ba�ar�yla kaydedildi!");

                    // ListBox'a ekle
                    listBox1.Items.Clear(); // �nce eski verileri temizle
                    StreamReader oku = File.OpenText("bilgiler.txt");
                    while ((sonuc = oku.ReadLine()) != null)
                    {
                        listBox1.Items.Add(sonuc);
                    }
                    oku.Close();
                }
            }
        }

        string sonuc;
        int fakt;
        DialogResult soru, soru2;

        private void Form1_Load(object sender, EventArgs e)
        {
            while (true)
            {
                string input = Interaction.InputBox("Say� Giriniz", "Say�");

              
                if (string.IsNullOrWhiteSpace(input)) //innullorwhitespace kodu kullan�c�n�n girdi�i de�erin bo� olup olmad���n� kontrol eder
                {
                    MessageBox.Show("Giri� i�lemi iptal edildi.");
                    Application.Exit();
                    break;
                }

                // Say�n�n do�rulu�unu kontrol et
                if (int.TryParse(input, out int sayi))
                {
                    if (sayi >= 1 && sayi <= 10)
                    {
                        faktoriyel(sayi);
                        break;
                    }
                    else
                    {
                        MessageBox.Show("1-10 aras�nda bir rakam giriniz!");
                    }
                }
                else
                {
                    MessageBox.Show("Ge�erli bir say� girmeniz gerekmektedir!");
                }
            }
        }

        
    }
}
