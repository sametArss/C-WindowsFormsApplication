namespace MiniATM2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            girisYapButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            kullaniciAditextBox = new TextBox();
            SifretextBox = new TextBox();
            güvenlikKodutextBox = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // girisYapButton
            // 
            girisYapButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            girisYapButton.Location = new Point(92, 348);
            girisYapButton.Name = "girisYapButton";
            girisYapButton.Size = new Size(303, 46);
            girisYapButton.TabIndex = 0;
            girisYapButton.Text = "Giriş Yap";
            girisYapButton.UseVisualStyleBackColor = true;
            girisYapButton.Click += girisYapButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(44, 170);
            label1.Name = "label1";
            label1.Size = new Size(114, 24);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(104, 231);
            label2.Name = "label2";
            label2.Size = new Size(54, 24);
            label2.TabIndex = 2;
            label2.Text = "Şifre :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(32, 296);
            label3.Name = "label3";
            label3.Size = new Size(126, 24);
            label3.TabIndex = 3;
            label3.Text = "Güvenlik Kodu :";
            // 
            // kullaniciAditextBox
            // 
            kullaniciAditextBox.Location = new Point(164, 170);
            kullaniciAditextBox.Name = "kullaniciAditextBox";
            kullaniciAditextBox.Size = new Size(176, 27);
            kullaniciAditextBox.TabIndex = 4;
            // 
            // SifretextBox
            // 
            SifretextBox.Location = new Point(164, 231);
            SifretextBox.Name = "SifretextBox";
            SifretextBox.Size = new Size(176, 27);
            SifretextBox.TabIndex = 5;
            SifretextBox.UseSystemPasswordChar = true;
            // 
            // güvenlikKodutextBox
            // 
            güvenlikKodutextBox.Location = new Point(164, 296);
            güvenlikKodutextBox.Name = "güvenlikKodutextBox";
            güvenlikKodutextBox.Size = new Size(176, 27);
            güvenlikKodutextBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Viner Hand ITC", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(394, 294);
            label4.Name = "label4";
            label4.Size = new Size(66, 29);
            label4.TabIndex = 7;
            label4.Text = "label4";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(86, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(309, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 431);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(güvenlikKodutextBox);
            Controls.Add(SifretextBox);
            Controls.Add(kullaniciAditextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(girisYapButton);
            Name = "Form1";
            Text = "ArsBank";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button girisYapButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox kullaniciAditextBox;
        private TextBox SifretextBox;
        private TextBox güvenlikKodutextBox;
        private Label label4;
        private PictureBox pictureBox1;
    }
}