using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JiahsinSys;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Security.Cryptography;

namespace JiahsinSys
{
    public partial class LoginFrm : Form
    {
       public LoginFrm()
        {
            InitializeComponent();
        }   

        private void bt_login_Click(object sender, EventArgs e)
        {
            string name = txtb_name.Text.ToString();
            string hasPass = "";
            MdPubFunc funcs = new MdPubFunc();
            hasPass = funcs.EnCrypt(txtb_pass.Text.ToString());
            string qry = "select * from sUser where susercode='" + name + "' and suserpass='" + hasPass + "'";
            object result = funcs.ExcScalar(qry,MdDefine.strcon);
            if (result != null)
            {
                MainSys main = new MainSys(txtb_name.Text);
                main.ShowDialog();
                this.Close();
            }
            else
            {
                lbl_message.Text = "Username or Password incorrect";
                txtb_name.Text = "";
                txtb_pass.Text = "";
                txtb_name.Focus();
            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
