namespace Steam_Desktop_Authenticator
{

    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnSteamLogin = new Wisej.Web.Button();
            this.groupBox1 = new Wisej.Web.GroupBox();
            this.btnCopy = new Wisej.Web.Button();
            this.pbTimeout = new Wisej.Web.ProgressBar();
            this.txtLoginToken = new Wisej.Web.TextBox();
            this.listAccounts = new Wisej.Web.ListBox();
            this.timerSteamGuard = new Wisej.Web.Timer(this.components);
            this.btnTradeConfirmations = new Wisej.Web.Button();
            this.btnManageEncryption = new Wisej.Web.Button();
            this.groupAccount = new Wisej.Web.GroupBox();
            this.labelVersion = new Wisej.Web.Label();
            this.labelUpdate = new Wisej.Web.LinkLabel();
            this.menuStrip = new Wisej.Web.MenuBar();
            this.fileToolStripMenuItem = new Wisej.Web.MenuItem();
            this.menuImportAccount = new Wisej.Web.MenuItem();
            this.menuSettings = new Wisej.Web.MenuItem();
            this.menuQuit = new Wisej.Web.MenuItem();
            this.accountToolStripMenuItem = new Wisej.Web.MenuItem();
            this.menuLoginAgain = new Wisej.Web.MenuItem();
            this.menuRemoveAccountFromManifest = new Wisej.Web.MenuItem();
            this.menuDeactivateAuthenticator = new Wisej.Web.MenuItem();
            this.menuSetApiKey = new Wisej.Web.MenuItem();
            this.timerTradesPopup = new Wisej.Web.Timer(this.components);
            this.lblStatus = new Wisej.Web.Label();
            this.txtAccSearch = new Wisej.Web.TextBox();
            this.label1 = new Wisej.Web.Label();
            this.panelButtons = new Wisej.Web.Panel();
            this.groupBox1.SuspendLayout();
            this.groupAccount.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();

