using ClassDiagram.Model.Users;
using ClassDiagram.Service.UserService;
using KlinikaZdravo.Repository;
using KlinikaZdravo.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Service
{
    class AddressService : IService<Adress, long>
    {
        private readonly IAddressRepository Repository;

        public AddressService(IAddressRepository repository)
        {
            Repository = repository;
        }

        public Adress Create(Adress adress) => Repository.Create(adress);
        public void Delete(Adress adress) => Repository.Delete(adress);

        public void DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public Adress Get(long id) => Repository.GetByID(id);
        public IEnumerable<Adress> GetAll() => Repository.GetAll();
        public void Update(Adress adress) => Repository.Update(adress); 
    }
}
