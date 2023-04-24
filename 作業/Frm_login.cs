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
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
 
            string Name = txt_account.Text;
            string Password = txt_password.Text;

            MessageBox.Show("會員 :  "+Name+"\n\n          登入成功");
         }

     }
 }
 
