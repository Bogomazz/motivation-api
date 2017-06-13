using Motivation.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Motivation.Models
{
    public class User : IUser
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Login { set; get; }
        public string Hash { set; get; }
        public string Salt { set; get; }
        public int Pocket { set; get; }
        public string ImgUrl { set; get; }

        public ICollection<Issue> Issues { set; get; }
        public ICollection<Category> Categories { set; get; }
        public ICollection<Session> Sessions { set; get; }
        public ICollection<Action> Actions { set; get; }
        public ICollection<Reward> Rewards { set; get; }
    }
}