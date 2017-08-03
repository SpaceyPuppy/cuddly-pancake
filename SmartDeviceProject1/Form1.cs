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
    public partial class homeForm : Form
    {
        public homeForm()
        {
            InitializeComponent();
        }

        private void homeForm_Load(object sender, EventArgs e)
        {

        }

        private void menuSettings_Click(object sender, EventArgs e)
        {
            Form settingsForm = new settingsForm();
            settingsForm.Show();
        }

        private void menu_Click(object sender, EventArgs e)
        {

        }

        private void ticketsButton_Click(object sender, EventArgs e)
        {

        }


    }
}