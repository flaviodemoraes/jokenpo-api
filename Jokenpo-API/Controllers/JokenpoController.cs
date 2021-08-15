using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jokenpo_API.Models;
using Jokenpo_API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Jokenpo_API.Controllers
{
    [Route("api/[controller]")]
    public class JokenpoController : Controller
    {
        private readonly IGamersService _gamersService;
        private readonly ILogger _logger;

        public JokenpoController(IGamersService gamersService,
            ILogger<JokenpoController> logger)
        {
            _gamersService = gamersService;
            _logger = logger;
        }

        /// <summary>
        /// Let's Play? Choose an option between: Rock, Paper and Scissors.
        /// </summary>
        /// <param name="choiceUser"></param>
        /// <remarks>
        /// POST api/jokenpo
        /// {
        ///     "choisesUser": "Rock"
        /// }
        /// </remarks>
        [HttpPost]
        public IActionResult LetsGoJokenpo([FromBody]Choice choiceUser)
        { 
            var result =  _gamersService.GamerState(choiceUser.choisesUser.ToString());
            _logger.LogInformation(result);
            return Ok(result);
        }
    }

    
}
