using ClassDiagram.Controller;
using ClassDiagram.Model.Users;
using ClassDiagram.Service.UserService;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Controller
{
    public class ManagerController : IController<Manager, long>
    {

        private static ManagerController Instance;
        private readonly IService<Manager, long> Service;

        public ManagerController(IService<Manager, long> service)
        {
            Service = service;
        }
        public static ManagerController GetInstance(IService<Manager, long> service)
        {
            if (Instance == null)
            {
                Instance = new ManagerController(service);
            }
            return Instance;
        }


        public IEnumerable<Manager> GetAll() => Service.GetAll();

        public Manager GetByID(long id) => Service.Get(id);

        public Manager Create(Manager manager) => Service.Create(manager);

        public void Update(Manager manager) => Service.Update(manager);
        public void Delete(Manager manager) => Service.Delete(manager); 
        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public void DeleteById(long v)
        {
            throw new NotImplementedException();
        }
    }
}
