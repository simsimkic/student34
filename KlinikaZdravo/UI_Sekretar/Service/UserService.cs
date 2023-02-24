using ClassDiagram.Model.Users;
using ClassDiagram.Service.UserService;
using KlinikaZdravo.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Service
{
    public class UserService : IService<User, long>
    {
        private readonly IUserRepository Repository;
        public UserService(IUserRepository repository)
        {
            Repository = repository;
        }
        public User Create(User user) => Repository.Create(user);
        public void Delete(User user) => Repository.Delete(user);

        public void DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public User Get(long id) => Repository.GetByID(id);
        public IEnumerable<User> GetAll() => Repository.GetAll();
        public void Update(User user) => Repository.Update(user);

    }
}
