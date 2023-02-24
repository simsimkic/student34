using ClassDiagram.Controller;
using ClassDiagram.Model.Users;
using ClassDiagram.Service.UserService;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Controller
{
    public class CityController : IController<City, long>
    {

        private static CityController Instance;
        private readonly IService<City, long> Service;

        public CityController(IService<City, long> service)
        {
            Service = service;
        }
        public static CityController GetInstance(IService<City, long> service)
        {
            if (Instance == null)
            {
                Instance = new CityController(service);
            }
            return Instance;
        }

        public IEnumerable<City> GetAll() => Service.GetAll();
        public City GetByID(long id) => Service.Get(id);
        public City Create(City city) => Service.Create(city);
        public void Update(City city) => Service.Update(city);
        public void Delete(City city) => Service.Delete(city);
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
