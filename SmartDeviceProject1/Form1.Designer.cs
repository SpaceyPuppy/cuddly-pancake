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
            this.customersButton = new System.Windows.Forms.Button();
            this.ticketsButton = new System.Windows.Forms.Button();
            this.assetsButton = new System.Windows.Forms.Button();
            this.inventoryButton = new System.Windows.Forms.Button();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menu = new System.Windows.Forms.MenuItem();
            this.menuTicket = new System.Windows.Forms.MenuItem();
            this.menuTicketNew = new System.Windows.Forms.MenuItem();
            this.menuTicketSearch = new System.Windows.Forms.MenuItem();
            this.menuTicketList = new System.Windows.Forms.MenuItem();
            this.menuCust = new System.Windows.Forms.MenuItem();
            this.menuCustNew = new System.Windows.Forms.MenuItem();
            this.menuCustSearch = new System.Windows.Forms.MenuItem();
            this.menuCustList = new System.Windows.Forms.MenuItem();
            this.menuAsset = new System.Windows.Forms.MenuItem();
            this.menuAssetNew = new System.Windows.Forms.MenuItem();
            this.menuAssetSearch = new System.Windows.Forms.MenuItem();
            this.menuAssetList = new System.Windows.Forms.MenuItem();
            this.menuInventory = new System.Windows.Forms.MenuItem();
            this.menuEstimate = new System.Windows.Forms.MenuItem();
            this.menuEstimateNew = new System.Windows.Forms.MenuItem();
            this.menuEstimateSearch = new System.Windows.Forms.MenuItem();
            this.menuEstimateList = new System.Windows.Forms.MenuItem();
            this.menuInvoice = new System.Windows.Forms.MenuItem();
            this.menuInvoiceNew = new System.Windows.Forms.MenuItem();
            this.menuInvoiceSearch = new System.Windows.Forms.MenuItem();
            this.menuInvoiceList = new System.Windows.Forms.MenuItem();
            this.menuSettings = new System.Windows.Forms.MenuItem();
            this.menuExit = new System.Windows.Forms.MenuItem();
            this.scanMenu = new System.Windows.Forms.MenuItem();
            this.scanMenuTicket = new System.Windows.Forms.MenuItem();
            this.scanMenuAsset = new System.Windows.Forms.MenuItem();
            this.scanMenuCustomer = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // customersButton
            // 
            this.customersButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.customersButton.Location = new System.Drawing.Point(22, 216);
            this.customersButton.Name = "customersButton";
            this.customersButton.Size = new System.Drawing.Size(197, 62);
            this.customersButton.TabIndex = 0;
            this.customersButton.Text = "Customers";
            // 
            // ticketsButton
            // 
            this.ticketsButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ticketsButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ticketsButton.Location = new System.Drawing.Point(22, 17);
            this.ticketsButton.Name = "ticketsButton";
            this.ticketsButton.Size = new System.Drawing.Size(197, 62);
            this.ticketsButton.TabIndex = 1;
            this.ticketsButton.Text = "Tickets";
            // 
            // assetsButton
            // 
            this.assetsButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.assetsButton.Location = new System.Drawing.Point(22, 150);
            this.assetsButton.Name = "assetsButton";
            this.assetsButton.Size = new System.Drawing.Size(197, 62);
            this.assetsButton.TabIndex = 2;
            this.assetsButton.Text = "Assets";
            // 
            // inventoryButton
            // 
            this.inventoryButton.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.inventoryButton.Location = new System.Drawing.Point(22, 83);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(197, 62);
            this.inventoryButton.TabIndex = 4;
            this.inventoryButton.Text = "Inventory";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menu);
            this.mainMenu1.MenuItems.Add(this.scanMenu);
            // 
            // menu
            // 
            this.menu.MenuItems.Add(this.menuTicket);
            this.menu.MenuItems.Add(this.menuCust);
            this.menu.MenuItems.Add(this.menuAsset);
            this.menu.MenuItems.Add(this.menuInventory);
            this.menu.MenuItems.Add(this.menuEstimate);
            this.menu.MenuItems.Add(this.menuInvoice);
            this.menu.MenuItems.Add(this.menuSettings);
            this.menu.MenuItems.Add(this.menuExit);
            this.menu.Text = "Menu";
            // 
            // menuTicket
            // 
            this.menuTicket.MenuItems.Add(this.menuTicketNew);
            this.menuTicket.MenuItems.Add(this.menuTicketSearch);
            this.menuTicket.MenuItems.Add(this.menuTicketList);
            this.menuTicket.Text = "Tickets";
            // 
            // menuTicketNew
            // 
            this.menuTicketNew.Text = "New";
            // 
            // menuTicketSearch
            // 
            this.menuTicketSearch.Text = "Search";
            // 
            // menuTicketList
            // 
            this.menuTicketList.Text = "View List";
            // 
            // menuCust
            // 
            this.menuCust.MenuItems.Add(this.menuCustNew);
            this.menuCust.MenuItems.Add(this.menuCustSearch);
            this.menuCust.MenuItems.Add(this.menuCustList);
            this.menuCust.Text = "Customers";
            // 
            // menuCustNew
            // 
            this.menuCustNew.Text = "New";
            // 
            // menuCustSearch
            // 
            this.menuCustSearch.Text = "Search";
            // 
            // menuCustList
            // 
            this.menuCustList.Text = "View List";
            // 
            // menuAsset
            // 
            this.menuAsset.MenuItems.Add(this.menuAssetNew);
            this.menuAsset.MenuItems.Add(this.menuAssetSearch);
            this.menuAsset.MenuItems.Add(this.menuAssetList);
            this.menuAsset.Text = "Assets";
            // 
            // menuAssetNew
            // 
            this.menuAssetNew.Text = "New";
            // 
            // menuAssetSearch
            // 
            this.menuAssetSearch.Text = "Search";
            // 
            // menuAssetList
            // 
            this.menuAssetList.Text = "View List";
            // 
            // menuInventory
            // 
            this.menuInventory.Text = "Inventory Search";
            // 
            // menuEstimate
            // 
            this.menuEstimate.MenuItems.Add(this.menuEstimateNew);
            this.menuEstimate.MenuItems.Add(this.menuEstimateSearch);
            this.menuEstimate.MenuItems.Add(this.menuEstimateList);
            this.menuEstimate.Text = "Estimate";
            // 
            // menuEstimateNew
            // 
            this.menuEstimateNew.Text = "New";
            // 
            // menuEstimateSearch
            // 
            this.menuEstimateSearch.Text = "Search";
            // 
            // menuEstimateList
            // 
            this.menuEstimateList.Text = "View List";
            // 
            // menuInvoice
            // 
            this.menuInvoice.MenuItems.Add(this.menuInvoiceNew);
            this.menuInvoice.MenuItems.Add(this.menuInvoiceSearch);
            this.menuInvoice.MenuItems.Add(this.menuInvoiceList);
            this.menuInvoice.Text = "Invoice";
            // 
            // menuInvoiceNew
            // 
            this.menuInvoiceNew.Text = "New";
            // 
            // menuInvoiceSearch
            // 
            this.menuInvoiceSearch.Text = "Search";
            // 
            // menuInvoiceList
            // 
            this.menuInvoiceList.Text = "View List";
            // 
            // menuSettings
            // 
            this.menuSettings.Text = "Settings";
            // 
            // menuExit
            // 
            this.menuExit.Text = "Exit App";
            // 
            // scanMenu
            // 
            this.scanMenu.MenuItems.Add(this.scanMenuTicket);
            this.scanMenu.MenuItems.Add(this.scanMenuAsset);
            this.scanMenu.MenuItems.Add(this.scanMenuCustomer);
            this.scanMenu.Text = "Scan";
            // 
            // scanMenuTicket
            // 
            this.scanMenuTicket.Text = "Ticket";
            // 
            // scanMenuAsset
            // 
            this.scanMenuAsset.Text = "Asset";
            // 
            // scanMenuCustomer
            // 
            this.scanMenuCustomer.Text = "Customer";
            // 
            // homeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.inventoryButton);
            this.Controls.Add(this.assetsButton);
            this.Controls.Add(this.ticketsButton);
            this.Controls.Add(this.customersButton);
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "homeForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.homeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button customersButton;
        private System.Windows.Forms.Button ticketsButton;
        private System.Windows.Forms.Button assetsButton;
        private System.Windows.Forms.Button inventoryButton;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menu;
        private System.Windows.Forms.MenuItem menuTicket;
        private System.Windows.Forms.MenuItem menuCust;
        private System.Windows.Forms.MenuItem menuAsset;
        private System.Windows.Forms.MenuItem menuInventory;
        private System.Windows.Forms.MenuItem menuEstimate;
        private System.Windows.Forms.MenuItem menuInvoice;
        private System.Windows.Forms.MenuItem scanMenu;
        private System.Windows.Forms.MenuItem menuSettings;
        private System.Windows.Forms.MenuItem menuTicketNew;
        private System.Windows.Forms.MenuItem menuTicketSearch;
        private System.Windows.Forms.MenuItem menuTicketList;
        private System.Windows.Forms.MenuItem menuCustNew;
        private System.Windows.Forms.MenuItem menuCustSearch;
        private System.Windows.Forms.MenuItem menuCustList;
        private System.Windows.Forms.MenuItem menuAssetNew;
        private System.Windows.Forms.MenuItem menuAssetSearch;
        private System.Windows.Forms.MenuItem menuAssetList;
        private System.Windows.Forms.MenuItem menuEstimateNew;
        private System.Windows.Forms.MenuItem menuEstimateSearch;
        private System.Windows.Forms.MenuItem menuEstimateList;
        private System.Windows.Forms.MenuItem menuInvoiceNew;
        private System.Windows.Forms.MenuItem menuInvoiceSearch;
        private System.Windows.Forms.MenuItem menuInvoiceList;
        private System.Windows.Forms.MenuItem menuExit;
        private System.Windows.Forms.MenuItem scanMenuTicket;
        private System.Windows.Forms.MenuItem scanMenuAsset;
        private System.Windows.Forms.MenuItem scanMenuCustomer;
    }
}

