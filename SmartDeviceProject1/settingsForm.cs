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

    public partial class settingsForm : Form
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
            var keySave = MessageBox.Show(TEXT; //DO THIS ASDASDASDGHASDGHSDFASDHFASDHFASDHFASDFHADSFHASDFHADFHFASDF           
            
            // this will show a question mark icon in a blue circle.

                        //the following can also be handled as a if/else for simplicity, I chose to cover all bases

            switch(keySave)
            {
                case DialogResult.Yes:                      //yes pressed
                    MessageBox.Show("Key saved.", "Key Saved.");          //this shows a dialog telling the user it saved
                                                            //the following actually saves/overwrites the key
                    using(StreamWriter outputFile = new StreamWriter(filePath + @"\APIkey.txt")) {
                        outputFile.WriteLine(apiKey);
                    }

            }

            /* string apiKey = Convert.ToString(GlobalStrings.APIKey);
            apiKey = theKey.Text;
            MessageBox.Show("This is now your API key: " + apiKey);
            keyShowBox.Refresh(); */
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