namespace BankSystemProjectWinfosForm
{
    partial class frmManageUsers
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
            this.labMainScreenUsers = new System.Windows.Forms.Label();
            this.btnDeleteUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnUserList = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnFindUser = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labMainScreenUsers
            // 
            this.labMainScreenUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labMainScreenUsers.AutoSize = true;
            this.labMainScreenUsers.Font = new System.Drawing.Font("Roboto Slab", 20F, System.Drawing.FontStyle.Bold);
            this.labMainScreenUsers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labMainScreenUsers.Location = new System.Drawing.Point(59, 10);
            this.labMainScreenUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labMainScreenUsers.Name = "labMainScreenUsers";
            this.labMainScreenUsers.Size = new System.Drawing.Size(373, 46);
            this.labMainScreenUsers.TabIndex = 22;
            this.labMainScreenUsers.Text = "Manage Users Screen";
            this.labMainScreenUsers.Click += new System.EventHandler(this.labMainScreenUsers_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteUser.Animated = true;
            this.btnDeleteUser.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteUser.BorderRadius = 30;
            this.btnDeleteUser.BorderThickness = 1;
            this.btnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteUser.FillColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteUser.Font = new System.Drawing.Font("Roboto Slab", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnDeleteUser.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDeleteUser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteUser.IndicateFocus = true;
            this.btnDeleteUser.Location = new System.Drawing.Point(386, 188);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(293, 78);
            this.btnDeleteUser.TabIndex = 21;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseTransparentBackground = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnUserList
            // 
            this.btnUserList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUserList.Animated = true;
            this.btnUserList.BackColor = System.Drawing.Color.Transparent;
            this.btnUserList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUserList.BorderRadius = 30;
            this.btnUserList.BorderThickness = 1;
            this.btnUserList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUserList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUserList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUserList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUserList.FillColor = System.Drawing.Color.Gainsboro;
            this.btnUserList.Font = new System.Drawing.Font("Roboto Slab", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnUserList.ForeColor = System.Drawing.Color.Black;
            this.btnUserList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnUserList.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUserList.IndicateFocus = true;
            this.btnUserList.Location = new System.Drawing.Point(52, 286);
            this.btnUserList.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserList.Name = "btnUserList";
            this.btnUserList.Size = new System.Drawing.Size(627, 78);
            this.btnUserList.TabIndex = 20;
            this.btnUserList.Text = "User List";
            this.btnUserList.UseTransparentBackground = true;
            this.btnUserList.Click += new System.EventHandler(this.btnUserList_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateUser.Animated = true;
            this.btnUpdateUser.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateUser.BorderRadius = 30;
            this.btnUpdateUser.BorderThickness = 1;
            this.btnUpdateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateUser.FillColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateUser.Font = new System.Drawing.Font("Roboto Slab", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdateUser.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnUpdateUser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdateUser.IndicateFocus = true;
            this.btnUpdateUser.Location = new System.Drawing.Point(52, 188);
            this.btnUpdateUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(293, 78);
            this.btnUpdateUser.TabIndex = 19;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.UseTransparentBackground = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddUser.Animated = true;
            this.btnAddUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddUser.BorderRadius = 30;
            this.btnAddUser.BorderThickness = 1;
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddUser.FillColor = System.Drawing.Color.Gainsboro;
            this.btnAddUser.Font = new System.Drawing.Font("Roboto Slab", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAddUser.ForeColor = System.Drawing.Color.Black;
            this.btnAddUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddUser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddUser.IndicateFocus = true;
            this.btnAddUser.Location = new System.Drawing.Point(386, 91);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(293, 78);
            this.btnAddUser.TabIndex = 18;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseTransparentBackground = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnFindUser
            // 
            this.btnFindUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFindUser.Animated = true;
            this.btnFindUser.BackColor = System.Drawing.Color.Transparent;
            this.btnFindUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFindUser.BorderRadius = 30;
            this.btnFindUser.BorderThickness = 1;
            this.btnFindUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFindUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFindUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFindUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFindUser.FillColor = System.Drawing.Color.Gainsboro;
            this.btnFindUser.Font = new System.Drawing.Font("Roboto Slab", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnFindUser.ForeColor = System.Drawing.Color.Black;
            this.btnFindUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnFindUser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnFindUser.IndicateFocus = true;
            this.btnFindUser.Location = new System.Drawing.Point(52, 91);
            this.btnFindUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.Size = new System.Drawing.Size(293, 78);
            this.btnFindUser.TabIndex = 17;
            this.btnFindUser.Text = "Find User";
            this.btnFindUser.UseTransparentBackground = true;
            this.btnFindUser.Click += new System.EventHandler(this.btnFindUser_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.labMainScreenUsers);
            this.panel1.Controls.Add(this.btnFindUser);
            this.panel1.Controls.Add(this.btnDeleteUser);
            this.panel1.Controls.Add(this.btnUpdateUser);
            this.panel1.Controls.Add(this.btnUserList);
            this.panel1.Location = new System.Drawing.Point(100, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 457);
            this.panel1.TabIndex = 23;
            // 
            // frmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 628);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageUsers";
            this.Text = "frmManageUsers";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labMainScreenUsers;
        private Guna.UI2.WinForms.Guna2Button btnDeleteUser;
        private Guna.UI2.WinForms.Guna2Button btnUserList;
        private Guna.UI2.WinForms.Guna2Button btnUpdateUser;
        private Guna.UI2.WinForms.Guna2Button btnAddUser;
        private Guna.UI2.WinForms.Guna2Button btnFindUser;
        private System.Windows.Forms.Panel panel1;
    }
}