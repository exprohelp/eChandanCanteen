using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace eChandanCanteen 
{
    public partial class frmCommonRpt : Form
    {
        public frmCommonRpt()
        {
            InitializeComponent();
        }

        private void frmCommonRpt_Load(object sender, EventArgs e)
        {

        }
        private void frmCommonRpt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); 
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
