namespace Anaokulu
{
    partial class SubeEkle
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
            ogretmenCmb = new ComboBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            yasgrCmb = new ComboBox();
            yrdTxt = new TextBox();
            binaTxt = new TextBox();
            subeTxt = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(ogretmenCmb);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(yasgrCmb);
            groupBox1.Controls.Add(yrdTxt);
            groupBox1.Controls.Add(binaTxt);
            groupBox1.Controls.Add(subeTxt);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(53, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(694, 313);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yeni Şube Ekleme";
            // 
            // ogretmenCmb
            // 
            ogretmenCmb.FormattingEnabled = true;
            ogretmenCmb.Location = new Point(157, 110);
            ogretmenCmb.Name = "ogretmenCmb";
            ogretmenCmb.Size = new Size(179, 23);
            ogretmenCmb.TabIndex = 16;
            // 
            // button3
            // 
            button3.Location = new Point(556, 240);
            button3.Name = "button3";
            button3.Size = new Size(106, 52);
            button3.TabIndex = 15;
            button3.Text = "Ana Menü";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(433, 240);
            button2.Name = "button2";
            button2.Size = new Size(106, 52);
            button2.TabIndex = 14;
            button2.Text = "Temizle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(311, 240);
            button1.Name = "button1";
            button1.Size = new Size(106, 52);
            button1.TabIndex = 13;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // yasgrCmb
            // 
            yasgrCmb.FormattingEnabled = true;
            yasgrCmb.Location = new Point(499, 105);
            yasgrCmb.Name = "yasgrCmb";
            yasgrCmb.Size = new Size(163, 23);
            yasgrCmb.TabIndex = 11;
            // 
            // yrdTxt
            // 
            yrdTxt.Location = new Point(499, 28);
            yrdTxt.Name = "yrdTxt";
            yrdTxt.Size = new Size(163, 23);
            yrdTxt.TabIndex = 9;
            // 
            // binaTxt
            // 
            binaTxt.Location = new Point(157, 169);
            binaTxt.Name = "binaTxt";
            binaTxt.Size = new Size(179, 23);
            binaTxt.TabIndex = 8;
            // 
            // subeTxt
            // 
            subeTxt.Location = new Point(157, 28);
            subeTxt.Name = "subeTxt";
            subeTxt.Size = new Size(179, 23);
            subeTxt.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(390, 109);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 4;
            label5.Text = "Yaş Grubu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(390, 36);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 3;
            label4.Text = "Müdür Yardımcısı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 177);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Bina Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 113);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 1;
            label2.Text = "Öğretmen Adı Soyadı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 36);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Şube İsmi";
            // 
            // SubeEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ArkaPlan;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "SubeEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yeni Şube Ekle";
            Load += SubeEkle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private ComboBox yasgrCmb;
        private TextBox yrdTxt;
        private TextBox binaTxt;
        private TextBox subeTxt;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox ogretmenCmb;
    }
}