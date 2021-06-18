using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppropriateApp
{
    public partial class FakeSoftwareUpdate : Form
    {
        public FakeSoftwareUpdate()
        {
            InitializeComponent();
        }

        private void FakeSoftwareUpdate_Load(object sender, EventArgs e)
            
        {
           label1.Text = AppropriateApp.Properties.Settings.Default.FakeSoftwareUpdateCreatorName + label1.Text;
            label2.Text = AppropriateApp.Properties.Settings.Default.FakeSoftwareUpdateDebu + label2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppropriateApp.Properties.Settings.Default.FakeSoftwareUpdateCreatorName = "";
            AppropriateApp.Properties.Settings.Default.FakeSoftwareUpdateDebu = "";
            this.Close();
        }
    }
}
