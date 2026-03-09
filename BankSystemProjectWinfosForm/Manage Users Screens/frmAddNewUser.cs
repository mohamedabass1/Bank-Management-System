using BankBuisnessLayer;
using System;
using System.Windows.Forms;

namespace BankSystemProjectWinfosForm
{
    public partial class frmAddNewUser : Form
    {
        public frmAddNewUser()
        {
            InitializeComponent();
        }

        clsUser User1;
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
            txtUserName.Clear();
            txtPassword.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            pictUserImage.Image = null;

            chboxFullPermissions.Checked = false;
            chboxPmanageClient.Checked = false;
            chboxPmanageAccounts.Checked = false;
            chboxPmanageUser.Checked = false;
            chboxPmanageTransaction.Checked = false;
            chboxPmanageLoginRegister.Checked = false;
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            if (!_CheckIsVaildInput())
            {
                MessageBox.Show("Invalid User input.");
                return;
            }


            User1 = new clsUser();


            User1.UserName = txtUserName.Text;
            User1.Password = txtPassword.Text;
            User1.FirstName = txtFirstName.Text;
            User1.LastName = txtLastName.Text;
            User1.Email = txtEmail.Text;
            User1.Phone = txtPhone.Text;
            User1.JoinDate = DateTime.Now;

            User1.Permission = _CalcoluteUserPermissions();


            if (!string.IsNullOrEmpty(pictUserImage.ImageLocation))
                User1.ImagePath = pictUserImage.ImageLocation;
            else
                User1.ImagePath = "";


            if (User1.Save())
            {
                MessageBox.Show("User Added Successfully User ID: " + User1.UserID);
                _Clear();
            }
            else
                MessageBox.Show("User Added Failed ");



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

        private void btnClear_Click(object sender, EventArgs e)
        {
            _Clear();
        }


    }
}
