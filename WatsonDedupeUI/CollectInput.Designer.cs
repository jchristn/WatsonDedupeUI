namespace WatsonDedupeUI
{
    partial class CollectInput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ParamNameLabel = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ParamNameLabel
            // 
            this.ParamNameLabel.AutoSize = true;
            this.ParamNameLabel.Location = new System.Drawing.Point(13, 13);
            this.ParamNameLabel.Name = "ParamNameLabel";
            this.ParamNameLabel.Size = new System.Drawing.Size(86, 13);
            this.ParamNameLabel.TabIndex = 0;
            this.ParamNameLabel.Text = "Parameter Name";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(13, 30);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(304, 20);
            this.InputTextBox.TabIndex = 1;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(13, 57);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CollectInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 93);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.ParamNameLabel);
            this.Name = "CollectInput";
            this.Text = "Provide the Following Value";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ParamNameLabel;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button OkButton;
    }
}