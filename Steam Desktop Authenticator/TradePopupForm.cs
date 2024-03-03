using SteamAuth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wisej.Web;

namespace Steam_Desktop_Authenticator
{
    public partial class TradePopupForm : Form
    {
        private Confirmation currentConfirmation;
        private SteamGuardAccount currentAccount;
        private bool deny2, accept2;

        public TradePopupForm()
        {
            InitializeComponent();
            lblStatus.Text = "";
        }

        public SortedDictionary<SteamGuardAccount, List<Confirmation>> Confirmations { get; set; }

        private void TradePopupForm_Load(object sender, EventArgs e)
        {
            this.Location = (Point)Size.Subtract(Screen.WorkingArea.Size, this.Size);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (!accept2)
            {
                // Allow user to confirm first
                lblStatus.Text = "Press Accept again to confirm";
                btnAccept.BackColor = Color.FromArgb(128, 255, 128);
                accept2 = true;
            }
            else
            {
                lblStatus.Text = "Accepting...";
                currentAccount.AcceptConfirmation(currentConfirmation);
                Confirmations[currentAccount].Remove(currentConfirmation);
                Reset();
            }
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            if (!deny2)
            {
                lblStatus.Text = "Press Deny again to confirm";
                btnDeny.BackColor = Color.FromArgb(255, 255, 128);
                deny2 = true;
            }
            else
            {
                lblStatus.Text = "Denying...";
                currentAccount.DenyConfirmation(currentConfirmation);
                Confirmations[currentAccount].Remove(currentConfirmation);
                Reset();
            }
        }

        private void Reset()
        {
            KeyValuePair<SteamGuardAccount, List<Confirmation>> a = Confirmations.FirstOrDefault();
            if (a.Key == null)
            {
                this.Hide();
                return;
            }
            currentAccount = a.Key;
            currentConfirmation = a.Value.First();
            
            deny2 = false;
            accept2 = false;
            btnAccept.BackColor = Color.FromArgb(192, 255, 192);
            btnDeny.BackColor = Color.FromArgb(255, 255, 192);

            btnAccept.Text = "Accept";
            btnDeny.Text = "Deny";
            lblAccount.Text = currentAccount.AccountName;
            lblStatus.Text = "";

            if (Confirmations.Count == 0)
            {
                this.Hide();
            }
            else
            {
                //TODO: Re-add confirmation description support to SteamAuth.
                lblDesc.Text = $"{currentConfirmation.ConfType} Confirmation\n{currentConfirmation.Headline}";
                string summary = string.Join("\n", currentConfirmation.Summary);
                toolTip1.SetToolTip(lblDesc, summary);
            }
        }

        public void Popup()
        {
            Reset();
            this.Show();
        }
    }
}
