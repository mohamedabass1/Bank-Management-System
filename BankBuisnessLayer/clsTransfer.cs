using BankDataAccessLayer;
using System;
using System.Data;

namespace BankBuisnessLayer
{
    public class clsTransfer
    {
        public int TransferID { get; set; }
        public decimal Amount { get; set; }
        public int FromAccountNumber { get; set; }
        public int ToAccountNumber { get; set; }
        public int UserID { get; set; }
        public DateTime TransferDate { get; set; }


        public clsTransfer()
        {
            this.Amount = 0;
            this.FromAccountNumber = -1;
            this.ToAccountNumber = -1;
            this.UserID = -1;
            this.TransferDate = DateTime.Now;
        }

        public bool AddNewTransfer()
        {
            this.TransferID = clsTransfersDataAccess.AddNewTransfer(this.Amount, this.FromAccountNumber, this.ToAccountNumber, this.UserID);

            return (this.TransferID != -1);
        }
        public static bool AddNewTransfer(decimal Amount, int SenderAccountNumber, int RetrievalAccountNumber, int UserID)
        {
            int TransferID = clsTransfersDataAccess.AddNewTransfer(Amount, SenderAccountNumber, RetrievalAccountNumber, UserID);

            return (TransferID != -1);
        }

        public static DataTable GetAllTransfersLog()
        {
            return clsTransfersDataAccess.GetAllTransfersLog();

        }


    }
}
