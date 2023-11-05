using Microsoft.Extensions.Configuration;

namespace ConfigFixer
{
    public partial class Form1 : Form
    {

        private string _SOLUTIONPATH = string.Empty;
        private List<(string ProjectName, string ProjectPath)> _PROJECTS = new List<(string ProjectName, string ProjectPath)>();
        private string _FOCUSEDPROJECT = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void Search_Changed(object sender, EventArgs e)
        {
            this.ProjectList.Clear();
            var dyn = (dynamic)sender;

            if (dyn.Text == string.Empty)
            {
                foreach (var project in _PROJECTS)
                {
                    this.ProjectList.Items.Add(project.ProjectName);
                }
                return;
            }

            var projects = _PROJECTS.Where(project => project.ProjectName.Contains(dyn.Text, StringComparison.InvariantCultureIgnoreCase));

            foreach (var project in projects)
            {
                this.ProjectList.Items.Add(project.ProjectName);
            }
        }

        private void ProjectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox2.Items.Clear();

            _FOCUSEDPROJECT = ProjectList?.FocusedItem?.Text.ToString() ?? string.Empty;

            if (_FOCUSEDPROJECT is null || _FOCUSEDPROJECT == string.Empty)
            {
                return;
            }

            this.textBox2.Text = _FOCUSEDPROJECT;

            try
            {
                var appsettingsPath = @_PROJECTS.First(p => p.ProjectName == _FOCUSEDPROJECT).ProjectPath.Replace(_FOCUSEDPROJECT, "") + "appsettings.json";
                var appsettingsLocalPath = @_PROJECTS.First(p => p.ProjectName == _FOCUSEDPROJECT).ProjectPath.Replace(_FOCUSEDPROJECT, "") + "appsettings.local.json";

                var appsettingsConfig = new ConfigurationBuilder().AddJsonFile(appsettingsPath).Build();
                var appsettingsLocalFileExists = File.Exists(appsettingsLocalPath);
                var appsettingsLocalConfig = appsettingsLocalFileExists ? new ConfigurationBuilder().AddJsonFile(appsettingsLocalPath).Build() : new ConfigurationBuilder().Build();
                var appsettingsLocalConfigSettingKeys = appsettingsLocalConfig.Providers.SelectMany(configurationProvider => configurationProvider.GetChildKeys(new List<string>(), default)).Distinct().OrderBy(key => key);

                int i = 0;
                var configSetting = new List<(string ConfigName, bool UseTest)>();
                foreach (var settingKey in appsettingsConfig.Providers.SelectMany(configurationProvider => configurationProvider.GetChildKeys(new List<string>(), default)).Distinct().OrderBy(key => key))
                {
                    checkedListBox2.Items.Add(settingKey);

                    if (appsettingsLocalConfigSettingKeys.Contains(settingKey))
                    {
                        checkedListBox2.SetItemCheckState(i, CheckState.Checked);
                    }

                    configSetting.Add(new(settingKey, appsettingsLocalConfigSettingKeys.Contains(settingKey)));

                    i++;
                }
            }
            catch (Exception ex)
            {
                // do nothing
            }
        }


        private void SyncSolution_Click(object sender, EventArgs e)
        {
            ProjectList.Items.Clear();
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "solution files (*.sln)|*.sln",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                FileInfo fileInfo = new FileInfo(openFileDialog1.FileName);
                _SOLUTIONPATH = fileInfo.DirectoryName!;

                var csProjFilePaths = Directory.EnumerateFiles(_SOLUTIONPATH, "*.csproj*", SearchOption.AllDirectories).Where(file => file.EndsWith(".csproj"));
                var projectInformations = new List<(string ProjectName, string ProjectPath)>();

                foreach (var csprojPath in csProjFilePaths)
                {
                    var last = csprojPath.LastIndexOf("\\") + 1;
                    var projectName = csprojPath.Substring(last);
                    projectInformations.Add(new() { ProjectName = projectName, ProjectPath = csprojPath });
                }

                foreach (var projectInformation in projectInformations)
                {
                    this.ProjectList.Items.Add(projectInformation.ProjectName);
                }

                _PROJECTS = projectInformations;
                textBox1.Text = _SOLUTIONPATH;
            }
        }

        private void SetAppSettingsLocal_Click(object sender, EventArgs e)
        {
            var path = @_PROJECTS.First(p => p.ProjectName == _FOCUSEDPROJECT).ProjectPath.Replace(_FOCUSEDPROJECT, "");
            var localAppsettingsFile = @path + "appsettings.local.json";

            var testSettingsReference = File.ReadAllText("testsettings.txt");

            using (StreamWriter sw = new StreamWriter(localAppsettingsFile))
            {
                sw.Write("{");

                for (int i = 0; i < checkedListBox2.CheckedItems.Count; i++)
                {
                    var setting = (string)checkedListBox2.CheckedItems[i]!;
                    var testsettingsSubstringedBeginning = testSettingsReference.Substring(testSettingsReference.IndexOf("@@" + setting)).Substring(setting.Length + 2);
                    var testsettingsSubstringedBeginningAndEnd = testsettingsSubstringedBeginning.Substring(0, testsettingsSubstringedBeginning.IndexOf("@@@"));

                    sw.Write(testsettingsSubstringedBeginningAndEnd);

                    if (checkedListBox2.CheckedItems.Count != i + 1)
                    {
                        sw.Write("  ,");
                    }
                }
                sw.Write("}");
            }
        }

        private void ToggleAllSettingsButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                checkedListBox2.SetItemCheckState(i, CheckState.Checked);
            }
        }

        private void ResetAllSettings_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                checkedListBox2.SetItemCheckState(i, CheckState.Unchecked);
            }
        }
    }
}

