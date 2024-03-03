﻿using System;
using System.Drawing;
using System.Threading.Tasks;
using Wisej.Web;
using SteamAuth;
using System.Drawing.Drawing2D;

namespace Steam_Desktop_Authenticator
{
    using System.Collections.Generic;
    using System.Linq;

    public partial class ConfirmationFormWeb : Form
    {
        private SteamGuardAccount steamAccount;

        public ConfirmationFormWeb(SteamGuardAccount steamAccount)
        {
            InitializeComponent();
            this.steamAccount = steamAccount;
            this.Text = String.Format("Trade Confirmations - {0}", steamAccount.AccountName);
        }

        private async Task LoadData()
        {
            this.splitContainer1.Panel2.Controls.Clear();

            // Check for a valid refresh token first
            if (steamAccount.Session.IsRefreshTokenExpired())
            {
                MessageBox.Show(
                    "Your session has expired. Use the login again button under the selected account menu.",
                    "Trade Confirmations",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // Check for a valid access token, refresh it if needed
            if (steamAccount.Session.IsAccessTokenExpired())
            {
                try
                {
                    await steamAccount.Session.RefreshAccessToken();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Steam Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
            }

            try
            {
                var confirmations = await steamAccount.FetchConfirmationsAsync();

                if (confirmations == null || confirmations.Length == 0)
                {
                    Label errorLabel = new Label()
                    {
                        Text = "Nothing to confirm/cancel",
                        AutoSize = true, ForeColor = Color.Black,
                        Location = new Point(150, 20),
                    };
                    this.splitContainer1.Panel2.Controls.Add(errorLabel);
                }

                List<TradeOffer> trades = await steamAccount.FetchTradesAsync();

                foreach (Confirmation confirmation in confirmations)
                {
                    Panel panel = new Panel() { Dock = DockStyle.Top, Height = 120 };
                    panel.Paint += (s, e) =>
                    {
                        using (LinearGradientBrush brush = new LinearGradientBrush(panel.ClientRectangle, Color.Black, Color.DarkCyan, 90F))
                        {
                            e.Graphics.FillRectangle(brush, panel.ClientRectangle);
                        }
                    };

                    PictureBox pictureBox = new PictureBox()
                        { Width = 60, Height = 60, Location = new Point(20, 20), SizeMode = PictureBoxSizeMode.Zoom };
                    if (!string.IsNullOrEmpty(confirmation.Icon))
                    {
                        pictureBox.Load(confirmation.Icon);
                        panel.Controls.Add(pictureBox);
                    }

                    Label nameLabel = new Label()
                    {
                        Text = $"{confirmation.Headline}\n{confirmation.Creator.ToString()}",
                        AutoSize = true,
                        ForeColor = Color.Snow,
                        Location = new Point(90, 20),
                        BackColor = Color.Transparent
                    };
                    panel.Controls.Add(nameLabel);

                    ConfirmationButton acceptButton = new ConfirmationButton()
                    {
                        Text = confirmation.Accept,
                        Location = new Point(90, 50),
                        BackColor = Color.Black,
                        ForeColor = Color.Snow,
                        Confirmation = confirmation
                    };
                    acceptButton.Click += btnAccept_Click;
                    panel.Controls.Add(acceptButton);

                    ConfirmationButton cancelButton = new ConfirmationButton()
                    {
                        Text = confirmation.Cancel,
                        Location = new Point(180, 50),
                        BackColor = Color.Black,
                        ForeColor = Color.Snow,
                        Confirmation = confirmation
                    };
                    cancelButton.Click += btnCancel_Click;
                    panel.Controls.Add(cancelButton);

                    Label summaryLabel = new Label()
                    {
                        Text = String.Join("\n", confirmation.Summary),
                        AutoSize = true,
                        ForeColor = Color.Snow,
                        Location = new Point(90, 80),
                        BackColor = Color.Transparent
                    };
                    panel.Controls.Add(summaryLabel);

                    this.splitContainer1.Panel2.Controls.Add(panel);
                    if (confirmation.ConfType == Confirmation.EMobileConfirmationType.Trade && trades != null)
                    {
                        TradeOffer trade = trades.FirstOrDefault(t => t.TradeOfferId == confirmation.Creator);
                        if (trade != null)
                        {
                            pictureBox.Click += (s, e) =>
                            {
                                System.Diagnostics.Process.Start($"https://steamcommunity.com/profiles/{trade.SteamId}");
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Label errorLabel = new Label()
                {
                    Text = "Something went wrong:\n" + ex.Message,
                    AutoSize = true,
                    ForeColor = Color.Red,
                    Location = new Point(20, 20),
                };
                this.splitContainer1.Panel2.Controls.Add(errorLabel);
            }
        }

        private async void btnAccept_Click(object sender, EventArgs e)
        {
            var button = (ConfirmationButton)sender;
            var confirmation = button.Confirmation;
            bool result = await steamAccount.AcceptConfirmation(confirmation);

            await this.LoadData();
        }

        private async void btnCancel_Click(object sender, EventArgs e)
        {
            var button = (ConfirmationButton)sender;
            var confirmation = button.Confirmation;
            bool result = await steamAccount.DenyConfirmation(confirmation);

            await this.LoadData();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            this.btnRefresh.Enabled = false;
            this.btnRefresh.Text = "Refreshing...";

            await this.LoadData();

            this.btnRefresh.Enabled = true;
            this.btnRefresh.Text = "Refresh";
        }

        private async void ConfirmationFormWeb_Shown(object sender, EventArgs e)
        {
            this.btnRefresh.Enabled = false;
            this.btnRefresh.Text = "Refreshing...";

            await this.LoadData();

            this.btnRefresh.Enabled = true;
            this.btnRefresh.Text = "Refresh";
        }
    }
}