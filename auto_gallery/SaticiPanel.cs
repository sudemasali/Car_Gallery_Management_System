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
    public partial class SaticiPanel : Form
    {
        public SaticiPanel()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();
        public string TelNo;
        private void SaticiPanel_Load(object sender, EventArgs e)
        {
            LblTelno.Text = TelNo;

            //Çalışan Ad Soyad Çekme
            SqlCommand komut = new SqlCommand("Select WorkerNameSurname,WorkerFirm From tbl_worker where WorkerPhone=@p1 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",LblTelno.Text);
            SqlDataReader dr= komut.ExecuteReader();
            while(dr.Read())
            {
                LblAdSoyad.Text =dr[0]+" ";
                LblFirma.Text = dr[1]+" ";
            }
            bgl.baglanti().Close();

            //Çalışana ait randevuları çekme
            DataTable dt= new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From tbl_randevu where SaticiAd='" + LblAdSoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr=new FrmDuyurular();
            fr.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
