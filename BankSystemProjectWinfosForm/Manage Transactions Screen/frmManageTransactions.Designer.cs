namespace BankSystemProjectWinfosForm.Manage_Transactions_Screen
{
    partial class frmManageTransactions
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
            this.btnTransferLog = new Guna.UI2.WinForms.Guna2Button();
            this.btnTotalBalances = new Guna.UI2.WinForms.Guna2Button();
            this.btnTransfer = new Guna.UI2.WinForms.Guna2Button();
            this.btnWithdraw = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeposit = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Roboto Slab", 20F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaLabel1.Location = new System.Drawing.Point(67, 81);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(511, 46);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "Manage Transactions Screeen";
            // 
            // btnTransferLog
            // 
            this.btnTransferLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTransferLog.Animated = true;
            this.btnTransferLog.BackColor = System.Drawing.Color.Transparent;
            this.btnTransferLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTransferLog.BorderRadius = 10;
            this.btnTransferLog.BorderThickness = 1;
            this.btnTransferLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransferLog.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTransferLog.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTransferLog.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTransferLog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTransferLog.FillColor = System.Drawing.Color.Gainsboro;
            this.btnTransferLog.Font = new System.Drawing.Font("Roboto Slab", 18.75F, System.Drawing.FontStyle.Bold);
            this.btnTransferLog.ForeColor = System.Drawing.Color.Black;
            this.btnTransferLog.Image = global::BankSystemProjectWinfosForm.Properties.Resources.icons8_history_64;
            this.btnTransferLog.ImageOffset = new System.Drawing.Point(-10, -10);
            this.btnTransferLog.ImageSize = new System.Drawing.Size(70, 70);
            this.btnTransferLog.IndicateFocus = true;
            this.btnTransferLog.Location = new System.Drawing.Point(52, 472);
            this.btnTransferLog.Margin = new System.Windows.Forms.Padding(4);
            this.btnTransferLog.Name = "btnTransferLog";
            this.btnTransferLog.Size = new System.Drawing.Size(976, 127);
            this.btnTransferLog.TabIndex = 13;
            this.btnTransferLog.Text = "Transfer Log";
            this.btnTransferLog.UseTransparentBackground = true;
            this.btnTransferLog.Click += new System.EventHandler(this.btnTransferLog_Click);
            // 
            // btnTotalBalances
            // 
            this.btnTotalBalances.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTotalBalances.Animated = true;
            this.btnTotalBalances.BackColor = System.Drawing.Color.Transparent;
            this.btnTotalBalances.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTotalBalances.BorderRadius = 10;
            this.btnTotalBalances.BorderThickness = 1;
            this.btnTotalBalances.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTotalBalances.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTotalBalances.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTotalBalances.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTotalBalances.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTotalBalances.FillColor = System.Drawing.Color.Gainsboro;
            this.btnTotalBalances.Font = new System.Drawing.Font("Roboto Slab", 18.75F, System.Drawing.FontStyle.Bold);
            this.btnTotalBalances.ForeColor = System.Drawing.Color.Black;
            this.btnTotalBalances.Image = global::BankSystemProjectWinfosForm.Properties.Resources.icons8_money_35;
            this.btnTotalBalances.ImageOffset = new System.Drawing.Point(-10, -10);
            this.btnTotalBalances.ImageSize = new System.Drawing.Size(70, 70);
            this.btnTotalBalances.IndicateFocus = true;
            this.btnTotalBalances.Location = new System.Drawing.Point(52, 325);
            this.btnTotalBalances.Margin = new System.Windows.Forms.Padding(4);
            this.btnTotalBalances.Name = "btnTotalBalances";
            this.btnTotalBalances.Size = new System.Drawing.Size(976, 127);
            this.btnTotalBalances.TabIndex = 12;
            this.btnTotalBalances.Text = "Total Balances";
            this.btnTotalBalances.UseTransparentBackground = true;
            this.btnTotalBalances.Click += new System.EventHandler(this.btnTotalBalances_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTransfer.Animated = true;
            this.btnTransfer.BackColor = System.Drawing.Color.Transparent;
            this.btnTransfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTransfer.BorderRadius = 10;
            this.btnTransfer.BorderThickness = 1;
            this.btnTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransfer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTransfer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTransfer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTransfer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTransfer.FillColor = System.Drawing.Color.Gainsboro;
            this.btnTransfer.Font = new System.Drawing.Font("Roboto Slab", 18.75F, System.Drawing.FontStyle.Bold);
            this.btnTransfer.ForeColor = System.Drawing.Color.Black;
            this.btnTransfer.Image = global::BankSystemProjectWinfosForm.Properties.Resources.icons8_transfer_64;
            this.btnTransfer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTransfer.ImageSize = new System.Drawing.Size(60, 60);
            this.btnTransfer.IndicateFocus = true;
            this.btnTransfer.Location = new System.Drawing.Point(757, 177);
            this.btnTransfer.Margin = new System.Windows.Forms.Padding(4);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(273, 127);
            this.btnTransfer.TabIndex = 11;
            this.btnTransfer.Text = "    Transfer";
            this.btnTransfer.UseTransparentBackground = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWithdraw.Animated = true;
            this.btnWithdraw.BackColor = System.Drawing.Color.Transparent;
            this.btnWithdraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWithdraw.BorderRadius = 10;
            this.btnWithdraw.BorderThickness = 1;
            this.btnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWithdraw.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWithdraw.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWithdraw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWithdraw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWithdraw.FillColor = System.Drawing.Color.Gainsboro;
            this.btnWithdraw.Font = new System.Drawing.Font("Roboto Slab", 18.75F, System.Drawing.FontStyle.Bold);
            this.btnWithdraw.ForeColor = System.Drawing.Color.Black;
            this.btnWithdraw.Image = global::BankSystemProjectWinfosForm.Properties.Resources.icons8_withdraw_64;
            this.btnWithdraw.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnWithdraw.ImageSize = new System.Drawing.Size(50, 50);
            this.btnWithdraw.IndicateFocus = true;
            this.btnWithdraw.Location = new System.Drawing.Point(404, 177);
            this.btnWithdraw.Margin = new System.Windows.Forms.Padding(4);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(273, 127);
            this.btnWithdraw.TabIndex = 10;
            this.btnWithdraw.Text = "    Withdraw";
            this.btnWithdraw.UseTransparentBackground = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeposit.Animated = true;
            this.btnDeposit.BackColor = System.Drawing.Color.Transparent;
            this.btnDeposit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeposit.BorderRadius = 10;
            this.btnDeposit.BorderThickness = 1;
            this.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeposit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeposit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeposit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeposit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeposit.FillColor = System.Drawing.Color.Gainsboro;
            this.btnDeposit.Font = new System.Drawing.Font("Roboto Slab", 18.75F, System.Drawing.FontStyle.Bold);
            this.btnDeposit.ForeColor = System.Drawing.Color.Black;
            this.btnDeposit.Image = global::BankSystemProjectWinfosForm.Properties.Resources.icons8_deposit_64;
            this.btnDeposit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeposit.ImageSize = new System.Drawing.Size(55, 55);
            this.btnDeposit.IndicateFocus = true;
            this.btnDeposit.Location = new System.Drawing.Point(52, 177);
            this.btnDeposit.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(273, 127);
            this.btnDeposit.TabIndex = 9;
            this.btnDeposit.Text = "  Deposit";
            this.btnDeposit.UseTransparentBackground = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // frmManageTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1104, 757);
            this.Controls.Add(this.btnTransferLog);
            this.Controls.Add(this.btnTotalBalances);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageTransactions";
            this.Text = "frmManageTransactions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2Button btnTransferLog;
        private Guna.UI2.WinForms.Guna2Button btnTotalBalances;
        private Guna.UI2.WinForms.Guna2Button btnTransfer;
        private Guna.UI2.WinForms.Guna2Button btnWithdraw;
        private Guna.UI2.WinForms.Guna2Button btnDeposit;
    }
}