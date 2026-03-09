using System;
using System.Windows.Forms;

namespace BankSystemProjectWinfosForm
{
    public partial class frmManageClients : Form
    {
        public frmManageClients()
        {
            InitializeComponent();
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            Form1._LoadForm(new frmFindClient());
        }

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            Form1._LoadForm(new frmAddNewClient());
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            Form1._LoadForm(new frmUpdateClient());
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            Form1._LoadForm(new frmDeleteClient());
        }

        private void btnClientList_Click(object sender, EventArgs e)
        {
            Form1._LoadForm(new frmClientsList());
        }
    }
}
