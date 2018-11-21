namespace GreenHouse
{
    partial class Login
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
            this.lblWelcomeLogin = new System.Windows.Forms.Label();
            this.lblUsernameLogin = new System.Windows.Forms.Label();
            this.lblPasswordLogin = new System.Windows.Forms.Label();
            this.txtUsernameLogin = new System.Windows.Forms.TextBox();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcomeLogin
            // 
            this.lblWelcomeLogin.AutoSize = true;
            this.lblWelcomeLogin.Location = new System.Drawing.Point(96, 35);
            this.lblWelcomeLogin.Name = "lblWelcomeLogin";
            this.lblWelcomeLogin.Size = new System.Drawing.Size(237, 17);
            this.lblWelcomeLogin.TabIndex = 0;
            this.lblWelcomeLogin.Text = "Welcome to Automated Greenhouse";
            // 
            // lblUsernameLogin
            // 
            this.lblUsernameLogin.AutoSize = true;
            this.lblUsernameLogin.Location = new System.Drawing.Point(38, 136);
            this.lblUsernameLogin.Name = "lblUsernameLogin";
            this.lblUsernameLogin.Size = new System.Drawing.Size(77, 17);
            this.lblUsernameLogin.TabIndex = 1;
            this.lblUsernameLogin.Text = "Username:";
            // 
            // lblPasswordLogin
            // 
            this.lblPasswordLogin.AutoSize = true;
            this.lblPasswordLogin.Location = new System.Drawing.Point(41, 210);
            this.lblPasswordLogin.Name = "lblPasswordLogin";
            this.lblPasswordLogin.Size = new System.Drawing.Size(73, 17);
            this.lblPasswordLogin.TabIndex = 2;
            this.lblPasswordLogin.Text = "Password:";
            // 
            // txtUsernameLogin
            // 
            this.txtUsernameLogin.Location = new System.Drawing.Point(157, 136);
            this.txtUsernameLogin.Name = "txtUsernameLogin";
            this.txtUsernameLogin.Size = new System.Drawing.Size(100, 22);
            this.txtUsernameLogin.TabIndex = 3;
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.Location = new System.Drawing.Point(157, 210);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.PasswordChar = '*';
            this.txtPasswordLogin.Size = new System.Drawing.Size(100, 22);
            this.txtPasswordLogin.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(121, 287);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 35);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 393);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPasswordLogin);
            this.Controls.Add(this.txtUsernameLogin);
            this.Controls.Add(this.lblPasswordLogin);
            this.Controls.Add(this.lblUsernameLogin);
            this.Controls.Add(this.lblWelcomeLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeLogin;
        private System.Windows.Forms.Label lblUsernameLogin;
        private System.Windows.Forms.Label lblPasswordLogin;
        private System.Windows.Forms.TextBox txtUsernameLogin;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.Button btnLogin;
    }
}

