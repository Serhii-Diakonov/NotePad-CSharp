using System.Runtime.InteropServices;

namespace NotePad
{
    public partial class Form1 : Form
    {
		private List<RichTextBox> textes = new List<RichTextBox>();
		private List<string> times = new List<string>();
		private TabPage curTab;
		private RichTextBox curTextBox;
		Size closeImgSize = new Size(8, 8);
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
			tt6.SetToolTip(closeAllTabsBtn, "Close all tabs");

			tabControl.DrawItem += tabControl_DrawItem;
			tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
			tabControl.Padding = new Point(16, 3);
			tabControl.MouseClick += new MouseEventHandler(tabControl_MouseClick);
        }

		private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
			try
			{
				Image img = new Bitmap(Properties.Resources.closeImg, closeImgSize);
				Brush titleBrush = new SolidBrush(Color.Black);
				string title = tabControl.TabPages[e.Index].Text;

				switch (tabControl.Alignment)
				{
					case TabAlignment.Left:
						{
							Rectangle r = e.Bounds;
							r = tabControl.GetTabRect(e.Index);
							r.Offset(2, 2);

							StringFormat drawFormat = new StringFormat();
							drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;

							//e.Graphics.TranslateTransform(Width, 0);
							//e.Graphics.RotateTransform(180);

							e.Graphics.DrawString(title, Font, titleBrush, new Point(r.X, r.Y), drawFormat);

							e.Graphics.DrawImage(img, new Point(tabControl.GetTabRect(e.Index).Width/2 - closeImgSize.Width / 4,
								r.Y + tabControl.GetTabRect(e.Index).Height - 8 - closeImgSize.Height));
							break;
						}

					case TabAlignment.Top:
						{
							Rectangle r = e.Bounds;
							r = tabControl.GetTabRect(e.Index);
							r.Offset(2, 2);

							e.Graphics.DrawString(title, Font, titleBrush, new Point(r.X, r.Y));

							e.Graphics.DrawImage(img, new Point(r.X + tabControl.GetTabRect(e.Index).Width - 8 - closeImgSize.Width,
								tabControl.GetTabRect(e.Index).Height / 2 - closeImgSize.Height / 4));
							break;
						}
					case TabAlignment.Bottom:
						{
							Rectangle r = e.Bounds;
							r = tabControl.GetTabRect(e.Index);
							r.Offset(2, 2);

							e.Graphics.DrawString(title, Font, titleBrush, new Point(r.X, r.Y));

							e.Graphics.DrawImage(img, new Point(r.X + tabControl.GetTabRect(e.Index).Width - 8 - closeImgSize.Width, r.Y +
                                tabControl.GetTabRect(e.Index).Height / 2 - closeImgSize.Height+2));
							break;
						}
					case TabAlignment.Right:
						{
							Rectangle r = e.Bounds;
							r = tabControl.GetTabRect(e.Index);
							r.Offset(2, 2);

							StringFormat drawFormat = new StringFormat();
							drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;
							e.Graphics.DrawString(title, Font, titleBrush, new Point(r.X, r.Y), drawFormat);

							e.Graphics.DrawImage(img, new Point(r.X+tabControl.GetTabRect(e.Index).Width / 2 - closeImgSize.Width / 4,
								r.Y + tabControl.GetTabRect(e.Index).Height - 8 - closeImgSize.Height));
							break;
						}
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("An error has occured: " + ex.Message, "Error during creating closable tab",
	MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void tabControl_MouseClick(object sender, MouseEventArgs e)
		{
			TabControl tc = (TabControl)sender;
			Point p = e.Location;
			int _tabWidth = tabControl.GetTabRect(tc.SelectedIndex).Width - 18;
			Rectangle r = tabControl.GetTabRect(tc.SelectedIndex);
			r.Offset(_tabWidth, 5);
			r.Width = 15;
			r.Height = 15;
			if (r.Contains(p))
			{
				TabPage tab = tc.TabPages[tc.SelectedIndex];
				askToSave(tab);
				tc.TabPages.Remove(tab);
				if (tc.TabCount == 0)
				{
					disactivateFunctions();
					lastSaveLabel.Text = "Last save:";
				}
			}
		}

		private void askToSave(TabPage tab) {
			if (tab.Text.Contains("*"))
				if (MessageBox.Show("You are going to leave the content of the tab unsaved!\nWould you like " +
                    "to save changes in \""+tab.Text.TrimEnd('*')+"\"?",
					"Closing without saving", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					saveFile(null, null);
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
			bottomPanel.Enabled = true;
			tabControl.Enabled = true;
			closeAllTabsBtn.Enabled = true;
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
			closeAllTabsBtn.Enabled = false;
			bottomPanel.Enabled = false;
			tabControl.Enabled = false;
		}

		private void tabInit(TabPage tab) 
		{
			int number = 1 + tabControl.TabCount;
			tab.Text = "Untitled-" + number;
			tabControl.SelectedTab = tab;
			tabControl.Click += new EventHandler(tabIsChosen);
			curTab = tab;

			RichTextBox textBox = new RichTextBox();
			tab.Controls.Add(textBox);
			textBoxInit(textBox);

			tabControl.TabPages.Add(tab);
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
			if (tabControl.TabCount == 0) activateFunctions();
			tabInit(new TabPage());

			amountLabel.Text = "Amount of symbols: " + curTextBox.Text.Length;
			setLastSaveLabel();
			curTextBox.Focus();
		}
        private void newTabBtn_Click(object sender, EventArgs e)
        {
			openNewTab();
		}

		private void setLastSaveLabel() {
			lastSaveLabel.Text = "Last save: " + DateTime.Now.ToString("HH:mm:ss");
			if (times.Count !=tabControl.TabCount) times.Add(DateTime.Now.ToString("HH:mm:ss"));
			else times[tabControl.TabPages.IndexOf(curTab)] = DateTime.Now.ToString("HH:mm:ss");
		}
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
			openNewTab();
		}

		private void tabIsChosen(object sender, EventArgs e)
        {
			TabControl tabControl = (TabControl)sender;
			if (!tabControl.SelectedTab.Equals(curTab))
			{
				curTab = tabControl.SelectedTab;
				int index = tabControl.TabPages.IndexOf(curTab);
				curTextBox = textes.ElementAt(index);
				amountLabel.Text = "Amount of symbols: " + curTextBox.Text.Length;
				lastSaveLabel.Text = "Last save: "+times.ElementAt(index);
			}

		}

		private void countAmountOfSymbols(object sender, EventArgs e) {
			int index = tabControl.TabPages.IndexOf(curTab);
			amountLabel.Text = "Amount of symbols: " + textes.ElementAt(index).Text.Length;
		}

		private void markedAsUnsaved(object sender, EventArgs e)
        {
			if(!curTab.Text.Contains('*')) curTab.Text = curTab.Text + '*';
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

        private void singlelineTabsToolStripMenuItem_Click(object sender, EventArgs e)
        {
			tabControl.Multiline = false;
			multilineTabsToolStripMenuItem1.Checked = false;
        }

        private void multilineTabsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
			singlelineTabsToolStripMenuItem.Checked = false;
			tabControl.Multiline = true;
        }

        private void topToolStripMenuItem_Click(object sender, EventArgs e)
        {
			rightToolStripMenuItem.Checked = false;
			leftToolStripMenuItem.Checked = false;
			bottomToolStripMenuItem.Checked = false;
			tabControl.Alignment = TabAlignment.Top;
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
			topToolStripMenuItem.Checked = false;
			leftToolStripMenuItem.Checked = false;
			bottomToolStripMenuItem.Checked = false;
			tabControl.Alignment = TabAlignment.Right;
		}

        private void bottomToolStripMenuItem_Click(object sender, EventArgs e)
        {
			rightToolStripMenuItem.Checked = false;
			leftToolStripMenuItem.Checked = false;
			topToolStripMenuItem.Checked = false;
			tabControl.Alignment = TabAlignment.Bottom;
		}

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
			rightToolStripMenuItem.Checked = false;
			topToolStripMenuItem.Checked = false;
			bottomToolStripMenuItem.Checked = false;
			tabControl.Alignment = TabAlignment.Left;
		}

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
			closeAllTabs();
			Close();
        }

		private void closeAllTabs() {
				for (int i = tabControl.TabCount - 1; i >= 0; i--)
				{
					askToSave(tabControl.TabPages[i]);
				if (i != 0)
					tabControl.TabPages.RemoveAt(i);
				else tabControl.TabPages.Clear();
				}
			//disactivateFunctions();
			lastSaveLabel.Text = "Last save:"+tabControl.TabCount;
		}

		private void closeAllTabsBtn_Click(object sender, EventArgs e)
        {
			closeAllTabs();
        }
    }
}