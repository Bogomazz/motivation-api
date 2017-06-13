using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Motivation.Models
{
    public class Category
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public int Factor { set; get; }

        public int? UserId { set; get; }
        public ICollection<Issue> Issues { set; get; }
    }
}