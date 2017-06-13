using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Motivation.Models
{
    public class Issue
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public string Description { set; get; }
        public int Cost { set; get; }


        public int? CategoryId { set; get; }
        public int? UserId { set; get; }

    }
}