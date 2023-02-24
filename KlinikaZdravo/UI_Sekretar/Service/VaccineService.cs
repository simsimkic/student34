using ClassDiagram.Model.DoctorExaminations;
using ClassDiagram.Service.UserService;
using KlinikaZdravo.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Service
{
    public class VaccineService : IService<Vaccine, long>
    {
        private readonly IVaccineRepository Repository;

        public VaccineService(IVaccineRepository repository)
        {
            Repository = repository;
        }

        public Vaccine Create(Vaccine entity) => Repository.Create(entity);
        public void Delete(Vaccine entity) => Repository.Delete(entity);

        public void DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public Vaccine Get(long id) => Repository.GetByID(id);
        public IEnumerable<Vaccine> GetAll() => Repository.GetAll();
        public void Update(Vaccine adress) => Repository.Update(adress);
    }
}
