using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace Anaokulu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OQJ59QU;Initial Catalog=Anaokulu;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader read;
        AnaSayfa anasayfa = new AnaSayfa();
        DataTable tablo;
        public SqlDataReader kullanici(TextBox kuladi,TextBox sifre)
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select *from kullanici where kuladi='"+textBox1.Text+"'";
            read= komut.ExecuteReader();
            if (read.Read()==true)
            {
                if (sifre.Text == read["sifre"].ToString())
                {
                    MessageBox.Show("Hoþ Geldiniz");
                    anasayfa.Show();
                }
                else
                {
                    MessageBox.Show("Þifreyi Yanlýþ Girdiniz", "Þifre Hatasý");
                }
            }
            else
            {
                MessageBox.Show("Kullanýcý Adý Sistemde Yok Lütfen Yöneticiye Baþvurunuz", "Kullanýcý Adý Hatasý");
            }
            baglanti.Close();
            return read;
        }
       
        Form1 kulgiris = new Form1();
        private void button1_Click(object sender, EventArgs e)
        {
            kulgiris.kullanici(textBox1, textBox2);         
        }
    }
    
}