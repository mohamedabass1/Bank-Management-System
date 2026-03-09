using BankDataAccessLayer;
using System;
using System.Data;



namespace BankBuisnessLayer
{
    public class clsPerson
    {



        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }


        protected enum enPersonMode { AddNew = 1, Update = 2 }

        protected enPersonMode _PersonMode;
        public clsPerson()
        {
            this.PersonID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Email = "";
            this.Phone = "";
            this.Address = "";
            this.DateOfBirth = DateTime.Now;

            _PersonMode = enPersonMode.AddNew;

        }

        private clsPerson(int PersonID, string FirstName, string LastName, string Email, string Phone, string Address, DateTime DateOfBirth)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
            this.DateOfBirth = DateOfBirth;

            _PersonMode = enPersonMode.Update;

        }


        public static clsPerson FindPerson(int PersonID)
        {
            string FirstName = "", LastName = "", Email = "", Phone = "", Address = "";
            DateTime DateOfBirth = DateTime.Now;


            if (clsPersonDataAccess.Find(PersonID, ref FirstName, ref LastName, ref Email, ref Phone, ref Address, ref DateOfBirth))
            {
                return new clsPerson(PersonID, FirstName, LastName, Email, Phone, Address, DateOfBirth);
            }
            else
                return null;
        }


        private bool _AddNewPerson()
        {
            this.PersonID = clsPersonDataAccess.AddNewPerson(this.FirstName, this.LastName, this.Email, this.Phone, this.Address, this.DateOfBirth);

            return (this.PersonID != -1);

        }
        private bool _Update()
        {
            return clsPersonDataAccess.UpdatePerson(this.PersonID, this.FirstName, this.LastName, this.Email, this.Phone, this.Address, this.DateOfBirth);
        }
        protected bool SavePerson()
        {

            switch (_PersonMode)
            {
                case enPersonMode.AddNew:
                    {
                        if (_AddNewPerson())
                        {
                            _PersonMode = enPersonMode.Update;
                            return true;
                        }
                        else
                            return false;
                    }

                case enPersonMode.Update:
                    {
                        return _Update();
                    }

            }

            return false;
        }

        public static bool DeletePerson(int PersonID)
        {
            return clsPersonDataAccess.Delete(PersonID);
        }

        public static DataTable GetAllPersons()
        {
            return clsPersonDataAccess.GetAllPersons();
        }

        public static bool IsExistsPerson(int PersonID)
        {
            return clsPersonDataAccess.IsExistsPerson(PersonID);
        }







    }
}
