using System;
using ExcelDNAExample.Properties;
using System.Windows.Forms;

namespace ElevationDataAPI.TerrainProfiler
{
    public partial class SetGoogleAPIKey : Form
    {

        public SetGoogleAPIKey()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            //Replace the current API key with the user defined one
            if(textBox3.Text != null)
            {
                Settings.Default.APIKey = textBox3.Text;
                Settings.Default.Save();
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
