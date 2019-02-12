using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JiahsinSys
{
    public class MdDefine
    {
        public static string server ="192.168.3.202";
        public static string database = "desktopAppShm";
        public static string user = "desktopAppShm";
        public static string password = "123456";
        public static string port = "3306";
        public static string sslM = "none";
        public static string SeasionUser = "";
        // string strcon = "Data Source=.\\sqlexpress;Initial Catalog=User_Permission;Integrated Security=True";
        public static string strcon = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);
        public static MdDefine strcon1;
    }
}
