using BankSystemProjectWinfosForm.LoginRegisters;
using BankSystemProjectWinfosForm.Manage_Transactions_Screen;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace BankSystemProjectWinfosForm
{


    public partial class Form1 : Form
    {
        public static Panel myPanel;

        // To Save the login form reference
        frmLogin _Login;
        public Form1(frmLogin Login)
        {
            _Login = Login;

            InitializeComponent();
        }

        enum enPermissions : int
        {
            pFullPemissions = -1, pManageClients = 1, pManageAccounts = 2,
            pManageUsers = 4, pManageTransactions = 8, pLogineRegisters = 16
        }
        private bool _CheckAccessPermission(enPermissions Permission)
        {
            if (Permission == enPermissions.pFullPemissions)
                return true;

            if ((Permission & (enPermissions)clsGolobalCurrentUser.Permissions) == Permission)
                return true;
            else
                return false;

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            myPanel = mainPanal;


            // check the permissions if the user not have full Access
            if (clsGolobalCurrentUser.Permissions != (int)enPermissions.pFullPemissions)
            {
                btnManageClients.Enabled = _CheckAccessPermission(enPermissions.pManageClients);
                btnManageAccounts.Enabled = _CheckAccessPermission(enPermissions.pManageAccounts);

                btnManageUsers.Enabled = _CheckAccessPermission(enPermissions.pManageUsers);
                btnManageTransactionScreen.Enabled = _CheckAccessPermission(enPermissions.pManageTransactions);
                btnManageLoginRegister.Enabled = _CheckAccessPermission(enPermissions.pLogineRegisters);
            }



            lblCurrentUserName.Text = clsGolobalCurrentUser.UserName;

            if (clsGolobalCurrentUser.ImagePath != "")
                pictCurrentUserImage.Load(clsGolobalCurrentUser.ImagePath);

            lblDate.Text = DateTime.Now.ToString();
        }



        // Load Specific Form  int the Panel in this form
        public static void _LoadForm(Form frm)
        {
            if (frm == null) return;

            // لو الفورم المفتوح هو نفسه الفورم اللي اشتي افتحه متعملش حاجة
            if (myPanel.Controls.Count > 0 && myPanel.Controls[0].GetType() == frm.GetType())
                return;

            if (myPanel.Controls.Count > 0)
            {
                myPanel.Controls[0].Dispose();
                myPanel.Controls.Clear();
            }

            frm.BackColor = Color.LightCyan;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            myPanel.Controls.Add(frm);
            myPanel.Tag = frm;
            frm.Show();
        }


        private void btnManageClients_Click_1(object sender, EventArgs e)
        {
            _LoadForm(new frmManageClients());

        }
        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            _LoadForm(new frmManageUsers());

        }
        private void btnManageTransactionScreen_Click(object sender, EventArgs e)
        {
            _LoadForm(new frmManageTransactions());
        }
        private void btnManageAccounts_Click(object sender, EventArgs e)
        {
            _LoadForm(new frmManageAaccounts());

        }
        private void btnManageLoginRegister_Click(object sender, EventArgs e)
        {
            _LoadForm(new frmLoginRegistersList());

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void picBoxMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            _Login.Show();
            clsGolobalCurrentUser.Clear();

            this.Close();
        }

        private void mainPanal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
