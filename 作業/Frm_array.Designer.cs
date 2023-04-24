namespace 作業
{
    partial class Frm_array
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labresult = new System.Windows.Forms.Label();
            this.btn99 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labfrom = new System.Windows.Forms.Label();
            this.labto = new System.Windows.Forms.Label();
            this.labstep = new System.Windows.Forms.Label();
            this.btnfor = new System.Windows.Forms.Button();
            this.btnwhile = new System.Windows.Forms.Button();
            this.btndo = new System.Windows.Forms.Button();
            this.txtfrom = new System.Windows.Forms.TextBox();
            this.txtto = new System.Windows.Forms.TextBox();
            this.txtstep = new System.Windows.Forms.TextBox();
            this.btnsum = new System.Windows.Forms.Button();
            this.btnmax = new System.Windows.Forms.Button();
            this.btnmin = new System.Windows.Forms.Button();
            this.labnumber = new System.Windows.Forms.Label();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.btn0422 = new System.Windows.Forms.Button();
            this.btn奇偶 = new System.Windows.Forms.Button();
            this.btntree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labresult
            // 
            this.labresult.AutoSize = true;
            this.labresult.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labresult.Location = new System.Drawing.Point(31, 370);
            this.labresult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labresult.Name = "labresult";
            this.labresult.Size = new System.Drawing.Size(222, 50);
            this.labresult.TabIndex = 0;
            this.labresult.Text = "結果Result";
            // 
            // btn99
            // 
            this.btn99.BackColor = System.Drawing.Color.RosyBrown;
            this.btn99.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn99.Location = new System.Drawing.Point(969, 292);
            this.btn99.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn99.Name = "btn99";
            this.btn99.Size = new System.Drawing.Size(136, 49);
            this.btn99.TabIndex = 2;
            this.btn99.Text = "九九乘法表";
            this.btn99.UseVisualStyleBackColor = false;
            this.btn99.Click += new System.EventHandler(this.btn99_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(16, 434);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 3;
            // 
            // labfrom
            // 
            this.labfrom.AutoSize = true;
            this.labfrom.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labfrom.Location = new System.Drawing.Point(706, 264);
            this.labfrom.Name = "labfrom";
            this.labfrom.Size = new System.Drawing.Size(61, 22);
            this.labfrom.TabIndex = 4;
            this.labfrom.Text = "From :";
            // 
            // labto
            // 
            this.labto.AutoSize = true;
            this.labto.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labto.Location = new System.Drawing.Point(706, 305);
            this.labto.Name = "labto";
            this.labto.Size = new System.Drawing.Size(39, 22);
            this.labto.TabIndex = 5;
            this.labto.Text = "To :";
            // 
            // labstep
            // 
            this.labstep.AutoSize = true;
            this.labstep.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labstep.Location = new System.Drawing.Point(706, 344);
            this.labstep.Name = "labstep";
            this.labstep.Size = new System.Drawing.Size(56, 22);
            this.labstep.TabIndex = 6;
            this.labstep.Text = "Step :";
            // 
            // btnfor
            // 
            this.btnfor.BackColor = System.Drawing.Color.RosyBrown;
            this.btnfor.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnfor.Location = new System.Drawing.Point(850, 260);
            this.btnfor.Margin = new System.Windows.Forms.Padding(4);
            this.btnfor.Name = "btnfor";
            this.btnfor.Size = new System.Drawing.Size(95, 36);
            this.btnfor.TabIndex = 7;
            this.btnfor.Text = "For";
            this.btnfor.UseVisualStyleBackColor = false;
            this.btnfor.Click += new System.EventHandler(this.btnfor_Click);
            // 
            // btnwhile
            // 
            this.btnwhile.BackColor = System.Drawing.Color.RosyBrown;
            this.btnwhile.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnwhile.Location = new System.Drawing.Point(850, 298);
            this.btnwhile.Margin = new System.Windows.Forms.Padding(4);
            this.btnwhile.Name = "btnwhile";
            this.btnwhile.Size = new System.Drawing.Size(95, 36);
            this.btnwhile.TabIndex = 8;
            this.btnwhile.Text = "While";
            this.btnwhile.UseVisualStyleBackColor = false;
            this.btnwhile.Click += new System.EventHandler(this.btnwhile_Click);
            // 
            // btndo
            // 
            this.btndo.BackColor = System.Drawing.Color.RosyBrown;
            this.btndo.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btndo.Location = new System.Drawing.Point(850, 333);
            this.btndo.Margin = new System.Windows.Forms.Padding(4);
            this.btndo.Name = "btndo";
            this.btndo.Size = new System.Drawing.Size(95, 36);
            this.btndo.TabIndex = 9;
            this.btndo.Text = "do";
            this.btndo.UseVisualStyleBackColor = false;
            this.btndo.Click += new System.EventHandler(this.btndo_Click);
            // 
            // txtfrom
            // 
            this.txtfrom.Location = new System.Drawing.Point(774, 266);
            this.txtfrom.Name = "txtfrom";
            this.txtfrom.Size = new System.Drawing.Size(69, 25);
            this.txtfrom.TabIndex = 10;
            // 
            // txtto
            // 
            this.txtto.Location = new System.Drawing.Point(774, 302);
            this.txtto.Name = "txtto";
            this.txtto.Size = new System.Drawing.Size(69, 25);
            this.txtto.TabIndex = 11;
            // 
            // txtstep
            // 
            this.txtstep.Location = new System.Drawing.Point(774, 341);
            this.txtstep.Name = "txtstep";
            this.txtstep.Size = new System.Drawing.Size(69, 25);
            this.txtstep.TabIndex = 12;
            // 
            // btnsum
            // 
            this.btnsum.BackColor = System.Drawing.Color.RosyBrown;
            this.btnsum.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnsum.Location = new System.Drawing.Point(1028, 60);
            this.btnsum.Margin = new System.Windows.Forms.Padding(4);
            this.btnsum.Name = "btnsum";
            this.btnsum.Size = new System.Drawing.Size(148, 36);
            this.btnsum.TabIndex = 13;
            this.btnsum.Text = "Sum陣列0422";
            this.btnsum.UseVisualStyleBackColor = false;
            this.btnsum.Click += new System.EventHandler(this.btnsum_Click);
            // 
            // btnmax
            // 
            this.btnmax.BackColor = System.Drawing.Color.RosyBrown;
            this.btnmax.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnmax.Location = new System.Drawing.Point(1028, 104);
            this.btnmax.Margin = new System.Windows.Forms.Padding(4);
            this.btnmax.Name = "btnmax";
            this.btnmax.Size = new System.Drawing.Size(148, 36);
            this.btnmax.TabIndex = 14;
            this.btnmax.Text = "Max陣列0422";
            this.btnmax.UseVisualStyleBackColor = false;
            this.btnmax.Click += new System.EventHandler(this.btnmax_Click);
            // 
            // btnmin
            // 
            this.btnmin.BackColor = System.Drawing.Color.RosyBrown;
            this.btnmin.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnmin.Location = new System.Drawing.Point(1028, 148);
            this.btnmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(148, 36);
            this.btnmin.TabIndex = 15;
            this.btnmin.Text = "Min陣列0422";
            this.btnmin.UseVisualStyleBackColor = false;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // labnumber
            // 
            this.labnumber.AutoSize = true;
            this.labnumber.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labnumber.Location = new System.Drawing.Point(22, 15);
            this.labnumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labnumber.Name = "labnumber";
            this.labnumber.Size = new System.Drawing.Size(117, 29);
            this.labnumber.TabIndex = 16;
            this.labnumber.Text = "Number :";
            // 
            // txtnumber
            // 
            this.txtnumber.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtnumber.Location = new System.Drawing.Point(146, 12);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(119, 38);
            this.txtnumber.TabIndex = 17;
            // 
            // btn0422
            // 
            this.btn0422.BackColor = System.Drawing.Color.RosyBrown;
            this.btn0422.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn0422.Location = new System.Drawing.Point(872, 60);
            this.btn0422.Margin = new System.Windows.Forms.Padding(4);
            this.btn0422.Name = "btn0422";
            this.btn0422.Size = new System.Drawing.Size(148, 36);
            this.btn0422.TabIndex = 18;
            this.btn0422.Text = "奇偶陣列0422";
            this.btn0422.UseVisualStyleBackColor = false;
            this.btn0422.Click += new System.EventHandler(this.btn0422_Click);
            // 
            // btn奇偶
            // 
            this.btn奇偶.BackColor = System.Drawing.Color.RosyBrown;
            this.btn奇偶.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn奇偶.Location = new System.Drawing.Point(20, 60);
            this.btn奇偶.Margin = new System.Windows.Forms.Padding(4);
            this.btn奇偶.Name = "btn奇偶";
            this.btn奇偶.Size = new System.Drawing.Size(179, 36);
            this.btn奇偶.TabIndex = 19;
            this.btn奇偶.Text = "輸入數字為奇或偶?";
            this.btn奇偶.UseVisualStyleBackColor = false;
            this.btn奇偶.Click += new System.EventHandler(this.btn奇偶_Click);
            // 
            // btntree
            // 
            this.btntree.BackColor = System.Drawing.Color.RosyBrown;
            this.btntree.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btntree.Location = new System.Drawing.Point(296, 15);
            this.btntree.Margin = new System.Windows.Forms.Padding(4);
            this.btntree.Name = "btntree";
            this.btntree.Size = new System.Drawing.Size(148, 36);
            this.btntree.TabIndex = 20;
            this.btntree.Text = "樹";
            this.btntree.UseVisualStyleBackColor = false;
            this.btntree.Click += new System.EventHandler(this.btntree_Click);
            // 
            // Frm_array
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 951);
            this.Controls.Add(this.btntree);
            this.Controls.Add(this.btn奇偶);
            this.Controls.Add(this.btn0422);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.labnumber);
            this.Controls.Add(this.btnmin);
            this.Controls.Add(this.btnmax);
            this.Controls.Add(this.btnsum);
            this.Controls.Add(this.txtstep);
            this.Controls.Add(this.txtto);
            this.Controls.Add(this.txtfrom);
            this.Controls.Add(this.btndo);
            this.Controls.Add(this.btnwhile);
            this.Controls.Add(this.btnfor);
            this.Controls.Add(this.labstep);
            this.Controls.Add(this.labto);
            this.Controls.Add(this.labfrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn99);
            this.Controls.Add(this.labresult);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_array";
            this.Text = "Frm_array";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labresult;
        private System.Windows.Forms.Button btn99;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labfrom;
        private System.Windows.Forms.Label labto;
        private System.Windows.Forms.Label labstep;
        private System.Windows.Forms.Button btnfor;
        private System.Windows.Forms.Button btnwhile;
        private System.Windows.Forms.Button btndo;
        private System.Windows.Forms.TextBox txtfrom;
        private System.Windows.Forms.TextBox txtto;
        private System.Windows.Forms.TextBox txtstep;
        private System.Windows.Forms.Button btnsum;
        private System.Windows.Forms.Button btnmax;
        private System.Windows.Forms.Button btnmin;
        private System.Windows.Forms.Label labnumber;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.Button btn0422;
        private System.Windows.Forms.Button btn奇偶;
        private System.Windows.Forms.Button btntree;
    }
}