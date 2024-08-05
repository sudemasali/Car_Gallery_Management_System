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
    public partial class SaticiGiris : Form
    {
        public SaticiGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();
        private void SaticiGiris_Load(object sender, EventArgs e)
        {

        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from tbl_worker where WorkerPhone=@p1 and WorkerPassword=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtTelNo.Text);
            komut.Parameters.AddWithValue("@p2",MskPassword.Text);
            SqlDataReader dr= komut.ExecuteReader();
            if (dr.Read())
            {
                SaticiPanel sp= new SaticiPanel();
                sp.TelNo =TxtTelNo.Text;
                sp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı telefon numarası veya şifre.");
            }
            bgl.baglanti().Close();
        }
    }
}
