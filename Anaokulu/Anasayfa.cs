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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            OgrenciEkle ekle = new OgrenciEkle();
            ekle.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
