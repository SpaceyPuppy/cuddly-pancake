using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Web.Extensions;
using Newtonsoft.Json

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
            //string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Programs);
            string filePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);

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
                    MessageBox.Show("API key set!", "Key Set", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    break;

                case DialogResult.No:
                    MessageBox.Show("Please check your API key", "Check Key", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    break;
            }

        } //

        private void doneButton_Click(object sender, EventArgs e)
        {

        } //does nothing ? use ok button


        private void clrKeyBox_Click(object sender, EventArgs e)
        {
            theKey.Text = String.Empty;
        } //clears the key box to type again

        private void button3_Click(object sender, EventArgs e)
        {
            string filePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);

            if (File.Exists(filePath + @"\APIkey.txt"))
            {
                using (TextReader reder = File.OpenText(filePath + @"\APIkey.txt"))
                {
                    label3.Text = reder.ReadToEnd();
                }
            }
            else
            {
                MessageBox.Show("No API key set. Please set one using the box above.");
            }

        }  //refresh API key display

        //TECHNICIAN PAGE CODE BELOW THIS LINE

        private void testSendButton_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"\APIkey.txt");
            var apiKey = sr.ReadToEnd();
                                                    // set this address to whatever, /me /leads etc
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://chrisphelan.repairshopr.com/api/v1/me");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";  // ****CHANGE TO POST/GET/PUT ETC*****

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {    //set json variables under apiKey below
                string json = new JavaScriptSerializer().Serialize(new
                {
                    apiKey = apiKey
                });

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                //set the label box to the output of the API
                apiResponse.Text = streamReader.ReadToEnd();
            }
        }

        private void apiResponse_ParentChanged(object sender, EventArgs e)
        {

        }
    }
}