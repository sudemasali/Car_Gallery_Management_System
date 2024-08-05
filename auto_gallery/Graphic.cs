using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Data.SqlClient;


namespace auto_gallery
{
    public partial class Graphic : Form
    {
        public Graphic()
        {
            InitializeComponent();
        }
     

        private void Graphic_Load(object sender, EventArgs e)
        { 

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            float r1, r2, r3, total;
            r1 = int.Parse(textBox1.Text);
            r2 = int.Parse(textBox2.Text);
            r3 = int.Parse(textBox3.Text);
            total = r1 + r2 + r3;
            float pr1, pr2, pr3;
            pr1 = (r1 / total) * 360;
            pr2 = (r2 / total) * 360;
            pr3 = (r3 / total) * 360;
            Pen p = new Pen(Graphic.DefaultBackColor);
           
            Graphics g = this.CreateGraphics();
            Rectangle rec = new Rectangle(button1.Location.X + button1.Size.Width + 20, 20, 250, 250);
            Brush b1 = new SolidBrush(Color.Red);
            Brush b2 = new SolidBrush(Color.White);
            Brush b3 = new SolidBrush(Color.Turquoise);
            g.Clear(Graphic.DefaultBackColor);


            g.DrawPie(p, rec, 0, pr1);
            g.FillPie(b1, rec, 0, pr1);
            g.DrawPie(p, rec, pr1, pr2);
            g.FillPie(b2, rec, pr1, pr2);
            g.DrawPie(p, rec, pr1 + pr2, pr3);
            g.FillPie(b3, rec, pr1 + pr2, pr3);
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            button1_Click_1(sender, e);
        }

        
    }
}

    

