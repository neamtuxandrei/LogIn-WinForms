
namespace LoginProject
{
    partial class AdminMenu
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
            this.ViewUsersButton = new System.Windows.Forms.Button();
            this.CreateBookButton = new System.Windows.Forms.Button();
            this.ViewBooksButton = new System.Windows.Forms.Button();
            this.ReturnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewUsersButton
            // 
            this.ViewUsersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewUsersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewUsersButton.Location = new System.Drawing.Point(291, 146);
            this.ViewUsersButton.Name = "ViewUsersButton";
            this.ViewUsersButton.Size = new System.Drawing.Size(132, 38);
            this.ViewUsersButton.TabIndex = 6;
            this.ViewUsersButton.Text = "View Users";
            this.ViewUsersButton.UseVisualStyleBackColor = true;
            this.ViewUsersButton.Click += new System.EventHandler(this.ViewUsersButton_Click);
            // 
            // CreateBookButton
            // 
            this.CreateBookButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBookButton.Location = new System.Drawing.Point(291, 276);
            this.CreateBookButton.Name = "CreateBookButton";
            this.CreateBookButton.Size = new System.Drawing.Size(132, 38);
            this.CreateBookButton.TabIndex = 7;
            this.CreateBookButton.Text = "Buy Book";
            this.CreateBookButton.UseVisualStyleBackColor = true;
            this.CreateBookButton.Click += new System.EventHandler(this.BuyBookButton_Click);
            // 
            // ViewBooksButton
            // 
            this.ViewBooksButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewBooksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewBooksButton.Location = new System.Drawing.Point(291, 213);
            this.ViewBooksButton.Name = "ViewBooksButton";
            this.ViewBooksButton.Size = new System.Drawing.Size(132, 38);
            this.ViewBooksButton.TabIndex = 8;
            this.ViewBooksButton.Text = "View Books";
            this.ViewBooksButton.UseVisualStyleBackColor = true;
            this.ViewBooksButton.Click += new System.EventHandler(this.ViewBooksButton_Click);
            // 
            // ReturnLogin
            // 
            this.ReturnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReturnLogin.Location = new System.Drawing.Point(12, 12);
            this.ReturnLogin.Name = "ReturnLogin";
            this.ReturnLogin.Size = new System.Drawing.Size(156, 23);
            this.ReturnLogin.TabIndex = 16;
            this.ReturnLogin.Text = "Sign Out";
            this.ReturnLogin.UseVisualStyleBackColor = true;
            this.ReturnLogin.Click += new System.EventHandler(this.ReturnLogin_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 487);
            this.Controls.Add(this.ReturnLogin);
            this.Controls.Add(this.ViewBooksButton);
            this.Controls.Add(this.CreateBookButton);
            this.Controls.Add(this.ViewUsersButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminMenu";
            this.Text = "AdminPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewUsersButton;
        private System.Windows.Forms.Button CreateBookButton;
        private System.Windows.Forms.Button ViewBooksButton;
        private System.Windows.Forms.Button ReturnLogin;
    }
}