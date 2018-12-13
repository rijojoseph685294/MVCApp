using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TwitterClone.Models
{
    public class DashboardModel
    {
        public string LoggedInUserId { get; set; }
        public int TweetCount { get; set; }
        public int Following { get; set; }
        public int Followers { get; set; }
        public string Message { get; set; }
        public virtual Person Person { get; set; }
        public virtual List<Tweet> TweetList { get; set; }
    }




    public class Person
    {
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
        public System.DateTime Joined { get; set; }
        public bool Active { get; set; }
    }

    public class Tweet
    {
        public int TweetId { get; set; }
        [Required]
        public string TweetUser { get; set; }
        [Required]
        public string TweetMessage { get; set; }
        public string TweetTime { get; set; }
    }
}
