using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Anaokulu
{
    public partial class OgrenciListele : Form
    {
        public OgrenciListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OQJ59QU;Initial Catalog=Anaokulu;Integrated Security=True");
        SqlCommand komut;
        SqlCommand komut2;
        SqlCommand komut3;
        SqlDataReader read;
        DataTable tablo;
        kulForm listele = new kulForm();
        private void OgrenciListele_Load(object sender, EventArgs e)
        {
            yenileListele();
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OQJ59QU;Initial Catalog=Anaokulu;Integrated Security=True");
            SqlCommand subekomut = new SqlCommand();
            subekomut.CommandText = "Select subead from sube";
            subekomut.Connection = baglanti;
            subekomut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = subekomut.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["subead"]);

            }
            baglanti.Close();
            SqlConnection baglanti2 = new SqlConnection("Data Source=DESKTOP-OQJ59QU;Initial Catalog=Anaokulu;Integrated Security=True");
            SqlCommand subekomut2 = new SqlCommand();
            subekomut2.CommandText = "Select yas from yas";
            subekomut2.Connection = baglanti2;
            subekomut2.CommandType = CommandType.Text;

            SqlDataReader dr2;
            baglanti2.Open();
            dr2 = subekomut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox1.Items.Add(dr2["yas"]);

            }
            baglanti2.Close();

        }

        private void yenileListele()
        {
            string sorgu = "select *from ogrenci";
            SqlDataAdapter adtr20 = new SqlDataAdapter();
            dataGridView1.DataSource = listele.listele(adtr20, sorgu);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string sorgu = "select *from ogrenci where adsoyad like '%" + textBox5.Text + "%' ";
            SqlDataAdapter adtr20 = new SqlDataAdapter();
            dataGridView1.DataSource = listele.listele(adtr20, sorgu);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            textBox1.Text = satır.Cells[0].Value.ToString();
            textBox2.Text = satır.Cells[1].Value.ToString();
            textBox3.Text = satır.Cells[2].Value.ToString();
            textBox4.Text = satır.Cells[3].Value.ToString();
            comboBox1.Text = satır.Cells[4].Value.ToString();
            comboBox2.Text = satır.Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "update ogrenci set adsoyad='" + textBox2.Text + "',atel='" + textBox3.Text + "',btel='" + textBox4.Text + "',yas='" + comboBox1.Text + "',sube='" + comboBox2.Text + "'  where tc='" + textBox1.Text + "'";
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Güncellenmesi Başarılı");
            yenileListele();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Öğrenciyi Silmek İstediğinizden Emin Misiniz?", "Silme Uyarısı!", MessageBoxButtons.YesNo);
            if(x == DialogResult.Yes)
            {
                baglanti.Open();
                komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "delete from ogrenci where tc='" + textBox1.Text + "'";
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Öğrenci Başarı ile silinmiştir. Başarılı");
                yenileListele();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
            }
            else
            {
                yenileListele();
            }
            
        }
    }
}
