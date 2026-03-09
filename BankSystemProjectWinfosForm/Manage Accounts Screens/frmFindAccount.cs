using BankBuisnessLayer;
using System.Windows.Forms;

namespace BankSystemProjectWinfosForm
{
    public partial class frmFindAccount : Form
    {
        public frmFindAccount()
        {
            InitializeComponent();
        }



        private void BtnFind_Click(object sender, System.EventArgs e)
        {
            if (!int.TryParse(txtAccountNumber.Text, out int AccountNumber))
            {
                MessageBox.Show("Invalid AccountNumber Pleas enter Valid One.");
                return;
            }

            clsAccounts Account1 = clsAccounts.Find(AccountNumber);

            if (Account1 != null)
            {
                txtPassword.Text = Account1.Password;
                txtAccountBalance.Text = Account1.AccountBalance.ToString();
                txtClientID.Text = Account1.ClientID.ToString();
                txtCearationDate.Text = Account1.CreationDate.ToString();
            }
            else
                MessageBox.Show($"Account with number {AccountNumber} does not exist.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }


        private void _Clear()
        {
            txtAccountNumber.Clear();
            txtPassword.Clear();
            txtAccountBalance.Clear();
            txtClientID.Clear();
            txtCearationDate.Clear();
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
