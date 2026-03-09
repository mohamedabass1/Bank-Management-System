using System;
using System.Data;
using System.Data.SqlClient;


namespace BankDataAccessLayer
{
    public class clsPersonDataAccess
    {

        public static bool Find(int ID, ref string FirstName, ref string LastName, ref string Email, ref string Phone, ref string Address, ref DateTime DateOfBirth)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Select * from Persons Where PersonID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            bool IsFound = false;
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    IsFound = true;


                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    Address = (string)reader["Address"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];


                }
                reader.Close();

            }

            catch (Exception)
            {
                IsFound = false;
            }
            finally
            {

                connection.Close();
            }

            return IsFound;
        }
        public static int AddNewPerson(string FirstName, string LastName, string Email, string Phone, string Address, DateTime DateOfBirth)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Insert Into 
                             Persons (FirstName,LastName,Email,Phone,Address,DateOfBirth) 
                             Values  (@FirstName,@LastName,@Email,@Phone,@Address,@DateOfBirth);
                             Select SCOPE_IDENTITY();";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);


            int PersonID = -1;

            try
            {

                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    PersonID = InsertedID;
                }

            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return PersonID;



        }

        public static bool UpdatePerson(int ID, string FirstName, string LastName, string Email, string Phone, string Address, DateTime DateOfBirth)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Update Persons
                             SET
                                 FirstName = @FirstName,
                                 LastName = @LastName,
                                 Email = @Email,
                                 Phone = @Phone,
                                 Address = @Address,
                                 DateOfBirth = @DateOfBirth
                             WHERE PersonID = @ID; ";




            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);

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

        public static bool Delete(int ID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Delete Persons
                                    WHERE PersonID = @ID; ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

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

        public static DataTable GetAllPersons()
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Select * from Persons";

            SqlCommand command = new SqlCommand(query, connection);


            DataTable PersonsDataTable = new DataTable();
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    PersonsDataTable.Load(reader);
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


            return PersonsDataTable;


        }


        public static bool IsExistsPerson(int ID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Select isFound = 1 from Persons
                               Where PersonID = @ID; ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            bool isExists = false;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    isExists = true;
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

            return isExists;
        }
    }
}
