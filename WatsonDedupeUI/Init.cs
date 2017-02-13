using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatsonDedupeUI
{
    public partial class Init : Form
    {
        public Init()
        {
            InitializeComponent();
        }

        private void Init_Load(object sender, EventArgs e)
        {

        }

        private void CreateNew_Click(object sender, EventArgs e)
        {
            CreateNew f = new WatsonDedupeUI.CreateNew();
            Hide();
            var result = f.ShowDialog();
            Close();
        }

        private void OpenExisting_Click(object sender, EventArgs e)
        {
            string file = null;
            OpenFileDialog d = new OpenFileDialog();
            if (d.ShowDialog() == DialogResult.OK)
            {
                file = d.FileName;
            }

            IndexInterface i = new IndexInterface(file);
            Hide();
            var result = i.ShowDialog();
            Close();
        }
    }
}
