using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto_gallery
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaticiGiris fr= new SaticiGiris();
            fr.Show();
            this.Hide();

        }

        private void BtnClientGiris_Click(object sender, EventArgs e)
        {
            ClientGiris fr=new ClientGiris();
            fr.Show();
            this.Hide();
        }

        private void BtnManagerGiris_Click(object sender, EventArgs e)
        {
            ManagerGiris fr=new ManagerGiris();
            fr.Show();
            this.Hide();
        }
    }
}
