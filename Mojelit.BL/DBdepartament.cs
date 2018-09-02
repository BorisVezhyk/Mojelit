using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Mojelit.BL
{
    public interface IDbDepartament
    {
        DataTable GetAllDepartaments();
        int GetNewIdDep();
        void SaveChange(DataGridView dataGrid);
    }

    public class DBdepartament : IDbDepartament
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
        //get data all departaments
        public DataTable GetAllDepartaments()
        {
            DataTable dt = new DataTable();
            using(SqlCommand cmd=new SqlCommand("select * from allDepartament", sqlCn))
            {
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                
            }
        }

        //get new id departament
        public int GetNewIdDep()
        {
            using(SqlCommand cmd=new SqlCommand("select MAX(idDep) from Departament",sqlCn))
            {
                return (int)cmd.ExecuteScalar() + 1;
            }
        }

        //save all change in datagrid
        public void SaveChange(DataGridView dataGrid)
        {
            string query = "exec sp_SaveDepartaments @id, @abbrev, @name, @phone";
            using (SqlCommand cmd = new SqlCommand(query, sqlCn))
            {
                SqlTransaction sqlt = null;
                try
                {
                    sqlt = sqlCn.BeginTransaction();
                    cmd.Transaction = sqlt;
                    for (int i = 0; i < dataGrid.Rows.Count; i++)
                    {
                        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(dataGrid[0, i].Value.ToString()));
                        cmd.Parameters.AddWithValue("@abbrev", dataGrid[1, i].Value.ToString());
                        cmd.Parameters.AddWithValue("@name", dataGrid[2, i].Value.ToString());
                        cmd.Parameters.AddWithValue("@phone", dataGrid[3, i].Value.ToString());

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    sqlt.Commit();
                }
                catch ( Exception ex)
                {
                    sqlt.Rollback();
                    MessageBox.Show(text: ex.Message);
                }
            }
        }
    }
}
