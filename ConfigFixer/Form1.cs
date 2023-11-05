using Microsoft.Extensions.Configuration;
using System.Windows.Forms;

namespace ConfigFixer
{
    public partial class Form1 : Form
    {

        private string _PATH = string.Empty;
        private List<(string ProjectName, string ProjectPath)> _PROJECTS = new List<(string ProjectName, string ProjectPath)>();
        private string _FOCUSEDPROJECT = string.Empty;
        private Dictionary<string, List<(string ConfigName, bool UseTest)>> _PROJECTSETTINGS = new Dictionary<string, List<(string ConfigName, bool UseTest)>>();

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

        private void CheckedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var dyn = (dynamic)sender;
            if (dyn.SelectedItem == null) return;
            _PROJECTSETTINGS[_FOCUSEDPROJECT].Remove(new(dyn.SelectedItem, e.CurrentValue == CheckState.Checked ? true : false));
            _PROJECTSETTINGS[_FOCUSEDPROJECT].Add(new(dyn.SelectedItem, e.NewValue == CheckState.Checked ? true : false));
        }

        private void ProjectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox2.Items.Clear();

            _FOCUSEDPROJECT = ProjectList?.FocusedItem?.Text.ToString() ?? string.Empty;

            if (_FOCUSEDPROJECT is null || _FOCUSEDPROJECT == string.Empty)
            {
                return;
            }

            if (_PROJECTSETTINGS.ContainsKey(_FOCUSEDPROJECT))
            {

                int i = 0;
                var checkedSettings = new List<int>();

                foreach (var setting in _PROJECTSETTINGS[_FOCUSEDPROJECT])
                {
                    checkedListBox2.Items.Add(setting.ConfigName);
                    if (setting.UseTest)
                    {
                        checkedSettings.Add(i);
                    }
                    i++;
                }
                foreach (var check in checkedSettings)
                {
                    checkedListBox2.SetItemCheckState(check, CheckState.Checked);
                }
                return;
            }

            try
            {
                var configSetting = new List<(string ConfigName, bool UseTest)>();
                var path = @_PROJECTS.First(x => x.ProjectName == _FOCUSEDPROJECT).ProjectPath.Replace(_FOCUSEDPROJECT, "") + "appsettings.json"; ;
                var config = new ConfigurationBuilder().AddJsonFile(path).Build();

                foreach (var settingKey in config.Providers.SelectMany(x => x.GetChildKeys(new List<string>(), default)).Distinct().OrderBy(key => key))
                {
                    checkedListBox2.Items.Add(settingKey);
                    configSetting.Add(new(settingKey, false));
                }

                _PROJECTSETTINGS.Add(_FOCUSEDPROJECT, configSetting);
            }
            catch (Exception ex)
            {
                // do nothing
            }
        }


        private void button1_Click(object sender, EventArgs e)
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
                _PATH = fileInfo.DirectoryName!;

                this.ProjectList.Clear();

                var csProjFilePaths = Directory.EnumerateFiles(_PATH, "*.csproj*", SearchOption.AllDirectories).Where(file => file.EndsWith(".csproj"));
                var projectInformations = new List<(string ProjectName, string ProjectPath)>();

                foreach (var csprojPath in csProjFilePaths)
                {
                    var last = csprojPath.LastIndexOf("\\") + 1;
                    var projectName = csprojPath.Substring(last);
                    projectInformations.Add(new() { ProjectName = projectName, ProjectPath = csprojPath });
                }

                foreach (var projectInformation in projectInformations)
                {
                    Console.WriteLine(projectInformation.ProjectName + "\t" + projectInformation.ProjectPath);
                    this.ProjectList.Items.Add(projectInformation.ProjectName);
                }

                _PROJECTS = projectInformations;
                textBox1.Text = _PATH;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var path = @_PROJECTS.First(x => x.ProjectName == _FOCUSEDPROJECT).ProjectPath.Replace(_FOCUSEDPROJECT, "");
            var localAppsettingsFile = @path + "appsettings.local.json";

            var testsettings = File.ReadAllText("testsettings.txt");

            using (StreamWriter sw = new StreamWriter(localAppsettingsFile))
            {
                sw.Write("{");

                for (int i = 0; i < checkedListBox2.CheckedItems.Count; i++)
                {
                    var setting = (string)checkedListBox2.CheckedItems[i]!;
                    var testsettingsSubstringedBeginning = testsettings.Substring(testsettings.IndexOf("@@" + setting)).Substring(setting.Length + 2);
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
    }
}

