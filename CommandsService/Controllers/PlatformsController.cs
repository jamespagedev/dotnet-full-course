using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers
{
    [Route("api/c/[controller]")] // since "platforms" is used by another project, it will cause gateway issues, so we make the name unique
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        public PlatformsController()
        {
            
        }
        
        [HttpPost]
        public ActionResult TestInboundConnection()
        {
            Console.WriteLine("--> Inbound POST # Command Service");
            
            return Ok("Inbound test ok from platforms controller");
        }
    }
}