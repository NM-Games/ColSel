namespace ColSel
{
    partial class Form2
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
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.ByLabel = new System.Windows.Forms.Label();
            this.AuthorPictureBox = new System.Windows.Forms.PictureBox();
            this.AboutLabel = new System.Windows.Forms.Label();
            this.WebsiteButton = new System.Windows.Forms.Button();
            this.GithubButton = new System.Windows.Forms.Button();
            this.DiscordButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::ColSel.Properties.Resources.colsel_logo;
            this.LogoPictureBox.Location = new System.Drawing.Point(20, 12);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(147, 38);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VersionLabel.Location = new System.Drawing.Point(173, 10);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(94, 37);
            this.VersionLabel.TabIndex = 1;
            this.VersionLabel.Text = "v1.0.0";
            // 
            // ByLabel
            // 
            this.ByLabel.AutoSize = true;
            this.ByLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ByLabel.Location = new System.Drawing.Point(24, 70);
            this.ByLabel.Name = "ByLabel";
            this.ByLabel.Size = new System.Drawing.Size(35, 30);
            this.ByLabel.TabIndex = 2;
            this.ByLabel.Text = "by";
            // 
            // AuthorPictureBox
            // 
            this.AuthorPictureBox.Image = global::ColSel.Properties.Resources.logo_wide;
            this.AuthorPictureBox.Location = new System.Drawing.Point(62, 65);
            this.AuthorPictureBox.Name = "AuthorPictureBox";
            this.AuthorPictureBox.Size = new System.Drawing.Size(193, 45);
            this.AuthorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AuthorPictureBox.TabIndex = 3;
            this.AuthorPictureBox.TabStop = false;
            // 
            // AboutLabel
            // 
            this.AboutLabel.AutoSize = true;
            this.AboutLabel.Location = new System.Drawing.Point(9, 128);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(261, 30);
            this.AboutLabel.TabIndex = 4;
            this.AboutLabel.Text = "ColSel is a free and open-source tool to\r\nselect colors and view them in differen" +
    "t formats!";
            this.AboutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WebsiteButton
            // 
            this.WebsiteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.WebsiteButton.Location = new System.Drawing.Point(23, 177);
            this.WebsiteButton.Name = "WebsiteButton";
            this.WebsiteButton.Size = new System.Drawing.Size(75, 23);
            this.WebsiteButton.TabIndex = 5;
            this.WebsiteButton.Text = "Website";
            this.WebsiteButton.UseVisualStyleBackColor = true;
            this.WebsiteButton.Click += new System.EventHandler(this.WebsiteButton_Click);
            // 
            // GithubButton
            // 
            this.GithubButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GithubButton.Location = new System.Drawing.Point(104, 177);
            this.GithubButton.Name = "GithubButton";
            this.GithubButton.Size = new System.Drawing.Size(75, 23);
            this.GithubButton.TabIndex = 6;
            this.GithubButton.Text = "GitHub";
            this.GithubButton.UseVisualStyleBackColor = true;
            this.GithubButton.Click += new System.EventHandler(this.GithubButton_Click);
            // 
            // DiscordButton
            // 
            this.DiscordButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DiscordButton.Location = new System.Drawing.Point(185, 177);
            this.DiscordButton.Name = "DiscordButton";
            this.DiscordButton.Size = new System.Drawing.Size(75, 23);
            this.DiscordButton.TabIndex = 7;
            this.DiscordButton.Text = "Discord";
            this.DiscordButton.UseVisualStyleBackColor = true;
            this.DiscordButton.Click += new System.EventHandler(this.DiscordButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 221);
            this.Controls.Add(this.DiscordButton);
            this.Controls.Add(this.GithubButton);
            this.Controls.Add(this.WebsiteButton);
            this.Controls.Add(this.AboutLabel);
            this.Controls.Add(this.AuthorPictureBox);
            this.Controls.Add(this.ByLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.LogoPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::ColSel.Properties.Resources.colsel;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "About ColSel";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox LogoPictureBox;
        private Label VersionLabel;
        private Label ByLabel;
        private PictureBox AuthorPictureBox;
        private Label AboutLabel;
        private Button WebsiteButton;
        private Button GithubButton;
        private Button DiscordButton;
    }
}