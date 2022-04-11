using System.Runtime.InteropServices;

namespace NotePad
{
    public partial class Form1 : Form
    {
		private List<RichTextBox> textes = new List<RichTextBox>();
		private List<string> times = new List<string>();
		private TabPage curTab;
		private RichTextBox curTextBox;
		int tabNumber = 1;
		private List<TabPage> pages = new List<TabPage>();
		private TabControl tabControl2=null;

        public Form1()
        {
            InitializeComponent();

            ToolTip tt1 = new ToolTip();
            tt1.SetToolTip(newTabBtn, "Create New");
            ToolTip tt2 = new ToolTip();
            tt2.SetToolTip(openBtn, "Open");
            ToolTip tt3 = new ToolTip();
            tt3.SetToolTip(saveBtn, "Save");
            ToolTip tt4 = new ToolTip();
            tt4.SetToolTip(cutBtn, "Cut");
            ToolTip tt5 = new ToolTip();
            tt5.SetToolTip(copyBtn, "Copy");
            ToolTip tt6 = new ToolTip();
            tt6.SetToolTip(pasteBtn, "Paste");
			ToolTip tt7 = new ToolTip();
			tt7.SetToolTip(closeTabBtn, "Close the tab");
		}


        private void saveFile(object sender, EventArgs e)
        {
            {
				SaveFileDialog save = new SaveFileDialog();
				save.DefaultExt = ".txt";
                save.Title = "File saving";
				save.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
				save.CheckPathExists = true;
				if (save.ShowDialog() == DialogResult.OK)
                {
					StreamWriter sw = new StreamWriter(save.FileName);
					sw.WriteLine(curTextBox.Text);
                    sw.Close();
					curTab.Text= save.FileName;
					setLastSaveLabel();
				}
			} 
        }
		private void save(object sender, EventArgs e) {
			curTab.Text=curTab.Text.TrimEnd('*');
			StreamWriter sw = new StreamWriter(curTab.Text);
			sw.WriteLine(curTextBox.Text);
			sw.Close();
			setLastSaveLabel();
		}


		private void open(object sender, EventArgs e)
        {
			OpenFileDialog open = new OpenFileDialog();
			open.Title = "File opening";
			open.DefaultExt = ".txt";
			open.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
			open.CheckPathExists = true;
			if (open.ShowDialog() == DialogResult.OK)
			{
				using (StreamReader sr = new StreamReader(open.FileName))
				{
					openNewTab();
					curTextBox.Text = sr.ReadToEnd();
					curTab.Text = open.FileName;
					sr.Close();
				}
			}
		}

		private void cut(object sender, EventArgs e)
        {
			curTextBox.Cut();
		}

		private void delete(object sender, EventArgs e)
        {
			curTextBox.SelectedText = "";
		}

		private void copy(object sender, EventArgs e)
        {
			curTextBox.Copy();
		}

        private void aboutProgrammToolStripMenuItem_Click(object sender, EventArgs e)
        {
			AboutBox about=new AboutBox();
			about.ShowDialog();	
        }

		private void activateFunctions() {
			panel2.Visible = true;
			saveBtn.Enabled = true;
			cutBtn.Enabled = true;
			copyBtn.Enabled = true;
			pasteBtn.Enabled = true;
			editToolStripMenuItem.Enabled = true;
			saveToolStripMenuItem.Enabled = true;
			saveAsToolStripMenuItem.Enabled = true;
			formatToolStripMenuItem.Enabled = true;
			windowToolStripMenuItem.Enabled = true;
			tabControl1.Enabled = true;
			bottomPanel.Visible = true;
			closeTabBtn.Enabled = true;
		}

		private void disactivateFunctions()
		{
			panel2.Visible = false;
			saveBtn.Enabled = false;
			cutBtn.Enabled = false;
			copyBtn.Enabled = false;
			pasteBtn.Enabled = false;
			editToolStripMenuItem.Enabled = false;
			saveToolStripMenuItem.Enabled = false;
			saveAsToolStripMenuItem.Enabled = false;
			formatToolStripMenuItem.Enabled = false;
			windowToolStripMenuItem.Enabled = false;
			closeTabBtn.Enabled = false;
			bottomPanel.Visible = false;
		}

		private void tabInit(TabPage tab) 
		{
			tab.Text = "Untitled-" + tabNumber++;
			tab.UseVisualStyleBackColor = true;
			tabControl1.SelectedTab = tab;
			tabControl1.Click += new EventHandler(tabIsChosen);
			curTab = tab;

			RichTextBox textBox = new RichTextBox();
			textBox.Click += new EventHandler(textAreaIsChosen);
			tab.Controls.Add(textBox);
			textBoxInit(textBox);

			tabControl1.Controls.Add(tab);
			pages.Add(tab);
		}


