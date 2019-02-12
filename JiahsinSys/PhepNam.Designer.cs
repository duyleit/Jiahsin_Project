namespace JiahsinSys
{
    partial class PhepNam
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_del = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_inq = new System.Windows.Forms.Button();
            this.bt_print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Phép năm: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1136, 469);
            this.dataGridView1.TabIndex = 7;
            // 
            // bt_save
            // 
            this.bt_save.Image = global::JiahsinSys.Properties.Resources.save;
            this.bt_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_save.Location = new System.Drawing.Point(1032, 40);
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
            this.bt_del.Location = new System.Drawing.Point(936, 40);
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
            this.bt_edit.Location = new System.Drawing.Point(837, 40);
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
            this.bt_add.Location = new System.Drawing.Point(738, 40);
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
            this.bt_inq.Location = new System.Drawing.Point(540, 40);
            this.bt_inq.Name = "bt_inq";
            this.bt_inq.Size = new System.Drawing.Size(93, 35);
            this.bt_inq.TabIndex = 22;
            this.bt_inq.Text = "Truy vấn";
            this.bt_inq.UseVisualStyleBackColor = true;
            // 
            // bt_print
            // 
            this.bt_print.Image = global::JiahsinSys.Properties.Resources.print;
            this.bt_print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_print.Location = new System.Drawing.Point(639, 40);
            this.bt_print.Name = "bt_print";
            this.bt_print.Size = new System.Drawing.Size(93, 35);
            this.bt_print.TabIndex = 28;
            this.bt_print.Text = "In";
            this.bt_print.UseVisualStyleBackColor = true;
            // 
            // PhepNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 560);
            this.Controls.Add(this.bt_print);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_del);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.bt_inq);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PhepNam";
            this.Text = "Quản ly phép năm";
            this.Load += new System.EventHandler(this.PhepNam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_del;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_inq;
        private System.Windows.Forms.Button bt_print;

    }
}