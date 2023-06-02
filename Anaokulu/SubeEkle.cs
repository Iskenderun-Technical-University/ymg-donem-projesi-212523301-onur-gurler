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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Anaokulu
{
    public partial class SubeEkle : Form
    {
        public SubeEkle()
        {
            InitializeComponent();
        }
        kulForm subeekle = new kulForm();
        private void button1_Click(object sender, EventArgs e)
        {
            subeekle.yeniSube(subeTxt, ogretmenCmb, binaTxt, yrdTxt, yasgrCmb, groupBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            subeTxt.Text = "";
            ogretmenCmb.Text = "";
            binaTxt.Text = "";
            yrdTxt.Text = "";
            yasgrCmb.Text = "";
        }

        private void SubeEkle_Load(object sender, EventArgs e)
        {
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
                yasgrCmb.Items.Add(dr2["yas"]);

            }
            baglanti2.Close();
            SqlConnection baglanti3 = new SqlConnection("Data Source=DESKTOP-OQJ59QU;Initial Catalog=Anaokulu;Integrated Security=True");
            SqlCommand subekomut3 = new SqlCommand();
            subekomut3.CommandText = "Select adsoyad from ogretmen";
            subekomut3.Connection = baglanti3;
            subekomut3.CommandType = CommandType.Text;

            SqlDataReader dr3;
            baglanti3.Open();
            dr3 = subekomut3.ExecuteReader();
            while (dr3.Read())
            {
                ogretmenCmb.Items.Add(dr3["adsoyad"]);

            }
            baglanti3 .Close();
        }
    }
}
