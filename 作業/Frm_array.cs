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
    public partial class Frm_array : Form
    {
        public Frm_array()
        {
            InitializeComponent();
        }

        private void btn99_Click(object sender, EventArgs e)
        {
            int a, b, c;
            for (a = 1; a < 10; a++)
            {
                for (b = 1; b < 10; b++)
                {
                    c = a * b;
                    label1.Text += (a + " X " + b + " = " + c+"  ");
                }
                label1.Text += "\n";
            }
        }

        private void btnfor_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(txtfrom.Text);
            int b = Int32.Parse(txtto.Text);
            int c = Int32.Parse(txtstep.Text);
            int d = 0;
            
            for (int i = a; i<= b; i += c)
            {
                d += i;
            }
            label1.Text = txtfrom.Text+" 到 "+ txtto.Text+ " 相隔 "+ txtstep.Text+"\n"
                +" 加總為 "+ d.ToString();
        }

        private void btndo_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(txtfrom.Text);
            int b = Int32.Parse(txtto.Text);
            int c = Int32.Parse(txtstep.Text);
            int d = 0;

            int i = a;
            do
            {
                d += i;
                label1.Text = txtfrom.Text + " 到 " + txtto.Text + " 相隔 " + txtstep.Text + "\n"
                + " 加總為 " + d.ToString();
                i += c;
            }while (i < b);

        }

        private void btnwhile_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(txtfrom.Text);
            int b = Int32.Parse(txtto.Text);
            int c = Int32.Parse(txtstep.Text);
            int d = 0;

            int i = a;
            while (i < b) 
            {
                d += i;
                label1.Text = txtfrom.Text + " 到 " + txtto.Text + " 相隔 " + txtstep.Text + "\n"
                + " 加總為 " + d.ToString();
                i += c;
            } 

        }

        int[] arr0422 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
        private void btnsum_Click(object sender, EventArgs e)
        {
            int avgNum = arr0422.Sum();
            label1.Text =" int陣列 arr0422 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 }"+"\n"+"加總為"+avgNum.ToString();
        }
        private void btnmax_Click(object sender, EventArgs e)
        {
            label1.Text = " int陣列 arr0422 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 }" + "\n"+"最大值為"+ arr0422.Max().ToString();
        }
        private void btnmin_Click(object sender, EventArgs e)
        {
            label1.Text = " int陣列 arr0422 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 }" + "\n" + "最大值為" + arr0422.Min().ToString();
        }

        private void btn奇偶_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(txtnumber.Text) % 2 == 0)
            {
                label1.Text = "輸入的數字為 " + txtnumber.Text + " 偶數";
                 }
            else 
            {
                label1.Text = "輸入的數字為 " + txtnumber.Text + " 奇數";
            }

        }

        private void btn0422_Click(object sender, EventArgs e)
        {
            int a = arr0422.Count();
            int b = 0;
            for (int i = 0; i < arr0422.Length; i++)
            {
                if (arr0422[i] % 2 == 0)
                {
                    b++;
                }
            }
            label1.Text = " int陣列 arr0422 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 }"+"\n"
                +"奇數共" +( a-b).ToString()+"\n"
                +"偶數共"+b.ToString();
        }

        private void btntree_Click(object sender, EventArgs e)
        {   
            int x = Int32.Parse(txtnumber.Text);
            for (int i = 1; i <=x; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    label1.Text += "*";
                }
                label1.Text += "\n";
            }

        }
    }
}
