namespace 作業
{
    partial class Frm_paint
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.picbox1 = new System.Windows.Forms.PictureBox();
            this.btncolor = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.Color = System.Drawing.Color.White;
            // 
            // picbox1
            // 
            this.picbox1.Location = new System.Drawing.Point(0, -1);
            this.picbox1.Name = "picbox1";
            this.picbox1.Size = new System.Drawing.Size(1068, 564);
            this.picbox1.TabIndex = 0;
            this.picbox1.TabStop = false;
            this.picbox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picbox1_MouseDown);
            this.picbox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picbox1_MouseMove);
            // 
            // btncolor
            // 
            this.btncolor.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btncolor.Location = new System.Drawing.Point(907, 47);
            this.btncolor.Name = "btncolor";
            this.btncolor.Size = new System.Drawing.Size(113, 58);
            this.btncolor.TabIndex = 1;
            this.btncolor.Text = "顏色";
            this.btncolor.UseVisualStyleBackColor = true;
            this.btncolor.Click += new System.EventHandler(this.btncolor_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(922, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 25);
            this.textBox1.TabIndex = 2;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(934, 234);
            this.trackBar1.Maximum = 8;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(56, 205);
            this.trackBar1.TabIndex = 3;
            // 
            // Frm_paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btncolor);
            this.Controls.Add(this.picbox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_paint";
            this.Text = "小畫家";
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox picbox1;
        private System.Windows.Forms.Button btncolor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}