using Microsoft.AspNetCore.Mvc;
using poc.Core.Interfaces.Repositories;
using poc.Core.Interfaces.Services;
using poc.Core.Services;
using poc.Infra.Repositories;

namespace poc.Api.Controllers {

    //[Produces("application/json")]
    //[Route("api/[controller]")]
    public abstract class AbstractController : Controller {

        protected readonly UserService UserService = new UserService(new UserRepository());

        protected AbstractController() {

        }

        // TODO: Implementar Injeção de dependência.
        //protected AbstractController(IUserService userService) {
        //    this._userService = userService;
        //}
    }
}