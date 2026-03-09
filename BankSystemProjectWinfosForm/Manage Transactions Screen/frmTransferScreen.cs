using BankBuisnessLayer;
using System.Windows.Forms;

namespace BankSystemProjectWinfosForm.Manage_Transactions_Screen
{
    public partial class frmTransferScreen : Form
    {
        public frmTransferScreen()
        {
            InitializeComponent();
        }

        clsAccounts SenderAccount;
        clsAccounts RetrievalAccount;


        private void _LoadAccountsInfo()
        {
            // Load Sender Info
            txtFromAccountBalance.Text = SenderAccount.AccountBalance.ToString();
            txtFromClientID.Text = SenderAccount.ClientID.ToString();
            txtFromAccountPassword.Text = SenderAccount.Password;

            // Load Retrieval Info
            txtToAccountBalance.Text = RetrievalAccount.AccountBalance.ToString();
            txtToClientID.Text = RetrievalAccount.ClientID.ToString();
            txtToAccountPassword.Text = RetrievalAccount.Password;
        }


        private void btnSerach_Click(object sender, System.EventArgs e)
        {

            int SenderAccountNumber = 0;
            int RetrievalAccountNumber = 0;

            if ((!int.TryParse(txtFromAccountNumber.Text, out SenderAccountNumber) ||
                (!int.TryParse(txtToAccountNumber.Text, out RetrievalAccountNumber))))
            {
                MessageBox.Show("Pleas enter valid AccountNumber.", "Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SenderAccount = clsAccounts.Find(SenderAccountNumber);
            RetrievalAccount = clsAccounts.Find(RetrievalAccountNumber);


            if (SenderAccount != null && RetrievalAccount != null)
            {
                _LoadAccountsInfo();

                txtTransferAmount.Visible = true;
                btnTransferAmount.Visible = true;
                btnClear.Visible = true;
            }
            else
                MessageBox.Show("Data retrieved failed, Pleas enter valid AccountNumber.", "Field", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void _Clear()
        {
            txtFromAccountNumber.Text = "";
            txtFromAccountBalance.Text = "";
            txtFromAccountPassword.Text = "";
            txtFromClientID.Text = "";

            txtToAccountNumber.Text = "";
            txtToAccountBalance.Text = "";
            txtToAccountPassword.Text = "";
            txtToClientID.Text = "";

            txtTransferAmount.Clear();
            txtTransferAmount.Visible = false;

            btnTransferAmount.Visible = false;
            btnClear.Visible = false;
        }
        private void btnTransferAmount_Click(object sender, System.EventArgs e)
        {
            decimal TransferAmount = 0;

            if (!decimal.TryParse(txtTransferAmount.Text, out TransferAmount))
            {
                MessageBox.Show("Invalid Amount");
                return;

            }

            if (TransferAmount <= 0)
            {
                MessageBox.Show("Invalid Amount");
                return;
            }

            if (TransferAmount > SenderAccount.AccountBalance)
            {
                MessageBox.Show($"Please enter a value less than the sender account balance [ {SenderAccount.AccountBalance} ]", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (SenderAccount.WithDraw(TransferAmount) && RetrievalAccount.Diposit(TransferAmount))
            {
                clsTransfer.AddNewTransfer(TransferAmount, SenderAccount.AccountNumber, RetrievalAccount.AccountNumber, clsGolobalCurrentUser.UserID);
                MessageBox.Show("The transfer process has succeeded", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Clear();
            }



        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            _Clear();
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            Form1._LoadForm(new frmManageTransactions());
        }

        private void frmTransferScreen_Load(object sender, System.EventArgs e)
        {

        }
    }
}
