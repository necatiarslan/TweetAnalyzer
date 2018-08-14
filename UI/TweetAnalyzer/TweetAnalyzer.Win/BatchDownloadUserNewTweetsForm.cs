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
    public partial class BatchDownloadUserNewTweetsForm : Form
    {
        public BatchDownloadUserNewTweetsForm()
        {
            InitializeComponent();
        }

        private void DownloadUserNewTweetsForm_Load(object sender, EventArgs e)
        {

        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            Dac dac = new Dac();
            DataTable userDataTable = dac.ExecuteDataTable("SELECT * FROM User").Result;
            decimal progress = 0;

            foreach(DataRow dr in userDataTable.Rows)
            {
                IUser user = TwitterEngine.User.FindUserFromUserName((string)dr["UserName"]).Result;
                if (user == null)
                    continue;

                progress++;
                ProgressbarDescriptionLabel.Text = user.Name;
                ProgressBar.Value = (int)((progress / userDataTable.Rows.Count) * 100);

                MethodResult<int> result = DbHelper.SaveTweetList(user.GetUserTimeline((int)TweetCountNumericUpDown.Value).ToList<ITweet>());
                if (result.IsSuccessful)
                {
                    //ProgressbarDescriptionLabel.Text = user.Name + " : " + result.Result.ToString() + " Tweets Saved :-)";
                    ResultsTextBox.Text += Environment.NewLine + user.Name + " : " + result.Result.ToString() + " Tweets Saved :-)";
                    //MessageBox.Show(user.Name + " : " + result.Result.ToString() + " Tweets Saved :-)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ProgressbarDescriptionLabel.Text = user.Name + " : " + "Save Error :-(";
                    ResultsTextBox.Text += Environment.NewLine + user.Name + " : " + "Save Error :-(";
                    ProgressBar.Value = 0;
                    MessageBox.Show(user.Name + " : " + "Save Error :-(" + Environment.NewLine + result.Exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    return;
                }
            }

            ProgressbarDescriptionLabel.Text = "Finished";
            ResultsTextBox.Text += Environment.NewLine + "Finished"; 
            ProgressBar.Value = 100;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
