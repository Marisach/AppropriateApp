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
    public partial class FakeSoftwareUpdateCreator : Form
    {
        public FakeSoftwareUpdateCreator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            適当なアプリ_.Properties.Settings.Default.FakeSoftwareUpdateCreatorName = textBox1.Text;
            適当なアプリ_.Properties.Settings.Default.FakeSoftwareUpdateDebu = textBox2.Text;
            FakeSoftwareUpdate fakeSoftware = new FakeSoftwareUpdate();
            {
                fakeSoftware.ShowDialog();
            };
        }
    }
}
