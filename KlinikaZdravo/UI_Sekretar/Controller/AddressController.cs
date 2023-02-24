using ClassDiagram.Controller;
using ClassDiagram.Model.Users;
using ClassDiagram.Service.UserService;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Controller
{
    public class AddressController : IController<Adress, long>
    {
        private static AddressController Instance;
        private readonly IService<Adress, long> Service;

        public AddressController(IService<Adress, long> service)
        {
            Service = service;
        }
        public static AddressController GetInstance(IService<Adress, long> service)
        {
            if (Instance == null)
            {
                Instance = new AddressController(service);
            }
            return Instance;
        }
        public Adress Create(Adress adress) => Service.Create(adress);
        public void Delete(Adress adress) => Service.Delete(adress);
        public void Update(Adress adress) => Service.Update(adress);
        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Adress> GetAll() => Service.GetAll();
        public Adress GetByID(long id) => Service.Get(id);

        public void DeleteById(long v)
        {
            throw new NotImplementedException();
        }
    }
}
