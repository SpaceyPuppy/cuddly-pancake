namespace SmartDeviceProject1
{
    partial class settingsForm
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
            this.theKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.settingsCtrl = new System.Windows.Forms.TabControl();
            this.settingsAPI = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.clrKeyBox = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.settingsTechID = new System.Windows.Forms.TabPage();
            this.testSendButton = new System.Windows.Forms.Button();
            this.settingsCtrl.SuspendLayout();
            this.settingsAPI.SuspendLayout();
            this.settingsTechID.SuspendLayout();
            this.SuspendLayout();
            // 
            // theKey
            // 
            this.theKey.Location = new System.Drawing.Point(3, 41);
            this.theKey.MaxLength = 36;
            this.theKey.Name = "theKey";
            this.theKey.Size = new System.Drawing.Size(234, 21);
            this.theKey.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.Text = "API Key:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(69, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // settingsCtrl
            // 
            this.settingsCtrl.Controls.Add(this.settingsAPI);
            this.settingsCtrl.Controls.Add(this.settingsTechID);
            this.settingsCtrl.Location = new System.Drawing.Point(0, 0);
            this.settingsCtrl.Name = "settingsCtrl";
            this.settingsCtrl.SelectedIndex = 0;
            this.settingsCtrl.Size = new System.Drawing.Size(240, 294);
            this.settingsCtrl.TabIndex = 4;
            this.settingsCtrl.Tag = "";
            // 
            // settingsAPI
            // 
            this.settingsAPI.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.settingsAPI.Controls.Add(this.button3);
            this.settingsAPI.Controls.Add(this.label4);
            this.settingsAPI.Controls.Add(this.clrKeyBox);
            this.settingsAPI.Controls.Add(this.label3);
            this.settingsAPI.Controls.Add(this.label1);
            this.settingsAPI.Controls.Add(this.button1);
            this.settingsAPI.Controls.Add(this.theKey);
            this.settingsAPI.Location = new System.Drawing.Point(0, 0);
            this.settingsAPI.Name = "settingsAPI";
            this.settingsAPI.Size = new System.Drawing.Size(240, 271);
            this.settingsAPI.Text = "API";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(178, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 20);
            this.button3.TabIndex = 9;
            this.button3.Text = "Refresh";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(70, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.Text = "Current Key:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // clrKeyBox
            // 
            this.clrKeyBox.BackColor = System.Drawing.Color.LightCoral;
            this.clrKeyBox.Font = new System.Drawing.Font("Tahoma", 40F, System.Drawing.FontStyle.Regular);
            this.clrKeyBox.Location = new System.Drawing.Point(3, 66);
            this.clrKeyBox.Name = "clrKeyBox";
            this.clrKeyBox.Size = new System.Drawing.Size(60, 60);
            this.clrKeyBox.TabIndex = 6;
            this.clrKeyBox.Text = "X";
            this.clrKeyBox.Click += new System.EventHandler(this.clrKeyBox_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(8, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 74);
            this.label3.Text = "No API key set. \r\nSet one using the box above.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // settingsTechID
            // 
            this.settingsTechID.BackColor = System.Drawing.Color.White;
            this.settingsTechID.Controls.Add(this.testSendButton);
            this.settingsTechID.Location = new System.Drawing.Point(0, 0);
            this.settingsTechID.Name = "settingsTechID";
            this.settingsTechID.Size = new System.Drawing.Size(240, 271);
            this.settingsTechID.Text = "Technician";
            // 
            // testSendButton
            // 
            this.testSendButton.Location = new System.Drawing.Point(62, 79);
            this.testSendButton.Name = "testSendButton";
            this.testSendButton.Size = new System.Drawing.Size(107, 20);
            this.testSendButton.TabIndex = 0;
            this.testSendButton.Text = "Send Test Req.";
            this.testSendButton.Click += new System.EventHandler(this.testSendButton_Click);
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.settingsCtrl);
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "settingsForm";
            this.Text = "Settings";
            this.settingsCtrl.ResumeLayout(false);
            this.settingsAPI.ResumeLayout(false);
            this.settingsTechID.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox theKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl settingsCtrl;
        private System.Windows.Forms.TabPage settingsAPI;
        private System.Windows.Forms.TabPage settingsTechID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clrKeyBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button testSendButton;
    }
}