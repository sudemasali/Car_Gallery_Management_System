using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace auto_gallery
{
    public partial class ManagerPanel : Form
    {
        public ManagerPanel()
        {
            InitializeComponent();
        }
        public string Ad;
      
        sqlbaglantisi bgl=new sqlbaglantisi();
        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        
        private void ManagerPanel_Load(object sender, EventArgs e)
        {
        LblAd.Text = Ad;
           
           
            
            //Araçları DataGridView ile görüntüleme
            DataTable dt1 = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("Select * From tbl_car ",bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
            

            //Satış Danışmanlarını DataGridView ile görüntüleme
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select WorkerNameSurname,WorkerFirm,WorkerPhone From tbl_worker", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //ComboBox a marka isimlerini çekme
            SqlCommand komut2 = new SqlCommand("Select Brand From tbl_car", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbMarka.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

            //


        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
           SqlCommand komutkaydet=new SqlCommand("insert into tbl_randevu (RandevuTarih,RandevuSaat,SaticiAd) values (@r1,@r2,@r3)",bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", MskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", MskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", CmbSatici.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu. ");

        }

        private void CmbSatici_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void CmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbSatici.Items.Clear();

            SqlCommand komut = new SqlCommand("Select WorkerNameSurname From tbl_worker Where WorkerFirm=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",CmbMarka.Text);
            SqlDataReader dr=komut.ExecuteReader();
            while(dr.Read())
            {
                CmbSatici.Items.Add(dr[0]);
            } 
            bgl.baglanti().Close();

        }

        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_duyurular (Duyuru) values(@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1",RchDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti() .Close();
            MessageBox.Show("Duyuru Oluşturuldu");
        }

        private void BtnSatPan_Click(object sender, EventArgs e)
        {
            MCalisanPanel mcp=new MCalisanPanel();
            mcp.Show();
        }

        private void BtnAracPan_Click(object sender, EventArgs e)
        {
            MAracPanel map=new MAracPanel();
            map.Show();
        }

        private void BtnRndListe_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frl=new FrmRandevuListesi();
            frl.Show();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
          
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr=new FrmDuyurular();
            fr.Show();
        }

        private void BtnGrafik_Click(object sender, EventArgs e)
        {
            Graphic gr=new Graphic();
            gr.Show();
        }
    }
}
