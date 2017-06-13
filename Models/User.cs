using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Motivation.Models
{
    public class User
    {
        public int Id { set; get; }
        public string UserName { set; get; }
        public string Hash { set; get; }
        public string Salt { set; get; }
        public int Pocket { set; get; }
        public string ImgUrl { set; get; }

        public ICollection<Task> Tasks { set; get; }
        public ICollection<Category> Categories { set; get; }
        public ICollection<Session> Sessions { set; get; }
        public ICollection<Action> Actions { set; get; }
        public ICollection<Reward> Rewards { set; get; }
    }
}