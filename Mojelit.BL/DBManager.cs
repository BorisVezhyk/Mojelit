using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Mojelit.BL
{
    public interface IDbManager
    {
        string TakePasswordFromBd(string login);
        string GetUserDepartament(string password);
        int GetUserId(string password);
        DataTable GetDataTableAllDetails();
        DataTable GetDataTableDetailsOnUserDep(string dep);
        DataTable GetDataTableAllUsers();
        DataTable GetAllUser();
        string GetPassword(string login);
    }

    public class DbManager : IDbManager
    {
        private SqlConnection _sqlCn;


        public void OpenConnection(string connect)
        {
            _sqlCn = new SqlConnection(connect);
            _sqlCn.Open();
        }

        public void CloseConnection()
        {
            _sqlCn.Close();
        }
        /// <summary>
        /// Method gets password from BD
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public string TakePasswordFromBd(string login)
        {
            string query = "select Pass from Login_pass where Login= @login";
            using (SqlCommand cmd = new SqlCommand(query, _sqlCn))
            {
                cmd.Parameters.AddWithValue("@login", login);
                return (string)cmd.ExecuteScalar();
            }
        }

        /// <summary>
        /// Method gets user departament from BD
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public string GetUserDepartament(string password)
        {
            string query = "select Abbreviation from Employees join Login_pass on Employees.Id_Employee=Login_pass.Id_Employee where Login_pass.Pass=@password";
            using (SqlCommand cmd = new SqlCommand(query, _sqlCn))
            {
                cmd.Parameters.AddWithValue("@password", password);
                return (string)cmd.ExecuteScalar();
            }

        }

        /// <summary>
        /// Method gets user Id from BD
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public int GetUserId(string password)
        {
            string query = "select Employees.Id_Employee from Employees join Login_pass on Employees.Id_Employee=Login_pass.Id_Employee where Login_pass.Pass= @password";
            using (SqlCommand cmd = new SqlCommand(query, _sqlCn))
            {
                cmd.Parameters.AddWithValue("@password", password);
                return (int)cmd.ExecuteScalar();
            }
        }

        /// <summary>
        /// Method gets data all details
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTableAllDetails()
        {
            DataTable dt = new DataTable();
            string query = "SELECT Вид, Тип, Модель, Баланс AS Количество, Участок, [Последнее изменение], Примечание FROM all_details where Баланс!=0";
            using (SqlCommand cmd = new SqlCommand(query, _sqlCn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
            }
        }
        
        /// <summary>
        /// Method gets data details in user's departament
        /// </summary>
        /// <param name="dep"></param>
        /// <returns></returns>
        public DataTable GetDataTableDetailsOnUserDep(string dep)
        {
            DataTable dt = new DataTable();
            string query = "select * from all_details where Участок=@dep and Not(Баланс=0)";
            using(SqlCommand cmd = new SqlCommand(query, _sqlCn))
            {
                cmd.Parameters.AddWithValue("@dep", dep);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
            }
        }


        /// <summary>
        /// Method gets data all users
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTableAllUsers()
        {
            DataTable dt = new DataTable();
            string query = "select * from allEmployees";
            using (SqlCommand cmd = new SqlCommand(query, _sqlCn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                    reader.Close();
                    return dt;

                }
            }
        }

        public DataTable GetAllUser()
        {

            string query = "select LName+' '+FName+' '+MName as ФИО from Employees";
            DataTable dt = new DataTable();

            using (SqlCommand cmd=new SqlCommand(query,_sqlCn))
            {
                using (SqlDataReader reader= cmd.ExecuteReader())
                {
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
            }

        }

        public string GetPassword(string login)
        {
            string query =
                $"select Login_pass.Pass from Employees join Login_pass on\n " +
                $"Employees.Id_Employee = Login_pass.Id_Employee where Employees.LName like '{login}'";
            using (SqlCommand cmd = new SqlCommand(query,_sqlCn))
            {
                var temp = cmd.ExecuteScalar();
                return (string)temp;
            }
        }
    }

    
}
    
