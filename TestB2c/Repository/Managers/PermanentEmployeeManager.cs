using GraphApi;
using Models.DbModels;
using Repository.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Repository.Managers
{
    public class PermanentEmployeeManager
    {
        private IGenericRepository<PermanentEmployee> _repository;
      //  private B2CGraphClient _b2CGraphClient;
        public PermanentEmployeeManager(GenericRepository<PermanentEmployee> repository)
        {
            this._repository = repository;
           // this._b2CGraphClient = b2CGraphClient;
        }
        public async Task AddPEmployee(PermanentEmployee permanentEmployee)
        {
           // var user = await _b2CGraphClient.GetAllUsers("");
            await _repository.Insert(permanentEmployee);
            await _repository.SaveChanges();
        }

        public async Task UpdatePEmployee(PermanentEmployee permanentEmployee)
        {
            var existingEmployees = await _repository.GetById(permanentEmployee.Id);
            if(existingEmployees==null)
               throw new Exception($"Employee update,Employee details not found in  for Id- {permanentEmployee.Id}");
            existingEmployees.FirstName = permanentEmployee.FirstName;
            existingEmployees.LastName = permanentEmployee.LastName;
            existingEmployees.YearlySalary = permanentEmployee.YearlySalary;
            await _repository.Update(existingEmployees);
            await _repository.SaveChanges();
        }
        public async Task<List<PermanentEmployee>> GetAll()
        {
            var allEmployees = await _repository.GetAll();
            var employeeList = allEmployees.Cast<PermanentEmployee>().ToList();
            return employeeList;
        }

        public async Task<PermanentEmployee> GetById(int Id)
        {
            var employee = await _repository.GetById(Id);
            return employee;
        }
    }
}
