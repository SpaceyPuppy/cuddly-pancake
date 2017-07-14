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
            this.settingsUserAuth = new System.Windows.Forms.TabPage();
            this.authStatusBar = new System.Windows.Forms.StatusBar();
            this.label2 = new System.Windows.Forms.Label();
            this.authStatPhrase = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.passBox = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.TextBox();
            this.settingsCtrl.SuspendLayout();
            this.settingsAPI.SuspendLayout();
            this.settingsUserAuth.SuspendLayout();
            this.SuspendLayout();
            // 
            // theKey
            // 
            this.theKey.Location = new System.Drawing.Point(3, 44);
            this.theKey.MaxLength = 36;
            this.theKey.Name = "theKey";
            this.theKey.Size = new System.Drawing.Size(234, 21);
            this.theKey.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.Text = "API Key:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save Key";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // settingsCtrl
            // 
            this.settingsCtrl.Controls.Add(this.settingsAPI);
            this.settingsCtrl.Controls.Add(this.settingsUserAuth);
            this.settingsCtrl.Location = new System.Drawing.Point(0, 0);
            this.settingsCtrl.Name = "settingsCtrl";
            this.settingsCtrl.SelectedIndex = 0;
            this.settingsCtrl.Size = new System.Drawing.Size(240, 294);
            this.settingsCtrl.TabIndex = 4;
            this.settingsCtrl.Tag = "";
            // 
            // settingsAPI
            // 
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
            this.label3.Location = new System.Drawing.Point(8, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 74);
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.TextChanged += new System.EventHandler(this.theyKey_TextChanged);
            // 
            // settingsUserAuth
            // 
            this.settingsUserAuth.Controls.Add(this.authStatusBar);
            this.settingsUserAuth.Controls.Add(this.label2);
            this.settingsUserAuth.Controls.Add(this.authStatPhrase);
            this.settingsUserAuth.Controls.Add(this.button2);
            this.settingsUserAuth.Controls.Add(this.passBox);
            this.settingsUserAuth.Controls.Add(this.passLabel);
            this.settingsUserAuth.Controls.Add(this.userLabel);
            this.settingsUserAuth.Controls.Add(this.userBox);
            this.settingsUserAuth.Location = new System.Drawing.Point(0, 0);
            this.settingsUserAuth.Name = "settingsUserAuth";
            this.settingsUserAuth.Size = new System.Drawing.Size(232, 268);
            this.settingsUserAuth.Text = "User Authentication";
            // 
            // authStatusBar
            // 
            this.authStatusBar.Location = new System.Drawing.Point(0, 246);
            this.authStatusBar.Name = "authStatusBar";
            this.authStatusBar.Size = new System.Drawing.Size(232, 22);
            this.authStatusBar.Text = "authStatus";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Courier New", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.Location = new System.Drawing.Point(178, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.Text = "OK";
            // 
            // authStatPhrase
            // 
            this.authStatPhrase.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular);
            this.authStatPhrase.Location = new System.Drawing.Point(3, 197);
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
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.settingsCtrl);
            this.Name = "settingsForm";
            this.Text = "Settings";
            this.settingsCtrl.ResumeLayout(false);
            this.settingsAPI.ResumeLayout(false);
            this.settingsUserAuth.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox theKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl settingsCtrl;
        private System.Windows.Forms.TabPage settingsAPI;
        private System.Windows.Forms.TabPage settingsUserAuth;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label authStatPhrase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusBar authStatusBar;
        private System.Windows.Forms.Label label3;
    }
}