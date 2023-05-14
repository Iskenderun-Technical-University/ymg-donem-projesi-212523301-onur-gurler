namespace Anaokulu
{
    partial class AnaSayfa
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.öğrenci_logo;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Gadugi", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(46, 257);
            button1.Name = "button1";
            button1.Size = new Size(218, 202);
            button1.TabIndex = 0;
            button1.Text = "Yeni Öğrenci Ekle";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.şube_logo;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Font = new Font("Gadugi", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(300, 257);
            button2.Name = "button2";
            button2.Size = new Size(218, 202);
            button2.TabIndex = 1;
            button2.Text = "Şube Ekle/Sil";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.liste_logo;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Font = new Font("Gadugi", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(554, 257);
            button3.Name = "button3";
            button3.Size = new Size(218, 202);
            button3.TabIndex = 2;
            button3.Text = "Öğrenci Listele/Sil";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.Çıkış_Logo;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Font = new Font("Gadugi", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(808, 257);
            button4.Name = "button4";
            button4.Size = new Size(218, 202);
            button4.TabIndex = 3;
            button4.Text = "Çıkış";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // AnaSayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ArkaPlan;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1064, 631);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "AnaSayfa";
            Text = "AnaSayfa";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}