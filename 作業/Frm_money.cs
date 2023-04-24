using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 作業
{
    public partial class Frm_money : Form
    {
        public Frm_money()
        {
            InitializeComponent();
        }

        private void btndo_it_Click(object sender, EventArgs e)
        {
            double Money = Int32.Parse(txtmoney.Text);
            double Month = Int32.Parse(txtmonth.Text);
            double Rate = Int32.Parse(txtrate.Text);
            double Payment = Int32.Parse(txtpayment.Text);
            string resultmonth = ((Money - Payment) * (1 + Rate / 100) / Month).ToString();
            string resultallmoney = ((Money - Payment) * (1 + Rate / 100)+ Payment).ToString();

            txtmonthpay.Text = resultmonth;
            txtallmoney.Text = resultallmoney;

        }
    }
}
