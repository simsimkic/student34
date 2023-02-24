using ClassDiagram.Model.Users;
using ClassDiagram.Service.UserService;
using KlinikaZdravo.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Service
{
    public class CountryService : IService<Country, long>
    {
        private readonly ICountryRepository Repository;

        public CountryService(ICountryRepository repository)
        {
            Repository = repository;
        }
        public Country Create(Country country) => Repository.Create(country);
        public void Delete(Country country) => Repository.Delete(country);

        public void DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public Country Get(long id) => Repository.GetByID(id);
        public IEnumerable<Country> GetAll() => Repository.GetAll();
        public void Update(Country country) => Repository.Update(country); 
    }
}
