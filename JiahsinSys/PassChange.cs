using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JiahsinSys
{
    public partial class PassChange : Form
    {
        public PassChange()
        {
            InitializeComponent();
            tb_pwdId.Text = MdDefine.SeasionUser;
        }

        private void bt_pwdOK_Click(object sender, EventArgs e)
        { 
            MdPubFunc funcs= new MdPubFunc();
            string pass = funcs.EnCrypt(tb_pwdOld.Text);
            string query = "select * from sUser where sUserCode = '" + tb_pwdId.Text + "' and sUserPass = '" + pass + "'";
            if (funcs.ExcScalar(query, MdDefine.strcon) == null)
            {
                lbl_mess.Text = "Mật khẩu không đúng !!!";
            }
            else
            {

                if (tb_pwdNew.Text != tb_pwdNewR.Text )
                {
                    lbl_mess.Text = "Mật khẩu mới ko giống nhau !!!";
                }
                else
                {
                    pass = funcs.EnCrypt(tb_pwdNew.Text.ToString());
                    query = "Update sUser Set sUserPass= '" + pass + "' Where sUserCode='" + tb_pwdId.Text + "'";

                    if (funcs.ExecuteQuery(query, MdDefine.strcon) > 0)
                    {
                        MessageBox.Show("Bạn đã thay đổi thành công !!!");
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi trong quá trình thay đổi!!!");
                    }
                }
            }
        }

        private void bt_pwdNO_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
