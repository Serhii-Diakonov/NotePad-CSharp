using System.Runtime.InteropServices;

namespace NotePad
{
    public partial class Form1 : Form
    {
		private List<RichTextBox> textes = new List<RichTextBox>();
		//private List<TabPage> tabs = new List<TabPage>();
		private List<string> times = new List<string>();
		private TabPage curTab;
		private RichTextBox curTextBox;
		private string buffer;

		[DllImport("user32")]
		public static extern int MessageBox(IntPtr handle, string text, string title, int type);
		public enum MessageBoxType : int
		{
			/// <summary>
			/// Три кнопки - Abort, Retry, Ignore
			/// </summary>
			MB_ABORTRETRYIGNORE = 2,
			/// <summary>
			/// Три кнопки - Cancel, Try, Continue
			/// </summary>
			MB_CANCELTRYCONTINUE = 6,
			/// <summary>
			/// Одна кнопка - Ok.
			/// </summary>
			MB_OK = 0,
			/// <summary>
			/// Две кнопки - Ok, Cancel.
			/// </summary>
			MB_OKCANCEL = 1,
			/// <summary>
			/// Две кнопки - Retry, Cancel
			/// </summary>
			MB_RETRYCANCEL = 5,
			/// <summary>
			/// Две кнопки - Yes, No
			/// </summary>
			MB_YESNO = 4,
			/// <summary>
			///  Три кнопки - Yes, No, Cancel
			/// </summary>
			MB_YESNOCANCEL = 3,
			/// <summary>
			/// Иконка - восклицание
			/// </summary>
			MB_ICONEXCLAMATION = 0x30,
			/// <summary>
			/// Иконка - предупреждение
			/// </summary>
			MB_ICONWARNING = 0x30,
			/// <summary>
			/// Иконка - информация
			/// </summary>
			MB_ICONINFORMATION = 0x40,
			/// <summary>
			/// Иконка - вопрос
			/// </summary>
			MB_ICONQUESTION = 0x20,
			/// <summary>
			/// Иконка - стоп
			/// </summary>
			MB_ICONSTOP = 0x10,
			/// <summary>
			/// Иконка - ошибка
			/// </summary>
			MB_ICONERROR = 0x10,

		}
		public enum MessageBoxReturnType : int
		{
			IDABORT = 3,
			IDCANCEL = 2,
			IDCONTINUE = 11,
			IDIGNORE = 5,
			IDNO = 7,
			IDOK = 1,
			IDRETRY = 4,
			IDTRYAGAIN = 10,
			IDYES = 6
		}
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
			/*else
			{
				MessageBox(Handle, "Opening error", "Cannot open the file!", (int)MessageBoxType.MB_OK
				| (int)MessageBoxType.MB_ICONERROR);
			}*/
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
			tabControl.Enabled = true;
			bottomPanel.Enabled = true;
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
		}

		private void tabInit(TabPage tab) 
		{
			int number = 1 + tabControl.TabCount;/*tabs.Count*/;
			tab.Text = "Untitled-" + number;
			tab.UseVisualStyleBackColor = true;
			/*tabs.Add(tab);*/
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
			if (/*tabs.Count */tabControl.TabCount == 0) activateFunctions();
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
			if (times.Count != /*tabs.Count*/tabControl.TabCount) times.Add(DateTime.Now.ToString("HH:mm:ss"));
			else times[/*tabs*/tabControl.TabPages.IndexOf(curTab)] = DateTime.Now.ToString("HH:mm:ss");
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
				int index = /*tabs*/tabControl.TabPages.IndexOf(curTab);
				curTextBox = textes.ElementAt(index);
				amountLabel.Text = "Amount of symbols: " + curTextBox.Text.Length;
				lastSaveLabel.Text = "Last save: "+times.ElementAt(index);
			}

		}

		private void countAmountOfSymbols(object sender, EventArgs e) {
			int index = /*tabs*/tabControl.TabPages.IndexOf(curTab);
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
    }
}