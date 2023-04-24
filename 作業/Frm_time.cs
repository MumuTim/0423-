using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace 作業
{
    public partial class Frm_time : Form
    {
        public Frm_time()
        {
            InitializeComponent();
        }
        string input = "";
        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime n = DateTime.Now;
            labtime.Text = n.ToString("HH:mm:ss");
            if (textBox1.Text+"00"== n.ToString("HHmmss"))
            {
                MessageBox.Show("時間到囉", "注意", MessageBoxButtons.OK);
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            
            string input = textBox1.Text;
            DateTime time;
            if (DateTime.TryParseExact(input, "HHmm", null, System.Globalization.DateTimeStyles.None, out time))
            {
                MessageBox.Show("設置成功", "注意", MessageBoxButtons.OK );
            }
            else 
            {
                MessageBox.Show("格式不正確，請重新輸入", "注意", MessageBoxButtons.OK);
                textBox1.Clear();
                textBox1.Focus();
            }


         }
    }
}
