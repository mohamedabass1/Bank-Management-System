using BankBuisnessLayer;
using System;
using System.Windows.Forms;

namespace BankSystemProjectWinfosForm.Manage_Transactions_Screen
{
    public partial class frmTotalBlances : Form
    {
        public frmTotalBlances()
        {
            InitializeComponent();
        }

        private void frmTotalBlances_Load(object sender, EventArgs e)
        {
            dgvTotalBlancesList.DataSource = clsAccounts.GetAllAccounts();

            lblTotalBalances.Text = clsAccounts.GetSumOfTotalBalances().ToString();
        }
    }
}
