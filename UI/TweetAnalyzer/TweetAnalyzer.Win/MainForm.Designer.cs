namespace TweetAnalyzer.Win
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.TwitterUserToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DatabaseFileLocationToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.ConnectToTwitterToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ConnectToDatabaseToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.UserListToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.TweetListToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.DownloadUserTweetToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BatchDownloadNewTweetsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.StandardToolStrip = new System.Windows.Forms.ToolStrip();
            this.AddToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ViewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.AnalyseToolStrip = new System.Windows.Forms.ToolStrip();
            this.RunAnalyseToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.RunAllAnalysisToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.AnalyseResultsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.AnalyseConfigToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.TrendsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.MainStatusStrip.SuspendLayout();
            this.MainToolStrip.SuspendLayout();
            this.StandardToolStrip.SuspendLayout();
            this.AnalyseToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TwitterUserToolStripStatusLabel,
            this.DatabaseFileLocationToolStripStatusLabel});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 428);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(847, 22);
            this.MainStatusStrip.TabIndex = 1;
            this.MainStatusStrip.Text = "statusStrip1";
            // 
            // TwitterUserToolStripStatusLabel
            // 
            this.TwitterUserToolStripStatusLabel.Image = global::TweetAnalyzer.Win.Properties.Resources.if_2018_social_media_popular_app_logo_twitter_3225183;
            this.TwitterUserToolStripStatusLabel.Name = "TwitterUserToolStripStatusLabel";
            this.TwitterUserToolStripStatusLabel.Size = new System.Drawing.Size(104, 17);
            this.TwitterUserToolStripStatusLabel.Text = "Not Connected";
            this.TwitterUserToolStripStatusLabel.Click += new System.EventHandler(this.TwitterUserToolStripStatusLabel_Click);
            // 
            // DatabaseFileLocationToolStripStatusLabel
            // 
            this.DatabaseFileLocationToolStripStatusLabel.Image = global::TweetAnalyzer.Win.Properties.Resources.if_database_299089;
            this.DatabaseFileLocationToolStripStatusLabel.Name = "DatabaseFileLocationToolStripStatusLabel";
            this.DatabaseFileLocationToolStripStatusLabel.Size = new System.Drawing.Size(113, 17);
            this.DatabaseFileLocationToolStripStatusLabel.Text = "Database Not Set";
            this.DatabaseFileLocationToolStripStatusLabel.Click += new System.EventHandler(this.ConnectToDatabaseToolStripStatusLabel_Click);
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(958, 24);
            this.MainMenuStrip.TabIndex = 2;
            this.MainMenuStrip.Text = "menuStrip1";
            this.MainMenuStrip.Visible = false;
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectToTwitterToolStripButton,
            this.ConnectToDatabaseToolStripButton,
            this.toolStripSeparator1,
            this.UserListToolStripButton,
            this.TweetListToolStripButton,
            this.toolStripSeparator2,
            this.DownloadUserTweetToolStripButton,
            this.BatchDownloadNewTweetsToolStripButton,
            this.toolStripSeparator3,
            this.TrendsToolStripButton});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(847, 28);
            this.MainToolStrip.TabIndex = 3;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // ConnectToTwitterToolStripButton
            // 
            this.ConnectToTwitterToolStripButton.Image = global::TweetAnalyzer.Win.Properties.Resources.if_2018_social_media_popular_app_logo_twitter_3225183;
            this.ConnectToTwitterToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConnectToTwitterToolStripButton.Name = "ConnectToTwitterToolStripButton";
            this.ConnectToTwitterToolStripButton.Size = new System.Drawing.Size(93, 25);
            this.ConnectToTwitterToolStripButton.Text = "Connect";
            this.ConnectToTwitterToolStripButton.Click += new System.EventHandler(this.ConnectToTwitterToolStripButton_Click);
            // 
            // ConnectToDatabaseToolStripButton
            // 
            this.ConnectToDatabaseToolStripButton.Image = global::TweetAnalyzer.Win.Properties.Resources.if_database_299089;
            this.ConnectToDatabaseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConnectToDatabaseToolStripButton.Name = "ConnectToDatabaseToolStripButton";
            this.ConnectToDatabaseToolStripButton.Size = new System.Drawing.Size(93, 25);
            this.ConnectToDatabaseToolStripButton.Text = "Connect";
            this.ConnectToDatabaseToolStripButton.Click += new System.EventHandler(this.ConnectToDatabaseToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // UserListToolStripButton
            // 
            this.UserListToolStripButton.Image = global::TweetAnalyzer.Win.Properties.Resources.if_user_alt_285645;
            this.UserListToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UserListToolStripButton.Name = "UserListToolStripButton";
            this.UserListToolStripButton.Size = new System.Drawing.Size(71, 25);
            this.UserListToolStripButton.Text = "Users";
            this.UserListToolStripButton.Click += new System.EventHandler(this.AddUserToolStripButton_Click);
            // 
            // TweetListToolStripButton
            // 
            this.TweetListToolStripButton.Image = global::TweetAnalyzer.Win.Properties.Resources.if_2018_social_media_popular_app_logo_twitter_32251831;
            this.TweetListToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TweetListToolStripButton.Name = "TweetListToolStripButton";
            this.TweetListToolStripButton.Size = new System.Drawing.Size(82, 25);
            this.TweetListToolStripButton.Text = "Tweets";
            this.TweetListToolStripButton.Click += new System.EventHandler(this.TweetListToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // DownloadUserTweetToolStripButton
            // 
            this.DownloadUserTweetToolStripButton.Image = global::TweetAnalyzer.Win.Properties.Resources.if_box_in_299102;
            this.DownloadUserTweetToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DownloadUserTweetToolStripButton.Name = "DownloadUserTweetToolStripButton";
            this.DownloadUserTweetToolStripButton.Size = new System.Drawing.Size(203, 25);
            this.DownloadUserTweetToolStripButton.Text = "Download User Tweets";
            this.DownloadUserTweetToolStripButton.Click += new System.EventHandler(this.UserTweetToolStripButton_Click);
            // 
            // BatchDownloadNewTweetsToolStripButton
            // 
            this.BatchDownloadNewTweetsToolStripButton.Image = global::TweetAnalyzer.Win.Properties.Resources.if_box_in_2991021;
            this.BatchDownloadNewTweetsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BatchDownloadNewTweetsToolStripButton.Name = "BatchDownloadNewTweetsToolStripButton";
            this.BatchDownloadNewTweetsToolStripButton.Size = new System.Drawing.Size(229, 25);
            this.BatchDownloadNewTweetsToolStripButton.Text = "Download All New Tweets";
            this.BatchDownloadNewTweetsToolStripButton.Click += new System.EventHandler(this.DownloadNewTweetsToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // StandardToolStrip
            // 
            this.StandardToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripButton,
            this.DeleteToolStripButton,
            this.EditToolStripButton,
            this.ViewToolStripButton,
            this.RefreshToolStripButton});
            this.StandardToolStrip.Location = new System.Drawing.Point(0, 28);
            this.StandardToolStrip.Name = "StandardToolStrip";
            this.StandardToolStrip.Size = new System.Drawing.Size(847, 25);
            this.StandardToolStrip.TabIndex = 5;
            this.StandardToolStrip.Text = "toolStrip1";
            // 
            // AddToolStripButton
            // 
            this.AddToolStripButton.Image = global::TweetAnalyzer.Win.Properties.Resources.if_sign_add_299068;
            this.AddToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddToolStripButton.Name = "AddToolStripButton";
            this.AddToolStripButton.Size = new System.Drawing.Size(49, 22);
            this.AddToolStripButton.Text = "Add";
            this.AddToolStripButton.Click += new System.EventHandler(this.AddToolStripButton_Click);
            // 
            // DeleteToolStripButton
            // 
            this.DeleteToolStripButton.Image = global::TweetAnalyzer.Win.Properties.Resources.if_sign_error_299045;
            this.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteToolStripButton.Name = "DeleteToolStripButton";
            this.DeleteToolStripButton.Size = new System.Drawing.Size(60, 22);
            this.DeleteToolStripButton.Text = "Delete";
            this.DeleteToolStripButton.Click += new System.EventHandler(this.DeleteToolStripButton_Click);
            // 
            // EditToolStripButton
            // 
            this.EditToolStripButton.Image = global::TweetAnalyzer.Win.Properties.Resources.if_notepad_285631;
            this.EditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditToolStripButton.Name = "EditToolStripButton";
            this.EditToolStripButton.Size = new System.Drawing.Size(47, 22);
            this.EditToolStripButton.Text = "Edit";
            this.EditToolStripButton.Click += new System.EventHandler(this.EditToolStripButton_Click);
            // 
            // ViewToolStripButton
            // 
            this.ViewToolStripButton.Image = global::TweetAnalyzer.Win.Properties.Resources.if_search_285651;
            this.ViewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ViewToolStripButton.Name = "ViewToolStripButton";
            this.ViewToolStripButton.Size = new System.Drawing.Size(52, 22);
            this.ViewToolStripButton.Text = "View";
            this.ViewToolStripButton.Click += new System.EventHandler(this.ViewToolStripButton_Click);
            // 
            // RefreshToolStripButton
            // 
            this.RefreshToolStripButton.Image = global::TweetAnalyzer.Win.Properties.Resources.if_cloud_sync_299097;
            this.RefreshToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshToolStripButton.Name = "RefreshToolStripButton";
            this.RefreshToolStripButton.Size = new System.Drawing.Size(66, 22);
            this.RefreshToolStripButton.Text = "Refresh";
            this.RefreshToolStripButton.Click += new System.EventHandler(this.RefreshToolStripButton_Click);
            // 
            // AnalyseToolStrip
            // 
            this.AnalyseToolStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AnalyseToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RunAnalyseToolStripButton,
            this.RunAllAnalysisToolStripButton,
            this.toolStripSeparator4,
            this.AnalyseResultsToolStripButton,
            this.toolStripSeparator5,
            this.AnalyseConfigToolStripButton});
            this.AnalyseToolStrip.Location = new System.Drawing.Point(0, 53);
            this.AnalyseToolStrip.Name = "AnalyseToolStrip";
            this.AnalyseToolStrip.Size = new System.Drawing.Size(847, 28);
            this.AnalyseToolStrip.TabIndex = 8;
            this.AnalyseToolStrip.Text = "toolStrip1";
            // 
            // RunAnalyseToolStripButton
            // 
            this.RunAnalyseToolStripButton.Image = global::TweetAnalyzer.Win.Properties.Resources.if_flask_299052;
            this.RunAnalyseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RunAnalyseToolStripButton.Name = "RunAnalyseToolStripButton";
            this.RunAnalyseToolStripButton.Size = new System.Drawing.Size(124, 25);
            this.RunAnalyseToolStripButton.Text = "Run Analyse";
            // 
            // RunAllAnalysisToolStripButton
            // 
            this.RunAllAnalysisToolStripButton.Image = global::TweetAnalyzer.Win.Properties.Resources.if_flask_299052;
            this.RunAllAnalysisToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RunAllAnalysisToolStripButton.Name = "RunAllAnalysisToolStripButton";
            this.RunAllAnalysisToolStripButton.Size = new System.Drawing.Size(152, 25);
            this.RunAllAnalysisToolStripButton.Text = "Run All Analysis";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // AnalyseResultsToolStripButton
            // 
            this.AnalyseResultsToolStripButton.Image = global::TweetAnalyzer.Win.Properties.Resources.if_search_285651;
            this.AnalyseResultsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AnalyseResultsToolStripButton.Name = "AnalyseResultsToolStripButton";
            this.AnalyseResultsToolStripButton.Size = new System.Drawing.Size(148, 25);
            this.AnalyseResultsToolStripButton.Text = "Analyse Results";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 28);
            // 
            // AnalyseConfigToolStripButton
            // 
            this.AnalyseConfigToolStripButton.Image = global::TweetAnalyzer.Win.Properties.Resources.if_wrench_screwdriver_299100;
            this.AnalyseConfigToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AnalyseConfigToolStripButton.Name = "AnalyseConfigToolStripButton";
            this.AnalyseConfigToolStripButton.Size = new System.Drawing.Size(145, 25);
            this.AnalyseConfigToolStripButton.Text = "Analyse Config";
            // 
            // TrendsToolStripButton
            // 
            this.TrendsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("TrendsToolStripButton.Image")));
            this.TrendsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TrendsToolStripButton.Name = "TrendsToolStripButton";
            this.TrendsToolStripButton.Size = new System.Drawing.Size(80, 25);
            this.TrendsToolStripButton.Text = "Trends";
            this.TrendsToolStripButton.Click += new System.EventHandler(this.TrendsToolStripButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.AnalyseToolStrip);
            this.Controls.Add(this.StandardToolStrip);
            this.Controls.Add(this.MainToolStrip);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.MainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tweet Analyzer 20180726";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MdiChildActivate += new System.EventHandler(this.MainForm_MdiChildActivate);
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.StandardToolStrip.ResumeLayout(false);
            this.StandardToolStrip.PerformLayout();
            this.AnalyseToolStrip.ResumeLayout(false);
            this.AnalyseToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripStatusLabel TwitterUserToolStripStatusLabel;
        private System.Windows.Forms.ToolStripButton ConnectToTwitterToolStripButton;
        private System.Windows.Forms.ToolStripButton UserListToolStripButton;
        private System.Windows.Forms.ToolStripStatusLabel DatabaseFileLocationToolStripStatusLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip StandardToolStrip;
        private System.Windows.Forms.ToolStripButton AddToolStripButton;
        private System.Windows.Forms.ToolStripButton DeleteToolStripButton;
        private System.Windows.Forms.ToolStripButton EditToolStripButton;
        private System.Windows.Forms.ToolStripButton ViewToolStripButton;
        private System.Windows.Forms.ToolStripButton RefreshToolStripButton;
        private System.Windows.Forms.ToolStripButton DownloadUserTweetToolStripButton;
        private System.Windows.Forms.ToolStripButton BatchDownloadNewTweetsToolStripButton;
        private System.Windows.Forms.ToolStripButton TweetListToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStrip AnalyseToolStrip;
        private System.Windows.Forms.ToolStripButton RunAnalyseToolStripButton;
        private System.Windows.Forms.ToolStripButton RunAllAnalysisToolStripButton;
        private System.Windows.Forms.ToolStripButton AnalyseResultsToolStripButton;
        private System.Windows.Forms.ToolStripButton AnalyseConfigToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton ConnectToDatabaseToolStripButton;
        private System.Windows.Forms.ToolStripButton TrendsToolStripButton;
    }
}