		private void textBoxInit(RichTextBox textBox) {
			textBox.Dock = DockStyle.Fill;
			textBox.Text = "";
			textBox.TextChanged += new EventHandler(countAmountOfSymbols);
			textBox.TextChanged += new EventHandler(markedAsUnsaved);
			textes.Add(textBox);
			curTextBox = textBox;
		}
		private void openNewTab()
        {
			if (pages.Count == 0) activateFunctions();
			tabInit(new TabPage());

			addTabToArrangeMenu(curTab);

			amountLabel.Text = "Amount of symbols: " + curTextBox.Text.Length;
			setLastSaveLabel();
			curTextBox.Focus();
		}

		private void addTabToArrangeMenu(TabPage tab) {
			ToolStripMenuItem newTab = new ToolStripMenuItem();
			newTab.Text = tab.Text;
			newTab.Size = new Size(120, 22);
			newTab.AutoToolTip = true;
			newTab.ToolTipText = tab.Text;
			newTab.CheckOnClick = true;
			newTab.Checked = true;
			newTab.Click += new EventHandler(tabFromArrangeList);
			foreach (ToolStripMenuItem tsmi in arrangeTabsToolStripMenuItem.DropDownItems)
				tsmi.Checked = false;
			arrangeTabsToolStripMenuItem.DropDownItems.Add(newTab);
		}

		private void tabFromArrangeList(object sender, EventArgs e) {
			ToolStripMenuItem pressedItem = (ToolStripMenuItem)sender;
			tabControl1.SelectedTab = pages[arrangeTabsToolStripMenuItem.DropDownItems.IndexOf(pressedItem)];
			tabIsChosen(tabControl1,e);
		}
		private void newTabBtn_Click(object sender, EventArgs e)
        {
			openNewTab();
		}

		private void setLastSaveLabel() {
			lastSaveLabel.Text = "Last save: " + DateTime.Now.ToString("HH:mm:ss");
			if (times.Count != pages.Count) times.Add(DateTime.Now.ToString("HH:mm:ss"));
			else times[pages.IndexOf(curTab)] = DateTime.Now.ToString("HH:mm:ss");
		}
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
			openNewTab();
		}

		private void textAreaIsChosen(object sender, EventArgs e)
        {
			RichTextBox text= (RichTextBox)sender;
			if (!text.Equals(curTextBox))
            {
                if (tabControl2 != null )
                {
					TabPage t = (TabPage)tabControl2.Controls[0];
                    if (t.Controls.Contains(text))
						tabIsChosen(tabControl2, null);
					else 
						tabIsChosen(tabControl1, null);
				}

			}

		}
		private void tabIsChosen(object sender, EventArgs e)
        {
			TabControl tabControl = (TabControl)sender;
			if (!tabControl.SelectedTab.Equals(curTab))
			{
				curTab = tabControl.SelectedTab;
				int index = pages.IndexOf(curTab);
				curTextBox = textes.ElementAt(index);
				refreshLabels(curTab);

				foreach(ToolStripMenuItem tsmi in arrangeTabsToolStripMenuItem.DropDownItems)
                {
					if (tsmi == arrangeTabsToolStripMenuItem.DropDownItems[index]) tsmi.Checked = true;
					else tsmi.Checked = false;
                }
			}

		}

		private void countAmountOfSymbols(object sender, EventArgs e) {
			int index = pages.IndexOf(curTab);
			amountLabel.Text = "Amount of symbols: " + textes.ElementAt(index).Text.Length;
		}

		private void markedAsUnsaved(object sender, EventArgs e)
        {
			if (!curTab.Text.Contains('*'))
			{
				curTab.Text = curTab.Text + '*';
				arrangeTabsToolStripMenuItem.DropDownItems[pages.IndexOf(curTab)].Text=curTab.Text;
			}
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
			ColorDialog dialog = new ColorDialog();
			dialog.ShowDialog();
			curTextBox.SelectionColor = dialog.Color;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
			FontDialog dialog = new FontDialog();
			dialog.ShowDialog();
			curTextBox.SelectionFont = dialog.Font;
        }

