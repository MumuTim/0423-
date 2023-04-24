using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 作業
{
    public partial class Frm_student2 : Form
    {
        public Frm_student2()
        {
            InitializeComponent();
        }
        public struct Score
        {
            public string Name;
            public int Chn;
            public int Eng;
            public int Math;

        }
        ArrayList Scr = new ArrayList();
        void ShowProductList()
        {
            int stutotal = 0;
        
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Score scr;
            scr.Name= txtname.Text;
            scr.Chn = Int32.Parse(txtchn.Text);
            scr.Eng = Int32.Parse(txteng.Text);
            scr.Math = Int32.Parse(txtmath.Text);

        }
    }
}
