namespace ConfigFixer
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
            label2 = new Label();
            CurrentProjectLabel = new TextBox();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // ProjectList
            // 
            ProjectList.FullRowSelect = true;
            ProjectList.GridLines = true;
            ProjectList.Location = new Point(70, 102);
            ProjectList.MultiSelect = false;
            ProjectList.Name = "ProjectList";
            ProjectList.Size = new Size(284, 513);
            ProjectList.Sorting = SortOrder.Ascending;
            ProjectList.TabIndex = 0;
            ProjectList.UseCompatibleStateImageBehavior = false;
            ProjectList.View = View.List;
            ProjectList.SelectedIndexChanged += ProjectList_SelectedIndexChanged;
            // 
            // ProjectSearch
            // 
            ProjectSearch.Location = new Point(70, 52);
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
            BrowseRootFolder.Location = new Point(452, 20);
            BrowseRootFolder.Name = "BrowseRootFolder";
            BrowseRootFolder.Size = new Size(285, 23);
            BrowseRootFolder.TabIndex = 3;
            BrowseRootFolder.Text = "Get Root Solution Path";
            BrowseRootFolder.UseVisualStyleBackColor = true;
            BrowseRootFolder.Click += SyncSolution_Click;
            // 
            // RootPathLabel
            // 
            RootPathLabel.Enabled = false;
            RootPathLabel.Location = new Point(452, 49);
            RootPathLabel.Name = "RootPathLabel";
            RootPathLabel.ReadOnly = true;
            RootPathLabel.Size = new Size(285, 23);
            RootPathLabel.TabIndex = 4;
            // 
            // ProjectSettingCheckedList
            // 
            ProjectSettingCheckedList.CheckOnClick = true;
            ProjectSettingCheckedList.FormattingEnabled = true;
            ProjectSettingCheckedList.Location = new Point(515, 203);
            ProjectSettingCheckedList.Name = "ProjectSettingCheckedList";
            ProjectSettingCheckedList.Size = new Size(222, 418);
            ProjectSettingCheckedList.Sorted = true;
            ProjectSettingCheckedList.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(515, 97);
            button1.Name = "button1";
            button1.Size = new Size(222, 25);
            button1.TabIndex = 7;
            button1.Text = "Set Local Json";
            button1.UseVisualStyleBackColor = true;
            button1.Click += SetAppSettingsLocal_Click;
            // 
            // Search
            // 
            Search.AutoSize = true;
            Search.Location = new Point(19, 60);
            Search.Name = "Search";
            Search.Size = new Size(45, 15);
            Search.TabIndex = 8;
            Search.Text = "Search:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(415, 52);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 9;
            label1.Text = "Root:";
            // 
            // Appsettings
            // 
            Appsettings.AutoSize = true;
            Appsettings.Location = new Point(436, 203);
            Appsettings.Name = "Appsettings";
            Appsettings.Size = new Size(70, 15);
            Appsettings.TabIndex = 10;
            Appsettings.Text = "Appsettings";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 102);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 11;
            label2.Text = "Projects:";
            // 
            // CurrentProjectLabel
            // 
            CurrentProjectLabel.Enabled = false;
            CurrentProjectLabel.Location = new Point(515, 157);
            CurrentProjectLabel.Name = "CurrentProjectLabel";
            CurrentProjectLabel.ReadOnly = true;
            CurrentProjectLabel.Size = new Size(222, 23);
            CurrentProjectLabel.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(412, 157);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 13;
            label3.Text = "Selected Project:";
            // 
            // button2
            // 
            button2.Location = new Point(515, 126);
            button2.Name = "button2";
            button2.Size = new Size(102, 25);
            button2.TabIndex = 14;
            button2.Text = "Toggle All";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ToggleAllSettingsButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(635, 126);
            button3.Name = "button3";
            button3.Size = new Size(102, 25);
            button3.TabIndex = 15;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = true;
            button3.Click += ResetAllSettings_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 628);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(CurrentProjectLabel);
            Controls.Add(label2);
            Controls.Add(Appsettings);
            Controls.Add(label1);
            Controls.Add(Search);
            Controls.Add(button1);
            Controls.Add(ProjectSettingCheckedList);
            Controls.Add(RootPathLabel);
            Controls.Add(BrowseRootFolder);
            Controls.Add(ProjectSearch);
            Controls.Add(ProjectList);
            Name = "Form1";
            Text = "ConfigFixer";
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
        private Label label2;
        private DialogResult dialogueResult;
        private TextBox CurrentProjectLabel;
        private Label label3;
        private Button button2;
        private Button button3;
    }
}