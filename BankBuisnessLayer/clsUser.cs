using BankDataAccessLayer;
using System;
using System.Data;

namespace BankBuisnessLayer
{
    public class clsUser : clsPerson
    {

        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Permission { get; set; }
        public DateTime JoinDate { get; set; }
        public string ImagePath { get; set; }


        enum enMode { AddNew = 1, Update = 2 }
        enMode _Mode;


        public clsUser()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = "";
            this.Password = "";
            this.Permission = 0;
            this.JoinDate = DateTime.Now;
            this.FirstName = "";
            this.LastName = "";
            this.Email = "";
            this.Phone = "";
            this.Address = "";
            this.DateOfBirth = DateTime.Now;
            this.ImagePath = "";

            _Mode = enMode.AddNew;
            this._PersonMode = enPersonMode.AddNew;

        }

        private clsUser(int UserID, int PersonID, string UserName, string Password, int Permission, DateTime JoinDate
            , string FirstName, string LastName, string Email, string Phone,
            string Address, DateTime DateOfBirth, string ImagePath)
        {

            // UserInfo
            this.UserID = UserID;
            this.UserName = UserName;
            this.Password = Password;
            this.Permission = Permission;
            this.JoinDate = JoinDate;

            // PersonInfo
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
            this.DateOfBirth = DateOfBirth;
            this.ImagePath = ImagePath;


            this._Mode = enMode.Update;
            this._PersonMode = enPersonMode.Update;
        }


        public static clsUser Find(int UserID)
        {
            int PersonID = -1;
            string UserName = "", Password = "";
            int Permission = 0;
            DateTime JoinDate = DateTime.Now;
            string ImagePath = "";

            // first check if the User is found then get the person info

            if (UsersDataAccess.Find(UserID, ref PersonID, ref UserName, ref Password, ref Permission, ref JoinDate, ref ImagePath))
            {
                string FirstName = "", LastName = "", Email = "", Phone = "", Address = "";
                DateTime DateOfBirth = DateTime.Now;

                // Get the person info from Person Table
                if (clsPersonDataAccess.Find(PersonID, ref FirstName, ref LastName, ref Email, ref Phone, ref Address, ref DateOfBirth))
                {
                    return new clsUser(UserID, PersonID, UserName, Password, Permission, JoinDate, FirstName, LastName, Email, Phone, Address, DateOfBirth, ImagePath);
                }
            }


            return null;

        }

        //Find By UserName
        public static clsUser Find(string UserName)
        {
            int UserID = -1, PersonID = -1;
            string Password = "";
            int Permission = 0;
            DateTime JoinDate = DateTime.Now;
            string ImagePath = "";

            // first check if the User is found then get the person info
            if (UsersDataAccess.Find(UserName, ref UserID, ref PersonID, ref Password, ref Permission, ref JoinDate, ref ImagePath))
            {
                string FirstName = "", LastName = "", Email = "", Phone = "", Address = "";
                DateTime DateOfBirth = DateTime.Now;

                // Get the person info from Person Table
                if (clsPersonDataAccess.Find(PersonID, ref FirstName, ref LastName, ref Email, ref Phone, ref Address, ref DateOfBirth))
                {
                    return new clsUser(UserID, PersonID, UserName, Password, Permission, JoinDate, FirstName, LastName, Email, Phone, Address, DateOfBirth, ImagePath);
                }
            }


            return null;
        }
        //Find By UserName and Password
        public static clsUser Find(string UserName, string Password)
        {
            int UserID = -1, PersonID = -1;
            int Permission = 0;
            DateTime JoinDate = DateTime.Now;
            string ImagePath = "";

            // first check if the User is found then get the person info
            if (UsersDataAccess.Find(UserName, Password, ref UserID, ref PersonID, ref Permission, ref JoinDate, ref ImagePath))
            {
                string FirstName = "", LastName = "", Email = "", Phone = "", Address = "";
                DateTime DateOfBirth = DateTime.Now;

                // Get the person info from Person Table
                if (clsPersonDataAccess.Find(PersonID, ref FirstName, ref LastName, ref Email, ref Phone, ref Address, ref DateOfBirth))
                {
                    return new clsUser(UserID, PersonID, UserName, Password, Permission, JoinDate, FirstName, LastName, Email, Phone, Address, DateOfBirth, ImagePath);
                }
            }


            return null;
        }
        private bool _AddNewUser()
        {
            // Save Person info into Persons Table
            if (!this.SavePerson())
                return false;


            // Add User Info into Users Table
            this.UserID = UsersDataAccess.AddNewUser(this.PersonID, this.UserName, this.Password, this.Permission, this.JoinDate, this.ImagePath);

            return (this.UserID != -1);
        }


        private bool _Update()
        {
            // Update Person info in the persons Table First
            if (!this.SavePerson())
                return false;

            return UsersDataAccess.Update(this.UserID, this.UserName, this.Password, this.Permission, this.JoinDate, this.ImagePath);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewUser())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        else
                            return false;
                    }

                case enMode.Update:
                    {
                        return _Update();
                    }

            }

            return false;
        }

        public static bool Delete(int UserID)
        {
            return UsersDataAccess.Delete(UserID);
        }

        public static bool IsExistsUser(string UserName)
        {
            return UsersDataAccess.IsExistsUser(UserName);
        }

        static public DataTable GetAllUsers()
        {
            return UsersDataAccess.GetAllUsers();
        }

    }
}
