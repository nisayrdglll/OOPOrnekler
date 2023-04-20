namespace WindowsFormsApp2
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
            this.txtUrunFiyat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrunAdet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKdvTutar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbtn1 = new System.Windows.Forms.RadioButton();
            this.rdbtn8 = new System.Windows.Forms.RadioButton();
            this.rdbtn18 = new System.Windows.Forms.RadioButton();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTopTutar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUrunFiyat
            // 
            this.txtUrunFiyat.Location = new System.Drawing.Point(104, 63);
            this.txtUrunFiyat.Name = "txtUrunFiyat";
            this.txtUrunFiyat.Size = new System.Drawing.Size(135, 20);
            this.txtUrunFiyat.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Fiyatı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürün Adedi";
            // 
            // txtUrunAdet
            // 
            this.txtUrunAdet.Location = new System.Drawing.Point(104, 107);
            this.txtUrunAdet.Name = "txtUrunAdet";
            this.txtUrunAdet.Size = new System.Drawing.Size(135, 20);
            this.txtUrunAdet.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "KDV Tutarı";
            // 
            // txtKdvTutar
            // 
            this.txtKdvTutar.Location = new System.Drawing.Point(104, 197);
            this.txtKdvTutar.Name = "txtKdvTutar";
            this.txtKdvTutar.Size = new System.Drawing.Size(135, 20);
            this.txtKdvTutar.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "KDV Oranı";
            // 
            // rdbtn1
            // 
            this.rdbtn1.AutoSize = true;
            this.rdbtn1.Location = new System.Drawing.Point(104, 150);
            this.rdbtn1.Name = "rdbtn1";
            this.rdbtn1.Size = new System.Drawing.Size(39, 17);
            this.rdbtn1.TabIndex = 7;
            this.rdbtn1.TabStop = true;
            this.rdbtn1.Text = "%1";
            this.rdbtn1.UseVisualStyleBackColor = true;
            // 
            // rdbtn8
            // 
            this.rdbtn8.AutoSize = true;
            this.rdbtn8.Location = new System.Drawing.Point(149, 150);
            this.rdbtn8.Name = "rdbtn8";
            this.rdbtn8.Size = new System.Drawing.Size(39, 17);
            this.rdbtn8.TabIndex = 8;
            this.rdbtn8.TabStop = true;
            this.rdbtn8.Text = "%8";
            this.rdbtn8.UseVisualStyleBackColor = true;
            // 
            // rdbtn18
            // 
            this.rdbtn18.AutoSize = true;
            this.rdbtn18.Location = new System.Drawing.Point(194, 150);
            this.rdbtn18.Name = "rdbtn18";
            this.rdbtn18.Size = new System.Drawing.Size(45, 17);
            this.rdbtn18.TabIndex = 9;
            this.rdbtn18.TabStop = true;
            this.rdbtn18.Text = "%18";
            this.rdbtn18.UseVisualStyleBackColor = true;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(133, 237);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 10;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Toplam Tutar";
            // 
            // txtTopTutar
            // 
            this.txtTopTutar.Location = new System.Drawing.Point(104, 283);
            this.txtTopTutar.Name = "txtTopTutar";
            this.txtTopTutar.Size = new System.Drawing.Size(135, 20);
            this.txtTopTutar.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "KDV Hesaplama";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 329);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTopTutar);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.rdbtn18);
            this.Controls.Add(this.rdbtn8);
            this.Controls.Add(this.rdbtn1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKdvTutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrunAdet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrunFiyat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrunFiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrunAdet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKdvTutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbtn1;
        private System.Windows.Forms.RadioButton rdbtn8;
        private System.Windows.Forms.RadioButton rdbtn18;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTopTutar;
        private System.Windows.Forms.Label label6;
    }
}

