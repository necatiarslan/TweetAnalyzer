namespace TweetAnalyzer.Win
{
    partial class TwitterConnectForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userAccessSecretTextBox = new System.Windows.Forms.TextBox();
            this.userAccessTokenTextBox = new System.Windows.Forms.TextBox();
            this.consumerSecretTextBox = new System.Windows.Forms.TextBox();
            this.consumerKeyTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.RememberCheckBox = new System.Windows.Forms.CheckBox();
            this.TestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consumer Key :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Consumer Secret :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Access Token :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "User Access Secret :";
            // 
            // userAccessSecretTextBox
            // 
            this.userAccessSecretTextBox.Location = new System.Drawing.Point(122, 91);
            this.userAccessSecretTextBox.Name = "userAccessSecretTextBox";
            this.userAccessSecretTextBox.Size = new System.Drawing.Size(369, 20);
            this.userAccessSecretTextBox.TabIndex = 4;
            // 
            // userAccessTokenTextBox
            // 
            this.userAccessTokenTextBox.Location = new System.Drawing.Point(122, 64);
            this.userAccessTokenTextBox.Name = "userAccessTokenTextBox";
            this.userAccessTokenTextBox.Size = new System.Drawing.Size(369, 20);
            this.userAccessTokenTextBox.TabIndex = 5;
            // 
            // consumerSecretTextBox
            // 
            this.consumerSecretTextBox.Location = new System.Drawing.Point(122, 38);
            this.consumerSecretTextBox.Name = "consumerSecretTextBox";
            this.consumerSecretTextBox.Size = new System.Drawing.Size(369, 20);
            this.consumerSecretTextBox.TabIndex = 6;
            // 
            // consumerKeyTextBox
            // 
            this.consumerKeyTextBox.Location = new System.Drawing.Point(122, 12);
            this.consumerKeyTextBox.Name = "consumerKeyTextBox";
            this.consumerKeyTextBox.Size = new System.Drawing.Size(369, 20);
            this.consumerKeyTextBox.TabIndex = 7;
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(418, 124);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 8;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(337, 124);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // RememberCheckBox
            // 
            this.RememberCheckBox.AutoSize = true;
            this.RememberCheckBox.Checked = true;
            this.RememberCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RememberCheckBox.Location = new System.Drawing.Point(203, 128);
            this.RememberCheckBox.Name = "RememberCheckBox";
            this.RememberCheckBox.Size = new System.Drawing.Size(77, 17);
            this.RememberCheckBox.TabIndex = 10;
            this.RememberCheckBox.Text = "Remember";
            this.RememberCheckBox.UseVisualStyleBackColor = true;
            // 
            // TestButton
            // 
            this.TestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TestButton.Location = new System.Drawing.Point(122, 124);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(75, 23);
            this.TestButton.TabIndex = 11;
            this.TestButton.Text = "Test";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // ConnectForm
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 159);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.RememberCheckBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.consumerKeyTextBox);
            this.Controls.Add(this.consumerSecretTextBox);
            this.Controls.Add(this.userAccessTokenTextBox);
            this.Controls.Add(this.userAccessSecretTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConnectForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect To Twitter";
            this.Load += new System.EventHandler(this.ConnectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userAccessSecretTextBox;
        private System.Windows.Forms.TextBox userAccessTokenTextBox;
        private System.Windows.Forms.TextBox consumerSecretTextBox;
        private System.Windows.Forms.TextBox consumerKeyTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.CheckBox RememberCheckBox;
        private System.Windows.Forms.Button TestButton;
    }
}