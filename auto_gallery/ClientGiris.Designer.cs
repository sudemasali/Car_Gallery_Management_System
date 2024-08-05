namespace auto_gallery
{
    partial class ClientGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LblUye = new System.Windows.Forms.LinkLabel();
            this.MskPassword = new System.Windows.Forms.MaskedTextBox();
            this.TxtTel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tel No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // BtnGiris
            // 
            this.BtnGiris.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnGiris.Location = new System.Drawing.Point(141, 315);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(132, 34);
            this.BtnGiris.TabIndex = 2;
            this.BtnGiris.Text = "Giriş";
            this.BtnGiris.UseVisualStyleBackColor = false;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(70, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 55);
            this.label3.TabIndex = 5;
            this.label3.Text = "Müşteri Girişi";
            // 
            // LblUye
            // 
            this.LblUye.AutoSize = true;
            this.LblUye.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LblUye.LinkColor = System.Drawing.Color.Black;
            this.LblUye.Location = new System.Drawing.Point(202, 365);
            this.LblUye.Name = "LblUye";
            this.LblUye.Size = new System.Drawing.Size(71, 28);
            this.LblUye.TabIndex = 4;
            this.LblUye.TabStop = true;
            this.LblUye.Text = "Üye ol";
            this.LblUye.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblUye_LinkClicked);
            // 
            // MskPassword
            // 
            this.MskPassword.Location = new System.Drawing.Point(126, 259);
            this.MskPassword.Mask = "00000000000";
            this.MskPassword.Name = "MskPassword";
            this.MskPassword.Size = new System.Drawing.Size(147, 36);
            this.MskPassword.TabIndex = 1;
            this.MskPassword.UseSystemPasswordChar = true;
            this.MskPassword.ValidatingType = typeof(int);
            // 
            // TxtTel
            // 
            this.TxtTel.Location = new System.Drawing.Point(126, 202);
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(147, 36);
            this.TxtTel.TabIndex = 0;
            // 
            // ClientGiris
            // 
            this.AcceptButton = this.BtnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(407, 501);
            this.Controls.Add(this.TxtTel);
            this.Controls.Add(this.MskPassword);
            this.Controls.Add(this.LblUye);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ClientGiris";
            this.Text = "Müşteri Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel LblUye;
        private System.Windows.Forms.MaskedTextBox MskPassword;
        private System.Windows.Forms.TextBox TxtTel;
    }
}