namespace BankSystemProjectWinfosForm

{
    partial class frmAddNewUser
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
            this.pictRemoveUserImage = new System.Windows.Forms.PictureBox();
            this.picAddUserImge = new System.Windows.Forms.PictureBox();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.btnAddNewUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictUserImage = new Guna.UI.WinForms.GunaPictureBox();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictRemoveUserImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddUserImge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(112, 65);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(284, 52);
            this.gunaLabel1.TabIndex = 88;
            this.gunaLabel1.Text = "Add New User";
            // 
            // pictRemoveUserImage
            // 
            this.pictRemoveUserImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictRemoveUserImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictRemoveUserImage.Image = global::BankSystemProjectWinfosForm.Properties.Resources.deleteimage_;
            this.pictRemoveUserImage.Location = new System.Drawing.Point(977, 377);
            this.pictRemoveUserImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictRemoveUserImage.Name = "pictRemoveUserImage";
            this.pictRemoveUserImage.Size = new System.Drawing.Size(48, 49);
            this.pictRemoveUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictRemoveUserImage.TabIndex = 90;
            this.pictRemoveUserImage.TabStop = false;
            this.pictRemoveUserImage.Click += new System.EventHandler(this.pictRemoveUserImage_Click);
            // 
            // picAddUserImge
            // 
            this.picAddUserImge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picAddUserImge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAddUserImge.Image = global::BankSystemProjectWinfosForm.Properties.Resources.image_;
            this.picAddUserImge.Location = new System.Drawing.Point(900, 377);
            this.picAddUserImge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picAddUserImge.Name = "picAddUserImge";
            this.picAddUserImge.Size = new System.Drawing.Size(48, 49);
            this.picAddUserImge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAddUserImge.TabIndex = 89;
            this.picAddUserImge.TabStop = false;
            this.picAddUserImge.Click += new System.EventHandler(this.picAddUserImge_Click);
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
            this.txtPhone.Location = new System.Drawing.Point(503, 342);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PlaceholderText = "Phone";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(336, 76);
            this.txtPhone.TabIndex = 116;
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
            this.txtPassword.Location = new System.Drawing.Point(503, 154);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(336, 76);
            this.txtPassword.TabIndex = 115;
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
            this.txtEmail.Location = new System.Drawing.Point(121, 342);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(336, 76);
            this.txtEmail.TabIndex = 114;
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
            this.txtUserName.Location = new System.Drawing.Point(121, 154);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PlaceholderText = "UserName";
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(336, 76);
            this.txtUserName.TabIndex = 112;
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
            this.txtLastName.Location = new System.Drawing.Point(503, 248);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PlaceholderText = "LastName";
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(336, 76);
            this.txtLastName.TabIndex = 111;
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
            this.txtFirstName.Location = new System.Drawing.Point(121, 248);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PlaceholderText = "FirstName";
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(336, 76);
            this.txtFirstName.TabIndex = 110;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chboxPmanageTransaction
            // 
            this.chboxPmanageTransaction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chboxPmanageTransaction.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chboxPmanageTransaction.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chboxPmanageTransaction.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.chboxPmanageTransaction.CheckedState.InnerColor = System.Drawing.Color.White;
            this.chboxPmanageTransaction.Location = new System.Drawing.Point(639, 487);
            this.chboxPmanageTransaction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chboxPmanageTransaction.Name = "chboxPmanageTransaction";
            this.chboxPmanageTransaction.Size = new System.Drawing.Size(41, 25);
            this.chboxPmanageTransaction.TabIndex = 140;
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
            this.chboxPmanageLoginRegister.Location = new System.Drawing.Point(639, 524);
            this.chboxPmanageLoginRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chboxPmanageLoginRegister.Name = "chboxPmanageLoginRegister";
            this.chboxPmanageLoginRegister.Size = new System.Drawing.Size(41, 25);
            this.chboxPmanageLoginRegister.TabIndex = 139;
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
            this.labFullPermissions.Location = new System.Drawing.Point(124, 489);
            this.labFullPermissions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labFullPermissions.Name = "labFullPermissions";
            this.labFullPermissions.Size = new System.Drawing.Size(173, 24);
            this.labFullPermissions.TabIndex = 138;
            this.labFullPermissions.Text = "Full Permissions";
            // 
            // chboxFullPermissions
            // 
            this.chboxFullPermissions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chboxFullPermissions.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chboxFullPermissions.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chboxFullPermissions.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.chboxFullPermissions.CheckedState.InnerColor = System.Drawing.Color.White;
            this.chboxFullPermissions.Location = new System.Drawing.Point(314, 488);
            this.chboxFullPermissions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chboxFullPermissions.Name = "chboxFullPermissions";
            this.chboxFullPermissions.Size = new System.Drawing.Size(41, 25);
            this.chboxFullPermissions.TabIndex = 137;
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
            this.labPmanageLoginRegister.Location = new System.Drawing.Point(426, 524);
            this.labPmanageLoginRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPmanageLoginRegister.Name = "labPmanageLoginRegister";
            this.labPmanageLoginRegister.Size = new System.Drawing.Size(156, 24);
            this.labPmanageLoginRegister.TabIndex = 136;
            this.labPmanageLoginRegister.Text = "Login Register";
            // 
            // labPmanageTransaction
            // 
            this.labPmanageTransaction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labPmanageTransaction.AutoSize = true;
            this.labPmanageTransaction.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labPmanageTransaction.Location = new System.Drawing.Point(426, 487);
            this.labPmanageTransaction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPmanageTransaction.Name = "labPmanageTransaction";
            this.labPmanageTransaction.Size = new System.Drawing.Size(214, 24);
            this.labPmanageTransaction.TabIndex = 135;
            this.labPmanageTransaction.Text = "Manage Transaction";
            // 
            // labPmanageUser
            // 
            this.labPmanageUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labPmanageUser.AutoSize = true;
            this.labPmanageUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labPmanageUser.Location = new System.Drawing.Point(124, 597);
            this.labPmanageUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPmanageUser.Name = "labPmanageUser";
            this.labPmanageUser.Size = new System.Drawing.Size(142, 24);
            this.labPmanageUser.TabIndex = 134;
            this.labPmanageUser.Text = "Manage User";
            // 
            // chboxPmanageUser
            // 
            this.chboxPmanageUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chboxPmanageUser.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chboxPmanageUser.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chboxPmanageUser.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.chboxPmanageUser.CheckedState.InnerColor = System.Drawing.Color.White;
            this.chboxPmanageUser.Location = new System.Drawing.Point(314, 597);
            this.chboxPmanageUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chboxPmanageUser.Name = "chboxPmanageUser";
            this.chboxPmanageUser.Size = new System.Drawing.Size(41, 23);
            this.chboxPmanageUser.TabIndex = 133;
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
            this.labPmanageAccounts.Location = new System.Drawing.Point(124, 561);
            this.labPmanageAccounts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPmanageAccounts.Name = "labPmanageAccounts";
            this.labPmanageAccounts.Size = new System.Drawing.Size(188, 24);
            this.labPmanageAccounts.TabIndex = 130;
            this.labPmanageAccounts.Text = "Manage Accounts";
            // 
            // chboxPmanageAccounts
            // 
            this.chboxPmanageAccounts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chboxPmanageAccounts.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chboxPmanageAccounts.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chboxPmanageAccounts.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.chboxPmanageAccounts.CheckedState.InnerColor = System.Drawing.Color.White;
            this.chboxPmanageAccounts.Location = new System.Drawing.Point(314, 560);
            this.chboxPmanageAccounts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chboxPmanageAccounts.Name = "chboxPmanageAccounts";
            this.chboxPmanageAccounts.Size = new System.Drawing.Size(41, 25);
            this.chboxPmanageAccounts.TabIndex = 129;
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
            this.labPermissionsTitle.Location = new System.Drawing.Point(124, 454);
            this.labPermissionsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPermissionsTitle.Name = "labPermissionsTitle";
            this.labPermissionsTitle.Size = new System.Drawing.Size(130, 24);
            this.labPermissionsTitle.TabIndex = 128;
            this.labPermissionsTitle.Text = "Permissions";
            // 
            // labPmanageClient
            // 
            this.labPmanageClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labPmanageClient.AutoSize = true;
            this.labPmanageClient.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labPmanageClient.Location = new System.Drawing.Point(124, 526);
            this.labPmanageClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPmanageClient.Name = "labPmanageClient";
            this.labPmanageClient.Size = new System.Drawing.Size(154, 24);
            this.labPmanageClient.TabIndex = 127;
            this.labPmanageClient.Text = "Manage Client";
            // 
            // chboxPmanageClient
            // 
            this.chboxPmanageClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chboxPmanageClient.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chboxPmanageClient.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chboxPmanageClient.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.chboxPmanageClient.CheckedState.InnerColor = System.Drawing.Color.White;
            this.chboxPmanageClient.Location = new System.Drawing.Point(314, 526);
            this.chboxPmanageClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chboxPmanageClient.Name = "chboxPmanageClient";
            this.chboxPmanageClient.Size = new System.Drawing.Size(41, 23);
            this.chboxPmanageClient.TabIndex = 126;
            this.chboxPmanageClient.Tag = "1";
            this.chboxPmanageClient.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chboxPmanageClient.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chboxPmanageClient.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.chboxPmanageClient.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddNewUser.Animated = true;
            this.btnAddNewUser.AutoRoundedCorners = true;
            this.btnAddNewUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewUser.BorderRadius = 26;
            this.btnAddNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddNewUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddNewUser.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNewUser.Location = new System.Drawing.Point(726, 654);
            this.btnAddNewUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(222, 54);
            this.btnAddNewUser.TabIndex = 125;
            this.btnAddNewUser.Text = "Add New User";
            this.btnAddNewUser.UseTransparentBackground = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
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
            this.btnBack.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBack.Location = new System.Drawing.Point(128, 654);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(197, 54);
            this.btnBack.TabIndex = 124;
            this.btnBack.Text = "Back";
            this.btnBack.UseTransparentBackground = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictUserImage
            // 
            this.pictUserImage.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.pictUserImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictUserImage.BackColor = System.Drawing.Color.Transparent;
            this.pictUserImage.BaseColor = System.Drawing.Color.White;
            this.pictUserImage.Location = new System.Drawing.Point(869, 146);
            this.pictUserImage.Name = "pictUserImage";
            this.pictUserImage.Radius = 70;
            this.pictUserImage.Size = new System.Drawing.Size(201, 178);
            this.pictUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictUserImage.TabIndex = 141;
            this.pictUserImage.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.Animated = true;
            this.btnClear.AutoRoundedCorners = true;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BorderRadius = 26;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClear.Location = new System.Drawing.Point(463, 654);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(147, 54);
            this.btnClear.TabIndex = 142;
            this.btnClear.Text = "Clear";
            this.btnClear.UseTransparentBackground = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 787);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pictUserImage);
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
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.btnBack);
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
            this.Name = "frmAddNewUser";
            this.Text = "frmAddNewUser";
            ((System.ComponentModel.ISupportInitialize)(this.pictRemoveUserImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddUserImge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictUserImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.PictureBox pictRemoveUserImage;
        private System.Windows.Forms.PictureBox picAddUserImge;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
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
        private Guna.UI2.WinForms.Guna2Button btnAddNewUser;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI.WinForms.GunaPictureBox pictUserImage;
        private Guna.UI2.WinForms.Guna2Button btnClear;
    }
}