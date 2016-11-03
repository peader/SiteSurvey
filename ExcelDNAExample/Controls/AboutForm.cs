/* 
 * SiteSurvey
 * https://github.com/peader/SiteSurvey/
 * 
 * Copyright 2016, Peter Mahady
 * Licensed under the MIT license
 * http://www.opensource.org/licenses/mit-license.php
 */

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ExcelDNAExample.Controls
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            //this.VersionLabel.Text = "Version " + ASNZS1170Functions.ASNZS1170Functions.GetCurrentVersion();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {

        }
        private void UrlLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel label = (LinkLabel)sender;
            Process.Start(label.Text);
        }

        private void MailLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel label = (LinkLabel)sender;
            Process.Start("mailto:" + label.Text);
        }

        private void VersionLabel_Click(object sender, EventArgs e)
        {

        }

        private void MITLicenceLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel label = (LinkLabel)sender;
            Process.Start(label.Text);
        }
    }
}
