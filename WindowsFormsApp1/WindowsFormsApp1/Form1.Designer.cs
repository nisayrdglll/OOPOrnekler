namespace WindowsFormsApp1
{
    partial class Form1
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
            this.chbxCay = new System.Windows.Forms.CheckBox();
            this.chbxKahve = new System.Windows.Forms.CheckBox();
            this.chbxKraker = new System.Windows.Forms.CheckBox();
            this.chbxCikolata = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHesapla = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chbxCay
            // 
            this.chbxCay.AutoSize = true;
            this.chbxCay.Location = new System.Drawing.Point(75, 80);
            this.chbxCay.Name = "chbxCay";
            this.chbxCay.Size = new System.Drawing.Size(72, 17);
            this.chbxCay.TabIndex = 0;
            this.chbxCay.Text = "Çay- 2 TL";
            this.chbxCay.UseVisualStyleBackColor = true;
            // 
            // chbxKahve
            // 
            this.chbxKahve.AutoSize = true;
            this.chbxKahve.Location = new System.Drawing.Point(75, 117);
            this.chbxKahve.Name = "chbxKahve";
            this.chbxKahve.Size = new System.Drawing.Size(88, 17);
            this.chbxKahve.TabIndex = 2;
            this.chbxKahve.Text = "Kahve - 3 TL";
            this.chbxKahve.UseVisualStyleBackColor = true;
            // 
            // chbxKraker
            // 
            this.chbxKraker.AutoSize = true;
            this.chbxKraker.Location = new System.Drawing.Point(75, 155);
            this.chbxKraker.Name = "chbxKraker";
            this.chbxKraker.Size = new System.Drawing.Size(88, 17);
            this.chbxKraker.TabIndex = 3;
            this.chbxKraker.Text = "Kraker - 1 TL";
            this.chbxKraker.UseVisualStyleBackColor = true;
            // 
            // chbxCikolata
            // 
            this.chbxCikolata.AutoSize = true;
            this.chbxCikolata.Location = new System.Drawing.Point(75, 190);
            this.chbxCikolata.Name = "chbxCikolata";
            this.chbxCikolata.Size = new System.Drawing.Size(95, 17);
            this.chbxCikolata.TabIndex = 4;
            this.chbxCikolata.Text = "Çikolata - 4 TL";
            this.chbxCikolata.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnHesapla);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sipariş Fişi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tutar";
            // 
            // txtHesapla
            // 
            this.txtHesapla.Location = new System.Drawing.Point(110, 297);
            this.txtHesapla.Name = "txtHesapla";
            this.txtHesapla.Size = new System.Drawing.Size(100, 20);
            this.txtHesapla.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 429);
            this.Controls.Add(this.txtHesapla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chbxCikolata);
            this.Controls.Add(this.chbxKraker);
            this.Controls.Add(this.chbxKahve);
            this.Controls.Add(this.chbxCay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbxCay;
        private System.Windows.Forms.CheckBox chbxKahve;
        private System.Windows.Forms.CheckBox chbxKraker;
        private System.Windows.Forms.CheckBox chbxCikolata;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHesapla;
    }
}

