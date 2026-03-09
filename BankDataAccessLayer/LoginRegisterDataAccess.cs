using System;
using System.Data;
using System.Data.SqlClient;

namespace BankDataAccessLayer
{
    public class clsLoginRegisterDataAccess
    {
        public static int AddNewLoginRegister(DateTime LoginDate, int UserID, string UserName, int Permissions)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Insert INTO LoginRegisters (LoginDate, UserID,UserName ,Permissions)
                              VALUES (@LoginDate,@UserID,@UserName,@Permissions);
                     SELECT SCOPE_IDENTITY(); ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LoginDate", LoginDate);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Permissions", Permissions);

            int ID = -1;

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    ID = InsertedID;
                }
            }
            catch (System.Exception)
            {


            }
            finally
            {
                connection.Close();
            }

            return ID;
        }

        public static DataTable GetAllLoginRegisters()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Select * from LoginRegisters;";

            SqlCommand command = new SqlCommand(query, connection);

            DataTable dtLoginRegisters = new DataTable();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtLoginRegisters.Load(reader);
                }

                reader.Close();
            }
            catch (System.Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return dtLoginRegisters;
        }

    }
}
