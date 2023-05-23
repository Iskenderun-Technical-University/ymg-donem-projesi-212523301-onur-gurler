using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Anaokulu
{
    public partial class OgrenciEkle : Form
    {
        public OgrenciEkle()
        {
            InitializeComponent();
        }
        kulForm ogrekle = new kulForm();
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void OgrenciEkle_Load(object sender, EventArgs e)
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            ogrekle.yeniOgrenci(textBox1, textBox2, textBox3, textBox4, comboBox1, comboBox2, groupBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls) if (item is TextBox or ComboBox) item.Text = "";
        }
    }
}
