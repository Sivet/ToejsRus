using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace toejController.Controllers{

    [ApiController]
    [Route("[controller]")]
    class ItemOverviewController : ControllerBase{

        [HttpGet]
        public string GetImage(string imageName)
        {
            return "s";
        }
    }
}