using BankBuisnessLayer;
using System;
using System.Windows.Forms;

namespace BankSystemProjectWinfosForm.Manage_Transactions_Screen
{
    public partial class frmDepositScreen : Form
    {
        public frmDepositScreen()
        {
            InitializeComponent();
        }

        clsAccounts Account1;
        private void btnSerach_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAccountNumber.Text, out int AccountNumber))
            {
                MessageBox.Show("Invalid AccountNumber Pleas enter Valid One.");
                return;
            }

            Account1 = clsAccounts.Find(AccountNumber);

            if (Account1 != null)
            {
                txtPassword.Text = Account1.Password;
                txtAccountBalance.Text = Account1.AccountBalance.ToString();
                txtClientID.Text = Account1.ClientID.ToString();
                txtCearationDate.Text = Account1.CreationDate.ToString();


                txtDepositAmount.Visible = true;
                btnDeposit.Visible = true;
                btnClear.Visible = true;
            }
            else
                MessageBox.Show($"Account with number {AccountNumber} does not exist.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void _Clear()
        {
            Account1 = null;
            txtAccountNumber.Clear();
            txtPassword.Clear();
            txtAccountBalance.Clear();
            txtClientID.Clear();
            txtCearationDate.Clear();
            txtDepositAmount.Clear();

            txtDepositAmount.Visible = false;
            btnDeposit.Visible = false;
            btnClear.Visible = false;
        }


        private void btnDeposit_Click(object sender, EventArgs e)
        {
            decimal DipositAmount = 0;
            if (!decimal.TryParse(txtDepositAmount.Text, out DipositAmount) || DipositAmount <= 0)
            {
                MessageBox.Show("Invalid Deposit Amount Pleas enter positive numeric amount.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Account1.Diposit(DipositAmount))
            {

                MessageBox.Show($"The process was completed successfully, and an amount has been deposited {DipositAmount} " +
                    $"into the account [ {Account1.AccountNumber} ]", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Clear();

            }
            else
                MessageBox.Show($"The process has failed. Please try again correctly." +
                    $"", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1._LoadForm(new frmManageTransactions());
        }

    }
}
