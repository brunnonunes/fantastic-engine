using System;
using Microsoft.AspNetCore.Mvc;
using poc.Api.DataContracts;
using poc.Api.Models;
using poc.Core.ServiceContracts;

namespace poc.Api.Controllers {

    [Produces("application/json")]
    [Route("api/[controller]")]
    public class UserController : AbstractController {

        [HttpGet]
        public string GetOperationalSystem() { return Environment.OSVersion.VersionString; }

        [HttpPost]
        [Route("signIn")]
        public IActionResult SignInUser([FromBody]SignInModel model) {

            if (ModelState.IsValid == false) { return BadRequest(ModelState); }

            SignInUserRequest serviceRequest = new SignInUserRequest { Login = model.Login, Password = model.Password };

            SignInUserResponse serviceResponse = this.UserService.SignInUser(serviceRequest);

            SignInUserApiResponse apiResponse = new SignInUserApiResponse();

            if (serviceResponse.Success == false) {

                foreach (Report report in serviceResponse.OperationReport) {
                    apiResponse.OperationReport.Add(new ApiReport { Field = report.Field, Message = report.Message });
                }

                return Ok(apiResponse);
            }

            apiResponse.AuthenticationToken = serviceResponse.AuthenticationToken;
            apiResponse.TokenExpirationInMinutes = serviceResponse.TokenExpirationInMinutes;
            apiResponse.UserKey = serviceResponse.UserKey;
            apiResponse.Name = serviceResponse.Name;
            apiResponse.Success = true;

            return Ok(apiResponse);
        }
    }
}