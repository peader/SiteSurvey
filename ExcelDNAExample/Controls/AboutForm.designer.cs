using System.Drawing;
namespace ExcelDNAExample.Controls
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.Copyrightlabel = new System.Windows.Forms.Label();
            this.ExcelDnaLabel = new System.Windows.Forms.Label();
            this.ExcelDnaDownloadLinkLabel = new System.Windows.Forms.LinkLabel();
            this.ExcelDnaCopyrightLabel = new System.Windows.Forms.Label();
            this.ExcelDnaLicenseLabel = new System.Windows.Forms.Label();
            this.ExcelDnaLicenseLinkLabel = new System.Windows.Forms.LinkLabel();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.LicenseLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.MailLinkLabel = new System.Windows.Forms.LinkLabel();
            this.MITLicenceLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Copyrightlabel
            // 
            this.Copyrightlabel.AutoSize = true;
            this.Copyrightlabel.Location = new System.Drawing.Point(9, 70);
            this.Copyrightlabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.Copyrightlabel.Name = "Copyrightlabel";
            this.Copyrightlabel.Size = new System.Drawing.Size(171, 13);
            this.Copyrightlabel.TabIndex = 4;
            this.Copyrightlabel.Text = "Copyright © 2016 Peter Mahady";
            // 
            // ExcelDnaLabel
            // 
            this.ExcelDnaLabel.AutoSize = true;
            this.ExcelDnaLabel.Location = new System.Drawing.Point(9, 173);
            this.ExcelDnaLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ExcelDnaLabel.Name = "ExcelDnaLabel";
            this.ExcelDnaLabel.Size = new System.Drawing.Size(99, 13);
            this.ExcelDnaLabel.TabIndex = 7;
            this.ExcelDnaLabel.Text = "Utilizes Excel-DNA";
            // 
            // ExcelDnaDownloadLinkLabel
            // 
            this.ExcelDnaDownloadLinkLabel.ActiveLinkColor = System.Drawing.Color.Blue;
            this.ExcelDnaDownloadLinkLabel.AutoSize = true;
            this.ExcelDnaDownloadLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ExcelDnaDownloadLinkLabel.Location = new System.Drawing.Point(9, 189);
            this.ExcelDnaDownloadLinkLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ExcelDnaDownloadLinkLabel.Name = "ExcelDnaDownloadLinkLabel";
            this.ExcelDnaDownloadLinkLabel.Size = new System.Drawing.Size(162, 13);
            this.ExcelDnaDownloadLinkLabel.TabIndex = 9;
            this.ExcelDnaDownloadLinkLabel.TabStop = true;
            this.ExcelDnaDownloadLinkLabel.Text = "http://exceldna.codeplex.com/";
            this.ExcelDnaDownloadLinkLabel.VisitedLinkColor = System.Drawing.Color.Blue;
            this.ExcelDnaDownloadLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UrlLinkLabel_LinkClicked);
            // 
            // ExcelDnaCopyrightLabel
            // 
            this.ExcelDnaCopyrightLabel.AutoSize = true;
            this.ExcelDnaCopyrightLabel.Location = new System.Drawing.Point(9, 205);
            this.ExcelDnaCopyrightLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ExcelDnaCopyrightLabel.Name = "ExcelDnaCopyrightLabel";
            this.ExcelDnaCopyrightLabel.Size = new System.Drawing.Size(244, 13);
            this.ExcelDnaCopyrightLabel.TabIndex = 10;
            this.ExcelDnaCopyrightLabel.Text = "Copyright © 2005‒2011 Govert van Drimmelen";
            // 
            // ExcelDnaLicenseLabel
            // 
            this.ExcelDnaLicenseLabel.AutoSize = true;
            this.ExcelDnaLicenseLabel.Location = new System.Drawing.Point(9, 221);
            this.ExcelDnaLicenseLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ExcelDnaLicenseLabel.Name = "ExcelDnaLicenseLabel";
            this.ExcelDnaLicenseLabel.Size = new System.Drawing.Size(177, 13);
            this.ExcelDnaLicenseLabel.TabIndex = 11;
            this.ExcelDnaLicenseLabel.Text = "Released under a custom license:";
            // 
            // ExcelDnaLicenseLinkLabel
            // 
            this.ExcelDnaLicenseLinkLabel.ActiveLinkColor = System.Drawing.Color.Blue;
            this.ExcelDnaLicenseLinkLabel.AutoSize = true;
            this.ExcelDnaLicenseLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ExcelDnaLicenseLinkLabel.Location = new System.Drawing.Point(9, 237);
            this.ExcelDnaLicenseLinkLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.ExcelDnaLicenseLinkLabel.Name = "ExcelDnaLicenseLinkLabel";
            this.ExcelDnaLicenseLinkLabel.Size = new System.Drawing.Size(197, 13);
            this.ExcelDnaLicenseLinkLabel.TabIndex = 12;
            this.ExcelDnaLicenseLinkLabel.TabStop = true;
            this.ExcelDnaLicenseLinkLabel.Text = "http://exceldna.codeplex.com/license";
            this.ExcelDnaLicenseLinkLabel.VisitedLinkColor = System.Drawing.Color.Blue;
            this.ExcelDnaLicenseLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UrlLinkLabel_LinkClicked);
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Location = new System.Drawing.Point(9, 135);
            this.ContactLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(155, 13);
            this.ContactLabel.TabIndex = 13;
            this.ContactLabel.Text = "For further enquires contact:";
            // 
            // LicenseLabel
            // 
            this.LicenseLabel.AutoSize = true;
            this.LicenseLabel.Location = new System.Drawing.Point(9, 86);
            this.LicenseLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.LicenseLabel.Name = "LicenseLabel";
            this.LicenseLabel.Size = new System.Drawing.Size(164, 13);
            this.LicenseLabel.TabIndex = 17;
            this.LicenseLabel.Text = "Licensed under the MIT license";
            // 
            // CloseButton
            // 
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Location = new System.Drawing.Point(120, 267);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 15;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MailLinkLabel
            // 
            this.MailLinkLabel.ActiveLinkColor = System.Drawing.Color.Blue;
            this.MailLinkLabel.AutoSize = true;
            this.MailLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.MailLinkLabel.Location = new System.Drawing.Point(9, 151);
            this.MailLinkLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.MailLinkLabel.Name = "MailLinkLabel";
            this.MailLinkLabel.Size = new System.Drawing.Size(146, 13);
            this.MailLinkLabel.TabIndex = 18;
            this.MailLinkLabel.TabStop = true;
            this.MailLinkLabel.Text = "peter.mahady1@gmail.com";
            this.MailLinkLabel.VisitedLinkColor = System.Drawing.Color.Blue;
            this.MailLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MailLinkLabel_LinkClicked);
            // 
            // MITLicenceLabel
            // 
            this.MITLicenceLabel.ActiveLinkColor = System.Drawing.Color.Blue;
            this.MITLicenceLabel.AutoSize = true;
            this.MITLicenceLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.MITLicenceLabel.Location = new System.Drawing.Point(9, 102);
            this.MITLicenceLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.MITLicenceLabel.Name = "MITLicenceLabel";
            this.MITLicenceLabel.Size = new System.Drawing.Size(279, 13);
            this.MITLicenceLabel.TabIndex = 20;
            this.MITLicenceLabel.TabStop = true;
            this.MITLicenceLabel.Text = "http://www.opensource.org/licenses/mit-license.php";
            this.MITLicenceLabel.VisitedLinkColor = System.Drawing.Color.Blue;
            this.MITLicenceLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MITLicenceLabel_LinkClicked);
            // 
            // AboutForm
            // 
            this.AcceptButton = this.CloseButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(332, 302);
            this.Controls.Add(this.MITLicenceLabel);
            this.Controls.Add(this.MailLinkLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.LicenseLabel);
            this.Controls.Add(this.ContactLabel);
            this.Controls.Add(this.ExcelDnaLicenseLinkLabel);
            this.Controls.Add(this.ExcelDnaLicenseLabel);
            this.Controls.Add(this.ExcelDnaCopyrightLabel);
            this.Controls.Add(this.ExcelDnaDownloadLinkLabel);
            this.Controls.Add(this.ExcelDnaLabel);
            this.Controls.Add(this.Copyrightlabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.Text = " Terrain Profiler";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Copyrightlabel;
        private System.Windows.Forms.Label ExcelDnaLabel;
        private System.Windows.Forms.LinkLabel ExcelDnaDownloadLinkLabel;
        private System.Windows.Forms.Label ExcelDnaCopyrightLabel;
        private System.Windows.Forms.Label ExcelDnaLicenseLabel;
        private System.Windows.Forms.LinkLabel ExcelDnaLicenseLinkLabel;
        private System.Windows.Forms.Label ContactLabel;
        //private System.Windows.Forms.Label VersionLabel;
        //private System.Windows.Forms.PictureBox LogoImage;
        private System.Windows.Forms.Label LicenseLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.LinkLabel MailLinkLabel;
        private System.Windows.Forms.LinkLabel MITLicenceLabel;
    }
}