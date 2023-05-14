using System.Data.OleDb;

namespace Anaokulu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Lütfen Kullanýcý Adý ve Þifrenizi Giriniz!!!");
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen Kullanýcý Adý Kýsmýný Boþ Býrakmayýnýz!!!");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Lütfen Þifre Kýsmýný Boþ Býrakmayýnýz!!!");
            }
            else
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("select * from kullanicigiris where kul_adi='" + textBox1.Text + "'", baglanti);
                OleDbDataReader okuyucu = komut.ExecuteReader();
                if (okuyucu.Read() == true)
                {
                    if (textBox1.Text == okuyucu["kul_adi"].ToString() && textBox2.Text == okuyucu["sifre"].ToString())
                    {
                        MessageBox.Show("Hoþgeldin " + okuyucu["adsoyad"].ToString());
                        Form AnaSayfa = new Form1();
                        AnaSayfa.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Giriþ Bilgilerinizi Kontrol Ediniz!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Giriþ Bilgilerinizi Kontrol Ediniz!!!");
                }
                baglanti.Close();
            }
        }
    }
    }
}