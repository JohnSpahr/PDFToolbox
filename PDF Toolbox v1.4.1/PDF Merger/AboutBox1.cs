using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace PDF_Merger
{
    partial class AboutBox1 : Form
    {
        public AboutBox1()
        {
            InitializeComponent();
        }


        private void TableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LabelCopyright_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://tectrasystems.org");
        }
    }
}
