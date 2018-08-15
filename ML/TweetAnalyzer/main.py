import sys, re
import datetime

import self as self
from textblob import TextBlob
import matplotlib.pyplot as plt
import sqlite3


class SentimentAnalysis:

    def __init__(self):
        self.tweetText=[]

    def AnalyseTweets(self):

        conn = sqlite3.connect("D:\Projects\TweetAnalyzer\Database\TweetAnalyzerDb.db")
        c = conn.cursor()

        searchGroup = input("Enter user category id to analyze: ")

        query = "SELECT * FROM Tweet t LEFT JOIN User u ON t.CreatedByUserId = u.Id WHERE u.UserCategoryId = " + searchGroup
        queryCount = "SELECT count(*) FROM Tweet t LEFT JOIN User u ON t.CreatedByUserId=u.Id WHERE u.UserCategoryId = " + searchGroup
        result = c.execute(queryCount)
        result1 = result.fetchone()
        NoOfTerms = result1[0]

        # creating some variables to store info
        polarity=0
        positive=0
        wpositive=0
        spositive=0
        negative=0
        wnegative=0
        snegative=0
        neutral=0

        #Removing analysis from database which has same user category id in the same date.
        cmdDelete=conn.cursor()
        now=datetime.datetime.now()
        cmdDeleteText="DELETE FROM AnalyseResult WHERE UserCategoryTypeId = " + searchGroup + " AND substr(AnalyseDate,1,10) = '" + (str(now)[0:10:1]) + "'"
        cmdDelete.execute(cmdDeleteText)

        for row in c.execute(query):
            # Append to temp. I use encode UTF-8
            self.tweetText.append(self.cleanTweet(row[1]).encode('utf-8'))
            analysis=TextBlob(row[1])
            #print(analysis.sentiment)
            polarity+=analysis.sentiment.polarity  # adding up polarities to find the average later

            polarityText = "belirlenmemiş"

            if (analysis.sentiment.polarity == 0):  # adding reaction of how people are reacting to find average later
                neutral+=1
                polarityText = "nötr"
            elif (analysis.sentiment.polarity > 0 and analysis.sentiment.polarity <= 0.3):
                wpositive+=1
                polarityText = "zayıf pozitif"
            elif (analysis.sentiment.polarity > 0.3 and analysis.sentiment.polarity <= 0.6):
                positive+=1
                polarityText = "pozitif"
            elif (analysis.sentiment.polarity > 0.6 and analysis.sentiment.polarity <= 1):
                spositive+=1
                polarityText = "güçlü pozitif"
            elif (analysis.sentiment.polarity > -0.3 and analysis.sentiment.polarity <= 0):
                wnegative+=1
                polarityText = "zayıf negatif"
            elif (analysis.sentiment.polarity > -0.6 and analysis.sentiment.polarity <= -0.3):
                negative+=1
                polarityText = "negatif"
            elif (analysis.sentiment.polarity > -1 and analysis.sentiment.polarity <= -0.6):
                snegative+=1
                polarityText = "güçlü negatif"

            cmdInsert = conn.cursor()
            cmdInsertText = "INSERT INTO AnalyseResult (AnalyseTypeId, UserCategoryTypeId, AnalyseDate, AnalyseUserName, TweetId, ResultValue, ResultText) " \
                          "VALUES (1," + searchGroup + " , '" + str(now) + "' , 'FatmaDeniz' , " + str(row[0]) + "," + str(analysis.sentiment.polarity) + ", '" + polarityText + "' )"
            cmdInsert.execute(cmdInsertText )
            conn.commit()
            cmdInsert.close()

        # finding average of how people are reacting
        positive=self.percentage(positive, NoOfTerms)
        wpositive=self.percentage(wpositive, NoOfTerms)
        spositive=self.percentage(spositive, NoOfTerms)
        negative=self.percentage(negative, NoOfTerms)
        wnegative=self.percentage(wnegative, NoOfTerms)
        snegative=self.percentage(snegative, NoOfTerms)
        neutral=self.percentage(neutral, NoOfTerms)

        # finding average reaction
        polarity = polarity / NoOfTerms

        print("General Report: ")

        if (polarity == 0):
            print("Neutral")
        elif (polarity > 0 and polarity <= 0.3):
            print("Weakly Positive")
        elif (polarity > 0.3 and polarity <= 0.6):
            print("Positive")
        elif (polarity > 0.6 and polarity <= 1):
            print("Strongly Positive")
        elif (polarity > -0.3 and polarity <= 0):
            print("Weakly Negative")
        elif (polarity > -0.6 and polarity <= -0.3):
            print("Negative")
        elif (polarity > -1 and polarity <= -0.6):
            print("Strongly Negative")

        print()
        print("Detailed Report: ")
        print(str(positive) + "% people thought it was positive")
        print(str(wpositive) + "% people thought it was weakly positive")
        print(str(spositive) + "% people thought it was strongly positive")
        print(str(negative) + "% people thought it was negative")
        print(str(wnegative) + "% people thought it was weakly negative")
        print(str(snegative) + "% people thought it was strongly negative")
        print(str(neutral) + "% people thought it was neutral")

    def cleanTweet(self, tweet):
        # Remove Links, Special Characters etc from tweet
        return' '.join(re.sub("(@[A-Za-z0-9]+)|([^0-9A-Za-z \t]) | (\w +:\ / \ / \S +)", " ", tweet).split())

    def percentage(self, part, whole):
        temp=100 * float(part) / float(whole)
        return format(temp, '.2f')

if __name__ == "__main__":
    sa = SentimentAnalysis()
    sa.AnalyseTweets()


