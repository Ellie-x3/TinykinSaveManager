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
            using(var fbd = new FolderBrowserDialog()) { 
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    if (Directory.Exists(fbd.SelectedPath + "\\ILSAVES"))
                    {
                        saves.Clear(); 
                        btnApply.Enabled = true;
                        comboBox1.Enabled = true;

                        string[] files = Directory.GetFiles(fbd.SelectedPath + "\\ILSAVES");
                        path = fbd.SelectedPath;

                        foreach(var f in files) { 
                            comboBox1.Items.Add(Path.GetFileName(f));
                            string key = Path.GetFileName(f);
                            saves.Add(key, f);
                        }

                    } else {
                        MessageBox.Show("ILSAVES folder not found", "Message");
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
            string filePath = path + "\\SaveGame.save";
            Process[] processes = Process.GetProcessesByName("Tinykin");
            if (processes.Length != 0) { 
                MessageBox.Show("Please close Tinykin before applying save");
                return;
            }

            if (saves.ContainsKey(req)) {
                if(File.Exists(filePath)) { 
                    File.Delete(filePath);
                }

                File.Copy(saves[req], filePath);
                lblApplied.Text = "Applied successfully!";
            } else { 
                MessageBox.Show("Save was not found!", "Message");
                lblApplied.Text = "";
            }        
        }
    }
}