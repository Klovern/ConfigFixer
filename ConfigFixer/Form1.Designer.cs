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
            textBox1 = new TextBox();
            checkedListBox2 = new CheckedListBox();
            button1 = new Button();
            Search = new Label();
            label1 = new Label();
            Appsettings = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
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
            BrowseRootFolder.Text = "Set Root Folder";
            BrowseRootFolder.UseVisualStyleBackColor = true;
            BrowseRootFolder.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(452, 49);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(285, 23);
            textBox1.TabIndex = 4;
            // 
            // checkedListBox2
            // 
            checkedListBox2.CheckOnClick = true;
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Location = new Point(515, 203);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(222, 418);
            checkedListBox2.TabIndex = 6;
            checkedListBox2.ItemCheck += CheckedListBox2_ItemCheck;
            // 
            // button1
            // 
            button1.Location = new Point(515, 126);
            button1.Name = "button1";
            button1.Size = new Size(222, 25);
            button1.TabIndex = 7;
            button1.Text = "Set Local Json";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
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
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(515, 157);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(222, 23);
            textBox2.TabIndex = 12;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 628);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(Appsettings);
            Controls.Add(label1);
            Controls.Add(Search);
            Controls.Add(button1);
            Controls.Add(checkedListBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private CheckedListBox checkedListBox2;
        private Button button1;
        private Label Search;
        private Label label1;
        private Label Appsettings;
        private Label label2;
        private DialogResult dialogueResult;
        private TextBox textBox2;
        private Label label3;
    }
}