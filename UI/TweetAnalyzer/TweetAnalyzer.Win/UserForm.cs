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
using TweetAnalyzer.TwitterEngine;

namespace TweetAnalyzer.Win
{
    public partial class UserForm : Form
    {
        public UserForm(ShowMode showMode = ShowMode.Add)
        {
            InitializeComponent();
            this.showMode = showMode;
        }

        ShowMode showMode;

        public UserForm(decimal UserId, ShowMode showMode = ShowMode.Edit)
        {
            InitializeComponent();
            SetUIFromUserId(UserId);
            this.showMode = showMode;
        }

        public UserForm(IUser user, ShowMode showMode = ShowMode.Add)
        {
            InitializeComponent();
            SetUIFromUser(user);
            this.showMode = showMode;
        }

        private void GetUserButton_Click(object sender, EventArgs e)
        {
            TwitterEngine.MethodResult<IUser> result = TwitterEngine.User.FindUserFromUserName(UserNameTextBox.Text);
            if(result.IsSuccessful)
            {
                IUser user = result.Result;
                SetUIFromUser(user);
            }
            else
            {
                MessageBox.Show("User Not Found :-(");
            }

        }

        private void SetUIFromUser(IUser user)
        {
            if (user == null)
                return;

            UserIdTextBox.Text = user.Id.ToString();
            NameTextBox.Text = user.Name;
            DescriptionTextBox.Text = user.Description;
            FollowingCountTextBox.Text = user.FriendsCount.ToString();
            FollowersCountTextBox.Text = user.FollowersCount.ToString();
            LanguageTextBox.Text = user.Language.ToString();
            LocationTextBox.Text = user.Location;
            WebSiteTextBox.Text = user.Url;
            ProtectedCheckBox.Checked = user.Protected;
            ProfileImagePictureBox.ImageLocation = user.ProfileImageUrl400x400;
        }

        private void SetUIFromUserId(decimal userId)
        {
            if (userId == 0)
                return;

            Dac dac = new Dac();

            IDictionary<string, object> values = dac.Select("User", "Id", userId).Result;

            UserNameTextBox.Text = values["UserName"].ToString();
            UserIdTextBox.Text = values["Id"].ToString();
            NameTextBox.Text = values["Name"].ToString();
            DescriptionTextBox.Text = values["Description"].ToString();
            FollowingCountTextBox.Text = values["FriendsCount"].ToString();
            FollowersCountTextBox.Text = values["FollowersCount"].ToString();
            LanguageTextBox.Text = values["Language"].ToString();
            LocationTextBox.Text = values["Location"].ToString();
            WebSiteTextBox.Text = values["Url"].ToString();
            ProtectedCheckBox.Checked = values["Protected"].ToString() == "1";
            ProfileImagePictureBox.ImageLocation = values["ProfileImageUrl400x400"].ToString();

        }

        private void OkeyButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> columns = new Dictionary<string, object>();

            columns["UserName"] = UserNameTextBox.Text;
            columns["Name"] = NameTextBox.Text;
            columns["Description"] = DescriptionTextBox.Text;
            columns["FriendsCount"] = Convert.ToInt32(FollowingCountTextBox.Text);
            columns["FollowersCount"] = Convert.ToInt32(FollowersCountTextBox.Text);
            columns["Language"] = LanguageTextBox.Text;
            columns["Location"] = LocationTextBox.Text;
            columns["Url"] = WebSiteTextBox.Text;
            columns["Protected"] = ProtectedCheckBox.Checked;
            columns["ProfileImageUrl400x400"] = ProfileImagePictureBox.ImageLocation;

            Dac dac = new Dac();
            MethodResult result = new MethodResult();

            if(this.showMode == ShowMode.Edit)
            {
                result = dac.Update("User", "Id", Convert.ToInt64(UserIdTextBox.Text), columns);
            }
            else if (this.showMode == ShowMode.Add)
            {
                columns["Id"] = Convert.ToInt64(UserIdTextBox.Text);
                result = dac.Insert("User", columns);
            }
            else if (this.showMode == ShowMode.Delete)
            {
                columns["Id"] = Convert.ToInt64(UserIdTextBox.Text);
                result = dac.Delete("User", "Id", Convert.ToInt64(UserIdTextBox.Text));
            }

            if (result.IsSuccessful)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Save Error :-(" + Environment.NewLine + result.Exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            if(this.showMode == ShowMode.View)
            {
                this.OkeyButton.Enabled = false;
            }

            if (this.showMode == ShowMode.Delete)
            {
                this.OkeyButton.Text = "Delete";
            }

            DataTable dataTable = new Dac().ExecuteDataTable("SELECT Id, Name FROM UserCategory ORDER BY Name").Result;
            UserCategoryComboBox.DataSource = dataTable;
            UserCategoryComboBox.DisplayMember = "Name";
            UserCategoryComboBox.ValueMember = "Id";
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
