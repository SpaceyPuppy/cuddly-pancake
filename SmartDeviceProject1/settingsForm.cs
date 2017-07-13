using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartDeviceProject1
{
    public partial class settingsForm : Form
    {
        public settingsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string apiKey;
            apiKey = theKey.Text;
            MessageBox.Show("This is now your API key: " + apiKey);
            keyShowBox.Refresh();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void keyShowBox_ParentChanged(object sender, EventArgs e)
        {
            
        }

    }
}