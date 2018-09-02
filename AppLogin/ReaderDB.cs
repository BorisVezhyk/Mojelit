using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppLogin
{
     /*class ReaderDB
    {
        /// <summary>
        /// Метод для получения данных из БД и вывод этой информации в DataGritView
        /// </summary>
        /// <param name="gridView"></param>
        /// <param name="query"></param>
        public static void LoadDatainDataGV(System.Windows.Forms.DataGridView gridView, string query)
        {
            using(SqlConnection con = ConnectDB.GetConnectDB())
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = query;
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string[] tempData = new string[reader.FieldCount];
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            tempData[i] = reader[i].ToString();
                        }
                        gridView.Rows.Add(tempData);


                    }
                }
            }
        }

        /// <summary>
        /// Св-во получает аббреввиатуру активного пользователя 
        /// </summary>
        private static string userDep;
        public static string UserDep
        {
            get { return userDep; }
            set
            {
                if (userDep==""||userDep==null)
                {
                    userDep = value;
                }
                
            }
        }

        /// <summary>
        /// Св-во получает ID активного пользователя
        /// </summary>
        private static int userid;
        public static int UserId
        {
            get { return userid; }
            set
            {
                if (userid == 0)
                {
                    userid = value;
                }

            }
        }

        /// <summary>
        /// Метод получает аббревиатуру участка активного пользователя 
        /// </summary>
        /// <param name="login"></param>
        public static void GetUserDepartament(string login)
        {
            using(SqlConnection con = ConnectDB.GetConnectDB())
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                string queryGetDep = "select Abbreviation from Employees join Login_pass on Employees.Id_Employee=Login_pass.Id_Employee where Login_pass.Login=@login";
                cmd.CommandText = queryGetDep;
                cmd.Parameters.AddWithValue("@login", login);

                UserDep = (string)cmd.ExecuteScalar();
            }
        }

        /// <summary>
        /// Метод получает ID активного пользователя 
        /// </summary>
        /// <param name="login"></param>
        public static void GetUserID(string login)
        {
            using (SqlConnection con = ConnectDB.GetConnectDB())
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                string queryGetDep = "select Employees.Id_Employee from Employees join Login_pass on Employees.Id_Employee=Login_pass.Id_Employee where Login_pass.Login= @login";
                cmd.CommandText = queryGetDep;
                cmd.Parameters.AddWithValue("@login", login);

                UserId = (int)cmd.ExecuteScalar();
            }
        }

        
        //test
        public static void LoadDataInClearDgv(System.Windows.Forms.DataGridView gridView, string query, string fromDate, string toDate)
        {
            
            using (SqlConnection con = ConnectDB.GetConnectDB())
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;

                if (fromDate != null && toDate != null)
                {
                    string priod = " @fromDate, @toDate";
                    cmd.CommandText = query + priod;
                    cmd.Parameters.AddWithValue("@fromDate", fromDate);
                    cmd.Parameters.AddWithValue("@toDate", toDate);
                }
                else cmd.CommandText = query;
                
                                
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    //Set DGV quantity Column and name column
                    SetColumnAndNameColumn(gridView, reader);

                    while (reader.Read())
                    {
                        string[] tempData = new string[reader.FieldCount];
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            tempData[i] = reader[i].ToString();

                        }
                        gridView.Rows.Add(tempData);


                    }
                }
            }
        }


        /// <summary>
        /// The Overloaded Method loads data from DB with help query in clear DGV
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="query"></param>
        public static void LoadDataInClearDgv(DataGridView dataGridView, string query)
        {
            LoadDataInClearDgv(dataGridView, query, null, null);
        }

        /// <summary>
        /// Method sets column and name of column in DGV
        /// </summary>
        /// <param name="gridView"></param>
        /// <param name="reader"></param>
        private static void SetColumnAndNameColumn(DataGridView gridView, SqlDataReader reader)
        {
            if (gridView.ColumnCount == 0)
            {
                gridView.ColumnCount = reader.FieldCount;
                //Set Name column in DGV
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    gridView.Columns[i].Name = reader.GetName(i);

                }
            }
        }
    }

    */
}
