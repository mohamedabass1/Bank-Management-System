using BankBuisnessLayer;
using System;
using System.Windows.Forms;

namespace BankSystemProjectWinfosForm
{
    public partial class frmDeleteAccount : Form
    {
        public frmDeleteAccount()
        {
            InitializeComponent();
        }

        clsAccounts Account1;
        int AccountNumber = 0;

        private void _LoadAccountInfo()
        {

            txtAccountBalance.Text = Account1.AccountBalance.ToString();
            txtClientID.Text = Account1.ClientID.ToString();
            txtPassword.Text = Account1.Password;
            txtCreationDate.Text = Account1.CreationDate.ToString();

            btnDelete.Enabled = true;
        }
        private void _Clear()
        {
            Account1 = null;
            AccountNumber = 0;

            txtAccountNumber.Clear();
            txtAccountBalance.Clear();
            txtClientID.Clear();
            txtPassword.Clear();
            txtCreationDate.Clear();

            btnDelete.Enabled = false;
        }
        private void btnSerach_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAccountNumber.Text, out AccountNumber))
            {
                MessageBox.Show("Invalid AccountNumber");
                return;
            }

            Account1 = clsAccounts.Find(AccountNumber);

            if (Account1 != null)
            {
                _LoadAccountInfo();
            }
            else
                MessageBox.Show($"Account with AccountNumber {AccountNumber} does not exist.");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this account?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsAccounts.Delete(AccountNumber))
                {
                    MessageBox.Show("Account Deleted Successfully.");
                    _Clear();
                }
                else
                    MessageBox.Show("Account Deleted Failed.");

            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            _Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1._LoadForm(new frmManageAaccounts());
        }

    }
}
