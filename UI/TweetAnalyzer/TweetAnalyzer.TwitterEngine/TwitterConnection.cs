using Microsoft.Win32;
using System;
using System.Collections.Generic;
using Tweetinvi;
using Tweetinvi.Models;

namespace TweetAnalyzer.TwitterEngine
{
    public class TwitterConnection
    {
        public TwitterConnection()
        {
            TwitterConnection.Current = this;
            this.ConsumerKey = string.Empty;
            this.ConsumerSecret = string.Empty;
            this.UserAccessToken = string.Empty;
            this.UserAccessSecret = string.Empty;
            this.IsConected = false;
        }

        public IAuthenticatedUser User { get; set; }
        public ITwitterCredentials TwitterCredentials { get; set; }
        public string ConsumerKey { get; set; }
        public string ConsumerSecret { get; set; }
        public string UserAccessToken { get; set; }
        public string UserAccessSecret { get; set; }
        public bool IsConected { get; private set; }
        public static TwitterConnection Current { get; set; }

        public void Connect()
        {
            //this.TwitterCredentials = SetUserCredentials("0WRnU8jdgC3LtnRyHi9WIyqaA", "Y2GmbR7IELkcWSvyLbZJ4YnejPDBNVeoT1tmZitWieqbmF7vCH", "807855001615945728-03IgRRjRjZ0PypAaORNHvZitbxVzu9j", "ymrBMBNwmGFUMnWMyOOwCEl5PoEaqXCURzBpPsDMjatqw");
            this.TwitterCredentials = SetUserCredentials(this.ConsumerKey, this.ConsumerSecret, this.UserAccessToken, this.UserAccessSecret);
            
            this.User = Tweetinvi.User.GetAuthenticatedUser();
            this.IsConected = true;
        }

        public void SaveCredentialsToReqistry()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\TweetAnalyzer");

            key.SetValue("ConsumerKey", this.ConsumerKey);
            key.SetValue("ConsumerSecret", this.ConsumerSecret);
            key.SetValue("UserAccessToken", this.UserAccessToken);
            key.SetValue("UserAccessSecret", this.UserAccessSecret);
            key.Close();
        }

        public void ResetCredentialsToReqistry()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\TweetAnalyzer");

            key.SetValue("ConsumerKey", string.Empty);
            key.SetValue("ConsumerSecret", string.Empty);
            key.SetValue("UserAccessToken", string.Empty);
            key.SetValue("UserAccessSecret", string.Empty);
            key.Close();
        }

        public void LoadCredentialsFromReqistry()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\TweetAnalyzer");

            this.ConsumerKey = (string)key.GetValue("ConsumerKey");
            this.ConsumerSecret = (string)key.GetValue("ConsumerSecret");
            this.UserAccessToken = (string)key.GetValue("UserAccessToken");
            this.UserAccessSecret = (string)key.GetValue("UserAccessSecret");
            key.Close();
        }

        public void Disconnect()
        {
            this.TwitterCredentials = null;
            this.User = null;
            Auth.InvalidateCredentials();
            this.IsConected = false;
        }

        private static ITwitterCredentials SetUserCredentials(string consumerKey, string consumerSecret, string userAccessToken, string userAccessSecret)
        {
            //return Auth.SetUserCredentials("0WRnU8jdgC3LtnRyHi9WIyqaA", "Y2GmbR7IELkcWSvyLbZJ4YnejPDBNVeoT1tmZitWieqbmF7vCH", "807855001615945728-03IgRRjRjZ0PypAaORNHvZitbxVzu9j", "ymrBMBNwmGFUMnWMyOOwCEl5PoEaqXCURzBpPsDMjatqw");
            return Auth.SetUserCredentials(consumerKey, consumerSecret, userAccessToken, userAccessSecret);
        }

    }
}
