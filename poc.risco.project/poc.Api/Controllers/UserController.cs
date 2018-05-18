using System;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using poc.Api.Models;

namespace poc.Api.Controllers {

    [Produces("application/json")]
    [Route("api/[controller]")]
    public class UserController : AbstractController {

        [HttpGet]
        public string GetOperationalSystem() {

            return Environment.OSVersion.VersionString;
        }

        [HttpPost]
        [Route("signIn")]
        public IActionResult SignInUser([FromBody]SignInModel model) {

            if (ModelState.IsValid == false) {
                throw new InvalidOperationException("invalid");
            }

            return Ok();
        }
    }
}