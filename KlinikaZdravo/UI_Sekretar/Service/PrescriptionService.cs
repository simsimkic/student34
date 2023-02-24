using ClassDiagram.Model.DoctorExaminations;
using ClassDiagram.Service.UserService;
using KlinikaZdravo.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Service
{
    public class PrescriptionServicev : IService<Prescription, long>
    {
        private readonly IPrescriptionRepository Repository;

        public PrescriptionServicev(IPrescriptionRepository repository)
        {
            Repository = repository;
        }

        public Prescription Create(Prescription entity) => Repository.Create(entity);
        public void Delete(Prescription entity) => Repository.Delete(entity);

        public void DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public Prescription Get(long id) => Repository.GetByID(id);
        public IEnumerable<Prescription> GetAll() => Repository.GetAll();
        public void Update(Prescription adress) => Repository.Update(adress);
    }
    
}
