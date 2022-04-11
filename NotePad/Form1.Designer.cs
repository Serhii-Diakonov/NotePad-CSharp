namespace NotePad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeTabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.alignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multilineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgrammToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTabBtn = new System.Windows.Forms.Button();
            this.openBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeTabBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cutBtn = new System.Windows.Forms.Button();
            this.pasteBtn = new System.Windows.Forms.Button();
            this.copyBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.lastSaveLabel = new System.Windows.Forms.Label();
            this.timePanel = new System.Windows.Forms.Panel();
            this.amountPanel = new System.Windows.Forms.Panel();
            this.amountLabel = new System.Windows.Forms.Label();
            this.severalTabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.amountPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.open);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(183, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.save);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveFile);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(183, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem,
            this.toolStripSeparator3,
            this.findToolStripMenuItem});
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cut);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copy);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.paste);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.delete);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(161, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.findToolStripMenuItem.Text = "&Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.formatToolStripMenuItem.Enabled = false;
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "F&ormat";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.AutoToolTip = true;
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.fontToolStripMenuItem.Text = "Font...";
            this.fontToolStripMenuItem.ToolTipText = "Change font family, size for the text in the current tab";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.AutoToolTip = true;
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.colorToolStripMenuItem.Text = "Color...";
            this.colorToolStripMenuItem.ToolTipText = "Change the text color in the current tab";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrangeTabsToolStripMenuItem,
            this.toolStripSeparator1,
            this.alignToolStripMenuItem,
            this.multilineToolStripMenuItem,
            this.severalTabsToolStripMenuItem});
            this.windowToolStripMenuItem.Enabled = false;
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "&Window";
            // 
            // arrangeTabsToolStripMenuItem
            // 
            this.arrangeTabsToolStripMenuItem.AutoToolTip = true;
            this.arrangeTabsToolStripMenuItem.Name = "arrangeTabsToolStripMenuItem";
            this.arrangeTabsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arrangeTabsToolStripMenuItem.Text = "Arrange Tabs";
            this.arrangeTabsToolStripMenuItem.ToolTipText = "See all your tabs for better navigating";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // alignToolStripMenuItem
            // 
            this.alignToolStripMenuItem.AutoToolTip = true;
            this.alignToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topToolStripMenuItem,
            this.rightToolStripMenuItem,
            this.bottomToolStripMenuItem,
            this.leftToolStripMenuItem});
            this.alignToolStripMenuItem.Name = "alignToolStripMenuItem";
            this.alignToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alignToolStripMenuItem.Text = "Align Tabs";
            this.alignToolStripMenuItem.ToolTipText = "Allows you to align tabs in different ways";
            // 
            // topToolStripMenuItem
            // 
            this.topToolStripMenuItem.AutoToolTip = true;
            this.topToolStripMenuItem.Checked = true;
            this.topToolStripMenuItem.CheckOnClick = true;
            this.topToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.topToolStripMenuItem.Name = "topToolStripMenuItem";
            this.topToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.topToolStripMenuItem.Text = "Top";
            this.topToolStripMenuItem.ToolTipText = "Place your tabs in the top";
            this.topToolStripMenuItem.Click += new System.EventHandler(this.topToolStripMenuItem_Click);
            // 
            // rightToolStripMenuItem
            // 
            this.rightToolStripMenuItem.AutoToolTip = true;
            this.rightToolStripMenuItem.CheckOnClick = true;
            this.rightToolStripMenuItem.Name = "rightToolStripMenuItem";
            this.rightToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.rightToolStripMenuItem.Text = "Right";
            this.rightToolStripMenuItem.ToolTipText = "Place your tabs in right side";
            this.rightToolStripMenuItem.Click += new System.EventHandler(this.rightToolStripMenuItem_Click);
            // 
            // bottomToolStripMenuItem
            // 
            this.bottomToolStripMenuItem.AutoToolTip = true;
            this.bottomToolStripMenuItem.CheckOnClick = true;
            this.bottomToolStripMenuItem.Name = "bottomToolStripMenuItem";
            this.bottomToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.bottomToolStripMenuItem.Text = "Bottom";
            this.bottomToolStripMenuItem.ToolTipText = "Place your tabs in the bottom";
            this.bottomToolStripMenuItem.Click += new System.EventHandler(this.bottomToolStripMenuItem_Click);
            // 
            // leftToolStripMenuItem
            // 
            this.leftToolStripMenuItem.AutoToolTip = true;
            this.leftToolStripMenuItem.CheckOnClick = true;
            this.leftToolStripMenuItem.Name = "leftToolStripMenuItem";
            this.leftToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.leftToolStripMenuItem.Text = "Left";
            this.leftToolStripMenuItem.ToolTipText = "Place your tabs in left side";
            this.leftToolStripMenuItem.Click += new System.EventHandler(this.leftToolStripMenuItem_Click);
            // 
            // multilineToolStripMenuItem
            // 
            this.multilineToolStripMenuItem.AutoToolTip = true;
            this.multilineToolStripMenuItem.Name = "multilineToolStripMenuItem";
            this.multilineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.multilineToolStripMenuItem.Text = "Multiline Tabs";
            this.multilineToolStripMenuItem.ToolTipText = "Arragne tabs in several lines for better navigating";
            this.multilineToolStripMenuItem.Click += new System.EventHandler(this.multilineToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProgrammToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(24, 20);
            this.infoToolStripMenuItem.Text = "?";
            // 
            // aboutProgrammToolStripMenuItem
            // 
            this.aboutProgrammToolStripMenuItem.Name = "aboutProgrammToolStripMenuItem";
            this.aboutProgrammToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.aboutProgrammToolStripMenuItem.Text = "About programm";
            this.aboutProgrammToolStripMenuItem.Click += new System.EventHandler(this.aboutProgrammToolStripMenuItem_Click);
            // 
            // newTabBtn
            // 
            this.newTabBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newTabBtn.BackgroundImage")));
            this.newTabBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.newTabBtn.Location = new System.Drawing.Point(1, 0);
            this.newTabBtn.Name = "newTabBtn";
            this.newTabBtn.Size = new System.Drawing.Size(25, 25);
            this.newTabBtn.TabIndex = 1;
            this.newTabBtn.Tag = "";
            this.newTabBtn.UseVisualStyleBackColor = true;
            this.newTabBtn.Click += new System.EventHandler(this.newTabBtn_Click);
            // 
            // openBtn
            // 
            this.openBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openBtn.BackgroundImage")));
            this.openBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.openBtn.Location = new System.Drawing.Point(25, 0);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(25, 25);
            this.openBtn.TabIndex = 2;
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.open);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.closeTabBtn);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.cutBtn);
            this.panel1.Controls.Add(this.pasteBtn);
            this.panel1.Controls.Add(this.copyBtn);
            this.panel1.Controls.Add(this.openBtn);
            this.panel1.Controls.Add(this.newTabBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 27);
            this.panel1.TabIndex = 3;
            // 
            // closeTabBtn
            // 
            this.closeTabBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.closeTabBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeTabBtn.BackgroundImage")));
            this.closeTabBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeTabBtn.Enabled = false;
            this.closeTabBtn.Location = new System.Drawing.Point(772, 4);
            this.closeTabBtn.Name = "closeTabBtn";
            this.closeTabBtn.Size = new System.Drawing.Size(15, 15);
            this.closeTabBtn.TabIndex = 7;
            this.closeTabBtn.UseVisualStyleBackColor = true;
            this.closeTabBtn.Click += new System.EventHandler(this.closeTabBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveBtn.BackgroundImage")));
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveBtn.Enabled = false;
            this.saveBtn.Location = new System.Drawing.Point(49, 0);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(25, 25);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.save);
            // 
            // cutBtn
            // 
            this.cutBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cutBtn.BackgroundImage")));
            this.cutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cutBtn.Enabled = false;
            this.cutBtn.Location = new System.Drawing.Point(73, 0);
            this.cutBtn.Name = "cutBtn";
            this.cutBtn.Size = new System.Drawing.Size(25, 25);
            this.cutBtn.TabIndex = 5;
            this.cutBtn.UseVisualStyleBackColor = true;
            this.cutBtn.Click += new System.EventHandler(this.cut);
            // 
            // pasteBtn
            // 
            this.pasteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pasteBtn.BackgroundImage")));
            this.pasteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pasteBtn.Enabled = false;
            this.pasteBtn.Location = new System.Drawing.Point(121, 0);
            this.pasteBtn.Name = "pasteBtn";
            this.pasteBtn.Size = new System.Drawing.Size(25, 25);
            this.pasteBtn.TabIndex = 4;
            this.pasteBtn.UseVisualStyleBackColor = true;
            this.pasteBtn.Click += new System.EventHandler(this.paste);
            // 
            // copyBtn
            // 
            this.copyBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("copyBtn.BackgroundImage")));
            this.copyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.copyBtn.Enabled = false;
            this.copyBtn.Location = new System.Drawing.Point(97, 0);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(25, 25);
            this.copyBtn.TabIndex = 3;
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copy);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 425);
            this.panel2.TabIndex = 4;
            this.panel2.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 421);
            this.tabControl1.TabIndex = 0;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.bottomPanel.Controls.Add(this.lastSaveLabel);
            this.bottomPanel.Controls.Add(this.timePanel);
            this.bottomPanel.Controls.Add(this.amountPanel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 472);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(800, 29);
            this.bottomPanel.TabIndex = 1;
            this.bottomPanel.Visible = false;
            // 
            // lastSaveLabel
            // 
            this.lastSaveLabel.AutoSize = true;
            this.lastSaveLabel.Location = new System.Drawing.Point(229, 7);
            this.lastSaveLabel.Name = "lastSaveLabel";
            this.lastSaveLabel.Size = new System.Drawing.Size(57, 15);
            this.lastSaveLabel.TabIndex = 1;
            this.lastSaveLabel.Text = "Last save:";
            // 
            // timePanel
            // 
            this.timePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timePanel.Location = new System.Drawing.Point(224, 3);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(200, 23);
            this.timePanel.TabIndex = 1;
            // 
            // amountPanel
            // 
            this.amountPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.amountPanel.Controls.Add(this.amountLabel);
            this.amountPanel.Location = new System.Drawing.Point(4, 3);
            this.amountPanel.Name = "amountPanel";
            this.amountPanel.Size = new System.Drawing.Size(218, 23);
            this.amountPanel.TabIndex = 0;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(3, 2);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(124, 15);
            this.amountLabel.TabIndex = 0;
            this.amountLabel.Text = "Amount of symbols: 0";
            // 
            // severalTabsToolStripMenuItem
            // 
            this.severalTabsToolStripMenuItem.AutoToolTip = true;
            this.severalTabsToolStripMenuItem.Name = "severalTabsToolStripMenuItem";
            this.severalTabsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.severalTabsToolStripMenuItem.Text = "Several Tabs";
            this.severalTabsToolStripMenuItem.ToolTipText = "Arrange your tabs to place several tabs simultaneously";
            this.severalTabsToolStripMenuItem.Click += new System.EventHandler(this.severalTabsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Notepad C#";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.amountPanel.ResumeLayout(false);
            this.amountPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem findToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem windowToolStripMenuItem;
        private ToolStripMenuItem arrangeTabsToolStripMenuItem;
        private ToolStripMenuItem alignToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem aboutProgrammToolStripMenuItem;
        private Button newTabBtn;
        private Button openBtn;
        private Panel panel1;
        private Button saveBtn;
        private Button cutBtn;
        private Button pasteBtn;
        private Button copyBtn;
        private Panel panel2;
        private TabControl tabControl1;
        private Panel bottomPanel;
        private Label lastSaveLabel;
        private Panel timePanel;
        private Panel amountPanel;
        private Label amountLabel;
        private Button closeTabBtn;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem topToolStripMenuItem;
        private ToolStripMenuItem rightToolStripMenuItem;
        private ToolStripMenuItem bottomToolStripMenuItem;
        private ToolStripMenuItem leftToolStripMenuItem;
        private ToolStripMenuItem multilineToolStripMenuItem;
        private ToolStripMenuItem severalTabsToolStripMenuItem;
    }
}