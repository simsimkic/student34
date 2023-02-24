using ClassDiagram.Model.Users;
using ClassDiagram.Service.UserService;
using KlinikaZdravo.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Service
{
    public class CityService : IService<City, long>
    {
        private readonly ICityRepository Repository;

        public CityService(ICityRepository repository)
        {
            Repository = repository;
        }

        public City Create(City city) => Repository.Create(city);
        public void Delete(City city) => Repository.Delete(city);

        public void DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public City Get(long id) => Repository.GetByID(id);
        public IEnumerable<City> GetAll() => Repository.GetAll();
        public void Update(City city) => Repository.Update(city); 
    }
}
