namespace auto_gallery
{
    partial class UyeKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeKayit));
            this.MskPassword = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnKayit = new System.Windows.Forms.Button();
            this.TxtTel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MskPassword
            // 
            this.MskPassword.Location = new System.Drawing.Point(144, 278);
            this.MskPassword.Mask = "00000000000";
            this.MskPassword.Name = "MskPassword";
            this.MskPassword.Size = new System.Drawing.Size(152, 36);
            this.MskPassword.TabIndex = 3;
            this.MskPassword.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tel No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "İsim:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "Soyisim:";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(144, 198);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(152, 36);
            this.TxtSoyad.TabIndex = 1;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(144, 155);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(152, 36);
            this.TxtAd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(118, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 48);
            this.label1.TabIndex = 19;
            this.label1.Text = "Üye Kayıt";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnKayit
            // 
            this.BtnKayit.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnKayit.Location = new System.Drawing.Point(149, 320);
            this.BtnKayit.Name = "BtnKayit";
            this.BtnKayit.Size = new System.Drawing.Size(147, 44);
            this.BtnKayit.TabIndex = 20;
            this.BtnKayit.Text = "Kaydol";
            this.BtnKayit.UseVisualStyleBackColor = false;
            this.BtnKayit.Click += new System.EventHandler(this.BtnKayit_Click);
            // 
            // TxtTel
            // 
            this.TxtTel.Location = new System.Drawing.Point(144, 236);
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(152, 36);
            this.TxtTel.TabIndex = 21;
            // 
            // UyeKayit
            // 
            this.AcceptButton = this.BtnKayit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(478, 469);
            this.Controls.Add(this.TxtTel);
            this.Controls.Add(this.BtnKayit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MskPassword);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "UyeKayit";
            this.Text = "Üye Kayıt";
            this.Load += new System.EventHandler(this.UyeKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox MskPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnKayit;
        private System.Windows.Forms.TextBox TxtTel;
    }
}