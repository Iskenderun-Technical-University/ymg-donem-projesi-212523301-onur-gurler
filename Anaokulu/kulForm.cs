using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anaokulu
{
    internal class kulForm
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OQJ59QU;Initial Catalog=Anaokulu;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader read;
        Anasayfa anasayfa = new Anasayfa();

        public SqlDataReader kullanici(TextBox kuladi, TextBox sifre)
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select *from kullanici where kuladi='" + kuladi.Text + "'";
            read = komut.ExecuteReader();
            if (read.Read()==true)
            {
                if (sifre.Text == read["sifre"].ToString())
                {
                    MessageBox.Show("Giriş Başarılıdır.");                 
                    anasayfa.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Şifreyi Yanlış Girdiniz.","sifreHata");
                }
            }
            else
            {
                MessageBox.Show("Böyle Bir Kullanıcı Yoktur.", "kulHata");
            }
            baglanti.Close();
            return read;
        }
    }
}
