namespace BankSystemProjectWinfosForm
{
    partial class frmAddNewClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.btnAddNewClient = new Guna.UI.WinForms.GunaButton();
            this.pibRemoveImage = new Guna.UI.WinForms.GunaPictureBox();
            this.pibAddImage = new Guna.UI.WinForms.GunaPictureBox();
            this.pibClientImage = new Guna.UI.WinForms.GunaPictureBox();
            this.dtpDateOfBrith = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txtAddress = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtPhone = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtEmail = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtLastName = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtFirstName = new Guna.UI.WinForms.GunaTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibRemoveImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibAddImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibClientImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.btnBack);
            this.gunaPanel1.Controls.Add(this.gunaLabel8);
            this.gunaPanel1.Controls.Add(this.btnAddNewClient);
            this.gunaPanel1.Controls.Add(this.pibRemoveImage);
            this.gunaPanel1.Controls.Add(this.pibAddImage);
            this.gunaPanel1.Controls.Add(this.pibClientImage);
            this.gunaPanel1.Controls.Add(this.dtpDateOfBrith);
            this.gunaPanel1.Controls.Add(this.gunaLabel6);
            this.gunaPanel1.Controls.Add(this.gunaLabel7);
            this.gunaPanel1.Controls.Add(this.txtAddress);
            this.gunaPanel1.Controls.Add(this.gunaLabel4);
            this.gunaPanel1.Controls.Add(this.txtPhone);
            this.gunaPanel1.Controls.Add(this.gunaLabel5);
            this.gunaPanel1.Controls.Add(this.txtEmail);
            this.gunaPanel1.Controls.Add(this.gunaLabel3);
            this.gunaPanel1.Controls.Add(this.txtLastName);
            this.gunaPanel1.Controls.Add(this.gunaLabel2);
            this.gunaPanel1.Controls.Add(this.txtFirstName);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1122, 628);
            this.gunaPanel1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Animated = true;
            this.btnBack.AutoRoundedCorners = true;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BorderRadius = 26;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBack.Location = new System.Drawing.Point(141, 553);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(210, 55);
            this.btnBack.TabIndex = 53;
            this.btnBack.Text = "Back";
            this.btnBack.UseTransparentBackground = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.gunaLabel8.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel8.Location = new System.Drawing.Point(144, 85);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(318, 54);
            this.gunaLabel8.TabIndex = 35;
            this.gunaLabel8.Text = "Add New Client";
            // 
            // btnAddNewClient
            // 
            this.btnAddNewClient.AnimationHoverSpeed = 0.07F;
            this.btnAddNewClient.AnimationSpeed = 0.03F;
            this.btnAddNewClient.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewClient.BaseColor = System.Drawing.Color.Gainsboro;
            this.btnAddNewClient.BorderColor = System.Drawing.Color.Black;
            this.btnAddNewClient.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNewClient.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddNewClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddNewClient.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewClient.Image = null;
            this.btnAddNewClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddNewClient.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddNewClient.Location = new System.Drawing.Point(492, 553);
            this.btnAddNewClient.Name = "btnAddNewClient";
            this.btnAddNewClient.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddNewClient.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddNewClient.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnAddNewClient.OnHoverImage = null;
            this.btnAddNewClient.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddNewClient.Radius = 20;
            this.btnAddNewClient.Size = new System.Drawing.Size(218, 55);
            this.btnAddNewClient.TabIndex = 34;
            this.btnAddNewClient.Text = "Add New Client";
            this.btnAddNewClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddNewClient.Click += new System.EventHandler(this.btnAddNewClient_Click);
            // 
            // pibRemoveImage
            // 
            this.pibRemoveImage.BackColor = System.Drawing.Color.Transparent;
            this.pibRemoveImage.BaseColor = System.Drawing.Color.White;
            this.pibRemoveImage.Image = global::BankSystemProjectWinfosForm.Properties.Resources.deleteimage_;
            this.pibRemoveImage.Location = new System.Drawing.Point(881, 359);
            this.pibRemoveImage.Name = "pibRemoveImage";
            this.pibRemoveImage.Radius = 25;
            this.pibRemoveImage.Size = new System.Drawing.Size(61, 50);
            this.pibRemoveImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibRemoveImage.TabIndex = 33;
            this.pibRemoveImage.TabStop = false;
            this.toolTip1.SetToolTip(this.pibRemoveImage, "Remove ImagePath");
            this.pibRemoveImage.Click += new System.EventHandler(this.pibRemoveImage_Click);
            // 
            // pibAddImage
            // 
            this.pibAddImage.BackColor = System.Drawing.Color.Transparent;
            this.pibAddImage.BaseColor = System.Drawing.Color.White;
            this.pibAddImage.Image = global::BankSystemProjectWinfosForm.Properties.Resources.image_;
            this.pibAddImage.Location = new System.Drawing.Point(800, 359);
            this.pibAddImage.Name = "pibAddImage";
            this.pibAddImage.Radius = 25;
            this.pibAddImage.Size = new System.Drawing.Size(61, 50);
            this.pibAddImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibAddImage.TabIndex = 32;
            this.pibAddImage.TabStop = false;
            this.toolTip1.SetToolTip(this.pibAddImage, "Add ImagePath");
            this.pibAddImage.Click += new System.EventHandler(this.pibAddImage_Click);
            // 
            // pibClientImage
            // 
            this.pibClientImage.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.pibClientImage.BackColor = System.Drawing.Color.Transparent;
            this.pibClientImage.BaseColor = System.Drawing.Color.White;
            this.pibClientImage.Location = new System.Drawing.Point(773, 163);
            this.pibClientImage.Name = "pibClientImage";
            this.pibClientImage.Radius = 70;
            this.pibClientImage.Size = new System.Drawing.Size(201, 178);
            this.pibClientImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibClientImage.TabIndex = 31;
            this.pibClientImage.TabStop = false;
            // 
            // dtpDateOfBrith
            // 
            this.dtpDateOfBrith.BackColor = System.Drawing.Color.Transparent;
            this.dtpDateOfBrith.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dtpDateOfBrith.BaseColor = System.Drawing.Color.Gainsboro;
            this.dtpDateOfBrith.BorderColor = System.Drawing.Color.Silver;
            this.dtpDateOfBrith.CustomFormat = null;
            this.dtpDateOfBrith.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDateOfBrith.FocusedColor = System.Drawing.Color.Gainsboro;
            this.dtpDateOfBrith.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDateOfBrith.ForeColor = System.Drawing.Color.Black;
            this.dtpDateOfBrith.Location = new System.Drawing.Point(480, 437);
            this.dtpDateOfBrith.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDateOfBrith.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDateOfBrith.Name = "dtpDateOfBrith";
            this.dtpDateOfBrith.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpDateOfBrith.OnHoverBorderColor = System.Drawing.Color.DarkSlateGray;
            this.dtpDateOfBrith.OnHoverForeColor = System.Drawing.Color.DarkSlateGray;
            this.dtpDateOfBrith.OnPressedColor = System.Drawing.Color.Black;
            this.dtpDateOfBrith.Radius = 15;
            this.dtpDateOfBrith.Size = new System.Drawing.Size(287, 50);
            this.dtpDateOfBrith.TabIndex = 30;
            this.dtpDateOfBrith.Text = "Wednesday, 3 September 2025";
            this.dtpDateOfBrith.Value = new System.DateTime(2025, 9, 3, 0, 7, 5, 301);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.gunaLabel6.Location = new System.Drawing.Point(487, 406);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(127, 25);
            this.gunaLabel6.TabIndex = 29;
            this.gunaLabel6.Text = "Date Of Brith";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.gunaLabel7.Location = new System.Drawing.Point(148, 406);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(83, 25);
            this.gunaLabel7.TabIndex = 27;
            this.gunaLabel7.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtAddress.BaseColor = System.Drawing.Color.White;
            this.txtAddress.BorderColor = System.Drawing.Color.Silver;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAddress.FocusedBorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtAddress.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtAddress.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtAddress.Location = new System.Drawing.Point(141, 437);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.Radius = 15;
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(287, 50);
            this.txtAddress.TabIndex = 26;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.Location = new System.Drawing.Point(487, 304);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(69, 25);
            this.gunaLabel4.TabIndex = 25;
            this.gunaLabel4.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtPhone.BaseColor = System.Drawing.Color.White;
            this.txtPhone.BorderColor = System.Drawing.Color.Silver;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPhone.FocusedBorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtPhone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPhone.Location = new System.Drawing.Point(480, 335);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.Radius = 15;
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(287, 50);
            this.txtPhone.TabIndex = 24;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.gunaLabel5.Location = new System.Drawing.Point(148, 304);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(59, 25);
            this.gunaLabel5.TabIndex = 23;
            this.gunaLabel5.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BaseColor = System.Drawing.Color.White;
            this.txtEmail.BorderColor = System.Drawing.Color.Silver;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEmail.FocusedBorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtEmail.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtEmail.Location = new System.Drawing.Point(141, 335);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.Radius = 15;
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(287, 50);
            this.txtEmail.TabIndex = 22;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.Location = new System.Drawing.Point(487, 205);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(99, 25);
            this.gunaLabel3.TabIndex = 21;
            this.gunaLabel3.Text = "LastName";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.Transparent;
            this.txtLastName.BaseColor = System.Drawing.Color.White;
            this.txtLastName.BorderColor = System.Drawing.Color.Silver;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtLastName.FocusedBorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtLastName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtLastName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtLastName.Location = new System.Drawing.Point(480, 236);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.Radius = 15;
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(287, 50);
            this.txtLastName.TabIndex = 20;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.Location = new System.Drawing.Point(148, 205);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(102, 25);
            this.gunaLabel2.TabIndex = 19;
            this.gunaLabel2.Text = "FirstName";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.Transparent;
            this.txtFirstName.BaseColor = System.Drawing.Color.White;
            this.txtFirstName.BorderColor = System.Drawing.Color.Silver;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFirstName.FocusedBorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtFirstName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtFirstName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtFirstName.Location = new System.Drawing.Point(141, 236);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.Radius = 15;
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(287, 50);
            this.txtFirstName.TabIndex = 18;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAddNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 628);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddNewClient";
            this.Text = "frmAddNewClient";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibRemoveImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibAddImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibClientImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaTextBox txtAddress;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtPhone;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox txtEmail;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox txtLastName;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtFirstName;
        private Guna.UI.WinForms.GunaDateTimePicker dtpDateOfBrith;
        private Guna.UI.WinForms.GunaPictureBox pibAddImage;
        private Guna.UI.WinForms.GunaPictureBox pibClientImage;
        private Guna.UI.WinForms.GunaPictureBox pibRemoveImage;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI.WinForms.GunaButton btnAddNewClient;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI2.WinForms.Guna2Button btnBack;
    }
}