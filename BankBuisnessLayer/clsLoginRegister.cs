using BankDataAccessLayer;
using System;
using System.Data;

namespace BankBuisnessLayer
{
    public class clsLoginRegister
    {
        public int ID { get; set; }
        public DateTime LoginDate { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public int Permissions { get; set; }

        public clsLoginRegister()
        {
            this.ID = -1;
            this.LoginDate = DateTime.Now;
            this.UserID = -1;
            this.UserName = "";
            this.Permissions = 0;
        }

        public bool AddNewLoginRegister()
        {
            this.ID = clsLoginRegisterDataAccess.AddNewLoginRegister(this.LoginDate, this.UserID, this.UserName, this.Permissions);

            return (this.ID != -1);
        }

        public static bool AddNewLoginRegister(DateTime LoginDate, int UserID, string UserName, int Permissions)
        {
            int RegisterID = clsLoginRegisterDataAccess.AddNewLoginRegister(LoginDate, UserID, UserName, Permissions);

            return (RegisterID != -1);
        }

        public static DataTable GetAllLoginRegisters()
        {
            return clsLoginRegisterDataAccess.GetAllLoginRegisters();
        }
    }
}
