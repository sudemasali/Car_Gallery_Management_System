namespace auto_gallery
{
    partial class ManagerPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblAd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnOlustur = new System.Windows.Forms.Button();
            this.RchDuyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CmbMarka = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.CmbSatici = new System.Windows.Forms.ComboBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.MskSaat = new System.Windows.Forms.MaskedTextBox();
            this.MskTarih = new System.Windows.Forms.MaskedTextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.ChcDurum = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BtnDuyurular = new System.Windows.Forms.Button();
            this.BtnAracPan = new System.Windows.Forms.Button();
            this.BtnRndListe = new System.Windows.Forms.Button();
            this.BtnSatPan = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BtnGrafik = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yönetici Bilgi";
            // 
            // LblAd
            // 
            this.LblAd.AutoSize = true;
            this.LblAd.Location = new System.Drawing.Point(69, 74);
            this.LblAd.Name = "LblAd";
            this.LblAd.Size = new System.Drawing.Size(50, 28);
            this.LblAd.TabIndex = 4;
            this.LblAd.Text = "Null";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnOlustur);
            this.groupBox2.Controls.Add(this.RchDuyuru);
            this.groupBox2.Location = new System.Drawing.Point(12, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 422);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // BtnOlustur
            // 
            this.BtnOlustur.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnOlustur.Location = new System.Drawing.Point(6, 347);
            this.BtnOlustur.Name = "BtnOlustur";
            this.BtnOlustur.Size = new System.Drawing.Size(372, 51);
            this.BtnOlustur.TabIndex = 1;
            this.BtnOlustur.Text = "OLUŞTUR";
            this.BtnOlustur.UseVisualStyleBackColor = false;
            this.BtnOlustur.Click += new System.EventHandler(this.BtnOlustur_Click);
            // 
            // RchDuyuru
            // 
            this.RchDuyuru.Location = new System.Drawing.Point(6, 47);
            this.RchDuyuru.Name = "RchDuyuru";
            this.RchDuyuru.Size = new System.Drawing.Size(372, 294);
            this.RchDuyuru.TabIndex = 0;
            this.RchDuyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.CmbMarka);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TxtPhone);
            this.groupBox3.Controls.Add(this.CmbSatici);
            this.groupBox3.Controls.Add(this.BtnKaydet);
            this.groupBox3.Controls.Add(this.MskSaat);
            this.groupBox3.Controls.Add(this.MskTarih);
            this.groupBox3.Controls.Add(this.TxtId);
            this.groupBox3.Controls.Add(this.ChcDurum);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(433, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 570);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // CmbMarka
            // 
            this.CmbMarka.FormattingEnabled = true;
            this.CmbMarka.Location = new System.Drawing.Point(86, 226);
            this.CmbMarka.Name = "CmbMarka";
            this.CmbMarka.Size = new System.Drawing.Size(180, 36);
            this.CmbMarka.TabIndex = 18;
            this.CmbMarka.SelectedIndexChanged += new System.EventHandler(this.CmbMarka_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 28);
            this.label5.TabIndex = 17;
            this.label5.Text = "Marka:";
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(86, 317);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(180, 36);
            this.TxtPhone.TabIndex = 16;
            // 
            // CmbSatici
            // 
            this.CmbSatici.FormattingEnabled = true;
            this.CmbSatici.Location = new System.Drawing.Point(86, 268);
            this.CmbSatici.Name = "CmbSatici";
            this.CmbSatici.Size = new System.Drawing.Size(180, 36);
            this.CmbSatici.TabIndex = 15;
            this.CmbSatici.SelectedIndexChanged += new System.EventHandler(this.CmbSatici_SelectedIndexChanged);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnKaydet.Location = new System.Drawing.Point(92, 410);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(179, 40);
            this.BtnKaydet.TabIndex = 13;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // MskSaat
            // 
            this.MskSaat.Location = new System.Drawing.Point(86, 186);
            this.MskSaat.Mask = "00:00";
            this.MskSaat.Name = "MskSaat";
            this.MskSaat.Size = new System.Drawing.Size(180, 36);
            this.MskSaat.TabIndex = 9;
            this.MskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // MskTarih
            // 
            this.MskTarih.Location = new System.Drawing.Point(86, 144);
            this.MskTarih.Mask = "00/00/0000";
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(180, 36);
            this.MskTarih.TabIndex = 8;
            this.MskTarih.ValidatingType = typeof(System.DateTime);
            this.MskTarih.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(86, 102);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(180, 36);
            this.TxtId.TabIndex = 7;
            // 
            // ChcDurum
            // 
            this.ChcDurum.AutoSize = true;
            this.ChcDurum.Location = new System.Drawing.Point(166, 372);
            this.ChcDurum.Name = "ChcDurum";
            this.ChcDurum.Size = new System.Drawing.Size(100, 32);
            this.ChcDurum.TabIndex = 6;
            this.ChcDurum.Text = "Durum";
            this.ChcDurum.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-5, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 56);
            this.label7.TabIndex = 5;
            this.label7.Text = "Müşteri\r\n         No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 28);
            this.label6.TabIndex = 4;
            this.label6.Text = "Satıcı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Saat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(795, 26);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(375, 357);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Araçlar";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(369, 322);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.BtnGrafik);
            this.groupBox5.Controls.Add(this.BtnDuyurular);
            this.groupBox5.Controls.Add(this.BtnAracPan);
            this.groupBox5.Controls.Add(this.BtnRndListe);
            this.groupBox5.Controls.Add(this.BtnSatPan);
            this.groupBox5.Location = new System.Drawing.Point(12, 620);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(766, 137);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Menü";
            // 
            // BtnDuyurular
            // 
            this.BtnDuyurular.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnDuyurular.Location = new System.Drawing.Point(571, 35);
            this.BtnDuyurular.Name = "BtnDuyurular";
            this.BtnDuyurular.Size = new System.Drawing.Size(200, 48);
            this.BtnDuyurular.TabIndex = 3;
            this.BtnDuyurular.Text = "Duyurular";
            this.BtnDuyurular.UseVisualStyleBackColor = false;
            this.BtnDuyurular.Click += new System.EventHandler(this.BtnDuyurular_Click);
            // 
            // BtnAracPan
            // 
            this.BtnAracPan.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnAracPan.Location = new System.Drawing.Point(178, 35);
            this.BtnAracPan.Name = "BtnAracPan";
            this.BtnAracPan.Size = new System.Drawing.Size(200, 48);
            this.BtnAracPan.TabIndex = 2;
            this.BtnAracPan.Text = "Araç Paneli";
            this.BtnAracPan.UseVisualStyleBackColor = false;
            this.BtnAracPan.Click += new System.EventHandler(this.BtnAracPan_Click);
            // 
            // BtnRndListe
            // 
            this.BtnRndListe.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnRndListe.Location = new System.Drawing.Point(375, 35);
            this.BtnRndListe.Name = "BtnRndListe";
            this.BtnRndListe.Size = new System.Drawing.Size(200, 48);
            this.BtnRndListe.TabIndex = 1;
            this.BtnRndListe.Text = "Randevu Listesi";
            this.BtnRndListe.UseVisualStyleBackColor = false;
            this.BtnRndListe.Click += new System.EventHandler(this.BtnRndListe_Click);
            // 
            // BtnSatPan
            // 
            this.BtnSatPan.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnSatPan.Location = new System.Drawing.Point(-19, 35);
            this.BtnSatPan.Name = "BtnSatPan";
            this.BtnSatPan.Size = new System.Drawing.Size(200, 48);
            this.BtnSatPan.TabIndex = 0;
            this.BtnSatPan.Text = "Satıcı Paneli";
            this.BtnSatPan.UseVisualStyleBackColor = false;
            this.BtnSatPan.Click += new System.EventHandler(this.BtnSatPan_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridView2);
            this.groupBox6.Location = new System.Drawing.Point(795, 400);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(375, 357);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Satış Danışmanları";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(369, 322);
            this.dataGridView2.TabIndex = 0;
            // 
            // BtnGrafik
            // 
            this.BtnGrafik.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnGrafik.Location = new System.Drawing.Point(293, 99);
            this.BtnGrafik.Name = "BtnGrafik";
            this.BtnGrafik.Size = new System.Drawing.Size(204, 35);
            this.BtnGrafik.TabIndex = 4;
            this.BtnGrafik.Text = "Grafik";
            this.BtnGrafik.UseVisualStyleBackColor = false;
            this.BtnGrafik.Click += new System.EventHandler(this.BtnGrafik_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(260, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ManagerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1200, 788);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ManagerPanel";
            this.Text = "Yönetici Paneli";
            this.Load += new System.EventHandler(this.ManagerPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label LblAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button BtnOlustur;
        private System.Windows.Forms.RichTextBox RchDuyuru;
        private System.Windows.Forms.Button BtnAracPan;
        private System.Windows.Forms.Button BtnRndListe;
        private System.Windows.Forms.Button BtnSatPan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MskSaat;
        private System.Windows.Forms.MaskedTextBox MskTarih;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.CheckBox ChcDurum;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.ComboBox CmbSatici;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.ComboBox CmbMarka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnDuyurular;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnGrafik;
    }
}