            // 
            // btnSteamLogin
            // 
            this.btnSteamLogin.Location = new System.Drawing.Point(0, 0);
            this.btnSteamLogin.Name = "btnSteamLogin";
            this.btnSteamLogin.Size = new System.Drawing.Size(155, 30);
            this.btnSteamLogin.TabIndex = 1;
            this.btnSteamLogin.Text = "Setup New Account";
            this.btnSteamLogin.Click += new System.EventHandler(this.btnSteamLogin_Click);

            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) | Wisej.Web.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnCopy);
            this.groupBox1.Controls.Add(this.pbTimeout);
            this.groupBox1.Controls.Add(this.txtLoginToken);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 85);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Token";

            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(250, 19);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(54, 35);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Copy";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);

            // 
            // pbTimeout
            // 
            this.pbTimeout.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) | Wisej.Web.AnchorStyles.Right)));
            this.pbTimeout.Location = new System.Drawing.Point(6, 60);
            this.pbTimeout.Maximum = 30;
            this.pbTimeout.Name = "pbTimeout";
            this.pbTimeout.Size = new System.Drawing.Size(298, 19);
            this.pbTimeout.TabIndex = 1;
            this.pbTimeout.Value = 30;

            // 
            // txtLoginToken
            // 
            this.txtLoginToken.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) | Wisej.Web.AnchorStyles.Right)));
            this.txtLoginToken.BackColor = System.Drawing.SystemColors.Window;
            this.txtLoginToken.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginToken.Location = new System.Drawing.Point(6, 19);
            this.txtLoginToken.Name = "txtLoginToken";
            this.txtLoginToken.ReadOnly = true;
            this.txtLoginToken.Size = new System.Drawing.Size(238, 35);
            this.txtLoginToken.TabIndex = 0;
            this.txtLoginToken.TextAlign = Wisej.Web.HorizontalAlignment.Center;

            // 
            // listAccounts
            // 
            this.listAccounts.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) | Wisej.Web.AnchorStyles.Left) | Wisej.Web.AnchorStyles.Right)));
            this.listAccounts.FormattingEnabled = true;
            this.listAccounts.Location = new System.Drawing.Point(12, 217);
            this.listAccounts.Name = "listAccounts";
            this.listAccounts.Size = new System.Drawing.Size(310, 186);
            this.listAccounts.TabIndex = 3;
            this.listAccounts.SelectedValueChanged += new System.EventHandler(this.listAccounts_SelectedValueChanged);
            this.listAccounts.KeyDown += new Wisej.Web.KeyEventHandler(this.listAccounts_KeyDown);

            // 
            // timerSteamGuard
            // 
            this.timerSteamGuard.Enabled = true;
            this.timerSteamGuard.Interval = 1000;
            this.timerSteamGuard.Tick += new System.EventHandler(this.timerSteamGuard_Tick);

            // 
            // btnTradeConfirmations
            // 
            this.btnTradeConfirmations.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.btnTradeConfirmations.Enabled = false;
            this.btnTradeConfirmations.Location = new System.Drawing.Point(6, 19);
            this.btnTradeConfirmations.Name = "btnTradeConfirmations";
            this.btnTradeConfirmations.Size = new System.Drawing.Size(298, 31);
            this.btnTradeConfirmations.TabIndex = 4;
            this.btnTradeConfirmations.Text = "View Confirmations";
            this.btnTradeConfirmations.Click += new System.EventHandler(this.btnTradeConfirmations_Click);

            // 
            // btnManageEncryption
            // 
            this.btnManageEncryption.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnManageEncryption.Location = new System.Drawing.Point(155, 0);
            this.btnManageEncryption.Name = "btnManageEncryption";
            this.btnManageEncryption.Size = new System.Drawing.Size(155, 30);
            this.btnManageEncryption.TabIndex = 6;
            this.btnManageEncryption.Text = "Manage Encryption";
            this.btnManageEncryption.Click += new System.EventHandler(this.btnManageEncryption_Click);

            // 
            // groupAccount
            // 
            this.groupAccount.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) | Wisej.Web.AnchorStyles.Right)));
            this.groupAccount.Controls.Add(this.btnTradeConfirmations);
            this.groupAccount.Location = new System.Drawing.Point(12, 155);
            this.groupAccount.Name = "groupAccount";
            this.groupAccount.Size = new System.Drawing.Size(310, 56);
            this.groupAccount.TabIndex = 7;
            this.groupAccount.TabStop = false;
            this.groupAccount.Text = "Account";

            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
            this.labelVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelVersion.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelVersion.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.labelVersion.Location = new System.Drawing.Point(260, 441);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(70, 15);
            this.labelVersion.TabIndex = 8;
            this.labelVersion.Text = "v0.0.0";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.BottomRight;

            // 
            // labelUpdate
            // 
            this.labelUpdate.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left)));
            this.labelUpdate.BackColor = System.Drawing.Color.Transparent;
            this.labelUpdate.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelUpdate.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.labelUpdate.Location = new System.Drawing.Point(5, 441);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(122, 14);
            this.labelUpdate.TabIndex = 9;
            this.labelUpdate.TabStop = true;
            this.labelUpdate.Text = "Check for updates";
            this.labelUpdate.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.labelUpdate.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.labelUpdate_LinkClicked);

            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.MenuItems.AddRange(new Wisej.Web.MenuItem[] { this.fileToolStripMenuItem, this.accountToolStripMenuItem });
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(334, 24);
            this.menuStrip.TabIndex = 10;
            this.menuStrip.Text = "menuStrip1";

            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.MenuItems.AddRange(new Wisej.Web.MenuItem[] { this.menuImportAccount, this.menuSettings, this.menuQuit });
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Text = "File";

            // 
            // menuImportAccount
            // 
            this.menuImportAccount.Name = "menuImportAccount";
            this.menuImportAccount.Text = "Import Account";
            this.menuImportAccount.Click += new System.EventHandler(this.menuImportAccount_Click);

            // 
            // menuSettings
            // 
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Text = "Settings";
            this.menuSettings.Click += new System.EventHandler(this.menuSettings_Click);

            // 
            // menuQuit
            // 
            this.menuQuit.Name = "menuQuit";
            this.menuQuit.Text = "Quit";
            this.menuQuit.Click += new System.EventHandler(this.menuQuit_Click);

            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.MenuItems.AddRange(new Wisej.Web.MenuItem[] { this.menuLoginAgain, this.menuRemoveAccountFromManifest, this.menuDeactivateAuthenticator, this.menuSetApiKey });
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Text = "Selected Account";

            // 
            // menuLoginAgain
            // 
            this.menuLoginAgain.Name = "menuLoginAgain";
            this.menuLoginAgain.Text = "Login again";
            this.menuLoginAgain.Click += new System.EventHandler(this.menuLoginAgain_Click);

            // 
            // menuRemoveAccountFromManifest
            // 
            this.menuRemoveAccountFromManifest.Name = "menuRemoveAccountFromManifest";
            this.menuRemoveAccountFromManifest.Text = "Remove from manifest";
            this.menuRemoveAccountFromManifest.Click += new System.EventHandler(this.menuRemoveAccountFromManifest_Click);

            // 
            // menuDeactivateAuthenticator
            // 
            this.menuDeactivateAuthenticator.Name = "menuDeactivateAuthenticator";
            this.menuDeactivateAuthenticator.Text = "Deactivate Authenticator";
            this.menuDeactivateAuthenticator.Click += new System.EventHandler(this.menuDeactivateAuthenticator_Click);

            // 
            // menuSetApiKey
            // 
            this.menuSetApiKey.Name = "menuSetApiKey";
            this.menuSetApiKey.Text = "Set API Key";
            this.menuSetApiKey.Click += new System.EventHandler(this.menuSetApiKey_Click);

            // 
            // timerTradesPopup
            // 
            this.timerTradesPopup.Enabled = true;
            this.timerTradesPopup.Interval = 5000;
            this.timerTradesPopup.Tick += new System.EventHandler(this.timerTradesPopup_Tick);

            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.lblStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(166, 5);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(163, 18);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;

            // 
            // txtAccSearch
            // 
            this.txtAccSearch.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left) | Wisej.Web.AnchorStyles.Right)));
            this.txtAccSearch.Location = new System.Drawing.Point(49, 411);
            this.txtAccSearch.Name = "txtAccSearch";
            this.txtAccSearch.Size = new System.Drawing.Size(273, 22);
            this.txtAccSearch.TabIndex = 12;
            this.txtAccSearch.TextChanged += new System.EventHandler(this.txtAccSearch_TextChanged);

            // 
            // label1
            // 
            this.label1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Filter:";

            // 
            // panelButtons
            // 
            this.panelButtons.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) | Wisej.Web.AnchorStyles.Right)));
            this.panelButtons.BackColor = System.Drawing.Color.Transparent;
            this.panelButtons.Controls.Add(this.btnSteamLogin);
            this.panelButtons.Controls.Add(this.btnManageEncryption);
            this.panelButtons.Location = new System.Drawing.Point(12, 26);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(310, 30);
            this.panelButtons.TabIndex = 14;
            this.panelButtons.SizeChanged += new System.EventHandler(this.panelButtons_SizeChanged);

            // 
            // MainForm
            // 
            this.AcceptButton = this.btnCopy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAccSearch);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.labelUpdate);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.groupAccount);
            this.Controls.Add(this.listAccounts);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 400);
            this.Name = "MainForm";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "Steam Desktop Authenticator";
            this.FormClosing += new Wisej.Web.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.KeyDown += new Wisej.Web.KeyEventHandler(this.MainForm_KeyDown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupAccount.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private Wisej.Web.Button btnSteamLogin;
        private Wisej.Web.GroupBox groupBox1;
        private Wisej.Web.ProgressBar pbTimeout;
        private Wisej.Web.TextBox txtLoginToken;
        private Wisej.Web.ListBox listAccounts;
        private Wisej.Web.Timer timerSteamGuard;
        private Wisej.Web.Button btnTradeConfirmations;
        private Wisej.Web.Button btnManageEncryption;
        private Wisej.Web.GroupBox groupAccount;
        private Wisej.Web.Label labelVersion;
        private Wisej.Web.LinkLabel labelUpdate;
        private Wisej.Web.MenuBar menuStrip;
        private Wisej.Web.MenuItem fileToolStripMenuItem;
        private Wisej.Web.MenuItem menuQuit;
        private Wisej.Web.MenuItem accountToolStripMenuItem;
        private Wisej.Web.MenuItem menuRemoveAccountFromManifest;
        private Wisej.Web.MenuItem menuLoginAgain;
        private Wisej.Web.MenuItem menuSetApiKey;
        private Wisej.Web.Timer timerTradesPopup;
        private Wisej.Web.MenuItem menuImportAccount;
        private Wisej.Web.Label lblStatus;
        private Wisej.Web.TextBox txtAccSearch;
        private Wisej.Web.Label label1;
        private Wisej.Web.MenuItem menuSettings;
        private Wisej.Web.MenuItem menuDeactivateAuthenticator;
        private Wisej.Web.Button btnCopy;
        private Wisej.Web.Panel panelButtons;
    }
}

