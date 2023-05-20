namespace Anaokulu
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        kulForm kulform = new kulForm();

        private void button1_Click(object sender, EventArgs e)
        {
            kulform.kullanici(textBox1, textBox2);

        }
    }
}