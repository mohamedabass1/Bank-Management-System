using BankBuisnessLayer;
using System;
using System.Windows.Forms;

namespace BankSystemProjectWinfosForm.Manage_Transactions_Screen
{
    public partial class frmTransfersLogScreen : Form
    {
        public frmTransfersLogScreen()
        {
            InitializeComponent();
        }

        private void frmTransfersLogScreen_Load(object sender, EventArgs e)
        {
            dgvAllTransactionsLog.DataSource = clsTransfer.GetAllTransfersLog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1._LoadForm(new frmManageTransactions());
        }
        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

    }
}
