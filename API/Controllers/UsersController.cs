using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetUser()
        {

            return Ok("ok");
        }

        [HttpGet]
        [Route("GetUsera")]
        public ActionResult GetUsera()
        {

            return Ok("false");
        }

        [HttpGet]
        [Route("GetUserb")]
        public ActionResult GetUserb()
        {

            return Ok("NULL");
        }

    }
}