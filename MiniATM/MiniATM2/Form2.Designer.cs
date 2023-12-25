namespace MiniATM2
{
    partial class Form2
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
            button5 = new Button();
            button6 = new Button();
            yatirButton = new Button();
            label1 = new Label();
            label2 = new Label();
            cekilecekYatirilacakTextBox = new TextBox();
            label3 = new Label();
            ParaCekmeButton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(23, 99);
            button1.Name = "button1";
            button1.Size = new Size(139, 50);
            button1.TabIndex = 0;
            button1.Text = "Bakiye Görüntüleme";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(23, 188);
            button2.Name = "button2";
            button2.Size = new Size(139, 50);
            button2.TabIndex = 1;
            button2.Text = "Hesap Bilgileri";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(23, 272);
            button3.Name = "button3";
            button3.Size = new Size(139, 45);
            button3.TabIndex = 2;
            button3.Text = "Kredi Durumu ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(23, 357);
            button4.Name = "button4";
            button4.Size = new Size(139, 45);
            button4.TabIndex = 3;
            button4.Text = "Çıkış Yap ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(272, 99);
            button5.Name = "button5";
            button5.Size = new Size(139, 45);
            button5.TabIndex = 4;
            button5.Text = "Para Çekme ";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(272, 188);
            button6.Name = "button6";
            button6.Size = new Size(139, 50);
            button6.TabIndex = 5;
            button6.Text = "Para Yatırma";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // yatirButton
            // 
            yatirButton.Location = new Point(277, 389);
            yatirButton.Name = "yatirButton";
            yatirButton.Size = new Size(131, 42);
            yatirButton.TabIndex = 6;
            yatirButton.Text = "Onayla ";
            yatirButton.UseVisualStyleBackColor = true;
            yatirButton.Click += yatirButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(50, 30);
            label1.Name = "label1";
            label1.Size = new Size(380, 29);
            label1.TabIndex = 7;
            label1.Text = "Merhabalar !! Bankamıza Hoşgeldiniz...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 284);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 8;
            label2.Text = "label2";
            // 
            // cekilecekYatirilacakTextBox
            // 
            cekilecekYatirilacakTextBox.Location = new Point(260, 327);
            cekilecekYatirilacakTextBox.Name = "cekilecekYatirilacakTextBox";
            cekilecekYatirilacakTextBox.Size = new Size(171, 27);
            cekilecekYatirilacakTextBox.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(437, 334);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 10;
            label3.Text = "TL";
            // 
            // ParaCekmeButton
            // 
            ParaCekmeButton.Location = new Point(277, 389);
            ParaCekmeButton.Name = "ParaCekmeButton";
            ParaCekmeButton.Size = new Size(131, 42);
            ParaCekmeButton.TabIndex = 11;
            ParaCekmeButton.Text = "Onayla ";
            ParaCekmeButton.UseVisualStyleBackColor = true;
            ParaCekmeButton.Click += ParaCekmeButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 487);
            Controls.Add(ParaCekmeButton);
            Controls.Add(label3);
            Controls.Add(cekilecekYatirilacakTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(yatirButton);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Menu";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button yatirButton;
        private Label label1;
        private Label label2;
        private TextBox cekilecekYatirilacakTextBox;
        private Label label3;
        private Button ParaCekmeButton;
    }
}