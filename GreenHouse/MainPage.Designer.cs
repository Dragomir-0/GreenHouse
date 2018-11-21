namespace GreenHouse
{
    partial class MainPage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plantMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectPlantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePlantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conditionMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvPlantMainPage = new System.Windows.Forms.DataGridView();
            this.lblMainPageIntro = new System.Windows.Forms.Label();
            this.btnSimulateMainPage = new System.Windows.Forms.Button();
            this.lblSelectedPlantMainPage = new System.Windows.Forms.Label();
            this.dgvConditionsMainPage = new System.Windows.Forms.DataGridView();
            this.lblConditionsMainPage = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlantMainPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConditionsMainPage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userMenuToolStripMenuItem,
            this.plantMenuToolStripMenuItem,
            this.conditionMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userMenuToolStripMenuItem
            // 
            this.userMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateUserToolStripMenuItem,
            this.addUserToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.userMenuToolStripMenuItem.Name = "userMenuToolStripMenuItem";
            this.userMenuToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.userMenuToolStripMenuItem.Text = "User Menu";
            // 
            // updateUserToolStripMenuItem
            // 
            this.updateUserToolStripMenuItem.Name = "updateUserToolStripMenuItem";
            this.updateUserToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.updateUserToolStripMenuItem.Text = "Update User";
            this.updateUserToolStripMenuItem.Click += new System.EventHandler(this.updateUserToolStripMenuItem_Click);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // plantMenuToolStripMenuItem
            // 
            this.plantMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectPlantToolStripMenuItem,
            this.updatePlantToolStripMenuItem});
            this.plantMenuToolStripMenuItem.Name = "plantMenuToolStripMenuItem";
            this.plantMenuToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.plantMenuToolStripMenuItem.Text = "Plant Menu";
            // 
            // selectPlantToolStripMenuItem
            // 
            this.selectPlantToolStripMenuItem.Name = "selectPlantToolStripMenuItem";
            this.selectPlantToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.selectPlantToolStripMenuItem.Text = "Select Plant";
            this.selectPlantToolStripMenuItem.Click += new System.EventHandler(this.selectPlantToolStripMenuItem_Click);
            // 
            // updatePlantToolStripMenuItem
            // 
            this.updatePlantToolStripMenuItem.Name = "updatePlantToolStripMenuItem";
            this.updatePlantToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.updatePlantToolStripMenuItem.Text = "Update Plant";
            this.updatePlantToolStripMenuItem.Click += new System.EventHandler(this.updatePlantToolStripMenuItem_Click);
            // 
            // conditionMenuToolStripMenuItem
            // 
            this.conditionMenuToolStripMenuItem.Name = "conditionMenuToolStripMenuItem";
            this.conditionMenuToolStripMenuItem.Size = new System.Drawing.Size(12, 24);
            // 
            // dgvPlantMainPage
            // 
            this.dgvPlantMainPage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlantMainPage.Location = new System.Drawing.Point(36, 130);
            this.dgvPlantMainPage.Name = "dgvPlantMainPage";
            this.dgvPlantMainPage.RowTemplate.Height = 24;
            this.dgvPlantMainPage.Size = new System.Drawing.Size(706, 130);
            this.dgvPlantMainPage.TabIndex = 1;
            this.dgvPlantMainPage.Visible = false;
            // 
            // lblMainPageIntro
            // 
            this.lblMainPageIntro.AutoSize = true;
            this.lblMainPageIntro.Location = new System.Drawing.Point(150, 57);
            this.lblMainPageIntro.Name = "lblMainPageIntro";
            this.lblMainPageIntro.Size = new System.Drawing.Size(365, 17);
            this.lblMainPageIntro.TabIndex = 2;
            this.lblMainPageIntro.Text = "No plants selected. Please select a plant using the menu";
            this.lblMainPageIntro.Visible = false;
            // 
            // btnSimulateMainPage
            // 
            this.btnSimulateMainPage.Location = new System.Drawing.Point(298, 571);
            this.btnSimulateMainPage.Name = "btnSimulateMainPage";
            this.btnSimulateMainPage.Size = new System.Drawing.Size(146, 37);
            this.btnSimulateMainPage.TabIndex = 3;
            this.btnSimulateMainPage.Text = "Simulate Conditions";
            this.btnSimulateMainPage.UseVisualStyleBackColor = true;
            this.btnSimulateMainPage.Visible = false;
            this.btnSimulateMainPage.Click += new System.EventHandler(this.btnSimulateMainPage_Click);
            // 
            // lblSelectedPlantMainPage
            // 
            this.lblSelectedPlantMainPage.AutoSize = true;
            this.lblSelectedPlantMainPage.Location = new System.Drawing.Point(33, 98);
            this.lblSelectedPlantMainPage.Name = "lblSelectedPlantMainPage";
            this.lblSelectedPlantMainPage.Size = new System.Drawing.Size(103, 17);
            this.lblSelectedPlantMainPage.TabIndex = 4;
            this.lblSelectedPlantMainPage.Text = "Selected Plant:";
            this.lblSelectedPlantMainPage.Visible = false;
            // 
            // dgvConditionsMainPage
            // 
            this.dgvConditionsMainPage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConditionsMainPage.Location = new System.Drawing.Point(36, 384);
            this.dgvConditionsMainPage.Name = "dgvConditionsMainPage";
            this.dgvConditionsMainPage.RowTemplate.Height = 24;
            this.dgvConditionsMainPage.Size = new System.Drawing.Size(706, 134);
            this.dgvConditionsMainPage.TabIndex = 5;
            this.dgvConditionsMainPage.Visible = false;
            // 
            // lblConditionsMainPage
            // 
            this.lblConditionsMainPage.AutoSize = true;
            this.lblConditionsMainPage.Location = new System.Drawing.Point(33, 352);
            this.lblConditionsMainPage.Name = "lblConditionsMainPage";
            this.lblConditionsMainPage.Size = new System.Drawing.Size(112, 17);
            this.lblConditionsMainPage.TabIndex = 6;
            this.lblConditionsMainPage.Text = "Plant conditions:";
            this.lblConditionsMainPage.Visible = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 644);
            this.Controls.Add(this.lblConditionsMainPage);
            this.Controls.Add(this.dgvConditionsMainPage);
            this.Controls.Add(this.lblSelectedPlantMainPage);
            this.Controls.Add(this.btnSimulateMainPage);
            this.Controls.Add(this.lblMainPageIntro);
            this.Controls.Add(this.dgvPlantMainPage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlantMainPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConditionsMainPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plantMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectPlantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePlantToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvPlantMainPage;
        private System.Windows.Forms.Label lblMainPageIntro;
        private System.Windows.Forms.Button btnSimulateMainPage;
        private System.Windows.Forms.Label lblSelectedPlantMainPage;
        private System.Windows.Forms.DataGridView dgvConditionsMainPage;
        private System.Windows.Forms.Label lblConditionsMainPage;
        private System.Windows.Forms.ToolStripMenuItem conditionMenuToolStripMenuItem;
    }
}