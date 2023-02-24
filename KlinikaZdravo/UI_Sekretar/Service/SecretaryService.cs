using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Service.UserService;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Service
{
    public class SecretaryService : IService<Secretary, long>
    {
        private readonly ISecretaryAccountRepository Repository;
        public SecretaryService(ISecretaryAccountRepository repository)
        { 
            Repository = repository;
        }

        public Secretary Create(Secretary entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Secretary entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public Secretary Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Secretary> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Secretary entity)
        {
            throw new NotImplementedException();
        }
    }
}
