namespace 作業
{
    partial class Frm_student
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
            this.labname = new System.Windows.Forms.Label();
            this.labchn = new System.Windows.Forms.Label();
            this.labeng = new System.Windows.Forms.Label();
            this.labmath = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtchn = new System.Windows.Forms.TextBox();
            this.txteng = new System.Windows.Forms.TextBox();
            this.txtmath = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnshowsave = new System.Windows.Forms.Button();
            this.btnmaxmin = new System.Windows.Forms.Button();
            this.txtshowgrade = new System.Windows.Forms.TextBox();
            this.txtmaxmin = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // labname
            // 
            this.labname.AutoSize = true;
            this.labname.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labname.Location = new System.Drawing.Point(45, 30);
            this.labname.Name = "labname";
            this.labname.Size = new System.Drawing.Size(53, 24);
            this.labname.TabIndex = 0;
            this.labname.Text = "姓名:";
            // 
            // labchn
            // 
            this.labchn.AutoSize = true;
            this.labchn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labchn.Location = new System.Drawing.Point(45, 91);
            this.labchn.Name = "labchn";
            this.labchn.Size = new System.Drawing.Size(53, 24);
            this.labchn.TabIndex = 1;
            this.labchn.Text = "國文:";
            // 
            // labeng
            // 
            this.labeng.AutoSize = true;
            this.labeng.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labeng.Location = new System.Drawing.Point(45, 148);
            this.labeng.Name = "labeng";
            this.labeng.Size = new System.Drawing.Size(53, 24);
            this.labeng.TabIndex = 2;
            this.labeng.Text = "英文:";
            // 
            // labmath
            // 
            this.labmath.AutoSize = true;
            this.labmath.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labmath.Location = new System.Drawing.Point(45, 213);
            this.labmath.Name = "labmath";
            this.labmath.Size = new System.Drawing.Size(53, 24);
            this.labmath.TabIndex = 3;
            this.labmath.Text = "數學:";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtname.Location = new System.Drawing.Point(114, 21);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 33);
            this.txtname.TabIndex = 4;
            // 
            // txtchn
            // 
            this.txtchn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtchn.Location = new System.Drawing.Point(114, 82);
            this.txtchn.Name = "txtchn";
            this.txtchn.Size = new System.Drawing.Size(100, 33);
            this.txtchn.TabIndex = 5;
            // 
            // txteng
            // 
            this.txteng.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txteng.Location = new System.Drawing.Point(114, 145);
            this.txteng.Name = "txteng";
            this.txteng.Size = new System.Drawing.Size(100, 33);
            this.txteng.TabIndex = 6;
            // 
            // txtmath
            // 
            this.txtmath.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtmath.Location = new System.Drawing.Point(114, 204);
            this.txtmath.Name = "txtmath";
            this.txtmath.Size = new System.Drawing.Size(100, 33);
            this.txtmath.TabIndex = 7;
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnsave.Location = new System.Drawing.Point(31, 279);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(118, 45);
            this.btnsave.TabIndex = 8;
            this.btnsave.Text = "儲存";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnshowsave
            // 
            this.btnshowsave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnshowsave.Location = new System.Drawing.Point(188, 279);
            this.btnshowsave.Name = "btnshowsave";
            this.btnshowsave.Size = new System.Drawing.Size(118, 45);
            this.btnshowsave.TabIndex = 9;
            this.btnshowsave.Text = "顯示儲存內容";
            this.btnshowsave.UseVisualStyleBackColor = true;
            this.btnshowsave.Click += new System.EventHandler(this.btnshowsave_Click);
            // 
            // btnmaxmin
            // 
            this.btnmaxmin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnmaxmin.Location = new System.Drawing.Point(408, 279);
            this.btnmaxmin.Name = "btnmaxmin";
            this.btnmaxmin.Size = new System.Drawing.Size(155, 45);
            this.btnmaxmin.TabIndex = 10;
            this.btnmaxmin.Text = "最高分/最低分科目";
            this.btnmaxmin.UseVisualStyleBackColor = true;
            this.btnmaxmin.Click += new System.EventHandler(this.btnmaxmin_Click);
            // 
            // txtshowgrade
            // 
            this.txtshowgrade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtshowgrade.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtshowgrade.Location = new System.Drawing.Point(6, 21);
            this.txtshowgrade.Multiline = true;
            this.txtshowgrade.Name = "txtshowgrade";
            this.txtshowgrade.ReadOnly = true;
            this.txtshowgrade.Size = new System.Drawing.Size(309, 142);
            this.txtshowgrade.TabIndex = 11;
            // 
            // txtmaxmin
            // 
            this.txtmaxmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmaxmin.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtmaxmin.Location = new System.Drawing.Point(6, 169);
            this.txtmaxmin.Multiline = true;
            this.txtmaxmin.Name = "txtmaxmin";
            this.txtmaxmin.ReadOnly = true;
            this.txtmaxmin.Size = new System.Drawing.Size(309, 50);
            this.txtmaxmin.TabIndex = 12;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.txtshowgrade);
            this.groupBox.Controls.Add(this.txtmaxmin);
            this.groupBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox.Location = new System.Drawing.Point(242, 21);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(321, 224);
            this.groupBox.TabIndex = 13;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "成績";
            // 
            // Frm_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnmaxmin);
            this.Controls.Add(this.btnshowsave);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtmath);
            this.Controls.Add(this.txteng);
            this.Controls.Add(this.txtchn);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.labmath);
            this.Controls.Add(this.labeng);
            this.Controls.Add(this.labchn);
            this.Controls.Add(this.labname);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_student";
            this.Text = "學生11111";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labname;
        private System.Windows.Forms.Label labchn;
        private System.Windows.Forms.Label labeng;
        private System.Windows.Forms.Label labmath;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtchn;
        private System.Windows.Forms.TextBox txteng;
        private System.Windows.Forms.TextBox txtmath;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnshowsave;
        private System.Windows.Forms.Button btnmaxmin;
        private System.Windows.Forms.TextBox txtshowgrade;
        private System.Windows.Forms.TextBox txtmaxmin;
        private System.Windows.Forms.GroupBox groupBox;
    }
}