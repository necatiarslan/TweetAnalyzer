namespace TweetAnalyzer.Win
{
    partial class DownloadUserTweetListForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveTweetsButton = new System.Windows.Forms.Button();
            this.DownloadTweetsButton = new System.Windows.Forms.Button();
            this.SelectUserButton = new System.Windows.Forms.Button();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MainDataGridView = new System.Windows.Forms.DataGridView();
            this.ShowOnlyNewTweetsCheckBox = new System.Windows.Forms.CheckBox();
            this.TweetCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TweetCountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TweetCountNumericUpDown);
            this.panel1.Controls.Add(this.ShowOnlyNewTweetsCheckBox);
            this.panel1.Controls.Add(this.SaveTweetsButton);
            this.panel1.Controls.Add(this.DownloadTweetsButton);
            this.panel1.Controls.Add(this.SelectUserButton);
            this.panel1.Controls.Add(this.UserNameTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 40);
            this.panel1.TabIndex = 0;
            // 
            // SaveTweetsButton
            // 
            this.SaveTweetsButton.Location = new System.Drawing.Point(770, 8);
            this.SaveTweetsButton.Name = "SaveTweetsButton";
            this.SaveTweetsButton.Size = new System.Drawing.Size(130, 23);
            this.SaveTweetsButton.TabIndex = 4;
            this.SaveTweetsButton.Text = "Save Tweets";
            this.SaveTweetsButton.UseVisualStyleBackColor = true;
            this.SaveTweetsButton.Click += new System.EventHandler(this.SaveTweetsButton_Click);
            // 
            // DownloadTweetsButton
            // 
            this.DownloadTweetsButton.Location = new System.Drawing.Point(632, 8);
            this.DownloadTweetsButton.Name = "DownloadTweetsButton";
            this.DownloadTweetsButton.Size = new System.Drawing.Size(132, 23);
            this.DownloadTweetsButton.TabIndex = 3;
            this.DownloadTweetsButton.Text = "Download Tweets";
            this.DownloadTweetsButton.UseVisualStyleBackColor = true;
            this.DownloadTweetsButton.Click += new System.EventHandler(this.LoadTweetsButton_Click);
            // 
            // SelectUserButton
            // 
            this.SelectUserButton.Location = new System.Drawing.Point(371, 8);
            this.SelectUserButton.Name = "SelectUserButton";
            this.SelectUserButton.Size = new System.Drawing.Size(75, 23);
            this.SelectUserButton.TabIndex = 2;
            this.SelectUserButton.Text = "Select";
            this.SelectUserButton.UseVisualStyleBackColor = true;
            this.SelectUserButton.Click += new System.EventHandler(this.SelectUserButton_Click);
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserNameTextBox.Location = new System.Drawing.Point(69, 6);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.ReadOnly = true;
            this.UserNameTextBox.Size = new System.Drawing.Size(296, 26);
            this.UserNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User :";
            // 
            // MainDataGridView
            // 
            this.MainDataGridView.AllowUserToAddRows = false;
            this.MainDataGridView.AllowUserToDeleteRows = false;
            this.MainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainDataGridView.Location = new System.Drawing.Point(0, 40);
            this.MainDataGridView.Name = "MainDataGridView";
            this.MainDataGridView.ReadOnly = true;
            this.MainDataGridView.Size = new System.Drawing.Size(918, 410);
            this.MainDataGridView.TabIndex = 1;
            // 
            // ShowOnlyNewTweetsCheckBox
            // 
            this.ShowOnlyNewTweetsCheckBox.AutoSize = true;
            this.ShowOnlyNewTweetsCheckBox.Checked = true;
            this.ShowOnlyNewTweetsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowOnlyNewTweetsCheckBox.Location = new System.Drawing.Point(452, 11);
            this.ShowOnlyNewTweetsCheckBox.Name = "ShowOnlyNewTweetsCheckBox";
            this.ShowOnlyNewTweetsCheckBox.Size = new System.Drawing.Size(72, 17);
            this.ShowOnlyNewTweetsCheckBox.TabIndex = 5;
            this.ShowOnlyNewTweetsCheckBox.Text = "Only New";
            this.ShowOnlyNewTweetsCheckBox.UseVisualStyleBackColor = true;
            // 
            // TweetCountNumericUpDown
            // 
            this.TweetCountNumericUpDown.Location = new System.Drawing.Point(531, 9);
            this.TweetCountNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TweetCountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TweetCountNumericUpDown.Name = "TweetCountNumericUpDown";
            this.TweetCountNumericUpDown.Size = new System.Drawing.Size(42, 20);
            this.TweetCountNumericUpDown.TabIndex = 6;
            this.TweetCountNumericUpDown.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tweets";
            // 
            // DownloadUserTweetListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 450);
            this.Controls.Add(this.MainDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "DownloadUserTweetListForm";
            this.Text = "User Tweets";
            this.Load += new System.EventHandler(this.UserTweetListForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TweetCountNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView MainDataGridView;
        private System.Windows.Forms.Button SelectUserButton;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DownloadTweetsButton;
        private System.Windows.Forms.Button SaveTweetsButton;
        private System.Windows.Forms.CheckBox ShowOnlyNewTweetsCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown TweetCountNumericUpDown;
    }
}