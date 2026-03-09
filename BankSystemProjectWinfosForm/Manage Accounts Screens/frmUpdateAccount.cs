using BankBuisnessLayer;
using System.Windows.Forms;

namespace BankSystemProjectWinfosForm
{
    public partial class frmUpdateAccount : Form
    {
        public frmUpdateAccount()
        {
            InitializeComponent();
        }

        clsAccounts Account1;
        int ClientID = 0;
        private void _LoadeAccountInfo()
        {
            // 
            txtPassword.ReadOnly = false;
            txtAccountBalance.ReadOnly = false;
            txtClientID.ReadOnly = false;

            txtPassword.Text = Account1.Password;
            txtAccountBalance.Text = Account1.AccountBalance.ToString();
            txtClientID.Text = Account1.ClientID.ToString();


            btnUpdate.Enabled = true;

        }

        private void BtnSerach_Click(object sender, System.EventArgs e)
        {
            if (!int.TryParse(txtAccountNumber.Text, out int AccountNumber))
            {
                MessageBox.Show("Invalid AccountNumber");
                return;
            }

            Account1 = clsAccounts.Find(AccountNumber);


            if (Account1 != null)
            {
                // Load the Account Info from the Object to the textBoxes 
                _LoadeAccountInfo();
            }
            else
                MessageBox.Show($"Account with AccountNumber {AccountNumber} does not exist.");


        }


        private bool _IsValidUeserInput()
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
                return false;

            if (!decimal.TryParse(txtAccountBalance.Text, out decimal Balance))
                return false;

            if (!int.TryParse(txtClientID.Text, out ClientID))
                return false;

            return true;
        }
        private void _Clear()
        {

            txtAccountNumber.Clear();
            txtClientID.Clear();
            txtAccountBalance.Clear();
            txtPassword.Clear();

            txtPassword.ReadOnly = true;
            txtAccountBalance.ReadOnly = true;
            txtClientID.ReadOnly = true;

            btnUpdate.Enabled = false;

        }
        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            if (!_IsValidUeserInput())
            {
                MessageBox.Show("Invalid Input!");
                return;
            }


            if (!clsClient.IsExistsClient(ClientID))
            {
                MessageBox.Show("Invalid ClientID");
                return;
            }


            // Load data from textBoxes to the object
            Account1.Password = txtPassword.Text;
            Account1.AccountBalance = decimal.Parse(txtAccountBalance.Text);
            Account1.ClientID = int.Parse(txtClientID.Text);


            if (MessageBox.Show("Are you sure want to apply those changes", "Update Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (Account1.Save())
                {
                    MessageBox.Show("Account Updated Successfully");
                    _Clear();
                    Account1 = null;
                }
                else
                    MessageBox.Show("Failed to update account. Please try again.");
            }


        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            _Clear();
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            Form1._LoadForm(new frmManageAaccounts());
        }


    }
}
