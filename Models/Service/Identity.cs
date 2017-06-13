using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using Motivation.Models.Interfaces;

namespace Motivation.Models.Service
{
    public class Identity : IIdentity
    {
        private IUser user;
        public Identity(IUser user)
        {
            this.user = user;
        }
        public string AuthenticationType
        {
            get
            {
                return "Custom";
            }
        }

        public bool IsAuthenticated
        {
            get
            {
                return true;
            }
        }

        public string Name
        {
            get
            {
                return this.user.Name;
            }
        }
    }
}