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
           /* var doc = new XmlDocument();
            doc.Load(ProgramData/apiKey.xml);
            var node = doc.SelectSingleNode(@"config/webservices/webservice/value");
            node.InnerText = theKey.Text;
            doc.Save(fileName);

            MessageBox.Show("This is now your API key: " + apiKey); */
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void theyKey_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "Your API Key: ";
        }

    }
}