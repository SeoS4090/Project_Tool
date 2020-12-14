
namespace Project_Tool
{
    partial class ExcelToData
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
            this.FilePath = new System.Windows.Forms.TextBox();
            this.LoadFile = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.LogBox = new System.Windows.Forms.RichTextBox();
            this.LogClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FilePath
            // 
            this.FilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilePath.Location = new System.Drawing.Point(12, 12);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(285, 21);
            this.FilePath.TabIndex = 0;
            // 
            // LoadFile
            // 
            this.LoadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadFile.Location = new System.Drawing.Point(303, 10);
            this.LoadFile.Name = "LoadFile";
            this.LoadFile.Size = new System.Drawing.Size(120, 23);
            this.LoadFile.TabIndex = 1;
            this.LoadFile.Text = "Load";
            this.LoadFile.UseVisualStyleBackColor = true;
            this.LoadFile.Click += new System.EventHandler(this.LoadFile_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Savebtn.Location = new System.Drawing.Point(303, 362);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(120, 23);
            this.Savebtn.TabIndex = 2;
            this.Savebtn.Text = "Create Data File";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // LogBox
            // 
            this.LogBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogBox.Location = new System.Drawing.Point(12, 39);
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.Size = new System.Drawing.Size(285, 346);
            this.LogBox.TabIndex = 3;
            this.LogBox.Text = "";
            // 
            // LogClear
            // 
            this.LogClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogClear.Location = new System.Drawing.Point(303, 39);
            this.LogClear.Name = "LogClear";
            this.LogClear.Size = new System.Drawing.Size(120, 23);
            this.LogClear.TabIndex = 4;
            this.LogClear.Text = "LogClear";
            this.LogClear.UseVisualStyleBackColor = true;
            this.LogClear.Click += new System.EventHandler(this.LogClear_Click);
            // 
            // ExcelToData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 397);
            this.Controls.Add(this.LogClear);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.LoadFile);
            this.Controls.Add(this.FilePath);
            this.MinimumSize = new System.Drawing.Size(16, 145);
            this.Name = "ExcelToData";
            this.Text = "ExcelToData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Button LoadFile;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.RichTextBox LogBox;
        private System.Windows.Forms.Button LogClear;
    }
}