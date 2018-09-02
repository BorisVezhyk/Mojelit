using System.Data;
using System.Data.SqlClient;

namespace Mojelit.BL
{
    public interface IDbAllDetails
    {
        DataTable GetAllDetails();
    }
    public class DBAllDetails : IDbAllDetails
    {
        private SqlConnection sqlCn = null;

        //create connection
        public void OpenConnection(string connect)
        {
            sqlCn = new SqlConnection(connect);
            sqlCn.Open();
        }

        public void CloseConnection()
        {
            sqlCn.Close();
        }

        //method gets data all details
        public DataTable GetAllDetails()
        {
            DataTable dt = new DataTable();
            string query = "SELECT Вид, Тип, Модель, Баланс AS Количество, Участок, [Последнее изменение], Примечание FROM all_details " +
                           "where Баланс !=0";
            using (SqlCommand cmd = new SqlCommand(query, sqlCn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
            }
        }
    }
}
