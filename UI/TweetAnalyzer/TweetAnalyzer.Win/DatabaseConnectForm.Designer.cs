namespace TweetAnalyzer.Win
{
    partial class DatabaseConnectForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.DatabaseFileLocationTextBox = new System.Windows.Forms.TextBox();
            this.OkeyButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.TestButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File :";
            // 
            // DatabaseFileLocationTextBox
            // 
            this.DatabaseFileLocationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatabaseFileLocationTextBox.Location = new System.Drawing.Point(15, 25);
            this.DatabaseFileLocationTextBox.Multiline = true;
            this.DatabaseFileLocationTextBox.Name = "DatabaseFileLocationTextBox";
            this.DatabaseFileLocationTextBox.ReadOnly = true;
            this.DatabaseFileLocationTextBox.Size = new System.Drawing.Size(337, 57);
            this.DatabaseFileLocationTextBox.TabIndex = 1;
            // 
            // OkeyButton
            // 
            this.OkeyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkeyButton.Location = new System.Drawing.Point(275, 128);
            this.OkeyButton.Name = "OkeyButton";
            this.OkeyButton.Size = new System.Drawing.Size(75, 23);
            this.OkeyButton.TabIndex = 2;
            this.OkeyButton.Text = "Ok";
            this.OkeyButton.UseVisualStyleBackColor = true;
            this.OkeyButton.Click += new System.EventHandler(this.OkeyButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(194, 128);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(96, 88);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(75, 23);
            this.TestButton.TabIndex = 4;
            this.TestButton.Text = "Test";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(15, 88);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(75, 23);
            this.SelectButton.TabIndex = 5;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.Selectbutton_Click);
            // 
            // SelectDatabaseFileLocation
            // 
            this.AcceptButton = this.OkeyButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 163);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkeyButton);
            this.Controls.Add(this.DatabaseFileLocationTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SelectDatabaseFileLocation";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Database File";
            this.Load += new System.EventHandler(this.SelectDatabaseFileLocation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DatabaseFileLocationTextBox;
        private System.Windows.Forms.Button OkeyButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Button SelectButton;
    }
}