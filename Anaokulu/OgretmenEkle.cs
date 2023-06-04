using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anaokulu
{
    public partial class OgretmenEkle : Form
    {
        public OgretmenEkle()
        {
            InitializeComponent();
        }
        kulForm ogretmenekle = new kulForm();
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls) if (item is TextBox or ComboBox) item.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogretmenekle.yeniOgretmen(ogretmenadsoyadTxt, ogretmenmezuniyetTxt, ogretmentecrubeTxt, groupBox1);
        }
    }
}
