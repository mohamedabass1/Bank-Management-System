namespace BankSystemProjectWinfosForm
{
    partial class frmUpdateUser
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.pictUserImage = new Guna.UI.WinForms.GunaPictureBox();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictRemoveUserImage = new System.Windows.Forms.PictureBox();
            this.picAddUserImge = new System.Windows.Forms.PictureBox();
            this.txtPermissions = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictFindUser = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtUserIDToFind = new Guna.UI2.WinForms.Guna2TextBox();
            this.chboxPmanageTransaction = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.chboxPmanageLoginRegister = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.labFullPermissions = new System.Windows.Forms.Label();
            this.chboxFullPermissions = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.labPmanageLoginRegister = new System.Windows.Forms.Label();
            this.labPmanageTransaction = new System.Windows.Forms.Label();
            this.labPmanageUser = new System.Windows.Forms.Label();
            this.chboxPmanageUser = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.labPmanageAccounts = new System.Windows.Forms.Label();
            this.chboxPmanageAccounts = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.labPermissionsTitle = new System.Windows.Forms.Label();
            this.labPmanageClient = new System.Windows.Forms.Label();
            this.chboxPmanageClient = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateUser = new Guna.UI2.WinForms.Guna2Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictUserImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictRemoveUserImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddUserImge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictFindUser)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(61, 65);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(248, 52);
            this.gunaLabel1.TabIndex = 88;
            this.gunaLabel1.Text = "Update User";
            // 
            // pictUserImage
            // 
            this.pictUserImage.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.pictUserImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictUserImage.BackColor = System.Drawing.Color.Transparent;
            this.pictUserImage.BaseColor = System.Drawing.Color.White;
            this.pictUserImage.Location = new System.Drawing.Point(912, 201);
            this.pictUserImage.Name = "pictUserImage";
            this.pictUserImage.Radius = 70;
            this.pictUserImage.Size = new System.Drawing.Size(201, 178);
            this.pictUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictUserImage.TabIndex = 150;
            this.pictUserImage.TabStop = false;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone.Animated = true;
            this.txtPhone.BorderRadius = 10;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Location = new System.Drawing.Point(545, 390);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PlaceholderText = "Phone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(336, 76);
            this.txtPhone.TabIndex = 149;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Animated = true;
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(545, 202);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(336, 76);
            this.txtPassword.TabIndex = 148;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Animated = true;
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(163, 390);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(336, 76);
            this.txtEmail.TabIndex = 147;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserName.Animated = true;
            this.txtUserName.BorderRadius = 10;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Location = new System.Drawing.Point(163, 202);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PlaceholderText = "UserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(336, 76);
            this.txtUserName.TabIndex = 146;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastName.Animated = true;
            this.txtLastName.BorderRadius = 10;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.DefaultText = "";
            this.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Location = new System.Drawing.Point(545, 296);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PlaceholderText = "LastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(336, 76);
            this.txtLastName.TabIndex = 145;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstName.Animated = true;
            this.txtFirstName.BorderRadius = 10;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.DefaultText = "";
            this.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Location = new System.Drawing.Point(163, 296);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PlaceholderText = "FirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(336, 76);
            this.txtFirstName.TabIndex = 144;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictRemoveUserImage
            // 
            this.pictRemoveUserImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictRemoveUserImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictRemoveUserImage.Image = global::BankSystemProjectWinfosForm.Properties.Resources.deleteimage_;
            this.pictRemoveUserImage.Location = new System.Drawing.Point(1014, 399);
            this.pictRemoveUserImage.Margin = new System.Windows.Forms.Padding(4);
            this.pictRemoveUserImage.Name = "pictRemoveUserImage";
            this.pictRemoveUserImage.Size = new System.Drawing.Size(48, 49);
            this.pictRemoveUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictRemoveUserImage.TabIndex = 143;
            this.pictRemoveUserImage.TabStop = false;
            this.pictRemoveUserImage.Visible = false;
            this.pictRemoveUserImage.Click += new System.EventHandler(this.pictRemoveUserImage_Click);
            // 
            // picAddUserImge
            // 
            this.picAddUserImge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picAddUserImge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAddUserImge.Image = global::BankSystemProjectWinfosForm.Properties.Resources.image_;
            this.picAddUserImge.Location = new System.Drawing.Point(937, 399);
            this.picAddUserImge.Margin = new System.Windows.Forms.Padding(4);
            this.picAddUserImge.Name = "picAddUserImge";
            this.picAddUserImge.Size = new System.Drawing.Size(48, 49);
            this.picAddUserImge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAddUserImge.TabIndex = 142;
            this.picAddUserImge.TabStop = false;
            this.picAddUserImge.Click += new System.EventHandler(this.picAddUserImge_Click);
            // 
            // txtPermissions
            // 
            this.txtPermissions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPermissions.Animated = true;
            this.txtPermissions.BorderRadius = 10;
            this.txtPermissions.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPermissions.DefaultText = "";
            this.txtPermissions.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPermissions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPermissions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPermissions.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPermissions.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPermissions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtPermissions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPermissions.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPermissions.Location = new System.Drawing.Point(545, 488);
            this.txtPermissions.Margin = new System.Windows.Forms.Padding(5);
            this.txtPermissions.Name = "txtPermissions";
            this.txtPermissions.PasswordChar = '\0';
            this.txtPermissions.PlaceholderText = "Permissions";
            this.txtPermissions.ReadOnly = true;
            this.txtPermissions.SelectedText = "";
            this.txtPermissions.Size = new System.Drawing.Size(336, 76);
            this.txtPermissions.TabIndex = 151;
            this.txtPermissions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictFindUser
            // 
            this.pictFindUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictFindUser.BackColor = System.Drawing.Color.Transparent;
            this.pictFindUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictFindUser.Image = global::BankSystemProjectWinfosForm.Properties.Resources.FindClientIcon;
            this.pictFindUser.ImageRotate = 0F;
            this.pictFindUser.Location = new System.Drawing.Point(653, 126);
            this.pictFindUser.Margin = new System.Windows.Forms.Padding(4);
            this.pictFindUser.Name = "pictFindUser";
            this.pictFindUser.Size = new System.Drawing.Size(43, 52);
            this.pictFindUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictFindUser.TabIndex = 153;
            this.pictFindUser.TabStop = false;
            this.pictFindUser.UseTransparentBackground = true;
            this.pictFindUser.Click += new System.EventHandler(this.pictFindUser_Click);
            // 
            // txtUserIDToFind
            // 
            this.txtUserIDToFind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserIDToFind.Animated = true;
            this.txtUserIDToFind.BorderRadius = 10;
            this.txtUserIDToFind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserIDToFind.DefaultText = "";
            this.txtUserIDToFind.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserIDToFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserIDToFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserIDToFind.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserIDToFind.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserIDToFind.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserIDToFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserIDToFind.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserIDToFind.Location = new System.Drawing.Point(443, 126);
            this.txtUserIDToFind.Margin = new System.Windows.Forms.Padding(5);
            this.txtUserIDToFind.Name = "txtUserIDToFind";
            this.txtUserIDToFind.PasswordChar = '\0';
            this.txtUserIDToFind.PlaceholderText = "UserID";
            this.txtUserIDToFind.SelectedText = "";
            this.txtUserIDToFind.Size = new System.Drawing.Size(202, 58);
            this.txtUserIDToFind.TabIndex = 152;
            this.txtUserIDToFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chboxPmanageTransaction
            // 
            this.chboxPmanageTransaction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chboxPmanageTransaction.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chboxPmanageTransaction.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chboxPmanageTransaction.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.chboxPmanageTransaction.CheckedState.InnerColor = System.Drawing.Color.White;
            this.chboxPmanageTransaction.Location = new System.Drawing.Point(644, 600);
            this.chboxPmanageTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.chboxPmanageTransaction.Name = "chboxPmanageTransaction";
            this.chboxPmanageTransaction.Size = new System.Drawing.Size(41, 25);
            this.chboxPmanageTransaction.TabIndex = 166;
            this.chboxPmanageTransaction.Tag = "8";
            this.chboxPmanageTransaction.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chboxPmanageTransaction.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chboxPmanageTransaction.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.chboxPmanageTransaction.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // chboxPmanageLoginRegister
            // 
            this.chboxPmanageLoginRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chboxPmanageLoginRegister.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chboxPmanageLoginRegister.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chboxPmanageLoginRegister.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.chboxPmanageLoginRegister.CheckedState.InnerColor = System.Drawing.Color.White;
            this.chboxPmanageLoginRegister.Location = new System.Drawing.Point(644, 637);
            this.chboxPmanageLoginRegister.Margin = new System.Windows.Forms.Padding(4);
            this.chboxPmanageLoginRegister.Name = "chboxPmanageLoginRegister";
            this.chboxPmanageLoginRegister.Size = new System.Drawing.Size(41, 25);
            this.chboxPmanageLoginRegister.TabIndex = 165;
            this.chboxPmanageLoginRegister.Tag = "16";
            this.chboxPmanageLoginRegister.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chboxPmanageLoginRegister.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chboxPmanageLoginRegister.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.chboxPmanageLoginRegister.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // labFullPermissions
            // 
            this.labFullPermissions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labFullPermissions.AutoSize = true;
            this.labFullPermissions.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labFullPermissions.ForeColor = System.Drawing.Color.Firebrick;
            this.labFullPermissions.Location = new System.Drawing.Point(167, 530);
            this.labFullPermissions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labFullPermissions.Name = "labFullPermissions";
            this.labFullPermissions.Size = new System.Drawing.Size(173, 24);
            this.labFullPermissions.TabIndex = 164;
            this.labFullPermissions.Text = "Full Permissions";
            // 
            // chboxFullPermissions
            // 
            this.chboxFullPermissions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chboxFullPermissions.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chboxFullPermissions.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chboxFullPermissions.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.chboxFullPermissions.CheckedState.InnerColor = System.Drawing.Color.White;
            this.chboxFullPermissions.Location = new System.Drawing.Point(357, 528);
            this.chboxFullPermissions.Margin = new System.Windows.Forms.Padding(4);
            this.chboxFullPermissions.Name = "chboxFullPermissions";
            this.chboxFullPermissions.Size = new System.Drawing.Size(41, 25);
            this.chboxFullPermissions.TabIndex = 163;
            this.chboxFullPermissions.Tag = "-1";
            this.chboxFullPermissions.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chboxFullPermissions.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chboxFullPermissions.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.chboxFullPermissions.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // labPmanageLoginRegister
            // 
            this.labPmanageLoginRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labPmanageLoginRegister.AutoSize = true;
            this.labPmanageLoginRegister.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labPmanageLoginRegister.Location = new System.Drawing.Point(431, 637);
            this.labPmanageLoginRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPmanageLoginRegister.Name = "labPmanageLoginRegister";
            this.labPmanageLoginRegister.Size = new System.Drawing.Size(156, 24);
            this.labPmanageLoginRegister.TabIndex = 162;
            this.labPmanageLoginRegister.Text = "Login Register";
            // 
            // labPmanageTransaction
            // 
            this.labPmanageTransaction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labPmanageTransaction.AutoSize = true;
            this.labPmanageTransaction.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labPmanageTransaction.Location = new System.Drawing.Point(431, 600);
            this.labPmanageTransaction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPmanageTransaction.Name = "labPmanageTransaction";
            this.labPmanageTransaction.Size = new System.Drawing.Size(214, 24);
            this.labPmanageTransaction.TabIndex = 161;
            this.labPmanageTransaction.Text = "Manage Transaction";
            // 
            // labPmanageUser
            // 
            this.labPmanageUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labPmanageUser.AutoSize = true;
            this.labPmanageUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labPmanageUser.Location = new System.Drawing.Point(167, 635);
            this.labPmanageUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPmanageUser.Name = "labPmanageUser";
            this.labPmanageUser.Size = new System.Drawing.Size(142, 24);
            this.labPmanageUser.TabIndex = 160;
            this.labPmanageUser.Text = "Manage User";
            // 
            // chboxPmanageUser
            // 
            this.chboxPmanageUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chboxPmanageUser.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chboxPmanageUser.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chboxPmanageUser.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.chboxPmanageUser.CheckedState.InnerColor = System.Drawing.Color.White;
            this.chboxPmanageUser.Location = new System.Drawing.Point(357, 637);
            this.chboxPmanageUser.Margin = new System.Windows.Forms.Padding(4);
            this.chboxPmanageUser.Name = "chboxPmanageUser";
            this.chboxPmanageUser.Size = new System.Drawing.Size(41, 23);
            this.chboxPmanageUser.TabIndex = 159;
            this.chboxPmanageUser.Tag = "4";
            this.chboxPmanageUser.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chboxPmanageUser.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chboxPmanageUser.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.chboxPmanageUser.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // labPmanageAccounts
            // 
            this.labPmanageAccounts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labPmanageAccounts.AutoSize = true;
            this.labPmanageAccounts.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labPmanageAccounts.Location = new System.Drawing.Point(167, 600);
            this.labPmanageAccounts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPmanageAccounts.Name = "labPmanageAccounts";
            this.labPmanageAccounts.Size = new System.Drawing.Size(188, 24);
            this.labPmanageAccounts.TabIndex = 158;
            this.labPmanageAccounts.Text = "Manage Accounts";
            // 
            // chboxPmanageAccounts
            // 
            this.chboxPmanageAccounts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chboxPmanageAccounts.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chboxPmanageAccounts.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chboxPmanageAccounts.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.chboxPmanageAccounts.CheckedState.InnerColor = System.Drawing.Color.White;
            this.chboxPmanageAccounts.Location = new System.Drawing.Point(357, 600);
            this.chboxPmanageAccounts.Margin = new System.Windows.Forms.Padding(4);
            this.chboxPmanageAccounts.Name = "chboxPmanageAccounts";
            this.chboxPmanageAccounts.Size = new System.Drawing.Size(41, 25);
            this.chboxPmanageAccounts.TabIndex = 157;
            this.chboxPmanageAccounts.Tag = "2";
            this.chboxPmanageAccounts.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chboxPmanageAccounts.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chboxPmanageAccounts.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.chboxPmanageAccounts.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // labPermissionsTitle
            // 
            this.labPermissionsTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labPermissionsTitle.AutoSize = true;
            this.labPermissionsTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labPermissionsTitle.ForeColor = System.Drawing.Color.Red;
            this.labPermissionsTitle.Location = new System.Drawing.Point(167, 495);
            this.labPermissionsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPermissionsTitle.Name = "labPermissionsTitle";
            this.labPermissionsTitle.Size = new System.Drawing.Size(130, 24);
            this.labPermissionsTitle.TabIndex = 156;
            this.labPermissionsTitle.Text = "Permissions";
            // 
            // labPmanageClient
            // 
            this.labPmanageClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labPmanageClient.AutoSize = true;
            this.labPmanageClient.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labPmanageClient.Location = new System.Drawing.Point(167, 565);
            this.labPmanageClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPmanageClient.Name = "labPmanageClient";
            this.labPmanageClient.Size = new System.Drawing.Size(154, 24);
            this.labPmanageClient.TabIndex = 155;
            this.labPmanageClient.Text = "Manage Client";
            // 
            // chboxPmanageClient
            // 
            this.chboxPmanageClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chboxPmanageClient.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chboxPmanageClient.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chboxPmanageClient.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.chboxPmanageClient.CheckedState.InnerColor = System.Drawing.Color.White;
            this.chboxPmanageClient.Location = new System.Drawing.Point(357, 565);
            this.chboxPmanageClient.Margin = new System.Windows.Forms.Padding(4);
            this.chboxPmanageClient.Name = "chboxPmanageClient";
            this.chboxPmanageClient.Size = new System.Drawing.Size(41, 23);
            this.chboxPmanageClient.TabIndex = 154;
            this.chboxPmanageClient.Tag = "1";
            this.chboxPmanageClient.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chboxPmanageClient.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chboxPmanageClient.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.chboxPmanageClient.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btnBack.Image = global::BankSystemProjectWinfosForm.Properties.Resources.back;
            this.btnBack.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBack.Location = new System.Drawing.Point(144, 705);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(197, 54);
            this.btnBack.TabIndex = 167;
            this.btnBack.Text = "Back";
            this.btnBack.UseTransparentBackground = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateUser.Animated = true;
            this.btnUpdateUser.AutoRoundedCorners = true;
            this.btnUpdateUser.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateUser.BorderRadius = 26;
            this.btnUpdateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdateUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdateUser.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateUser.Location = new System.Drawing.Point(774, 705);
            this.btnUpdateUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(222, 54);
            this.btnUpdateUser.TabIndex = 168;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.UseTransparentBackground = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // frmUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 849);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.chboxPmanageTransaction);
            this.Controls.Add(this.chboxPmanageLoginRegister);
            this.Controls.Add(this.labFullPermissions);
            this.Controls.Add(this.chboxFullPermissions);
            this.Controls.Add(this.labPmanageLoginRegister);
            this.Controls.Add(this.labPmanageTransaction);
            this.Controls.Add(this.labPmanageUser);
            this.Controls.Add(this.chboxPmanageUser);
            this.Controls.Add(this.labPmanageAccounts);
            this.Controls.Add(this.chboxPmanageAccounts);
            this.Controls.Add(this.labPermissionsTitle);
            this.Controls.Add(this.labPmanageClient);
            this.Controls.Add(this.chboxPmanageClient);
            this.Controls.Add(this.pictFindUser);
            this.Controls.Add(this.txtUserIDToFind);
            this.Controls.Add(this.txtPermissions);
            this.Controls.Add(this.pictUserImage);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.pictRemoveUserImage);
            this.Controls.Add(this.picAddUserImge);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUpdateUser";
            this.Text = "frmUpdateUser";
            ((System.ComponentModel.ISupportInitialize)(this.pictUserImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictRemoveUserImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddUserImge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictFindUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPictureBox pictUserImage;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private System.Windows.Forms.PictureBox pictRemoveUserImage;
        private System.Windows.Forms.PictureBox picAddUserImge;
        private Guna.UI2.WinForms.Guna2TextBox txtPermissions;
        private Guna.UI2.WinForms.Guna2PictureBox pictFindUser;
        private Guna.UI2.WinForms.Guna2TextBox txtUserIDToFind;
        private Guna.UI2.WinForms.Guna2ToggleSwitch chboxPmanageTransaction;
        private Guna.UI2.WinForms.Guna2ToggleSwitch chboxPmanageLoginRegister;
        private System.Windows.Forms.Label labFullPermissions;
        private Guna.UI2.WinForms.Guna2ToggleSwitch chboxFullPermissions;
        private System.Windows.Forms.Label labPmanageLoginRegister;
        private System.Windows.Forms.Label labPmanageTransaction;
        private System.Windows.Forms.Label labPmanageUser;
        private Guna.UI2.WinForms.Guna2ToggleSwitch chboxPmanageUser;
        private System.Windows.Forms.Label labPmanageAccounts;
        private Guna.UI2.WinForms.Guna2ToggleSwitch chboxPmanageAccounts;
        private System.Windows.Forms.Label labPermissionsTitle;
        private System.Windows.Forms.Label labPmanageClient;
        private Guna.UI2.WinForms.Guna2ToggleSwitch chboxPmanageClient;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnUpdateUser;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}