using BankBuisnessLayer;
using System;
using System.Windows.Forms;

namespace BankSystemProjectWinfosForm
{
    public partial class frmDeleteUser : Form
    {
        public frmDeleteUser()
        {
            InitializeComponent();
        }

        clsUser User1;
        int UserID = 0;

        private void _Clear()
        {
            txtUserID.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtPermissions.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtJoinDate.Clear();
            pictUserImage.Image = null;

            btnDelete.Enabled = false;

        }

        private void pictFindUser_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtUserID.Text, out UserID))
            {
                MessageBox.Show("Invalid UserID.");
                return;
            }

            User1 = clsUser.Find(UserID);

            if (User1 != null)
            {
                // Load UserData from Object to Boxes
                txtUserName.Text = User1.UserName;
                txtPassword.Text = User1.Password;
                txtFirstName.Text = User1.FirstName;
                txtLastName.Text = User1.LastName;
                txtEmail.Text = User1.Email;
                txtPhone.Text = User1.Phone;
                txtJoinDate.Text = User1.JoinDate.ToString();
                txtPermissions.Text = User1.Permission.ToString();

                btnDelete.Enabled = true;


                if (string.IsNullOrEmpty(User1.ImagePath))
                    pictUserImage.Image = null;
                else
                    pictUserImage.Load(User1.ImagePath);
            }
            else
                MessageBox.Show("User Not Found.");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are sure want to delete this user? ", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsUser.Delete(UserID))
                {
                    MessageBox.Show("User Deleted Successfully.");
                    _Clear();
                    User1 = null;
                }
                else
                    MessageBox.Show("User Deleted Failed.");

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1._LoadForm(new frmManageUsers());
        }
    }
}
