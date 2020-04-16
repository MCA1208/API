using API.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using API.Models;
using System;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public UsersController(IConfiguration configuration)
        {
            _configuration = configuration;

        }
        ResultModel Data = new ResultModel();
        UserService Service = new UserService();

        [HttpGet]
        public ActionResult GetUser()
        {

            return Ok("ok");
        }

        [HttpGet]
        [Route("GetUsera")]
        public ActionResult GetUsera()///api/Users/GetUsera
        {
            try
            {
                Data.Result = Service.SpGetAllClient(_configuration.GetValue<string>("Data:ConnectionString"));
                Data.Result = JsonConvert.SerializeObject(Data, Formatting.Indented);

                return Ok(Data.Result);
            }
            catch (Exception ex) 
            {
                Data.Status = "error";
                Data.Message = ex.Message;
                Data.Result = JsonConvert.SerializeObject(Data, Formatting.Indented);

                return Ok(Data.Result);

            }
        }

        [HttpGet]
        [Route("GetUserb")]
        public ActionResult GetUserb()
        {

            return Ok("NULL");
        }

    }
}