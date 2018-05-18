using Microsoft.AspNetCore.Mvc;
using poc.Core.Interfaces.Services;

namespace poc.Api.Controllers {

    //[Produces("application/json")]
    //[Route("api/[controller]")]
    public abstract class AbstractController : Controller {

        private readonly IUserService _userService;

        protected AbstractController() { }

        protected AbstractController(IUserService userService) {
            this._userService = userService;
        }
    }
}