		private void paste(object sender, EventArgs e)
        {
			curTextBox.Paste();
		}

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
			curTextBox.SelectAll();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
			FindBox find = new FindBox(ref curTextBox);
			find.Show();
        }

		private void askToSave(TabPage tab)
		{
			if (tab.Text.Contains("*"))
				if (MessageBox.Show("You are going to leave the content of the tab unsaved!\nWould you like " +
					"to save changes in \"" + tab.Text.TrimEnd('*') + "\"?",
					"Closing without saving", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					saveFile(null, null);
		}

		private void closeTabBtn_Click(object sender, EventArgs e)
        {
			askToSave(curTab);

			if (tabControl2 != null && pages.Count == 2)
			{
				mergeTabs();
			}
			tabRemove(curTab);

			if (pages.Count == 0) disactivateFunctions();
			else
			{
				curTab = tabControl1.SelectedTab;
				curTextBox = textes.ElementAt(pages.IndexOf(curTab));
				refreshLabels(curTab);
			}
		}
		private void tabRemove(TabPage tab)
        {
			int index = pages.IndexOf(tab);
			times.RemoveAt(index);
			textes.RemoveAt(index);
			arrangeTabsToolStripMenuItem.DropDownItems.RemoveAt(index);
			if(isLeftSelected()) 
				mergeTabs();
			tabControl1.Controls.Remove(curTab);
			pages.Remove(curTab);
		}

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
			for(int i=pages.Count-1; i >= 0; i--)
            {
				askToSave(pages[i]);
				pages.RemoveAt(i);
            }
			Close();
        }

		private void refreshLabels(TabPage tab) {
			int index = pages.IndexOf(tab);
			amountLabel.Text = "Amount of symbols: " + textes[index].Text.Length;
			lastSaveLabel.Text = "Last save: " + times.ElementAt(index);
		}


        private void topToolStripMenuItem_Click(object sender, EventArgs e)
        {
			checkUncheck(topToolStripMenuItem);
			tabControl1.Alignment = TabAlignment.Top;
        }

		private void checkUncheck(ToolStripMenuItem cur) {
			foreach(ToolStripMenuItem tsmi in alignToolStripMenuItem.DropDownItems)
            {
				if(tsmi!=cur)tsmi.Checked = false;
				else tsmi.Checked = true;
            }
		}

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
			checkUncheck(rightToolStripMenuItem);
			tabControl1.Alignment = TabAlignment.Right;
		}

        private void bottomToolStripMenuItem_Click(object sender, EventArgs e)
        {
			checkUncheck(bottomToolStripMenuItem);
			tabControl1.Alignment = TabAlignment.Bottom;
		}

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
			checkUncheck(leftToolStripMenuItem);
			tabControl1.Alignment = TabAlignment.Left;
		}

        private void multilineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (multilineToolStripMenuItem.Checked)
            {
				multilineToolStripMenuItem.Checked = false;
				tabControl1.Multiline = false;
				topToolStripMenuItem_Click(sender, e);
			} else
            {
				multilineToolStripMenuItem.Checked = true;
				tabControl1.Multiline = true;
			}
        }

        private void severalTabsToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (severalTabsToolStripMenuItem.Checked)
			{ 

				mergeTabs();
			}
			else if(!severalTabsToolStripMenuItem.Checked && pages.Count>1)
			{
				

				splitTabs();
			}
		}

		private void mergeTabs() {
			severalTabsToolStripMenuItem.Checked = false;
			tabControl1.Controls.Add(tabControl2.TabPages[0]);
			panel2.Controls.Remove(tabControl2);
			tabControl2 = null;
			refreshLabels(tabControl1.SelectedTab);
			tabControl1.Dock = DockStyle.Fill;
			curTab = tabControl1.SelectedTab;
		}

		private void splitTabs() {
			severalTabsToolStripMenuItem.Checked = true;

			Size curSize = tabControl1.Size;
			tabControl2 = new TabControl();
			tabControl2.Controls.Add(curTab);
			panel2.Controls.Add(tabControl2);

			tabControl2.Dock = DockStyle.Left;
			tabControl1.Dock = DockStyle.Right;
			tabControl2.Size = tabControl1.Size;
			tabControl2.Size = new Size(curSize.Width / 2, curSize.Height);
			tabControl1.Size = new Size(curSize.Width / 2, curSize.Height);

			tabControl2.Click += new EventHandler(tabIsChosen);

			tabControl1.TabPages.Remove(curTab);

			curTab.Focus();
			refreshLabels(curTab);
		}
		private Boolean isLeftSelected()
        {
			if (tabControl2 != null)
			{
				TabPage t = (TabPage)tabControl2.Controls[0];
				return t.Controls.Contains(curTextBox);
			} return false;
		}
    }
}