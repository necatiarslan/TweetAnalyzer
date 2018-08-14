using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi.Models;
using TweetAnalyzer.Database;

namespace TweetAnalyzer.Win
{
    class DbHelper
    {
        public static MethodResult<int> SaveTweetList(List<ITweet> tweets)
        {
            MethodResult<int> result = new MethodResult<int>();
            
            if (tweets == null)
            {
                result.Exception = new NullReferenceException();
                return result;
            }

            foreach (ITweet tweet in tweets)
            {
                MethodResult<bool> saveTweetResult = SaveTweet(tweet);
                if (saveTweetResult.IsSuccessful)
                {
                    if(saveTweetResult.Result)
                        result.Result++;
                }
                else
                {
                    result.Exception = saveTweetResult.Exception;
                    result.IsSuccessful = false;
                    return result;
                }
            }

            result.IsSuccessful = true;
            return result;
        }

        public static MethodResult<bool> SaveTweet(ITweet tweet)
        {
            MethodResult<bool> result = new MethodResult<bool>();
                        
            /*
                CREATE TABLE `Tweet` (
	                `TweetId`	NUMERIC NOT NULL UNIQUE,
	                `FullText`	TEXT NOT NULL,
	                `Text`	TEXT NOT NULL,
	                `CreatedByUserId`	INTEGER NOT NULL,
	                `RetweetCount`	INTEGER,
	                `FavoriteCount`	INTEGER,
	                `Language`	TEXT,
	                `CreatedAt`	TEXT,
	                `Source`	TEXT,
	                `IsRetweet`	INTEGER,
	                `RetweetedTweetId`	NUMERIC,
	                PRIMARY KEY(`TweetId`)
                );

                CREATE TABLE `TweetHashtag` (
	                `TweetId`	NUMERIC,
	                `Hashtag`	TEXT
                );


                CREATE TABLE `TweetMedia` (
	                `TweetId`	NUMERIC,
	                `Id`	NUMERIC,
	                `Url`	TEXT,
	                `MediaType`	TEXT
                );

                CREATE TABLE `TweetMention` (
	                `TweetId`	NUMERIC NOT NULL,
	                `UserId`	NUMERIC,
	                `Name`	TEXT,
	                `ScreenName`	TEXT
                );

                CREATE TABLE `TweetUrl` (
	                `TweetId`	NUMERIC,
	                `Url`	TEXT
                );
             */


                Dictionary<string, object> columns = new Dictionary<string, object>();

                columns["FullText"] = tweet.FullText;
                columns["Text"] = tweet.Text;
                columns["CreatedByUserId"] = tweet.CreatedBy.Id;
                columns["CreatedAt"] = tweet.CreatedAt;
                columns["RetweetCount"] = tweet.RetweetCount;
                columns["FavoriteCount"] = tweet.FavoriteCount;
                columns["Language"] = tweet.Language.ToString();
                columns["Source"] = tweet.Source;
                columns["IsRetweet"] = tweet.IsRetweet;
                columns["RetweetedTweetId"] = (tweet.IsRetweet ? tweet.RetweetedTweet.Id : 0);

 
                MethodResult<bool> existsResult = IsTweetSaved(tweet);

                if(!existsResult.IsSuccessful)
                {
                    result.Exception = existsResult.Exception;
                    result.IsSuccessful = false;
                    return result;
                }

                Dac dac = new Dac();

                if (!existsResult.Result)
                {
                    columns["TweetId"] = tweet.Id;
                    MethodResult resultTweet = dac.Insert("Tweet", columns);
                    result.Result= true;

                    if (!resultTweet.IsSuccessful)
                    {
                        throw resultTweet.Exception;
                    }

                    foreach (var hashtag in tweet.Hashtags)
                    {
                        Dictionary<string, object> hashtagColumns = new Dictionary<string, object>();
                        hashtagColumns.Add("TweetId", tweet.Id);
                        hashtagColumns.Add("Hashtag", hashtag.Text);

                        MethodResult resultHashtag = dac.Insert("TweetHashtag", hashtagColumns);

                        if (!resultHashtag.IsSuccessful)
                        {
                            result.Exception = resultHashtag.Exception;
                            result.IsSuccessful = false;
                            return result;
                        }

                    }

                    foreach (var media in tweet.Media)
                    {
                        Dictionary<string, object> mediaColumns = new Dictionary<string, object>();
                        mediaColumns.Add("TweetId", tweet.Id);
                        mediaColumns.Add("Id", media.Id);
                        mediaColumns.Add("Url", media.MediaURL);
                        mediaColumns.Add("MediaType", media.MediaType);

                        MethodResult resulMedia = dac.Insert("TweetMedia", mediaColumns);

                        if (!resulMedia.IsSuccessful)
                        {
                        result.Exception = resulMedia.Exception;
                        result.IsSuccessful = false;
                        return result;
                    }
                    }

                    foreach (var mention in tweet.UserMentions)
                    {
                        Dictionary<string, object> mentionColumns = new Dictionary<string, object>();
                        mentionColumns.Add("TweetId", tweet.Id);
                        mentionColumns.Add("UserId", mention.Id);
                        mentionColumns.Add("Name", mention.Name);
                        mentionColumns.Add("ScreenName", mention.ScreenName);

                        MethodResult resulMention = dac.Insert("TweetMention", mentionColumns);

                        if (!resulMention.IsSuccessful)
                        {
                        result.Exception = resulMention.Exception;
                        result.IsSuccessful = false;
                        return result;
                    }
                    }

                    foreach (var url in tweet.Urls)
                    {
                        Dictionary<string, object> urlColumns = new Dictionary<string, object>();
                        urlColumns.Add("TweetId", tweet.Id);
                        urlColumns.Add("Url", url.URL);

                        MethodResult resultUrl = dac.Insert("TweetUrl", urlColumns);

                        if (!resultUrl.IsSuccessful)
                        {
                        result.Exception = resultUrl.Exception;
                        result.IsSuccessful = false;
                        return result;
                    }
                    }

                }

            result.IsSuccessful = true;
            return result;

        }

        public static MethodResult<bool> IsTweetSaved(ITweet tweet)
        {
            Dac dac = new Dac();
            MethodResult<bool> existsResult = dac.Exists("Tweet", "TweetId", tweet.Id);

            return existsResult;
        }
    }
}
