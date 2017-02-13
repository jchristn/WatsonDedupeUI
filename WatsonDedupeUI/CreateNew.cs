using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatsonDedupe;

namespace WatsonDedupeUI
{
    public partial class CreateNew : Form
    {
        private string Filename = null;
        private string RootDirectory = null;
        private string ChunksDirectory = null;
        private DedupeLibrary D = null;

        public CreateNew()
        {
            InitializeComponent();
        }

        private void CreateNew_Load(object sender, EventArgs e)
        {
            DirectoryLabel.Text = "";
            FilenameTextBox.Text = "dedupe.idx";
            MinChunkSizeTextBox.Text = "128";
            MaxChunkSizeTextBox.Text = "4096";
            ShiftCountBytesTextBox.Text = "16";
            BoundaryCheckBytesTextBox.Text = "2";
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (!ValidateAndSetFields()) return;
            
            try
            {
                InitializeChunkDirectory(Filename);
                D = new DedupeLibrary(Filename,
                    Convert.ToInt32(MinChunkSizeTextBox.Text),
                    Convert.ToInt32(MaxChunkSizeTextBox.Text),
                    Convert.ToInt32(ShiftCountBytesTextBox.Text),
                    Convert.ToInt32(BoundaryCheckBytesTextBox.Text),
                    WriteChunk,
                    ReadChunk,
                    DeleteChunk,
                    false, false);
                IndexInterface i = new IndexInterface(Filename);
                Hide();
                var result = i.ShowDialog();
                Close();
            }
            catch (Exception ex)
            {
                DisplayException de = new DisplayException(ex);
                de.Show();
                Close();
            }
        }

        private bool ValidateAndSetFields()
        {
            if (String.IsNullOrEmpty(DirectoryLabel.Text))
            {
                MessageBox.Show("Please choose a directory", "Error");
                return false;
            }

            RootDirectory = DirectoryLabel.Text;

            if (String.IsNullOrEmpty(FilenameTextBox.Text))
            {
                MessageBox.Show("Please specify an index filename", "Error");
                return false;
            }

            Filename = RootDirectory + "\\" + FilenameTextBox.Text;

            int minChunkSize;
            int maxChunkSize;
            int shiftCount;
            int boundaryCheck;

            if (!Int32.TryParse(MinChunkSizeTextBox.Text, out minChunkSize)
                || !Int32.TryParse(MaxChunkSizeTextBox.Text, out maxChunkSize)
                || !Int32.TryParse(ShiftCountBytesTextBox.Text, out shiftCount)
                || !Int32.TryParse(BoundaryCheckBytesTextBox.Text, out boundaryCheck))
            {
                MessageBox.Show("Values must be convertible to integer", "Error");
                return false;
            }

            return true;
        }

        private void InitializeChunkDirectory(string file)
        {
            try
            {
                RootDirectory = Path.GetDirectoryName(file);
                ChunksDirectory = RootDirectory + "\\Chunks\\";
                if (!Directory.Exists(ChunksDirectory))
                {
                    Directory.CreateDirectory(ChunksDirectory);
                }
            }
            catch (Exception e)
            {
                DisplayException de = new DisplayException(e);
                de.Show();
                Close();
            }
        }

        private bool WriteChunk(Chunk data)
        {
            File.WriteAllBytes(ChunksDirectory + data.Key, data.Value);
            return true;
        }

        private byte[] ReadChunk(string key)
        {
            return File.ReadAllBytes(ChunksDirectory + key);
        }

        private bool DeleteChunk(string key)
        {
            File.Delete(ChunksDirectory + key);
            return true;
        }

        private void ChooseDirectory_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    DirectoryLabel.Text = fbd.SelectedPath;
                }
            }
        }
    }
}
