namespace Degiskenler_int
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            int sayi;
            sayi= 99;
            label1.Text = sayi.ToString();
            */

            /*
            int sayi1, sayi2, toplam;
            sayi1 = 11;
            sayi2 = 22;
            toplam = sayi1 + sayi2;
            label1.Text = toplam.ToString();
            */

            // Kod kýsmýndan bir kenarý verilen karenin alanýnýn ve çevresinin hesaplanmasý 
            /*
            int kenar, alan, cevre;
            kenar = 10;
            alan = kenar * kenar;
            cevre = kenar * 4;
            label1.Text = "Alan: " + alan + " Çevre: " + cevre;
            */
            
            int uzunkenar, kisakenar, alan, cevre;
            uzunkenar = 20;
            kisakenar = 10;
            alan = uzunkenar * kisakenar;
            cevre = (uzunkenar + kisakenar) * 2;
            label1.Text = "Alan: " + alan + " Çevre: " + cevre;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sinav1, sinav2, sinav3, ortalama;
            sinav1 = 20;
            sinav2 = 10;
            sinav3 = 100;
            ortalama = (sinav1 + sinav2 + sinav3) / 3;
            label2.Text = "Sýnav ortalamasý: " + ortalama;
            MessageBox.Show("Kaldý");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
            int vize, final, proje, ortalama;
            vize = Convert.ToInt32(textBox1.Text);
            final = Convert.ToInt32(textBox2.Text);
            proje = Convert.ToInt32(textBox3.Text);
            ortalama = (vize + final + proje) / 3;
            textBox4.Text = Convert.ToString(ortalama);
            */

            // Küsuratlý hesaplama için

            double vize, final, proje, ortalama;
            string ikihane;
            vize = Convert.ToDouble(textBox1.Text);
            final = Convert.ToDouble(textBox2.Text);
            proje = Convert.ToDouble(textBox3.Text); 
            ortalama = (vize + final + proje) / 3;
            // textBox4.Text = Convert.ToString(ortalama);
            ikihane= string.Format("{0:0.00}", ortalama); // iki haneli küsürat için gerekli kod
            label8.Text = ikihane;

        }

        
    }
}