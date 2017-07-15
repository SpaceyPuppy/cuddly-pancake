using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SmartDeviceProject1
{

    public partial class settingsForm:Form
    {
        public settingsForm()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            /*<summary>
            *I've used the StreamWriter class Example from MSDN for this bit with a few fingers-crossed changes.
              <summary> */

            //this creates the apiKey string from the key that was typed in the textbox on Settings
            string apiKey = theKey.Text;
            
            //this finds the path of AppData on the device and creates a string for us with the path called filePath
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Programs);

            //Now I'll try to get the text file contents to show in a MessageBox
            var keySave = MessageBox.Show(apiKey + " - Is this the correct API key to use?",
                "API Key Correct?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            
            //this could also be an if/else, but that code didn't work and this did, tbh. 
            switch (keySave)
            {
                case DialogResult.Yes:
                    using (StreamWriter outputFile = new StreamWriter(filePath + @"\APIkey.txt"))
                    {
                        outputFile.WriteLine(apiKey);
                    }
                    MessageBox.Show("API key set!","Key Set",MessageBoxButtons.OK,MessageBoxIcon.Asterisk,MessageBoxDefaultButton.Button1);
                    break;

                case DialogResult.No:
                    MessageBox.Show("Please check your API key","Check Key",MessageBoxButtons.OK,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1);
                    break;
            }
          

            /* string apiKey = Convert.ToString(GlobalStrings.APIKey);
            apiKey = theKey.Text;
            MessageBox.Show("This is now your API key: " + apiKey);
            keyShowBox.Refresh(); */
        }
        
        private void doneButton_Click(object sender, EventArgs e)
        {
            settingsForm frm1 = new settingsForm();
            frm1.Hide();
        }

        private void theKey_TextChanged(object sender, EventArgs e)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Programs);

        }

        private void clrKeyBox_Click(object sender, EventArgs e)
        {
            theKey.Text = String.Empty;
        }

        /*private void label3_ParentChanged(object sender, EventArgs e)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Programs);
            TextReader reder = File.OpenText(filePath + @"\APIkey.txt");
            label3.Text = reder.ReadToEnd();
        }
        */  //TODO: fix the FILEPATH to a documents path instead, that'd be good.
            //TODO: get this working :(
            //TODO: THAT IS ALL :D
    }
}