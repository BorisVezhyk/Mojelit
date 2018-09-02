using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace AppLogin
{
    public class ConnectDB
    {
        //Чуть позже переделать подключение через конфиг пример трол ст.765-766
        private static SqlConnection conn = new SqlConnection(@"Data Source=VOZIK-PC;Initial Catalog=DB_MogJel;Integrated Security=True");

        public static SqlConnection Connect
        {
            get { return conn; }
        }

        static string con = @"Data Source=VOZIK-PC;Initial Catalog=DB_MogJel;Integrated Security=True";

        public static  SqlConnection GetConnectDB()
        {
            return new SqlConnection(con);
        }

    }
}
