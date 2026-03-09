using System;
using System.Data;
using System.Data.SqlClient;

namespace BankDataAccessLayer
{
    public class UsersDataAccess
    {

        // Find By UserID
        public static bool Find(int UserID, ref int PersonID, ref string UserName, ref string Password,
            ref int Permission, ref DateTime JoinDate, ref string ImagePath)
        {

            bool IsFound = false;


            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Select * from Users Where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    IsFound = true;

                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    Permission = (int)reader["Permission"];
                    JoinDate = (DateTime)reader["JoinDate"];

                    if (reader["ImagePath"] == DBNull.Value)
                        ImagePath = "";
                    else
                        ImagePath = (string)reader["ImagePath"];

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

        //Find By UserName
        public static bool Find(string UserName, ref int UserID, ref int PersonID, ref string Password,
            ref int Permission, ref DateTime JoinDate, ref string ImagePath)
        {

            bool IsFound = false;


            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Select * from Users Where UserName = @UserName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    IsFound = true;

                    PersonID = (int)reader["PersonID"];
                    UserID = (int)reader["UserID"];
                    Password = (string)reader["Password"];
                    Permission = (int)reader["Permission"];
                    JoinDate = (DateTime)reader["JoinDate"];

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


        //Find By UserName And Password
        public static bool Find(string UserName, string Password, ref int UserID, ref int PersonID,
            ref int Permission, ref DateTime JoinDate, ref string ImagePath)
        {

            bool IsFound = false;


            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Select * from Users 
                                       Where UserName = @UserName And Password = @Password";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    IsFound = true;

                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    Permission = (int)reader["Permission"];
                    JoinDate = (DateTime)reader["JoinDate"];

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

        public static int AddNewUser(int PersonID, string UserName, string Password,
             int Permission, DateTime JoinDate, string ImagePath)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Insert Into Users (PersonID,UserName,Password,Permission,JoinDate,ImagePath)
                                        Values (@PersonID,@UserName,@Password,@Permission,@JoinDate,@ImagePath);
                                    Select SCOPE_IDENTITY();  ";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permission", Permission);
            command.Parameters.AddWithValue("@JoinDate", JoinDate);

            if (ImagePath == "")
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ImagePath", ImagePath);

            int UserID = -1;
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    UserID = InsertedID;
                }

            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }


            return UserID;


        }


        public static bool Update(int UserID, string UserName, string Password,
             int Permission, DateTime JoinDate, string ImagePath)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Update Users 
                                         SET  
                                            UserName = @UserName,
                                            Password = @Password, 
                                            Permission = @Permission, 
                                            JoinDate = @JoinDate, 
                                            ImagePath = @ImagePath 
                             Where UserID = @UserID; ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permission", Permission);
            command.Parameters.AddWithValue("@JoinDate", JoinDate);

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

        public static bool Delete(int UserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Delete Users 
                                         Where UserID = @UserID; ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);


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

        static public DataTable GetAllUsers()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"SELECT Users.UserID, Users.UserName, Users.Password, Users.Permission, 
                                        Persons.FirstName, Persons.LastName, Persons.Phone,
                                        Users.JoinDate, Users.PersonID, Users.ImagePath
                             FROM Users INNER JOIN
                                             Persons ON Users.PersonID = Persons.PersonID;";

            SqlCommand command = new SqlCommand(query, connection);


            DataTable UsersDataTable = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    UsersDataTable.Load(reader);
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


            return UsersDataTable;

        }

        public static bool IsExistsUser(string UserName)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Select isFound = 1 from Users
                               Where UserName = @UserName; ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);

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
