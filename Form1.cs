using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace eIM
{
    public partial class Form1 : Form
    {
        Rectangle rec = new Rectangle();
        Size sz = new Size();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            sz = rec.Size;
            this.Height = sz.Height;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (button1.Text == "<<")
            {
                int limit = 5;
                do
                {
                    limit = limit + 5;
                    this.Width = 280 + limit;
                    this.Location = new System.Drawing.Point((sz.Width) - (280 + limit), 0);
                    this.Refresh();
                    if (limit <= sz.Width - 280)
                    { button1.Text = ">>"; }
                }
                while (limit <= sz.Width - 280);
            }
            else
            {
                int limit = 5;
                Rectangle rec = Screen.PrimaryScreen.WorkingArea;
                sz = rec.Size;
                do
                {
                    limit = limit + 5;
                    this.Width = sz.Width - limit;
                    this.Location = new System.Drawing.Point(limit, 0);
                    if (limit <= sz.Width - 280)
                    { button1.Text = "<<"; }
                }
                while (limit <= sz.Width - 280);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }

    }
}
