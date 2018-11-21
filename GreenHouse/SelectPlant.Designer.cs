namespace GreenHouse
{
    partial class SelectPlant
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
            this.lbxCurrentPlants = new System.Windows.Forms.ListBox();
            this.lblSelectPlant = new System.Windows.Forms.Label();
            this.btnSelectPlant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxCurrentPlants
            // 
            this.lbxCurrentPlants.FormattingEnabled = true;
            this.lbxCurrentPlants.ItemHeight = 16;
            this.lbxCurrentPlants.Location = new System.Drawing.Point(66, 63);
            this.lbxCurrentPlants.Name = "lbxCurrentPlants";
            this.lbxCurrentPlants.Size = new System.Drawing.Size(255, 212);
            this.lbxCurrentPlants.TabIndex = 0;
            // 
            // lblSelectPlant
            // 
            this.lblSelectPlant.AutoSize = true;
            this.lblSelectPlant.Location = new System.Drawing.Point(80, 29);
            this.lblSelectPlant.Name = "lblSelectPlant";
            this.lblSelectPlant.Size = new System.Drawing.Size(212, 17);
            this.lblSelectPlant.TabIndex = 1;
            this.lblSelectPlant.Text = "Plants currently in the database:";
            // 
            // btnSelectPlant
            // 
            this.btnSelectPlant.Location = new System.Drawing.Point(127, 314);
            this.btnSelectPlant.Name = "btnSelectPlant";
            this.btnSelectPlant.Size = new System.Drawing.Size(134, 34);
            this.btnSelectPlant.TabIndex = 2;
            this.btnSelectPlant.Text = "Select Plant";
            this.btnSelectPlant.UseVisualStyleBackColor = true;
            this.btnSelectPlant.Click += new System.EventHandler(this.btnSelectPlant_Click);
            // 
            // SelectPlant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 376);
            this.Controls.Add(this.btnSelectPlant);
            this.Controls.Add(this.lblSelectPlant);
            this.Controls.Add(this.lbxCurrentPlants);
            this.Name = "SelectPlant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectPlant";
            this.Load += new System.EventHandler(this.SelectPlant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCurrentPlants;
        private System.Windows.Forms.Label lblSelectPlant;
        private System.Windows.Forms.Button btnSelectPlant;
    }
}