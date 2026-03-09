using System;
using System.Windows.Forms;

namespace BankSystemProjectWinfosForm
{
    public partial class frmManageAaccounts : Form
    {
        public frmManageAaccounts()
        {
            InitializeComponent();
        }

        private void btnFindAccount_Click(object sender, EventArgs e)
        {
            Form1._LoadForm(new frmFindAccount());
        }

        private void frmManageAaccounts_Load(object sender, EventArgs e)
        {

        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            Form1._LoadForm(new frmAddNewAccount());
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            Form1._LoadForm(new frmUpdateAccount());

        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            Form1._LoadForm(new frmDeleteAccount());
        }

        private void btnAccountsList_Click(object sender, EventArgs e)
        {
            Form1._LoadForm(new frmAccountsList());

        }
    }
}
