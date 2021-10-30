
namespace D2RServerChecker {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.generateBaselineButton = new System.Windows.Forms.Button();
            this.getServerAddressButton = new System.Windows.Forms.Button();
            this.serverAddressTextBox = new System.Windows.Forms.Label();
            this.targetIpLbl = new System.Windows.Forms.Label();
            this.targetIp = new System.Windows.Forms.TextBox();
            this.pinBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // generateBaselineButton
            // 
            this.generateBaselineButton.Location = new System.Drawing.Point(12, 12);
            this.generateBaselineButton.Name = "generateBaselineButton";
            this.generateBaselineButton.Size = new System.Drawing.Size(153, 23);
            this.generateBaselineButton.TabIndex = 0;
            this.generateBaselineButton.Text = "Click this when in lobby";
            this.generateBaselineButton.UseVisualStyleBackColor = true;
            this.generateBaselineButton.Click += new System.EventHandler(this.generateBaselineButton_Click);
            // 
            // getServerAddressButton
            // 
            this.getServerAddressButton.Enabled = false;
            this.getServerAddressButton.Location = new System.Drawing.Point(12, 41);
            this.getServerAddressButton.Name = "getServerAddressButton";
            this.getServerAddressButton.Size = new System.Drawing.Size(153, 23);
            this.getServerAddressButton.TabIndex = 1;
            this.getServerAddressButton.Text = "Get server address:";
            this.getServerAddressButton.UseVisualStyleBackColor = true;
            this.getServerAddressButton.Click += new System.EventHandler(this.getServerAddressButton_Click);
            // 
            // serverAddressTextBox
            // 
            this.serverAddressTextBox.Location = new System.Drawing.Point(171, 42);
            this.serverAddressTextBox.Name = "serverAddressTextBox";
            this.serverAddressTextBox.Size = new System.Drawing.Size(179, 23);
            this.serverAddressTextBox.TabIndex = 3;
            // 
            // targetIpLbl
            // 
            this.targetIpLbl.AutoSize = true;
            this.targetIpLbl.Location = new System.Drawing.Point(12, 71);
            this.targetIpLbl.Name = "targetIpLbl";
            this.targetIpLbl.Size = new System.Drawing.Size(82, 15);
            this.targetIpLbl.TabIndex = 4;
            this.targetIpLbl.Text = "Enter Target IP";
            // 
            // targetIp
            // 
            this.targetIp.Location = new System.Drawing.Point(171, 71);
            this.targetIp.Name = "targetIp";
            this.targetIp.Size = new System.Drawing.Size(179, 23);
            this.targetIp.TabIndex = 5;
            // 
            // pinBtn
            // 
            this.pinBtn.Location = new System.Drawing.Point(291, 12);
            this.pinBtn.Name = "pinBtn";
            this.pinBtn.Size = new System.Drawing.Size(59, 23);
            this.pinBtn.TabIndex = 6;
            this.pinBtn.Text = "pin";
            this.pinBtn.UseVisualStyleBackColor = true;
            this.pinBtn.Click += new System.EventHandler(this.pinBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 112);
            this.Controls.Add(this.pinBtn);
            this.Controls.Add(this.targetIp);
            this.Controls.Add(this.targetIpLbl);
            this.Controls.Add(this.serverAddressTextBox);
            this.Controls.Add(this.getServerAddressButton);
            this.Controls.Add(this.generateBaselineButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "D2R Server Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateBaselineButton;
        private System.Windows.Forms.Button getServerAddressButton;
        private System.Windows.Forms.Label serverAddressTextBox;
        private System.Windows.Forms.Label targetIpLbl;
        private System.Windows.Forms.TextBox targetIp;
        private System.Windows.Forms.Button pinBtn;
    }
}

