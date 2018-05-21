using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using poc.Api.DataContracts;
using poc.Api.Models;
using poc.Core.ConfigurationSettings;
using poc.Core.Interfaces.Services;
using poc.Core.ServiceContracts;
using poc.Core.Services;

namespace poc.Api.Controllers {

    [Produces("application/json")]
    [Route("api/[controller]")]
    public class UserController : AbstractController {

        private GimSettings _gimSettings { get; set; }

        public UserController(IOptions<GimSettings> gimSettings) { this._gimSettings = gimSettings.Value; }

        private IUserService _userService { get; }

        //public UserController(IUserService userService) {
        //    this._userService = userService;
        //}

        [HttpGet]
        public string GetOperationalSystem() { return Environment.OSVersion.VersionString; }

        [HttpPost]
        [Route("signIn")]
        public IActionResult SignInUser([FromBody]SignInModel model) {

            var x = _gimSettings.ProductionDomain;

            if (ModelState.IsValid == false) { return BadRequest(ModelState); }

            SignInUserRequest serviceRequest = new SignInUserRequest { Login = model.Login, Password = model.Password };

            SignInUserResponse serviceResponse = _userService.SignInUser(serviceRequest);

            SignInUserApiResponse apiResponse = new SignInUserApiResponse();

            if (serviceResponse.Success == false) {

                foreach (Report report in serviceResponse.OperationReport) {
                    apiResponse.OperationReport.Add(new ApiReport { Field = report.Field, Message = report.Message });
                }

                return Ok(apiResponse);
            }

            // TODO: Melhorar passagem de dados com AutoMapper ou outro.

            // TODO: remover valores nulos da resposta quando retornar false.

            apiResponse.AuthenticationToken = serviceResponse.AuthenticationToken;
            apiResponse.TokenExpirationInMinutes = serviceResponse.TokenExpirationInMinutes;
            apiResponse.UserKey = serviceResponse.UserKey;
            apiResponse.Name = serviceResponse.Name;
            apiResponse.Success = true;

            return Ok(apiResponse);
        }
    }
}