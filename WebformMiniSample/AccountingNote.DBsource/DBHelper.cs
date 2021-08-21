using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingNote.DBsource
{
    class DBHelper
    {
        public static string GetConnectionString()
        {
            string val =
                ConfigurationManager.ConnectionStrings
                ["DefaultConnection"].ConnectionString;
            return val;
        }

        public static DataTable ReadDataTable(string connStr, string dbCommand, List<SqlParameter> list)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand comm = new SqlCommand(dbCommand, conn))
                {
                    //comm.Parameters.AddWithValue("@userID", userID);
                    comm.Parameters.AddRange(list.ToArray());

                    conn.Open();
                    var reader = comm.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    return dt;

                }

            }


        }

        public static DataRow GetUserAccount(int id, string userID, string connStr, string dbCommand)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand comm = new SqlCommand(dbCommand, conn))
                {
                    comm.Parameters.AddWithValue("@id", id);
                    comm.Parameters.AddWithValue("@userID", userID);

                    conn.Open();
                    var reader = comm.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    if (dt.Rows.Count == 0)
                        return null;

                    return dt.Rows[0];
                }

            }
        }

        public static void AmoAct(int amount, int actType)
        {
            if (amount < 0 || amount > 1000000)
                throw new ArgumentException("Amount must between 0 and 1000000.");

            if (actType < 0 || actType > 1)
                throw new ArgumentException("ActType must be 0 or 1.");
        }

        public static bool Alldatasql(int ID, string caption, int amount, int actType, string body, string connStr, string dbcommand)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand comm = new SqlCommand(dbcommand, conn))
                {
                    comm.Parameters.AddWithValue("@id", ID);
                    comm.Parameters.AddWithValue("@caption", caption);
                    comm.Parameters.AddWithValue("@amount", amount);
                    comm.Parameters.AddWithValue("@acttype", actType);
                    comm.Parameters.AddWithValue("@createdate", DateTime.Now);
                    comm.Parameters.AddWithValue("@body", body);

                    conn.Open();
                    int effectRows = comm.ExecuteNonQuery();

                    if (effectRows == 1)
                        return true;
                    else
                        return false;
                }
            }
        }

        public static void DeAccNot(int ID, string connStr, string dbcommand)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand comm = new SqlCommand(dbcommand, conn))
                {
                    comm.Parameters.AddWithValue("@id", ID);
                    conn.Open();
                    comm.ExecuteNonQuery();
                }
            }
        }

        public static DataRow Userlist(string account, string connectionString, string dbCommandString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(dbCommandString, connection))
                {
                    command.Parameters.AddWithValue("@account", account);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();

                    if (dt.Rows.Count == 0)
                        return null;

                    DataRow dr = dt.Rows[0];
                    return dr;

                }
            }
        }

        public static void Nadduser(string account, string PWD, string name, string Email, string connectionString, string dbCommandString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand(dbCommandString, conn))
                {
                    Guid g = Guid.NewGuid();

                    var idd = g.ToString();
                    comm.Parameters.AddWithValue("@ID", idd);
                    comm.Parameters.AddWithValue("@account", account);
                    comm.Parameters.AddWithValue("@PWD", PWD);
                    comm.Parameters.AddWithValue("@name", name);
                    comm.Parameters.AddWithValue("@Email", Email);
                    conn.Open();
                    int effectRows = comm.ExecuteNonQuery();

                }
            }
        }




    }
}
