using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace JiahsinSys
{
   public class MdPubFunc
    {
       
       public string EnCrypt(string text)
       {
           byte[] temp = ASCIIEncoding.ASCII.GetBytes(text);
           byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
           string hasPass = "";
           foreach (byte item in hasData)
           {
               hasPass += item;
           }
           return hasPass;
       }
       public int ExecuteQuery(string query,string constr)
       {
           int result;
            MySqlConnection con = new MySqlConnection(constr);
            MySqlCommand cmd = new MySqlCommand(query, con);
            try
            {
                con.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception )
            {
                throw;
            }
            finally
            {
                con.Close();
            }
             return result;
       }
       public object ExcScalar(string query, string constr)
       {
           object result;
           MySqlConnection con = new MySqlConnection(constr);
           MySqlCommand cmd = new MySqlCommand(query, con);
           try
           {
               con.Open();
               result = cmd.ExecuteScalar();
           }
           catch (Exception)
           {
               throw;
           }
           finally
           {
               con.Close();
           }
           return result;
       }

       public object CheckAuth(string formname, string name)
       {
          string qry = "select * from suserform where formid='" + formname + "' and usercode ='" + name + "' and form_inq = 1";
          object result = ExcScalar(qry,MdDefine.strcon);
           return result;
       }
       public DataSet getDataSet(string query, string constr)
       {
           DataSet ds = new DataSet();
           MySqlDataAdapter da = new MySqlDataAdapter(query, constr);
           da.Fill(ds);
           return ds;
       }
       public MySqlDataReader getDataReader(string query, string constr)  // It's not work
       {
        //   object dr;
           MySqlDataReader dr1;
           MySqlConnection con = new MySqlConnection(constr);
           MySqlCommand cmd = new MySqlCommand(query,con);
           try
           {
               con.Open();
         //      dr = cmd.ExecuteScalar();
               dr1 = cmd.ExecuteReader();
           }
           catch (Exception)
           {

               throw;
           }
           finally
           {
              con.Close();
            }
           return  dr1;
       }
    }
}
