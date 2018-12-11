// Created by Norbert Lubaszka
// Contact: norbert.lubaszka@gmail.com
// All rights reserved ©
// If you want to use the source code contact me
                                                                                                        // References
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;                                                                                        // Allow to make interaction with files

namespace Random_Numbers_Generator
{
    public partial class generator : UserControl
    {
        int fromNumber;                                                                                 // Variable with hold from with number we will generate
        int toNumber;                                                                                   // Variable with hold to with number we will generate
        uint howManyNumbers;                                                                            // Variable with hold how many numbers we are going to generate
        uint intervalBetweenGenerating;                                                                 // Variable with hold interval between generating each number
        string signBetweenNumbers;                                                                      // Variable with hold sign with will be between numbers
        int generated = 0;                                                                              // Variable with help to recognize how many numbers have been generated
        public generator()                                                                              // This method run when user control open
        {
            InitializeComponent();                                                                      // Initializeing components
        }

        private void generateButton_Click(object sender, EventArgs e)                                   // This method run when generate button clicked
        {
            try                                                                                         // Catching exceptions while converting values from gaps
            {
                fromNumber = Convert.ToInt32(fromTB.Text);                                              // Converting
                toNumber = Convert.ToInt32(toTB.Text);                                                  // Converting
                howManyNumbers = Convert.ToUInt32(howManyTB.Text);                                      // Converting
                intervalBetweenGenerating = Convert.ToUInt32(intervalTB.Text);                          // Converting
                signBetweenNumbers = signTB.Text;                                                       // Converting
                stopButton.Enabled = true;
                clearButton.Enabled = false;                                                            // Changing enable status for buttons and else
                saveButton.Enabled = false;                                                             // Changing enable status for buttons and else
                informCB.Enabled = false;                                                               // Changing enable status for buttons and else
                generateButton.Enabled = false;                                                         // Changing enable status for buttons and else
                generateLabel.Text = "Wygenerowano: " + generated.ToString() +                          // Changing text with inform about how many numbers have been generated
                    " / " + howManyNumbers.ToString();                                                  // Changing text with inform about how many numbers have been generated
                generateTimer.Interval = Convert.ToInt32(intervalBetweenGenerating);                    // Seting timer interval
                generateTimer.Start();                                                                  // Starting timer
            }
            catch (Exception)                                                                           // If some exception catched
            {
                MessageBox.Show("Some gap is empty or had wrong format !",                              // Inform user about some empty gaps or wrong format
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                               // Seting buttons and icon for messagebox
            }
        }

        private void stopButton_Click(object sender, EventArgs e)                                       // This method run after stop button clicked
        {
            generateButton.Enabled = true;                                                              // Changing enable status for buttons and else
            clearButton.Enabled = true;                                                                 // Changing enable status for buttons and else
            saveButton.Enabled = true;                                                                  // Changing enable status for buttons and else
            informCB.Enabled = true;                                                                    // Changing enable status for buttons and else
            generateTimer.Stop();                                                                       // Stoping generate timer
            stopButton.Enabled = false;                                                                 // Changing enable status for buttons and else
        }

        private void clearButton_Click(object sender, EventArgs e)                                      // This method run after clear button clicked
        {
            resultRTB.Text = "";                                                                        // Clearing text of result rich text box
        }

        private void saveButton_Click(object sender, EventArgs e)                                       // This method run after save button clicked
        {
            if(saveDialog.ShowDialog() == DialogResult.OK)                                              // If dialog result is ok
            {
                try                                                                                     // Holding errors while saveing datas to file
                {
                    File.WriteAllText(saveDialog.FileName, resultRTB.Text);                             // Saveing result rich text box text to chosen file
                }
                catch (Exception)                                                                       // If some errors catched
                {
                    MessageBox.Show("Error while saveing file", "Error",                                // Inform user about error while saveing datas
                        MessageBoxButtons.OK, MessageBoxIcon.Error);                                    // Seting buttons and icon
                }
            }
            else                                                                                        // If dialog result is not ok
            {
                MessageBox.Show("Error while opening file", "Error",                                    // Inform user about something wrong with file
                    MessageBoxButtons.OK, MessageBoxIcon.Error);                                        // Seting buttons and icon
            }
        }

        private void generateTimer_Tick(object sender, EventArgs e)                                     // This method run when timer start
        {
            if(generated == howManyNumbers)                                                             // If generater numbers is equal to how many numbers we have to generate
            {
                if(informCB.Checked == true)                                                            // If inform check box is checked
                {
                    notifyIcon.Icon = SystemIcons.Application;                                          // Showing notify for user
                    notifyIcon.ShowBalloonTip(5000, "Generating end",                                   // Seting notify text and other
                        "Genereted " + howManyNumbers.ToString() + " numbers", ToolTipIcon.Info);       // Seting notify text and other
                }
                generated = 0;                                                                          // Seting generated as 0
                informCB.Enabled = true;                                                                // Changing enable status for buttons and else
                generateButton.Enabled = true;                                                          // Changing enable status for buttons and else
                clearButton.Enabled = true;                                                             // Changing enable status for buttons and else
                saveButton.Enabled = true;                                                              // Changing enable status for buttons and else
                stopButton.Enabled = false;                                                             // Changing enable status for buttons and else
                generateTimer.Stop();                                                                   // Stoping timer with is generating numbers
            }
            else                                                                                        // If generater numbers is not equal to how many numbers we have to generate
            {
                Random random = new Random();                                                           // Creating new object of Random
                int value = random.Next(fromNumber, toNumber);                                          // Creating random number from given number to given number and puting it inside variable
                generated = generated + 1;                                                              // Adding 1 to generated numbers
                generateLabel.Text = "Wygenerowano: " + generated.ToString() +                          // Changing generated numbers with new value
                    " / " + howManyNumbers.ToString();                                                  // Changing generated numbers with new value
                if (signBetweenNumbers != string.Empty)                                                 // If sign between numbers had been given
                {
                    resultRTB.Text = resultRTB.Text + value.ToString() + signBetweenNumbers;            // Updating result rich text box with new random value and given sign between each number
                }
                else                                                                                    // If sign was not given
                {
                    resultRTB.Text = resultRTB.Text + " " + value.ToString();                           // Updating result rich text box with new random value and space between each number
                }
            }
        }
    }
}
