using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
        }


        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
