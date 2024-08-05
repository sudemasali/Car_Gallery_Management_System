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
    public partial class MAracPanel : Form
    {
        public MAracPanel()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MAracPanel_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_car",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("insert into tbl_car(Brand,Model,Year,Colour,Engine,Price,Km,Gear_Type,Status) values (@c1,@c2,@c3,@c4,@c5,@c6,@c7,@c8,@c9)",bgl.baglanti());
            komut.Parameters.AddWithValue("@c1", CmbMarka.Text);
            komut.Parameters.AddWithValue("@c2",CmbModel.Text);
            komut.Parameters.AddWithValue("@c3", MskUretimYili.Text);
            komut.Parameters.AddWithValue("@c4", TxtRenk.Text);
            komut.Parameters.AddWithValue("@c5",CmbMotor.Text);
            komut.Parameters.AddWithValue("@c6", MskFiyat.Text);
            komut.Parameters.AddWithValue("@c7", MskKm.Text);
            komut.Parameters.AddWithValue("@c8", TxtVites.Text);
            komut.Parameters.AddWithValue("@c9", TxtDurum.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Araç eklendi.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            CmbMarka.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            CmbModel.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MskUretimYili.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtRenk.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            CmbMotor.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            MskFiyat.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            MskKm.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            TxtVites.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            TxtDurum.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete From tbl_car where CarID=@c1 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@c1",TxtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Araç silindi.");

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_car set Brand=@c1,Model=@c2,Year=@c3,Colour=@c4,Engine=@c5,Price=@c6,Km=@c7,Gear_Type=@c8,Status=@c9 where CarID=@c0 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@c1", CmbMarka.Text);
            komut.Parameters.AddWithValue("@c2", CmbModel.Text);
            komut.Parameters.AddWithValue("@c3", MskUretimYili.Text);
            komut.Parameters.AddWithValue("@c4", TxtRenk.Text);
            komut.Parameters.AddWithValue("@c5", CmbMotor.Text);
            komut.Parameters.AddWithValue("@c6", MskFiyat.Text);
            komut.Parameters.AddWithValue("@c7", MskKm.Text);
            komut.Parameters.AddWithValue("@c8", TxtVites.Text);
            komut.Parameters.AddWithValue("@c9", TxtDurum.Text);
            komut.Parameters.AddWithValue("@c0", TxtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Araç güncellendi.");
        }
    }
}