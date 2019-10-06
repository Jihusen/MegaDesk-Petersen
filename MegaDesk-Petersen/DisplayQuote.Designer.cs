namespace MegaDesk_Petersen
{
    partial class DisplayQuote
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.QuoteLabel = new System.Windows.Forms.Label();
            this.SeeQuote = new System.Windows.Forms.Button();
            this.ReadFile = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // QuoteLabel
            // 
            this.QuoteLabel.AutoSize = true;
            this.QuoteLabel.Location = new System.Drawing.Point(340, 150);
            this.QuoteLabel.Name = "QuoteLabel";
            this.QuoteLabel.Size = new System.Drawing.Size(0, 13);
            this.QuoteLabel.TabIndex = 3;
            // 
            // SeeQuote
            // 
            this.SeeQuote.Location = new System.Drawing.Point(343, 221);
            this.SeeQuote.Name = "SeeQuote";
            this.SeeQuote.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SeeQuote.Size = new System.Drawing.Size(75, 23);
            this.SeeQuote.TabIndex = 4;
            this.SeeQuote.Text = "See Quote";
            this.SeeQuote.UseVisualStyleBackColor = true;
            this.SeeQuote.Click += new System.EventHandler(this.SeeQuote_Click);
            // 
            // ReadFile
            // 
            this.ReadFile.Location = new System.Drawing.Point(151, 178);
            this.ReadFile.Name = "ReadFile";
            this.ReadFile.ReadOnly = true;
            this.ReadFile.Size = new System.Drawing.Size(449, 20);
            this.ReadFile.TabIndex = 5;
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReadFile);
            this.Controls.Add(this.SeeQuote);
            this.Controls.Add(this.QuoteLabel);
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label QuoteLabel;
        private System.Windows.Forms.Button SeeQuote;
        private System.Windows.Forms.TextBox ReadFile;
    }
}