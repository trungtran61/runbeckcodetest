using System;
using System.ComponentModel;
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

            try
            {
                // instantiate new file processor with user specified values
                var fileProcessor = new FileProcessor(
                    FileName.Text,
                    CommaDelimited.Checked ? FileType.CSV : FileType.TSV,
                    Convert.ToInt16(FieldsCount.Value));
                
                fileProcessor.ProcessFile();

                TotalRecords.Text = string.Concat("Total Records:    ", fileProcessor.TotalRecordsCount);
                ValidRecordsCount.Text = string.Concat("Valid Records:    ", fileProcessor.ValidRecordsCount);
                InvalidRecordsCount.Text = string.Concat("Invalid Records: ", fileProcessor.InvalidRecordsCount);
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
            // only enable Process File button if file was specified
            ProcessFile.Enabled = true;
        }
    }
}
