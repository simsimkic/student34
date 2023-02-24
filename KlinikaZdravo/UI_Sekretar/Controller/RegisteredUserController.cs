// File:    RegisteredUserController.cs
// Created: Tuesday, June 23, 2020 5:50:39 PM
// Purpose: Definition of Class RegisteredUserController

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Users;
using ClassDiagram.Service.UserService;

namespace ClassDiagram.Controller
{
   public class RegisteredUserController : IController<RegisteredUser, long>
   {
        private static RegisteredUserController Instance;
        private readonly IService<RegisteredUser, long> Service;

        public RegisteredUserController(IService<RegisteredUser, long> service)
        {
            Service = service;
        }


        public static RegisteredUserController GetInstance(IService<RegisteredUser, long> service)
        {
            if (Instance == null)
            {
                Instance = new RegisteredUserController(service);
            }
            return Instance;
        }

        public Boolean LogIn(String username, String password)
      {
         throw new NotImplementedException();
      }
      
      public Boolean LogOut()
      {
         throw new NotImplementedException();
      }
      
      public void ChangeLanguage()
      {
         throw new NotImplementedException();
      }
      
      public List<Notifications> ShowNotification()
      {
         throw new NotImplementedException();
      }

        public IEnumerable<RegisteredUser> GetAll() => Service.GetAll();

        public RegisteredUser GetByID(long id) => Service.Get(id);
        public RegisteredUser Create(RegisteredUser registeredUser) => Service.Create(registeredUser);
        public void Update(RegisteredUser registeredUser) => Service.Update(registeredUser);
        public void Delete(RegisteredUser registeredUser) => Service.Delete(registeredUser);
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