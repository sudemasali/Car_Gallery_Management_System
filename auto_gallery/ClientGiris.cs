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
    public partial class ClientGiris : Form
    {
        public ClientGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();
        private void LblUye_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UyeKayit fr = new UyeKayit();
            fr.Show();
            
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From tbl_client Where Phone=@p1 and Password=@p2 ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtTel.Text);
            komut.Parameters.AddWithValue("@p2",MskPassword.Text);
            SqlDataReader dr=komut.ExecuteReader();
            if (dr.Read()) 
            {
                ClientPanel fr = new ClientPanel();
                fr.Telno=TxtTel.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Numara & Şifre");
            }
            bgl.baglanti().Close();

        }
    }
}
