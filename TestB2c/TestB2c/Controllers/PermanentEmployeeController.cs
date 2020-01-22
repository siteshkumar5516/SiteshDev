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
            await _permanentEmployeeManager.AddPEmployee(permanentEmployee);
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
    }
}