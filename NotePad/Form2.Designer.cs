namespace NotePad
{
    partial class FindBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enterLabel = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.findBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.caseCheckBox = new System.Windows.Forms.CheckBox();
            this.wordCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // enterLabel
            // 
            this.enterLabel.AutoSize = true;
            this.enterLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enterLabel.Location = new System.Drawing.Point(12, 13);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(71, 17);
            this.enterLabel.TabIndex = 0;
            this.enterLabel.Text = "Enter text:";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 33);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(230, 23);
            this.textBox.TabIndex = 1;
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(259, 32);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(75, 23);
            this.findBtn.TabIndex = 2;
            this.findBtn.Text = "&Find";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(259, 61);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "&Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // caseCheckBox
            // 
            this.caseCheckBox.AutoSize = true;
            this.caseCheckBox.Location = new System.Drawing.Point(14, 64);
            this.caseCheckBox.Name = "caseCheckBox";
            this.caseCheckBox.Size = new System.Drawing.Size(88, 19);
            this.caseCheckBox.TabIndex = 4;
            this.caseCheckBox.Text = "Match &Case";
            this.caseCheckBox.UseVisualStyleBackColor = true;
            // 
            // wordCheckBox
            // 
            this.wordCheckBox.AutoSize = true;
            this.wordCheckBox.Location = new System.Drawing.Point(124, 64);
            this.wordCheckBox.Name = "wordCheckBox";
            this.wordCheckBox.Size = new System.Drawing.Size(125, 19);
            this.wordCheckBox.TabIndex = 5;
            this.wordCheckBox.Text = "Match &whole word";
            this.wordCheckBox.UseVisualStyleBackColor = true;
            // 
            // FindBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(341, 93);
            this.Controls.Add(this.wordCheckBox);
            this.Controls.Add(this.caseCheckBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.enterLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Find";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label enterLabel;
        private TextBox textBox;
        private Button findBtn;
        private Button cancelBtn;
        private CheckBox caseCheckBox;
        private CheckBox wordCheckBox;
    }
}