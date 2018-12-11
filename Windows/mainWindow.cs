// Created by Norbert Lubaszka
// Contact: norbert.lubaszka@gmail.com
// All rights reserved ©
// If you want to use the source code contact me
                                                                            // References
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Numbers_Generator
{
    public partial class mainWindow : Form
    {
        public mainWindow()                                                 // This method run when window open
        {
            InitializeComponent();                                          // Initialize components
        }

        private void exitLabel_Click(object sender, EventArgs e)            // This method run when exit label clicked
        {
            Application.Exit();                                             // Closing application
        }

        private void minimalizedLabel_Click(object sender, EventArgs e)     // This method run when minimalized label clicked
        {
            this.WindowState = FormWindowState.Minimized;                   // Minimlized window
        }

        private void dashboardButton_Click(object sender, EventArgs e)      // This method run when dashboard button clicked
        {
            generatorButton.ForeColor = Color.Lime;                         // Changeing generate button color
            dashboardButton.ForeColor = Color.Blue;                         // Changing dashboard button color
            currentPanelLabel.Text = "Dashboard";                           // Changing current panel text
            dashboardUC.BringToFront();                                     //  Bringing dashboard to front
        }

        private void generatorButton_Click(object sender, EventArgs e)      // This method run when generator button clicked
        {
            dashboardButton.ForeColor = Color.Lime;                         // Changing dashboard color
            generatorButton.ForeColor = Color.Blue;                         // Changeing generator color
            currentPanelLabel.Text = "Generator";                           // Changing current panel text
            generatorUC.BringToFront();                                     // Bringing generator to front
        }
    }
}
