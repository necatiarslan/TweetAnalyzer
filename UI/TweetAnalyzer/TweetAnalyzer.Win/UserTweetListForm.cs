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

namespace TweetAnalyzer.Win
{
    public partial class UserTweetListForm : Form, IStandardToolbar
    {
        public UserTweetListForm()
        {
            InitializeComponent();
        }

        private decimal userId;

        public bool CanAddItem => true;

        public bool CanDeleteItem => true;

        public bool CanEditItem => true;

        public bool CanViewItem => true;

        public bool CanRefreshList => true;

        private void UserTweetListForm_Load(object sender, EventArgs e)
        {

        }

        private void SelectUserButton_Click(object sender, EventArgs e)
        {
            UserListForm userListForm = new UserListForm(ShowMode.Select);
            if (userListForm.ShowDialog() == DialogResult.OK)
            {
                Dac dac = new Dac();
                Dictionary<string, object> values = dac.Select("User", "Id", userListForm.SelectedUserId).Result;
                UserNameTextBox.Text = (string)values["UserName"];
                this.userId = userListForm.SelectedUserId;
            }
        }

        private void ListButton_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        public void AddItem()
        {
            DownloadUserTweetListForm downloadUserTweetListForm = new DownloadUserTweetListForm(this.userId);
            downloadUserTweetListForm.ShowDialog();
        }

        public void DeleteItem()
        {
            
        }

        public void EditItem()
        {
            
        }

        public void ViewItem()
        {
            
        }

        public void RefreshList()
        {
            if (this.userId == 0)
                return;

            Dac dac = new Dac();

            MethodResult<DataTable> result = dac.ExecuteDataTable(" SELECT CreatedAt, Text, RetweetCount, FavoriteCount, IsRetweet FROM Tweet WHERE CreatedByUserId=" + this.userId.ToString());

            if (result.IsSuccessful)
            {
                MainDataGridView.DataSource = result.Result;
            }
            else
            {
                MessageBox.Show("List Error :-(" + Environment.NewLine + result.Exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteAllTweetsButton_Click(object sender, EventArgs e)
        {
            if (this.userId == 0)
                return;

            if(MessageBox.Show("User all tweets will be deleted." + Environment.NewLine + "Are You Sure ?", "Sure", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Dac dac = new Dac();
                dac.ExecuteNonQuery("DELETE FROM Tweet WHERE CreatedByUserId=" + this.userId.ToString());
                RefreshList();
            }
            
        }
    }
}
