using CapitanTioApp.Data.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitanTioApp.Data
{
    public static class conversacion
    {
        /// <summary>
        /// CapitanTio tweets
        /// </summary>
        public static clsTwitterJson Tweets;
        /// <summary>
        /// Obtiene el chat de dos usario que hablan en capitan tio
        /// </summary>
        /// <param name="user1"></param>
        /// <param name="user2"></param>
        /// <returns>Lista de string con los tweets</returns>h
        /// Conversacion
        public static List<string> getUserChat(string user1, string user2)
        {
            List<string> tweetsList = new List<string>();
            if (Tweets != null && Tweets.results != null && Tweets.results.Count > 0)
            {
                List<Tweet> userTweets = Tweets.results.FindAll(r => (r.from_user_name == user1 && r.to_user_name == user2) || (r.from_user_name == user2 && r.to_user_name == user1));
                foreach (Tweet tw in userTweets)
                {
                    tweetsList.Add(tw.text);
                }
            }
            return tweetsList;
        }
        //Monólogo
        public static List<string> getUserChat(string user1)
        {
            List<string> tweetsList = new List<string>();
            if (Tweets != null && Tweets.results != null && Tweets.results.Count > 0)
            {
                List<Tweet> userTweets = Tweets.results.FindAll(r => (r.from_user_name == user1 && r.to_user_name == null));
                foreach (Tweet tw in userTweets)
                {
                    tweetsList.Add(tw.text);
                }
            }
            return tweetsList;
        }
        /// <summary>
        /// Obtiene todos los twieets de capitan tio.
        /// </summary>
        /// <returns>Lista de string con los tweets</returns>
        public static List<string> getMonologo()
        {
            List<string> tweetsList = new List<string>();
            if (Tweets != null && Tweets.results != null && Tweets.results.Count > 0)
            {
                foreach (Tweet tw in Tweets.results)
                {
                    tweetsList.Add(tw.text);
                }
            }
            return tweetsList;
        }
    }
}