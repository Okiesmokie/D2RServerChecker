
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
            this.serverAddressTextLabel = new System.Windows.Forms.Label();
            this.serverAddressTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // generateBaselineButton
            // 
            this.generateBaselineButton.Location = new System.Drawing.Point(12, 12);
            this.generateBaselineButton.Name = "generateBaselineButton";
            this.generateBaselineButton.Size = new System.Drawing.Size(329, 23);
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
            this.getServerAddressButton.Size = new System.Drawing.Size(329, 23);
            this.getServerAddressButton.TabIndex = 1;
            this.getServerAddressButton.Text = "Get server address";
            this.getServerAddressButton.UseVisualStyleBackColor = true;
            this.getServerAddressButton.Click += new System.EventHandler(this.getServerAddressButton_Click);
            // 
            // serverAddressTextLabel
            // 
            this.serverAddressTextLabel.AutoSize = true;
            this.serverAddressTextLabel.Location = new System.Drawing.Point(12, 77);
            this.serverAddressTextLabel.Name = "serverAddressTextLabel";
            this.serverAddressTextLabel.Size = new System.Drawing.Size(65, 15);
            this.serverAddressTextLabel.TabIndex = 2;
            this.serverAddressTextLabel.Text = "IP Address:";
            // 
            // serverAddressTextBox
            // 
            this.serverAddressTextBox.Location = new System.Drawing.Point(83, 74);
            this.serverAddressTextBox.Name = "serverAddressTextBox";
            this.serverAddressTextBox.ReadOnly = true;
            this.serverAddressTextBox.Size = new System.Drawing.Size(258, 23);
            this.serverAddressTextBox.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 112);
            this.Controls.Add(this.serverAddressTextBox);
            this.Controls.Add(this.serverAddressTextLabel);
            this.Controls.Add(this.getServerAddressButton);
            this.Controls.Add(this.generateBaselineButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "D2R Server Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateBaselineButton;
        private System.Windows.Forms.Button getServerAddressButton;
        private System.Windows.Forms.Label serverAddressTextLabel;
        private System.Windows.Forms.TextBox serverAddressTextBox;
    }
}

