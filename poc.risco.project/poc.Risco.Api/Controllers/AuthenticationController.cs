using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace poc.Risco.api.Controllers {

    [Produces("application/json")]
    [Route("api/[controller]")]
    public class AuthenticationController : Controller {

        [HttpGet]
        public string Get() {

            return System.Environment.OSVersion.VersionString;
        }

        [HttpPost]
        public string SignInUser()
        {

            return null;
        }
    }
}