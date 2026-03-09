using System.Data;
using System.Data.SqlClient;

namespace BankDataAccessLayer
{
    public class clsTransfersDataAccess
    {

        public static int AddNewTransfer(decimal Amount, int SenderAccountNumber, int RetrievalAccountNumber, int UserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Insert INTO Transfers (Amount,SenderAccountNumber,RetrievalAccountNumber,UserID)
                              VALUES (@Amount,@SenderAccountNumber,@RetrievalAccountNumber,@UserID);
                     SELECT SCOPE_IDENTITY(); ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@SenderAccountNumber", SenderAccountNumber);
            command.Parameters.AddWithValue("@RetrievalAccountNumber", RetrievalAccountNumber);
            command.Parameters.AddWithValue("@UserID", UserID);

            int TransferID = -1;

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    TransferID = InsertedID;
                }
            }
            catch (System.Exception)
            {


            }
            finally
            {
                connection.Close();
            }

            return TransferID;
        }

        public static DataTable GetAllTransfersLog()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Select * from Transfers;";

            SqlCommand command = new SqlCommand(query, connection);

            DataTable dtTransfersLog = new DataTable();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtTransfersLog.Load(reader);
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

            return dtTransfersLog;
        }
    }
}
