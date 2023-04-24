namespace 作業
{
    partial class Frm_pos
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
            this.grpboxmenu = new System.Windows.Forms.GroupBox();
            this.btnbeer = new System.Windows.Forms.Button();
            this.btncola = new System.Windows.Forms.Button();
            this.btnmilktea = new System.Windows.Forms.Button();
            this.btncoffee = new System.Windows.Forms.Button();
            this.grplist = new System.Windows.Forms.GroupBox();
            this.txtlist = new System.Windows.Forms.TextBox();
            this.grpboxpay = new System.Windows.Forms.GroupBox();
            this.labcredit = new System.Windows.Forms.Label();
            this.btncredit = new System.Windows.Forms.Button();
            this.btncash = new System.Windows.Forms.Button();
            this.grptotal = new System.Windows.Forms.GroupBox();
            this.txttotalprice = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.grpboxmenu.SuspendLayout();
            this.grplist.SuspendLayout();
            this.grpboxpay.SuspendLayout();
            this.grptotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxmenu
            // 
            this.grpboxmenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grpboxmenu.Controls.Add(this.btnbeer);
            this.grpboxmenu.Controls.Add(this.btncola);
            this.grpboxmenu.Controls.Add(this.btnmilktea);
            this.grpboxmenu.Controls.Add(this.btncoffee);
            this.grpboxmenu.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpboxmenu.Location = new System.Drawing.Point(9, 49);
            this.grpboxmenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpboxmenu.Name = "grpboxmenu";
            this.grpboxmenu.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpboxmenu.Size = new System.Drawing.Size(158, 261);
            this.grpboxmenu.TabIndex = 0;
            this.grpboxmenu.TabStop = false;
            this.grpboxmenu.Text = "餐點Menu";
            // 
            // btnbeer
            // 
            this.btnbeer.AutoSize = true;
            this.btnbeer.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnbeer.Location = new System.Drawing.Point(80, 156);
            this.btnbeer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnbeer.Name = "btnbeer";
            this.btnbeer.Size = new System.Drawing.Size(72, 94);
            this.btnbeer.TabIndex = 3;
            this.btnbeer.Text = "啤酒\nBeer\nNT120";
            this.btnbeer.UseVisualStyleBackColor = true;
            this.btnbeer.Click += new System.EventHandler(this.btnbeer_Click);
            // 
            // btncola
            // 
            this.btncola.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btncola.Location = new System.Drawing.Point(4, 156);
            this.btncola.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncola.Name = "btncola";
            this.btncola.Size = new System.Drawing.Size(72, 94);
            this.btncola.TabIndex = 2;
            this.btncola.Text = "可樂\nCola\nNT40";
            this.btncola.UseVisualStyleBackColor = true;
            this.btncola.Click += new System.EventHandler(this.btncola_Click);
            // 
            // btnmilktea
            // 
            this.btnmilktea.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnmilktea.Location = new System.Drawing.Point(80, 42);
            this.btnmilktea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnmilktea.Name = "btnmilktea";
            this.btnmilktea.Size = new System.Drawing.Size(72, 94);
            this.btnmilktea.TabIndex = 1;
            this.btnmilktea.Text = "鮮奶茶\nTea\nNT55";
            this.btnmilktea.UseVisualStyleBackColor = true;
            this.btnmilktea.Click += new System.EventHandler(this.btnmilktea_Click);
            // 
            // btncoffee
            // 
            this.btncoffee.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btncoffee.Location = new System.Drawing.Point(4, 42);
            this.btncoffee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncoffee.Name = "btncoffee";
            this.btncoffee.Size = new System.Drawing.Size(72, 94);
            this.btncoffee.TabIndex = 0;
            this.btncoffee.Text = "咖啡\nCoffee\nNT95";
            this.btncoffee.UseVisualStyleBackColor = true;
            this.btncoffee.Click += new System.EventHandler(this.btncoffee_Click);
            // 
            // grplist
            // 
            this.grplist.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grplist.Controls.Add(this.txtlist);
            this.grplist.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grplist.Location = new System.Drawing.Point(424, 49);
            this.grplist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grplist.Name = "grplist";
            this.grplist.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grplist.Size = new System.Drawing.Size(242, 261);
            this.grplist.TabIndex = 1;
            this.grplist.TabStop = false;
            this.grplist.Text = "清單OrderList";
            // 
            // txtlist
            // 
            this.txtlist.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtlist.Location = new System.Drawing.Point(4, 52);
            this.txtlist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtlist.Multiline = true;
            this.txtlist.Name = "txtlist";
            this.txtlist.Size = new System.Drawing.Size(234, 186);
            this.txtlist.TabIndex = 0;
            this.txtlist.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpboxpay
            // 
            this.grpboxpay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grpboxpay.Controls.Add(this.labcredit);
            this.grpboxpay.Controls.Add(this.btncredit);
            this.grpboxpay.Controls.Add(this.btncash);
            this.grpboxpay.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpboxpay.Location = new System.Drawing.Point(171, 49);
            this.grpboxpay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpboxpay.Name = "grpboxpay";
            this.grpboxpay.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpboxpay.Size = new System.Drawing.Size(249, 151);
            this.grpboxpay.TabIndex = 1;
            this.grpboxpay.TabStop = false;
            this.grpboxpay.Text = "付款方式Method";
            // 
            // labcredit
            // 
            this.labcredit.AutoSize = true;
            this.labcredit.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labcredit.Location = new System.Drawing.Point(180, 35);
            this.labcredit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labcredit.Name = "labcredit";
            this.labcredit.Size = new System.Drawing.Size(50, 36);
            this.labcredit.TabIndex = 3;
            this.labcredit.Text = "信用卡\n9折";
            // 
            // btncredit
            // 
            this.btncredit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btncredit.Location = new System.Drawing.Point(168, 73);
            this.btncredit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncredit.Name = "btncredit";
            this.btncredit.Size = new System.Drawing.Size(76, 30);
            this.btncredit.TabIndex = 1;
            this.btncredit.Text = "信用卡";
            this.btncredit.UseVisualStyleBackColor = true;
            this.btncredit.Click += new System.EventHandler(this.btncredit_Click);
            // 
            // btncash
            // 
            this.btncash.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btncash.Location = new System.Drawing.Point(4, 73);
            this.btncash.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncash.Name = "btncash";
            this.btncash.Size = new System.Drawing.Size(76, 30);
            this.btncash.TabIndex = 0;
            this.btncash.Text = "現金付款";
            this.btncash.UseVisualStyleBackColor = true;
            this.btncash.Click += new System.EventHandler(this.btncash_Click);
            // 
            // grptotal
            // 
            this.grptotal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grptotal.Controls.Add(this.txttotalprice);
            this.grptotal.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grptotal.Location = new System.Drawing.Point(171, 205);
            this.grptotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grptotal.Name = "grptotal";
            this.grptotal.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grptotal.Size = new System.Drawing.Size(249, 105);
            this.grptotal.TabIndex = 2;
            this.grptotal.TabStop = false;
            this.grptotal.Text = "總金額Price";
            // 
            // txttotalprice
            // 
            this.txttotalprice.BackColor = System.Drawing.SystemColors.MenuText;
            this.txttotalprice.ForeColor = System.Drawing.SystemColors.Window;
            this.txttotalprice.Location = new System.Drawing.Point(40, 47);
            this.txttotalprice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttotalprice.Name = "txttotalprice";
            this.txttotalprice.Size = new System.Drawing.Size(154, 36);
            this.txttotalprice.TabIndex = 0;
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnclear.Location = new System.Drawing.Point(507, 319);
            this.btnclear.Margin = new System.Windows.Forms.Padding(2);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(105, 30);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "清除清單";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Frm_pos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(666, 360);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.grptotal);
            this.Controls.Add(this.grpboxpay);
            this.Controls.Add(this.grplist);
            this.Controls.Add(this.grpboxmenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_pos";
            this.Text = "Pos機";
            this.grpboxmenu.ResumeLayout(false);
            this.grpboxmenu.PerformLayout();
            this.grplist.ResumeLayout(false);
            this.grplist.PerformLayout();
            this.grpboxpay.ResumeLayout(false);
            this.grpboxpay.PerformLayout();
            this.grptotal.ResumeLayout(false);
            this.grptotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxmenu;
        private System.Windows.Forms.GroupBox grplist;
        private System.Windows.Forms.GroupBox grpboxpay;
        private System.Windows.Forms.GroupBox grptotal;
        private System.Windows.Forms.TextBox txttotalprice;
        private System.Windows.Forms.Button btncoffee;
        private System.Windows.Forms.Button btnbeer;
        private System.Windows.Forms.Button btncola;
        private System.Windows.Forms.Button btnmilktea;
        private System.Windows.Forms.Label labcredit;
        private System.Windows.Forms.Button btncredit;
        private System.Windows.Forms.Button btncash;
        private System.Windows.Forms.TextBox txtlist;
        private System.Windows.Forms.Button btnclear;
    }
}