using BankBuisnessLayer;
using System;
using System.Windows.Forms;

namespace BankSystemProjectWinfosForm
{
    public partial class frmAddNewAccount : Form
    {
        public frmAddNewAccount()
        {
            InitializeComponent();
        }

        private void _Clear()
        {
            txtClientID.Clear();
            txtAccountBalance.Clear();
            txtPassword.Clear();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // Is Valid Client ID And Is Client is Exists in DataBase
            if (!int.TryParse(txtClientID.Text, out int ClientID) || !clsClient.IsExistsClient(ClientID))
            {
                MessageBox.Show("Invalid ClientID");
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text) || !decimal.TryParse(txtAccountBalance.Text, out decimal AccountBaalace))
            {
                MessageBox.Show("Invalid Input");
                return;

            }

            clsAccounts Account1 = new clsAccounts();


            // Load Account Info from Form To Object
            Account1.ClientID = ClientID;
            Account1.AccountBalance = AccountBaalace;
            Account1.Password = txtPassword.Text;


            if (Account1.Save())
            {
                MessageBox.Show("Account Added Successfully AccountNumber is: " + Account1.AccountNumber);
                _Clear();
            }
            else
                MessageBox.Show("Failed to add new account. Please try again.");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1._LoadForm(new frmManageAaccounts());
        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }

        private void txtClientID_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void txtAccountBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
