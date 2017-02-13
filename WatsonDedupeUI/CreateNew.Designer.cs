namespace WatsonDedupeUI
{
    partial class CreateNew
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
            this.ChooseDirectory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MinChunkSizeTextBox = new System.Windows.Forms.TextBox();
            this.MaxChunkSizeTextBox = new System.Windows.Forms.TextBox();
            this.ShiftCountBytesTextBox = new System.Windows.Forms.TextBox();
            this.BoundaryCheckBytesTextBox = new System.Windows.Forms.TextBox();
            this.DirectoryLabel = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.FilenameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChooseDirectory
            // 
            this.ChooseDirectory.Location = new System.Drawing.Point(22, 21);
            this.ChooseDirectory.Name = "ChooseDirectory";
            this.ChooseDirectory.Size = new System.Drawing.Size(117, 23);
            this.ChooseDirectory.TabIndex = 0;
            this.ChooseDirectory.Text = "Directory";
            this.ChooseDirectory.UseVisualStyleBackColor = true;
            this.ChooseDirectory.Click += new System.EventHandler(this.ChooseDirectory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Minimum Chunk Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Maximum Chunk Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Shift Count Bytes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Boundary Check Bytes";
            // 
            // MinChunkSizeTextBox
            // 
            this.MinChunkSizeTextBox.Location = new System.Drawing.Point(161, 95);
            this.MinChunkSizeTextBox.Name = "MinChunkSizeTextBox";
            this.MinChunkSizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.MinChunkSizeTextBox.TabIndex = 5;
            // 
            // MaxChunkSizeTextBox
            // 
            this.MaxChunkSizeTextBox.Location = new System.Drawing.Point(161, 122);
            this.MaxChunkSizeTextBox.Name = "MaxChunkSizeTextBox";
            this.MaxChunkSizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.MaxChunkSizeTextBox.TabIndex = 6;
            // 
            // ShiftCountBytesTextBox
            // 
            this.ShiftCountBytesTextBox.Location = new System.Drawing.Point(161, 149);
            this.ShiftCountBytesTextBox.Name = "ShiftCountBytesTextBox";
            this.ShiftCountBytesTextBox.Size = new System.Drawing.Size(100, 20);
            this.ShiftCountBytesTextBox.TabIndex = 7;
            // 
            // BoundaryCheckBytesTextBox
            // 
            this.BoundaryCheckBytesTextBox.Location = new System.Drawing.Point(161, 176);
            this.BoundaryCheckBytesTextBox.Name = "BoundaryCheckBytesTextBox";
            this.BoundaryCheckBytesTextBox.Size = new System.Drawing.Size(100, 20);
            this.BoundaryCheckBytesTextBox.TabIndex = 8;
            // 
            // FileAndDirectoryLabel
            // 
            this.DirectoryLabel.AutoSize = true;
            this.DirectoryLabel.Location = new System.Drawing.Point(155, 25);
            this.DirectoryLabel.Name = "FileAndDirectoryLabel";
            this.DirectoryLabel.Size = new System.Drawing.Size(0, 13);
            this.DirectoryLabel.TabIndex = 9;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(259, 233);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 10;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(349, 233);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateBtn.TabIndex = 11;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Filename";
            // 
            // FilenameTextBox
            // 
            this.FilenameTextBox.Location = new System.Drawing.Point(161, 68);
            this.FilenameTextBox.Name = "FilenameTextBox";
            this.FilenameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FilenameTextBox.TabIndex = 13;
            // 
            // CreateNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 279);
            this.Controls.Add(this.FilenameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.DirectoryLabel);
            this.Controls.Add(this.BoundaryCheckBytesTextBox);
            this.Controls.Add(this.ShiftCountBytesTextBox);
            this.Controls.Add(this.MaxChunkSizeTextBox);
            this.Controls.Add(this.MinChunkSizeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChooseDirectory);
            this.Name = "CreateNew";
            this.Text = "Create New Index";
            this.Load += new System.EventHandler(this.CreateNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChooseDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MinChunkSizeTextBox;
        private System.Windows.Forms.TextBox MaxChunkSizeTextBox;
        private System.Windows.Forms.TextBox ShiftCountBytesTextBox;
        private System.Windows.Forms.TextBox BoundaryCheckBytesTextBox;
        private System.Windows.Forms.Label DirectoryLabel;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FilenameTextBox;
    }
}