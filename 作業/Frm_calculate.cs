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
    public partial class Frm_calculate : Form
    {
        public Frm_calculate()
        {
            InitializeComponent();
        }
        int A = 0;
        int a = 0;
        int b = 0; 
       
        void Plus(ref int a, ref int b)
        { }
        void Subtract(ref int a, ref int b)
        { }
        void Multi(ref int a, ref int b)
        { }
        void Divid(ref int a, ref int b)
        { }

        private void btnequ_Click(object sender, EventArgs e)
        {
            if (A == 1)
            {
                int a =Int32.Parse(txtbox1.Text); int b = Int32.Parse(txtbox2.Text);
                Plus(ref a, ref b);
                txtbox3.Text=(a+b).ToString();
            }
            else if (A == 2) 
            {
                int a = Int32.Parse(txtbox1.Text); int b = Int32.Parse(txtbox2.Text);
                Subtract(ref a, ref b);
                txtbox3.Text = (a - b).ToString();
            }
            else if (A == 3)
            {
                int a = Int32.Parse(txtbox1.Text); int b = Int32.Parse(txtbox2.Text);
                Multi(ref a, ref b);
                txtbox3.Text = (a * b).ToString();
            }
            else if (A == 4)
            {
                if (Int32.Parse(txtbox2.Text) == 0)
                {
                    MessageBox.Show("被除數不可是0", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbox2.Text = "";
                    txtbox2.Focus();

                }
                else
                {
                    int a = Int32.Parse(txtbox1.Text); int b = Int32.Parse(txtbox2.Text);
                    Multi(ref a, ref b);
                    txtbox3.Text = (a / b).ToString();
                }
            }
            else 
            {
                MessageBox.Show("請先填入數字和選擇運算方法" , "警告", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            A = 1;
            lab.Text = "+";
            txtbox2.Focus();
        }

        private void btnsubtract_Click(object sender, EventArgs e)
        {
            A = 2;
            lab.Text = "-";
            txtbox2.Focus();
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            A = 3;
            lab.Text = "*";
            txtbox2.Focus();
        }

        private void btndivid_Click(object sender, EventArgs e)
        {
            A = 4;
            lab.Text = "/";
            txtbox2.Focus();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            A = 0;
            txtbox1.Text = " ";
            txtbox2.Text = " ";
            txtbox3.Text = " ";
            lab.Text = " ";
            txtbox1.Focus();
        }
    }
}
