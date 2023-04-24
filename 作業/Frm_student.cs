using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static 作業.Frm_student;

namespace 作業
{
    public partial class Frm_student : Form
    {
        public Frm_student()
        {
            InitializeComponent();
        }
         public static string S = "";
         public static string B = "";
        public struct Grade
        {
            public string Name { get; set; }
            public int ChnGrade { get; set; }
            public int EngGrade { get; set; }
            public int MathGrade { get; set; }

            public Grade(string StName, int StChnGrade, int StEngGrade, int StMathGrade)
            {
                Name = StName;
                ChnGrade = StChnGrade;
                EngGrade = StEngGrade;
                MathGrade = StMathGrade;

                int[] arrInt = { ChnGrade, EngGrade, MathGrade };
                 S = (" 最小分數為 " + arrInt.Min());
                 B = (" 最大分數為 " + arrInt.Max());

            }


        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            txtshowgrade.Visible = false;
            
            int Sumgrade = 0;
            bool isNum = int.TryParse(txtchn.Text+ txteng.Text+ txtmath.Text, out Sumgrade);
            
            if (isNum)
            {

                Grade stgrade = new Grade(txtname.Text, int.Parse(txtchn.Text), int.Parse(txteng.Text), int.Parse(txtmath.Text));
                txtshowgrade.Text = $"\n姓名: {stgrade.Name} ,國文: {stgrade.ChnGrade}  ,英文: {stgrade.EngGrade} ,數學: {stgrade.MathGrade}";
            }
            else
            {
                MessageBox.Show("分數格式錯誤, 請修正");
               
                txtchn.Clear();
                txteng.Clear();
                txtmath.Clear();
                txtchn.Focus();
            }
        }

        
        
        private void btnshowsave_Click(object sender, EventArgs e)
        {
            txtshowgrade.Visible = true;
        }

             
        private void btnmaxmin_Click(object sender, EventArgs e)
        {

            txtmaxmin.Text = S+"\n"+B;

        }
    }
}
