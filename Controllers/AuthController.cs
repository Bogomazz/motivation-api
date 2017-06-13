using Motivation.Models;
using Motivation.Models.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Motivation.Controllers
{
    public class AuthController : ApiController
    {
        [ActionName("Register")]
        [HttpPost]
        public void Register([FromBody]RegisterForm data)
        {

        }

        [ActionName("Login")]
        [HttpPost]
        public void Login([FromBody]LoginForm data)
        {

        }
    }
}
