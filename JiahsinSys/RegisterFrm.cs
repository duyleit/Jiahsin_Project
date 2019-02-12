using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using JiahsinSys;

namespace JiahsinSys
{
    public partial class RegisterFrm : Form
    {
      public RegisterFrm()
        {
            InitializeComponent();
        }

        private void bt_register_Click(object sender, EventArgs e)
        {
           // string name =  tb_NameRe.Text.ToString();
            string hasPass = "";
            int status = ckb_status.Checked ? 1 : 0;
            MdPubFunc funcs = new MdPubFunc();
            hasPass=funcs.EnCrypt(tb_PassRe.Text.ToString());
            string qry = "Insert into suser(susercode,suserpass,suserfullname,susercom_code,suserrole_code,suserdept_code,suserposi_code,suseremail,suserphone_extend,suserstatus) Values( '" + tb_id.Text + "','" + hasPass + "','" + tb_NameRe.Text + "','" + tb_company.Text + "','" + tb_role.Text + "','" + tb_dept.Text + "','" + tb_posi.Text + "','" + tb_email.Text + "','" + tb_phone.Text + "','" + status + "')";
           if (funcs.ExecuteQuery(qry, MdDefine.strcon) > 0)
            {
                MessageBox.Show("Bạn đã đăng kí thành công !!!");
            }
            else
            {
                MessageBox.Show("Có lỗi trong quá trình đăng kí !!!");
            }
         }
    }
}
