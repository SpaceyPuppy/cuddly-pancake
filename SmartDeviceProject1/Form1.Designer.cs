namespace SmartDeviceProject1
{
    partial class homeForm
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
            this.customers = new System.Windows.Forms.Button();
            this.tickets = new System.Windows.Forms.Button();
            this.assets = new System.Windows.Forms.Button();
            this.inventory = new System.Windows.Forms.Button();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuNewAsset = new System.Windows.Forms.MenuItem();
            this.menuSearchAsset = new System.Windows.Forms.MenuItem();
            this.menuListAsset = new System.Windows.Forms.MenuItem();
            this.menuSearchInventory = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuNewEstimate = new System.Windows.Forms.MenuItem();
            this.menuSearchEstimate = new System.Windows.Forms.MenuItem();
            this.menuListEstimate = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuNewInvoice = new System.Windows.Forms.MenuItem();
            this.menuSearchInvoice = new System.Windows.Forms.MenuItem();
            this.menuListInvoice = new System.Windows.Forms.MenuItem();
            this.menuSettings = new System.Windows.Forms.MenuItem();
            this.menuExit = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem26 = new System.Windows.Forms.MenuItem();
            this.menuItem27 = new System.Windows.Forms.MenuItem();
            this.menuItem28 = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // customers
            // 
            this.customers.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.customers.Location = new System.Drawing.Point(22, 216);
            this.customers.Name = "customers";
            this.customers.Size = new System.Drawing.Size(197, 62);
            this.customers.TabIndex = 0;
            this.customers.Text = "Customers";
            // 
            // tickets
            // 
            this.tickets.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tickets.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.tickets.Location = new System.Drawing.Point(22, 17);
            this.tickets.Name = "tickets";
            this.tickets.Size = new System.Drawing.Size(197, 62);
            this.tickets.TabIndex = 1;
            this.tickets.Text = "Tickets";
            // 
            // assets
            // 
            this.assets.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.assets.Location = new System.Drawing.Point(22, 150);
            this.assets.Name = "assets";
            this.assets.Size = new System.Drawing.Size(197, 62);
            this.assets.TabIndex = 2;
            this.assets.Text = "Assets";
            // 
            // inventory
            // 
            this.inventory.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.inventory.Location = new System.Drawing.Point(22, 83);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(197, 62);
            this.inventory.TabIndex = 4;
            this.inventory.Text = "Inventory";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.menuItem8);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItem2);
            this.menuItem1.MenuItems.Add(this.menuItem3);
            this.menuItem1.MenuItems.Add(this.menuItem4);
            this.menuItem1.MenuItems.Add(this.menuSearchInventory);
            this.menuItem1.MenuItems.Add(this.menuItem6);
            this.menuItem1.MenuItems.Add(this.menuItem7);
            this.menuItem1.MenuItems.Add(this.menuSettings);
            this.menuItem1.MenuItems.Add(this.menuExit);
            this.menuItem1.Text = "Menu";
            // 
            // menuItem2
            // 
            this.menuItem2.MenuItems.Add(this.menuItem10);
            this.menuItem2.MenuItems.Add(this.menuItem11);
            this.menuItem2.MenuItems.Add(this.menuItem15);
            this.menuItem2.Text = "Tickets";
            // 
            // menuItem10
            // 
            this.menuItem10.Text = "New";
            // 
            // menuItem11
            // 
            this.menuItem11.Text = "Search";
            // 
            // menuItem15
            // 
            this.menuItem15.Text = "View List";
            // 
            // menuItem3
            // 
            this.menuItem3.MenuItems.Add(this.menuItem12);
            this.menuItem3.MenuItems.Add(this.menuItem13);
            this.menuItem3.MenuItems.Add(this.menuItem14);
            this.menuItem3.Text = "Customers";
            // 
            // menuItem12
            // 
            this.menuItem12.Text = "New";
            // 
            // menuItem13
            // 
            this.menuItem13.Text = "Search";
            // 
            // menuItem14
            // 
            this.menuItem14.Text = "View List";
            // 
            // menuItem4
            // 
            this.menuItem4.MenuItems.Add(this.menuNewAsset);
            this.menuItem4.MenuItems.Add(this.menuSearchAsset);
            this.menuItem4.MenuItems.Add(this.menuListAsset);
            this.menuItem4.Text = "Assets";
            // 
            // menuNewAsset
            // 
            this.menuNewAsset.Text = "New";
            // 
            // menuSearchAsset
            // 
            this.menuSearchAsset.Text = "Search";
            // 
            // menuListAsset
            // 
            this.menuListAsset.Text = "View List";
            // 
            // menuSearchInventory
            // 
            this.menuSearchInventory.Text = "Inventory Search";
            // 
            // menuItem6
            // 
            this.menuItem6.MenuItems.Add(this.menuNewEstimate);
            this.menuItem6.MenuItems.Add(this.menuSearchEstimate);
            this.menuItem6.MenuItems.Add(this.menuListEstimate);
            this.menuItem6.Text = "Estimate";
            // 
            // menuNewEstimate
            // 
            this.menuNewEstimate.Text = "New";
            // 
            // menuSearchEstimate
            // 
            this.menuSearchEstimate.Text = "Search";
            // 
            // menuListEstimate
            // 
            this.menuListEstimate.Text = "View List";
            // 
            // menuItem7
            // 
            this.menuItem7.MenuItems.Add(this.menuNewInvoice);
            this.menuItem7.MenuItems.Add(this.menuSearchInvoice);
            this.menuItem7.MenuItems.Add(this.menuListInvoice);
            this.menuItem7.Text = "Invoice";
            // 
            // menuNewInvoice
            // 
            this.menuNewInvoice.Text = "New";
            // 
            // menuSearchInvoice
            // 
            this.menuSearchInvoice.Text = "Search";
            // 
            // menuListInvoice
            // 
            this.menuListInvoice.Text = "View List";
            // 
            // menuSettings
            // 
            this.menuSettings.Text = "Settings";
            // 
            // menuExit
            // 
            this.menuExit.Text = "Exit App";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.MenuItems.Add(this.menuItem26);
            this.menuItem8.MenuItems.Add(this.menuItem27);
            this.menuItem8.MenuItems.Add(this.menuItem28);
            this.menuItem8.Text = "Scan";
            // 
            // menuItem26
            // 
            this.menuItem26.Text = "Ticket";
            // 
            // menuItem27
            // 
            this.menuItem27.Text = "Asset";
            // 
            // menuItem28
            // 
            this.menuItem28.Text = "Customer";
            // 
            // homeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.assets);
            this.Controls.Add(this.tickets);
            this.Controls.Add(this.customers);
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "homeForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button customers;
        private System.Windows.Forms.Button tickets;
        private System.Windows.Forms.Button assets;
        private System.Windows.Forms.Button inventory;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuSearchInventory;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuSettings;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.MenuItem menuItem15;
        private System.Windows.Forms.MenuItem menuItem12;
        private System.Windows.Forms.MenuItem menuItem13;
        private System.Windows.Forms.MenuItem menuItem14;
        private System.Windows.Forms.MenuItem menuNewAsset;
        private System.Windows.Forms.MenuItem menuSearchAsset;
        private System.Windows.Forms.MenuItem menuListAsset;
        private System.Windows.Forms.MenuItem menuNewEstimate;
        private System.Windows.Forms.MenuItem menuSearchEstimate;
        private System.Windows.Forms.MenuItem menuListEstimate;
        private System.Windows.Forms.MenuItem menuNewInvoice;
        private System.Windows.Forms.MenuItem menuSearchInvoice;
        private System.Windows.Forms.MenuItem menuListInvoice;
        private System.Windows.Forms.MenuItem menuExit;
        private System.Windows.Forms.MenuItem menuItem26;
        private System.Windows.Forms.MenuItem menuItem27;
        private System.Windows.Forms.MenuItem menuItem28;
    }
}

