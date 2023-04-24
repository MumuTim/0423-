using System;
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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btn_member_Click(object sender, EventArgs e)
        {
            Frm_login frm = new Frm_login();
            frm.Show();
        }

        private void btnmoney_Click(object sender, EventArgs e)
        {
            Frm_money frm = new Frm_money();
            frm.Show();
        }

        private void btncalcu_Click(object sender, EventArgs e)
        {
            Frm_calculate frm = new Frm_calculate();
            frm.Show();
        }

        private void btnstudent1_Click(object sender, EventArgs e)
        {
            Frm_student frm = new Frm_student();
            frm.Show();
        }

        private void btnOX_Click(object sender, EventArgs e)
        {
            Frm_OX frm = new Frm_OX();
            frm.Show();
        }

        private void btnpos_Click(object sender, EventArgs e)
        {
            Frm_pos frm = new Frm_pos();
            frm.Show();
        }

        private void btnpaint_Click(object sender, EventArgs e)
        {
            Frm_paint frm = new Frm_paint();
            frm.Show();
        }

        private void btnnote_Click(object sender, EventArgs e)
        {
            Frm_note frm = new Frm_note();
            frm.Show();
        }

        private void btnarray_Click(object sender, EventArgs e)
        {
            Frm_array frm = new Frm_array();
            frm.Show();
        }

        private void btntime_Click(object sender, EventArgs e)
        {
            Frm_time frm = new Frm_time();
            frm.Show();
        }

        private void btnstudent2_Click(object sender, EventArgs e)
        {
            Frm_student2 frm = new Frm_student2();
            frm.Show();
        }

        private void btnscreen_Click(object sender, EventArgs e)
        {
            Frm_screen frm = new Frm_screen();
            frm.Show();
        }
    }
}
