using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TweetAnalyzer.Database;
using TweetAnalyzer.TwitterEngine;

namespace TweetAnalyzer.Win
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DisableStandardToolbar();

            try
            {
                Dac dac = new Dac();
                dac.LoadDatabaseFileLocationFromReqistry();
                DatabaseFileLocationToolStripStatusLabel.Text = "Database : " + Dac.Current.DatabaseFileLocation;
            }
            catch
            {
                DatabaseFileLocationToolStripStatusLabel.Text = "Database Connection Error !!!";
            }

            try
            {
                TwitterConnection twitterConnection = new TwitterConnection();
                twitterConnection.LoadCredentialsFromReqistry();
                twitterConnection.Connect();
                TwitterUserToolStripStatusLabel.Text = "Twitter User : " + TwitterConnection.Current.User.Name;
            }
            catch
            {
                TwitterUserToolStripStatusLabel.Text = "Twitter Connection Error !!!";
            }

        }

        private void ConnectToTwitterToolStripButton_Click(object sender, EventArgs e)
        {
            TwitterConnectForm connectForm = new TwitterConnectForm();
            if (connectForm.ShowDialog() == DialogResult.OK)
            {
                TwitterUserToolStripStatusLabel.Text = TwitterConnection.Current.User.Name;
            }
        }

        private void AddUserToolStripButton_Click(object sender, EventArgs e)
        {
            UserListForm userListForm = new UserListForm();
            userListForm.MdiParent = this;
            userListForm.Show();
        }

        private void TwitterUserToolStripStatusLabel_Click(object sender, EventArgs e)
        {
            if (TwitterConnection.Current == null || TwitterConnection.Current.User == null)
            {
                ConnectToTwitterToolStripButton_Click(this, EventArgs.Empty);
            }
            else
            {
                UserForm userForm = new UserForm(TwitterConnection.Current.User);
                userForm.Show();
            }
        }

        private void ConnectToDatabaseToolStripStatusLabel_Click(object sender, EventArgs e)
        {
            ConnectToDatabaseToolStripButton_Click(this, EventArgs.Empty);
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            DisableStandardToolbar();

            if (this.ActiveMdiChild == null)
                return;

            if ((this.ActiveMdiChild is IStandardToolbar))
            {
                IStandardToolbar form = (IStandardToolbar)this.ActiveMdiChild;

                AddToolStripButton.Enabled = form.CanAddItem;
                DeleteToolStripButton.Enabled = form.CanDeleteItem;
                EditToolStripButton.Enabled = form.CanEditItem;
                ViewToolStripButton.Enabled = form.CanViewItem;
                RefreshToolStripButton.Enabled = form.CanRefreshList;
            }


        }

        private void DisableStandardToolbar()
        {
            AddToolStripButton.Enabled = false;
            DeleteToolStripButton.Enabled = false;
            EditToolStripButton.Enabled = false;
            ViewToolStripButton.Enabled = false;
            RefreshToolStripButton.Enabled = false;
        }

        private void AddToolStripButton_Click(object sender, EventArgs e)
        {
            IStandardToolbar form = (IStandardToolbar)this.ActiveMdiChild;
            form.AddItem();
        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            IStandardToolbar form = (IStandardToolbar)this.ActiveMdiChild;
            form.DeleteItem();
        }

        private void EditToolStripButton_Click(object sender, EventArgs e)
        {
            IStandardToolbar form = (IStandardToolbar)this.ActiveMdiChild;
            form.EditItem();
        }

        private void ViewToolStripButton_Click(object sender, EventArgs e)
        {
            IStandardToolbar form = (IStandardToolbar)this.ActiveMdiChild;
            form.ViewItem();
        }

        private void RefreshToolStripButton_Click(object sender, EventArgs e)
        {
            IStandardToolbar form = (IStandardToolbar)this.ActiveMdiChild;
            form.RefreshList();
        }

        private void UserTweetToolStripButton_Click(object sender, EventArgs e)
        {
            DownloadUserTweetListForm downloadUserTweetListForm = new DownloadUserTweetListForm();
            downloadUserTweetListForm.MdiParent = this;
            downloadUserTweetListForm.Show();
        }

        private void DownloadNewTweetsToolStripButton_Click(object sender, EventArgs e)
        {
            BatchDownloadUserNewTweetsForm downloadUserNewTweetsForm = new BatchDownloadUserNewTweetsForm();
            downloadUserNewTweetsForm.Show();
        }

        private void TweetListToolStripButton_Click(object sender, EventArgs e)
        {
            UserTweetListForm userTweetListForm = new UserTweetListForm();
            userTweetListForm.MdiParent = this;
            userTweetListForm.Show();
        }

        private void ConnectToDatabaseToolStripButton_Click(object sender, EventArgs e)
        {
            DatabaseConnectForm selectDatabaseFileLocation = new DatabaseConnectForm();
            if (selectDatabaseFileLocation.ShowDialog() == DialogResult.OK)
            {
                DatabaseFileLocationToolStripStatusLabel.Text = Dac.Current.DatabaseFileLocation;
            }
        }

        private void TrendsToolStripButton_Click(object sender, EventArgs e)
        {
            TrendListForm trendListForm = new TrendListForm();
            trendListForm.MdiParent = this;
            trendListForm.Dock = DockStyle.Fill;
            trendListForm.Show();
        }
    }
}
