namespace SmartDeviceProject1
{
    partial class settingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.doneButton = new System.Windows.Forms.MenuItem();
            this.theKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CurrentKeyLabel = new System.Windows.Forms.Label();
            this.keyShowBox = new System.Windows.Forms.Label();
            this.settingsTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.settingsTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.doneButton);
            // 
            // doneButton
            // 
            this.doneButton.Text = "Done";
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
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.Text = "New API Key:";
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
            // CurrentKeyLabel
            // 
            this.CurrentKeyLabel.Location = new System.Drawing.Point(84, 159);
            this.CurrentKeyLabel.Name = "CurrentKeyLabel";
            this.CurrentKeyLabel.Size = new System.Drawing.Size(100, 20);
            this.CurrentKeyLabel.Text = "Current Key:";
            // 
            // keyShowBox
            // 
            this.keyShowBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.keyShowBox.Location = new System.Drawing.Point(4, 179);
            this.keyShowBox.Name = "keyShowBox";
            this.keyShowBox.Size = new System.Drawing.Size(233, 54);
            this.keyShowBox.ParentChanged += new System.EventHandler(this.keyShowBox_ParentChanged);
            // 
            // settingsTabs
            // 
            this.settingsTabs.Controls.Add(this.tabPage1);
            this.settingsTabs.Controls.Add(this.tabPage2);
            this.settingsTabs.Controls.Add(this.tabPage3);
            this.settingsTabs.Location = new System.Drawing.Point(0, 0);
            this.settingsTabs.Name = "settingsTabs";
            this.settingsTabs.SelectedIndex = 0;
            this.settingsTabs.Size = new System.Drawing.Size(240, 268);
            this.settingsTabs.TabIndex = 4;
            this.settingsTabs.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CurrentKeyLabel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.theKey);
            this.tabPage1.Controls.Add(this.keyShowBox);
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(240, 245);
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(240, 245);
            this.tabPage2.Text = "tabPage2";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(240, 245);
            this.tabPage3.Text = "tabPage3";
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.settingsTabs);
            this.Menu = this.mainMenu1;
            this.Name = "settingsForm";
            this.Text = "Settings";
            this.settingsTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox theKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label CurrentKeyLabel;
        private System.Windows.Forms.Label keyShowBox;
        private System.Windows.Forms.MenuItem doneButton;
        private System.Windows.Forms.TabControl settingsTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}