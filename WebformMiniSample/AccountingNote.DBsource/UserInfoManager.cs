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

            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@account", account));
            try
            {
                return DBHelper.Userlist(account, connectionString, dbCommandString);
        
            }
            catch (Exception ex)
            {
                logger.WriteLog(ex);
                //Console.WriteLine(ex.ToString());
                return null;
            }
        
        }

        //public static DataTable aGetUserInfoListToal(string account)
        //{
        //    string connectionString = DBHelper.GetConnectionString();
        //    string dbCommandString =
        //        @"SELECT [ID],[Account],[PWD],[Name],[Email] 
        //            FROM UserInfo                     
        //          ";
        //    //where [Account] = @account   
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        using (SqlCommand command = new SqlCommand(dbCommandString, connection))
        //        {
        //            command.Parameters.AddWithValue("@account", account);

        //            try
        //            {
        //                connection.Open();
        //                SqlDataReader reader = command.ExecuteReader();

        //                DataTable dt = new DataTable();
        //                dt.Load(reader);
        //                //reader.Close();
        //                return dt;
                        
        //            }
        //            catch (Exception ex)
        //            {
        //                logger.WriteLog(ex);
        //                //Console.WriteLine(ex.ToString());
        //                return null;
        //            }
        //        }
        //    }
        //}

        public static void InsertIntoData(string account, string PWD, string name, string Email)
        {
            string connectionString = DBHelper.GetConnectionString();

            string dbCommandString =
                @"INSERT INTO UserInfo
                        (ID, Account, PWD, Name, Email)
                  VALUES
                        (@ID, @account,@PWD,@name,@Email)  
                 ";

            List<SqlParameter> list = new List<SqlParameter>();
        //    list.Add(new SqlParameter("@ID", idd));
            list.Add(new SqlParameter("@account", account));
            list.Add(new SqlParameter("@PWD", PWD));
            list.Add(new SqlParameter("@name", name));
            list.Add(new SqlParameter("@Email", Email));

            try
            {
                DBHelper.Nadduser(account, PWD, name, Email, connectionString, dbCommandString);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


        public static DataTable GetUserInfoListtol(string account)
        {
            string connectionString = DBHelper.GetConnectionString();
            string dbCommandString =
                @"SELECT [ID],[Account],[PWD],[Name],[Email] 
                    FROM UserInfo                        
                  ";
            //where [Account] = @account 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(dbCommandString, connection))
                {
                    // command.Parameters.AddWithValue("@account", account);

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



    }
}
