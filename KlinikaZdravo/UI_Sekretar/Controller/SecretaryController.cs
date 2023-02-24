using ClassDiagram.Controller;
using ClassDiagram.Model.Users;
using ClassDiagram.Service.UserService;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Controller
{
    public class SecretaryController : IController<Secretary, long>
    {
        private static SecretaryController Instance;
        private readonly IService<Secretary, long> Service;

        public SecretaryController(IService<Secretary, long> service)
        {
            Service = service;
        }
        public static SecretaryController GetInstance(IService<Secretary, long> service)
        {
            if (Instance == null)
            {
                Instance = new SecretaryController(service);
            }
            return Instance;
        }
        public Secretary Create(Secretary secretary) => Service.Create(secretary);
        public void Delete(Secretary secretary) => Service.Delete(secretary); 
        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Secretary> GetAll() => Service.GetAll();
        public Secretary GetByID(long id) => Service.Get(id);
        public void Update(Secretary secretary) => Service.Update(secretary);

        public void DeleteById(long v)
        {
            throw new NotImplementedException();
        }
    }
}
