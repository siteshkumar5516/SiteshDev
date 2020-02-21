using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.GraphModels;
using Repository.Managers;

namespace TestB2c.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GraphUserController : ControllerBase
    {
        private B2CUserManager _b2cUserManager;
        public GraphUserController(B2CUserManager b2cUserManager)
        {
            this._b2cUserManager = b2cUserManager;
        }
        [HttpPost]
        public async Task<IActionResult> Create(B2CUserModel user)
        {
            var data=await _b2cUserManager.Create(user);
            return Ok(data);
        }
    }
}