using ClassDiagram.Model.DoctorExaminations;
using ClassDiagram.Service.UserService;
using KlinikaZdravo.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Service
{
    public class AllergieService : IService<Allergie, long>
    {
        private readonly IAllergieRepository Repository;

        public AllergieService(IAllergieRepository repository)
        {
            Repository = repository;
        }

        public Allergie Create(Allergie entity) => Repository.Create(entity);
        public void Delete(Allergie entity) => Repository.Delete(entity);

        public void DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public Allergie Get(long id) => Repository.GetByID(id);
        public IEnumerable<Allergie> GetAll() => Repository.GetAll();
        public void Update(Allergie adress) => Repository.Update(adress);
    }
}
