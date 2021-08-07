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
    public class UserInfoManager
    {
       

        public static DataRow GetUserInfoListtest(string account)
        {
            string connectionString = DBHelper.GetConnectionString();
            string dbCommandString =
                @"SELECT [ID],[Account],[PWD],[Name],[Email] 
                    FROM UserInfo 
                    where [Account] = @account    
                  ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(dbCommandString, connection))
                {
                    command.Parameters.AddWithValue("@account",account);

                    try
                    {
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
                    catch (Exception ex)
                    {
                        logger.WriteLog(ex);
                        //Console.WriteLine(ex.ToString());
                        return null;
                    }
                }
            }
        }

        public static DataTable aGetUserInfoListtest(string account)
        {
            string connectionString = DBHelper.GetConnectionString();
            string dbCommandString =
                @"SELECT [ID],[Account],[PWD],[Name],[Email] 
                    FROM UserInfo 
                    where [Account] = @account    
                  ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(dbCommandString, connection))
                {
                    command.Parameters.AddWithValue("@account", account);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        //reader.Close();
                        return dt;
                        
                    }
                    catch (Exception ex)
                    {
                        logger.WriteLog(ex);
                        //Console.WriteLine(ex.ToString());
                        return null;
                    }
                }
            }
        }








        public static void InsertIntoData( string account, string PWD, string name, string Email)
        {
            string connectionString = DBHelper.GetConnectionString();

            string dbCommandString =
                @"INSERT INTO UserInfo
                        ( ID, Account, PWD, Name, Email)
                  VALUES
                        (@ID, @account,@PWD,@name,@Email)  
                 ";

            //@"DELETE TestTable WHERE ID = @id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand(dbCommandString, conn))
                {
                    var idd = "F048585A-6A4A-4828-B7A6-5719A7DF5E36";
                    comm.Parameters.AddWithValue("@ID", idd);
                    comm.Parameters.AddWithValue("@account", account);
                    comm.Parameters.AddWithValue("@PWD", PWD);
                    comm.Parameters.AddWithValue("@name", name);
                    comm.Parameters.AddWithValue("@Email", Email);


                    // comm.Parameters.AddWithValue("@numberCol", 240);

                    try
                    {
                        conn.Open();
                        int effectRows = comm.ExecuteNonQuery();
                        // Console.WriteLine($" {effectRows } has changed. ");
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }


        }
    }
}
