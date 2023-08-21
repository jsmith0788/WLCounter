using LocalStreamTools.Models;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace LocalStreamTools
{
    public partial class Form1 : Form
    {
        private WinLossSettings Settings { get; set; }

        private string SettingsPath { get; set; }

        public Form1()
        {
            InitializeComponent();

            var applicationPath = GetApplicationPath();
            SettingsPath = Path.Combine(applicationPath, "Settings");

            CreateSettingsFolderIfNotExists();
            CreateBlankSettingsFileIfNotExists();
            Settings = GetSettings();
            LoadSettings();

            this.ActiveControl = lblFileSource;
        }

        public void LoadSettings()
        {
            txtSource.Text = Settings.FileSource;
            txtPrefix.Text = Settings.PrefixText;

            GlobalHotKey.RegisterHotKey("Ctrl + Alt + W", () =>
            {
                Settings.Wins++;
                UpdateStreamFile();
                SaveSettings();
            });

            GlobalHotKey.RegisterHotKey("Ctrl + Alt + L", () =>
            {
                Settings.Losses++;
                UpdateStreamFile();
                SaveSettings();
            });

            GlobalHotKey.RegisterHotKey("Ctrl + Alt + R", () =>
            {
                Settings.Wins = 0;
                Settings.Losses = 0;
                Settings.Draws = 0;
                UpdateStreamFile();
                SaveSettings();
            });
        }

        private void btnWin_Click(object sender, EventArgs e)
        {
            Settings.Wins++;
            UpdateStreamFile();
            SaveSettings();
        }

        private void btnLoss_Click(object sender, EventArgs e)
        {
            Settings.Losses++;
            UpdateStreamFile();
            SaveSettings();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Settings.Wins = 0;
            Settings.Losses = 0;
            Settings.Draws = 0;
            UpdateStreamFile();
            SaveSettings();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtSource.Text = ofd.FileName;
                    Settings.FileSource = ofd.FileName;
                    SaveSettings();
                }
            }
        }

        private string GetApplicationPath()
        {
            return Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
        }

        private void CreateSettingsFolderIfNotExists()
        {
            if (!Directory.Exists(SettingsPath))
            {
                Directory.CreateDirectory(SettingsPath);
            }
        }

        private void CreateBlankSettingsFileIfNotExists()
        {
            var path = GetSettingsFilePath();
            if (!File.Exists(path))
            {
                CreateEmptyFile(path);
            }
        }

        private void CreateBlankRankFileIfNotExists()
        {
            var path = GetSettingsFilePath();
            path = path.Substring(0, path.LastIndexOf('\\'));
            path += $"\\rankfile.txt";
            if (!File.Exists(path))
            {
                CreateEmptyFile(path);
            }
        }

        private WinLossSettings GetSettings()
        {
            var path = GetSettingsFilePath();

            if (!File.Exists(path))
            {
                CreateBlankSettingsFileIfNotExists();
                return new WinLossSettings();
            }

            var content = File.ReadAllText(path);

            if (string.IsNullOrWhiteSpace(content))
            {
                return new WinLossSettings();
            }
            
            try
            {
                return JsonConvert.DeserializeObject<WinLossSettings>(content);
            }
            catch
            {
                return new WinLossSettings();
            }
        }

        private void CreateEmptyFile(string fileName)
        {
            File.Create(fileName).Dispose();
        }

        private string GetSettingsFilePath()
        {
            return Path.Combine(SettingsPath, "winLossSettings.txt");
        }

        private void UpdateStreamFile()
        {
            var path = txtSource.Text;

            if (string.IsNullOrWhiteSpace(path))
            {
                MessageBox.Show($"Error updating Win/Loss file./r/nThere is no file selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }


            if (!File.Exists(path))
                CreateBlankSettingsFileIfNotExists();

            var content = $"{Settings.PrefixText} {Settings.Wins}/{Settings.Losses}/{Settings.Draws}";
            lblDisplay.Text = content;

            try
            {
                File.WriteAllText(path, content);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error updating Win/Loss file./r/n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void UpdateRankFile()
        {
            var path = txtSource.Text.Substring(0, txtSource.Text.LastIndexOf('\\'));
            path += "\\rankfile.txt";

            if (string.IsNullOrWhiteSpace(path))
            {
                MessageBox.Show($"Error updating Rank file. /r/n/There is no file selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            if (!File.Exists(path))
                CreateBlankRankFileIfNotExists();

            var content = $"{Settings.RankGroup} {Settings.RankNumber}";

            try
            {
                File.WriteAllText(path, content);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error updating rank file. /r/n/{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
        }

        private void SaveSettings()
        {
            var path = GetSettingsFilePath();

            if (!File.Exists(path))
            {
                CreateBlankSettingsFileIfNotExists();
            }

            var content = JsonConvert.SerializeObject(Settings);

            try
            {
                File.WriteAllText(path, content);
            }
            catch
            {
                //hide this error.. not a huge deal.
            }
        }

        private void txtPrefix_TextChanged(object sender, EventArgs e)
        {
            Settings.PrefixText = txtPrefix.Text;
            UpdateStreamFile();
            SaveSettings();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Settings.Draws += 1;
            UpdateStreamFile();
            SaveSettings();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.RankGroup = comboBox1.Text;
            UpdateRankFile();
            SaveSettings();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.RankNumber = comboBox2.Text;
            UpdateRankFile();
            SaveSettings();
        }
    }
}
