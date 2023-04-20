
namespace LoginProject
{
    partial class AdminViewUsers
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
            this.UsersListBox = new System.Windows.Forms.ListBox();
            this.labelUsers = new System.Windows.Forms.Label();
            this.ReturnLoginButton = new System.Windows.Forms.Button();
            this.ReturnMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsersListBox
            // 
            this.UsersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersListBox.ColumnWidth = 2;
            this.UsersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersListBox.FormattingEnabled = true;
            this.UsersListBox.ItemHeight = 17;
            this.UsersListBox.Location = new System.Drawing.Point(59, 134);
            this.UsersListBox.Name = "UsersListBox";
            this.UsersListBox.Size = new System.Drawing.Size(673, 259);
            this.UsersListBox.TabIndex = 0;
            this.UsersListBox.DoubleClick += new System.EventHandler(this.UsersListBox_DoubleClick);
            // 
            // labelUsers
            // 
            this.labelUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsers.Location = new System.Drawing.Point(330, 12);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(96, 29);
            this.labelUsers.TabIndex = 1;
            this.labelUsers.Text = "Users";
            // 
            // ReturnLoginButton
            // 
            this.ReturnLoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReturnLoginButton.Location = new System.Drawing.Point(12, 12);
            this.ReturnLoginButton.Name = "ReturnLoginButton";
            this.ReturnLoginButton.Size = new System.Drawing.Size(156, 23);
            this.ReturnLoginButton.TabIndex = 14;
            this.ReturnLoginButton.Text = "Sign Out";
            this.ReturnLoginButton.UseVisualStyleBackColor = true;
            this.ReturnLoginButton.Click += new System.EventHandler(this.ReturnLoginButton_Click);
            // 
            // ReturnMenuButton
            // 
            this.ReturnMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReturnMenuButton.Location = new System.Drawing.Point(12, 41);
            this.ReturnMenuButton.Name = "ReturnMenuButton";
            this.ReturnMenuButton.Size = new System.Drawing.Size(156, 23);
            this.ReturnMenuButton.TabIndex = 15;
            this.ReturnMenuButton.Text = "Return to Menu";
            this.ReturnMenuButton.UseVisualStyleBackColor = true;
            this.ReturnMenuButton.Click += new System.EventHandler(this.ReturnMenuButton_Click);
            // 
            // AdminViewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReturnMenuButton);
            this.Controls.Add(this.ReturnLoginButton);
            this.Controls.Add(this.labelUsers);
            this.Controls.Add(this.UsersListBox);
            this.Name = "AdminViewUsers";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox UsersListBox;
        private System.Windows.Forms.Label labelUsers;
        private System.Windows.Forms.Button ReturnLoginButton;
        private System.Windows.Forms.Button ReturnMenuButton;
    }
}