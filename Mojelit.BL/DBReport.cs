using System;
using System.Data.SqlClient;
using System.Data;

namespace Mojelit.BL
{
    public interface IDbReport
    {
        DataTable LoadReportQuery(string fromDate, string toDate);
        DataTable GetDataUser();
        DataTable GetDataDepartament();
        DataTable GetRemainder(string byDate);
        DataTable GetDataActivity(string fromDate, string toDate);
    }

    public class DBReport : IDbReport
    {
        private SqlConnection sqlCn = null;


        public void OpenConnection(string connect)
        {
            sqlCn = new SqlConnection(connect);
            sqlCn.Open();
        }

        public void CloseConnection()
        {
            sqlCn.Close();
        }
        //Get Report
        public DataTable LoadReportQuery(string fromDate, string toDate)
        {
            string query = "select * from MainReport(@fromDate,@toDate)" +
                           "where Not([Остаток на Начало]=0 and Приход=0)";
            using (SqlCommand cmd = new SqlCommand(query,sqlCn))
            {
                cmd.Parameters.AddWithValue("@fromDate", fromDate);
                cmd.Parameters.AddWithValue("@toDate", toDate);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;

                }
            }
        }
        //Get data Activity
        public DataTable GetDataActivity(string fromDate, string toDate)
        {
            string query = "exec sp_fullDataSelect";
            using (SqlCommand cmd = new SqlCommand(query, sqlCn))
            {

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
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;

                }
            }
        }

        //Get Remainder
        public DataTable GetRemainder(string byDate)
        {
            string query = string.Format(
                "with tempAddT as (select SUM(Quantity) as TotalAdd, Id_Detail from List_Adding_details\n" +
                "join Employee_Add_details on\n List_Adding_details.Id_ListAdd = Employee_Add_details.Id_ListAdd\n" +
                "where Date <= '{0}' group by Id_Detail),\n" +
                " tempTakeT as ( select SUM(Quantity) as TotalTake,Id_Detail from List_Taking_details join Employee_Take_details on\n" +
                "List_Taking_details.Id_ListTake = Employee_Take_details.Id_ListTake where Date<= '{0}' group by Id_Detail),\n" +
                "FactDetailsOnDate as (select a.TotalAdd - b.TotalTake as Остаток,a.Id_Detail from tempAddT as a join tempTakeT as b on\n " +
                "a.Id_Detail = b.Id_Detail union select* from tempAddT where tempAddT.Id_Detail not in " +
                "(select a.Id_Detail from tempAddT as a join tempTakeT as b on\n a.Id_Detail = b.Id_Detail)) " +
                "select b.Sort as Вид, b.Type as Тип, b.Model as Модель , b.Abbreviation as Отдел, a.Остаток from FactDetailsOnDate as a " +
                "join Details as b on\n b.Id_Detail = a.Id_Detail order by a.Id_Detail;",byDate);


            using (SqlCommand cmd = new SqlCommand(query,sqlCn))
            {
                //cmd.Parameters.AddWithValue("@setdate", byDate);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
            }
        }

        //Get all Data Users
        public DataTable GetDataUser()
        {
            DataTable dt = new DataTable();
            string query = "select LName+FName+Mname from Employees";
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

        //Get all Data Departament
        public DataTable GetDataDepartament()
        {
            DataTable dt = new DataTable();
            string query = "select Abbreviation from Details group by Abbreviation";
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
