namespace WatsonDedupeUI
{
    partial class IndexInterface
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
            this.IndexLabel = new System.Windows.Forms.Label();
            this.StatsButton = new System.Windows.Forms.Button();
            this.ListObjectsButton = new System.Windows.Forms.Button();
            this.ObjectExistsButton = new System.Windows.Forms.Button();
            this.StoreObjectButton = new System.Windows.Forms.Button();
            this.RetrieveObjectButton = new System.Windows.Forms.Button();
            this.DeleteObjectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IndexLabel
            // 
            this.IndexLabel.AutoSize = true;
            this.IndexLabel.Location = new System.Drawing.Point(13, 13);
            this.IndexLabel.Name = "IndexLabel";
            this.IndexLabel.Size = new System.Drawing.Size(36, 13);
            this.IndexLabel.TabIndex = 0;
            this.IndexLabel.Text = "Index:";
            // 
            // StatsButton
            // 
            this.StatsButton.Location = new System.Drawing.Point(13, 44);
            this.StatsButton.Name = "StatsButton";
            this.StatsButton.Size = new System.Drawing.Size(108, 23);
            this.StatsButton.TabIndex = 1;
            this.StatsButton.Text = "Statistics";
            this.StatsButton.UseVisualStyleBackColor = true;
            this.StatsButton.Click += new System.EventHandler(this.StatsButton_Click);
            // 
            // ListObjectsButton
            // 
            this.ListObjectsButton.Location = new System.Drawing.Point(13, 73);
            this.ListObjectsButton.Name = "ListObjectsButton";
            this.ListObjectsButton.Size = new System.Drawing.Size(108, 23);
            this.ListObjectsButton.TabIndex = 3;
            this.ListObjectsButton.Text = "List Objects";
            this.ListObjectsButton.UseVisualStyleBackColor = true;
            this.ListObjectsButton.Click += new System.EventHandler(this.ListObjectsButton_Click);
            // 
            // ObjectExistsButton
            // 
            this.ObjectExistsButton.Location = new System.Drawing.Point(13, 102);
            this.ObjectExistsButton.Name = "ObjectExistsButton";
            this.ObjectExistsButton.Size = new System.Drawing.Size(108, 23);
            this.ObjectExistsButton.TabIndex = 4;
            this.ObjectExistsButton.Text = "Object Exists";
            this.ObjectExistsButton.UseVisualStyleBackColor = true;
            this.ObjectExistsButton.Click += new System.EventHandler(this.ObjectExistsButton_Click);
            // 
            // StoreObjectButton
            // 
            this.StoreObjectButton.Location = new System.Drawing.Point(127, 44);
            this.StoreObjectButton.Name = "StoreObjectButton";
            this.StoreObjectButton.Size = new System.Drawing.Size(116, 23);
            this.StoreObjectButton.TabIndex = 6;
            this.StoreObjectButton.Text = "Store Object";
            this.StoreObjectButton.UseVisualStyleBackColor = true;
            this.StoreObjectButton.Click += new System.EventHandler(this.StoreObjectButton_Click);
            // 
            // RetrieveObjectButton
            // 
            this.RetrieveObjectButton.Location = new System.Drawing.Point(127, 73);
            this.RetrieveObjectButton.Name = "RetrieveObjectButton";
            this.RetrieveObjectButton.Size = new System.Drawing.Size(116, 23);
            this.RetrieveObjectButton.TabIndex = 7;
            this.RetrieveObjectButton.Text = "Retrieve Object";
            this.RetrieveObjectButton.UseVisualStyleBackColor = true;
            this.RetrieveObjectButton.Click += new System.EventHandler(this.RetrieveObjectButton_Click);
            // 
            // DeleteObjectButton
            // 
            this.DeleteObjectButton.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteObjectButton.Location = new System.Drawing.Point(127, 102);
            this.DeleteObjectButton.Name = "DeleteObjectButton";
            this.DeleteObjectButton.Size = new System.Drawing.Size(116, 23);
            this.DeleteObjectButton.TabIndex = 8;
            this.DeleteObjectButton.Text = "Delete Object";
            this.DeleteObjectButton.UseVisualStyleBackColor = false;
            this.DeleteObjectButton.Click += new System.EventHandler(this.DeleteObjectButton_Click);
            // 
            // IndexInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 147);
            this.Controls.Add(this.DeleteObjectButton);
            this.Controls.Add(this.RetrieveObjectButton);
            this.Controls.Add(this.StoreObjectButton);
            this.Controls.Add(this.ObjectExistsButton);
            this.Controls.Add(this.ListObjectsButton);
            this.Controls.Add(this.StatsButton);
            this.Controls.Add(this.IndexLabel);
            this.Name = "IndexInterface";
            this.Text = "Index";
            this.Load += new System.EventHandler(this.IndexInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IndexLabel;
        private System.Windows.Forms.Button StatsButton;
        private System.Windows.Forms.Button ListObjectsButton;
        private System.Windows.Forms.Button ObjectExistsButton;
        private System.Windows.Forms.Button StoreObjectButton;
        private System.Windows.Forms.Button RetrieveObjectButton;
        private System.Windows.Forms.Button DeleteObjectButton;
    }
}