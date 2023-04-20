
namespace LoginProject
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginPageUsernameText = new System.Windows.Forms.TextBox();
            this.LoginPicture = new System.Windows.Forms.PictureBox();
            this.LoginPagePasswordText = new System.Windows.Forms.TextBox();
            this.LoginPageUsername = new System.Windows.Forms.Label();
            this.LoginPagePassword = new System.Windows.Forms.Label();
            this.LoginPageLoginButton = new System.Windows.Forms.Button();
            this.LoginPageRegisterButton = new System.Windows.Forms.Button();
            this.LoginFormCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginPageUsernameText
            // 
            this.LoginPageUsernameText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginPageUsernameText.Location = new System.Drawing.Point(223, 210);
            this.LoginPageUsernameText.Name = "LoginPageUsernameText";
            this.LoginPageUsernameText.Size = new System.Drawing.Size(298, 20);
            this.LoginPageUsernameText.TabIndex = 0;
            // 
            // LoginPicture
            // 
            this.LoginPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginPicture.Image = ((System.Drawing.Image)(resources.GetObject("LoginPicture.Image")));
            this.LoginPicture.Location = new System.Drawing.Point(271, 12);
            this.LoginPicture.Name = "LoginPicture";
            this.LoginPicture.Size = new System.Drawing.Size(214, 128);
            this.LoginPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginPicture.TabIndex = 1;
            this.LoginPicture.TabStop = false;
            // 
            // LoginPagePasswordText
            // 
            this.LoginPagePasswordText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginPagePasswordText.Location = new System.Drawing.Point(223, 292);
            this.LoginPagePasswordText.Name = "LoginPagePasswordText";
            this.LoginPagePasswordText.Size = new System.Drawing.Size(298, 20);
            this.LoginPagePasswordText.TabIndex = 2;
            this.LoginPagePasswordText.UseSystemPasswordChar = true;
            // 
            // LoginPageUsername
            // 
            this.LoginPageUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginPageUsername.AutoSize = true;
            this.LoginPageUsername.BackColor = System.Drawing.SystemColors.Control;
            this.LoginPageUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPageUsername.Location = new System.Drawing.Point(92, 210);
            this.LoginPageUsername.Name = "LoginPageUsername";
            this.LoginPageUsername.Size = new System.Drawing.Size(91, 20);
            this.LoginPageUsername.TabIndex = 3;
            this.LoginPageUsername.Text = "Username";
            // 
            // LoginPagePassword
            // 
            this.LoginPagePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginPagePassword.AutoSize = true;
            this.LoginPagePassword.BackColor = System.Drawing.SystemColors.Control;
            this.LoginPagePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPagePassword.Location = new System.Drawing.Point(95, 289);
            this.LoginPagePassword.Name = "LoginPagePassword";
            this.LoginPagePassword.Size = new System.Drawing.Size(86, 20);
            this.LoginPagePassword.TabIndex = 4;
            this.LoginPagePassword.Text = "Password";
            // 
            // LoginPageLoginButton
            // 
            this.LoginPageLoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginPageLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPageLoginButton.Location = new System.Drawing.Point(223, 404);
            this.LoginPageLoginButton.Name = "LoginPageLoginButton";
            this.LoginPageLoginButton.Size = new System.Drawing.Size(132, 38);
            this.LoginPageLoginButton.TabIndex = 5;
            this.LoginPageLoginButton.Text = "Login";
            this.LoginPageLoginButton.UseVisualStyleBackColor = true;
            this.LoginPageLoginButton.Click += new System.EventHandler(this.LoginPageLoginButton_Click);
            // 
            // LoginPageRegisterButton
            // 
            this.LoginPageRegisterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginPageRegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPageRegisterButton.Location = new System.Drawing.Point(388, 404);
            this.LoginPageRegisterButton.Name = "LoginPageRegisterButton";
            this.LoginPageRegisterButton.Size = new System.Drawing.Size(132, 38);
            this.LoginPageRegisterButton.TabIndex = 6;
            this.LoginPageRegisterButton.Text = "Register";
            this.LoginPageRegisterButton.UseVisualStyleBackColor = true;
            this.LoginPageRegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // LoginFormCheckBox
            // 
            this.LoginFormCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginFormCheckBox.AutoSize = true;
            this.LoginFormCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginFormCheckBox.Location = new System.Drawing.Point(397, 317);
            this.LoginFormCheckBox.Name = "LoginFormCheckBox";
            this.LoginFormCheckBox.Size = new System.Drawing.Size(136, 20);
            this.LoginFormCheckBox.TabIndex = 7;
            this.LoginFormCheckBox.Text = "Show Password";
            this.LoginFormCheckBox.UseVisualStyleBackColor = true;
            this.LoginFormCheckBox.CheckedChanged += new System.EventHandler(this.LoginFormCheckBox_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(775, 487);
            this.Controls.Add(this.LoginFormCheckBox);
            this.Controls.Add(this.LoginPageRegisterButton);
            this.Controls.Add(this.LoginPageLoginButton);
            this.Controls.Add(this.LoginPagePassword);
            this.Controls.Add(this.LoginPageUsername);
            this.Controls.Add(this.LoginPagePasswordText);
            this.Controls.Add(this.LoginPicture);
            this.Controls.Add(this.LoginPageUsernameText);
            this.Name = "LoginForm";
            this.Text = "Andrei\'s App";
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginPageUsernameText;
        private System.Windows.Forms.PictureBox LoginPicture;
        private System.Windows.Forms.TextBox LoginPagePasswordText;
        private System.Windows.Forms.Label LoginPageUsername;
        private System.Windows.Forms.Label LoginPagePassword;
        private System.Windows.Forms.Button LoginPageLoginButton;
        private System.Windows.Forms.Button LoginPageRegisterButton;
        private System.Windows.Forms.CheckBox LoginFormCheckBox;
    }
}

