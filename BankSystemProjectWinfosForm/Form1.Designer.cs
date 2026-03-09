namespace BankSystemProjectWinfosForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblCurrentUserName = new System.Windows.Forms.Label();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnManageAccounts = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageLoginRegister = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageTransactionScreen = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageClients = new Guna.UI2.WinForms.Guna2Button();
            this.pictCurrentUserImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.picBoxMinimized = new System.Windows.Forms.PictureBox();
            this.mainPanal = new Guna.UI.WinForms.GunaPanel();
            this.LabUser = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictCurrentUserImage)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimized)).BeginInit();
            this.mainPanal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurrentUserName
            // 
            this.lblCurrentUserName.AutoSize = true;
            this.lblCurrentUserName.Font = new System.Drawing.Font("Roboto Slab", 11F, System.Drawing.FontStyle.Bold);
            this.lblCurrentUserName.ForeColor = System.Drawing.Color.Transparent;
            this.lblCurrentUserName.Location = new System.Drawing.Point(86, 215);
            this.lblCurrentUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentUserName.Name = "lblCurrentUserName";
            this.lblCurrentUserName.Size = new System.Drawing.Size(68, 26);
            this.lblCurrentUserName.TabIndex = 11;
            this.lblCurrentUserName.Text = "[?????]";
            // 
            // guna2Button5
            // 
            this.guna2Button5.Animated = true;
            this.guna2Button5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button5.ForeColor = System.Drawing.Color.Black;
            this.guna2Button5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button5.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button5.IndicateFocus = true;
            this.guna2Button5.Location = new System.Drawing.Point(1149, 1);
            this.guna2Button5.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(57, 51);
            this.guna2Button5.TabIndex = 10;
            this.guna2Button5.Text = "X";
            this.guna2Button5.UseTransparentBackground = true;
            this.guna2Button5.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.guna2Panel1.Controls.Add(this.lblDate);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.btnManageAccounts);
            this.guna2Panel1.Controls.Add(this.btnManageUsers);
            this.guna2Panel1.Controls.Add(this.btnManageLoginRegister);
            this.guna2Panel1.Controls.Add(this.lblCurrentUserName);
            this.guna2Panel1.Controls.Add(this.btnManageTransactionScreen);
            this.guna2Panel1.Controls.Add(this.btnManageClients);
            this.guna2Panel1.Controls.Add(this.pictCurrentUserImage);
            this.guna2Panel1.Controls.Add(this.btnLogout);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(288, 850);
            this.guna2Panel1.TabIndex = 13;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Roboto Slab", 14F);
            this.lblDate.Location = new System.Drawing.Point(12, 809);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(81, 32);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Slab", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "User: ";
            // 
            // btnManageAccounts
            // 
            this.btnManageAccounts.Animated = true;
            this.btnManageAccounts.BackColor = System.Drawing.Color.Transparent;
            this.btnManageAccounts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnManageAccounts.BorderRadius = 10;
            this.btnManageAccounts.BorderThickness = 2;
            this.btnManageAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageAccounts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageAccounts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageAccounts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageAccounts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageAccounts.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnManageAccounts.Font = new System.Drawing.Font("Roboto Slab", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnManageAccounts.ForeColor = System.Drawing.Color.Black;
            this.btnManageAccounts.Image = ((System.Drawing.Image)(resources.GetObject("btnManageAccounts.Image")));
            this.btnManageAccounts.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageAccounts.ImageSize = new System.Drawing.Size(48, 48);
            this.btnManageAccounts.IndicateFocus = true;
            this.btnManageAccounts.Location = new System.Drawing.Point(13, 362);
            this.btnManageAccounts.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageAccounts.Name = "btnManageAccounts";
            this.btnManageAccounts.Size = new System.Drawing.Size(265, 67);
            this.btnManageAccounts.TabIndex = 6;
            this.btnManageAccounts.Text = "Accounts";
            this.btnManageAccounts.UseTransparentBackground = true;
            this.btnManageAccounts.Click += new System.EventHandler(this.btnManageAccounts_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Animated = true;
            this.btnManageUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnManageUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnManageUsers.BorderRadius = 10;
            this.btnManageUsers.BorderThickness = 2;
            this.btnManageUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageUsers.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnManageUsers.Font = new System.Drawing.Font("Roboto Slab", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnManageUsers.ForeColor = System.Drawing.Color.Black;
            this.btnManageUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnManageUsers.Image")));
            this.btnManageUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageUsers.ImageSize = new System.Drawing.Size(48, 48);
            this.btnManageUsers.IndicateFocus = true;
            this.btnManageUsers.Location = new System.Drawing.Point(11, 454);
            this.btnManageUsers.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(267, 67);
            this.btnManageUsers.TabIndex = 7;
            this.btnManageUsers.Text = "Users";
            this.btnManageUsers.UseTransparentBackground = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnManageLoginRegister
            // 
            this.btnManageLoginRegister.Animated = true;
            this.btnManageLoginRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnManageLoginRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnManageLoginRegister.BorderRadius = 10;
            this.btnManageLoginRegister.BorderThickness = 2;
            this.btnManageLoginRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageLoginRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageLoginRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageLoginRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageLoginRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageLoginRegister.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnManageLoginRegister.Font = new System.Drawing.Font("Roboto Slab", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnManageLoginRegister.ForeColor = System.Drawing.Color.Black;
            this.btnManageLoginRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnManageLoginRegister.Image")));
            this.btnManageLoginRegister.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageLoginRegister.ImageSize = new System.Drawing.Size(40, 40);
            this.btnManageLoginRegister.IndicateFocus = true;
            this.btnManageLoginRegister.Location = new System.Drawing.Point(14, 638);
            this.btnManageLoginRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageLoginRegister.Name = "btnManageLoginRegister";
            this.btnManageLoginRegister.Size = new System.Drawing.Size(267, 67);
            this.btnManageLoginRegister.TabIndex = 12;
            this.btnManageLoginRegister.Text = "      Login Register";
            this.btnManageLoginRegister.UseTransparentBackground = true;
            this.btnManageLoginRegister.Click += new System.EventHandler(this.btnManageLoginRegister_Click);
            // 
            // btnManageTransactionScreen
            // 
            this.btnManageTransactionScreen.Animated = true;
            this.btnManageTransactionScreen.BackColor = System.Drawing.Color.Transparent;
            this.btnManageTransactionScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnManageTransactionScreen.BorderRadius = 10;
            this.btnManageTransactionScreen.BorderThickness = 2;
            this.btnManageTransactionScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageTransactionScreen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageTransactionScreen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageTransactionScreen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageTransactionScreen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageTransactionScreen.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnManageTransactionScreen.Font = new System.Drawing.Font("Roboto Slab", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnManageTransactionScreen.ForeColor = System.Drawing.Color.Black;
            this.btnManageTransactionScreen.Image = ((System.Drawing.Image)(resources.GetObject("btnManageTransactionScreen.Image")));
            this.btnManageTransactionScreen.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageTransactionScreen.ImageSize = new System.Drawing.Size(48, 48);
            this.btnManageTransactionScreen.IndicateFocus = true;
            this.btnManageTransactionScreen.Location = new System.Drawing.Point(11, 546);
            this.btnManageTransactionScreen.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageTransactionScreen.Name = "btnManageTransactionScreen";
            this.btnManageTransactionScreen.Size = new System.Drawing.Size(267, 67);
            this.btnManageTransactionScreen.TabIndex = 8;
            this.btnManageTransactionScreen.Text = "  Transaction";
            this.btnManageTransactionScreen.UseTransparentBackground = true;
            this.btnManageTransactionScreen.Click += new System.EventHandler(this.btnManageTransactionScreen_Click);
            // 
            // btnManageClients
            // 
            this.btnManageClients.Animated = true;
            this.btnManageClients.BackColor = System.Drawing.Color.Transparent;
            this.btnManageClients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnManageClients.BorderRadius = 10;
            this.btnManageClients.BorderThickness = 2;
            this.btnManageClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageClients.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageClients.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageClients.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageClients.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageClients.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnManageClients.FocusedColor = System.Drawing.Color.Transparent;
            this.btnManageClients.Font = new System.Drawing.Font("Roboto Slab", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnManageClients.ForeColor = System.Drawing.Color.Black;
            this.btnManageClients.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnManageClients.Image = ((System.Drawing.Image)(resources.GetObject("btnManageClients.Image")));
            this.btnManageClients.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageClients.ImageSize = new System.Drawing.Size(48, 48);
            this.btnManageClients.IndicateFocus = true;
            this.btnManageClients.Location = new System.Drawing.Point(13, 270);
            this.btnManageClients.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageClients.Name = "btnManageClients";
            this.btnManageClients.Size = new System.Drawing.Size(265, 67);
            this.btnManageClients.TabIndex = 5;
            this.btnManageClients.Text = "Clients";
            this.btnManageClients.UseTransparentBackground = true;
            this.btnManageClients.Click += new System.EventHandler(this.btnManageClients_Click_1);
            // 
            // pictCurrentUserImage
            // 
            this.pictCurrentUserImage.BackColor = System.Drawing.Color.Transparent;
            this.pictCurrentUserImage.Image = ((System.Drawing.Image)(resources.GetObject("pictCurrentUserImage.Image")));
            this.pictCurrentUserImage.ImageRotate = 0F;
            this.pictCurrentUserImage.Location = new System.Drawing.Point(49, 13);
            this.pictCurrentUserImage.Margin = new System.Windows.Forms.Padding(4);
            this.pictCurrentUserImage.Name = "pictCurrentUserImage";
            this.pictCurrentUserImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictCurrentUserImage.Size = new System.Drawing.Size(175, 185);
            this.pictCurrentUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictCurrentUserImage.TabIndex = 9;
            this.pictCurrentUserImage.TabStop = false;
            this.pictCurrentUserImage.UseTransparentBackground = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Animated = true;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.BorderRadius = 10;
            this.btnLogout.BorderThickness = 2;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnLogout.Font = new System.Drawing.Font("Roboto Slab", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLogout.IndicateFocus = true;
            this.btnLogout.Location = new System.Drawing.Point(13, 729);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(61, 64);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "  Logout";
            this.btnLogout.UseTransparentBackground = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Panel2.Controls.Add(this.picBoxMinimized);
            this.guna2Panel2.Controls.Add(this.guna2Button5);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(288, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1199, 45);
            this.guna2Panel2.TabIndex = 14;
            // 
            // picBoxMinimized
            // 
            this.picBoxMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxMinimized.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMinimized.Image")));
            this.picBoxMinimized.Location = new System.Drawing.Point(1091, 1);
            this.picBoxMinimized.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxMinimized.Name = "picBoxMinimized";
            this.picBoxMinimized.Size = new System.Drawing.Size(57, 51);
            this.picBoxMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMinimized.TabIndex = 11;
            this.picBoxMinimized.TabStop = false;
            this.picBoxMinimized.Click += new System.EventHandler(this.picBoxMinimized_Click);
            // 
            // mainPanal
            // 
            this.mainPanal.BackColor = System.Drawing.Color.White;
            this.mainPanal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanal.BackgroundImage")));
            this.mainPanal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mainPanal.Controls.Add(this.LabUser);
            this.mainPanal.Location = new System.Drawing.Point(285, 46);
            this.mainPanal.Name = "mainPanal";
            this.mainPanal.Size = new System.Drawing.Size(1202, 850);
            this.mainPanal.TabIndex = 2;
            this.mainPanal.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanal_Paint);
            // 
            // LabUser
            // 
            this.LabUser.AutoSize = true;
            this.LabUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabUser.ForeColor = System.Drawing.Color.Black;
            this.LabUser.Location = new System.Drawing.Point(147, -21);
            this.LabUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabUser.Name = "LabUser";
            this.LabUser.Size = new System.Drawing.Size(70, 27);
            this.LabUser.TabIndex = 10;
            this.LabUser.Text = "User :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1487, 850);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.mainPanal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Managment System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictCurrentUserImage)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimized)).EndInit();
            this.mainPanal.ResumeLayout(false);
            this.mainPanal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaPanel mainPanal;
        private Guna.UI2.WinForms.Guna2Button btnManageClients;
        private Guna.UI2.WinForms.Guna2Button btnManageAccounts;
        private Guna.UI2.WinForms.Guna2Button btnManageUsers;
        private Guna.UI2.WinForms.Guna2Button btnManageTransactionScreen;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictCurrentUserImage;
        private System.Windows.Forms.Label LabUser;
        private System.Windows.Forms.Label lblCurrentUserName;
        private Guna.UI2.WinForms.Guna2Button btnManageLoginRegister;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private System.Windows.Forms.PictureBox picBoxMinimized;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblDate;
    }
}

