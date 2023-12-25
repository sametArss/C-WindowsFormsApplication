namespace MiniATM2
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(60, 70);
            label1.Name = "label1";
            label1.Size = new Size(256, 28);
            label1.TabIndex = 0;
            label1.Text = "Hesap Bilgileriniz  ....";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 145);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Adı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 190);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 2;
            label3.Text = "Soyadı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 237);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 3;
            label4.Text = "Kullanıcı Adı :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 281);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 4;
            label5.Text = "Şifre :";
            // 
            // button1
            // 
            button1.Location = new Point(231, 361);
            button1.Name = "button1";
            button1.Size = new Size(128, 56);
            button1.TabIndex = 5;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 142);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(123, 187);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(178, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(124, 234);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(177, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(124, 278);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(177, 27);
            textBox4.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(19, 361);
            button2.Name = "button2";
            button2.Size = new Size(124, 56);
            button2.TabIndex = 10;
            button2.Text = "<--   Geri";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 429);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Hesap Bilgileri";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button2;
    }
}