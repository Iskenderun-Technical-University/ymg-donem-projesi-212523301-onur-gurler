namespace Anaokulu
{
    partial class OgretmenEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ogretmentecrubeTxt = new TextBox();
            ogretmenmezuniyetTxt = new TextBox();
            ogretmenadsoyadTxt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(ogretmentecrubeTxt);
            groupBox1.Controls.Add(ogretmenmezuniyetTxt);
            groupBox1.Controls.Add(ogretmenadsoyadTxt);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(203, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(412, 313);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğretmen Ekle";
            // 
            // button3
            // 
            button3.Location = new Point(278, 242);
            button3.Name = "button3";
            button3.Size = new Size(106, 52);
            button3.TabIndex = 15;
            button3.Text = "Ana Menü";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(155, 242);
            button2.Name = "button2";
            button2.Size = new Size(106, 52);
            button2.TabIndex = 14;
            button2.Text = "Temizle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(33, 242);
            button1.Name = "button1";
            button1.Size = new Size(106, 52);
            button1.TabIndex = 13;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ogretmentecrubeTxt
            // 
            ogretmentecrubeTxt.Location = new Point(166, 168);
            ogretmentecrubeTxt.Name = "ogretmentecrubeTxt";
            ogretmentecrubeTxt.Size = new Size(179, 23);
            ogretmentecrubeTxt.TabIndex = 8;
            // 
            // ogretmenmezuniyetTxt
            // 
            ogretmenmezuniyetTxt.Location = new Point(166, 98);
            ogretmenmezuniyetTxt.Name = "ogretmenmezuniyetTxt";
            ogretmenmezuniyetTxt.Size = new Size(179, 23);
            ogretmenmezuniyetTxt.TabIndex = 7;
            // 
            // ogretmenadsoyadTxt
            // 
            ogretmenadsoyadTxt.Location = new Point(166, 28);
            ogretmenadsoyadTxt.Name = "ogretmenadsoyadTxt";
            ogretmenadsoyadTxt.Size = new Size(179, 23);
            ogretmenadsoyadTxt.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 176);
            label3.Name = "label3";
            label3.Size = new Size(125, 15);
            label3.TabIndex = 2;
            label3.Text = "Öğretmenlik Tecrübesi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 106);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 1;
            label2.Text = "Mezun Olduğu Okul";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 36);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad";
            // 
            // OgretmenEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ArkaPlan;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "OgretmenEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Öğretmen Ekleme";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox ogretmentecrubeTxt;
        private TextBox ogretmenmezuniyetTxt;
        private TextBox ogretmenadsoyadTxt;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}