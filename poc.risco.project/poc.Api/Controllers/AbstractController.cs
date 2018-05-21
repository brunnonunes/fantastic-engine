using Microsoft.AspNetCore.Mvc;

namespace poc.Api.Controllers {

    //[Produces("application/json")]
    //[Route("api/[controller]")]
    public abstract class AbstractController : Controller {

        protected AbstractController() {

        }
    }
}