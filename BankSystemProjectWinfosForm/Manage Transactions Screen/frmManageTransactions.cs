using System;
using System.Windows.Forms;

namespace BankSystemProjectWinfosForm.Manage_Transactions_Screen
{
    public partial class frmManageTransactions : Form
    {
        public frmManageTransactions()
        {
            InitializeComponent();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Form1._LoadForm(new frmDepositScreen());
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Form1._LoadForm(new WithdrawScreen());

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            Form1._LoadForm(new frmTransferScreen());
        }

        private void btnTransferLog_Click(object sender, EventArgs e)
        {
            Form1._LoadForm(new frmTransfersLogScreen());

        }

        private void btnTotalBalances_Click(object sender, EventArgs e)
        {
            Form1._LoadForm(new frmTotalBlances());
        }
    }
}
