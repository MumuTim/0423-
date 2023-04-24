namespace 作業
{
    partial class Frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_login));
            this.lab_account = new System.Windows.Forms.Label();
            this.lab_password = new System.Windows.Forms.Label();
            this.txt_account = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_account
            // 
            this.lab_account.AutoSize = true;
            this.lab_account.BackColor = System.Drawing.Color.Transparent;
            this.lab_account.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_account.ForeColor = System.Drawing.SystemColors.Window;
            this.lab_account.Location = new System.Drawing.Point(16, 144);
            this.lab_account.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_account.Name = "lab_account";
            this.lab_account.Size = new System.Drawing.Size(77, 38);
            this.lab_account.TabIndex = 0;
            this.lab_account.Text = "帳號";
            // 
            // lab_password
            // 
            this.lab_password.AutoSize = true;
            this.lab_password.BackColor = System.Drawing.Color.Transparent;
            this.lab_password.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_password.ForeColor = System.Drawing.SystemColors.Window;
            this.lab_password.Location = new System.Drawing.Point(16, 201);
            this.lab_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_password.Name = "lab_password";
            this.lab_password.Size = new System.Drawing.Size(77, 38);
            this.lab_password.TabIndex = 1;
            this.lab_password.Text = "密碼";
            // 
            // txt_account
            // 
            this.txt_account.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_account.Location = new System.Drawing.Point(107, 146);
            this.txt_account.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_account.Name = "txt_account";
            this.txt_account.Size = new System.Drawing.Size(159, 34);
            this.txt_account.TabIndex = 2;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_password.Location = new System.Drawing.Point(107, 204);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(159, 34);
            this.txt_password.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_login.Location = new System.Drawing.Point(629, 201);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(100, 39);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "登入";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(779, 326);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_account);
            this.Controls.Add(this.lab_password);
            this.Controls.Add(this.lab_account);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_login";
            this.Text = "登入";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_account;
        private System.Windows.Forms.Label lab_password;
        private System.Windows.Forms.TextBox txt_account;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_login;
    }
}