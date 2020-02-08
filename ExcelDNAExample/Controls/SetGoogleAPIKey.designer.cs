using ExcelDNAExample.Properties;
namespace ExcelDNAExample.Controls
{
    partial class SetGoogleAPIKey
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
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.APIKeyLinkLabel = new System.Windows.Forms.LinkLabel();
            this.APIKeyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "CurrentAPIKey";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(241, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 18;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "NewAPIKey";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(126, 90);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(207, 20);
            this.textBox3.TabIndex = 23;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(126, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 20);
            this.textBox2.TabIndex = 17;
            this.textBox2.Text = global::ExcelDNAExample.Properties.Settings.Default.APIKey;
            // 
            // APIKeyLinkLabel
            // 
            this.APIKeyLinkLabel.ActiveLinkColor = System.Drawing.Color.Blue;
            this.APIKeyLinkLabel.AutoSize = true;
            this.APIKeyLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.APIKeyLinkLabel.Location = new System.Drawing.Point(33, 191);
            this.APIKeyLinkLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.APIKeyLinkLabel.Name = "ExcelDnaLicenseLinkLabel";
            this.APIKeyLinkLabel.Size = new System.Drawing.Size(382, 13);
            this.APIKeyLinkLabel.TabIndex = 25;
            this.APIKeyLinkLabel.TabStop = true;
            this.APIKeyLinkLabel.Text = "https://developers.google.com/maps/documentation/elevation/start#get-a-key";
            this.APIKeyLinkLabel.VisitedLinkColor = System.Drawing.Color.Blue;
            this.APIKeyLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.APIKeyLinkLabel_LinkClicked);
            // 
            // ExcelDnaLicenseLabel
            // 
            this.APIKeyLabel.AutoSize = true;
            this.APIKeyLabel.Location = new System.Drawing.Point(33, 175);
            this.APIKeyLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.APIKeyLabel.Name = "ExcelDnaLicenseLabel";
            this.APIKeyLabel.Size = new System.Drawing.Size(270, 13);
            this.APIKeyLabel.TabIndex = 26;
            this.APIKeyLabel.Text = "For further information on how to obtain an API key visit:";
            // 
            // SetGoogleAPIKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 219);
            this.Controls.Add(this.APIKeyLabel);
            this.Controls.Add(this.APIKeyLinkLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Name = "SetGoogleAPIKey";
            this.Text = "SetAPIKey";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.LinkLabel APIKeyLinkLabel;
        private System.Windows.Forms.Label APIKeyLabel;
    }
}