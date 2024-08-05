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
    public partial class ClientPanel : Form
    {
        public ClientPanel()
        {
            InitializeComponent();
        }
        
        public string Telno;

        sqlbaglantisi bgl=new sqlbaglantisi();
        private void ClientPanel_Load(object sender, EventArgs e)
        {
         LblTelno.Text = Telno;

            SqlCommand komut = new SqlCommand("Select Client_Name From tbl_client where Phone=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",LblTelno.Text);
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                LblAd.Text = dr[0]+" ";
            }
            bgl.baglanti().Close();

            //Randevu

            DataTable dt= new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From tbl_randevu where Phone= " + Telno, bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource= dt;

            //Araçlar

            SqlCommand komut2 = new SqlCommand("Select * From tbl_car ", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From tbl_car", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;

            while (dr2.Read())
            {
                CmbMarka.Items.Add(dr2[1]);
            }
            bgl.baglanti().Close();


        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CmbID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDanisman.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select WorkerNameSurname From tbl_worker where WorkerFirm=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", CmbMarka.Text);
            SqlDataReader dr3=komut3.ExecuteReader();
            while(dr3.Read())
            {
                CmbDanisman.Items.Add(dr3[0]);
            }
            bgl.baglanti().Close();
        }

        private void CmbDanisman_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From tbl_randevu where SaticiAd='" + CmbDanisman.Text + "'and RandevuDurum=0 ", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;  
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            TxtRandevuID.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
    }

        private void BtnRandevual_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_randevu Set RandevuDurum=1,Phone=@p1 where RandevuId=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTelno.Text);
            komut.Parameters.AddWithValue("@p3", TxtRandevuID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Rndevu alındı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        }
    }
