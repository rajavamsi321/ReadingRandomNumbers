namespace ReadingRandomNumbers
{
    partial class Form1
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
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.lstBoxOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "OpenDialogBox1";
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(301, 44);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(169, 47);
            this.btnReadFile.TabIndex = 0;
            this.btnReadFile.Text = "Read From File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // lstBoxOutput
            // 
            this.lstBoxOutput.FormattingEnabled = true;
            this.lstBoxOutput.ItemHeight = 16;
            this.lstBoxOutput.Location = new System.Drawing.Point(238, 130);
            this.lstBoxOutput.Name = "lstBoxOutput";
            this.lstBoxOutput.Size = new System.Drawing.Size(289, 244);
            this.lstBoxOutput.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstBoxOutput);
            this.Controls.Add(this.btnReadFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.ListBox lstBoxOutput;
    }
}

