using ClassDiagram.Controller;
using ClassDiagram.Model.DoctorExaminations;
using ClassDiagram.Repository.Csv.Converter;
using ClassDiagram.Service.UserService;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Controller
{
    public class RefferalController : IController<ReferralLetter, long>
    {
        private static RefferalController Instance;
        private readonly IService<ReferralLetter, long> Service;

        public RefferalController(IService<ReferralLetter, long> service)
        {
            Service = service;
        }
        public static RefferalController GetInstance(IService<ReferralLetter, long> service)
        {
            if (Instance == null)
            {
                Instance = new RefferalController(service);
            }
            return Instance;
        }
        public ReferralLetter Create(ReferralLetter entity) => Service.Create(entity);
        public void Delete(ReferralLetter entity) => Service.Delete(entity);
        public void Update(ReferralLetter entity) => Service.Update(entity);
        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReferralLetter> GetAll() => Service.GetAll();
        public ReferralLetter GetByID(long id) => Service.Get(id);

        public void DeleteById(long v)
        {
            throw new NotImplementedException();
        }
    }
}
