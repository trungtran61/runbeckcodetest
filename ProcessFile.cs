using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunbeckProcessFile
{
    public partial class ProcessFileForm : Form
    {
        public ProcessFileForm()
        {
            InitializeComponent();
        }

        private void ProcessFile_Load(object sender, EventArgs e)
        {

        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            // exit application
            this.Close();
        }

        private void ProcessFile_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;             

            var delimiter = (char) (CommaDelimited.Checked ? ',': '\t');

            var validRecords = new List<string>();
            var invalidRecords = new List<string>();

            try
            {
                string[] lines = File.ReadAllLines(FileName.Text);
                lines = lines.Skip(1).ToArray();
                TotalRecords.Text = string.Concat("Total Records:    ", lines.Length);

                // process all lines in parallel
                Parallel.ForEach(lines, (line, _, lineNumber) =>
                {
                    if (line.Split(delimiter).Length == FieldsCount.Value)
                    {
                        lock (validRecords)
                        {
                            validRecords.Add(line);
                        }
                    }
                    else
                    {
                        lock (invalidRecords)
                        {
                            invalidRecords.Add(line);
                        }
                    }
                });

                // create valid records file
                if (validRecords.Count > 0)
                {
                    File.WriteAllLines("ValidRecords.txt", validRecords.ToArray());
                }

                // create invalid record file
                if (invalidRecords.Count > 0)
                {
                    File.WriteAllLines("InvalidRecords.txt", invalidRecords.ToArray());
                }

                ValidRecordsCount.Text = string.Concat("Valid Records:    ", validRecords.Count);
                InvalidRecordsCount.Text = string.Concat("Invalid Records: ", invalidRecords.Count);

                validRecords.Clear();
                invalidRecords.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("Error occurs while processing file: ", ex.Message));
            }

            Cursor = Cursors.Arrow;
        }

        private void OpenFileDialog_Click(object sender, EventArgs e)
        {
            FileDialog.ShowDialog();
        }
      
        private void FileDialog_FileOk(object sender, CancelEventArgs e)
        {
            FileName.Text = FileDialog.FileName;
            ProcessFile.Enabled = true;
        }
    }
}
