using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Core;
using Tweetinvi.Models;
using Tweetinvi.Parameters;

namespace TweetAnalyzer.TwitterEngine
{
    public class User
    {
        public static MethodResult<IUser> FindUserFromUserName(string userName)
        {
            IUser user;
            MethodResult<IUser> result = new MethodResult<IUser>();

            try
            {
                user = Tweetinvi.User.GetUserFromScreenName(userName);
                if (user != null)
                {
                    result.Result = user;
                    result.IsSuccessful = true;
                }

            }
            catch (Exception ex)
            {
                result.Exception = ex;
                result.IsSuccessful = false;
            }
            

            return result;
        }

        public static List<ITweet> GetTweetUserList(IUser user)
        {
            return user.Timeline;
        }

        public static List<ITweet> GetUserTweets(IUser user)
        {
            return user.Timeline;
        }

        public static List<ITweet> GetUserTweets(IUser user, decimal tweetId)
        {
            List<ITweet> result = new List<ITweet>();


            var searchParameter = new SearchTweetsParameters("tweetinvi");
            searchParameter.SinceId = (long)tweetId;
            

            var tweets = Search.SearchTweets(searchParameter);

            return result;
        }
    }
}
