using BankBuisnessLayer;
using System;
using System.Windows.Forms;

namespace BankSystemProjectWinfosForm
{
    public partial class frmUpdateUser : Form
    {
        public frmUpdateUser()
        {
            InitializeComponent();
        }

        clsUser User1;

        enum enUserPermissions { pManageClient = 1, pManageAccounts = 2, pManageUsers = 4, pManageTransactions = 8, pManageLoginRegisters = 16 }
        private void _LoadUserInfo()
        {

            btnUpdateUser.Enabled = true;
            txtUserName.ReadOnly = false;
            txtPassword.ReadOnly = false;
            txtFirstName.ReadOnly = false;
            txtLastName.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtPhone.ReadOnly = false;

            txtUserName.Text = User1.UserName;
            txtPassword.Text = User1.Password;
            txtFirstName.Text = User1.FirstName;
            txtLastName.Text = User1.LastName;
            txtEmail.Text = User1.Email;
            txtPhone.Text = User1.Phone;
            txtPermissions.Text = User1.Permission.ToString();

            if (string.IsNullOrEmpty(User1.ImagePath))
                pictUserImage.Image = null;
            else
                pictUserImage.Load(User1.ImagePath);

            pictRemoveUserImage.Visible = (pictUserImage.Image != null);

            if (User1.Permission == -1)
            {
                chboxFullPermissions.Checked = true;
                return;
            }

            chboxPmanageClient.Checked = (((int)enUserPermissions.pManageClient & User1.Permission) == (int)enUserPermissions.pManageClient);
            chboxPmanageAccounts.Checked = (((int)enUserPermissions.pManageAccounts & User1.Permission) == (int)enUserPermissions.pManageAccounts);
            chboxPmanageUser.Checked = (((int)enUserPermissions.pManageUsers & User1.Permission) == (int)enUserPermissions.pManageUsers);
            chboxPmanageTransaction.Checked = (((int)enUserPermissions.pManageTransactions & User1.Permission) == (int)enUserPermissions.pManageTransactions);
            chboxPmanageLoginRegister.Checked = (((int)enUserPermissions.pManageLoginRegisters & User1.Permission) == (int)enUserPermissions.pManageLoginRegisters);

        }

        private void pictFindUser_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUserIDToFind.Text, out int UserID))
            {
                MessageBox.Show("Invalid UserID");
            }

            User1 = clsUser.Find(UserID);


            if (User1 != null)
            {
                _LoadUserInfo();
            }
            else
                MessageBox.Show("User Not Found.");


        }

        private bool _CheckIsVaildInput()
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
                return false;

            if (string.IsNullOrEmpty(txtPassword.Text))
                return false;

            if (string.IsNullOrEmpty(txtFirstName.Text))
                return false;

            if (string.IsNullOrEmpty(txtLastName.Text))
                return false;

            if (string.IsNullOrEmpty(txtEmail.Text))
                return false;

            return true;
        }

        private int _CalcoluteUserPermissions()
        {
            int Permission = 0;

            if (chboxFullPermissions.Checked)
                return -1;


            if (chboxPmanageClient.Checked)
                Permission += 1;

            if (chboxPmanageAccounts.Checked)
                Permission += 2;

            if (chboxPmanageUser.Checked)
                Permission += 4;

            if (chboxPmanageTransaction.Checked)
                Permission += 8;

            if (chboxPmanageLoginRegister.Checked)
                Permission += 16;

            return Permission;

        }

        private void _Clear()
        {

            User1 = null;
            txtUserIDToFind.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            pictUserImage.Image = null;
            txtPermissions.Clear();

            btnUpdateUser.Enabled = false;

            chboxFullPermissions.Checked = false;
            chboxPmanageClient.Checked = false;
            chboxPmanageAccounts.Checked = false;
            chboxPmanageUser.Checked = false;
            chboxPmanageTransaction.Checked = false;
            chboxPmanageLoginRegister.Checked = false;
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (!_CheckIsVaildInput())
            {
                MessageBox.Show("Invalid User Input ");
                return;
            }

            User1.UserName = txtUserName.Text;
            User1.Password = txtPassword.Text;
            User1.FirstName = txtFirstName.Text;
            User1.LastName = txtLastName.Text;
            User1.Email = txtEmail.Text;
            User1.Phone = txtPhone.Text;


            User1.Permission = _CalcoluteUserPermissions();


            if (!string.IsNullOrEmpty(pictUserImage.ImageLocation))
                User1.ImagePath = pictUserImage.ImageLocation;
            else
                User1.ImagePath = "";


            if (User1.Save())
            {
                MessageBox.Show("User Updated Successfully.");
                _Clear();
            }
            else
                MessageBox.Show("User Updated Failed.");

        }

        private void picAddUserImge_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "ImagePath Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;

                pictUserImage.Load(selectedFilePath);
            }
        }

        private void pictRemoveUserImage_Click(object sender, EventArgs e)
        {
            pictUserImage.Image = null;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1._LoadForm(new frmManageUsers());
        }


    }
}
