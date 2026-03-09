using BankBuisnessLayer;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace BankSystemProjectWinfosForm
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please Enter UserName And Password");
                return;
            }

            string UserName = txtUserName.Text;
            string Password = txtPassword.Text;

            clsUser User1 = clsUser.Find(UserName, Password);

            if (User1 != null)
            {
                clsGolobalCurrentUser.UserID = User1.UserID;
                clsGolobalCurrentUser.UserName = User1.UserName;
                clsGolobalCurrentUser.Password = User1.Password;
                clsGolobalCurrentUser.Permissions = User1.Permission;
                clsGolobalCurrentUser.ImagePath = User1.ImagePath;

                clsLoginRegister.AddNewLoginRegister(DateTime.Now, clsGolobalCurrentUser.UserID, clsGolobalCurrentUser.UserName, clsGolobalCurrentUser.Permissions);


                Form Form1 = new Form1(this);
                Form1.Show();
                this.Hide();

                txtUserName.Clear();
                txtPassword.Clear();
            }
            else
                MessageBox.Show($"This user does not exist: {UserName} , {Password}", "Oops Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '●')
            {
                txtPassword.PasswordChar = '\0';
            }
            else
                txtPassword.PasswordChar = '●'; ;
        }
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picBoxMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pictLinkedin_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = "https://www.linkedin.com/in/mohamed-abass-157a6a328?utm_source=share&utm_campaign=share_via&utm_content=profile&utm_medium=ios_app", UseShellExecute = true });

        }

        private void pictgithub_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = "https://github.com/mohamedabass1", UseShellExecute = true });

        }
    }
}
