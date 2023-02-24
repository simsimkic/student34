using ClassDiagram.Controller;
using ClassDiagram.Model.Users;
using ClassDiagram.Service.UserService;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Controller
{
    public class CountryController : IController<Country, long>
    {

        private static CountryController Instance;
        private readonly IService<Country, long> Service;

        public CountryController(IService<Country, long> service)
        {
            Service = service;
        }
        public static CountryController GetInstance(IService<Country, long> service)
        {
            if (Instance == null)
            {
                Instance = new CountryController(service);
            }
            return Instance;
        }

        public IEnumerable<Country> GetAll() => Service.GetAll();
        public Country GetByID(long id) => Service.Get(id);
        public Country Create(Country country) => Service.Create(country);
        public void Update(Country country) => Service.Update(country);
        public void Delete(Country country) => Service.Delete(country);
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
