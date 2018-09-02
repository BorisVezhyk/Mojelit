using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Mojelit.BL
{
    public interface IDbDetailsOnDep
    {
        DataTable GetDataTableDetailsOnUserDep(string dep);
        int CreateTakeAwayList(int userId);
        void FillTakeAwayList(int idList, DataGridView dgvListAdd);
        DataTable GetData();
        int CreateListAdd(int userId);
        void SaveListDetailsTransfer(int idList, string userDep, DataGridView dgvListAdd);
    }

    public class DbDetailstOnDep:IDbDetailsOnDep
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
        /// Method gets data details in user's departament
        /// </summary>
        /// <param name="dep"></param>
        /// <returns></returns>
        public DataTable GetDataTableDetailsOnUserDep(string dep)
        {
            DataTable dt = new DataTable();
            string query = "select * from all_details where Участок=@dep " +
                           "and NOT(Баланс=0)";
            using (SqlCommand cmd = new SqlCommand(query, _sqlCn))
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
        /// The method creates new Take_list of the details.
        /// </summary>
        /// <returns></returns>
        public int CreateTakeAwayList(int userId)
        {
            string query = "Exec sp_crNewListTakeAway @userId";
            using (SqlCommand cmd = new SqlCommand(query, _sqlCn))
            {

                cmd.Parameters.AddWithValue("@userId", userId);
                int idList = (int)cmd.ExecuteScalar();

                return idList;
            }
        }

        /// <summary>
        /// Method fill take away list
        /// </summary>
        /// <param name="idList"></param>
        /// <param name="dgvListAdd"></param>
        public void FillTakeAwayList(int idList, DataGridView dgvListAdd)
        {
            string query = "exec sp_FillListTakeAwayDetail @idlist,@idDet,@quantity";
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
                        //set id Detail
                        int idDetail = Convert.ToInt32(dgvListAdd.Rows[i].Cells[0].Value);
                        cmd.Parameters.AddWithValue("@idDet", idDetail);
                        //set quantity details
                        int quantity = Convert.ToInt32(dgvListAdd.Rows[i].Cells[8].Value);
                        cmd.Parameters.AddWithValue("@quantity", quantity);

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    sqlTx.Commit();

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    if (sqlTx != null) sqlTx.Rollback();
                }
            }
        }


        //Method get data Employees for transfers
        public DataTable GetData()
        {
            DataTable dt = new DataTable();

            string query = "select Id_Employee,Abbreviation,LName from Employees";

            using (SqlCommand cmd = new SqlCommand(query, _sqlCn))
            {
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    dt.Load(sdr);
                    sdr.Close();
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
                        cmd.Parameters.AddWithValue("@sort", dgvListAdd.Rows[i].Cells[1].Value);
                        cmd.Parameters.AddWithValue("@type", dgvListAdd.Rows[i].Cells[2].Value);
                        cmd.Parameters.AddWithValue("@model", dgvListAdd.Rows[i].Cells[3].Value);
                        cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(dgvListAdd.Rows[i].Cells[8].Value));
                        cmd.Parameters.AddWithValue("@abbrev", userDep);
                        cmd.Parameters.AddWithValue("@notices", dgvListAdd.Rows[i].Cells[7].Value);

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
    }
}
