using BankBuisnessLayer;
using System;
using System.IO;
using System.Windows.Forms;

namespace BankSystemProjectWinfosForm
{
    public partial class frmDeleteClient : Form
    {
        public frmDeleteClient()
        {
            InitializeComponent();
        }


        clsClient Client1;
        int ClientID;

        private void _LoadClientInfo()
        {

            txtFirstName.Text = Client1.FirstName;
            txtLastName.Text = Client1.LastName;
            txtEmail.Text = Client1.Email;
            txtPhone.Text = Client1.Phone;
            txtAddress.Text = Client1.Address;
            dtpDateOfBrith.Text = Client1.DateOfBirth.ToString();


            if (string.IsNullOrEmpty(Client1.ImagePath) || !File.Exists(Client1.ImagePath))
                pibClientImage.Image = null;
            else
                pibClientImage.Load(Client1.ImagePath);


            btnDelete.Enabled = true;

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtClientID.Text, out ClientID))
            {
                MessageBox.Show("Invalid Client ID");
                return;
            }

            Client1 = clsClient.FindClient(ClientID);

            if (Client1 != null)
            {
                // Load Client Info from Object to the Form
                _LoadClientInfo();
            }
            else
                MessageBox.Show($"Client with ID  {ClientID} not exists in the system.", "Not Found");


        }

        void _Clear()
        {
            ClientID = 0;
            Client1 = null;
            txtClientID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            dtpDateOfBrith.Value = DateTime.Now;
            pibClientImage.Image = null;
            btnDelete.Enabled = false;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Want To Delete This Client?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (clsClient.Delete(ClientID))
                {
                    _Clear();
                    MessageBox.Show("Client Deleted Successfully.");
                }
                else
                    MessageBox.Show("The Client Delectation Failed.", "Field", MessageBoxButtons.OK, MessageBoxIcon.Error); ;

            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1._LoadForm(new frmManageClients());

        }
    }
}
