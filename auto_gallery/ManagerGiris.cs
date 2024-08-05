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
    public partial class ManagerGiris : Form
    {
        public ManagerGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From tbl_manager Where ManagerName=@p1 and ManagerPassword=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", MskPassword.Text);
            SqlDataReader dr=komut.ExecuteReader();
            if(dr.Read())
            {
                ManagerPanel Mp = new ManagerPanel();
                Mp.Ad=TxtAd.Text;
                Mp.Show();
                this.Hide();

            }
            else {
                MessageBox.Show("Hatalı İsim veya Şifre");
                    }
            bgl.baglanti().Close();
        }
    }
}
