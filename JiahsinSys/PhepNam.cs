using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JiahsinSys
{
    public partial class PhepNam : Form
    {
        private const string FORM_CODE = "PNZ01";
        private bool[] priArr = { };
        private string G_UserID;
        public PhepNam()
        {
            InitializeComponent();
        }
        public PhepNam(string name):this()
        {
            this.G_UserID = name;
        }
        private void SetBt()
        {
            bt_add.Enabled = false;
            bt_edit.Enabled = false;
            bt_del.Enabled = false;
            bt_print.Enabled = false;
            bt_save.Enabled = false;
        }
        private bool[] getPrvArr(string UserId, string FormId)
        {
            bool[] ArrPri = { false, false, false, false };

            string con = "Data Source=.\\sqlexpress;Initial Catalog=User_Permission;Integrated Security=True";
            string qry = "select form_add,form_upd,form_del,form_prt from user_form where UserId='" + UserId + "' and Form_Id='" + FormId + "'";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            da.Fill(ds);

            string[] arrFieldName = { "form_add", "form_upd", "form_del", "form_prt" };
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < arrFieldName.Length; i++)
                {
                    ArrPri[i] = Convert.ToBoolean(ds.Tables[0].Rows[0][i]);
                }
            }

            return ArrPri;
        }
        private void PhepNam_Load(object sender, EventArgs e)
        {
            SetBt();
            priArr = getPrvArr(G_UserID, FORM_CODE);
            bt_add.Enabled = priArr[0];
            bt_edit.Enabled = priArr[1];
            bt_del.Enabled = priArr[2];
            bt_print.Enabled = priArr[3];
            bt_save.Enabled = priArr[0] || priArr[1];
        }
    }
}
