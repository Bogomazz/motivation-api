using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Motivation.Models
{
    public class Session
    {
        public int Id { set; get; }
        public string Token { set; get; }

        public int UserId { set; get; }
    }
}