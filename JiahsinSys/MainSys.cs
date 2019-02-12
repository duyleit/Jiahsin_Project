using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JiahsinSys;
using System.Data.SqlClient;
using System.IO;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using FoodOrder;
using ConnectDatatoMysql;
using System.Threading;
using MySql.Data.MySqlClient;
using FingerPrint;


namespace JiahsinSys
{
    public partial class MainSys : Form
    {
        private string name;
        public MainSys()
        {
            InitializeComponent();
         }

        public MainSys(string name):this()
        {
           this.name = name;
           string qry = "select * from susermod where usercode ='" +this.name+"'";
           MdPubFunc funcs = new MdPubFunc();
           DataSet ds = new DataSet();
           ds = funcs.getDataSet(qry,MdDefine.strcon);
             for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ToolStripMenuItem AmenuItem = new ToolStripMenuItem();
                AmenuItem.Name = ds.Tables[0].Rows[i][1].ToString();
                AmenuItem.Text = ds.Tables[0].Rows[i][1].ToString();
                MenuStrip.Items.Add(AmenuItem);
                addSubMenu(ds.Tables[0].Rows[i][1].ToString(), AmenuItem);
            }

             // Language Menu
             ToolStripMenuItem LangpmenuItem = new ToolStripMenuItem();
             LangpmenuItem.Name = "Language";
             LangpmenuItem.Text = "Language";
             MenuStrip.Items.Add(LangpmenuItem);

             string qry1 = "select sLangName from sLang";
             ds = funcs.getDataSet(qry1, MdDefine.strcon);
             for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
             {
                 ToolStripMenuItem AmenuItem = new ToolStripMenuItem();
                 AmenuItem.Name = ds.Tables[0].Rows[i][0].ToString();
                 AmenuItem.Text = ds.Tables[0].Rows[i][0].ToString();
                 AmenuItem.Click += ShowSubForm;
                 LangpmenuItem.DropDownItems.Add(AmenuItem);
             }


            // Help Menu
             ToolStripMenuItem HelpmenuItem = new ToolStripMenuItem();
             HelpmenuItem.Name = "Help";
             HelpmenuItem.Text = "Help";
             MenuStrip.Items.Add(HelpmenuItem);

             ToolStripMenuItem childpmenuItem = new ToolStripMenuItem();
          // string FilePath =  @"Images\infor.bmp";
             childpmenuItem.Name = "About";
             childpmenuItem.Text = "About";
             childpmenuItem.ShortcutKeys = Keys.Control | Keys.I;
          // childpmenuItem.Image = Image.FromFile(FilePath);
             childpmenuItem.Click += ShowSubForm;
             HelpmenuItem.DropDownItems.Add(childpmenuItem);
            
            

        }

        private void MainSys_Load(object sender, EventArgs e)
        {
            MdDefine.SeasionUser = name;
            StatusUser.Text ="Người dùng: "+ name;
            StatusDate.Text ="Ngày: " + DateTime.Now.ToString("yyyy/MM/dd");
            toolStripStatusLabel.Text = "Chương trình đang hoạt động ...";
            toolStripStatusServer.Text = "  Area APServer [" + MdDefine.server + "]";
        }
        private void addSubMenu(string modname, ToolStripMenuItem PMenu)
        {
            string qry = "select CONCAT_WS (' ',sFormId ,sFormName) as info from sForm where sFormsModuleId = '" + modname + "'";
            //string qry = "select * from sform where moduleid = '" + modname + "'";
            MdPubFunc funcs = new MdPubFunc();
            //MySqlDataReader reader;
            DataSet ds = new DataSet();
            ds = funcs.getDataSet(qry,MdDefine.strcon);
            for (int i = 0; i < ds.Tables[0].Rows.Count;i++ )
            {
                ToolStripMenuItem AmenuItem = new ToolStripMenuItem();
                AmenuItem.Name = ds.Tables[0].Rows[i][0].ToString();
                AmenuItem.Text = ds.Tables[0].Rows[i][0].ToString();
                AmenuItem.Click += ShowSubForm;
                PMenu.DropDownItems.Add(AmenuItem);
            }
                //if (reader.HasRows)
                //{
                //    try
                //    {
                //        while (reader.Read())
                //        {
                //            ToolStripMenuItem AmenuItem = new ToolStripMenuItem();
                //            AmenuItem.Name = reader["formid"].ToString();
                //            AmenuItem.Text = reader["formid"].ToString();
                //            AmenuItem.Click += ShowSubForm;
                //            PMenu.DropDownItems.Add(AmenuItem);
                //        }
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show(ex.ToString());
                //        Close();
                //    }
                //    finally
                //    {
                //        reader.Close();
                      
                //    }
                //}
            }
        public void ShowSubForm(object sender, EventArgs e)
        {
            string AFormName = Microsoft.VisualBasic.Strings.Left(sender.ToString(),5).Trim();
            MdPubFunc funcs = new MdPubFunc();
            System.Reflection.Assembly tempAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            string str = tempAssembly.GetName().Name + "." + AFormName;

            Form frm;
            try
            {
                frm = (Form)tempAssembly.CreateInstance(str);
            }
            catch (Exception)
            {
                
                throw;
            }


            switch (AFormName)
            {
                case "DCM01":
                    if (funcs.CheckAuth(AFormName, name) != null)
                    {
                       FoodOrder_Frm DCM01_form = new FoodOrder_Frm();
                       DCM01_form.MdiParent = this;
                       DCM01_form.WindowState = FormWindowState.Maximized;
                       DCM01_form.Show();


            //            obVal = FindObject(frm, "Panelsys")
            //If Not obVal Is Nothing Then
            //    obVal.Parent = SysPage.SelectedTab  '本程序顯示在主窗体的mainpage中 2008-10-01 （Panelsys是在最上面Fill）hyt
            //    iCurIndex = SysPage.SelectedIndex
            //    LangDeal(AFormName, SysPage.TabPages.Item(iCurIndex))
            //End If
                     }
                    else
                    {
                        MessageBox.Show("Bạn không có quyền đề vào chương trình !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    break;
                case "USR01":
                    if (funcs.CheckAuth(AFormName, name) != null)
                    {
                        QuanliUser ql_form = new QuanliUser(name);
                        ql_form.MdiParent = this;
                        ql_form.WindowState = FormWindowState.Maximized;
                        ql_form.Show();
                     
                    }
                    else
                    {
                        MessageBox.Show("Bạn không có quyền đề vào chương trình !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    break;

                case "USR03":
                    if (funcs.CheckAuth(AFormName, name) != null)
                    {
                        RegisterFrm re = new RegisterFrm();
                       // re.MdiParent = this;
                       // re.WindowState = FormWindowState.Maximized;
                        re.Show();
                    }
                    else
                    {
                        MessageBox.Show("Bạn không có quyền đề vào chương trình !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    break;
                case "FGP01":
                    if (funcs.CheckAuth(AFormName, name) != null)
                    {
                        FingerPrint.FingerPrint fg = new FingerPrint.FingerPrint();
                         fg.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Bạn không có quyền đề vào chương trình !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    break;

                case "About":
                    About about = new About();
                    about.Show();
                    break;
                default:
                    MessageBox.Show("Chưa định nghĩa chương trình !!!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    break;



            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PassChange chagepwd = new PassChange();
            chagepwd.ShowDialog();
        }

        private void MainSys_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult diag = MessageBox.Show("Do you want to exit", "Warming", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (diag == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Exit();
             }
        }

              
     }
}
