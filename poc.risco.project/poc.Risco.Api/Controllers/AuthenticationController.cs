﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using poc.Risco.Api.Models;

namespace poc.Risco.api.Controllers {

    [Produces("application/json")]
    [Route("api")]
    public class AuthenticationController : Controller {

        [HttpGet]
        public string Get() {

            return System.Environment.OSVersion.VersionString;
        }

        //[HttpPost]
        //[Route("signIn")]
        //public HttpResponseMessage SignInUser([FromBody]SignInModel model) {

        //    HttpResponseMessage httpResponseMessage = new HttpResponseMessage();



        //    return httpResponseMessage;
        //}
    }
}