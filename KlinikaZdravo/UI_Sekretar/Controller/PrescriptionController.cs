using ClassDiagram.Controller;
using ClassDiagram.Model.DoctorExaminations;
using ClassDiagram.Service.UserService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace KlinikaZdravo.Controller
{
    public class PrescriptionController : IController<Prescription, long>
    {
        private static PrescriptionController Instance;
        private readonly IService<Prescription, long> Service;

        public PrescriptionController(IService<Prescription, long> service)
        {
            Service = service;
        }
        public static PrescriptionController GetInstance(IService<Prescription, long> service)
        {
            if (Instance == null)
            {
                Instance = new PrescriptionController(service);
            }
            return Instance;
        }

        public Prescription Create(Prescription entity) => Service.Create(entity);
        public void Delete(Prescription entity) => Service.Delete(entity);
        public void Update(Prescription entity) => Service.Update(entity);
        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Prescription> GetAll() => Service.GetAll();
        public Prescription GetByID(long id) => Service.Get(id);

        public void DeleteById(long v)
        {
            throw new NotImplementedException();
        }
    }
}
