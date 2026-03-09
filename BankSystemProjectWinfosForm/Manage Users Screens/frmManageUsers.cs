using System;
using System.Windows.Forms;

namespace BankSystemProjectWinfosForm
{
    public partial class frmManageUsers : Form
    {
        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void btnFindUser_Click(object sender, EventArgs e)
        {
            Form1._LoadForm(new frmFindUser());
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Form1._LoadForm(new frmAddNewUser());
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            Form1._LoadForm(new frmUpdateUser());
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            Form1._LoadForm(new frmDeleteUser());
        }

        private void btnUserList_Click(object sender, EventArgs e)
        {
            Form1._LoadForm(new frmUsersList());

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labMainScreenUsers_Click(object sender, EventArgs e)
        {

        }
    }
}
