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
    public partial class MCalisanPanel : Form
    {
        public MCalisanPanel()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl=new sqlbaglantisi();
        private void MCalisanPanel_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From tbl_worker", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Firma adlarını  combo box a çekme
            SqlCommand komut2 = new SqlCommand("Select Brand From tbl_car", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbFirma.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_worker (WorkerPassword,WorkerNameSurname,WorkerFirm,WorkerPhone) values (@d1,@d2,@d3,@d4) ", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", TxtSifre.Text);
            komut.Parameters.AddWithValue("@d2", TxtAdSoyad.Text);
            komut.Parameters.AddWithValue("@d3", CmbFirma.Text);
            komut.Parameters.AddWithValue("@d4", TxtTelNo.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Çalışan eklendi.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtAdSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtTelNo.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            CmbFirma.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from tbl_worker where WorkerPhone=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",TxtTelNo.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update tbl_worker set WorkerPassword=@w1,WorkerNameSurname=@w2,WorkerFirm=@w3 where WorkerPhone=@w4", bgl.baglanti());
            komut.Parameters.AddWithValue("@w1", TxtSifre.Text);
            komut.Parameters.AddWithValue("@w2", TxtAdSoyad.Text);
            komut.Parameters.AddWithValue("@w3", CmbFirma.Text);
            komut.Parameters.AddWithValue("@w4", TxtTelNo.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Çalışan bilgileri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
