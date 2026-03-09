using BankDataAccessLayer;
using System;
using System.Data;

namespace BankBuisnessLayer
{
    public class clsClient : clsPerson
    {


        public int ClientID { get; set; }
        public string ImagePath { get; set; }

        enum enMode { AddNew = 1, Update = 2 }

        enMode _Mode;

        public clsClient()
        {
            this.ClientID = -1;
            this.PersonID = -1;
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

        private clsClient(int ClientID, int PersonID, string FirstName, string LastName, string Email, string Phone, string Address, DateTime DateOfBirth, string ImagePath)
        {
            this.ClientID = ClientID;
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
            this.DateOfBirth = DateOfBirth;
            this.ImagePath = ImagePath;

            _Mode = enMode.Update;
            this._PersonMode = enPersonMode.Update;

        }

        static public clsClient FindClient(int ClientID)
        {
            string ImagePath = "";
            int PersonID = -1;

            // first check if the client is found then get the person info
            if (clsClientDataAccess.Find(ClientID, ref PersonID, ref ImagePath))
            {
                // Person Info
                string FirstName = "", LastName = "", Email = "", Phone = "", Address = "";
                DateTime DateOfBirth = DateTime.Now;

                // Get the person info from Person Table
                if (clsPersonDataAccess.Find(PersonID, ref FirstName, ref LastName, ref Email, ref Phone, ref Address, ref DateOfBirth))
                {

                    return new clsClient(ClientID, PersonID, FirstName, LastName,
                                   Email, Phone, Address, DateOfBirth, ImagePath);

                }
            }

            return null;
        }

        private bool _AddNewClient()
        {

            // Save Person info into Persons Table
            if (!this.SavePerson())
                return false;


            // Save Client info into Persons Table
            this.ClientID = clsClientDataAccess.AddNewClient(this.PersonID, this.ImagePath);

            return (this.ClientID != -1);
        }

        private bool _Update()
        {
            // Update Person info in the persons Table First
            if (!this.SavePerson())
                return false;


            // Update Client info in the Client Table
            return clsClientDataAccess.UpdateClient(this.ClientID, this.ImagePath);
        }


        public bool SaveClient()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewClient())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        else
                            return false;
                    }


                case enMode.Update:
                    {
                        if (_Update())
                            return true;
                        else
                            return false;

                    }

            }


            return false;
        }


        static public bool Delete(int ClientID)
        {
            return clsClientDataAccess.Delete(ClientID);
        }

        static public DataTable GetAllClients()
        {
            return clsClientDataAccess.GetAllClients();
        }

        public static bool IsExistsClient(int ClientID)
        {
            return clsClientDataAccess.IsExistsClient(ClientID);
        }

    }
}
