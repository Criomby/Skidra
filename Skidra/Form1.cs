using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skidra
{
    public partial class Form1 : Form
    {
        private string Python = Properties.Settings.Default.Python;
        private string PyScript = Properties.Settings.Default.PyScript;
        private string filepath = null;
        private string fileDir = null;

        private bool excel = false;
        private bool all = false;

        private bool ind = false;
        private bool lds = false;
        private bool ldsind = false;
        private bool top = false;
        private bool pit = false;
        private bool res = false;

        public Form1()
        {
            InitializeComponent();
            if (!File.Exists(Python))
            {
                const string message = "Welcome to Skidra!\n\nPlease select the location of your installed Python distribution.\nYou'll only have to do this once.";
                const string caption = "Skidra - Select Python.exe";
                var result = MessageBox.Show(message, caption,
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    OpenFileDialog openFileDialog1 = new OpenFileDialog
                    {
                        InitialDirectory = @"C:\",
                        Title = "Select Python.exe file",
                        CheckFileExists = true,
                        CheckPathExists = true,
                        DefaultExt = "exe",
                        Filter = "exe files (*.exe)|*.exe",
                        FilterIndex = 2,
                        RestoreDirectory = true,
                        ReadOnlyChecked = true,
                        ShowReadOnly = true
                    };
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        Properties.Settings.Default.Python = openFileDialog1.FileName;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        System.Environment.Exit(0);
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    System.Environment.Exit(0);
                }
            }
            if (!File.Exists(PyScript))
            {
                const string message2 = "Please select the Skidra Python script.\nYou'll only have to do this once.";
                const string caption2 = "Skidra - Select Python script";
                var result2 = MessageBox.Show(message2, caption2,
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result2 == DialogResult.OK)
                {
                    OpenFileDialog openFileDialog2 = new OpenFileDialog
                    {
                        InitialDirectory = @"C:\",
                        Title = "Select Skidra Python script file",
                        CheckFileExists = true,
                        CheckPathExists = true,
                        DefaultExt = "py",
                        Filter = "py files (*.py)|*.py",
                        FilterIndex = 2,
                        RestoreDirectory = true,
                        ReadOnlyChecked = true,
                        ShowReadOnly = true
                    };
                    if (openFileDialog2.ShowDialog() == DialogResult.OK)
                    {
                        Properties.Settings.Default.PyScript = openFileDialog2.FileName;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        System.Environment.Exit(0);
                    }
                    }
                    else
                    {
                        System.Environment.Exit(0);
                    }
            }
        }

        private string run_cmd(string cmd, string args)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            // Python venv of hubspool
            //start.FileName = "C:\\Users\\phili\\Documents\\Projects\\hubspool\\venvhub\\Scripts\\python.exe";
            start.FileName = Properties.Settings.Default.Python;
            start.Arguments = string.Format("{0} {1}", cmd, args);
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.RedirectStandardError = true;
            start.CreateNoWindow = true;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader_stdOut = process.StandardOutput)
                {
                    string result = reader_stdOut.ReadToEnd();
                    //Console.Write("Result Out:", result); // debug
                    if (result == "")
                    {
                        using (StreamReader reader_stdErr = process.StandardError)
                        {
                            string err = reader_stdErr.ReadToEnd();
                            //Console.Write("Result Err:", err); // debug
                            return err;
                        }
                    }
                    return result;
                } 
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog3 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Select .csv file",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "csv",
                Filter = "csv files (*.csv)|*.csv",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true,
                Multiselect = false,
            };

            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog3.FileName;
                fileDir = Path.GetDirectoryName(filepath);
                string filename = openFileDialog3.SafeFileName;
                richTextBox1.Text = "Selected file:\n" + filename;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (filepath is null)
            {
                richTextBox1.Text = "Select a file first.";
            }
            else
            {
                if ((all || ind || lds || ldsind || top || pit || res) == false) 
                {
                    richTextBox1.Text = "Select at least one option on the left or \"ALL\" to select all options.";
                }
                else
                {
                    Console.WriteLine($"{filepath}\n{fileDir}\n{excel}\n{all}\n{ind}\n{lds}\n{ldsind}\n{top}\n{pit}\n{res}"); // debug
                    string pyargs = $"{filepath} {fileDir} {excel} {all} {ind} {lds} {ldsind} {top} {pit} {res}";
                    //Console.WriteLine(pyargs); // debug
                    //string result = run_cmd("C:\\Users\\phili\\PycharmProjects\\winforms\\return.py", pyargs); // testing
                    string result = run_cmd(Properties.Settings.Default.PyScript, pyargs);
                    richTextBox1.Text = result;
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                all = true;
                checkBoxInd.Enabled = false;
                checkBoxLeads.Enabled = false;
                checkBoxLeadInd.Enabled = false;
                checkBoxTop.Enabled = false;
                checkBoxPit.Enabled = false;
                checkBoxRej.Enabled = false;

  
            }
            else if (!checkBox2.Checked)
            {
                all = false;
                checkBoxInd.Enabled = true;
                checkBoxLeads.Enabled = true;
                checkBoxLeadInd.Enabled = true;
                checkBoxTop.Enabled = true;
                checkBoxPit.Enabled = true;
                checkBoxRej.Enabled = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Criomby/Skidra");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://philippebraum.com");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var rTBzoom = richTextBox1.ZoomFactor;
            richTextBox1.Clear();
            richTextBox1.ZoomFactor = 1.0f;
            richTextBox1.ZoomFactor = rTBzoom;
            checkBoxExcel.Checked = false;
            checkBox2.Checked = false;
            checkBoxInd.Checked = false;
            checkBoxLeads.Checked = false;
            checkBoxLeadInd.Checked = false;
            checkBoxTop.Checked = false;
            checkBoxPit.Checked = false;
            checkBoxRej.Checked = false;
        }

        private void checkBoxExcel_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxExcel.Checked)
            {
                excel = true;
            }
            else if (!checkBoxExcel.Checked)
            {
                excel = false;
            }
        }

        private void checkBoxInd_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxInd.Checked)
            {
                ind = true;
                checkBox2.Enabled = false;
            }
            else if (!checkBoxInd.Checked)
            {
                ind = false;
                if ((ind || lds || ldsind || top || pit || res) == false) { checkBox2.Enabled = true; }
            }
        }

        private void checkBoxLeads_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLeads.Checked)
            {
                lds = true;
                checkBox2.Enabled = false;
            }
            else if (!checkBoxLeads.Checked)
            {
                lds = false;
                if ((ind || lds || ldsind || top || pit || res) == false) { checkBox2.Enabled = true; }
            }
        }

        private void checkBoxLeadInd_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLeadInd.Checked)
            {
                ldsind = true;
                checkBox2.Enabled = false;
            }
            else if (!checkBoxLeadInd.Checked)
            {
                ldsind = false;
                if ((ind || lds || ldsind || top || pit || res) == false) { checkBox2.Enabled = true; }
            }
        }

        private void checkBoxTop_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTop.Checked)
            {
                top = true;
                checkBox2.Enabled = false;
            }
            else if (!checkBoxTop.Checked)
            {
                top = false;
                if ((ind || lds || ldsind || top || pit || res) == false) { checkBox2.Enabled = true; }
            }
        }

        private void checkBoxPit_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPit.Checked)
            {
                pit = true;
                checkBox2.Enabled = false;
            }
            else if (!checkBoxPit.Checked)
            {
                pit = false;
                if ((ind || lds || ldsind || top || pit || res) == false) { checkBox2.Enabled = true; }
            }
        }

        private void checkBoxRej_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRej.Checked)
            {
                res = true;
                checkBox2.Enabled = false;
            }
            else if (!checkBoxRej.Checked)
            {
                res = false;
                if ((ind || lds || ldsind || top || pit || res) == false) { checkBox2.Enabled = true; }
            }
        }
    }
}
