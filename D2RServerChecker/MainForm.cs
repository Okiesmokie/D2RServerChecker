using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D2RServerChecker {
    public partial class MainForm : Form {
        DiabloServerInfo dsi = new DiabloServerInfo();

        public MainForm() {
            InitializeComponent();
        }

        private void generateBaselineButton_Click(object sender, EventArgs e) {
            if(!dsi.getD2RProcessID()) {
                MessageBox.Show("Please ensure the Diablo II: Resurrected is currently running", "Error");
                return;
            }

            dsi.getConnectedAddresses(true);

            getServerAddressButton.Enabled = true;
        }

        private void getServerAddressButton_Click(object sender, EventArgs e) {
            List<string> serverAddresses = dsi.getServerAddresses();

            if(serverAddresses.Count <= 0) {
                MessageBox.Show("No server address found. Are you connected to a game?", "Error");
                return;
            }

            if(serverAddresses.Count > 1) {
                MessageBox.Show("Multiple possible addresses found.  Did you click the top button while in a lobby before getting server address?", "Information");
            }

            serverAddressTextBox.Text = string.Join(",", serverAddresses);

            if(serverAddresses.Contains(targetIp.Text))
            {
                serverAddressTextBox.BackColor = Color.LightGreen;
            } else
            {
                serverAddressTextBox.BackColor = Color.Transparent;
            }
        }

        private void pinBtn_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;
            pinBtn.Text = pinBtn.Text == "pin" ? "unpin": "pin";
        }
    }
}
