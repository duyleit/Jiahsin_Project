namespace JiahsinSys
{
    partial class QuanliUser
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_print = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_del = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_inq = new System.Windows.Forms.Button();
            this.Panelsys = new System.Windows.Forms.Panel();
            this.gridview_user = new System.Windows.Forms.DataGridView();
            this.Paneltop = new System.Windows.Forms.Panel();
            this.panel_center = new System.Windows.Forms.Panel();
            this.Panelsys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_user)).BeginInit();
            this.Paneltop.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Người dùng:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 6;
            // 
            // bt_print
            // 
            this.bt_print.Image = global::JiahsinSys.Properties.Resources.print;
            this.bt_print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_print.Location = new System.Drawing.Point(612, 35);
            this.bt_print.Name = "bt_print";
            this.bt_print.Size = new System.Drawing.Size(93, 35);
            this.bt_print.TabIndex = 27;
            this.bt_print.Text = "In";
            this.bt_print.UseVisualStyleBackColor = true;
            // 
            // bt_save
            // 
            this.bt_save.Image = global::JiahsinSys.Properties.Resources.save;
            this.bt_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_save.Location = new System.Drawing.Point(1005, 35);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(93, 35);
            this.bt_save.TabIndex = 26;
            this.bt_save.Text = "Lưu";
            this.bt_save.UseVisualStyleBackColor = true;
            // 
            // bt_del
            // 
            this.bt_del.Image = global::JiahsinSys.Properties.Resources.delete;
            this.bt_del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_del.Location = new System.Drawing.Point(909, 35);
            this.bt_del.Name = "bt_del";
            this.bt_del.Size = new System.Drawing.Size(93, 35);
            this.bt_del.TabIndex = 25;
            this.bt_del.Text = "Xóa";
            this.bt_del.UseVisualStyleBackColor = true;
            // 
            // bt_edit
            // 
            this.bt_edit.Image = global::JiahsinSys.Properties.Resources.edit;
            this.bt_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_edit.Location = new System.Drawing.Point(810, 35);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(93, 35);
            this.bt_edit.TabIndex = 24;
            this.bt_edit.Text = "Sửa";
            this.bt_edit.UseVisualStyleBackColor = true;
            // 
            // bt_add
            // 
            this.bt_add.Image = global::JiahsinSys.Properties.Resources.Add;
            this.bt_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_add.Location = new System.Drawing.Point(711, 35);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(93, 35);
            this.bt_add.TabIndex = 23;
            this.bt_add.Text = "Thêm";
            this.bt_add.UseVisualStyleBackColor = true;
            // 
            // bt_inq
            // 
            this.bt_inq.Image = global::JiahsinSys.Properties.Resources.search;
            this.bt_inq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_inq.Location = new System.Drawing.Point(513, 35);
            this.bt_inq.Name = "bt_inq";
            this.bt_inq.Size = new System.Drawing.Size(93, 35);
            this.bt_inq.TabIndex = 22;
            this.bt_inq.Text = "Truy vấn";
            this.bt_inq.UseVisualStyleBackColor = true;
            this.bt_inq.Click += new System.EventHandler(this.bt_inq_Click);
            // 
            // Panelsys
            // 
            this.Panelsys.Controls.Add(this.gridview_user);
            this.Panelsys.Controls.Add(this.Paneltop);
            this.Panelsys.Controls.Add(this.panel_center);
            this.Panelsys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panelsys.Location = new System.Drawing.Point(0, 0);
            this.Panelsys.Name = "Panelsys";
            this.Panelsys.Size = new System.Drawing.Size(1100, 594);
            this.Panelsys.TabIndex = 28;
            // 
            // gridview_user
            // 
            this.gridview_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridview_user.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridview_user.Location = new System.Drawing.Point(0, 78);
            this.gridview_user.Name = "gridview_user";
            this.gridview_user.Size = new System.Drawing.Size(1100, 516);
            this.gridview_user.TabIndex = 0;
            // 
            // Paneltop
            // 
            this.Paneltop.Controls.Add(this.label1);
            this.Paneltop.Controls.Add(this.textBox1);
            this.Paneltop.Controls.Add(this.bt_print);
            this.Paneltop.Controls.Add(this.bt_inq);
            this.Paneltop.Controls.Add(this.bt_save);
            this.Paneltop.Controls.Add(this.bt_edit);
            this.Paneltop.Controls.Add(this.bt_add);
            this.Paneltop.Controls.Add(this.bt_del);
            this.Paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.Paneltop.Location = new System.Drawing.Point(0, 0);
            this.Paneltop.Name = "Paneltop";
            this.Paneltop.Size = new System.Drawing.Size(1100, 78);
            this.Paneltop.TabIndex = 28;
            // 
            // panel_center
            // 
            this.panel_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_center.Location = new System.Drawing.Point(0, 0);
            this.panel_center.Name = "panel_center";
            this.panel_center.Size = new System.Drawing.Size(1100, 594);
            this.panel_center.TabIndex = 29;
            // 
            // QuanliUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 594);
            this.Controls.Add(this.Panelsys);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "QuanliUser";
            this.Text = "Quản lý người dùng";
            this.Load += new System.EventHandler(this.QuanliUser_Load);
            this.Panelsys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridview_user)).EndInit();
            this.Paneltop.ResumeLayout(false);
            this.Paneltop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_del;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_inq;
        private System.Windows.Forms.Button bt_print;
        private System.Windows.Forms.Panel Panelsys;
        private System.Windows.Forms.Panel Paneltop;
        private System.Windows.Forms.DataGridView gridview_user;
        private System.Windows.Forms.Panel panel_center;

    }
}