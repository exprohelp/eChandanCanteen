using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eChandanCanteen
{
    public partial class ChangeCmp : Form
    {
        public event SearchUpdateEventHandler SearchUpdated;
        public ChangeCmp()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            GlobalUsage.gCmpCode=comboBox1.Text;
            MessageBox.Show("Company has Changed i.e ( " + GlobalUsage.gCmpCode + " )");
        }

        private void ChangeCmp_Load(object sender, EventArgs e)
        {
            comboBox1.Text=GlobalUsage.gCmpCode;
        }

        private void ChangeCmp_FormClosing(object sender, FormClosingEventArgs e)
        {
            SearchUpdatedEventArgs valueArgs = new SearchUpdatedEventArgs(GlobalUsage.gCmpCode);
            SearchUpdated(this, valueArgs);
            this.Dispose();
            this.Close();
        }
    }
}
