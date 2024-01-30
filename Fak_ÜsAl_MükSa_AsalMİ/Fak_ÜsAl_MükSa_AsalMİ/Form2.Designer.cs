namespace Fak_ÜsAl_MükSa_AsalMİ
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sayiTexBox = new System.Windows.Forms.TextBox();
            this.hesaplaButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ussayiTexBox = new System.Windows.Forms.TextBox();
            this.geriButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // sayiTexBox
            // 
            this.sayiTexBox.Location = new System.Drawing.Point(214, 87);
            this.sayiTexBox.Multiline = true;
            this.sayiTexBox.Name = "sayiTexBox";
            this.sayiTexBox.Size = new System.Drawing.Size(131, 39);
            this.sayiTexBox.TabIndex = 2;
            this.sayiTexBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hesaplaButton
            // 
            this.hesaplaButton.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesaplaButton.Location = new System.Drawing.Point(396, 86);
            this.hesaplaButton.Name = "hesaplaButton";
            this.hesaplaButton.Size = new System.Drawing.Size(157, 96);
            this.hesaplaButton.TabIndex = 3;
            this.hesaplaButton.Text = "Hesapla";
            this.hesaplaButton.UseVisualStyleBackColor = true;
            this.hesaplaButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // ussayiTexBox
            // 
            this.ussayiTexBox.Location = new System.Drawing.Point(214, 143);
            this.ussayiTexBox.Multiline = true;
            this.ussayiTexBox.Name = "ussayiTexBox";
            this.ussayiTexBox.Size = new System.Drawing.Size(131, 39);
            this.ussayiTexBox.TabIndex = 5;
            this.ussayiTexBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // geriButton
            // 
            this.geriButton.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geriButton.ForeColor = System.Drawing.Color.Red;
            this.geriButton.Location = new System.Drawing.Point(168, 199);
            this.geriButton.Name = "geriButton";
            this.geriButton.Size = new System.Drawing.Size(208, 46);
            this.geriButton.TabIndex = 6;
            this.geriButton.Text = "< --- Geri";
            this.geriButton.UseVisualStyleBackColor = true;
            this.geriButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(613, 270);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.geriButton);
            this.Controls.Add(this.ussayiTexBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hesaplaButton);
            this.Controls.Add(this.sayiTexBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sayiTexBox;
        private System.Windows.Forms.Button hesaplaButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ussayiTexBox;
        private System.Windows.Forms.Button geriButton;
        private System.Windows.Forms.Label label4;
    }
}