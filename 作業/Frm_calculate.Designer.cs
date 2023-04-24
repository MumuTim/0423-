namespace 作業
{
    partial class Frm_calculate
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
            this.btnplus = new System.Windows.Forms.Button();
            this.btnsubtract = new System.Windows.Forms.Button();
            this.btnmulti = new System.Windows.Forms.Button();
            this.btndivid = new System.Windows.Forms.Button();
            this.btnequ = new System.Windows.Forms.Button();
            this.lab = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.txtbox2 = new System.Windows.Forms.TextBox();
            this.txtbox3 = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnplus
            // 
            this.btnplus.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnplus.Location = new System.Drawing.Point(631, 32);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(102, 47);
            this.btnplus.TabIndex = 0;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btnsubtract
            // 
            this.btnsubtract.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnsubtract.Location = new System.Drawing.Point(631, 106);
            this.btnsubtract.Name = "btnsubtract";
            this.btnsubtract.Size = new System.Drawing.Size(102, 47);
            this.btnsubtract.TabIndex = 1;
            this.btnsubtract.Text = "-";
            this.btnsubtract.UseVisualStyleBackColor = true;
            this.btnsubtract.Click += new System.EventHandler(this.btnsubtract_Click);
            // 
            // btnmulti
            // 
            this.btnmulti.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnmulti.Location = new System.Drawing.Point(631, 181);
            this.btnmulti.Name = "btnmulti";
            this.btnmulti.Size = new System.Drawing.Size(102, 47);
            this.btnmulti.TabIndex = 2;
            this.btnmulti.Text = "*";
            this.btnmulti.UseVisualStyleBackColor = true;
            this.btnmulti.Click += new System.EventHandler(this.btnmulti_Click);
            // 
            // btndivid
            // 
            this.btndivid.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btndivid.Location = new System.Drawing.Point(631, 252);
            this.btndivid.Name = "btndivid";
            this.btndivid.Size = new System.Drawing.Size(102, 47);
            this.btndivid.TabIndex = 3;
            this.btndivid.Text = "/";
            this.btndivid.UseVisualStyleBackColor = true;
            this.btndivid.Click += new System.EventHandler(this.btndivid_Click);
            // 
            // btnequ
            // 
            this.btnequ.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnequ.Location = new System.Drawing.Point(631, 329);
            this.btnequ.Name = "btnequ";
            this.btnequ.Size = new System.Drawing.Size(102, 47);
            this.btnequ.TabIndex = 4;
            this.btnequ.Text = "=";
            this.btnequ.UseVisualStyleBackColor = true;
            this.btnequ.Click += new System.EventHandler(this.btnequ_Click);
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab.Location = new System.Drawing.Point(293, 163);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(0, 43);
            this.lab.TabIndex = 5;
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab2.Location = new System.Drawing.Point(167, 300);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(44, 43);
            this.lab2.TabIndex = 6;
            this.lab2.Text = "=";
            // 
            // txtbox1
            // 
            this.txtbox1.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtbox1.Location = new System.Drawing.Point(115, 156);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(146, 57);
            this.txtbox1.TabIndex = 7;
            this.txtbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbox2
            // 
            this.txtbox2.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtbox2.Location = new System.Drawing.Point(356, 156);
            this.txtbox2.Name = "txtbox2";
            this.txtbox2.Size = new System.Drawing.Size(146, 57);
            this.txtbox2.TabIndex = 8;
            this.txtbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbox3
            // 
            this.txtbox3.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtbox3.Location = new System.Drawing.Point(236, 293);
            this.txtbox3.Name = "txtbox3";
            this.txtbox3.ReadOnly = true;
            this.txtbox3.Size = new System.Drawing.Size(228, 57);
            this.txtbox3.TabIndex = 9;
            this.txtbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnclear.Location = new System.Drawing.Point(480, 293);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(92, 54);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Frm_calculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.txtbox3);
            this.Controls.Add(this.txtbox2);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.btnequ);
            this.Controls.Add(this.btndivid);
            this.Controls.Add(this.btnmulti);
            this.Controls.Add(this.btnsubtract);
            this.Controls.Add(this.btnplus);
            this.Name = "Frm_calculate";
            this.Text = "計算機";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnsubtract;
        private System.Windows.Forms.Button btnmulti;
        private System.Windows.Forms.Button btndivid;
        private System.Windows.Forms.Button btnequ;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.TextBox txtbox2;
        private System.Windows.Forms.TextBox txtbox3;
        private System.Windows.Forms.Button btnclear;
    }
}