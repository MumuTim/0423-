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
    public partial class Frm_pos : Form
    {
        public Frm_pos()
        {
            InitializeComponent();
        }
        int qtycoffee = 0;
        int qtymilk = 0;
        int qtycola = 0;
        int qtybeer = 0;
        string newline = "\n";
        int total = 0;
        private void btncoffee_Click(object sender, EventArgs e)
        {
            qtycoffee++;
            if (qtycoffee == 1)
            {
                txtlist.Text += "咖啡Coffee,x" + qtycoffee + "共NT$" + qtycoffee * 95 + newline;
            }
            else
            {
                txtlist.Text = txtlist.Text.Replace(string.Format("咖啡Coffee,x{0}共NT${1}", qtycoffee - 1, (qtycoffee - 1) * 95), string.Format("咖啡Coffee,x{0}共NT${1}", qtycoffee, qtycoffee * 95 + newline));
            }
            total = (qtycoffee * 95) + (qtymilk * 55) + (qtycola * 40) + (qtybeer * 120);
            txttotalprice.Text = "NT"+"$"+ total.ToString();

        }

        private void btnmilktea_Click(object sender, EventArgs e)
        {

            qtymilk++;
            if (qtymilk == 1)
            {
                txtlist.Text += "鮮奶茶Tea,x" + qtymilk + "共NT$" + qtymilk * 55 + newline;
            }
            else
            {
                txtlist.Text = txtlist.Text.Replace(string.Format("鮮奶茶Tea,x{0}共NT${1}", qtymilk - 1, (qtymilk - 1) * 55), string.Format("鮮奶茶Tea,x{0}共NT${1}", qtymilk, qtymilk * 55 + newline));
            }
            total = (qtycoffee * 95) + (qtymilk * 55) + (qtycola * 40) + (qtybeer * 120);
            txttotalprice.Text = "NT" + "$" + total.ToString();
        }

        private void btncola_Click(object sender, EventArgs e)
        {
            qtycola++;
            if (qtycola == 1)
            {
                txtlist.Text += "可樂Cola,x" + qtycola + "共NT$" + qtycola * 40 + newline;
            }
            else
            {
                txtlist.Text = txtlist.Text.Replace(string.Format("可樂Cola,x{0}共NT${1}", qtycola - 1, (qtycola - 1) * 40), string.Format("可樂Cola,x{0}共NT${1}", qtycola, qtycola * 40 + newline));
            }
            total = (qtycoffee * 95) + (qtymilk * 55) + (qtycola * 40) + (qtybeer * 120);
            txttotalprice.Text = "NT" + "$" + total.ToString();

        }

        private void btnbeer_Click(object sender, EventArgs e)
        {
            qtybeer++;
            if (qtybeer == 1)
            {
                txtlist.Text += "啤酒Beer,x" + qtybeer + "共NT$" + qtybeer * 120 + newline;
            }
            else
            {
                txtlist.Text = txtlist.Text.Replace(string.Format("啤酒Beer,x{0}共NT${1}", qtybeer - 1, (qtybeer - 1) * 120), string.Format("啤酒Beer,x{0}共NT${1}", qtybeer, qtybeer * 120 + newline));
            }
            total = (qtycoffee * 95) + (qtymilk * 55) + (qtycola * 40) + (qtybeer * 120);
            txttotalprice.Text = "NT" + "$" + total.ToString();
        }

        private void btncash_Click(object sender, EventArgs e)
        {
            if(txttotalprice.Text =="")
            {
                MessageBox.Show("尚未點餐!", "確認付款",MessageBoxButtons.OK,MessageBoxIcon.Warning) ;

            }
            else 
            {
                MessageBox.Show("總金額: " + txttotalprice.Text, "確認付款", MessageBoxButtons.YesNo);
            }
        }

        private void btncredit_Click(object sender, EventArgs e)
        {
            if (txttotalprice.Text == "")
            {
                MessageBox.Show("尚未點餐!", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("總金額: " + txttotalprice.Text+"\n"+ "折扣後金額: "+ (total*0.9).ToString(), "確認付款", MessageBoxButtons.YesNo);
            }



        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            qtycoffee = 0;
            qtymilk = 0;
            qtycola = 0;
            qtybeer = 0;
            
            txtlist.Text = "";

            txttotalprice.Text = "";


        }
    }
}

