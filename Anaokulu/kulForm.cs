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
        SqlCommand komut2;
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
        public void yeniOgrenci(TextBox tc, TextBox adsoyad, TextBox atel, TextBox btel, ComboBox yas, ComboBox sube, GroupBox ogrencigrup)
        {
            if (tc.TextLength==11)
            {
                baglanti.Open();
                komut=new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "insert into ogrenci values('"+tc.Text
                    +"','"+adsoyad.Text+"','"+atel.Text+"','"+btel.Text+"','"+yas.Text+"','"+sube.Text+"')";
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Öğrenci eklemesi Başarılı");
                foreach (Control item in ogrencigrup.Controls) if (item is TextBox or ComboBox) item.Text = "";
                {
                    
                }
            }
            else
            {
                MessageBox.Show("TC Kimlik numarası 11 haneli olmalıdır.");
            }
        }
        public void yeniSube(TextBox subeTxt, ComboBox ogretmenCmb,TextBox binaTxt, TextBox yrdTxt, ComboBox yasgrCmb, GroupBox subegrup)
        {
            baglanti.Open();
            komut2 = new SqlCommand();
            komut2.Connection = baglanti;
            komut2.CommandText = "insert into sube values('" + subeTxt.Text
                + "','" + ogretmenCmb.Text + "','" + binaTxt.Text + "','" + yrdTxt.Text + "','" + yasgrCmb.Text + "')";
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Şube eklemesi Başarılı");
            foreach (Control item in subegrup.Controls) if (item is TextBox or ComboBox) item.Text = "";
            {

            }
        }
    }
}
