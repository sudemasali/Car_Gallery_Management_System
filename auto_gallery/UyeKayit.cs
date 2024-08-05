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
    public partial class UyeKayit : Form
    {
        public UyeKayit()
        {
            InitializeComponent();
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void BtnKayit_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_client (Client_Name,Client_Surname,Phone,Password) values(@p1,@p2,@p3,@p4)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3",TxtTel.Text);
            komut.Parameters.AddWithValue("@p4", MskPassword.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız gerçekleşmiştir! Şifreniz: " + MskPassword.Text,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);



        }

        private void UyeKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
