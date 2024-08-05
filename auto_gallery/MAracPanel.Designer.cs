namespace auto_gallery
{
    partial class MAracPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAracPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbMarka = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbModel = new System.Windows.Forms.ComboBox();
            this.MskUretimYili = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtRenk = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbMotor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MskFiyat = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MskKm = new System.Windows.Forms.MaskedTextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtDurum = new System.Windows.Forms.TextBox();
            this.TxtVites = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(391, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 607);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araçlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(571, 572);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Marka:";
            // 
            // CmbMarka
            // 
            this.CmbMarka.FormattingEnabled = true;
            this.CmbMarka.Location = new System.Drawing.Point(135, 110);
            this.CmbMarka.Name = "CmbMarka";
            this.CmbMarka.Size = new System.Drawing.Size(161, 36);
            this.CmbMarka.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "Vites:";
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSil.Location = new System.Drawing.Point(192, 512);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(169, 39);
            this.BtnSil.TabIndex = 17;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnGuncelle.Location = new System.Drawing.Point(125, 557);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(169, 39);
            this.BtnGuncelle.TabIndex = 16;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEkle.Location = new System.Drawing.Point(27, 512);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(169, 39);
            this.BtnEkle.TabIndex = 15;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 28);
            this.label4.TabIndex = 20;
            this.label4.Text = "Model:";
            // 
            // CmbModel
            // 
            this.CmbModel.FormattingEnabled = true;
            this.CmbModel.Location = new System.Drawing.Point(135, 153);
            this.CmbModel.Name = "CmbModel";
            this.CmbModel.Size = new System.Drawing.Size(161, 36);
            this.CmbModel.TabIndex = 21;
            // 
            // MskUretimYili
            // 
            this.MskUretimYili.Location = new System.Drawing.Point(135, 195);
            this.MskUretimYili.Mask = "0000";
            this.MskUretimYili.Name = "MskUretimYili";
            this.MskUretimYili.Size = new System.Drawing.Size(160, 36);
            this.MskUretimYili.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "Üretim yılı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 28);
            this.label5.TabIndex = 26;
            this.label5.Text = "Durum:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 28);
            this.label6.TabIndex = 29;
            this.label6.Text = "Renk:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // TxtRenk
            // 
            this.TxtRenk.Location = new System.Drawing.Point(134, 321);
            this.TxtRenk.Name = "TxtRenk";
            this.TxtRenk.Size = new System.Drawing.Size(161, 36);
            this.TxtRenk.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 28);
            this.label7.TabIndex = 31;
            this.label7.Text = "Motor:";
            // 
            // CmbMotor
            // 
            this.CmbMotor.FormattingEnabled = true;
            this.CmbMotor.Location = new System.Drawing.Point(134, 362);
            this.CmbMotor.Name = "CmbMotor";
            this.CmbMotor.Size = new System.Drawing.Size(161, 36);
            this.CmbMotor.TabIndex = 32;
            this.CmbMotor.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 28);
            this.label8.TabIndex = 33;
            this.label8.Text = "Fiyat:";
            // 
            // MskFiyat
            // 
            this.MskFiyat.Location = new System.Drawing.Point(134, 404);
            this.MskFiyat.Mask = "000000";
            this.MskFiyat.Name = "MskFiyat";
            this.MskFiyat.Size = new System.Drawing.Size(161, 36);
            this.MskFiyat.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(85, 452);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 28);
            this.label9.TabIndex = 35;
            this.label9.Text = "Km:";
            // 
            // MskKm
            // 
            this.MskKm.Location = new System.Drawing.Point(134, 449);
            this.MskKm.Mask = "000000";
            this.MskKm.Name = "MskKm";
            this.MskKm.Size = new System.Drawing.Size(161, 36);
            this.MskKm.TabIndex = 36;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(134, 68);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(161, 36);
            this.TxtID.TabIndex = 38;
            this.TxtID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(72, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 28);
            this.label10.TabIndex = 37;
            this.label10.Text = "ID:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // TxtDurum
            // 
            this.TxtDurum.Location = new System.Drawing.Point(136, 279);
            this.TxtDurum.Name = "TxtDurum";
            this.TxtDurum.Size = new System.Drawing.Size(161, 36);
            this.TxtDurum.TabIndex = 39;
            // 
            // TxtVites
            // 
            this.TxtVites.Location = new System.Drawing.Point(136, 237);
            this.TxtVites.Name = "TxtVites";
            this.TxtVites.Size = new System.Drawing.Size(161, 36);
            this.TxtVites.TabIndex = 40;
            // 
            // MAracPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(980, 613);
            this.Controls.Add(this.TxtVites);
            this.Controls.Add(this.TxtDurum);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.MskKm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MskFiyat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CmbMotor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtRenk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MskUretimYili);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbModel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbMarka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnEkle);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MAracPanel";
            this.Text = "Araç Paneli";
            this.Load += new System.EventHandler(this.MAracPanel_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbMarka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbModel;
        private System.Windows.Forms.MaskedTextBox MskUretimYili;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtRenk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbMotor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox MskFiyat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox MskKm;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtDurum;
        private System.Windows.Forms.TextBox TxtVites;
    }
}