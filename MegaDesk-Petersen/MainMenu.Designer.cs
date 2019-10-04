namespace MegaDesk_Petersen
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addNewQuote = new System.Windows.Forms.Button();
            this.searchQuote = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.DisplayQuotes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(332, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(385, 353);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // addNewQuote
            // 
            this.addNewQuote.Location = new System.Drawing.Point(47, 72);
            this.addNewQuote.Name = "addNewQuote";
            this.addNewQuote.Size = new System.Drawing.Size(186, 48);
            this.addNewQuote.TabIndex = 1;
            this.addNewQuote.Text = "Add New Quote";
            this.addNewQuote.UseVisualStyleBackColor = true;
            this.addNewQuote.Click += new System.EventHandler(this.AddQuote_Click);
            // 
            // searchQuote
            // 
            this.searchQuote.Location = new System.Drawing.Point(47, 225);
            this.searchQuote.Name = "searchQuote";
            this.searchQuote.Size = new System.Drawing.Size(186, 48);
            this.searchQuote.TabIndex = 3;
            this.searchQuote.Text = "Search Quotes";
            this.searchQuote.UseVisualStyleBackColor = true;
            this.searchQuote.Click += new System.EventHandler(this.SearchQuotes_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(47, 305);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(186, 48);
            this.exit.TabIndex = 4;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // DisplayQuotes
            // 
            this.DisplayQuotes.Location = new System.Drawing.Point(47, 145);
            this.DisplayQuotes.Name = "DisplayQuotes";
            this.DisplayQuotes.Size = new System.Drawing.Size(186, 48);
            this.DisplayQuotes.TabIndex = 5;
            this.DisplayQuotes.Text = "View Quotes";
            this.DisplayQuotes.UseVisualStyleBackColor = true;
            this.DisplayQuotes.Click += new System.EventHandler(this.DisplayQuotes_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DisplayQuotes);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.searchQuote);
            this.Controls.Add(this.addNewQuote);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainMenu";
            this.Text = "MegaDesk";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addNewQuote;
        private System.Windows.Forms.Button searchQuote;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button DisplayQuotes;
    }
}

