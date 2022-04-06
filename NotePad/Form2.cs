using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class FindBox : Form
    {
        private RichTextBox text;
        public FindBox(ref RichTextBox textBox)
        {
            text=textBox;
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            if (caseCheckBox.Checked && wordCheckBox.Checked) text.Find(textBox.Text, RichTextBoxFinds.MatchCase | RichTextBoxFinds.WholeWord);
            else if (wordCheckBox.Checked) text.Find(textBox.Text, RichTextBoxFinds.WholeWord);
            else if (caseCheckBox.Checked) text.Find(textBox.Text, RichTextBoxFinds.MatchCase);
            else text.Find(textBox.Text);
            Close();
        }
    }
}
