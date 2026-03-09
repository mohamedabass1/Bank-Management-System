using BankBuisnessLayer;
using System;
using System.Windows.Forms;

namespace BankSystemProjectWinfosForm
{
    public partial class frmAccountsList : Form
    {
        public frmAccountsList()
        {
            InitializeComponent();

            dgvAccountList.DataSource = clsAccounts.GetAllAccounts();
            lblTotalBalances.Text = clsAccounts.GetSumOfTotalBalances().ToString();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1._LoadForm(new frmManageAaccounts());
        }
    }
}
