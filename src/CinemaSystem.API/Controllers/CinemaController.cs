namespace CinemaSystem.API.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/cinema")]
    [ApiController]
    public class CinemaController : ControllerBase
    {
        [HttpGet("displayes")]
        public async Task<IActionResult> GetCinemaDisplayes()
        {
            //CommandExecutor
            //var subscription = await _paymentsModule.ExecuteQueryAsync(new GetAuthenticatedPayerSubscriptionQuery());

            return Ok();
        }
    }
}
