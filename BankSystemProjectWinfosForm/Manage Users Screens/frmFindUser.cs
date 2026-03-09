using BankBuisnessLayer;
using System;
using System.Windows.Forms;

namespace BankSystemProjectWinfosForm
{
    public partial class frmFindUser : Form
    {
        public frmFindUser()
        {
            InitializeComponent();
        }

        private void pictFindUser_Click(object sender, EventArgs e)
        {
            int UserID = 0;
            if (!int.TryParse(txtUserID.Text, out UserID))
            {
                MessageBox.Show("Invalid UserID.");
                return;
            }

            clsUser User1 = clsUser.Find(UserID);

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


                if (string.IsNullOrEmpty(User1.ImagePath))
                    pictUserImage.Image = null;
                else
                    pictUserImage.Load(User1.ImagePath);
            }
            else
                MessageBox.Show("User Not Found.");

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1._LoadForm(new frmManageUsers());
        }



    }
}
