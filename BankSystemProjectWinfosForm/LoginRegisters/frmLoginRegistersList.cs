using BankBuisnessLayer;
using System;
using System.Windows.Forms;

namespace BankSystemProjectWinfosForm.LoginRegisters
{
    public partial class frmLoginRegistersList : Form
    {
        public frmLoginRegistersList()
        {
            InitializeComponent();
        }

        private void frmLoginRegistersList_Load(object sender, EventArgs e)
        {
            dgvLoginRegisters.DataSource = clsLoginRegister.GetAllLoginRegisters();
        }
    }
}
