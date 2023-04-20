
namespace LoginProject
{
    partial class AdminViewBooks
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
            this.ReturnLoginButton = new System.Windows.Forms.Button();
            this.ReturnMenuButton = new System.Windows.Forms.Button();
            this.labelUsers = new System.Windows.Forms.Label();
            this.BooksListBox = new System.Windows.Forms.ListBox();
            this.SearchBooksText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReturnLoginButton
            // 
            this.ReturnLoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReturnLoginButton.Location = new System.Drawing.Point(16, 15);
            this.ReturnLoginButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReturnLoginButton.Name = "ReturnLoginButton";
            this.ReturnLoginButton.Size = new System.Drawing.Size(208, 28);
            this.ReturnLoginButton.TabIndex = 15;
            this.ReturnLoginButton.Text = "Sign Out";
            this.ReturnLoginButton.UseVisualStyleBackColor = true;
            this.ReturnLoginButton.Click += new System.EventHandler(this.ReturnLoginButton_Click);
            // 
            // ReturnMenuButton
            // 
            this.ReturnMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReturnMenuButton.Location = new System.Drawing.Point(16, 50);
            this.ReturnMenuButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReturnMenuButton.Name = "ReturnMenuButton";
            this.ReturnMenuButton.Size = new System.Drawing.Size(208, 28);
            this.ReturnMenuButton.TabIndex = 16;
            this.ReturnMenuButton.Text = "Return to Menu";
            this.ReturnMenuButton.UseVisualStyleBackColor = true;
            this.ReturnMenuButton.Click += new System.EventHandler(this.ReturnMenuButton_Click);
            // 
            // labelUsers
            // 
            this.labelUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsers.Location = new System.Drawing.Point(452, 15);
            this.labelUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(136, 36);
            this.labelUsers.TabIndex = 17;
            this.labelUsers.Text = "Books";
            // 
            // BooksListBox
            // 
            this.BooksListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BooksListBox.ColumnWidth = 2;
            this.BooksListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BooksListBox.FormattingEnabled = true;
            this.BooksListBox.ItemHeight = 20;
            this.BooksListBox.Location = new System.Drawing.Point(79, 165);
            this.BooksListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BooksListBox.Name = "BooksListBox";
            this.BooksListBox.Size = new System.Drawing.Size(896, 304);
            this.BooksListBox.TabIndex = 18;
            // 
            // SearchBooksText
            // 
            this.SearchBooksText.Location = new System.Drawing.Point(768, 133);
            this.SearchBooksText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchBooksText.Name = "SearchBooksText";
            this.SearchBooksText.Size = new System.Drawing.Size(207, 22);
            this.SearchBooksText.TabIndex = 19;
            this.SearchBooksText.TextChanged += new System.EventHandler(this.SearchBooksText_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(761, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 36);
            this.label1.TabIndex = 20;
            this.label1.Text = "Search";
            // 
            // AdminViewBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBooksText);
            this.Controls.Add(this.BooksListBox);
            this.Controls.Add(this.labelUsers);
            this.Controls.Add(this.ReturnMenuButton);
            this.Controls.Add(this.ReturnLoginButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminViewBooks";
            this.Text = "AdminViewBooks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnLoginButton;
        private System.Windows.Forms.Button ReturnMenuButton;
        private System.Windows.Forms.Label labelUsers;
        private System.Windows.Forms.ListBox BooksListBox;
        private System.Windows.Forms.TextBox SearchBooksText;
        private System.Windows.Forms.Label label1;
    }
}