namespace BankSystemProjectWinfosForm
{
    partial class frmManageClients
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
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnDeleteClient = new Guna.UI.WinForms.GunaButton();
            this.btnClientList = new Guna.UI.WinForms.GunaButton();
            this.btnUpdateClient = new Guna.UI.WinForms.GunaButton();
            this.btnAddNewClient = new Guna.UI.WinForms.GunaButton();
            this.btnFindClient = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.panel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1080, 790);
            this.gunaPanel1.TabIndex = 0;
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.AnimationHoverSpeed = 0.07F;
            this.btnDeleteClient.AnimationSpeed = 0.03F;
            this.btnDeleteClient.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteClient.BaseColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteClient.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteClient.BorderSize = 1;
            this.btnDeleteClient.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeleteClient.FocusedColor = System.Drawing.Color.Empty;
            this.btnDeleteClient.Font = new System.Drawing.Font("Roboto Slab", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClient.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteClient.Image = null;
            this.btnDeleteClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDeleteClient.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDeleteClient.Location = new System.Drawing.Point(405, 218);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDeleteClient.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDeleteClient.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnDeleteClient.OnHoverImage = null;
            this.btnDeleteClient.OnPressedColor = System.Drawing.Color.Black;
            this.btnDeleteClient.Radius = 20;
            this.btnDeleteClient.Size = new System.Drawing.Size(325, 66);
            this.btnDeleteClient.TabIndex = 7;
            this.btnDeleteClient.Text = "Delete Client";
            this.btnDeleteClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnClientList
            // 
            this.btnClientList.AnimationHoverSpeed = 0.07F;
            this.btnClientList.AnimationSpeed = 0.03F;
            this.btnClientList.BackColor = System.Drawing.Color.Transparent;
            this.btnClientList.BaseColor = System.Drawing.Color.Gainsboro;
            this.btnClientList.BorderColor = System.Drawing.Color.Black;
            this.btnClientList.BorderSize = 1;
            this.btnClientList.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClientList.FocusedColor = System.Drawing.Color.Empty;
            this.btnClientList.Font = new System.Drawing.Font("Roboto Slab", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientList.ForeColor = System.Drawing.Color.Black;
            this.btnClientList.Image = null;
            this.btnClientList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnClientList.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClientList.Location = new System.Drawing.Point(58, 307);
            this.btnClientList.Name = "btnClientList";
            this.btnClientList.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClientList.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClientList.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnClientList.OnHoverImage = null;
            this.btnClientList.OnPressedColor = System.Drawing.Color.Black;
            this.btnClientList.Radius = 20;
            this.btnClientList.Size = new System.Drawing.Size(672, 66);
            this.btnClientList.TabIndex = 6;
            this.btnClientList.Text = "Client List";
            this.btnClientList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClientList.Click += new System.EventHandler(this.btnClientList_Click);
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.AnimationHoverSpeed = 0.07F;
            this.btnUpdateClient.AnimationSpeed = 0.03F;
            this.btnUpdateClient.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateClient.BaseColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateClient.BorderColor = System.Drawing.Color.Black;
            this.btnUpdateClient.BorderSize = 1;
            this.btnUpdateClient.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdateClient.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdateClient.Font = new System.Drawing.Font("Roboto Slab", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClient.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateClient.Image = null;
            this.btnUpdateClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnUpdateClient.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdateClient.Location = new System.Drawing.Point(405, 129);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdateClient.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdateClient.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnUpdateClient.OnHoverImage = null;
            this.btnUpdateClient.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdateClient.Radius = 20;
            this.btnUpdateClient.Size = new System.Drawing.Size(325, 66);
            this.btnUpdateClient.TabIndex = 5;
            this.btnUpdateClient.Text = "Update Client";
            this.btnUpdateClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // btnAddNewClient
            // 
            this.btnAddNewClient.AnimationHoverSpeed = 0.07F;
            this.btnAddNewClient.AnimationSpeed = 0.03F;
            this.btnAddNewClient.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewClient.BaseColor = System.Drawing.Color.Gainsboro;
            this.btnAddNewClient.BorderColor = System.Drawing.Color.Black;
            this.btnAddNewClient.BorderSize = 1;
            this.btnAddNewClient.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNewClient.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddNewClient.Font = new System.Drawing.Font("Roboto Slab", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewClient.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewClient.Image = null;
            this.btnAddNewClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddNewClient.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddNewClient.Location = new System.Drawing.Point(58, 218);
            this.btnAddNewClient.Name = "btnAddNewClient";
            this.btnAddNewClient.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddNewClient.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddNewClient.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnAddNewClient.OnHoverImage = null;
            this.btnAddNewClient.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddNewClient.Radius = 20;
            this.btnAddNewClient.Size = new System.Drawing.Size(325, 66);
            this.btnAddNewClient.TabIndex = 4;
            this.btnAddNewClient.Text = "Add Client";
            this.btnAddNewClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddNewClient.Click += new System.EventHandler(this.btnAddNewClient_Click);
            // 
            // btnFindClient
            // 
            this.btnFindClient.AnimationHoverSpeed = 0.07F;
            this.btnFindClient.AnimationSpeed = 0.03F;
            this.btnFindClient.BackColor = System.Drawing.Color.Transparent;
            this.btnFindClient.BaseColor = System.Drawing.Color.Gainsboro;
            this.btnFindClient.BorderColor = System.Drawing.Color.Black;
            this.btnFindClient.BorderSize = 1;
            this.btnFindClient.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFindClient.FocusedColor = System.Drawing.Color.Empty;
            this.btnFindClient.Font = new System.Drawing.Font("Roboto Slab", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindClient.ForeColor = System.Drawing.Color.Black;
            this.btnFindClient.Image = null;
            this.btnFindClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnFindClient.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFindClient.Location = new System.Drawing.Point(58, 129);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFindClient.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFindClient.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnFindClient.OnHoverImage = null;
            this.btnFindClient.OnPressedColor = System.Drawing.Color.Black;
            this.btnFindClient.Radius = 20;
            this.btnFindClient.Size = new System.Drawing.Size(325, 66);
            this.btnFindClient.TabIndex = 3;
            this.btnFindClient.Text = "Find Client";
            this.btnFindClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Roboto Slab", 20F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaLabel1.Location = new System.Drawing.Point(67, 37);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(410, 46);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Manage Clients Screeen";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClientList);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.btnDeleteClient);
            this.panel1.Controls.Add(this.btnFindClient);
            this.panel1.Controls.Add(this.btnAddNewClient);
            this.panel1.Controls.Add(this.btnUpdateClient);
            this.panel1.Location = new System.Drawing.Point(100, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 464);
            this.panel1.TabIndex = 8;
            // 
            // frmManageClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 790);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageClients";
            this.Text = "frmManageClients";
            this.gunaPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton btnFindClient;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btnDeleteClient;
        private Guna.UI.WinForms.GunaButton btnClientList;
        private Guna.UI.WinForms.GunaButton btnUpdateClient;
        private Guna.UI.WinForms.GunaButton btnAddNewClient;
        private System.Windows.Forms.Panel panel1;
    }
}