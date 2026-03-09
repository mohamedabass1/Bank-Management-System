using BankBuisnessLayer;
using System;
using System.Windows.Forms;

namespace BankSystemProjectWinfosForm
{
    public partial class frmClientsList : Form
    {
        public frmClientsList()
        {
            InitializeComponent();
        }

        private void frmClientsList_Load(object sender, EventArgs e)
        {
            dgvClientsList.DataSource = clsClient.GetAllClients();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1._LoadForm(new frmManageClients());
        }
    }
}
