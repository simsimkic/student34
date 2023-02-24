using ClassDiagram.Controller;
using ClassDiagram.Model.Rooms;
using ClassDiagram.Service.UserService;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Controller
{
    public class RenovationController : IController<Renovation, long>
    {

        private static RenovationController Instance;
        private readonly IService<Renovation, long> Service;
        public RenovationController(IService<Renovation, long> service)
        {
            Service = service;
        }
        public static RenovationController GetInstance(IService<Renovation, long> service)
        {
            if (Instance == null)
            {
                Instance = new RenovationController(service);
            }
            return Instance;
        }
        public IEnumerable<Renovation> GetAll() => Service.GetAll();

        public Renovation GetByID(long id) => Service.Get(id);

        public Renovation Create(Renovation entity) => Service.Create(entity);

        public void Update(Renovation entity) => Service.Update(entity);

        public void Delete(Renovation entity) => Service.Delete(entity);

       

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
