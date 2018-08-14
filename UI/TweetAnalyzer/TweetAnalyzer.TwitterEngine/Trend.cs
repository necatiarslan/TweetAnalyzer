using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi.Models;

namespace TweetAnalyzer.TwitterEngine
{
    public class Trend
    {
        public static long TurkeyWoelId = 23424969;

        public static List<ITrend> GetTrends()
        {
            return Tweetinvi.Trends.GetTrendsAt(TurkeyWoelId).Trends;
        }
    }
}
