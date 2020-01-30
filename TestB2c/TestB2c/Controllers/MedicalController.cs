using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.DbModels;
using Repository.Managers;

namespace TestB2c.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalController : BaseController
    {
        private MedicalManager _medicalManager { get; set; }
        public MedicalController(MedicalManager medicalManager)
        {
            this._medicalManager = medicalManager;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Medical medical)
        {
            await this._medicalManager.Create(medical);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Put(Medical medical)
        {
            await this._medicalManager.Update(medical);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
           var medical= await this._medicalManager.GetAll();
            return Ok(medical);
        }
    }
}