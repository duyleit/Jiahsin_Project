namespace JiahsinSys
{
    partial class LoginFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_name = new System.Windows.Forms.TextBox();
            this.txtb_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_message = new System.Windows.Forms.Label();
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản:";
            // 
            // txtb_name
            // 
            this.txtb_name.Location = new System.Drawing.Point(155, 29);
            this.txtb_name.Name = "txtb_name";
            this.txtb_name.Size = new System.Drawing.Size(143, 20);
            this.txtb_name.TabIndex = 1;
            this.txtb_name.Text = "I13042";
            // 
            // txtb_pass
            // 
            this.txtb_pass.Location = new System.Drawing.Point(155, 66);
            this.txtb_pass.Name = "txtb_pass";
            this.txtb_pass.Size = new System.Drawing.Size(143, 20);
            this.txtb_pass.TabIndex = 3;
            this.txtb_pass.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu: ";
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.ForeColor = System.Drawing.Color.Red;
            this.lbl_message.Location = new System.Drawing.Point(91, 91);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(0, 13);
            this.lbl_message.TabIndex = 5;
            // 
            // bt_exit
            // 
            this.bt_exit.Image = global::JiahsinSys.Properties.Resources.thoat;
            this.bt_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_exit.Location = new System.Drawing.Point(207, 114);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(91, 36);
            this.bt_exit.TabIndex = 6;
            this.bt_exit.Text = "     Đăng Xuất";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_login
            // 
            this.bt_login.Image = global::JiahsinSys.Properties.Resources.login;
            this.bt_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_login.Location = new System.Drawing.Point(94, 114);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(91, 36);
            this.bt_login.TabIndex = 4;
            this.bt_login.Text = "       Đăng Nhập";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 92);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(344, 171);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.txtb_pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtb_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_name;
        private System.Windows.Forms.TextBox txtb_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}