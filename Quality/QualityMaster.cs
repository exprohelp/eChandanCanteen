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
    public partial class QualityMaster : Form
    {
        public QualityMaster()
        {
            InitializeComponent();
        }
        private void StaffManagement_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size,60);
        }
   
        private void btnFileAttachment_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            pnlControl.Controls.Clear();
            ucQualityAttachement obj = new ucQualityAttachement();
            pnlControl.Controls.Add(obj);
            Cursor.Current = Cursors.Default;
        }
  
      
      
    }
}
