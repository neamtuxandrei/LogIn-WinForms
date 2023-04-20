
namespace LoginProject
{
    partial class BookRent
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
            this.BooksListBox = new System.Windows.Forms.ListBox();
            this.SearchBooksText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUsers = new System.Windows.Forms.Label();
            this.ReturnLoginButton = new System.Windows.Forms.Button();
            this.ReturnMenuButton = new System.Windows.Forms.Button();
            this.CartListBox = new System.Windows.Forms.ListBox();
            this.PricePerDay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddRentButton = new System.Windows.Forms.Button();
            this.RemoveRentButton = new System.Windows.Forms.Button();
            this.RentButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Sold = new System.Windows.Forms.TextBox();
            this.PageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BooksListBox
            // 
            this.BooksListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BooksListBox.ColumnWidth = 2;
            this.BooksListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BooksListBox.FormattingEnabled = true;
            this.BooksListBox.ItemHeight = 17;
            this.BooksListBox.Location = new System.Drawing.Point(12, 131);
            this.BooksListBox.Name = "BooksListBox";
            this.BooksListBox.Size = new System.Drawing.Size(231, 259);
            this.BooksListBox.TabIndex = 19;
            this.BooksListBox.Click += new System.EventHandler(this.BooksListBox_Click);
            this.BooksListBox.SelectedValueChanged += new System.EventHandler(this.BooksListBox_SelectedValueChanged_1);
            // 
            // SearchBooksText
            // 
            this.SearchBooksText.Location = new System.Drawing.Point(95, 105);
            this.SearchBooksText.Name = "SearchBooksText";
            this.SearchBooksText.Size = new System.Drawing.Size(104, 20);
            this.SearchBooksText.TabIndex = 20;
            this.SearchBooksText.TextChanged += new System.EventHandler(this.SearchBooksText_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "Search";
            // 
            // labelUsers
            // 
            this.labelUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsers.Location = new System.Drawing.Point(359, 12);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(76, 34);
            this.labelUsers.TabIndex = 22;
            this.labelUsers.Text = "Rent";
            // 
            // ReturnLoginButton
            // 
            this.ReturnLoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReturnLoginButton.Location = new System.Drawing.Point(12, 12);
            this.ReturnLoginButton.Name = "ReturnLoginButton";
            this.ReturnLoginButton.Size = new System.Drawing.Size(156, 23);
            this.ReturnLoginButton.TabIndex = 23;
            this.ReturnLoginButton.Text = "Sign out";
            this.ReturnLoginButton.UseVisualStyleBackColor = true;
            this.ReturnLoginButton.Click += new System.EventHandler(this.ReturnLoginButton_Click);
            // 
            // ReturnMenuButton
            // 
            this.ReturnMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReturnMenuButton.Location = new System.Drawing.Point(12, 42);
            this.ReturnMenuButton.Name = "ReturnMenuButton";
            this.ReturnMenuButton.Size = new System.Drawing.Size(156, 23);
            this.ReturnMenuButton.TabIndex = 24;
            this.ReturnMenuButton.Text = "Return to User Page";
            this.ReturnMenuButton.UseVisualStyleBackColor = true;
            this.ReturnMenuButton.Click += new System.EventHandler(this.ReturnMenuButton_Click);
            // 
            // CartListBox
            // 
            this.CartListBox.ColumnWidth = 2;
            this.CartListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartListBox.FormattingEnabled = true;
            this.CartListBox.ItemHeight = 17;
            this.CartListBox.Location = new System.Drawing.Point(557, 131);
            this.CartListBox.Name = "CartListBox";
            this.CartListBox.Size = new System.Drawing.Size(231, 259);
            this.CartListBox.TabIndex = 25;
            this.CartListBox.SelectedValueChanged += new System.EventHandler(this.CartListBox_SelectedValueChanged);
            // 
            // PricePerDay
            // 
            this.PricePerDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PricePerDay.Enabled = false;
            this.PricePerDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PricePerDay.Location = new System.Drawing.Point(307, 174);
            this.PricePerDay.Name = "PricePerDay";
            this.PricePerDay.Size = new System.Drawing.Size(180, 20);
            this.PricePerDay.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(329, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Price/day(EUR)";
            // 
            // TotalPrice
            // 
            this.TotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalPrice.Enabled = false;
            this.TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPrice.Location = new System.Drawing.Point(702, 408);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(86, 20);
            this.TotalPrice.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(520, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Total price/day(EUR)";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(344, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Rent Time";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(307, 253);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(180, 20);
            this.DateTimePicker.TabIndex = 37;
            // 
            // AddRentButton
            // 
            this.AddRentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddRentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRentButton.Location = new System.Drawing.Point(250, 352);
            this.AddRentButton.Name = "AddRentButton";
            this.AddRentButton.Size = new System.Drawing.Size(132, 38);
            this.AddRentButton.TabIndex = 39;
            this.AddRentButton.Text = "Add";
            this.AddRentButton.UseVisualStyleBackColor = true;
            this.AddRentButton.Click += new System.EventHandler(this.AddRentButton_Click);
            // 
            // RemoveRentButton
            // 
            this.RemoveRentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveRentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveRentButton.Location = new System.Drawing.Point(413, 352);
            this.RemoveRentButton.Name = "RemoveRentButton";
            this.RemoveRentButton.Size = new System.Drawing.Size(132, 38);
            this.RemoveRentButton.TabIndex = 40;
            this.RemoveRentButton.Text = "Remove";
            this.RemoveRentButton.UseVisualStyleBackColor = true;
            this.RemoveRentButton.Click += new System.EventHandler(this.RemoveRentButton_Click);
            // 
            // RentButton
            // 
            this.RentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentButton.Location = new System.Drawing.Point(333, 399);
            this.RentButton.Name = "RentButton";
            this.RentButton.Size = new System.Drawing.Size(132, 38);
            this.RentButton.TabIndex = 41;
            this.RentButton.Text = "Rent";
            this.RentButton.UseVisualStyleBackColor = true;
            this.RentButton.Click += new System.EventHandler(this.RentButton_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(562, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 28);
            this.label5.TabIndex = 43;
            this.label5.Text = "Sold";
            // 
            // Sold
            // 
            this.Sold.Enabled = false;
            this.Sold.Location = new System.Drawing.Point(624, 103);
            this.Sold.Name = "Sold";
            this.Sold.Size = new System.Drawing.Size(104, 20);
            this.Sold.TabIndex = 44;
            // 
            // PageLabel
            // 
            this.PageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PageLabel.AutoSize = true;
            this.PageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageLabel.ForeColor = System.Drawing.Color.LawnGreen;
            this.PageLabel.Location = new System.Drawing.Point(27, 413);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(0, 24);
            this.PageLabel.TabIndex = 45;
            // 
            // BookRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PageLabel);
            this.Controls.Add(this.Sold);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RentButton);
            this.Controls.Add(this.RemoveRentButton);
            this.Controls.Add(this.AddRentButton);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PricePerDay);
            this.Controls.Add(this.CartListBox);
            this.Controls.Add(this.ReturnMenuButton);
            this.Controls.Add(this.ReturnLoginButton);
            this.Controls.Add(this.labelUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBooksText);
            this.Controls.Add(this.BooksListBox);
            this.Name = "BookRent";
            this.Text = "BookRent";
            this.Load += new System.EventHandler(this.BookRent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox BooksListBox;
        private System.Windows.Forms.TextBox SearchBooksText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUsers;
        private System.Windows.Forms.Button ReturnLoginButton;
        private System.Windows.Forms.Button ReturnMenuButton;
        private System.Windows.Forms.ListBox CartListBox;
        private System.Windows.Forms.TextBox PricePerDay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TotalPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Button AddRentButton;
        private System.Windows.Forms.Button RemoveRentButton;
        private System.Windows.Forms.Button RentButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Sold;
        private System.Windows.Forms.Label PageLabel;
    }
}