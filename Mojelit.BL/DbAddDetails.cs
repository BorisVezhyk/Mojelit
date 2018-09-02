using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mojelit.BL
{
    public interface IDbAddDetails
    {
        int CreateListAdd(int userId);
        void SaveListDetails(int idList, string userDep, DataGridView dgvListAdd);
        DataTable GetDataTableAllDetails();
        DataTable GetDataForCompleteString();
        void SaveListDetailsTransfer(int idList, string userDep, DataGridView dgvListAdd);
    }

    public class DbAddDetails : IDbAddDetails
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
        /// Method get datatable for AutoCompleteString
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataForCompleteString()
        {
            DataTable dt = new DataTable();
            string query = "select Sort,Type,Model from Details";
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
        /// The method creates new ADD_list of the details.
        /// </summary>
        /// <returns></returns>
        public int CreateListAdd(int userId)
        {
            string query = "Exec dbo.crNewListAdd @userId";
            using (SqlCommand cmd = new SqlCommand(query, _sqlCn))
            {
                cmd.Parameters.AddWithValue("@userId", userId);
                return (int)cmd.ExecuteScalar();
            }
        }

        /// <summary>
        /// The method saves all list of the details. 
        /// </summary>
        /// <param name="idList"></param>
        /// <param name="userDep"></param>
        /// <param name="dgvListAdd"></param>
        public void SaveListDetails(int idList, string userDep, DataGridView dgvListAdd)
        {
            string query = "EXEC FillListAdd @idlist, @sort, @type, @model, @quantity, @abbrev,@notices";

            using (SqlCommand cmd = new SqlCommand(query, _sqlCn))
            {
                SqlTransaction sqlTx = null;
                try
                {
                    sqlTx = _sqlCn.BeginTransaction();
                    cmd.Transaction = sqlTx;
                    for (int i = 0; i < dgvListAdd.RowCount; i++)
                    {
                        cmd.Parameters.AddWithValue("@idlist", idList);
                        cmd.Parameters.AddWithValue("@sort", dgvListAdd.Rows[i].Cells[0].Value);
                        cmd.Parameters.AddWithValue("@type", dgvListAdd.Rows[i].Cells[1].Value);
                        cmd.Parameters.AddWithValue("@model", dgvListAdd.Rows[i].Cells[2].Value);
                        cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(dgvListAdd.Rows[i].Cells[3].Value));
                        cmd.Parameters.AddWithValue("@abbrev", userDep);
                        cmd.Parameters.AddWithValue("@notices", dgvListAdd.Rows[i].Cells[4].Value);

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    sqlTx.Commit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(text: ex.Message);
                    sqlTx?.Rollback();
                }

            }
        }

        //The method saves data for Transfer
        public void SaveListDetailsTransfer(int idList, string userDep, DataGridView dgvListAdd)
        {
            string query = "EXEC FillListAdd @idlist, @sort, @type, @model, @quantity, @abbrev,@notices";

            using (SqlCommand cmd = new SqlCommand(query, _sqlCn))
            {
                SqlTransaction sqlTx = null;
                try
                {
                    sqlTx = _sqlCn.BeginTransaction();
                    cmd.Transaction = sqlTx;
                    for (int i = 0; i < dgvListAdd.RowCount; i++)
                    {
                        cmd.Parameters.AddWithValue("@idlist", idList);
                        cmd.Parameters.AddWithValue("@sort", dgvListAdd.Rows[i].Cells[0].Value);
                        cmd.Parameters.AddWithValue("@type", dgvListAdd.Rows[i].Cells[1].Value);
                        cmd.Parameters.AddWithValue("@model", dgvListAdd.Rows[i].Cells[2].Value);
                        cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(dgvListAdd.Rows[i].Cells[7].Value));
                        cmd.Parameters.AddWithValue("@abbrev", userDep);
                        cmd.Parameters.AddWithValue("@notices", dgvListAdd.Rows[i].Cells[6].Value);

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    sqlTx.Commit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(text: ex.Message);
                    sqlTx?.Rollback();
                }

            }
        }

        /// <summary>
        /// Method gets data all details
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTableAllDetails()
        {
            DataTable dt = new DataTable();
            string query = "select * from all_details";
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
    }
}
