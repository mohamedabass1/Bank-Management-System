using BankBuisnessLayer;
using System;
using System.Windows.Forms;

namespace BankSystemProjectWinfosForm.Manage_Transactions_Screen
{
    public partial class WithdrawScreen : Form
    {
        public WithdrawScreen()
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


                txtWithdrawAmount.Visible = true;
                btnWithdraw.Visible = true;
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
            txtWithdrawAmount.Clear();

            txtWithdrawAmount.Visible = false;
            btnWithdraw.Visible = false;
            btnClear.Visible = false;
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {

            decimal WithdrawAmount = 0;
            if (!decimal.TryParse(txtWithdrawAmount.Text, out WithdrawAmount))
            {
                MessageBox.Show("Invalid Withdraw Amount Pleas enter numeric amount.");
                return;
            }

            if (WithdrawAmount <= 0 || WithdrawAmount > Account1.AccountBalance)
            {
                MessageBox.Show($"Error: Please enter a value less than the current account balance [ {Account1.AccountBalance} ]", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            if (Account1.WithDraw(WithdrawAmount))
            {
                MessageBox.Show($"The process was completed successfully, and an amount has been deposited {WithdrawAmount}", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Clear();
            }
            else
                MessageBox.Show($"The process has failed. Please try again correctly.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
