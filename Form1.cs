using System.Diagnostics;
using System;
using System.IO.Compression;
using System.Management;

namespace PJCBLauncher;

public partial class Form1 : Form
{
    public float gameVersion = 0;
    public string zipPath = string.Empty;
    public Form1()
    {
        InitializeComponent();
    }

    private void button11_Click(object sender, EventArgs e)
    {
        WebManager.OpenUrl("https://linktr.ee/pixlplaya5");
    }

    private void button9_Click(object sender, EventArgs e)
    {
        WebManager.OpenUrl("https://github.com/pixlplaya5/clobeats-game/issues");
    }

    private void LogToTextBox(string log, string severity = "Log")
    {
        textBox1.AppendText($"[{severity}]: {log}{Environment.NewLine}");
    }

    private void button8_Click(object sender, EventArgs e)
    {
        LogToTextBox("START SYSTEM SPECS LOG");
        LogToTextBox($"Current Game Version: {gameVersion}");
        // Get CPU Name
        using (var searcher = new ManagementObjectSearcher("SELECT Name, NumberOfCores FROM Win32_Processor"))
        {
            foreach (var obj in searcher.Get())
            {
                LogToTextBox($"CPU: {obj["Name"]} ({obj["NumberOfCores"]} Cores)");
            }
        }

        // Get GPU Name
        using (var searcher = new ManagementObjectSearcher("SELECT Name FROM Win32_VideoController"))
        {
            foreach (var obj in searcher.Get())
            {
                LogToTextBox($"GPU: {obj["Name"]}");
            }
        }

        // Get Manufacturer, Model & Total RAM
        using (var searcher = new ManagementObjectSearcher("SELECT Manufacturer, Model, TotalPhysicalMemory FROM Win32_ComputerSystem"))
        {
            foreach (var obj in searcher.Get())
            {
                ulong ramBytes = Convert.ToUInt64(obj["TotalPhysicalMemory"]);
                LogToTextBox($"System: {obj["Manufacturer"]} {obj["Model"]}");
                LogToTextBox($"RAM: {ramBytes / (1024 * 1024 * 1024)} GB");
            }
        }
        
        // Get OS Version
        LogToTextBox($"OS: {Environment.OSVersion.VersionString}");
        TimeSpan uptime = TimeSpan.FromMilliseconds(Environment.TickCount64);
        LogToTextBox($"Uptime: {uptime.Days}d {uptime.Hours}h {uptime.Minutes}m {uptime.Seconds}s");
        LogToTextBox("STOP SYSTEM SPECS LOG");
    }

    private void checkBox3_CheckedChanged(object sender, EventArgs e)
    {
        comboBox3.Enabled = checkBox3.Checked;
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
        
    }

    private void button5_Click(object sender, EventArgs e)
    {
        using var dialog = new FolderBrowserDialog
        {
            Description = "Select a Folder",
            UseDescriptionForTitle = true,
            InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        };

        if (dialog.ShowDialog() == DialogResult.OK)
        {
            textBox2.Text = dialog.SelectedPath;
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        if (File.Exists(Path.Combine(textBox2.Text, "Project CloBeats.exe")))
        {
            string gfxApi;
            switch (comboBox3.Text)
            {
                case "DirectX 11": gfxApi = "d3d11"; break;
                case "DirectX 12": gfxApi = "d3d12"; break;
                case "OpenGL": gfxApi = "glcore"; break;
                case "Vulkan": gfxApi = "vulkan"; break;
                default: gfxApi = "d3d11"; break;
            }
            var startInfo = new ProcessStartInfo()
            {
                FileName = Path.Combine(textBox2.Text, "Project CloBeats.exe"),
                Arguments = "-force-" + gfxApi + " " + textBox3.Text,
                UseShellExecute = false,
            };
            Process.Start(startInfo);
        }
        else
        {
            LogToTextBox("Install path is invalid.", "Error");
        }

        if (checkBox1.Checked)
        {
            // Keep launcher open
        }
        else
        {
            Application.Exit();
        }
    }

    private async void button4_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(textBox4.Text))
        {
            button4.Enabled = false;
            progressBar1.Value = 0;

            // Progress<T> safely marshals updates back to the UI thread
            var progressIndicator = new Progress<double>(percent =>
            {
                progressBar1.Value = (int)percent;
            });

            try
            {
                string url = textBox4.Text;
                string savePath = textBox2.Text;

                zipPath = await DLManager.DownloadToFolderAsync(url, savePath, progressIndicator);
                LogToTextBox("Download complete!");
            }
            catch (Exception ex)
            {
                LogToTextBox($"Download failed: {ex.Message}", "Exception");
            }
            finally
            {
                button4.Enabled = true;
            }
            
            try
            {
                foreach (var file in Directory.GetFiles(textBox2.Text))
                {
                    if (file.EndsWith(".zip")) continue;
                    File.Delete(file);
                }
            }
            catch (Exception exception)
            {
                LogToTextBox(exception.Message, "Exception");
            }

            try
            {
                if (Path.GetExtension(zipPath).Equals(".zip", StringComparison.OrdinalIgnoreCase))
                {
                    ZipFile.ExtractToDirectory(zipPath, textBox2.Text, overwriteFiles: true);
                }
                else
                {
                    LogToTextBox($"File \"{zipPath}\" is not a .zip file.", "Error");
                }
            }
            catch (Exception exception)
            {
                LogToTextBox(exception.Message, "Exception");
            }
            
        }
        else
        {
            LogToTextBox("Please enter download URL.", "Error");
        }
    }
}