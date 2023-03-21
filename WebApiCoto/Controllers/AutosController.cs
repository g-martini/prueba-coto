using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCoto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutosController : ControllerBase
    {
        private readonly ILogger<AutosController> _logger;

        public AutosController(ILogger<AutosController> logger)
        {
            _logger = logger;
        }
    }
}
