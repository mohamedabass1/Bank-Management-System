using BankBuisnessLayer;
using System;
using System.IO;
using System.Windows.Forms;

namespace BankSystemProjectWinfosForm
{
    public partial class frmFindClient : Form
    {
        public frmFindClient()
        {
            InitializeComponent();
        }

        private void ptbFind_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtClientID.Text.ToString(), out int ClientID))
            {
                MessageBox.Show("Invalid Input!");
                return;
            }


            clsClient Client1 = clsClient.FindClient(ClientID);

            if (Client1 != null)
            {
                // Load Client Info to boxes
                txtFirstName.Text = Client1.FirstName;
                txtLastName.Text = Client1.LastName;
                txtEmail.Text = Client1.Email;
                txtPhone.Text = Client1.Phone;
                txtAddress.Text = Client1.Address;
                txtDateOfBrith.Text = Client1.DateOfBirth.ToString();


                if (!string.IsNullOrEmpty(Client1.ImagePath) || File.Exists(Client1.ImagePath))
                    gunaPictureBox1.Load(Client1.ImagePath);
                else
                    gunaPictureBox1.Image = null;

            }
            else
                MessageBox.Show($"Client with ID: {ClientID} not exists in the system.");



        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1._LoadForm(new frmManageClients());
        }
    }
}
