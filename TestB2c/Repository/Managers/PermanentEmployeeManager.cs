using Models.DbModels;
using Repository.GenericRepo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Repository.Managers
{
    public class PermanentEmployeeManager
    {
        private IGenericRepository<PermanentEmployee> _repository;
        public PermanentEmployeeManager(GenericRepository<PermanentEmployee> repository)
        {
            this._repository = repository;
        }
        public async Task AddPEmployee(PermanentEmployee permanentEmployee)
        {
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
    }
}
