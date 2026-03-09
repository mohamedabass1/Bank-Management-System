// Ignore Spelling: Diposit

using BankDataAccessLayer;
using System;
using System.Data;

namespace BankBuisnessLayer
{
    public class clsAccounts
    {

        public int AccountNumber { get; set; }
        public int ClientID { get; set; }
        public string Password { get; set; }
        public decimal AccountBalance { get; set; }
        public DateTime CreationDate { get; set; }

        enum enMode { AddNew = 1, Update = 2 }
        enMode _Mode;



        public clsAccounts()
        {
            this.AccountNumber = -1;
            this.AccountBalance = 0;
            this.Password = "";
            this.ClientID = -1;
            this.CreationDate = DateTime.Now;

            _Mode = enMode.AddNew;
        }

        private clsAccounts(int AccountNumber, int ClientID, string Password, decimal AccountBalance, DateTime CreationDate)
        {
            this.AccountNumber = AccountNumber;
            this.ClientID = ClientID;
            this.Password = Password;
            this.AccountBalance = AccountBalance;
            this.CreationDate = CreationDate;

            _Mode = enMode.Update;
        }


        public static clsAccounts Find(int AccountNumber)
        {
            int ClientID = -1;
            string Password = "";
            decimal AccountBalance = 0;
            DateTime CreationDate = DateTime.Now;

            if (clsAccountDataAccess.Find(AccountNumber, ref ClientID, ref Password, ref AccountBalance, ref CreationDate))
            {
                return new clsAccounts(AccountNumber, ClientID, Password, AccountBalance, CreationDate);
            }
            else
                return null;
        }
        private bool _AddNewAccount()
        {
            this.AccountNumber = clsAccountDataAccess.AddNewAccount(this.ClientID, this.Password, this.AccountBalance);

            return (this.AccountNumber != -1);
        }

        private bool _Update()
        {
            return clsAccountDataAccess.Update(this.AccountNumber, this.ClientID, this.Password, this.AccountBalance);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewAccount())
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

        public static bool Delete(int AccountNumber)
        {
            return clsAccountDataAccess.Delete(AccountNumber);
        }

        static public DataTable GetAllAccounts()
        {
            return clsAccountDataAccess.GetAllAccounts();
        }

        public static bool IsExistsAccount(int AccountNumber)
        {
            return clsAccountDataAccess.IsExistsAccount(AccountNumber);
        }

        public static decimal GetSumOfTotalBalances()
        {
            return clsAccountDataAccess.GetSumOfTotalBalances();
        }



        public bool Diposit(decimal Amount)
        {
            if (Amount <= 0)
                return false;

            this.AccountBalance += Amount;
            return clsAccountDataAccess.UpdateAccountBalance(this.AccountNumber, this.AccountBalance);
        }

        public bool WithDraw(decimal Amount)
        {
            if (Amount <= 0)
                return false;

            if (Amount > this.AccountBalance)
                return false;


            this.AccountBalance -= Amount;
            return clsAccountDataAccess.UpdateAccountBalance(this.AccountNumber, this.AccountBalance);
        }

    }
}
