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
    public partial class IndexInterface : Form
    {
        private string RootDirectory = null;
        private string ChunksDirectory = null;
        private DedupeLibrary D = null;

        public IndexInterface(string file)
        {
            InitializeComponent();
            InitializeChunkDirectory(file);
            InitializeLibrary(file);

            IndexLabel.Text = file;
        }

        private void IndexInterface_Load(object sender, EventArgs e)
        {

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

        private void InitializeLibrary(string file)
        {
            try
            {
                D = new DedupeLibrary(file, WriteChunk, ReadChunk, DeleteChunk, false, false);
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

        private void StatsButton_Click(object sender, EventArgs e)
        {
            int numObjects = 0;
            int numChunks = 0;
            long logicalBytes = 0;
            long physicalBytes = 0;
            decimal dedupeRatioX = 0m;
            decimal dedupeRatioPercent = 0m;

            if (!D.IndexStats(
                out numObjects,
                out numChunks,
                out logicalBytes,
                out physicalBytes,
                out dedupeRatioX,
                out dedupeRatioPercent))
            {
                MessageBox.Show("Unable to retrieve index statistics", "Error");
                return;
            }
            else
            {
                string message =
                    "Number of objects: " + numObjects + Environment.NewLine +
                    "Number of chunks: " + numChunks + Environment.NewLine +
                    "Logical bytes: " + logicalBytes + " bytes" + Environment.NewLine +
                    "Physical bytes: " + physicalBytes + " bytes" + Environment.NewLine +
                    "Dedupe ratio: " + dedupeRatioX + "X (" + dedupeRatioPercent.ToString("0.##") + "%)";

                MessageBox.Show(message, "Index statistics");
                return;
            }
        }
        
        private void ListObjectsButton_Click(object sender, EventArgs e)
        {
            List<string> keys = new List<string>();

            D.ListObjects(out keys);
            if (keys == null || keys.Count < 1)
            {
                MessageBox.Show("None", "Objects");
                return;
            }
            else
            {
                string message = "";
                foreach (string curr in keys)
                {
                    message += curr + Environment.NewLine;
                }

                MessageBox.Show(message, "Objects");
                return;
            }
        }

        private void ObjectExistsButton_Click(object sender, EventArgs e)
        {
            string val = null;
            using (var form = new CollectInput("Object key"))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    val = form.Value;
                }
            }

            if (String.IsNullOrEmpty(val)) return;
            if (D.ObjectExists(val))
            {
                MessageBox.Show("Object " + val + " exists");
            }
            else
            {
                MessageBox.Show("Object " + val + " does not exist");
            }

            return;
        }

        private void StoreObjectButton_Click(object sender, EventArgs e)
        {
            string inputFile = null;
            string objectKey = null;

            OpenFileDialog d = new OpenFileDialog();
            d.Title = "Choose input file";
            if (d.ShowDialog() == DialogResult.OK)
            {
                inputFile = d.FileName;
            }
            else
            {
                return;
            }

            using (var form = new CollectInput("Object Key"))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    objectKey = form.Value;
                }
            }

            byte[] data = File.ReadAllBytes(inputFile);
            List<Chunk> chunks = new List<Chunk>();

            if (D.StoreObject(objectKey, data, out chunks))
            {
                MessageBox.Show("Object successfully stored", "Information");
            }
            else
            {
                MessageBox.Show("Unable to store object", "Error");
            }
        }

        private void RetrieveObjectButton_Click(object sender, EventArgs e)
        {
            string outputFile = null;
            string objectKey = null;

            SaveFileDialog d = new SaveFileDialog();
            d.Title = "Choose output file";
            if (d.ShowDialog() == DialogResult.OK)
            {
                outputFile = d.FileName;
            }
            else
            {
                return;
            }

            using (var form = new CollectInput("Object Key"))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    objectKey = form.Value;
                }
            }

            byte[] data;
            if (D.RetrieveObject(objectKey, out data))
            {
                File.WriteAllBytes(outputFile, data);
                MessageBox.Show("Object successfully retrieved", "Information");
            }
            else
            {
                MessageBox.Show("Unable to retrieve object", "Error");
            }
        }

        private void DeleteObjectButton_Click(object sender, EventArgs e)
        {
            string objectKey = null;

            using (var form = new CollectInput("Object Key"))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    objectKey = form.Value;
                }
            }

            if (D.DeleteObject(objectKey))
            {
                MessageBox.Show("Object successfully deleted", "Information");
            }
            else
            {
                MessageBox.Show("Unable to delete object", "Error");
            }
        }
    }
}
