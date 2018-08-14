using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tweetinvi.Models;
using TweetAnalyzer.Database;

namespace TweetAnalyzer.Win
{
    public partial class DownloadUserTweetListForm : Form
    {
        public DownloadUserTweetListForm()
        {
            InitializeComponent();
        }

        public DownloadUserTweetListForm(decimal userId)
        {
            InitializeComponent();
            SetUser(userId);
        }

        List<ITweet> tweets;

        private void SelectUserButton_Click(object sender, EventArgs e)
        {
            UserListForm userListForm = new UserListForm(ShowMode.Select);
            if(userListForm.ShowDialog() == DialogResult.OK)
            {
                SetUser(userListForm.SelectedUserId);
            }
        }

        private void SetUser(decimal userId)
        {
            if (userId == 0)
                return;

            Dac dac = new Dac();
            Dictionary<string, object> values = dac.Select("User", "Id", userId).Result;
            UserNameTextBox.Text = (string)values["UserName"];
        }

        private void UserTweetListForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadTweetsButton_Click(object sender, EventArgs e)
        {
            IUser user = TweetAnalyzer.TwitterEngine.User.FindUserFromUserName(UserNameTextBox.Text).Result;

            tweets = user.GetUserTimeline((int)TweetCountNumericUpDown.Value).ToList<ITweet>();
            
            if(ShowOnlyNewTweetsCheckBox.Checked)
            {
                List<ITweet> tempTweets = tweets;
                tweets = new List<ITweet>();
                foreach (ITweet tweet in tempTweets)
                {
                    if(!DbHelper.IsTweetSaved(tweet).Result)
                    {
                        tweets.Add(tweet);
                    }
                }
            }

            MainDataGridView.DataSource = tweets;
            UIHelper.SetGridColumns(MainDataGridView, "Text", "RetweetCount", "FavoriteCount", "IsRetweet", "CreatedAt" );


        }

        private void SaveTweetsButton_Click(object sender, EventArgs e)
        {
            if (tweets == null)
                return;

            if (tweets.Count == 0)
                return;

            MethodResult<int> result = DbHelper.SaveTweetList(tweets);
            if (result.IsSuccessful)
            {
                MessageBox.Show(result.Result.ToString() + " Tweets Saved :-)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Save Error :-(" + Environment.NewLine + result.Exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
