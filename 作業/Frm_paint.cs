using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 作業
{
    public partial class Frm_paint : Form
    {
        public Frm_paint()
        {
            InitializeComponent();
        }
        int X0, Y0;
        Bitmap R;

        private void picbox1_MouseDown(object sender, MouseEventArgs e)
        {
            X0 = e.X;
            Y0 = e.Y;
            picbox1.Image = new Bitmap(1068, 564);
        }

        private void btncolor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.BackColor = colorDialog1.Color;
           
        }

        private void picbox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(R);
                Pen p = new Pen(colorDialog1.Color, trackBar1.Value);
                g.DrawLine(p, X0, Y0, e.X, e.Y);
                X0 = e.X;
                Y0 = e.Y;
                picbox1.Refresh();
                picbox1.Image = R;

                

            }
        }

        
        
    }
}
