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
            this.label3 = new System.Windows.Forms.Label();
            this.settingsTechID = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.authStatPhrase = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.passBox = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.TextBox();
            this.clrKeyBox = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
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
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(8, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 74);
            this.label3.Text = "No API key set. \r\nSet one using the box above.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.ParentChanged += new System.EventHandler(this.label3_ParentChanged);
            // 
            // settingsTechID
            // 
            this.settingsTechID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.settingsTechID.Controls.Add(this.label2);
            this.settingsTechID.Controls.Add(this.authStatPhrase);
            this.settingsTechID.Controls.Add(this.button2);
            this.settingsTechID.Controls.Add(this.passBox);
            this.settingsTechID.Controls.Add(this.passLabel);
            this.settingsTechID.Controls.Add(this.userLabel);
            this.settingsTechID.Controls.Add(this.userBox);
            this.settingsTechID.Location = new System.Drawing.Point(0, 0);
            this.settingsTechID.Name = "settingsTechID";
            this.settingsTechID.Size = new System.Drawing.Size(472, 510);
            this.settingsTechID.Text = "Technician";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Courier New", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.Location = new System.Drawing.Point(174, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.Text = "OK";
            // 
            // authStatPhrase
            // 
            this.authStatPhrase.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular);
            this.authStatPhrase.Location = new System.Drawing.Point(3, 219);
            this.authStatPhrase.Name = "authStatPhrase";
            this.authStatPhrase.Size = new System.Drawing.Size(168, 20);
            this.authStatPhrase.Text = "Authentication Status:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Login to RepairShopr";
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(38, 120);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(164, 21);
            this.passBox.TabIndex = 2;
            // 
            // passLabel
            // 
            this.passLabel.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.passLabel.Location = new System.Drawing.Point(38, 91);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(164, 26);
            this.passLabel.Text = "Password:";
            this.passLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // userLabel
            // 
            this.userLabel.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.userLabel.Location = new System.Drawing.Point(38, 29);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(164, 26);
            this.userLabel.Text = "User:";
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(38, 58);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(164, 21);
            this.userBox.TabIndex = 0;
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
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label authStatPhrase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clrKeyBox;
        private System.Windows.Forms.Label label4;
    }
}