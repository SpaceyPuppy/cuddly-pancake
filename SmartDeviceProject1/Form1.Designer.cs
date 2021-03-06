﻿namespace SmartDeviceProject1
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
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuCust = new System.Windows.Forms.MenuItem();
            this.menuCustNew = new System.Windows.Forms.MenuItem();
            this.menuCustSearch = new System.Windows.Forms.MenuItem();
            this.menuCustList = new System.Windows.Forms.MenuItem();
            this.menuAsset = new System.Windows.Forms.MenuItem();
            this.menuAssetNew = new System.Windows.Forms.MenuItem();
            this.menuAssetSearch = new System.Windows.Forms.MenuItem();
            this.menuAssetList = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuInvoice = new System.Windows.Forms.MenuItem();
            this.menuInvoiceNew = new System.Windows.Forms.MenuItem();
            this.menuInvoiceSearch = new System.Windows.Forms.MenuItem();
            this.menuInvoiceList = new System.Windows.Forms.MenuItem();
            this.menuEstimate = new System.Windows.Forms.MenuItem();
            this.menuEstimateNew = new System.Windows.Forms.MenuItem();
            this.menuEstimateSearch = new System.Windows.Forms.MenuItem();
            this.menuEstimateList = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuInventory = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuSettings = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuExit = new System.Windows.Forms.MenuItem();
            this.scanMenu = new System.Windows.Forms.MenuItem();
            this.scanMenuTicket = new System.Windows.Forms.MenuItem();
            this.scanMenuAsset = new System.Windows.Forms.MenuItem();
            this.scanMenuCustomer = new System.Windows.Forms.MenuItem();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customersButton
            // 
            this.customersButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.customersButton.Location = new System.Drawing.Point(22, 196);
            this.customersButton.Name = "customersButton";
            this.customersButton.Size = new System.Drawing.Size(98, 62);
            this.customersButton.TabIndex = 0;
            this.customersButton.Text = "Customers";
            // 
            // ticketsButton
            // 
            this.ticketsButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ticketsButton.Location = new System.Drawing.Point(22, 128);
            this.ticketsButton.Name = "ticketsButton";
            this.ticketsButton.Size = new System.Drawing.Size(98, 62);
            this.ticketsButton.TabIndex = 1;
            this.ticketsButton.Text = "Tickets";
            this.ticketsButton.Click += new System.EventHandler(this.ticketsButton_Click);
            // 
            // assetsButton
            // 
            this.assetsButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.assetsButton.Location = new System.Drawing.Point(121, 196);
            this.assetsButton.Name = "assetsButton";
            this.assetsButton.Size = new System.Drawing.Size(98, 62);
            this.assetsButton.TabIndex = 2;
            this.assetsButton.Text = "Assets";
            // 
            // inventoryButton
            // 
            this.inventoryButton.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.inventoryButton.Location = new System.Drawing.Point(121, 128);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(98, 62);
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
            this.menu.MenuItems.Add(this.menuItem1);
            this.menu.MenuItems.Add(this.menuCust);
            this.menu.MenuItems.Add(this.menuAsset);
            this.menu.MenuItems.Add(this.menuItem3);
            this.menu.MenuItems.Add(this.menuInvoice);
            this.menu.MenuItems.Add(this.menuEstimate);
            this.menu.MenuItems.Add(this.menuItem4);
            this.menu.MenuItems.Add(this.menuInventory);
            this.menu.MenuItems.Add(this.menuItem2);
            this.menu.MenuItems.Add(this.menuSettings);
            this.menu.MenuItems.Add(this.menuItem5);
            this.menu.MenuItems.Add(this.menuExit);
            this.menu.Text = "Menu";
            this.menu.Click += new System.EventHandler(this.menu_Click);
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
            // menuItem1
            // 
            this.menuItem1.Text = "-";
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
            // menuItem3
            // 
            this.menuItem3.Text = "-";
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
            // menuItem4
            // 
            this.menuItem4.Text = "-";
            // 
            // menuInventory
            // 
            this.menuInventory.Text = "Inventory Search";
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "-";
            // 
            // menuSettings
            // 
            this.menuSettings.Text = "Settings";
            this.menuSettings.Click += new System.EventHandler(this.menuSettings_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Text = "-";
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
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Lime;
            this.searchButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.searchButton.Location = new System.Drawing.Point(22, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(197, 50);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // homeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(257, 268);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.inventoryButton);
            this.Controls.Add(this.assetsButton);
            this.Controls.Add(this.ticketsButton);
            this.Controls.Add(this.customersButton);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "homeForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.homeForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.homeForm_KeyDown);
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
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.Button searchButton;
    }
}

