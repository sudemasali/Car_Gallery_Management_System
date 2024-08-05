namespace auto_gallery
{
    partial class ClientPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.LblAd = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnHakkimizda = new System.Windows.Forms.Button();
            this.BtnDuyuru = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TxtRandevuID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbDanisman = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbMarka = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnRandevual = new System.Windows.Forms.Button();
            this.LblTelno = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(348, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 330);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araçlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(821, 295);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOŞGELDİN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblAd
            // 
            this.LblAd.AutoSize = true;
            this.LblAd.Font = new System.Drawing.Font("Corbel", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAd.Location = new System.Drawing.Point(115, 19);
            this.LblAd.Name = "LblAd";
            this.LblAd.Size = new System.Drawing.Size(77, 37);
            this.LblAd.TabIndex = 2;
            this.LblAd.Text = "0000";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(351, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(821, 264);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aktif Randevular";
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
            this.dataGridView2.Size = new System.Drawing.Size(815, 229);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.BtnHakkimizda);
            this.groupBox3.Controls.Add(this.BtnDuyuru);
            this.groupBox3.Controls.Add(this.BtnCikis);
            this.groupBox3.Location = new System.Drawing.Point(12, 507);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 203);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Menü";
            // 
            // BtnHakkimizda
            // 
            this.BtnHakkimizda.Location = new System.Drawing.Point(159, 66);
            this.BtnHakkimizda.Name = "BtnHakkimizda";
            this.BtnHakkimizda.Size = new System.Drawing.Size(152, 36);
            this.BtnHakkimizda.TabIndex = 3;
            this.BtnHakkimizda.Text = "Hakkımızda";
            this.BtnHakkimizda.UseVisualStyleBackColor = true;
            // 
            // BtnDuyuru
            // 
            this.BtnDuyuru.Location = new System.Drawing.Point(11, 66);
            this.BtnDuyuru.Name = "BtnDuyuru";
            this.BtnDuyuru.Size = new System.Drawing.Size(142, 36);
            this.BtnDuyuru.TabIndex = 2;
            this.BtnDuyuru.Text = "Duyurular";
            this.BtnDuyuru.UseVisualStyleBackColor = true;
            // 
            // BtnCikis
            // 
            this.BtnCikis.Location = new System.Drawing.Point(6, 128);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(305, 35);
            this.BtnCikis.TabIndex = 1;
            this.BtnCikis.Text = "Çıkış";
            this.BtnCikis.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TxtRandevuID);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.CmbDanisman);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.CmbMarka);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.BtnRandevual);
            this.groupBox4.Location = new System.Drawing.Point(12, 66);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(311, 421);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Randevu Oluştur";
            // 
            // TxtRandevuID
            // 
            this.TxtRandevuID.Enabled = false;
            this.TxtRandevuID.Location = new System.Drawing.Point(141, 44);
            this.TxtRandevuID.Name = "TxtRandevuID";
            this.TxtRandevuID.Size = new System.Drawing.Size(151, 36);
            this.TxtRandevuID.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Randevu ID:";
            // 
            // CmbDanisman
            // 
            this.CmbDanisman.FormattingEnabled = true;
            this.CmbDanisman.Location = new System.Drawing.Point(141, 128);
            this.CmbDanisman.Name = "CmbDanisman";
            this.CmbDanisman.Size = new System.Drawing.Size(151, 36);
            this.CmbDanisman.TabIndex = 6;
            this.CmbDanisman.SelectedIndexChanged += new System.EventHandler(this.CmbDanisman_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Danışman:";
            // 
            // CmbMarka
            // 
            this.CmbMarka.FormattingEnabled = true;
            this.CmbMarka.Location = new System.Drawing.Point(141, 86);
            this.CmbMarka.Name = "CmbMarka";
            this.CmbMarka.Size = new System.Drawing.Size(151, 36);
            this.CmbMarka.TabIndex = 4;
            this.CmbMarka.SelectedIndexChanged += new System.EventHandler(this.CmbMarka_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Marka:";
            // 
            // BtnRandevual
            // 
            this.BtnRandevual.Location = new System.Drawing.Point(141, 212);
            this.BtnRandevual.Name = "BtnRandevual";
            this.BtnRandevual.Size = new System.Drawing.Size(151, 36);
            this.BtnRandevual.TabIndex = 1;
            this.BtnRandevual.Text = "Randevu al";
            this.BtnRandevual.UseVisualStyleBackColor = true;
            this.BtnRandevual.Click += new System.EventHandler(this.BtnRandevual_Click);
            // 
            // LblTelno
            // 
            this.LblTelno.AutoSize = true;
            this.LblTelno.Location = new System.Drawing.Point(218, 19);
            this.LblTelno.Name = "LblTelno";
            this.LblTelno.Size = new System.Drawing.Size(66, 28);
            this.LblTelno.TabIndex = 6;
            this.LblTelno.Text = "label3";
            this.LblTelno.Visible = false;
            // 
            // ClientPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1200, 731);
            this.Controls.Add(this.LblTelno);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LblAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "ClientPanel";
            this.Text = "Müşteri Paneli";
            this.Load += new System.EventHandler(this.ClientPanel_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblAd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnDuyuru;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Button BtnHakkimizda;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnRandevual;
        private System.Windows.Forms.Label LblTelno;
        private System.Windows.Forms.ComboBox CmbDanisman;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbMarka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtRandevuID;
        private System.Windows.Forms.Label label5;
    }
}