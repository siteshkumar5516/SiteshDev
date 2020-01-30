using Models.DbModels;
using Repository.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Managers
{
    public class MedicalManager
    {
        private IGenericRepository<Medical> _repository;
        public MedicalManager(GenericRepository<Medical> repository)
        {
            this._repository = repository;
        }
        public async Task Create(Medical medical)
        {
            await this._repository.Insert(medical);
            await _repository.SaveChanges();

        }
        public async Task Update(Medical medical)
        {
            await this._repository.Update(medical);
            await _repository.SaveChanges();
        }
        public async Task<List<Medical>> GetAll()
        {
            var medicals = await this._repository.GetAll();
            var medicalList = medicals.Cast<Medical>().ToList();
            return medicalList;
        }

    }
}
