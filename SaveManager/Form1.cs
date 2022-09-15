using System;
using System.Diagnostics;

namespace SaveManager
{
    public partial class frmSave : Form
    {
        public frmSave()
        {
            InitializeComponent();
        }

        Dictionary<string, string> saves = new Dictionary<string, string>();
        string path = "";

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    if (Directory.Exists(fbd.SelectedPath))
                    {
                        path = fbd.SelectedPath;
                        saves.Clear();
                        btnApply.Enabled = true;
                        comboBox1.Enabled = true;

                        string[] files = Directory.GetFiles(path);


                        foreach (var f in files)
                        {
                            comboBox1.Items.Add(Path.GetFileName(f));
                            string key = Path.GetFileName(f);
                            saves.Add(key, f);
                        }

                    }
                    else
                    {
                        MessageBox.Show("folder not found", "Message");
                        btnApply.Enabled = false;
                        comboBox1.Enabled = false;
                        lblApplied.Text = "";
                        path = "";
                    }
                }
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string req = comboBox1.Text;
            string defaultPath = "C:\\Users\\" + Environment.GetEnvironmentVariable("username") + "\\AppData\\LocalLow\\tinyBuild Games\\SaveGame.save";

            Process[] processes = Process.GetProcessesByName("Tinykin");
            if (processes.Length != 0)
            {
                MessageBox.Show("Please close Tinykin before applying save");
                return;
            }

            if (File.Exists(defaultPath))
            {
                if (saves.ContainsKey(req))
                {
                    if (File.Exists(defaultPath))
                    {
                        File.Delete(defaultPath);
                    }

                    File.Copy(saves[req], defaultPath);
                    lblApplied.Text = "Applied successfully!";
                }
                else
                {
                    MessageBox.Show("Save was not found!", "Message");
                    lblApplied.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Tinykin is not installed in its default location. If you see this contact Toothie#1111 on discord", "Message");
            }


        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            lblApplied.Text = "";
        }
    }
}