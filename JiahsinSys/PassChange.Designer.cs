namespace JiahsinSys
{
    partial class PassChange
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_pwdId = new System.Windows.Forms.TextBox();
            this.tb_pwdOld = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_pwdNew = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_pwdNewR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_pwdOK = new System.Windows.Forms.Button();
            this.bt_pwdNO = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_mess = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username: ";
            // 
            // tb_pwdId
            // 
            this.tb_pwdId.Enabled = false;
            this.tb_pwdId.Location = new System.Drawing.Point(119, 38);
            this.tb_pwdId.Name = "tb_pwdId";
            this.tb_pwdId.Size = new System.Drawing.Size(198, 20);
            this.tb_pwdId.TabIndex = 1;
            // 
            // tb_pwdOld
            // 
            this.tb_pwdOld.Location = new System.Drawing.Point(119, 77);
            this.tb_pwdOld.Name = "tb_pwdOld";
            this.tb_pwdOld.PasswordChar = '*';
            this.tb_pwdOld.Size = new System.Drawing.Size(198, 20);
            this.tb_pwdOld.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Old Pass:";
            // 
            // tb_pwdNew
            // 
            this.tb_pwdNew.Location = new System.Drawing.Point(119, 120);
            this.tb_pwdNew.Name = "tb_pwdNew";
            this.tb_pwdNew.PasswordChar = '*';
            this.tb_pwdNew.Size = new System.Drawing.Size(198, 20);
            this.tb_pwdNew.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "New Pass :";
            // 
            // tb_pwdNewR
            // 
            this.tb_pwdNewR.Location = new System.Drawing.Point(119, 165);
            this.tb_pwdNewR.Name = "tb_pwdNewR";
            this.tb_pwdNewR.PasswordChar = '*';
            this.tb_pwdNewR.Size = new System.Drawing.Size(198, 20);
            this.tb_pwdNewR.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Re New Pass:";
            // 
            // bt_pwdOK
            // 
            this.bt_pwdOK.Location = new System.Drawing.Point(101, 256);
            this.bt_pwdOK.Name = "bt_pwdOK";
            this.bt_pwdOK.Size = new System.Drawing.Size(79, 32);
            this.bt_pwdOK.TabIndex = 8;
            this.bt_pwdOK.Text = "Accept";
            this.bt_pwdOK.UseVisualStyleBackColor = true;
            this.bt_pwdOK.Click += new System.EventHandler(this.bt_pwdOK_Click);
            // 
            // bt_pwdNO
            // 
            this.bt_pwdNO.Location = new System.Drawing.Point(207, 256);
            this.bt_pwdNO.Name = "bt_pwdNO";
            this.bt_pwdNO.Size = new System.Drawing.Size(75, 32);
            this.bt_pwdNO.TabIndex = 9;
            this.bt_pwdNO.Text = "Cancel";
            this.bt_pwdNO.UseVisualStyleBackColor = true;
            this.bt_pwdNO.Click += new System.EventHandler(this.bt_pwdNO_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_mess);
            this.groupBox1.Location = new System.Drawing.Point(1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 220);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Password";
            // 
            // lbl_mess
            // 
            this.lbl_mess.AutoSize = true;
            this.lbl_mess.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mess.ForeColor = System.Drawing.Color.Red;
            this.lbl_mess.Location = new System.Drawing.Point(118, 201);
            this.lbl_mess.Name = "lbl_mess";
            this.lbl_mess.Size = new System.Drawing.Size(0, 16);
            this.lbl_mess.TabIndex = 0;
            // 
            // PassChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 300);
            this.Controls.Add(this.bt_pwdNO);
            this.Controls.Add(this.bt_pwdOK);
            this.Controls.Add(this.tb_pwdNewR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_pwdNew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_pwdOld);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_pwdId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "PassChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassChange";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_pwdId;
        private System.Windows.Forms.TextBox tb_pwdOld;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_pwdNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_pwdNewR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_pwdOK;
        private System.Windows.Forms.Button bt_pwdNO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_mess;
    }
}