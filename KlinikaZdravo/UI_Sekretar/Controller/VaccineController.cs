using ClassDiagram.Controller;
using ClassDiagram.Model.DoctorExaminations;
using ClassDiagram.Service.UserService;
using System;
using System.Collections.Generic;

namespace KlinikaZdravo.Controller
{
    public class VaccineController : IController<Vaccine, long>
    {
        private static VaccineController Instance;
        private readonly IService<Vaccine, long> Service;

        public VaccineController(IService<Vaccine, long> service)
        {
            Service = service;
        }
        public static VaccineController GetInstance(IService<Vaccine, long> service)
        {
            if (Instance == null)
            {
                Instance = new VaccineController(service);
            }
            return Instance;
        }

        public Vaccine Create(Vaccine entity) => Service.Create(entity);
        public void Delete(Vaccine entity) => Service.Delete(entity);
        public void Update(Vaccine entity) => Service.Update(entity);
        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vaccine> GetAll() => Service.GetAll();
        public Vaccine GetByID(long id) => Service.Get(id);

        public void DeleteById(long v)
        {
            throw new NotImplementedException();
        }
    }
}
