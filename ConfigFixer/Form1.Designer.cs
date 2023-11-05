namespace ConfigFixer
{
    partial class ConfigFixerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigFixerForm));
            ProjectList = new ListView();
            ProjectSearch = new TextBox();
            BrowseFolders = new FolderBrowserDialog();
            BrowseRootFolder = new Button();
            RootPathLabel = new TextBox();
            ProjectSettingCheckedList = new CheckedListBox();
            button1 = new Button();
            Search = new Label();
            label1 = new Label();
            Appsettings = new Label();
            CurrentProjectLabel = new TextBox();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // ProjectList
            // 
            ProjectList.BackColor = SystemColors.Control;
            ProjectList.BackgroundImageTiled = true;
            ProjectList.BorderStyle = BorderStyle.FixedSingle;
            ProjectList.FullRowSelect = true;
            ProjectList.GridLines = true;
            ProjectList.Location = new Point(30, 128);
            ProjectList.MultiSelect = false;
            ProjectList.Name = "ProjectList";
            ProjectList.Size = new Size(284, 391);
            ProjectList.Sorting = SortOrder.Ascending;
            ProjectList.TabIndex = 0;
            ProjectList.UseCompatibleStateImageBehavior = false;
            ProjectList.View = View.List;
            ProjectList.SelectedIndexChanged += ProjectList_SelectedIndexChanged;
            // 
            // ProjectSearch
            // 
            ProjectSearch.BackColor = SystemColors.Control;
            ProjectSearch.BorderStyle = BorderStyle.FixedSingle;
            ProjectSearch.Location = new Point(30, 90);
            ProjectSearch.Name = "ProjectSearch";
            ProjectSearch.Size = new Size(284, 23);
            ProjectSearch.TabIndex = 2;
            ProjectSearch.TextChanged += Search_Changed;
            // 
            // BrowseFolders
            // 
            BrowseFolders.ShowHiddenFiles = true;
            // 
            // BrowseRootFolder
            // 
            BrowseRootFolder.BackColor = Color.Snow;
            BrowseRootFolder.Location = new Point(29, 14);
            BrowseRootFolder.Name = "BrowseRootFolder";
            BrowseRootFolder.Size = new Size(285, 40);
            BrowseRootFolder.TabIndex = 3;
            BrowseRootFolder.Text = "Set Solution Root";
            BrowseRootFolder.UseVisualStyleBackColor = false;
            BrowseRootFolder.Click += SyncSolution_Click;
            // 
            // RootPathLabel
            // 
            RootPathLabel.BorderStyle = BorderStyle.FixedSingle;
            RootPathLabel.Enabled = false;
            RootPathLabel.Location = new Point(424, 94);
            RootPathLabel.Name = "RootPathLabel";
            RootPathLabel.ReadOnly = true;
            RootPathLabel.Size = new Size(292, 23);
            RootPathLabel.TabIndex = 4;
            // 
            // ProjectSettingCheckedList
            // 
            ProjectSettingCheckedList.BackColor = SystemColors.Control;
            ProjectSettingCheckedList.BorderStyle = BorderStyle.FixedSingle;
            ProjectSettingCheckedList.CheckOnClick = true;
            ProjectSettingCheckedList.FormattingEnabled = true;
            ProjectSettingCheckedList.Location = new Point(458, 157);
            ProjectSettingCheckedList.Name = "ProjectSettingCheckedList";
            ProjectSettingCheckedList.Size = new Size(258, 362);
            ProjectSettingCheckedList.Sorted = true;
            ProjectSettingCheckedList.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Snow;
            button1.Location = new Point(458, 14);
            button1.Name = "button1";
            button1.Size = new Size(258, 40);
            button1.TabIndex = 7;
            button1.Text = "Set Local Json";
            button1.UseVisualStyleBackColor = false;
            button1.Click += SetAppSettingsLocal_Click;
            // 
            // Search
            // 
            Search.AutoSize = true;
            Search.Location = new Point(29, 68);
            Search.Name = "Search";
            Search.Size = new Size(93, 15);
            Search.TabIndex = 8;
            Search.Text = "Search Projects";
            Search.Click += Search_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(332, 94);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 9;
            label1.Text = "Solution Root:";
            // 
            // Appsettings
            // 
            Appsettings.AutoSize = true;
            Appsettings.BackColor = Color.Transparent;
            Appsettings.Location = new Point(376, 157);
            Appsettings.Name = "Appsettings";
            Appsettings.Size = new Size(76, 15);
            Appsettings.TabIndex = 10;
            Appsettings.Text = "Appsettings:";
            Appsettings.Click += Appsettings_Click;
            // 
            // CurrentProjectLabel
            // 
            CurrentProjectLabel.BorderStyle = BorderStyle.FixedSingle;
            CurrentProjectLabel.Enabled = false;
            CurrentProjectLabel.Location = new Point(458, 128);
            CurrentProjectLabel.Name = "CurrentProjectLabel";
            CurrentProjectLabel.ReadOnly = true;
            CurrentProjectLabel.Size = new Size(258, 23);
            CurrentProjectLabel.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(350, 128);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 13;
            label3.Text = "Selected Project:";
            label3.Click += label3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(458, 58);
            button2.Name = "button2";
            button2.Size = new Size(102, 25);
            button2.TabIndex = 14;
            button2.Text = "Toggle All";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ToggleAllSettingsButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(614, 58);
            button3.Name = "button3";
            button3.Size = new Size(102, 25);
            button3.TabIndex = 15;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = true;
            button3.Click += ResetAllSettings_Click;
            // 
            // ConfigFixerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(789, 655);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(CurrentProjectLabel);
            Controls.Add(Appsettings);
            Controls.Add(label1);
            Controls.Add(Search);
            Controls.Add(button1);
            Controls.Add(ProjectSettingCheckedList);
            Controls.Add(RootPathLabel);
            Controls.Add(BrowseRootFolder);
            Controls.Add(ProjectSearch);
            Controls.Add(ProjectList);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ConfigFixerForm";
            Text = "ConfigFixer";
            Load += ConfigFixerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private ListView ProjectList;
        private TextBox ProjectSearch;
        private FolderBrowserDialog BrowseFolders;
        private Button BrowseRootFolder;
        private TextBox RootPathLabel;
        private CheckedListBox ProjectSettingCheckedList;
        private Button button1;
        private Label Search;
        private Label label1;
        private Label Appsettings;
        private DialogResult dialogueResult;
        private TextBox CurrentProjectLabel;
        private Label label3;
        private Button button2;
        private Button button3;
    }
}