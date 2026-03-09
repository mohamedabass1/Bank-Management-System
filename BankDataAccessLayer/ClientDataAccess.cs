using System;
using System.Data;
using System.Data.SqlClient;

namespace BankDataAccessLayer
{
    public class clsClientDataAccess
    {


        public static bool Find(int ClientID, ref int PersonID, ref string ImagePath)
        {

            bool IsFound = false;


            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Select * from Clients Where ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    IsFound = true;

                    PersonID = (int)reader["PersonID"];


                    if (reader["ImagePath"] == DBNull.Value)
                        ImagePath = "";
                    else
                        ImagePath = (string)reader["ImagePath"];

                }
                reader.Close();


            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();

            }

            return IsFound;


        }

        public static int AddNewClient(int PersonID, string ImagePath)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Insert Into Clients (PersonID,ImagePath)
                                          Values (@PersonID,@ImagePath);
                             Select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            if (string.IsNullOrWhiteSpace(ImagePath))
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ImagePath", ImagePath);

            int ClientID = -1;

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    ClientID = InsertedID;
                }


            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return ClientID;
        }

        public static bool UpdateClient(int ClientID, string ImagePath)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Update Clients 
                                         SET  
                                            ImagePath = @ImagePath 
                                         Where ClientID = @ClientID; ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);

            if (string.IsNullOrWhiteSpace(ImagePath))
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ImagePath", ImagePath);


            int AffcetedRows = 0;
            try
            {
                connection.Open();

                AffcetedRows = command.ExecuteNonQuery();

            }
            catch (Exception)
            {


            }
            finally
            {
                connection.Close();
            }

            return (AffcetedRows > 0);
        }

        public static bool Delete(int ClientID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Delete Clients 
                                         Where ClientID = @ClientID; ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);


            int AffcetedRows = 0;
            try
            {
                connection.Open();

                AffcetedRows = command.ExecuteNonQuery();

            }
            catch (Exception)
            {


            }
            finally
            {
                connection.Close();
            }

            return (AffcetedRows > 0);

        }

        static public DataTable GetAllClients()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"SELECT Clients.ClientID, Persons.FirstName, Persons.LastName, Persons.Email, Persons.Phone,
                                    Persons.Address, Persons.DateOfBirth, Clients.ImagePath
                  FROM     Clients INNER JOIN
                  Persons ON Clients.PersonID = Persons.PersonID;";

            SqlCommand command = new SqlCommand(query, connection);


            DataTable ClientsDataTable = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    ClientsDataTable.Load(reader);
                }
                reader.Close();
            }
            catch (Exception)
            {

            }

            finally
            {
                connection.Close();

            }


            return ClientsDataTable;

        }

        public static bool IsExistsClient(int ClientID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Select isFound = 1 from Clients
                               Where ClientID = @ClientID; ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);

            bool isExists = false;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                isExists = reader.HasRows;

                reader.Close();


            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return isExists;
        }

    }
}
