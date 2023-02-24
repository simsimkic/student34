using ClassDiagram.Controller;
using ClassDiagram.Model.Users;
using ClassDiagram.Service.UserService;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Controller
{
    public class UserController : IController<User, long>
    {
        private static UserController Instance;
        private readonly IService<User, long> Service;
        public UserController(IService<User, long> service)
        {
            Service = service;
        }

        public static UserController GetInstance(IService<User, long> service)
        {
            if (Instance == null)
            {
                Instance = new UserController(service);
            }
            return Instance;
        }


        public User Create(User user) => Service.Create(user);
        public void Delete(User user) => Service.Delete(user);
        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll() => Service.GetAll();
        public User GetByID(long id) => Service.Get(id);
        public void Update(User user) => Service.Update(user);

        public void DeleteById(long v)
        {
            throw new NotImplementedException();
        }
    }
}
