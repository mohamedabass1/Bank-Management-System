using System;
using System.Data;
using System.Data.SqlClient;


namespace BankDataAccessLayer
{
    public class clsAccountDataAccess
    {
        public static bool Find(int AccountNumber, ref int ClientID, ref string Password, ref decimal AccountBalance, ref DateTime CreationDate)
        {

            bool IsFound = false;


            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Select * from Accounts Where AccountNumber = @AccountNumber";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    IsFound = true;


                    ClientID = (int)reader["ClientID"];
                    Password = (string)reader["Password"];

                    AccountBalance = (decimal)reader["AccountBalance"];
                    CreationDate = (DateTime)reader["CreationDate"];


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

        public static int AddNewAccount(int ClientID, string Password, decimal AccountBalance)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Insert into Accounts (ClientID,Password,AccountBalance) 
                                         Values(@ClientID,@Password,@AccountBalance);
                            Select SCOPE_IDENTITY();";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@AccountBalance", AccountBalance);


            int AccountNumber = -1;

            try
            {
                connection.Open();


                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    AccountNumber = InsertedID;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return AccountNumber;

        }

        public static bool Update(int AccountNumber, int ClientID, string Password, decimal AccountBalance)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Update Accounts
                                 SET ClientID = @ClientID, 
                                     Password = @Password, 
                                     AccountBalance = @AccountBalance 
                               Where AccountNumber = @AccountNumber;";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@AccountBalance", AccountBalance);


            int AffectedRows = 0;
            try
            {

                connection.Open();

                AffectedRows = command.ExecuteNonQuery();

            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return (AffectedRows > 0);
        }

        public static bool Delete(int AccountNumber)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Delete Accounts Where AccountNumber = @AccountNumber;";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            int AffectedRows = 0;

            try
            {
                connection.Open();

                AffectedRows = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return (AffectedRows > 0);
        }

        static public DataTable GetAllAccounts()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"SELECT * FROM Accounts;";

            SqlCommand command = new SqlCommand(query, connection);


            DataTable AccountsDataTable = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    AccountsDataTable.Load(reader);
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


            return AccountsDataTable;

        }

        public static bool IsExistsAccount(int AccountNumber)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Select isFound = 1 from Accounts
                               Where AccountNumber = @AccountNumber; ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

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

        public static decimal GetSumOfTotalBalances()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Select SUM(AccountBalance) From Accounts;";


            SqlCommand command = new SqlCommand(query, connection);

            decimal TotalBalaneces = 0;

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && decimal.TryParse(result.ToString(), out decimal Balaneces))
                {
                    TotalBalaneces = Balaneces;
                }

            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return TotalBalaneces;
        }


        public static bool UpdateAccountBalance(int AccountNumber, decimal NewAccountBalance)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);


            string query = @"Update Accounts 
                                            SET AccountBalance = @NewAccountBalance
                                         WHERE AccountNumber = @AccountNumber; ";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@NewAccountBalance", NewAccountBalance);

            int AffectedRow = 0;
            try
            {
                connection.Open();

                AffectedRow = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }


            return (AffectedRow > 0);
        }
    }
}
