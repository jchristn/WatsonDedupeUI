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
    public partial class CollectInput : Form
    {
        public string Value { get; set; }

        public CollectInput(string title)
        {
            InitializeComponent();
            ParamNameLabel.Text = title;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(InputTextBox.Text)) return;
            this.Value = InputTextBox.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
