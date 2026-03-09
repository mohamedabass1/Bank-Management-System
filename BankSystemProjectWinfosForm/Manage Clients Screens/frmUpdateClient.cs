using BankBuisnessLayer;
using System;
using System.IO;
using System.Windows.Forms;

namespace BankSystemProjectWinfosForm
{
    public partial class frmUpdateClient : Form
    {
        public frmUpdateClient()
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

            // Visibility of Remove Image icon 
            pibRemoveImage.Visible = (pibClientImage.Image != null);

            btnSave.Enabled = true;


        }
        private void ptbFind_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtClientID.Text, out ClientID))
            {
                MessageBox.Show($"Invalid Client ID");
                return;
            }

            Client1 = clsClient.FindClient(ClientID);

            if (Client1 != null)
            {
                // Load Client Data From Object 
                _LoadClientInfo();
            }
            else
                MessageBox.Show($"Client with ID  {ClientID} not exists in the system.", "Not Found");

        }

        bool _IsValidUserInput()
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
                return false;

            if (string.IsNullOrEmpty(txtLastName.Text))
                return false;

            if (string.IsNullOrEmpty(txtEmail.Text))
                return false;

            if (string.IsNullOrEmpty(txtPhone.Text))
                return false;

            return true;
        }
        void _Clear()
        {
            txtClientID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            dtpDateOfBrith.Value = DateTime.Now;
            pibClientImage.Image = null;
            btnSave.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_IsValidUserInput())
            {
                MessageBox.Show("Invalid Input!");
                return;
            }


            // Update The Object Info 
            Client1.FirstName = txtFirstName.Text;
            Client1.LastName = txtLastName.Text;
            Client1.Email = txtEmail.Text;
            Client1.Phone = txtPhone.Text;
            Client1.Address = txtAddress.Text;
            Client1.DateOfBirth = dtpDateOfBrith.Value;

            if (pibClientImage.Image != null)
                Client1.ImagePath = pibClientImage.ImageLocation;
            else
                Client1.ImagePath = "";

            if (Client1.SaveClient())
            {
                MessageBox.Show("Client Updated Successfully");
                _Clear();
            }
            else
                MessageBox.Show("Client Updated Failed");



        }

        private void pibAddImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "ImagePath Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;

                pibClientImage.Load(selectedFilePath);
            }
        }

        private void pibRemoveImage_Click(object sender, EventArgs e)
        {
            pibClientImage.Image = null;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1._LoadForm(new frmManageClients());
        }

    }
}
