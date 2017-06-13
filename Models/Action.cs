using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Motivation.Models
{
    public class Action
    {
        public int Id { set; get; }
        public int? IssueId { set; get; }
        public int? RewardId { set; get; }
        public string Type { set; get; }
        public int PocketDelta { set; get; }

        public int UserId { set; get; }
    }
}