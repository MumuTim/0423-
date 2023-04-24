using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 作業
{
    public partial class Frm_OX : Form
    {
        public Frm_OX()
        {
            InitializeComponent();
        }
        int Y = 0;
        int aY = 0;
        int bY = 0;
        int cY = 0;
        int dY = 0;
        int eY = 0;
        int fY = 0;
        int gY = 0;
        int hY = 0;
        int iY = 0;
        int Z = 0;

        string O = "O";
        string X = "X";


        private void btnO_Click(object sender, EventArgs e)
        {
            Y = 0;
            Y =1;
        }
        private void btnX_Click(object sender, EventArgs e)
        {
            Y = 0;
            Y = -1;           
        }
        private void btn1_Click(object sender, EventArgs e)
        {
             
                aY = Y;
                Z++;

            if (aY == 1)
            {
                btn1.Text = O;
            }
            else if (aY == -1)
            {
                btn1.Text = X;
            }
            else;



            if (aY + bY + cY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + bY + cY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + dY + gY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + dY + gY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + eY + iY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + eY + iY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (bY + eY + hY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (bY + eY + hY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + eY + gY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + eY + gY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + fY + iY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + fY + iY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dY + eY + fY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dY + eY + fY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (gY + hY + iY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (gY + hY + iY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Z == 9)
            {
                MessageBox.Show("平手", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            
                bY =  Y;
                 Z++;
            if (bY == 1)
            {
                btn2.Text = O;
            }
            else if (bY == -1)
            {
                btn2.Text = X;
            }
            else;
      
            if (aY + bY + cY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + bY + cY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + dY + gY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + dY + gY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + eY + iY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + eY + iY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (bY + eY + hY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (bY + eY + hY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + eY + gY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + eY + gY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + fY + iY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + fY + iY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dY + eY + fY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dY + eY + fY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (gY + hY + iY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (gY + hY + iY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Z== 9)
            {
                MessageBox.Show("平手", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            else;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
                cY = Y;
                 Z++;
            if (cY == 1)
            {
                btn3.Text = O;
            }
            else if (cY == -1)
            {
                btn3.Text = X;
            }
            else;
         


            if (aY + bY + cY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + bY + cY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + dY + gY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + dY + gY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + eY + iY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + eY + iY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (bY + eY + hY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (bY + eY + hY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + eY + gY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + eY + gY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + fY + iY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + fY + iY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dY + eY + fY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dY + eY + fY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (gY + hY + iY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (gY + hY + iY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Z== 9)
            {
                MessageBox.Show("平手", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            else;


        }

        private void btn4_Click(object sender, EventArgs e)
        {
            dY = Y; Z++;
            if (dY == 1)
            {
                btn4.Text = O;
            }
            else if (dY == -1)
            {
                btn4.Text = X;
            }
            else;
      
            if (aY + bY + cY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + bY + cY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + dY + gY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + dY + gY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + eY + iY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + eY + iY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (bY + eY + hY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (bY + eY + hY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + eY + gY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + eY + gY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + fY + iY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + fY + iY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dY + eY + fY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dY + eY + fY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (gY + hY + iY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (gY + hY + iY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Z == 9)
            {
                MessageBox.Show("平手", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            else;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            eY = Y; Z++;
            if (eY == 1)
            {
                btn5.Text = O;
            }
            else if (eY == -1)
            {
                btn5.Text = X;
            }
            else;
          
            if (aY + bY + cY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + bY + cY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + dY + gY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + dY + gY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + eY + iY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + eY + iY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (bY + eY + hY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (bY + eY + hY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + eY + gY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + eY + gY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + fY + iY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + fY + iY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dY + eY + fY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dY + eY + fY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (gY + hY + iY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (gY + hY + iY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Z == 9)
            {
                MessageBox.Show("平手", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            else;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            fY = Y; Z++;
            if (fY == 1)
            {
                btn6.Text = O;
            }
            else if (fY == -1)
            {
                btn6.Text = X;
            }
            else;
               
            if (aY + bY + cY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + bY + cY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + dY + gY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + dY + gY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + eY + iY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + eY + iY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (bY + eY + hY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (bY + eY + hY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + eY + gY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + eY + gY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + fY + iY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + fY + iY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dY + eY + fY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dY + eY + fY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (gY + hY + iY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (gY + hY + iY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Z== 9)
            {
                MessageBox.Show("平手", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            else;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            gY = Y; Z++;
            if (gY == 1)
            {
                btn7.Text = O;
            }
            else if (gY == -1)
            {
                btn7.Text = X;
            }
            else;
                
            if (aY + bY + cY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + bY + cY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + dY + gY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + dY + gY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + eY + iY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + eY + iY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (bY + eY + hY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (bY + eY + hY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + eY + gY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + eY + gY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + fY + iY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + fY + iY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dY + eY + fY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dY + eY + fY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (gY + hY + iY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (gY + hY + iY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Z== 9)
            {
                MessageBox.Show("平手", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            else;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            hY = Y; Z++;
            if (hY == 1)
            {
                btn8.Text = O;
            }
            else if (hY == -1)
            {
                btn8.Text = X;
            }
            else;
               
            if (aY + bY + cY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + bY + cY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + dY + gY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + dY + gY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + eY + iY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + eY + iY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (bY + eY + hY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (bY + eY + hY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + eY + gY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + eY + gY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + fY + iY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + fY + iY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dY + eY + fY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dY + eY + fY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (gY + hY + iY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (gY + hY + iY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Z== 9)
            {
                MessageBox.Show("平手", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            else;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            iY = Y; Z++;
            if (iY == 1)
            {
                btn9.Text = O;
            }
            else if (iY == -1)
            {
                btn9.Text = X;
            }
            else;
            
            if (aY + bY + cY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + bY + cY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + dY + gY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + dY + gY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + eY + iY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aY + eY + iY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (bY + eY + hY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (bY + eY + hY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + eY + gY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + eY + gY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + fY + iY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cY + fY + iY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dY + eY + fY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dY + eY + fY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (gY + hY + iY == 3)
            {
                MessageBox.Show("OO勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (gY + hY + iY == -3)
            {
                MessageBox.Show("XX勝利", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Z== 9)
            {
                MessageBox.Show("平手", "勝負結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnrestart_Click(object sender, EventArgs e)
        {
             Y = 0;
             aY = 0;
             bY = 0;
             cY = 0;
             dY = 0;
             eY = 0;
             fY = 0;
             gY = 0;
             hY = 0;
             iY = 0;
             Z = 0;
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            
        }
    }
}
