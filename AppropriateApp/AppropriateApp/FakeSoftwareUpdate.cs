using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 適当なアプリ_
{
    public partial class FakeSoftwareUpdate : Form
    {
        public FakeSoftwareUpdate()
        {
            InitializeComponent();
        }

        private void FakeSoftwareUpdate_Load(object sender, EventArgs e)
            
        {
            label1.Text = 適当なアプリ_.Properties.Settings.Default.FakeSoftwareUpdateCreatorName + label1.Text;
            label2.Text = 適当なアプリ_.Properties.Settings.Default.FakeSoftwareUpdateDebu + label2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            適当なアプリ_.Properties.Settings.Default.FakeSoftwareUpdateCreatorName = "";
            適当なアプリ_.Properties.Settings.Default.FakeSoftwareUpdateDebu = "";
            this.Close();
        }
    }
}
