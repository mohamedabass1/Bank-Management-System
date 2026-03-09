using BankBuisnessLayer;
using System;
using System.Windows.Forms;

namespace BankSystemProjectWinfosForm
{
    public partial class frmAddNewClient : Form
    {
        public frmAddNewClient()
        {
            InitializeComponent();
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

            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            dtpDateOfBrith.Value = DateTime.Now;
            pibClientImage.Image = null;
        }
        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            if (!_IsValidUserInput())
            {
                MessageBox.Show("Invalid Input!");
                return;
            }

            clsClient Client1 = new clsClient();

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
                MessageBox.Show("Client Added Successfully Client ID is " + Client1.ClientID);
                _Clear();
            }
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
