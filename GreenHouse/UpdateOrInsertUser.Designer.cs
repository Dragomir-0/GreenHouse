namespace GreenHouse
{
    partial class UpdateOrInsertUser
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
            this.lblUpdateOrInsertUser = new System.Windows.Forms.Label();
            this.lblUsernameUpdateOrInsert = new System.Windows.Forms.Label();
            this.lblPasswordUpdateOrInsert = new System.Windows.Forms.Label();
            this.lblConfirmPasswordUpdateOrInsert = new System.Windows.Forms.Label();
            this.txtUsernameUpdateOrInsert = new System.Windows.Forms.TextBox();
            this.txtPasswordUpdateOrInsert = new System.Windows.Forms.TextBox();
            this.txtConfirmPasswordUpdateOrInsert = new System.Windows.Forms.TextBox();
            this.btnUpdateOrInsert = new System.Windows.Forms.Button();
            this.btnBackUpdateOrInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUpdateOrInsertUser
            // 
            this.lblUpdateOrInsertUser.AutoSize = true;
            this.lblUpdateOrInsertUser.Location = new System.Drawing.Point(69, 13);
            this.lblUpdateOrInsertUser.Name = "lblUpdateOrInsertUser";
            this.lblUpdateOrInsertUser.Size = new System.Drawing.Size(46, 17);
            this.lblUpdateOrInsertUser.TabIndex = 0;
            this.lblUpdateOrInsertUser.Text = "label1";
            // 
            // lblUsernameUpdateOrInsert
            // 
            this.lblUsernameUpdateOrInsert.AutoSize = true;
            this.lblUsernameUpdateOrInsert.Location = new System.Drawing.Point(41, 107);
            this.lblUsernameUpdateOrInsert.Name = "lblUsernameUpdateOrInsert";
            this.lblUsernameUpdateOrInsert.Size = new System.Drawing.Size(73, 17);
            this.lblUsernameUpdateOrInsert.TabIndex = 1;
            this.lblUsernameUpdateOrInsert.Text = "Username";
            // 
            // lblPasswordUpdateOrInsert
            // 
            this.lblPasswordUpdateOrInsert.AutoSize = true;
            this.lblPasswordUpdateOrInsert.Location = new System.Drawing.Point(41, 154);
            this.lblPasswordUpdateOrInsert.Name = "lblPasswordUpdateOrInsert";
            this.lblPasswordUpdateOrInsert.Size = new System.Drawing.Size(69, 17);
            this.lblPasswordUpdateOrInsert.TabIndex = 2;
            this.lblPasswordUpdateOrInsert.Text = "Password";
            // 
            // lblConfirmPasswordUpdateOrInsert
            // 
            this.lblConfirmPasswordUpdateOrInsert.AutoSize = true;
            this.lblConfirmPasswordUpdateOrInsert.Location = new System.Drawing.Point(41, 200);
            this.lblConfirmPasswordUpdateOrInsert.Name = "lblConfirmPasswordUpdateOrInsert";
            this.lblConfirmPasswordUpdateOrInsert.Size = new System.Drawing.Size(121, 17);
            this.lblConfirmPasswordUpdateOrInsert.TabIndex = 3;
            this.lblConfirmPasswordUpdateOrInsert.Text = "Confirm Password";
            // 
            // txtUsernameUpdateOrInsert
            // 
            this.txtUsernameUpdateOrInsert.Location = new System.Drawing.Point(190, 102);
            this.txtUsernameUpdateOrInsert.Name = "txtUsernameUpdateOrInsert";
            this.txtUsernameUpdateOrInsert.Size = new System.Drawing.Size(100, 22);
            this.txtUsernameUpdateOrInsert.TabIndex = 4;
            // 
            // txtPasswordUpdateOrInsert
            // 
            this.txtPasswordUpdateOrInsert.Location = new System.Drawing.Point(190, 149);
            this.txtPasswordUpdateOrInsert.Name = "txtPasswordUpdateOrInsert";
            this.txtPasswordUpdateOrInsert.PasswordChar = '*';
            this.txtPasswordUpdateOrInsert.Size = new System.Drawing.Size(100, 22);
            this.txtPasswordUpdateOrInsert.TabIndex = 5;
            // 
            // txtConfirmPasswordUpdateOrInsert
            // 
            this.txtConfirmPasswordUpdateOrInsert.Location = new System.Drawing.Point(190, 200);
            this.txtConfirmPasswordUpdateOrInsert.Name = "txtConfirmPasswordUpdateOrInsert";
            this.txtConfirmPasswordUpdateOrInsert.PasswordChar = '*';
            this.txtConfirmPasswordUpdateOrInsert.Size = new System.Drawing.Size(100, 22);
            this.txtConfirmPasswordUpdateOrInsert.TabIndex = 6;
            // 
            // btnUpdateOrInsert
            // 
            this.btnUpdateOrInsert.Location = new System.Drawing.Point(86, 302);
            this.btnUpdateOrInsert.Name = "btnUpdateOrInsert";
            this.btnUpdateOrInsert.Size = new System.Drawing.Size(75, 36);
            this.btnUpdateOrInsert.TabIndex = 7;
            this.btnUpdateOrInsert.Text = "button1";
            this.btnUpdateOrInsert.UseVisualStyleBackColor = true;
            this.btnUpdateOrInsert.Click += new System.EventHandler(this.btnUpdateOrInsert_Click);
            // 
            // btnBackUpdateOrInsert
            // 
            this.btnBackUpdateOrInsert.Location = new System.Drawing.Point(215, 302);
            this.btnBackUpdateOrInsert.Name = "btnBackUpdateOrInsert";
            this.btnBackUpdateOrInsert.Size = new System.Drawing.Size(75, 36);
            this.btnBackUpdateOrInsert.TabIndex = 8;
            this.btnBackUpdateOrInsert.Text = "Back";
            this.btnBackUpdateOrInsert.UseVisualStyleBackColor = true;
            this.btnBackUpdateOrInsert.Click += new System.EventHandler(this.btnBackUpdateOrInsert_Click);
            // 
            // UpdateOrInsertUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 410);
            this.Controls.Add(this.btnBackUpdateOrInsert);
            this.Controls.Add(this.btnUpdateOrInsert);
            this.Controls.Add(this.txtConfirmPasswordUpdateOrInsert);
            this.Controls.Add(this.txtPasswordUpdateOrInsert);
            this.Controls.Add(this.txtUsernameUpdateOrInsert);
            this.Controls.Add(this.lblConfirmPasswordUpdateOrInsert);
            this.Controls.Add(this.lblPasswordUpdateOrInsert);
            this.Controls.Add(this.lblUsernameUpdateOrInsert);
            this.Controls.Add(this.lblUpdateOrInsertUser);
            this.Name = "UpdateOrInsertUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateOrInsertUser";
            this.Load += new System.EventHandler(this.UpdateOrInsertUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpdateOrInsertUser;
        private System.Windows.Forms.Label lblUsernameUpdateOrInsert;
        private System.Windows.Forms.Label lblPasswordUpdateOrInsert;
        private System.Windows.Forms.Label lblConfirmPasswordUpdateOrInsert;
        private System.Windows.Forms.TextBox txtUsernameUpdateOrInsert;
        private System.Windows.Forms.TextBox txtPasswordUpdateOrInsert;
        private System.Windows.Forms.TextBox txtConfirmPasswordUpdateOrInsert;
        private System.Windows.Forms.Button btnUpdateOrInsert;
        private System.Windows.Forms.Button btnBackUpdateOrInsert;
    }
}