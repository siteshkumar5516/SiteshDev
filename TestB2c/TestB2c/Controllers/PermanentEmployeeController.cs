using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.DbModels;
using Repository.Managers;

namespace TestB2c.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
  
    public class PermanentEmployeeController : ControllerBase
    {
        private PermanentEmployeeManager _permanentEmployeeManager { get; set; }
        public PermanentEmployeeController(PermanentEmployeeManager permanentEmployeeManager)
        {
            this._permanentEmployeeManager = permanentEmployeeManager;
        }
        [HttpPost]
        public async Task Create(PermanentEmployee permanentEmployee)
        {
            try
            {
                await _permanentEmployeeManager.AddPEmployee(permanentEmployee);
            }
           catch(Exception ex)
            {
                throw ex.InnerException;
            }
        }

        [HttpPut]
        public async Task Update(PermanentEmployee permanentEmployee)
        {
            try
            {
                await _permanentEmployeeManager.UpdatePEmployee(permanentEmployee);
            }
            catch(Exception ex)
            {

            }
          
        }
        [HttpGet]
        
        public async Task<IActionResult> Get()
        {
            var employees = await _permanentEmployeeManager.GetAll();
            return Ok(employees);

        }

        [HttpGet("{id}")]
   
        public async Task<IActionResult> Get(int id)
        {
            var employees = await _permanentEmployeeManager.GetById(id);
            return Ok(employees);

        }
    }
}