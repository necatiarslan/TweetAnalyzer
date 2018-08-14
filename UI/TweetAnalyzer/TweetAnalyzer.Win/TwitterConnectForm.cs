using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TweetAnalyzer.TwitterEngine;

namespace TweetAnalyzer.Win
{
    public partial class TwitterConnectForm : Form
    {
        public TwitterConnectForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            TwitterConnection twitterConnection = new TwitterConnection();
            twitterConnection.ConsumerKey = consumerKeyTextBox.Text;
            twitterConnection.ConsumerSecret = consumerSecretTextBox.Text;
            twitterConnection.UserAccessToken = userAccessTokenTextBox.Text;
            twitterConnection.UserAccessSecret = userAccessSecretTextBox.Text;

            try
            {
                twitterConnection.Connect();

                if (RememberCheckBox.Checked)
                    twitterConnection.SaveCredentialsToReqistry();
                else
                    twitterConnection.ResetCredentialsToReqistry();

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong Credentials Or Connection Error :-(" + Environment.NewLine + ex.ToString());
            }
        }

        private void ConnectForm_Load(object sender, EventArgs e)
        {
            try
            {
                TwitterConnection twitterConnection = new TwitterConnection();
                twitterConnection.LoadCredentialsFromReqistry();

                consumerKeyTextBox.Text = twitterConnection.ConsumerKey;
                consumerSecretTextBox.Text = twitterConnection.ConsumerSecret;
                userAccessTokenTextBox.Text = twitterConnection.UserAccessToken;
                userAccessSecretTextBox.Text = twitterConnection.UserAccessSecret;
            }
            catch (Exception ex)
            {

            }
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            TwitterConnection twitterConnection = new TwitterConnection();
            twitterConnection.ConsumerKey = consumerKeyTextBox.Text;
            twitterConnection.ConsumerSecret = consumerSecretTextBox.Text;
            twitterConnection.UserAccessToken = userAccessTokenTextBox.Text;
            twitterConnection.UserAccessSecret = userAccessSecretTextBox.Text;

            try
            {
                twitterConnection.Connect();
                MessageBox.Show("Connection Ok :-)" + Environment.NewLine + "User : " + twitterConnection.User.Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error :-(" + Environment.NewLine + ex.ToString());
            }

        }
    }
}
