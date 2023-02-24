using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Service.UserService;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Service
{
    public class ManagerService : IService<Manager, long>
    {
        private readonly IManagerAccountRepository Repository;

        public ManagerService(IManagerAccountRepository repository)
        {
            Repository = repository;
        }

        public Manager Create(Manager entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Manager entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public Manager Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Manager> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Manager entity)
        {
            throw new NotImplementedException();
        }
    }
}
