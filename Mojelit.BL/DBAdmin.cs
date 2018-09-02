using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mojelit.BL
{
    public interface IDbAdmin
    {
        DataTable GetDataDepartament();
        DataTable GetDataTableAllUsers();
        int GetNewIdUser();
        void SaveChangedUser(DataGridView gridView);
    }

    public class DbAdmin : IDbAdmin
    {
        private SqlConnection sqlCn = null;

        //Method sets connection and its opens
        public void OpenConnection(string connect)
        {
            sqlCn = new SqlConnection(connect);
            sqlCn.Open();
        }
        //Method closes connection
        public void CloseConnection()
        {
            sqlCn.Close();
        }

        //Get all Data Departament
        public DataTable GetDataDepartament()
        {
            DataTable dt = new DataTable();
            string query = "select Abbreviation from Departament";
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

        /// Method gets data all users
        public DataTable GetDataTableAllUsers()
        {
            DataTable dt = new DataTable();
            string query = "select * from allEmployees";
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

        //Get from DB new id user
        public int GetNewIdUser()
        {
            using(SqlCommand cmd = new SqlCommand("select Max(Id_Employee) from Employees",sqlCn))
            {
                return (int)cmd.ExecuteScalar()+1;
            }
        }

        //Save all changed user
        public void SaveChangedUser(DataGridView gridView)
        {
            string query = "exec sp_SaveChangedUser @iduser, @lname, @fname, @mname,@abrev, @phone, @login,@pass";
            using (SqlCommand cmd = new SqlCommand(query, sqlCn))
            {
                SqlTransaction sqlTransaction = null;
                try
                {
                    //start transaction
                    sqlTransaction = sqlCn.BeginTransaction();
                    cmd.Transaction = sqlTransaction;
                    for (int i = 0; i < gridView.Rows.Count; i++)
                    {
                        //set all parameters
                        cmd.Parameters.AddWithValue("@iduser", Convert.ToInt32(gridView[0, i].Value.ToString()));
                        cmd.Parameters.AddWithValue("@lname", gridView[1, i].Value.ToString());
                        cmd.Parameters.AddWithValue("@fname", gridView[2, i].Value.ToString());
                        cmd.Parameters.AddWithValue("@mname", gridView[3, i].Value.ToString());
                        cmd.Parameters.AddWithValue("@abrev", gridView[4, i].Value.ToString());
                        cmd.Parameters.AddWithValue("@phone", gridView[5, i].Value.ToString());
                        cmd.Parameters.AddWithValue("@login", gridView[6, i].Value.ToString());
                        cmd.Parameters.AddWithValue("@pass", gridView[7, i].Value.ToString());

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    sqlTransaction.Commit();
                }
                catch (Exception e)
                {
                    MessageBox.Show(text: e.Message);
                    sqlTransaction.Rollback();
                }
                
            }
        }
    }
}
