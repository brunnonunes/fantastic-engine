using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace poc.Api.Controllers {

    [Produces("application/json")]
    [Route("api/[controller]")]
    public class TransactionController : AbstractController {

        [HttpPost]
        [Route("send")]
        public IActionResult Send([FromBody] string data) {

            return Ok();
        }
    }
}